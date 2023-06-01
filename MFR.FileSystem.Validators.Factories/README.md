<a name='assembly'></a>
# MFR.FileSystem.Validators.Factories

## Contents

- [GetFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Factories-GetFileSystemEntryValidator 'MFR.FileSystem.Validators.Factories.GetFileSystemEntryValidator')
  - [For(type)](#M-MFR-FileSystem-Validators-Factories-GetFileSystemEntryValidator-For-MFR-Operations-Constants-OperationType- 'MFR.FileSystem.Validators.Factories.GetFileSystemEntryValidator.For(MFR.Operations.Constants.OperationType)')
- [Resources](#T-MFR-FileSystem-Validators-Factories-Properties-Resources 'MFR.FileSystem.Validators.Factories.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Validators-Factories-Properties-Resources-Culture 'MFR.FileSystem.Validators.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Validators-Factories-Properties-Resources-ResourceManager 'MFR.FileSystem.Validators.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Validators-Factories-GetFileSystemEntryValidator'></a>
## GetFileSystemEntryValidator `type`

##### Namespace

MFR.FileSystem.Validators.Factories

##### Summary

Gets instances of objects that implement the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Interfaces.IFileSystemEntryValidator')
interface
that correspond to the type of file-system operation that is being performed.

<a name='M-MFR-FileSystem-Validators-Factories-GetFileSystemEntryValidator-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Gets a reference to an instance of an object implementing the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Interfaces.IFileSystemEntryValidator')
interface corresponding to the
[OperationType](#T-MFR-OperationType 'MFR.OperationType')
value that is
provided in the `type` parameter.

##### Returns

Reference to the instance of the object implementing the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Interfaces.IFileSystemEntryValidator')
interface that corresponds to the type of file-system operation
specified by the `type` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | One of the [OperationType](#T-MFR-OperationType 'MFR.OperationType')
values that specifies the type of file-system operation that is
being performed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if there is no file system entry validator object available
for the specified operation `type`. |

<a name='T-MFR-FileSystem-Validators-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Validators.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Validators-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Validators-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
