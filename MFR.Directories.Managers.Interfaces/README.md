<a name='assembly'></a>
# MFR.Directories.Managers.Interfaces

## Contents

- [ISearchDirectoryManager](#T-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager 'MFR.Directories.Managers.Interfaces.ISearchDirectoryManager')
  - [SearchDirectories](#P-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager-SearchDirectories 'MFR.Directories.Managers.Interfaces.ISearchDirectoryManager.SearchDirectories')
  - [Clear()](#M-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager-Clear 'MFR.Directories.Managers.Interfaces.ISearchDirectoryManager.Clear')
  - [Search(pathname)](#M-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager-Search-System-String,System-Predicate{System-String}- 'MFR.Directories.Managers.Interfaces.ISearchDirectoryManager.Search(System.String,System.Predicate{System.String})')
- [Resources](#T-MFR-Directories-Managers-Interfaces-Properties-Resources 'MFR.Directories.Managers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Directories-Managers-Interfaces-Properties-Resources-Culture 'MFR.Directories.Managers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Managers-Interfaces-Properties-Resources-ResourceManager 'MFR.Directories.Managers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager'></a>
## ISearchDirectoryManager `type`

##### Namespace

MFR.Directories.Managers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that manages
the search folders for performing the operations requested by the user to
rename projects, files, and folders.

<a name='P-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager-SearchDirectories'></a>
### SearchDirectories `property`

##### Summary

Gets a collection of fully-qualified pathnames of folders found by this object, that
should be searched for projects, files, and folders whose names should be
changed.

<a name='M-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager-Clear'></a>
### Clear() `method`

##### Summary

Clears the list of search folders.

##### Parameters

This method has no parameters.

<a name='M-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager-Search-System-String,System-Predicate{System-String}-'></a>
### Search(pathname) `method`

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

##### Remarks

After this method executes, callers can access the
[SearchDirectories](#P-MFR-Directories-Managers-SearchDirectoryManager-SearchDirectories 'MFR.Directories.Managers.SearchDirectoryManager.SearchDirectories')
property in order to access the list of folders that was retrieved.

<a name='T-MFR-Directories-Managers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Directories.Managers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Directories-Managers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Directories-Managers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
