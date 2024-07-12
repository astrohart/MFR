using MFR.Replacers.Factories.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Replacers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Replacers.Factories.Interfaces.IStringReplacerFactory" />
    /// interface that creates instances of objects that are responsible for replacing
    /// the text in the filenames of files that exist in a specific directory tree on
    /// the file system.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetRenameFilesInFolderStringReplacerFactory
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Replacers.Factories.Interfaces.IStringReplacerFactory" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Replacers.Factories.Interfaces.IStringReplacerFactory" />
        /// interface that creates instances of objects that are responsible for replacing
        /// the text in the filenames of files that exist in a specific directory tree on
        /// the file system.
        /// </returns>
        public static IStringReplacerFactory SoleInstance()
            => RenameFilesInFolderStringReplacerFactory.Instance;
    }
}