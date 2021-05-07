using MFR.Objects.CommandLine.Validators.Constants;
using MFR.Objects.CommandLine.Validators.Constants.Generators;
using System;

namespace MFR.Objects.CommandLine.Validators.Events
{
    /// <summary>
    /// Provides information for CommandLineInfoInvalid event handlers.
    /// </summary>
    public class CommandLineInfoInvalidEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="cmdInfo">
        /// (Required.) Reference to that instance of
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.CommandLineInfo" />
        /// whose properties
        /// were found to contain invalid data.
        /// </param>
        /// <param name="reason">
        /// (Required.) A
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason" />
        /// value that explains why the validation failed.
        /// </param>
        public CommandLineInfoInvalidEventArgs(CommandLineInfo cmdInfo,
            CommandLineInvalidReason reason)
        {
            CmdInfo = cmdInfo;
            Reason = reason;
            Exception = null;
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="cmdInfo">
        /// (Required.) Reference to that instance of
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.CommandLineInfo" />
        /// whose properties
        /// were found to contain invalid data.
        /// </param>
        /// <param name="reason">
        /// (Required.) A
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason" />
        /// value that explains why the validation failed.
        /// </param>
        /// <param name="exception">
        /// (Required.) Reference to an instance of
        /// <see
        ///     cref="T:System.Exception" />
        /// that contains detailed error information.
        /// </param>
        public CommandLineInfoInvalidEventArgs(CommandLineInfo cmdInfo,
            CommandLineInvalidReason reason, Exception exception)
        {
            CmdInfo = cmdInfo;
            Reason = reason;
            Exception = exception;
        }

        /// <summary>
        /// Gets a reference to the instance of
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.CommandLineInfo" />
        /// whose properties
        /// were found to have invalid values.
        /// </summary>
        public CommandLineInfo CmdInfo
        {
            get;
        }

        /// <summary>
        /// Gets a reference to an instance of <see cref="T:System.Exception" />
        /// that describes an error in more detail.
        /// </summary>
        /// <remarks>
        /// This property might be <see langword="null" />.
        /// </remarks>
        public Exception Exception
        {
            get;
        }

        /// <summary>
        /// Gets a string containing an error message to be displayed to the user.
        /// </summary>
        public string Message
        {
            get {
                var result = GetCommandLineValidationFailedMessage.For
                    .ForReason(Reason);

                if (!string.IsNullOrWhiteSpace(result) &&
                    CommandLineInvalidReason.Unknown == Reason &&
                    Exception != null)
                    result += Environment.NewLine + Environment.NewLine +
                              Exception?.Message;

                return result;
            }
        }

        /// <summary>
        /// Gets a
        /// <see
        ///     cref="T:MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason" />
        /// value that corresponds to the reason that validation failed.
        /// </summary>
        public CommandLineInvalidReason Reason
        {
            get;
        }
    }
}