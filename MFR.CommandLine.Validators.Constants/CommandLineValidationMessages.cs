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