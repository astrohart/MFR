<a name='assembly'></a>
# MFR.Objects.Messages.Constants

## Contents

- [ActionType](#T-MFR-Objects-Messages-Constants-ActionType 'MFR.Objects.Messages.Constants.ActionType')
  - [#ctor(messageId)](#M-MFR-Objects-Messages-Constants-ActionType-#ctor-System-Guid- 'MFR.Objects.Messages.Constants.ActionType.#ctor(System.Guid)')
- [CommandType](#T-MFR-Objects-Messages-Constants-CommandType 'MFR.Objects.Messages.Constants.CommandType')
  - [#ctor(messageId)](#M-MFR-Objects-Messages-Constants-CommandType-#ctor-System-Guid- 'MFR.Objects.Messages.Constants.CommandType.#ctor(System.Guid)')
- [MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Objects.Messages.Constants.MessageType')
  - [#ctor(messageId)](#M-MFR-Objects-Messages-Constants-MessageType-#ctor-System-Guid- 'MFR.Objects.Messages.Constants.MessageType.#ctor(System.Guid)')
  - [_messageId](#F-MFR-Objects-Messages-Constants-MessageType-_messageId 'MFR.Objects.Messages.Constants.MessageType._messageId')
- [Resources](#T-MFR-Objects-Messages-Constants-Properties-Resources 'MFR.Objects.Messages.Constants.Properties.Resources')
  - [Culture](#P-MFR-Objects-Messages-Constants-Properties-Resources-Culture 'MFR.Objects.Messages.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Messages-Constants-Properties-Resources-ResourceManager 'MFR.Objects.Messages.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Messages-Constants-ActionType'></a>
## ActionType `type`

##### Namespace

MFR.Objects.Messages.Constants

##### Summary

Base class for pseudo-enumerations of action types.

<a name='M-MFR-Objects-Messages-Constants-ActionType-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[ActionType](#T-MFR-Objects-Messages-Constants-ActionType 'MFR.Objects.Messages.Constants.ActionType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='T-MFR-Objects-Messages-Constants-CommandType'></a>
## CommandType `type`

##### Namespace

MFR.Objects.Messages.Constants

##### Summary

Base class for pseudo-enumerations of command types.

<a name='M-MFR-Objects-Messages-Constants-CommandType-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[CommandType](#T-MFR-Objects-Messages-Constants-CommandType 'MFR.Objects.Messages.Constants.CommandType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='T-MFR-Objects-Messages-Constants-MessageType'></a>
## MessageType `type`

##### Namespace

MFR.Objects.Messages.Constants

##### Summary

Base class for all message-type "enumeration" classes.

##### Remarks

This object provides services that are common to all message-type objects.

<a name='M-MFR-Objects-Messages-Constants-MessageType-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Objects.Messages.Constants.MessageType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-Objects-Messages-Constants-MessageType-_messageId'></a>
### _messageId `constants`

##### Summary

Reference to a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that is the unique ID of
the command referenced by this type.

<a name='T-MFR-Objects-Messages-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Messages.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Messages-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Messages-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
