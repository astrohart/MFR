<a name='assembly'></a>
# MFR.Objects.TextValues.Retrievers.Factories

## Contents

- [GetTextValueRetriever](#T-MFR-Objects-TextValues-Retrievers-Factories-GetTextValueRetriever 'MFR.Objects.TextValues.Retrievers.Factories.GetTextValueRetriever')
  - [For(type)](#M-MFR-Objects-TextValues-Retrievers-Factories-GetTextValueRetriever-For-MFR-Objects-Operations-Constants-OperationType- 'MFR.Objects.TextValues.Retrievers.Factories.GetTextValueRetriever.For(MFR.Objects.Operations.Constants.OperationType)')
- [Resources](#T-MFR-Objects-TextValues-Retrievers-Factories-Properties-Resources 'MFR.Objects.TextValues.Retrievers.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-TextValues-Retrievers-Factories-Properties-Resources-Culture 'MFR.Objects.TextValues.Retrievers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-TextValues-Retrievers-Factories-Properties-Resources-ResourceManager 'MFR.Objects.TextValues.Retrievers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-TextValues-Retrievers-Factories-GetTextValueRetriever'></a>
## GetTextValueRetriever `type`

##### Namespace

MFR.Objects.TextValues.Retrievers.Factories

##### Summary

Creates instances of objects that implement the
[ITextValueRetriever](#T-MFR-Objects-FileSystem-Retrievers-ITextValueRetriever 'MFR.Objects.FileSystem.Retrievers.ITextValueRetriever')
interface.

<a name='M-MFR-Objects-TextValues-Retrievers-Factories-GetTextValueRetriever-For-MFR-Objects-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates a new instance of an object that implements the
[ITextValueRetriever](#T-MFR-Objects-FileSystem-Retrievers-Interfaces-ITextValueRetriever 'MFR.Objects.FileSystem.Retrievers.Interfaces.ITextValueRetriever')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ITextValueRetriever](#T-MFR-Objects-FileSystem-Retrievers-Interfaces-ITextValueRetriever 'MFR.Objects.FileSystem.Retrievers.Interfaces.ITextValueRetriever')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Objects.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType') | One of the
[OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType')
values
that specifies which operation is currently being performed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the operation type specified by the
`type`
parameter is not one of the supported values. |

<a name='T-MFR-Objects-TextValues-Retrievers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.TextValues.Retrievers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-TextValues-Retrievers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-TextValues-Retrievers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
