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

using MFR.Directories.Validators.Constants;
using MFR.Directories.Validators.Constants.Generators;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using System.ComponentModel;
using System.Diagnostics;

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
            string rootDirectory
        )
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
        [Log(AttributeExclude = true)]
        public RootDirectoryInvalidEventArgs(
            RootDirectoryInvalidReason reason,
            string rootDirectory,
            Exception exception
        )
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
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets a string containing an error message to be displayed to the user.
        /// </summary>
        public string Message
        {
            [DebuggerStepThrough]
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
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets the string containing the root directory that was specified by
        /// the user on the command line.
        /// </summary>
        public string RootDirectory
        {
            [DebuggerStepThrough] get;
        }
    }
}