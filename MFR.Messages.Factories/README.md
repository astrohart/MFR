<a name='assembly'></a>
# MFR.Messages.Factories

## Contents

- [GetMessage](#T-MFR-Objects-Messages-Factories-GetMessage 'MFR.Messages.Factories.GetMessage')
  - [For()](#M-MFR-Objects-Messages-Factories-GetMessage-For-MFR-Objects-Messages-Constants-MessageType- 'MFR.Messages.Factories.GetMessage.For(MFR.Messages.Constants.MessageType)')
- [GetRequest](#T-MFR-Objects-Messages-Factories-GetRequest 'MFR.Messages.Factories.GetRequest')
  - [For\`\`1(type)](#M-MFR-Objects-Messages-Factories-GetRequest-For``1-MFR-Objects-Messages-Constants-MessageType- 'MFR.Messages.Factories.GetRequest.For``1(MFR.Messages.Constants.MessageType)')
- [Resources](#T-MFR-Objects-Messages-Factories-Properties-Resources 'MFR.Messages.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Messages-Factories-Properties-Resources-Culture 'MFR.Messages.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Messages-Factories-Properties-Resources-ResourceManager 'MFR.Messages.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Messages-Factories-GetMessage'></a>
## GetMessage `type`

##### Namespace

MFR.Messages.Factories

##### Summary

Creates instances of objects that implement the
[IMessage](#T-MFR-Objects-IMessage 'MFR.IMessage')
interface.

<a name='M-MFR-Objects-Messages-Factories-GetMessage-For-MFR-Objects-Messages-Constants-MessageType-'></a>
### For() `method`

##### Summary

Creates a new instance of an object that implements the
[IMessage](#T-MFR-Objects-IMessage 'MFR.IMessage')
interface and returns a
reference to it.

##### Parameters

This method has no parameters.

##### Remarks

The current implementation of this method throws [NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException').

<a name='T-MFR-Objects-Messages-Factories-GetRequest'></a>
## GetRequest `type`

##### Namespace

MFR.Messages.Factories

##### Summary

Creates instances of objects that implement the
[IRequest](#T-MFR-Objects-IRequest 'MFR.IRequest')
interface.

<a name='M-MFR-Objects-Messages-Factories-GetRequest-For``1-MFR-Objects-Messages-Constants-MessageType-'></a>
### For\`\`1(type) `method`

##### Summary

Creates a new instance of an object that implements the
[IRequest](#T-MFR-Objects-IRequest 'MFR.IRequest')
interface and returns a reference to
it.

##### Returns

Reference to an instance of an object that implements the
[IRequest](#T-MFR-Objects-Messages-Requests-Interfaces-IRequest 'MFR.Messages.Requests.Interfaces.IRequest')
interface that corresponds to the specified
[MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Messages.Constants.MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType') | (Required.) A
[MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType')
value that
indicates what request to execute. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if no request object is available that corresponds to the
[MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType') value
provided in the `type` parameter. |

##### Remarks

The current implementation of this method does nothing but throw
[NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException').

<a name='T-MFR-Objects-Messages-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Messages.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Messages-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Messages-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
