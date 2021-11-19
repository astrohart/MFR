<a name='assembly'></a>
# MFR.Managers.RootFolders.Interfaces

## Contents

- [IRootFolderPathManager](#T-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager 'MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager')
  - [Count](#P-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-Count 'MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager.Count')
  - [AddFolderIfItContainsASolution(path)](#M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-AddFolderIfItContainsASolution-System-String- 'MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager.AddFolderIfItContainsASolution(System.String)')
  - [AddSolutionSubFoldersOf(path)](#M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-AddSolutionSubFoldersOf-System-String- 'MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager.AddSolutionSubFoldersOf(System.String)')
  - [AddSubFoldersOf(path)](#M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-AddSubFoldersOf-System-String- 'MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager.AddSubFoldersOf(System.String)')
  - [Clear()](#M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-Clear 'MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager.Clear')
  - [GetAll()](#M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-GetAll 'MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager.GetAll')
  - [RemoveSolutionSubFoldersOf(path)](#M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-RemoveSolutionSubFoldersOf-System-String- 'MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager.RemoveSolutionSubFoldersOf(System.String)')
  - [RemoveSubFoldersOf(path)](#M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-RemoveSubFoldersOf-System-String- 'MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager.RemoveSubFoldersOf(System.String)')
- [Resources](#T-MFR-Managers-RootFolders-Interfaces-Properties-Resources 'MFR.Managers.RootFolders.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Managers-RootFolders-Interfaces-Properties-Resources-Culture 'MFR.Managers.RootFolders.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Managers-RootFolders-Interfaces-Properties-Resources-ResourceManager 'MFR.Managers.RootFolders.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager'></a>
## IRootFolderPathManager `type`

##### Namespace

MFR.Managers.RootFolders.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that manages a
collection of the paths to the root folders from which to start the
operation(s) desired by the user.

<a name='P-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-Count'></a>
### Count `property`

##### Summary

Gets a count of the root folder pathnames stored in the collection.

<a name='M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-AddFolderIfItContainsASolution-System-String-'></a>
### AddFolderIfItContainsASolution(path) `method`

##### Summary

Adds a root folder path to this object's collection if, and only if, the folder
in question contains a file whose name ends with the `.sln` extension.

##### Returns

Number of entries added successfully.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) (Required.) String containing the
fully-qualified pathname to the folder whose subfolders should be added. |

<a name='M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-AddSolutionSubFoldersOf-System-String-'></a>
### AddSolutionSubFoldersOf(path) `method`

##### Summary

Adds a root folder path to this object's collection if, and only if, the folder
in question contains a file whose name ends with the `.sln` extension,
among the subfolders of the folder whose `path` is specified.

##### Returns

Number of entries added successfully.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) (Required.) String containing the
fully-qualified pathname to the folder whose subfolders should be added. |

<a name='M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-AddSubFoldersOf-System-String-'></a>
### AddSubFoldersOf(path) `method`

##### Summary

Adds the subfolder(s) of the folder having the specified path (except folders
such as `.vs`, `.git`, other dotfolder, and `packages` etc.) to
the collection that this object manages.



This method just uses the folders in the topmost level of the directory tree.

##### Returns

Number of entries added successfully.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required). String containing the fully-qualified pathname
of the folder whose subfolders should be added. |

<a name='M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-Clear'></a>
### Clear() `method`

##### Summary

Clears all elements from the internal collection that this object manages.

##### Parameters

This method has no parameters.

<a name='M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-GetAll'></a>
### GetAll() `method`

##### Summary

Obtains a reference to an enumerable collection of all the root folders that
this object manages.

##### Returns

Enumerable collection of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')s, all of which
are the pathname to a folder that exists and is where processing is to begin.

##### Parameters

This method has no parameters.

<a name='M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-RemoveSolutionSubFoldersOf-System-String-'></a>
### RemoveSolutionSubFoldersOf(path) `method`

##### Summary

Removes a root folder path from this object's collection if, and only if, the
folder
in question contains a file whose name ends with the `.sln` extension, and
it's
already a member of the internal collection.

##### Returns

Number of entries added successfully.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) (Required.) String containing the
fully-qualified pathname from the folder whose subfolders should be added. |

<a name='M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-RemoveSubFoldersOf-System-String-'></a>
### RemoveSubFoldersOf(path) `method`

##### Summary

Removes the subfolder(s) of the folder having the specified path (except
folders
such as `.vs`, `.git`, other dotfolder, and `packages` etc.)
from
the collection that this object manages.



This method just uses the folders in the topmost level of the directory tree.

##### Returns

Number of entries added successfully.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required). String containing the fully-qualified pathname
of the folder whose subfolders should be added. |

<a name='T-MFR-Managers-RootFolders-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Managers.RootFolders.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Managers-RootFolders-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Managers-RootFolders-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
