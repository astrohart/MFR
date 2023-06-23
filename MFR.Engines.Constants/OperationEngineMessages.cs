using System;
using xyLOGIX.Core.Debug;

namespace MFR.Engines.Constants
{
    public static class OperationEngineMessages
    {
        /// <summary>
        /// Unique identifier for the message that is sent by the Operation Engine when one
        /// of the file-renaming operations throws an exception.
        /// </summary>
        public static readonly OperationEngineMessageId OE_OPERATION_ERROR =
            new OperationEngineMessageId {
                MessageId = Guid.NewGuid(), Name = "OE_OPERATION_ERROR"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Operation Engine when all
        /// of the requested file-renaming operations have been completed.
        /// </summary>
        public static readonly OperationEngineMessageId OE_PROCESSING_FINISHED =
            new OperationEngineMessageId {
                MessageId = Guid.NewGuid(), Name = "OE_PROCESSING_FINISHED"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Operation Engine when a
        /// new <see cref="T:MFR.Renamers.Files.FileRenamer" /> job is started.
        /// </summary>
        public static readonly OperationEngineMessageId OE_PROCESSING_STARTED =
            new OperationEngineMessageId {
                MessageId = Guid.NewGuid(), Name = "OE_PROCESSING_STARTED"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Operation Engine when the
        /// root directory, i.e., the starting directory, path is changed.
        /// </summary>
        public static readonly OperationEngineMessageId
            OE_ROOT_DIRECTORY_PATH_UPDATED = new OperationEngineMessageId {
                MessageId = Guid.NewGuid(),
                Name = "OE_ROOT_DIRECTORY_PATH_UPDATED"
            };

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.Engines.Constants.OperationEngineMessages" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// </remarks>
        static OperationEngineMessages()
        {
            // Dump the variable OE_OPERATION_ERROR to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"OperationEngineMessages.OperationEngineMessages: OE_OPERATION_ERROR = '{OE_OPERATION_ERROR}'"
            );

            // Dump the variable OE_PROCESSING_FINISHED to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"OperationEngineMessages.OperationEngineMessages: OE_PROCESSING_FINISHED = '{OE_PROCESSING_FINISHED}'"
            );

            // Dump the variable OE_PROCESSING_STARTED to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"OperationEngineMessages.OperationEngineMessages: OE_PROCESSING_STARTED = '{OE_PROCESSING_STARTED}'"
            );

            // Dump the variable OE_ROOT_DIRECTORY_PATH_UPDATED to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"OperationEngineMessages.OperationEngineMessages: OE_ROOT_DIRECTORY_PATH_UPDATED = '{OE_ROOT_DIRECTORY_PATH_UPDATED}'"
            );
        }
    }
}