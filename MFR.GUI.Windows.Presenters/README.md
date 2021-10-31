<a name='assembly'></a>
# MFR.GUI.Windows.Presenters

## Contents

- [MainWindowPresenter](#T-MFR-GUI-Windows-Presenters-MainWindowPresenter 'MFR.GUI.Windows.Presenters.MainWindowPresenter')
  - [#ctor()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-#ctor 'MFR.GUI.Windows.Presenters.MainWindowPresenter.#ctor')
  - [_exportConfigDialog](#F-MFR-GUI-Windows-Presenters-MainWindowPresenter-_exportConfigDialog 'MFR.GUI.Windows.Presenters.MainWindowPresenter._exportConfigDialog')
  - [_fileRenamer](#F-MFR-GUI-Windows-Presenters-MainWindowPresenter-_fileRenamer 'MFR.GUI.Windows.Presenters.MainWindowPresenter._fileRenamer')
  - [_historyManager](#F-MFR-GUI-Windows-Presenters-MainWindowPresenter-_historyManager 'MFR.GUI.Windows.Presenters.MainWindowPresenter._historyManager')
  - [_importConfigDialog](#F-MFR-GUI-Windows-Presenters-MainWindowPresenter-_importConfigDialog 'MFR.GUI.Windows.Presenters.MainWindowPresenter._importConfigDialog')
  - [_mainWindow](#F-MFR-GUI-Windows-Presenters-MainWindowPresenter-_mainWindow 'MFR.GUI.Windows.Presenters.MainWindowPresenter._mainWindow')
  - [_progressDialog](#F-MFR-GUI-Windows-Presenters-MainWindowPresenter-_progressDialog 'MFR.GUI.Windows.Presenters.MainWindowPresenter._progressDialog')
  - [FindWhat](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-FindWhat 'MFR.GUI.Windows.Presenters.MainWindowPresenter.FindWhat')
  - [ReplaceWith](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-ReplaceWith 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ReplaceWith')
  - [StartingFolder](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-StartingFolder 'MFR.GUI.Windows.Presenters.MainWindowPresenter.StartingFolder')
  - [AndHistoryManager(historyManager)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-AndHistoryManager-MFR-Objects-Managers-History-Interfaces-IHistoryManager- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.AndHistoryManager(MFR.Managers.History.Interfaces.IHistoryManager)')
  - [ClearAllHistory()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ClearAllHistory 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ClearAllHistory')
  - [CloseProgressDialog()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-CloseProgressDialog 'MFR.GUI.Windows.Presenters.MainWindowPresenter.CloseProgressDialog')
  - [CommenceRenameOperation()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-CommenceRenameOperation 'MFR.GUI.Windows.Presenters.MainWindowPresenter.CommenceRenameOperation')
  - [ExportConfiguration()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ExportConfiguration 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ExportConfiguration')
  - [HandleFilesCountedEvent(count)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-HandleFilesCountedEvent-System-Int32- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.HandleFilesCountedEvent(System.Int32)')
  - [HavingWindowReference(view)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-HavingWindowReference-MFR-GUI-Windows-Interfaces-IMainWindow- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.HavingWindowReference(MFR.GUI.Windows.Interfaces.IMainWindow)')
  - [ImportConfiguration()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ImportConfiguration 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ImportConfiguration')
  - [IncrementProgressBar(statusLabelText,currentFileLabelText)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-IncrementProgressBar-System-String,System-String- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.IncrementProgressBar(System.String,System.String)')
  - [InitializeComponents()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-InitializeComponents 'MFR.GUI.Windows.Presenters.MainWindowPresenter.InitializeComponents')
  - [InitializeFileRenamer()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-InitializeFileRenamer 'MFR.GUI.Windows.Presenters.MainWindowPresenter.InitializeFileRenamer')
  - [InitializeOperationSelections()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-InitializeOperationSelections 'MFR.GUI.Windows.Presenters.MainWindowPresenter.InitializeOperationSelections')
  - [OnAllHistoryCleared()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnAllHistoryCleared 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnAllHistoryCleared')
  - [OnConfigurationExported(e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnConfigurationExported-MFR-Objects-Configuration-Events-ConfigurationExportedEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnConfigurationExported(MFR.Configuration.Events.ConfigurationExportedEventArgs)')
  - [OnConfigurationImported(e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnConfigurationImported-MFR-Objects-Configuration-Events-ConfigurationImportedEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnConfigurationImported(MFR.Configuration.Events.ConfigurationImportedEventArgs)')
  - [OnDataOperationError(e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnDataOperationError-MFR-Objects-Operations-Events-DataOperationErrorEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnDataOperationError(MFR.Operations.Events.DataOperationErrorEventArgs)')
  - [OnDataOperationFinished()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnDataOperationFinished 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnDataOperationFinished')
  - [OnDataOperationStarted(e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnDataOperationStarted-MFR-Objects-Operations-Events-DataOperationEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnDataOperationStarted(MFR.Operations.Events.DataOperationEventArgs)')
  - [OnFileRenamerExceptionRaised(sender,e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerExceptionRaised-System-Object,MFR-Objects-Events-Common-ExceptionRaisedEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnFileRenamerExceptionRaised(System.Object,MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnFileRenamerFilesToBeRenamedCounted(sender,e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerFilesToBeRenamedCounted-System-Object,MFR-Objects-Events-FilesOrFoldersCountedEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnFileRenamerFilesToBeRenamedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFileRenamerFilesToHaveTextReplacedCounted(sender,e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerFilesToHaveTextReplacedCounted-System-Object,MFR-Objects-Events-FilesOrFoldersCountedEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnFileRenamerFilesToHaveTextReplacedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFileRenamerFinished()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerFinished 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnFileRenamerFinished')
  - [OnFileRenamerOperationFinished(sender,e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerOperationFinished-System-Object,MFR-Objects-Operations-Events-OperationFinishedEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnFileRenamerOperationFinished(System.Object,MFR.Operations.Events.OperationFinishedEventArgs)')
  - [OnFileRenamerOperationStarted(sender,e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerOperationStarted-System-Object,MFR-Objects-Operations-Events-OperationStartedEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnFileRenamerOperationStarted(System.Object,MFR.Operations.Events.OperationStartedEventArgs)')
  - [OnFileRenamerProcessingOperation(sender,e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerProcessingOperation-System-Object,MFR-Objects-Operations-Events-ProcessingOperationEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnFileRenamerProcessingOperation(System.Object,MFR.Operations.Events.ProcessingOperationEventArgs)')
  - [OnFileRenamerStarted(sender,e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerStarted-System-Object,System-EventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnFileRenamerStarted(System.Object,System.EventArgs)')
  - [OnFileRenamerSubfoldersToBeRenamedCounted(sender,e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerSubfoldersToBeRenamedCounted-System-Object,MFR-Objects-Events-FilesOrFoldersCountedEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnFileRenamerSubfoldersToBeRenamedCounted(System.Object,MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFinished()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFinished 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnFinished')
  - [OnOperationError(e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnOperationError-MFR-Objects-Events-Common-ExceptionRaisedEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnOperationError(MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnProgressDialogRequestedCancel(sender,e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnProgressDialogRequestedCancel-System-Object,System-EventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnProgressDialogRequestedCancel(System.Object,System.EventArgs)')
  - [Process()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-Process 'MFR.GUI.Windows.Presenters.MainWindowPresenter.Process')
  - [ReinitializeProgressDialog()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ReinitializeProgressDialog 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ReinitializeProgressDialog')
  - [ResetProgressBar()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ResetProgressBar 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ResetProgressBar')
  - [SaveConfigurationDataFrom(dialog)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-SaveConfigurationDataFrom-MFR-GUI-Dialogs-Interfaces-IOptionsDialog- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.SaveConfigurationDataFrom(MFR.GUI.Dialogs.Interfaces.IOptionsDialog)')
  - [SaveOperationSelections()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-SaveOperationSelections 'MFR.GUI.Windows.Presenters.MainWindowPresenter.SaveOperationSelections')
  - [ShowCalculatingProgressBar(text)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ShowCalculatingProgressBar-System-String- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ShowCalculatingProgressBar(System.String)')
  - [ShowProgressDialog()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ShowProgressDialog 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ShowProgressDialog')
  - [UpdateConfiguration(configuration)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-UpdateConfiguration-MFR-Objects-Configuration-Interfaces-IConfiguration- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.UpdateConfiguration(MFR.Configuration.Interfaces.IConfiguration)')
  - [UpdateData(bSavingAndValidating)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-UpdateData-System-Boolean- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.UpdateData(System.Boolean)')
  - [ValidateInputs()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ValidateInputs 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ValidateInputs')
  - [WindowReference(mainWindow)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-WindowReference-MFR-GUI-Windows-Interfaces-IMainWindow- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.WindowReference(MFR.GUI.Windows.Interfaces.IMainWindow)')
  - [WithFileRenamer(fileRenamer)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-WithFileRenamer-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.WithFileRenamer(MFR.Renamers.Files.Interfaces.IFileRenamer)')
- [Resources](#T-MFR-GUI-Windows-Presenters-Properties-Resources 'MFR.GUI.Windows.Presenters.Properties.Resources')
  - [Culture](#P-MFR-GUI-Windows-Presenters-Properties-Resources-Culture 'MFR.GUI.Windows.Presenters.Properties.Resources.Culture')
  - [Error_FindWhatRequired](#P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_FindWhatRequired 'MFR.GUI.Windows.Presenters.Properties.Resources.Error_FindWhatRequired')
  - [Error_ReplaceWithBlank](#P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_ReplaceWithBlank 'MFR.GUI.Windows.Presenters.Properties.Resources.Error_ReplaceWithBlank')
  - [Error_RootDirectoryNotFound](#P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_RootDirectoryNotFound 'MFR.GUI.Windows.Presenters.Properties.Resources.Error_RootDirectoryNotFound')
  - [ResourceManager](#P-MFR-GUI-Windows-Presenters-Properties-Resources-ResourceManager 'MFR.GUI.Windows.Presenters.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Windows-Presenters-MainWindowPresenter'></a>
## MainWindowPresenter `type`

##### Namespace

MFR.GUI.Windows.Presenters

##### Summary

Presenter for the main application window.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[MainWindowPresenter](#T-MFR-GUI-MainWindowPresenter 'MFR.GUI.MainWindowPresenter')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Windows-Presenters-MainWindowPresenter-_exportConfigDialog'></a>
### _exportConfigDialog `constants`

##### Summary

Reference to an instance of a
[SaveFileDialog](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SaveFileDialog 'System.Windows.Forms.SaveFileDialog')
that allows the user
to choose where they want to export the configuration data.

<a name='F-MFR-GUI-Windows-Presenters-MainWindowPresenter-_fileRenamer'></a>
### _fileRenamer `constants`

##### Summary

Reference to an instance of an object that implements the
[IFileRenamer](#T-MFR-Objects-IFileRenamer 'MFR.IFileRenamer')
interface.

##### Remarks

THis object provides the core services that this application offers.

<a name='F-MFR-GUI-Windows-Presenters-MainWindowPresenter-_historyManager'></a>
### _historyManager `constants`

##### Summary

Reference to an instance of an object that implements the
[IHistoryManager](#T-MFR-Objects-IHistoryManager 'MFR.IHistoryManager')
interface.

##### Remarks

This object's sole purpose in life is to provide the service of
maintaining the history lists in the configuration data source.

<a name='F-MFR-GUI-Windows-Presenters-MainWindowPresenter-_importConfigDialog'></a>
### _importConfigDialog `constants`

##### Summary

Reference to an instance of
[OpenFileDialog](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.OpenFileDialog 'System.Windows.Forms.OpenFileDialog')
that allows the user
to choose a filename on the disk.

##### Remarks

The file chosen by this dialog is to be used for importing
configuration data.

<a name='F-MFR-GUI-Windows-Presenters-MainWindowPresenter-_mainWindow'></a>
### _mainWindow `constants`

##### Summary

Reference to an instance of an object that implements the
[IMainWindow](#T-MFR-GUI-IMainWindow 'MFR.GUI.IMainWindow')
interface.

##### Remarks

This object provides the functionality of the main window of the application.

<a name='F-MFR-GUI-Windows-Presenters-MainWindowPresenter-_progressDialog'></a>
### _progressDialog `constants`

##### Summary

Reference to an instance of an object that implements the
[IProgressDialog](#T-MFR-GUI-IProgressDialog 'MFR.GUI.IProgressDialog')
interface.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets the text to be searched for during the operations.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets the replacement text to be used during the operations.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-StartingFolder'></a>
### StartingFolder `property`

##### Summary

Gets the path to the starting folder of the search.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-AndHistoryManager-MFR-Objects-Managers-History-Interfaces-IHistoryManager-'></a>
### AndHistoryManager(historyManager) `method`

##### Summary

Fluent-builder method for initializing the history manager
dependency of this Presenter class. History Manager objects control
the flow of values into and out of the list of previously-specified
values in prior searches.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| historyManager | [MFR.Managers.History.Interfaces.IHistoryManager](#T-MFR-Objects-Managers-History-Interfaces-IHistoryManager 'MFR.Managers.History.Interfaces.IHistoryManager') | Reference to an instance of an object that implements the
[IHistoryManager](#T-MFR-Objects-IHistoryManager 'MFR.IHistoryManager')
on which this Presenter
should depend. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ClearAllHistory'></a>
### ClearAllHistory() `method`

##### Summary

Clears all the history lists in the configuration.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-CloseProgressDialog'></a>
### CloseProgressDialog() `method`

##### Summary

Dismisses the progress dialog.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-CommenceRenameOperation'></a>
### CommenceRenameOperation() `method`

##### Summary

Actually begins the rename process.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ExportConfiguration'></a>
### ExportConfiguration() `method`

##### Summary

Exports the current configuration data to a file on the user's hard drive.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-HandleFilesCountedEvent-System-Int32-'></a>
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

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-HavingWindowReference-MFR-GUI-Windows-Interfaces-IMainWindow-'></a>
### HavingWindowReference(view) `method`

##### Summary

Fluent-builder method to set a reference to the main window of the application.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| view | [MFR.GUI.Windows.Interfaces.IMainWindow](#T-MFR-GUI-Windows-Interfaces-IMainWindow 'MFR.GUI.Windows.Interfaces.IMainWindow') | (Required.) Reference to an instance of an object that implements
the [IMainWindow](#T-MFR-GUI-Windows-Interfaces-IMainWindow 'MFR.GUI.Windows.Interfaces.IMainWindow')
interface, and which represents the form that is to be associated
with this presenter. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `view`, is passed
a `null` value. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ImportConfiguration'></a>
### ImportConfiguration() `method`

##### Summary

Imports the configuration data for this application.

##### Parameters

This method has no parameters.

##### Remarks

The data is presumed to be located inside of a JSON-formatted file
that exists on the user's hard drive and has the `.json` extension.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-IncrementProgressBar-System-String,System-String-'></a>
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

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-InitializeComponents'></a>
### InitializeComponents() `method`

##### Summary

Initializes the values of those dependencies which are not
configurable by use of fluent-builder methods.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-InitializeFileRenamer'></a>
### InitializeFileRenamer() `method`

##### Summary

Sets the properties of the FileRenamer object that we are working
with and subscribes to the events that it emits.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-InitializeOperationSelections'></a>
### InitializeOperationSelections() `method`

##### Summary

Sets the state of the Operations to Perform checked list box items
based on configuration settings.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnAllHistoryCleared'></a>
### OnAllHistoryCleared() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Windows-Presenters-MainWindowPresenter-AllHistoryCleared 'MFR.GUI.Windows.Presenters.MainWindowPresenter.AllHistoryCleared')
event.

##### Parameters

This method has no parameters.

##### Remarks

The objective of calling this method is to inform interested parties
that the operation of clearing all the history is complete.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnConfigurationExported-MFR-Objects-Configuration-Events-ConfigurationExportedEventArgs-'></a>
### OnConfigurationExported(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-MainWindowPresenter-ConfigurationExported 'MFR.GUI.MainWindowPresenter.ConfigurationExported')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Configuration.Events.ConfigurationExportedEventArgs](#T-MFR-Objects-Configuration-Events-ConfigurationExportedEventArgs 'MFR.Configuration.Events.ConfigurationExportedEventArgs') | A [ConfigurationExportedEventArgs](#T-MFR-Objects-ConfigurationExportedEventArgs 'MFR.ConfigurationExportedEventArgs') that
contains the event data. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnConfigurationImported-MFR-Objects-Configuration-Events-ConfigurationImportedEventArgs-'></a>
### OnConfigurationImported(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-MainWindowPresenter-ConfigurationImported 'MFR.GUI.MainWindowPresenter.ConfigurationImported')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Configuration.Events.ConfigurationImportedEventArgs](#T-MFR-Objects-Configuration-Events-ConfigurationImportedEventArgs 'MFR.Configuration.Events.ConfigurationImportedEventArgs') | A [ConfigurationImportedEventArgs](#T-MFR-Objects-ConfigurationImportedEventArgs 'MFR.ConfigurationImportedEventArgs') that
contains the event data. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnDataOperationError-MFR-Objects-Operations-Events-DataOperationErrorEventArgs-'></a>
### OnDataOperationError(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-MainWindowPresenter-DataOperationError 'MFR.GUI.MainWindowPresenter.DataOperationError')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Operations.Events.DataOperationErrorEventArgs](#T-MFR-Objects-Operations-Events-DataOperationErrorEventArgs 'MFR.Operations.Events.DataOperationErrorEventArgs') | A [DataOperationErrorEventArgs](#T-MFR-Objects-DataOperationErrorEventArgs 'MFR.DataOperationErrorEventArgs') that
contains the event data. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnDataOperationFinished'></a>
### OnDataOperationFinished() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Windows-Presenters-MainWindowPresenter-DataOperationFinished 'MFR.GUI.Windows.Presenters.MainWindowPresenter.DataOperationFinished')
event.

##### Parameters

This method has no parameters.

##### Remarks

Ideally, it should be the main application window that handles this
event by simply displaying a marquee progress bar on the status bar
of the application window but otherwise maintaining the ability of
the user to use the GUI. This is because moving data to and from the
configuration data source, while a mildly lengthy operation, is
nowhere near as involved as the file operations we would normally undertake.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnDataOperationStarted-MFR-Objects-Operations-Events-DataOperationEventArgs-'></a>
### OnDataOperationStarted(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-MainWindowPresenter-DataOperationStarted 'MFR.GUI.MainWindowPresenter.DataOperationStarted')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Operations.Events.DataOperationEventArgs](#T-MFR-Objects-Operations-Events-DataOperationEventArgs 'MFR.Operations.Events.DataOperationEventArgs') | (Required.) A [DataOperationEventArgs](#T-MFR-Objects-DataOperationEventArgs 'MFR.DataOperationEventArgs')
that contains the event data. |

##### Remarks

Ideally, it should be the main application window that handles this
event by simply displaying a marquee progress bar on the status bar
of the application window but otherwise maintaining the ability of
the user to use the GUI. This is because moving data to and from the
configuration data source, while a mildly lengthy operation, is
nowhere near as involved as the file operations we would normally undertake.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerExceptionRaised-System-Object,MFR-Objects-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnFileRenamerExceptionRaised(sender,e) `method`

##### Summary

Handles the [](#E-MFR-Objects-IFileRenamer-ExceptionRaised 'MFR.IFileRenamer.ExceptionRaised') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Events.Common.ExceptionRaisedEventArgs](#T-MFR-Objects-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to such an event by showing the user a message
box, logging the error, and then aborting the operation.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerFilesToBeRenamedCounted-System-Object,MFR-Objects-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFileRenamerFilesToBeRenamedCounted(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Objects-IFileRenamer-FilesToBeRenamedCounted 'MFR.IFileRenamer.FilesToBeRenamedCounted')
event
raised by the file renamer object when it's finished determining the
set of file system entries upon which the current operation should act.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Objects-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Objects-FilesOrFoldersCountedEventArgs 'MFR.FilesOrFoldersCountedEventArgs') that
contains the event data. |

##### Remarks

This method responds by resetting the progress dialog's progress bar
back to zero, and then updating the value of its
[Maximum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ProgressBar.Maximum 'System.Windows.Forms.ProgressBar.Maximum')
property to have
the same value as the count of file system entries.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerFilesToHaveTextReplacedCounted-System-Object,MFR-Objects-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFileRenamerFilesToHaveTextReplacedCounted(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Objects-IFileRenamer-FilesToHaveTextReplacedCounted 'MFR.IFileRenamer.FilesToHaveTextReplacedCounted')
event raised by the File Renamer object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Objects-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Objects-FilesOrFoldersCountedEventArgs 'MFR.FilesOrFoldersCountedEventArgs') that
contains the event data. |

##### Remarks

This method responds by resetting the progress dialog's progress bar
back to zero, and then updating the value of its
[Maximum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ProgressBar.Maximum 'System.Windows.Forms.ProgressBar.Maximum')
property to have
the same value as the count of file system entries.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerFinished'></a>
### OnFileRenamerFinished() `method`

##### Summary

Handles the [](#E-MFR-Objects-IFileRenamer-Finished 'MFR.IFileRenamer.Finished') event
raised by the File Renamer object. This event is raised when the
rename operations are all completed.

##### Parameters

This method has no parameters.

##### Remarks

This method responds merely by raising the
[](#E-MFR-GUI-IMainWindowPresenter-Finished 'MFR.GUI.IMainWindowPresenter.Finished')
event in turn.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerOperationFinished-System-Object,MFR-Objects-Operations-Events-OperationFinishedEventArgs-'></a>
### OnFileRenamerOperationFinished(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Objects-IFileRenamer-OperationFinished 'MFR.IFileRenamer.OperationFinished')
event raised
by the file renamer object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Operations.Events.OperationFinishedEventArgs](#T-MFR-Objects-Operations-Events-OperationFinishedEventArgs 'MFR.Operations.Events.OperationFinishedEventArgs') | A [OperationFinishedEventArgs](#T-MFR-Objects-OperationFinishedEventArgs 'MFR.OperationFinishedEventArgs') that
contains the event data. |

##### Remarks

This method responds to the event by telling the progress dialog to
reset the progress bar back to the starting point.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerOperationStarted-System-Object,MFR-Objects-Operations-Events-OperationStartedEventArgs-'></a>
### OnFileRenamerOperationStarted(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Objects-IFileRenamer-OperationStarted 'MFR.IFileRenamer.OperationStarted')
event raised by
the file-renamer object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Operations.Events.OperationStartedEventArgs](#T-MFR-Objects-Operations-Events-OperationStartedEventArgs 'MFR.Operations.Events.OperationStartedEventArgs') | A [OperationStartedEventArgs](#T-MFR-Objects-OperationStartedEventArgs 'MFR.OperationStartedEventArgs') that
contains the event data. |

##### Remarks

This method responds to the event by telling the progress dialog to
show the marquee progress bar for the operation type whose
processing is now being started.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerProcessingOperation-System-Object,MFR-Objects-Operations-Events-ProcessingOperationEventArgs-'></a>
### OnFileRenamerProcessingOperation(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Objects-IFileRenamer-ProcessingOperation 'MFR.IFileRenamer.ProcessingOperation')
event raised
by the File Renamer object when it moves on to processing the next
file system entry in its list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Operations.Events.ProcessingOperationEventArgs](#T-MFR-Objects-Operations-Events-ProcessingOperationEventArgs 'MFR.Operations.Events.ProcessingOperationEventArgs') | A [ProcessingOperationEventArgs](#T-MFR-Objects-ProcessingOperationEventArgs 'MFR.ProcessingOperationEventArgs') that
contains the event data. |

##### Remarks

This method responds by first checking the values passed in the
[ProcessingOperationEventArgs](#T-MFR-Objects-ProcessingOperationEventArgs 'MFR.ProcessingOperationEventArgs')
for valid values.



If the checks fail, then this method does nothing.



Otherwise, the method responds by incrementing the progress dialog's
progress bar to the next notch, and updating the text of the lower
status label in the progress dialog to contain the path to the file
currently being worked on.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerStarted-System-Object,System-EventArgs-'></a>
### OnFileRenamerStarted(sender,e) `method`

##### Summary

Handles the [](#E-MFR-Objects-IFileRenamer-Started 'MFR.IFileRenamer.Started') event
raised by the File Renamer object. This event is raised when the
rename operations are all completed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to the instance of the object that raised this event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds merely by raising the
[](#E-MFR-GUI-IMainWindowPresenter-Started 'MFR.GUI.IMainWindowPresenter.Started')
event, in turn.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFileRenamerSubfoldersToBeRenamedCounted-System-Object,MFR-Objects-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFileRenamerSubfoldersToBeRenamedCounted(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Objects-IFileRenamer-SubfoldersToBeRenamedCounted 'MFR.IFileRenamer.SubfoldersToBeRenamedCounted')
event raised by the File Renamer object when it has finished
calculating how many subfolders are to be renamed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Objects-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Objects-FilesOrFoldersCountedEventArgs 'MFR.FilesOrFoldersCountedEventArgs') that
contains the event data. |

##### Remarks

This method responds by resetting the progress dialog's progress bar
back to zero, and then updating the value of its
[Maximum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ProgressBar.Maximum 'System.Windows.Forms.ProgressBar.Maximum')
property to have
the same value as the count of file system entries.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFinished'></a>
### OnFinished() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Windows-Presenters-MainWindowPresenter-Finished 'MFR.GUI.Windows.Presenters.MainWindowPresenter.Finished')
event.

##### Parameters

This method has no parameters.

##### Remarks

This event lets client objects know that the presenter is about to
finish an operation. Typically, the client object is the main
application window, which should respond by dismissing any progress
dialog that may have been previously shown during the operation and
re-enabling user input.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnOperationError-MFR-Objects-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnOperationError(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-MainWindowPresenter-OperationError 'MFR.GUI.MainWindowPresenter.OperationError')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.Common.ExceptionRaisedEventArgs](#T-MFR-Objects-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs') | A [ExceptionRaisedEventArgs](#T-MFR-Objects-ExceptionRaisedEventArgs 'MFR.ExceptionRaisedEventArgs') that contains
the event data. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnProgressDialogRequestedCancel-System-Object,System-EventArgs-'></a>
### OnProgressDialogRequestedCancel(sender,e) `method`

##### Summary

Handles the [](#E-MFR-GUI-IProgressDialog-CancelRequested 'MFR.GUI.IProgressDialog.CancelRequested') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method handles the situation in which the user has clicked the
Cancel button on the progress dialog. The message taken by this
method is to tell the File Renamer Object to attempt to abort.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-Process'></a>
### Process() `method`

##### Summary

Begins the rename operation.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ReinitializeProgressDialog'></a>
### ReinitializeProgressDialog() `method`

##### Summary

Sets the progress dialog and/or reinitializes it from prior use.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ResetProgressBar'></a>
### ResetProgressBar() `method`

##### Summary

Resets the progress bar back to the beginning.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-SaveConfigurationDataFrom-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-'></a>
### SaveConfigurationDataFrom(dialog) `method`

##### Summary

Runs code that should execute when either the OK or Apply buttons
are clicked on the Tools -> Options dialog box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dialog | [MFR.GUI.Dialogs.Interfaces.IOptionsDialog](#T-MFR-GUI-Dialogs-Interfaces-IOptionsDialog 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog') | (Required.) Reference to an instance of an object that implements
the [IOptionsDialog](#T-MFR-GUI-Dialogs-Interfaces-IOptionsDialog 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `dialog`, is
passed a `null` value. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-SaveOperationSelections'></a>
### SaveOperationSelections() `method`

##### Summary

Saves the selections made in the Operations to Perform checked list
box into the [Configuration](#T-MFR-Objects-Configuration-Configuration 'MFR.Configuration.Configuration') object.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ShowCalculatingProgressBar-System-String-'></a>
### ShowCalculatingProgressBar(text) `method`

##### Summary

Shows a marquee progress bar that indicates the application is
performing work but of an indeterminate length, such as calculating
the amount of files to process.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to display in the progress dialog. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `text`, is passed
a blank or `null` string for a value. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ShowProgressDialog'></a>
### ShowProgressDialog() `method`

##### Summary

Shows the progress window.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-UpdateConfiguration-MFR-Objects-Configuration-Interfaces-IConfiguration-'></a>
### UpdateConfiguration(configuration) `method`

##### Summary

Updates the configuration currently being used with a new value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [MFR.Configuration.Interfaces.IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the [IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration') interface which has
the new settings. |

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

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-UpdateData-System-Boolean-'></a>
### UpdateData(bSavingAndValidating) `method`

##### Summary

Updates data. Moves data from the screen to the model (
`bSavingAndValidating`
equals `true`) or from
the model to the screen ( `bSavingAndValidating`
equals `false`).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bSavingAndValidating | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set to `true` to move data from the screen to the
model; `false` to move data from the model to the screen. |

##### Remarks

Note that whatever operations this method performs may potentially
throw exceptions.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ValidateInputs'></a>
### ValidateInputs() `method`

##### Summary

Runs rules to ensure that the entries on the main window's form are
valid. Throws a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') if a validation
rule fails.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the directory whose pathname is referenced by
[StartingFolder](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-StartingFolder 'MFR.GUI.Windows.Presenters.MainWindowPresenter.StartingFolder')
is not found on the disk. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if either of the
[FindWhat](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-FindWhat 'MFR.GUI.Windows.Presenters.MainWindowPresenter.FindWhat')
or
[ReplaceWith](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-ReplaceWith 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ReplaceWith')
properties are blank. |

##### Remarks

This method should be called in a try/catch handler. Upon catching
an exception, instead of logging the error, the application should
also respond by displaying a Stop message box to the user with the
value of the [Message](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception.Message 'System.Exception.Message') property of
the caught exception as its text, and then set the focus to the
offending field (if feasible).

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-WindowReference-MFR-GUI-Windows-Interfaces-IMainWindow-'></a>
### WindowReference(mainWindow) `method`

##### Summary

Fluent-builder method to set a reference to the main window of the application.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mainWindow | [MFR.GUI.Windows.Interfaces.IMainWindow](#T-MFR-GUI-Windows-Interfaces-IMainWindow 'MFR.GUI.Windows.Interfaces.IMainWindow') | (Required.) Reference to an instance of an object that implements
the [IMainWindow](#T-MFR-GUI-IMainWindow 'MFR.GUI.IMainWindow') interface and which
represents the main window of the application. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `mainWindow`, is
passed a `null` value. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-WithFileRenamer-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-'></a>
### WithFileRenamer(fileRenamer) `method`

##### Summary

Fluent-builder method for composing a file-renamer object with this presenter.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileRenamer | [MFR.Renamers.Files.Interfaces.IFileRenamer](#T-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer 'MFR.Renamers.Files.Interfaces.IFileRenamer') | (Required.) Reference to an instance of an object that implements
the [IFileRenamer](#T-MFR-Objects-IFileRenamer 'MFR.IFileRenamer') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `fileRenamer`, is
passed a `null` value. |

<a name='T-MFR-GUI-Windows-Presenters-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Windows.Presenters.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Windows-Presenters-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_FindWhatRequired'></a>
### Error_FindWhatRequired `property`

##### Summary

Looks up a localized string similar to The text to be found cannot be blank.

Type the text you want replaced, and then try again..

<a name='P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_ReplaceWithBlank'></a>
### Error_ReplaceWithBlank `property`

##### Summary

Looks up a localized string similar to The text to use as replacement text cannot be blank.

Type a value for this text, and then try again..

<a name='P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_RootDirectoryNotFound'></a>
### Error_RootDirectoryNotFound `property`

##### Summary

Looks up a localized string similar to Could not locate the folder '{0}' on the disk.

Please specify a folder path of click the '...' button to browse for one..

<a name='P-MFR-GUI-Windows-Presenters-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
