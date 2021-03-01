using System;
using System.IO;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Base class that provides common methods and properties for all
    /// event-argument objects for text pattern matches.
    /// </summary>
    public class TextPatternMatchEventArgs : OperationEventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextPatternMatchEventArgs" />
        /// and returns a reference to it.
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
        public TextPatternMatchEventArgs(string source,
            string findWhat, string replaceWith, OperationType type) : base(type)
        {
            if (string.IsNullOrWhiteSpace(source))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(source)
                );
            if (string.IsNullOrWhiteSpace(findWhat))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(findWhat)
                );
            if (string.IsNullOrWhiteSpace(replaceWith))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(replaceWith)
                );
            if (type != OperationType.ReplaceTextInFiles && !File.Exists(source))
                throw new FileNotFoundException(
                    "The system cannot find the file specified.", source
                );

            Source = source;
            FindWhat = findWhat;
            ReplaceWith = replaceWith;
        }

        /// <summary>
        /// Gets a string containing the textual criteria for determining
        /// whether the name of the file is to be targeted by a rename operation.
        /// </summary>
        public string FindWhat
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

        /// <summary>
        /// Gets the text that any found occurrences of the data in the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.TextPatternMatchEventArgs.FindWhat" />
        /// should be replaced with.
        /// </summary>
        public string ReplaceWith
        {
            get;
        }

        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MassFileRenamer.Objects.OperationEventArgs"/> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the <see
        /// cref="T:MassFileRenamer.Objects.OperationType"/> values that
        /// specifies the operation being performed.
        /// </param>
        public TextPatternMatchEventArgs(OperationType type) : base(type) { }
    }
}