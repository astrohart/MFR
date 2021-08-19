<a name='assembly'></a>
# MFR.Objects.FileSystem

## Contents

- [FileSystemEntry](#T-MFR-Objects-FileSystem-FileSystemEntry 'MFR.Objects.FileSystem.FileSystemEntry')
  - [#ctor(path)](#M-MFR-Objects-FileSystem-FileSystemEntry-#ctor-System-String- 'MFR.Objects.FileSystem.FileSystemEntry.#ctor(System.String)')
  - [ContainingFolder](#P-MFR-Objects-FileSystem-FileSystemEntry-ContainingFolder 'MFR.Objects.FileSystem.FileSystemEntry.ContainingFolder')
  - [OperationType](#P-MFR-Objects-FileSystem-FileSystemEntry-OperationType 'MFR.Objects.FileSystem.FileSystemEntry.OperationType')
  - [Path](#P-MFR-Objects-FileSystem-FileSystemEntry-Path 'MFR.Objects.FileSystem.FileSystemEntry.Path')
  - [UserState](#P-MFR-Objects-FileSystem-FileSystemEntry-UserState 'MFR.Objects.FileSystem.FileSystemEntry.UserState')
  - [AndHavingUserState(userState)](#M-MFR-Objects-FileSystem-FileSystemEntry-AndHavingUserState-System-Object- 'MFR.Objects.FileSystem.FileSystemEntry.AndHavingUserState(System.Object)')
- [Resources](#T-MFR-Objects-FileSystem-Properties-Resources 'MFR.Objects.FileSystem.Properties.Resources')
  - [Culture](#P-MFR-Objects-FileSystem-Properties-Resources-Culture 'MFR.Objects.FileSystem.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-FileSystem-Properties-Resources-ResourceManager 'MFR.Objects.FileSystem.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-FileSystem-FileSystemEntry'></a>
## FileSystemEntry `type`

##### Namespace

MFR.Objects.FileSystem

##### Summary

POCO to encapsulate the details of a file-system entry, such as a file
or a folder.

<a name='M-MFR-Objects-FileSystem-FileSystemEntry-#ctor-System-String-'></a>
### #ctor(path) `constructor`

##### Summary

Constructs a new instance of
[FileSystemEntry](#T-MFR-Objects-FileSystem-FileSystemEntry 'MFR.Objects.FileSystem.FileSystemEntry')
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

<a name='P-MFR-Objects-FileSystem-FileSystemEntry-ContainingFolder'></a>
### ContainingFolder `property`

##### Summary

Gets or sets the pathname of the parent folder of this file system entry.

<a name='P-MFR-Objects-FileSystem-FileSystemEntry-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Objects-FileSystem-FileSystemEntry-Path'></a>
### Path `property`

##### Summary

Gets or sets the pathname of the file-system entry.

<a name='P-MFR-Objects-FileSystem-FileSystemEntry-UserState'></a>
### UserState `property`

##### Summary

Gets or sets user state.

##### Remarks

For example, if the file-system entry is representing a text file,
then this property might contain the file's contents from them
having been previously read in.

<a name='M-MFR-Objects-FileSystem-FileSystemEntry-AndHavingUserState-System-Object-'></a>
### AndHavingUserState(userState) `method`

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

<a name='T-MFR-Objects-FileSystem-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.FileSystem.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-FileSystem-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-FileSystem-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
