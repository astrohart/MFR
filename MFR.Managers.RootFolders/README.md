<a name='assembly'></a>
# MFR.Managers.RootFolders

## Contents

- [Resources](#T-MFR-Managers-RootFolders-Properties-Resources 'MFR.Managers.RootFolders.Properties.Resources')
  - [Culture](#P-MFR-Managers-RootFolders-Properties-Resources-Culture 'MFR.Managers.RootFolders.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Managers-RootFolders-Properties-Resources-ResourceManager 'MFR.Managers.RootFolders.Properties.Resources.ResourceManager')
- [RootFolderPathManager](#T-MFR-Managers-RootFolders-RootFolderPathManager 'MFR.Managers.RootFolders.RootFolderPathManager')
  - [#ctor()](#M-MFR-Managers-RootFolders-RootFolderPathManager-#ctor 'MFR.Managers.RootFolders.RootFolderPathManager.#ctor')
  - [Count](#P-MFR-Managers-RootFolders-RootFolderPathManager-Count 'MFR.Managers.RootFolders.RootFolderPathManager.Count')
  - [Instance](#P-MFR-Managers-RootFolders-RootFolderPathManager-Instance 'MFR.Managers.RootFolders.RootFolderPathManager.Instance')
  - [RootFolders](#P-MFR-Managers-RootFolders-RootFolderPathManager-RootFolders 'MFR.Managers.RootFolders.RootFolderPathManager.RootFolders')
  - [#cctor()](#M-MFR-Managers-RootFolders-RootFolderPathManager-#cctor 'MFR.Managers.RootFolders.RootFolderPathManager.#cctor')
  - [AddAll(folders)](#M-MFR-Managers-RootFolders-RootFolderPathManager-AddAll-System-Collections-Generic-IEnumerable{System-String}- 'MFR.Managers.RootFolders.RootFolderPathManager.AddAll(System.Collections.Generic.IEnumerable{System.String})')
  - [AddFolderIfItContainsASolution(path)](#M-MFR-Managers-RootFolders-RootFolderPathManager-AddFolderIfItContainsASolution-System-String- 'MFR.Managers.RootFolders.RootFolderPathManager.AddFolderIfItContainsASolution(System.String)')
  - [AddSolutionSubFoldersOf(path)](#M-MFR-Managers-RootFolders-RootFolderPathManager-AddSolutionSubFoldersOf-System-String- 'MFR.Managers.RootFolders.RootFolderPathManager.AddSolutionSubFoldersOf(System.String)')
  - [AddSubFoldersOf(path)](#M-MFR-Managers-RootFolders-RootFolderPathManager-AddSubFoldersOf-System-String- 'MFR.Managers.RootFolders.RootFolderPathManager.AddSubFoldersOf(System.String)')
  - [Clear()](#M-MFR-Managers-RootFolders-RootFolderPathManager-Clear 'MFR.Managers.RootFolders.RootFolderPathManager.Clear')
  - [GetAll()](#M-MFR-Managers-RootFolders-RootFolderPathManager-GetAll 'MFR.Managers.RootFolders.RootFolderPathManager.GetAll')
  - [GetAllSubFoldersThatContainSolutionsIn(path)](#M-MFR-Managers-RootFolders-RootFolderPathManager-GetAllSubFoldersThatContainSolutionsIn-System-String- 'MFR.Managers.RootFolders.RootFolderPathManager.GetAllSubFoldersThatContainSolutionsIn(System.String)')
  - [GetSubFoldersOf(path)](#M-MFR-Managers-RootFolders-RootFolderPathManager-GetSubFoldersOf-System-String- 'MFR.Managers.RootFolders.RootFolderPathManager.GetSubFoldersOf(System.String)')
  - [OnRootFolderAdded(e)](#M-MFR-Managers-RootFolders-RootFolderPathManager-OnRootFolderAdded-MFR-Managers-RootFolders-Events-RootFolderAddedEventArgs- 'MFR.Managers.RootFolders.RootFolderPathManager.OnRootFolderAdded(MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs)')
  - [OnRootFolderRemoved(e)](#M-MFR-Managers-RootFolders-RootFolderPathManager-OnRootFolderRemoved-MFR-Managers-RootFolders-Events-RootFolderRemovedEventArgs- 'MFR.Managers.RootFolders.RootFolderPathManager.OnRootFolderRemoved(MFR.Managers.RootFolders.Events.RootFolderRemovedEventArgs)')
  - [RemoveAll(folders)](#M-MFR-Managers-RootFolders-RootFolderPathManager-RemoveAll-System-Collections-Generic-IEnumerable{System-String}- 'MFR.Managers.RootFolders.RootFolderPathManager.RemoveAll(System.Collections.Generic.IEnumerable{System.String})')
  - [RemoveSolutionSubFoldersOf(path)](#M-MFR-Managers-RootFolders-RootFolderPathManager-RemoveSolutionSubFoldersOf-System-String- 'MFR.Managers.RootFolders.RootFolderPathManager.RemoveSolutionSubFoldersOf(System.String)')
  - [RemoveSubFoldersOf(path)](#M-MFR-Managers-RootFolders-RootFolderPathManager-RemoveSubFoldersOf-System-String- 'MFR.Managers.RootFolders.RootFolderPathManager.RemoveSubFoldersOf(System.String)')

<a name='T-MFR-Managers-RootFolders-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Managers.RootFolders.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Managers-RootFolders-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Managers-RootFolders-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Managers-RootFolders-RootFolderPathManager'></a>
## RootFolderPathManager `type`

##### Namespace

MFR.Managers.RootFolders

##### Summary

Class to manage a collection of root folder paths to iterate over, processing
the find/replace operations for all folders listed in the collection.

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Managers-RootFolders-RootFolderPathManager-Count'></a>
### Count `property`

##### Summary

Gets a count of the root folder pathnames stored in the collection.

<a name='P-MFR-Managers-RootFolders-RootFolderPathManager-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[RootFolderPathManager](#T-MFR-Managers-RootFolders-RootFolderPathManager 'MFR.Managers.RootFolders.RootFolderPathManager').

<a name='P-MFR-Managers-RootFolders-RootFolderPathManager-RootFolders'></a>
### RootFolders `property`

##### Summary

Gets a reference to a collection of instances of objects that implement the
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') interface.



Each object plays the role of a folder from which the operation(s) that are
selected by the user start processing from.

##### Remarks

A [HashSet](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet 'System.Collections.Generic.HashSet') is used as the
implementation of this property.



The [HashSet](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet 'System.Collections.Generic.HashSet') collection is designed
to not allow/list out duplicate entries by default.

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-AddAll-System-Collections-Generic-IEnumerable{System-String}-'></a>
### AddAll(folders) `method`

##### Summary

Adds all the strings in the `folders` collection to the
internal collection that is managed by this class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folders | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | (Required.) Reference to an enumerable collection of
strings, each of which is assumed to be a folder. |

##### Remarks

If all of the strings in the collection passed are not the paths of folders
that exist, then this method does nothing.

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-AddFolderIfItContainsASolution-System-String-'></a>
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

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-AddSolutionSubFoldersOf-System-String-'></a>
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

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-AddSubFoldersOf-System-String-'></a>
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

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-Clear'></a>
### Clear() `method`

##### Summary

Clears all elements from the internal collection that this object manages.

##### Parameters

This method has no parameters.

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-GetAll'></a>
### GetAll() `method`

##### Summary

Obtains a reference to an enumerable collection of all the root folders that
this object manages.

##### Returns

Enumerable collection of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')s, all of which
are the pathname to a folder that exists and is where processing is to begin.

##### Parameters

This method has no parameters.

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-GetAllSubFoldersThatContainSolutionsIn-System-String-'></a>
### GetAllSubFoldersThatContainSolutionsIn(path) `method`

##### Summary

Retrieves a list of the top-level folders of the folder having the specified
`path`, the criteria for being in the set of returned strings
being that the folder must contain a file whose name ends with the `.sln`
extension.

##### Returns

Collection of strings containing the fully-qualified pathnames of all
top-level subfolders of the folder having the specified
`path` that contain at least one file whose name has the
extension `.sln`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) (Required.) String containing the
fully-qualified pathname of the folder whose subfolers are to be enumerated. |

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-GetSubFoldersOf-System-String-'></a>
### GetSubFoldersOf(path) `method`

##### Summary

Obtains a reference to a collection of strings that are the fully-qualified
pathnames of the subfolders of the folder having the specified
`path`, to the first level down only.

##### Returns

Collection of strings; this collection is the empty set if an error
occurs or the `path` parameter is blank, or whose value
refers to a folder that does not exist on the disk; otherwise, a collection of
strings containing the pathnames of all of the top-level subfolders of the
folder having the specified `path` is returned.



The empty collection is also returned if an I/O or other operating-system error
occurs during the execution of the search.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) (Required.) String containing the
fully-qualified pathname of the folder to start searching in. |

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-OnRootFolderAdded-MFR-Managers-RootFolders-Events-RootFolderAddedEventArgs-'></a>
### OnRootFolderAdded(e) `method`

##### Summary

Raises the
[](#E-MFR-Managers-RootFolders-RootFolderPathManager-RootFolderAdded 'MFR.Managers.RootFolders.RootFolderPathManager.RootFolderAdded')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs](#T-MFR-Managers-RootFolders-Events-RootFolderAddedEventArgs 'MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs') | A
[RootFolderAddedEventArgs](#T-MFR-Managers-RootFolders-Events-RootFolderAddedEventArgs 'MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs') that
contains the event data. |

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-OnRootFolderRemoved-MFR-Managers-RootFolders-Events-RootFolderRemovedEventArgs-'></a>
### OnRootFolderRemoved(e) `method`

##### Summary

Raises the
[](#E-MFR-Managers-RootFolders-RootFolderPathManager-RootFolderRemoved 'MFR.Managers.RootFolders.RootFolderPathManager.RootFolderRemoved')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Managers.RootFolders.Events.RootFolderRemovedEventArgs](#T-MFR-Managers-RootFolders-Events-RootFolderRemovedEventArgs 'MFR.Managers.RootFolders.Events.RootFolderRemovedEventArgs') | A
[RootFolderRemovedEventArgs](#T-MFR-Managers-RootFolders-Events-RootFolderRemovedEventArgs 'MFR.Managers.RootFolders.Events.RootFolderRemovedEventArgs')
that
contains the event data. |

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-RemoveAll-System-Collections-Generic-IEnumerable{System-String}-'></a>
### RemoveAll(folders) `method`

##### Summary

Removes all the strings in the `folders` collection from the
internal collection that is managed by this class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folders | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | (Required.) Reference to an enumerable collection of
strings, each of which is assumed to be a folder. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `folders`, is passed a `null`
value. |

##### Remarks

If all of the strings in the collection passed are not the paths of folders
that exist, then this method does nothing.

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-RemoveSolutionSubFoldersOf-System-String-'></a>
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

<a name='M-MFR-Managers-RootFolders-RootFolderPathManager-RemoveSubFoldersOf-System-String-'></a>
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
