<a name='assembly'></a>
# MFR.Operations.Events

## Contents

- [DataOperationErrorEventArgs](#T-MFR-Operations-Events-DataOperationErrorEventArgs 'MFR.Operations.Events.DataOperationErrorEventArgs')
  - [#ctor(exception)](#M-MFR-Operations-Events-DataOperationErrorEventArgs-#ctor-System-Exception- 'MFR.Operations.Events.DataOperationErrorEventArgs.#ctor(System.Exception)')
- [DataOperationErrorEventHandler](#T-MFR-Operations-Events-DataOperationErrorEventHandler 'MFR.Operations.Events.DataOperationErrorEventHandler')
- [DataOperationEventArgs](#T-MFR-Operations-Events-DataOperationEventArgs 'MFR.Operations.Events.DataOperationEventArgs')
  - [#ctor(message)](#M-MFR-Operations-Events-DataOperationEventArgs-#ctor-System-String- 'MFR.Operations.Events.DataOperationEventArgs.#ctor(System.String)')
  - [Message](#P-MFR-Operations-Events-DataOperationEventArgs-Message 'MFR.Operations.Events.DataOperationEventArgs.Message')
- [DataOperationEventHandler](#T-MFR-Operations-Events-DataOperationEventHandler 'MFR.Operations.Events.DataOperationEventHandler')
- [OperationCancelEventArgs](#T-MFR-Operations-Events-OperationCancelEventArgs 'MFR.Operations.Events.OperationCancelEventArgs')
  - [#ctor(type)](#M-MFR-Operations-Events-OperationCancelEventArgs-#ctor-MFR-Operations-Constants-OperationType- 'MFR.Operations.Events.OperationCancelEventArgs.#ctor(MFR.Operations.Constants.OperationType)')
  - [OperationType](#P-MFR-Operations-Events-OperationCancelEventArgs-OperationType 'MFR.Operations.Events.OperationCancelEventArgs.OperationType')
- [OperationEventArgs](#T-MFR-Operations-Events-OperationEventArgs 'MFR.Operations.Events.OperationEventArgs')
  - [#ctor(operationType)](#M-MFR-Operations-Events-OperationEventArgs-#ctor-MFR-Operations-Constants-OperationType- 'MFR.Operations.Events.OperationEventArgs.#ctor(MFR.Operations.Constants.OperationType)')
  - [OperationType](#P-MFR-Operations-Events-OperationEventArgs-OperationType 'MFR.Operations.Events.OperationEventArgs.OperationType')
- [OperationFinishedEventArgs](#T-MFR-Operations-Events-OperationFinishedEventArgs 'MFR.Operations.Events.OperationFinishedEventArgs')
  - [#ctor(operationType)](#M-MFR-Operations-Events-OperationFinishedEventArgs-#ctor-MFR-Operations-Constants-OperationType- 'MFR.Operations.Events.OperationFinishedEventArgs.#ctor(MFR.Operations.Constants.OperationType)')
- [OperationFinishedEventHandler](#T-MFR-Operations-Events-OperationFinishedEventHandler 'MFR.Operations.Events.OperationFinishedEventHandler')
- [OperationStartedEventArgs](#T-MFR-Operations-Events-OperationStartedEventArgs 'MFR.Operations.Events.OperationStartedEventArgs')
  - [#ctor(operationType)](#M-MFR-Operations-Events-OperationStartedEventArgs-#ctor-MFR-Operations-Constants-OperationType- 'MFR.Operations.Events.OperationStartedEventArgs.#ctor(MFR.Operations.Constants.OperationType)')
- [OperationStartedEventHandler](#T-MFR-Operations-Events-OperationStartedEventHandler 'MFR.Operations.Events.OperationStartedEventHandler')
- [ProcessingOperationEventArgs](#T-MFR-Operations-Events-ProcessingOperationEventArgs 'MFR.Operations.Events.ProcessingOperationEventArgs')
  - [#ctor(entry,type)](#M-MFR-Operations-Events-ProcessingOperationEventArgs-#ctor-MFR-FileSystem-Interfaces-IFileSystemEntry,MFR-Operations-Constants-OperationType- 'MFR.Operations.Events.ProcessingOperationEventArgs.#ctor(MFR.FileSystem.Interfaces.IFileSystemEntry,MFR.Operations.Constants.OperationType)')
  - [Entry](#P-MFR-Operations-Events-ProcessingOperationEventArgs-Entry 'MFR.Operations.Events.ProcessingOperationEventArgs.Entry')
- [ProcessingOperationEventHandler](#T-MFR-Operations-Events-ProcessingOperationEventHandler 'MFR.Operations.Events.ProcessingOperationEventHandler')
- [Resources](#T-MFR-Operations-Events-Properties-Resources 'MFR.Operations.Events.Properties.Resources')
  - [Culture](#P-MFR-Operations-Events-Properties-Resources-Culture 'MFR.Operations.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Operations-Events-Properties-Resources-ResourceManager 'MFR.Operations.Events.Properties.Resources.ResourceManager')

<a name='T-MFR-Operations-Events-DataOperationErrorEventArgs'></a>
## DataOperationErrorEventArgs `type`

##### Namespace

MFR.Operations.Events

##### Summary

Provides information for DataOperationError event handlers.

<a name='M-MFR-Operations-Events-DataOperationErrorEventArgs-#ctor-System-Exception-'></a>
### #ctor(exception) `constructor`

##### Summary

Constructs a new instance of [DataOperationErrorEventArgs](#T-MFR-Operations-Events-DataOperationErrorEventArgs 'MFR.Operations.Events.DataOperationErrorEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) Reference to an instance of [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') , or a child of it, that provides error details. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `exception`, is
passed a `null` reference for a value. |

<a name='T-MFR-Operations-Events-DataOperationErrorEventHandler'></a>
## DataOperationErrorEventHandler `type`

##### Namespace

MFR.Operations.Events

##### Summary

Represents a handler for a DataOperationError event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Operations.Events.DataOperationErrorEventHandler](#T-T-MFR-Operations-Events-DataOperationErrorEventHandler 'T:MFR.Operations.Events.DataOperationErrorEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle
the DataOperationError event.

<a name='T-MFR-Operations-Events-DataOperationEventArgs'></a>
## DataOperationEventArgs `type`

##### Namespace

MFR.Operations.Events

##### Summary

Provides information for DataOperation event handlers.

<a name='M-MFR-Operations-Events-DataOperationEventArgs-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Constructs a new instance of [DataOperationEventArgs](#T-MFR-Operations-Events-DataOperationEventArgs 'MFR.Operations.Events.DataOperationEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing message text to be displayed to the
user while the operation is progressing. |

<a name='P-MFR-Operations-Events-DataOperationEventArgs-Message'></a>
### Message `property`

##### Summary

Gets a string containing a message to be displayed to the user
during a data update operation.

<a name='T-MFR-Operations-Events-DataOperationEventHandler'></a>
## DataOperationEventHandler `type`

##### Namespace

MFR.Operations.Events

##### Summary

Represents a handler for an DataOperation event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Operations.Events.DataOperationEventHandler](#T-T-MFR-Operations-Events-DataOperationEventHandler 'T:MFR.Operations.Events.DataOperationEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle
the DataOperation event.

<a name='T-MFR-Operations-Events-OperationCancelEventArgs'></a>
## OperationCancelEventArgs `type`

##### Namespace

MFR.Operations.Events

##### Summary

Contains data for an OperationCanceled event.

<a name='M-MFR-Operations-Events-OperationCancelEventArgs-#ctor-MFR-Operations-Constants-OperationType-'></a>
### #ctor(type) `constructor`

##### Summary

Constructs a new instance of [OperationEventArgs](#T-MFR-OperationEventArgs 'MFR.OperationEventArgs') and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values that
specifies the operation being performed. |

<a name='P-MFR-Operations-Events-OperationCancelEventArgs-OperationType'></a>
### OperationType `property`

##### Summary

Gets the type of operation being performed.

<a name='T-MFR-Operations-Events-OperationEventArgs'></a>
## OperationEventArgs `type`

##### Namespace

MFR.Operations.Events

##### Summary

Provides methods and properties common to all event argument objects for
a particular operation type.

<a name='M-MFR-Operations-Events-OperationEventArgs-#ctor-MFR-Operations-Constants-OperationType-'></a>
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

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotSupportedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotSupportedException 'System.NotSupportedException') | Thrown if
[Unknown](#T-MFR-Operations-Constants-OperationType-Unknown 'MFR.Operations.Constants.OperationType.Unknown')
is passed
for the `operationType` parameter. |

<a name='P-MFR-Operations-Events-OperationEventArgs-OperationType'></a>
### OperationType `property`

##### Summary

Gets the type of operation being performed.

<a name='T-MFR-Operations-Events-OperationFinishedEventArgs'></a>
## OperationFinishedEventArgs `type`

##### Namespace

MFR.Operations.Events

##### Summary

Contains the data for a OperationFinished event.

<a name='M-MFR-Operations-Events-OperationFinishedEventArgs-#ctor-MFR-Operations-Constants-OperationType-'></a>
### #ctor(operationType) `constructor`

##### Summary

Constructs a new instance of [OperationEventArgs](#T-MFR-OperationEventArgs 'MFR.OperationEventArgs') and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationType | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values that
specifies the operation being performed. |

<a name='T-MFR-Operations-Events-OperationFinishedEventHandler'></a>
## OperationFinishedEventHandler `type`

##### Namespace

MFR.Operations.Events

##### Summary

Represents a handler for an OperationFinished event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Operations.Events.OperationFinishedEventHandler](#T-T-MFR-Operations-Events-OperationFinishedEventHandler 'T:MFR.Operations.Events.OperationFinishedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle
the OperationFinished event.

<a name='T-MFR-Operations-Events-OperationStartedEventArgs'></a>
## OperationStartedEventArgs `type`

##### Namespace

MFR.Operations.Events

##### Summary

Defines the data that is passed by all events of type [OperationStartedEventHandler](#T-MFR-Operations-Events-OperationStartedEventHandler 'MFR.Operations.Events.OperationStartedEventHandler').

<a name='M-MFR-Operations-Events-OperationStartedEventArgs-#ctor-MFR-Operations-Constants-OperationType-'></a>
### #ctor(operationType) `constructor`

##### Summary

Constructs a new instance of [OperationEventArgs](#T-MFR-OperationEventArgs 'MFR.OperationEventArgs') and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationType | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values that
specifies the operation being performed. |

<a name='T-MFR-Operations-Events-OperationStartedEventHandler'></a>
## OperationStartedEventHandler `type`

##### Namespace

MFR.Operations.Events

##### Summary

Defines the method signature for the handlers of the [](#E-MFR-FileRenamer-OperationStarted 'MFR.FileRenamer.OperationStarted') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Operations.Events.OperationStartedEventHandler](#T-T-MFR-Operations-Events-OperationStartedEventHandler 'T:MFR.Operations.Events.OperationStartedEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-MFR-Operations-Events-ProcessingOperationEventArgs'></a>
## ProcessingOperationEventArgs `type`

##### Namespace

MFR.Operations.Events

##### Summary

Defines the data that is passed by all events of type
[ProcessingOperationEventHandler](#T-MFR-Operations-Events-ProcessingOperationEventHandler 'MFR.Operations.Events.ProcessingOperationEventHandler').

<a name='M-MFR-Operations-Events-ProcessingOperationEventArgs-#ctor-MFR-FileSystem-Interfaces-IFileSystemEntry,MFR-Operations-Constants-OperationType-'></a>
### #ctor(entry,type) `constructor`

##### Summary

Creates a new instance of
[ProcessingOperationEventArgs](#T-MFR-ProcessingOperationEventArgs 'MFR.ProcessingOperationEventArgs')
and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface. |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
specifies the operation being performed. |

<a name='P-MFR-Operations-Events-ProcessingOperationEventArgs-Entry'></a>
### Entry `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface
that represents information about which file or folder is about to
be processed.

<a name='T-MFR-Operations-Events-ProcessingOperationEventHandler'></a>
## ProcessingOperationEventHandler `type`

##### Namespace

MFR.Operations.Events

##### Summary

Defines the method signature for the handlers of a ProcessingOperation event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Operations.Events.ProcessingOperationEventHandler](#T-T-MFR-Operations-Events-ProcessingOperationEventHandler 'T:MFR.Operations.Events.ProcessingOperationEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-MFR-Operations-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Operations.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Operations-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Operations-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
