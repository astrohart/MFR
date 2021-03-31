namespace MFR.Objects.Renamers.Files.Factories
{
    /// <summary>
    /// Provides helper methods that create new instances of objects that
    /// implement the <see cref="T:MFR.Objects.IFileRenamer" /> interface.
    /// </summary>
    public static class MakeNewFileRenamer
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IFileRenamer" />
        /// interface using the
        /// default constructor.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IFileRenamer" />
        /// interface.
        /// </returns>
        public static IFileRenamer FromScratch()
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In MakeFileRenamer.FromScratch"
            );

            var result = new FileRenamer();

            if (result != null)
                DebugUtils.WriteLine(DebugLevel.Info, "*** SUCCESS *** Fashioned a new FileRenamer object from scratch.");

            DebugUtils.WriteLine(
                DebugLevel.Debug, "MakeFileRenamer.FromScratch: Done."
            );

            return result;
        }
    }
}