<a name='assembly'></a>
# MFR.Operations.Constants

## Contents

- [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
  - [CalculateListOfFilesToBeRenamed](#F-MFR-Operations-Constants-OperationType-CalculateListOfFilesToBeRenamed 'MFR.Operations.Constants.OperationType.CalculateListOfFilesToBeRenamed')
  - [CheckingWhetherChosenFolderContainsSolutions](#F-MFR-Operations-Constants-OperationType-CheckingWhetherChosenFolderContainsSolutions 'MFR.Operations.Constants.OperationType.CheckingWhetherChosenFolderContainsSolutions')
  - [CleanFiles](#F-MFR-Operations-Constants-OperationType-CleanFiles 'MFR.Operations.Constants.OperationType.CleanFiles')
  - [CloseActiveSolutions](#F-MFR-Operations-Constants-OperationType-CloseActiveSolutions 'MFR.Operations.Constants.OperationType.CloseActiveSolutions')
  - [CommitPendingChanges](#F-MFR-Operations-Constants-OperationType-CommitPendingChanges 'MFR.Operations.Constants.OperationType.CommitPendingChanges')
  - [CommitResultsToGit](#F-MFR-Operations-Constants-OperationType-CommitResultsToGit 'MFR.Operations.Constants.OperationType.CommitResultsToGit')
  - [FindVisualStudio](#F-MFR-Operations-Constants-OperationType-FindVisualStudio 'MFR.Operations.Constants.OperationType.FindVisualStudio')
  - [InitializeApplication](#F-MFR-Operations-Constants-OperationType-InitializeApplication 'MFR.Operations.Constants.OperationType.InitializeApplication')
  - [ListTopLevelSubFolders](#F-MFR-Operations-Constants-OperationType-ListTopLevelSubFolders 'MFR.Operations.Constants.OperationType.ListTopLevelSubFolders')
  - [LoadAllSolutionsInFolder](#F-MFR-Operations-Constants-OperationType-LoadAllSolutionsInFolder 'MFR.Operations.Constants.OperationType.LoadAllSolutionsInFolder')
  - [OpenActiveSolutions](#F-MFR-Operations-Constants-OperationType-OpenActiveSolutions 'MFR.Operations.Constants.OperationType.OpenActiveSolutions')
  - [RenameFilesInFolder](#F-MFR-Operations-Constants-OperationType-RenameFilesInFolder 'MFR.Operations.Constants.OperationType.RenameFilesInFolder')
  - [RenameSolutionFolders](#F-MFR-Operations-Constants-OperationType-RenameSolutionFolders 'MFR.Operations.Constants.OperationType.RenameSolutionFolders')
  - [RenameSubFolders](#F-MFR-Operations-Constants-OperationType-RenameSubFolders 'MFR.Operations.Constants.OperationType.RenameSubFolders')
  - [ReplaceTextInFiles](#F-MFR-Operations-Constants-OperationType-ReplaceTextInFiles 'MFR.Operations.Constants.OperationType.ReplaceTextInFiles')
  - [ScanDirectoryTreeForSolutionFiles](#F-MFR-Operations-Constants-OperationType-ScanDirectoryTreeForSolutionFiles 'MFR.Operations.Constants.OperationType.ScanDirectoryTreeForSolutionFiles')
  - [Unknown](#F-MFR-Operations-Constants-OperationType-Unknown 'MFR.Operations.Constants.OperationType.Unknown')
  - [UnloadAllSolutionsInFolder](#F-MFR-Operations-Constants-OperationType-UnloadAllSolutionsInFolder 'MFR.Operations.Constants.OperationType.UnloadAllSolutionsInFolder')
- [Resources](#T-MFR-Operations-Constants-Properties-Resources 'MFR.Operations.Constants.Properties.Resources')
  - [Culture](#P-MFR-Operations-Constants-Properties-Resources-Culture 'MFR.Operations.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Operations-Constants-Properties-Resources-ResourceManager 'MFR.Operations.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Operations-Constants-OperationType'></a>
## OperationType `type`

##### Namespace

MFR.Operations.Constants

##### Summary

Specifies the type of operation now being performed.

<a name='F-MFR-Operations-Constants-OperationType-CalculateListOfFilesToBeRenamed'></a>
### CalculateListOfFilesToBeRenamed `constants`

##### Summary

The list of file system entries to be renamed is being retrieved.

<a name='F-MFR-Operations-Constants-OperationType-CheckingWhetherChosenFolderContainsSolutions'></a>
### CheckingWhetherChosenFolderContainsSolutions `constants`

##### Summary

Checking the starting folder that has been selected to ensure that it or one or
more of its subfolders contain Visual Studio Solution (*.sln) files.

<a name='F-MFR-Operations-Constants-OperationType-CleanFiles'></a>
### CleanFiles `constants`

##### Summary

Iterates over the root directory's files and removes `NUL` character(s)
that may be present in any of the text file(s) touched by this application.

<a name='F-MFR-Operations-Constants-OperationType-CloseActiveSolutions'></a>
### CloseActiveSolutions `constants`

##### Summary

Closes the active solution in Visual Studio.

##### Remarks

The "active" solution is defined as that which exists as a
`.sln` file in the starting (root) folder.

<a name='F-MFR-Operations-Constants-OperationType-CommitPendingChanges'></a>
### CommitPendingChanges `constants`

##### Summary

Commits the user's existing pending changes to the user's local Git repository
(if one is present in the starting folder) prior to the commencement of
operation processing.

<a name='F-MFR-Operations-Constants-OperationType-CommitResultsToGit'></a>
### CommitResultsToGit `constants`

##### Summary

Commits the results of the processing of operations to the user's local Git
repository (if one is present in the starting folder) prior to the commencement
of operations.

<a name='F-MFR-Operations-Constants-OperationType-FindVisualStudio'></a>
### FindVisualStudio `constants`

##### Summary

Finds the instance of Visual Studio that has the solution open.

##### Remarks

The particular solution is that which exists in the starting (root) folder.

<a name='F-MFR-Operations-Constants-OperationType-InitializeApplication'></a>
### InitializeApplication `constants`

##### Summary

The application is loading configuration and profiles and such.

<a name='F-MFR-Operations-Constants-OperationType-ListTopLevelSubFolders'></a>
### ListTopLevelSubFolders `constants`

##### Summary

Gathering a list of the top-level subfolders of the current folder.

<a name='F-MFR-Operations-Constants-OperationType-LoadAllSolutionsInFolder'></a>
### LoadAllSolutionsInFolder `constants`

##### Summary

Searches a specified folder for the paths of all the `*.sln` files within
it.



For each `*.sln` file found, opens it in its own separate instance of
Visual Studio.

<a name='F-MFR-Operations-Constants-OperationType-OpenActiveSolutions'></a>
### OpenActiveSolutions `constants`

##### Summary

Open the solution back up in Visual Studio.

##### Remarks

The "active" solution is defined as that which exists as a
`.sln` file in the starting (root) folder.

<a name='F-MFR-Operations-Constants-OperationType-RenameFilesInFolder'></a>
### RenameFilesInFolder `constants`

##### Summary

We are replacing text values in the names of files.

<a name='F-MFR-Operations-Constants-OperationType-RenameSolutionFolders'></a>
### RenameSolutionFolders `constants`

##### Summary

The folder in which the containing Solution is itself being renamed.

<a name='F-MFR-Operations-Constants-OperationType-RenameSubFolders'></a>
### RenameSubFolders `constants`

##### Summary

We are replacing text in the names of folders.

<a name='F-MFR-Operations-Constants-OperationType-ReplaceTextInFiles'></a>
### ReplaceTextInFiles `constants`

##### Summary

We are replacing text in the content of the files.

<a name='F-MFR-Operations-Constants-OperationType-ScanDirectoryTreeForSolutionFiles'></a>
### ScanDirectoryTreeForSolutionFiles `constants`

##### Summary

We are searching for ALL files with the extension *.sln in a specific directory
tree.

<a name='F-MFR-Operations-Constants-OperationType-Unknown'></a>
### Unknown `constants`

##### Summary

Unknown operation type.

<a name='F-MFR-Operations-Constants-OperationType-UnloadAllSolutionsInFolder'></a>
### UnloadAllSolutionsInFolder `constants`

##### Summary

Unloads all `*.sln` files in a given folder, that are currently loaded
in running instances of Visual Studio.

<a name='T-MFR-Operations-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Operations.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Operations-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Operations-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
