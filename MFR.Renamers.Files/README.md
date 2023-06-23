<a name='assembly'></a>
# MFR.Renamers.Files

## Contents

- [FileRenamer](#T-MFR-Renamers-Files-FileRenamer 'MFR.Renamers.Files.FileRenamer')
  - [#ctor()](#M-MFR-Renamers-Files-FileRenamer-#ctor 'MFR.Renamers.Files.FileRenamer.#ctor')
  - [_currentOperation](#F-MFR-Renamers-Files-FileRenamer-_currentOperation 'MFR.Renamers.Files.FileRenamer._currentOperation')
  - [_rootDirectoryPath](#F-MFR-Renamers-Files-FileRenamer-_rootDirectoryPath 'MFR.Renamers.Files.FileRenamer._rootDirectoryPath')
  - [AbortRequested](#P-MFR-Renamers-Files-FileRenamer-AbortRequested 'MFR.Renamers.Files.FileRenamer.AbortRequested')
  - [ConfigProvider](#P-MFR-Renamers-Files-FileRenamer-ConfigProvider 'MFR.Renamers.Files.FileRenamer.ConfigProvider')
  - [CurrentConfiguration](#P-MFR-Renamers-Files-FileRenamer-CurrentConfiguration 'MFR.Renamers.Files.FileRenamer.CurrentConfiguration')
  - [CurrentOperation](#P-MFR-Renamers-Files-FileRenamer-CurrentOperation 'MFR.Renamers.Files.FileRenamer.CurrentOperation')
  - [EnabledOperations](#P-MFR-Renamers-Files-FileRenamer-EnabledOperations 'MFR.Renamers.Files.FileRenamer.EnabledOperations')
  - [FileStreamProvider](#P-MFR-Renamers-Files-FileRenamer-FileStreamProvider 'MFR.Renamers.Files.FileRenamer.FileStreamProvider')
  - [Instance](#P-MFR-Renamers-Files-FileRenamer-Instance 'MFR.Renamers.Files.FileRenamer.Instance')
  - [IsBusy](#P-MFR-Renamers-Files-FileRenamer-IsBusy 'MFR.Renamers.Files.FileRenamer.IsBusy')
  - [IsStarted](#P-MFR-Renamers-Files-FileRenamer-IsStarted 'MFR.Renamers.Files.FileRenamer.IsStarted')
  - [LastSolutionFolderPath](#P-MFR-Renamers-Files-FileRenamer-LastSolutionFolderPath 'MFR.Renamers.Files.FileRenamer.LastSolutionFolderPath')
  - [LoadedSolutionProvider](#P-MFR-Renamers-Files-FileRenamer-LoadedSolutionProvider 'MFR.Renamers.Files.FileRenamer.LoadedSolutionProvider')
  - [LoadedSolutions](#P-MFR-Renamers-Files-FileRenamer-LoadedSolutions 'MFR.Renamers.Files.FileRenamer.LoadedSolutions')
  - [RootDirectoryPath](#P-MFR-Renamers-Files-FileRenamer-RootDirectoryPath 'MFR.Renamers.Files.FileRenamer.RootDirectoryPath')
  - [RootDirectoryPathValidator](#P-MFR-Renamers-Files-FileRenamer-RootDirectoryPathValidator 'MFR.Renamers.Files.FileRenamer.RootDirectoryPathValidator')
  - [SearchDirectories](#P-MFR-Renamers-Files-FileRenamer-SearchDirectories 'MFR.Renamers.Files.FileRenamer.SearchDirectories')
  - [SearchDirectoryManager](#P-MFR-Renamers-Files-FileRenamer-SearchDirectoryManager 'MFR.Renamers.Files.FileRenamer.SearchDirectoryManager')
  - [ShouldReOpenSolutions](#P-MFR-Renamers-Files-FileRenamer-ShouldReOpenSolutions 'MFR.Renamers.Files.FileRenamer.ShouldReOpenSolutions')
  - [SyncRoot](#P-MFR-Renamers-Files-FileRenamer-SyncRoot 'MFR.Renamers.Files.FileRenamer.SyncRoot')
  - [VisualStudioSolutionService](#P-MFR-Renamers-Files-FileRenamer-VisualStudioSolutionService 'MFR.Renamers.Files.FileRenamer.VisualStudioSolutionService')
  - [#cctor()](#M-MFR-Renamers-Files-FileRenamer-#cctor 'MFR.Renamers.Files.FileRenamer.#cctor')
  - [CloseSolution(solution)](#M-MFR-Renamers-Files-FileRenamer-CloseSolution-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution- 'MFR.Renamers.Files.FileRenamer.CloseSolution(xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution)')
  - [DoProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-DoProcessAll-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.DoProcessAll(System.String,System.String,System.String,System.Predicate{System.String})')
  - [EnableOperations(operations)](#M-MFR-Renamers-Files-FileRenamer-EnableOperations-MFR-Operations-Constants-OperationType[]- 'MFR.Renamers.Files.FileRenamer.EnableOperations(MFR.Operations.Constants.OperationType[])')
  - [InvokeProcessing(findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-InvokeProcessing-System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.InvokeProcessing(System.String,System.String,System.Predicate{System.String})')
  - [OnClosingSolution(e)](#M-MFR-Renamers-Files-FileRenamer-OnClosingSolution-MFR-Renamers-Files-Events-ClosingSolutionEventArgs- 'MFR.Renamers.Files.FileRenamer.OnClosingSolution(MFR.Renamers.Files.Events.ClosingSolutionEventArgs)')
  - [OnCurrentOperationChanged(e)](#M-MFR-Renamers-Files-FileRenamer-OnCurrentOperationChanged-MFR-Renamers-Files-Events-CurrentOperationChangedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnCurrentOperationChanged(MFR.Renamers.Files.Events.CurrentOperationChangedEventArgs)')
  - [OnExceptionRaised(e)](#M-MFR-Renamers-Files-FileRenamer-OnExceptionRaised-MFR-Events-Common-ExceptionRaisedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnExceptionRaised(MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnFileRenamed(e)](#M-MFR-Renamers-Files-FileRenamer-OnFileRenamed-MFR-Events-FileRenamedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnFileRenamed(MFR.Events.FileRenamedEventArgs)')
  - [OnFilesToBeRenamedCounted(e)](#M-MFR-Renamers-Files-FileRenamer-OnFilesToBeRenamedCounted-MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnFilesToBeRenamedCounted(MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFilesToHaveTextReplacedCounted(e)](#M-MFR-Renamers-Files-FileRenamer-OnFilesToHaveTextReplacedCounted-MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnFilesToHaveTextReplacedCounted(MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnFinished()](#M-MFR-Renamers-Files-FileRenamer-OnFinished 'MFR.Renamers.Files.FileRenamer.OnFinished')
  - [OnFolderRenamed(e)](#M-MFR-Renamers-Files-FileRenamer-OnFolderRenamed-MFR-Events-FolderRenamedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnFolderRenamed(MFR.Events.FolderRenamedEventArgs)')
  - [OnOperationFinished(e)](#M-MFR-Renamers-Files-FileRenamer-OnOperationFinished-MFR-Operations-Events-OperationFinishedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnOperationFinished(MFR.Operations.Events.OperationFinishedEventArgs)')
  - [OnOperationStarted(e)](#M-MFR-Renamers-Files-FileRenamer-OnOperationStarted-MFR-Operations-Events-OperationStartedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnOperationStarted(MFR.Operations.Events.OperationStartedEventArgs)')
  - [OnProcessingOperation(e)](#M-MFR-Renamers-Files-FileRenamer-OnProcessingOperation-MFR-Operations-Events-ProcessingOperationEventArgs- 'MFR.Renamers.Files.FileRenamer.OnProcessingOperation(MFR.Operations.Events.ProcessingOperationEventArgs)')
  - [OnRootDirectoryPathChanged(e)](#M-MFR-Renamers-Files-FileRenamer-OnRootDirectoryPathChanged-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnRootDirectoryPathChanged(MFR.Renamers.Files.Events.RootDirectoryPathChangedEventArgs)')
  - [OnSolutionCloseFailed(e)](#M-MFR-Renamers-Files-FileRenamer-OnSolutionCloseFailed-MFR-Renamers-Files-Events-SolutionCloseFailedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnSolutionCloseFailed(MFR.Renamers.Files.Events.SolutionCloseFailedEventArgs)')
  - [OnSolutionClosed(e)](#M-MFR-Renamers-Files-FileRenamer-OnSolutionClosed-MFR-Renamers-Files-Events-SolutionClosedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnSolutionClosed(MFR.Renamers.Files.Events.SolutionClosedEventArgs)')
  - [OnSolutionFolderRenamed(e)](#M-MFR-Renamers-Files-FileRenamer-OnSolutionFolderRenamed-MFR-Events-FolderRenamedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnSolutionFolderRenamed(MFR.Events.FolderRenamedEventArgs)')
  - [OnSolutionFoldersToBeRenamedCounted(e)](#M-MFR-Renamers-Files-FileRenamer-OnSolutionFoldersToBeRenamedCounted-MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnSolutionFoldersToBeRenamedCounted(MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnStarted()](#M-MFR-Renamers-Files-FileRenamer-OnStarted 'MFR.Renamers.Files.FileRenamer.OnStarted')
  - [OnStarting()](#M-MFR-Renamers-Files-FileRenamer-OnStarting 'MFR.Renamers.Files.FileRenamer.OnStarting')
  - [OnStatusUpdate(e)](#M-MFR-Renamers-Files-FileRenamer-OnStatusUpdate-MFR-Events-Common-StatusUpdateEventArgs- 'MFR.Renamers.Files.FileRenamer.OnStatusUpdate(MFR.Events.Common.StatusUpdateEventArgs)')
  - [OnSubfoldersToBeRenamedCounted(e)](#M-MFR-Renamers-Files-FileRenamer-OnSubfoldersToBeRenamedCounted-MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnSubfoldersToBeRenamedCounted(MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [ProcessAll(findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-ProcessAll-System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.ProcessAll(System.String,System.String,System.Predicate{System.String})')
  - [ProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.ProcessAll(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RenameFilesInFolder(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-RenameFilesInFolder-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.RenameFilesInFolder(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RenameSolutionFolders(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-RenameSolutionFolders-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.RenameSolutionFolders(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RenameSubFoldersOf(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-RenameSubFoldersOf-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.RenameSubFoldersOf(System.String,System.String,System.String,System.Predicate{System.String})')
  - [ReopenSolution(solution)](#M-MFR-Renamers-Files-FileRenamer-ReopenSolution-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution- 'MFR.Renamers.Files.FileRenamer.ReopenSolution(xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution)')
  - [ReplaceTextInFiles(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-ReplaceTextInFiles-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.ReplaceTextInFiles(System.String,System.String,System.String,System.Predicate{System.String})')
  - [ReportSolutionCloseFailed(pathname)](#M-MFR-Renamers-Files-FileRenamer-ReportSolutionCloseFailed-System-String- 'MFR.Renamers.Files.FileRenamer.ReportSolutionCloseFailed(System.String)')
  - [RequestAbort()](#M-MFR-Renamers-Files-FileRenamer-RequestAbort 'MFR.Renamers.Files.FileRenamer.RequestAbort')
  - [StartingFrom(path)](#M-MFR-Renamers-Files-FileRenamer-StartingFrom-System-String- 'MFR.Renamers.Files.FileRenamer.StartingFrom(System.String)')
  - [UpdateStatus(text,operationType,operationFinished)](#M-MFR-Renamers-Files-FileRenamer-UpdateStatus-System-String,MFR-Operations-Constants-OperationType,System-Boolean- 'MFR.Renamers.Files.FileRenamer.UpdateStatus(System.String,MFR.Operations.Constants.OperationType,System.Boolean)')
- [Resources](#T-MFR-Renamers-Files-Properties-Resources 'MFR.Renamers.Files.Properties.Resources')
  - [Confirm_PerformRename](#P-MFR-Renamers-Files-Properties-Resources-Confirm_PerformRename 'MFR.Renamers.Files.Properties.Resources.Confirm_PerformRename')
  - [Culture](#P-MFR-Renamers-Files-Properties-Resources-Culture 'MFR.Renamers.Files.Properties.Resources.Culture')
  - [Error_AttemptToCloseSolutionFailed](#P-MFR-Renamers-Files-Properties-Resources-Error_AttemptToCloseSolutionFailed 'MFR.Renamers.Files.Properties.Resources.Error_AttemptToCloseSolutionFailed')
  - [Error_NoSolutionsInRootDirectory](#P-MFR-Renamers-Files-Properties-Resources-Error_NoSolutionsInRootDirectory 'MFR.Renamers.Files.Properties.Resources.Error_NoSolutionsInRootDirectory')
  - [Error_OperationAborted](#P-MFR-Renamers-Files-Properties-Resources-Error_OperationAborted 'MFR.Renamers.Files.Properties.Resources.Error_OperationAborted')
  - [ResourceManager](#P-MFR-Renamers-Files-Properties-Resources-ResourceManager 'MFR.Renamers.Files.Properties.Resources.ResourceManager')
  - [StatusUpdate_AttemptingRenameSolutionFolders](#P-MFR-Renamers-Files-Properties-Resources-StatusUpdate_AttemptingRenameSolutionFolders 'MFR.Renamers.Files.Properties.Resources.StatusUpdate_AttemptingRenameSolutionFolders')
  - [StatusUpdate_FinishedRenamingSolutionFolders](#P-MFR-Renamers-Files-Properties-Resources-StatusUpdate_FinishedRenamingSolutionFolders 'MFR.Renamers.Files.Properties.Resources.StatusUpdate_FinishedRenamingSolutionFolders')
  - [StatusUpdate_RenamingFilesInFolders](#P-MFR-Renamers-Files-Properties-Resources-StatusUpdate_RenamingFilesInFolders 'MFR.Renamers.Files.Properties.Resources.StatusUpdate_RenamingFilesInFolders')

<a name='T-MFR-Renamers-Files-FileRenamer'></a>
## FileRenamer `type`

##### Namespace

MFR.Renamers.Files

##### Summary

Provides file- and folder-rename services.

##### Remarks

NOTE: Instances of this class must be composed with an instance of an
object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface.



Such an object is necessary because it provides settings specified by
the user that change the behavior of this object.

<a name='M-MFR-Renamers-Files-FileRenamer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Renamers-Files-FileRenamer-_currentOperation'></a>
### _currentOperation `constants`

##### Summary

An [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') enumeration value
that describes what operation is currently being performed by the application.

<a name='F-MFR-Renamers-Files-FileRenamer-_rootDirectoryPath'></a>
### _rootDirectoryPath `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the full pathname of the folder
where all operations start.

<a name='P-MFR-Renamers-Files-FileRenamer-AbortRequested'></a>
### AbortRequested `property`

##### Summary

Gets a value that indicates whether an abort of the current
operation has been requested.

<a name='P-MFR-Renamers-Files-FileRenamer-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider')
interface.

##### Remarks

This object allows access to the user configuration and the
actions
associated with it.

<a name='P-MFR-Renamers-Files-FileRenamer-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface.

<a name='P-MFR-Renamers-Files-FileRenamer-CurrentOperation'></a>
### CurrentOperation `property`

##### Summary

Gets or sets the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
enumeration value that indicates which operation is currently being performed.

<a name='P-MFR-Renamers-Files-FileRenamer-EnabledOperations'></a>
### EnabledOperations `property`

##### Summary

Gets a reference to a collection of of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values.

##### Remarks

All the values in this collection identify operations that the user
wishes to perform.



This list should be cleared after every run.



If the list is empty when the
[ProcessAll](#M-MFR-FileRenamer-ProcessAll 'MFR.FileRenamer.ProcessAll')
method is called, do
nothing or throw an exception.

<a name='P-MFR-Renamers-Files-FileRenamer-FileStreamProvider'></a>
### FileStreamProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileStreamProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider')
interface.

<a name='P-MFR-Renamers-Files-FileRenamer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFileRenamer](#T-MFR-Renamers-Files-Interfaces-IFileRenamer 'MFR.Renamers.Files.Interfaces.IFileRenamer') interface.

<a name='P-MFR-Renamers-Files-FileRenamer-IsBusy'></a>
### IsBusy `property`

##### Summary

Gets a value that indicates whether this component is currently processing
operation(s).

<a name='P-MFR-Renamers-Files-FileRenamer-IsStarted'></a>
### IsStarted `property`

##### Summary

Gets a value that indicates whether this component is currently processing
operation(s).

<a name='P-MFR-Renamers-Files-FileRenamer-LastSolutionFolderPath'></a>
### LastSolutionFolderPath `property`

##### Summary

Gets or sets the path to the folder in which last Visual Studio Solution that
we have worked with most recently resides.

<a name='P-MFR-Renamers-Files-FileRenamer-LoadedSolutionProvider'></a>
### LoadedSolutionProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ILoadedSolutionProvider](#T-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider')
interface.

<a name='P-MFR-Renamers-Files-FileRenamer-LoadedSolutions'></a>
### LoadedSolutions `property`

##### Summary

Gets a reference to a collection, each element of which implements the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface.

##### Remarks

Each element of the collection represents a Visual Studio Solution (*.sln) that
is loaded in a running instance of Visual Studio.

<a name='P-MFR-Renamers-Files-FileRenamer-RootDirectoryPath'></a>
### RootDirectoryPath `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified pathname
of the folder where all operations start.

##### Remarks

This property raises the
[](#E-MFR-Renamers-Files-FileRenamer-RootDirectoryPathChanged 'MFR.Renamers.Files.FileRenamer.RootDirectoryPathChanged') event
when its value is updated.

<a name='P-MFR-Renamers-Files-FileRenamer-RootDirectoryPathValidator'></a>
### RootDirectoryPathValidator `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IRootDirectoryPathValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryPathValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator')
interface.

##### Remarks

This object runs validation rules to ensure, among other things, that the
pathname passed to it is that of a folder that exists on disk, and that
contains a `.sln` file.

<a name='P-MFR-Renamers-Files-FileRenamer-SearchDirectories'></a>
### SearchDirectories `property`

##### Summary

Gets a collection of fully-qualified pathnames of folders found by this object,
that
should be searched for projects, files, and folders whose names should be
changed.

<a name='P-MFR-Renamers-Files-FileRenamer-SearchDirectoryManager'></a>
### SearchDirectoryManager `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ISearchDirectoryManager](#T-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager 'MFR.Directories.Managers.Interfaces.ISearchDirectoryManager')
interface.

<a name='P-MFR-Renamers-Files-FileRenamer-ShouldReOpenSolutions'></a>
### ShouldReOpenSolutions `property`

##### Summary

Gets a value determining whether the currently-open solution
in Visual Studio should be closed and then re-opened at the
completion of the operation.

<a name='P-MFR-Renamers-Files-FileRenamer-SyncRoot'></a>
### SyncRoot `property`

##### Summary

Synchronization root object for creating critical sections.

<a name='P-MFR-Renamers-Files-FileRenamer-VisualStudioSolutionService'></a>
### VisualStudioSolutionService `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IVisualStudioSolutionService](#T-MFR-Managers-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService')
interface.

##### Remarks

This property allows access to an object that helps us manage the Visual Studio
Solution(s) that may be in the starting folder, and to track which running
instance(s), if any, have said Solution(s) open, and to command the instance(s)
to load/unload the Solution(s).

<a name='M-MFR-Renamers-Files-FileRenamer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Renamers-Files-FileRenamer-CloseSolution-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution-'></a>
### CloseSolution(solution) `method`

##### Summary

Calls upon the running Visual Studio instance (if any) that currently has the
specified `solution` loaded, to close it.

##### Returns

`true` if the operation was successful;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| solution | [xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution') | (Required.) Reference to an instance of an object that implements the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface that represents the Solution. |

##### Remarks

If the specified `solution` object does not contain
enough information to use to close the Solution, or if the Solution isn't
loaded in any of the currently-running instances of Visual Studio, then this
method returns `false`.



This method also returns `false` if the Visual Studio Solution
(`*.sln`) file corresponding to the specified `solution`
object does not exist on the user's hard disk.



This method raises the
[](#E-MFR-Renamers-Files-FileRenamer-ClosingSolution 'MFR.Renamers.Files.FileRenamer.ClosingSolution') event before it
performs the requested operation.  The specified `solution`
is included in the event data.  The handler(s) of this event may set the value
of the [Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property
to `true` to block this operation from proceeding, but only
for the currently-specified `solution`.

<a name='M-MFR-Renamers-Files-FileRenamer-DoProcessAll-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### DoProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Provides the rename-processing services for just one out of potentially several
root directories.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootDirectoryPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) FullName to the recursion root. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to search for. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to replace the text specified
by `findWhat` with. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) Reference to an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func')
that points to a delegate, accepting the current file or folder's
path as an argument, that returns `true` if the file
should be included in the operation or `false` otherwise.



This parameter is `null` by default. This method
should return `true` to specify that a given
file-system entry is to be included in the output collection --
barring other inclusion/exclusion criteria.



In the event that this parameter is `null`, no path
filtering is done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`rootDirectoryPath`
, is passed a blank or
`null`
string for a value. |

<a name='M-MFR-Renamers-Files-FileRenamer-EnableOperations-MFR-Operations-Constants-OperationType[]-'></a>
### EnableOperations(operations) `method`

##### Summary

Enables this object to perform some or all of the operations specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operations | [MFR.Operations.Constants.OperationType[]](#T-MFR-Operations-Constants-OperationType[] 'MFR.Operations.Constants.OperationType[]') |  |

<a name='M-MFR-Renamers-Files-FileRenamer-InvokeProcessing-System-String,System-String,System-Predicate{System-String}-'></a>
### InvokeProcessing(findWhat,replaceWith,pathFilter) `method`

##### Summary

Invokes the core processing of this file-renamer object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to search for. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to replace the text specified
by `findWhat` with. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) Reference to an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func')
that points to a delegate, accepting the current file or folder's
path as an argument, that returns `true` if the file
should be included in the operation or `false` otherwise.



This parameter is `null` by default. This method
should return `true` to specify that a given
file-system entry is to be included in the output collection --
barring other inclusion/exclusion criteria.



In the event that this parameter is `null`, no path
filtering is done. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnClosingSolution-MFR-Renamers-Files-Events-ClosingSolutionEventArgs-'></a>
### OnClosingSolution(e) `method`

##### Summary

Raises the [](#E-MFR-Renamers-Files-FileRenamer-ClosingSolution 'MFR.Renamers.Files.FileRenamer.ClosingSolution')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Renamers.Files.Events.ClosingSolutionEventArgs](#T-MFR-Renamers-Files-Events-ClosingSolutionEventArgs 'MFR.Renamers.Files.Events.ClosingSolutionEventArgs') | A
[ClosingSolutionEventArgs](#T-MFR-Renamers-Files-Events-ClosingSolutionEventArgs 'MFR.Renamers.Files.Events.ClosingSolutionEventArgs') that
contains the event data. |

##### Remarks

Handlers of this event can set the value of the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true` to stop the operation from proceeding.

<a name='M-MFR-Renamers-Files-FileRenamer-OnCurrentOperationChanged-MFR-Renamers-Files-Events-CurrentOperationChangedEventArgs-'></a>
### OnCurrentOperationChanged(e) `method`

##### Summary

Raises the
[](#E-MFR-Renamers-Files-FileRenamer-CurrentOperationChanged 'MFR.Renamers.Files.FileRenamer.CurrentOperationChanged')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Renamers.Files.Events.CurrentOperationChangedEventArgs](#T-MFR-Renamers-Files-Events-CurrentOperationChangedEventArgs 'MFR.Renamers.Files.Events.CurrentOperationChangedEventArgs') | A
[CurrentOperationChangedEventArgs](#T-MFR-Renamers-Files-Events-CurrentOperationChangedEventArgs 'MFR.Renamers.Files.Events.CurrentOperationChangedEventArgs')
that contains the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnExceptionRaised-MFR-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnExceptionRaised(e) `method`

##### Summary

Raises the [](#E-MFR-Renamers-Files-FileRenamer-ExceptionRaised 'MFR.Renamers.Files.FileRenamer.ExceptionRaised')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.Common.ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs') | A [ExceptionRaisedEventArgs](#T-MFR-ExceptionRaisedEventArgs 'MFR.ExceptionRaisedEventArgs') that contains
the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnFileRenamed-MFR-Events-FileRenamedEventArgs-'></a>
### OnFileRenamed(e) `method`

##### Summary

Raises the [](#E-MFR-Renamers-Files-FileRenamer-FileRenamed 'MFR.Renamers.Files.FileRenamer.FileRenamed') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.FileRenamedEventArgs](#T-MFR-Events-FileRenamedEventArgs 'MFR.Events.FileRenamedEventArgs') | A [FileRenamed](#T-MFR-Renamers-Files-FileRenamer-FileRenamed 'MFR.Renamers.Files.FileRenamer.FileRenamed')
that contains the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnFilesToBeRenamedCounted-MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFilesToBeRenamedCounted(e) `method`

##### Summary

Raises the
[](#E-MFR-Renamers-Files-FileRenamer-FilesToBeRenamedCounted 'MFR.Renamers.Files.FileRenamer.FilesToBeRenamedCounted')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') that
contains the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnFilesToHaveTextReplacedCounted-MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnFilesToHaveTextReplacedCounted(e) `method`

##### Summary

Raises the
[](#E-MFR-Renamers-Files-FileRenamer-FilesToHaveTextReplacedCounted 'MFR.Renamers.Files.FileRenamer.FilesToHaveTextReplacedCounted')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') that
contains the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnFinished'></a>
### OnFinished() `method`

##### Summary

Raises the
[](#E-MFR-Renamers-Files-FileRenamer-Finished 'MFR.Renamers.Files.FileRenamer.Finished')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Renamers-Files-FileRenamer-OnFolderRenamed-MFR-Events-FolderRenamedEventArgs-'></a>
### OnFolderRenamed(e) `method`

##### Summary

Raises the [](#E-MFR-Renamers-Files-FileRenamer-FolderRenamed 'MFR.Renamers.Files.FileRenamer.FolderRenamed') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.FolderRenamedEventArgs](#T-MFR-Events-FolderRenamedEventArgs 'MFR.Events.FolderRenamedEventArgs') | A [FolderRenamedEventArgs](#T-MFR-Events-FolderRenamedEventArgs 'MFR.Events.FolderRenamedEventArgs') that
contains the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnOperationFinished-MFR-Operations-Events-OperationFinishedEventArgs-'></a>
### OnOperationFinished(e) `method`

##### Summary

Raises the [](#E-MFR-Renamers-Files-FileRenamer-OperationFinished 'MFR.Renamers.Files.FileRenamer.OperationFinished')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Operations.Events.OperationFinishedEventArgs](#T-MFR-Operations-Events-OperationFinishedEventArgs 'MFR.Operations.Events.OperationFinishedEventArgs') | An [OperationFinishedEventArgs](#T-MFR-Operations-Events-OperationFinishedEventArgs 'MFR.Operations.Events.OperationFinishedEventArgs') that
contains the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnOperationStarted-MFR-Operations-Events-OperationStartedEventArgs-'></a>
### OnOperationStarted(e) `method`

##### Summary

Raises the [](#E-MFR-Renamers-Files-FileRenamer-OperationStarted 'MFR.Renamers.Files.FileRenamer.OperationStarted')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Operations.Events.OperationStartedEventArgs](#T-MFR-Operations-Events-OperationStartedEventArgs 'MFR.Operations.Events.OperationStartedEventArgs') | A [OperationStartedEventArgs](#T-MFR-Operations-Events-OperationStartedEventArgs 'MFR.Operations.Events.OperationStartedEventArgs') that
contains the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnProcessingOperation-MFR-Operations-Events-ProcessingOperationEventArgs-'></a>
### OnProcessingOperation(e) `method`

##### Summary

Raises the [](#E-MFR-ProcessingOperation 'MFR.ProcessingOperation') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Operations.Events.ProcessingOperationEventArgs](#T-MFR-Operations-Events-ProcessingOperationEventArgs 'MFR.Operations.Events.ProcessingOperationEventArgs') | A [ProcessingOperationEventArgs](#T-MFR-ProcessingOperationEventArgs 'MFR.ProcessingOperationEventArgs') that
contains the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnRootDirectoryPathChanged-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventArgs-'></a>
### OnRootDirectoryPathChanged(e) `method`

##### Summary

Raises the
[](#E-MFR-Renamers-Files-FileRenamer-RootDirectoryPathChanged 'MFR.Renamers.Files.FileRenamer.RootDirectoryPathChanged') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Renamers.Files.Events.RootDirectoryPathChangedEventArgs](#T-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventArgs 'MFR.Renamers.Files.Events.RootDirectoryPathChangedEventArgs') | (Required.) A
[RootDirectoryPathChangedEventArgs](#T-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventArgs 'MFR.Renamers.Files.Events.RootDirectoryPathChangedEventArgs')
that contains the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnSolutionCloseFailed-MFR-Renamers-Files-Events-SolutionCloseFailedEventArgs-'></a>
### OnSolutionCloseFailed(e) `method`

##### Summary

Raises the [](#E-MFR-Renamers-Files-FileRenamer-SolutionCloseFailed 'MFR.Renamers.Files.FileRenamer.SolutionCloseFailed')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Renamers.Files.Events.SolutionCloseFailedEventArgs](#T-MFR-Renamers-Files-Events-SolutionCloseFailedEventArgs 'MFR.Renamers.Files.Events.SolutionCloseFailedEventArgs') | A
[SolutionCloseFailedEventArgs](#T-MFR-Renamers-Files-Events-SolutionCloseFailedEventArgs 'MFR.Renamers.Files.Events.SolutionCloseFailedEventArgs') that
contains the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnSolutionClosed-MFR-Renamers-Files-Events-SolutionClosedEventArgs-'></a>
### OnSolutionClosed(e) `method`

##### Summary

Raises the [](#E-MFR-Renamers-Files-FileRenamer-SolutionClosed 'MFR.Renamers.Files.FileRenamer.SolutionClosed')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Renamers.Files.Events.SolutionClosedEventArgs](#T-MFR-Renamers-Files-Events-SolutionClosedEventArgs 'MFR.Renamers.Files.Events.SolutionClosedEventArgs') | A
[SolutionClosedEventArgs](#T-MFR-Renamers-Files-Events-SolutionClosedEventArgs 'MFR.Renamers.Files.Events.SolutionClosedEventArgs') that
contains the event data. |

##### Remarks

The [](#E-MFR-Renamers-Files-FileRenamer-SolutionClosed 'MFR.Renamers.Files.FileRenamer.SolutionClosed') event is
used to indicate that a running instance of Visual Studio has just finished
closing/unloading a Visual Studio Solution (`*.sln`) file.

<a name='M-MFR-Renamers-Files-FileRenamer-OnSolutionFolderRenamed-MFR-Events-FolderRenamedEventArgs-'></a>
### OnSolutionFolderRenamed(e) `method`

##### Summary

Raises the [](#E-MFR-Renamers-Files-FileRenamer-FolderRenamed 'MFR.Renamers.Files.FileRenamer.FolderRenamed') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.FolderRenamedEventArgs](#T-MFR-Events-FolderRenamedEventArgs 'MFR.Events.FolderRenamedEventArgs') | A [FolderRenamedEventArgs](#T-MFR-Events-FolderRenamedEventArgs 'MFR.Events.FolderRenamedEventArgs') that
contains the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnSolutionFoldersToBeRenamedCounted-MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnSolutionFoldersToBeRenamedCounted(e) `method`

##### Summary

Raises the
[](#E-MFR-Renamers-Files-FileRenamer-SolutionFoldersToBeRenamedCounted 'MFR.Renamers.Files.FileRenamer.SolutionFoldersToBeRenamedCounted')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') that
contains the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnStarted'></a>
### OnStarted() `method`

##### Summary

Raises the
[](#E-MFR-Renamers-Files-FileRenamer-Started 'MFR.Renamers.Files.FileRenamer.Started')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Renamers-Files-FileRenamer-OnStarting'></a>
### OnStarting() `method`

##### Summary

Raises the [](#E-MFR-Renamers-Files-FileRenamer-Starting 'MFR.Renamers.Files.FileRenamer.Starting') event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Renamers-Files-FileRenamer-OnStatusUpdate-MFR-Events-Common-StatusUpdateEventArgs-'></a>
### OnStatusUpdate(e) `method`

##### Summary

Raises the [](#E-MFR-Renamers-Files-FileRenamer-StatusUpdate 'MFR.Renamers.Files.FileRenamer.StatusUpdate') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.Common.StatusUpdateEventArgs](#T-MFR-Events-Common-StatusUpdateEventArgs 'MFR.Events.Common.StatusUpdateEventArgs') | A [StatusUpdateEventArgs](#T-MFR-StatusUpdateEventArgs 'MFR.StatusUpdateEventArgs') that contains
the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-OnSubfoldersToBeRenamedCounted-MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnSubfoldersToBeRenamedCounted(e) `method`

##### Summary

Raises the
[](#E-MFR-Renamers-Files-FileRenamer-SubfoldersToBeRenamedCounted 'MFR.Renamers.Files.FileRenamer.SubfoldersToBeRenamedCounted')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') that
contains the event data. |

<a name='M-MFR-Renamers-Files-FileRenamer-ProcessAll-System-String,System-String,System-Predicate{System-String}-'></a>
### ProcessAll(findWhat,replaceWith,pathFilter) `method`

##### Summary

Executes the Rename Subfolders, Rename Files, and Replace Text in
Files operation on all the folders and files in the root folder with
the pathname stored in the
[RootDirectoryPath](#P-MFR-FileRenamer-RootDirectoryPath 'MFR.FileRenamer.RootDirectoryPath')
property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to search for. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to replace the text specified
by `findWhat` with. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) Reference to an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func')
that points to a delegate, accepting the current file or folder's
path as an argument, that returns `true` if the file
should be included in the operation or `false` otherwise.



This parameter is `null` by default. This method
should return `true` to specify that a given
file-system entry is to be included in the output collection --
barring other inclusion/exclusion criteria.



In the event that this parameter is `null`, no path
filtering is done. |

<a name='M-MFR-Renamers-Files-FileRenamer-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### ProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Executes the Rename Subfolders, Rename Files, and Replace Text in
Files operation on all the folders and files in the root folder with
the pathname specified by the `rootDirectoryPath` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootDirectoryPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) FullName to the recursion root. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to search for. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to replace the text specified
by `findWhat` with. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) Reference to an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func')
that points to a delegate, accepting the current file or folder's
path as an argument, that returns `true` if the file
should be included in the operation or `false` otherwise.



This parameter is `null` by default. This method
should return `true` to specify that a given
file-system entry is to be included in the output collection --
barring other inclusion/exclusion criteria.



In the event that this parameter is `null`, no path
filtering is done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the value of the
[CurrentConfiguration](#P-MFR-Settings-Configuration-ConfigurationComposedObjectBase-CurrentConfiguration 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.CurrentConfiguration')
property has not been set prior to calling this method.



Call the
[UpdateConfiguration](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-UpdateConfiguration 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.UpdateConfiguration')
method on this object prior to calling this method. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`rootDirectoryPath`
, is passed a blank or
`null`
string for a value. |

<a name='M-MFR-Renamers-Files-FileRenamer-RenameFilesInFolder-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### RenameFilesInFolder(rootFolderPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Renames all the files in the all the subfolders etc., recursively,
of the folder whose pathname is specified by the
`rootFolderPath`
parameter.

##### Returns

`true` if the operation was successful;
`false` if the operation failed or if the user cancelled the
operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the full pathname of an existing
directory on the computer that is to be where the operation is started. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to search for. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to replace the text specified
by `findWhat` with. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) Reference to an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func')
that points to a delegate, accepting the current file or folder's
path as an argument, that returns `true` if the file
should be included in the operation or `false` otherwise.



This parameter is `null` by default. This method
should return `true` to specify that a given
file-system entry is to be included in the output collection --
barring other inclusion/exclusion criteria.



In the event that this parameter is `null`, no path
filtering is done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either the `rootFolderPath`,
`findWhat`
, or `replaceWith` parameters are blank. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the
`rootFolderPath`
does not exist. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |

<a name='M-MFR-Renamers-Files-FileRenamer-RenameSolutionFolders-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### RenameSolutionFolders(rootFolderPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Iterates through the directory tree that is topped by the folder having the
specified `rootFolderPath`, and, for all Visual Studio
Solution (`*.sln`) file(s) found in the directory tree, renames them
according to the text-replacement pattern specified by the arguments of the
`findWhat` and `replaceWith` parameters.

##### Returns

`true` if the operation succeeded;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a folder in which the operation is to start. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Text to be found in each file contained in the directory tree. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text that the text
specified by the argument of the `findWhat` parameter is to
be replaced with. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) Reference to an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func')
that points to a delegate, accepting the current file or folder's
path as an argument, that returns `true` if the file
should be included in the operation or `false` otherwise.



This parameter is `null` by default. This method
should return `true` to specify that a given
file-system entry is to be included in the output collection --
barring other inclusion/exclusion criteria.



In the event that this parameter is `null`, no path
filtering is done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either the `rootFolderPath` or the
`findWhat` parameters are blank. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the
`rootFolderPath`
does not exist. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |

<a name='M-MFR-Renamers-Files-FileRenamer-RenameSubFoldersOf-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### RenameSubFoldersOf(rootFolderPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Recursively renames all the subfolders in the folder having a
pathname specified by `rootFolderPath`, replacing
any occurrences of the text in the `findWhat`
parameter with the values in the `replaceWith` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the full pathname of an existing
directory on the computer that is to be where the operation is started. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to search for. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to replace the text specified
by `findWhat` with. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) Reference to an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func')
that points to a delegate, accepting the current file or folder's
path as an argument, that returns `true` if the file
should be included in the operation or `false` otherwise.



This parameter is `null` by default. This method
should return `true` to specify that a given
file-system entry is to be included in the output collection --
barring other inclusion/exclusion criteria.



In the event that this parameter is `null`, no path
filtering is done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either the `rootFolderPath`,
`findWhat`
, or `replaceWith` parameters are blank. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the
`rootFolderPath`
does not exist. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |

<a name='M-MFR-Renamers-Files-FileRenamer-ReopenSolution-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution-'></a>
### ReopenSolution(solution) `method`

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

<a name='M-MFR-Renamers-Files-FileRenamer-ReplaceTextInFiles-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### ReplaceTextInFiles(rootFolderPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Iterates recursively through a directory tree, starting at the
folder with pathname `rootFolderPath` and replacing
every occurrence of the text specified by the
`findWhat`
parameter with the text specified by the
`replaceWith`
parameter. A case-sensitive, not-in-exact-word
search is performed.

##### Returns

`true` if the operation succeeded;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Pathname of the folder where the operation is to start. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Text to be found in each file contained in the directory tree. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Text to replace all the instances of
`findWhat`
with. If this parameter is blank (the default),
then the text is deleted. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) Reference to an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func')
that points to a delegate, accepting the current file or folder's
path as an argument, that returns `true` if the file
should be included in the operation or `false` otherwise.



This parameter is `null` by default. This method
should return `true` to specify that a given
file-system entry is to be included in the output collection --
barring other inclusion/exclusion criteria.



In the event that this parameter is `null`, no path
filtering is done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either the `rootFolderPath` or the
`findWhat` parameters are blank. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the
`rootFolderPath`
does not exist. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |

<a name='M-MFR-Renamers-Files-FileRenamer-ReportSolutionCloseFailed-System-String-'></a>
### ReportSolutionCloseFailed(pathname) `method`

##### Summary

Reports that an attempt to close a Visual Studio Solution (`*.sln`) file
having the specified `pathname` that was loaded into a
running instance of Visual Studio has failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the fully-qualified pathname of the Visual Studio Solution (`*.sln`) that
could not be closed. |

<a name='M-MFR-Renamers-Files-FileRenamer-RequestAbort'></a>
### RequestAbort() `method`

##### Summary

Called to ask the `File Renamer` object to stop operations.

##### Parameters

This method has no parameters.

<a name='M-MFR-Renamers-Files-FileRenamer-StartingFrom-System-String-'></a>
### StartingFrom(path) `method`

##### Summary

Sets the new root directory path from which searches should be started.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of the folder from
which searches should be started.



The fully-qualified pathname passed must reference a folder that currently
exists on the disk; otherwise,
[DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') is thrown. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`path`, is passed a blank or `null` string
for a value. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder whose fully-qualified pathname is passed in the
`path` parameter cannot be located on the disk. |

##### Remarks

Upon successful validation of the fully-qualified folder pathname that is
specified as the value of the `path` parameter, assigns the
value to the [RootDirectoryPath](#P-MFR-Renamers-Files-FileRenamer-RootDirectoryPath 'MFR.Renamers.Files.FileRenamer.RootDirectoryPath')
property.

<a name='M-MFR-Renamers-Files-FileRenamer-UpdateStatus-System-String,MFR-Operations-Constants-OperationType,System-Boolean-'></a>
### UpdateStatus(text,operationType,operationFinished) `method`

##### Summary

Raises the [](#E-MFR-Renamers-Files-FileRenamer-StatusUpdate 'MFR.Renamers.Files.FileRenamer.StatusUpdate') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the status message text that is meant for display
to the user. |
| operationType | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
enumeration values that describes the operation that is currently being
performed. |
| operationFinished | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value that indicates whether the
operation is finished.



Default value is `false`. |

<a name='T-MFR-Renamers-Files-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Renamers.Files.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Renamers-Files-Properties-Resources-Confirm_PerformRename'></a>
### Confirm_PerformRename `property`

##### Summary

Looks up a localized string similar to We've noticed that you have one or more instances of Visual Studio 2019 open.

It doesn't appear that the solution contaiing the project to be renamed is open in any of them.

Choose File -> Reopen Workspace when the selected rename operation(s) have completed if the solution is open and we missed it.

Do you want to proceed with the rename operation?.

<a name='P-MFR-Renamers-Files-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Renamers-Files-Properties-Resources-Error_AttemptToCloseSolutionFailed'></a>
### Error_AttemptToCloseSolutionFailed `property`

##### Summary

Looks up a localized string similar to The attempt to close the solution '{0}' has failed..

<a name='P-MFR-Renamers-Files-Properties-Resources-Error_NoSolutionsInRootDirectory'></a>
### Error_NoSolutionsInRootDirectory `property`

##### Summary

Looks up a localized string similar to FileRenamer.DoProcessAll: A Visual Studio Solution file could not be located in the folder '{0}'.  Stopping..

<a name='P-MFR-Renamers-Files-Properties-Resources-Error_OperationAborted'></a>
### Error_OperationAborted `property`

##### Summary

Looks up a localized string similar to The operation has been aborted..

<a name='P-MFR-Renamers-Files-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-MFR-Renamers-Files-Properties-Resources-StatusUpdate_AttemptingRenameSolutionFolders'></a>
### StatusUpdate_AttemptingRenameSolutionFolders `property`

##### Summary

Looks up a localized string similar to Attempting to rename the folder(s) in the '{0}' folder that contain Visual Studio Solution (*.sln) file(s) to match the name(s) of those Solution(s)... .

<a name='P-MFR-Renamers-Files-Properties-Resources-StatusUpdate_FinishedRenamingSolutionFolders'></a>
### StatusUpdate_FinishedRenamingSolutionFolders `property`

##### Summary

Looks up a localized string similar to *** Finished renaming solution folders in '{0}'..

<a name='P-MFR-Renamers-Files-Properties-Resources-StatusUpdate_RenamingFilesInFolders'></a>
### StatusUpdate_RenamingFilesInFolders `property`

##### Summary

Looks up a localized string similar to Renaming files in subfolders of '{0}', replacing '{1}' with '{2}'....
