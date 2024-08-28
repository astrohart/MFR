<a name='assembly'></a>
# MFR.GUI.Models.Interfaces

## Contents

- [IErrantProcessInfo](#T-MFR-GUI-Models-Interfaces-IErrantProcessInfo 'MFR.GUI.Models.Interfaces.IErrantProcessInfo')
  - [FileName](#P-MFR-GUI-Models-Interfaces-IErrantProcessInfo-FileName 'MFR.GUI.Models.Interfaces.IErrantProcessInfo.FileName')
  - [Pathname](#P-MFR-GUI-Models-Interfaces-IErrantProcessInfo-Pathname 'MFR.GUI.Models.Interfaces.IErrantProcessInfo.Pathname')
- [IOperationTypeInfo](#T-MFR-GUI-Models-Interfaces-IOperationTypeInfo 'MFR.GUI.Models.Interfaces.IOperationTypeInfo')
  - [Enabled](#P-MFR-GUI-Models-Interfaces-IOperationTypeInfo-Enabled 'MFR.GUI.Models.Interfaces.IOperationTypeInfo.Enabled')
  - [Name](#P-MFR-GUI-Models-Interfaces-IOperationTypeInfo-Name 'MFR.GUI.Models.Interfaces.IOperationTypeInfo.Name')
  - [OperationType](#P-MFR-GUI-Models-Interfaces-IOperationTypeInfo-OperationType 'MFR.GUI.Models.Interfaces.IOperationTypeInfo.OperationType')
- [Resources](#T-MFR-GUI-Models-Interfaces-Properties-Resources 'MFR.GUI.Models.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-GUI-Models-Interfaces-Properties-Resources-Culture 'MFR.GUI.Models.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Models-Interfaces-Properties-Resources-ResourceManager 'MFR.GUI.Models.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Models-Interfaces-IErrantProcessInfo'></a>
## IErrantProcessInfo `type`

##### Namespace

MFR.GUI.Models.Interfaces

##### Summary

Defines the publicly-exposed events, methods and properties of an object that
encapsulates data about a process that is to be forcibly terminated prior to
the start of either the `Rename Files in Folder` or
`Rename Sub Folders` operations.

<a name='P-MFR-GUI-Models-Interfaces-IErrantProcessInfo-FileName'></a>
### FileName `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing just the filename only, of the
`.exe` file representing a process that is to be forcibly terminated.

<a name='P-MFR-GUI-Models-Interfaces-IErrantProcessInfo-Pathname'></a>
### Pathname `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a `.exe` file that is to be forcibly terminated.

<a name='T-MFR-GUI-Models-Interfaces-IOperationTypeInfo'></a>
## IOperationTypeInfo `type`

##### Namespace

MFR.GUI.Models.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a POCO that encodes
information about a type of operation.

<a name='P-MFR-GUI-Models-Interfaces-IOperationTypeInfo-Enabled'></a>
### Enabled `property`

##### Summary

Gets or sets a value that indicates whether the user wants to perform the
operation.

<a name='P-MFR-GUI-Models-Interfaces-IOperationTypeInfo-Name'></a>
### Name `property`

##### Summary

Gets or sets the name of the operation type.

<a name='P-MFR-GUI-Models-Interfaces-IOperationTypeInfo-OperationType'></a>
### OperationType `property`

##### Summary

Gets or sets the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') value
that corresponds to the type of operation to perform.

<a name='T-MFR-GUI-Models-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Models.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Models-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Models-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
