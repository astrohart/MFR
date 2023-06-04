using MFR.Matchers.Factories.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Matchers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
    /// interface that creates string matcher objects to be used in order to assist the
    /// application with renaming files in a folder that match a specific
    /// text-replacement pattern.
    /// </summary>
    [Log(AttributeExclude = true)]
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
        /// interface that creates string matcher objects to be used in order to assist the
        /// application with renaming files in a folder that match a specific
        /// text-replacement pattern.
        /// </returns>
        public static IStringMatcherFactory SoleInstance()
            => RenameFilesInFolderStringMatcherFactory.Instance;
    }
}