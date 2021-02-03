using MassFileRenamer.Objects;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions;

namespace MassFileRenamer.GUI
{
   /// <summary>
   /// Displays the main window of the application.
   /// </summary>
   public partial class MainWindow : Form, IMainWindow
   {
      /// <summary>
      /// Reference to the presenter for this form.
      /// </summary>
      private IMainWindowPresenter _presenter;

      /// <summary>
      /// Constructs a new instance of
      /// <see
      ///    cref="T:MassFileRenamer.GUI.MainWindow" />
      /// and returns a reference to it.
      /// </summary>
      /// <param name="configurationPathname">
      /// (Required.) String containing the pathname of the configuration file.
      /// </param>
      /// <exception cref="T:System.ArgumentException">
      /// Thrown if the <paramref name="configurationPathname" /> parameter is blank.
      /// </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">
      /// Thrown if a file with pathname specified by the
      /// <paramref
      ///    name="configurationPathname" />
      /// parameter cannot be found.
      /// </exception>
      public MainWindow(string configurationPathname)
      {
         // write the name of the current class and method we are now entering,
         // into the log
         if (string.IsNullOrWhiteSpace(configurationPathname))
            throw new ArgumentException(
               "Value cannot be null or whitespace.",
               nameof(configurationPathname)
            );
         if (!File.Exists(configurationPathname))
            throw new FileNotFoundException(
               $"Could not locate the configuration file at '{configurationPathname}'."
            );

         InitializeComponent();

         InitializePresenter(configurationPathname);
      }

      /// <summary>
      /// Gets a reference to the text box control that allows the user to
      /// specify the text to be found.
      /// </summary>
      public TextBox FindWhatTextBox
      {
         [DebuggerStepThrough] get => findWhatTextBox;
      }

      /// <summary>
      /// Gets a reference to the text box control that allows the user to
      /// specify the text to replace found text with.
      /// </summary>
      public TextBox ReplaceWithTextBox
      {
         [DebuggerStepThrough] get => replaceWithTextBox;
      }

      /// <summary>
      /// Gets a reference to the control that allows the user to specify the
      /// path to the starting folder.
      /// </summary>
      public TextBox StartingFolderTextBox
      {
         [DebuggerStepThrough] get => startingFolderTextBox;
      }

      /// <summary>
      /// Gets a string containing this application's version.
      /// </summary>
      /// <remarks>
      /// Thanks to
      /// <a
      ///    href="
      /// https://social.msdn.microsoft.com/Forums/vstudio/en-US/d9a69018-4840-4aeb-b9f1-4d98ab35f782/applicationproductversion?forum=csharpgeneral
      /// ">
      /// Kiran
      /// Suthar
      /// </a>
      /// 's answer on the Microsoft forums.
      /// </remarks>
      public string Version { get; } = Assembly.GetExecutingAssembly().GetName()
         .Version.ToString();

      /// <summary>
      /// Raises the <see cref="E:System.Windows.Forms.Form.FormClosing" /> event.
      /// </summary>
      /// <param name="e">
      /// A <see cref="T:System.Windows.Forms.FormClosingEventArgs" /> that
      /// contains the event data.
      /// </param>
      protected override void OnFormClosing(FormClosingEventArgs e)
      {
         base.OnFormClosing(e);

         if (DialogResult == DialogResult.Cancel) return;

         UpdateData();

         _presenter.SaveConfiguration();
      }

      /// <summary>
      /// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
      /// </summary>
      /// <param name="e">
      /// A <see cref="T:System.EventArgs" /> that contains the event data.
      /// </param>
      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);

         Text = $"{Application.ProductName} {Version}";

         UpdateData(false);
      }

      /// <summary>
      /// Sets up the presenter object and attaches handlers to events that it exposes.
      /// </summary>
      /// <param name="configurationPathname">
      /// (Required.) String containing the pathname of the configuration file.
      /// </param>
      /// <exception cref="T:System.ArgumentException">
      /// Thrown if the <paramref name="configurationPathname" /> parameter is blank.
      /// </exception>
      /// <exception cref="T:System.IO.FileNotFoundException">
      /// Thrown if a file with pathname specified by the
      /// <paramref
      ///    name="configurationPathname" />
      /// parameter cannot be found.
      /// </exception>
      private void InitializePresenter(string configurationPathname)
      {
         if (string.IsNullOrWhiteSpace(configurationPathname))
            throw new ArgumentException(
               "Value cannot be null or whitespace.",
               nameof(configurationPathname)
            );
         if (!File.Exists(configurationPathname))
            throw new FileNotFoundException(
               $"Could not locate the configuration file at '{configurationPathname}'."
            );

         _presenter = new MainWindowPresenter(
            this, new FileRenamer(), configurationPathname
         );
         _presenter.Started += OnPresenterStarted;
         _presenter.Finished += OnPresenterFinished;
      }

      /// <summary>
      /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event
      /// for the Browse ("...") button.
      /// </summary>
      /// <param name="sender">
      /// Reference to an instance of the object that raised the event.
      /// </param>
      /// <param name="e">
      /// A <see cref="T:System.EventArgs" /> that contains the event data.
      /// </param>
      /// <remarks>
      /// <para>
      /// When the user clicks the "..." button, we want to show them a dialog
      /// box to select a folder.
      /// </para>
      /// <para>
      /// The contents of the Starting Folder text box will then be initialized
      /// to hold the pathname to the folder that the user selects.
      /// </para>
      /// </remarks>
      private void OnClickBrowse(object sender, EventArgs e)
      {
         using (var fsd = new FolderSelectDialog())
         {
            fsd.InitialDirectory = StartingFolderTextBox.Text;
            fsd.Title = "Browse";
            if (!fsd.ShowDialog(Handle))
               return;
            StartingFolderTextBox.Text = fsd.FileName;
         }
      }

      /// <summary>
      /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event
      /// for the Perform Operation button.
      /// </summary>
      /// <param name="sender">
      /// The sender of this event.
      /// </param>
      /// <param name="e">
      /// A <see cref="T:System.EventArgs" /> that contains the event data.
      /// </param>
      /// <remarks>
      /// This handler starts the processing of renaming folders and files when
      /// the Perform Operation button is clicked.
      /// </remarks>
      private void OnClickPerformOperation(object sender, EventArgs e)
      {
         UseWaitCursor = true;

         UpdateData();

         _presenter.SaveConfiguration();

         Enabled = false;

         try
         {
            _presenter.Process();
         }
         catch (Exception ex)
         {
            UseWaitCursor = false;

            MessageBox.Show(
               this, ex.Message, Application.ProductName, MessageBoxButtons.OK,
               MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1
            );
         }
         finally
         {
            Enabled = true;

            UseWaitCursor = false;
         }
      }

      /// <summary>
      /// Handles the
      /// <see
      ///    cref="E:MassFileRenamer.Objects.FoldUnfoldButton.FormFolded" />
      /// event.
      /// </summary>
      /// <param name="sender">
      /// Reference to an instance of the object that raised the event.
      /// </param>
      /// <param name="e">
      /// A <see cref="T:MassFileRenamer.Objects.FormFoldedEventArgs" /> that
      /// contains the event data.
      /// </param>
      /// <remarks>
      /// </remarks>
      private void OnFormFolded(object sender, FormFoldedEventArgs e)
      {
         Size = e.Size;

         foldButton.Text = foldButton.IsFolded ? "&More >>" : "&Less <<";
         Application.DoEvents();
         Update();
         Refresh(); // repaint

         CenterToScreen();
      }

      /// <summary>
      /// Handles the
      /// <see
      ///    cref="E:MassFileRenamer.GUI.IMainWindowPresenter.Finished" />
      /// event.
      /// </summary>
      /// <param name="sender">
      /// Reference to an instance of the object that raised the event.
      /// </param>
      /// <param name="e">
      /// A <see cref="T:System.EventArgs" /> that contains the event data.
      /// </param>
      /// <remarks>
      /// This method toggles UI state and dismisses the progress dialog.
      /// </remarks>
      private void OnPresenterFinished(object sender, EventArgs e)
      {
         startingFolderBrowseButton.InvokeIfRequired(
            () =>
            {
               UseWaitCursor = false;
               Enabled = true;

               _presenter.CloseProgressDialog();
            }
         );
      }

      /// <summary>
      /// Handles the
      /// <see
      ///    cref="E:MassFileRenamer.GUI.IMainWindowPresenter.Started" />
      /// event.
      /// </summary>
      /// <param name="sender">
      /// The sender of the event.
      /// </param>
      /// <param name="e">
      /// A <see cref="T:System.EventArgs" /> containing the event data.
      /// </param>
      /// <remarks>
      /// This handler is called when the
      /// <see
      ///    cref="M:MassFileRenamer.Objects.FileRenamer.ProcessAll" />
      /// begins its execution.
      /// </remarks>
      private void OnPresenterStarted(object sender, EventArgs e)
      {
         startingFolderBrowseButton.InvokeIfRequired(
            () =>
            {
               Enabled = false;
               UseWaitCursor = true;

               _presenter.ShowProgressDialog();
            }
         );
      }

      private void UpdateData(bool bSavingAndValidating = true)
      {
         if (bSavingAndValidating)
         {
            _presenter.Configuration.StartingFolder =
               StartingFolderTextBox.Text;
            _presenter.Configuration.FindWhat = FindWhatTextBox.Text;
            _presenter.Configuration.ReplaceWith = ReplaceWithTextBox.Text;
         }
         else
         {
            StartingFolderTextBox.Text =
               _presenter.Configuration.StartingFolder;
            FindWhatTextBox.Text = _presenter.Configuration.FindWhat;
            ReplaceWithTextBox.Text = _presenter.Configuration.ReplaceWith;
         }
      }
   }
}