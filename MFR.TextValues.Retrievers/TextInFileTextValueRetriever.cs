using MFR.FileSystem.Interfaces;
using MFR.Operations.Constants;
using MFR.TextValues.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.MemoryMapped.Factories;

namespace MFR.TextValues.Retrievers
{
    /// <summary>
    /// Retrieves the text content of a file.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class TextInFileTextValueRetriever : TextValueRetrieverBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static TextInFileTextValueRetriever() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected TextInFileTextValueRetriever() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever" />
        /// interface for retrieving the text from files on the filesystem.
        /// </summary>
        public static ITextValueRetriever Instance
        {
            get;
        } = new TextInFileTextValueRetriever();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public override OperationType OperationType
        {
            get;
        } = OperationType.ReplaceTextInFiles;

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the text to be
        /// searched, from the file-system <paramref name="entry" /> provided,
        /// given the current
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
        /// A <see cref="T:System.String" /> containing the value data to be searched
        /// for the current operation type, or the empty string if the data source has
        /// no data.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        [return: NotLogged]
        public override string GetTextValue(IFileSystemEntry entry)
        {
            var result = string.Empty;

            try
            {
                if (entry == null) return result;
                if (!FileSystemEntryValidatorSays.IsValid(entry)) return result;
                if (!(entry.UserState is Guid)) return result;
                if (Guid.Empty.Equals(entry.UserState)) return result;

                using (var reader = MakeNewFileStreamReader.ForPath(entry.Path))
                    result = reader.ReadAllText();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}