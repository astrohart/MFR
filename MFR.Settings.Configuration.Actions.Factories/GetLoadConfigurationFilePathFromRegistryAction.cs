using MFR.Expressions.Registry.Interfaces;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;

namespace MFR.Settings.Configuration.Actions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Messages.Actions.Interfaces.ICachedResultAction{MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String}, MFR.FileSystem.Interfaces.IFileSystemEntry}" />
    /// interface.
    /// </summary>
    public static class GetLoadConfigurationFilePathFromRegistryAction
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Messages.Actions.Interfaces.ICachedResultAction{MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String}, MFR.FileSystem.Interfaces.IFileSystemEntry}" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Messages.Actions.Interfaces.ICachedResultAction{MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String}, MFR.FileSystem.Interfaces.IFileSystemEntry}" />
        /// interface.
        /// </returns>
        public static
            ICachedResultAction<IRegQueryExpression<string>, IFileSystemEntry>
            SoleInstance()
            => LoadConfigurationFilePathFromRegistryAction.Instance;
    }
}