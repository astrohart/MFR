<a name='assembly'></a>
# MFR.FileSystem

## Contents

- [FileSystemEntry](#T-MFR-FileSystem-FileSystemEntry 'MFR.FileSystem.FileSystemEntry')
  - [#ctor(path)](#M-MFR-FileSystem-FileSystemEntry-#ctor-System-String- 'MFR.FileSystem.FileSystemEntry.#ctor(System.String)')
  - [ContainingFolder](#P-MFR-FileSystem-FileSystemEntry-ContainingFolder 'MFR.FileSystem.FileSystemEntry.ContainingFolder')
  - [Exists](#P-MFR-FileSystem-FileSystemEntry-Exists 'MFR.FileSystem.FileSystemEntry.Exists')
  - [OperationType](#P-MFR-FileSystem-FileSystemEntry-OperationType 'MFR.FileSystem.FileSystemEntry.OperationType')
  - [Path](#P-MFR-FileSystem-FileSystemEntry-Path 'MFR.FileSystem.FileSystemEntry.Path')
  - [ShortPath](#P-MFR-FileSystem-FileSystemEntry-ShortPath 'MFR.FileSystem.FileSystemEntry.ShortPath')
  - [UserState](#P-MFR-FileSystem-FileSystemEntry-UserState 'MFR.FileSystem.FileSystemEntry.UserState')
  - [SetUserState(userState)](#M-MFR-FileSystem-FileSystemEntry-SetUserState-System-Object- 'MFR.FileSystem.FileSystemEntry.SetUserState(System.Object)')
  - [ToString()](#M-MFR-FileSystem-FileSystemEntry-ToString 'MFR.FileSystem.FileSystemEntry.ToString')
- [Resources](#T-MFR-FileSystem-Properties-Resources 'MFR.FileSystem.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Properties-Resources-Culture 'MFR.FileSystem.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Properties-Resources-ResourceManager 'MFR.FileSystem.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-FileSystemEntry'></a>
## FileSystemEntry `type`

##### Namespace

MFR.FileSystem

##### Summary

POCO to encapsulate the details of a file-system entry, such as a file
or a folder.

<a name='M-MFR-FileSystem-FileSystemEntry-#ctor-System-String-'></a>
### #ctor(path) `constructor`

##### Summary

Constructs a new instance of
[FileSystemEntry](#T-MFR-FileSystem-FileSystemEntry 'MFR.FileSystem.FileSystemEntry')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname of the file-system entry. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `path`, is passed
a blank or `null` string for a value. |

<a name='P-MFR-FileSystem-FileSystemEntry-ContainingFolder'></a>
### ContainingFolder `property`

##### Summary

Gets or sets the pathname of the parent folder of this file system entry.

<a name='P-MFR-FileSystem-FileSystemEntry-Exists'></a>
### Exists `property`

##### Summary

Gets a value that indicates whether the file system entry exists.

##### Returns

`true` if the file system entry exists;
`false` otherwise.

<a name='P-MFR-FileSystem-FileSystemEntry-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-FileSystem-FileSystemEntry-Path'></a>
### Path `property`

##### Summary

Gets or sets the pathname of the file-system entry.

<a name='P-MFR-FileSystem-FileSystemEntry-ShortPath'></a>
### ShortPath `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a truncated version of the
value of the [Path](#P-MFR-FileSystem-FileSystemEntry-Path 'MFR.FileSystem.FileSystemEntry.Path') property.

<a name='P-MFR-FileSystem-FileSystemEntry-UserState'></a>
### UserState `property`

##### Summary

Gets or sets user state.

##### Remarks

For example, if the file-system entry is representing a text file,
then this property might contain the file's contents from them
having been previously read in.

<a name='M-MFR-FileSystem-FileSystemEntry-SetUserState-System-Object-'></a>
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

<a name='M-MFR-FileSystem-FileSystemEntry-ToString'></a>
### ToString() `method`

##### Summary

Returns a string that represents the current object.

##### Returns

A string that represents the current object.

##### Parameters

This method has no parameters.

<a name='T-MFR-FileSystem-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
