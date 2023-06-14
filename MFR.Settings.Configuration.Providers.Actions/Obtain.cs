using MFR.Settings.Configuration.Interfaces;
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
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface that contains the application configuration.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a <c>config.json</c> file on the disk from which the application
        /// configuration is to be loaded.
        /// </param>
        /// <returns>
        /// If successful, a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface that contains the application configuration is returned; otherwise, a
        /// blank configuration is returned.
        /// </returns>
        public static IProjectFileRenamerConfiguration ConfigurationFrom(
            string pathname
        )
        {
            var result = Create.BlankConfiguration();

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

                result = Create.BlankConfiguration();
            }

            return result;
        }
    }
}