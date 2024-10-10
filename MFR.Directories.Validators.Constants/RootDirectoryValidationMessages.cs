using MFR.Directories.Validators.Constants.Properties;

namespace MFR.Directories.Validators.Constants
{
    /// <summary>
    /// Provides access to format strings that can be used to display
    /// user-friendly error messages when validation of a root directory
    /// pathname fails.
    /// </summary>
    public static class RootDirectoryValidationMessages
    {
        /// <summary>
        /// Looks up a localized string similar to The specified starting directory, &apos;{0}&apos;, exists on disk but does not contain a Visual Studio Solution (*.sln) file.
        ///
        ///Provide the pathname of a folder that contains a <c>*.sln</c> file in its topmost level, and then try to run this application again..
        /// </summary>
        public static string RootDirectoryDoesntContainSolution
        {
            get;
        } = Resources.RootDirectoryDoesntContainSolution;

        /// <summary>
        /// Looks up a localized string similar to The specified starting
        /// directory, '{0}', exists on disk but does not contain a Visual
        /// Studio Solution (*.sln) file..
        /// </summary>
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
        /// exists on the file system and contains a Visual Studio Solution (*.sln) file..
        /// </summary>
        public static string RootDirectoryValid
        {
            get;
        } = Resources.RootDirectoryValid;

        /// <summary>
        /// Looks up a localized string similar to Due to an error we didn't
        /// expect, we could not perform validation on the path '{0}' that was
        /// provided for the starting folder..
        /// </summary>
        public static string UnknownRootDirectoryValidationFailedError
        {
            get;
        } = Resources.UnknownRootDirectoryValidationFailedError;
    }
}