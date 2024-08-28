<a name='assembly'></a>
# MFR.FileSystem.Validators.Interfaces

## Contents

- [IFileSystemEntryValidator](#T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
  - [DoesExist(entry)](#M-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator-DoesExist-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator.DoesExist(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [IsValid(entry)](#M-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator-IsValid-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator.IsValid(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [ShouldNotSkip(path)](#M-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator-ShouldNotSkip-System-String- 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator.ShouldNotSkip(System.String)')
  - [ShouldSkip(path)](#M-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator-ShouldSkip-System-String- 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator.ShouldSkip(System.String)')
- [Resources](#T-MFR-FileSystem-Validators-Interfaces-Properties-Resources 'MFR.FileSystem.Validators.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Validators-Interfaces-Properties-Resources-Culture 'MFR.FileSystem.Validators.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Validators-Interfaces-Properties-Resources-ResourceManager 'MFR.FileSystem.Validators.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator'></a>
## IFileSystemEntryValidator `type`

##### Namespace

MFR.FileSystem.Validators.Interfaces

##### Summary

Defines the public-exposed methods and properties of a file-system-entry
validator object.

##### Remarks

Such an object is one that uses information about the type of operation
being performed, as well as a pathname to a file or a folder, in order
to determine whether the pathname is valid.

<a name='M-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator-DoesExist-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### DoesExist(entry) `method`

##### Summary

Determines whether the specified file-system s
`entry`
exists on the file system.

##### Returns

`true` if the file-system `entry`
exists on the file system; `false` otherwise.

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

<a name='M-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator-IsValid-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### IsValid(entry) `method`

##### Summary

Determines whether a file system `entry` exists on
the file system at the pathname indicated.

##### Returns

`true` if the provided filesystem `entry` is valid; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface containing information about the entry to be checked. |

##### Remarks

If the properties of the `entry` have valid data
and the path stored in the entry refers to a file-system object that
exists on the file system, then this method returns `true`.



If an object instance variable or property has a
`null`
reference, or if the path stored in the entry
refers to a file-system object that does not exist on the file system, then
this method returns `false`.

<a name='M-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator-ShouldNotSkip-System-String-'></a>
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

<a name='M-MFR-FileSystem-Validators-Interfaces-IFileSystemEntryValidator-ShouldSkip-System-String-'></a>
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
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname on the file system of the
file-system entry that is to potentially be skipped. |

<a name='T-MFR-FileSystem-Validators-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Validators.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Validators-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Validators-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
