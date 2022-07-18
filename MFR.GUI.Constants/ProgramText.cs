using System.Windows.Forms;

namespace MFR.GUI.Constants
{
    /// <summary>
    /// Text to be used throughout the application.
    /// </summary>
    public static class ProgramText
    {
        /// <summary>
        /// Gets the title text that should be utilized for the main application window.
        /// </summary>
        public static string MainWindowTitle
            => $"{ShortCompanyName} {ProductNameWithoutCompany}";

        /// <summary>
        /// Gets the short name (without prefixes or suffixes) of the company
        /// that manufactured this tool.
        /// </summary>
        public static string ShortCompanyName
            => Application.CompanyName.Replace(", LLC", string.Empty);

        /// <summary>
        /// Gets the product name without the company name.
        /// </summary>
        private static string ProductNameWithoutCompany
            => Application.ProductName.Replace(ShortCompanyName, string.Empty);
    }
}
