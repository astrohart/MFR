using MFR.Engines.Constants;
using MFR.Engines.Operations.Interfaces;
using MFR.Engines.Operations.Properties;
using MFR.Events.Common;
using MFR.GUI.Dialogs.Factories;
using MFR.GUI.Dialogs.Interfaces;
using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Factories;
using MFR.Operations.Events;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Engines.Operations
{
    /// <summary>
    /// Coordinates the operation of the <c>File Renamer</c> component inadmidst the
    /// full graphical user interface of the application.
    /// </summary>
    public class FullGuiOperationEngine : OperationEngineBase,
        IFullGuiOperationEngine
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.ICancellableProgressDialog" />
        /// interface.
        /// </summary>
        private ICancellableProgressDialog _cancellableProgressDialog;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface that represents
        /// the parent window of the progress dialog.
        /// </summary>
        private IWin32Window _dialogOwner;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static FullGuiOperationEngine() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected FullGuiOperationEngine()
        {
            ReinitializeProgressDialog(); // reinitialize the progress dialog to a "clean" state
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
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface that represents
        /// the parent window of the progress dialog.
        /// </summary>
        public IWin32Window DialogOwner
        {
            get => _dialogOwner;
            private set {
                var changed = _dialogOwner != value;
                _dialogOwner = value;
                if (changed)
                    OnDialogOwnerChanged();
            }
        }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Engines.Interfaces.IFullGuiOperationEngine" /> interface.
        /// </summary>
        public static IFullGuiOperationEngine Instance
        {
            get;
        } = new FullGuiOperationEngine();

        /// <summary>
        /// Gets a <see cref="T:MFR.Engines.Constants.OperationEngineType" /> enumeration
        /// value that describes what type of operation engine this.
        /// </summary>
        /// <remarks>
        /// Child classes must implement this property.
        /// </remarks>
        public override OperationEngineType Type
            => OperationEngineType.FullGUI;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:MFR.Engines.Operations.FullGuiOperationEngine.DialogOwner" /> property is
        /// updated.
        /// </summary>
        public event EventHandler DialogOwnerChanged;

        /// <summary>
        /// Dismisses the progress dialog.
        /// </summary>
        public void CloseProgressDialog()
            => _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.Close()
            );

        /// <summary>
        /// Sets the owner window of all dialog boxes displayed by this component.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface that represents
        /// the new owner window.
        /// </param>
        /// <remarks>
        /// Typically, this method would be called by passing a reference to the
        /// main window of the application.
        /// <para />
        /// </remarks>
        public void SetDialogOwner(IWin32Window owner)
        {
            try
            {
                if (owner == null) return;

                DialogOwner = owner;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

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
        public void ShowCalculatingProgressBar(
            string text,
            bool canCancel = true
        )
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(text)
                );
            ResetProgressBar();

            _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.ProgressBarStyle =
                    ProgressBarStyle.Marquee
            );
            _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.Status = text
            );
        }

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        /// <param name="canCancel">
        /// (Required.) A <see cref="T:System.Boolean" /> that controls whether the
        /// <strong>Cancel</strong> button is displayed by the dialog box.
        /// <para />
        /// Set this parameter to <see langword="true" /> to display the button;
        /// <see langword="false" /> to hide it.
        /// </param>
        public void ShowProgressDialog(bool canCancel)
            => _cancellableProgressDialog.DoIfNotDisposed(
                () =>
                {
                    _cancellableProgressDialog.CanCancel = canCancel;
                    _cancellableProgressDialog.ShowDialog(DialogOwner);
                }
            );

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object plays the role of the parent window of the dialog box.
        /// </param>
        public void ShowProgressDialog(IWin32Window owner)
            => _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.Show(owner)
            );

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object plays the role of the parent window of the dialog box.
        /// </param>
        /// <param name="canCancel">
        /// (Required.) A <see cref="T:System.Boolean" /> that controls whether the
        /// <strong>Cancel</strong> button is displayed by the dialog box.
        /// <para />
        /// Set this parameter to <see langword="true" /> to display the button;
        /// <see langword="false" /> to hide it.
        /// </param>
        public void ShowProgressDialog(IWin32Window owner, bool canCancel)
            => _cancellableProgressDialog.DoIfNotDisposed(
                () =>
                {
                    _cancellableProgressDialog.InvokeIfRequired(
                        () =>
                        {
                            _cancellableProgressDialog.CanCancel = canCancel;
                            _cancellableProgressDialog.Show(owner);
                        }
                    );
                }
            );

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        public void ShowProgressDialog()
            => _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.InvokeIfRequired(
                    _cancellableProgressDialog.Show
                )
            );

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

            InitializeFileRenamer();
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
        protected override void HandleFilesCountedEvent(int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            ResetProgressBar();

            _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.ProgressBarMaximum = count
            );
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Engines.Operations.FullGuiOperationEngine.DialogOwnerChanged" /> event.
        /// </summary>
        protected virtual void OnDialogOwnerChanged()
            => DialogOwnerChanged?.Invoke(this, EventArgs.Empty);

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
        protected override void OnFileRenamerOperationFinished(
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
        protected override void OnFileRenamerOperationStarted(
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
        protected override void OnFileRenamerProcessingOperation(
            object sender,
            ProcessingOperationEventArgs e
        )
        {
            if (e.OperationType == OperationType.Unknown) return;
            if (e.Entry == null) return;
            if (string.IsNullOrWhiteSpace(e.Entry.Path)) return;

            IncrementProgressBar(
                GetOperationDescriptionText.For(e.OperationType), 
                    e.Entry.ShortPath
            );
        }

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
        protected override void OnFileRenamerStatusUpdate(
            object sender,
            StatusUpdateEventArgs e
        )
            => _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.Status = e.Text
            );

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Engines.Interfaces.IOperationEngine.ProcessingError" />
        /// event.
        /// </summary>
        protected override void OnProcessingError(ExceptionRaisedEventArgs e)
        {
            base.OnProcessingError(e);

            xyLOGIX.Win32.Interact.Messages.ShowStopError(
                Resources.Error_OperationFailed
            );
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Engines.Operations.OperationEngineBase.ProcessingFinished" /> event.
        /// </summary>
        protected override void OnProcessingFinished()
        {
            base.OnProcessingFinished();

            CloseProgressDialog();
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.Engines.Operations.OperationEngineBase.ProcessingStarted" />
        /// event.
        /// </summary>
        protected override void OnProcessingStarted()
        {
            base.OnProcessingStarted();

            ReinitializeProgressDialog();

            ShowProgressDialog();
        }

        /// <summary>
        /// Handles the <see cref="E:MFR.GUI.ICancellableProgressDialog.CancelRequested" />
        /// event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method handles the situation in which the user has clicked the
        /// Cancel button on the progress dialog. The message taken by this
        /// method is to tell the File Renamer Object to attempt to abort.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private static void OnCancellableProgressDialogRequestedCancel(
                object sender,
                EventArgs e
            )

            // Ask the File Renamer component to stop.  Because the user has
            // clicked the Cancel button in the progress dialog.
            => FileRenamer.RequestAbort();

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
            _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.Status = statusLabelText
            );
            _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.CurrentFile =
                    currentFileLabelText
            );
            _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.ProgressBarValue++
            );
        }

        /// <summary>
        /// Sets the progress dialog and/or reinitializes it from prior use.
        /// </summary>
        [Log(AttributeExclude = true)]
        private void ReinitializeProgressDialog()
        {
            _cancellableProgressDialog.DoIfNotDisposed(
                () =>
                {
                    if (_cancellableProgressDialog != null)
                    {
                        _cancellableProgressDialog.Close();
                        _cancellableProgressDialog.Dispose();
                    }

                    _cancellableProgressDialog = null;
                }
            );
            _cancellableProgressDialog.DoIfDisposed(
                () => _cancellableProgressDialog =
                    MakeNewProgressDialog.FromScratch()
            );

            _cancellableProgressDialog.CancelRequested -=
                OnCancellableProgressDialogRequestedCancel;
            _cancellableProgressDialog.CancelRequested +=
                OnCancellableProgressDialogRequestedCancel;
        }

        /// <summary>
        /// Resets the progress bar back to the beginning.
        /// </summary>
        [Log(AttributeExclude = true)]
        private void ResetProgressBar()
            => _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.InvokeIfRequired(
                    _cancellableProgressDialog.Reset
                )
            );
    }
}