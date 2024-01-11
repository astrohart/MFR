<a name='assembly'></a>
# MFR.FileSystem.Interfaces

## Contents

- [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
  - [ContainingFolder](#P-MFR-FileSystem-Interfaces-IFileSystemEntry-ContainingFolder 'MFR.FileSystem.Interfaces.IFileSystemEntry.ContainingFolder')
  - [Exists](#P-MFR-FileSystem-Interfaces-IFileSystemEntry-Exists 'MFR.FileSystem.Interfaces.IFileSystemEntry.Exists')
  - [IsFolder](#P-MFR-FileSystem-Interfaces-IFileSystemEntry-IsFolder 'MFR.FileSystem.Interfaces.IFileSystemEntry.IsFolder')
  - [Path](#P-MFR-FileSystem-Interfaces-IFileSystemEntry-Path 'MFR.FileSystem.Interfaces.IFileSystemEntry.Path')
  - [ShortPath](#P-MFR-FileSystem-Interfaces-IFileSystemEntry-ShortPath 'MFR.FileSystem.Interfaces.IFileSystemEntry.ShortPath')
  - [UserState](#P-MFR-FileSystem-Interfaces-IFileSystemEntry-UserState 'MFR.FileSystem.Interfaces.IFileSystemEntry.UserState')
  - [SetUserState(userState)](#M-MFR-FileSystem-Interfaces-IFileSystemEntry-SetUserState-System-Object- 'MFR.FileSystem.Interfaces.IFileSystemEntry.SetUserState(System.Object)')
- [Resources](#T-MFR-FileSystem-Interfaces-Properties-Resources 'MFR.FileSystem.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Interfaces-Properties-Resources-Culture 'MFR.FileSystem.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Interfaces-Properties-Resources-ResourceManager 'MFR.FileSystem.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Interfaces-IFileSystemEntry'></a>
## IFileSystemEntry `type`

##### Namespace

MFR.FileSystem.Interfaces

##### Summary

Defines the public-exposed methods and properties of a POCO that
encapsulates data about a file-system entry.

<a name='P-MFR-FileSystem-Interfaces-IFileSystemEntry-ContainingFolder'></a>
### ContainingFolder `property`

##### Summary

Gets or sets the pathname of the parent folder of this file system entry.

<a name='P-MFR-FileSystem-Interfaces-IFileSystemEntry-Exists'></a>
### Exists `property`

##### Summary

Gets a value that indicates whether the file system entry exists.

##### Returns

`true` if the file system entry exists;
`false` otherwise.

<a name='P-MFR-FileSystem-Interfaces-IFileSystemEntry-IsFolder'></a>
### IsFolder `property`

##### Summary

Gets a value indicating whether the entry represents a file or a folder on the
file system.

##### Returns

`true` if this file system entry is folder;
`false` otherwise.

<a name='P-MFR-FileSystem-Interfaces-IFileSystemEntry-Path'></a>
### Path `property`

##### Summary

Gets or sets the pathname of the file-system entry.

<a name='P-MFR-FileSystem-Interfaces-IFileSystemEntry-ShortPath'></a>
### ShortPath `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a truncated version of the
value of the [Path](#P-MFR-FileSystem-FileSystemEntry-Path 'MFR.FileSystem.FileSystemEntry.Path') property.

<a name='P-MFR-FileSystem-Interfaces-IFileSystemEntry-UserState'></a>
### UserState `property`

##### Summary

Gets or sets user state.

##### Remarks

For example, if the file-system entry is representing a text file,
then this property might contain the file's contents from them
having been previously read in.

<a name='M-MFR-FileSystem-Interfaces-IFileSystemEntry-SetUserState-System-Object-'></a>
### SetUserState(userState) `method`

##### Summary

Associates user state information, such as file contents or other
data, with this file-system entry.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userState | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to an instance of an object that serves as
user state information. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `userState`, is
passed a `null` value. |

<a name='T-MFR-FileSystem-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
