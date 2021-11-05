using MFR.Registry.Helpers;
using MFR.Registry.Loaders.Interfaces;
using Microsoft.Win32;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Registry.Loaders
{
    public class StringLoader : Loader<string>, IStringLoader
    {
        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MFR.Registry.Loaders.StringLoader"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static StringLoader Instance
        {
            get;
        } = new StringLoader();

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static StringLoader() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected StringLoader() { }

        /// <summary>
        /// Obtains a data value from the system Registry key.
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
        /// This parameter is <see langword="null" /> by default.
        /// </param>
        /// <returns>
        /// Reference to an object containing the value data, or the value of the
        /// <paramref
        ///     name="defaultValue" />
        /// parameter if the value was not found or a
        /// problem occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="keyName" />, is blank.
        /// </exception>
        public override string FromRegistry(string keyName, string valueName,
            string defaultValue = default)
        {
            var result = string.Empty;

            if (string.IsNullOrWhiteSpace(keyName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(keyName)
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
                                    valueName, defaultValue,
                                    RegistryValueOptions.None
                                )
                                .ToString();
                }
                catch
                {
                    result = defaultValue;
                }
                finally
                {
                    key?.Close();
                    baseKey.Close();
                }

            return result;
        }
    }
}