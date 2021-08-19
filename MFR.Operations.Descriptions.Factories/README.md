<a name='assembly'></a>
# MFR.Objects.Operations.Descriptions.Factories

## Contents

- [GetOperationDescription](#T-MFR-Objects-Operations-Descriptions-Factories-GetOperationDescription 'MFR.Objects.Operations.Descriptions.Factories.GetOperationDescription')
  - [For(type)](#M-MFR-Objects-Operations-Descriptions-Factories-GetOperationDescription-For-MFR-Objects-Operations-Constants-OperationType- 'MFR.Objects.Operations.Descriptions.Factories.GetOperationDescription.For(MFR.Objects.Operations.Constants.OperationType)')
- [GetOperationStartedDescription](#T-MFR-Objects-Operations-Descriptions-Factories-GetOperationStartedDescription 'MFR.Objects.Operations.Descriptions.Factories.GetOperationStartedDescription')
  - [For(type)](#M-MFR-Objects-Operations-Descriptions-Factories-GetOperationStartedDescription-For-MFR-Objects-Operations-Constants-OperationType- 'MFR.Objects.Operations.Descriptions.Factories.GetOperationStartedDescription.For(MFR.Objects.Operations.Constants.OperationType)')
- [Resources](#T-MFR-Objects-Operations-Descriptions-Factories-Properties-Resources 'MFR.Objects.Operations.Descriptions.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Operations-Descriptions-Factories-Properties-Resources-Culture 'MFR.Objects.Operations.Descriptions.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Operations-Descriptions-Factories-Properties-Resources-ResourceManager 'MFR.Objects.Operations.Descriptions.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Operations-Descriptions-Factories-GetOperationDescription'></a>
## GetOperationDescription `type`

##### Namespace

MFR.Objects.Operations.Descriptions.Factories

##### Summary

Creates instances of objects that implement the
[IOperationDescription](#T-MFR-Objects-IOperationDescription 'MFR.Objects.IOperationDescription')
interface.

<a name='M-MFR-Objects-Operations-Descriptions-Factories-GetOperationDescription-For-MFR-Objects-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates a new instance of an object that implements the
[IOperationDescription](#T-MFR-Objects-IOperationDescription 'MFR.Objects.IOperationDescription')
interface,
corresponding to the specified operation `type`,
and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IOperationDescription](#T-MFR-Objects-IOperationDescription 'MFR.Objects.IOperationDescription')
interface that
corresponds to the specified operation `type`, or
`null` if no such object can be located.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Objects.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that specifies the operation type you want the descriptive
text for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the [OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType') value
specified in the `type` parameter does not have a
corresponding Operation Description object associated with it. |

<a name='T-MFR-Objects-Operations-Descriptions-Factories-GetOperationStartedDescription'></a>
## GetOperationStartedDescription `type`

##### Namespace

MFR.Objects.Operations.Descriptions.Factories

##### Summary

Creates instances of objects that implement the
[IOperationStartedDescription](#T-MFR-Objects-IOperationStartedDescription 'MFR.Objects.IOperationStartedDescription')
interface.

<a name='M-MFR-Objects-Operations-Descriptions-Factories-GetOperationStartedDescription-For-MFR-Objects-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates a new instance of an object that implements the
[IOperationStartedDescription](#T-MFR-Objects-IOperationStartedDescription 'MFR.Objects.IOperationStartedDescription')
interface,
corresponding to the specified operation `type` ,
and returns a reference to it.

##### Returns

String containing the text to describe the operation, or blank if a
handler corresponding to the specified
[OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType')
value can
be found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Objects.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that specifies the operation type you want the descriptive
text for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the [OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType') value
specified in the `type` parameter does not have a
corresponding Operation Started Description object associated with it. |

<a name='T-MFR-Objects-Operations-Descriptions-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Operations.Descriptions.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Operations-Descriptions-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Operations-Descriptions-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
