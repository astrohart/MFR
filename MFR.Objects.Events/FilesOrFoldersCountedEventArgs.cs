namespace MFR.Objects.Events
{
    /// <summary>
    /// Defines the data that is passed by all events of type <see cref="T:MFR.Objects.Events.FilesOrFoldersCountedEventHandler"/>.
    /// </summary>
    public class FilesOrFoldersCountedEventArgs : OperationEventArgs
    {
        /// <summary>
        /// Creates a new instance of <see
        /// cref="T:MFR.Objects.FilesOrFoldersCountedEventArgs"/>
        /// and returns a reference to it.
        /// </summary>
        /// <param name="count">
        /// (Required.) A zero or positive integer specifying the number of
        /// files to be processed by the operation.
        /// </param>
        /// <param name="operationType">
        /// (Required.) One of the <see
        /// cref="T:MFR.Objects.OperationType"/> values that
        /// specifies the operation being performed.
        /// </param>
        public FilesOrFoldersCountedEventArgs(int count, OperationType operationType) : base(operationType)
        {
            Count = count;
        }

        /// <summary>
        /// Gets the count of files to be processed.
        /// </summary>
        public int Count
        {
            get;
        }
    }
}