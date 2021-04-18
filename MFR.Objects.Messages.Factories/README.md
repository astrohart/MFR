<a name='assembly'></a>
# MFR.Objects.Messages.Factories

## Contents

- [GetAction](#T-MFR-Objects-Messages-Factories-GetAction 'MFR.Objects.Messages.Factories.GetAction')
  - [For\`\`2(type)](#M-MFR-Objects-Messages-Factories-GetAction-For``2-MFR-Objects-Messages-Constants-MessageType- 'MFR.Objects.Messages.Factories.GetAction.For``2(MFR.Objects.Messages.Constants.MessageType)')
- [GetCommand](#T-MFR-Objects-Messages-Factories-GetCommand 'MFR.Objects.Messages.Factories.GetCommand')
  - [For\`\`1()](#M-MFR-Objects-Messages-Factories-GetCommand-For``1-MFR-Objects-Messages-Constants-MessageType- 'MFR.Objects.Messages.Factories.GetCommand.For``1(MFR.Objects.Messages.Constants.MessageType)')
- [GetMessage](#T-MFR-Objects-Messages-Factories-GetMessage 'MFR.Objects.Messages.Factories.GetMessage')
  - [For()](#M-MFR-Objects-Messages-Factories-GetMessage-For-MFR-Objects-Messages-Constants-MessageType- 'MFR.Objects.Messages.Factories.GetMessage.For(MFR.Objects.Messages.Constants.MessageType)')
- [GetRequest](#T-MFR-Objects-Messages-Factories-GetRequest 'MFR.Objects.Messages.Factories.GetRequest')
  - [For\`\`1(type)](#M-MFR-Objects-Messages-Factories-GetRequest-For``1-MFR-Objects-Messages-Constants-MessageType- 'MFR.Objects.Messages.Factories.GetRequest.For``1(MFR.Objects.Messages.Constants.MessageType)')
- [Resources](#T-MFR-Objects-Messages-Factories-Properties-Resources 'MFR.Objects.Messages.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Messages-Factories-Properties-Resources-Culture 'MFR.Objects.Messages.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Messages-Factories-Properties-Resources-ResourceManager 'MFR.Objects.Messages.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Messages-Factories-GetAction'></a>
## GetAction `type`

##### Namespace

MFR.Objects.Messages.Factories

##### Summary

Creates instances of objects that implement the
[IAction](#T-MFR-Objects-IAction 'MFR.Objects.IAction')
interface.

<a name='M-MFR-Objects-Messages-Factories-GetAction-For``2-MFR-Objects-Messages-Constants-MessageType-'></a>
### For\`\`2(type) `method`

##### Summary

Creates a new instance of an object that implements the
[IAction](#T-MFR-Objects-IAction 'MFR.Objects.IAction')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IAction](#T-MFR-Objects-Messages-Actions-Interfaces-IAction 'MFR.Objects.Messages.Actions.Interfaces.IAction')
interface
that corresponds to the specified
[MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Objects.Messages.Constants.MessageType').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Objects.Messages.Constants.MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Objects.Messages.Constants.MessageType') | (Required.) A
[MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Objects.Messages.Constants.MessageType')
value that
indicates what action to execute. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if no action is available that corresponds to the
[MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Objects.Messages.Constants.MessageType')
value provided
in the `type` parameter. |

<a name='T-MFR-Objects-Messages-Factories-GetCommand'></a>
## GetCommand `type`

##### Namespace

MFR.Objects.Messages.Factories

##### Summary

Creates instances of objects that implement the
[ICommand](#T-MFR-Objects-ICommand 'MFR.Objects.ICommand')
interface.

##### Remarks

In our vernacular, a `command` object is an object that performs an
operation that accepts input, but has no output.

<a name='M-MFR-Objects-Messages-Factories-GetCommand-For``1-MFR-Objects-Messages-Constants-MessageType-'></a>
### For\`\`1() `method`

##### Summary

Creates a new instance of an object that implements the
[ICommand](#T-MFR-Objects-ICommand 'MFR.Objects.ICommand')
interface and returns a reference to it.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Messages-Factories-GetMessage'></a>
## GetMessage `type`

##### Namespace

MFR.Objects.Messages.Factories

##### Summary

Creates instances of objects that implement the
[IMessage](#T-MFR-Objects-IMessage 'MFR.Objects.IMessage')
interface.

<a name='M-MFR-Objects-Messages-Factories-GetMessage-For-MFR-Objects-Messages-Constants-MessageType-'></a>
### For() `method`

##### Summary

Creates a new instance of an object that implements the
[IMessage](#T-MFR-Objects-IMessage 'MFR.Objects.IMessage')
interface and returns a
reference to it.

##### Parameters

This method has no parameters.

##### Remarks

The current implementation of this method throws [NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException').

<a name='T-MFR-Objects-Messages-Factories-GetRequest'></a>
## GetRequest `type`

##### Namespace

MFR.Objects.Messages.Factories

##### Summary

Creates instances of objects that implement the
[IRequest](#T-MFR-Objects-IRequest 'MFR.Objects.IRequest')
interface.

<a name='M-MFR-Objects-Messages-Factories-GetRequest-For``1-MFR-Objects-Messages-Constants-MessageType-'></a>
### For\`\`1(type) `method`

##### Summary

Creates a new instance of an object that implements the
[IRequest](#T-MFR-Objects-IRequest 'MFR.Objects.IRequest')
interface and returns a reference to
it.

##### Returns

Reference to an instance of an object that implements the
[IRequest](#T-MFR-Objects-Messages-Requests-Interfaces-IRequest 'MFR.Objects.Messages.Requests.Interfaces.IRequest')
interface that corresponds to the specified
[MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Objects.Messages.Constants.MessageType').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Objects.Messages.Constants.MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Objects.Messages.Constants.MessageType') | (Required.) A
[MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Objects.Messages.Constants.MessageType')
value that
indicates what request to execute. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if no request object is available that corresponds to the
[MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Objects.Messages.Constants.MessageType') value
provided in the `type` parameter. |

##### Remarks

The current implementation of this method does nothing but throw
[NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException').

<a name='T-MFR-Objects-Messages-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Messages.Factories.Properties

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
