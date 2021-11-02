<a name='assembly'></a>
# MFR.Managers.RootFolders.Tests

## Contents

- [Resources](#T-MFR-Managers-RootFolders-Tests-Properties-Resources 'MFR.Managers.RootFolders.Tests.Properties.Resources')
  - [Culture](#P-MFR-Managers-RootFolders-Tests-Properties-Resources-Culture 'MFR.Managers.RootFolders.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Managers-RootFolders-Tests-Properties-Resources-ResourceManager 'MFR.Managers.RootFolders.Tests.Properties.Resources.ResourceManager')
- [RootFolderPathManagerTests](#T-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests')
  - [DUMMY_FOLDER](#F-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-DUMMY_FOLDER 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.DUMMY_FOLDER')
  - [RootFolderPathManager](#P-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-RootFolderPathManager 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.RootFolderPathManager')
  - [Initialize()](#M-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-Initialize 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.Initialize')
  - [OnRootFolderPathManagerRootFolderAdded(sender,e)](#M-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-OnRootFolderPathManagerRootFolderAdded-System-Object,MFR-Managers-RootFolders-Events-RootFolderAddedEventArgs- 'MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.OnRootFolderPathManagerRootFolderAdded(System.Object,MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs)')
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

<a name='P-MFR-Managers-RootFolders-Tests-RootFolderPathManagerTests-RootFolderPathManager'></a>
### RootFolderPathManager `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IRootFolderPathManager](#T-MFR-Managers-RootFolders-Interfaces-IRootFolderPathManager 'MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager')
interface.

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
