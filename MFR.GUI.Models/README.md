<a name='assembly'></a>
# MFR.GUI.Models

## Contents

- [OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo')
  - [_operationType](#F-MFR-GUI-Models-OperationTypeInfo-_operationType 'MFR.GUI.Models.OperationTypeInfo._operationType')
  - [Enabled](#P-MFR-GUI-Models-OperationTypeInfo-Enabled 'MFR.GUI.Models.OperationTypeInfo.Enabled')
  - [Name](#P-MFR-GUI-Models-OperationTypeInfo-Name 'MFR.GUI.Models.OperationTypeInfo.Name')
  - [OperationType](#P-MFR-GUI-Models-OperationTypeInfo-OperationType 'MFR.GUI.Models.OperationTypeInfo.OperationType')
  - [ToString()](#M-MFR-GUI-Models-OperationTypeInfo-ToString 'MFR.GUI.Models.OperationTypeInfo.ToString')
- [Resources](#T-MFR-GUI-Models-Properties-Resources 'MFR.GUI.Models.Properties.Resources')
  - [Culture](#P-MFR-GUI-Models-Properties-Resources-Culture 'MFR.GUI.Models.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Models-Properties-Resources-ResourceManager 'MFR.GUI.Models.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Models-OperationTypeInfo'></a>
## OperationTypeInfo `type`

##### Namespace

MFR.GUI.Models

##### Summary

Information about a type of operation to perform to indicate whether the user
wants to perform the operation.



Provides a model for a particular item in the CheckedListBox in the Operations
tab of the GUI.

<a name='F-MFR-GUI-Models-OperationTypeInfo-_operationType'></a>
### _operationType `constants`

##### Summary

One of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values that
corresponds to the type of operation to perform.

<a name='P-MFR-GUI-Models-OperationTypeInfo-Enabled'></a>
### Enabled `property`

##### Summary

Gets or sets a value that indicates whether the user wants to perform the
operation.

<a name='P-MFR-GUI-Models-OperationTypeInfo-Name'></a>
### Name `property`

##### Summary

Gets or sets the name of the operation type.

<a name='P-MFR-GUI-Models-OperationTypeInfo-OperationType'></a>
### OperationType `property`

##### Summary

Gets or sets the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') value
that corresponds to the type of operation to perform.

<a name='M-MFR-GUI-Models-OperationTypeInfo-ToString'></a>
### ToString() `method`

##### Summary

Returns a string that represents the current object.

##### Returns

A string that represents the current object.

##### Parameters

This method has no parameters.

##### Remarks

This method returns the value of the
[Name](#P-MFR-GUI-Models-OperationTypeInfo-Name 'MFR.GUI.Models.OperationTypeInfo.Name') property.

<a name='T-MFR-GUI-Models-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Models.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Models-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Models-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
