<a name='assembly'></a>
# MFR.FileSystem.Creators

## Contents

- [Create](#T-MFR-FileSystem-Creators-Create 'MFR.FileSystem.Creators.Create')
  - [Folder(path)](#M-MFR-FileSystem-Creators-Create-Folder-System-String- 'MFR.FileSystem.Creators.Create.Folder(System.String)')
- [Resources](#T-MFR-FileSystem-Creators-Properties-Resources 'MFR.FileSystem.Creators.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Creators-Properties-Resources-Culture 'MFR.FileSystem.Creators.Properties.Resources.Culture')
  - [Error_ValueCannotBeNullOrWhiteSpace](#P-MFR-FileSystem-Creators-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace 'MFR.FileSystem.Creators.Properties.Resources.Error_ValueCannotBeNullOrWhiteSpace')
  - [ResourceManager](#P-MFR-FileSystem-Creators-Properties-Resources-ResourceManager 'MFR.FileSystem.Creators.Properties.Resources.ResourceManager')
- [Verify](#T-MFR-FileSystem-Creators-Verify 'MFR.FileSystem.Creators.Verify')
  - [FolderWasCreated(containingFolderName)](#M-MFR-FileSystem-Creators-Verify-FolderWasCreated-System-String- 'MFR.FileSystem.Creators.Verify.FolderWasCreated(System.String)')

<a name='T-MFR-FileSystem-Creators-Create'></a>
## Create `type`

##### Namespace

MFR.FileSystem.Creators

##### Summary

Methods to fluently create file system items.

<a name='M-MFR-FileSystem-Creators-Create-Folder-System-String-'></a>
### Folder(path) `method`

##### Summary

Creates a folder at the specified `path`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname
of the folder you wish to create. |

##### Remarks

If an I/O exception is thrown during the operation, then it is written to the
log or the console.



Otherwise, if the `path` parameter is passed a
`null` or blank value, then this method does nothing.

<a name='T-MFR-FileSystem-Creators-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Creators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Creators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Creators-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace'></a>
### Error_ValueCannotBeNullOrWhiteSpace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or whitespace..

<a name='P-MFR-FileSystem-Creators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-FileSystem-Creators-Verify'></a>
## Verify `type`

##### Namespace

MFR.FileSystem.Creators

##### Summary

Methods to assert that file system entries satisfy certain conditions, or else.

<a name='M-MFR-FileSystem-Creators-Verify-FolderWasCreated-System-String-'></a>
### FolderWasCreated(containingFolderName) `method`

##### Summary

Insists that the folder whose path is provided in the parameter
`containingFolderName` exists.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| containingFolderName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the path to the folder whose existence on the
disk is to be verified. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`containingFolderName`, is passed a blank or
`null` string for a value. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the folder whose path is `containingFolderName`
does not exist on the file system when it is supposed to. |
