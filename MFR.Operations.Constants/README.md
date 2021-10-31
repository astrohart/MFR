<a name='assembly'></a>
# MFR.Operations.Constants

## Contents

- [OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
  - [CloseActiveSolution](#F-MFR-Objects-Operations-Constants-OperationType-CloseActiveSolution 'MFR.Operations.Constants.OperationType.CloseActiveSolution')
  - [FindVisualStudio](#F-MFR-Objects-Operations-Constants-OperationType-FindVisualStudio 'MFR.Operations.Constants.OperationType.FindVisualStudio')
  - [GettingListOfFilesToBeRenamed](#F-MFR-Objects-Operations-Constants-OperationType-GettingListOfFilesToBeRenamed 'MFR.Operations.Constants.OperationType.GettingListOfFilesToBeRenamed')
  - [OpenActiveSolution](#F-MFR-Objects-Operations-Constants-OperationType-OpenActiveSolution 'MFR.Operations.Constants.OperationType.OpenActiveSolution')
  - [RenameFilesInFolder](#F-MFR-Objects-Operations-Constants-OperationType-RenameFilesInFolder 'MFR.Operations.Constants.OperationType.RenameFilesInFolder')
  - [RenameSubFolders](#F-MFR-Objects-Operations-Constants-OperationType-RenameSubFolders 'MFR.Operations.Constants.OperationType.RenameSubFolders')
  - [ReplaceTextInFiles](#F-MFR-Objects-Operations-Constants-OperationType-ReplaceTextInFiles 'MFR.Operations.Constants.OperationType.ReplaceTextInFiles')
  - [Unknown](#F-MFR-Objects-Operations-Constants-OperationType-Unknown 'MFR.Operations.Constants.OperationType.Unknown')
- [Resources](#T-MFR-Objects-Operations-Constants-Properties-Resources 'MFR.Operations.Constants.Properties.Resources')
  - [Culture](#P-MFR-Objects-Operations-Constants-Properties-Resources-Culture 'MFR.Operations.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Operations-Constants-Properties-Resources-ResourceManager 'MFR.Operations.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Operations-Constants-OperationType'></a>
## OperationType `type`

##### Namespace

MFR.Operations.Constants

##### Summary

Specifies the type of operation now being performed.

<a name='F-MFR-Objects-Operations-Constants-OperationType-CloseActiveSolution'></a>
### CloseActiveSolution `constants`

##### Summary

Closes the active solution in Visual Studio.

##### Remarks

The "active" solution is defined as that which exists as a
`.sln` file in the starting (root) folder.

<a name='F-MFR-Objects-Operations-Constants-OperationType-FindVisualStudio'></a>
### FindVisualStudio `constants`

##### Summary

Finds the instance of Visual Studio that has the solution open.

##### Remarks

The particular solution is that which exists in the starting (root) folder.

<a name='F-MFR-Objects-Operations-Constants-OperationType-GettingListOfFilesToBeRenamed'></a>
### GettingListOfFilesToBeRenamed `constants`

##### Summary

The list of file system entries to be renamed is being retrieved.

<a name='F-MFR-Objects-Operations-Constants-OperationType-OpenActiveSolution'></a>
### OpenActiveSolution `constants`

##### Summary

Open the solution back up in Visual Studio.

##### Remarks

The "active" solution is defined as that which exists as a
`.sln` file in the starting (root) folder.

<a name='F-MFR-Objects-Operations-Constants-OperationType-RenameFilesInFolder'></a>
### RenameFilesInFolder `constants`

##### Summary

We are replacing text values in the names of files.

<a name='F-MFR-Objects-Operations-Constants-OperationType-RenameSubFolders'></a>
### RenameSubFolders `constants`

##### Summary

We are replacing text in the names of folders.

<a name='F-MFR-Objects-Operations-Constants-OperationType-ReplaceTextInFiles'></a>
### ReplaceTextInFiles `constants`

##### Summary

We are replacing text in the content of the files.

<a name='F-MFR-Objects-Operations-Constants-OperationType-Unknown'></a>
### Unknown `constants`

##### Summary

Unknown operation type.

<a name='T-MFR-Objects-Operations-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Operations.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Operations-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Operations-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
