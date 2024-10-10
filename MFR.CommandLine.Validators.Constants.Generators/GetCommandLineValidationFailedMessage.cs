using PostSharp.Patterns.Diagnostics;

namespace MFR.CommandLine.Validators.Constants.Generators
{
    /// <summary>
    /// Fluent builder object that crafts a validation failed message for a root
    /// directory that is also formatted with the value of the directory path
    /// that failed.
    /// </summary>
    public class GetCommandLineValidationFailedMessage
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static GetCommandLineValidationFailedMessage() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected GetCommandLineValidationFailedMessage() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static GetCommandLineValidationFailedMessage For
        {
            get;
        } = new GetCommandLineValidationFailedMessage();

        /// <summary>
        /// Gets or sets a string that contains the formatted validation-failure message.
        /// </summary>
        [Log(AttributeExclude = true)]
        private string MessageFormat
        {
            get;
            set;
        } = string.Empty;

        /// <summary>
        /// Gets a user-friendly message string to be displayed when a
        /// command-line argument object fails one or more validation rules.
        /// </summary>
        /// <param name="reason">
        /// One of the
        /// <see
        ///     cref="T:MFR.CommandLine.Validators.Constants.CommandLineInvalidReason" />
        /// values that specifies the reason for the failure.
        /// </param>
        /// <returns>
        /// String containing the user-friendly message that corresponds to the
        /// <paramref name="reason" /> that was given, or blank if nothing can be found.
        /// </returns>
        public string ForReason(CommandLineInvalidReason reason)
        {
            MessageFormat = string.Empty; // just to make extra sure

            switch (reason)
            {
                case CommandLineInvalidReason.IsNull:
                    MessageFormat = CommandLineValidationMessages
                        .CommandLineInfoIsNull;
                    break;

                case CommandLineInvalidReason.FindWhatBlank:
                    MessageFormat = CommandLineValidationMessages.FindWhatBlank;
                    break;

                case CommandLineInvalidReason
                    .RootDirectoryDoesntContainSolution:
                    MessageFormat = CommandLineValidationMessages
                        .RootDirectoryDoesntContainSolution;
                    break;

                case CommandLineInvalidReason.RootDirectoryDoesntExist:
                    MessageFormat = CommandLineValidationMessages
                        .RootDirectoryDoesntExist;
                    break;

                default:
                    MessageFormat = CommandLineValidationMessages
                        .UnknownCommandLineValidationFailedError;
                    break;
            }

            return MessageFormat;
        }
    }
}