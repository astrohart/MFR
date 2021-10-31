<a name='assembly'></a>
# MFR.Events

## Contents

- [FileSystemEntrySkippedEventArgs](#T-MFR-Objects-Events-FileSystemEntrySkippedEventArgs 'MFR.Events.FileSystemEntrySkippedEventArgs')
  - [#ctor(pathname)](#M-MFR-Objects-Events-FileSystemEntrySkippedEventArgs-#ctor-System-String- 'MFR.Events.FileSystemEntrySkippedEventArgs.#ctor(System.String)')
  - [Pathname](#P-MFR-Objects-Events-FileSystemEntrySkippedEventArgs-Pathname 'MFR.Events.FileSystemEntrySkippedEventArgs.Pathname')
- [FileSystemEntrySkippedEventHandler](#T-MFR-Objects-Events-FileSystemEntrySkippedEventHandler 'MFR.Events.FileSystemEntrySkippedEventHandler')
- [FilesOrFoldersCountedEventArgs](#T-MFR-Objects-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs')
  - [#ctor(count,operationType)](#M-MFR-Objects-Events-FilesOrFoldersCountedEventArgs-#ctor-System-Int32,MFR-Objects-Operations-Constants-OperationType- 'MFR.Events.FilesOrFoldersCountedEventArgs.#ctor(System.Int32,MFR.Operations.Constants.OperationType)')
  - [Count](#P-MFR-Objects-Events-FilesOrFoldersCountedEventArgs-Count 'MFR.Events.FilesOrFoldersCountedEventArgs.Count')
- [FilesOrFoldersCountedEventHandler](#T-MFR-Objects-Events-FilesOrFoldersCountedEventHandler 'MFR.Events.FilesOrFoldersCountedEventHandler')
- [Resources](#T-MFR-Objects-Events-Properties-Resources 'MFR.Events.Properties.Resources')
  - [Culture](#P-MFR-Objects-Events-Properties-Resources-Culture 'MFR.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Events-Properties-Resources-ResourceManager 'MFR.Events.Properties.Resources.ResourceManager')
- [TextPatternMatchEventArgs](#T-MFR-Objects-Events-TextPatternMatchEventArgs 'MFR.Events.TextPatternMatchEventArgs')
  - [#ctor(source,findWhat,replaceWith,operationType)](#M-MFR-Objects-Events-TextPatternMatchEventArgs-#ctor-System-String,System-String,System-String,MFR-Objects-Operations-Constants-OperationType- 'MFR.Events.TextPatternMatchEventArgs.#ctor(System.String,System.String,System.String,MFR.Operations.Constants.OperationType)')
  - [#ctor(operationType)](#M-MFR-Objects-Events-TextPatternMatchEventArgs-#ctor-MFR-Objects-Operations-Constants-OperationType- 'MFR.Events.TextPatternMatchEventArgs.#ctor(MFR.Operations.Constants.OperationType)')
  - [FindWhat](#P-MFR-Objects-Events-TextPatternMatchEventArgs-FindWhat 'MFR.Events.TextPatternMatchEventArgs.FindWhat')
  - [ReplaceWith](#P-MFR-Objects-Events-TextPatternMatchEventArgs-ReplaceWith 'MFR.Events.TextPatternMatchEventArgs.ReplaceWith')
  - [Source](#P-MFR-Objects-Events-TextPatternMatchEventArgs-Source 'MFR.Events.TextPatternMatchEventArgs.Source')

<a name='T-MFR-Objects-Events-FileSystemEntrySkippedEventArgs'></a>
## FileSystemEntrySkippedEventArgs `type`

##### Namespace

MFR.Events

##### Summary

Defines the data that is passed by all events of type [FileSystemEntrySkippedEventHandler](#T-MFR-Objects-Events-FileSystemEntrySkippedEventHandler 'MFR.Events.FileSystemEntrySkippedEventHandler').

<a name='M-MFR-Objects-Events-FileSystemEntrySkippedEventArgs-#ctor-System-String-'></a>
### #ctor(pathname) `constructor`

##### Summary

Creates a new instance of [FileSystemEntrySkippedEventArgs](#T-MFR-Objects-Events-FileSystemEntrySkippedEventArgs 'MFR.Events.FileSystemEntrySkippedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname to the skipped file
system entry (e.g., a file or a folder). |

<a name='P-MFR-Objects-Events-FileSystemEntrySkippedEventArgs-Pathname'></a>
### Pathname `property`

##### Summary

Gets the pathname of the file system entry (e.g., a file or a
folder) that is being skipped.

<a name='T-MFR-Objects-Events-FileSystemEntrySkippedEventHandler'></a>
## FileSystemEntrySkippedEventHandler `type`

##### Namespace

MFR.Events

##### Summary

Defines the method signature for the handlers of the [](#E-MFR-Objects-FileSystemEntrySkippedEventHandler-FileSystemEntrySkipped 'MFR.FileSystemEntrySkippedEventHandler.FileSystemEntrySkipped') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Events.FileSystemEntrySkippedEventHandler](#T-T-MFR-Objects-Events-FileSystemEntrySkippedEventHandler 'T:MFR.Events.FileSystemEntrySkippedEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-MFR-Objects-Events-FilesOrFoldersCountedEventArgs'></a>
## FilesOrFoldersCountedEventArgs `type`

##### Namespace

MFR.Events

##### Summary

Defines the data that is passed by all events of type [FilesOrFoldersCountedEventHandler](#T-MFR-Objects-Events-FilesOrFoldersCountedEventHandler 'MFR.Events.FilesOrFoldersCountedEventHandler').

<a name='M-MFR-Objects-Events-FilesOrFoldersCountedEventArgs-#ctor-System-Int32,MFR-Objects-Operations-Constants-OperationType-'></a>
### #ctor(count,operationType) `constructor`

##### Summary

Creates a new instance of [FilesOrFoldersCountedEventArgs](#T-MFR-Objects-FilesOrFoldersCountedEventArgs 'MFR.FilesOrFoldersCountedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) A zero or positive integer specifying the number of
files to be processed by the operation. |
| operationType | [MFR.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType') values that
specifies the operation being performed. |

<a name='P-MFR-Objects-Events-FilesOrFoldersCountedEventArgs-Count'></a>
### Count `property`

##### Summary

Gets the count of files to be processed.

<a name='T-MFR-Objects-Events-FilesOrFoldersCountedEventHandler'></a>
## FilesOrFoldersCountedEventHandler `type`

##### Namespace

MFR.Events

##### Summary

Defines the method signature for the handlers of the [](#E-MFR-Objects-FilesOrFoldersCountedEventHandler-FilesOrFoldersCounted 'MFR.FilesOrFoldersCountedEventHandler.FilesOrFoldersCounted') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Events.FilesOrFoldersCountedEventHandler](#T-T-MFR-Objects-Events-FilesOrFoldersCountedEventHandler 'T:MFR.Events.FilesOrFoldersCountedEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-MFR-Objects-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-Events-TextPatternMatchEventArgs'></a>
## TextPatternMatchEventArgs `type`

##### Namespace

MFR.Events

##### Summary

Base class that provides common methods and properties for all
event-argument objects for text pattern matches.

<a name='M-MFR-Objects-Events-TextPatternMatchEventArgs-#ctor-System-String,System-String,System-String,MFR-Objects-Operations-Constants-OperationType-'></a>
### #ctor(source,findWhat,replaceWith,operationType) `constructor`

##### Summary

Constructs a new instance of
[TextPatternMatchEventArgs](#T-MFR-Objects-TextPatternMatchEventArgs 'MFR.TextPatternMatchEventArgs')
and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text that is to be searched for
the pattern in `findWhat`.



This is typically the fully-qualified pathname of a file or folder;
however, if we are doing the
[ReplaceTextInFiles](#T-MFR-Objects-OperationType-ReplaceTextInFiles 'MFR.OperationType.ReplaceTextInFiles')
operation, then this is the text of the current file before
find-and-replace has been done. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the textual criteria for the match. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data that any occurrences of
`findWhat` in the `source` should
be replaced with.



NOTE: This parameter may be blank for the
[ReplaceTextInFiles](#T-MFR-Objects-OperationType-ReplaceTextInFiles 'MFR.OperationType.ReplaceTextInFiles')
operation type. |
| operationType | [MFR.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType')
values that
describes what operation is being performed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the either of the required parameters,
`source`
. `findWhat` , or
`replaceWith`
, are passed blank or `null` strings for values. |

<a name='M-MFR-Objects-Events-TextPatternMatchEventArgs-#ctor-MFR-Objects-Operations-Constants-OperationType-'></a>
### #ctor(operationType) `constructor`

##### Summary

Constructs a new instance of
[OperationEventArgs](#T-MFR-Objects-OperationEventArgs 'MFR.OperationEventArgs')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationType | [MFR.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType')
values that
specifies the operation being performed. |

<a name='P-MFR-Objects-Events-TextPatternMatchEventArgs-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets a string containing the textual criteria for determining
whether the name of the file is to be targeted by a rename operation.

<a name='P-MFR-Objects-Events-TextPatternMatchEventArgs-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets the text that any found occurrences of the data in the
[FindWhat](#P-MFR-Objects-Events-TextPatternMatchEventArgs-FindWhat 'MFR.Events.TextPatternMatchEventArgs.FindWhat')
should be replaced with.

<a name='P-MFR-Objects-Events-TextPatternMatchEventArgs-Source'></a>
### Source `property`

##### Summary

Gets a string containing the full pathname of the file to run a
match operation against.
