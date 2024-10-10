using PostSharp.Patterns.Diagnostics;

namespace MFR.Directories.Validators.Constants.Generators
{
    /// <summary>
    /// Fluent builder object that crafts a validation failed message for a root
    /// directory that is also formatted with the value of the directory path
    /// that failed.
    /// </summary>
    public class GetRootDirectoryValidationFailedMessage
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static GetRootDirectoryValidationFailedMessage() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected GetRootDirectoryValidationFailedMessage() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Directories.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static GetRootDirectoryValidationFailedMessage For
        {
            get;
        } = new GetRootDirectoryValidationFailedMessage();

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
        /// Formats the validation-failure message obtained with a call to the
        /// <see
        ///     cref="M:MFR.CommandLine.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.ValidationFailedReason" />
        /// method with the value attempted to be passed by the user.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the value to be substituted in the
        /// message format.
        /// </param>
        /// <returns>
        /// Message formatted with the string specified by
        /// <paramref
        ///     name="value" />
        /// ; empty if the
        /// <see
        ///     cref="P:MFR.Directories.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.MessageFormat" />
        /// property has not yet been initialized.
        /// </returns>
        /// <remarks>
        /// Before this method can be called, the
        /// <see
        ///     cref="M:MFR.CommandLine.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.ValidationFailedReason" />
        /// method must first be called and then chained with a call to this one.
        /// </remarks>
        public string AndRootDirectoryValue(string value)
            => string.IsNullOrWhiteSpace(MessageFormat)
                ? MessageFormat
                : string.Format(MessageFormat, value);

        /// <summary>s
        /// Initializes the
        /// <see cref="P:MFR.Directories.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.MessageFormat" />
        /// property with the message format string, if any, that corresponds to
        /// the
        /// <see
        ///     cref="T:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason" />
        /// value passed in the <paramref name="reason" /> parameter.
        /// </summary>
        /// <param name="reason">
        /// A
        /// <see
        ///     cref="T:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason" />
        /// value that indicates the reason why validation failed.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// After calling this method, callers must chain it with a call to the
        /// <see
        ///     cref="M:MFR.CommandLine.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.AndRootDirectoryValue" />
        /// method before the return value can be assigned to a
        /// <see cref="T:System.String" />
        /// -valued message property.
        /// </remarks>
        public GetRootDirectoryValidationFailedMessage ForReason(
            RootDirectoryInvalidReason reason)
        {
            MessageFormat = string.Empty; // just to make extra sure

            switch (reason)
            {
                case RootDirectoryInvalidReason.DoesntContainSolution:
                    MessageFormat = RootDirectoryValidationMessages
                        .RootDirectoryDoesntContainSolution;
                    break;

                case RootDirectoryInvalidReason.DoesntExist:
                    MessageFormat = RootDirectoryValidationMessages
                        .RootDirectoryDoesntExist;
                    break;

                case RootDirectoryInvalidReason.Unknown:
                    MessageFormat = RootDirectoryValidationMessages
                        .UnknownRootDirectoryValidationFailedError;
                    break;

                default:
                    MessageFormat = string.Empty;
                    break;
            }

            return this;
        }
    }
}