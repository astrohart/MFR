using Alphaleonis.Win32.Filesystem;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Providers.Actions
{
    /// <summary>
    /// Exposes static methods to formulate values in response to the values of
    /// parameters.
    /// </summary>
    public static class Formulate
    {
        /// <summary>
        /// Formulates the fully-qualified pathname of the folder that is the default
        /// folder for storing the application's configuration file.
        /// </summary>
        /// <param name="companyName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the company name associated with the application.
        /// </param>
        /// <param name="productName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the product name associated with the application.
        /// </param>
        /// <returns></returns>
        /// <remarks>
        /// If either the <paramref name="companyName" /> or the
        /// <paramref name="productName" /> parameters have the blank or
        /// <see langword="null" /> <see cref="T:System.String" /> passed to them as an
        /// argument, then this method returns the <see cref="F:System.String.Empty" />
        /// value.
        /// </remarks>
        public static string DefaultConfigDir(string companyName,
            string productName)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(companyName))
                    return result;
                if (string.IsNullOrWhiteSpace(productName)) return result;

                result = Path.Combine(
                    Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData
                        ), companyName
                    ), $@"{productName}\Config"
                );
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