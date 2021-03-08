using Microsoft.Win32;
using System;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
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
        /// Determines whether the <paramref name="keyPath" /> provided starts
        /// with the name of a Registry hive.
        /// </summary>
        /// <param name="keyPath">
        /// (Required.) String containing the fully-qualified pathname of a
        /// Registry key.
        /// </param>
        /// <returns>
        /// <c>true</c> if the <paramref name="keyPath" /> parameter is passed
        /// the path of a valid Registry key; <c>false</c> otherwise.
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
        /// Thrown if <paramref name="hiveName" /> is <c>null</c>, whitespace,
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