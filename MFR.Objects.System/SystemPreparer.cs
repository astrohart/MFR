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