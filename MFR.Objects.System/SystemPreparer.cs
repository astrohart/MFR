using MFR.Objects.FileSystem.Exceptions;
using MFR.Objects.Registry.Helpers;
using Microsoft.Win32;
using System;
using Alphaleonis.Win32.Filesystem;
using xyLOGIX.Core.Debug;

namespace MFR.Objects.System
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
        /// <param name="folderName">
        /// (Required.) Path to the folder in which to store the config.json file.
        /// </param>
        /// <param name="fileName">
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
        /// Thrown if either of the <paramref name="folderName"/> or <paramref
        /// name="fileName"/> parameters are blank.
        /// </exception>
        public static string CreateOrOpenConfigFile(string folderName,
            string fileName = "config.json")
        {
            if (string.IsNullOrWhiteSpace(folderName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(folderName)
                );
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(fileName)
                );

            var result = Path.Combine(folderName, fileName);
            if (!DebugFileAndFolderHelper.IsValidPath(result))
                throw new InvalidPathException(
                    "The path specified is not valid.", result
                );
            
            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the folder '{folderName}' already exists..."
            );

            if (Directory.Exists(folderName))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** SUCCESS *** The folder '{folderName}' already exists."
                );

               DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"SystemPreparer.CreateOrOpenConfigFile: Result = '{result}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "SystemPreparer.CreateOrOpenConfigFile: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: The folder '{folderName}' was not found."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"SystemPreparer.CreateOrOpenConfigFile: Attempting to create the folder '{folderName}'..."
            );

            try
            {
                // Attempt to create the folder specified if it does not already exist.
                DebugFileAndFolderHelper.CreateDirectoryIfNotExists(folderName);

                // if the file itself does not exist in the folder specified, then
                // create a new zero-byte file at the pathname specified.
                if (!File.Exists(result)) File.CreateText(result).Close();
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
                $"*** SUCCESS *** Created or found a folder at the pathname '{folderName}'."
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.CreateOrOpenConfigFile: Result = '{result}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "SystemPreparer.CreateOrOpenConfigFile: Done."
            );

            return result;
        }

        /// <summary>
        /// Obtains a string value from the system Registry key.
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
        /// String containing the value data, or the value of the <paramref
        /// name="defaultValue"/> parameter if the value was not found or a
        /// problem occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="keyName"/>, is blank.
        /// </exception>
        public static string GetRegistryString(string keyName, string valueName,
            string defaultValue = "")
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In SystemPreparer.GetRegistryString"
            );

            var result = string.Empty;

            // Dump the variable keyName to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.GetRegistryString: keyName = '{keyName}'"
            );

            if (string.IsNullOrWhiteSpace(keyName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(keyName)
                );

            // Dump the variable defaultValue to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.GetRegistryString: defaultValue = '{defaultValue}'"
            );

            using (var baseKey = RegistryKey.OpenBaseKey(
                keyName.ToRegistryHive(), RegistryView.Default
            ))
            using (var key = baseKey.OpenSubKey(
                keyName.RemoveHiveName(), RegistryKeyPermissionCheck.ReadSubTree
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
                    baseKey.Close();
                }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.GetRegistryString: Result = '{result}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "SystemPreparer.GetRegistryString: Done."
            );

            return result;
        }

        /// <summary>
        /// Writes profile data (i.e., application settings) to the system
        /// Registry.
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
        /// blank if you want to set the value's new data to be blank.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="keyName"/>, is blank.
        /// </exception>
        public static void SetRegistryString(string keyName,  /* mandatory */
            string valueName = "",  /* setting this to blank sets the (Default) entry */
            string valueData = "" /* setting this to blank clears the value's data */)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In SystemPreparer.SetRegistryString"
            );

            // Dump the variable keyName to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.SetRegistryString: keyName = '{keyName}'"
            );

            if (string.IsNullOrWhiteSpace(keyName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(keyName)
                );

            // Dump the variable valueName to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.SetRegistryString: valueName = '{valueName}'"
            );

            // Dump the variable valueData to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.SetRegistryString: valueData = '{valueData}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Trying to write the valueData to the system Registry..."
            );

            using (var baseKey = RegistryKey.OpenBaseKey(
                keyName.ToRegistryHive(), RegistryView.Default
            ))
            using (var key = baseKey.CreateSubKey(keyName.RemoveHiveName()))
                try
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"*** SUCCESS *** Registry key '{key.Name}' opened for writing."
                    );

                    key.SetValue(valueName, valueData);

                    DebugUtils.WriteLine(
                        DebugLevel.Info, $@"*** SUCCESS *** Value data written to the '{key.Name}\{valueName} value'."
                        );
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }
                finally
                {
                    key?.Close();
                    baseKey.Close();
                }

            DebugUtils.WriteLine(
                DebugLevel.Debug, "SystemPreparer.SetRegistryString: Done."
            );
        }
    }
}