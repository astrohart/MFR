using MassFileRenamer.Objects;
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
        /// Occurs when the configuration has been exported to a file.
        /// </summary>
        event ConfigurationExportedEventHandler ConfigurationExported;

        /// <summary>
        /// Occurs when the configuration has been imported successfully from a
        /// file on the disk.
        /// </summary>
        event ConfigurationImportedEventHandler ConfigurationImported;

        /// <summary>
        /// Occurs when the processing is done.
        /// </summary>
        event EventHandler Finished;

        /// <summary>
        /// Occurs when an exception is thrown during a file operation.
        /// </summary>
        event ExceptionRaisedEventHandler OperationError;

        /// <summary>
        /// Occurs when the processing has started.
        /// </summary>
        event EventHandler Started;

        /// <summary>
        /// Dismisses the progress dialog.
        /// </summary>
        void CloseProgressDialog();

        /// <summary>
        /// Exports the configuration to a file on the disk.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the pathname of the file to be written.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="pathname" />, is
        /// passed a blank or <c>null</c> value.
        /// </exception>
        void ExportConfiguration(string pathname);

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
        /// Sets the state of the Operations to Perform checked list box items
        /// based on configuration settings.
        /// </summary>
        void InitializeOperationSelections();

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

        /// <summary>
        /// Updates data. Moves data from the screen to the model (
        /// <paramref
        ///     name="bSavingAndValidating" />
        /// equals <c>true</c>) or from the model
        /// to the screen ( <paramref name="bSavingAndValidating" /> equals <c>false</c>).
        /// </summary>
        /// <param name="bSavingAndValidating">
        /// Set to <c>true</c> to move data from the screen to the model;
        /// <c>false</c> to move data from the model to the screen.
        /// </param>
        /// <remarks>
        /// Note that whatever operations this method performs may potentially
        /// throw exceptions.
        /// </remarks>
        void UpdateData(bool bSavingAndValidating = true);
    }
}