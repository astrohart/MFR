<a name='assembly'></a>
# MFR.Engines.Operations

## Contents

- [ConsoleOperationEngine](#T-MFR-Engines-Operations-ConsoleOperationEngine 'MFR.Engines.Operations.ConsoleOperationEngine')
  - [#ctor()](#M-MFR-Engines-Operations-ConsoleOperationEngine-#ctor 'MFR.Engines.Operations.ConsoleOperationEngine.#ctor')
  - [Instance](#P-MFR-Engines-Operations-ConsoleOperationEngine-Instance 'MFR.Engines.Operations.ConsoleOperationEngine.Instance')
  - [Type](#P-MFR-Engines-Operations-ConsoleOperationEngine-Type 'MFR.Engines.Operations.ConsoleOperationEngine.Type')
  - [#cctor()](#M-MFR-Engines-Operations-ConsoleOperationEngine-#cctor 'MFR.Engines.Operations.ConsoleOperationEngine.#cctor')
  - [HandleFilesCountedEvent(count)](#M-MFR-Engines-Operations-ConsoleOperationEngine-HandleFilesCountedEvent-System-Int32- 'MFR.Engines.Operations.ConsoleOperationEngine.HandleFilesCountedEvent(System.Int32)')
  - [OnFileRenamerOperationFinished(sender,e)](#M-MFR-Engines-Operations-ConsoleOperationEngine-OnFileRenamerOperationFinished-System-Object,MFR-Operations-Events-OperationFinishedEventArgs- 'MFR.Engines.Operations.ConsoleOperationEngine.OnFileRenamerOperationFinished(System.Object,MFR.Operations.Events.OperationFinishedEventArgs)')
  - [OnFileRenamerOperationStarted(sender,e)](#M-MFR-Engines-Operations-ConsoleOperationEngine-OnFileRenamerOperationStarted-System-Object,MFR-Operations-Events-OperationStartedEventArgs- 'MFR.Engines.Operations.ConsoleOperationEngine.OnFileRenamerOperationStarted(System.Object,MFR.Operations.Events.OperationStartedEventArgs)')
  - [OnFileRenamerProcessingOperation(sender,e)](#M-MFR-Engines-Operations-ConsoleOperationEngine-OnFileRenamerProcessingOperation-System-Object,MFR-Operations-Events-ProcessingOperationEventArgs- 'MFR.Engines.Operations.ConsoleOperationEngine.OnFileRenamerProcessingOperation(System.Object,MFR.Operations.Events.ProcessingOperationEventArgs)')
- [FullGuiOperationEngine](#T-MFR-Engines-Operations-FullGuiOperationEngine 'MFR.Engines.Operations.FullGuiOperationEngine')
  - [#ctor()](#M-MFR-Engines-Operations-FullGuiOperationEngine-#ctor 'MFR.Engines.Operations.FullGuiOperationEngine.#ctor')
  - [_cancellableProgressDialog](#F-MFR-Engines-Operations-FullGuiOperationEngine-_cancellableProgressDialog 'MFR.Engines.Operations.FullGuiOperationEngine._cancellableProgressDialog')
  - [_dialogOwner](#F-MFR-Engines-Operations-FullGuiOperationEngine-_dialogOwner 'MFR.Engines.Operations.FullGuiOperationEngine._dialogOwner')
  - [ConfigProvider](#P-MFR-Engines-Operations-FullGuiOperationEngine-ConfigProvider 'MFR.Engines.Operations.FullGuiOperationEngine.ConfigProvider')
  - [DialogOwner](#P-MFR-Engines-Operations-FullGuiOperationEngine-DialogOwner 'MFR.Engines.Operations.FullGuiOperationEngine.DialogOwner')
  - [Instance](#P-MFR-Engines-Operations-FullGuiOperationEngine-Instance 'MFR.Engines.Operations.FullGuiOperationEngine.Instance')
  - [Type](#P-MFR-Engines-Operations-FullGuiOperationEngine-Type 'MFR.Engines.Operations.FullGuiOperationEngine.Type')
  - [#cctor()](#M-MFR-Engines-Operations-FullGuiOperationEngine-#cctor 'MFR.Engines.Operations.FullGuiOperationEngine.#cctor')
  - [CloseProgressDialog()](#M-MFR-Engines-Operations-FullGuiOperationEngine-CloseProgressDialog 'MFR.Engines.Operations.FullGuiOperationEngine.CloseProgressDialog')
  - [HandleFilesCountedEvent(count)](#M-MFR-Engines-Operations-FullGuiOperationEngine-HandleFilesCountedEvent-System-Int32- 'MFR.Engines.Operations.FullGuiOperationEngine.HandleFilesCountedEvent(System.Int32)')
  - [IncrementProgressBar(statusLabelText,currentFileLabelText)](#M-MFR-Engines-Operations-FullGuiOperationEngine-IncrementProgressBar-System-String,System-String- 'MFR.Engines.Operations.FullGuiOperationEngine.IncrementProgressBar(System.String,System.String)')
  - [OnCancellableProgressDialogRequestedCancel(sender,e)](#M-MFR-Engines-Operations-FullGuiOperationEngine-OnCancellableProgressDialogRequestedCancel-System-Object,System-EventArgs- 'MFR.Engines.Operations.FullGuiOperationEngine.OnCancellableProgressDialogRequestedCancel(System.Object,System.EventArgs)')
  - [OnDialogOwnerChanged()](#M-MFR-Engines-Operations-FullGuiOperationEngine-OnDialogOwnerChanged 'MFR.Engines.Operations.FullGuiOperationEngine.OnDialogOwnerChanged')
  - [OnFileRenamerOperationFinished(sender,e)](#M-MFR-Engines-Operations-FullGuiOperationEngine-OnFileRenamerOperationFinished-System-Object,MFR-Operations-Events-OperationFinishedEventArgs- 'MFR.Engines.Operations.FullGuiOperationEngine.OnFileRenamerOperationFinished(System.Object,MFR.Operations.Events.OperationFinishedEventArgs)')
  - [OnFileRenamerOperationStarted(sender,e)](#M-MFR-Engines-Operations-FullGuiOperationEngine-OnFileRenamerOperationStarted-System-Object,MFR-Operations-Events-OperationStartedEventArgs- 'MFR.Engines.Operations.FullGuiOperationEngine.OnFileRenamerOperationStarted(System.Object,MFR.Operations.Events.OperationStartedEventArgs)')
  - [OnFileRenamerProcessingOperation(sender,e)](#M-MFR-Engines-Operations-FullGuiOperationEngine-OnFileRenamerProcessingOperation-System-Object,MFR-Operations-Events-ProcessingOperationEventArgs- 'MFR.Engines.Operations.FullGuiOperationEngine.OnFileRenamerProcessingOperation(System.Object,MFR.Operations.Events.ProcessingOperationEventArgs)')
  - [OnFileRenamerStatusUpdate(sender,e)](#M-MFR-Engines-Operations-FullGuiOperationEngine-OnFileRenamerStatusUpdate-System-Object,MFR-Events-Common-StatusUpdateEventArgs- 'MFR.Engines.Operations.FullGuiOperationEngine.OnFileRenamerStatusUpdate(System.Object,MFR.Events.Common.StatusUpdateEventArgs)')
  - [OnProcessingError()](#M-MFR-Engines-Operations-FullGuiOperationEngine-OnProcessingError-MFR-Events-Common-ExceptionRaisedEventArgs- 'MFR.Engines.Operations.FullGuiOperationEngine.OnProcessingError(MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnProcessingFinished()](#M-MFR-Engines-Operations-FullGuiOperationEngine-OnProcessingFinished 'MFR.Engines.Operations.FullGuiOperationEngine.OnProcessingFinished')
  - [OnProcessingStarted()](#M-MFR-Engines-Operations-FullGuiOperationEngine-OnProcessingStarted 'MFR.Engines.Operations.FullGuiOperationEngine.OnProcessingStarted')
  - [ReinitializeProgressDialog()](#M-MFR-Engines-Operations-FullGuiOperationEngine-ReinitializeProgressDialog 'MFR.Engines.Operations.FullGuiOperationEngine.ReinitializeProgressDialog')
  - [ResetProgressBar()](#M-MFR-Engines-Operations-FullGuiOperationEngine-ResetProgressBar 'MFR.Engines.Operations.FullGuiOperationEngine.ResetProgressBar')
  - [SetDialogOwner(owner)](#M-MFR-Engines-Operations-FullGuiOperationEngine-SetDialogOwner-System-Windows-Forms-IWin32Window- 'MFR.Engines.Operations.FullGuiOperationEngine.SetDialogOwner(System.Windows.Forms.IWin32Window)')
  - [ShowCalculatingProgressBar(text,canCancel)](#M-MFR-Engines-Operations-FullGuiOperationEngine-ShowCalculatingProgressBar-System-String,System-Boolean- 'MFR.Engines.Operations.FullGuiOperationEngine.ShowCalculatingProgressBar(System.String,System.Boolean)')
  - [ShowProgressDialog(canCancel)](#M-MFR-Engines-Operations-FullGuiOperationEngine-ShowProgressDialog-System-Boolean- 'MFR.Engines.Operations.FullGuiOperationEngine.ShowProgressDialog(System.Boolean)')
  - [ShowProgressDialog(owner)](#M-MFR-Engines-Operations-FullGuiOperationEngine-ShowProgressDialog-System-Windows-Forms-IWin32Window- 'MFR.Engines.Operations.FullGuiOperationEngine.ShowProgressDialog(System.Windows.Forms.IWin32Window)')
  - [ShowProgressDialog(owner,canCancel)](#M-MFR-Engines-Operations-FullGuiOperationEngine-ShowProgressDialog-System-Windows-Forms-IWin32Window,System-Boolean- 'MFR.Engines.Operations.FullGuiOperationEngine.ShowProgressDialog(System.Windows.Forms.IWin32Window,System.Boolean)')
  - [ShowProgressDialog()](#M-MFR-Engines-Operations-FullGuiOperationEngine-ShowProgressDialog 'MFR.Engines.Operations.FullGuiOperationEngine.ShowProgressDialog')
  - [UpdateConfiguration(config)](#M-MFR-Engines-Operations-FullGuiOperationEngine-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Engines.Operations.FullGuiOperationEngine.UpdateConfiguration(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
- [OperationEngineBase](#T-MFR-Engines-Operations-OperationEngineBase 'MFR.Engines.Operations.OperationEngineBase')
  - [#ctor()](#M-MFR-Engines-Operations-OperationEngineBase-#ctor 'MFR.Engines.Operations.OperationEngineBase.#ctor')
  - [_processingWorker](#F-MFR-Engines-Operations-OperationEngineBase-_processingWorker 'MFR.Engines.Operations.OperationEngineBase._processingWorker')
  - [ConfigProvider](#P-MFR-Engines-Operations-OperationEngineBase-ConfigProvider 'MFR.Engines.Operations.OperationEngineBase.ConfigProvider')
  - [CurrentConfig](#P-MFR-Engines-Operations-OperationEngineBase-CurrentConfig 'MFR.Engines.Operations.OperationEngineBase.CurrentConfig')
  - [FileRenamer](#P-MFR-Engines-Operations-OperationEngineBase-FileRenamer 'MFR.Engines.Operations.OperationEngineBase.FileRenamer')
  - [Type](#P-MFR-Engines-Operations-OperationEngineBase-Type 'MFR.Engines.Operations.OperationEngineBase.Type')
  - [HandleFilesCountedEvent(count)](#M-MFR-Engines-Operations-OperationEngineBase-HandleFilesCountedEvent-System-Int32- 'MFR.Engines.Operations.OperationEngineBase.HandleFilesCountedEvent(System.Int32)')
  - [InitializeFileRenamer()](#M-MFR-Engines-Operations-OperationEngineBase-InitializeFileRenamer 'MFR.Engines.Operations.OperationEngineBase.InitializeFileRenamer')
  - [InitializeProcessingWorker()](#M-MFR-Engines-Operations-OperationEngineBase-InitializeProcessingWorker 'MFR.Engines.Operations.OperationEngineBase.InitializeProcessingWorker')
  - [OnFileRenamerExceptionRaised(sender,e)](#M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerExceptionRaised-System-Object,MFR-Events-Common-ExceptionRaisedEventArgs- 'MFR.Engines.Operations.OperationEngineBase.OnFileRenamerExceptionRaised(System.Object,MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnFileRenamerFilesToBeRenamedCounted(sender,e)](#M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerFilesToBeRenamedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Engines.Operations.OperationEngineBase.OnFileRenamerFilesToBeRenamedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFileRenamerFilesToHaveTextReplacedCounted(sender,e)](#M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerFilesToHaveTextReplacedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Engines.Operations.OperationEngineBase.OnFileRenamerFilesToHaveTextReplacedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFileRenamerOperationFinished(sender,e)](#M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerOperationFinished-System-Object,MFR-Operations-Events-OperationFinishedEventArgs- 'MFR.Engines.Operations.OperationEngineBase.OnFileRenamerOperationFinished(System.Object,MFR.Operations.Events.OperationFinishedEventArgs)')
  - [OnFileRenamerOperationStarted(sender,e)](#M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerOperationStarted-System-Object,MFR-Operations-Events-OperationStartedEventArgs- 'MFR.Engines.Operations.OperationEngineBase.OnFileRenamerOperationStarted(System.Object,MFR.Operations.Events.OperationStartedEventArgs)')
  - [OnFileRenamerPendingChangesToBeCommittedCounted(sender,e)](#M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerPendingChangesToBeCommittedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Engines.Operations.OperationEngineBase.OnFileRenamerPendingChangesToBeCommittedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFileRenamerProcessingOperation(sender,e)](#M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerProcessingOperation-System-Object,MFR-Operations-Events-ProcessingOperationEventArgs- 'MFR.Engines.Operations.OperationEngineBase.OnFileRenamerProcessingOperation(System.Object,MFR.Operations.Events.ProcessingOperationEventArgs)')
  - [OnFileRenamerResultsToBeCommittedToGitCounted(sender,e)](#M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerResultsToBeCommittedToGitCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Engines.Operations.OperationEngineBase.OnFileRenamerResultsToBeCommittedToGitCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFileRenamerStatusUpdate(sender,e)](#M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerStatusUpdate-System-Object,MFR-Events-Common-StatusUpdateEventArgs- 'MFR.Engines.Operations.OperationEngineBase.OnFileRenamerStatusUpdate(System.Object,MFR.Events.Common.StatusUpdateEventArgs)')
  - [OnFileRenamerSubfoldersToBeRenamedCounted(sender,e)](#M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerSubfoldersToBeRenamedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Engines.Operations.OperationEngineBase.OnFileRenamerSubfoldersToBeRenamedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnProcessingError()](#M-MFR-Engines-Operations-OperationEngineBase-OnProcessingError-MFR-Events-Common-ExceptionRaisedEventArgs- 'MFR.Engines.Operations.OperationEngineBase.OnProcessingError(MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnProcessingFinished()](#M-MFR-Engines-Operations-OperationEngineBase-OnProcessingFinished 'MFR.Engines.Operations.OperationEngineBase.OnProcessingFinished')
  - [OnProcessingStarted()](#M-MFR-Engines-Operations-OperationEngineBase-OnProcessingStarted 'MFR.Engines.Operations.OperationEngineBase.OnProcessingStarted')
  - [OnProcessingWorkerDoWork(sender,e)](#M-MFR-Engines-Operations-OperationEngineBase-OnProcessingWorkerDoWork-System-Object,System-ComponentModel-DoWorkEventArgs- 'MFR.Engines.Operations.OperationEngineBase.OnProcessingWorkerDoWork(System.Object,System.ComponentModel.DoWorkEventArgs)')
  - [OnProcessingWorkerRunWorkerCompleted(sender,e)](#M-MFR-Engines-Operations-OperationEngineBase-OnProcessingWorkerRunWorkerCompleted-System-Object,System-ComponentModel-RunWorkerCompletedEventArgs- 'MFR.Engines.Operations.OperationEngineBase.OnProcessingWorkerRunWorkerCompleted(System.Object,System.ComponentModel.RunWorkerCompletedEventArgs)')
  - [ProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter)](#M-MFR-Engines-Operations-OperationEngineBase-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Engines.Operations.OperationEngineBase.ProcessAll(System.String,System.String,System.String,System.Predicate{System.String})')
  - [UpdateConfiguration(config)](#M-MFR-Engines-Operations-OperationEngineBase-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Engines.Operations.OperationEngineBase.UpdateConfiguration(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
- [Resources](#T-MFR-Engines-Operations-Properties-Resources 'MFR.Engines.Operations.Properties.Resources')
  - [Culture](#P-MFR-Engines-Operations-Properties-Resources-Culture 'MFR.Engines.Operations.Properties.Resources.Culture')
  - [Error_OperationFailed](#P-MFR-Engines-Operations-Properties-Resources-Error_OperationFailed 'MFR.Engines.Operations.Properties.Resources.Error_OperationFailed')
  - [Error_ValueCannotBeNullOrWhiteSpace](#P-MFR-Engines-Operations-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace 'MFR.Engines.Operations.Properties.Resources.Error_ValueCannotBeNullOrWhiteSpace')
  - [ResourceManager](#P-MFR-Engines-Operations-Properties-Resources-ResourceManager 'MFR.Engines.Operations.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Operations-ConsoleOperationEngine'></a>
## ConsoleOperationEngine `type`

##### Namespace

MFR.Engines.Operations

##### Summary

Coordinates the operation of the `File Renamer` component when the
application is invoked as a console app.

<a name='M-MFR-Engines-Operations-ConsoleOperationEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Engines-Operations-ConsoleOperationEngine-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFullGuiOperationEngine](#T-MFR-Engines-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Interfaces.IFullGuiOperationEngine') interface.

<a name='P-MFR-Engines-Operations-ConsoleOperationEngine-Type'></a>
### Type `property`

##### Summary

Gets a [OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType') enumeration
value that describes what type of operation engine this.

##### Remarks

Child classes must implement this property.

<a name='M-MFR-Engines-Operations-ConsoleOperationEngine-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-ConsoleOperationEngine-HandleFilesCountedEvent-System-Int32-'></a>
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

<a name='M-MFR-Engines-Operations-ConsoleOperationEngine-OnFileRenamerOperationFinished-System-Object,MFR-Operations-Events-OperationFinishedEventArgs-'></a>
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

<a name='M-MFR-Engines-Operations-ConsoleOperationEngine-OnFileRenamerOperationStarted-System-Object,MFR-Operations-Events-OperationStartedEventArgs-'></a>
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

<a name='M-MFR-Engines-Operations-ConsoleOperationEngine-OnFileRenamerProcessingOperation-System-Object,MFR-Operations-Events-ProcessingOperationEventArgs-'></a>
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

<a name='T-MFR-Engines-Operations-FullGuiOperationEngine'></a>
## FullGuiOperationEngine `type`

##### Namespace

MFR.Engines.Operations

##### Summary

Coordinates the operation of the `File Renamer` component inadmidst the
full graphical user interface of the application.

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Engines-Operations-FullGuiOperationEngine-_cancellableProgressDialog'></a>
### _cancellableProgressDialog `constants`

##### Summary

Reference to an instance of an object that implements the
[ICancellableProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-ICancellableProgressDialog 'MFR.GUI.Dialogs.Interfaces.ICancellableProgressDialog')
interface.

<a name='F-MFR-Engines-Operations-FullGuiOperationEngine-_dialogOwner'></a>
### _dialogOwner `constants`

##### Summary

Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface that represents
the parent window of the progress dialog.

<a name='P-MFR-Engines-Operations-FullGuiOperationEngine-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

##### Remarks

This object allows access to the user config and the
actions
associated with it.

<a name='P-MFR-Engines-Operations-FullGuiOperationEngine-DialogOwner'></a>
### DialogOwner `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface that represents
the parent window of the progress dialog.

<a name='P-MFR-Engines-Operations-FullGuiOperationEngine-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFullGuiOperationEngine](#T-MFR-Engines-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Interfaces.IFullGuiOperationEngine') interface.

<a name='P-MFR-Engines-Operations-FullGuiOperationEngine-Type'></a>
### Type `property`

##### Summary

Gets a [OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType') enumeration
value that describes what type of operation engine this.

##### Remarks

Child classes must implement this property.

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-CloseProgressDialog'></a>
### CloseProgressDialog() `method`

##### Summary

Dismisses the progress dialog.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-HandleFilesCountedEvent-System-Int32-'></a>
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

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-IncrementProgressBar-System-String,System-String-'></a>
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

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-OnCancellableProgressDialogRequestedCancel-System-Object,System-EventArgs-'></a>
### OnCancellableProgressDialogRequestedCancel(sender,e) `method`

##### Summary

Handles the [](#E-MFR-GUI-ICancellableProgressDialog-CancelRequested 'MFR.GUI.ICancellableProgressDialog.CancelRequested')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method handles the situation in which the user has clicked the
Cancel button on the progress dialog. The message taken by this
method is to tell the File Renamer Object to attempt to abort.

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-OnDialogOwnerChanged'></a>
### OnDialogOwnerChanged() `method`

##### Summary

Raises the
[](#E-MFR-Engines-Operations-FullGuiOperationEngine-DialogOwnerChanged 'MFR.Engines.Operations.FullGuiOperationEngine.DialogOwnerChanged') event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-OnFileRenamerOperationFinished-System-Object,MFR-Operations-Events-OperationFinishedEventArgs-'></a>
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

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-OnFileRenamerOperationStarted-System-Object,MFR-Operations-Events-OperationStartedEventArgs-'></a>
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

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-OnFileRenamerProcessingOperation-System-Object,MFR-Operations-Events-ProcessingOperationEventArgs-'></a>
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

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-OnFileRenamerStatusUpdate-System-Object,MFR-Events-Common-StatusUpdateEventArgs-'></a>
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



<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-OnProcessingError-MFR-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnProcessingError() `method`

##### Summary

Raises the
[](#E-MFR-Engines-Interfaces-IOperationEngine-ProcessingError 'MFR.Engines.Interfaces.IOperationEngine.ProcessingError')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-OnProcessingFinished'></a>
### OnProcessingFinished() `method`

##### Summary

Raises the
[](#E-MFR-Engines-Operations-OperationEngineBase-ProcessingFinished 'MFR.Engines.Operations.OperationEngineBase.ProcessingFinished') event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-OnProcessingStarted'></a>
### OnProcessingStarted() `method`

##### Summary

Raises the [](#E-MFR-Engines-Operations-OperationEngineBase-ProcessingStarted 'MFR.Engines.Operations.OperationEngineBase.ProcessingStarted')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-ReinitializeProgressDialog'></a>
### ReinitializeProgressDialog() `method`

##### Summary

Sets the progress dialog and/or reinitializes it from prior use.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-ResetProgressBar'></a>
### ResetProgressBar() `method`

##### Summary

Resets the progress bar back to the beginning.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-SetDialogOwner-System-Windows-Forms-IWin32Window-'></a>
### SetDialogOwner(owner) `method`

##### Summary

Sets the owner window of all dialog boxes displayed by this component.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface that represents
the new owner window. |

##### Remarks

Typically, this method would be called by passing a reference to the
main window of the application.

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-ShowCalculatingProgressBar-System-String,System-Boolean-'></a>
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

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-ShowProgressDialog-System-Boolean-'></a>
### ShowProgressDialog(canCancel) `method`

##### Summary

Shows the progress window.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| canCancel | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that controls whether the
button is displayed by the dialog box.



Set this parameter to `true` to display the button;
`false` to hide it. |

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-ShowProgressDialog-System-Windows-Forms-IWin32Window-'></a>
### ShowProgressDialog(owner) `method`

##### Summary

Shows the progress window.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.



This object plays the role of the parent window of the dialog box. |

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-ShowProgressDialog-System-Windows-Forms-IWin32Window,System-Boolean-'></a>
### ShowProgressDialog(owner,canCancel) `method`

##### Summary

Shows the progress window.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.



This object plays the role of the parent window of the dialog box. |
| canCancel | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that controls whether the
button is displayed by the dialog box.



Set this parameter to `true` to display the button;
`false` to hide it. |

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-ShowProgressDialog'></a>
### ShowProgressDialog() `method`

##### Summary

Shows the progress window.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-FullGuiOperationEngine-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### UpdateConfiguration(config) `method`

##### Summary

Updates the `config` currently being used with a new
value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface
which has the new settings. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `config`,
is passed a `null` value. |

##### Remarks

The settings in the object specified will be used for all matching
from this point forward.



NOTE:This member may be overriden by a child class. If this the
case, the overrider must call the base class method before doing any
of its own processing.

<a name='T-MFR-Engines-Operations-OperationEngineBase'></a>
## OperationEngineBase `type`

##### Namespace

MFR.Engines.Operations

##### Summary

Defines the events, methods, properties, and behaviors for all operation
engines.

<a name='M-MFR-Engines-Operations-OperationEngineBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[OperationEngineBase](#T-MFR-Engines-Operations-OperationEngineBase 'MFR.Engines.Operations.OperationEngineBase')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Engines-Operations-OperationEngineBase-_processingWorker'></a>
### _processingWorker `constants`

##### Summary

Reference to a [BackgroundWorker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.BackgroundWorker 'System.ComponentModel.BackgroundWorker') instance
that actually manages the file-rename processing itself.

##### Remarks

The problem that using this vs, say,
[Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task'), is that we can know,
deterministically, with a
[BackgroundWorker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.BackgroundWorker 'System.ComponentModel.BackgroundWorker'), when our operation is
actually complete, but it can still be run in an asynchronous way that keeps
the UI/UX of the application responsive.

<a name='P-MFR-Engines-Operations-OperationEngineBase-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

##### Remarks

This object allows access to the user config and the
actions
associated with it.

<a name='P-MFR-Engines-Operations-OperationEngineBase-CurrentConfig'></a>
### CurrentConfig `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

<a name='P-MFR-Engines-Operations-OperationEngineBase-FileRenamer'></a>
### FileRenamer `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileRenamer](#T-MFR-Renamers-Files-Interfaces-IFileRenamer 'MFR.Renamers.Files.Interfaces.IFileRenamer') interface.

##### Remarks

This object provides access to the file- and folder-processing functionality of
the application.



It is marked as `protected` in the source code, allowing access to
children of the [OperationEngineBase](#T-MFR-Engines-Operations-OperationEngineBase 'MFR.Engines.Operations.OperationEngineBase')
class.

<a name='P-MFR-Engines-Operations-OperationEngineBase-Type'></a>
### Type `property`

##### Summary

Gets a [OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType') enumeration
value that describes what type of operation engine this.

##### Remarks

Child classes must implement this property.

<a name='M-MFR-Engines-Operations-OperationEngineBase-HandleFilesCountedEvent-System-Int32-'></a>
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

<a name='M-MFR-Engines-Operations-OperationEngineBase-InitializeFileRenamer'></a>
### InitializeFileRenamer() `method`

##### Summary

Sets the properties of the [FileRenamer](#T-MFR-Renamers-Files-FileRenamer 'MFR.Renamers.Files.FileRenamer')
object that we are working
with and subscribes to the events that it emits.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-OperationEngineBase-InitializeProcessingWorker'></a>
### InitializeProcessingWorker() `method`

##### Summary

Initializes the settings for the
[BackgroundWorker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.BackgroundWorker 'System.ComponentModel.BackgroundWorker') that is used to process
the file-renaming operations.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerExceptionRaised-System-Object,MFR-Events-Common-ExceptionRaisedEventArgs-'></a>
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

<a name='M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerFilesToBeRenamedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
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

<a name='M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerFilesToHaveTextReplacedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
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

<a name='M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerOperationFinished-System-Object,MFR-Operations-Events-OperationFinishedEventArgs-'></a>
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

<a name='M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerOperationStarted-System-Object,MFR-Operations-Events-OperationStartedEventArgs-'></a>
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

<a name='M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerPendingChangesToBeCommittedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFileRenamerPendingChangesToBeCommittedCounted(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Renamers-Files-Interfaces-IFileRenamer-PendingChangesToBeCommittedCounted 'MFR.Renamers.Files.Interfaces.IFileRenamer.PendingChangesToBeCommittedCounted')
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

<a name='M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerProcessingOperation-System-Object,MFR-Operations-Events-ProcessingOperationEventArgs-'></a>
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

<a name='M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerResultsToBeCommittedToGitCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
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

<a name='M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerStatusUpdate-System-Object,MFR-Events-Common-StatusUpdateEventArgs-'></a>
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



<a name='M-MFR-Engines-Operations-OperationEngineBase-OnFileRenamerSubfoldersToBeRenamedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFileRenamerSubfoldersToBeRenamedCounted(sender,e) `method`

##### Summary

Handles the [](#E-MFR-IFileRenamer-Finished 'MFR.IFileRenamer.Finished') event
raised by the File Renamer object. This event is raised when the
rename operations are all completed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') that
contains the event data. |

##### Remarks

This method responds merely by raising the
[](#E-MFR-GUI-IMainWindowPresenter-Finished 'MFR.GUI.IMainWindowPresenter.Finished')
event in turn.

<a name='M-MFR-Engines-Operations-OperationEngineBase-OnProcessingError-MFR-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnProcessingError() `method`

##### Summary

Raises the
[](#E-MFR-Engines-Interfaces-IOperationEngine-ProcessingError 'MFR.Engines.Interfaces.IOperationEngine.ProcessingError')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-OperationEngineBase-OnProcessingFinished'></a>
### OnProcessingFinished() `method`

##### Summary

Raises the
[](#E-MFR-Engines-Interfaces-IOperationEngine-ProcessingFinished 'MFR.Engines.Interfaces.IOperationEngine.ProcessingFinished')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-OperationEngineBase-OnProcessingStarted'></a>
### OnProcessingStarted() `method`

##### Summary

Raises the
[](#E-MFR-Engines-Interfaces-IOperationEngine-ProcessingStarted 'MFR.Engines.Interfaces.IOperationEngine.ProcessingStarted')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-OperationEngineBase-OnProcessingWorkerDoWork-System-Object,System-ComponentModel-DoWorkEventArgs-'></a>
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

<a name='M-MFR-Engines-Operations-OperationEngineBase-OnProcessingWorkerRunWorkerCompleted-System-Object,System-ComponentModel-RunWorkerCompletedEventArgs-'></a>
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

<a name='M-MFR-Engines-Operations-OperationEngineBase-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### ProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Executes the Rename Subfolders, Rename Files, and Replace Text in
Files operation on all the folders and files in the root folder with
the pathname specified by the `rootDirectoryPath` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootDirectoryPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Path to the recursion root. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to search for. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to replace the text specified
by `findWhat` with. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) Reference to an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func')
that points to a delegate, accepting the current file or folder's
path as an argument, that returns `true` if the file
should be included in the operation or `false` otherwise.



This parameter is `null` by default. This method
should return `true` to specify that a given
file-system entry is to be included in the output collection --
barring other inclusion/exclusion criteria.



In the event that this parameter is `null`, no path
filtering is done. |

<a name='M-MFR-Engines-Operations-OperationEngineBase-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### UpdateConfiguration(config) `method`

##### Summary

Updates the `config` currently being used with a new
value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface
which has the new settings. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `config`,
is passed a `null` value. |

##### Remarks

The settings in the object specified will be used for all matching
from this point forward.



NOTE:This member may be overriden by a child class. If this the
case, the overrider must call the base class method before doing any
of its own processing.

<a name='T-MFR-Engines-Operations-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Operations.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Operations-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Operations-Properties-Resources-Error_OperationFailed'></a>
### Error_OperationFailed `property`

##### Summary

Looks up a localized string similar to Failed to perform the requested operations due to an unknown error.

Retry the operation.  The error has been logged..

<a name='P-MFR-Engines-Operations-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace'></a>
### Error_ValueCannotBeNullOrWhiteSpace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or whitespace..

<a name='P-MFR-Engines-Operations-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
