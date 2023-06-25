using MFR.Engines.Operations.Interfaces;
using MFR.Events.Common;
using MFR.GUI.Dialogs.Interfaces;
using MFR.GUI.Presenters.Interfaces;
using MFR.GUI.Windows.Interfaces;
using MFR.GUI.Windows.Presenters.Events;
using MFR.Managers.History.Interfaces;
using MFR.Operations.Events;
using MFR.Settings.Configuration.Events;
using System;

namespace MFR.GUI.Windows.Presenters.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of the presenter
    /// object for the main application window..
    /// </summary>
    public interface
        IMainWindowPresenter : IPresenter<IMainWindow, IMainWindowPresenter>
    {
        /// <summary>
        /// Gets a value that indicates whether a Profile is currently loaded.
        /// </summary>
        bool IsProfileLoaded
        {
            get;
        }

        /// <summary>
        /// Occurs when an Add Profile operation has failed.
        /// </summary>
        event AddProfileFailedEventHandler AddProfileFailed;

        /// <summary>
        /// Occurs when all the history has been cleared.
        /// </summary>
        event EventHandler AllHistoryCleared;

        /// <summary>
        /// Occurs when the configuration has been exported to a file.
        /// </summary>
        event ConfigurationExportedEventHandler ConfigurationExported;

        /// <summary>
        /// Occurs when the configuration has been imported successfully
        /// from a
        /// file on the disk.
        /// </summary>
        event ConfigurationImportedEventHandler ConfigurationImported;

        /// <summary>
        /// Occurs when the user issues a request to create a new, blank Profile.
        /// </summary>
        event CreateNewBlankProfileRequestedEventHandler
            CreateNewBlankProfileRequested;

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
        /// Creates a 'profile' (really a way of saving a group of
        /// configuration
        /// settings) and then adds it to the collection of profiles that the user has.
        /// </summary>
        /// <param name="name">
        /// (Required.) A descriptive name for the profile.
        /// <para />
        /// The name of the profile can't be reused.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the <paramref name="name" /> parameter has a
        /// <see langref="null" /> reference, or is the blank or whitespace string.
        /// <para />
        /// The <paramref name="name" /> parameter is required.
        /// </exception>
        void AddProfile(string name);

        /// <summary>
        /// Fluent-builder method for initializing the history manager
        /// dependency of this Presenter class. History Manager objects control
        /// the flow of values into and out of the list of previously-specified
        /// values in prior searches.
        /// </summary>
        /// <param name="historyManager">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IHistoryManager" />
        /// on which this Presenter
        /// should depend.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        IMainWindowPresenter AndHistoryManager(IHistoryManager historyManager);

        /// <summary>
        /// Clears all the history lists in the configuration.
        /// </summary>
        void ClearAllHistory();

        /// <summary>
        /// Executes the operations selected by the user.
        /// </summary>
        void DoSelectedOperations();

        /// <summary>
        /// Exports the current configuration data to the file on the
        /// user's hard drive having the specified <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file to which the configuration should be exported.
        /// </param>
        /// <remarks>
        /// If a file having the specified <paramref name="pathname" /> already
        /// exists on the disk at the time the export operation is performed, it will be
        /// overwritten.
        /// </remarks>
        void ExportConfiguration(string pathname);

        /// <summary>
        /// Determines whether the file having the specified <paramref name="pathname" />
        /// exists.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the file to be searched for.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="pathname" /> is
        /// non-blank and contains the fully-qualified pathname of a file that exists;
        /// <see langword="false" /> otherwise.
        /// </returns>
        bool FileExist(string pathname);

        /// <summary>
        /// This method is called to populate the Profiles combo box.
        /// </summary>
        void FillProfileDropDownList();

        /// <summary>
        /// Imports the configuration data for this application from the file with the
        /// specified <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file from which the configuration should be imported.
        /// </param>
        /// <remarks>
        /// The data is presumed to be located inside of a JSON-formatted file
        /// that exists on the user's hard drive and has the <c>.json</c> extension.
        /// </remarks>
        void ImportConfiguration(
            string pathname /* path of the file to be imported */
        );

        /// <summary>
        /// Sets the state of the Operations to Perform checked list box items
        /// based on configuration settings.
        /// </summary>
        void InitializeOperationSelections();

        /// <summary>
        /// Determines whether a Profile having the specified
        /// <paramref name="profileName" /> is already defined.
        /// <para />
        /// The match that is done is case-insensitive.
        /// </summary>
        /// <param name="profileName">
        /// (Required.) String containing the name of the Profile
        /// to search for.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if a Profile having the specified
        /// <paramref name="profileName" /> is defined; <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="profileName" />, is passed a blank or <see langword="null" />
        /// string for a value.
        /// </exception>
        bool ProfileAlreadyExist(string profileName);

        /// <summary>
        /// If the user has changed the pathname of where the configuration file is to be
        /// stored, this method renames the existing configuration file to match.
        /// </summary>
        /// <param name="newConfigFilePath">
        /// (Required.) A <see cref="T:System.String" /> that contains the new value of the
        /// fully-qualified pathname of the configuration file.
        /// </param>
        void RenameConfigFileToMatchNewName(string newConfigFilePath);

        /// <summary>
        /// Saves data from the screen control and then saves the
        /// configuration to the persistence location.
        /// </summary>
        void SaveConfiguration();

        /// <summary>
        /// Runs code that should execute when either the OK or Apply buttons
        /// are clicked on the Tools -&gt; Options dialog box.
        /// </summary>
        /// <param name="dialogBox">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.Dialogs.Interfaces.IOptionsDialogBox" /> interface.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="dialogBox" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        void SaveConfigurationDataFrom(IOptionsDialogBox dialogBox);

        /// <summary>
        /// Transforms the current value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.ProjectFileRenamerConfiguration" />
        /// property into a Profile with the <paramref name="profileName" /> specified.
        /// <para />
        /// If a Profile with the same name is already defined, then this method does
        /// nothing.
        /// </summary>
        /// <param name="profileName">
        /// (Required.) String containing the name to give the
        /// new Profile.
        /// </param>
        void SaveCurrentConfigurationAsProfile(string profileName);

        /// <summary>
        /// Fluent-builder method for initializing the operation engine object.  This is
        /// the object that actually schedules and runs the file-renaming tasks and
        /// provides user feedback.
        /// </summary>
        /// <param name="operationEngine">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Engines.Interfaces.IFullGuiOperationEngine" /> interface on
        /// which this Presenter should depend.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        IMainWindowPresenter WithOperationEngine(
            IFullGuiOperationEngine operationEngine
        );
    }
}