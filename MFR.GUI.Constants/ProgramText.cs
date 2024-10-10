using System;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Constants
{
    /// <summary>
    /// Text to be used throughout the application.
    /// </summary>
    public static class ProgramText
    {
        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that represents the company name
        /// that is associated with the application.
        /// </summary>
        public static string CompanyName
        {
            get;
            set;
        } = Application.CompanyName;

        /// <summary>
        /// Gets the title text that should be utilized for the main application window.
        /// </summary>
        public static string MainWindowTitle
        {
            get {
                var result = string.Empty;

                try
                {
                    if (string.IsNullOrWhiteSpace(ShortCompanyName))
                        return result;
                    if (string.IsNullOrWhiteSpace(ProductNameWithoutCompany))
                        return result;

                    result = $"{ShortCompanyName} {ProductNameWithoutCompany}";
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

        /// <summary>
        /// Gets or set a <see cref="T:System.String" /> that represents the product name
        /// that is associated with the application.
        /// </summary>
        public static string ProductName
        {
            get;
            set;
        } = Application.ProductName;

        /// <summary>
        /// Gets the product name without the company name.
        /// </summary>
        public static string ProductNameWithoutCompany
        {
            get {
                var result = string.Empty;

                try
                {
                    if (string.IsNullOrWhiteSpace(ProductName))
                        return result;
                    if (string.IsNullOrWhiteSpace(ShortCompanyName))
                        return ProductName;

                    result = ProductName.Replace(ShortCompanyName, string.Empty)
                                        .Trim();
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

        /// <summary>
        /// Gets the short name (without prefixes or suffixes) of the company
        /// that manufactured this tool.
        /// </summary>
        public static string ShortCompanyName
        {
            get {
                var result = string.Empty;

                try
                {
                    if (string.IsNullOrWhiteSpace(CompanyName))
                        return result;

                    result = CompanyName.Replace(", LLC", string.Empty)
                                        .Trim();
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
}