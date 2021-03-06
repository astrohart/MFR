using MFR.Settings.Configuration.Converters;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Serializers.Properties;
using MFR.FileSystem.Helpers;
using MFR.Settings.Configuration.Factories;
using System;
using System.IO;
using xyLOGIX.Core.Debug;
using File = Alphaleonis.Win32.Filesystem.File;

namespace MFR.Settings.Configuration.Serializers
{
    /// <summary>
    ///     Provides helper methods for storing the configuration data to, and
    ///     loading it from, a file on the disk.
    /// </summary>
    public static class ConfigurationSerializer
    {
        /// <summary>
        ///     Loads the configuration data from the file on the disk that has the
        ///     specified <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        ///     (Required.) String containing the fully-qualified pathname of a
        ///     JSON-formatted data file on the disk that contains the configuration data.
        /// </param>
        /// <returns>
        ///     Reference to an instance of an object that implements the
        ///     <see
        ///         cref="T:MFR.Settings.Profiles.Interfaces.IProfile" />
        ///     interface that has been
        ///     initialized with the data present in the file; or
        ///     <see
        ///         langword="null" />
        ///     if a problem occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the required parameter, <paramref name="pathname" />, is
        ///     passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        ///     Thrown if the file, the path to which is specified by the
        ///     <paramref
        ///         name="pathname" />
        ///     parameter, cannot be located on the disk.
        /// </exception>
        public static IConfiguration Load(string pathname)
        {
            if (string.IsNullOrWhiteSpace(pathname))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(pathname)
                );
            if (!File.Exists(pathname))
                throw new FileNotFoundException(
                    $"The system could not find the configuration file having the pathname '{pathname}'",
                    pathname
                );

            IConfiguration result;

            try
            {
                var content = File.ReadAllText(pathname);

                // If the file at the path pathname has zero bytes of data, or
                // only whitespace, then return a blank Configuration instance
                // with its properties all set to default values.
                result = string.IsNullOrWhiteSpace(content)
                    ? MakeNewConfiguration.FromScratch()
                    : ConvertConfiguration.FromJson(content);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            return result;
        }

        /// <summary>
        ///     Saves configuration data to a file.
        /// </summary>
        /// <param name="pathname">
        ///     (Required.) String containing the pathname of the file that the data
        ///     is to be saved to.
        /// </param>
        /// <param name="configuration">
        ///     (Required.) Reference to an instance of an object that implements
        ///     the
        ///     <see
        ///         cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
        ///     interface.
        /// </param>
        public static void Save(string pathname, IConfiguration configuration)
        {
            if (string.IsNullOrWhiteSpace(pathname))
                return;

            if (configuration == null)
                return;

            try
            {
                var content = ConvertConfiguration.ToJson(configuration);

                if (string.IsNullOrWhiteSpace(content))
                    return;

                if (File.Exists(pathname))
                    File.Delete(pathname);

                FileHelpers.MakeSureContainingFolderExists(pathname);

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
