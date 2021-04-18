<a name='assembly'></a>
# MFR.Objects.Events.Common

## Contents

- [ExceptionRaisedEventArgs](#T-MFR-Objects-Events-Common-ExceptionRaisedEventArgs 'MFR.Objects.Events.Common.ExceptionRaisedEventArgs')
  - [#ctor(exception)](#M-MFR-Objects-Events-Common-ExceptionRaisedEventArgs-#ctor-System-Exception- 'MFR.Objects.Events.Common.ExceptionRaisedEventArgs.#ctor(System.Exception)')
  - [Exception](#P-MFR-Objects-Events-Common-ExceptionRaisedEventArgs-Exception 'MFR.Objects.Events.Common.ExceptionRaisedEventArgs.Exception')
- [ExceptionRaisedEventHandler](#T-MFR-Objects-Events-Common-ExceptionRaisedEventHandler 'MFR.Objects.Events.Common.ExceptionRaisedEventHandler')
- [Resources](#T-MFR-Objects-Events-Common-Properties-Resources 'MFR.Objects.Events.Common.Properties.Resources')
  - [Culture](#P-MFR-Objects-Events-Common-Properties-Resources-Culture 'MFR.Objects.Events.Common.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Events-Common-Properties-Resources-ResourceManager 'MFR.Objects.Events.Common.Properties.Resources.ResourceManager')
- [StatusUpdateEventArgs](#T-MFR-Objects-Events-Common-StatusUpdateEventArgs 'MFR.Objects.Events.Common.StatusUpdateEventArgs')
  - [#ctor(text)](#M-MFR-Objects-Events-Common-StatusUpdateEventArgs-#ctor-System-String- 'MFR.Objects.Events.Common.StatusUpdateEventArgs.#ctor(System.String)')
  - [Text](#P-MFR-Objects-Events-Common-StatusUpdateEventArgs-Text 'MFR.Objects.Events.Common.StatusUpdateEventArgs.Text')
- [StatusUpdateEventHandler](#T-MFR-Objects-Events-Common-StatusUpdateEventHandler 'MFR.Objects.Events.Common.StatusUpdateEventHandler')

<a name='T-MFR-Objects-Events-Common-ExceptionRaisedEventArgs'></a>
## ExceptionRaisedEventArgs `type`

##### Namespace

MFR.Objects.Events.Common

##### Summary

Defines the data that is passed by all events of type
[ExceptionRaisedEventHandler](#T-MFR-Objects-Events-ExceptionRaisedEventHandler 'MFR.Objects.Events.ExceptionRaisedEventHandler').

<a name='M-MFR-Objects-Events-Common-ExceptionRaisedEventArgs-#ctor-System-Exception-'></a>
### #ctor(exception) `constructor`

##### Summary

Constructs a new instance of
[ExceptionRaisedEventArgs](#T-MFR-Objects-Events-Common-ExceptionRaisedEventArgs 'MFR.Objects.Events.Common.ExceptionRaisedEventArgs')
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

<a name='P-MFR-Objects-Events-Common-ExceptionRaisedEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a reference to the [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') instance
that describes the error that occurred.

<a name='T-MFR-Objects-Events-Common-ExceptionRaisedEventHandler'></a>
## ExceptionRaisedEventHandler `type`

##### Namespace

MFR.Objects.Events.Common

##### Summary

Defines the method signature for the handlers of a(n) ExceptionRaised event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Objects.Events.Common.ExceptionRaisedEventHandler](#T-T-MFR-Objects-Events-Common-ExceptionRaisedEventHandler 'T:MFR.Objects.Events.Common.ExceptionRaisedEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-MFR-Objects-Events-Common-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Events.Common.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Events-Common-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Events-Common-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-Events-Common-StatusUpdateEventArgs'></a>
## StatusUpdateEventArgs `type`

##### Namespace

MFR.Objects.Events.Common

##### Summary

Defines the data that is passed by all events of type [StatusUpdateEventHandler](#T-MFR-Objects-Events-Common-StatusUpdateEventHandler 'MFR.Objects.Events.Common.StatusUpdateEventHandler').

<a name='M-MFR-Objects-Events-Common-StatusUpdateEventArgs-#ctor-System-String-'></a>
### #ctor(text) `constructor`

##### Summary

Constructs a new instance of [StatusUpdateEventArgs](#T-MFR-Objects-Events-Common-StatusUpdateEventArgs 'MFR.Objects.Events.Common.StatusUpdateEventArgs') and returns
a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the status message text that is meant
for display to the user. |

<a name='P-MFR-Objects-Events-Common-StatusUpdateEventArgs-Text'></a>
### Text `property`

##### Summary

Gets the textual status message that is meant for display to the user.

<a name='T-MFR-Objects-Events-Common-StatusUpdateEventHandler'></a>
## StatusUpdateEventHandler `type`

##### Namespace

MFR.Objects.Events.Common

##### Summary

Defines the method signature for the handlers of the [](#E-MFR-Objects-IFileRenamer-StatusUpdate 'MFR.Objects.IFileRenamer.StatusUpdate') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Objects.Events.Common.StatusUpdateEventHandler](#T-T-MFR-Objects-Events-Common-StatusUpdateEventHandler 'T:MFR.Objects.Events.Common.StatusUpdateEventHandler') | Reference to the instance of the object that raised the event. |
