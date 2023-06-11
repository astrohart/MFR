using System.Windows.Forms;

namespace MFR.GUI.Constants
{
    /// <summary>
    /// Text to be used throughout the application.
    /// </summary>
    /// <remarks>
    /// This class contains static, computed properties, which may seem rather
    /// strange.
    /// <para />
    /// There is a reason for this: the static constructor of this class chokes
    /// otherwise.
    /// </remarks>
    public static class ProgramText
    {
        /// <summary>
        /// Gets a <see cref="T:System.String" /> that represents the company name
        /// associated with the application.
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
            => $"{ShortCompanyName} {ProductNameWithoutCompany}";

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that represents the product name that is
        /// associated with the application.
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
            => ProductName.Replace(ShortCompanyName, string.Empty).Trim();

        /// <summary>
        /// Gets the short name (without prefixes or suffixes) of the company
        /// that manufactured this tool.
        /// </summary>
        public static string ShortCompanyName
            => CompanyName.Replace(", LLC", string.Empty).Trim();
    }
}