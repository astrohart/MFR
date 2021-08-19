<a name='assembly'></a>
# MFR.Objects.Engines.Replacement.Factories

## Contents

- [GetTextReplacementEngine](#T-MFR-Objects-Engines-Replacement-Factories-GetTextReplacementEngine 'MFR.Objects.Engines.Replacement.Factories.GetTextReplacementEngine')
  - [For(type)](#M-MFR-Objects-Engines-Replacement-Factories-GetTextReplacementEngine-For-MFR-Objects-Operations-Constants-OperationType- 'MFR.Objects.Engines.Replacement.Factories.GetTextReplacementEngine.For(MFR.Objects.Operations.Constants.OperationType)')
- [Resources](#T-MFR-Objects-Engines-Replacement-Factories-Properties-Resources 'MFR.Objects.Engines.Replacement.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Engines-Replacement-Factories-Properties-Resources-Culture 'MFR.Objects.Engines.Replacement.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Engines-Replacement-Factories-Properties-Resources-ResourceManager 'MFR.Objects.Engines.Replacement.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Engines-Replacement-Factories-GetTextReplacementEngine'></a>
## GetTextReplacementEngine `type`

##### Namespace

MFR.Objects.Engines.Replacement.Factories

##### Summary

Creates instances of objects that implement the
[ITextReplacementEngine](#T-MFR-Objects-ITextReplacementEngine 'MFR.Objects.ITextReplacementEngine')
interface.

<a name='M-MFR-Objects-Engines-Replacement-Factories-GetTextReplacementEngine-For-MFR-Objects-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Gets an instance of the object that implements the
[ITextReplacementEngine](#T-MFR-Objects-ITextReplacementEngine 'MFR.Objects.ITextReplacementEngine')
interface
corresponding to the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
specified.

##### Returns

Reference to the instance of the object that implements the
[ITextReplacementEngine](#T-MFR-Objects-ITextReplacementEngine 'MFR.Objects.ITextReplacementEngine')
interface
corresponding to the operation of the `type`
specified, or `null` if no object supports the specified
`type` of operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Objects.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
specifies which operation is being performed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the `type` parameter specifies an
operation modality that is not supported. |

<a name='T-MFR-Objects-Engines-Replacement-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Engines.Replacement.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Engines-Replacement-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Engines-Replacement-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
