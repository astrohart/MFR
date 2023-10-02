<a name='assembly'></a>
# MFR.Messages.Constants

## Contents

- [ActionType](#T-MFR-Messages-Constants-ActionType 'MFR.Messages.Constants.ActionType')
  - [#ctor(messageId)](#M-MFR-Messages-Constants-ActionType-#ctor-System-Guid- 'MFR.Messages.Constants.ActionType.#ctor(System.Guid)')
  - [#ctor(description,messageId)](#M-MFR-Messages-Constants-ActionType-#ctor-System-Guid,System-String- 'MFR.Messages.Constants.ActionType.#ctor(System.Guid,System.String)')
- [CommandType](#T-MFR-Messages-Constants-CommandType 'MFR.Messages.Constants.CommandType')
  - [#ctor(messageId)](#M-MFR-Messages-Constants-CommandType-#ctor-System-Guid- 'MFR.Messages.Constants.CommandType.#ctor(System.Guid)')
  - [#ctor(description,messageId)](#M-MFR-Messages-Constants-CommandType-#ctor-System-Guid,System-String- 'MFR.Messages.Constants.CommandType.#ctor(System.Guid,System.String)')
- [MessageType](#T-MFR-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType')
  - [#ctor(description,messageId)](#M-MFR-Messages-Constants-MessageType-#ctor-System-Guid,System-String- 'MFR.Messages.Constants.MessageType.#ctor(System.Guid,System.String)')
  - [#ctor(messageId)](#M-MFR-Messages-Constants-MessageType-#ctor-System-Guid- 'MFR.Messages.Constants.MessageType.#ctor(System.Guid)')
  - [Description](#P-MFR-Messages-Constants-MessageType-Description 'MFR.Messages.Constants.MessageType.Description')
  - [MessageId](#P-MFR-Messages-Constants-MessageType-MessageId 'MFR.Messages.Constants.MessageType.MessageId')
  - [ToString()](#M-MFR-Messages-Constants-MessageType-ToString 'MFR.Messages.Constants.MessageType.ToString')
- [RequestType](#T-MFR-Messages-Constants-RequestType 'MFR.Messages.Constants.RequestType')
  - [#ctor(messageId)](#M-MFR-Messages-Constants-RequestType-#ctor-System-Guid- 'MFR.Messages.Constants.RequestType.#ctor(System.Guid)')
  - [#ctor(description,messageId)](#M-MFR-Messages-Constants-RequestType-#ctor-System-Guid,System-String- 'MFR.Messages.Constants.RequestType.#ctor(System.Guid,System.String)')
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

<a name='M-MFR-Messages-Constants-ActionType-#ctor-System-Guid,System-String-'></a>
### #ctor(description,messageId) `constructor`

##### Summary

Constructs a new instance of
[ActionType](#T-MFR-Messages-Constants-ActionType 'MFR.Messages.Constants.ActionType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a user-friendly
descriptive name for this message type. |
| messageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='T-MFR-Messages-Constants-CommandType'></a>
## CommandType `type`

##### Namespace

MFR.Messages.Constants

##### Summary

Base class for pseudo-enumerations of command types.

##### Remarks

Commands are a special sub-category of messages.  Commands merely carry out an
action; they do not return data to the sender of the message.

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

<a name='M-MFR-Messages-Constants-CommandType-#ctor-System-Guid,System-String-'></a>
### #ctor(description,messageId) `constructor`

##### Summary

Constructs a new instance of
[CommandType](#T-MFR-Messages-Constants-CommandType 'MFR.Messages.Constants.CommandType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a user-friendly
descriptive name for this message type. |
| messageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='T-MFR-Messages-Constants-MessageType'></a>
## MessageType `type`

##### Namespace

MFR.Messages.Constants

##### Summary

Base class for all message-type "enumeration" classes.

##### Remarks

This object provides services that are common to all message-type objects.

<a name='M-MFR-Messages-Constants-MessageType-#ctor-System-Guid,System-String-'></a>
### #ctor(description,messageId) `constructor`

##### Summary

Constructs a new instance of
[MessageType](#T-MFR-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a user-friendly
descriptive name for this message type. |
| messageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

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

<a name='P-MFR-Messages-Constants-MessageType-Description'></a>
### Description `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly description
of this message type.

<a name='P-MFR-Messages-Constants-MessageType-MessageId'></a>
### MessageId `property`

##### Summary

Reference to a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that is the unique ID of
the command referenced by this type.

<a name='M-MFR-Messages-Constants-MessageType-ToString'></a>
### ToString() `method`

##### Summary

Returns a string that represents the current object.

##### Returns

A string that represents the current object.

##### Parameters

This method has no parameters.

<a name='T-MFR-Messages-Constants-RequestType'></a>
## RequestType `type`

##### Namespace

MFR.Messages.Constants

##### Summary

Base class for pseudo-enumerations of request types.

##### Remarks

A request is a sub-category of message where no data is passed to the message
handler's code by the message's sender, but the message handler is expected to
return data to the message's sender.

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

<a name='M-MFR-Messages-Constants-RequestType-#ctor-System-Guid,System-String-'></a>
### #ctor(description,messageId) `constructor`

##### Summary

Constructs a new instance of
[RequestType](#T-MFR-Messages-Constants-RequestType 'MFR.Messages.Constants.RequestType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a user-friendly
descriptive name for this message type. |
| messageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
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
