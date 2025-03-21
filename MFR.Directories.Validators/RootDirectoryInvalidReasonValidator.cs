﻿/*71b451a5-ec2a-4538-a74d-a520fd3c98ef
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
using MFR.Directories.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

namespace MFR.Directories.Validators
{
    /// <summary>
    /// Validates data variables whose values are purported to fall within the defined
    /// value set of the
    /// <see cref="T:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason" />
    /// enumeration.
    /// </summary>
    public class
        RootDirectoryInvalidReasonValidator :
        IRootDirectoryInvalidReasonValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RootDirectoryInvalidReasonValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RootDirectoryInvalidReasonValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryInvalidReasonValidator" />
        /// interface.
        /// </summary>
        public static IRootDirectoryInvalidReasonValidator Instance
        {
            [DebuggerStepThrough] get;
        } = new RootDirectoryInvalidReasonValidator();

        /// <summary>
        /// Determines whether the specified <paramref name="reason" /> is actually within
        /// the defined value set of the
        /// <see cref="T:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason" />
        /// enumeration.
        /// </summary>
        /// <param name="reason">
        /// (Required.) One of the
        /// <see cref="T:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason" />
        /// enumeration value(s) that is to be examined.
        /// </param>
        /// <remarks>
        /// If
        /// <see
        ///     cref="F:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason.Unknown" />
        /// is the value of the <paramref name="reason" /> parameter, then this method
        /// returns <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="reason" /> is
        /// within the defined value set of the
        /// <see cref="T:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason" />
        /// enumeration; <see langword="false" /> otherwise.
        /// </returns>
        public bool IsValid(RootDirectoryInvalidReason reason)
        {
            var result = false;

            try
            {
                // Dump the argument of the parameter, 'reason', to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"RootDirectoryInvalidReasonValidator.IsValid: reason = '{reason}'"
                );

                /*
                 * For cybersecurity reasons, and to defeat reverse-engineering,
                 * check the value of the 'reason' parameter to ensure that it
                 * is not set to a value outside the set of valid values defined
                 * by the MFR.Directories.Validators.Constants.RootDirectoryInvalidReason
                 * enumeration.
                 *
                 * In principle, since all C# enums devolve to integer values, a
                 * hacker could insert a different value into the CPU register that the
                 * 'reason' parameter is read from and thereby make this application
                 * do something it's not intended to do.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"RootDirectoryInvalidReasonValidator.IsValid: Checking whether the value of the 'reason' parameter, i.e., '{reason}', is within the defined value set of the MFR.Directories.Validators.Constants.RootDirectoryInvalidReason enumeration..."
                );

                // Check whether the value of the 'reason' parameter is within the defined value set of its 
                // enumerated data.  If this is not the case, then write an error message to the log
                // file, and then terminate the execution of this method while returning the default return
                // value.
                if (!Enum.IsDefined(typeof(RootDirectoryInvalidReason), reason))
                {
                    // The value of the 'reason' parameter is NOT within the defined value set 
                    // of the MFR.Directories.Validators.Constants.RootDirectoryInvalidReason enumeration.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** The value of the 'reason' parameter, i.e., '{reason}', is NOT within the defined value set of the MFR.Directories.Validators.Constants.RootDirectoryInvalidReason enumeration.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"RootDirectoryInvalidReasonValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"RootDirectoryInvalidReasonValidator.IsValid: *** SUCCESS *** The value of the 'reason' parameter, i.e., '{reason}', is within the defined value set of the MFR.Directories.Validators.Constants.RootDirectoryInvalidReason enumeration.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "RootDirectoryInvalidReasonValidator.IsValid: Checking whether the 'Unknown' value has NOT been specified for the 'reason' parameter..."
                );

                // Check whether the 'Unknown' value has been specified for the 'reason' parameter.  If this is the case, then
                // write an error message to the log file, and then terminate the execution 
                // of this method, returning the default return value in order to indicate
                // that this method failed.
                if (RootDirectoryInvalidReason.Unknown.Equals(reason))
                {
                    // The 'Unknown' value has been specified for the 'reason' parameter.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The 'Unknown' value has been specified for the 'reason' parameter.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"RootDirectoryInvalidReasonValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "RootDirectoryInvalidReasonValidator.IsValid: *** SUCCESS *** The 'Unknown' value has NOT been specified for the 'reason' parameter.  Proceeding..."
                );

                /*
                 * If we made it here with no Exception(s) getting caught, then
                 * assume that the value supplied to this method is valid.
                 */

                result = true;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"RootDirectoryInvalidReasonValidator.IsValid: Result = {result}"
            );

            return result;
        }
    }
}