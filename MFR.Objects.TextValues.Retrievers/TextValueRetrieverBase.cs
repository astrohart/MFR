using MFR.Objects.FileSystem.Interfaces;
using MFR.Objects.Operations.Constants;
using MFR.Objects.TextValues.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Objects.TextValues.Retrievers
{
    public abstract class TextValueRetrieverBase : ITextValueRetriever
    {
        /// <summary>
        /// Gets one of the <see
        /// cref="T:MFR.Objects.OperationType"/> values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public abstract OperationType OperationType
        {
            get;
        }

        /// <summary>
        /// Gets a string containing the text to be searched, from the
        /// file-system <paramref name="entry"/> provided, given the current
        /// <see
        /// cref="P:MFR.Objects.FileAndFolderTextValueRetriever.OperationType"/> .
        /// </summary>
        /// <param name="entry">
        /// Reference to an instance of an object that implements the <see
        /// cref="T:MFR.Objects.FileSystem.Interfaces.IFileSystemEntry"/> interface.
        /// </param>
        /// <returns>
        /// String containing the value data to be searched for the current
        /// operation type, or the empty string if the data source has no data.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry"/>, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public abstract string GetTextValue(IFileSystemEntry entry);
    }
}