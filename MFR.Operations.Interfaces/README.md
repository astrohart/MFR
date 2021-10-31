<a name='assembly'></a>
# MFR.Operations.Interfaces

## Contents

- [IFixedOperationTypeSpecificObject](#T-MFR-Objects-Operations-Interfaces-IFixedOperationTypeSpecificObject 'MFR.Operations.Interfaces.IFixedOperationTypeSpecificObject')
  - [OperationType](#P-MFR-Objects-Operations-Interfaces-IFixedOperationTypeSpecificObject-OperationType 'MFR.Operations.Interfaces.IFixedOperationTypeSpecificObject.OperationType')
- [IOperationTypeSpecificObject](#T-MFR-Objects-Operations-Interfaces-IOperationTypeSpecificObject 'MFR.Operations.Interfaces.IOperationTypeSpecificObject')
  - [AndOperationType(type)](#M-MFR-Objects-Operations-Interfaces-IOperationTypeSpecificObject-AndOperationType-MFR-Objects-Operations-Constants-OperationType- 'MFR.Operations.Interfaces.IOperationTypeSpecificObject.AndOperationType(MFR.Operations.Constants.OperationType)')
- [Resources](#T-MFR-Objects-Operations-Interfaces-Properties-Resources 'MFR.Operations.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Operations-Interfaces-Properties-Resources-Culture 'MFR.Operations.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Operations-Interfaces-Properties-Resources-ResourceManager 'MFR.Operations.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Operations-Interfaces-IFixedOperationTypeSpecificObject'></a>
## IFixedOperationTypeSpecificObject `type`

##### Namespace

MFR.Operations.Interfaces

##### Summary

Defines the public-exposed methods and properties of an object that is
tagged with one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType')
values.

##### Remarks

This interface represents an object for which the operation type is immutable.

<a name='P-MFR-Objects-Operations-Interfaces-IFixedOperationTypeSpecificObject-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType')
values that
corresponds to the type of operation being performed.

<a name='T-MFR-Objects-Operations-Interfaces-IOperationTypeSpecificObject'></a>
## IOperationTypeSpecificObject `type`

##### Namespace

MFR.Operations.Interfaces

##### Summary

Defines the public-exposed methods and properties of an object whose
behavior varies depending on the type of operation being performed.

<a name='M-MFR-Objects-Operations-Interfaces-IOperationTypeSpecificObject-AndOperationType-MFR-Objects-Operations-Constants-OperationType-'></a>
### AndOperationType(type) `method`

##### Summary

Initializes the
[OperationType](#P-MFR-Objects-IOperationSpecificObject-OperationType 'MFR.IOperationSpecificObject.OperationType')
property with the specific
[OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType')
value that
corresponds to the type of operation being performed.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType')
values that
specifies the type of operation being performed. |

<a name='T-MFR-Objects-Operations-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Operations.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Operations-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Operations-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
