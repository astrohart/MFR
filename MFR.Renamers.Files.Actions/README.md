<a name='assembly'></a>
# MFR.Renamers.Files.Actions

## Contents

- [Delete](#T-MFR-Renamers-Files-Actions-Delete 'MFR.Renamers.Files.Actions.Delete')
  - [File(pathname)](#M-MFR-Renamers-Files-Actions-Delete-File-System-String- 'MFR.Renamers.Files.Actions.Delete.File(System.String)')
- [Resources](#T-MFR-Renamers-Files-Actions-Properties-Resources 'MFR.Renamers.Files.Actions.Properties.Resources')
  - [Culture](#P-MFR-Renamers-Files-Actions-Properties-Resources-Culture 'MFR.Renamers.Files.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Renamers-Files-Actions-Properties-Resources-ResourceManager 'MFR.Renamers.Files.Actions.Properties.Resources.ResourceManager')
- [Write](#T-MFR-Renamers-Files-Actions-Write 'MFR.Renamers.Files.Actions.Write')
  - [FileContent(path,contents)](#M-MFR-Renamers-Files-Actions-Write-FileContent-System-String,System-String- 'MFR.Renamers.Files.Actions.Write.FileContent(System.String,System.String)')

<a name='T-MFR-Renamers-Files-Actions-Delete'></a>
## Delete `type`

##### Namespace

MFR.Renamers.Files.Actions

##### Summary

Exposes static methods to delete data.

<a name='M-MFR-Renamers-Files-Actions-Delete-File-System-String-'></a>
### File(pathname) `method`

##### Summary

If it exists, deletes the file having the specified
`pathname`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file that is to be deleted from the disk. |

##### Remarks

If the file having the specified `pathname` does not
exist, then this method does nothing.

<a name='T-MFR-Renamers-Files-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Renamers.Files.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Renamers-Files-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Renamers-Files-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Renamers-Files-Actions-Write'></a>
## Write `type`

##### Namespace

MFR.Renamers.Files.Actions

##### Summary

Exposes static methods to write data, e.g., to files or other data sources.

<a name='M-MFR-Renamers-Files-Actions-Write-FileContent-System-String,System-String-'></a>
### FileContent(path,contents) `method`

##### Summary

Writes the specified `contents` to the file having the
specified `path`.



If the file already exists, then it is deleted.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file to be written to the disk. |
| contents | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the contents of the new
file. |
