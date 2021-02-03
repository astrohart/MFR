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
      /// <exception cref="T:System.ArgumentNullException">
      /// Thrown if either of the required <paramref name="mainWindow" /> or
      /// <paramref name="renamer" /> parameters have a <c>null</c> value.
      /// </exception>
      public MainWindowPresenter(IMainWindow mainWindow, IFileRenamer renamer)
      {
         _mainWindow = mainWindow ??
                       throw new ArgumentNullException(nameof(mainWindow));
         _renamer = renamer ?? throw new ArgumentNullException(nameof(renamer));

         InitializeFileRenamer();

         ReinitializeProrgessDialog();
      }

      private string FindWhat
         => _mainWindow.FindWhatTextBox.Text;

      private string ReplaceWith
         => _mainWindow.ReplaceWithTextBox.Text;

      private string StartingFolderPath
         => _mainWindow.StartingFolderTextBox.Text;

      /// <summary>
      /// Begins the rename operation.
      /// </summary>
      public void Process()
      {
         if (_mainWindow == null || _renamer == null)
            return;

         ValidateInputs();

         ShowProgressDialog();

         CommenceRenameOperation();

         ReinitializeProrgessDialog();
      }

      private void CommenceRenameOperation()
         => Task.Run(
            () => _renamer.ProcessAll(StartingFolderPath, FindWhat, ReplaceWith)
         ).Wait();

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
         if (count <= 0)
            throw new ArgumentOutOfRangeException(nameof(count));

         ResetProgressBar();
         ((Form) _progressDialog).DoIfNotDisposed(
            () => _progressDialog.ProgressBarMaximum = count
         );
      }

      private void IncrementProgressBar(string pathname)
      {
         ((Form) _progressDialog).DoIfNotDisposed(
            () => _progressDialog.DetailedStatus = pathname
         );
         ((Form) _progressDialog).DoIfNotDisposed(
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
            => ((Form) _progressDialog).DoIfNotDisposed(
               () => _progressDialog.Status = eventArgs.Text
            );
         _renamer.ProcessingOperation += (sender, eventArgs)
            => IncrementProgressBar(eventArgs.Pathname);
      }

      /// <summary>
      /// Sets the progress dialog and/or reinitializes it from prior use.
      /// </summary>
      private void ReinitializeProrgessDialog()
      {
         ((Form) _progressDialog).DoIfNotDisposed(
            () => _progressDialog.Close()
         );
         ((Form) _progressDialog).DoIfDisposed(
            () => _progressDialog = new ProgressDialog()
         );
      }

      private void ResetProgressBar()
      {
         ((Form) _progressDialog).DoIfNotDisposed(
            () => _progressDialog.Reset()
         );
      }

      private void ShowCalculatingProgressBar(OperationType type)
      {
         ResetProgressBar();

         ((Form) _progressDialog).DoIfNotDisposed(
            () => _progressDialog.ProgressBarStyle = ProgressBarStyle.Marquee
         );
         ((Form) _progressDialog).DoIfNotDisposed(
            () => _progressDialog.Status = GetOperationStartedText(type)
         );
      }

      private void ShowProgressDialog()
         => ((Form) _progressDialog).DoIfNotDisposed(
            () => _progressDialog.ShowDialog(_mainWindow)
         );

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