<a name='assembly'></a>
# MFR.FileSystem.Interfaces

## Contents

- [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
  - [ContainingFolder](#P-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-ContainingFolder 'MFR.FileSystem.Interfaces.IFileSystemEntry.ContainingFolder')
  - [Path](#P-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-Path 'MFR.FileSystem.Interfaces.IFileSystemEntry.Path')
  - [UserState](#P-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-UserState 'MFR.FileSystem.Interfaces.IFileSystemEntry.UserState')
  - [AndHavingUserState(userState)](#M-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-AndHavingUserState-System-Object- 'MFR.FileSystem.Interfaces.IFileSystemEntry.AndHavingUserState(System.Object)')
- [Resources](#T-MFR-Objects-FileSystem-Interfaces-Properties-Resources 'MFR.FileSystem.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-FileSystem-Interfaces-Properties-Resources-Culture 'MFR.FileSystem.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-FileSystem-Interfaces-Properties-Resources-ResourceManager 'MFR.FileSystem.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry'></a>
## IFileSystemEntry `type`

##### Namespace

MFR.FileSystem.Interfaces

##### Summary

Defines the public-exposed methods and properties of a POCO that
encapsulates data about a file-system entry.

<a name='P-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-ContainingFolder'></a>
### ContainingFolder `property`

##### Summary

Gets or sets the pathname of the parent folder of this file system entry.

<a name='P-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-Path'></a>
### Path `property`

##### Summary

Gets or sets the pathname of the file-system entry.

<a name='P-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-UserState'></a>
### UserState `property`

##### Summary

Gets or sets user state.

##### Remarks

For example, if the file-system entry is representing a text file,
then this property might contain the file's contents from them
having been previously read in.

<a name='M-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-AndHavingUserState-System-Object-'></a>
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

<a name='T-MFR-Objects-FileSystem-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-FileSystem-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-FileSystem-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
