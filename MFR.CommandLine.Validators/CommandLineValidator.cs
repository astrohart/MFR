using MFR.CommandLine.Models.Interfaces;
using MFR.CommandLine.Validators.Constants;
using MFR.CommandLine.Validators.Events;
using MFR.CommandLine.Validators.Interfaces;
using MFR.Directories.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.CommandLine.Validators
{
    /// <summary>
    /// Validates instances of
    /// <see
    ///     cref="T:MFR.CommandLine.CommandLineInfo" />
    /// to ensure they
    /// contain values that the application can work with.
    /// </summary>
    public class CommandLineValidator : ICommandLineValidator
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryValidator" />
        /// interface.
        /// </summary>
        private IRootDirectoryValidator _rootDirectoryValidator;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static CommandLineValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected CommandLineValidator() { }

        /// <summary>
        /// Gets a collection of strings, each of which contains an error message.
        /// </summary>
        public IList<string> Errors
        {
            get;
            private set;
        } = new List<string>();

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.CommandLine.Validators.CommandLineValidator" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static CommandLineValidator Instance
        {
            get;
        } = new CommandLineValidator();

        /// <summary>
        /// Gets a count of validation failures that occurred the last time the
        /// <see
        ///     cref="M:MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.IsValid" />
        /// method was called.
        /// </summary>
        public int ValidationFailures
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a collection of strings, each of which contains a warning message.
        /// </summary>
        public IList<string> VWarnings
        {
            get;
        } = new List<string>();

        /// <summary>
        /// Occurs once for each validation failure.
        /// </summary>
        public event CommandLineInfoInvalidEventHandler CommandLineInfoInvalid;

        /// <summary>
        /// Associates an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryValidator" />
        /// interface with this validator object.
        /// </summary>
        /// <param name="rootDirectoryValidator">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryValidator" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref
        ///     name="rootDirectoryValidator" />
        /// , is passed a <see langword="null" /> value.
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
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// that represents the object whose properties' values are to be validated.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="cmdInfo" /> object's
        /// properties contain valid values, according to the current validation rules.
        /// </returns>
        /// <remarks>
        /// If the <paramref name="cmdInfo" /> parameter is passed a
        /// <see langword="null" /> reference, this method raises the
        /// <see
        ///     cref="E:MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.CommandLineInfoInvalid" />
        /// event and then increments the value of the
        /// <see
        ///     cref="P:MFR.CommandLine.Validators.Interfaces.IValidator.ValidationFailures" />
        /// property, and then this method does no further processing.
        /// <para />
        /// Otherwise, the object whose reference is passed in the
        /// <paramref name="cmdInfo" /> parameter is validated.  The
        /// <see
        ///     cref="P:MFR.CommandLine.Validators.Interfaces.IValidator.ValidationFailures" />
        /// property is used to keep track of the number of validation failures that occur.
        /// <para />
        /// At the beginning of this method's execution, the
        /// <see
        ///     cref="P:MFR.CommandLine.Validators.Interfaces.IValidator.ValidationFailures" />
        /// property's value is set to zero.
        /// </remarks>
        public bool Validate(ICommandLineInfo cmdInfo)
        {
            ValidationFailures = 0;

            try
            {
                if (cmdInfo == null)
                    OnCommandLineInfoInvalid(
                        new CommandLineInfoInvalidEventArgs(
                            cmdInfo, CommandLineInvalidReason.IsNull
                        )
                    );

                /*
                 * Call an associated validator object in order to
                 * validate the RootDirectory property's value.  This
                 * validator raises its own set of validation-failure events.
                 * Therefore, if the validation fails here, we simply increment
                 * the count of validation failures but otherwise do nothing.
                 */
                if (!_rootDirectoryValidator?.Validate(cmdInfo.StartingFolder) ??
                    false)
                {
                    ValidationFailures +=
                        _rootDirectoryValidator?.ValidationFailures ?? 1;
                    Errors = Errors.Concat(_rootDirectoryValidator.Errors)
                                   .ToList();
                }

                if (string.IsNullOrWhiteSpace(cmdInfo.FindWhat))
                    OnCommandLineInfoInvalid(
                        new CommandLineInfoInvalidEventArgs(
                            cmdInfo, CommandLineInvalidReason.FindWhatBlank
                        )
                    );
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
        /// Raises the
        /// <see
        ///     cref="E:MFR.CommandLine.Validators.CommandLineValidator.CommandLineInfoInvalid" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs" />
        /// that contains the event data.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="e" />, is passed a <see langword="null" /> value.
        /// </exception>
        protected virtual void OnCommandLineInfoInvalid(
            CommandLineInfoInvalidEventArgs e)
        {
            if (e == null) throw new ArgumentNullException(nameof(e));

            Errors.Add(e.Message);
            ValidationFailures = Errors.Count;

            CommandLineInfoInvalid?.Invoke(this, e);
        }
    }
}