using PostSharp.Patterns.Threading;
using MFR.Operations.Constants;
using MFR.Operations.Events;
using System;

namespace MFR.Events
{
    /// <summary>
    /// Base class that provides common methods and properties for all
    /// event-argument objects for text pattern matches.
    /// </summary>
[ExplicitlySynchronized]
    public class TextPatternMatchEventArgs : OperationEventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.TextPatternMatchEventArgs" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <param name="source">
        /// (Required.) String containing the text that is to be searched for
        /// the pattern in <paramref name="findWhat" />.
        /// <para />
        /// This typically the fully-qualified pathname of a file or folder;
        /// however, if we are doing the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.ReplaceTextInFiles" />
        /// operation, then this the text of the current file before
        /// find-and-replace has been done.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the textual criteria for the match.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the data that any occurrences of
        /// <paramref name="findWhat" /> in the <paramref name="source" /> should
        /// be replaced with.
        /// <para />
        /// NOTE: This parameter may be blank for the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.ReplaceTextInFiles" />
        /// operation type.
        /// </param>
        /// <param name="operationType">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// describes what operation is being performed.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the either of the required parameters,
        /// <paramref
        ///     name="source" />
        /// . <paramref name="findWhat" /> , or
        /// <paramref
        ///     name="replaceWith" />
        /// , are passed blank or <see langword="null" /> strings for values.
        /// </exception>
        public TextPatternMatchEventArgs(string source, string findWhat,
            string replaceWith, OperationType operationType) : base(
            operationType
        )
        {
            if (string.IsNullOrWhiteSpace(source))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(source)
                );
            if (string.IsNullOrWhiteSpace(findWhat))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(findWhat)
                );
            if (operationType != OperationType.ReplaceTextInFiles &&
                string.IsNullOrWhiteSpace(replaceWith))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(replaceWith)
                );

            // NOTE: I removed the file-exists validation that was here. As this
            // class really should be just a class that transfers information
            // from one place to another.

            Source = source;
            FindWhat = findWhat;
            ReplaceWith = replaceWith;
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.OperationEventArgs" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="operationType">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// specifies the operation being performed.
        /// </param>
        public TextPatternMatchEventArgs(OperationType operationType) : base(
            operationType
        ) { }

        /// <summary>
        /// Gets a string containing the textual criteria for determining
        /// whether the name of the file is to be targeted by a rename operation.
        /// </summary>
        public string FindWhat
        {
            get;
        }

        /// <summary>
        /// Gets the text that any found occurrences of the data in the
        /// <see
        ///     cref="P:MFR.Events.TextPatternMatchEventArgs.FindWhat" />
        /// should be replaced with.
        /// </summary>
        public string ReplaceWith
        {
            get;
        }

        /// <summary>
        /// Gets a string containing the full pathname of the file to run a
        /// match operation against.
        /// </summary>
        public string Source
        {
            get;
        }
    }
}