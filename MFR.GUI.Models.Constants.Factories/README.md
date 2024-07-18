<a name='assembly'></a>
# MFR.GUI.Models.Constants.Factories

## Contents

- [GetOperationName](#T-MFR-GUI-Models-Converters-Factories-GetOperationName 'MFR.GUI.Models.Constants.Factories.GetOperationName')
  - [For(type)](#M-MFR-GUI-Models-Converters-Factories-GetOperationName-For-MFR-Operations-Constants-OperationType- 'MFR.GUI.Models.Constants.Factories.GetOperationName.For(MFR.Operations.Constants.OperationType)')
- [Resources](#T-MFR-GUI-Models-Converters-Factories-Properties-Resources 'MFR.GUI.Models.Constants.Factories.Properties.Resources')
  - [Culture](#P-MFR-GUI-Models-Converters-Factories-Properties-Resources-Culture 'MFR.GUI.Models.Constants.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Models-Converters-Factories-Properties-Resources-ResourceManager 'MFR.GUI.Models.Constants.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Models-Converters-Factories-GetOperationName'></a>
## GetOperationName `type`

##### Namespace

MFR.GUI.Models.Constants.Factories

##### Summary

Exposes methods to obtain the names of operations.

<a name='M-MFR-GUI-Models-Converters-Factories-GetOperationName-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Given the specified operation `type`, retrieves a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the corresponding operation name.



This [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') should be used for displaying information
about the operation in UI/UX elements.

##### Returns

If the specified
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') enumeration value is
supported, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that corresponds to the operation
for use in displaying information about the operation in the user interface; if
the specified operation `type` is not supported, then the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value will be returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') enumeration values that
specifies the operation for which to obtain the corresponding user-interface
text. |

<a name='T-MFR-GUI-Models-Converters-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Models.Constants.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Models-Converters-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Models-Converters-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.s