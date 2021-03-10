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
        /// Occurs when all the history has been cleared.
        /// </summary>
        event EventHandler AllHistoryCleared;

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
        /// Occurs when an error happens during a data operation.
        /// </summary>
        event DataOperationErrorEventHandler DataOperationError;

        /// <summary>
        /// Occurs when data is finished being moved to and fro between the
        /// screen and the configuration data source.
        /// </summary>
        event EventHandler DataOperationFinished;

        /// <summary>
        /// Occurs when a data operation is about to start.
        /// </summary>
        event DataOperationEventHandler DataOperationStarted;

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
        /// Fluent-builder method for initializing the history manager
        /// dependency of this Presenter class. History Manager objects control
        /// the flow of values into and out of the list of previously-specified
        /// values in prior searches.
        /// </summary>
        /// <param name="historyManager">
        /// Reference to an instance of an object that implements the <see
        /// cref="T:MassFileRenamer.Objects.IHistoryManager"/> on which this
        /// Presenter should depend.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        IMainWindowPresenter AndHistoryManager(
            IHistoryManager historyManager);

        /// <summary>
        /// Clears all the history lists in the configuration.
        /// </summary>
        void ClearAllHistory();

        /// <summary>
        /// Dismisses the progress dialog.
        /// </summary>
        void CloseProgressDialog();

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
        /// Shows the progress window.
        /// </summary>
        void ShowProgressDialog();

        /// <summary>
        /// Updates data. Moves data from the screen to the model ( <paramref
        /// name="bSavingAndValidating"/> equals <c>true</c>) or from the model
        /// to the screen ( <paramref name="bSavingAndValidating"/> equals <c>false</c>).
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

        /// <summary>
        /// Fluent-builder method to set a reference to the main window of the application.
        /// </summary>
        /// <param name="mainWindow">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.GUI.IMainWindow"/> interface and
        /// which represents the main window of the application.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="mainWindow"/>, is
        /// passed a <c>null</c> value.
        /// </exception>
        IMainWindowPresenter WindowReference(IMainWindow mainWindow);

        /// <summary>
        /// Fluent-builder method for composing a file-renamer object with this presenter.
        /// </summary>
        /// <param name="fileRenamer">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IFileRenamer"/> interface.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="fileRenamer"/>, is
        /// passed a <c>null</c> value.
        /// </exception>
        IMainWindowPresenter WithFileRenamer(IFileRenamer fileRenamer);
    }
}