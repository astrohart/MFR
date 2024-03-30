<a name='assembly'></a>
# MFR.FileSystem.Validators

## Contents

- [DirectoryPathValidator](#T-MFR-FileSystem-Validators-DirectoryPathValidator 'MFR.FileSystem.Validators.DirectoryPathValidator')
  - [#ctor()](#M-MFR-FileSystem-Validators-DirectoryPathValidator-#ctor 'MFR.FileSystem.Validators.DirectoryPathValidator.#ctor')
  - [Instance](#P-MFR-FileSystem-Validators-DirectoryPathValidator-Instance 'MFR.FileSystem.Validators.DirectoryPathValidator.Instance')
  - [#cctor()](#M-MFR-FileSystem-Validators-DirectoryPathValidator-#cctor 'MFR.FileSystem.Validators.DirectoryPathValidator.#cctor')
- [FileSystemEntryValidator](#T-MFR-FileSystem-Validators-FileSystemEntryValidator 'MFR.FileSystem.Validators.FileSystemEntryValidator')
  - [ValidateFileSystemEntry(entry)](#M-MFR-FileSystem-Validators-FileSystemEntryValidator-ValidateFileSystemEntry-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.FileSystemEntryValidator.ValidateFileSystemEntry(MFR.FileSystem.Interfaces.IFileSystemEntry)')
- [FileSystemEntryValidatorBase](#T-MFR-FileSystem-Validators-FileSystemEntryValidatorBase 'MFR.FileSystem.Validators.FileSystemEntryValidatorBase')
  - [DISALLOWED_EXTENSIONS](#F-MFR-FileSystem-Validators-FileSystemEntryValidatorBase-DISALLOWED_EXTENSIONS 'MFR.FileSystem.Validators.FileSystemEntryValidatorBase.DISALLOWED_EXTENSIONS')
  - [DoesExist(entry)](#M-MFR-FileSystem-Validators-FileSystemEntryValidatorBase-DoesExist-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.FileSystemEntryValidatorBase.DoesExist(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [DoesExist(pathname)](#M-MFR-FileSystem-Validators-FileSystemEntryValidatorBase-DoesExist-System-String- 'MFR.FileSystem.Validators.FileSystemEntryValidatorBase.DoesExist(System.String)')
  - [IsValid(entry)](#M-MFR-FileSystem-Validators-FileSystemEntryValidatorBase-IsValid-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.FileSystemEntryValidatorBase.IsValid(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [ShouldNotSkip(path)](#M-MFR-FileSystem-Validators-FileSystemEntryValidatorBase-ShouldNotSkip-System-String- 'MFR.FileSystem.Validators.FileSystemEntryValidatorBase.ShouldNotSkip(System.String)')
  - [ShouldSkip(path)](#M-MFR-FileSystem-Validators-FileSystemEntryValidatorBase-ShouldSkip-System-String- 'MFR.FileSystem.Validators.FileSystemEntryValidatorBase.ShouldSkip(System.String)')
- [GitRepositoryFolderPathValidator](#T-MFR-FileSystem-Validators-GitRepositoryFolderPathValidator 'MFR.FileSystem.Validators.GitRepositoryFolderPathValidator')
  - [#ctor()](#M-MFR-FileSystem-Validators-GitRepositoryFolderPathValidator-#ctor 'MFR.FileSystem.Validators.GitRepositoryFolderPathValidator.#ctor')
  - [Instance](#P-MFR-FileSystem-Validators-GitRepositoryFolderPathValidator-Instance 'MFR.FileSystem.Validators.GitRepositoryFolderPathValidator.Instance')
  - [#cctor()](#M-MFR-FileSystem-Validators-GitRepositoryFolderPathValidator-#cctor 'MFR.FileSystem.Validators.GitRepositoryFolderPathValidator.#cctor')
  - [IsValid(entry)](#M-MFR-FileSystem-Validators-GitRepositoryFolderPathValidator-IsValid-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.GitRepositoryFolderPathValidator.IsValid(MFR.FileSystem.Interfaces.IFileSystemEntry)')
- [ProjectFileValidator](#T-MFR-FileSystem-Validators-ProjectFileValidator 'MFR.FileSystem.Validators.ProjectFileValidator')
  - [#ctor()](#M-MFR-FileSystem-Validators-ProjectFileValidator-#ctor 'MFR.FileSystem.Validators.ProjectFileValidator.#ctor')
  - [Instance](#P-MFR-FileSystem-Validators-ProjectFileValidator-Instance 'MFR.FileSystem.Validators.ProjectFileValidator.Instance')
  - [#cctor()](#M-MFR-FileSystem-Validators-ProjectFileValidator-#cctor 'MFR.FileSystem.Validators.ProjectFileValidator.#cctor')
  - [ShouldSkip(path)](#M-MFR-FileSystem-Validators-ProjectFileValidator-ShouldSkip-System-String- 'MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip(System.String)')
- [Resources](#T-MFR-FileSystem-Validators-Properties-Resources 'MFR.FileSystem.Validators.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Validators-Properties-Resources-Culture 'MFR.FileSystem.Validators.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Validators-Properties-Resources-ResourceManager 'MFR.FileSystem.Validators.Properties.Resources.ResourceManager')
- [SolutionFileValidator](#T-MFR-FileSystem-Validators-SolutionFileValidator 'MFR.FileSystem.Validators.SolutionFileValidator')
  - [#ctor()](#M-MFR-FileSystem-Validators-SolutionFileValidator-#ctor 'MFR.FileSystem.Validators.SolutionFileValidator.#ctor')
  - [Instance](#P-MFR-FileSystem-Validators-SolutionFileValidator-Instance 'MFR.FileSystem.Validators.SolutionFileValidator.Instance')
  - [#cctor()](#M-MFR-FileSystem-Validators-SolutionFileValidator-#cctor 'MFR.FileSystem.Validators.SolutionFileValidator.#cctor')
  - [ShouldSkip(path)](#M-MFR-FileSystem-Validators-SolutionFileValidator-ShouldSkip-System-String- 'MFR.FileSystem.Validators.SolutionFileValidator.ShouldSkip(System.String)')

<a name='T-MFR-FileSystem-Validators-DirectoryPathValidator'></a>
## DirectoryPathValidator `type`

##### Namespace

MFR.FileSystem.Validators

##### Summary

Defines an object that validates the paths of folders.

<a name='M-MFR-FileSystem-Validators-DirectoryPathValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-FileSystem-Validators-DirectoryPathValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface that validates directory paths, specifically.

<a name='M-MFR-FileSystem-Validators-DirectoryPathValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-FileSystem-Validators-FileSystemEntryValidator'></a>
## FileSystemEntryValidator `type`

##### Namespace

MFR.FileSystem.Validators

##### Summary

Validates the values of the properties of instances of objects that
implement the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface.

<a name='M-MFR-FileSystem-Validators-FileSystemEntryValidator-ValidateFileSystemEntry-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### ValidateFileSystemEntry(entry) `method`

##### Summary

Validates the `entry` specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown in the event that the
[Path](#P-MFR-IFileSystemEntry-Path 'MFR.IFileSystemEntry.Path')
property of
the object referenced by the `entry` parameter is a
blank or `null` string. |

<a name='T-MFR-FileSystem-Validators-FileSystemEntryValidatorBase'></a>
## FileSystemEntryValidatorBase `type`

##### Namespace

MFR.FileSystem.Validators

##### Summary

Defines the common methods, properties, events, and other functionality
for all types of file-system-entry validator object.

<a name='F-MFR-FileSystem-Validators-FileSystemEntryValidatorBase-DISALLOWED_EXTENSIONS'></a>
### DISALLOWED_EXTENSIONS `constants`

##### Summary

Array of extensions of files we won't search ever.

<a name='M-MFR-FileSystem-Validators-FileSystemEntryValidatorBase-DoesExist-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### DoesExist(entry) `method`

##### Summary

Determines whether the specified file-system
`entry`
exists on the disk.

##### Returns

`true` if the file-system `entry`
exists on the disk; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |

<a name='M-MFR-FileSystem-Validators-FileSystemEntryValidatorBase-DoesExist-System-String-'></a>
### DoesExist(pathname) `method`

##### Summary

Determines whether the file system entry at the specified
`pathname`, be it a file or a folder, exists.



Since a different API is used to determine whether files or directories exist,
this method must be overriden by child classes.

##### Returns

`true` if the resource exists at the pathname specified;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname
of the resource whose existence must be checked. |

##### Remarks

The purpose of this method is really to provide resource-existence detection
services to the public overload of this method, and so it can be used in the
body of, e.g., the
[ShouldSkip](#M-MFR-FileSystem-Validators-FileSystemEntryValidatorBase-ShouldSkip 'MFR.FileSystem.Validators.FileSystemEntryValidatorBase.ShouldSkip')
method.

<a name='M-MFR-FileSystem-Validators-FileSystemEntryValidatorBase-IsValid-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### IsValid(entry) `method`

##### Summary

Determines whether a file system `entry` exists on
the disk at the pathname indicated.

##### Returns

`true` if the provided filesystem
`entry` is valid; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface containing information about the entry to be checked. |

##### Remarks

If the properties of the `entry` have valid data
and the path stored in the entry refers to a file-system object that
exists on the disk, then this method returns `true`.



If an object instance variable or property has a
`null`
reference, or if the path stored in the entry
refers to a file-system object that does not exist on the disk, then
this method returns `false`.

<a name='M-MFR-FileSystem-Validators-FileSystemEntryValidatorBase-ShouldNotSkip-System-String-'></a>
### ShouldNotSkip(path) `method`

##### Summary

Gets a value determining whether the file system entry having the specified
`path` should be not be skipped.

##### Returns

`true` if the file or folder specified should not be
skipped during the current operation; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of a folder or a
file. |

<a name='M-MFR-FileSystem-Validators-FileSystemEntryValidatorBase-ShouldSkip-System-String-'></a>
### ShouldSkip(path) `method`

##### Summary

Determines whether the file-system entry with the specified
`path` should be skipped during an operation.

##### Returns

`true` is returned by this method if the file-system
entry with the specified `path` is to be skipped by
the operation; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname on the disk of the
file-system entry that is to potentially be skipped. |

<a name='T-MFR-FileSystem-Validators-GitRepositoryFolderPathValidator'></a>
## GitRepositoryFolderPathValidator `type`

##### Namespace

MFR.FileSystem.Validators

##### Summary

Defines an object that validates the paths of folders.

<a name='M-MFR-FileSystem-Validators-GitRepositoryFolderPathValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-FileSystem-Validators-GitRepositoryFolderPathValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface that validates directory paths, specifically, those that are supposed to
contain a local Git repository.  We know this is so if the directory's path, with
`.git` appended to it, exists.

<a name='M-MFR-FileSystem-Validators-GitRepositoryFolderPathValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Validators-GitRepositoryFolderPathValidator-IsValid-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### IsValid(entry) `method`

##### Summary

Determines whether a file system `entry` exists on
the disk at the pathname indicated.

##### Returns

`true` if the provided filesystem
`entry` is valid; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface containing information about the entry to be checked. |

##### Remarks

If the properties of the `entry` have valid data
and the path stored in the entry refers to a file-system object that
exists on the disk, then this method returns `true`.



If an object instance variable or property has a
`null`
reference, or if the path stored in the entry
refers to a file-system object that does not exist on the disk, then
this method returns `false`.

<a name='T-MFR-FileSystem-Validators-ProjectFileValidator'></a>
## ProjectFileValidator `type`

##### Namespace

MFR.FileSystem.Validators

##### Summary

Defines an object that validates the paths of files.

<a name='M-MFR-FileSystem-Validators-ProjectFileValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-FileSystem-Validators-ProjectFileValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface that validates project files.

<a name='M-MFR-FileSystem-Validators-ProjectFileValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Validators-ProjectFileValidator-ShouldSkip-System-String-'></a>
### ShouldSkip(path) `method`

##### Summary

Determines whether the file-system entry with the specified
`path` should be skipped during an operation.

##### Returns

`true` is returned by this method if the file-system
entry with the specified `path` is to be skipped by
the operation; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname on the disk of the
file-system entry that is to potentially be skipped. |

<a name='T-MFR-FileSystem-Validators-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Validators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Validators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Validators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-FileSystem-Validators-SolutionFileValidator'></a>
## SolutionFileValidator `type`

##### Namespace

MFR.FileSystem.Validators

##### Summary

Defines an object that validates the paths of Visual Studio Solution (those
whose names have the extension `.sln`) files.

<a name='M-MFR-FileSystem-Validators-SolutionFileValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-FileSystem-Validators-SolutionFileValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
interface and which validates the pathnames of Visual Studio Solution (*.sln)
files.

<a name='M-MFR-FileSystem-Validators-SolutionFileValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Validators-SolutionFileValidator-ShouldSkip-System-String-'></a>
### ShouldSkip(path) `method`

##### Summary

Determines whether the file-system entry with the specified
`path` should be skipped during an operation.

##### Returns

`true` is returned by this method if the file-system
entry with the specified `path` is to be skipped by
the operation; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname on the disk of the
file-system entry that is to potentially be skipped. |
