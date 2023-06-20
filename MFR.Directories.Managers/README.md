<a name='assembly'></a>
# MFR.Directories.Managers

## Contents

- [Resources](#T-MFR-Directories-Managers-Properties-Resources 'MFR.Directories.Managers.Properties.Resources')
  - [Culture](#P-MFR-Directories-Managers-Properties-Resources-Culture 'MFR.Directories.Managers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Managers-Properties-Resources-ResourceManager 'MFR.Directories.Managers.Properties.Resources.ResourceManager')
- [SearchDirectoryManager](#T-MFR-Directories-Managers-SearchDirectoryManager 'MFR.Directories.Managers.SearchDirectoryManager')
  - [#ctor()](#M-MFR-Directories-Managers-SearchDirectoryManager-#ctor 'MFR.Directories.Managers.SearchDirectoryManager.#ctor')
  - [Instance](#P-MFR-Directories-Managers-SearchDirectoryManager-Instance 'MFR.Directories.Managers.SearchDirectoryManager.Instance')
  - [#cctor()](#M-MFR-Directories-Managers-SearchDirectoryManager-#cctor 'MFR.Directories.Managers.SearchDirectoryManager.#cctor')
  - [GetSearchDirectories(pathname)](#M-MFR-Directories-Managers-SearchDirectoryManager-GetSearchDirectories-System-String,System-Predicate{System-String}- 'MFR.Directories.Managers.SearchDirectoryManager.GetSearchDirectories(System.String,System.Predicate{System.String})')

<a name='T-MFR-Directories-Managers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Directories.Managers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Directories-Managers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Directories-Managers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Directories-Managers-SearchDirectoryManager'></a>
## SearchDirectoryManager `type`

##### Namespace

MFR.Directories.Managers

##### Summary

Manages the search folders for performing the operations requested by the user
to rename projects, files, and folders.

<a name='M-MFR-Directories-Managers-SearchDirectoryManager-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Directories-Managers-SearchDirectoryManager-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[ISearchDirectoryManager](#T-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager 'MFR.Directories.Managers.Interfaces.ISearchDirectoryManager')
interface.

<a name='M-MFR-Directories-Managers-SearchDirectoryManager-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Directories-Managers-SearchDirectoryManager-GetSearchDirectories-System-String,System-Predicate{System-String}-'></a>
### GetSearchDirectories(pathname) `method`

##### Summary

Scans the folder having the specified `pathname` for Visual
Studio Solution (`*.sln`) files and then builds the list in the
[SearchDirectories](#P-MFR-Directories-Managers-SearchDirectoryManager-SearchDirectories 'MFR.Directories.Managers.SearchDirectoryManager.SearchDirectories')
property of all the folders under the folder having the specified
`pathname` that contain Visual Studio Solution (`*.sln`)
files.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a folder to scan for Visual Studio Solution (`*.sln`) files. |
