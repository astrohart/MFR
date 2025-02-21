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