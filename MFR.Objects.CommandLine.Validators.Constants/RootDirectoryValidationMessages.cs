using MFR.Objects.CommandLine.Validators.Constants.Properties;

namespace MFR.Objects.CommandLine.Validators.Constants
{
    /// <summary>
    /// Provides access to format strings that can be used to display
    /// user-friendly error messages when validation of a root directory
    /// pathname fails.
    /// </summary>
    public static class RootDirectoryValidationMessages
    {
        /// <summary>
        /// Looks up a localized string similar to The specified starting
        /// directory, '{0}', exists on disk but does not contain a Visual
        /// Studio Solution (*.sln) file..
        /// </summary>

        public static string RootDirectoryDoesntContainSolution
        {
            get;
        } = Resources.RootDirectoryDoesntContainSolution;

        /// <summary>
        /// Looks up a localized string similar to The specified starting
        /// directory, '{0}', does not exist..
        /// </summary>
        public static string RootDirectoryDoesntExist
        {
            get;
        } = Resources.RootDirectoryDoesntExist;

        /// <summary>
        /// Looks up a localized string similar to The specified directory
        /// exists on the disk and contains a Visual Studio Solution (*.sln) file..
        /// </summary>
        public static string RootDirectoryValid
        {
            get;
        } = Resources.RootDirectoryValid;
    }
}