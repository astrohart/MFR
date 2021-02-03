namespace MassFileRenamer.GUI
{
   /// <summary>
   /// Defines the public-exposed methods and properties of the presenter object
   /// for the main application window..
   /// </summary>
   public interface IMainWindowPresenter
   {
      /// <summary>
      /// Gets or sets a reference to an object that implements the
      /// <see
      ///    cref="T:MassFileRenamer.GUI.IConfiguration" />
      /// interface that contains
      /// the configuration details.
      /// </summary>
      IConfiguration Configuration { get; }

      /// <summary>
      /// Begins the rename operation.
      /// </summary>
      void Process();

      /// <summary>
      /// Saves the configuration to disk.
      /// </summary>
      void SaveConfiguration();
   }
}