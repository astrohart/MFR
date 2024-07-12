using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;
using MFR.Settings.Configuration.Factories;
using MFR.Settings.Configuration.Interfaces;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Providers.Actions
{
    /// <summary>
    /// Exposes static  methods to execute actions on data.
    /// </summary>
    public static class Execute
    {
        /// <summary>
        /// Attempts to execute the operation of loading a new instance of an object that
        /// implements
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// from a file on the file system.
        /// </summary>
        /// <param name="action">
        /// (Required.) Reference to an <c>Action</c> object that, when executed, loads the
        /// application config from a file on the file system.
        /// </param>
        /// <returns>
        /// If successful, a reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface containing the loaded application config, or the blank
        /// config if the operation could not be executed, or if no application
        /// config data is contained within the specified file.
        /// </returns>
        public static IProjectFileRenamerConfig
            OperationToLoadConfigFromFile(
                IAction<IFileSystemEntry, IProjectFileRenamerConfig>
                    action
            )
        {
            var result = GetBlankProjectFileRenamerConfig.SoleInstance();

            try
            {
                if (action == null) return result;

                result = action.Execute();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = GetBlankProjectFileRenamerConfig.SoleInstance();
            }

            return result;
        }
    }
}