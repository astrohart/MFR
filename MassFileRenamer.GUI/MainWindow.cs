using MassFileRenamer.Objects;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

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
      /// An <see cref="T:System.EventArgs" /> that contains the event data.
      /// </param>
      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);

         Text = $"{Application.ProductName} {Version}";

         UpdateData(false);
      }

      private void InitializePresenter(string configurationPathname)
      {
         _presenter = new MainWindowPresenter(
            this, new FileRenamer(), configurationPathname
         );
      }

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
      /// for the Cancel button.
      /// </summary>
      /// <param name="sender">
      /// The sender of this event.
      /// </param>
      /// <param name="e">
      /// A <see cref="T:System.EventArgs" /> that contains the event data.
      /// </param>
      /// <remarks>
      /// This handler closes the application window (and thereby exits the application
      /// itself) when the user clicks the Cancel button on the main window.
      /// </remarks>
      private void OnClickCancel(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Cancel;

         Close();
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