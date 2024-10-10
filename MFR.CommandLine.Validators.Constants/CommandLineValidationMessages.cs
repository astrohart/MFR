using MFR.CommandLine.Validators.Constants.Properties;

namespace MFR.CommandLine.Validators.Constants
{
    /// <summary>
    /// Provides access to format strings that can be used to display
    /// user-friendly error messages when validation of a
    /// <see
    ///     cref="T:MFR.CommandLine.CommandLineInfo" />
    /// instance fails.
    /// </summary>
    public static class CommandLineValidationMessages
    {
        /// <summary>
        /// Looks up a localized string similar to The command-line arguments
        /// could not be parsed..
        /// </summary>
        public static string CommandLineInfoIsNull
        {
            get;
        } = Resources.CommandLineInfoIsNull;

        /// <summary>
        /// Looks up a localized string similar to The &apos;Find What&apos; value is
        /// blank, or it contains only whitespace..
        /// </summary>
        public static string FindWhatBlank
        {
            get;
        } = Resources.FindWhatBlank;

        /// <summary>
        /// Looks up a localized string similar to The specified starting directory, &apos;
        /// {0}&apos;, exists on disk but does not contain a Visual Studio Solution (*.sln)
        /// file.
        /// m  the pathname of a folder that contains a *.sln file in its topmost level,
        /// and then try to run this application again..
        /// </summary>
        public static string RootDirectoryDoesntContainSolution
        {
            get;
        } = Resources.RootDirectoryDoesntContainSolution;

        /// <summary>
        /// Looks up a localized string similar to The specified starting directory, &apos;
        /// {0}&apos;, does not exist.
        /// Check the value passed on the command line, and then try again..
        /// </summary>
        public static string RootDirectoryDoesntExist
        {
            get;
        } = Resources.RootDirectoryDoesntExist;

        /// <summary>
        /// Looks up a localized string similar to Due to an error we didn't
        /// expect, we could not perform validation on the command-line
        /// arguments supplied to this application..
        /// </summary>
        public static string UnknownCommandLineValidationFailedError
        {
            get;
        } = Resources.UnknownCommandLineValidationFailedError;
    }
}