namespace MFR.Objects
{
    /// <summary>
    /// Provides information for a TextReplacementRequested event.
    /// </summary>
    public class TextReplacementRequestedEventArgs : TextPatternMatchEventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.TextReplacementRequestedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="source">
        /// (Required.) String containing the text that is to be searched for
        /// the pattern in <paramref name="findWhat" />.<para/>This is typically the
        /// fully-qualified pathname of a file or folder; however, if we are
        /// doing the
        /// <see
        ///     cref="T:MFR.Objects.OperationType.ReplaceTextInFiles" />
        /// operation, then this is the text of the current file before
        /// find-and-replace has been done.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the textual criteria for the match.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the data that any occurrences of
        /// <paramref name="findWhat" /> in the <paramref name="source" /> should
        /// be replaced with.
        /// </param>
        /// <param name="operationType">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.Objects.OperationType" />
        /// values that
        /// describes what operation is being performed.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the either of the required parameters,
        /// <paramref
        ///     name="source" />
        /// , <paramref name="findWhat" />, or
        /// <paramref
        ///     name="replaceWith" />
        /// , are passed blank or <c>null</c> strings for values.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the system is unable to locate the file whose pathname is
        /// specified by the <paramref name="source" /> parameter on the disk
        /// (unless we are performing the
        /// <see
        ///     cref="T:MFR.Objects.OperationType.ReplaceTextInFiles" />
        /// operation).
        /// </exception>
        public TextReplacementRequestedEventArgs(string source, string findWhat,
            string replaceWith, OperationType operationType) : base(
            source, findWhat, replaceWith, operationType
        )
        {
            // TODO: Add code here to initialize this event-argument object.
        }

        /// <summary>
        /// Gets or sets the result of the replacement operation.
        /// </summary>
        /// <remarks>
        /// Event handlers should set the value of this property with the text
        /// as it reads once the requested replacement operation has been
        /// performed. If no replacement can be made, then the value of this
        /// property must be set to the text as it originally was provided.
        /// </remarks>
        public string Result
        {
            get;
            set;
        }
    }
}