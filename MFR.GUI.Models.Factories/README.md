<a name='assembly'></a>
# MFR.GUI.Models.Factories

## Contents

- [MakeNewOperationTypeInfo](#T-MFR-GUI-Models-Factories-MakeNewOperationTypeInfo 'MFR.GUI.Models.Factories.MakeNewOperationTypeInfo')
  - [AndSetEnabledFlag(self,enabled)](#M-MFR-GUI-Models-Factories-MakeNewOperationTypeInfo-AndSetEnabledFlag-MFR-GUI-Models-Interfaces-IOperationTypeInfo,System-Boolean- 'MFR.GUI.Models.Factories.MakeNewOperationTypeInfo.AndSetEnabledFlag(MFR.GUI.Models.Interfaces.IOperationTypeInfo,System.Boolean)')
  - [FromScratch()](#M-MFR-GUI-Models-Factories-MakeNewOperationTypeInfo-FromScratch 'MFR.GUI.Models.Factories.MakeNewOperationTypeInfo.FromScratch')
  - [HavingOperationType(self,type)](#M-MFR-GUI-Models-Factories-MakeNewOperationTypeInfo-HavingOperationType-MFR-GUI-Models-Interfaces-IOperationTypeInfo,MFR-Operations-Constants-OperationType- 'MFR.GUI.Models.Factories.MakeNewOperationTypeInfo.HavingOperationType(MFR.GUI.Models.Interfaces.IOperationTypeInfo,MFR.Operations.Constants.OperationType)')
- [Resources](#T-MFR-GUI-Models-Factories-Properties-Resources 'MFR.GUI.Models.Factories.Properties.Resources')
  - [Culture](#P-MFR-GUI-Models-Factories-Properties-Resources-Culture 'MFR.GUI.Models.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Models-Factories-Properties-Resources-ResourceManager 'MFR.GUI.Models.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Models-Factories-MakeNewOperationTypeInfo'></a>
## MakeNewOperationTypeInfo `type`

##### Namespace

MFR.GUI.Models.Factories

##### Summary

Creates new instances of objects that implement the
[IOperationTypeInfo](#T-MFR-GUI-Models-Interfaces-IOperationTypeInfo 'MFR.GUI.Models.Interfaces.IOperationTypeInfo') interface, and
returns references to them.

<a name='M-MFR-GUI-Models-Factories-MakeNewOperationTypeInfo-AndSetEnabledFlag-MFR-GUI-Models-Interfaces-IOperationTypeInfo,System-Boolean-'></a>
### AndSetEnabledFlag(self,enabled) `method`

##### Summary

Builder extension method that initializes the
[Enabled](#P-MFR-GUI-Models-Interfaces-IOperationTypeInfo-Enabled 'MFR.GUI.Models.Interfaces.IOperationTypeInfo.Enabled')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Models.Interfaces.IOperationTypeInfo](#T-MFR-GUI-Models-Interfaces-IOperationTypeInfo 'MFR.GUI.Models.Interfaces.IOperationTypeInfo') | (Required.) Reference to an instance of an object that implements
the
[IOperationTypeInfo](#T-MFR-GUI-Models-Interfaces-IOperationTypeInfo 'MFR.GUI.Models.Interfaces.IOperationTypeInfo')
interface. |
| enabled | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A value that indicates whether the user wants to perform the type
of operation that is specified by the value of the
[OperationType](#P-MFR-GUI-Models-Interfaces-IOperationTypeInfo-OperationType 'MFR.GUI.Models.Interfaces.IOperationTypeInfo.OperationType')
property. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-GUI-Models-Factories-MakeNewOperationTypeInfo-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IOperationTypeInfo](#T-MFR-GUI-Models-Interfaces-IOperationTypeInfo 'MFR.GUI.Models.Interfaces.IOperationTypeInfo') interface and
returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IOperationTypeInfo](#T-MFR-GUI-Models-Interfaces-IOperationTypeInfo 'MFR.GUI.Models.Interfaces.IOperationTypeInfo') interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Models-Factories-MakeNewOperationTypeInfo-HavingOperationType-MFR-GUI-Models-Interfaces-IOperationTypeInfo,MFR-Operations-Constants-OperationType-'></a>
### HavingOperationType(self,type) `method`

##### Summary

Builder extension method that initializes the
[PROPNAME](#P-MFR-GUI-Models-Interfaces-IOperationTypeInfo-PROPNAME 'MFR.GUI.Models.Interfaces.IOperationTypeInfo.PROPNAME')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Models.Interfaces.IOperationTypeInfo](#T-MFR-GUI-Models-Interfaces-IOperationTypeInfo 'MFR.GUI.Models.Interfaces.IOperationTypeInfo') | (Required.) Reference to an instance of an object that implements
the
[IOperationTypeInfo](#T-MFR-GUI-Models-Interfaces-IOperationTypeInfo 'MFR.GUI.Models.Interfaces.IOperationTypeInfo')
interface. |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) An [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') value
that corresponds to the type of operation to be performed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='T-MFR-GUI-Models-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Models.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Models-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Models-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
