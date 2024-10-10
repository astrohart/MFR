using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Validators.Factories;
using MFR.FileSystem.Validators.Interfaces;
using MFR.Operations.Constants;
using MFR.TextValues.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System.Threading.Tasks;

namespace MFR.TextValues.Retrievers
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all
    /// <c>
    /// Text
    /// Value Retriever
    /// </c>
    /// objects.
    /// </summary>
    [Log(AttributeExclude = true)]
    public abstract class TextValueRetrieverBase : ITextValueRetriever
    {
        /// <summary>
        /// Fluent bridge property that accesses the appropriate file-system
        /// entry validator object, that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntryValidator" />
        /// interface, for the current operation type.
        /// </summary>
        /// <remarks>
        /// The property is designed to be called as part of a fluent
        /// criteria-evaluation expression.
        /// </remarks>
        protected IFileSystemEntryValidator FileSystemEntryValidatorSays
            => GetFileSystemEntryValidator.For(OperationType);

        /// <summary>
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        public abstract OperationType OperationType
        {
            get;
        }

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
        public abstract string GetTextValue(IFileSystemEntry entry);

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
        /// <remarks>
        /// The base-class version of this method does nothing but always return
        /// the return value of the
        /// <see cref="M:MFR.TextValues.Retrievers.TextValueRetrieverBase.GetTextValue" />
        /// method.
        /// <para />
        /// Override this method if you want to do something else.  Child classes need not
        /// call the base-class version of this method.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public virtual Task<string> GetTextValueAsync(IFileSystemEntry entry)
            => Task.FromResult(GetTextValue(entry));
    }
}