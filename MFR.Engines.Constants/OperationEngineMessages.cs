using MFR.Messages.Identifiers.Factories;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Engines.Constants
{
    /// <summary>
    /// Identifiers of messages that the operation engines raise to other parts of the
    /// application.
    /// </summary>
    public static class OperationEngineMessages
    {
        /// <summary>
        /// Unique identifier for the message that is sent by the Operation Engine when one
        /// of the file-renaming operations throws an exception.
        /// </summary>
        public static readonly Guid OE_OPERATION_ERROR =
            MakeNewMessageIdentifier.ForNewMessageId()
                                    .AndName("OE_OPERATION_ERROR")
                                    .ToGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Operation Engine when all
        /// of the requested file-renaming operations have been completed.
        /// </summary>
        public static readonly Guid OE_PROCESSING_FINISHED =
            MakeNewMessageIdentifier.ForNewMessageId()
                                    .AndName("OE_OPERATION_ERROR")
                                    .ToGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Operation Engine when a
        /// new <see cref="T:MFR.Renamers.Files.FileRenamer" /> job is started.
        /// </summary>
        public static readonly Guid OE_PROCESSING_STARTED =
            MakeNewMessageIdentifier.ForNewMessageId()
                                    .AndName("OE_OPERATION_ERROR")
                                    .ToGuid();

        /// <summary>
        /// Unique identifier for the message that is sent by the Operation Engine when the
        /// root directory, i.e., the starting directory, path is changed.
        /// </summary>
        public static readonly Guid OE_ROOT_DIRECTORY_PATH_UPDATED =
            MakeNewMessageIdentifier.ForNewMessageId()
                                    .AndName("OE_ROOT_DIRECTORY_UPDATED")
                                    .ToGuid();

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.Engines.Constants.OperationEngineMessages" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static OperationEngineMessages() { }
    }
}