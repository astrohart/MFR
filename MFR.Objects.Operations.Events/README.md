<a name='assembly'></a>
# MFR.Objects.Operations.Events

## Contents

- [DataOperationErrorEventArgs](#T-MFR-Objects-Operations-Events-DataOperationErrorEventArgs 'MFR.Objects.Operations.Events.DataOperationErrorEventArgs')
  - [#ctor(exception)](#M-MFR-Objects-Operations-Events-DataOperationErrorEventArgs-#ctor-System-Exception- 'MFR.Objects.Operations.Events.DataOperationErrorEventArgs.#ctor(System.Exception)')
- [DataOperationErrorEventHandler](#T-MFR-Objects-Operations-Events-DataOperationErrorEventHandler 'MFR.Objects.Operations.Events.DataOperationErrorEventHandler')
- [DataOperationEventArgs](#T-MFR-Objects-Operations-Events-DataOperationEventArgs 'MFR.Objects.Operations.Events.DataOperationEventArgs')
  - [Message](#P-MFR-Objects-Operations-Events-DataOperationEventArgs-Message 'MFR.Objects.Operations.Events.DataOperationEventArgs.Message')
- [DataOperationEventHandler](#T-MFR-Objects-Operations-Events-DataOperationEventHandler 'MFR.Objects.Operations.Events.DataOperationEventHandler')
- [OperationCancelEventArgs](#T-MFR-Objects-Operations-Events-OperationCancelEventArgs 'MFR.Objects.Operations.Events.OperationCancelEventArgs')
  - [#ctor(type)](#M-MFR-Objects-Operations-Events-OperationCancelEventArgs-#ctor-MFR-Objects-Operations-Constants-OperationType- 'MFR.Objects.Operations.Events.OperationCancelEventArgs.#ctor(MFR.Objects.Operations.Constants.OperationType)')
  - [OperationType](#P-MFR-Objects-Operations-Events-OperationCancelEventArgs-OperationType 'MFR.Objects.Operations.Events.OperationCancelEventArgs.OperationType')
- [OperationEventArgs](#T-MFR-Objects-Operations-Events-OperationEventArgs 'MFR.Objects.Operations.Events.OperationEventArgs')
  - [#ctor(operationType)](#M-MFR-Objects-Operations-Events-OperationEventArgs-#ctor-MFR-Objects-Operations-Constants-OperationType- 'MFR.Objects.Operations.Events.OperationEventArgs.#ctor(MFR.Objects.Operations.Constants.OperationType)')
  - [OperationType](#P-MFR-Objects-Operations-Events-OperationEventArgs-OperationType 'MFR.Objects.Operations.Events.OperationEventArgs.OperationType')
- [OperationFinishedEventArgs](#T-MFR-Objects-Operations-Events-OperationFinishedEventArgs 'MFR.Objects.Operations.Events.OperationFinishedEventArgs')
  - [#ctor(operationType)](#M-MFR-Objects-Operations-Events-OperationFinishedEventArgs-#ctor-MFR-Objects-Operations-Constants-OperationType- 'MFR.Objects.Operations.Events.OperationFinishedEventArgs.#ctor(MFR.Objects.Operations.Constants.OperationType)')
- [OperationFinishedEventHandler](#T-MFR-Objects-Operations-Events-OperationFinishedEventHandler 'MFR.Objects.Operations.Events.OperationFinishedEventHandler')
- [OperationStartedEventArgs](#T-MFR-Objects-Operations-Events-OperationStartedEventArgs 'MFR.Objects.Operations.Events.OperationStartedEventArgs')
  - [#ctor(operationType)](#M-MFR-Objects-Operations-Events-OperationStartedEventArgs-#ctor-MFR-Objects-Operations-Constants-OperationType- 'MFR.Objects.Operations.Events.OperationStartedEventArgs.#ctor(MFR.Objects.Operations.Constants.OperationType)')
- [OperationStartedEventHandler](#T-MFR-Objects-Operations-Events-OperationStartedEventHandler 'MFR.Objects.Operations.Events.OperationStartedEventHandler')
- [ProcessingOperationEventArgs](#T-MFR-Objects-Operations-Events-ProcessingOperationEventArgs 'MFR.Objects.Operations.Events.ProcessingOperationEventArgs')
  - [#ctor(entry,type)](#M-MFR-Objects-Operations-Events-ProcessingOperationEventArgs-#ctor-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry,MFR-Objects-Operations-Constants-OperationType- 'MFR.Objects.Operations.Events.ProcessingOperationEventArgs.#ctor(MFR.Objects.FileSystem.Interfaces.IFileSystemEntry,MFR.Objects.Operations.Constants.OperationType)')
  - [Entry](#P-MFR-Objects-Operations-Events-ProcessingOperationEventArgs-Entry 'MFR.Objects.Operations.Events.ProcessingOperationEventArgs.Entry')
- [ProcessingOperationEventHandler](#T-MFR-Objects-Operations-Events-ProcessingOperationEventHandler 'MFR.Objects.Operations.Events.ProcessingOperationEventHandler')
- [Resources](#T-MFR-Objects-Operations-Events-Properties-Resources 'MFR.Objects.Operations.Events.Properties.Resources')
  - [Culture](#P-MFR-Objects-Operations-Events-Properties-Resources-Culture 'MFR.Objects.Operations.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Operations-Events-Properties-Resources-ResourceManager 'MFR.Objects.Operations.Events.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Operations-Events-DataOperationErrorEventArgs'></a>
## DataOperationErrorEventArgs `type`

##### Namespace

MFR.Objects.Operations.Events

##### Summary

Provides information for DataOperationError event handlers.

<a name='M-MFR-Objects-Operations-Events-DataOperationErrorEventArgs-#ctor-System-Exception-'></a>
### #ctor(exception) `constructor`

##### Summary

Constructs a new instance of [DataOperationErrorEventArgs](#T-MFR-Objects-Operations-Events-DataOperationErrorEventArgs 'MFR.Objects.Operations.Events.DataOperationErrorEventArgs')
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

<a name='T-MFR-Objects-Operations-Events-DataOperationErrorEventHandler'></a>
## DataOperationErrorEventHandler `type`

##### Namespace

MFR.Objects.Operations.Events

##### Summary

Represents a handler for a DataOperationError event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Objects.Operations.Events.DataOperationErrorEventHandler](#T-T-MFR-Objects-Operations-Events-DataOperationErrorEventHandler 'T:MFR.Objects.Operations.Events.DataOperationErrorEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle
the DataOperationError event.

<a name='T-MFR-Objects-Operations-Events-DataOperationEventArgs'></a>
## DataOperationEventArgs `type`

##### Namespace

MFR.Objects.Operations.Events

##### Summary

Provides information for DataOperation event handlers.

<a name='P-MFR-Objects-Operations-Events-DataOperationEventArgs-Message'></a>
### Message `property`

##### Summary

Gets a string containing a message to be displayed to the user
during a data update operation.

<a name='T-MFR-Objects-Operations-Events-DataOperationEventHandler'></a>
## DataOperationEventHandler `type`

##### Namespace

MFR.Objects.Operations.Events

##### Summary

Represents a handler for an DataOperation event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Objects.Operations.Events.DataOperationEventHandler](#T-T-MFR-Objects-Operations-Events-DataOperationEventHandler 'T:MFR.Objects.Operations.Events.DataOperationEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle
the DataOperation event.

<a name='T-MFR-Objects-Operations-Events-OperationCancelEventArgs'></a>
## OperationCancelEventArgs `type`

##### Namespace

MFR.Objects.Operations.Events

<a name='M-MFR-Objects-Operations-Events-OperationCancelEventArgs-#ctor-MFR-Objects-Operations-Constants-OperationType-'></a>
### #ctor(type) `constructor`

##### Summary

Constructs a new instance of [OperationEventArgs](#T-MFR-Objects-OperationEventArgs 'MFR.Objects.OperationEventArgs') and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Objects.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType') values that
specifies the operation being performed. |

<a name='P-MFR-Objects-Operations-Events-OperationCancelEventArgs-OperationType'></a>
### OperationType `property`

##### Summary

Gets the type of operation being performed.

<a name='T-MFR-Objects-Operations-Events-OperationEventArgs'></a>
## OperationEventArgs `type`

##### Namespace

MFR.Objects.Operations.Events

##### Summary

Provides methods and properties common to all event argument objects for
a particular operation type.

<a name='M-MFR-Objects-Operations-Events-OperationEventArgs-#ctor-MFR-Objects-Operations-Constants-OperationType-'></a>
### #ctor(operationType) `constructor`

##### Summary

Constructs a new instance of
[OperationEventArgs](#T-MFR-Objects-OperationEventArgs 'MFR.Objects.OperationEventArgs')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationType | [MFR.Objects.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
specifies the operation being performed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotSupportedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotSupportedException 'System.NotSupportedException') | Thrown if
[Unknown](#T-MFR-Objects-OperationType-Unknown 'MFR.Objects.OperationType.Unknown')
is passed
for the `operationType` parameter. |

<a name='P-MFR-Objects-Operations-Events-OperationEventArgs-OperationType'></a>
### OperationType `property`

##### Summary

Gets the type of operation being performed.

<a name='T-MFR-Objects-Operations-Events-OperationFinishedEventArgs'></a>
## OperationFinishedEventArgs `type`

##### Namespace

MFR.Objects.Operations.Events

##### Summary

Contains the data for a OperationFinished event.

<a name='M-MFR-Objects-Operations-Events-OperationFinishedEventArgs-#ctor-MFR-Objects-Operations-Constants-OperationType-'></a>
### #ctor(operationType) `constructor`

##### Summary

Constructs a new instance of [OperationEventArgs](#T-MFR-Objects-OperationEventArgs 'MFR.Objects.OperationEventArgs') and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationType | [MFR.Objects.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType') values that
specifies the operation being performed. |

<a name='T-MFR-Objects-Operations-Events-OperationFinishedEventHandler'></a>
## OperationFinishedEventHandler `type`

##### Namespace

MFR.Objects.Operations.Events

##### Summary

Represents a handler for an OperationFinished event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Objects.Operations.Events.OperationFinishedEventHandler](#T-T-MFR-Objects-Operations-Events-OperationFinishedEventHandler 'T:MFR.Objects.Operations.Events.OperationFinishedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle
the OperationFinished event.

<a name='T-MFR-Objects-Operations-Events-OperationStartedEventArgs'></a>
## OperationStartedEventArgs `type`

##### Namespace

MFR.Objects.Operations.Events

##### Summary

Defines the data that is passed by all events of type [OperationStartedEventHandler](#T-MFR-Objects-Operations-Events-OperationStartedEventHandler 'MFR.Objects.Operations.Events.OperationStartedEventHandler').

<a name='M-MFR-Objects-Operations-Events-OperationStartedEventArgs-#ctor-MFR-Objects-Operations-Constants-OperationType-'></a>
### #ctor(operationType) `constructor`

##### Summary

Constructs a new instance of [OperationEventArgs](#T-MFR-Objects-OperationEventArgs 'MFR.Objects.OperationEventArgs') and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationType | [MFR.Objects.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType') values that
specifies the operation being performed. |

<a name='T-MFR-Objects-Operations-Events-OperationStartedEventHandler'></a>
## OperationStartedEventHandler `type`

##### Namespace

MFR.Objects.Operations.Events

##### Summary

Defines the method signature for the handlers of the [](#E-MFR-Objects-FileRenamer-OperationStarted 'MFR.Objects.FileRenamer.OperationStarted') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Objects.Operations.Events.OperationStartedEventHandler](#T-T-MFR-Objects-Operations-Events-OperationStartedEventHandler 'T:MFR.Objects.Operations.Events.OperationStartedEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-MFR-Objects-Operations-Events-ProcessingOperationEventArgs'></a>
## ProcessingOperationEventArgs `type`

##### Namespace

MFR.Objects.Operations.Events

##### Summary

Defines the data that is passed by all events of type
[ProcessingOperationEventHandler](#T-MFR-Objects-Operations-Events-ProcessingOperationEventHandler 'MFR.Objects.Operations.Events.ProcessingOperationEventHandler').

<a name='M-MFR-Objects-Operations-Events-ProcessingOperationEventArgs-#ctor-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry,MFR-Objects-Operations-Constants-OperationType-'></a>
### #ctor(entry,type) `constructor`

##### Summary

Creates a new instance of
[ProcessingOperationEventArgs](#T-MFR-Objects-ProcessingOperationEventArgs 'MFR.Objects.ProcessingOperationEventArgs')
and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.Objects.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') interface. |
| type | [MFR.Objects.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
specifies the operation being performed. |

<a name='P-MFR-Objects-Operations-Events-ProcessingOperationEventArgs-Entry'></a>
### Entry `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') interface
that represents information about which file or folder is about to
be processed.

<a name='T-MFR-Objects-Operations-Events-ProcessingOperationEventHandler'></a>
## ProcessingOperationEventHandler `type`

##### Namespace

MFR.Objects.Operations.Events

##### Summary

Defines the method signature for the handlers of a ProcessingOperation event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Objects.Operations.Events.ProcessingOperationEventHandler](#T-T-MFR-Objects-Operations-Events-ProcessingOperationEventHandler 'T:MFR.Objects.Operations.Events.ProcessingOperationEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-MFR-Objects-Operations-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Operations.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Operations-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Operations-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
