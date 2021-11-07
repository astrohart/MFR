using MFR.Events.Common;
using MFR.GUI.Dialogs.Interfaces;
using MFR.GUI.Presenters.Interfaces;
using MFR.GUI.Windows.Interfaces;
using MFR.GUI.Windows.Presenters.Events;
using MFR.Managers.History.Interfaces;
using MFR.Operations.Events;
using MFR.Renamers.Files.Interfaces;
using MFR.Settings.Configuration.Events;
using System;
using System.Windows.Forms;

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
        /// Occurs when the configuration has been imported successfully from a
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
        /// Gets a value that indicates whether a Profile is currently loaded.
        /// </summary>
        bool IsProfileLoaded
        {
            get;
        }

        /// <summary>
        /// Creates a 'profile' (really a way of saving a group of configuration
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
        /// Exports the current configuration data to a file on the user's hard drive.
        /// </summary>
        void ExportConfiguration();

        /// <summary>
        /// This method is called to populate the Profiles combo box.
        /// </summary>
        void FillProfileDropDownList();

        /// <summary>
        /// Imports the configuration data for this application.
        /// </summary>
        /// <remarks>
        /// The data is presumed to be located inside of a JSON-formatted file
        /// that exists on the user's hard drive and has the <c>.json</c> extension.
        /// </remarks>
        void ImportConfiguration();

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
        /// Saves data from the screen control and then saves the configuration to the persistence location.
        /// </summary>
        void SaveConfiguration();

        /// <summary>
        /// Runs code that should execute when either the OK or Apply buttons
        /// are clicked on the Tools -&gt; Options dialog box.
        /// </summary>
        /// <param name="dialog">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.Dialogs.Interfaces.IOptionsDialog" /> interface.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="dialog" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        void SaveConfigurationDataFrom(IOptionsDialog dialog);

        /// <summary>
        /// Transforms the current value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.Configuration" />
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
        /// Shows the progress window.
        /// </summary>
        /// <param name="canCancel">
        /// (Required.) A <see cref="T:System.Boolean" /> that controls whether the
        /// <strong>Cancel</strong> button is displayed by the dialog box.
        /// <para />
        /// Set this parameter to <see langword="true" /> to display the button;
        /// <see langword="false" /> to hide it.
        /// </param>
        void ShowProgressDialog(bool canCancel);

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object plays the role of the parent window of the dialog box.
        /// </param>
        void ShowProgressDialog(IWin32Window owner);

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object plays the role of the parent window of the dialog box.
        /// </param>
        /// <param name="canCancel">
        /// (Required.) A <see cref="T:System.Boolean" /> that controls whether the
        /// <strong>Cancel</strong> button is displayed by the dialog box.
        /// <para />
        /// Set this parameter to <see langword="true" /> to display the button;
        /// <see langword="false" /> to hide it.
        /// </param>
        void ShowProgressDialog(IWin32Window owner,
            bool canCancel);

        /// <summary>
        /// Fluent-builder method for composing a file-renamer object with this
        /// presenter.
        /// </summary>
        /// <param name="fileRenamer">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.IFileRenamer" /> interface.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="fileRenamer" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        IMainWindowPresenter WithFileRenamer(IFileRenamer fileRenamer);

        /// <summary>
        /// Shows a marquee progress bar that indicates the application is
        /// performing work but of an indeterminate length, such as calculating
        /// the amount of files to process.
        /// </summary>
        /// ///
        /// <param name="text">
        /// (Required.) String containing the text to display in the progress dialog.
        /// </param>
        /// <param name="canCancel">
        /// (Required.) <see langword="true" /> to show a <strong>Cancel</strong> button in
        /// the progress dialog; <see langword="false" /> to hide it.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="text" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        void ShowCalculatingProgressBar(string text,
            bool canCancel = true);
    }
}