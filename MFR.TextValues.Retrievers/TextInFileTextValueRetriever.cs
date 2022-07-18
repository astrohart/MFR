using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Validators.Factories;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.TextValues.Retrievers
{
    /// <summary>
    /// Retrieves the text content of a file.
    /// </summary>
    public class TextInFileTextValueRetriever : TextValueRetrieverBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static TextInFileTextValueRetriever() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected TextInFileTextValueRetriever() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.TextValues.Retrievers.TextInFileTextValueRetriever" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static TextInFileTextValueRetriever Instance
        {
            get;
        } = new TextInFileTextValueRetriever();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
            => OperationType.ReplaceTextInFiles;

        /// <summary>
        /// Gets a string containing the text to be searched, from the
        /// file-system <paramref name="entry" /> provided, given the current
        /// <see
        ///     cref="P:MFR.FileAndFolderTextValueRetriever.OperationType" />
        /// .
        /// </summary>
        /// <param name="entry">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface.
        /// </param>
        /// <returns>
        /// String containing the value data to be searched for the current
        /// operation type, or the empty string if the data source has no data.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public override string GetTextValue(IFileSystemEntry entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));

            GetFileSystemEntryValidator.For(OperationType)
                                       .IsValid(entry);

            if (entry.UserState == null)
                throw new InvalidOperationException(
                    $"The entry's UserState variable has a null reference for a value.  It's supposed to contain the text of the file having path '{entry.Path}'."
                );

            return entry.UserState as string;
        }
    }
}
