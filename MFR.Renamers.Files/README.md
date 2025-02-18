<a name='assembly'></a>
# MFR.Renamers.Files

## Contents

- [FileRenamer](#T-MFR-Renamers-Files-FileRenamer 'MFR.Renamers.Files.FileRenamer')
  - [#ctor()](#M-MFR-Renamers-Files-FileRenamer-#ctor 'MFR.Renamers.Files.FileRenamer.#ctor')
  - [_currentOperation](#F-MFR-Renamers-Files-FileRenamer-_currentOperation 'MFR.Renamers.Files.FileRenamer._currentOperation')
  - [_rootDirectoryPath](#F-MFR-Renamers-Files-FileRenamer-_rootDirectoryPath 'MFR.Renamers.Files.FileRenamer._rootDirectoryPath')
  - [AbortRequested](#P-MFR-Renamers-Files-FileRenamer-AbortRequested 'MFR.Renamers.Files.FileRenamer.AbortRequested')
  - [CommitMessageMapper](#P-MFR-Renamers-Files-FileRenamer-CommitMessageMapper 'MFR.Renamers.Files.FileRenamer.CommitMessageMapper')
  - [ConfigProvider](#P-MFR-Renamers-Files-FileRenamer-ConfigProvider 'MFR.Renamers.Files.FileRenamer.ConfigProvider')
  - [CurrentConfig](#P-MFR-Renamers-Files-FileRenamer-CurrentConfig 'MFR.Renamers.Files.FileRenamer.CurrentConfig')
  - [CurrentOperation](#P-MFR-Renamers-Files-FileRenamer-CurrentOperation 'MFR.Renamers.Files.FileRenamer.CurrentOperation')
  - [EnabledOperations](#P-MFR-Renamers-Files-FileRenamer-EnabledOperations 'MFR.Renamers.Files.FileRenamer.EnabledOperations')
  - [FoldersToCleanup](#P-MFR-Renamers-Files-FileRenamer-FoldersToCleanup 'MFR.Renamers.Files.FileRenamer.FoldersToCleanup')
  - [Instance](#P-MFR-Renamers-Files-FileRenamer-Instance 'MFR.Renamers.Files.FileRenamer.Instance')
  - [IsBusy](#P-MFR-Renamers-Files-FileRenamer-IsBusy 'MFR.Renamers.Files.FileRenamer.IsBusy')
  - [IsStarted](#P-MFR-Renamers-Files-FileRenamer-IsStarted 'MFR.Renamers.Files.FileRenamer.IsStarted')
  - [LastSolutionFolderPath](#P-MFR-Renamers-Files-FileRenamer-LastSolutionFolderPath 'MFR.Renamers.Files.FileRenamer.LastSolutionFolderPath')
  - [LoadedSolutionProvider](#P-MFR-Renamers-Files-FileRenamer-LoadedSolutionProvider 'MFR.Renamers.Files.FileRenamer.LoadedSolutionProvider')
  - [LoadedSolutions](#P-MFR-Renamers-Files-FileRenamer-LoadedSolutions 'MFR.Renamers.Files.FileRenamer.LoadedSolutions')
  - [LocalGitInteropProvider](#P-MFR-Renamers-Files-FileRenamer-LocalGitInteropProvider 'MFR.Renamers.Files.FileRenamer.LocalGitInteropProvider')
  - [ProcessProvider](#P-MFR-Renamers-Files-FileRenamer-ProcessProvider 'MFR.Renamers.Files.FileRenamer.ProcessProvider')
  - [RootDirectoryPath](#P-MFR-Renamers-Files-FileRenamer-RootDirectoryPath 'MFR.Renamers.Files.FileRenamer.RootDirectoryPath')
  - [RootDirectoryPathValidator](#P-MFR-Renamers-Files-FileRenamer-RootDirectoryPathValidator 'MFR.Renamers.Files.FileRenamer.RootDirectoryPathValidator')
  - [SearchDirectories](#P-MFR-Renamers-Files-FileRenamer-SearchDirectories 'MFR.Renamers.Files.FileRenamer.SearchDirectories')
  - [SearchDirectoryManager](#P-MFR-Renamers-Files-FileRenamer-SearchDirectoryManager 'MFR.Renamers.Files.FileRenamer.SearchDirectoryManager')
  - [ShouldReOpenSolutions](#P-MFR-Renamers-Files-FileRenamer-ShouldReOpenSolutions 'MFR.Renamers.Files.FileRenamer.ShouldReOpenSolutions')
  - [SyncRoot](#P-MFR-Renamers-Files-FileRenamer-SyncRoot 'MFR.Renamers.Files.FileRenamer.SyncRoot')
  - [TaskPool](#P-MFR-Renamers-Files-FileRenamer-TaskPool 'MFR.Renamers.Files.FileRenamer.TaskPool')
  - [TotalReposWithPendingChanges](#P-MFR-Renamers-Files-FileRenamer-TotalReposWithPendingChanges 'MFR.Renamers.Files.FileRenamer.TotalReposWithPendingChanges')
  - [VisualStudioSolutionService](#P-MFR-Renamers-Files-FileRenamer-VisualStudioSolutionService 'MFR.Renamers.Files.FileRenamer.VisualStudioSolutionService')
  - [#cctor()](#M-MFR-Renamers-Files-FileRenamer-#cctor 'MFR.Renamers.Files.FileRenamer.#cctor')
  - [CleanFileForEntry(entry)](#M-MFR-Renamers-Files-FileRenamer-CleanFileForEntry-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Renamers.Files.FileRenamer.CleanFileForEntry(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [CleanFilesAndFolders(rootFolderPath)](#M-MFR-Renamers-Files-FileRenamer-CleanFilesAndFolders-System-String- 'MFR.Renamers.Files.FileRenamer.CleanFilesAndFolders(System.String)')
  - [CloseSolution(solution)](#M-MFR-Renamers-Files-FileRenamer-CloseSolution-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution- 'MFR.Renamers.Files.FileRenamer.CloseSolution(xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution)')
  - [ConnectToLocalGitRepoFor(entry)](#M-MFR-Renamers-Files-FileRenamer-ConnectToLocalGitRepoFor-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Renamers.Files.FileRenamer.ConnectToLocalGitRepoFor(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [DoProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-DoProcessAll-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.DoProcessAll(System.String,System.String,System.String,System.Predicate{System.String})')
  - [EmptyRecycleBin()](#M-MFR-Renamers-Files-FileRenamer-EmptyRecycleBin 'MFR.Renamers.Files.FileRenamer.EmptyRecycleBin')
  - [EnableOperations(operations)](#M-MFR-Renamers-Files-FileRenamer-EnableOperations-MFR-Operations-Constants-OperationType[]- 'MFR.Renamers.Files.FileRenamer.EnableOperations(MFR.Operations.Constants.OperationType[])')
  - [HasPendingChanges(entry)](#M-MFR-Renamers-Files-FileRenamer-HasPendingChanges-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Renamers.Files.FileRenamer.HasPendingChanges(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [InvokeProcessing(findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-InvokeProcessing-System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.InvokeProcessing(System.String,System.String,System.Predicate{System.String})')
  - [KillErrantProcesses()](#M-MFR-Renamers-Files-FileRenamer-KillErrantProcesses 'MFR.Renamers.Files.FileRenamer.KillErrantProcesses')
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
  - [OnPendingChangesToBeCommittedCounted(e)](#M-MFR-Renamers-Files-FileRenamer-OnPendingChangesToBeCommittedCounted-MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnPendingChangesToBeCommittedCounted(MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnProcessingOperation(e)](#M-MFR-Renamers-Files-FileRenamer-OnProcessingOperation-MFR-Operations-Events-ProcessingOperationEventArgs- 'MFR.Renamers.Files.FileRenamer.OnProcessingOperation(MFR.Operations.Events.ProcessingOperationEventArgs)')
  - [OnResultsToBeCommittedToGitCounted(e)](#M-MFR-Renamers-Files-FileRenamer-OnResultsToBeCommittedToGitCounted-MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnResultsToBeCommittedToGitCounted(MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnRootDirectoryPathChanged(e)](#M-MFR-Renamers-Files-FileRenamer-OnRootDirectoryPathChanged-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnRootDirectoryPathChanged(MFR.Renamers.Files.Events.RootDirectoryPathChangedEventArgs)')
  - [OnSolutionCloseFailed(e)](#M-MFR-Renamers-Files-FileRenamer-OnSolutionCloseFailed-MFR-Renamers-Files-Events-SolutionCloseFailedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnSolutionCloseFailed(MFR.Renamers.Files.Events.SolutionCloseFailedEventArgs)')
  - [OnSolutionClosed(e)](#M-MFR-Renamers-Files-FileRenamer-OnSolutionClosed-MFR-Renamers-Files-Events-SolutionClosedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnSolutionClosed(MFR.Renamers.Files.Events.SolutionClosedEventArgs)')
  - [OnSolutionFolderRenamed(e)](#M-MFR-Renamers-Files-FileRenamer-OnSolutionFolderRenamed-MFR-Events-FolderRenamedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnSolutionFolderRenamed(MFR.Events.FolderRenamedEventArgs)')
  - [OnSolutionFoldersToBeRenamedCounted(e)](#M-MFR-Renamers-Files-FileRenamer-OnSolutionFoldersToBeRenamedCounted-MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnSolutionFoldersToBeRenamedCounted(MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [OnSolutionOpenFailed(e)](#M-MFR-Renamers-Files-FileRenamer-OnSolutionOpenFailed-MFR-Renamers-Files-Events-SolutionOpenFailedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnSolutionOpenFailed(MFR.Renamers.Files.Events.SolutionOpenFailedEventArgs)')
  - [OnStarted()](#M-MFR-Renamers-Files-FileRenamer-OnStarted 'MFR.Renamers.Files.FileRenamer.OnStarted')
  - [OnStarting()](#M-MFR-Renamers-Files-FileRenamer-OnStarting 'MFR.Renamers.Files.FileRenamer.OnStarting')
  - [OnStatusUpdate(e)](#M-MFR-Renamers-Files-FileRenamer-OnStatusUpdate-MFR-Events-Common-StatusUpdateEventArgs- 'MFR.Renamers.Files.FileRenamer.OnStatusUpdate(MFR.Events.Common.StatusUpdateEventArgs)')
  - [OnSubfoldersToBeRenamedCounted(e)](#M-MFR-Renamers-Files-FileRenamer-OnSubfoldersToBeRenamedCounted-MFR-Events-FilesOrFoldersCountedEventArgs- 'MFR.Renamers.Files.FileRenamer.OnSubfoldersToBeRenamedCounted(MFR.Events.FilesOrFoldersCountedEventArgs)')
  - [ProcessAll(findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-ProcessAll-System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.ProcessAll(System.String,System.String,System.Predicate{System.String})')
  - [ProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.ProcessAll(System.String,System.String,System.String,System.Predicate{System.String})')
  - [ReleaseAllVisualStudioConnections()](#M-MFR-Renamers-Files-FileRenamer-ReleaseAllVisualStudioConnections 'MFR.Renamers.Files.FileRenamer.ReleaseAllVisualStudioConnections')
  - [RenameFileInFolderForEntry(findWhat,replaceWith,entry)](#M-MFR-Renamers-Files-FileRenamer-RenameFileInFolderForEntry-System-String,System-String,MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Renamers.Files.FileRenamer.RenameFileInFolderForEntry(System.String,System.String,MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [RenameFilesInFolder(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-RenameFilesInFolder-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.RenameFilesInFolder(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RenameSolutionFolders(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-RenameSolutionFolders-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.RenameSolutionFolders(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RenameSubFoldersOf(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-RenameSubFoldersOf-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.RenameSubFoldersOf(System.String,System.String,System.String,System.Predicate{System.String})')
  - [ReopenActiveSolutions()](#M-MFR-Renamers-Files-FileRenamer-ReopenActiveSolutions 'MFR.Renamers.Files.FileRenamer.ReopenActiveSolutions')
  - [ReopenSolution(solution)](#M-MFR-Renamers-Files-FileRenamer-ReopenSolution-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution- 'MFR.Renamers.Files.FileRenamer.ReopenSolution(xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution)')
  - [ReplaceTextInFiles(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-FileRenamer-ReplaceTextInFiles-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.FileRenamer.ReplaceTextInFiles(System.String,System.String,System.String,System.Predicate{System.String})')
  - [ReportSolutionCloseFailed(pathname)](#M-MFR-Renamers-Files-FileRenamer-ReportSolutionCloseFailed-System-String- 'MFR.Renamers.Files.FileRenamer.ReportSolutionCloseFailed(System.String)')
  - [RequestAbort()](#M-MFR-Renamers-Files-FileRenamer-RequestAbort 'MFR.Renamers.Files.FileRenamer.RequestAbort')
  - [SearchForLoadedSolutions()](#M-MFR-Renamers-Files-FileRenamer-SearchForLoadedSolutions 'MFR.Renamers.Files.FileRenamer.SearchForLoadedSolutions')
  - [StartingFrom(path)](#M-MFR-Renamers-Files-FileRenamer-StartingFrom-System-String- 'MFR.Renamers.Files.FileRenamer.StartingFrom(System.String)')
  - [UpdateStatus(text,operationType,operationFinished)](#M-MFR-Renamers-Files-FileRenamer-UpdateStatus-System-String,MFR-Operations-Constants-OperationType,System-Boolean- 'MFR.Renamers.Files.FileRenamer.UpdateStatus(System.String,MFR.Operations.Constants.OperationType,System.Boolean)')
- [Resources](#T-MFR-Renamers-Files-Properties-Resources 'MFR.Renamers.Files.Properties.Resources')
  - [Command_GitAddAll](#P-MFR-Renamers-Files-Properties-Resources-Command_GitAddAll 'MFR.Renamers.Files.Properties.Resources.Command_GitAddAll')
  - [CommitMessage_AboutToUseProjectFileRenamer](#P-MFR-Renamers-Files-Properties-Resources-CommitMessage_AboutToUseProjectFileRenamer 'MFR.Renamers.Files.Properties.Resources.CommitMessage_AboutToUseProjectFileRenamer')
  - [CommitMessage_UsedProjectFileRenamer](#P-MFR-Renamers-Files-Properties-Resources-CommitMessage_UsedProjectFileRenamer 'MFR.Renamers.Files.Properties.Resources.CommitMessage_UsedProjectFileRenamer')
  - [Confirm_PerformRename](#P-MFR-Renamers-Files-Properties-Resources-Confirm_PerformRename 'MFR.Renamers.Files.Properties.Resources.Confirm_PerformRename')
  - [Culture](#P-MFR-Renamers-Files-Properties-Resources-Culture 'MFR.Renamers.Files.Properties.Resources.Culture')
  - [Error_AttemptToCloseSolutionFailed](#P-MFR-Renamers-Files-Properties-Resources-Error_AttemptToCloseSolutionFailed 'MFR.Renamers.Files.Properties.Resources.Error_AttemptToCloseSolutionFailed')
  - [Error_AttemptToOpenSolutionFailed](#P-MFR-Renamers-Files-Properties-Resources-Error_AttemptToOpenSolutionFailed 'MFR.Renamers.Files.Properties.Resources.Error_AttemptToOpenSolutionFailed')
  - [Error_NoSolutionsInRootDirectory](#P-MFR-Renamers-Files-Properties-Resources-Error_NoSolutionsInRootDirectory 'MFR.Renamers.Files.Properties.Resources.Error_NoSolutionsInRootDirectory')
  - [Error_OperationAborted](#P-MFR-Renamers-Files-Properties-Resources-Error_OperationAborted 'MFR.Renamers.Files.Properties.Resources.Error_OperationAborted')
  - [Info_AttemptingToRenameSubFolders](#P-MFR-Renamers-Files-Properties-Resources-Info_AttemptingToRenameSubFolders 'MFR.Renamers.Files.Properties.Resources.Info_AttemptingToRenameSubFolders')
  - [Info_CommittingPendingChangesToGit](#P-MFR-Renamers-Files-Properties-Resources-Info_CommittingPendingChangesToGit 'MFR.Renamers.Files.Properties.Resources.Info_CommittingPendingChangesToGit')
  - [Info_CommittingPendingChangesToGit_WithStats](#P-MFR-Renamers-Files-Properties-Resources-Info_CommittingPendingChangesToGit_WithStats 'MFR.Renamers.Files.Properties.Resources.Info_CommittingPendingChangesToGit_WithStats')
  - [Info_CommittingResultsToGit](#P-MFR-Renamers-Files-Properties-Resources-Info_CommittingResultsToGit 'MFR.Renamers.Files.Properties.Resources.Info_CommittingResultsToGit')
  - [Info_CommittingResultsToGit_WithStats](#P-MFR-Renamers-Files-Properties-Resources-Info_CommittingResultsToGit_WithStats 'MFR.Renamers.Files.Properties.Resources.Info_CommittingResultsToGit_WithStats')
  - [ResourceManager](#P-MFR-Renamers-Files-Properties-Resources-ResourceManager 'MFR.Renamers.Files.Properties.Resources.ResourceManager')
  - [StatusUpdate_AttemptingRenameSolutionFolders](#P-MFR-Renamers-Files-Properties-Resources-StatusUpdate_AttemptingRenameSolutionFolders 'MFR.Renamers.Files.Properties.Resources.StatusUpdate_AttemptingRenameSolutionFolders')
  - [StatusUpdate_FinishedRenamingSolutionFolders](#P-MFR-Renamers-Files-Properties-Resources-StatusUpdate_FinishedRenamingSolutionFolders 'MFR.Renamers.Files.Properties.Resources.StatusUpdate_FinishedRenamingSolutionFolders')
  - [StatusUpdate_RenamingFilesInFolders](#P-MFR-Renamers-Files-Properties-Resources-StatusUpdate_RenamingFilesInFolders 'MFR.Renamers.Files.Properties.Resources.StatusUpdate_RenamingFilesInFolders')
  - [Warning_FailedCommitPendingChanges](#P-MFR-Renamers-Files-Properties-Resources-Warning_FailedCommitPendingChanges 'MFR.Renamers.Files.Properties.Resources.Warning_FailedCommitPendingChanges')
  - [_release_handles](#P-MFR-Renamers-Files-Properties-Resources-_release_handles 'MFR.Renamers.Files.Properties.Resources._release_handles')

<a name='T-MFR-Renamers-Files-FileRenamer'></a>
## FileRenamer `type`

##### Namespace

MFR.Renamers.Files

##### Summary

Provides file- and folder-rename services.

##### Remarks

NOTE: Instances of this class must be composed with an instance of an
object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
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

A [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') enumeration value
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

<a name='P-MFR-Renamers-Files-FileRenamer-CommitMessageMapper'></a>
### CommitMessageMapper `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IConfigurationStringMapper](#T-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper 'MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper')
interface for commit messages.

<a name='P-MFR-Renamers-Files-FileRenamer-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

##### Remarks

This object allows access to the user config and the
actions
associated with it.

<a name='P-MFR-Renamers-Files-FileRenamer-CurrentConfig'></a>
### CurrentConfig `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

<a name='P-MFR-Renamers-Files-FileRenamer-CurrentOperation'></a>
### CurrentOperation `property`

##### Summary

Gets or sets the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
enumeration value that indicates which operation is currently being performed.

<a name='P-MFR-Renamers-Files-FileRenamer-EnabledOperations'></a>
### EnabledOperations `property`

##### Summary

Gets a reference to a collection of the
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

<a name='P-MFR-Renamers-Files-FileRenamer-FoldersToCleanup'></a>
### FoldersToCleanup `property`

##### Summary

Gets a reference to a collection, each element of which implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface.

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

<a name='P-MFR-Renamers-Files-FileRenamer-LocalGitInteropProvider'></a>
### LocalGitInteropProvider `property`

##### Summary

Gets or sets a reference to an instance of an object that implements the
[ILocalGitInteropProvider](#T-xyLOGIX-Interop-Git-Interfaces-ILocalGitInteropProvider 'xyLOGIX.Interop.Git.Interfaces.ILocalGitInteropProvider')
interface.

##### Remarks

This object provides access to Git functionality on the local machine.

<a name='P-MFR-Renamers-Files-FileRenamer-ProcessProvider'></a>
### ProcessProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProcessProvider](#T-xyLOGIX-Interop-Processes-Interfaces-IProcessProvider 'xyLOGIX.Interop.Processes.Interfaces.IProcessProvider')
interface.

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

<a name='P-MFR-Renamers-Files-FileRenamer-TaskPool'></a>
### TaskPool `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ITaskPool](#T-xyLOGIX-Pools-Tasks-Interfaces-ITaskPool 'xyLOGIX.Pools.Tasks.Interfaces.ITaskPool') interface.

<a name='P-MFR-Renamers-Files-FileRenamer-TotalReposWithPendingChanges'></a>
### TotalReposWithPendingChanges `property`

##### Summary

Gets or sets a [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') with the total changes pending
prior to the attempt to commit them.

##### Remarks

This count refers to the count of pending changes in local Git repo(s)
that existed PRIOR TO the file-renaming operations taking place.



The default value of this property is `-1`.  This indicates the property's
value has not been computed yet, or that we've begun a new round of processing.

<a name='P-MFR-Renamers-Files-FileRenamer-VisualStudioSolutionService'></a>
### VisualStudioSolutionService `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IVisualStudioSolutionService](#T-MFR-Services-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService')
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

<a name='M-MFR-Renamers-Files-FileRenamer-CleanFileForEntry-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### CleanFileForEntry(entry) `method`

##### Summary

Called to run the file-cleaning algorithm (i.e., removing NULs and other
control character(s)),

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') |  |

<a name='M-MFR-Renamers-Files-FileRenamer-CleanFilesAndFolders-System-String-'></a>
### CleanFilesAndFolders(rootFolderPath) `method`

##### Summary

Called to clean the file(s), i.e., remove `NUL`s and any other ASCII
control characters, as applicable, from the file(s) in the folder having the
pathname specified in the `rootFolderPath` parameter.

##### Returns

`true` if the operation completed successfully;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a folder where the search is to start. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [MFR.Operations.Exceptions.OperationAbortedException](#T-MFR-Operations-Exceptions-OperationAbortedException 'MFR.Operations.Exceptions.OperationAbortedException') |  |

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

<a name='M-MFR-Renamers-Files-FileRenamer-ConnectToLocalGitRepoFor-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### ConnectToLocalGitRepoFor(entry) `method`

##### Summary

Called to determine whether the `Local Git Interop Provider` object has
already been initialized for the current `entry`, or if a new
instance needs to be initialized for the specified `entry`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface that
represents a folder containing the local Git repository with which to
interoperate. |

##### Remarks

This method does nothing if a `null` reference is
passed for the argument of the `entry` parameter, the
`entry` represents a file, or if the
`entry` does not refer to a folder that exists in the file
system.



This method also does nothing if the
[LocalGitInteropProvider](#P-MFR-Renamers-Files-FileRenamer-LocalGitInteropProvider 'MFR.Renamers.Files.FileRenamer.LocalGitInteropProvider')
property already refers to a `Local Git Interop Provider` that is focused
on the specified `entry`, except that it does re-scan that
repository for changes.

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

<a name='M-MFR-Renamers-Files-FileRenamer-EmptyRecycleBin'></a>
### EmptyRecycleBin() `method`

##### Summary

Called to empty the Recycle Bin prior to the execution of the requested
operations.

##### Parameters

This method has no parameters.

<a name='M-MFR-Renamers-Files-FileRenamer-EnableOperations-MFR-Operations-Constants-OperationType[]-'></a>
### EnableOperations(operations) `method`

##### Summary

Enables this object to perform some or all of the operations specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operations | [MFR.Operations.Constants.OperationType[]](#T-MFR-Operations-Constants-OperationType[] 'MFR.Operations.Constants.OperationType[]') |  |

<a name='M-MFR-Renamers-Files-FileRenamer-HasPendingChanges-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### HasPendingChanges(entry) `method`

##### Summary

Determines if there are any pending Git changes in the repository having the
home folder corresponding to the file-system `entry`
specified.

##### Returns

`true` if the local Git repository contained by the
folder corresponding to the specified file-system `entry` has
greater than zero pending changes; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface.



This object must correspond to a folder that contains a Git repository. |

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

<a name='M-MFR-Renamers-Files-FileRenamer-KillErrantProcesses'></a>
### KillErrantProcesses() `method`

##### Summary

Forcibly kills all instances of process(es) that may be locking key file(s)
and/or folder(s).

##### Parameters

This method has no parameters.

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

<a name='M-MFR-Renamers-Files-FileRenamer-OnPendingChangesToBeCommittedCounted-MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnPendingChangesToBeCommittedCounted(e) `method`

##### Summary

Raises the
[](#E-MFR-Renamers-Files-FileRenamer-PendingChangesToBeCommittedCounted 'MFR.Renamers.Files.FileRenamer.PendingChangesToBeCommittedCounted')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') that
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

<a name='M-MFR-Renamers-Files-FileRenamer-OnResultsToBeCommittedToGitCounted-MFR-Events-FilesOrFoldersCountedEventArgs-'></a>
### OnResultsToBeCommittedToGitCounted(e) `method`

##### Summary

Raises the
[](#E-MFR-Renamers-Files-FileRenamer-ResultsToBeCommittedToGitCounted 'MFR.Renamers.Files.FileRenamer.ResultsToBeCommittedToGitCounted')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') | A [FilesOrFoldersCountedEventArgs](#T-MFR-Events-FilesOrFoldersCountedEventArgs 'MFR.Events.FilesOrFoldersCountedEventArgs') that
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

<a name='M-MFR-Renamers-Files-FileRenamer-OnSolutionOpenFailed-MFR-Renamers-Files-Events-SolutionOpenFailedEventArgs-'></a>
### OnSolutionOpenFailed(e) `method`

##### Summary

Raises the [](#E-MFR-Renamers-Files-FileRenamer-SolutionOpenFailed 'MFR.Renamers.Files.FileRenamer.SolutionOpenFailed')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Renamers.Files.Events.SolutionOpenFailedEventArgs](#T-MFR-Renamers-Files-Events-SolutionOpenFailedEventArgs 'MFR.Renamers.Files.Events.SolutionOpenFailedEventArgs') | (Required.) A
[SolutionOpenFailedEventArgs](#T-MFR-Renamers-Files-Events-SolutionOpenFailedEventArgs 'MFR.Renamers.Files.Events.SolutionOpenFailedEventArgs') that
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
[CurrentConfig](#P-MFR-Settings-Configuration-ConfigurationComposedObjectBase-CurrentConfig 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.CurrentConfig')
property has not been set prior to calling this method.



Call the
[UpdateConfiguration](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-UpdateConfiguration 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.UpdateConfiguration')
method on this object prior to calling this method. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`rootDirectoryPath`
, is passed a blank or
`null`
string for a value. |

<a name='M-MFR-Renamers-Files-FileRenamer-ReleaseAllVisualStudioConnections'></a>
### ReleaseAllVisualStudioConnections() `method`

##### Summary

Called to instruct the Windows operating system to release all references to
the currently-running instances of Visual Studio.

##### Parameters

This method has no parameters.

<a name='M-MFR-Renamers-Files-FileRenamer-RenameFileInFolderForEntry-System-String,System-String,MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### RenameFileInFolderForEntry(findWhat,replaceWith,entry) `method`

##### Summary

Renames a file for the specified file system `entry`.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the data for which to search in the name of the target file of the specified
`entry`. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
containing the data to replace the found search text with in the name of the
target file of the specified `entry`. |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') |  |

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

<a name='M-MFR-Renamers-Files-FileRenamer-ReopenActiveSolutions'></a>
### ReopenActiveSolutions() `method`

##### Summary

Attempts to reopen those Visual Studio Solution (`*.sln`) files that were
loaded in various Visual Studio instance(s) before the operation(s) were
performed.

##### Parameters

This method has no parameters.

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
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the `findWhat` parameter is blank. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the
`rootFolderPath`
cannot be located on the file system. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |
| [MFR.Operations.Exceptions.OperationAbortedException](#T-MFR-Operations-Exceptions-OperationAbortedException 'MFR.Operations.Exceptions.OperationAbortedException') | Thrown
if the operation is to be aborted, e.g., by the user clicking the 
button in the progress dialog. |

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

<a name='M-MFR-Renamers-Files-FileRenamer-SearchForLoadedSolutions'></a>
### SearchForLoadedSolutions() `method`

##### Summary

Searches for any Visual Studio Solution (`*.sln`) files that are loaded in
any currently-running instance(s) of Visual Studio.

##### Returns

`true` if more than one currently-running instance of
Visual Studio has any of the Visual Studio Solution (`*.sln`) file(s)
found in the current `Root Directory` open in them;
`false` otherwise.

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
exists on the file system; otherwise,
[DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') is thrown. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`path`, is passed a blank or `null` string
for a value. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder whose fully-qualified pathname is passed in the
`path` parameter cannot be located on the file system. |

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

<a name='P-MFR-Renamers-Files-Properties-Resources-Command_GitAddAll'></a>
### Command_GitAddAll `property`

##### Summary

Looks up a localized string similar to git add ..

<a name='P-MFR-Renamers-Files-Properties-Resources-CommitMessage_AboutToUseProjectFileRenamer'></a>
### CommitMessage_AboutToUseProjectFileRenamer `property`

##### Summary

Looks up a localized string similar to git commit -m "Latest updates on {1} at {0} {5}" -m "At {0} on {1}, the Project File Renamer was invoked to replace all occurrences of '{2}' with '{3}' in the files, folders, and names of folders of the '{4}' folder.".

<a name='P-MFR-Renamers-Files-Properties-Resources-CommitMessage_UsedProjectFileRenamer'></a>
### CommitMessage_UsedProjectFileRenamer `property`

##### Summary

Looks up a localized string similar to git commit -m "Used the Project File Renamer" -m "At {0} {5} on {1}, the Project File Renamer was used to replace all occurrences of '{2}' with '{3}' in the files, folders, and names of folders of the '{4}' folder.".

<a name='P-MFR-Renamers-Files-Properties-Resources-Confirm_PerformRename'></a>
### Confirm_PerformRename `property`

##### Summary

Looks up a localized string similar to We've noticed that you have one or more instances of Visual Studio 2019 open.

It doesn't appear that the solution containing the project to be renamed is open in any of them.

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

Looks up a localized string similar to The attempt to close the Solution '{0}' has failed..

<a name='P-MFR-Renamers-Files-Properties-Resources-Error_AttemptToOpenSolutionFailed'></a>
### Error_AttemptToOpenSolutionFailed `property`

##### Summary

Looks up a localized string similar to The attempt to open the Solution '{0}' has failed..

<a name='P-MFR-Renamers-Files-Properties-Resources-Error_NoSolutionsInRootDirectory'></a>
### Error_NoSolutionsInRootDirectory `property`

##### Summary

Looks up a localized string similar to FileRenamer.DoProcessAll: A Visual Studio Solution file could not be located in the folder '{0}'.  Stopping..

<a name='P-MFR-Renamers-Files-Properties-Resources-Error_OperationAborted'></a>
### Error_OperationAborted `property`

##### Summary

Looks up a localized string similar to The operation has been aborted..

<a name='P-MFR-Renamers-Files-Properties-Resources-Info_AttemptingToRenameSubFolders'></a>
### Info_AttemptingToRenameSubFolders `property`

##### Summary

Looks up a localized string similar to Attempting to rename subfolders of '{0}', replacing '{1}' with '{2}'....

<a name='P-MFR-Renamers-Files-Properties-Resources-Info_CommittingPendingChangesToGit'></a>
### Info_CommittingPendingChangesToGit `property`

##### Summary

Looks up a localized string similar to Committing your pending changes to Git....

<a name='P-MFR-Renamers-Files-Properties-Resources-Info_CommittingPendingChangesToGit_WithStats'></a>
### Info_CommittingPendingChangesToGit_WithStats `property`

##### Summary

Looks up a localized string similar to Committing your pending changes to Git...

{0} total pending change(s) across {1} repository(ies).

<a name='P-MFR-Renamers-Files-Properties-Resources-Info_CommittingResultsToGit'></a>
### Info_CommittingResultsToGit `property`

##### Summary

Looks up a localized string similar to Committing result(s) of operation(s) to Git....

<a name='P-MFR-Renamers-Files-Properties-Resources-Info_CommittingResultsToGit_WithStats'></a>
### Info_CommittingResultsToGit_WithStats `property`

##### Summary

Looks up a localized string similar to Committing results of operation(s) to Git...

{0} total pending change(s) across {1} repository(ies).

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

<a name='P-MFR-Renamers-Files-Properties-Resources-Warning_FailedCommitPendingChanges'></a>
### Warning_FailedCommitPendingChanges `property`

##### Summary

Looks up a localized string similar to Failed to commit pending changes to the repository you're working in.

We will still carry out the operations..

<a name='P-MFR-Renamers-Files-Properties-Resources-_release_handles'></a>
### _release_handles `property`

##### Summary

Looks up a localized string similar to @echo off
for /f "tokens=3,6,8 delims=: " %%i in ('handle /accepteula -p $PROCESS$ "$FOLDER$"') do echo Releasing %%k & handle -c %%j -y -p %%i.
