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
 */using MFR.Constants;
using MFR.Engines.Operations.Jobs.Factories;
using MFR.Engines.Operations.Jobs.Interfaces;
using MFR.Events;
using MFR.Events.Common;
using MFR.GUI.Dialogs.Interfaces;
using MFR.GUI.Dialogs.Properties;
using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Factories;
using MFR.Operations.Events;
using MFR.Renamers.Files.Factories;
using MFR.Renamers.Files.Interfaces;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Queues.Messages.Mappings;
using xyLOGIX.Win32.Interact;

#pragma warning disable IDE0060

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Variant of the <see cref="T:MFR.GUI.Dialogs.CancellableProgressDialog" /> that
    /// can be used when the user specifies the <c>--autoStart</c> flag on the command
    /// line.
    /// </summary>
    /// <remarks>
    /// This class hosts a <c>FileRenamer</c> component that can perform the
    /// user's requested operations itself.
    /// </remarks>
    public class AutoStartCancellableProgressDialog : CancellableProgressDialog,
        IAutoStartCancellableProgressDialog
    {
        /// <summary>
        /// Reference to an instance of
        /// <see cref="T:System.ComponentModel.BackgroundWorker" /> that runs the
        /// <c>FileRenamer</c> component in a worker thread.
        /// </summary>
        /// I
        private BackgroundWorker _processingWorker;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static AutoStartCancellableProgressDialog() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected AutoStartCancellableProgressDialog()
        {
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            InitializeFileRenamer();
            InitializeProcessingWorker();
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        private static IProjectFileRenamerConfigProvider
            ConfigProvider
            => GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface that represents the currently-loaded config.
        /// </summary>
        private static IProjectFileRenamerConfig CurrentConfig
            => ConfigProvider.CurrentConfig;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Renamers.Files.Interfaces.IFileRenamer" /> interface.
        /// </summary>
        private static IFileRenamer FileRenamer
        {
            get;
        } = GetFileRenamer.SoleInstance();

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.IAutoStartCancellableProgressDialog" /> interface.
        /// </summary>
        public static IAutoStartCancellableProgressDialog Instance
        {
            get;
        } = new AutoStartCancellableProgressDialog();

        /// <summary>
        /// Sets the properties of the <see cref="T:MFR.Renamers.Files.FileRenamer" />
        /// object that we are working
        /// with and subscribes to the events that it emits.
        /// </summary>
        protected void InitializeFileRenamer()
        {
            // write the name of the current class and method we are now
            // Check to see if the required field, _fileRenamer, is null. If it
            if (FileRenamer == null)
                return;

            NewMessageMapping<ExceptionRaisedEventArgs>.Associate
                .WithMessageId(FileRenamerMessages.FRM_EXCEPTION_RAISED)
                .AndHandler(
                    new Action<object, ExceptionRaisedEventArgs>(
                        OnFileRenamerExceptionRaised
                    )
                );
            NewMessageMapping<OperationFinishedEventArgs>.Associate
                .WithMessageId(FileRenamerMessages.FRM_OPERATION_FINISHED)
                .AndHandler(
                    new Action<object, OperationFinishedEventArgs>(
                        OnFileRenamerOperationFinished
                    )
                );
            NewMessageMapping<OperationStartedEventArgs>.Associate
                .WithMessageId(FileRenamerMessages.FRM_OPERATION_STARTED)
                .AndHandler(
                    new Action<object, OperationStartedEventArgs>(
                        OnFileRenamerOperationStarted
                    )
                );
            NewMessageMapping<FilesOrFoldersCountedEventArgs>.Associate
                .WithMessageId(
                    FileRenamerMessages.FRM_FILES_TO_BE_RENAMED_COUNTED
                )
                .AndHandler(
                    new FilesOrFoldersCountedEventHandler(
                        OnFileRenamerFilesToBeRenamedCounted
                    )
                );
            NewMessageMapping<FilesOrFoldersCountedEventArgs>.Associate
                .WithMessageId(
                    FileRenamerMessages.FRM_FILES_TO_HAVE_TEXT_REPLACED_COUNTED
                )
                .AndHandler(
                    new FilesOrFoldersCountedEventHandler(
                        OnFileRenamerFilesToHaveTextReplacedCounted
                    )
                );
            NewMessageMapping<FilesOrFoldersCountedEventArgs>.Associate
                .WithMessageId(
                    FileRenamerMessages
                        .FRM_PENDING_CHANGES_TO_BE_COMMITTED_COUNTED
                )
                .AndHandler(
                    new FilesOrFoldersCountedEventHandler(
                        OnFileRenamerPendingChangesToBeCommittedCounted
                    )
                );
            NewMessageMapping<FilesOrFoldersCountedEventArgs>.Associate
                .WithMessageId(
                    FileRenamerMessages
                        .FRM_RESULTS_TO_BE_COMMITTED_TO_GIT_COUNTED
                )
                .AndHandler(
                    new FilesOrFoldersCountedEventHandler(
                        OnFileRenamerResultsToBeCommittedToGitCounted
                    )
                );
            NewMessageMapping<FilesOrFoldersCountedEventArgs>.Associate
                .WithMessageId(
                    FileRenamerMessages.FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED
                )
                .AndHandler(
                    new FilesOrFoldersCountedEventHandler(
                        OnFileRenamerSubfoldersToBeRenamedCounted
                    )
                );
            NewMessageMapping<FilesOrFoldersCountedEventArgs>.Associate
                .WithMessageId(
                    FileRenamerMessages
                        .FRM_SOLUTION_FOLDERS_TO_BE_RENAMED_COUNTED
                )
                .AndHandler(
                    new FilesOrFoldersCountedEventHandler(
                        OnFileRenamerSolutionFoldersToBeRenamedCounted
                    )
                );
            NewMessageMapping<StatusUpdateEventArgs>.Associate
                                                    .WithMessageId(
                                                        FileRenamerMessages
                                                            .FRM_STATUS_UPDATE
                                                    )
                                                    .AndHandler(
                                                        new Action<object,
                                                            StatusUpdateEventArgs>(
                                                            OnFileRenamerStatusUpdate
                                                        )
                                                    );
            NewMessageMapping<ProcessingOperationEventArgs>.Associate
                .WithMessageId(FileRenamerMessages.FRM_PROCESSING_OPERATION)
                .AndHandler(
                    new Action<object, ProcessingOperationEventArgs>(
                        OnFileRenamerProcessingOperation
                    )
                );
            NewMessageMapping.Associate.WithMessageId(
                                 FileRenamerMessages.FRM_FINISHED
                             )
                             .AndHandler(new Action(OnFileRenamerFinished));
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Shown" /> event.</summary>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            PerformAutoScale();

            CenterToScreen();

            Update();
            Refresh();
            Application.DoEvents();

            FileRenamer.UpdateConfiguration(CurrentConfig);

            _processingWorker.RunWorkerAsync(
                MakeNewFileRenamerJob
                    .ForRootDirectory(CurrentConfig.StartingFolder)
                    .HavingPathFilter(null)
                    .ToFindWhat(CurrentConfig.FindWhat)
                    .AndReplaceItWith(CurrentConfig.ReplaceWith)
            );
        }

        /// <summary>
        /// Handles the <see cref="E:System.ComponentModel.BackgroundWorker.DoWork" />
        /// event raised by the Processing Worker that invokes the File Renamer.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.DoWorkEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method is called to process a File Renamer job in a background
        /// thread.
        /// </remarks>
        private static void OnProcessingWorkerDoWork(
            object sender,
            DoWorkEventArgs e
        )
        {
            if (!(e.Argument is IFileRenamerJob job)) return; // no job data

            FileRenamer.ProcessAll(
                job.RootDirectory, job.FindWhat, job.ReplaceWith, job.PathFilter
            );
        }

        /// <summary>
        /// Called when the count of files to be processed in a given operation
        /// is computed.
        /// </summary>
        /// <param name="count">
        /// (Required.) Integer value specifying the count of files that are to
        /// be processed in the current operation.
        /// </param>
        /// <remarks>
        /// Takes the message of resetting the progress dialog and reconfiguring
        /// the progress bar such that the <paramref name="count" /> parameter
        /// specifies the new maximum value of the progress bar.
        /// </remarks>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the <paramref name="count" /> parameter is zero or
        /// negative. This parameter describes a count of files; therefore, it
        /// is expected that it should be 1 or greater.
        /// </exception>
        [Log(AttributeExclude = true)]
        private void HandleFilesCountedEvent(int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            ResetProgressBar();

            ProgressBarMaximum = count;
        }

        /// <summary>
        /// Increments the value of the progress bar. Also updates the status
        /// text and the label that is displaying the pathname to the file that
        /// is currently being processed.
        /// </summary>
        /// <param name="statusLabelText">
        /// (Required.) String containing the text that is to be displayed on
        /// the top line of the progress dialog. This text serves to inform the
        /// user as to which operation is currently being performed.
        /// </param>
        /// efs
        /// <param name="currentFileLabelText">
        /// (Required.) String containing the pathname to the file that is
        /// currently being processed.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="statusLabelText" />
        /// or <paramref name="currentFileLabelText" />,
        /// are passed blank or <see langword="null" /> string for values.
        /// </exception>
        [Log(AttributeExclude = true)]
        private void IncrementProgressBar(
            string statusLabelText,
            string currentFileLabelText
        )
        {
            if (string.IsNullOrWhiteSpace(statusLabelText))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(statusLabelText)
                );
            if (string.IsNullOrWhiteSpace(currentFileLabelText))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(currentFileLabelText)
                );

            Status = statusLabelText;

            CurrentFile = currentFileLabelText;
            ProgressBarValue++;
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            //
            // AutoStartCancellableProgressDialog
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            CancelButton = null;
            ClientSize = new Size(417, 138);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = true;
            Name = "AutoStartCancellableProgressDialog";
            ShowIcon = true;
            ShowInTaskbar = true;
            Status = "Calculating files to be processed...";
            Text = Application.ProductName;
            ResumeLayout(false);
        }

        /// <summary>
        /// Initializes the settings for the
        /// <see cref="T:System.ComponentModel.BackgroundWorker" /> that is used to process
        /// the file-renaming operations.
        /// </summary>
        private void InitializeProcessingWorker()
        {
            _processingWorker = new BackgroundWorker();
            _processingWorker.DoWork -= OnProcessingWorkerDoWork;
            _processingWorker.DoWork += OnProcessingWorkerDoWork;
            _processingWorker.RunWorkerCompleted +=
                OnProcessingWorkerRunWorkerCompleted;
        }

        /// <summary>
        /// Handles the <see cref="E:MFR.IFileRenamer.ExceptionRaised" /> event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:MFR.Events.Common.ExceptionRaisedEventArgs" /> that contains
        /// the event data.
        /// </param>
        /// <remarks>
        /// This method responds to such an event by showing the user a message
        /// box, logging the error, and then aborting the operation.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerExceptionRaised(
            object sender,
            ExceptionRaisedEventArgs e
        )
            => this.InvokeIfRequired(
                () =>
                {
                    FileRenamer.RequestAbort();

                    Hide();

                    Update();
                    Refresh();
                    Application.DoEvents();

                    // dump all the exception info to the log
                    DebugUtils.LogException(e.Exception);

                    Messages.ShowStopError(this, e.Exception.Message);

                    Close();
                }
            );

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.IFileRenamer.FilesToBeRenamedCounted" />
        /// event
        /// raised by the file renamer object when it's finished determining the
        /// set of file system entries upon which the current operation should act.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by resetting the progress dialog's progress bar
        /// back to zero, and then updating the value of its
        /// <see
        ///     cref="P:System.Windows.Forms.ProgressBar.Maximum" />
        /// property to have
        /// the same value as the count of file system entries.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerFilesToBeRenamedCounted(
            object sender,
            FilesOrFoldersCountedEventArgs e
        )
            => HandleFilesCountedEvent(e.Count);

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.IFileRenamer.FilesToHaveTextReplacedCounted" />
        /// event raised by the File Renamer object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by resetting the progress dialog's progress bar
        /// back to zero, and then updating the value of its
        /// <see
        ///     cref="P:System.Windows.Forms.ProgressBar.Maximum" />
        /// property to have
        /// the same value as the count of file system entries.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerFilesToHaveTextReplacedCounted(
            object sender,
            FilesOrFoldersCountedEventArgs e
        )
            => HandleFilesCountedEvent(e.Count);

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.IFileRenamer.OperationFinished" />
        /// event raised
        /// by the file renamer object.
        /// </summary>
        /// <remarks>
        /// This method responds to the event by telling the progress dialog to
        /// reset the progress bar back to the starting point.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerFinished()
            => ResetProgressBar();

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.IFileRenamer.OperationFinished" />
        /// event raised
        /// by the file renamer object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.Operations.Events.OperationFinishedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by telling the progress dialog to
        /// reset the progress bar back to the starting point.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerOperationFinished(
            object sender,
            OperationFinishedEventArgs e
        )
            => ResetProgressBar();

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.IFileRenamer.OperationStarted" />
        /// event raised by
        /// the file-renamer object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.Operations.Events.OperationStartedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds to the event by telling the progress dialog to
        /// show the marquee progress bar for the operation type whose
        /// processing is now being started.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerOperationStarted(
            object sender,
            OperationStartedEventArgs e
        )
        {
            if (e.OperationType == OperationType.Unknown) return;

            ShowCalculatingProgressBar(
                GetOperationStartedDescriptionText.For(e.OperationType)
            );
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.Renamers.Files.Interfaces.IFileRenamer.SubfoldersToBeRenamedCounted" />
        /// event raised by the File Renamer object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by resetting the progress dialog's progress bar
        /// back to zero, and then updating the value of its
        /// <see
        ///     cref="P:System.Windows.Forms.ProgressBar.Maximum" />
        /// property to have
        /// the same value as the count of file system entries.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerPendingChangesToBeCommittedCounted(
            object sender,
            FilesOrFoldersCountedEventArgs e
        )
            => HandleFilesCountedEvent(e.Count);

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.IFileRenamer.ProcessingOperation" />
        /// event raised
        /// by the File Renamer object when it moves on to processing the next
        /// file system entry in its list.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.ProcessingOperationEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by first checking the values passed in the
        /// <see
        ///     cref="T:MFR.ProcessingOperationEventArgs" />
        /// for valid values.
        /// <para />
        /// If the checks fail, then this method does nothing.
        /// <para />
        /// Otherwise, the method responds by incrementing the progress dialog's
        /// progress bar to the next notch, and updating the text of the lower
        /// status label in the progress dialog to contain the path to the file
        /// currently being worked on.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerProcessingOperation(
            object sender,
            ProcessingOperationEventArgs e
        )
        {
            if (e.OperationType == OperationType.Unknown) return;
            if (e.Entry == null) return;

            var currentFilePathname = e.Entry.ShortPath;
            if (string.IsNullOrWhiteSpace(currentFilePathname)) return;

            var statusLabelText =
                GetOperationDescriptionText.For(e.OperationType);
            if (string.IsNullOrWhiteSpace(statusLabelText)) return;

            IncrementProgressBar(statusLabelText, currentFilePathname);
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.Renamers.Files.Interfaces.IFileRenamer.ResultsToBeCommittedToGitCounted" />
        /// event raised by the File Renamer object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by resetting the progress dialog's progress bar
        /// back to zero, and then updating the value of its
        /// <see
        ///     cref="P:System.Windows.Forms.ProgressBar.Maximum" />
        /// property to have
        /// the same value as the count of file system entries.
        /// </remarks>
        private void OnFileRenamerResultsToBeCommittedToGitCounted(
            object sender,
            FilesOrFoldersCountedEventArgs e
        )
            => HandleFilesCountedEvent(e.Count);

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.Renamers.Files.Interfaces.IFileRenamer.SubfoldersToBeRenamedCounted" />
        /// event raised by the File Renamer object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by resetting the progress dialog's progress bar
        /// back to zero, and then updating the value of its
        /// <see
        ///     cref="P:System.Windows.Forms.ProgressBar.Maximum" />
        /// property to have
        /// the same value as the count of file system entries.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerSolutionFoldersToBeRenamedCounted(
            object sender,
            FilesOrFoldersCountedEventArgs e
        )
            => HandleFilesCountedEvent(e.Count);

        /// <summary>
        /// Handles the
        /// <see cref="E:MFR.Renamers.Files.Interfaces.IFileRenamer.StatusUpdate" /> event
        /// raised by the <c>FileRenamer</c> component when it has new text to send to the
        /// UI/UX of the application..
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.Common.StatusUpdateEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks></remarks>
        private void OnFileRenamerStatusUpdate(
            object sender,
            StatusUpdateEventArgs e
        )
            => Status = e.Text;

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.Renamers.Files.Interfaces.IFileRenamer.SubfoldersToBeRenamedCounted" />
        /// event raised by the File Renamer object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by resetting the progress dialog's progress bar
        /// back to zero, and then updating the value of its
        /// <see
        ///     cref="P:System.Windows.Forms.ProgressBar.Maximum" />
        /// property to have
        /// the same value as the count of file system entries.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private void OnFileRenamerSubfoldersToBeRenamedCounted(
            object sender,
            FilesOrFoldersCountedEventArgs e
        )
            => HandleFilesCountedEvent(e.Count);

        /// <summary>
        /// Handles the
        /// <see cref="E:System.ComponentModel.BackgroundWorker.RunWorkerCompleted" />
        /// event raised by the Processing Worker that actually invokes the File Renamer.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:System.ComponentModel.RunWorkerCompletedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by raising the
        /// <see cref="E:MFR.Engines.Interfaces.IOperationEngine.ProcessingFinished" />
        /// event and associated message.
        /// </remarks>
        private void OnProcessingWorkerRunWorkerCompleted(
            object sender,
            RunWorkerCompletedEventArgs e
        )
            => Close(); // just close this form

        /// <summary>
        /// Resets the progress bar back to the beginning.
        /// </summary>
        private void ResetProgressBar()
            => this.InvokeIfRequired(Reset);

        /// <summary>
        /// Shows a marquee progress bar that indicates the application is
        /// performing work but of an indeterminate length, such as calculating
        /// the amount of files to process.
        /// </summary>
        /// ///
        /// <param name="text">
        /// (Required.) String containing the text to display in the progress dialog.
        /// </param>
        /// <param name="canCancel">
        /// (Required.) <see langword="true" /> to show a <strong>Cancel</strong> button in
        /// the progress dialog; <see langword="false" /> to hide it.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="text" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        [Log(AttributeExclude = true)]
        private void ShowCalculatingProgressBar(
            string text,
            bool canCancel = true
        )
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(text)
                );
            ResetProgressBar();

            ProgressBarStyle = ProgressBarStyle.Marquee;
            Status = text;
        }
    }
}