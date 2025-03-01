<a name='assembly'></a>
# MFR.Operations

## Contents

- [OperationTypeSpecificObjectBase](#T-MFR-Operations-OperationTypeSpecificObjectBase 'MFR.Operations.OperationTypeSpecificObjectBase')
  - [#ctor()](#M-MFR-Operations-OperationTypeSpecificObjectBase-#ctor 'MFR.Operations.OperationTypeSpecificObjectBase.#ctor')
  - [OperationType](#P-MFR-Operations-OperationTypeSpecificObjectBase-OperationType 'MFR.Operations.OperationTypeSpecificObjectBase.OperationType')
  - [AndOperationType(type)](#M-MFR-Operations-OperationTypeSpecificObjectBase-AndOperationType-MFR-Operations-Constants-OperationType- 'MFR.Operations.OperationTypeSpecificObjectBase.AndOperationType(MFR.Operations.Constants.OperationType)')
- [Resources](#T-MFR-Operations-Properties-Resources 'MFR.Operations.Properties.Resources')
  - [Culture](#P-MFR-Operations-Properties-Resources-Culture 'MFR.Operations.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Operations-Properties-Resources-ResourceManager 'MFR.Operations.Properties.Resources.ResourceManager')

<a name='T-MFR-Operations-OperationTypeSpecificObjectBase'></a>
## OperationTypeSpecificObjectBase `type`

##### Namespace

MFR.Operations

##### Summary

Provides functionality that is shared among all operation-type-specific
objects.

<a name='M-MFR-Operations-OperationTypeSpecificObjectBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [OperationSpecificObjectBase](#T-MFR-OperationSpecificObjectBase 'MFR.OperationSpecificObjectBase') and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-OperationTypeSpecificObjectBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Operations-OperationTypeSpecificObjectBase-AndOperationType-MFR-Operations-Constants-OperationType-'></a>
### AndOperationType(type) `method`

##### Summary

Initializes the
[OperationType](#P-MFR-IOperationSpecificObject-OperationType 'MFR.IOperationSpecificObject.OperationType')
property with the specific
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
value that
corresponds to the type of operation being performed.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
specifies the type of operation being performed. |

##### Remarks

This method is optional. If the objects in the bridge hierarchy
implement the
[OperationType](#P-MFR-IOperationSpecificObject-OperationType 'MFR.IOperationSpecificObject.OperationType')
property themselves, then this method is not necessary to be called.



However, it is made `virtual` so that child implementations may
override its functionality.

<a name='T-MFR-Operations-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Operations.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Operations-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Operations-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
