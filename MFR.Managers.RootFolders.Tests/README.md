<a name='assembly'></a>
# MFR.Managers.RootFolders.Tests

## Contents

- [Resources](#T-MFR-Managers-RootFolders-Tests-Properties-Resources 'MFR.Managers.RootFolders.Tests.Properties.Resources')
  - [Culture](#P-MFR-Managers-RootFolders-Tests-Properties-Resources-Culture 'MFR.Managers.RootFolders.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Managers-RootFolders-Tests-Properties-Resources-ResourceManager 'MFR.Managers.RootFolders.Tests.Properties.Resources.ResourceManager')
- [RootFolderPathManagerTests](#T-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests')
  - [DUMMY_FOLDER](#F-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-DUMMY_FOLDER 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.DUMMY_FOLDER')
  - [DUMMY_FOLDER_THAT_CONTAINS_A_SINGLE_SOLUTION](#F-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-DUMMY_FOLDER_THAT_CONTAINS_A_SINGLE_SOLUTION 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.DUMMY_FOLDER_THAT_CONTAINS_A_SINGLE_SOLUTION')
  - [DUMMY_FOLDER_THAT_CONTAINS_SOLUTION_FOLDERS](#F-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-DUMMY_FOLDER_THAT_CONTAINS_SOLUTION_FOLDERS 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.DUMMY_FOLDER_THAT_CONTAINS_SOLUTION_FOLDERS')
  - [RootFolderPathManager](#P-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-RootFolderPathManager 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.RootFolderPathManager')
  - [GetAllSubFoldersThatContainSolutionsIn(path)](#M-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-GetAllSubFoldersThatContainSolutionsIn-System-String- 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.GetAllSubFoldersThatContainSolutionsIn(System.String)')
  - [GetSubFoldersOf(path)](#M-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-GetSubFoldersOf-System-String- 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.GetSubFoldersOf(System.String)')
  - [Initialize()](#M-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-Initialize 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.Initialize')
  - [OnRootFolderPathManagerRootFolderAdded(sender,e)](#M-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-OnRootFolderPathManagerRootFolderAdded-System-Object,MFR-Managers-RootFolders-Events-RootFolderAddedEventArgs- 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.OnRootFolderPathManagerRootFolderAdded(System.Object,MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs)')
  - [Test_AddSolutionSubFoldersOf_Method_Works()](#M-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-Test_AddSolutionSubFoldersOf_Method_Works 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.Test_AddSolutionSubFoldersOf_Method_Works')
  - [Test_AddSubFoldersOf_Method_Works()](#M-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-Test_AddSubFoldersOf_Method_Works 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.Test_AddSubFoldersOf_Method_Works')

<a name='T-MFR-Managers-RootFolders-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Managers.RootFolders.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Managers-RootFolders-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Managers-RootFolders-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests'></a>
## RootFolderPathManagerTests `type`

##### Namespace

MFR.Managers.RootFolders.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[RootFolderPathManager](#T-MFR-Managers-RootFolders-RootFolderPathManager 'MFR.Managers.RootFolders.RootFolderPathManager') class.

<a name='F-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-DUMMY_FOLDER'></a>
### DUMMY_FOLDER `constants`

##### Summary

String containing the path to a dummy folder.

<a name='F-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-DUMMY_FOLDER_THAT_CONTAINS_A_SINGLE_SOLUTION'></a>
### DUMMY_FOLDER_THAT_CONTAINS_A_SINGLE_SOLUTION `constants`

##### Summary

String containing the path to a dummy folder that is guaranteed to contain only
a single solution.

<a name='F-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-DUMMY_FOLDER_THAT_CONTAINS_SOLUTION_FOLDERS'></a>
### DUMMY_FOLDER_THAT_CONTAINS_SOLUTION_FOLDERS `constants`

##### Summary

String containing the path to a dummy folder.

<a name='P-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-RootFolderPathManager'></a>
### RootFolderPathManager `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IRootFolderPathManager](#T-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager 'MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager')
interface.

<a name='M-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-GetAllSubFoldersThatContainSolutionsIn-System-String-'></a>
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

<a name='M-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-GetSubFoldersOf-System-String-'></a>
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

<a name='M-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the state of this fixture for every unit test session.

##### Parameters

This method has no parameters.

<a name='M-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-OnRootFolderPathManagerRootFolderAdded-System-Object,MFR-Managers-RootFolders-Events-RootFolderAddedEventArgs-'></a>
### OnRootFolderPathManagerRootFolderAdded(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-RootFolderAdded 'MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager.RootFolderAdded')
event raised by the Root Folder Path Manager object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs](#T-MFR-Managers-RootFolders-Events-RootFolderAddedEventArgs 'MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs') | A
[RootFolderAddedEventArgs](#T-MFR-Managers-RootFolders-Events-RootFolderAddedEventArgs 'MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs') that
contains the event data. |

##### Remarks

This method responds by writing the pathname of the folder that has
been added to the manager's collection, to the console output.

<a name='M-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-Test_AddSolutionSubFoldersOf_Method_Works'></a>
### Test_AddSolutionSubFoldersOf_Method_Works() `method`

##### Summary

Asserts that the
[AddSolutionSubFoldersOf](#M-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager-AddSolutionSubFoldersOf 'MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager.AddSolutionSubFoldersOf')
method works properly.

##### Parameters

This method has no parameters.

<a name='M-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-Test_AddSubFoldersOf_Method_Works'></a>
### Test_AddSubFoldersOf_Method_Works() `method`

##### Summary

Asserts that the
[AddSubFoldersOf](#M-MFR-Managers-RootFolders-RootFolderPathManager-AddSubFoldersOf 'MFR.Managers.RootFolders.RootFolderPathManager.AddSubFoldersOf')
method works properly.



In this case, that it adds all the top-level folders of the
[DUMMY_FOLDER](#F-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-DUMMY_FOLDER 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.DUMMY_FOLDER')
to the list maintained by the
[RootFolderPathManager](#T-MFR-Managers-RootFolders-RootFolderPathManager 'MFR.Managers.RootFolders.RootFolderPathManager') object.

##### Parameters

This method has no parameters.
