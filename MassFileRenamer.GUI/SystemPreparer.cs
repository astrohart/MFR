using MassFileRenamer.Objects;
using Microsoft.Win32;
using System;
using System.ComponentModel.Design;
using System.IO;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.GUI
{
    /// <summary>
    /// Provides methods that prepare the computer for the use of this application.
    /// </summary>
    public static class SystemPreparer
    {
        /// <summary>
        /// Creates a blank config.json file in the specified folder. This
        /// method also attempts to create the folder if it does not already exist.
        /// </summary>
        /// <param name="folder">
        /// (Required.) Path to the folder in which to store the config.json file.
        /// </param>
        /// <param name="configFileName">
        /// (Optional.) Filename to use for the config file. Config.json is the
        /// default. If this parameter is specified, it can't be a blank string
        /// and must be a valid filename.
        /// </param>
        /// <returns>
        /// String containing the fully-qualified pathname to the config.json
        /// file. Blank if a problem occurred (either invalid permissions or
        /// some such.
        /// </returns>
        /// <remarks>
        /// This method simply returns the fully-qualified path to the
        /// configuration file if it already exists.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the <paramref name="folder" /> or
        /// <paramref
        ///     name="configFileName" />
        /// parameters are blank.
        /// </exception>
        public static string CreateConfigFile(string folder,
            string configFileName = "config.json")
        {
            if (string.IsNullOrWhiteSpace(folder))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(folder)
                );
            if (string.IsNullOrWhiteSpace(configFileName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(configFileName)
                );

            var fullyQualifiedPath = Path.Combine(folder, configFileName);
            if (!DebugFileAndFolderHelper.IsValidPath(fullyQualifiedPath))
                throw new InvalidPathException(
                    "The path specified is not valid.", fullyQualifiedPath
                );

            var result = fullyQualifiedPath;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the folder '{folder}' already exists..."
            );

            if (Directory.Exists(folder))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** SUCCESS *** The folder '{folder}' already exists."
                );

                result = fullyQualifiedPath;

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"SystemPreparer.CreateConfigFile: Result = '{result}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "SystemPreparer.CreateConfigFile: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: The folder '{folder}' was not found."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"SystemPreparer.CreateConfigFile: Attempting to create the folder '{folder}'..."
            );

            try
            {
                // Attempt to create the folder specified if it does not already exist.
                DebugFileAndFolderHelper.CreateDirectoryIfNotExists(folder);

                // return the fully qualified path name to the configuration file.
                result = fullyQualifiedPath;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result =
                    string
                        .Empty; // set the result to blank if an exception is thrown.
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** Created or found a folder at the pathname '{folder}'."
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.CreateConfigFile: Result = '{result}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "SystemPreparer.CreateConfigFile: Done."
            );

            return result;
        }

        /// <summary>
        /// Obtains a string value from the system Registry under the
        /// <c>HKEY_CURRENT_USER\SOFTWARE</c> key.
        /// </summary>
        /// <param name="keyName">
        /// (Required.) String containing the name of the subkey under which the
        /// value resides.
        /// </param>
        /// <param name="valueName">
        /// (Required.) Name of the Registry value of type <c>REG_SZ</c> that
        /// contains the information requested.
        /// </param>
        /// <param name="defaultValue">
        /// (Optional.) Default value to return if the key/value is not found.
        /// This parameter is blank by default.
        /// </param>
        /// <returns>
        /// String containing the value data, or the value of the
        /// <paramref
        ///     name="defaultValue" />
        /// parameter if the value was not found or a
        /// problem occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="keyName" />, is blank.
        /// </exception>
        public static string GetProfileString(string keyName, string valueName,
            string defaultValue = "")
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In SystemPreparer.GetProfileString"
            );

            var result = string.Empty;

            // Dump the variable keyName to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.GetProfileString: keyName = '{keyName}'"
            );

            if (string.IsNullOrWhiteSpace(keyName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(keyName)
                );

            // Dump the variable defaultValue to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.GetProfileString: defaultValue = '{defaultValue}'"
            );

            using (var baseKey = RegistryKey.OpenBaseKey(
                RegistryHive.CurrentUser, RegistryView.Default
            ))
            using (var key = baseKey.OpenSubKey(
                keyName, RegistryKeyPermissionCheck.ReadSubTree
            ))
                try
                {
                    if (key == null)
                        return defaultValue;

                    result = key.GetValue(
                        valueName, defaultValue, RegistryValueOptions.None
                    ).ToString();
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = defaultValue;
                }
                finally
                {
                    key?.Close();
                    baseKey?.Close();
                }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.GetProfileString: Result = '{result}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "SystemPreparer.GetProfileString: Done."
            );

            return result;
        }

        /// <summary>
        /// Writes profile data (i.e., application settings) to the system
        /// Registry, using a subkey of the <c>HKEY_CURRENT_USER</c> hive.
        /// </summary>
        /// <param name="keyName">
        /// (Required.) String containing the path to the subkey.
        /// </param>
        /// <param name="valueName">
        /// (Required.) String containing the name of the Registry value whose
        /// data should be altered.
        /// </param>
        /// <param name="valueData">
        /// (Optional.) String containing the new data for the value. Set to
        /// blank if you want to set the value's data to be blank.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="keyName" />, is blank.
        /// </exception>
        public static void SetProfileString(string keyName, string valueName,
            string valueData = "")
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In SystemPreparer.SetProfileString"
            );

            // Dump the variable keyName to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.SetProfileString: keyName = '{keyName}'"
            );

            if (string.IsNullOrWhiteSpace(keyName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(keyName)
                );

            // Dump the variable valueName to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.SetProfileString: valueName = '{valueName}'"
            );

            // Dump the variable valueData to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.SetProfileString: valueData = '{valueData}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Trying to write the valueData to the system Registry..."
            );

            using (var baseKey = RegistryKey.OpenBaseKey(
                RegistryHive.CurrentUser, RegistryView.Default
            ))
            using (var key = baseKey.CreateSubKey(keyName))
                try
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"*** SUCCESS *** Registry key '{key.Name}' opened for writing."
                    );

                    key.SetValue(valueName, valueData);

                    DebugUtils.WriteLine(
                        DebugLevel.Info, $@"*** SUCCESS *** Value data written to the '{key.Name}\{valueName} value'.");
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }
                finally
                {
                    key?.Close();
                    baseKey?.Close();
                }

            DebugUtils.WriteLine(
                DebugLevel.Debug, "SystemPreparer.SetProfileString: Done."
            );
        }
    }
}