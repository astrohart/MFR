<a name='assembly'></a>
# MFR.Messages.Constants

## Contents

- [ActionType](#T-MFR-Messages-Constants-ActionType 'MFR.Messages.Constants.ActionType')
  - [#ctor(messageId)](#M-MFR-Messages-Constants-ActionType-#ctor-System-Guid- 'MFR.Messages.Constants.ActionType.#ctor(System.Guid)')
- [CommandType](#T-MFR-Messages-Constants-CommandType 'MFR.Messages.Constants.CommandType')
  - [#ctor(messageId)](#M-MFR-Messages-Constants-CommandType-#ctor-System-Guid- 'MFR.Messages.Constants.CommandType.#ctor(System.Guid)')
- [MessageType](#T-MFR-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType')
  - [#ctor(messageId)](#M-MFR-Messages-Constants-MessageType-#ctor-System-Guid- 'MFR.Messages.Constants.MessageType.#ctor(System.Guid)')
  - [_messageId](#F-MFR-Messages-Constants-MessageType-_messageId 'MFR.Messages.Constants.MessageType._messageId')
- [RequestType](#T-MFR-Messages-Constants-RequestType 'MFR.Messages.Constants.RequestType')
  - [#ctor(messageId)](#M-MFR-Messages-Constants-RequestType-#ctor-System-Guid- 'MFR.Messages.Constants.RequestType.#ctor(System.Guid)')
- [Resources](#T-MFR-Messages-Constants-Properties-Resources 'MFR.Messages.Constants.Properties.Resources')
  - [Culture](#P-MFR-Messages-Constants-Properties-Resources-Culture 'MFR.Messages.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Messages-Constants-Properties-Resources-ResourceManager 'MFR.Messages.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Messages-Constants-ActionType'></a>
## ActionType `type`

##### Namespace

MFR.Messages.Constants

##### Summary

Base class for pseudo-enumerations of action types.

<a name='M-MFR-Messages-Constants-ActionType-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[ActionType](#T-MFR-Messages-Constants-ActionType 'MFR.Messages.Constants.ActionType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='T-MFR-Messages-Constants-CommandType'></a>
## CommandType `type`

##### Namespace

MFR.Messages.Constants

##### Summary

Base class for pseudo-enumerations of command types.

<a name='M-MFR-Messages-Constants-CommandType-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[CommandType](#T-MFR-Messages-Constants-CommandType 'MFR.Messages.Constants.CommandType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='T-MFR-Messages-Constants-MessageType'></a>
## MessageType `type`

##### Namespace

MFR.Messages.Constants

##### Summary

Base class for all message-type "enumeration" classes.

##### Remarks

This object provides services that are common to all message-type objects.

<a name='M-MFR-Messages-Constants-MessageType-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[MessageType](#T-MFR-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-Messages-Constants-MessageType-_messageId'></a>
### _messageId `constants`

##### Summary

Reference to a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that is the unique ID of
the command referenced by this type.

<a name='T-MFR-Messages-Constants-RequestType'></a>
## RequestType `type`

##### Namespace

MFR.Messages.Constants

##### Summary

Base class for pseudo-enumerations of request types.

<a name='M-MFR-Messages-Constants-RequestType-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[RequestType](#T-MFR-Messages-Constants-RequestType 'MFR.Messages.Constants.RequestType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='T-MFR-Messages-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Messages.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Messages-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Messages-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
