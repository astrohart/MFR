using MFR.Errors.Reports.Commands.Constants;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Helpers;
using MFR.GUI.Dialogs.Events;
using MFR.Messages.Commands;
using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

namespace MFR.Errors.Reports.Commands
{
    /// <summary>
    /// Instructs the application to launch a viewer of an error report.
    /// </summary>
    public class
        ViewErrorReportWithNotepadCommand : CommandBase<
        ViewErrorReportRequestedEventArgs>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static ViewErrorReportWithNotepadCommand() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected ViewErrorReportWithNotepadCommand() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Errors.Reports.Commands.ViewErrorReportWithNotepadCommand" />.
        /// </summary>
        public static ViewErrorReportWithNotepadCommand Instance
        {
            [DebuggerStepThrough] get;
        } = new ViewErrorReportWithNotepadCommand();

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

                if (string.IsNullOrWhiteSpace(Input.ErrorReportContent)) return;

                // STEP 1: Dump the error report to a temp file (in .txt format)
                var newTempFilePath =
                    DumpText.ToTempFile(Input.ErrorReportContent);

                // STEP 2: Check to ensure the operation succeeded
                if (string.IsNullOrWhiteSpace(newTempFilePath)) return;

                var resultantFile = MakeNewFileInfo.ForPath(newTempFilePath);

                if (!resultantFile.Exists || resultantFile.Length == 0 ||
                    resultantFile.Length != Input.ErrorReportContent.Length)
                    return;

                // STEP 3: If we are here, then call Notepad on the file to display the error report.

                Process.Start("notepad.exe", newTempFilePath);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}