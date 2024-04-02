<a name='assembly'></a>
# MFR.Events

## Contents

- [ErrorEventArgs](#T-MFR-Events-ErrorEventArgs 'MFR.Events.ErrorEventArgs')
  - [#ctor(message)](#M-MFR-Events-ErrorEventArgs-#ctor-System-String- 'MFR.Events.ErrorEventArgs.#ctor(System.String)')
  - [Message](#P-MFR-Events-ErrorEventArgs-Message 'MFR.Events.ErrorEventArgs.Message')
- [ErrorEventHandler](#T-MFR-Events-ErrorEventHandler 'MFR.Events.ErrorEventHandler')
- [FileRenamedEventArgs](#T-MFR-Events-FileRenamedEventArgs 'MFR.Events.FileRenamedEventArgs')
  - [#ctor(source,destination)](#M-MFR-Events-FileRenamedEventArgs-#ctor-System-String,System-String- 'MFR.Events.FileRenamedEventArgs.#ctor(System.String,System.String)')
  - [Destination](#P-MFR-Events-FileRenamedEventArgs-Destination 'MFR.Events.FileRenamedEventArgs.Destination')
  - [Source](#P-MFR-Events-FileRenamedEventArgs-Source 'MFR.Events.FileRenamedEventArgs.Source')
- [FileRenamedEventHandler](#T-MFR-Events-FileRenamedEventHandler 'MFR.Events.FileRenamedEventHandler')
- [FileSystemEntrySkippedEventArgs](#T-MFR-Events-FileSystemEntrySkippedEventArgs 'MFR.Events.FileSystemEntrySkippedEventArgs')
  - [#ctor(pathname)](#M-MFR-Events-FileSystemEntrySkippedEventArgs-#ctor-System-String- 'MFR.Events.FileSystemEntrySkippedEventArgs.#ctor(System.String)')
  - [Pathname](#P-MFR-Events-FileSystemEntrySkippedEventArgs-Pathname 'MFR.Events.FileSystemEntrySkippedEventArgs.Pathname')
- [FileSystemEntrySkippedEventHandler](#T-MFR-Events-FileSystemEntrySkippedEventHandler 'MFR.Events.FileSystemEntrySkippedEventHandler')
- [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs')
  - [#ctor(count,operationType)](#M-MFR-Events-FilesOrFoldersCountedEventArgs-#ctor-System-Int32,MFR-Operations-Constants-OperationType- 'MFR.Events.FilesOrFoldersCountedEventArgs.#ctor(System.Int32,MFR.Operations.Constants.OperationType)')
  - [Count](#P-MFR-Events-FilesOrFoldersCountedEventArgs-Count 'MFR.Events.FilesOrFoldersCountedEventArgs.Count')
- [FilesOrFoldersCountedEventHandler](#T-MFR-Events-FilesOrFoldersCountedEventHandler 'MFR.Events.FilesOrFoldersCountedEventHandler')
- [FolderRenamedEventArgs](#T-MFR-Events-FolderRenamedEventArgs 'MFR.Events.FolderRenamedEventArgs')
  - [#ctor(source,destination)](#M-MFR-Events-FolderRenamedEventArgs-#ctor-System-String,System-String- 'MFR.Events.FolderRenamedEventArgs.#ctor(System.String,System.String)')
  - [Destination](#P-MFR-Events-FolderRenamedEventArgs-Destination 'MFR.Events.FolderRenamedEventArgs.Destination')
  - [Source](#P-MFR-Events-FolderRenamedEventArgs-Source 'MFR.Events.FolderRenamedEventArgs.Source')
- [FolderRenamedEventHandler](#T-MFR-Events-FolderRenamedEventHandler 'MFR.Events.FolderRenamedEventHandler')
- [Resources](#T-MFR-Events-Properties-Resources 'MFR.Events.Properties.Resources')
  - [Culture](#P-MFR-Events-Properties-Resources-Culture 'MFR.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Events-Properties-Resources-ResourceManager 'MFR.Events.Properties.Resources.ResourceManager')
- [TextPatternMatchEventArgs](#T-MFR-Events-TextPatternMatchEventArgs 'MFR.Events.TextPatternMatchEventArgs')
  - [#ctor(source,findWhat,replaceWith,operationType)](#M-MFR-Events-TextPatternMatchEventArgs-#ctor-System-String,System-String,System-String,MFR-Operations-Constants-OperationType- 'MFR.Events.TextPatternMatchEventArgs.#ctor(System.String,System.String,System.String,MFR.Operations.Constants.OperationType)')
  - [#ctor(operationType)](#M-MFR-Events-TextPatternMatchEventArgs-#ctor-MFR-Operations-Constants-OperationType- 'MFR.Events.TextPatternMatchEventArgs.#ctor(MFR.Operations.Constants.OperationType)')
  - [FindWhat](#P-MFR-Events-TextPatternMatchEventArgs-FindWhat 'MFR.Events.TextPatternMatchEventArgs.FindWhat')
  - [ReplaceWith](#P-MFR-Events-TextPatternMatchEventArgs-ReplaceWith 'MFR.Events.TextPatternMatchEventArgs.ReplaceWith')
  - [Source](#P-MFR-Events-TextPatternMatchEventArgs-Source 'MFR.Events.TextPatternMatchEventArgs.Source')

<a name='T-MFR-Events-ErrorEventArgs'></a>
## ErrorEventArgs `type`

##### Namespace

MFR.Events

##### Summary

Provides information for `Error` event handlers.

##### Remarks

The `Error` event is typically raised when an error occurs that's not
triggered by an actual [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception').

<a name='M-MFR-Events-ErrorEventArgs-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Constructs a new instance of [ErrorEventArgs](#T-MFR-Events-ErrorEventArgs 'MFR.Events.ErrorEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the message that
describes the error. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`message`, is passed a blank or `null`
string for a value. |

<a name='P-MFR-Events-ErrorEventArgs-Message'></a>
### Message `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the message that describes the
error.

<a name='T-MFR-Events-ErrorEventHandler'></a>
## ErrorEventHandler `type`

##### Namespace

MFR.Events

##### Summary

Represents a handler for a `Error` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Events.ErrorEventHandler](#T-T-MFR-Events-ErrorEventHandler 'T:MFR.Events.ErrorEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

The `Error` event is typically raised when an error occurs that's not
triggered by an actual [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception').



This delegate merely specifies the signature of all methods that handle the
`Error` event.

<a name='T-MFR-Events-FileRenamedEventArgs'></a>
## FileRenamedEventArgs `type`

##### Namespace

MFR.Events

##### Summary

Provides information for FileRenamed event handlers.

<a name='M-MFR-Events-FileRenamedEventArgs-#ctor-System-String,System-String-'></a>
### #ctor(source,destination) `constructor`

##### Summary

Constructs a new instance of [FileRenamedEventArgs](#T-MFR-Events-FileRenamedEventArgs 'MFR.Events.FileRenamedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname of the file's former location (before the rename operation). |
| destination | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname of the file's current location (after the rename operation). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required
parameters, `source` or `source`, are
passed blank or `null` strings for values. |

<a name='P-MFR-Events-FileRenamedEventArgs-Destination'></a>
### Destination `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified pathname
of the file's current location.

<a name='P-MFR-Events-FileRenamedEventArgs-Source'></a>
### Source `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified pathname
of the file's former name.

<a name='T-MFR-Events-FileRenamedEventHandler'></a>
## FileRenamedEventHandler `type`

##### Namespace

MFR.Events

##### Summary

Represents a handler for a `FileRenamed` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Events.FileRenamedEventHandler](#T-T-MFR-Events-FileRenamedEventHandler 'T:MFR.Events.FileRenamedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`FileRenamed` event.

<a name='T-MFR-Events-FileSystemEntrySkippedEventArgs'></a>
## FileSystemEntrySkippedEventArgs `type`

##### Namespace

MFR.Events

##### Summary

Defines the data that is passed by all events of type [FileSystemEntrySkippedEventHandler](#T-MFR-Events-FileSystemEntrySkippedEventHandler 'MFR.Events.FileSystemEntrySkippedEventHandler').

<a name='M-MFR-Events-FileSystemEntrySkippedEventArgs-#ctor-System-String-'></a>
### #ctor(pathname) `constructor`

##### Summary

Creates a new instance of [FileSystemEntrySkippedEventArgs](#T-MFR-Events-FileSystemEntrySkippedEventArgs 'MFR.Events.FileSystemEntrySkippedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname to the skipped file
system entry (e.g., a file or a folder). |

<a name='P-MFR-Events-FileSystemEntrySkippedEventArgs-Pathname'></a>
### Pathname `property`

##### Summary

Gets the pathname of the file system entry (e.g., a file or a
folder) that is being skipped.

<a name='T-MFR-Events-FileSystemEntrySkippedEventHandler'></a>
## FileSystemEntrySkippedEventHandler `type`

##### Namespace

MFR.Events

##### Summary

Defines the method signature for the handlers of the [](#E-MFR-FileSystemEntrySkippedEventHandler-FileSystemEntrySkipped 'MFR.FileSystemEntrySkippedEventHandler.FileSystemEntrySkipped') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Events.FileSystemEntrySkippedEventHandler](#T-T-MFR-Events-FileSystemEntrySkippedEventHandler 'T:MFR.Events.FileSystemEntrySkippedEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-MFR-Events-FilesOrFoldersCountedEventArgs'></a>
## FilesOrFoldersCountedEventArgs `type`

##### Namespace

MFR.Events

##### Summary

Defines the data that is passed by all events of type [FilesOrFoldersCountedEventHandler](#T-MFR-Events-FilesOrFoldersCountedEventHandler 'MFR.Events.FilesOrFoldersCountedEventHandler').

<a name='M-MFR-Events-FilesOrFoldersCountedEventArgs-#ctor-System-Int32,MFR-Operations-Constants-OperationType-'></a>
### #ctor(count,operationType) `constructor`

##### Summary

Creates a new instance of [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) A zero or positive integer specifying the number of
files to be processed by the operation. |
| operationType | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values that
specifies the operation being performed. |

<a name='P-MFR-Events-FilesOrFoldersCountedEventArgs-Count'></a>
### Count `property`

##### Summary

Gets the count of files to be processed.

<a name='T-MFR-Events-FilesOrFoldersCountedEventHandler'></a>
## FilesOrFoldersCountedEventHandler `type`

##### Namespace

MFR.Events

##### Summary

Defines the method signature for the handlers of the [](#E-MFR-FilesOrFoldersCountedEventHandler-FilesOrFoldersCounted 'MFR.FilesOrFoldersCountedEventHandler.FilesOrFoldersCounted') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Events.FilesOrFoldersCountedEventHandler](#T-T-MFR-Events-FilesOrFoldersCountedEventHandler 'T:MFR.Events.FilesOrFoldersCountedEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-MFR-Events-FolderRenamedEventArgs'></a>
## FolderRenamedEventArgs `type`

##### Namespace

MFR.Events

##### Summary

Provides information for `FolderRenamed` event handlers.

##### Remarks

This class is utilized in order to supply data to handlers of the
`FolderRenamed` event.



This class has two read-only [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') properties,
[Source](#P-MFR-Events-FolderRenamedEventArgs-Source 'MFR.Events.FolderRenamedEventArgs.Source') and
[Destination](#P-MFR-Events-FolderRenamedEventArgs-Destination 'MFR.Events.FolderRenamedEventArgs.Destination').



The [Source](#P-MFR-Events-FolderRenamedEventArgs-Source 'MFR.Events.FolderRenamedEventArgs.Source') property stores
the fully-qualified pathname of the previous location of a folder that has been
renamed.  The [Destination](#P-MFR-Events-FolderRenamedEventArgs-Destination 'MFR.Events.FolderRenamedEventArgs.Destination')
property stores the fully-qualified pathname of the current location of a
folder that has been renamed.



Callers of this class must use the class' constructor to initialize these
properties.

<a name='M-MFR-Events-FolderRenamedEventArgs-#ctor-System-String,System-String-'></a>
### #ctor(source,destination) `constructor`

##### Summary

Constructs a new instance of [FolderRenamedEventArgs](#T-MFR-Events-FolderRenamedEventArgs 'MFR.Events.FolderRenamedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname of the previous location of a folder that has been renamed. |
| destination | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname of the current location of a folder that has been renamed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required
parameters, `source` or `destination`, are
passed blank or `null` strings for values. |

##### Remarks

This constructor is utilized in order to construct a new instance of an object
that supplies data to handlers of the `FolderRenamed` event.



This constructor has two required parameters, `source` and
`destination`.  Both must be filled in, otherwise
[ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') is thrown.  The
`source` parameter should refer to the name the folder used
to have, and the `destination` parameter should refer to the
current pathname of the folder.



If valid values have been passed for both the `source` and
`destination` parameters, then this constructor sets the
values of the [Source](#P-MFR-Events-FolderRenamedEventArgs-Source 'MFR.Events.FolderRenamedEventArgs.Source') and
[Destination](#P-MFR-Events-FolderRenamedEventArgs-Destination 'MFR.Events.FolderRenamedEventArgs.Destination') properties to
the corresponding parameter values.

<a name='P-MFR-Events-FolderRenamedEventArgs-Destination'></a>
### Destination `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the current location of a folder that has been renamed.

<a name='P-MFR-Events-FolderRenamedEventArgs-Source'></a>
### Source `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the previous location of a folder that has been renamed.

<a name='T-MFR-Events-FolderRenamedEventHandler'></a>
## FolderRenamedEventHandler `type`

##### Namespace

MFR.Events

##### Summary

Represents a handler for a `FolderRenamed` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Events.FolderRenamedEventHandler](#T-T-MFR-Events-FolderRenamedEventHandler 'T:MFR.Events.FolderRenamedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`FolderRenamed` event.

<a name='T-MFR-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Events-TextPatternMatchEventArgs'></a>
## TextPatternMatchEventArgs `type`

##### Namespace

MFR.Events

##### Summary

Base class that provides common methods and properties for all
event-argument objects for text pattern matches.

<a name='M-MFR-Events-TextPatternMatchEventArgs-#ctor-System-String,System-String,System-String,MFR-Operations-Constants-OperationType-'></a>
### #ctor(source,findWhat,replaceWith,operationType) `constructor`

##### Summary

Constructs a new instance of
[TextPatternMatchEventArgs](#T-MFR-TextPatternMatchEventArgs 'MFR.TextPatternMatchEventArgs')
and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text that is to be searched for
the pattern in `findWhat`.



This typically the fully-qualified pathname of a file or folder;
however, if we are doing the
[ReplaceTextInFiles](#T-MFR-Operations-Constants-OperationType-ReplaceTextInFiles 'MFR.Operations.Constants.OperationType.ReplaceTextInFiles')
operation, then this the text of the current file before
find-and-replace has been done. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the textual criteria for the match. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data that any occurrences of
`findWhat` in the `source` should
be replaced with.



NOTE: This parameter may be blank for the
[ReplaceTextInFiles](#T-MFR-Operations-Constants-OperationType-ReplaceTextInFiles 'MFR.Operations.Constants.OperationType.ReplaceTextInFiles')
operation type. |
| operationType | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
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

<a name='M-MFR-Events-TextPatternMatchEventArgs-#ctor-MFR-Operations-Constants-OperationType-'></a>
### #ctor(operationType) `constructor`

##### Summary

Constructs a new instance of
[OperationEventArgs](#T-MFR-OperationEventArgs 'MFR.OperationEventArgs')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationType | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
specifies the operation being performed. |

<a name='P-MFR-Events-TextPatternMatchEventArgs-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets a string containing the textual criteria for determining
whether the name of the file is to be targeted by a rename operation.

<a name='P-MFR-Events-TextPatternMatchEventArgs-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets the text that any found occurrences of the data in the
[FindWhat](#P-MFR-Events-TextPatternMatchEventArgs-FindWhat 'MFR.Events.TextPatternMatchEventArgs.FindWhat')
should be replaced with.

<a name='P-MFR-Events-TextPatternMatchEventArgs-Source'></a>
### Source `property`

##### Summary

Gets a string containing the full pathname of the file to run a
match operation against.
