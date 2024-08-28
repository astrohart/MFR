<a name='assembly'></a>
# MFR.GUI.Models.Factories

## Contents

- [MakeNewErrantProcessInfo](#T-MFR-GUI-Models-Factories-MakeNewErrantProcessInfo 'MFR.GUI.Models.Factories.MakeNewErrantProcessInfo')
  - [#cctor()](#M-MFR-GUI-Models-Factories-MakeNewErrantProcessInfo-#cctor 'MFR.GUI.Models.Factories.MakeNewErrantProcessInfo.#cctor')
  - [ForFile(pathname)](#M-MFR-GUI-Models-Factories-MakeNewErrantProcessInfo-ForFile-System-String- 'MFR.GUI.Models.Factories.MakeNewErrantProcessInfo.ForFile(System.String)')
- [MakeNewOperationTypeInfo](#T-MFR-GUI-Models-Factories-MakeNewOperationTypeInfo 'MFR.GUI.Models.Factories.MakeNewOperationTypeInfo')
  - [AndSetEnabledFlag(self,enabled)](#M-MFR-GUI-Models-Factories-MakeNewOperationTypeInfo-AndSetEnabledFlag-MFR-GUI-Models-Interfaces-IOperationTypeInfo,System-Boolean- 'MFR.GUI.Models.Factories.MakeNewOperationTypeInfo.AndSetEnabledFlag(MFR.GUI.Models.Interfaces.IOperationTypeInfo,System.Boolean)')
  - [FromScratch()](#M-MFR-GUI-Models-Factories-MakeNewOperationTypeInfo-FromScratch 'MFR.GUI.Models.Factories.MakeNewOperationTypeInfo.FromScratch')
  - [HavingOperationType(self,type)](#M-MFR-GUI-Models-Factories-MakeNewOperationTypeInfo-HavingOperationType-MFR-GUI-Models-Interfaces-IOperationTypeInfo,MFR-Operations-Constants-OperationType- 'MFR.GUI.Models.Factories.MakeNewOperationTypeInfo.HavingOperationType(MFR.GUI.Models.Interfaces.IOperationTypeInfo,MFR.Operations.Constants.OperationType)')
- [Resources](#T-MFR-GUI-Models-Factories-Properties-Resources 'MFR.GUI.Models.Factories.Properties.Resources')
  - [Culture](#P-MFR-GUI-Models-Factories-Properties-Resources-Culture 'MFR.GUI.Models.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Models-Factories-Properties-Resources-ResourceManager 'MFR.GUI.Models.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Models-Factories-MakeNewErrantProcessInfo'></a>
## MakeNewErrantProcessInfo `type`

##### Namespace

MFR.GUI.Models.Factories

##### Summary

Creates new instances of objects that implement the
[IErrantProcessInfo](#T-MFR-GUI-Models-Interfaces-IErrantProcessInfo 'MFR.GUI.Models.Interfaces.IErrantProcessInfo') interface, and
returns references to them.

<a name='M-MFR-GUI-Models-Factories-MakeNewErrantProcessInfo-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed
once only for the
[MakeNewErrantProcessInfo](#T-MFR-GUI-Models-Factories-MakeNewErrantProcessInfo 'MFR.GUI.Models.Factories.MakeNewErrantProcessInfo') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-MFR-GUI-Models-Factories-MakeNewErrantProcessInfo-ForFile-System-String-'></a>
### ForFile(pathname) `method`

##### Summary

Creates a new instance of an object that implements the
[IErrantProcessInfo](#T-MFR-GUI-Models-Interfaces-IErrantProcessInfo 'MFR.GUI.Models.Interfaces.IErrantProcessInfo') interface and
returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IErrantProcessInfo](#T-MFR-GUI-Models-Interfaces-IErrantProcessInfo 'MFR.GUI.Models.Interfaces.IErrantProcessInfo') interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file to create a new object for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`pathname`, is passed a blank or `null`
string for a value. |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the file having the specified `pathname` cannot be
located on the file system. |

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
