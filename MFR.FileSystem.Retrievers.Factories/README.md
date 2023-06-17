<a name='assembly'></a>
# MFR.FileSystem.Retrievers.Factories

## Contents

- [GetFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Factories-GetFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Factories.GetFileSystemEntryListRetriever')
  - [For(type)](#M-MFR-FileSystem-Retrievers-Factories-GetFileSystemEntryListRetriever-For-MFR-Operations-Constants-OperationType- 'MFR.FileSystem.Retrievers.Factories.GetFileSystemEntryListRetriever.For(MFR.Operations.Constants.OperationType)')
- [Resources](#T-MFR-FileSystem-Retrievers-Factories-Properties-Resources 'MFR.FileSystem.Retrievers.Factories.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Retrievers-Factories-Properties-Resources-Culture 'MFR.FileSystem.Retrievers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Retrievers-Factories-Properties-Resources-ResourceManager 'MFR.FileSystem.Retrievers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Retrievers-Factories-GetFileSystemEntryListRetriever'></a>
## GetFileSystemEntryListRetriever `type`

##### Namespace

MFR.FileSystem.Retrievers.Factories

##### Summary

Creates instances of objects that implement the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Interfaces.IFileSystemEntryListRetriever')
interface.

##### Remarks

These objects enumerate objects on the file system according to search
criteria specified by the user.

<a name='M-MFR-FileSystem-Retrievers-Factories-GetFileSystemEntryListRetriever-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates a new instance of an object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface that corresponds to the specified `type`
of operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) A
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
value that
corresponds to the type of operation currently being performed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if there is no object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface available that corresponds to the specified operation
`type`. |

<a name='T-MFR-FileSystem-Retrievers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Retrievers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Retrievers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Retrievers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
