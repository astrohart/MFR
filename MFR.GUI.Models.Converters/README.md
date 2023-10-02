<a name='assembly'></a>
# MFR.GUI.Models.Converters

## Contents

- [ConvertOperationType](#T-MFR-GUI-Models-Converters-ConvertOperationType 'MFR.GUI.Models.Converters.ConvertOperationType')
  - [ToString(type)](#M-MFR-GUI-Models-Converters-ConvertOperationType-ToString-MFR-Operations-Constants-OperationType- 'MFR.GUI.Models.Converters.ConvertOperationType.ToString(MFR.Operations.Constants.OperationType)')
- [Resources](#T-MFR-GUI-Models-Converters-Properties-Resources 'MFR.GUI.Models.Converters.Properties.Resources')
  - [Culture](#P-MFR-GUI-Models-Converters-Properties-Resources-Culture 'MFR.GUI.Models.Converters.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Models-Converters-Properties-Resources-ResourceManager 'MFR.GUI.Models.Converters.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Models-Converters-ConvertOperationType'></a>
## ConvertOperationType `type`

##### Namespace

MFR.GUI.Models.Converters

##### Summary

Methods for converting [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values to descriptive strings.

<a name='M-MFR-GUI-Models-Converters-ConvertOperationType-ToString-MFR-Operations-Constants-OperationType-'></a>
### ToString(type) `method`

##### Summary

Converts the specified [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
value into a descriptive string, e.g., for display in a GUI.

##### Returns

If a supported [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
value is passed for the `type` parameter, then a descriptive
string corresponding to it is returned.



Otherwise, the return value is the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the supported
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values. |

<a name='T-MFR-GUI-Models-Converters-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Models.Converters.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Models-Converters-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Models-Converters-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
