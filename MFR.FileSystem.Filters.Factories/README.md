<a name='assembly'></a>
# MFR.FileSystem.Filters.Factories

## Contents

- [Folder](#T-MFR-FileSystem-Filters-Factories-Folder 'MFR.FileSystem.Filters.Factories.Folder')
  - [HavingPath(path)](#M-MFR-FileSystem-Filters-Factories-Folder-HavingPath-System-String- 'MFR.FileSystem.Filters.Factories.Folder.HavingPath(System.String)')
- [Resources](#T-MFR-FileSystem-Filters-Factories-Properties-Resources 'MFR.FileSystem.Filters.Factories.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Filters-Factories-Properties-Resources-Culture 'MFR.FileSystem.Filters.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Filters-Factories-Properties-Resources-ResourceManager 'MFR.FileSystem.Filters.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Filters-Factories-Folder'></a>
## Folder `type`

##### Namespace

MFR.FileSystem.Filters.Factories

##### Summary

Creates new instances of objects that implement the
[IFolderFilter](#T-MFR-FileSystem-Filters-Interfaces-IFolderFilter 'MFR.FileSystem.Filters.Interfaces.IFolderFilter') interface.

##### Remarks

Such an object has the ability to determine whether certain facts are
true about folders and files.

<a name='M-MFR-FileSystem-Filters-Factories-Folder-HavingPath-System-String-'></a>
### HavingPath(path) `method`

##### Summary

Creates a new instance of an object that implements the
[IFolderFilter](#T-MFR-FileSystem-Filters-Interfaces-IFolderFilter 'MFR.FileSystem.Filters.Interfaces.IFolderFilter') interface and
returns a reference to it.



The folder filter object obtained is set to search in the specified
`path`.

##### Returns

Reference to an instance of an object that implements the
[IFolderFilter](#T-MFR-FileSystem-Filters-Interfaces-IFolderFilter 'MFR.FileSystem.Filters.Interfaces.IFolderFilter') interface that
can be used for searching.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname
of the folder to be searched. |

<a name='T-MFR-FileSystem-Filters-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Filters.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Filters-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Filters-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
