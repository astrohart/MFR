<a name='assembly'></a>
# MFR.Engines

## Contents

- [ConsoleOperationEngine](#T-MFR-Engines-ConsoleOperationEngine 'MFR.Engines.ConsoleOperationEngine')
  - [#ctor()](#M-MFR-Engines-ConsoleOperationEngine-#ctor 'MFR.Engines.ConsoleOperationEngine.#ctor')
  - [Instance](#P-MFR-Engines-ConsoleOperationEngine-Instance 'MFR.Engines.ConsoleOperationEngine.Instance')
  - [Type](#P-MFR-Engines-ConsoleOperationEngine-Type 'MFR.Engines.ConsoleOperationEngine.Type')
  - [#cctor()](#M-MFR-Engines-ConsoleOperationEngine-#cctor 'MFR.Engines.ConsoleOperationEngine.#cctor')
  - [HandleFilesCountedEvent(count)](#M-MFR-Engines-ConsoleOperationEngine-HandleFilesCountedEvent-System-Int32- 'MFR.Engines.ConsoleOperationEngine.HandleFilesCountedEvent(System.Int32)')
  - [OnFileRenamerOperationFinished(sender,e)](#M-MFR-Engines-ConsoleOperationEngine-OnFileRenamerOperationFinished-System-Object,MFR-Operations-Events-OperationFinishedEventArgs- 'MFR.Engines.ConsoleOperationEngine.OnFileRenamerOperationFinished(System.Object,MFR.Operations.Events.OperationFinishedEventArgs)')
  - [OnFileRenamerOperationStarted(sender,e)](#M-MFR-Engines-ConsoleOperationEngine-OnFileRenamerOperationStarted-System-Object,MFR-Operations-Events-OperationStartedEventArgs- 'MFR.Engines.ConsoleOperationEngine.OnFileRenamerOperationStarted(System.Object,MFR.Operations.Events.OperationStartedEventArgs)')
  - [OnFileRenamerProcessingOperation(sender,e)](#M-MFR-Engines-ConsoleOperationEngine-OnFileRenamerProcessingOperation-System-Object,MFR-Operations-Events-ProcessingOperationEventArgs- 'MFR.Engines.ConsoleOperationEngine.OnFileRenamerProcessingOperation(System.Object,MFR.Operations.Events.ProcessingOperationEventArgs)')
- [FullGuiOperationEngine](#T-MFR-Engines-FullGuiOperationEngine 'MFR.Engines.FullGuiOperationEngine')
  - [#ctor()](#M-MFR-Engines-FullGuiOperationEngine-#ctor 'MFR.Engines.FullGuiOperationEngine.#ctor')
  - [_cancellableProgressDialog](#F-MFR-Engines-FullGuiOperationEngine-_cancellableProgressDialog 'MFR.Engines.FullGuiOperationEngine._cancellableProgressDialog')
  - [ConfigurationProvider](#P-MFR-Engines-FullGuiOperationEngine-ConfigurationProvider 'MFR.Engines.FullGuiOperationEngine.ConfigurationProvider')
  - [Instance](#P-MFR-Engines-FullGuiOperationEngine-Instance 'MFR.Engines.FullGuiOperationEngine.Instance')
  - [Type](#P-MFR-Engines-FullGuiOperationEngine-Type 'MFR.Engines.FullGuiOperationEngine.Type')
  - [#cctor()](#M-MFR-Engines-FullGuiOperationEngine-#cctor 'MFR.Engines.FullGuiOperationEngine.#cctor')
  - [CloseProgressDialog()](#M-MFR-Engines-FullGuiOperationEngine-CloseProgressDialog 'MFR.Engines.FullGuiOperationEngine.CloseProgressDialog')
  - [HandleFilesCountedEvent(count)](#M-MFR-Engines-FullGuiOperationEngine-HandleFilesCountedEvent-System-Int32- 'MFR.Engines.FullGuiOperationEngine.HandleFilesCountedEvent(System.Int32)')
  - [IncrementProgressBar(statusLabelText,currentFileLabelText)](#M-MFR-Engines-FullGuiOperationEngine-IncrementProgressBar-System-String,System-String- 'MFR.Engines.FullGuiOperationEngine.IncrementProgressBar(System.String,System.String)')
  - [OnCancellableProgressDialogRequestedCancel(sender,e)](#M-MFR-Engines-FullGuiOperationEngine-OnCancellableProgressDialogRequestedCancel-System-Object,System-EventArgs- 'MFR.Engines.FullGuiOperationEngine.OnCancellableProgressDialogRequestedCancel(System.Object,System.EventArgs)')
  - [OnFileRenamerOperationFinished(sender,e)](#M-MFR-Engines-FullGuiOperationEngine-OnFileRenamerOperationFinished-System-Object,MFR-Operations-Events-OperationFinishedEventArgs- 'MFR.Engines.FullGuiOperationEngine.OnFileRenamerOperationFinished(System.Object,MFR.Operations.Events.OperationFinishedEventArgs)')
  - [OnFileRenamerOperationStarted(sender,e)](#M-MFR-Engines-FullGuiOperationEngine-OnFileRenamerOperationStarted-System-Object,MFR-Operations-Events-OperationStartedEventArgs- 'MFR.Engines.FullGuiOperationEngine.OnFileRenamerOperationStarted(System.Object,MFR.Operations.Events.OperationStartedEventArgs)')
  - [OnFileRenamerProcessingOperation(sender,e)](#M-MFR-Engines-FullGuiOperationEngine-OnFileRenamerProcessingOperation-System-Object,MFR-Operations-Events-ProcessingOperationEventArgs- 'MFR.Engines.FullGuiOperationEngine.OnFileRenamerProcessingOperation(System.Object,MFR.Operations.Events.ProcessingOperationEventArgs)')
  - [OnFileRenamerStatusUpdate(sender,e)](#M-MFR-Engines-FullGuiOperationEngine-OnFileRenamerStatusUpdate-System-Object,MFR-Events-Common-StatusUpdateEventArgs- 'MFR.Engines.FullGuiOperationEngine.OnFileRenamerStatusUpdate(System.Object,MFR.Events.Common.StatusUpdateEventArgs)')
  - [OnProcessingFinished()](#M-MFR-Engines-FullGuiOperationEngine-OnProcessingFinished 'MFR.Engines.FullGuiOperationEngine.OnProcessingFinished')
  - [OnProcessingStarted()](#M-MFR-Engines-FullGuiOperationEngine-OnProcessingStarted 'MFR.Engines.FullGuiOperationEngine.OnProcessingStarted')
  - [ReinitializeProgressDialog()](#M-MFR-Engines-FullGuiOperationEngine-ReinitializeProgressDialog 'MFR.Engines.FullGuiOperationEngine.ReinitializeProgressDialog')
  - [ResetProgressBar()](#M-MFR-Engines-FullGuiOperationEngine-ResetProgressBar 'MFR.Engines.FullGuiOperationEngine.ResetProgressBar')
  - [ShowCalculatingProgressBar(text,canCancel)](#M-MFR-Engines-FullGuiOperationEngine-ShowCalculatingProgressBar-System-String,System-Boolean- 'MFR.Engines.FullGuiOperationEngine.ShowCalculatingProgressBar(System.String,System.Boolean)')
  - [ShowProgressDialog(canCancel)](#M-MFR-Engines-FullGuiOperationEngine-ShowProgressDialog-System-Boolean- 'MFR.Engines.FullGuiOperationEngine.ShowProgressDialog(System.Boolean)')
  - [ShowProgressDialog(owner)](#M-MFR-Engines-FullGuiOperationEngine-ShowProgressDialog-System-Windows-Forms-IWin32Window- 'MFR.Engines.FullGuiOperationEngine.ShowProgressDialog(System.Windows.Forms.IWin32Window)')
  - [ShowProgressDialog(owner,canCancel)](#M-MFR-Engines-FullGuiOperationEngine-ShowProgressDialog-System-Windows-Forms-IWin32Window,System-Boolean- 'MFR.Engines.FullGuiOperationEngine.ShowProgressDialog(System.Windows.Forms.IWin32Window,System.Boolean)')
  - [ShowProgressDialog()](#M-MFR-Engines-FullGuiOperationEngine-ShowProgressDialog 'MFR.Engines.FullGuiOperationEngine.ShowProgressDialog')
  - [UpdateConfiguration(configuration)](#M-MFR-Engines-FullGuiOperationEngine-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration- 'MFR.Engines.FullGuiOperationEngine.UpdateConfiguration(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration)')
- [OperationEngine](#T-MFR-Engines-OperationEngine 'MFR.Engines.OperationEngine')
- [OperationEngineBase](#T-MFR-Engines-OperationEngineBase 'MFR.Engines.OperationEngineBase')
  - [#ctor()](#M-MFR-Engines-OperationEngineBase-#ctor 'MFR.Engines.OperationEngineBase.#ctor')
  - [_processingWorker](#F-MFR-Engines-OperationEngineBase-_processingWorker 'MFR.Engines.OperationEngineBase._processingWorker')
  - [ConfigurationProvider](#P-MFR-Engines-OperationEngineBase-ConfigurationProvider 'MFR.Engines.OperationEngineBase.ConfigurationProvider')
  - [CurrentConfiguration](#P-MFR-Engines-OperationEngineBase-CurrentConfiguration 'MFR.Engines.OperationEngineBase.CurrentConfiguration')
  - [FileRenamer](#P-MFR-Engines-OperationEngineBase-FileRenamer 'MFR.Engines.OperationEngineBase.FileRenamer')
  - [Type](#P-MFR-Engines-OperationEngineBase-Type 'MFR.Engines.OperationEngineBase.Type')
  - [HandleFilesCountedEvent(count)](#M-MFR-Engines-OperationEngineBase-HandleFilesCountedEvent-System-Int32- 'MFR.Engines.OperationEngineBase.HandleFilesCountedEvent(System.Int32)')
  - [InitializeFileRenamer()](#M-MFR-Engines-OperationEngineBase-InitializeFileRenamer 'MFR.Engines.OperationEngineBase.InitializeFileRenamer')
  - [InitializeProcessingWorker()](#M-MFR-Engines-OperationEngineBase-InitializeProcessingWorker 'MFR.Engines.OperationEngineBase.InitializeProcessingWorker')
  - [OnFileRenamerExceptionRaised(sender,e)](#M-MFR-Engines-OperationEngineBase-OnFileRenamerExceptionRaised-System-Object,MFR-Events-Common-ExceptionRaisedEventArgs- 'MFR.Engines.OperationEngineBase.OnFileRenamerExceptionRaised(System.Object,MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnFileRenamerFilesToBeRenamedCounted(sender,e)](#M-MFR-Engines-OperationEngineBase-OnFileRenamerFilesToBeRenamedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Engines.OperationEngineBase.OnFileRenamerFilesToBeRenamedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFileRenamerFilesToHaveTextReplacedCounted(sender,e)](#M-MFR-Engines-OperationEngineBase-OnFileRenamerFilesToHaveTextReplacedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Engines.OperationEngineBase.OnFileRenamerFilesToHaveTextReplacedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFileRenamerFinished()](#M-MFR-Engines-OperationEngineBase-OnFileRenamerFinished 'MFR.Engines.OperationEngineBase.OnFileRenamerFinished')
  - [OnFileRenamerOperationFinished(sender,e)](#M-MFR-Engines-OperationEngineBase-OnFileRenamerOperationFinished-System-Object,MFR-Operations-Events-OperationFinishedEventArgs- 'MFR.Engines.OperationEngineBase.OnFileRenamerOperationFinished(System.Object,MFR.Operations.Events.OperationFinishedEventArgs)')
  - [OnFileRenamerOperationStarted(sender,e)](#M-MFR-Engines-OperationEngineBase-OnFileRenamerOperationStarted-System-Object,MFR-Operations-Events-OperationStartedEventArgs- 'MFR.Engines.OperationEngineBase.OnFileRenamerOperationStarted(System.Object,MFR.Operations.Events.OperationStartedEventArgs)')
  - [OnFileRenamerProcessingOperation(sender,e)](#M-MFR-Engines-OperationEngineBase-OnFileRenamerProcessingOperation-System-Object,MFR-Operations-Events-ProcessingOperationEventArgs- 'MFR.Engines.OperationEngineBase.OnFileRenamerProcessingOperation(System.Object,MFR.Operations.Events.ProcessingOperationEventArgs)')
  - [OnFileRenamerStatusUpdate(sender,e)](#M-MFR-Engines-OperationEngineBase-OnFileRenamerStatusUpdate-System-Object,MFR-Events-Common-StatusUpdateEventArgs- 'MFR.Engines.OperationEngineBase.OnFileRenamerStatusUpdate(System.Object,MFR.Events.Common.StatusUpdateEventArgs)')
  - [OnFileRenamerSubfoldersToBeRenamedCounted(sender,e)](#M-MFR-Engines-OperationEngineBase-OnFileRenamerSubfoldersToBeRenamedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Engines.OperationEngineBase.OnFileRenamerSubfoldersToBeRenamedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnProcessingError()](#M-MFR-Engines-OperationEngineBase-OnProcessingError-MFR-Events-Common-ExceptionRaisedEventArgs- 'MFR.Engines.OperationEngineBase.OnProcessingError(MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnProcessingFinished()](#M-MFR-Engines-OperationEngineBase-OnProcessingFinished 'MFR.Engines.OperationEngineBase.OnProcessingFinished')
  - [OnProcessingStarted()](#M-MFR-Engines-OperationEngineBase-OnProcessingStarted 'MFR.Engines.OperationEngineBase.OnProcessingStarted')
  - [OnProcessingWorkerDoWork(sender,e)](#M-MFR-Engines-OperationEngineBase-OnProcessingWorkerDoWork-System-Object,System-ComponentModel-DoWorkEventArgs- 'MFR.Engines.OperationEngineBase.OnProcessingWorkerDoWork(System.Object,System.ComponentModel.DoWorkEventArgs)')
  - [OnProcessingWorkerRunWorkerCompleted(sender,e)](#M-MFR-Engines-OperationEngineBase-OnProcessingWorkerRunWorkerCompleted-System-Object,System-ComponentModel-RunWorkerCompletedEventArgs- 'MFR.Engines.OperationEngineBase.OnProcessingWorkerRunWorkerCompleted(System.Object,System.ComponentModel.RunWorkerCompletedEventArgs)')
  - [ProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter)](#M-MFR-Engines-OperationEngineBase-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Engines.OperationEngineBase.ProcessAll(System.String,System.String,System.String,System.Predicate{System.String})')
  - [UpdateConfiguration(configuration)](#M-MFR-Engines-OperationEngineBase-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration- 'MFR.Engines.OperationEngineBase.UpdateConfiguration(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration)')
- [Resources](#T-MFR-Engines-Properties-Resources 'MFR.Engines.Properties.Resources')
  - [Culture](#P-MFR-Engines-Properties-Resources-Culture 'MFR.Engines.Properties.Resources.Culture')
  - [Error_ValueCannotBeNullOrWhiteSpace](#P-MFR-Engines-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace 'MFR.Engines.Properties.Resources.Error_ValueCannotBeNullOrWhiteSpace')
  - [ResourceManager](#P-MFR-Engines-Properties-Resources-ResourceManager 'MFR.Engines.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-ConsoleOperationEngine'></a>
## ConsoleOperationEngine `type`

##### Namespace

MFR.Engines

##### Summary

Coordinates the operation of the `File Renamer` component when the
application is invoked as a console app.

<a name='M-MFR-Engines-ConsoleOperationEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Engines-ConsoleOperationEngine-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFullGuiOperationEngine](#T-MFR-Engines-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Interfaces.IFullGuiOperationEngine') interface.

<a name='P-MFR-Engines-ConsoleOperationEngine-Type'></a>
### Type `property`

##### Summary

Gets a [OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType') enumeration
value that describes what type of operation engine this is.

##### Remarks

Child classes must implement this property.

<a name='M-MFR-Engines-ConsoleOperationEngine-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-ConsoleOperationEngine-HandleFilesCountedEvent-System-Int32-'></a>
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

<a name='M-MFR-Engines-ConsoleOperationEngine-OnFileRenamerOperationFinished-System-Object,MFR-Operations-Events-OperationFinishedEventArgs-'></a>
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

<a name='M-MFR-Engines-ConsoleOperationEngine-OnFileRenamerOperationStarted-System-Object,MFR-Operations-Events-OperationStartedEventArgs-'></a>
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

<a name='M-MFR-Engines-ConsoleOperationEngine-OnFileRenamerProcessingOperation-System-Object,MFR-Operations-Events-ProcessingOperationEventArgs-'></a>
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

<a name='T-MFR-Engines-FullGuiOperationEngine'></a>
## FullGuiOperationEngine `type`

##### Namespace

MFR.Engines

##### Summary

Coordinates the operation of the `File Renamer` component inadmidst the
full graphical user interface of the application.

<a name='M-MFR-Engines-FullGuiOperationEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Engines-FullGuiOperationEngine-_cancellableProgressDialog'></a>
### _cancellableProgressDialog `constants`

##### Summary

Reference to an instance of an object that implements the
[ICancellableProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-ICancellableProgressDialog 'MFR.GUI.Dialogs.Interfaces.ICancellableProgressDialog')
interface.

<a name='P-MFR-Engines-FullGuiOperationEngine-ConfigurationProvider'></a>
### ConfigurationProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider')
interface.

##### Remarks

This object allows access to the user projectFileRenamerConfiguration and the
actions
associated with it.

<a name='P-MFR-Engines-FullGuiOperationEngine-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFullGuiOperationEngine](#T-MFR-Engines-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Interfaces.IFullGuiOperationEngine') interface.

<a name='P-MFR-Engines-FullGuiOperationEngine-Type'></a>
### Type `property`

##### Summary

Gets a [OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType') enumeration
value that describes what type of operation engine this is.

##### Remarks

Child classes must implement this property.

<a name='M-MFR-Engines-FullGuiOperationEngine-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-FullGuiOperationEngine-CloseProgressDialog'></a>
### CloseProgressDialog() `method`

##### Summary

Dismisses the progress dialog.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-FullGuiOperationEngine-HandleFilesCountedEvent-System-Int32-'></a>
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

<a name='M-MFR-Engines-FullGuiOperationEngine-IncrementProgressBar-System-String,System-String-'></a>
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

<a name='M-MFR-Engines-FullGuiOperationEngine-OnCancellableProgressDialogRequestedCancel-System-Object,System-EventArgs-'></a>
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

<a name='M-MFR-Engines-FullGuiOperationEngine-OnFileRenamerOperationFinished-System-Object,MFR-Operations-Events-OperationFinishedEventArgs-'></a>
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

<a name='M-MFR-Engines-FullGuiOperationEngine-OnFileRenamerOperationStarted-System-Object,MFR-Operations-Events-OperationStartedEventArgs-'></a>
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

<a name='M-MFR-Engines-FullGuiOperationEngine-OnFileRenamerProcessingOperation-System-Object,MFR-Operations-Events-ProcessingOperationEventArgs-'></a>
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

<a name='M-MFR-Engines-FullGuiOperationEngine-OnFileRenamerStatusUpdate-System-Object,MFR-Events-Common-StatusUpdateEventArgs-'></a>
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



<a name='M-MFR-Engines-FullGuiOperationEngine-OnProcessingFinished'></a>
### OnProcessingFinished() `method`

##### Summary

Raises the
[](#E-MFR-Engines-OperationEngineBase-ProcessingFinished 'MFR.Engines.OperationEngineBase.ProcessingFinished') event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-FullGuiOperationEngine-OnProcessingStarted'></a>
### OnProcessingStarted() `method`

##### Summary

Raises the [](#E-MFR-Engines-OperationEngineBase-ProcessingStarted 'MFR.Engines.OperationEngineBase.ProcessingStarted')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-FullGuiOperationEngine-ReinitializeProgressDialog'></a>
### ReinitializeProgressDialog() `method`

##### Summary

Sets the progress dialog and/or reinitializes it from prior use.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-FullGuiOperationEngine-ResetProgressBar'></a>
### ResetProgressBar() `method`

##### Summary

Resets the progress bar back to the beginning.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-FullGuiOperationEngine-ShowCalculatingProgressBar-System-String,System-Boolean-'></a>
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

<a name='M-MFR-Engines-FullGuiOperationEngine-ShowProgressDialog-System-Boolean-'></a>
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

<a name='M-MFR-Engines-FullGuiOperationEngine-ShowProgressDialog-System-Windows-Forms-IWin32Window-'></a>
### ShowProgressDialog(owner) `method`

##### Summary

Shows the progress window.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.



This object plays the role of the parent window of the dialog box. |

<a name='M-MFR-Engines-FullGuiOperationEngine-ShowProgressDialog-System-Windows-Forms-IWin32Window,System-Boolean-'></a>
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

<a name='M-MFR-Engines-FullGuiOperationEngine-ShowProgressDialog'></a>
### ShowProgressDialog() `method`

##### Summary

Shows the progress window.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-FullGuiOperationEngine-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-'></a>
### UpdateConfiguration(configuration) `method`

##### Summary

Updates the `configuration` currently being used with a new
value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface
which has the new settings. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `configuration`,
is passed a `null` value. |

##### Remarks

The settings in the object specified will be used for all matching
from this point forward.



NOTE:This member may be overriden by a child class. If this is the
case, the overrider must call the base class method before doing any
of its own processing.

<a name='T-MFR-Engines-OperationEngine'></a>
## OperationEngine `type`

##### Namespace

MFR.Engines

##### Summary

Wraps the file-renaming component in an object that adapts it for use at any
place in this software system.

##### Remarks

There is a part of me that feels like this class may be redundant.

<a name='T-MFR-Engines-OperationEngineBase'></a>
## OperationEngineBase `type`

##### Namespace

MFR.Engines

##### Summary

Defines the events, methods, properties, and behaviors for all operation
engines.

<a name='M-MFR-Engines-OperationEngineBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [OperationEngineBase](#T-MFR-Engines-OperationEngineBase 'MFR.Engines.OperationEngineBase')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Engines-OperationEngineBase-_processingWorker'></a>
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

<a name='P-MFR-Engines-OperationEngineBase-ConfigurationProvider'></a>
### ConfigurationProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider')
interface.

##### Remarks

This object allows access to the user projectFileRenamerConfiguration and the
actions
associated with it.

<a name='P-MFR-Engines-OperationEngineBase-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface.

<a name='P-MFR-Engines-OperationEngineBase-FileRenamer'></a>
### FileRenamer `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileRenamer](#T-MFR-Renamers-Files-Interfaces-IFileRenamer 'MFR.Renamers.Files.Interfaces.IFileRenamer') interface.

##### Remarks

This object provides access to the file- and folder-processing functionality of
the application.



It is marked as `protected` in the source code, allowing access to
children of the [OperationEngineBase](#T-MFR-Engines-OperationEngineBase 'MFR.Engines.OperationEngineBase') class.

<a name='P-MFR-Engines-OperationEngineBase-Type'></a>
### Type `property`

##### Summary

Gets a [OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType') enumeration
value that describes what type of operation engine this is.

##### Remarks

Child classes must implement this property.

<a name='M-MFR-Engines-OperationEngineBase-HandleFilesCountedEvent-System-Int32-'></a>
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

<a name='M-MFR-Engines-OperationEngineBase-InitializeFileRenamer'></a>
### InitializeFileRenamer() `method`

##### Summary

Sets the properties of the [FileRenamer](#T-MFR-Renamers-Files-FileRenamer 'MFR.Renamers.Files.FileRenamer')
object that we are working
with and subscribes to the events that it emits.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-OperationEngineBase-InitializeProcessingWorker'></a>
### InitializeProcessingWorker() `method`

##### Summary

Initializes the settings for the
[BackgroundWorker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.BackgroundWorker 'System.ComponentModel.BackgroundWorker') that is used to process
the file-renaming operations.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-OperationEngineBase-OnFileRenamerExceptionRaised-System-Object,MFR-Events-Common-ExceptionRaisedEventArgs-'></a>
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

<a name='M-MFR-Engines-OperationEngineBase-OnFileRenamerFilesToBeRenamedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
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

<a name='M-MFR-Engines-OperationEngineBase-OnFileRenamerFilesToHaveTextReplacedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
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

<a name='M-MFR-Engines-OperationEngineBase-OnFileRenamerFinished'></a>
### OnFileRenamerFinished() `method`

##### Summary

Handles the [](#E-MFR-IFileRenamer-Finished 'MFR.IFileRenamer.Finished') event
raised by the File Renamer object. This event is raised when the
rename operations are all completed.

##### Parameters

This method has no parameters.

##### Remarks

This method responds merely by raising the
[](#E-MFR-GUI-IMainWindowPresenter-Finished 'MFR.GUI.IMainWindowPresenter.Finished')
event in turn.

<a name='M-MFR-Engines-OperationEngineBase-OnFileRenamerOperationFinished-System-Object,MFR-Operations-Events-OperationFinishedEventArgs-'></a>
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

<a name='M-MFR-Engines-OperationEngineBase-OnFileRenamerOperationStarted-System-Object,MFR-Operations-Events-OperationStartedEventArgs-'></a>
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

<a name='M-MFR-Engines-OperationEngineBase-OnFileRenamerProcessingOperation-System-Object,MFR-Operations-Events-ProcessingOperationEventArgs-'></a>
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

<a name='M-MFR-Engines-OperationEngineBase-OnFileRenamerStatusUpdate-System-Object,MFR-Events-Common-StatusUpdateEventArgs-'></a>
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



<a name='M-MFR-Engines-OperationEngineBase-OnFileRenamerSubfoldersToBeRenamedCounted-System-Object,MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
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

<a name='M-MFR-Engines-OperationEngineBase-OnProcessingError-MFR-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnProcessingError() `method`

##### Summary

Raises the
[](#E-MFR-Engines-Interfaces-IOperationEngine-ProcessingError 'MFR.Engines.Interfaces.IOperationEngine.ProcessingError')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-OperationEngineBase-OnProcessingFinished'></a>
### OnProcessingFinished() `method`

##### Summary

Raises the
[](#E-MFR-Engines-Interfaces-IOperationEngine-ProcessingFinished 'MFR.Engines.Interfaces.IOperationEngine.ProcessingFinished')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-OperationEngineBase-OnProcessingStarted'></a>
### OnProcessingStarted() `method`

##### Summary

Raises the
[](#E-MFR-Engines-Interfaces-IOperationEngine-ProcessingStarted 'MFR.Engines.Interfaces.IOperationEngine.ProcessingStarted')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-OperationEngineBase-OnProcessingWorkerDoWork-System-Object,System-ComponentModel-DoWorkEventArgs-'></a>
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

<a name='M-MFR-Engines-OperationEngineBase-OnProcessingWorkerRunWorkerCompleted-System-Object,System-ComponentModel-RunWorkerCompletedEventArgs-'></a>
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

<a name='M-MFR-Engines-OperationEngineBase-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
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

<a name='M-MFR-Engines-OperationEngineBase-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-'></a>
### UpdateConfiguration(configuration) `method`

##### Summary

Updates the `configuration` currently being used with a new
value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface
which has the new settings. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `configuration`,
is passed a `null` value. |

##### Remarks

The settings in the object specified will be used for all matching
from this point forward.



NOTE:This member may be overriden by a child class. If this is the
case, the overrider must call the base class method before doing any
of its own processing.

<a name='T-MFR-Engines-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace'></a>
### Error_ValueCannotBeNullOrWhiteSpace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or whitespace..

<a name='P-MFR-Engines-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
