using MFR.Matchers.Factories.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Matchers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
    /// interface for replacing values within the text of a file.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetReplaceTextInFilesStringMatcherFactory
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
        /// interface for replacing values within the text of a file.
        /// </returns>
        public static IStringMatcherFactory SoleInstance()
            => ReplaceTextInFilesStringMatcherFactory.Instance;
    }
}