<a name='assembly'></a>
# MFR.FileSystem.Validators

## Contents

- [DirectoryValidator](#T-MFR-Objects-FileSystem-Validators-DirectoryValidator 'MFR.FileSystem.Validators.DirectoryValidator')
  - [#ctor()](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-#ctor 'MFR.FileSystem.Validators.DirectoryValidator.#ctor')
  - [Instance](#P-MFR-Objects-FileSystem-Validators-DirectoryValidator-Instance 'MFR.FileSystem.Validators.DirectoryValidator.Instance')
  - [#cctor()](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-#cctor 'MFR.FileSystem.Validators.DirectoryValidator.#cctor')
  - [DoesExist(entry)](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-DoesExist-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.DirectoryValidator.DoesExist(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [IsValid(entry)](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-IsValid-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.DirectoryValidator.IsValid(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [ShouldSkip(path)](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-ShouldSkip-System-String- 'MFR.FileSystem.Validators.DirectoryValidator.ShouldSkip(System.String)')
- [FileSystemEntryValidator](#T-MFR-Objects-FileSystem-Validators-FileSystemEntryValidator 'MFR.FileSystem.Validators.FileSystemEntryValidator')
  - [ValidateFileSystemEntry(entry)](#M-MFR-Objects-FileSystem-Validators-FileSystemEntryValidator-ValidateFileSystemEntry-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.FileSystemEntryValidator.ValidateFileSystemEntry(MFR.FileSystem.Interfaces.IFileSystemEntry)')
- [FileSystemEntryValidatorBase](#T-MFR-Objects-FileSystem-Validators-FileSystemEntryValidatorBase 'MFR.FileSystem.Validators.FileSystemEntryValidatorBase')
  - [DoesExist(entry)](#M-MFR-Objects-FileSystem-Validators-FileSystemEntryValidatorBase-DoesExist-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.FileSystemEntryValidatorBase.DoesExist(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [IsValid(entry)](#M-MFR-Objects-FileSystem-Validators-FileSystemEntryValidatorBase-IsValid-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.FileSystemEntryValidatorBase.IsValid(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [ShouldSkip(path)](#M-MFR-Objects-FileSystem-Validators-FileSystemEntryValidatorBase-ShouldSkip-System-String- 'MFR.FileSystem.Validators.FileSystemEntryValidatorBase.ShouldSkip(System.String)')
- [FileValidator](#T-MFR-Objects-FileSystem-Validators-FileValidator 'MFR.FileSystem.Validators.FileValidator')
  - [#ctor()](#M-MFR-Objects-FileSystem-Validators-FileValidator-#ctor 'MFR.FileSystem.Validators.FileValidator.#ctor')
  - [Instance](#P-MFR-Objects-FileSystem-Validators-FileValidator-Instance 'MFR.FileSystem.Validators.FileValidator.Instance')
  - [#cctor()](#M-MFR-Objects-FileSystem-Validators-FileValidator-#cctor 'MFR.FileSystem.Validators.FileValidator.#cctor')
  - [DoesExist(entry)](#M-MFR-Objects-FileSystem-Validators-FileValidator-DoesExist-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.FileValidator.DoesExist(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [IsValid(entry)](#M-MFR-Objects-FileSystem-Validators-FileValidator-IsValid-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Validators.FileValidator.IsValid(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [ShouldSkip(path)](#M-MFR-Objects-FileSystem-Validators-FileValidator-ShouldSkip-System-String- 'MFR.FileSystem.Validators.FileValidator.ShouldSkip(System.String)')
- [Resources](#T-MFR-Objects-FileSystem-Validators-Properties-Resources 'MFR.FileSystem.Validators.Properties.Resources')
  - [Culture](#P-MFR-Objects-FileSystem-Validators-Properties-Resources-Culture 'MFR.FileSystem.Validators.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-FileSystem-Validators-Properties-Resources-ResourceManager 'MFR.FileSystem.Validators.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-FileSystem-Validators-DirectoryValidator'></a>
## DirectoryValidator `type`

##### Namespace

MFR.FileSystem.Validators

##### Summary

Defines an object that validates the paths of folders.

<a name='M-MFR-Objects-FileSystem-Validators-DirectoryValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-FileSystem-Validators-DirectoryValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[DirectoryValidator](#T-MFR-Objects-FileSystem-Validators-DirectoryValidator 'MFR.FileSystem.Validators.DirectoryValidator').

<a name='M-MFR-Objects-FileSystem-Validators-DirectoryValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-DirectoryValidator-DoesExist-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
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
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |

<a name='M-MFR-Objects-FileSystem-Validators-DirectoryValidator-IsValid-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
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

<a name='M-MFR-Objects-FileSystem-Validators-DirectoryValidator-ShouldSkip-System-String-'></a>
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

<a name='T-MFR-Objects-FileSystem-Validators-FileSystemEntryValidator'></a>
## FileSystemEntryValidator `type`

##### Namespace

MFR.FileSystem.Validators

##### Summary

Validates the values of the properties of instances of objects that
implement the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface.

<a name='M-MFR-Objects-FileSystem-Validators-FileSystemEntryValidator-ValidateFileSystemEntry-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
### ValidateFileSystemEntry(entry) `method`

##### Summary

Validates the `entry` specified.

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
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown in the event that the
[Path](#P-MFR-Objects-IFileSystemEntry-Path 'MFR.IFileSystemEntry.Path')
property of
the object referenced by the `entry` parameter is a
blank or `null` string. |

<a name='T-MFR-Objects-FileSystem-Validators-FileSystemEntryValidatorBase'></a>
## FileSystemEntryValidatorBase `type`

##### Namespace

MFR.FileSystem.Validators

##### Summary

Defines the common methods, properties, events, and other functionality
for all types of file-system-entry validator object.

<a name='M-MFR-Objects-FileSystem-Validators-FileSystemEntryValidatorBase-DoesExist-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
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
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |

<a name='M-MFR-Objects-FileSystem-Validators-FileSystemEntryValidatorBase-IsValid-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
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

<a name='M-MFR-Objects-FileSystem-Validators-FileSystemEntryValidatorBase-ShouldSkip-System-String-'></a>
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

<a name='T-MFR-Objects-FileSystem-Validators-FileValidator'></a>
## FileValidator `type`

##### Namespace

MFR.FileSystem.Validators

##### Summary

Defines an object that validates the paths of files.

<a name='M-MFR-Objects-FileSystem-Validators-FileValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-FileSystem-Validators-FileValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[FileValidator](#T-MFR-Objects-FileSystem-Validators-FileValidator 'MFR.FileSystem.Validators.FileValidator').

<a name='M-MFR-Objects-FileSystem-Validators-FileValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-FileValidator-DoesExist-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
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
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |

<a name='M-MFR-Objects-FileSystem-Validators-FileValidator-IsValid-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
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

<a name='M-MFR-Objects-FileSystem-Validators-FileValidator-ShouldSkip-System-String-'></a>
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

<a name='T-MFR-Objects-FileSystem-Validators-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Validators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-FileSystem-Validators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-FileSystem-Validators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
