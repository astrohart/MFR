using Microsoft.Win32;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Paths.Config.Provider.Actions.Tests
{
    /// <summary>
    /// Exposes static methods to read data from data sources.
    /// </summary>
    public static class Read
    {
        /// <summary>
        /// Attempts to read a <c>REG-SZ</c> value from the system Registry having the
        /// specified <paramref name="valueName" /> and under the specified Registry
        /// <paramref name="keyPath" />.
        /// </summary>
        /// <param name="keyPath">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the fully-qualified Registry key pathname of the key that the value
        /// exists under.
        /// </param>
        /// <param name="valueName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the name of the value under <c>HKEY_CURRENT_USER</c>
        /// which the data is stored.
        /// <para />
        /// Pass the <see cref="F:System.String.Empty" /> value to get the data stored
        /// under the key's <c>(default)</c> value.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the data
        /// under the specified key and value.
        /// </returns>
        public static string RegistryValue(string keyPath, string valueName)
        {
            var result = string.Empty;

            RegistryKey key = default;
            try
            {
                if (string.IsNullOrWhiteSpace(keyPath)) return result;

                using (key = Registry.CurrentUser.OpenSubKey(keyPath))
                {
                    var valueData = key?.GetValue(valueName);
                    if (valueData == null) return result;

                    result = valueData.ToString();
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }
            finally
            {
                key?.Close();
            }

            return result;
        }
    }
}