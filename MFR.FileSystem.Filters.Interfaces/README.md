<a name='assembly'></a>
# MFR.FileSystem.Filters.Interfaces

## Contents

- [IFolderFilter](#T-MFR-FileSystem-Filters-Interfaces-IFolderFilter 'MFR.FileSystem.Filters.Interfaces.IFolderFilter')
  - [Contains](#P-MFR-FileSystem-Filters-Interfaces-IFolderFilter-Contains 'MFR.FileSystem.Filters.Interfaces.IFolderFilter.Contains')
  - [SearchPath](#P-MFR-FileSystem-Filters-Interfaces-IFolderFilter-SearchPath 'MFR.FileSystem.Filters.Interfaces.IFolderFilter.SearchPath')
  - [File(pathPart)](#M-MFR-FileSystem-Filters-Interfaces-IFolderFilter-File-System-String- 'MFR.FileSystem.Filters.Interfaces.IFolderFilter.File(System.String)')
  - [Folder(pathPart)](#M-MFR-FileSystem-Filters-Interfaces-IFolderFilter-Folder-System-String- 'MFR.FileSystem.Filters.Interfaces.IFolderFilter.Folder(System.String)')
- [Resources](#T-MFR-FileSystem-Filters-Interfaces-Properties-Resources 'MFR.FileSystem.Filters.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Filters-Interfaces-Properties-Resources-Culture 'MFR.FileSystem.Filters.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Filters-Interfaces-Properties-Resources-ResourceManager 'MFR.FileSystem.Filters.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Filters-Interfaces-IFolderFilter'></a>
## IFolderFilter `type`

##### Namespace

MFR.FileSystem.Filters.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that
determines whether facts are true about files and folders.

<a name='P-MFR-FileSystem-Filters-Interfaces-IFolderFilter-Contains'></a>
### Contains `property`

##### Summary

Gets a reference to this object instance.

##### Remarks

This property is here to maintain method call semantics.

<a name='P-MFR-FileSystem-Filters-Interfaces-IFolderFilter-SearchPath'></a>
### SearchPath `property`

##### Summary

Gets or sets a string that contains the fully-qualified pathname of the
directory to be searched for a file or a folder.

<a name='M-MFR-FileSystem-Filters-Interfaces-IFolderFilter-File-System-String-'></a>
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

<a name='M-MFR-FileSystem-Filters-Interfaces-IFolderFilter-Folder-System-String-'></a>
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

<a name='T-MFR-FileSystem-Filters-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Filters.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Filters-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Filters-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
