<a name='assembly'></a>
# MFR.Renamers.Files.Actions

## Contents

- [Cleanup](#T-MFR-Renamers-Files-Actions-Cleanup 'MFR.Renamers.Files.Actions.Cleanup')
  - [#cctor()](#M-MFR-Renamers-Files-Actions-Cleanup-#cctor 'MFR.Renamers.Files.Actions.Cleanup.#cctor')
  - [EmptyFileFolder(entry)](#M-MFR-Renamers-Files-Actions-Cleanup-EmptyFileFolder-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Renamers.Files.Actions.Cleanup.EmptyFileFolder(MFR.FileSystem.Interfaces.IFileSystemEntry)')
- [Delete](#T-MFR-Renamers-Files-Actions-Delete 'MFR.Renamers.Files.Actions.Delete')
  - [File(pathname)](#M-MFR-Renamers-Files-Actions-Delete-File-System-String- 'MFR.Renamers.Files.Actions.Delete.File(System.String)')
- [Formulate](#T-MFR-Renamers-Files-Actions-Formulate 'MFR.Renamers.Files.Actions.Formulate')
- [List](#T-MFR-Renamers-Files-Actions-List 'MFR.Renamers.Files.Actions.List')
  - [ProcessesLockingFileSystemEntry(pathname)](#M-MFR-Renamers-Files-Actions-List-ProcessesLockingFileSystemEntry-System-String- 'MFR.Renamers.Files.Actions.List.ProcessesLockingFileSystemEntry(System.String)')
- [Remove](#T-MFR-Renamers-Files-Actions-Remove 'MFR.Renamers.Files.Actions.Remove')
  - [#cctor()](#M-MFR-Renamers-Files-Actions-Remove-#cctor 'MFR.Renamers.Files.Actions.Remove.#cctor')
  - [Directory(pathname)](#M-MFR-Renamers-Files-Actions-Remove-Directory-System-String- 'MFR.Renamers.Files.Actions.Remove.Directory(System.String)')
- [Reopen](#T-MFR-Renamers-Files-Actions-Reopen 'MFR.Renamers.Files.Actions.Reopen')
  - [#cctor()](#M-MFR-Renamers-Files-Actions-Reopen-#cctor 'MFR.Renamers.Files.Actions.Reopen.#cctor')
  - [DoReopenSolution(solution)](#M-MFR-Renamers-Files-Actions-Reopen-DoReopenSolution-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution- 'MFR.Renamers.Files.Actions.Reopen.DoReopenSolution(xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution)')
- [Resources](#T-MFR-Renamers-Files-Actions-Properties-Resources 'MFR.Renamers.Files.Actions.Properties.Resources')
  - [Culture](#P-MFR-Renamers-Files-Actions-Properties-Resources-Culture 'MFR.Renamers.Files.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Renamers-Files-Actions-Properties-Resources-ResourceManager 'MFR.Renamers.Files.Actions.Properties.Resources.ResourceManager')
- [Scan](#T-MFR-Renamers-Files-Actions-Scan 'MFR.Renamers.Files.Actions.Scan')
  - [FileDataForBinaryControlCharacters(textToBeSearched)](#M-MFR-Renamers-Files-Actions-Scan-FileDataForBinaryControlCharacters-System-String- 'MFR.Renamers.Files.Actions.Scan.FileDataForBinaryControlCharacters(System.String)')
- [Should](#T-MFR-Renamers-Files-Actions-Should 'MFR.Renamers.Files.Actions.Should')
  - [AnyPreviouslyLoadedSolutionsBeReopened(previouslyLoadedSolutions)](#M-MFR-Renamers-Files-Actions-Should-AnyPreviouslyLoadedSolutionsBeReopened-System-Collections-Generic-IList{xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution}- 'MFR.Renamers.Files.Actions.Should.AnyPreviouslyLoadedSolutionsBeReopened(System.Collections.Generic.IList{xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution})')
- [Start](#T-MFR-Renamers-Files-Actions-Start 'MFR.Renamers.Files.Actions.Start')
  - [#cctor()](#M-MFR-Renamers-Files-Actions-Start-#cctor 'MFR.Renamers.Files.Actions.Start.#cctor')
  - [Service(serviceName)](#M-MFR-Renamers-Files-Actions-Start-Service-System-String- 'MFR.Renamers.Files.Actions.Start.Service(System.String)')
- [Stop](#T-MFR-Renamers-Files-Actions-Stop 'MFR.Renamers.Files.Actions.Stop')
  - [#cctor()](#M-MFR-Renamers-Files-Actions-Stop-#cctor 'MFR.Renamers.Files.Actions.Stop.#cctor')
  - [Process(fileName)](#M-MFR-Renamers-Files-Actions-Stop-Process-System-String- 'MFR.Renamers.Files.Actions.Stop.Process(System.String)')
  - [Service(serviceName)](#M-MFR-Renamers-Files-Actions-Stop-Service-System-String- 'MFR.Renamers.Files.Actions.Stop.Service(System.String)')

<a name='T-MFR-Renamers-Files-Actions-Cleanup'></a>
## Cleanup `type`

##### Namespace

MFR.Renamers.Files.Actions

##### Summary

Exposes static methods to perform cleanup after other operations have
completed.

<a name='M-MFR-Renamers-Files-Actions-Cleanup-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [Cleanup](#T-MFR-Renamers-Files-Actions-Cleanup 'MFR.Renamers.Files.Actions.Cleanup') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-Renamers-Files-Actions-Cleanup-EmptyFileFolder-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### EmptyFileFolder(entry) `method`

##### Summary

Attempts to remove an empty file folder (usually the result of a rename)
referred to by the specified file system `entry`.

##### Returns

`true` if the operation succeeded;
`false` otherwise, or if the operation isn't applicable to the
specified file system `entry`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface and which
refers to a (presumably) empty file folder. |

##### Remarks

If a `null` reference is passed as the argument of
the `entry` parameter, then this method returns
`false`, but otherwise, does nothing.



This method also does nothing if the folder that is referred to by the
specified file system `entry` is not empty.



Finally, nothing is done by this method if the specified file system
`entry` either: (a) does not refer to a folder that exists on
the file system; or (b) refers to a file and not a folder.

<a name='T-MFR-Renamers-Files-Actions-Delete'></a>
## Delete `type`

##### Namespace

MFR.Renamers.Files.Actions

##### Summary

Exposes static methods to delete data.

<a name='M-MFR-Renamers-Files-Actions-Delete-File-System-String-'></a>
### File(pathname) `method`

##### Summary

If it exists, deletes the file having the specified
`pathname`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file that is to be deleted from the file system. |

##### Remarks

If the file having the specified `pathname` does not
exist, then this method does nothing.

<a name='T-MFR-Renamers-Files-Actions-Formulate'></a>
## Formulate `type`

##### Namespace

MFR.Renamers.Files.Actions

##### Summary

Exposes static methods to formulate string values with other values as input.

<a name='T-MFR-Renamers-Files-Actions-List'></a>
## List `type`

##### Namespace

MFR.Renamers.Files.Actions

<a name='M-MFR-Renamers-Files-Actions-List-ProcessesLockingFileSystemEntry-System-String-'></a>
### ProcessesLockingFileSystemEntry(pathname) `method`

##### Summary

Find out what process(es) have a lock on the specified file.

##### Returns

Processes locking the file

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Path of the file. |

##### Remarks

See also:
http://msdn.microsoft.com/en-us/library/windows/desktop/aa373661(v=vs.85).aspx
http://wyupdate.googlecode.com/svn-history/r401/trunk/frmFilesInUse.cs (no
copyright in code at time of viewing)

<a name='T-MFR-Renamers-Files-Actions-Remove'></a>
## Remove `type`

##### Namespace

MFR.Renamers.Files.Actions

##### Summary

Exposes static methods to remove data from data sources or the file system.

<a name='M-MFR-Renamers-Files-Actions-Remove-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [Remove](#T-MFR-Renamers-Files-Actions-Remove 'MFR.Renamers.Files.Actions.Remove') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-Renamers-Files-Actions-Remove-Directory-System-String-'></a>
### Directory(pathname) `method`

##### Summary

Attempts to remove the directory having the specified
`pathname`, and all of its contents, from the file system.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the fully-qualified pathname of the directory that is to be removed. |

<a name='T-MFR-Renamers-Files-Actions-Reopen'></a>
## Reopen `type`

##### Namespace

MFR.Renamers.Files.Actions

<a name='M-MFR-Renamers-Files-Actions-Reopen-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [Reopen](#T-MFR-Renamers-Files-Actions-Reopen 'MFR.Renamers.Files.Actions.Reopen') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-Renamers-Files-Actions-Reopen-DoReopenSolution-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution-'></a>
### DoReopenSolution(solution) `method`

##### Summary

Tasks the associated instance of Visual Studio to load the specified
`solution`.

##### Returns

`true` if the operation completed successfully;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| solution | [xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution') | (Required.) Reference to an instance of an object that implements the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface that represents the Visual Studio Solution (`*.sln`) file that
is to be loaded. |

<a name='T-MFR-Renamers-Files-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Renamers.Files.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Renamers-Files-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Renamers-Files-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Renamers-Files-Actions-Scan'></a>
## Scan `type`

##### Namespace

MFR.Renamers.Files.Actions

##### Summary

Exposes static methods to scan file data for patterns.

<a name='M-MFR-Renamers-Files-Actions-Scan-FileDataForBinaryControlCharacters-System-String-'></a>
### FileDataForBinaryControlCharacters(textToBeSearched) `method`

##### Summary

Scans the `textToBeSearched`, one character at a time, for
any non-text ASCII control character bytes.

##### Returns

`true` if any non-text ASCII control characters are
present in the specified `textToBeSearched`, or
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textToBeSearched | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
containing the character-string representation of the contents of a file that
is to be scanned. |

##### Remarks

If this method returns `true`, then it can be safely
assumed that the file from which the specified
`textToBeSearched` came is not an ASCII text file.

<a name='T-MFR-Renamers-Files-Actions-Should'></a>
## Should `type`

##### Namespace

MFR.Renamers.Files.Actions

##### Summary

Exposes static methods to determine whether certain actions should be taken.

<a name='M-MFR-Renamers-Files-Actions-Should-AnyPreviouslyLoadedSolutionsBeReopened-System-Collections-Generic-IList{xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution}-'></a>
### AnyPreviouslyLoadedSolutionsBeReopened(previouslyLoadedSolutions) `method`

##### Summary

Determines whether one or more of the entries in the
`previouslyLoadedSolutions` list has a value of its
[ShouldReopen](#P-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution-ShouldReopen 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution.ShouldReopen')
property that is `true`.

##### Returns

`true` if at least one of the
`previouslyLoadedSolutions` should be reopened;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| previouslyLoadedSolutions | [System.Collections.Generic.IList{xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution}') | (Required.) Reference to an instance of a collection of instances of objects
that implement the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface. |

##### Remarks

This method returns `false` if the argument of the
`previouslyLoadedSolutions` parameter is a
`null` reference.



This method also returns `false` if the count of items in the
`previouslyLoadedSolutions` collection is zero.



If an error occurs while searching the
`previouslyLoadedSolutions` collection, then this method
returns `false`.

<a name='T-MFR-Renamers-Files-Actions-Start'></a>
## Start `type`

##### Namespace

MFR.Renamers.Files.Actions

##### Summary

Exposes static methods for starting processes, services etc.

<a name='M-MFR-Renamers-Files-Actions-Start-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [Start](#T-MFR-Renamers-Files-Actions-Start 'MFR.Renamers.Files.Actions.Start') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-Renamers-Files-Actions-Start-Service-System-String-'></a>
### Service(serviceName) `method`

##### Summary

Starts a Windows Service by using the command line `sc start` command.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the name of the service
(must have no spaces). |

##### Remarks

If a blank value is passed as the argument of the
`serviceName` parameter, then this method does nothing.

<a name='T-MFR-Renamers-Files-Actions-Stop'></a>
## Stop `type`

##### Namespace

MFR.Renamers.Files.Actions

##### Summary

Exposes static methods to stop processes and services from the command line.

<a name='M-MFR-Renamers-Files-Actions-Stop-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [Stop](#T-MFR-Renamers-Files-Actions-Stop 'MFR.Renamers.Files.Actions.Stop') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-Renamers-Files-Actions-Stop-Process-System-String-'></a>
### Process(fileName) `method`

##### Summary

Stops a process.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the filename only,
e.g., `notepad.exe`, of the process that is to be terminated. |

<a name='M-MFR-Renamers-Files-Actions-Stop-Service-System-String-'></a>
### Service(serviceName) `method`

##### Summary

Stops a Windows Service by using the command line `sc stop` command.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the name of the service
(must have no spaces). |

##### Remarks

If a blank value is passed as the argument of the
`serviceName` parameter, then this method does nothing.
