using System;

namespace MFR.Constants
{
    /// <summary>
    /// Contains the identifiers to be utilized in order to tag those messages
    /// sent by the File Renamer object.
    /// </summary>
    public static class FileRenamerMessages
    {
        /// <summary>
        /// Unique identifier for a message that indicates an exception has been
        /// raised by the File Renamer component.
        /// </summary>
        public static readonly Guid FRM_EXCEPTION_RAISED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for a message that indicates that a file has been renamed.
        /// </summary>
        public static readonly Guid FRM_FILE_RENAMED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for a message that indicates that a folder has been renamed.
        /// </summary>
        public static readonly Guid FRM_FOLDER_RENAMED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for a message that indicates a file system entry
        /// (file or folder) has been skipped by the current operation.
        /// </summary>
        public static readonly Guid FRM_FILE_SYSTEM_ENTRY_SKIPPED =
            Guid.NewGuid();

        /// <summary>
        /// Unique identifier for a message that indicates that the number of
        /// files that are to be renamed has been counted.
        /// </summary>
        public static readonly Guid FRM_FILES_TO_BE_RENAMED_COUNTED =
            Guid.NewGuid();

        /// <summary>
        /// Unique identifier for a message that indicates that the number of
        /// files to have text within them replaced has been counted.
        /// </summary>
        public static readonly Guid FRM_FILES_TO_HAVE_TEXT_REPLACED_COUNTED =
            Guid.NewGuid();

        /// <summary>
        /// Unique identifier for a message that indicates that the File Renamer
        /// component has completed all of the requested operations.
        /// </summary>
        public static readonly Guid FRM_FINISHED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for a message that indicates that a particular
        /// File Renamer component operation has been completed.
        /// </summary>
        public static readonly Guid FRM_OPERATION_FINISHED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for a message that indicates that a particular
        /// File Renamer component operation has been started.
        /// </summary>
        public static readonly Guid FRM_OPERATION_STARTED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for a message that indicates that the current
        /// operation is being processed.
        /// </summary>
        public static readonly Guid FRM_PROCESSING_OPERATION = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for a message that indicates that the set of all
        /// requested File Renamer operations has started.
        /// </summary>
        public static readonly Guid FRM_STARTED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for a message that indicates that the set of all
        /// requested File Renamer operations are about to begin.
        /// </summary>
        public static readonly Guid FRM_STARTING = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for a message that indicates that the File Renamer
        /// component has a status update available that should be displayed to
        /// the user.
        /// </summary>
        public static readonly Guid FRM_STATUS_UPDATE = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for a message that indicates that the File Renamer
        /// component has determined the number of subfolders that need to be
        /// operated on.
        /// </summary>
        public static readonly Guid FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED =
            Guid.NewGuid();
    }
}
