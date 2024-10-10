using System;
using xyLOGIX.Core.Debug;

namespace MFR.Paths.Config.Provider.Actions
{
    /// <summary>
    /// Exposes static methods to formulate data values from other data values.
    /// </summary>
    public static class Formulate
    {
        /// <summary>
        /// Attempts to get the fully-qualified Registry key pathname of the key storing
        /// the pathnames of the profile list and configuration files.
        /// </summary>
        /// <param name="companyName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the company name associated with the application.
        /// </param>
        /// <param name="productName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the product name associated with the application.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> that contains the
        /// fully-qualified Registry key pathname of the key storing the pathnames of the
        /// profile list and configuration files.
        /// </returns>
        /// <remarks>
        /// If either of the required parameters, <paramref name="companyName" /> and
        /// <paramref name="productName" /> are passed the blank or <see langword="null" />
        /// value as an argument, then this method returns the
        /// <see cref="F:System.String.Empty" /> value.
        /// <para />
        /// The <see cref="F:System.String.Empty" /> value is also returned if an error
        /// occurs during the processing of the operation.
        /// </remarks>
        public static string ConfigFilePathRegistryKeyPathname(
            string companyName, string productName)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(companyName)) return result;
                if (string.IsNullOrWhiteSpace(productName)) return result;

                result =
                    $@"HKEY_CURRENT_USER\SOFTWARE\{companyName}\{productName}\Paths";
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}