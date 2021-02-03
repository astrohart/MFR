using MassFileRenamer.Objects;
using System;

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
      }

      /// <summary>
      /// Begins the rename operation.
      /// </summary>
      public void Process()
      {
         if (_mainWindow == null || _renamer == null)
            return;

         _renamer.ProcessAll(
            _mainWindow.StartingFolderTextBox.Text,
            _mainWindow.FindWhatTextBox.Text,
            _mainWindow.ReplaceWithTextBox.Text
         );
      }
   }
}