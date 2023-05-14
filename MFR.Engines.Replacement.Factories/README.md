<a name='assembly'></a>
# MFR.Engines.Replacement.Factories

## Contents

- [GetTextReplacementEngine](#T-MFR-Engines-Replacement-Factories-GetTextReplacementEngine 'MFR.Engines.Replacement.Factories.GetTextReplacementEngine')
  - [For(type)](#M-MFR-Engines-Replacement-Factories-GetTextReplacementEngine-For-MFR-Operations-Constants-OperationType- 'MFR.Engines.Replacement.Factories.GetTextReplacementEngine.For(MFR.Operations.Constants.OperationType)')
- [Resources](#T-MFR-Engines-Replacement-Factories-Properties-Resources 'MFR.Engines.Replacement.Factories.Properties.Resources')
  - [Culture](#P-MFR-Engines-Replacement-Factories-Properties-Resources-Culture 'MFR.Engines.Replacement.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Replacement-Factories-Properties-Resources-ResourceManager 'MFR.Engines.Replacement.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Replacement-Factories-GetTextReplacementEngine'></a>
## GetTextReplacementEngine `type`

##### Namespace

MFR.Engines.Replacement.Factories

##### Summary

Creates instances of objects that implement the
[ITextReplacementEngine](#T-MFR-ITextReplacementEngine 'MFR.ITextReplacementEngine')
interface.

<a name='M-MFR-Engines-Replacement-Factories-GetTextReplacementEngine-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Gets an instance of the object that implements the
[ITextReplacementEngine](#T-MFR-ITextReplacementEngine 'MFR.ITextReplacementEngine')
interface
corresponding to the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
specified.

##### Returns

Reference to the instance of the object that implements the
[ITextReplacementEngine](#T-MFR-ITextReplacementEngine 'MFR.ITextReplacementEngine')
interface
corresponding to the operation of the `type`
specified, or `null` if no object supports the specified
`type` of operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
specifies which operation is being performed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the `type` parameter specifies an
operation modality that is not supported. |

<a name='T-MFR-Engines-Replacement-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Replacement.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Replacement-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Replacement-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
