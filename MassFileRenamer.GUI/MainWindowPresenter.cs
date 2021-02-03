using MassFileRenamer.GUI.Properties;
using MassFileRenamer.Objects;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions;

namespace MassFileRenamer.GUI
{
   /// <summary>
   /// Presenter for the main application window.
   /// </summary>
   public class MainWindowPresenter : IMainWindowPresenter
   {
      /// <summary>
      /// Reference to an instance of an object that implements the
      /// <see
      ///    cref="T:MassFileRenamer.GUI.IMainWindow" />
      /// interface.
      /// </summary>
      /// <remarks>
      /// This object provides the functionality of the main window of the application.
      /// </remarks>
      private readonly IMainWindow _mainWindow;

      private readonly IFileRenamer _renamer;

      /// <summary>
      /// Reference to an instance of an object that implements the
      /// <see
      ///    cref="T:MassFileRenamer.GUI.IProgressDialog" />
      /// interface.
      /// </summary>
      private IProgressDialog _progressDialog;

      /// <summary>
      /// Constructs a new instance of
      /// <see
      ///    cref="T:MassFileRenamer.GUI.MainWindowPresenter" />
      /// and returns a
      /// reference to it.
      /// </summary>
      /// <param name="mainWindow">
      /// (Required.) Reference to an instance of an object that implements the
      /// <see cref="T:MassFileRenamer.GUI.IMainWindow" /> interface.
      /// </param>
      /// <param name="renamer">
      /// (Required.) Reference to an instance of an object that implements the
      /// <see cref="T:MassFileRenamer.Objects.IFileRenamer" /> interface.
      /// </param>
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
      /// <exception cref="T:System.ArgumentNullException">
      /// Thrown if either of the required <paramref name="mainWindow" /> or
      /// <paramref name="renamer" /> parameters have a <c>null</c> value.
      /// </exception>
      public MainWindowPresenter(IMainWindow mainWindow, IFileRenamer renamer,
         string configurationPathname)
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

         _mainWindow = mainWindow ??
                       throw new ArgumentNullException(nameof(mainWindow));
         _renamer = renamer ?? throw new ArgumentNullException(nameof(renamer));

         InitializeFileRenamer();

         ReinitializeProrgessDialog();

         LoadConfiguration(configurationPathname);
      }

      /// <summary>
      /// Gets a string that contains the text to be found.
      /// </summary>
      private string FindWhat
         => _mainWindow.FindWhatTextBox.Text;

      /// <summary>
      /// Gets a string that contains the new text to be used to replace the
      /// text specified by
      /// <see cref="P:MassFileRenamer.GUI.MainWindowPresenter.FindWhat" />.
      /// </summary>
      private string ReplaceWith
         => _mainWindow.ReplaceWithTextBox.Text;

      /// <summary>
      /// String containing the pathname to the configuration file.
      /// </summary>
      private string ConfigurationPathname { get; set; }

      /// <summary>
      /// String containing the pathname of the folder where the operation is to start.
      /// </summary>
      private string StartingFolderPath
         => _mainWindow.StartingFolderTextBox.Text;

      /// <summary>
      /// Gets or sets a reference to an object that implements the
      /// <see
      ///    cref="T:MassFileRenamer.GUI.IConfiguration" />
      /// interface that contains
      /// the configuration details.
      /// </summary>
      public IConfiguration Configuration { get; private set; }

      /// <summary>
      /// Begins the rename operation.
      /// </summary>
      public void Process()
      {
         if (_mainWindow == null || _renamer == null)
            return;

         ReinitializeProrgessDialog();

         ValidateInputs();

         ShowProgressDialog();

         CommenceRenameOperation();


      }

      /// <summary>
      /// Saves the configuration to disk.
      /// </summary>
      public void SaveConfiguration()
      {
         ConfigurationSerializer.Save(ConfigurationPathname, Configuration);
      }

      /// <summary>
      /// Occurs when the processing is done.
      /// </summary>
      public event EventHandler Finished;

      /// <summary>
      /// Raises the
      /// <see
      ///    cref="E:MassFileRenamer.GUI.MainWindowPresenter.Finished" />
      /// event.
      /// </summary>
      protected virtual void OnFinished()
         => Finished?.Invoke(this, EventArgs.Empty);

      private static string GetOperationDescriptionFor(OperationType type)
      {
         var result = string.Empty;

         switch (type)
         {
            case OperationType.RenameFilesInFolder:
               result = "Renaming files...";
               break;

            case OperationType.ReplaceTextInFiles:
               result = "Replacing text in files...";
               break;

            case OperationType.RenameSubFolders:
               result = "Renaming subfolders...";
               break;

            default:
               throw new ArgumentOutOfRangeException(nameof(type), type, null);
         }

         return result;
      }

      private void CloseProgressDialog()
      {
         _progressDialog.DoIfNotDisposed(() => _progressDialog.Close());
      }

      private void CommenceRenameOperation()
         => Task.Run(
            () => _renamer.ProcessAll(StartingFolderPath, FindWhat, ReplaceWith)
         );

      private string GetOperationStartedText(OperationType type)
      {
         var result = string.Empty;

         switch (type)
         {
            case OperationType.RenameFilesInFolder:
               result = "Calculating files to be renamed...";
               break;

            case OperationType.ReplaceTextInFiles:
               result = "Calculating files in which to replace text...";
               break;

            case OperationType.RenameSubFolders:
               result = "Calculating folders to be renamed...";
               break;

            default:
               throw new ArgumentOutOfRangeException(nameof(type), type, null);
         }

         return result;
      }

      private void HandleFilesCountedEvent(int count)
      {
         ResetProgressBar();

         if (count <= 0)
            return;

         _progressDialog.DoIfNotDisposed(
            () => _progressDialog.ProgressBarMaximum = count
         );
      }

      private void IncrementProgressBar(string operationDescription,
         string pathname)
      {
         _progressDialog.DoIfNotDisposed(
            () => _progressDialog.Status = operationDescription
         );
         _progressDialog.DoIfNotDisposed(
            () => _progressDialog.DetailedStatus = pathname
         );
         _progressDialog.DoIfNotDisposed(
            () => _progressDialog.ProgressBarValue++
         );
      }

      /// <summary>
      /// Sets the properties of the FileRenamer object that we are working with
      /// and subscribes to the events that it emits.
      /// </summary>
      private void InitializeFileRenamer()
      {
         if (_renamer == null) return;

         _renamer.OperationFinished += (sender, eventArgs)
            => ResetProgressBar();
         _renamer.OperationStarted += (sender, eventArgs)
            => ShowCalculatingProgressBar(eventArgs.OperationType);
         _renamer.FilesToBeRenamedCounted += (sender, eventArgs)
            => HandleFilesCountedEvent(eventArgs.Count);
         _renamer.FilesToHaveTextReplacedCounted += (sender, eventArgs)
            => HandleFilesCountedEvent(eventArgs.Count);
         _renamer.SubfoldersToBeRenamedCounted += (sender, eventArgs)
            => HandleFilesCountedEvent(eventArgs.Count);
         _renamer.StatusUpdate += (sender, eventArgs)
            => Console.WriteLine(eventArgs.Text);
         _renamer.ProcessingOperation += (sender, eventArgs)
            => IncrementProgressBar(
               GetOperationDescriptionFor(eventArgs.OperationType),
               eventArgs.Pathname
            );
      }

      /// <summary>
      /// Loads the configuration.
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
      private void LoadConfiguration(string configurationPathname)
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

         ConfigurationPathname = configurationPathname;

         Configuration = ConfigurationSerializer.Load(ConfigurationPathname);
      }

      /// <summary>
      /// Sets the progress dialog and/or reinitializes it from prior use.
      /// </summary>
      private void ReinitializeProrgessDialog()
      {
         _progressDialog.DoIfNotDisposed(() => _progressDialog.Close());
         _progressDialog.DoIfDisposed(
            () => _progressDialog = new ProgressDialog()
         );
      }

      private void ResetProgressBar()
      {
         _progressDialog.DoIfNotDisposed(() => _progressDialog.Reset());
      }

      private void ShowCalculatingProgressBar(OperationType type)
      {
         ResetProgressBar();

         _progressDialog.DoIfNotDisposed(
            () => _progressDialog.ProgressBarStyle = ProgressBarStyle.Marquee
         );
         _progressDialog.DoIfNotDisposed(
            () => _progressDialog.Status = GetOperationStartedText(type)
         );
      }

      private void ShowProgressDialog()
         => _progressDialog.DoIfNotDisposed(() => _progressDialog.Show());

      private void ValidateInputs()
      {
         if (!Directory.Exists(StartingFolderPath))
            throw new DirectoryNotFoundException(
               string.Format(
                  Resources.Error_RootDirectoryNotFound, StartingFolderPath
               )
            );
         if (string.IsNullOrWhiteSpace(FindWhat))
            throw new InvalidOperationException(
               Resources.Error_FindWhatRequired
            );
         if (string.IsNullOrWhiteSpace(ReplaceWith))
            throw new InvalidOperationException(
               Resources.Error_ReplaceWithBlank
            );
      }
   }
}