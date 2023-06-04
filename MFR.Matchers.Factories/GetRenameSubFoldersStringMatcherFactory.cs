using MFR.Matchers.Factories.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Matchers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
    /// interface that creates string matcher objects used in order to assist the
    /// application with carrying out the operation of renaming folders in a directory
    /// tree according to a text-replacement pattern that is specified by the user.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetRenameSubFoldersStringMatcherFactory
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
        /// interface that creates string matcher objects used in order to assist the
        /// application with carrying out the operation of renaming folders in a directory
        /// tree according to a text-replacement pattern that is specified by the user.
        /// </returns>
        public static IStringMatcherFactory SoleInstance()
            => RenameSubFoldersStringMatcherFactory.Instance;
    }
}