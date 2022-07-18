using System;

namespace MFR.GUI.Windows.Presenters.Constants
{
    /// <summary>
    /// Unique identifiers for the messages that are sent by the Presenter of
    /// the main application window.
    /// </summary>
    public static class MainWindowPresenterMessages
    {
        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter when the
        /// operation of creating a new Profile has failed.
        /// </summary>
        public static readonly Guid MWP_ADD_NEW_PROFILE_FAILED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for
        /// the main application window when the history has just been cleared.
        /// </summary>
        public static readonly Guid MWP_ALL_HISTORY_CLEARED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter of
        /// the main application window when the configuration has just been
        /// exported to a file.
        /// </summary>
        public static readonly Guid MWP_CONFIGURATION_EXPORTED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter of
        /// the main application window when the configuration has just been
        /// imported from a file.
        /// </summary>
        public static readonly Guid MWP_CONFIGURATION_IMPORTED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for the main
        /// application window when the user has clicked the Add New Profile button.
        /// </summary>
        public static readonly Guid MWP_CREATE_NEW_BLANK_PROFILE_REQUESTED =
            Guid.NewGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for
        /// the main application window when a data operation error, such as
        /// accessing a file (separate from the operations that the application
        /// is designed to perform).
        /// </summary>
        public static readonly Guid MWP_DATA_OPERAITON_ERROR = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for
        /// the main application window when a data operation, such as accessing
        /// a file (separate from the operations that the application is
        /// designed to perform), is completed.
        /// </summary>
        public static readonly Guid
            MWP_DATA_OPERATION_FINISHED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for
        /// the main application window when a data operation, such as accessing
        /// a file (separate from the operations that the application is
        /// designed to perform), is newly started.
        /// </summary>
        public static readonly Guid MWP_DATA_OPERATION_STARTED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter of
        /// the main application window when all of the file-rename operations
        /// have finished.
        /// </summary>
        public static readonly Guid MWP_FINISHED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter of
        /// the main application window when one of the file-rename operations
        /// throws an exception.
        /// </summary>
        public static readonly Guid MWP_OPERATION_ERROR = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter of
        /// the main application window when one of the file-rename operations
        /// has just come to completion.
        /// </summary>
        public static readonly Guid MWP_OPERATION_FINISHED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the main
        /// application window's Presenter when a file-rename operation is started.
        /// </summary>
        public static readonly Guid MWP_STARTED = Guid.NewGuid();
    }
}
