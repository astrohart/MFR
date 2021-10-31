<a name='assembly'></a>
# MFR.FileSystem.Validators.Interfaces

## Contents

- [IFileSystemEntryValidator](#T-MFR-Objects-FileSystem-Validators-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator')
  - [DoesExist(entry)](#M-MFR-Objects-FileSystem-Validators-Interfaces-IFileSystemEntryValidator-DoesExist-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator.DoesExist(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [IsValid(entry)](#M-MFR-Objects-FileSystem-Validators-Interfaces-IFileSystemEntryValidator-IsValid-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator.IsValid(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [ShouldSkip(path)](#M-MFR-Objects-FileSystem-Validators-Interfaces-IFileSystemEntryValidator-ShouldSkip-System-String- 'MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator.ShouldSkip(System.String)')
- [Resources](#T-MFR-Objects-FileSystem-Validators-Interfaces-Properties-Resources 'MFR.FileSystem.Validators.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-FileSystem-Validators-Interfaces-Properties-Resources-Culture 'MFR.FileSystem.Validators.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-FileSystem-Validators-Interfaces-Properties-Resources-ResourceManager 'MFR.FileSystem.Validators.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-FileSystem-Validators-Interfaces-IFileSystemEntryValidator'></a>
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

<a name='M-MFR-Objects-FileSystem-Validators-Interfaces-IFileSystemEntryValidator-DoesExist-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
### DoesExist(entry) `method`

##### Summary

Determines whether the specified file-system s
`entry`
exists on the disk.

##### Returns

`true` if the file-system `entry`
exists on the disk; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |

<a name='M-MFR-Objects-FileSystem-Validators-Interfaces-IFileSystemEntryValidator-IsValid-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
### IsValid(entry) `method`

##### Summary

Determines whether a file system `entry` exists on
the disk at the pathname indicated.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface containing information about the entry to be checked. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the pathname to a folder is passed in the
`entry`
parameter and the folder cannot be located on the disk. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the pathname to a file is passed in the
`entry`
parameter and the file cannot be located on the disk. |

##### Remarks

If the properties of the `entry` have valid data
and the path stored in the entry refers to a file-system object that
exists on the disk, then this method does nothing.



If an object instance variable or property has a
`null`
reference, or if the path stored in the entry
refers to a file-system object that does not exist on the disk, then
an exception is thrown.

<a name='M-MFR-Objects-FileSystem-Validators-Interfaces-IFileSystemEntryValidator-ShouldSkip-System-String-'></a>
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

<a name='T-MFR-Objects-FileSystem-Validators-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Validators.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-FileSystem-Validators-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-FileSystem-Validators-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
