<a name='assembly'></a>
# MFR.Renamers.Files

## Contents

- [FileRenamer](#T-MFR-Objects-Renamers-Files-FileRenamer 'MFR.Renamers.Files.FileRenamer')
  - [#ctor()](#M-MFR-Objects-Renamers-Files-FileRenamer-#ctor 'MFR.Renamers.Files.FileRenamer.#ctor')
  - [#ctor(rootDirectoryPath)](#M-MFR-Objects-Renamers-Files-FileRenamer-#ctor-System-String- 'MFR.Renamers.Files.FileRenamer.#ctor(System.String)')
  - [AbortRequested](#P-MFR-Objects-Renamers-Files-FileRenamer-AbortRequested 'MFR.Renamers.Files.FileRenamer.AbortRequested')
  - [EnabledOperations](#P-MFR-Objects-Renamers-Files-FileRenamer-EnabledOperations 'MFR.Renamers.Files.FileRenamer.EnabledOperations')
  - [RootDirectoryPath](#P-MFR-Objects-Renamers-Files-FileRenamer-RootDirectoryPath 'MFR.Renamers.Files.FileRenamer.RootDirectoryPath')
  - [ShouldReOpenSolution](#P-MFR-Objects-Renamers-Files-FileRenamer-ShouldReOpenSolution 'MFR.Renamers.Files.FileRenamer.ShouldReOpenSolution')
  - [EnableOperations(operations)](#M-MFR-Objects-Renamers-Files-FileRenamer-EnableOperations-MFR-Objects-Operations-Constants-OperationType[]- 'MFR.Renamers.Files.FileRenamer.EnableOperations(MFR.Operations.Constants.OperationType[])')
  - [InvokeProcessing(findWhat,replaceWith,pathFilter)](#M-MFR-Objects-Renamers-Files-FileRenamer-InvokeProcessing-System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.InvokeProcessing(System.String,System.String,System.Predicate{System.String})')
  - [OnExceptionRaised(e)](#M-MFR-Objects-Renamers-Files-FileRenamer-OnExceptionRaised-MFR-Objects-Events-Common-ExceptionRaisedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnExceptionRaised(MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnFilesToBeRenamedCounted(e)](#M-MFR-Objects-Renamers-Files-FileRenamer-OnFilesToBeRenamedCounted-MFR-Objects-Events-FilesOrFoldersCountedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnFilesToBeRenamedCounted(MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFilesToHaveTextReplacedCounted(e)](#M-MFR-Objects-Renamers-Files-FileRenamer-OnFilesToHaveTextReplacedCounted-MFR-Objects-Events-FilesOrFoldersCountedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnFilesToHaveTextReplacedCounted(MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFinished()](#M-MFR-Objects-Renamers-Files-FileRenamer-OnFinished 'MFR.Renamers.Files.FileRenamer.OnFinished')
  - [OnOperationFinished(e)](#M-MFR-Objects-Renamers-Files-FileRenamer-OnOperationFinished-MFR-Objects-Operations-Events-OperationFinishedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnOperationFinished(MFR.Operations.Events.OperationFinishedEventArgs)')
  - [OnOperationStarted(e)](#M-MFR-Objects-Renamers-Files-FileRenamer-OnOperationStarted-MFR-Objects-Operations-Events-OperationStartedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnOperationStarted(MFR.Operations.Events.OperationStartedEventArgs)')
  - [OnProcessingOperation(e)](#M-MFR-Objects-Renamers-Files-FileRenamer-OnProcessingOperation-MFR-Objects-Operations-Events-ProcessingOperationEventArgs- 'MFR.Renamers.Files.FileRenamer.OnProcessingOperation(MFR.Operations.Events.ProcessingOperationEventArgs)')
  - [OnStarted()](#M-MFR-Objects-Renamers-Files-FileRenamer-OnStarted 'MFR.Renamers.Files.FileRenamer.OnStarted')
  - [OnStatusUpdate(e)](#M-MFR-Objects-Renamers-Files-FileRenamer-OnStatusUpdate-MFR-Objects-Events-Common-StatusUpdateEventArgs- 'MFR.Renamers.Files.FileRenamer.OnStatusUpdate(MFR.Events.Common.StatusUpdateEventArgs)')
  - [OnSubfoldersToBeRenamedCounted(e)](#M-MFR-Objects-Renamers-Files-FileRenamer-OnSubfoldersToBeRenamedCounted-MFR-Objects-Events-FilesOrFoldersCountedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnSubfoldersToBeRenamedCounted(MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [ProcessAll(findWhat,replaceWith,pathFilter)](#M-MFR-Objects-Renamers-Files-FileRenamer-ProcessAll-System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.ProcessAll(System.String,System.String,System.Predicate{System.String})')
  - [ProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter)](#M-MFR-Objects-Renamers-Files-FileRenamer-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.ProcessAll(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RenameFilesInFolder(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Objects-Renamers-Files-FileRenamer-RenameFilesInFolder-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.RenameFilesInFolder(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RenameSubFoldersOf(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Objects-Renamers-Files-FileRenamer-RenameSubFoldersOf-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.RenameSubFoldersOf(System.String,System.String,System.String,System.Predicate{System.String})')
  - [ReplaceTextInFiles(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Objects-Renamers-Files-FileRenamer-ReplaceTextInFiles-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.ReplaceTextInFiles(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RequestAbort()](#M-MFR-Objects-Renamers-Files-FileRenamer-RequestAbort 'MFR.Renamers.Files.FileRenamer.RequestAbort')
  - [StartingFrom()](#M-MFR-Objects-Renamers-Files-FileRenamer-StartingFrom-System-String- 'MFR.Renamers.Files.FileRenamer.StartingFrom(System.String)')
- [Resources](#T-MFR-Objects-Renamers-Files-Properties-Resources 'MFR.Renamers.Files.Properties.Resources')
  - [Confirm_PerformRename](#P-MFR-Objects-Renamers-Files-Properties-Resources-Confirm_PerformRename 'MFR.Renamers.Files.Properties.Resources.Confirm_PerformRename')
  - [Culture](#P-MFR-Objects-Renamers-Files-Properties-Resources-Culture 'MFR.Renamers.Files.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Renamers-Files-Properties-Resources-ResourceManager 'MFR.Renamers.Files.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Renamers-Files-FileRenamer'></a>
## FileRenamer `type`

##### Namespace

MFR.Renamers.Files

##### Summary

Provides file- and folder-rename services.

##### Remarks

NOTE: Instances of this class must be composed with an instance of an
object that implements the [IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration')
interface.



Such an object is necessary because it provides settings specified by
the user that change the behavior of this object.

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[FileRenamer](#T-MFR-Objects-Renamers-Files-FileRenamer 'MFR.Renamers.Files.FileRenamer')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-#ctor-System-String-'></a>
### #ctor(rootDirectoryPath) `constructor`

##### Summary

Constructs a new instance of
[FileRenamer](#T-MFR-Objects-Renamers-Files-FileRenamer 'MFR.Renamers.Files.FileRenamer')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootDirectoryPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Path to the recursion root. |

<a name='P-MFR-Objects-Renamers-Files-FileRenamer-AbortRequested'></a>
### AbortRequested `property`

##### Summary

Gets a value that indicates whether an abort of the current
operation has been requested.

<a name='P-MFR-Objects-Renamers-Files-FileRenamer-EnabledOperations'></a>
### EnabledOperations `property`

##### Summary

Gets a reference to a collection of of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType')
values.

##### Remarks

All the values in this collection identify operations that the user
wishes to perform.



This list should be cleared after every run.



If the list is empty when the
[ProcessAll](#M-MFR-Objects-FileRenamer-ProcessAll 'MFR.FileRenamer.ProcessAll')
method is called, do
nothing or throw an exception.

<a name='P-MFR-Objects-Renamers-Files-FileRenamer-RootDirectoryPath'></a>
### RootDirectoryPath `property`

##### Summary

Gets a string containing the full pathname of the folder where all
operations start.

<a name='P-MFR-Objects-Renamers-Files-FileRenamer-ShouldReOpenSolution'></a>
### ShouldReOpenSolution `property`

##### Summary

Gets or sets a value determining whether the currently-open solution
in Visual Studio should be closed and then re-opened at the
completion of the operation.

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-EnableOperations-MFR-Objects-Operations-Constants-OperationType[]-'></a>
### EnableOperations(operations) `method`

##### Summary

Enables this object to perform some or all of the operations specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operations | [MFR.Operations.Constants.OperationType[]](#T-MFR-Objects-Operations-Constants-OperationType[] 'MFR.Operations.Constants.OperationType[]') |  |

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-InvokeProcessing-System-String,System-String,System-Predicate{System-String}-'></a>
### InvokeProcessing(findWhat,replaceWith,pathFilter) `method`

##### Summary

Invokes the core processing of this file-renamer object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
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

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-OnExceptionRaised-MFR-Objects-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnExceptionRaised(e) `method`

##### Summary

Raises the [](#E-MFR-Objects-FileRenamer-ExceptionRaised 'MFR.FileRenamer.ExceptionRaised') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.Common.ExceptionRaisedEventArgs](#T-MFR-Objects-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs') | A [ExceptionRaisedEventArgs](#T-MFR-Objects-ExceptionRaisedEventArgs 'MFR.ExceptionRaisedEventArgs') that contains
the event data. |

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-OnFilesToBeRenamedCounted-MFR-Objects-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFilesToBeRenamedCounted(e) `method`

##### Summary

Raises the
[](#E-MFR-Objects-FileRenamer-FilesToBeRenamedCounted 'MFR.FileRenamer.FilesToBeRenamedCounted')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Objects-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Objects-FilesOrFoldersCountedEventArgs 'MFR.FilesOrFoldersCountedEventArgs') that
contains the event data. |

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-OnFilesToHaveTextReplacedCounted-MFR-Objects-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFilesToHaveTextReplacedCounted(e) `method`

##### Summary

Raises the
[](#E-MFR-Objects-FileRenamer-FilesToHaveTextReplacedCounted 'MFR.FileRenamer.FilesToHaveTextReplacedCounted')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Objects-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Objects-FilesOrFoldersCountedEventArgs 'MFR.FilesOrFoldersCountedEventArgs') that
contains the event data. |

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-OnFinished'></a>
### OnFinished() `method`

##### Summary

Raises the
[](#E-MFR-Objects-Renamers-Files-FileRenamer-Finished 'MFR.Renamers.Files.FileRenamer.Finished')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-OnOperationFinished-MFR-Objects-Operations-Events-OperationFinishedEventArgs-'></a>
### OnOperationFinished(e) `method`

##### Summary

Raises the [](#E-MFR-Objects-FileRenamer-OperationFinished 'MFR.FileRenamer.OperationFinished') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Operations.Events.OperationFinishedEventArgs](#T-MFR-Objects-Operations-Events-OperationFinishedEventArgs 'MFR.Operations.Events.OperationFinishedEventArgs') | An [OperationFinishedEventArgs](#T-MFR-Objects-OperationFinishedEventArgs 'MFR.OperationFinishedEventArgs') that
contains the event data. |

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-OnOperationStarted-MFR-Objects-Operations-Events-OperationStartedEventArgs-'></a>
### OnOperationStarted(e) `method`

##### Summary

Raises the [](#E-MFR-Objects-FileRenamer-OperationStarted 'MFR.FileRenamer.OperationStarted') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Operations.Events.OperationStartedEventArgs](#T-MFR-Objects-Operations-Events-OperationStartedEventArgs 'MFR.Operations.Events.OperationStartedEventArgs') | A [OperationStartedEventArgs](#T-MFR-Objects-OperationStartedEventArgs 'MFR.OperationStartedEventArgs') that
contains the event data. |

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-OnProcessingOperation-MFR-Objects-Operations-Events-ProcessingOperationEventArgs-'></a>
### OnProcessingOperation(e) `method`

##### Summary

Raises the [](#E-MFR-Objects-ProcessingOperation 'MFR.ProcessingOperation') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Operations.Events.ProcessingOperationEventArgs](#T-MFR-Objects-Operations-Events-ProcessingOperationEventArgs 'MFR.Operations.Events.ProcessingOperationEventArgs') | A [ProcessingOperationEventArgs](#T-MFR-Objects-ProcessingOperationEventArgs 'MFR.ProcessingOperationEventArgs') that
contains the event data. |

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-OnStarted'></a>
### OnStarted() `method`

##### Summary

Raises the
[](#E-MFR-Objects-Renamers-Files-FileRenamer-Started 'MFR.Renamers.Files.FileRenamer.Started')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-OnStatusUpdate-MFR-Objects-Events-Common-StatusUpdateEventArgs-'></a>
### OnStatusUpdate(e) `method`

##### Summary

Raises the [](#E-MFR-Objects-FileRenamer-StatusUpdate 'MFR.FileRenamer.StatusUpdate') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.Common.StatusUpdateEventArgs](#T-MFR-Objects-Events-Common-StatusUpdateEventArgs 'MFR.Events.Common.StatusUpdateEventArgs') | A [StatusUpdateEventArgs](#T-MFR-Objects-StatusUpdateEventArgs 'MFR.StatusUpdateEventArgs') that contains
the event data. |

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-OnSubfoldersToBeRenamedCounted-MFR-Objects-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnSubfoldersToBeRenamedCounted(e) `method`

##### Summary

Raises the
[](#E-MFR-Objects-FileRenamer-SubfoldersToBeRenamedCounted 'MFR.FileRenamer.SubfoldersToBeRenamedCounted')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Objects-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Objects-FilesOrFoldersCountedEventArgs 'MFR.FilesOrFoldersCountedEventArgs') that
contains the event data. |

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-ProcessAll-System-String,System-String,System-Predicate{System-String}-'></a>
### ProcessAll(findWhat,replaceWith,pathFilter) `method`

##### Summary

Executes the Rename Subfolders, Rename Files, and Replace Text in
Files operation on all the folders and files in the root folder with
the pathname stored in the
[RootDirectoryPath](#P-MFR-Objects-FileRenamer-RootDirectoryPath 'MFR.FileRenamer.RootDirectoryPath')
property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
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

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
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

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`rootDirectoryPath`
, is passed a blank or
`null`
string for a value. |

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-RenameFilesInFolder-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### RenameFilesInFolder(rootFolderPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Renames all the files in the all the subfolders etc., recursively,
of the folder whose pathname is specified by the
`rootFolderPath`
parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the full pathname of an existing
directory on the computer that is to be where the operation is started. |
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

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either the `rootFolderPath`,
`findWhat`
, or `replaceWith` parameters are blank. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the
`rootFolderPath`
does not exist. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-RenameSubFoldersOf-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### RenameSubFoldersOf(rootFolderPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Recursively renames all the subfolders in the folder having a
pathname specified by `rootFolderPath`, replacing
any occurrences of the text in the `findWhat`
parameter with the values in the `replaceWith` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the full pathname of an existing
directory on the computer that is to be where the operation is started. |
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

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either the `rootFolderPath`,
`findWhat`
, or `replaceWith` parameters are blank. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the
`rootFolderPath`
does not exist. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-ReplaceTextInFiles-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### ReplaceTextInFiles(rootFolderPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Iterates recursively through a directory tree, starting at the
folder with pathname `rootFolderPath` and replacing
every occurrence of the text specified by the
`findWhat`
parameter with the text specified by the
`replaceWith`
parameter. A case-sensitive, not-in-exact-word
search is performed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Pathname of the folder where the operation is to start. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Text to be found in each file contained in the directory tree. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Text to replace all the instances of
`findWhat`
with. If this parameter is blank (the default),
then the text is deleted. |
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

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either the `rootFolderPath` or the
`findWhat` parameters are blank. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the
`rootFolderPath`
does not exist. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-RequestAbort'></a>
### RequestAbort() `method`

##### Summary

Called to ask the `File Renamer` object to stop operations.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Renamers-Files-FileRenamer-StartingFrom-System-String-'></a>
### StartingFrom() `method`

##### Summary

Initializes the value of the
[RootDirectoryPath](#P-MFR-Objects-IFileRenamer-RootDirectoryPath 'MFR.IFileRenamer.RootDirectoryPath')
property to
the value specified in the `rootDirectoryPath` parameter.



The value is the starting location of the search operations.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Renamers-Files-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Renamers.Files.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Renamers-Files-Properties-Resources-Confirm_PerformRename'></a>
### Confirm_PerformRename `property`

##### Summary

Looks up a localized string similar to We've noticed that you have one or more instances of Visual Studio 2019 open.

It doesn't appear that the solution contaiing the project to be renamed is open in any of them.

Choose File -> Reopen Workspace when the selected rename operation(s) have completed if the solution is open and we missed it..

<a name='P-MFR-Objects-Renamers-Files-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Renamers-Files-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
