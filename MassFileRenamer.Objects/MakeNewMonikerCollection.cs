namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.IMonikerEnumerable" />
    /// interface.
    /// </summary>
    public static class MakeNewMonikerCollection
    {
        /// <summary>
        /// Creates a new, uninitialized instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IMonikerEnumerable" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IMonikerEnumerable" />
        /// interface.
        /// </returns>
        public static IMonikerEnumerable FromScratch()
            => new MonikerCollection();
    }
}