using System;

namespace MFR.Engines.Constants
{
    public static class OperationEngineMessages
    {
        /// <summary>
        /// Unique identifier for the message that is sent by the Operation Engine when one
        /// of the file-renaming operations throws an exception.
        /// </summary>
        public static readonly Guid OE_OPERATION_ERROR = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Operation Engine when all
        /// of the requested file-renaming operations have been completed.
        /// </summary>
        public static readonly Guid OE_OPERATION_FINISHED = Guid.NewGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Operation Engine when a
        /// new <see cref="T:MFR.Renamers.Files.FileRenamer" /> job is started.
        /// </summary>
        public static readonly Guid OE_OPERATION_STARTED = Guid.NewGuid();
    }
}