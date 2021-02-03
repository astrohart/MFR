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
      private IMainWindow _mainWindow;

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
      /// Thrown if the required <paramref name="mainWindow" /> parameter has a
      /// <c>null</c> value.
      /// </exception>
      public MainWindowPresenter(IMainWindow mainWindow)
      {
         _mainWindow = mainWindow ??
                       throw new ArgumentNullException(nameof(mainWindow));
      }
   }
}