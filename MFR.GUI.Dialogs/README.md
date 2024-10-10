<a name='assembly'></a>
# MFR.GUI.Dialogs

## Contents

- [AboutDialog](#T-MFR-GUI-Dialogs-AboutDialog 'MFR.GUI.Dialogs.AboutDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-AboutDialog-#ctor 'MFR.GUI.Dialogs.AboutDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-AboutDialog-components 'MFR.GUI.Dialogs.AboutDialog.components')
  - [AssemblyCompany](#P-MFR-GUI-Dialogs-AboutDialog-AssemblyCompany 'MFR.GUI.Dialogs.AboutDialog.AssemblyCompany')
  - [AssemblyCopyright](#P-MFR-GUI-Dialogs-AboutDialog-AssemblyCopyright 'MFR.GUI.Dialogs.AboutDialog.AssemblyCopyright')
  - [AssemblyDescription](#P-MFR-GUI-Dialogs-AboutDialog-AssemblyDescription 'MFR.GUI.Dialogs.AboutDialog.AssemblyDescription')
  - [AssemblyProduct](#P-MFR-GUI-Dialogs-AboutDialog-AssemblyProduct 'MFR.GUI.Dialogs.AboutDialog.AssemblyProduct')
  - [AssemblyTitle](#P-MFR-GUI-Dialogs-AboutDialog-AssemblyTitle 'MFR.GUI.Dialogs.AboutDialog.AssemblyTitle')
  - [AssemblyVersion](#P-MFR-GUI-Dialogs-AboutDialog-AssemblyVersion 'MFR.GUI.Dialogs.AboutDialog.AssemblyVersion')
  - [CreateParams](#P-MFR-GUI-Dialogs-AboutDialog-CreateParams 'MFR.GUI.Dialogs.AboutDialog.CreateParams')
  - [Display(owner)](#M-MFR-GUI-Dialogs-AboutDialog-Display-System-Windows-Forms-IWin32Window- 'MFR.GUI.Dialogs.AboutDialog.Display(System.Windows.Forms.IWin32Window)')
  - [Dispose()](#M-MFR-GUI-Dialogs-AboutDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.AboutDialog.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-AboutDialog-InitializeComponent 'MFR.GUI.Dialogs.AboutDialog.InitializeComponent')
- [AutoStartCancellableProgressDialog](#T-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-#ctor 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.#ctor')
  - [_processingWorker](#F-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-_processingWorker 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog._processingWorker')
  - [ConfigProvider](#P-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-ConfigProvider 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.ConfigProvider')
  - [CurrentConfiguration](#P-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-CurrentConfiguration 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.CurrentConfiguration')
  - [FileRenamer](#P-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-FileRenamer 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.FileRenamer')
  - [Instance](#P-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-Instance 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.Instance')
  - [#cctor()](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-#cctor 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.#cctor')
  - [HandleFilesCountedEvent(count)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-HandleFilesCountedEvent-System-Int32- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.HandleFilesCountedEvent(System.Int32)')
  - [IncrementProgressBar(statusLabelText,currentFileLabelText)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-IncrementProgressBar-System-String,System-String- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.IncrementProgressBar(System.String,System.String)')
  - [InitializeFileRenamer()](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-InitializeFileRenamer 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.InitializeFileRenamer')
  - [InitializeProcessingWorker()](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-InitializeProcessingWorker 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.InitializeProcessingWorker')
  - [OnFileRenamerExceptionRaised(sender,e)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerExceptionRaised-System-Object,MFR-Events-Common-ExceptionRaisedEventArgs- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnFileRenamerExceptionRaised(System.Object,MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnFileRenamerFilesToBeRenamedCounted(sender,e)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerFilesToBeRenamedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnFileRenamerFilesToBeRenamedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFileRenamerFilesToHaveTextReplacedCounted(sender,e)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerFilesToHaveTextReplacedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnFileRenamerFilesToHaveTextReplacedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFileRenamerFinished()](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerFinished 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnFileRenamerFinished')
  - [OnFileRenamerOperationFinished(sender,e)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerOperationFinished-System-Object,MFR-Operations-Events-OperationFinishedEventArgs- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnFileRenamerOperationFinished(System.Object,MFR.Operations.Events.OperationFinishedEventArgs)')
  - [OnFileRenamerOperationStarted(sender,e)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerOperationStarted-System-Object,MFR-Operations-Events-OperationStartedEventArgs- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnFileRenamerOperationStarted(System.Object,MFR.Operations.Events.OperationStartedEventArgs)')
  - [OnFileRenamerPendingChangesToBeCommittedCounted(sender,e)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerPendingChangesToBeCommittedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnFileRenamerPendingChangesToBeCommittedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFileRenamerProcessingOperation(sender,e)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerProcessingOperation-System-Object,MFR-Operations-Events-ProcessingOperationEventArgs- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnFileRenamerProcessingOperation(System.Object,MFR.Operations.Events.ProcessingOperationEventArgs)')
  - [OnFileRenamerResultsToBeCommittedToGitCounted(sender,e)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerResultsToBeCommittedToGitCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnFileRenamerResultsToBeCommittedToGitCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFileRenamerSolutionFoldersToBeRenamedCounted(sender,e)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerSolutionFoldersToBeRenamedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnFileRenamerSolutionFoldersToBeRenamedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFileRenamerStatusUpdate(sender,e)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerStatusUpdate-System-Object,MFR-Events-Common-StatusUpdateEventArgs- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnFileRenamerStatusUpdate(System.Object,MFR.Events.Common.StatusUpdateEventArgs)')
  - [OnFileRenamerSubfoldersToBeRenamedCounted(sender,e)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerSubfoldersToBeRenamedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnFileRenamerSubfoldersToBeRenamedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnProcessingWorkerDoWork(sender,e)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnProcessingWorkerDoWork-System-Object,System-ComponentModel-DoWorkEventArgs- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnProcessingWorkerDoWork(System.Object,System.ComponentModel.DoWorkEventArgs)')
  - [OnProcessingWorkerRunWorkerCompleted(sender,e)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnProcessingWorkerRunWorkerCompleted-System-Object,System-ComponentModel-RunWorkerCompletedEventArgs- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnProcessingWorkerRunWorkerCompleted(System.Object,System.ComponentModel.RunWorkerCompletedEventArgs)')
  - [OnShown(e)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnShown-System-EventArgs- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.OnShown(System.EventArgs)')
  - [ResetProgressBar()](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-ResetProgressBar 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.ResetProgressBar')
  - [ShowCalculatingProgressBar(text,canCancel)](#M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-ShowCalculatingProgressBar-System-String,System-Boolean- 'MFR.GUI.Dialogs.AutoStartCancellableProgressDialog.ShowCalculatingProgressBar(System.String,System.Boolean)')
- [CancellableProgressDialog](#T-MFR-GUI-Dialogs-CancellableProgressDialog 'MFR.GUI.Dialogs.CancellableProgressDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-CancellableProgressDialog-#ctor 'MFR.GUI.Dialogs.CancellableProgressDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-CancellableProgressDialog-components 'MFR.GUI.Dialogs.CancellableProgressDialog.components')
  - [CanCancel](#P-MFR-GUI-Dialogs-CancellableProgressDialog-CanCancel 'MFR.GUI.Dialogs.CancellableProgressDialog.CanCancel')
  - [CurrentFile](#P-MFR-GUI-Dialogs-CancellableProgressDialog-CurrentFile 'MFR.GUI.Dialogs.CancellableProgressDialog.CurrentFile')
  - [ProgressBar](#P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBar 'MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBar')
  - [ProgressBarMaximum](#P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarMaximum 'MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarMaximum')
  - [ProgressBarMinimum](#P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarMinimum 'MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarMinimum')
  - [ProgressBarStyle](#P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarStyle 'MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarStyle')
  - [ProgressBarValue](#P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarValue 'MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarValue')
  - [Status](#P-MFR-GUI-Dialogs-CancellableProgressDialog-Status 'MFR.GUI.Dialogs.CancellableProgressDialog.Status')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-CancellableProgressDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.CancellableProgressDialog.Dispose(System.Boolean)')
  - [DoSetProgressBarMaximum(value)](#M-MFR-GUI-Dialogs-CancellableProgressDialog-DoSetProgressBarMaximum-System-Int32- 'MFR.GUI.Dialogs.CancellableProgressDialog.DoSetProgressBarMaximum(System.Int32)')
  - [DoSetProgressBarMinimum(value)](#M-MFR-GUI-Dialogs-CancellableProgressDialog-DoSetProgressBarMinimum-System-Int32- 'MFR.GUI.Dialogs.CancellableProgressDialog.DoSetProgressBarMinimum(System.Int32)')
  - [DoSetProgressBarValue(value)](#M-MFR-GUI-Dialogs-CancellableProgressDialog-DoSetProgressBarValue-System-Int32- 'MFR.GUI.Dialogs.CancellableProgressDialog.DoSetProgressBarValue(System.Int32)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-CancellableProgressDialog-InitializeComponent 'MFR.GUI.Dialogs.CancellableProgressDialog.InitializeComponent')
  - [OnCancel(sender,e)](#M-MFR-GUI-Dialogs-CancellableProgressDialog-OnCancel-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.CancellableProgressDialog.OnCancel(System.Object,System.EventArgs)')
  - [OnCancelRequested()](#M-MFR-GUI-Dialogs-CancellableProgressDialog-OnCancelRequested 'MFR.GUI.Dialogs.CancellableProgressDialog.OnCancelRequested')
  - [OnLoad(e)](#M-MFR-GUI-Dialogs-CancellableProgressDialog-OnLoad-System-EventArgs- 'MFR.GUI.Dialogs.CancellableProgressDialog.OnLoad(System.EventArgs)')
  - [OnShown(e)](#M-MFR-GUI-Dialogs-CancellableProgressDialog-OnShown-System-EventArgs- 'MFR.GUI.Dialogs.CancellableProgressDialog.OnShown(System.EventArgs)')
  - [RedrawDisplay()](#M-MFR-GUI-Dialogs-CancellableProgressDialog-RedrawDisplay 'MFR.GUI.Dialogs.CancellableProgressDialog.RedrawDisplay')
  - [Reset()](#M-MFR-GUI-Dialogs-CancellableProgressDialog-Reset 'MFR.GUI.Dialogs.CancellableProgressDialog.Reset')
- [CustomizeCommitMessageDialog](#T-MFR-GUI-Dialogs-CustomizeCommitMessageDialog 'MFR.GUI.Dialogs.CustomizeCommitMessageDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-#ctor 'MFR.GUI.Dialogs.CustomizeCommitMessageDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-components 'MFR.GUI.Dialogs.CustomizeCommitMessageDialog.components')
  - [CommitMessageFormat](#P-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-CommitMessageFormat 'MFR.GUI.Dialogs.CustomizeCommitMessageDialog.CommitMessageFormat')
  - [CommitMessageMapper](#P-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-CommitMessageMapper 'MFR.GUI.Dialogs.CustomizeCommitMessageDialog.CommitMessageMapper')
  - [DetailedCommitMessageFormat](#P-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-DetailedCommitMessageFormat 'MFR.GUI.Dialogs.CustomizeCommitMessageDialog.DetailedCommitMessageFormat')
  - [Preview](#P-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-Preview 'MFR.GUI.Dialogs.CustomizeCommitMessageDialog.Preview')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.CustomizeCommitMessageDialog.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-InitializeComponent 'MFR.GUI.Dialogs.CustomizeCommitMessageDialog.InitializeComponent')
  - [OnFormClosing(e)](#M-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-OnFormClosing-System-Windows-Forms-FormClosingEventArgs- 'MFR.GUI.Dialogs.CustomizeCommitMessageDialog.OnFormClosing(System.Windows.Forms.FormClosingEventArgs)')
- [CustomizeOperationsDialog](#T-MFR-GUI-Dialogs-CustomizeOperationsDialog 'MFR.GUI.Dialogs.CustomizeOperationsDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-CustomizeOperationsDialog-#ctor 'MFR.GUI.Dialogs.CustomizeOperationsDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-CustomizeOperationsDialog-components 'MFR.GUI.Dialogs.CustomizeOperationsDialog.components')
  - [OperationListBuilder](#P-MFR-GUI-Dialogs-CustomizeOperationsDialog-OperationListBuilder 'MFR.GUI.Dialogs.CustomizeOperationsDialog.OperationListBuilder')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-CustomizeOperationsDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.CustomizeOperationsDialog.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-CustomizeOperationsDialog-InitializeComponent 'MFR.GUI.Dialogs.CustomizeOperationsDialog.InitializeComponent')
- [ErrorReportDialog](#T-MFR-GUI-Dialogs-ErrorReportDialog 'MFR.GUI.Dialogs.ErrorReportDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-ErrorReportDialog-#ctor 'MFR.GUI.Dialogs.ErrorReportDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-ErrorReportDialog-components 'MFR.GUI.Dialogs.ErrorReportDialog.components')
  - [ErrorReportContents](#P-MFR-GUI-Dialogs-ErrorReportDialog-ErrorReportContents 'MFR.GUI.Dialogs.ErrorReportDialog.ErrorReportContents')
  - [Exception](#P-MFR-GUI-Dialogs-ErrorReportDialog-Exception 'MFR.GUI.Dialogs.ErrorReportDialog.Exception')
  - [ReproductionSteps](#P-MFR-GUI-Dialogs-ErrorReportDialog-ReproductionSteps 'MFR.GUI.Dialogs.ErrorReportDialog.ReproductionSteps')
  - [ViewReportLinkLabel](#P-MFR-GUI-Dialogs-ErrorReportDialog-ViewReportLinkLabel 'MFR.GUI.Dialogs.ErrorReportDialog.ViewReportLinkLabel')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-ErrorReportDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.ErrorReportDialog.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-ErrorReportDialog-InitializeComponent 'MFR.GUI.Dialogs.ErrorReportDialog.InitializeComponent')
  - [OnClickSendReportButton(sender,e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnClickSendReportButton-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnClickSendReportButton(System.Object,System.EventArgs)')
  - [OnFormClosed(e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnFormClosed-System-Windows-Forms-FormClosedEventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnFormClosed(System.Windows.Forms.FormClosedEventArgs)')
  - [OnLinkClickedViewErrorReportLinkLabel(sender,e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnLinkClickedViewErrorReportLinkLabel-System-Object,System-Windows-Forms-LinkLabelLinkClickedEventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnLinkClickedViewErrorReportLinkLabel(System.Object,System.Windows.Forms.LinkLabelLinkClickedEventArgs)')
  - [OnLoad(e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnLoad-System-EventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnLoad(System.EventArgs)')
  - [OnSendErrorReportRequested(e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnSendErrorReportRequested-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnSendErrorReportRequested(MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs)')
  - [OnViewErrorReportRequested(e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnViewErrorReportRequested-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnViewErrorReportRequested(MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs)')
- [FolderSelectDialog](#T-MFR-GUI-Dialogs-FolderSelectDialog 'MFR.GUI.Dialogs.FolderSelectDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-FolderSelectDialog-#ctor 'MFR.GUI.Dialogs.FolderSelectDialog.#ctor')
  - [FileName](#P-MFR-GUI-Dialogs-FolderSelectDialog-FileName 'MFR.GUI.Dialogs.FolderSelectDialog.FileName')
  - [InitialDirectory](#P-MFR-GUI-Dialogs-FolderSelectDialog-InitialDirectory 'MFR.GUI.Dialogs.FolderSelectDialog.InitialDirectory')
  - [Title](#P-MFR-GUI-Dialogs-FolderSelectDialog-Title 'MFR.GUI.Dialogs.FolderSelectDialog.Title')
  - [Dispose()](#M-MFR-GUI-Dialogs-FolderSelectDialog-Dispose 'MFR.GUI.Dialogs.FolderSelectDialog.Dispose')
  - [InternalShowDialog()](#M-MFR-GUI-Dialogs-FolderSelectDialog-InternalShowDialog 'MFR.GUI.Dialogs.FolderSelectDialog.InternalShowDialog')
  - [InternalShowDialog(hWndOwner)](#M-MFR-GUI-Dialogs-FolderSelectDialog-InternalShowDialog-System-IntPtr- 'MFR.GUI.Dialogs.FolderSelectDialog.InternalShowDialog(System.IntPtr)')
  - [ShowDialog()](#M-MFR-GUI-Dialogs-FolderSelectDialog-ShowDialog 'MFR.GUI.Dialogs.FolderSelectDialog.ShowDialog')
  - [ShowDialog(owner)](#M-MFR-GUI-Dialogs-FolderSelectDialog-ShowDialog-System-Windows-Forms-IWin32Window- 'MFR.GUI.Dialogs.FolderSelectDialog.ShowDialog(System.Windows.Forms.IWin32Window)')
- [OperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-OperationDrivenProgressDialog 'MFR.GUI.Dialogs.OperationDrivenProgressDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-#ctor 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.#ctor')
  - [_worker](#F-MFR-GUI-Dialogs-OperationDrivenProgressDialog-_worker 'MFR.GUI.Dialogs.OperationDrivenProgressDialog._worker')
  - [components](#F-MFR-GUI-Dialogs-OperationDrivenProgressDialog-components 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.components')
  - [Argument](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Argument 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Argument')
  - [Proc](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Proc 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Proc')
  - [ProgressBar](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBar 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.ProgressBar')
  - [ProgressBarMaximum](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarMaximum 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.ProgressBarMaximum')
  - [ProgressBarMinimum](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarMinimum 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.ProgressBarMinimum')
  - [ProgressBarStyle](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarStyle 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.ProgressBarStyle')
  - [ProgressBarValue](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarValue 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.ProgressBarValue')
  - [Result](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Result 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Result')
  - [Status](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Status 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Status')
  - [Clear()](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Clear 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Clear')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Dispose(System.Boolean)')
  - [InitializeBackgroundWorker()](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-InitializeBackgroundWorker 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.InitializeBackgroundWorker')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-InitializeComponent 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.InitializeComponent')
  - [InitializeStartPosition()](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-InitializeStartPosition 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.InitializeStartPosition')
  - [OnDoWork(sender,e)](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnDoWork-System-Object,System-ComponentModel-DoWorkEventArgs- 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.OnDoWork(System.Object,System.ComponentModel.DoWorkEventArgs)')
  - [OnLoad(e)](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnLoad-System-EventArgs- 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.OnLoad(System.EventArgs)')
  - [OnRequestClose()](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnRequestClose 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.OnRequestClose')
  - [OnRunWorkerCompleted(sender,e)](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnRunWorkerCompleted-System-Object,System-ComponentModel-RunWorkerCompletedEventArgs- 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.OnRunWorkerCompleted(System.Object,System.ComponentModel.RunWorkerCompletedEventArgs)')
  - [OnShown(e)](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnShown-System-EventArgs- 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.OnShown(System.EventArgs)')
  - [RedrawDisplay()](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-RedrawDisplay 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.RedrawDisplay')
  - [Reset()](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Reset 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Reset')
  - [UpdateCaption(caption)](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-UpdateCaption-System-String- 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.UpdateCaption(System.String)')
- [OptionsDialog](#T-MFR-GUI-Dialogs-OptionsDialog 'MFR.GUI.Dialogs.OptionsDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-OptionsDialog-#ctor 'MFR.GUI.Dialogs.OptionsDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-OptionsDialog-components 'MFR.GUI.Dialogs.OptionsDialog.components')
  - [AutoQuitOnCompletion](#P-MFR-GUI-Dialogs-OptionsDialog-AutoQuitOnCompletion 'MFR.GUI.Dialogs.OptionsDialog.AutoQuitOnCompletion')
  - [CommitAuthorEmail](#P-MFR-GUI-Dialogs-OptionsDialog-CommitAuthorEmail 'MFR.GUI.Dialogs.OptionsDialog.CommitAuthorEmail')
  - [CommitAuthorName](#P-MFR-GUI-Dialogs-OptionsDialog-CommitAuthorName 'MFR.GUI.Dialogs.OptionsDialog.CommitAuthorName')
  - [ConfigPathname](#P-MFR-GUI-Dialogs-OptionsDialog-ConfigPathname 'MFR.GUI.Dialogs.OptionsDialog.ConfigPathname')
  - [ConfigProvider](#P-MFR-GUI-Dialogs-OptionsDialog-ConfigProvider 'MFR.GUI.Dialogs.OptionsDialog.ConfigProvider')
  - [CurrentConfiguration](#P-MFR-GUI-Dialogs-OptionsDialog-CurrentConfiguration 'MFR.GUI.Dialogs.OptionsDialog.CurrentConfiguration')
  - [DontPromptUserToReloadOpenSolution](#P-MFR-GUI-Dialogs-OptionsDialog-DontPromptUserToReloadOpenSolution 'MFR.GUI.Dialogs.OptionsDialog.DontPromptUserToReloadOpenSolution')
  - [ErrantProcesses](#P-MFR-GUI-Dialogs-OptionsDialog-ErrantProcesses 'MFR.GUI.Dialogs.OptionsDialog.ErrantProcesses')
  - [HasErrantProcesses](#P-MFR-GUI-Dialogs-OptionsDialog-HasErrantProcesses 'MFR.GUI.Dialogs.OptionsDialog.HasErrantProcesses')
  - [IsErrantProcessSelected](#P-MFR-GUI-Dialogs-OptionsDialog-IsErrantProcessSelected 'MFR.GUI.Dialogs.OptionsDialog.IsErrantProcessSelected')
  - [IsModified](#P-MFR-GUI-Dialogs-OptionsDialog-IsModified 'MFR.GUI.Dialogs.OptionsDialog.IsModified')
  - [PushChangesToRemoteWhenDone](#P-MFR-GUI-Dialogs-OptionsDialog-PushChangesToRemoteWhenDone 'MFR.GUI.Dialogs.OptionsDialog.PushChangesToRemoteWhenDone')
  - [ReOpenSolution](#P-MFR-GUI-Dialogs-OptionsDialog-ReOpenSolution 'MFR.GUI.Dialogs.OptionsDialog.ReOpenSolution')
  - [SelectedErrantProcess](#P-MFR-GUI-Dialogs-OptionsDialog-SelectedErrantProcess 'MFR.GUI.Dialogs.OptionsDialog.SelectedErrantProcess')
  - [ShouldCommitPendingChanges](#P-MFR-GUI-Dialogs-OptionsDialog-ShouldCommitPendingChanges 'MFR.GUI.Dialogs.OptionsDialog.ShouldCommitPendingChanges')
  - [ShouldCommitPostOperationChanges](#P-MFR-GUI-Dialogs-OptionsDialog-ShouldCommitPostOperationChanges 'MFR.GUI.Dialogs.OptionsDialog.ShouldCommitPostOperationChanges')
  - [UpdateGitOnAutoStart](#P-MFR-GUI-Dialogs-OptionsDialog-UpdateGitOnAutoStart 'MFR.GUI.Dialogs.OptionsDialog.UpdateGitOnAutoStart')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-OptionsDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.OptionsDialog.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-OptionsDialog-InitializeComponent 'MFR.GUI.Dialogs.OptionsDialog.InitializeComponent')
  - [OnAnyCheckBoxCheckedChanged(sender,e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnAnyCheckBoxCheckedChanged-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnAnyCheckBoxCheckedChanged(System.Object,System.EventArgs)')
  - [OnAnyTextBoxChanged(sender,e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnAnyTextBoxChanged-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnAnyTextBoxChanged(System.Object,System.EventArgs)')
  - [OnClickApply(sender,e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnClickApply-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnClickApply(System.Object,System.EventArgs)')
  - [OnClickConfigPathnameBrowseButton(sender,e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnClickConfigPathnameBrowseButton-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnClickConfigPathnameBrowseButton(System.Object,System.EventArgs)')
  - [OnFormClosing(e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnFormClosing-System-Windows-Forms-FormClosingEventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnFormClosing(System.Windows.Forms.FormClosingEventArgs)')
  - [OnLoad(e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnLoad-System-EventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnLoad(System.EventArgs)')
  - [OnModified(e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnModified-MFR-GUI-Dialogs-Events-ModifiedEventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnModified(MFR.GUI.Dialogs.Events.ModifiedEventArgs)')
  - [OnShown(e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnShown-System-EventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnShown(System.EventArgs)')
  - [OnUpdateCmdUI(sender,e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnUpdateCmdUI-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnUpdateCmdUI(System.Object,System.EventArgs)')
  - [SetModifiedFlag(dirty)](#M-MFR-GUI-Dialogs-OptionsDialog-SetModifiedFlag-System-Boolean- 'MFR.GUI.Dialogs.OptionsDialog.SetModifiedFlag(System.Boolean)')
  - [UpdateData(bSaveAndValidate)](#M-MFR-GUI-Dialogs-OptionsDialog-UpdateData-System-Boolean- 'MFR.GUI.Dialogs.OptionsDialog.UpdateData(System.Boolean)')
- [ProfileManagementDialogBox](#T-MFR-GUI-Dialogs-ProfileManagementDialogBox 'MFR.GUI.Dialogs.ProfileManagementDialogBox')
  - [#ctor()](#M-MFR-GUI-Dialogs-ProfileManagementDialogBox-#ctor 'MFR.GUI.Dialogs.ProfileManagementDialogBox.#ctor')
  - [components](#F-MFR-GUI-Dialogs-ProfileManagementDialogBox-components 'MFR.GUI.Dialogs.ProfileManagementDialogBox.components')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-ProfileManagementDialogBox-Dispose-System-Boolean- 'MFR.GUI.Dialogs.ProfileManagementDialogBox.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-ProfileManagementDialogBox-InitializeComponent 'MFR.GUI.Dialogs.ProfileManagementDialogBox.InitializeComponent')
- [ProfileNameDialog](#T-MFR-GUI-Dialogs-ProfileNameDialog 'MFR.GUI.Dialogs.ProfileNameDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-ProfileNameDialog-#ctor 'MFR.GUI.Dialogs.ProfileNameDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-ProfileNameDialog-components 'MFR.GUI.Dialogs.ProfileNameDialog.components')
  - [OperationType](#P-MFR-GUI-Dialogs-ProfileNameDialog-OperationType 'MFR.GUI.Dialogs.ProfileNameDialog.OperationType')
  - [ProfileName](#P-MFR-GUI-Dialogs-ProfileNameDialog-ProfileName 'MFR.GUI.Dialogs.ProfileNameDialog.ProfileName')
  - [ProfileProvider](#P-MFR-GUI-Dialogs-ProfileNameDialog-ProfileProvider 'MFR.GUI.Dialogs.ProfileNameDialog.ProfileProvider')
  - [CanClose()](#M-MFR-GUI-Dialogs-ProfileNameDialog-CanClose 'MFR.GUI.Dialogs.ProfileNameDialog.CanClose')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-ProfileNameDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.ProfileNameDialog.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-ProfileNameDialog-InitializeComponent 'MFR.GUI.Dialogs.ProfileNameDialog.InitializeComponent')
  - [OnClickReadMoreAboutProfilesLinkLabel(sender,e)](#M-MFR-GUI-Dialogs-ProfileNameDialog-OnClickReadMoreAboutProfilesLinkLabel-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.ProfileNameDialog.OnClickReadMoreAboutProfilesLinkLabel(System.Object,System.EventArgs)')
  - [OnFormClosing(e)](#M-MFR-GUI-Dialogs-ProfileNameDialog-OnFormClosing-System-Windows-Forms-FormClosingEventArgs- 'MFR.GUI.Dialogs.ProfileNameDialog.OnFormClosing(System.Windows.Forms.FormClosingEventArgs)')
  - [OnLoad(e)](#M-MFR-GUI-Dialogs-ProfileNameDialog-OnLoad-System-EventArgs- 'MFR.GUI.Dialogs.ProfileNameDialog.OnLoad(System.EventArgs)')
- [Resources](#T-MFR-GUI-Dialogs-Properties-Resources 'MFR.GUI.Dialogs.Properties.Resources')
  - [Culture](#P-MFR-GUI-Dialogs-Properties-Resources-Culture 'MFR.GUI.Dialogs.Properties.Resources.Culture')
  - [Error_CommitMessageRequired](#P-MFR-GUI-Dialogs-Properties-Resources-Error_CommitMessageRequired 'MFR.GUI.Dialogs.Properties.Resources.Error_CommitMessageRequired')
  - [Error_ErrantProcessEntryAlreadyPresent](#P-MFR-GUI-Dialogs-Properties-Resources-Error_ErrantProcessEntryAlreadyPresent 'MFR.GUI.Dialogs.Properties.Resources.Error_ErrantProcessEntryAlreadyPresent')
  - [Error_FailedAddErrantProcessEntry](#P-MFR-GUI-Dialogs-Properties-Resources-Error_FailedAddErrantProcessEntry 'MFR.GUI.Dialogs.Properties.Resources.Error_FailedAddErrantProcessEntry')
  - [Error_FailedEditErrantProcessEntry](#P-MFR-GUI-Dialogs-Properties-Resources-Error_FailedEditErrantProcessEntry 'MFR.GUI.Dialogs.Properties.Resources.Error_FailedEditErrantProcessEntry')
  - [Error_FailedRemoveAllErrantProcesses](#P-MFR-GUI-Dialogs-Properties-Resources-Error_FailedRemoveAllErrantProcesses 'MFR.GUI.Dialogs.Properties.Resources.Error_FailedRemoveAllErrantProcesses')
  - [Error_FailedRemoveErrantProcessEntry](#P-MFR-GUI-Dialogs-Properties-Resources-Error_FailedRemoveErrantProcessEntry 'MFR.GUI.Dialogs.Properties.Resources.Error_FailedRemoveErrantProcessEntry')
  - [Error_NoErrantProcessEntryPathname](#P-MFR-GUI-Dialogs-Properties-Resources-Error_NoErrantProcessEntryPathname 'MFR.GUI.Dialogs.Properties.Resources.Error_NoErrantProcessEntryPathname')
  - [Error_NoErrantProcessSelectedForEditing](#P-MFR-GUI-Dialogs-Properties-Resources-Error_NoErrantProcessSelectedForEditing 'MFR.GUI.Dialogs.Properties.Resources.Error_NoErrantProcessSelectedForEditing')
  - [Error_NoErrantProcessToBeRemovedIsSelected](#P-MFR-GUI-Dialogs-Properties-Resources-Error_NoErrantProcessToBeRemovedIsSelected 'MFR.GUI.Dialogs.Properties.Resources.Error_NoErrantProcessToBeRemovedIsSelected')
  - [Error_NoErrantProcessesToEdit](#P-MFR-GUI-Dialogs-Properties-Resources-Error_NoErrantProcessesToEdit 'MFR.GUI.Dialogs.Properties.Resources.Error_NoErrantProcessesToEdit')
  - [Error_NoErrantProcessesToRemove](#P-MFR-GUI-Dialogs-Properties-Resources-Error_NoErrantProcessesToRemove 'MFR.GUI.Dialogs.Properties.Resources.Error_NoErrantProcessesToRemove')
  - [Error_ValueCannotBeNullOrWhiteSpace](#P-MFR-GUI-Dialogs-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace 'MFR.GUI.Dialogs.Properties.Resources.Error_ValueCannotBeNullOrWhiteSpace')
  - [FolderSelectDialogFilters](#P-MFR-GUI-Dialogs-Properties-Resources-FolderSelectDialogFilters 'MFR.GUI.Dialogs.Properties.Resources.FolderSelectDialogFilters')
  - [Question_ConfirmRemoveAllErrantProcesses](#P-MFR-GUI-Dialogs-Properties-Resources-Question_ConfirmRemoveAllErrantProcesses 'MFR.GUI.Dialogs.Properties.Resources.Question_ConfirmRemoveAllErrantProcesses')
  - [ResourceManager](#P-MFR-GUI-Dialogs-Properties-Resources-ResourceManager 'MFR.GUI.Dialogs.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Dialogs-AboutDialog'></a>
## AboutDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Dialog box that displays information about this application to the user.

<a name='M-MFR-GUI-Dialogs-AboutDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[AboutDialog](#T-MFR-GUI-Dialogs-AboutDialog 'MFR.GUI.Dialogs.AboutDialog')
and returns a reference
to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-AboutDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-AboutDialog-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets the name of the company that produced this software.

<a name='P-MFR-GUI-Dialogs-AboutDialog-AssemblyCopyright'></a>
### AssemblyCopyright `property`

##### Summary

Gets the copyright string for this application.

<a name='P-MFR-GUI-Dialogs-AboutDialog-AssemblyDescription'></a>
### AssemblyDescription `property`

##### Summary

Gets the description of this application.

<a name='P-MFR-GUI-Dialogs-AboutDialog-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets the product name of the application.

<a name='P-MFR-GUI-Dialogs-AboutDialog-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets the title string for this application.

<a name='P-MFR-GUI-Dialogs-AboutDialog-AssemblyVersion'></a>
### AssemblyVersion `property`

##### Summary

Gets the full version of the application.

<a name='P-MFR-GUI-Dialogs-AboutDialog-CreateParams'></a>
### CreateParams `property`

##### Summary

Gets the required creation parameters when the control handle is
created.

##### Returns

A [CreateParams](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CreateParams 'System.Windows.Forms.CreateParams') that contains the
required creation parameters when the handle to the control is created.

<a name='M-MFR-GUI-Dialogs-AboutDialog-Display-System-Windows-Forms-IWin32Window-'></a>
### Display(owner) `method`

##### Summary

Displays this dialog box and does not return until the user has
dismissed it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Optional.) Reference to an instance of an object that implements
the [IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface and
which represents the parent window of this dialog box. |

<a name='M-MFR-GUI-Dialogs-AboutDialog-Dispose-System-Boolean-'></a>
### Dispose() `method`

##### Summary

Clean up any resources being used.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-AboutDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog'></a>
## AutoStartCancellableProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Variant of the [CancellableProgressDialog](#T-MFR-GUI-Dialogs-CancellableProgressDialog 'MFR.GUI.Dialogs.CancellableProgressDialog') that
can be used when the user specifies the `--autoStart` flag on the command
line.

##### Remarks

This class hosts a `FileRenamer` component that can perform the
user's requested operations itself.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-_processingWorker'></a>
### _processingWorker `constants`

##### Summary

Reference to an instance of
[BackgroundWorker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.BackgroundWorker 'System.ComponentModel.BackgroundWorker') that runs the
`FileRenamer` component in a worker thread.

<a name='P-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

<a name='P-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface that represents the currently-loaded config.

<a name='P-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-FileRenamer'></a>
### FileRenamer `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileRenamer](#T-MFR-Renamers-Files-Interfaces-IFileRenamer 'MFR.Renamers.Files.Interfaces.IFileRenamer') interface.

<a name='P-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IAutoStartCancellableProgressDialog](#T-MFR-GUI-Dialogs-IAutoStartCancellableProgressDialog 'MFR.GUI.Dialogs.IAutoStartCancellableProgressDialog') interface.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-HandleFilesCountedEvent-System-Int32-'></a>
### HandleFilesCountedEvent(count) `method`

##### Summary

Called when the count of files to be processed in a given operation
is computed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Integer value specifying the count of files that are to
be processed in the current operation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the `count` parameter is zero or
negative. This parameter describes a count of files; therefore, it
is expected that it should be 1 or greater. |

##### Remarks

Takes the message of resetting the progress dialog and reconfiguring
the progress bar such that the `count` parameter
specifies the new maximum value of the progress bar.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-IncrementProgressBar-System-String,System-String-'></a>
### IncrementProgressBar(statusLabelText,currentFileLabelText) `method`

##### Summary

Increments the value of the progress bar. Also updates the status
text and the label that is displaying the pathname to the file that
is currently being processed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| statusLabelText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text that is to be displayed on
the top line of the progress dialog. This text serves to inform the
user as to which operation is currently being performed. |
| currentFileLabelText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname to the file that is
currently being processed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`statusLabelText`
or `currentFileLabelText`,
are passed blank or `null` string for values. |

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-InitializeFileRenamer'></a>
### InitializeFileRenamer() `method`

##### Summary

Sets the properties of the [FileRenamer](#T-MFR-Renamers-Files-FileRenamer 'MFR.Renamers.Files.FileRenamer')
object that we are working
with and subscribes to the events that it emits.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-InitializeProcessingWorker'></a>
### InitializeProcessingWorker() `method`

##### Summary

Initializes the settings for the
[BackgroundWorker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.BackgroundWorker 'System.ComponentModel.BackgroundWorker') that is used to process
the file-renaming operations.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerExceptionRaised-System-Object,MFR-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnFileRenamerExceptionRaised(sender,e) `method`

##### Summary

Handles the [](#E-MFR-IFileRenamer-ExceptionRaised 'MFR.IFileRenamer.ExceptionRaised') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Events.Common.ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs') | An [ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs') that contains
the event data. |

##### Remarks

This method responds to such an event by showing the user a message
box, logging the error, and then aborting the operation.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerFilesToBeRenamedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFileRenamerFilesToBeRenamedCounted(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-IFileRenamer-FilesToBeRenamedCounted 'MFR.IFileRenamer.FilesToBeRenamedCounted')
event
raised by the file renamer object when it's finished determining the
set of file system entries upon which the current operation should act.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') that
contains the event data. |

##### Remarks

This method responds by resetting the progress dialog's progress bar
back to zero, and then updating the value of its
[Maximum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ProgressBar.Maximum 'System.Windows.Forms.ProgressBar.Maximum')
property to have
the same value as the count of file system entries.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerFilesToHaveTextReplacedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFileRenamerFilesToHaveTextReplacedCounted(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-IFileRenamer-FilesToHaveTextReplacedCounted 'MFR.IFileRenamer.FilesToHaveTextReplacedCounted')
event raised by the File Renamer object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') that
contains the event data. |

##### Remarks

This method responds by resetting the progress dialog's progress bar
back to zero, and then updating the value of its
[Maximum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ProgressBar.Maximum 'System.Windows.Forms.ProgressBar.Maximum')
property to have
the same value as the count of file system entries.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerFinished'></a>
### OnFileRenamerFinished() `method`

##### Summary

Handles the
[](#E-MFR-IFileRenamer-OperationFinished 'MFR.IFileRenamer.OperationFinished')
event raised
by the file renamer object.

##### Parameters

This method has no parameters.

##### Remarks

This method responds to the event by telling the progress dialog to
reset the progress bar back to the starting point.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerOperationFinished-System-Object,MFR-Operations-Events-OperationFinishedEventArgs-'></a>
### OnFileRenamerOperationFinished(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-IFileRenamer-OperationFinished 'MFR.IFileRenamer.OperationFinished')
event raised
by the file renamer object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Operations.Events.OperationFinishedEventArgs](#T-MFR-Operations-Events-OperationFinishedEventArgs 'MFR.Operations.Events.OperationFinishedEventArgs') | A [OperationFinishedEventArgs](#T-MFR-Operations-Events-OperationFinishedEventArgs 'MFR.Operations.Events.OperationFinishedEventArgs') that
contains the event data. |

##### Remarks

This method responds to the event by telling the progress dialog to
reset the progress bar back to the starting point.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerOperationStarted-System-Object,MFR-Operations-Events-OperationStartedEventArgs-'></a>
### OnFileRenamerOperationStarted(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-IFileRenamer-OperationStarted 'MFR.IFileRenamer.OperationStarted')
event raised by
the file-renamer object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Operations.Events.OperationStartedEventArgs](#T-MFR-Operations-Events-OperationStartedEventArgs 'MFR.Operations.Events.OperationStartedEventArgs') | A [OperationStartedEventArgs](#T-MFR-Operations-Events-OperationStartedEventArgs 'MFR.Operations.Events.OperationStartedEventArgs') that
contains the event data. |

##### Remarks

This method responds to the event by telling the progress dialog to
show the marquee progress bar for the operation type whose
processing is now being started.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerPendingChangesToBeCommittedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFileRenamerPendingChangesToBeCommittedCounted(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Renamers-Files-Interfaces-IFileRenamer-SubfoldersToBeRenamedCounted 'MFR.Renamers.Files.Interfaces.IFileRenamer.SubfoldersToBeRenamedCounted')
event raised by the File Renamer object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') that
contains the event data. |

##### Remarks

This method responds by resetting the progress dialog's progress bar
back to zero, and then updating the value of its
[Maximum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ProgressBar.Maximum 'System.Windows.Forms.ProgressBar.Maximum')
property to have
the same value as the count of file system entries.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerProcessingOperation-System-Object,MFR-Operations-Events-ProcessingOperationEventArgs-'></a>
### OnFileRenamerProcessingOperation(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-IFileRenamer-ProcessingOperation 'MFR.IFileRenamer.ProcessingOperation')
event raised
by the File Renamer object when it moves on to processing the next
file system entry in its list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Operations.Events.ProcessingOperationEventArgs](#T-MFR-Operations-Events-ProcessingOperationEventArgs 'MFR.Operations.Events.ProcessingOperationEventArgs') | A [ProcessingOperationEventArgs](#T-MFR-ProcessingOperationEventArgs 'MFR.ProcessingOperationEventArgs') that
contains the event data. |

##### Remarks

This method responds by first checking the values passed in the
[ProcessingOperationEventArgs](#T-MFR-ProcessingOperationEventArgs 'MFR.ProcessingOperationEventArgs')
for valid values.



If the checks fail, then this method does nothing.



Otherwise, the method responds by incrementing the progress dialog's
progress bar to the next notch, and updating the text of the lower
status label in the progress dialog to contain the path to the file
currently being worked on.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerResultsToBeCommittedToGitCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFileRenamerResultsToBeCommittedToGitCounted(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Renamers-Files-Interfaces-IFileRenamer-ResultsToBeCommittedToGitCounted 'MFR.Renamers.Files.Interfaces.IFileRenamer.ResultsToBeCommittedToGitCounted')
event raised by the File Renamer object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') that
contains the event data. |

##### Remarks

This method responds by resetting the progress dialog's progress bar
back to zero, and then updating the value of its
[Maximum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ProgressBar.Maximum 'System.Windows.Forms.ProgressBar.Maximum')
property to have
the same value as the count of file system entries.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerSolutionFoldersToBeRenamedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFileRenamerSolutionFoldersToBeRenamedCounted(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Renamers-Files-Interfaces-IFileRenamer-SubfoldersToBeRenamedCounted 'MFR.Renamers.Files.Interfaces.IFileRenamer.SubfoldersToBeRenamedCounted')
event raised by the File Renamer object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') that
contains the event data. |

##### Remarks

This method responds by resetting the progress dialog's progress bar
back to zero, and then updating the value of its
[Maximum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ProgressBar.Maximum 'System.Windows.Forms.ProgressBar.Maximum')
property to have
the same value as the count of file system entries.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerStatusUpdate-System-Object,MFR-Events-Common-StatusUpdateEventArgs-'></a>
### OnFileRenamerStatusUpdate(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Renamers-Files-Interfaces-IFileRenamer-StatusUpdate 'MFR.Renamers.Files.Interfaces.IFileRenamer.StatusUpdate') event
raised by the `FileRenamer` component when it has new text to send to the
UI/UX of the application..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [MFR.Events.Common.StatusUpdateEventArgs](#T-MFR-Events-Common-StatusUpdateEventArgs 'MFR.Events.Common.StatusUpdateEventArgs') | A [StatusUpdateEventArgs](#T-MFR-Events-Common-StatusUpdateEventArgs 'MFR.Events.Common.StatusUpdateEventArgs') that
contains the event data. |

##### Remarks



<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnFileRenamerSubfoldersToBeRenamedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFileRenamerSubfoldersToBeRenamedCounted(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Renamers-Files-Interfaces-IFileRenamer-SubfoldersToBeRenamedCounted 'MFR.Renamers.Files.Interfaces.IFileRenamer.SubfoldersToBeRenamedCounted')
event raised by the File Renamer object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') that
contains the event data. |

##### Remarks

This method responds by resetting the progress dialog's progress bar
back to zero, and then updating the value of its
[Maximum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ProgressBar.Maximum 'System.Windows.Forms.ProgressBar.Maximum')
property to have
the same value as the count of file system entries.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnProcessingWorkerDoWork-System-Object,System-ComponentModel-DoWorkEventArgs-'></a>
### OnProcessingWorkerDoWork(sender,e) `method`

##### Summary

Handles the [](#E-System-ComponentModel-BackgroundWorker-DoWork 'System.ComponentModel.BackgroundWorker.DoWork')
event raised by the Processing Worker that invokes the File Renamer.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.ComponentModel.DoWorkEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DoWorkEventArgs 'System.ComponentModel.DoWorkEventArgs') | A [DoWorkEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DoWorkEventArgs 'System.ComponentModel.DoWorkEventArgs') that
contains the event data. |

##### Remarks

This method is called to process a File Renamer job in a background
thread.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnProcessingWorkerRunWorkerCompleted-System-Object,System-ComponentModel-RunWorkerCompletedEventArgs-'></a>
### OnProcessingWorkerRunWorkerCompleted(sender,e) `method`

##### Summary

Handles the
[](#E-System-ComponentModel-BackgroundWorker-RunWorkerCompleted 'System.ComponentModel.BackgroundWorker.RunWorkerCompleted')
event raised by the Processing Worker that actually invokes the File Renamer.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.ComponentModel.RunWorkerCompletedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.RunWorkerCompletedEventArgs 'System.ComponentModel.RunWorkerCompletedEventArgs') | A
[RunWorkerCompletedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.RunWorkerCompletedEventArgs 'System.ComponentModel.RunWorkerCompletedEventArgs') that
contains the event data. |

##### Remarks

This method responds by raising the
[](#E-MFR-Engines-Interfaces-IOperationEngine-ProcessingFinished 'MFR.Engines.Interfaces.IOperationEngine.ProcessingFinished')
event and associated message.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-OnShown-System-EventArgs-'></a>
### OnShown(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Shown 'System.Windows.Forms.Form.Shown') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-ResetProgressBar'></a>
### ResetProgressBar() `method`

##### Summary

Resets the progress bar back to the beginning.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-AutoStartCancellableProgressDialog-ShowCalculatingProgressBar-System-String,System-Boolean-'></a>
### ShowCalculatingProgressBar(text,canCancel) `method`

##### Summary

Shows a marquee progress bar that indicates the application is
performing work but of an indeterminate length, such as calculating
the amount of files to process.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to display in the progress dialog. |
| canCancel | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) `true` to show a button in
the progress dialog; `false` to hide it. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `text`, is passed
a blank or `null` string for a value. |

<a name='T-MFR-GUI-Dialogs-CancellableProgressDialog'></a>
## CancellableProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Window that displays progress of an operation.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[CancellableProgressDialog](#T-MFR-GUI-Dialogs-CancellableProgressDialog 'MFR.GUI.Dialogs.CancellableProgressDialog')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-CancellableProgressDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-CanCancel'></a>
### CanCancel `property`

##### Summary

Gets or sets a value indicating whether the operation can be cancelled.

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-CurrentFile'></a>
### CurrentFile `property`

##### Summary

Gets or sets a string containing the new detailed status.

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBar'></a>
### ProgressBar `property`

##### Summary

Gets a reference to the progress bar control.

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarMaximum'></a>
### ProgressBarMaximum `property`

##### Summary

Gets or sets the maximum value of the range of the progress bar control.

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarMinimum'></a>
### ProgressBarMinimum `property`

##### Summary

Get or sets the minimum value of the range of the progress bar control.

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarStyle'></a>
### ProgressBarStyle `property`

##### Summary

Gets or sets the manner in which progress should

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarValue'></a>
### ProgressBarValue `property`

##### Summary

Gets or sets the current position of the progress bar.

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-Status'></a>
### Status `property`

##### Summary

Gets or sets a string containing the new status.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-DoSetProgressBarMaximum-System-Int32-'></a>
### DoSetProgressBarMaximum(value) `method`

##### Summary

Sets the value of the [Maximum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ProgressBar.Maximum 'System.Windows.Forms.ProgressBar.Maximum')
property but only after first checking that the argument of the
`value` parameter falls within a valid range.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) An [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') that specifies
the new value of the progress bar's maximum limit. |

##### Remarks

This method stops if (a) the argument of the `value`
parameter is negative (i.e., we do not know what a negative maximum value means
in the context of a progress bar), or (b) if the argument of the
`value` parameter is less than, or equal to, the value of the
[ProgressBarMinimum](#P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarMinimum 'MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarMinimum')
property, or (c) if the argument of the `value` parameter is
less than the value of the
[ProgressBarValue](#P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarValue 'MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarValue')
property.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-DoSetProgressBarMinimum-System-Int32-'></a>
### DoSetProgressBarMinimum(value) `method`

##### Summary

Sets the value of the [Minimum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ProgressBar.Minimum 'System.Windows.Forms.ProgressBar.Minimum')
property but only after first checking that the argument of the
`value` parameter falls within a valid range.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) An [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') that specifies the new value of
the
progress bar's minimum limit. |

##### Remarks

This method stops if (a) the argument of the `value`
parameter is negative (i.e., we do not know what a negative minimum value means
in the context of a progress bar), or (b) if the argument of the
`value` parameter is greater than, or equal to, the value of
the [Maximum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ProgressBar.Maximum 'System.Windows.Forms.ProgressBar.Maximum') property.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-DoSetProgressBarValue-System-Int32-'></a>
### DoSetProgressBarValue(value) `method`

##### Summary

Sets the value of the [Value](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ProgressBar.Value 'System.Windows.Forms.ProgressBar.Value')
property after first checking that the argument of the
`value` parameter is in the proper range, i.e., between the
minimum and maximum, inclusive.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) An [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') value that
specifies the new value of the progress of an operation. |

##### Remarks

This method stops if any of the following are true: (a) if the argument of the
`value` parameter is a negative number (we don't know how to
display negative progress), or (b) if the argument of the
`value` parameter is less than the value of the
[ProgressBarMinimum](#P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarMinimum 'MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarMinimum')
property, or (c) if the argument of the `value` parameter is
greater than the value of the
[ProgressBarMaximum](#P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarMaximum 'MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarMaximum')
property.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-OnCancel-System-Object,System-EventArgs-'></a>
### OnCancel(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event
for the Cancel button.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called when the user chooses the Cancel button or
presses the ESCAPE key. This method responds merely by raising the
[](#E-MFR-GUI-CancellableProgressDialog-CancelRequested 'MFR.GUI.CancellableProgressDialog.CancelRequested')
event. This event directs the caller of this dialog box to attempt
to abort the operation and close down this dialog box from its GUI thread.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-OnCancelRequested'></a>
### OnCancelRequested() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Dialogs-CancellableProgressDialog-CancelRequested 'MFR.GUI.Dialogs.CancellableProgressDialog.CancelRequested')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method sets the title of the dialog to match the application's name.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-OnShown-System-EventArgs-'></a>
### OnShown(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Shown 'System.Windows.Forms.Form.Shown') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-RedrawDisplay'></a>
### RedrawDisplay() `method`

##### Summary

Directs the application to update the user's display.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-Reset'></a>
### Reset() `method`

##### Summary

Clears the status text and progress bar.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-CustomizeCommitMessageDialog'></a>
## CustomizeCommitMessageDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Represents a dialog box that gathers input from the user.



This dialog box has a Dark theme.

<a name='M-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[CustomizeCommitMessageDialogBox](#T-MFR-GUI-Dialogs-CustomizeCommitMessageDialogBox 'MFR.GUI.Dialogs.CustomizeCommitMessageDialogBox') and returns a
reference to
it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-CommitMessageFormat'></a>
### CommitMessageFormat `property`

##### Summary

Gets or sets the value of the text box.

<a name='P-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-CommitMessageMapper'></a>
### CommitMessageMapper `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IConfigurationStringMapper](#T-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper 'MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper')
interface for commit messages.

<a name='P-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-DetailedCommitMessageFormat'></a>
### DetailedCommitMessageFormat `property`

##### Summary

Gets or sets the value of the text box.

<a name='P-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-Preview'></a>
### Preview `property`

##### Summary

Gets or sets the value of the text box.

<a name='M-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-CustomizeCommitMessageDialog-OnFormClosing-System-Windows-Forms-FormClosingEventArgs-'></a>
### OnFormClosing(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-FormClosing 'System.Windows.Forms.Form.FormClosing')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Windows.Forms.FormClosingEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosingEventArgs 'System.Windows.Forms.FormClosingEventArgs') | A [FormClosingEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosingEventArgs 'System.Windows.Forms.FormClosingEventArgs')
that contains the event data. |

<a name='T-MFR-GUI-Dialogs-CustomizeOperationsDialog'></a>
## CustomizeOperationsDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Dialog box that is displayed when the user clicks the button
in the tab of the main window.

##### Remarks

This dialog box allows the user to customize the list of primary operations tha
this application performs, to make some operations available and others not.

<a name='M-MFR-GUI-Dialogs-CustomizeOperationsDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[CustomizeOperationsDialog](#T-MFR-GUI-Dialogs-CustomizeOperationsDialog 'MFR.GUI.Dialogs.CustomizeOperationsDialog') and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-CustomizeOperationsDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-CustomizeOperationsDialog-OperationListBuilder'></a>
### OperationListBuilder `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IDarkListBuilderControl](#T-xyLOGIX-UI-Dark-Controls-Interfaces-IDarkListBuilderControl 'xyLOGIX.UI.Dark.Controls.Interfaces.IDarkListBuilderControl')
interface.

<a name='M-MFR-GUI-Dialogs-CustomizeOperationsDialog-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-CustomizeOperationsDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-ErrorReportDialog'></a>
## ErrorReportDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Displays information to the user about an exception or error.

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ErrorReportDialog](#T-MFR-GUI-Dialogs-ErrorReportDialog 'MFR.GUI.Dialogs.ErrorReportDialog')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-ErrorReportDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-ErrorReportDialog-ErrorReportContents'></a>
### ErrorReportContents `property`

##### Summary

Gets a string that contains the contents of an error report, given the value of
the [Exception](#P-MFR-GUI-Dialogs-ErrorReportDialog-Exception 'MFR.GUI.Dialogs.ErrorReportDialog.Exception') property.

<a name='P-MFR-GUI-Dialogs-ErrorReportDialog-Exception'></a>
### Exception `property`

##### Summary

Gets or sets the [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes the error
that occurred.

<a name='P-MFR-GUI-Dialogs-ErrorReportDialog-ReproductionSteps'></a>
### ReproductionSteps `property`

##### Summary

Gets or sets the value of the text box.

<a name='P-MFR-GUI-Dialogs-ErrorReportDialog-ViewReportLinkLabel'></a>
### ViewReportLinkLabel `property`

##### Summary

Gets a reference to the View Report link-label control.

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-OnClickSendReportButton-System-Object,System-EventArgs-'></a>
### OnClickSendReportButton(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event raised by
the Send Report button.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method responds by raising the
[](#E-MFR-GUI-Dialogs-ErrorReportDialog-SendErrorReportRequested 'MFR.GUI.Dialogs.ErrorReportDialog.SendErrorReportRequested')
event.



Doing so allows the invoker of this dialog to decide how to carry out the
action.

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-OnFormClosed-System-Windows-Forms-FormClosedEventArgs-'></a>
### OnFormClosed(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-FormClosed 'System.Windows.Forms.Form.FormClosed') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Windows.Forms.FormClosedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosedEventArgs 'System.Windows.Forms.FormClosedEventArgs') | A [FormClosedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosedEventArgs 'System.Windows.Forms.FormClosedEventArgs') that
contains the event data. |

##### Remarks

This override forcibly terminates the application by calling
[Exit](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Environment.Exit 'System.Environment.Exit')
with an exit code of `-1`.

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-OnLinkClickedViewErrorReportLinkLabel-System-Object,System-Windows-Forms-LinkLabelLinkClickedEventArgs-'></a>
### OnLinkClickedViewErrorReportLinkLabel(sender,e) `method`

##### Summary

Handles the
[](#E-System-Windows-Forms-LinkLabel-LinkClicked 'System.Windows.Forms.LinkLabel.LinkClicked')
event raised
by the View Report hyperlink.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.Windows.Forms.LinkLabelLinkClickedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.LinkLabelLinkClickedEventArgs 'System.Windows.Forms.LinkLabelLinkClickedEventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds by raising the
[](#E-MFR-GUI-Dialogs-ErrorReportDialog-ViewErrorReportRequested 'MFR.GUI.Dialogs.ErrorReportDialog.ViewErrorReportRequested')
event.



Doing this allows the caller of this dialog to attach their own custom
event-handling logic.

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-OnSendErrorReportRequested-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-'></a>
### OnSendErrorReportRequested(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-Dialogs-ErrorReportDialog-SendErrorReportRequested 'MFR.GUI.Dialogs.ErrorReportDialog.SendErrorReportRequested')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs') | A [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that contains the event
data. |

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-OnViewErrorReportRequested-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs-'></a>
### OnViewErrorReportRequested(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-Dialogs-ErrorReportDialog-ViewErrorReportRequested 'MFR.GUI.Dialogs.ErrorReportDialog.ViewErrorReportRequested')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs') | A
[ViewErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs') that
contains the event data. |

<a name='T-MFR-GUI-Dialogs-FolderSelectDialog'></a>
## FolderSelectDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Wraps System.Windows.Forms.OpenFileDialog to make it present a
vista-style Folder Select dialog.

<a name='M-MFR-GUI-Dialogs-FolderSelectDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs an instance of [FolderSelectDialog](#T-MFR-GUI-Dialogs-FolderSelectDialog 'MFR.GUI.Dialogs.FolderSelectDialog')
and returns a
reference to the new instance.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-GUI-Dialogs-FolderSelectDialog-FileName'></a>
### FileName `property`

##### Summary

Gets the selected folder

<a name='P-MFR-GUI-Dialogs-FolderSelectDialog-InitialDirectory'></a>
### InitialDirectory `property`

##### Summary

Gets/Sets the initial folder to be selected. A null value selects
the current directory.

<a name='P-MFR-GUI-Dialogs-FolderSelectDialog-Title'></a>
### Title `property`

##### Summary

Gets/Sets the title to show in the dialog

<a name='M-MFR-GUI-Dialogs-FolderSelectDialog-Dispose'></a>
### Dispose() `method`

##### Summary

Performs application-defined tasks associated with freeing,
releasing, or resetting unmanaged resources.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-FolderSelectDialog-InternalShowDialog'></a>
### InternalShowDialog() `method`

##### Summary

Shows the dialog.

##### Returns

`true` if the user presses OK else `false`.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-FolderSelectDialog-InternalShowDialog-System-IntPtr-'></a>
### InternalShowDialog(hWndOwner) `method`

##### Summary

Shows this [FolderSelectDialog](#T-MFR-GUI-Dialogs-FolderSelectDialog 'MFR.GUI.Dialogs.FolderSelectDialog') to the user to
allow
the user to select a folder on their computer. Returns a value
indicating whether the dialog ended with the OK or Cancel button
being clicked.

##### Returns

`true` if the user presses OK else `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hWndOwner | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | Handle of the control to be parent |

<a name='M-MFR-GUI-Dialogs-FolderSelectDialog-ShowDialog'></a>
### ShowDialog() `method`

##### Summary

Shows the form as a modal dialog box.

##### Returns

One of the [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') values.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | The form being shown is already visible.
-or- The form being shown is disabled.
-or- The form being shown is not a top-level window.
-or- The form being shown as a dialog box is already a modal form.
-or- The current process is not running in user interactive mode (for
more information, see
[UserInteractive](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SystemInformation.UserInteractive 'System.Windows.Forms.SystemInformation.UserInteractive')). |

<a name='M-MFR-GUI-Dialogs-FolderSelectDialog-ShowDialog-System-Windows-Forms-IWin32Window-'></a>
### ShowDialog(owner) `method`

##### Summary

Shows the form as a modal dialog box with the specified owner.

##### Returns

One of the [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | Any object that implements
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window')
that represents the
top-level window that will own the modal dialog box. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The form specified in the `owner` parameter is the same
as the form being shown. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | The form being shown is already visible.
-or- The form being shown is disabled.
-or- The form being shown is not a top-level window.
-or- The form being shown as a dialog box is already a modal form.
-or- The current process is not running in user interactive mode (for
more information, see
[UserInteractive](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SystemInformation.UserInteractive 'System.Windows.Forms.SystemInformation.UserInteractive')). |

<a name='T-MFR-GUI-Dialogs-OperationDrivenProgressDialog'></a>
## OperationDrivenProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Progress dialog that always displays a Marquee progress bar during an
operation.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[OperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-OperationDrivenProgressDialog 'MFR.GUI.Dialogs.OperationDrivenProgressDialog') and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-OperationDrivenProgressDialog-_worker'></a>
### _worker `constants`

##### Summary

A [BackgroundWorker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.BackgroundWorker 'System.ComponentModel.BackgroundWorker') that manages the work
done by this Progress Dialog's work.

<a name='F-MFR-GUI-Dialogs-OperationDrivenProgressDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Argument'></a>
### Argument `property`

##### Summary

Gets or sets a reference to an object to be supplied to the code that is
executed by this dialog.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Proc'></a>
### Proc `property`

##### Summary

Gets or sets a [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func') delegate, taking an object as a
parameter and returning an object as a result, that refers to code to be
executed while the dialog is displayed.  When the code finishes, the dialog is
dismissed.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBar'></a>
### ProgressBar `property`

##### Summary

Gets a reference to the progress bar control.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarMaximum'></a>
### ProgressBarMaximum `property`

##### Summary

Gets or sets the maximum value of the range of the progress bar control.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarMinimum'></a>
### ProgressBarMinimum `property`

##### Summary

Get or sets the minimum value of the range of the progress bar control.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarStyle'></a>
### ProgressBarStyle `property`

##### Summary

Gets or sets the manner in which progress should

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarValue'></a>
### ProgressBarValue `property`

##### Summary

Gets or sets the current position of the progress bar.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Result'></a>
### Result `property`

##### Summary

Gets a reference to an instance of an object that is supplied as the result of
the code that is executed by this dialog.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Status'></a>
### Status `property`

##### Summary

Gets or sets a string containing the new status.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Clear'></a>
### Clear() `method`

##### Summary

Resets all properties to their default values.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-InitializeBackgroundWorker'></a>
### InitializeBackgroundWorker() `method`

##### Summary

Initializes the internal
[BackgroundWorker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.BackgroundWorker 'System.ComponentModel.BackgroundWorker') object.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-InitializeStartPosition'></a>
### InitializeStartPosition() `method`

##### Summary

Sets the value of the [StartPosition](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Form.StartPosition 'System.Windows.Forms.Form.StartPosition')
property to either
[CenterParent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormStartPosition.CenterParent 'System.Windows.Forms.FormStartPosition.CenterParent') or
[CenterScreen](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormStartPosition.CenterScreen 'System.Windows.Forms.FormStartPosition.CenterScreen'), depending
on whether we have an owner window.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnDoWork-System-Object,System-ComponentModel-DoWorkEventArgs-'></a>
### OnDoWork(sender,e) `method`

##### Summary

Handles the [](#E-System-ComponentModel-BackgroundWorker-DoWork 'System.ComponentModel.BackgroundWorker.DoWork')
event raised by the internal background worker managed by this dialog box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.ComponentModel.DoWorkEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DoWorkEventArgs 'System.ComponentModel.DoWorkEventArgs') | A [DoWorkEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DoWorkEventArgs 'System.ComponentModel.DoWorkEventArgs') that
contains the event data. |

##### Remarks

This method runs the code referred to by the contents of the delegate
referred to by the
[Proc](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Proc 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Proc') property.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnRequestClose'></a>
### OnRequestClose() `method`

##### Summary

Closes this dialog when requested to, say, when we are about to show a message
box to the interactive user.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnRunWorkerCompleted-System-Object,System-ComponentModel-RunWorkerCompletedEventArgs-'></a>
### OnRunWorkerCompleted(sender,e) `method`

##### Summary

Handles the
[](#E-System-ComponentModel-BackgroundWorker-RunWorkerCompleted 'System.ComponentModel.BackgroundWorker.RunWorkerCompleted')
event raised by the internal background worker thread managed by this dialog
box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.ComponentModel.RunWorkerCompletedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.RunWorkerCompletedEventArgs 'System.ComponentModel.RunWorkerCompletedEventArgs') | A
[RunWorkerCompletedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.RunWorkerCompletedEventArgs 'System.ComponentModel.RunWorkerCompletedEventArgs') that
contains the event data. |

##### Remarks

This method responds by gathering the result of the operation and then
dismissing the dialog box.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnShown-System-EventArgs-'></a>
### OnShown(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Shown 'System.Windows.Forms.Form.Shown') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-RedrawDisplay'></a>
### RedrawDisplay() `method`

##### Summary

Directs the application to update the user's display.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Reset'></a>
### Reset() `method`

##### Summary

Clears the status text and progress bar.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-UpdateCaption-System-String-'></a>
### UpdateCaption(caption) `method`

##### Summary

Updates the window's caption to reflect the new value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| caption | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the new caption text. |

##### Remarks

If the blank string is passed for the `caption`
parameter, then this method sets the window caption to match the value of the
[ProductName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Application.ProductName 'System.Windows.Forms.Application.ProductName') property.

<a name='T-MFR-GUI-Dialogs-OptionsDialog'></a>
## OptionsDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Provides options to the user that allow the user to modify the
application's behavior.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[OptionsDialog](#T-MFR-GUI-Dialogs-OptionsDialog 'MFR.GUI.Dialogs.OptionsDialog')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-OptionsDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-AutoQuitOnCompletion'></a>
### AutoQuitOnCompletion `property`

##### Summary

Gets or sets the value of the
checkbox.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-CommitAuthorEmail'></a>
### CommitAuthorEmail `property`

##### Summary

Gets or sets the value of the text box in the
group box on the tab.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-CommitAuthorName'></a>
### CommitAuthorName `property`

##### Summary

Gets or sets the value of the text box in the
group box on the tab.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-ConfigPathname'></a>
### ConfigPathname `property`

##### Summary

Gets or sets the text of the config File Pathname text box.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

##### Remarks

This object allows access to the user config and the
actions
associated with it.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-DontPromptUserToReloadOpenSolution'></a>
### DontPromptUserToReloadOpenSolution `property`

##### Summary

Gets or sets the value of the

checkbox

<a name='P-MFR-GUI-Dialogs-OptionsDialog-ErrantProcesses'></a>
### ErrantProcesses `property`

##### Summary

Gets a reference to a collection, each element of which implements the
[IErrantProcessInfo](#T-MFR-GUI-Models-Interfaces-IErrantProcessInfo 'MFR.GUI.Models.Interfaces.IErrantProcessInfo') interface,
representing the process(es), if running, that should be forcibly terminated
prior to the execution of the `Rename Files in Folder` and
`Rename Sub Folders` operations.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-HasErrantProcesses'></a>
### HasErrantProcesses `property`

##### Summary

Gets a value that indicates whether the user has configured more than zero
`Errant Process` entry(ies) in the list box.

##### Returns

`true` if there are more than zero
`Errant Process` entry(ies) in the list box;
`false` otherwise.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-IsErrantProcessSelected'></a>
### IsErrantProcessSelected `property`

##### Summary

Gets a value indicating whether an entry is currently selected in the
list box.

##### Returns

`true` if an entry is currently selected in the
list box; `false` otherwise.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-IsModified'></a>
### IsModified `property`

##### Summary

Gets a value that indicates whether the data in this dialog box has
been modified.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-PushChangesToRemoteWhenDone'></a>
### PushChangesToRemoteWhenDone `property`

##### Summary

Gets or sets the value of the checkbox.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-ReOpenSolution'></a>
### ReOpenSolution `property`

##### Summary

Gets or sets the value of the checkbox.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-SelectedErrantProcess'></a>
### SelectedErrantProcess `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IErrantProcessInfo](#T-MFR-GUI-Models-Interfaces-IErrantProcessInfo 'MFR.GUI.Models.Interfaces.IErrantProcessInfo') interface that
represents the item that is currently selected, if any, in the
list box on the tab.

##### Returns

If successful, a reference to an instance of an object that implements
the [IErrantProcessInfo](#T-MFR-GUI-Models-Interfaces-IErrantProcessInfo 'MFR.GUI.Models.Interfaces.IErrantProcessInfo') interface;
otherwise, a `null` reference is returned.

##### Remarks

If there are no items currently in the list box, or none are currently
selected, then this property returns a `null` reference.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-ShouldCommitPendingChanges'></a>
### ShouldCommitPendingChanges `property`

##### Summary

Gets or sets the value of the checkbox.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-ShouldCommitPostOperationChanges'></a>
### ShouldCommitPostOperationChanges `property`

##### Summary

Gets or sets the value of the 
checkbox.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-UpdateGitOnAutoStart'></a>
### UpdateGitOnAutoStart `property`

##### Summary

Gets or sets the value of the
checkbox.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-OptionsDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnAnyCheckBoxCheckedChanged-System-Object,System-EventArgs-'></a>
### OnAnyCheckBoxCheckedChanged(sender,e) `method`

##### Summary

This method handles the
[](#E-System-Windows-Forms-CheckBox-CheckedChanged 'System.Windows.Forms.CheckBox.CheckedChanged') event for all the
checkboxes on the tabs of this property sheet.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to the object that raised this
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | (Required.) A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains
the event data. |

##### Remarks

This method responds by calling the
[SetModifiedFlag](#M-MFR-GUI-Dialogs-OptionsDialog-SetModifiedFlag 'MFR.GUI.Dialogs.OptionsDialog.SetModifiedFlag') method to
mark this property sheet as dirty, so that the button becomes
available.



When developers add a new checkbox to any of the tabs of this
property sheet, they should bind this handler to the
[](#E-System-Windows-Forms-CheckBox-CheckedChanged 'System.Windows.Forms.CheckBox.CheckedChanged') event of that
checkbox.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnAnyTextBoxChanged-System-Object,System-EventArgs-'></a>
### OnAnyTextBoxChanged(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-TextChanged 'System.Windows.Forms.Control.TextChanged') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called to respond to the value of the text inside the
CurrentConfiguration File Pathname text box being changed. This method
responds to such a happenstance by updating the value of the
[IsModified](#P-MFR-GUI-OptionsDialog-IsModified 'MFR.GUI.OptionsDialog.IsModified')
property to be
`true`
by calling the
[SetModifiedFlag](#M-MFR-GUI-OptionsDialog-SetModifiedFlag 'MFR.GUI.OptionsDialog.SetModifiedFlag')
method.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnClickApply-System-Object,System-EventArgs-'></a>
### OnClickApply(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called in response to the user clicking the Apply
button. We merely raise the
[](#E-MFR-GUI-OptionsDialog-Modified 'MFR.GUI.OptionsDialog.Modified')
event in order to prompt
the client of this dialog box to update data.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnClickConfigPathnameBrowseButton-System-Object,System-EventArgs-'></a>
### OnClickConfigPathnameBrowseButton(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event
for the Browse button on the config File Pathname text box..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to a click of the '...' button that lies next
to the text box that accepts the pathname of the application's
config file.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnFormClosing-System-Windows-Forms-FormClosingEventArgs-'></a>
### OnFormClosing(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-FormClosing 'System.Windows.Forms.Form.FormClosing')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Windows.Forms.FormClosingEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosingEventArgs 'System.Windows.Forms.FormClosingEventArgs') | A [FormClosingEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosingEventArgs 'System.Windows.Forms.FormClosingEventArgs')
that contains the event data. |

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnModified-MFR-GUI-Dialogs-Events-ModifiedEventArgs-'></a>
### OnModified(e) `method`

##### Summary

Raises the [](#E-MFR-GUI-OptionsDialog-Modified 'MFR.GUI.OptionsDialog.Modified') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.GUI.Dialogs.Events.ModifiedEventArgs](#T-MFR-GUI-Dialogs-Events-ModifiedEventArgs 'MFR.GUI.Dialogs.Events.ModifiedEventArgs') | A [ModifiedEventArgs](#T-MFR-ModifiedEventArgs 'MFR.ModifiedEventArgs') that contains the
event data. |

##### Remarks

If the [Handled](#P-MFR-ModifiedEventArgs-Handled 'MFR.ModifiedEventArgs.Handled')
property is set `true` by the event's handler, then
the [IsModified](#P-MFR-GUI-OptionsDialog-IsModified 'MFR.GUI.OptionsDialog.IsModified') will be set to
`false`.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnShown-System-EventArgs-'></a>
### OnShown(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Shown 'System.Windows.Forms.Form.Shown') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnUpdateCmdUI-System-Object,System-EventArgs-'></a>
### OnUpdateCmdUI(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Application-Idle 'System.Windows.Forms.Application.Idle') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called to update the enabled or disabled state of controls.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-SetModifiedFlag-System-Boolean-'></a>
### SetModifiedFlag(dirty) `method`

##### Summary

Sets the dirty state of the data of this dialog box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dirty | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set to `true` to indicate data has changed;
`false`
otherwise. Default is `true`. |

<a name='M-MFR-GUI-Dialogs-OptionsDialog-UpdateData-System-Boolean-'></a>
### UpdateData(bSaveAndValidate) `method`

##### Summary

Moves data from this dialog's controls to the config object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bSaveAndValidate | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')
that specifies whether to save information from the screen into data variables.
`false` to load data to the screen. |

<a name='T-MFR-GUI-Dialogs-ProfileManagementDialogBox'></a>
## ProfileManagementDialogBox `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Dialog box to assist the user in managing config profiles.

<a name='M-MFR-GUI-Dialogs-ProfileManagementDialogBox-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ProfileManagementDialogBox](#T-MFR-GUI-Dialogs-ProfileManagementDialogBox 'MFR.GUI.Dialogs.ProfileManagementDialogBox') and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-ProfileManagementDialogBox-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-MFR-GUI-Dialogs-ProfileManagementDialogBox-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-ProfileManagementDialogBox-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-ProfileNameDialog'></a>
## ProfileNameDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Displayed to the user to allow the user to create a blank profile with a given
name and/or save a profile.

<a name='M-MFR-GUI-Dialogs-ProfileNameDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ProfileNameDialog](#T-MFR-GUI-Dialogs-ProfileNameDialog 'MFR.GUI.Dialogs.ProfileNameDialog') and returns a reference
to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-ProfileNameDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-ProfileNameDialog-OperationType'></a>
### OperationType `property`

##### Summary

Gets or sets the
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') value
that controls what type of profile-creation operation (e.g., New, Save As etc.)
is being done.

<a name='P-MFR-GUI-Dialogs-ProfileNameDialog-ProfileName'></a>
### ProfileName `property`

##### Summary

Gets or sets the value of the Profile Name text box.

<a name='P-MFR-GUI-Dialogs-ProfileNameDialog-ProfileProvider'></a>
### ProfileProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProfileProvider](#T-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider')
interface.

<a name='M-MFR-GUI-Dialogs-ProfileNameDialog-CanClose'></a>
### CanClose() `method`

##### Summary

Determines whether this dialog can be closed.



Whether or not this the case, depends on several factors; for instance,
whether the input is valid.



If validation rules fail, then the user is presented with an error message box
telling them what to do.



If the dialog box's `Cancel` button is clicked, or the
`ESC` key is pressed on the keyboard, then this method always returns
`true`.

##### Returns

`true` if the dialog is allowed to be closed;
`false` otherwise.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-ProfileNameDialog-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-ProfileNameDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-ProfileNameDialog-OnClickReadMoreAboutProfilesLinkLabel-System-Object,System-EventArgs-'></a>
### OnClickReadMoreAboutProfilesLinkLabel(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event raised by
the Read More About Profiles link label.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method is called when the user clicks the
link.



The default action is to bring up a Help window that describes profiles and
what can be done with them.

<a name='M-MFR-GUI-Dialogs-ProfileNameDialog-OnFormClosing-System-Windows-Forms-FormClosingEventArgs-'></a>
### OnFormClosing(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-FormClosing 'System.Windows.Forms.Form.FormClosing')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Windows.Forms.FormClosingEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosingEventArgs 'System.Windows.Forms.FormClosingEventArgs') | A [FormClosingEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosingEventArgs 'System.Windows.Forms.FormClosingEventArgs')
that contains the event data. |

<a name='M-MFR-GUI-Dialogs-ProfileNameDialog-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='T-MFR-GUI-Dialogs-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Dialogs.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Error_CommitMessageRequired'></a>
### Error_CommitMessageRequired `property`

##### Summary

Looks up a localized string similar to You must type a value in the Commit Message text box..

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Error_ErrantProcessEntryAlreadyPresent'></a>
### Error_ErrantProcessEntryAlreadyPresent `property`

##### Summary

Looks up a localized string similar to An entry with the pathname, '{0}', is already present in the list..

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Error_FailedAddErrantProcessEntry'></a>
### Error_FailedAddErrantProcessEntry `property`

##### Summary

Looks up a localized string similar to Failed to add a new Errant Process entry.\n\n{0}.

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Error_FailedEditErrantProcessEntry'></a>
### Error_FailedEditErrantProcessEntry `property`

##### Summary

Looks up a localized string similar to Failed to edit the specified Errant Process entry.

{0}.

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Error_FailedRemoveAllErrantProcesses'></a>
### Error_FailedRemoveAllErrantProcesses `property`

##### Summary

Looks up a localized string similar to Failed to clear the entry(ies) in the Errant Processes list box.

{0}.

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Error_FailedRemoveErrantProcessEntry'></a>
### Error_FailedRemoveErrantProcessEntry `property`

##### Summary

Looks up a localized string similar to Failed to remove the selected Errant Process entry from the list.

{0}.

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Error_NoErrantProcessEntryPathname'></a>
### Error_NoErrantProcessEntryPathname `property`

##### Summary

Looks up a localized string similar to The selected Errant Process entry does not have an associated pathname specified..

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Error_NoErrantProcessSelectedForEditing'></a>
### Error_NoErrantProcessSelectedForEditing `property`

##### Summary

Looks up a localized string similar to Please select the Errant Process entry that you wish to edit..

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Error_NoErrantProcessToBeRemovedIsSelected'></a>
### Error_NoErrantProcessToBeRemovedIsSelected `property`

##### Summary

Looks up a localized string similar to Please click to highlight the Errant Process entry that is to be removed, and then click the Remove button..

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Error_NoErrantProcessesToEdit'></a>
### Error_NoErrantProcessesToEdit `property`

##### Summary

Looks up a localized string similar to Please add Errant Process(es) to the list before trying to edit one of them..

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Error_NoErrantProcessesToRemove'></a>
### Error_NoErrantProcessesToRemove `property`

##### Summary

Looks up a localized string similar to There aren't any entry(ies) in the Errant Processes list box to remove..

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace'></a>
### Error_ValueCannotBeNullOrWhiteSpace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or whitespace..

<a name='P-MFR-GUI-Dialogs-Properties-Resources-FolderSelectDialogFilters'></a>
### FolderSelectDialogFilters `property`

##### Summary

Looks up a localized string similar to SpecialWindowsFolders|.

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Question_ConfirmRemoveAllErrantProcesses'></a>
### Question_ConfirmRemoveAllErrantProcesses `property`

##### Summary

Looks up a localized string similar to Are you sure you want to remove all the entry(ies) currently in the Errant Processes list box?

This action cannot be undone..

<a name='P-MFR-GUI-Dialogs-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
