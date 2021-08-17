using MFR.GUI.Dialogs.Interfaces;
using MFR.GUI.Presenters.Interfaces;
using MFR.GUI.Windows.Interfaces;
using MFR.Objects.Configuration.Events;
using MFR.Objects.Events.Common;
using MFR.Objects.Managers.History.Interfaces;
using MFR.Objects.Operations.Events;
using MFR.Objects.Renamers.Files.Interfaces;
using MFR.Profiles.Collections.Interfaces;
using System;

namespace MFR.GUI.Windows.Presenters.Interfaces
{
    /// <summary>
    ///     Defines the public-exposed methods and properties of the presenter
    ///     object for the main application window..
    /// </summary>
    public interface
        IMainWindowPresenter : IPresenter<IMainWindow, IMainWindowPresenter>
    {
        /// <summary>
        ///     Creates a 'profile' (really a way of saving a group of configuration
        ///     settings) and then adds it to the collection of profiles that the user has.
        /// </summary>
        /// <param name="name">
        ///     (Required.) A descriptive name for the profile.
        ///     <para />
        ///     The name of the profile can't be reused.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the <paramref name="name" /> parameter has a
        ///     <see langref="null" /> reference, or is the blank or whitespace string.
        ///     <para />
        ///     The <paramref name="name" /> parameter is required.
        /// </exception>
        void AddProfile(string name);

        /// <summary>
        ///     Occurs when all the history has been cleared.
        /// </summary>
        event EventHandler AllHistoryCleared;

        /// <summary>
        ///     Occurs when the configuration has been exported to a file.
        /// </summary>
        event ConfigurationExportedEventHandler ConfigurationExported;

        /// <summary>
        ///     Occurs when the configuration has been imported successfully from a
        ///     file on the disk.
        /// </summary>
        event ConfigurationImportedEventHandler ConfigurationImported;

        /// <summary>
        ///     Occurs when an error happens during a data operation.
        /// </summary>
        event DataOperationErrorEventHandler DataOperationError;

        /// <summary>
        ///     Occurs when data is finished being moved to and fro between the
        ///     screen and the configuration data source.
        /// </summary>
        event EventHandler DataOperationFinished;

        /// <summary>
        ///     Occurs when a data operation is about to start.
        /// </summary>
        event DataOperationEventHandler DataOperationStarted;

        /// <summary>
        ///     Occurs when the processing is done.
        /// </summary>
        event EventHandler Finished;

        /// <summary>
        ///     Occurs when an exception is thrown during a file operation.
        /// </summary>
        event ExceptionRaisedEventHandler OperationError;

        /// <summary>
        ///     Occurs when the processing has started.
        /// </summary>
        event EventHandler Started;

        /// <summary>
        ///     Fluent-builder method for initializing the history manager
        ///     dependency of this Presenter class. History Manager objects control
        ///     the flow of values into and out of the list of previously-specified
        ///     values in prior searches.
        /// </summary>
        /// <param name="historyManager">
        ///     Reference to an instance of an object that implements the
        ///     <see
        ///         cref="T:MFR.Objects.IHistoryManager" />
        ///     on which this Presenter
        ///     should depend.
        /// </param>
        /// <returns>
        ///     Reference to the same instance of the object that called this
        ///     method, for fluent use.
        /// </returns>
        IMainWindowPresenter AndHistoryManager(IHistoryManager historyManager);

        /// <summary>
        ///     Clears all the history lists in the configuration.
        /// </summary>
        void ClearAllHistory();

        /// <summary>
        ///     Exports the current configuration data to a file on the user's hard drive.
        /// </summary>
        void ExportConfiguration();

        /// <summary>
        ///     Loads the list of profiles that the user has created, for example,
        ///     to load into a combobox.
        /// </summary>
        /// <returns>
        ///     Reference to an instance of an object that implements the
        ///     <see
        ///         cref="T:MFR.Profiles.Collections.Interfaces.IProfileCollection" />
        ///     interface.
        /// </returns>
        IProfileCollection GetProfiles();

        /// <summary>
        ///     Imports the configuration data for this application.
        /// </summary>
        /// <remarks>
        ///     The data is presumed to be located inside of a JSON-formatted file
        ///     that exists on the user's hard drive and has the <c>.json</c> extension.
        /// </remarks>
        void ImportConfiguration();

        /// <summary>
        ///     Sets the state of the Operations to Perform checked list box items
        ///     based on configuration settings.
        /// </summary>
        void InitializeOperationSelections();

        /// <summary>
        ///     Begins the rename operation.
        /// </summary>
        void Process();

        /// <summary>
        ///     Runs code that should execute when either the OK or Apply buttons
        ///     are clicked on the Tools -&gt; Options dialog box.
        /// </summary>
        /// <param name="dialog">
        ///     (Required.) Reference to an instance of an object that implements
        ///     the <see cref="T:MFR.GUI.Dialogs.Interfaces.IOptionsDialog" /> interface.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        ///     Thrown if the required parameter, <paramref name="dialog" />, is
        ///     passed a <see langword="null" /> value.
        /// </exception>
        void SaveConfigurationDataFrom(IOptionsDialog dialog);

        /// <summary>
        ///     Fluent-builder method for composing a file-renamer object with this
        ///     presenter.
        /// </summary>
        /// <param name="fileRenamer">
        ///     (Required.) Reference to an instance of an object that implements
        ///     the <see cref="T:MFR.Objects.IFileRenamer" /> interface.
        /// </param>
        /// <returns>
        ///     Reference to the same instance of the object that called this
        ///     method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///     Thrown if the required parameter, <paramref name="fileRenamer" />, is
        ///     passed a <see langword="null" /> value.
        /// </exception>
        IMainWindowPresenter WithFileRenamer(IFileRenamer fileRenamer);
    }
}