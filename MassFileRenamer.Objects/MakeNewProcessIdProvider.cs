namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.IProcessIdProvider" />
    /// interface.
    /// </summary>
    public static class MakeNewProcessIdProvider
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IProcessIdProvider" />
        /// interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to a new instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IProcessIdProvider" />
        /// interface.
        /// </returns>
        public static IProcessIdProvider FromScratch()
            => new ProcessIdProvider();
    }
}