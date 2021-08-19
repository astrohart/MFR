using MFR.Objects.FileSystem.Interfaces;
using MFR.Objects.Operations.Constants;

namespace MFR.Objects.Operations.Events
{
    /// <summary>
    /// Defines the data that is passed by all events of type
    /// <see cref="T:MFR.Objects.Operations.Events.ProcessingOperationEventHandler" />.
    /// </summary>
    public class ProcessingOperationEventArgs : OperationCancelEventArgs
    {
        /// <summary>
        /// Creates a new instance of
        /// <see
        ///     cref="T:MFR.Objects.ProcessingOperationEventArgs" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Objects.FileSystem.Interfaces.IFileSystemEntry" /> interface.
        /// </param>
        /// <param name="type">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.Objects.OperationType" />
        /// values that
        /// specifies the operation being performed.
        /// </param>
        public ProcessingOperationEventArgs(IFileSystemEntry entry,
            OperationType type) : base(type)
        {
            Entry = entry;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Objects.FileSystem.Interfaces.IFileSystemEntry" /> interface
        /// that represents information about which file or folder is about to
        /// be processed.
        /// </summary>
        public IFileSystemEntry Entry
        {
            get;
        }
    }
}