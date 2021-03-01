namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the data that is passed by all events of type <see cref="T:MassFileRenamer.Objects.ProcessingOperationEventHandler"/>.
    /// </summary>
    public class ProcessingOperationEventArgs : OperationCancelEventArgs
    {
        /// <summary>
        /// Creates a new instance of <see
        /// cref="T:MassFileRenamer.Objects.ProcessingOperationEventArgs"/> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the pathname of the file or the folder
        /// that is about to be processed.
        /// </param>
        /// <param name="type">
        /// (Required.) One of the <see
        /// cref="T:MassFileRenamer.Objects.OperationType"/> values that
        /// specifies the operation being performed.
        /// </param>
        public ProcessingOperationEventArgs(string pathname,
           OperationType type) : base(type)
        {
            Pathname = pathname;
        }

        /// <summary>
        /// Gets a string containing a pathname of the file or folder that is
        /// about to be processed.
        /// </summary>
        public string Pathname
        {
            get;
        }
    }
}