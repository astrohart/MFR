using MFR.Errors.Reports.Commands.Constants;
using MFR.GUI.Actions;
using MFR.GUI.Dialogs.Events;
using MFR.Messages.Commands;
using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;
using xyLOGIX.Reporters.Crashes.Actions;

namespace MFR.Errors.Reports.Commands
{
    /// <summary>
    /// Instructs the application to send an error report.
    /// </summary>
    public class
        SendErrorReportCommand : CommandBase<SendErrorReportRequestedEventArgs>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static SendErrorReportCommand() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected SendErrorReportCommand() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Errors.Reports.Commands.SendErrorReportCommand" />.
        /// </summary>
        public static SendErrorReportCommand Instance
        {
            [DebuggerStepThrough] get;
        } = new SendErrorReportCommand();

        /// <summary>
        /// Gets the
        /// <see
        ///     cref="T:MFR.MessageType" />
        /// that is
        /// being used to identify which message this.
        /// </summary>
        public override MessageType MessageType
        {
            [DebuggerStepThrough] get;
        } = ErrorReportCommandType.ViewErrorReportWithNotepad;

        /// <summary>
        /// Executes this command and does not return anything.
        /// </summary>
        /// <remarks>
        /// Implementers must override this method in order to return this
        /// object's functionality.
        /// </remarks>
        protected override void CommonExecute()
        {
            try
            {
                if (Input == null)
                    throw new ArgumentNullException(nameof(Input));

                if (string.IsNullOrWhiteSpace(Input.NameOfUser)) return;
                if (string.IsNullOrWhiteSpace(Input.EmailAddressOfUser)) return;
                if (string.IsNullOrWhiteSpace(Input.ReproductionSteps)) return;
                if (string.IsNullOrWhiteSpace(Input.ErrorReportContent)) return;

                Send.ErrorReport(
                    Input.Exception, Get.ApplicationProductName(),
                    Get.LogFilePath(), Input.ReproductionSteps,
                    Input.NameOfUser, Input.EmailAddressOfUser
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}