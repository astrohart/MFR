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

using MFR.GUI.Dialogs.Factories;
using MFR.GUI.Launchers.Dialogs.Interfaces;
using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using MFR.GUI.Launchers.Dialogs.Results.Factories;
using MFR.GUI.Launchers.Dialogs.Results.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Launchers.Dialogs
{
    /// <summary>
    /// Provides helper methods to launch the error dialog.
    /// </summary>
    /// <remarks>
    /// The error dialog typically is utilized to provide the user with a
    /// helpful way to deal with, basically, otherwise-unhandled exceptions, and
    /// to send the resulting error information to xyLOGIX.
    /// </remarks>
    public class ErrorReportDialogLauncher : IErrorReportDialogLauncher
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static ErrorReportDialogLauncher() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected ErrorReportDialogLauncher() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.GUI.Launchers.Dialogs.ErrorReportDialogLauncher" />.
        /// </summary>
        public static IErrorReportDialogLauncher Instance
        {
            [DebuggerStepThrough] get;
        } = new ErrorReportDialogLauncher();

        /// <summary>
        /// Displays a user-friendly dialog box that assists the user with
        /// recovering from an application-specific error i.e., an
        /// otherwise-unhandled exception.
        /// </summary>
        /// <param name="parms">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams" />
        /// interface.
        /// <para />
        /// This object describes the values of the parameters this method needs to launch
        /// the dialog.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults" />
        /// interface that describes the results of the user's choices in the dialog box.
        /// </returns>
        public IErrorReportDialogLaunchResults Launch(
            IErrorReportDialogLaunchParams parms)
        {
            IErrorReportDialogLaunchResults results;

            try
            {
                using (var dialog = MakeNewErrorReportDialog.FromScratch()
                    .ForException(parms.Exception))
                {
                    if (parms.ViewHandler != null)
                        dialog.AttachViewErrorReportRequestedEventHandler(
                            parms.ViewHandler
                        );
                    if (parms.SendHandler != null)
                        dialog.AttachSendErrorReportRequestedEventHandler(
                            parms.SendHandler
                        );

                    var dialogResult = parms.Owner == null
                        ? dialog.ShowDialog()
                        : dialog.ShowDialog(parms.Owner);

                    results =
                        MakeNewErrorReportDialogLaunchResults
                            .WithPropertyValues(
                                dialogResult, dialog.Exception,
                                dialog.ErrorReportContents,
                                dialog.ReproductionSteps
                            );
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                results = null;
            }

            return results;
        }
    }
}