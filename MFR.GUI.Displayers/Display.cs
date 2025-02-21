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
 */using MFR.Errors.Reports.Commands.Constants;
using MFR.Errors.Reports.Commands.Factories;
using MFR.GUI.Dialogs.Constants;
using MFR.GUI.Dialogs.Events;
using MFR.GUI.Launchers.Dialogs.Actions.Constants;
using MFR.GUI.Launchers.Dialogs.Actions.Factories;
using MFR.GUI.Launchers.Dialogs.Factories;
using MFR.GUI.Launchers.Dialogs.Params.Factories;
using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using MFR.GUI.Launchers.Dialogs.Results.Interfaces;
using System;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Displayers
{
    /// <summary>
    /// Contains methods to display dialog boxes.
    /// </summary>
    public static class Display
    {
        /// <summary>
        /// Launches a dialog box to display a report that an error occurred.
        /// </summary>
        /// <param name="exception">
        /// A <see cref="T:System.Exception" /> that describes the
        /// error to be reported.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="exception" />, is passed a <see langword="null" />
        /// value.
        /// </exception>
        /// <remarks>
        /// This method invokes a user-friendly dialog box that prompts the user
        /// to type in what happened that led to the error encountered.
        /// <para />
        /// This method associates the
        /// <see cref="M:MFR.GUI.Displayers.Display.OnViewErrorReportRequested" /> method
        /// as a handler of the
        /// <see cref="E:MFR.GUI.Dialogs.ErrorReportDialog.ViewErrorReportRequested" />
        /// event.
        /// </remarks>
        public static void ErrorReportDialog(Exception exception)
        {
            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Display.ErrorReportDialog: Checking whether the variable 'exception' has a null reference for a value..."
                );

                // Check to see if the variable, exception, is null. If it is, send an error to the log file and quit, returning from the method.
                if (exception == null)
                {
                    // the variable exception is required to have a valid object reference.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "Display.ErrorReportDialog: *** ERROR ***  The 'exception' variable has a null reference.  Stopping..."
                    );

                    // stop.
                    return;
                }

                // We can use the variable, exception, because it's not set to a null reference.
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Display.ErrorReportDialog: *** SUCCESS *** The 'exception' variable has a valid object reference for its value.  Proceeding..."
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            if (exception == null)
                throw new ArgumentNullException(nameof(exception));

            GetDialogLauncherAction
                .For<IErrorReportDialogLaunchParams,
                    IErrorReportDialogLaunchResults>(
                    DialogLauncherActionType.LaunchErrorReportDialog
                )
                .WithInput(
                    (IErrorReportDialogLaunchParams)
                    MakeNewErrorReportDialogLaunchParams.FromScratch()
                        .ForException(exception)
                        .AndAttachViewErrorReportRequestedEventHandler(
                            OnViewErrorReportRequested
                        )
                        .AndAttachSendErrorReportRequestedEventHandler(
                            OnSendErrorReportRequested
                        )
                        .AndOwnerWindow(Application.OpenForms[0])
                )
                .Execute();
        }

        /// <summary>
        /// Launches a dialog box to display a report that an error occurred.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// The object that implements this interface represents the parent window of the
        /// dialog box.
        /// </param>
        /// <param name="exception">
        /// A <see cref="T:System.Exception" /> that describes the
        /// error to be reported.
        /// </param>
        /// <remarks>
        /// This method also associates the
        /// <see cref="M:MFR.GUI.Displayers.Display.OnViewErrorReportRequested" /> method
        /// as the handler for the
        /// <see cref="E:MFR.GUI.Dialogs.ErrorReportDialog.ViewErrorReportRequested" />
        /// event.
        /// </remarks>
        public static void ErrorReportDialog(
            IWin32Window owner,
            Exception exception
        )
            => GetDialogLauncherAction
               .For<IErrorReportDialogLaunchParams,
                   IErrorReportDialogLaunchResults>(
                   DialogLauncherActionType.LaunchErrorReportDialog
               )
               .WithInput(
                   (IErrorReportDialogLaunchParams)
                   MakeNewErrorReportDialogLaunchParams.FromScratch()
                       .ForException(exception)
                       .AndAttachViewErrorReportRequestedEventHandler(
                           OnViewErrorReportRequested
                       )
                       .AndOwnerWindow(owner)
               )
               .Execute();

        /// <summary>
        /// Shows a Help window that explains Profiles to the user.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// The object that implements this interface represents the parent window of the
        /// dialog box.
        /// </param>
        public static void HelpProfileExplainerDialog(IWin32Window owner)
            => GetHelpProfileExplainerDialogLauncher.SoleInstance()
                                                    .Launch(owner);

        /// <summary>
        /// Shows a Help window that explains Profiles to the user.
        /// </summary>
        public static void HelpProfileExplainerDialog()
            => GetHelpProfileExplainerDialogLauncher.SoleInstance()
                                                    .Launch(
                                                        Application.OpenForms[0]
                                                    );

        /// <summary>
        /// Launches a dialog box to display a report that an error occurred.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> that
        /// specifies whether the dialog should be launched to create a new profile, or
        /// save an existing profile with a new name.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogLaunchResults" />
        /// interface whose properties are set to the results of the user's selections in
        /// the dialog box.
        /// </returns>
        public static IProfileNameDialogLaunchResults ProfileNameDialogBox(
            ProfileCreateOperationType type
        )
            => GetDialogLauncherAction
               .For<IProfileNameDialogLaunchParams,
                   IProfileNameDialogLaunchResults>(
                   DialogLauncherActionType.LaunchProfileNameDialog
               )
               .WithInput(
                   (IProfileNameDialogLaunchParams)
                   MakeNewProfileNameDialogLaunchParams.FromScratch()
                       .ForProfileCreateOperationType(type)
                       .AndOwnerWindow(Application.OpenForms[0])
               )
               .Execute();

        /// <summary>
        /// Launches a dialog box to display a report that an error occurred.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> that
        /// specifies whether the dialog should be launched to create a new profile, or
        /// save an existing profile with a new name.
        /// </param>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object plays the role of the parent window of the dialog box.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogLaunchResults" />
        /// interface whose properties are set to the results of the user's selections in
        /// the dialog box.
        /// </returns>
        public static IProfileNameDialogLaunchResults ProfileNameDialogBox(
            ProfileCreateOperationType type,
            IWin32Window owner
        )
            => GetDialogLauncherAction
               .For<IProfileNameDialogLaunchParams,
                   IProfileNameDialogLaunchResults>(
                   DialogLauncherActionType.LaunchProfileNameDialog
               )
               .WithInput(
                   (IProfileNameDialogLaunchParams)
                   MakeNewProfileNameDialogLaunchParams.FromScratch()
                       .ForProfileCreateOperationType(type)
                       .AndOwnerWindow(owner)
               )
               .Execute();

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.Dialogs.Interfaces.IErrorReportDialog.ViewErrorReportRequested" />
        /// event raised by the Error Report dialog box.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>This method responds by launching Notepad to view the detailed report.</remarks>
        private static void OnViewErrorReportRequested(
            object sender,
            ViewErrorReportRequestedEventArgs e
        )
            => GetErrorReportCommand.For<ViewErrorReportRequestedEventArgs>(
                                        ErrorReportCommandType
                                            .ViewErrorReportWithNotepad
                                    )
                                    .WithInput(e)
                                    .Execute();

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.GUI.Dialogs.Interfaces.IErrorReportDialog.SendErrorReportRequested" />
        /// event raised by the Error Report dialog box.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>This method responds by launching Notepad to view the detailed report.</remarks>
        private static void OnSendErrorReportRequested(
            object sender,
            SendErrorReportRequestedEventArgs e
        )
            => GetErrorReportCommand
               .For<SendErrorReportRequestedEventArgs>(
                   ErrorReportCommandType.SendErrorReport
               )
               .WithInput(e)
               .Execute();
    }
}