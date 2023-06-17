<a name='assembly'></a>
# MFR.FileSystem.Retrievers.Factories

## Contents

- [GetFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Factories-GetFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Factories.GetFileSystemEntryListRetriever')
  - [For(type)](#M-MFR-FileSystem-Retrievers-Factories-GetFileSystemEntryListRetriever-For-MFR-Operations-Constants-OperationType- 'MFR.FileSystem.Retrievers.Factories.GetFileSystemEntryListRetriever.For(MFR.Operations.Constants.OperationType)')
- [GetFilesToRenameRetriever](#T-MFR-FileSystem-Retrievers-Factories-GetFilesToRenameRetriever 'MFR.FileSystem.Retrievers.Factories.GetFilesToRenameRetriever')
  - [SoleInstance()](#M-MFR-FileSystem-Retrievers-Factories-GetFilesToRenameRetriever-SoleInstance 'MFR.FileSystem.Retrievers.Factories.GetFilesToRenameRetriever.SoleInstance')
- [GetFolderToRenameRetriever](#T-MFR-FileSystem-Retrievers-Factories-GetFolderToRenameRetriever 'MFR.FileSystem.Retrievers.Factories.GetFolderToRenameRetriever')
  - [SoleInstance()](#M-MFR-FileSystem-Retrievers-Factories-GetFolderToRenameRetriever-SoleInstance 'MFR.FileSystem.Retrievers.Factories.GetFolderToRenameRetriever.SoleInstance')
- [GetSolutionFilePathRetriever](#T-MFR-FileSystem-Retrievers-Factories-GetSolutionFilePathRetriever 'MFR.FileSystem.Retrievers.Factories.GetSolutionFilePathRetriever')
  - [SoleInstance()](#M-MFR-FileSystem-Retrievers-Factories-GetSolutionFilePathRetriever-SoleInstance 'MFR.FileSystem.Retrievers.Factories.GetSolutionFilePathRetriever.SoleInstance')
- [GetSolutionFoldersToRenameRetriever](#T-MFR-FileSystem-Retrievers-Factories-GetSolutionFoldersToRenameRetriever 'MFR.FileSystem.Retrievers.Factories.GetSolutionFoldersToRenameRetriever')
  - [SoleInstance()](#M-MFR-FileSystem-Retrievers-Factories-GetSolutionFoldersToRenameRetriever-SoleInstance 'MFR.FileSystem.Retrievers.Factories.GetSolutionFoldersToRenameRetriever.SoleInstance')
- [GetTextInFilesRetriever](#T-MFR-FileSystem-Retrievers-Factories-GetTextInFilesRetriever 'MFR.FileSystem.Retrievers.Factories.GetTextInFilesRetriever')
  - [SoleInstance()](#M-MFR-FileSystem-Retrievers-Factories-GetTextInFilesRetriever-SoleInstance 'MFR.FileSystem.Retrievers.Factories.GetTextInFilesRetriever.SoleInstance')
- [Resources](#T-MFR-FileSystem-Retrievers-Factories-Properties-Resources 'MFR.FileSystem.Retrievers.Factories.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Retrievers-Factories-Properties-Resources-Culture 'MFR.FileSystem.Retrievers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Retrievers-Factories-Properties-Resources-ResourceManager 'MFR.FileSystem.Retrievers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Retrievers-Factories-GetFileSystemEntryListRetriever'></a>
## GetFileSystemEntryListRetriever `type`

##### Namespace

MFR.FileSystem.Retrievers.Factories

##### Summary

Creates instances of objects that implement the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Interfaces.IFileSystemEntryListRetriever')
interface.

##### Remarks

These objects enumerate objects on the file system according to search
criteria specified by the user.

<a name='M-MFR-FileSystem-Retrievers-Factories-GetFileSystemEntryListRetriever-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates a new instance of an object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface that corresponds to the specified `type`
of operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) A
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
value that
corresponds to the type of operation currently being performed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if there is no object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface available that corresponds to the specified operation
`type`. |

<a name='T-MFR-FileSystem-Retrievers-Factories-GetFilesToRenameRetriever'></a>
## GetFilesToRenameRetriever `type`

##### Namespace

MFR.FileSystem.Retrievers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface that globs a directory tree for the set of all files that must be
renamed because their filenames match a search pattern that is defined by the
user.

<a name='M-MFR-FileSystem-Retrievers-Factories-GetFilesToRenameRetriever-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface that globs a directory tree for the set of all files that must be
renamed because their filenames match a search pattern that is defined by the
user.

##### Parameters

This method has no parameters.

<a name='T-MFR-FileSystem-Retrievers-Factories-GetFolderToRenameRetriever'></a>
## GetFolderToRenameRetriever `type`

##### Namespace

MFR.FileSystem.Retrievers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface that obtains a list of all those folders in a directory tree whose
names match a search pattern that is specified by the user for the renaming
process.

<a name='M-MFR-FileSystem-Retrievers-Factories-GetFolderToRenameRetriever-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface that obtains a list of all those folders in a directory tree whose
names match a search pattern that is specified by the user for the renaming
process.

##### Parameters

This method has no parameters.

<a name='T-MFR-FileSystem-Retrievers-Factories-GetSolutionFilePathRetriever'></a>
## GetSolutionFilePathRetriever `type`

##### Namespace

MFR.FileSystem.Retrievers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface that searches a particular directory tree of the file system for the
pathnames of any Visual Studio Solution (`*.sln`) files that may be
present within it.

<a name='M-MFR-FileSystem-Retrievers-Factories-GetSolutionFilePathRetriever-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface that searches a particular directory tree of the file system for the
pathnames of any Visual Studio Solution (`*.sln`) files that may be
present within it.

##### Parameters

This method has no parameters.

<a name='T-MFR-FileSystem-Retrievers-Factories-GetSolutionFoldersToRenameRetriever'></a>
## GetSolutionFoldersToRenameRetriever `type`

##### Namespace

MFR.FileSystem.Retrievers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface that searches a directory tree specified by the user in order to find
a list of the folder(s) containing Visual Studio Solution (`*.sln`) files.



These are folders that must be renamed according to the text-replacement
parameters specified by the user.

<a name='M-MFR-FileSystem-Retrievers-Factories-GetSolutionFoldersToRenameRetriever-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface that searches a directory tree specified by the user in order to find
a list of the folder(s) containing Visual Studio Solution (`*.sln`) files.



These are folders that must be renamed according to the text-replacement
parameters specified by the user.

##### Parameters

This method has no parameters.

<a name='T-MFR-FileSystem-Retrievers-Factories-GetTextInFilesRetriever'></a>
## GetTextInFilesRetriever `type`

##### Namespace

MFR.FileSystem.Retrievers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface that represents an object that is capable of retrieving the list of
all those files on the filesystem that contain a specific text pattern.

<a name='M-MFR-FileSystem-Retrievers-Factories-GetTextInFilesRetriever-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface that represents an object that is capable of retrieving the list of
all those files on the filesystem that contain a specific text pattern.

##### Parameters

This method has no parameters.

<a name='T-MFR-FileSystem-Retrievers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Retrievers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Retrievers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Retrievers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
