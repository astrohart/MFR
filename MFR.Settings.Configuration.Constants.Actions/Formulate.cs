using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Constants.Actions
{
    /// <summary>
    /// Exposes static methods to formulate <see cref="T:System.String" /> values.
    /// </summary>
    public static class Formulate
    {
        /// <summary>
        /// Formulates the fully-qualified Registry key pathname of the Registry key under
        /// which the pathname of the configuration file is stored.
        /// </summary>
        /// <param name="companyName">
        /// (Required.) A <see cref="T:System.String" /> that represents the company name
        /// that is associated with the application.
        /// </param>
        /// <param name="productName">
        /// (Required.) A <see cref="T:System.String" /> that represents the product name
        /// that is associated with the application.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the fully-qualified
        /// Registry key pathname of the Registry key under which the pathname of the
        /// configuration file is stored.
        /// </returns>
        /// <remarks>
        /// If either of the <paramref name="companyName" /> or
        /// <paramref name="productName" /> parameters' arguments are passed blank values
        /// or <see langword="null" /> references, then this method returns the
        /// <see cref="F:System.String.Empty" /> value.
        /// </remarks>
        public static string ConfigurationFilePathKeyName(string companyName,
            string productName)
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