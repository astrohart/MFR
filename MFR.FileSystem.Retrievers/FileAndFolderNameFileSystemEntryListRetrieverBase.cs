using MFR.FileSystem.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.FileSystem.Retrievers
{
    /// <summary>
    /// Implements functionality that is shared among objects that search file
    /// and folder names.
    /// </summary>
    public abstract class
        FileAndFolderNameFileSystemEntryListRetrieverBase :
            FileSystemEntryListRetrieverBase
    {
        /// <summary>
        /// Specifies a string that should be utilized in order to replace a
        /// textual pattern in the name of a file or folder or the contents thereof.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// The value of the <paramref name="replaceWith" /> parameter may be
        /// allowed by some implementations to be blank.
        /// <para />
        /// This particular implementation requires a non-blank value be specified.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="replaceWith" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        public sealed override IFileSystemEntryListRetriever AndReplaceItWith(
            string replaceWith)
        {
            if (string.IsNullOrWhiteSpace(replaceWith))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(replaceWith)
                );

            ReplaceWith = replaceWith;

            return this;
        }

        /// <summary>
        /// Sets the values of this class' properties to their default values.
        /// </summary>
        /// <remarks>
        /// This method typically is called from a class constructor.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public override void Reset()
            => SearchOption = System.IO.SearchOption.AllDirectories;
    }
}