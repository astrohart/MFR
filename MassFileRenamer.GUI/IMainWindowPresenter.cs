using System;

namespace MassFileRenamer.GUI
{
    /// <summary>
    /// Defines the public-exposed methods and properties of the presenter
    /// object for the main application window..
    /// </summary>
    public interface IMainWindowPresenter
    {
        /// <summary>
        /// Gets or sets a reference to an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.GUI.IConfiguration" />
        /// interface that
        /// contains the configuration details.
        /// </summary>
        IConfiguration Configuration
        {
            get;
        }

        /// <summary>
        /// Occurs when the configuration has been updated, say, by an import process.
        /// </summary>
        event EventHandler ConfigurationImported;

        /// <summary>
        /// Occurs when the processing is done.
        /// </summary>
        event EventHandler Finished;

        /// <summary>
        /// Occurs when the processing has started.
        /// </summary>
        event EventHandler Started;

        /// <summary>
        /// Dismisses the progress dialog.
        /// </summary>
        void CloseProgressDialog();

        /// <summary>
        /// Imports configuration from a JSON file located on the disk.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the path to the file.
        /// </param>
        /// <remarks>
        /// This method does nothing if the <paramref name="pathname" />
        /// parameter is blank or the file does not exist.
        /// </remarks>
        void ImportConfiguration(string pathname);

        /// <summary>
        /// Begins the rename operation.
        /// </summary>
        void Process();

        /// <summary>
        /// Saves the configuration to disk.
        /// </summary>
        void SaveConfiguration();

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        void ShowProgressDialog();
    }
}