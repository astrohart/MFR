using MFR.Registry.Helpers;
using Microsoft.Win32;
using System;
using System.Linq;
using xyLOGIX.Core.Extensions;

namespace MFR.Metadata.Registry
{
    /// <summary>
    /// Base class for the common methods, properties, fields, and events
    /// between implementers of the
    /// <see
    ///     cref="T:MFR.IRegQueryExpression" />
    /// interface and the
    /// <see cref="T:MFR.IRegOperationMetadata" /> interface.
    /// </summary>
    public class RegMetadataBase
    {
        /// <summary>
        /// String containing the fully-qualified pathname of a Registry key.
        /// </summary>
        private string _keyPath;

        /// <summary>
        /// Gets the <see cref="T:Microsoft.Win32.RegistryHive" /> value that
        /// corresponds to the hive specified by the user, either by default or explicitly.
        /// </summary>
        public RegistryHive Hive
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the path to the Registry key under which the desired
        /// data is stored.
        /// </summary>
        /// <remarks>
        /// Whenever the value of this property is updated, the value of the
        /// <see cref="P:MFR.IRegOperationMetadata.Hive" />
        /// property is updated to match.
        /// </remarks>
        public string KeyPath
        {
            get => _keyPath;
            set {
                _keyPath = value;
                DetermineRegistryHiveFromKeyPath(_keyPath);
            }
        }

        /// <summary>
        /// Attempts to parse the corresponding
        /// <see
        ///     cref="T:Microsoft.Win32.RegistryHive" />
        /// enumeration value from the
        /// <paramref name="keyPath" /> in the string provided.
        /// <para />
        /// Sets the value of the
        /// <see
        ///     cref="P:MFR.RegQueryExpression.Hive" />
        /// property
        /// to the result.
        /// </summary>
        /// <param name="keyPath">
        /// (Required.) String containing a fully-qualified pathname to a key in
        /// the system Registry.
        /// </param>
        /// <remarks>
        /// If the hive name cannot be parsed from <paramref name="keyPath" />,
        /// then the
        /// <see
        ///     cref="P:MFR.RegQueryExpression.Hive" />
        /// property
        /// is set to <see cref="T:Microsoft.Win32.RegistryHive.CurrentUser" />,
        /// except in the case where <paramref name="keyPath" /> is blank; if
        /// this the case, then this method does nothing.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if <paramref name="keyPath" /> is not a valid key pathname.
        /// </exception>
        protected void DetermineRegistryHiveFromKeyPath(string keyPath)
        {
            if (string.IsNullOrWhiteSpace(keyPath)) return; // nothing to do

            if (!keyPath.Contains(@"\"))
                throw new ArgumentException(
                    "Value must contain at least one backslash.",
                    nameof(keyPath)
                );

            if (!keyPath.StartsWith("HKEY_"))
            {
                Hive = RegistryHive.CurrentUser;
                return;
            }

            var hiveName = keyPath.SplitOn(@"\")
                                  .First();
            if (string.IsNullOrWhiteSpace(hiveName))
            {
                Hive = RegistryHive.CurrentUser;
                return;
            }

            Hive = hiveName.ToRegistryHive();
        }
    }
}