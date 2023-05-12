using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;
using MFR.Settings.Configuration.Interfaces;

namespace MFR.Settings.Configuration.Actions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.Messages.Actions.Interfaces.IAction{MFR.FileSystem.Interfaces.IFileSystemEntry, MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration}" />
    /// interface.
    /// </summary>
    public static class GetLoadConfigurationFromFileAction
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Messages.Actions.Interfaces.IAction{MFR.FileSystem.Interfaces.IFileSystemEntry, MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration}" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Messages.Actions.Interfaces.IAction{MFR.FileSystem.Interfaces.IFileSystemEntry, MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration}" />
        /// interface.
        /// </returns>
        public static
            IAction<IFileSystemEntry, IProjectFileRenamerConfiguration>
            SoleInstance()
            => LoadConfigurationFromFileAction.Instance;
    }
}