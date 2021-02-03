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
   }
}