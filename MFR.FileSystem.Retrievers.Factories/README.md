<a name='assembly'></a>
# MFR.Objects.FileSystem.Retrievers.Factories

## Contents

- [GetFileSystemEntryListRetriever](#T-MFR-Objects-FileSystem-Retrievers-Factories-GetFileSystemEntryListRetriever 'MFR.Objects.FileSystem.Retrievers.Factories.GetFileSystemEntryListRetriever')
  - [For(type)](#M-MFR-Objects-FileSystem-Retrievers-Factories-GetFileSystemEntryListRetriever-For-MFR-Objects-Operations-Constants-OperationType- 'MFR.Objects.FileSystem.Retrievers.Factories.GetFileSystemEntryListRetriever.For(MFR.Objects.Operations.Constants.OperationType)')
- [Resources](#T-MFR-Objects-FileSystem-Retrievers-Factories-Properties-Resources 'MFR.Objects.FileSystem.Retrievers.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-FileSystem-Retrievers-Factories-Properties-Resources-Culture 'MFR.Objects.FileSystem.Retrievers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-FileSystem-Retrievers-Factories-Properties-Resources-ResourceManager 'MFR.Objects.FileSystem.Retrievers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-FileSystem-Retrievers-Factories-GetFileSystemEntryListRetriever'></a>
## GetFileSystemEntryListRetriever `type`

##### Namespace

MFR.Objects.FileSystem.Retrievers.Factories

##### Summary

Creates instances of objects that implement the
[IFileSystemEntryListRetriever](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntryListRetriever 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntryListRetriever')
interface.

##### Remarks

These objects enumerate objects on the file system according to search
criteria specified by the user.

<a name='M-MFR-Objects-FileSystem-Retrievers-Factories-GetFileSystemEntryListRetriever-For-MFR-Objects-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates a new instance of an object that implements the
[IFileSystemEntryListRetriever](#T-MFR-Objects-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.Objects.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IFileSystemEntryListRetriever](#T-MFR-Objects-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.Objects.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface that corresponds to the specified `type`
of operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Objects.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType') | (Required.) A
[OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType')
value that
corresponds to the type of operation currently being performed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if there is no object that implements the
[IFileSystemEntryListRetriever](#T-MFR-Objects-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.Objects.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface available that corresponds to the specified operation
`type`. |

<a name='T-MFR-Objects-FileSystem-Retrievers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.FileSystem.Retrievers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-FileSystem-Retrievers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-FileSystem-Retrievers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.