using Microsoft.Win32;
using System;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.Registry.Helpers
{
    /// <summary>
    /// Helper methods for working with
    /// <see
    ///     cref="T:Microsoft.Win32.RegistryHive" />
    /// enumeration values.
    /// </summary>
    public static class RegistryHiveExtensions
    {
        /// <summary>
        /// Determines whether a value with the specified
        /// <paramref
        ///     name="valueName" />
        /// exists under the Registry key with the
        /// <paramref
        ///     name="keyPath" />
        /// given.
        /// </summary>
        /// <param name="keyPath">
        /// (Required.) Fully-qualified path, including the hive, of the key you
        /// want to access.
        /// </param>
        /// <param name="valueName">
        /// (Required.) Name of the value.
        /// <para />
        /// <b>NOTE:</b> This parameter is required to be non-blank. Normally,
        /// if a blank value is specified for <paramref name="valueName" />, the
        /// (Default) value would be accessed; however, since it's always the
        /// case that such a value exists for every Registry key, this is a
        /// non-sequitur to this method.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if a value with the specified name exists under the
        /// specified Registry key; <see langword="false" /> otherwise.
        /// </returns>
        public static bool HasValueWithName(this string keyPath,
            string valueName)
        {
            var result = false;

            if (string.IsNullOrWhiteSpace(keyPath)) return false;
            if (string.IsNullOrWhiteSpace(valueName)) return false;

            using (var baseKey = RegistryKey.OpenBaseKey(
                keyPath.ToRegistryHive(), RegistryView.Default
            ))
            using (var key = baseKey.OpenSubKey(
                keyPath.RemoveHiveName(), RegistryKeyPermissionCheck.ReadSubTree
            ))
                try
                {
                    result = key?.GetValue(valueName) != null;
                }
                catch
                {
                    result = false;
                }
                finally
                {
                    key?.Close();
                    baseKey.Close();
                }

            return result;
        }

        /// <summary>
        /// Attempts to strip the hive name from a path to a Registry key with
        /// the specified <paramref name="keyPath" />.
        /// </summary>
        /// <param name="keyPath">
        /// (Required.) String containing the path to the Registry key that
        /// might contain the name of a hive.
        /// </param>
        /// <returns>
        /// The Registry key path with the hive name (if present) stripped.
        /// </returns>
        /// <remarks>
        /// If the <paramref name="keyPath" />'s value does not contain
        /// backslashes, is blank, or does not start with 'HKEY', then this
        /// method devolves to the identity map.
        /// <para />
        /// The output of this method is also the same as that of the identity
        /// map in the case where an exception is thrown by the system during
        /// the parsing operation.
        /// </remarks>
        public static string RemoveHiveName(this string keyPath)
        {
            if (string.IsNullOrWhiteSpace(keyPath)) return keyPath;

            if (!keyPath.Contains(@"\")) return keyPath;

            if (!keyPath.StartsWith("HKEY_")) return keyPath;

            string result;

            try
            {
                result = string.Join(
                    @"\", keyPath.Split(
                                     new[] {@"\"},
                                     StringSplitOptions.RemoveEmptyEntries
                                 )
                                 .Skip(1)
                );
            }
            catch
            {
                result = keyPath;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the <paramref name="keyPath" /> provided starts
        /// with the name of a Registry hive.
        /// </summary>
        /// <param name="keyPath">
        /// (Required.) String containing the fully-qualified pathname of a
        /// Registry key.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="keyPath" /> parameter is passed
        /// the path of a valid Registry key; <see langword="false" /> otherwise.
        /// </returns>
        public static bool StartsWithValidHiveName(this string keyPath)
        {
            if (string.IsNullOrWhiteSpace(keyPath))
                return false; // can't possibly meet the criteria

            if (!keyPath.StartsWith("HKEY_")) return false;

            var result = false;

            try
            {
                // Simply call the ToRegistryHive method. If the method does not
                // throw any exception, then we will assume that the method
                // worked correctly. If that is the case, then the result of
                // this method is true
                result = keyPath.ToRegistryHive() != 0;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Given a string containing the name of a Registry hive (i.e.,
        /// <c>HKEY_CLASSES_ROOT</c>), attempts to translate such a string into
        /// one of the <see cref="T:Microsoft.Win32.RegistryHive" /> values that
        /// corresponds to it.
        /// </summary>
        /// <param name="hiveName">
        /// (Required.) String containing the name of a Registry hive.
        /// </param>
        /// <returns>
        /// The <see cref="T:Microsoft.Win32.RegistryHive" /> value that
        /// corresponds to the hive name passed.
        /// <para />
        /// If a matching value cannot be found, then
        /// <see
        ///     cref="T:System.ArgumentOutOfRangeException" />
        /// is thrown.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if <paramref name="hiveName" /> is <see langword="null" />, whitespace,
        /// blank, or not the name of a Registry hive, or contains a
        /// fully-qualified pathname of a subkey.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if none of the <see cref="T:Microsoft.Win32.RegistryHive" />
        /// values corresponds to the value passed in <paramref name="hiveName" />.
        /// </exception>
        public static RegistryHive ToRegistryHive(this string hiveName)
        {
            if (string.IsNullOrWhiteSpace(hiveName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(hiveName)
                );

            if (!hiveName.StartsWith("HKEY_"))
                throw new ArgumentException(
                    "Value must be HKEY_CLASSES_ROOT, HKEY_CURRENT_USER etc.",
                    nameof(hiveName)
                );

            if (hiveName.Contains(@"\"))
                hiveName = hiveName.Split('\\')
                                   .First();

            var result = RegistryHive.CurrentUser;

            switch (hiveName)
            {
                case "HKEY_CLASSES_ROOT":
                    result = RegistryHive.ClassesRoot;
                    break;

                case "HKEY_CURRENT_CONFIG":
                    result = RegistryHive.CurrentConfig;
                    break;

                case "HKEY_CURRENT_USER":
                    result = RegistryHive.CurrentUser;
                    break;

                case "HKEY_DYN_DATA":
                    result = RegistryHive.DynData;
                    break;

                case "HKEY_LOCAL_MACHINE":
                    result = RegistryHive.LocalMachine;
                    break;

                case "HKEY_PERFORMANCE_DATA":
                    result = RegistryHive.PerformanceData;
                    break;

                case "HKEY_USERS":
                    result = RegistryHive.Users;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(hiveName), hiveName,
                        $"The value '{hiveName}' cannot be translated into a RegistryHive enumeration value, because a corresponding value does not exist."
                    );
            }

            return result;
        }
    }
}