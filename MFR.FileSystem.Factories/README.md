<a name='assembly'></a>
# MFR.FileSystem.Factories

## Contents

- [MakeNewDirectoryInfo](#T-MFR-FileSystem-Factories-MakeNewDirectoryInfo 'MFR.FileSystem.Factories.MakeNewDirectoryInfo')
  - [ForPath(path)](#M-MFR-FileSystem-Factories-MakeNewDirectoryInfo-ForPath-System-String- 'MFR.FileSystem.Factories.MakeNewDirectoryInfo.ForPath(System.String)')
- [MakeNewFileInfo](#T-MFR-FileSystem-Factories-MakeNewFileInfo 'MFR.FileSystem.Factories.MakeNewFileInfo')
  - [ForPath(path)](#M-MFR-FileSystem-Factories-MakeNewFileInfo-ForPath-System-String- 'MFR.FileSystem.Factories.MakeNewFileInfo.ForPath(System.String)')
  - [FromFileSystemEntry(entry)](#M-MFR-FileSystem-Factories-MakeNewFileInfo-FromFileSystemEntry-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Factories.MakeNewFileInfo.FromFileSystemEntry(MFR.FileSystem.Interfaces.IFileSystemEntry)')
- [MakeNewFileSystemEntry](#T-MFR-FileSystem-Factories-MakeNewFileSystemEntry 'MFR.FileSystem.Factories.MakeNewFileSystemEntry')
  - [ForPath(pathname)](#M-MFR-FileSystem-Factories-MakeNewFileSystemEntry-ForPath-System-String- 'MFR.FileSystem.Factories.MakeNewFileSystemEntry.ForPath(System.String)')
- [Resources](#T-MFR-FileSystem-Factories-Properties-Resources 'MFR.FileSystem.Factories.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Factories-Properties-Resources-Culture 'MFR.FileSystem.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Factories-Properties-Resources-ResourceManager 'MFR.FileSystem.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Factories-MakeNewDirectoryInfo'></a>
## MakeNewDirectoryInfo `type`

##### Namespace

MFR.FileSystem.Factories

##### Summary

Creates new instances of
[DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo').

<a name='M-MFR-FileSystem-Factories-MakeNewDirectoryInfo-ForPath-System-String-'></a>
### ForPath(path) `method`

##### Summary

Creates a new instance of
[DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo')
that wraps the folder with the specified `path` and
returns a reference to it.

##### Returns

Reference to an instance of
[DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo')
that represents the folder with the specified `path`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the path of the folder to be wrapped. |

##### Remarks

If the `path` references a folder that does not exist, or if
the `path` folder is passed a string that is not the pathname
of a folder, or if `path` is blank, or if an I/O or other
exception was thrown during the creation process, then this method returns
`null`.

<a name='T-MFR-FileSystem-Factories-MakeNewFileInfo'></a>
## MakeNewFileInfo `type`

##### Namespace

MFR.FileSystem.Factories

##### Summary

Creates new instances of [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') and returns
references to them.

<a name='M-MFR-FileSystem-Factories-MakeNewFileInfo-ForPath-System-String-'></a>
### ForPath(path) `method`

##### Summary

Creates a new instance of [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo'),
initializes it with the `path` specified, and
returns it.

##### Returns

A [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo'), initialized with the specified
`path`.



`null` is returned if the operation failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname of a file on the file system. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `path`, is passed
a blank or `null` string for a value. |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the file, the path to which is specified by the
`path`
parameter, cannot be located on the file system. |

<a name='M-MFR-FileSystem-Factories-MakeNewFileInfo-FromFileSystemEntry-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### FromFileSystemEntry(entry) `method`

##### Summary

Creates a new instance of [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') for the
file whose path is specified by the object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface, a reference to which is passed in the
`entry`
parameter.

##### Returns

Reference to an instance of [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') that
is initialized with the path to the file referred to by the value of
the `entry` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface that contains the file's path. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required
[Path](#P-MFR-FileSystem-Interfaces-IFileSystemEntry-Path 'MFR.FileSystem.Interfaces.IFileSystemEntry.Path')
property is passed a blank or `null` string for a value. |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |

<a name='T-MFR-FileSystem-Factories-MakeNewFileSystemEntry'></a>
## MakeNewFileSystemEntry `type`

##### Namespace

MFR.FileSystem.Factories

##### Summary

Creates new instances of objects that implement the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface.

<a name='M-MFR-FileSystem-Factories-MakeNewFileSystemEntry-ForPath-System-String-'></a>
### ForPath(pathname) `method`

##### Summary

Creates a new instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface, for
the `pathname` specified, and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface,
initialized with the specified `pathname`, or
`null` if either an exception is thrown during the create
operation or if `pathname` is a blank value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of the
file-system entry (file or folder). |

##### Remarks

NOTE: The caller must also call the
[AndOperationType](#M-MFR-IOperationSpecificObject-AndOperationType 'MFR.IOperationSpecificObject.AndOperationType')
method,
and, optionally, the
[WithUserState](#M-MFR-IFileSystemEntry-WithUserState 'MFR.IFileSystemEntry.WithUserState')
fluent-builder methods on the result.

<a name='T-MFR-FileSystem-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
