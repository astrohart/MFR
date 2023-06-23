<a name='assembly'></a>
# MFR.Messages.Identifiers.Factories

## Contents

- [MakeNewMessageIdentifier](#T-MFR-Messages-Identifiers-Factories-MakeNewMessageIdentifier 'MFR.Messages.Identifiers.Factories.MakeNewMessageIdentifier')
  - [AndName(self,name)](#M-MFR-Messages-Identifiers-Factories-MakeNewMessageIdentifier-AndName-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier,System-String- 'MFR.Messages.Identifiers.Factories.MakeNewMessageIdentifier.AndName(MFR.Messages.Identifiers.Interfaces.IMessageIdentifier,System.String)')
  - [ForNewMessageId()](#M-MFR-Messages-Identifiers-Factories-MakeNewMessageIdentifier-ForNewMessageId 'MFR.Messages.Identifiers.Factories.MakeNewMessageIdentifier.ForNewMessageId')
- [Resources](#T-MFR-Messages-Identifiers-Factories-Properties-Resources 'MFR.Messages.Identifiers.Factories.Properties.Resources')
  - [Culture](#P-MFR-Messages-Identifiers-Factories-Properties-Resources-Culture 'MFR.Messages.Identifiers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Messages-Identifiers-Factories-Properties-Resources-ResourceManager 'MFR.Messages.Identifiers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Messages-Identifiers-Factories-MakeNewMessageIdentifier'></a>
## MakeNewMessageIdentifier `type`

##### Namespace

MFR.Messages.Identifiers.Factories

##### Summary

Creates new instances of objects that implement the
[IMessageIdentifier](#T-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier 'MFR.Messages.Identifiers.Interfaces.IMessageIdentifier')
interface, and returns references to them.

<a name='M-MFR-Messages-Identifiers-Factories-MakeNewMessageIdentifier-AndName-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier,System-String-'></a>
### AndName(self,name) `method`

##### Summary

Builder extension method that initializes the
[Name](#P-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier-Name 'MFR.Messages.Identifiers.Interfaces.IMessageIdentifier.Name')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Messages.Identifiers.Interfaces.IMessageIdentifier](#T-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier 'MFR.Messages.Identifiers.Interfaces.IMessageIdentifier') | (Required.) Reference to an instance of an object that implements
the
[IMessageIdentifier](#T-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier 'MFR.Messages.Identifiers.Interfaces.IMessageIdentifier')
interface. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the name of the
message that is identified by this object. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Messages-Identifiers-Factories-MakeNewMessageIdentifier-ForNewMessageId'></a>
### ForNewMessageId() `method`

##### Summary

Creates a new instance of an object that implements the
[IMessageIdentifier](#T-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier 'MFR.Messages.Identifiers.Interfaces.IMessageIdentifier')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IMessageIdentifier](#T-MFR-Messages-Identifiers-Interfaces-IMessageIdentifier 'MFR.Messages.Identifiers.Interfaces.IMessageIdentifier')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-Messages-Identifiers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Messages.Identifiers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Messages-Identifiers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Messages-Identifiers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
