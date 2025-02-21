/*71b451a5-ec2a-4538-a74d-a520fd3c98ef
 * # xyLOGIX Project File Renamer License
 * 
 * This software and associated documentation files (the "Software") are the exclusive property of xyLOGIX, LLC ("xyLOGIX"), a Tennessee Limited Liability Company. Copyright © 2025 by 
 * xyLOGIX, LLC.  All rights reserved.
 * 
 * ## License Grant
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this Software, to use the Software solely for the purpose of evaluating its functionality and performance.
 * This license does not grant the right to modify, distribute, sublicense, or sell copies of the Software, nor to use the Software for any commercial purpose.
 * 
 * ## Restrictions
 * 
 * 1.  No Distribution: You may not distribute, sublicense, or sell copies of the Software, in whole or in part, to any third party.
 * 2.  No Modification:  You may not modify, adapt, or create derivative works of the Software.
 * 3.  No Reverse Engineering:  You may not reverse engineer, decompile, or disassemble the Software.
 * 4.  No Commercial Use:  You may not use the Software for any commercial purpose without the prior written consent of xyLOGIX.
 * 5.  No Removal of Notices:  You may not remove or alter any proprietary notices, labels, or marks on the Software.
 * 
 * ## Intellectual Property Rights
 * 
 * All intellectual property rights, including but not limited to copyrights, patents, trademarks, and trade secrets, in and to the Software are and shall remain the exclusive property of xyLOGIX.
 * This license does not transfer any ownership rights in the Software to you.
 * 
 * ## Disclaimer of Warranty
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, AND NON-INFRINGEMENT. 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM, OUT OF, OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
 * OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 * ## Limitation of Liability
 * 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THE SOFTWARE
 * EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * ## Termination
 * 
 * This license is effective until terminated.  Your rights under this license will terminate automatically without notice from xyLOGIX if you fail to comply with any term(s) of this license. Upon termination, you must
 * cease all use of the Software and destroy all copies, full or partial, of the Software.
 * 
 * ## Governing Law
 *
 * This license shall be governed by and construed in accordance with the laws of the State of Washington, without regard to its conflict of laws principles and without regard to the principle of contra proferentem.
 *
 * ## Contact Information
 *
 * For inquiries regarding this license, please contact:
 *
 * xyLOGIX, LLC
 * info@xylogix.net
 */

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
    /// Validates instances of <see cref="T:MFR.CommandLine.CommandLineInfo" /> to
    /// ensure they contain values that the application can work with.
    /// </summary>
    public class CommandLineValidator : ICommandLineValidator
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator" />
        /// interface.
        /// </summary>
        private IRootDirectoryPathValidator _rootDirectoryPathValidator;

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
        ///     cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator" />
        /// interface with this validator object.
        /// </summary>
        /// <param name="rootDirectoryPathValidator">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref
        ///     name="rootDirectoryPathValidator" />
        /// , is passed a <see langword="null" /> value.
        /// </exception>
        public ICommandLineValidator AssociateWithRootDirectoryPathValidator(
            IRootDirectoryPathValidator rootDirectoryPathValidator
        )
        {
            _rootDirectoryPathValidator = rootDirectoryPathValidator ??
                                          throw new ArgumentNullException(
                                              nameof(rootDirectoryPathValidator)
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
            var result = false;

            ValidationFailures = 0;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CommandLineValidator.Validate: Attempting to validate the values passed by the user on the command line..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CommandLineValidator.Validate: Checking whether the 'cmdInfo' method parameter has a null reference for a value..."
                );

                // Check to see if the required parameter, cmdInfo, is null. If it is, send an
                // error to the log file and quit, returning the default return value of this
                // method.
                if (cmdInfo == null)
                {
                    // the parameter cmdInfo is required.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "CommandLineValidator.Validate: *** ERROR *** A null reference was passed for the 'cmdInfo' method parameter.  Stopping."
                    );

                    OnCommandLineInfoInvalid(
                        new CommandLineInfoInvalidEventArgs(
                            cmdInfo, CommandLineInvalidReason.IsNull
                        )
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CommandLineValidator.Validate: *** SUCCESS *** We have been passed a valid object reference for the 'cmdInfo' method parameter."
                );

                // Dump the value of the property, cmdInfo.StartingFolder, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"CommandLineValidator.Validate: cmdInfo.StartingFolder = '{cmdInfo.StartingFolder}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CommandLineValidator.Validate: Validating the starting folder that we were passed..."
                );

                /*
                 * Call an associated validator object in order to
                 * validate the RootDirectory property's value.  This
                 * validator raises its own set of validation-failure events.
                 * Therefore, if the validation fails here, we simply increment
                 * the count of validation failures but otherwise do nothing.
                 */
                if (!_rootDirectoryPathValidator?.Validate(
                        cmdInfo.StartingFolder
                    ) ?? false)
                {
                    ValidationFailures +=
                        _rootDirectoryPathValidator?.ValidationFailures ?? 1;
                    Errors = Errors.Concat(_rootDirectoryPathValidator.Errors)
                                   .ToList();
                }

                result = ValidationFailures == 0;
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

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"CommandLineValidator.Validate: Result = {result}"
            );

            return result;
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
            CommandLineInfoInvalidEventArgs e
        )
        {
            if (e == null) throw new ArgumentNullException(nameof(e));

            Errors.Add(e.Message);
            ValidationFailures = Errors.Count;

            CommandLineInfoInvalid?.Invoke(this, e);
        }
    }
}