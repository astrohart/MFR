/*71b451a5-ec2a-4538-a74d-a520fd3c98ef
 * # xyLOGIX Project File Renamer License
 * 
 * This software and associated documentation files (the "Software") are the exclusive property of xyLOGIX, LLC ("xyLOGIX"), a Tennessee Limited Liability Company. Copyright © 2025 by 
 * xyLOGIX, LLC.  All rights reserved.
 * 
 * ## License Grant
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this Software, to use the Software solely for the purpose of evaluating its functionality and performance.
 * This license does not grant the right to modify, distribute, sublicense, or sell copies of the Software, nor to use the Software for any commercial purpose.
 * 
 * ## Restrictions
 * 
 * 1.  No Distribution: You may not distribute, sublicense, or sell copies of the Software, in whole or in part, to any third party.
 * 2.  No Modification:  You may not modify, adapt, or create derivative works of the Software.
 * 3.  No Reverse Engineering:  You may not reverse engineer, decompile, or disassemble the Software.
 * 4.  No Commercial Use:  You may not use the Software for any commercial purpose without the prior written consent of xyLOGIX.
 * 5.  No Removal of Notices:  You may not remove or alter any proprietary notices, labels, or marks on the Software.
 * 
 * ## Intellectual Property Rights
 * 
 * All intellectual property rights, including but not limited to copyrights, patents, trademarks, and trade secrets, in and to the Software are and shall remain the exclusive property of xyLOGIX.
 * This license does not transfer any ownership rights in the Software to you.
 * 
 * ## Disclaimer of Warranty
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, AND NON-INFRINGEMENT. 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM, OUT OF, OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
 * OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 * ## Limitation of Liability
 * 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THE SOFTWARE
 * EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * ## Termination
 * 
 * This license is effective until terminated.  Your rights under this license will terminate automatically without notice from xyLOGIX if you fail to comply with any term(s) of this license. Upon termination, you must
 * cease all use of the Software and destroy all copies, full or partial, of the Software.
 * 
 * ## Governing Law
 *
 * This license shall be governed by and construed in accordance with the laws of the State of Washington, without regard to its conflict of laws principles and without regard to the principle of contra proferentem.
 *
 * ## Contact Information
 *
 * For inquiries regarding this license, please contact:
 *
 * xyLOGIX, LLC
 * info@xylogix.net
 */using Microsoft.Win32;
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
        /// case that such a value exists for every Registry key, this a
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

            bool result;

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