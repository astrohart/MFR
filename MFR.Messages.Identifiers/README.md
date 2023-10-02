<a name='assembly'></a>
# MFR.Messages.Identifiers

## Contents

- [MessageIdentifier](#T-MFR-Messages-Identifiers-MessageIdentifier 'MFR.Messages.Identifiers.MessageIdentifier')
  - [MessageId](#P-MFR-Messages-Identifiers-MessageIdentifier-MessageId 'MFR.Messages.Identifiers.MessageIdentifier.MessageId')
  - [Name](#P-MFR-Messages-Identifiers-MessageIdentifier-Name 'MFR.Messages.Identifiers.MessageIdentifier.Name')
  - [IsZero()](#M-MFR-Messages-Identifiers-MessageIdentifier-IsZero 'MFR.Messages.Identifiers.MessageIdentifier.IsZero')
  - [ToGuid()](#M-MFR-Messages-Identifiers-MessageIdentifier-ToGuid 'MFR.Messages.Identifiers.MessageIdentifier.ToGuid')
  - [ToGuid(id)](#M-MFR-Messages-Identifiers-MessageIdentifier-ToGuid-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier- 'MFR.Messages.Identifiers.MessageIdentifier.ToGuid(MFR.Messages.Identifiers.Interfaces.IMessageIdentifier)')
  - [ToString()](#M-MFR-Messages-Identifiers-MessageIdentifier-ToString 'MFR.Messages.Identifiers.MessageIdentifier.ToString')
- [Resources](#T-MFR-Messages-Identifiers-Properties-Resources 'MFR.Messages.Identifiers.Properties.Resources')
  - [Culture](#P-MFR-Messages-Identifiers-Properties-Resources-Culture 'MFR.Messages.Identifiers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Messages-Identifiers-Properties-Resources-ResourceManager 'MFR.Messages.Identifiers.Properties.Resources.ResourceManager')

<a name='T-MFR-Messages-Identifiers-MessageIdentifier'></a>
## MessageIdentifier `type`

##### Namespace

MFR.Messages.Identifiers

##### Summary

Defines the events, methods, properties, and behaviors for all message
identifier objects.

<a name='P-MFR-Messages-Identifiers-MessageIdentifier-MessageId'></a>
### MessageId `property`

##### Summary

Gets or sets a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that uniquely identifies the
message.

<a name='P-MFR-Messages-Identifiers-MessageIdentifier-Name'></a>
### Name `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that names this message
identifier.

<a name='M-MFR-Messages-Identifiers-MessageIdentifier-IsZero'></a>
### IsZero() `method`

##### Summary

Determines whether the value of the
[OperationEngineMessageId](#P-MFR-Engines-Constants-OperationEngineMessageId-OperationEngineMessageId 'MFR.Engines.Constants.OperationEngineMessageId.OperationEngineMessageId')
property is set
to the Zero GUID.

##### Returns

`true` if the value of the
[OperationEngineMessageId](#P-MFR-Engines-Constants-OperationEngineMessageId-OperationEngineMessageId 'MFR.Engines.Constants.OperationEngineMessageId.OperationEngineMessageId')
property is set
to the Zero GUID; `false` otherwise.

##### Parameters

This method has no parameters.

<a name='M-MFR-Messages-Identifiers-MessageIdentifier-ToGuid'></a>
### ToGuid() `method`

##### Summary

Expresses this object instance as a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that uniquely
identifies the message.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-MFR-Messages-Identifiers-MessageIdentifier-ToGuid-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier-'></a>
### ToGuid(id) `method`

##### Summary

Expresses an instance of an object that implements the
[IMessageIdentifier](#T-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier 'MFR.Messages.Identifiers.Interfaces.IMessageIdentifier')
interface as a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [MFR.Messages.Identifiers.Interfaces.IMessageIdentifier](#T-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier 'MFR.Messages.Identifiers.Interfaces.IMessageIdentifier') | (Required.) Reference to an instance of an object that implements the
[IMessageIdentifier](#T-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier 'MFR.Messages.Identifiers.Interfaces.IMessageIdentifier')
interface. |

<a name='M-MFR-Messages-Identifiers-MessageIdentifier-ToString'></a>
### ToString() `method`

##### Summary

Returns a string that represents the current object.

##### Returns

A string that represents the current object.

##### Parameters

This method has no parameters.

<a name='T-MFR-Messages-Identifiers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Messages.Identifiers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Messages-Identifiers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Messages-Identifiers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
