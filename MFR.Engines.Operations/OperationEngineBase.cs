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
using MFR.Engines.Constants;
using MFR.Engines.Operations.Interfaces;
using MFR.Engines.Operations.Jobs.Factories;
using MFR.Engines.Operations.Jobs.Interfaces;
using MFR.Events;
using MFR.Events.Common;
using MFR.Operations.Events;
using MFR.Renamers.Files.Factories;
using MFR.Renamers.Files.Interfaces;
using MFR.Settings.Configuration;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;
using xyLOGIX.Core.Debug;
using xyLOGIX.Queues.Messages.Mappings;
using xyLOGIX.Queues.Messages.Senders;

namespace MFR.Engines.Operations
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all operation
    /// engines.
    /// </summary>
    public abstract class OperationEngineBase : ConfigurationComposedObjectBase,
        IOperationEngine
    {
        /// <summary>
        /// Reference to a <see cref="T:System.ComponentModel.BackgroundWorker" /> instance
        /// that actually manages the file-rename processing itself.
        /// </summary>
        /// <remarks>
        /// The problem that using this vs, say,
        /// <see cref="T:System.Threading.Tasks.Task" />, is that we can know,
        /// deterministically, with a
        /// <see cref="T:System.ComponentModel.BackgroundWorker" />, when our operation is
        /// actually complete, but it can still be run in an asynchronous way that keeps
        /// the UI/UX of the application responsive.
        /// </remarks>
        private BackgroundWorker _processingWorker;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Engines.Operations.OperationEngineBase" />
        /// and returns a reference to it.
        /// </summary>
        protected OperationEngineBase()
        {
            InitializeProcessingWorker();
        }

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user config and the
        /// actions
        /// associated with it.
        /// </remarks>
        private static IProjectFileRenamerConfigProvider
            ConfigProvider
            => GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </summary>
        public override IProjectFileRenamerConfig CurrentConfig
        {
            get;
            set;
        } = ConfigProvider.CurrentConfig;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Renamers.Files.Interfaces.IFileRenamer" /> interface.
        /// </summary>
        /// <remarks>
        /// This object provides access to the file- and folder-processing functionality of
        /// the application.
        /// <para />
        /// It is marked as <see langword="protected" /> in the source code, allowing access to
        /// children of the <see cref="T:MFR.Engines.Operations.OperationEngineBase" />
        /// class.
        /// </remarks>
        protected static IFileRenamer FileRenamer
        {
            get;
        } = GetFileRenamer.SoleInstance();

        /// <summary>
        /// Gets a <see cref="T:MFR.Engines.Constants.OperationEngineType" /> enumeration
        /// value that describes what type of operation engine this.
        /// </summary>
        /// <remarks>
        /// Child classes must implement this property.
        /// </remarks>
        public abstract OperationEngineType Type
        {
            get;
        }

        /// <summary>
        /// Occurs when an exception is thrown during a file operation.
        /// </summary>
        public event ExceptionRaisedEventHandler ProcessingError;

        /// <summary>
        /// Occurs when the operation engine is finished.
        /// </summary>
        public event EventHandler ProcessingFinished;

        /// <summary>
        /// Occurs when the processing has been started.
        /// </summary>
        public event EventHandler ProcessingStarted;

        /// <summary>
        /// Executes the Rename Subfolders, Rename Files, and Replace Text in
        /// Files operation on all the folders and files in the root folder with
        /// the pathname specified by the <paramref name="rootDirectoryPath" /> parameter.
        /// </summary>
        /// <param name="rootDirectoryPath">
        /// Path to the recursion root.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat" /> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        public void ProcessAll(
            string rootDirectoryPath,
            string findWhat,
            string replaceWith,
            Predicate<string> pathFilter = null
        )
        {
            if (_processingWorker == null || _processingWorker.IsBusy) return;

            OnProcessingStarted();

            FileRenamer.UpdateConfiguration(CurrentConfig);

            _processingWorker.RunWorkerAsync(
                MakeNewFileRenamerJob.ForRootDirectory(rootDirectoryPath)
                                     .HavingPathFilter(pathFilter)
                                     .ToFindWhat(findWhat)
                                     .AndReplaceItWith(replaceWith)
            );
        }

        /// <summary>
        /// Updates the <paramref name="config" /> currently being used with a new
        /// value.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface
        /// which has the new settings.
        /// </param>
        /// <remarks>
        /// The settings in the object specified will be used for all matching
        /// from this point forward.
        /// <para />
        /// NOTE:This member may be overriden by a child class. If this the
        /// case, the overrider must call the base class method before doing any
        /// of its own processing.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="config" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        public override void UpdateConfiguration(
            IProjectFileRenamerConfig config
        )
        {
            base.UpdateConfiguration(config);

            FileRenamer.UpdateConfiguration(config);
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
        protected abstract void HandleFilesCountedEvent(int count);

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
        protected abstract void OnFileRenamerOperationFinished(
            object sender,
            OperationFinishedEventArgs e
        );

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
        protected abstract void OnFileRenamerOperationStarted(
            object sender,
            OperationStartedEventArgs e
        );

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
        protected abstract void OnFileRenamerProcessingOperation(
            object sender,
            ProcessingOperationEventArgs e
        );

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
        [Log(AttributeExclude = true)]
        protected virtual void OnFileRenamerStatusUpdate(
            object sender,
            StatusUpdateEventArgs e
        )
        {
            // write the name of the current class and method we are now entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "In OperationEngineBase.OnFileRenamerStatusUpdate"
            );

            if (string.IsNullOrWhiteSpace(e.Text)) return;

            Console.WriteLine(e.Text);
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Engines.Interfaces.IOperationEngine.ProcessingError" />
        /// event.
        /// </summary>
        protected virtual void OnProcessingError(ExceptionRaisedEventArgs e)
        {
            ProcessingError?.Invoke(this, e);
            SendMessage<ExceptionRaisedEventArgs>.Having.Args(this, e)
                                                 .ForMessageId(
                                                     OperationEngineMessages
                                                         .OE_OPERATION_ERROR
                                                 );
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Engines.Interfaces.IOperationEngine.ProcessingFinished" />
        /// event.
        /// </summary>
        protected virtual void OnProcessingFinished()
        {
            ProcessingFinished?.Invoke(this, EventArgs.Empty);
            SendMessage<EventArgs>.Having.Args(this, EventArgs.Empty)
                                  .ForMessageId(
                                      OperationEngineMessages
                                          .OE_PROCESSING_FINISHED
                                  );
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Engines.Interfaces.IOperationEngine.ProcessingStarted" />
        /// event.
        /// </summary>
        protected virtual void OnProcessingStarted()
        {
            ProcessingStarted?.Invoke(this, EventArgs.Empty);
            SendMessage<EventArgs>.Having.Args(this, EventArgs.Empty)
                                  .ForMessageId(
                                      OperationEngineMessages
                                          .OE_PROCESSING_STARTED
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
        private void OnFileRenamerExceptionRaised(
            object sender,
            ExceptionRaisedEventArgs e
        )
        {
            FileRenamer.RequestAbort();

            OnProcessingError(new ExceptionRaisedEventArgs(e.Exception));
        }

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
        private void OnFileRenamerFilesToHaveTextReplacedCounted(
            object sender,
            FilesOrFoldersCountedEventArgs e
        )
            => HandleFilesCountedEvent(e.Count);

        private void OnFileRenamerFinished() { }

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
        [Log(AttributeExclude = true)]
        private void OnFileRenamerResultsToBeCommittedToGitCounted(
            object sender,
            FilesOrFoldersCountedEventArgs e
        )
            => HandleFilesCountedEvent(e.Count);

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.Renamers.Files.Interfaces.IFileRenamer.PendingChangesToBeCommittedCounted" />
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
        /// Handles the <see cref="E:MFR.IFileRenamer.Finished" /> event
        /// raised by the File Renamer object. This event is raised when the
        /// rename operations are all completed.
        /// </summary>
        /// <remarks>
        /// This method responds merely by raising the
        /// <see
        ///     cref="E:MFR.GUI.IMainWindowPresenter.Finished" />
        /// event in turn.
        /// </remarks>
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
            => OnProcessingFinished();
    }
}