using PostSharp.Patterns.Threading;
using MFR.Directories.Validators.Constants;
using MFR.Directories.Validators.Constants.Generators;
using System;
using System.ComponentModel;

namespace MFR.Directories.Validators.Events
{
    /// <summary>
    /// Provides information for RootDirectoryInvalid event handlers.
    /// </summary>
[ExplicitlySynchronized]
    public class RootDirectoryInvalidEventArgs : CancelEventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="reason">
        /// (Required.) A
        /// <see
        ///     cref="T:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason" />
        /// value specifying why the validation failed.
        /// </param>
        /// <param name="rootDirectory">
        /// (Required.) String containing the value of the root directory
        /// specified by the user on the command line.
        /// </param>
        public RootDirectoryInvalidEventArgs(
            RootDirectoryInvalidReason reason,
            string rootDirectory)
        {
            Exception = null;
            Reason = reason;
            RootDirectory = rootDirectory;
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="reason">
        /// (Required.) A
        /// <see
        ///     cref="T:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason" />
        /// value specifying why the validation failed.
        /// </param>
        /// <param name="rootDirectory">
        /// (Required.) String containing the value of the root directory
        /// specified by the user on the command line.
        /// </param>
        /// <param name="exception">
        /// (Required.) An <see cref="T:System.Exception" /> that provides
        /// detailed error information.
        /// </param>
        public RootDirectoryInvalidEventArgs(
            RootDirectoryInvalidReason reason,
            string rootDirectory,
            Exception exception)
        {
            Exception = exception;
            Reason = reason;
            RootDirectory = rootDirectory;
        }

        /// <summary>
        /// Gets a <see cref="T:System.Exception" /> that describes the error in
        /// more detail.
        /// </summary>
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
                var result = GetRootDirectoryValidationFailedMessage.For
                    .ForReason(Reason)
                    .AndRootDirectoryValue(RootDirectory);

                if (!string.IsNullOrWhiteSpace(result) &&
                    RootDirectoryInvalidReason.Unknown == Reason &&
                    Exception != null)
                    result += Environment.NewLine + Environment.NewLine +
                              Exception?.Message;

                return result;
            }
        }

        /// <summary>
        /// Gets a
        /// <see
        ///     cref="T:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason" />
        /// value that specifies why the validation failed.
        /// </summary>
        public RootDirectoryInvalidReason Reason
        {
            get;
        }

        /// <summary>
        /// Gets the string containing the root directory that was specified by
        /// the user on the command line.
        /// </summary>
        public string RootDirectory
        {
            get;
        }
    }
}