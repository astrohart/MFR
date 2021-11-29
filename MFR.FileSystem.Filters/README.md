<a name='assembly'></a>
# MFR.FileSystem.Filters

## Contents

- [FolderFilter](#T-MFR-FileSystem-Filters-FolderFilter 'MFR.FileSystem.Filters.FolderFilter')
  - [#ctor(searchPath)](#M-MFR-FileSystem-Filters-FolderFilter-#ctor-System-String- 'MFR.FileSystem.Filters.FolderFilter.#ctor(System.String)')
  - [Contains](#P-MFR-FileSystem-Filters-FolderFilter-Contains 'MFR.FileSystem.Filters.FolderFilter.Contains')
  - [SearchPath](#P-MFR-FileSystem-Filters-FolderFilter-SearchPath 'MFR.FileSystem.Filters.FolderFilter.SearchPath')
  - [File(pathPart)](#M-MFR-FileSystem-Filters-FolderFilter-File-System-String- 'MFR.FileSystem.Filters.FolderFilter.File(System.String)')
  - [Folder(pathPart)](#M-MFR-FileSystem-Filters-FolderFilter-Folder-System-String- 'MFR.FileSystem.Filters.FolderFilter.Folder(System.String)')
- [Resources](#T-MFR-FileSystem-Filters-Properties-Resources 'MFR.FileSystem.Filters.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Filters-Properties-Resources-Culture 'MFR.FileSystem.Filters.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Filters-Properties-Resources-ResourceManager 'MFR.FileSystem.Filters.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Filters-FolderFilter'></a>
## FolderFilter `type`

##### Namespace

MFR.FileSystem.Filters

##### Summary

Object that implements the
[IFolderFilter](#T-MFR-FileSystem-Filters-Interfaces-IFolderFilter 'MFR.FileSystem.Filters.Interfaces.IFolderFilter') interface.



This object allows us to decide whether certain facts are true or not about
specific files and folders.

<a name='M-MFR-FileSystem-Filters-FolderFilter-#ctor-System-String-'></a>
### #ctor(searchPath) `constructor`

##### Summary

Constructs a new instance of
[FolderFilter](#T-MFR-FileSystem-Filters-FolderFilter 'MFR.FileSystem.Filters.FolderFilter') and returns a reference to
it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| searchPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String that contains the fully-qualified
pathname of the folder to be searched. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`searchPath`, is passed a blank or `null`
string for a value. |

<a name='P-MFR-FileSystem-Filters-FolderFilter-Contains'></a>
### Contains `property`

##### Summary

Gets a reference to this object instance.

##### Remarks

This property is here to maintain method call semantics.

<a name='P-MFR-FileSystem-Filters-FolderFilter-SearchPath'></a>
### SearchPath `property`

##### Summary

Gets or sets a string that contains the fully-qualified pathname of the
directory to be searched for a file or a folder.

<a name='M-MFR-FileSystem-Filters-FolderFilter-File-System-String-'></a>
### File(pathPart) `method`

##### Summary

Determines whether the
[SearchPath](#P-MFR-FileSystem-Filters-FolderFilter-SearchPath 'MFR.FileSystem.Filters.FolderFilter.SearchPath').

##### Returns

`true` if the exists at the complete path;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathPart | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the part of the path to
search for. |

<a name='M-MFR-FileSystem-Filters-FolderFilter-Folder-System-String-'></a>
### Folder(pathPart) `method`

##### Summary

Determines whether the
[SearchPath](#P-MFR-FileSystem-Filters-FolderFilter-SearchPath 'MFR.FileSystem.Filters.FolderFilter.SearchPath').

##### Returns

`true` if the folder contains the path;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathPart | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the part of the path to
search for. |

<a name='T-MFR-FileSystem-Filters-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Filters.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Filters-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Filters-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
