namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a text-retriever object.
    /// </summary>
    /// <remarks>
    /// Such objects examine the properties of another object that implements
    /// the <see cref="T:MassFileRenamer.Objects.IFileSystemEntry" /> interface.
    /// <para />
    /// The properties are used to extract a text value that contains the data
    /// upon which a find/replace operation is based.
    /// <para />
    /// The specific data to be utilized varies from one type of operation to
    /// the other.
    /// </remarks>
    public interface ITextValueRetriever : IFixedOperationTypeSpecificObject
    {
        /// <summary>
        /// Gets a string containing the text to be searched, from the
        /// file-system <paramref name="entry" /> provided, given the current
        /// <see cref="T:MassFileRenamer.Objects.OperationType"/> now being processed.
        /// </summary>
        /// <param name="entry">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IFileSystemEntry" />
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
        string GetTextValue(IFileSystemEntry entry);
    }
}