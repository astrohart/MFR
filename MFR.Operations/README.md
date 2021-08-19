<a name='assembly'></a>
# MFR.Objects.Operations

## Contents

- [OperationTypeSpecificObjectBase](#T-MFR-Objects-Operations-OperationTypeSpecificObjectBase 'MFR.Objects.Operations.OperationTypeSpecificObjectBase')
  - [#ctor()](#M-MFR-Objects-Operations-OperationTypeSpecificObjectBase-#ctor 'MFR.Objects.Operations.OperationTypeSpecificObjectBase.#ctor')
  - [OperationType](#P-MFR-Objects-Operations-OperationTypeSpecificObjectBase-OperationType 'MFR.Objects.Operations.OperationTypeSpecificObjectBase.OperationType')
  - [AndOperationType(type)](#M-MFR-Objects-Operations-OperationTypeSpecificObjectBase-AndOperationType-MFR-Objects-Operations-Constants-OperationType- 'MFR.Objects.Operations.OperationTypeSpecificObjectBase.AndOperationType(MFR.Objects.Operations.Constants.OperationType)')
- [Resources](#T-MFR-Objects-Operations-Properties-Resources 'MFR.Objects.Operations.Properties.Resources')
  - [Culture](#P-MFR-Objects-Operations-Properties-Resources-Culture 'MFR.Objects.Operations.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Operations-Properties-Resources-ResourceManager 'MFR.Objects.Operations.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Operations-OperationTypeSpecificObjectBase'></a>
## OperationTypeSpecificObjectBase `type`

##### Namespace

MFR.Objects.Operations

##### Summary

Provides functionality that is shared among all operation-type-specific
objects.

<a name='M-MFR-Objects-Operations-OperationTypeSpecificObjectBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [OperationSpecificObjectBase](#T-MFR-Objects-OperationSpecificObjectBase 'MFR.Objects.OperationSpecificObjectBase') and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Operations-OperationTypeSpecificObjectBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Operations-OperationTypeSpecificObjectBase-AndOperationType-MFR-Objects-Operations-Constants-OperationType-'></a>
### AndOperationType(type) `method`

##### Summary

Initializes the
[OperationType](#P-MFR-Objects-IOperationSpecificObject-OperationType 'MFR.Objects.IOperationSpecificObject.OperationType')
property with the specific
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
value that
corresponds to the type of operation being performed.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Objects.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
specifies the type of operation being performed. |

##### Remarks

This method is optional. If the objects in the bridge hierarchy
implement the
[OperationType](#P-MFR-Objects-IOperationSpecificObject-OperationType 'MFR.Objects.IOperationSpecificObject.OperationType')
property themselves, then this method is not necessary to be called.



However, it is made `virtual` so that child implementations may
override its functionality.

<a name='T-MFR-Objects-Operations-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Operations.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Operations-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Operations-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
