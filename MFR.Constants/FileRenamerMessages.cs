using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Constants
{
    /// <summary>
    /// Contains the identifiers to be utilized in order to tag those messages
    /// sent by the File Renamer object.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class FileRenamerMessages
    {
        /// <summary>
        /// Unique identifier for a message that indicates that the operation that is
        /// currently being executed by the application has changed.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_CURRENT_OPERATION_CHANGED = new FileRenamerMessageId {
                MessageId = Guid.NewGuid(),
                Name = "FRM_CURRENT_OPERATION_CHANGED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates an exception has been
        /// raised by the File Renamer component.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_EXCEPTION_RAISED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_EXCEPTION_RAISED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that a file has been renamed.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_FILE_RENAMED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_FILE_RENAMED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates a file system entry
        /// (file or folder) has been skipped by the current operation.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_FILE_SYSTEM_ENTRY_SKIPPED = new FileRenamerMessageId {
                MessageId = Guid.NewGuid(),
                Name = "FRM_FILE_SYSTEM_ENTRY_SKIPPED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the number of
        /// files that are to be renamed has been counted.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_FILES_TO_BE_RENAMED_COUNTED = new FileRenamerMessageId {
                MessageId = Guid.NewGuid(),
                Name = "FRM_FILES_TO_BE_RENAMED_COUNTED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the number of
        /// files to have text within them replaced has been counted.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_FILES_TO_HAVE_TEXT_REPLACED_COUNTED = new FileRenamerMessageId {
                MessageId = Guid.NewGuid(),
                Name = "FRM_FILES_TO_HAVE_TEXT_REPLACED_COUNTED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the File Renamer
        /// component has completed all of the requested operations.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_FINISHED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_FINISHED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that a folder has been renamed.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_FOLDER_RENAMED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_FINISHED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that a particular
        /// File Renamer component operation has been completed.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_OPERATION_FINISHED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_OPERATION_FINISHED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that a particular
        /// File Renamer component operation has been started.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_OPERATION_STARTED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_OPERATION_STARTED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the operation to commit
        /// pending changes before processing the renaming operations has counted the
        /// number of local Git repos that are to be processed.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_PENDING_CHANGES_TO_BE_COMMITTED_COUNTED =
                new FileRenamerMessageId {
                    MessageId = Guid.NewGuid(),
                    Name = "FRM_PENDING_CHANGES_TO_BE_COMMITTED_COUNTED"
                };

        /// <summary>
        /// Unique identifier for a message that indicates that the current
        /// operation is being processed.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_PROCESSING_OPERATION =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_PROCESSING_OPERATION"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the operation to commit the
        /// results of processing the renaming operations has counted the number of local
        /// Git repo actions that are to be performed.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_RESULTS_TO_BE_COMMITTED_TO_GIT_COUNTED =
                new FileRenamerMessageId {
                    MessageId = Guid.NewGuid(),
                    Name = "FRM_RESULTS_TO_BE_COMMITTED_TO_GIT_COUNTED"
                };

        /// <summary>
        /// Unique identifier for a message that indicates that the root directory, i.e.,
        /// the starting directory, of the File Renamer component has been altered.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_ROOT_DIRECTORY_PATH_CHANGED = new FileRenamerMessageId {
                MessageId = Guid.NewGuid(),
                Name = "FRM_ROOT_DIRECTORY_PATH_CHANGED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that aa attempt to close a
        /// Visual Studio Solution (<c>*.sln</c>) file loaded into a running instance of
        /// Visual Studio has failed.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_SOLUTION_CLOSE_FAILED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_SOLUTION_CLOSE_FAILED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that a folder has been renamed.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_SOLUTION_FOLDER_RENAMED = new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_SOLUTION_FOLDER_RENAMED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the File Renamer
        /// component has determined the number of subfolders that need to be
        /// operated on.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_SOLUTION_FOLDERS_TO_BE_RENAMED_COUNTED =
                new FileRenamerMessageId {
                    MessageId = Guid.NewGuid(),
                    Name = "FRM_SOLUTION_FOLDERS_TO_BE_RENAMED_COUNTED"
                };

        /// <summary>
        /// Unique identifier for a message that indicates that aa attempt to close a
        /// Visual Studio Solution (<c>*.sln</c>) file loaded into a running instance of
        /// Visual Studio has failed.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_SOLUTION_OPEN_FAILED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_SOLUTION_OPEN_FAILED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the set of all
        /// requested File Renamer operations has started.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_STARTED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_STARTED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the set of all
        /// requested File Renamer operations are about to begin.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_STARTING =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_STARTED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the File Renamer
        /// component has a status update available that should be displayed to
        /// the user.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_STATUS_UPDATE =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_STATUS_UPDATE"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the File Renamer
        /// component has determined the number of subfolders that need to be
        /// operated on.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED = new FileRenamerMessageId {
                MessageId = Guid.NewGuid(),
                Name = "FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED"
            };
    }
}