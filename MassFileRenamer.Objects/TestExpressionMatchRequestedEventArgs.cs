using System;
using System.IO;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Provides information for a TestExpressionMatchRequested event.
    /// </summary>
    public class TestExpressionMatchRequestedEventArgs : EventArgs
    {
        /// <summary> Constructs a new instance of <see
        /// cref="T:MassFileRenamer.Objects.TestExpressionMatchRequestedEventArgs"
        /// /> and returns a reference to it. </summary> <param name="path">
        /// (Required.) String containing the full pathname to the file to
        /// perform a match against. </param> <param name="findWhat">
        /// (Required.) String containing the textual criteria for the match.
        /// </param> <param name="replaceWith"> (Required.) String containing
        /// the data that any occurrences of <paramref name="findWhat" /> in the
        /// <paramref name="path" /> should be replaced with. </param> <param
        /// name="type"> (Required.) One of the <see
        /// cref="T:MassFileRenamer.Objects.OperationType" /> values that
        /// describes what operation is being performed. </param> <exception
        /// cref="T:System.ArgumentException"> Thrown if the either of the
        /// required parameters, <paramref name="path" />. <<paramref
        /// name="findWhat" /> , or <paramref name="replaceWith" /> , are passed
        /// blank or <c>null</c> strings for values. </exception> <exception
        /// cref="T:System.IO.FileNotFoundException"> Thrown if the system is
        /// unable to locate the file whose pathname is specified by the
        /// <paramref name="path" /> parameter on the disk. </exception>
        public TestExpressionMatchRequestedEventArgs(string path,
            string findWhat, string replaceWith, OperationType type)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );
            if (string.IsNullOrWhiteSpace(findWhat))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(findWhat)
                );
            if (string.IsNullOrWhiteSpace(replaceWith))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(replaceWith)
                );
            if (!File.Exists(path))
                throw new FileNotFoundException(
                    "The system cannot find the file specified.", path
                );

            Path = path;
            FindWhat = findWhat;
            ReplaceWith = replaceWith;
            OperationType = type;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the file name matches the criteria.
        /// </summary>
        public bool DoesMatch
        {
            get;
            set;
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
        /// Gets the <see cref="T:MassFileRenamer.Objects.OperationType"/> value
        /// that describes what operation is being performed.
        /// </summary>
        public OperationType OperationType
        {
            get;
        }

        /// <summary>
        /// Gets a string containing the full pathname of the file to run a
        /// match operation again.
        /// </summary>
        public string Path
        {
            get;
        }

        /// <summary>
        /// Gets the text that any found occurrences of the data in the <see
        /// cref="P:MassFileRenamer.Objects.TestExpressionMatchRequestedEventArgs.FindWhat"/>
        /// should be replaced with.
        /// </summary>
        public string ReplaceWith
        {
            get;
        }
    }
}