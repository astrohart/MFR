using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Helpers;
using MFR.Settings.Configuration.Converters;
using MFR.Settings.Configuration.Factories;
using MFR.Settings.Configuration.Interfaces;
using System;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;
using Initialize = MFR.GUI.Models.Actions.Initialize;

namespace MFR.Settings.Configuration.Serializers
{
    /// <summary>
    /// Provides helper methods for storing the config data to, and
    /// loading it from, a file on the file system.
    /// </summary>
    public static class ConfigurationSerializer
    {
        /// <summary>
        /// Loads the config data from the file on the file system that has the
        /// specified <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the fully-qualified pathname of a
        /// JSON-formatted data file on the file system that contains the config data.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Interfaces.IProfile" />
        /// interface that has been
        /// initialized with the data present in the file; or
        /// <see
        ///     langword="null" />
        /// if a problem occurred.
        /// </returns>
        public static IProjectFileRenamerConfig Load(string pathname)
        {
            var result = GetBlankProjectFileRenamerConfig.SoleInstance();

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (!File.Exists(pathname)) return result;

                var encoding = Determine.FileEncoding(pathname);
                var content = File.ReadAllText(pathname, encoding);
                if (string.IsNullOrWhiteSpace(content))
                    return result;

                // If the file at the path pathname has zero bytes of data, or
                // only whitespace, then return a blank ProjectFileRenamerConfig instance
                // with its properties all set to default values.
                result =
                    ConvertProjectFileRenamerConfig.FromJson(content);

                if (result == null) return result;

                /*
                 * If, for some reason, the loaded config object contains no
                 * operations to perform, initialize the list with the defaults.
                 */

                if (!result.InvokableOperations.Any())
                    result.InvokableOperations = Initialize.OperationList();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = GetBlankProjectFileRenamerConfig.SoleInstance();
            }

            return result;
        }

        /// <summary>
        /// Saves config data to a file.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the pathname of the file that the data
        /// is to be saved to.
        /// </param>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        public static void Save(
            string pathname,
            IProjectFileRenamerConfig config
        )
        {
            if (string.IsNullOrWhiteSpace(pathname))
                return;

            if (config == null)
                return;

            try
            {
                var content =
                    ConvertProjectFileRenamerConfig
                        .ToJson(config);

                if (string.IsNullOrWhiteSpace(content))
                    return;

                if (File.Exists(pathname))
                    File.Delete(pathname);

                MakeSure.ContainingFolderExists(pathname);

                File.WriteAllText(pathname, content);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}