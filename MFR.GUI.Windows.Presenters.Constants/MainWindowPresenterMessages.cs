using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.GUI.Windows.Presenters.Constants
{
    /// <summary>
    /// Unique identifiers for the messages that are sent by the Presenter of
    /// the main application window.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MainWindowPresenterMessages
    {
        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter when the
        /// operation of creating a new Profile has failed.
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_ADD_NEW_PROFILE_FAILED = new MainWindowPresenterMessageId {
                MessageId = Guid.NewGuid(), Name = "MWP_ADD_NEW_PROFILE_FAILED"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for
        /// the main application window when the history has just been cleared.
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_ALL_HISTORY_CLEARED = new MainWindowPresenterMessageId {
                MessageId = Guid.NewGuid(), Name = "MWP_ALL_HISTORY_CLEARED"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter of
        /// the main application window when the configuration has just been
        /// exported to a file.
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_CONFIGURATION_EXPORTED = new MainWindowPresenterMessageId {
                MessageId = Guid.NewGuid(), Name = "MWP_CONFIGURATION_EXPORTED"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter of
        /// the main application window when the configuration has just been
        /// imported from a file.
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_CONFIGURATION_IMPORTED = new MainWindowPresenterMessageId {
                MessageId = Guid.NewGuid(), Name = "MWP_CONFIGURATION_IMPORTED"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for the main
        /// application window when the user has clicked the Add New Profile button.
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_CREATE_NEW_BLANK_PROFILE_REQUESTED =
                new MainWindowPresenterMessageId {
                    MessageId = Guid.NewGuid(),
                    Name = "MWP_CREATE_NEW_BLANK_PROFILE_REQUESTED"
                };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for
        /// the main application window when a data operation error, such as
        /// accessing a file (separate from the operations that the application
        /// is designed to perform).
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_DATA_OPERATION_ERROR =
                new MainWindowPresenterMessageId {
                    MessageId = Guid.NewGuid(), Name = "MWP_DATA_OPERATION_ERROR"
                };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for
        /// the main application window when a data operation, such as accessing
        /// a file (separate from the operations that the application is
        /// designed to perform), is completed.
        /// </summary>
        public static readonly Guid MWP_DATA_OPERATION_FINISHED =
            new MainWindowPresenterMessageId {
                MessageId = Guid.NewGuid(), Name = "MWP_DATA_OPERATION_FINISHED"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for
        /// the main application window when a data operation, such as accessing
        /// a file (separate from the operations that the application is
        /// designed to perform), is newly started.
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_DATA_OPERATION_STARTED =
                new MainWindowPresenterMessageId {
                    MessageId = Guid.NewGuid(), Name = "MWP_DATA_OPERATION_STARTED"
                };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter of
        /// the main application window when all of the file-rename operations
        /// have finished.
        /// </summary>
        public static readonly MainWindowPresenterMessageId MWP_FINISHED =
            new MainWindowPresenterMessageId {
                MessageId = Guid.NewGuid(), Name = "MWP_FINISHED"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter of
        /// the main application window when one of the file-rename operations
        /// has just come to completion.
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_OPERATION_FINISHED =
                new MainWindowPresenterMessageId {
                    MessageId = Guid.NewGuid(), Name = "MWP_OPERATION_FINISHED"
                };

        /// <summary>
        /// Unique identifier for the message that is sent by the main
        /// application window's Presenter when a file-rename operation is started.
        /// </summary>
        public static readonly MainWindowPresenterMessageId MWP_STARTED =
            new MainWindowPresenterMessageId {
                MessageId = Guid.NewGuid(), Name = "MWP_STARTED"
            };
    }
}