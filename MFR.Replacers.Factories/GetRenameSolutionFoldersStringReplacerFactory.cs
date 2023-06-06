using MFR.Replacers.Factories.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Replacers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Replacers.Factories.Interfaces.IStringReplacerFactory" />
    /// interface that creates objects which are responsible for renaming file folders
    /// within a specific directory tree, that contain Visual Studio Solution (
    /// <c>*.sln</c>) files, according to a text-replacement pattern that was specified
    /// by the user.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetRenameSolutionFoldersStringReplacerFactory
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Replacers.Factories.Interfaces.IStringReplacerFactory" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Replacers.Factories.Interfaces.IStringReplacerFactory" />
        /// interface that creates objects which are responsible for renaming file folders
        /// within a specific directory tree, that contain Visual Studio Solution (
        /// <c>*.sln</c>) files, according to a text-replacement pattern that was specified
        /// by the user.
        /// </returns>
        public static IStringReplacerFactory SoleInstance()
            => RenameSolutionFoldersStringReplacerFactory.Instance;
    }
}