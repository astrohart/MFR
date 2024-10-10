using MFR.Replacers.Factories.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Replacers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Replacers.Factories.Interfaces.IStringReplacerFactory" />
    /// interface that creates objects which are responsible for replacing text in the
    /// contents of files within a specific directory tree based on a text-replacement
    /// pattern specified by the user.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetReplaceTextInFilesStringReplacerFactory
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Replacers.Factories.Interfaces.IStringReplacerFactory" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Replacers.Factories.Interfaces.IStringReplacerFactory" />
        /// interface that creates objects which are responsible for replacing text in the
        /// contents of files within a specific directory tree based on a text-replacement
        /// pattern specified by the user.
        /// </returns>
        public static IStringReplacerFactory SoleInstance()
            => ReplaceTextInFilesStringReplacerFactory.Instance;
    }
}