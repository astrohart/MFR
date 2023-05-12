<a name='assembly'></a>
# MFR.FileSystem.Factories.Actions

## Contents

- [Does](#T-MFR-FileSystem-Factories-Actions-Does 'MFR.FileSystem.Factories.Actions.Does')
  - [FileExist(pathname)](#M-MFR-FileSystem-Factories-Actions-Does-FileExist-System-String- 'MFR.FileSystem.Factories.Actions.Does.FileExist(System.String)')
  - [FileSystemEntryExist(pathname)](#M-MFR-FileSystem-Factories-Actions-Does-FileSystemEntryExist-System-String- 'MFR.FileSystem.Factories.Actions.Does.FileSystemEntryExist(System.String)')
  - [FolderExist(pathname)](#M-MFR-FileSystem-Factories-Actions-Does-FolderExist-System-String- 'MFR.FileSystem.Factories.Actions.Does.FolderExist(System.String)')
- [Is](#T-MFR-FileSystem-Factories-Actions-Is 'MFR.FileSystem.Factories.Actions.Is')
  - [Folder(pathname)](#M-MFR-FileSystem-Factories-Actions-Is-Folder-System-String- 'MFR.FileSystem.Factories.Actions.Is.Folder(System.String)')
- [Resources](#T-MFR-FileSystem-Factories-Actions-Properties-Resources 'MFR.FileSystem.Factories.Actions.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Factories-Actions-Properties-Resources-Culture 'MFR.FileSystem.Factories.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Factories-Actions-Properties-Resources-ResourceManager 'MFR.FileSystem.Factories.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Factories-Actions-Does'></a>
## Does `type`

##### Namespace

MFR.FileSystem.Factories.Actions

##### Summary

Determines whether data meets certain conditions.

<a name='M-MFR-FileSystem-Factories-Actions-Does-FileExist-System-String-'></a>
### FileExist(pathname) `method`

##### Summary

Determines whether the file having the specified `pathname`
exists.

##### Returns

`true` if the `pathname` refers to
a file and the file exists; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file to check. |

<a name='M-MFR-FileSystem-Factories-Actions-Does-FileSystemEntryExist-System-String-'></a>
### FileSystemEntryExist(pathname) `method`

##### Summary

Determines whether the file system entry having the specified
`pathname` exists.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Remarks

Use this method when you have no way of telling, in your code, whether
the file system entry having the specified `pathname` is a
folder or a file.



This method does the exists check for either a file or a folder having the
specified `pathname`; if either check returns
`true`, then this check returns `true` as
well.



This method returns the result of performing a bitwise OR operation on the
results of the [FileExist](#M-MFR-FileSystem-Factories-Actions-Does-FileExist 'MFR.FileSystem.Factories.Actions.Does.FileExist')
and [FolderExist](#M-MFR-FileSystem-Factories-Actions-Does-FolderExist 'MFR.FileSystem.Factories.Actions.Does.FolderExist') methods.



If a blank or `null`[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') is passed
as the argument of the `pathname` parameter, then this method
returns `false`.

<a name='M-MFR-FileSystem-Factories-Actions-Does-FolderExist-System-String-'></a>
### FolderExist(pathname) `method`

##### Summary

Determines whether the folder having the specified `pathname`
exists.

##### Returns

`true` if the `pathname` refers to
a folder and the folder exists; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a folder to check. |

<a name='T-MFR-FileSystem-Factories-Actions-Is'></a>
## Is `type`

##### Namespace

MFR.FileSystem.Factories.Actions

##### Summary

Exposes static methods to determine whether certain conditions are met by data.

<a name='M-MFR-FileSystem-Factories-Actions-Is-Folder-System-String-'></a>
### Folder(pathname) `method`

##### Summary

Determines whether the file system entry having the specified
`pathname` is a folder or not.

##### Returns

`true` if the file system entry having the specified
`pathname` is a folder; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the fully-qualified pathname of the file system entry to be checked. |

<a name='T-MFR-FileSystem-Factories-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Factories.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Factories-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Factories-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
