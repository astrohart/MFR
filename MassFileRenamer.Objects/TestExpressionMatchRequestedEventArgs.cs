namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Provides information for a TextExpressionMatchRequested event.
    /// </summary>
    public class
        TextExpressionMatchRequestedEventArgs : TextPatternMatchEventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextExpressionMatchRequestedEventArgs" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <param name="source">
        /// (Required.) String containing the text that is to be searched for
        /// the pattern in <paramref name="findWhat" />.<para/>This is typically the
        /// fully-qualified pathname of a file or folder; however, if we are
        /// doing the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType.ReplaceTextInFiles" />
        /// operation, then this is the text of the current file before
        /// find-and-replace has been done.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the textual criteria for the match.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing
        /// the data that any occurrences of <paramref name="findWhat" /> in the
        /// <paramref name="source" /> should be replaced with.
        /// </param>
        /// <param
        ///     name="type">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
        /// values that
        /// describes what operation is being performed.
        /// </param>
        /// <exception
        ///     cref="T:System.ArgumentException">
        /// Thrown if the either of the
        /// required parameters, <paramref name="source" />. <paramref
        ///                                                     name="findWhat" />
        /// , or <paramref name="replaceWith" /> , are passed
        /// blank or <c>null</c> strings for values.
        /// </exception>
        /// <exception
        ///     cref="T:System.IO.FileNotFoundException">
        /// Thrown if the system is
        /// unable to locate the file whose pathname is specified by the
        /// <paramref name="source" /> parameter on the disk (unless we are performing the <see cref="T:MassFileRenamer.Objects.OperationType.ReplaceTextInFiles"/> operation).
        /// </exception>
        public TextExpressionMatchRequestedEventArgs(string source,
            string findWhat, string replaceWith, OperationType type) : base(
            source, findWhat, replaceWith, type
        )
        {
            // TODO: Add code here to initialize this event-argument object.
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextExpressionMatchRequestedEventArgs" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
        /// values that
        /// specifies the operation being performed.
        /// </param>
        public TextExpressionMatchRequestedEventArgs(OperationType type) : base(
            type
        ) { }

        /// <summary>
        /// Gets or sets a value indicating whether the file name matches the criteria.
        /// </summary>
        public bool DoesMatch
        {
            get;
            set;
        }
    }
}