using System;

namespace MassFileRenamer.Objects
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
        public static readonly Guid FRM_OPERATION_FINISHED = Guid.NewGuid();
        public static readonly Guid FRM_OPERATION_STARTED = Guid.NewGuid();
        public static readonly Guid FRM_FILES_TO_BE_RENAMED_COUNTED = Guid.NewGuid();
        public static readonly Guid FRM_FILES_TO_HAVE_TEXT_REPLACED_COUNTED = Guid.NewGuid();
        public static readonly Guid FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED = Guid.NewGuid();
        public static readonly Guid FRM_STATUS_UPDATE = Guid.NewGuid();
        public static readonly Guid FRM_STARTED = Guid.NewGuid();
        public static readonly Guid FRM_PROCESSING_OPERATION = Guid.NewGuid();
        public static readonly Guid FRM_FINISHED = Guid.NewGuid();
        public static readonly Guid FRM_FILE_SYSTEM_ENTRY_SKIPPED = Guid.NewGuid();

    }
}