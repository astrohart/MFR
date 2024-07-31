<a name='assembly'></a>
# MFR.FileSystem.Validators.Factories

## Contents

- [GetDirectoryPathValidator](#T-MFR-FileSystem-Validators-Factories-GetDirectoryPathValidator 'MFR.FileSystem.Validators.Factories.GetDirectoryPathValidator')
  - [SoleInstance()](#M-MFR-FileSystem-Validators-Factories-GetDirectoryPathValidator-SoleInstance 'MFR.FileSystem.Validators.Factories.GetDirectoryPathValidator.SoleInstance')
- [GetFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Factories-GetFileSystemEntryValidator 'MFR.FileSystem.Validators.Factories.GetFileSystemEntryValidator')
  - [For(type)](#M-MFR-FileSystem-Validators-Factories-GetFileSystemEntryValidator-For-MFR-Operations-Constants-OperationType- 'MFR.FileSystem.Validators.Factories.GetFileSystemEntryValidator.For(MFR.Operations.Constants.OperationType)')
- [GetGitRepositoryFolderPathValidator](#T-MFR-FileSystem-Validators-Factories-GetGitRepositoryFolderPathValidator 'MFR.FileSystem.Validators.Factories.GetGitRepositoryFolderPathValidator')
  - [SoleInstance()](#M-MFR-FileSystem-Validators-Factories-GetGitRepositoryFolderPathValidator-SoleInstance 'MFR.FileSystem.Validators.Factories.GetGitRepositoryFolderPathValidator.SoleInstance')
- [GetProjectFileValidator](#T-MFR-FileSystem-Validators-Factories-GetProjectFileValidator 'MFR.FileSystem.Validators.Factories.GetProjectFileValidator')
  - [SoleInstance()](#M-MFR-FileSystem-Validators-Factories-GetProjectFileValidator-SoleInstance 'MFR.FileSystem.Validators.Factories.GetProjectFileValidator.SoleInstance')
- [GetSolutionFileValidator](#T-MFR-FileSystem-Validators-Factories-GetSolutionFileValidator 'MFR.FileSystem.Validators.Factories.GetSolutionFileValidator')
  - [SoleInstance()](#M-MFR-FileSystem-Validators-Factories-GetSolutionFileValidator-SoleInstance 'MFR.FileSystem.Validators.Factories.GetSolutionFileValidator.SoleInstance')
- [Resources](#T-MFR-FileSystem-Validators-Factories-Properties-Resources 'MFR.FileSystem.Validators.Factories.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Validators-Factories-Properties-Resources-Culture 'MFR.FileSystem.Validators.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Validators-Factories-Properties-Resources-ResourceManager 'MFR.FileSystem.Validators.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Validators-Factories-GetDirectoryPathValidator'></a>
## GetDirectoryPathValidator `type`

##### Namespace

MFR.FileSystem.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface that validates whether directories exist on the file system.

<a name='M-MFR-FileSystem-Validators-Factories-GetDirectoryPathValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface  that validates whether directories exist on the file system.

##### Parameters

This method has no parameters.

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
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
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
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | One of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that specifies the type of file-system operation that is
being performed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if there is no file system entry validator object available
for the specified operation `type`. |

<a name='T-MFR-FileSystem-Validators-Factories-GetGitRepositoryFolderPathValidator'></a>
## GetGitRepositoryFolderPathValidator `type`

##### Namespace

MFR.FileSystem.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface that validates directory paths, specifically, those that are supposed to
contain a local Git repository.  We know this is so if the directory's path, with
`.git` appended to it, exists.

<a name='M-MFR-FileSystem-Validators-Factories-GetGitRepositoryFolderPathValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface that validates directory paths, specifically, those that are supposed to
contain a local Git repository.  We know this is so if the directory's path, with
`.git` appended to it, exists.

##### Parameters

This method has no parameters.

<a name='T-MFR-FileSystem-Validators-Factories-GetProjectFileValidator'></a>
## GetProjectFileValidator `type`

##### Namespace

MFR.FileSystem.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface that validates the contents of project files.

<a name='M-MFR-FileSystem-Validators-Factories-GetProjectFileValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface that validates the contents of project files.

##### Parameters

This method has no parameters.

<a name='T-MFR-FileSystem-Validators-Factories-GetSolutionFileValidator'></a>
## GetSolutionFileValidator `type`

##### Namespace

MFR.FileSystem.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface that validates the contents of Visual Studio Solution (*.sln) files.

<a name='M-MFR-FileSystem-Validators-Factories-GetSolutionFileValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface that validates the contents of Visual Studio Solution (*.sln) files.

##### Parameters

This method has no parameters.

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
