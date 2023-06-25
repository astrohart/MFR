<a name='assembly'></a>
# MFR.Messages.Identifiers.Interfaces

## Contents

- [IMessageIdentifier](#T-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier 'MFR.Messages.Identifiers.Interfaces.IMessageIdentifier')
  - [MessageId](#P-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier-MessageId 'MFR.Messages.Identifiers.Interfaces.IMessageIdentifier.MessageId')
  - [Name](#P-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier-Name 'MFR.Messages.Identifiers.Interfaces.IMessageIdentifier.Name')
  - [IsZero()](#M-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier-IsZero 'MFR.Messages.Identifiers.Interfaces.IMessageIdentifier.IsZero')
  - [ToGuid()](#M-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier-ToGuid 'MFR.Messages.Identifiers.Interfaces.IMessageIdentifier.ToGuid')
- [Resources](#T-MFR-Messages-Identifiers-Interfaces-Properties-Resources 'MFR.Messages.Identifiers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Messages-Identifiers-Interfaces-Properties-Resources-Culture 'MFR.Messages.Identifiers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Messages-Identifiers-Interfaces-Properties-Resources-ResourceManager 'MFR.Messages.Identifiers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier'></a>
## IMessageIdentifier `type`

##### Namespace

MFR.Messages.Identifiers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a message ID object.

##### Remarks

These objects uniquely identify messages and also give them names.

<a name='P-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier-MessageId'></a>
### MessageId `property`

##### Summary

Gets or sets a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that uniquely identifies the
message.

<a name='P-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier-Name'></a>
### Name `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that names this message
identifier.

<a name='M-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier-IsZero'></a>
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

<a name='M-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier-ToGuid'></a>
### ToGuid() `method`

##### Summary

Expresses this object instance as a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that uniquely
identifies the message.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-MFR-Messages-Identifiers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Messages.Identifiers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Messages-Identifiers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Messages-Identifiers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
