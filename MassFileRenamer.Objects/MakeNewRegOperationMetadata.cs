namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.IRegOperationMetadata{T}" />
    /// interface.
    /// </summary>
    public static class MakeNewRegOperationMetadata
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IRegOperationMetadata{T}" />
        /// interface
        /// and returns a reference to it.
        /// </summary>
        /// <typeparam name="T">
        /// Name of the class that is the data type of the value to be obtained
        /// from the system Registry.
        /// </typeparam>
        /// <remarks>
        /// Callers of this method must then invoke the fluent-builder methods
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IRegOperationMetadata.ForKeyPath" />
        /// ,
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IRegOperationMetadata.AndValueName" />
        /// , and, optionally, the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IRegOperationMetadata.WithDefaultValue" />
        /// (if needed), to set the properties of the resultant object.
        /// <para />
        /// NOTE: The object's properties are also publicly-exposed, meaning an
        /// object initializer statement may also be utilized.
        /// <para />
        /// Callers are free to pick whichever instantiation method they feel is best.
        /// </remarks>
        public static IRegOperationMetadata<T> FromScatch<T>() where T : class
            => new RegOperationMetadata<T>();
    }
}