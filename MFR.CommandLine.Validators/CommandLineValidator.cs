using MFR.CommandLine.Models.Interfaces;
using MFR.CommandLine.Validators.Constants;
using MFR.CommandLine.Validators.Events;
using MFR.CommandLine.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.CommandLine.Validators
{
    /// <summary>
    /// Validates instances of <see
    /// cref="T:MFR.CommandLine.CommandLineInfo"/> to ensure they
    /// contain values that the application can work with.
    /// </summary>
    public class CommandLineValidator : ICommandLineValidator
    {
        /// <summary>
        /// Reference to an instance of an object that implements the <see
        /// cref="T:MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator"/> interface.
        /// </summary>
        private IRootDirectoryValidator _rootDirectoryValidator;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static CommandLineValidator()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected CommandLineValidator()
        {
        }

        /// <summary>
        /// Occurs once for each validation failure.
        /// </summary>
        public event CommandLineInfoInvalidEventHandler CommandLineInfoInvalid;

        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MFR.CommandLine.Validators.CommandLineValidator"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static CommandLineValidator Instance
        {
            get;
        } = new CommandLineValidator();

        /// <summary>
        /// Gets a count of validation failures that occurred the last time the
        /// <see
        /// cref="M:MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.IsValid"/>
        /// method was called.
        /// </summary>
        public int ValidationFailures
        {
            get;
            private set;
        }

        /// <summary>
        /// Associates an instance of an object that implements the <see
        /// cref="T:MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator"/>
        /// interface with this validator object.
        /// </summary>
        /// <param name="rootDirectoryValidator">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see
        /// cref="T:MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator"/> interface.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref
        /// name="rootDirectoryValidator"/> , is passed a <see langword="null"/> value.
        /// </exception>
        public ICommandLineValidator AssociateWithRootDirectoryValidator(
            IRootDirectoryValidator rootDirectoryValidator)
        {
            _rootDirectoryValidator = rootDirectoryValidator ??
                                      throw new ArgumentNullException(
                                          nameof(rootDirectoryValidator)
                                      );

            return this;
        }

        /// <summary>
        /// Gets a value indicating whether the specified
        /// <paramref
        ///     name="cmdInfo" />
        /// refers to a valid set of command-line argument values.
        /// </summary>
        /// <param name="cmdInfo">
        /// (Required.) Reference to an instance of
        /// <see
        ///     cref="T:MFR.CommandLine.CommandLineInfo" />
        /// that is the
        /// object to be validated.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="cmdInfo" /> object's
        /// properties contain valid values.
        /// </returns>
        public bool IsValid(ICommandLineInfo cmdInfo)
        {
            ValidationFailures = 0;

            try
            {
                if (cmdInfo == null)
                {
                    OnCommandLineInfoInvalid(
                        new CommandLineInfoInvalidEventArgs(
                            cmdInfo, CommandLineInvalidReason.IsNull
                        )
                    );

                    ValidationFailures++;
                }

                /*
                 * Call an associated validator object in order to
                 * validate the RootDirectory property's value.  This
                 * validator raises its own set of validation-failure events.
                 * Therefore, if the validation fails here, we simply increment
                 * the count of validation failures but otherwise do nothing.
                 */
                if (!_rootDirectoryValidator?.IsValid(cmdInfo.RootDirectory) ??
                    false)
                    ValidationFailures +=
                        _rootDirectoryValidator?.ValidationFailures ?? 1;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                OnCommandLineInfoInvalid(
                    new CommandLineInfoInvalidEventArgs(
                        cmdInfo, CommandLineInvalidReason.Unknown
                    )
                );

                ValidationFailures++;
            }

            return ValidationFailures == 0;
        }

        /// <summary>
        /// Raises the <see
        /// cref="E:MFR.CommandLine.Validators.CommandLineValidator.CommandLineInfoInvalid"/> event.
        /// </summary>
        /// <param name="e">
        /// A <see
        /// cref="T:MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs"/>
        /// that contains the event data.
        /// </param>
        protected virtual void OnCommandLineInfoInvalid(
            CommandLineInfoInvalidEventArgs e)
            => CommandLineInfoInvalid?.Invoke(this, e);
    }
}