<a name='assembly'></a>
# MFR.Operations.Constants

## Contents

- [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
  - [CheckingWhetherChosenFolderContainsSolutions](#F-MFR-Operations-Constants-OperationType-CheckingWhetherChosenFolderContainsSolutions 'MFR.Operations.Constants.OperationType.CheckingWhetherChosenFolderContainsSolutions')
  - [CloseActiveSolution](#F-MFR-Operations-Constants-OperationType-CloseActiveSolution 'MFR.Operations.Constants.OperationType.CloseActiveSolution')
  - [FindVisualStudio](#F-MFR-Operations-Constants-OperationType-FindVisualStudio 'MFR.Operations.Constants.OperationType.FindVisualStudio')
  - [GetListOfAllSolutionFilesInDirectoryTree](#F-MFR-Operations-Constants-OperationType-GetListOfAllSolutionFilesInDirectoryTree 'MFR.Operations.Constants.OperationType.GetListOfAllSolutionFilesInDirectoryTree')
  - [GetTopLevelSubFolders](#F-MFR-Operations-Constants-OperationType-GetTopLevelSubFolders 'MFR.Operations.Constants.OperationType.GetTopLevelSubFolders')
  - [GettingListOfFilesToBeRenamed](#F-MFR-Operations-Constants-OperationType-GettingListOfFilesToBeRenamed 'MFR.Operations.Constants.OperationType.GettingListOfFilesToBeRenamed')
  - [LoadAllSolutionsInFolder](#F-MFR-Operations-Constants-OperationType-LoadAllSolutionsInFolder 'MFR.Operations.Constants.OperationType.LoadAllSolutionsInFolder')
  - [OpenActiveSolution](#F-MFR-Operations-Constants-OperationType-OpenActiveSolution 'MFR.Operations.Constants.OperationType.OpenActiveSolution')
  - [RenameFilesInFolder](#F-MFR-Operations-Constants-OperationType-RenameFilesInFolder 'MFR.Operations.Constants.OperationType.RenameFilesInFolder')
  - [RenameSubFolders](#F-MFR-Operations-Constants-OperationType-RenameSubFolders 'MFR.Operations.Constants.OperationType.RenameSubFolders')
  - [ReplaceTextInFiles](#F-MFR-Operations-Constants-OperationType-ReplaceTextInFiles 'MFR.Operations.Constants.OperationType.ReplaceTextInFiles')
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

<a name='F-MFR-Operations-Constants-OperationType-CheckingWhetherChosenFolderContainsSolutions'></a>
### CheckingWhetherChosenFolderContainsSolutions `constants`

##### Summary

Checking the starting folder that has been selected to ensure that it or one or
more of its subfolders contain Visual Studio Solution (*.sln) files.

<a name='F-MFR-Operations-Constants-OperationType-CloseActiveSolution'></a>
### CloseActiveSolution `constants`

##### Summary

Closes the active solution in Visual Studio.

##### Remarks

The "active" solution is defined as that which exists as a
`.sln` file in the starting (root) folder.

<a name='F-MFR-Operations-Constants-OperationType-FindVisualStudio'></a>
### FindVisualStudio `constants`

##### Summary

Finds the instance of Visual Studio that has the solution open.

##### Remarks

The particular solution is that which exists in the starting (root) folder.

<a name='F-MFR-Operations-Constants-OperationType-GetListOfAllSolutionFilesInDirectoryTree'></a>
### GetListOfAllSolutionFilesInDirectoryTree `constants`

##### Summary

We are searching for ALL files with the extension *.sln in a specific directory
tree.

<a name='F-MFR-Operations-Constants-OperationType-GetTopLevelSubFolders'></a>
### GetTopLevelSubFolders `constants`

##### Summary

Gathering a list of the top-level subfolders of the current folder.

<a name='F-MFR-Operations-Constants-OperationType-GettingListOfFilesToBeRenamed'></a>
### GettingListOfFilesToBeRenamed `constants`

##### Summary

The list of file system entries to be renamed is being retrieved.

<a name='F-MFR-Operations-Constants-OperationType-LoadAllSolutionsInFolder'></a>
### LoadAllSolutionsInFolder `constants`

##### Summary

Searches a specified folder for the paths of all the `*.sln` files within
it.



For each `*.sln` file found, opens it in its own separate instance of
Visual Studio.

<a name='F-MFR-Operations-Constants-OperationType-OpenActiveSolution'></a>
### OpenActiveSolution `constants`

##### Summary

Open the solution back up in Visual Studio.

##### Remarks

The "active" solution is defined as that which exists as a
`.sln` file in the starting (root) folder.

<a name='F-MFR-Operations-Constants-OperationType-RenameFilesInFolder'></a>
### RenameFilesInFolder `constants`

##### Summary

We are replacing text values in the names of files.

<a name='F-MFR-Operations-Constants-OperationType-RenameSubFolders'></a>
### RenameSubFolders `constants`

##### Summary

We are replacing text in the names of folders.

<a name='F-MFR-Operations-Constants-OperationType-ReplaceTextInFiles'></a>
### ReplaceTextInFiles `constants`

##### Summary

We are replacing text in the content of the files.

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
