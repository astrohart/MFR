using MFR.Matchers.Factories.Interfaces;

namespace MFR.Matchers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
    /// interface for renaming the files contained within a parent folder.
    /// </summary>
    public static class GetRenameFilesInFolderStringMatcherFactory
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
        /// interface for renaming the files contained within a parent folder.
        /// </returns>
        public static IStringMatcherFactory SoleInstance()
            => RenameFilesInFolderStringMatcherFactory.Instance;
    }
}