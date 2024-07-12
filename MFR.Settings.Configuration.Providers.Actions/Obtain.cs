using MFR.Settings.Configuration.Factories;
using MFR.Settings.Configuration.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Providers.Actions
{
    /// <summary>
    /// Exposes static methods to load and initialize object instances from data
    /// sources.
    /// </summary>
    public static class Obtain
    {
        /// <summary>
        /// Attempts to obtain a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface that contains the application config.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a <c>config.json</c> file on the file system from which the application
        /// config is to be loaded.
        /// </param>
        /// <returns>
        /// If successful, a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface that contains the application config is returned; otherwise, a
        /// blank config is returned.
        /// </returns>
        public static IProjectFileRenamerConfig ConfigurationFrom(
            [NotLogged] string pathname
        )
        {
            var result = GetBlankProjectFileRenamerConfig.SoleInstance();

            try
            {
                if (!Determine.IsConfigPathValid(pathname))
                    return result;

                var configFileSystemEntry =
                    Generate.FileSystemEntryForConfiguration(pathname);
                if (configFileSystemEntry == null) return result;

                var loadConfigurationAction =
                    Generate.LoadConfigFromFileAction(configFileSystemEntry);
                if (loadConfigurationAction == null) return result;

                result =
                    Execute.OperationToLoadConfigFromFile(
                        loadConfigurationAction
                    );
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