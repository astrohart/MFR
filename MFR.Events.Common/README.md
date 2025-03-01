<a name='assembly'></a>
# MFR.Events.Common

## Contents

- [ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs')
  - [#ctor(exception)](#M-MFR-Events-Common-ExceptionRaisedEventArgs-#ctor-System-Exception- 'MFR.Events.Common.ExceptionRaisedEventArgs.#ctor(System.Exception)')
  - [Exception](#P-MFR-Events-Common-ExceptionRaisedEventArgs-Exception 'MFR.Events.Common.ExceptionRaisedEventArgs.Exception')
- [ExceptionRaisedEventHandler](#T-MFR-Events-Common-ExceptionRaisedEventHandler 'MFR.Events.Common.ExceptionRaisedEventHandler')
- [Resources](#T-MFR-Events-Common-Properties-Resources 'MFR.Events.Common.Properties.Resources')
  - [Culture](#P-MFR-Events-Common-Properties-Resources-Culture 'MFR.Events.Common.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Events-Common-Properties-Resources-ResourceManager 'MFR.Events.Common.Properties.Resources.ResourceManager')
- [StatusUpdateEventArgs](#T-MFR-Events-Common-StatusUpdateEventArgs 'MFR.Events.Common.StatusUpdateEventArgs')
  - [#ctor(text,operationType,operationFinished)](#M-MFR-Events-Common-StatusUpdateEventArgs-#ctor-System-String,MFR-Operations-Constants-OperationType,System-Boolean- 'MFR.Events.Common.StatusUpdateEventArgs.#ctor(System.String,MFR.Operations.Constants.OperationType,System.Boolean)')
  - [OperationFinished](#P-MFR-Events-Common-StatusUpdateEventArgs-OperationFinished 'MFR.Events.Common.StatusUpdateEventArgs.OperationFinished')
  - [OperationType](#P-MFR-Events-Common-StatusUpdateEventArgs-OperationType 'MFR.Events.Common.StatusUpdateEventArgs.OperationType')
  - [Text](#P-MFR-Events-Common-StatusUpdateEventArgs-Text 'MFR.Events.Common.StatusUpdateEventArgs.Text')
- [StatusUpdateEventHandler](#T-MFR-Events-Common-StatusUpdateEventHandler 'MFR.Events.Common.StatusUpdateEventHandler')

<a name='T-MFR-Events-Common-ExceptionRaisedEventArgs'></a>
## ExceptionRaisedEventArgs `type`

##### Namespace

MFR.Events.Common

##### Summary

Defines the data that is passed by all events of type
[ExceptionRaisedEventHandler](#T-MFR-Events-ExceptionRaisedEventHandler 'MFR.Events.ExceptionRaisedEventHandler').

<a name='M-MFR-Events-Common-ExceptionRaisedEventArgs-#ctor-System-Exception-'></a>
### #ctor(exception) `constructor`

##### Summary

Constructs a new instance of
[ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs')
and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) Reference to an instance of
[Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception'),
or a child of it, that provides error details. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `exception`, is
passed a `null` reference for a value. |

<a name='P-MFR-Events-Common-ExceptionRaisedEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a reference to the [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') instance
that describes the error that occurred.

<a name='T-MFR-Events-Common-ExceptionRaisedEventHandler'></a>
## ExceptionRaisedEventHandler `type`

##### Namespace

MFR.Events.Common

##### Summary

Defines the method signature for the handlers of a(n) ExceptionRaised event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Events.Common.ExceptionRaisedEventHandler](#T-T-MFR-Events-Common-ExceptionRaisedEventHandler 'T:MFR.Events.Common.ExceptionRaisedEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-MFR-Events-Common-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Events.Common.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Events-Common-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Events-Common-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Events-Common-StatusUpdateEventArgs'></a>
## StatusUpdateEventArgs `type`

##### Namespace

MFR.Events.Common

##### Summary

Defines the data that is passed by all events of type
[StatusUpdateEventHandler](#T-MFR-Events-Common-StatusUpdateEventHandler 'MFR.Events.Common.StatusUpdateEventHandler').

<a name='M-MFR-Events-Common-StatusUpdateEventArgs-#ctor-System-String,MFR-Operations-Constants-OperationType,System-Boolean-'></a>
### #ctor(text,operationType,operationFinished) `constructor`

##### Summary

Constructs a new instance of
[StatusUpdateEventArgs](#T-MFR-Events-Common-StatusUpdateEventArgs 'MFR.Events.Common.StatusUpdateEventArgs')
and returns
a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the status message text that is meant
for display to the user. |
| operationType | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
enumeration values that describes the operation that is currently being
performed. |
| operationFinished | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value that indicates whether the
operation is finished.



Default value is `false`. |

<a name='P-MFR-Events-Common-StatusUpdateEventArgs-OperationFinished'></a>
### OperationFinished `property`

##### Summary

Gets a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value that indicates whether the
operation has completed.

<a name='P-MFR-Events-Common-StatusUpdateEventArgs-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
enumeration values that indicates what operation is currently being performed.

<a name='P-MFR-Events-Common-StatusUpdateEventArgs-Text'></a>
### Text `property`

##### Summary

Gets the textual status message that is meant for display to the user.

<a name='T-MFR-Events-Common-StatusUpdateEventHandler'></a>
## StatusUpdateEventHandler `type`

##### Namespace

MFR.Events.Common

##### Summary

Defines the method signature for the handlers of the [](#E-MFR-IFileRenamer-StatusUpdate 'MFR.IFileRenamer.StatusUpdate') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Events.Common.StatusUpdateEventHandler](#T-T-MFR-Events-Common-StatusUpdateEventHandler 'T:MFR.Events.Common.StatusUpdateEventHandler') | Reference to the instance of the object that raised the event. |
