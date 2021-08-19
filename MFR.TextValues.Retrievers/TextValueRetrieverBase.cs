using MFR.FileSystem.Interfaces;
using MFR.Operations.Constants;
using MFR.TextValues.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.TextValues.Retrievers
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all <c>Text
    /// Value Retriever</c> objects.
    /// </summary>
    public abstract class TextValueRetrieverBase : ITextValueRetriever
    {
        /// <summary>
        /// Gets one of the <see cref="T:MFR.OperationType"/> values
        /// that corresponds to the type of operation being performed.
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
        /// cref="P:MFR.FileAndFolderTextValueRetriever.OperationType"/> .
        /// </summary>
        /// <param name="entry">
        /// Reference to an instance of an object that implements the <see
        /// cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry"/> interface.
        /// </param>
        /// <returns>
        /// String containing the value data to be searched for the current
        /// operation type, or the empty string if the data source has no data.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry"/>, is
        /// passed a <see langword="null"/> value.
        /// </exception>
        public abstract string GetTextValue(IFileSystemEntry entry);
    }
}