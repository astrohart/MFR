<a name='assembly'></a>
# MFR.Operations.Descriptions.Factories

## Contents

- [GetCalculateListOfFilesToBeRenamedOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetCalculateListOfFilesToBeRenamedOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetCalculateListOfFilesToBeRenamedOperationStartedDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetCalculateListOfFilesToBeRenamedOperationStartedDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetCalculateListOfFilesToBeRenamedOperationStartedDescription.SoleInstance')
- [GetCheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetCheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetCheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetCheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetCheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription.SoleInstance')
- [GetCleanFilesOperationDescription](#T-MFR-Operations-Descriptions-Factories-GetCleanFilesOperationDescription 'MFR.Operations.Descriptions.Factories.GetCleanFilesOperationDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetCleanFilesOperationDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetCleanFilesOperationDescription.SoleInstance')
- [GetCleanFilesOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetCleanFilesOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetCleanFilesOperationStartedDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetCleanFilesOperationStartedDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetCleanFilesOperationStartedDescription.SoleInstance')
- [GetCloseActiveSolutionOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetCloseActiveSolutionOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetCloseActiveSolutionOperationStartedDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetCloseActiveSolutionOperationStartedDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetCloseActiveSolutionOperationStartedDescription.SoleInstance')
- [GetCommitPendingChangesOperationDescription](#T-MFR-Operations-Descriptions-Factories-GetCommitPendingChangesOperationDescription 'MFR.Operations.Descriptions.Factories.GetCommitPendingChangesOperationDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetCommitPendingChangesOperationDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetCommitPendingChangesOperationDescription.SoleInstance')
- [GetCommitPendingChangesOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetCommitPendingChangesOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetCommitPendingChangesOperationStartedDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetCommitPendingChangesOperationStartedDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetCommitPendingChangesOperationStartedDescription.SoleInstance')
- [GetCommitResultsToGitOperationDescription](#T-MFR-Operations-Descriptions-Factories-GetCommitResultsToGitOperationDescription 'MFR.Operations.Descriptions.Factories.GetCommitResultsToGitOperationDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetCommitResultsToGitOperationDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetCommitResultsToGitOperationDescription.SoleInstance')
- [GetCommitResultsToGitOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetCommitResultsToGitOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetCommitResultsToGitOperationStartedDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetCommitResultsToGitOperationStartedDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetCommitResultsToGitOperationStartedDescription.SoleInstance')
- [GetFindVisualStudioOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetFindVisualStudioOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetFindVisualStudioOperationStartedDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetFindVisualStudioOperationStartedDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetFindVisualStudioOperationStartedDescription.SoleInstance')
- [GetInitializeApplicationOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetInitializeApplicationOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetInitializeApplicationOperationStartedDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetInitializeApplicationOperationStartedDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetInitializeApplicationOperationStartedDescription.SoleInstance')
- [GetLoadAllSolutionsInFolderOperationDescription](#T-MFR-Operations-Descriptions-Factories-GetLoadAllSolutionsInFolderOperationDescription 'MFR.Operations.Descriptions.Factories.GetLoadAllSolutionsInFolderOperationDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetLoadAllSolutionsInFolderOperationDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetLoadAllSolutionsInFolderOperationDescription.SoleInstance')
- [GetOpenActiveSolutionOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetOpenActiveSolutionOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetOpenActiveSolutionOperationStartedDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetOpenActiveSolutionOperationStartedDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetOpenActiveSolutionOperationStartedDescription.SoleInstance')
- [GetOperationDescription](#T-MFR-Operations-Descriptions-Factories-GetOperationDescription 'MFR.Operations.Descriptions.Factories.GetOperationDescription')
  - [For(type)](#M-MFR-Operations-Descriptions-Factories-GetOperationDescription-For-MFR-Operations-Constants-OperationType- 'MFR.Operations.Descriptions.Factories.GetOperationDescription.For(MFR.Operations.Constants.OperationType)')
- [GetOperationDescriptionText](#T-MFR-Operations-Descriptions-Factories-GetOperationDescriptionText 'MFR.Operations.Descriptions.Factories.GetOperationDescriptionText')
  - [For(type)](#M-MFR-Operations-Descriptions-Factories-GetOperationDescriptionText-For-MFR-Operations-Constants-OperationType- 'MFR.Operations.Descriptions.Factories.GetOperationDescriptionText.For(MFR.Operations.Constants.OperationType)')
- [GetOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetOperationStartedDescription')
  - [For(type)](#M-MFR-Operations-Descriptions-Factories-GetOperationStartedDescription-For-MFR-Operations-Constants-OperationType- 'MFR.Operations.Descriptions.Factories.GetOperationStartedDescription.For(MFR.Operations.Constants.OperationType)')
- [GetOperationStartedDescriptionText](#T-MFR-Operations-Descriptions-Factories-GetOperationStartedDescriptionText 'MFR.Operations.Descriptions.Factories.GetOperationStartedDescriptionText')
  - [For(type)](#M-MFR-Operations-Descriptions-Factories-GetOperationStartedDescriptionText-For-MFR-Operations-Constants-OperationType- 'MFR.Operations.Descriptions.Factories.GetOperationStartedDescriptionText.For(MFR.Operations.Constants.OperationType)')
- [GetRenameFilesInFolderOperationDescription](#T-MFR-Operations-Descriptions-Factories-GetRenameFilesInFolderOperationDescription 'MFR.Operations.Descriptions.Factories.GetRenameFilesInFolderOperationDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetRenameFilesInFolderOperationDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetRenameFilesInFolderOperationDescription.SoleInstance')
- [GetRenameFilesInFolderOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetRenameFilesInFolderOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetRenameFilesInFolderOperationStartedDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetRenameFilesInFolderOperationStartedDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetRenameFilesInFolderOperationStartedDescription.SoleInstance')
- [GetRenameSolutionFoldersOperationDescription](#T-MFR-Operations-Descriptions-Factories-GetRenameSolutionFoldersOperationDescription 'MFR.Operations.Descriptions.Factories.GetRenameSolutionFoldersOperationDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetRenameSolutionFoldersOperationDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetRenameSolutionFoldersOperationDescription.SoleInstance')
- [GetRenameSolutionFoldersOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetRenameSolutionFoldersOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetRenameSolutionFoldersOperationStartedDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetRenameSolutionFoldersOperationStartedDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetRenameSolutionFoldersOperationStartedDescription.SoleInstance')
- [GetRenameSubFoldersOperationDescription](#T-MFR-Operations-Descriptions-Factories-GetRenameSubFoldersOperationDescription 'MFR.Operations.Descriptions.Factories.GetRenameSubFoldersOperationDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetRenameSubFoldersOperationDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetRenameSubFoldersOperationDescription.SoleInstance')
- [GetRenameSubFoldersOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetRenameSubFoldersOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetRenameSubFoldersOperationStartedDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetRenameSubFoldersOperationStartedDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetRenameSubFoldersOperationStartedDescription.SoleInstance')
- [GetReplaceTextInFilesOperationDescription](#T-MFR-Operations-Descriptions-Factories-GetReplaceTextInFilesOperationDescription 'MFR.Operations.Descriptions.Factories.GetReplaceTextInFilesOperationDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetReplaceTextInFilesOperationDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetReplaceTextInFilesOperationDescription.SoleInstance')
- [GetReplaceTextInFilesOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetReplaceTextInFilesOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetReplaceTextInFilesOperationStartedDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetReplaceTextInFilesOperationStartedDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetReplaceTextInFilesOperationStartedDescription.SoleInstance')
- [GetScanDirectoryTreeForSolutionFilesOperationStartedDescription](#T-MFR-Operations-Descriptions-Factories-GetScanDirectoryTreeForSolutionFilesOperationStartedDescription 'MFR.Operations.Descriptions.Factories.GetScanDirectoryTreeForSolutionFilesOperationStartedDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetScanDirectoryTreeForSolutionFilesOperationStartedDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetScanDirectoryTreeForSolutionFilesOperationStartedDescription.SoleInstance')
- [GetUnloadAllSolutionsInFolderOperationDescription](#T-MFR-Operations-Descriptions-Factories-GetUnloadAllSolutionsInFolderOperationDescription 'MFR.Operations.Descriptions.Factories.GetUnloadAllSolutionsInFolderOperationDescription')
  - [SoleInstance()](#M-MFR-Operations-Descriptions-Factories-GetUnloadAllSolutionsInFolderOperationDescription-SoleInstance 'MFR.Operations.Descriptions.Factories.GetUnloadAllSolutionsInFolderOperationDescription.SoleInstance')
- [Resources](#T-MFR-Operations-Descriptions-Factories-Properties-Resources 'MFR.Operations.Descriptions.Factories.Properties.Resources')
  - [Culture](#P-MFR-Operations-Descriptions-Factories-Properties-Resources-Culture 'MFR.Operations.Descriptions.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Operations-Descriptions-Factories-Properties-Resources-ResourceManager 'MFR.Operations.Descriptions.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Operations-Descriptions-Factories-GetCalculateListOfFilesToBeRenamedOperationStartedDescription'></a>
## GetCalculateListOfFilesToBeRenamedOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides user-friendly text that indicates we are calculating
the list of files that need to be renamed.

<a name='M-MFR-Operations-Descriptions-Factories-GetCalculateListOfFilesToBeRenamedOperationStartedDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides user-friendly text that indicates we are calculating
the list of files that need to be renamed.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetCheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription'></a>
## GetCheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides a message that we display to the user when the
operation of checking whether a given folder even contains Visual Studio
Solutions, is starting.

<a name='M-MFR-Operations-Descriptions-Factories-GetCheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides a message that we display to the user when the
operation of checking whether a given folder even contains Visual Studio
Solutions, is starting.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetCleanFilesOperationDescription'></a>
## GetCleanFilesOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains to the user that
the application is currently processing committing the user's existing, pending
changes to the various local Git repository(ies) that reside within the
directory tree of the root folder, in order to baseline the current version of
the user's code.

<a name='M-MFR-Operations-Descriptions-Factories-GetCleanFilesOperationDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains to the user that
the application is currently processing committing the user's existing, pending
changes to the various local Git repository(ies) that reside within the
directory tree of the root folder, in order to baseline the current version of
the user's code.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetCleanFilesOperationStartedDescription'></a>
## GetCleanFilesOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides user-friendly text that indicates we are calculating
the list of files that need to be renamed.

<a name='M-MFR-Operations-Descriptions-Factories-GetCleanFilesOperationStartedDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides user-friendly text that indicates we are calculating
the list of files that need to be renamed.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetCloseActiveSolutionOperationStartedDescription'></a>
## GetCloseActiveSolutionOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides a message that we display to the user when the
operation of closing the active Solution that is open in a running instance of
Visual Studio before we begin processing it.

<a name='M-MFR-Operations-Descriptions-Factories-GetCloseActiveSolutionOperationStartedDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides a message that we display to the user when the
operation of closing the active Solution that is open in a running instance of
Visual Studio before we begin processing it.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetCommitPendingChangesOperationDescription'></a>
## GetCommitPendingChangesOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains to the user that
the application is currently processing committing the user's existing, pending
changes to the various local Git repository(ies) that reside within the
directory tree of the root folder, in order to baseline the current version of
the user's code.

<a name='M-MFR-Operations-Descriptions-Factories-GetCommitPendingChangesOperationDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains to the user that
the application is currently processing committing the user's existing, pending
changes to the various local Git repository(ies) that reside within the
directory tree of the root folder, in order to baseline the current version of
the user's code.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetCommitPendingChangesOperationStartedDescription'></a>
## GetCommitPendingChangesOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface and which provides user-friendly text that explains to the user that
the application is getting ready to begin the process of committing the
baseline pending changes of the user's code as it exists in the Git
repository(ies) that exist within the starting folder's directory tree.

<a name='M-MFR-Operations-Descriptions-Factories-GetCommitPendingChangesOperationStartedDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface and which provides user-friendly text that explains to the user that
the application is getting ready to begin the process of committing the
baseline pending changes of the user's code as it exists in the Git
repository(ies) that exist within the starting folder's directory tree.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetCommitResultsToGitOperationDescription'></a>
## GetCommitResultsToGitOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains to the user that
the application is currently processing committing the results of running
the main renaming operations to the various local Git repository(ies) that reside within
the directory tree of the root folder.

<a name='M-MFR-Operations-Descriptions-Factories-GetCommitResultsToGitOperationDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains to the user that
the application is currently processing committing the results of running
the main renaming operations to the various local Git repository(ies) that reside within
the directory tree of the root folder.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetCommitResultsToGitOperationStartedDescription'></a>
## GetCommitResultsToGitOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface and which provides user-friendly text that explains to the user that
the application is getting ready to begin the process of committing the results of running
the main renaming operations to the various local Git repository(ies) that reside within
the directory tree of the root folder.

<a name='M-MFR-Operations-Descriptions-Factories-GetCommitResultsToGitOperationStartedDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface and which provides user-friendly text that explains to the user that
the application is getting ready to begin the process of committing the results of running
the main renaming operations to the various local Git repository(ies) that reside within
the directory tree of the root folder.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetFindVisualStudioOperationStartedDescription'></a>
## GetFindVisualStudioOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides a user-friendly text status message that tells the user
that the application is beginning the process of determining whether the
Solution containing the project(s) and file(s) to be processed is currently
open in a running instance of Visual Studio.

<a name='M-MFR-Operations-Descriptions-Factories-GetFindVisualStudioOperationStartedDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides a user-friendly text status message that tells the user
that the application is beginning the process of determining whether the
Solution containing the project(s) and file(s) to be processed is currently
open in a running instance of Visual Studio.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetInitializeApplicationOperationStartedDescription'></a>
## GetInitializeApplicationOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides user-friendly text that indicates we are initializing
the application when it is launched.

<a name='M-MFR-Operations-Descriptions-Factories-GetInitializeApplicationOperationStartedDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides user-friendly text that indicates we are initializing
the application when it is launched.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetLoadAllSolutionsInFolderOperationDescription'></a>
## GetLoadAllSolutionsInFolderOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface that provides a descriptive text string that explains to the user of
the application that we are scanning a directory tree for (`*.sln`) files
that are within it, and then are opening each of them in Visual Studio.

<a name='M-MFR-Operations-Descriptions-Factories-GetLoadAllSolutionsInFolderOperationDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface that provides a descriptive text string that explains to the user of
the application that we are scanning a directory tree for (`*.sln`) files
that are within it, and then are opening each of them in Visual Studio.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetOpenActiveSolutionOperationStartedDescription'></a>
## GetOpenActiveSolutionOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface and which emits user-friendly text that explains that the application
is starting the operation of reloading the Visual Studio Solution(s) that
contain the item(s) that were processed.

<a name='M-MFR-Operations-Descriptions-Factories-GetOpenActiveSolutionOperationStartedDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface and which emits user-friendly text that explains that the application
is starting the operation of reloading the Visual Studio Solution(s) that
contain the item(s) that were processed.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetOperationDescription'></a>
## GetOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Creates instances of objects that implement the
[IOperationDescription](#T-MFR-IOperationDescription 'MFR.IOperationDescription')
interface.

<a name='M-MFR-Operations-Descriptions-Factories-GetOperationDescription-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates a new instance of an object that implements the
[IOperationDescription](#T-MFR-IOperationDescription 'MFR.IOperationDescription')
interface,
corresponding to the specified operation `type`,
and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IOperationDescription](#T-MFR-IOperationDescription 'MFR.IOperationDescription')
interface that
corresponds to the specified operation `type`, or
`null` if no such object can be located.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that specifies the operation type you want the descriptive
text for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') value
specified in the `type` parameter does not have a
corresponding Operation Description object associated with it. |

<a name='T-MFR-Operations-Descriptions-Factories-GetOperationDescriptionText'></a>
## GetOperationDescriptionText `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Obtains descriptive text [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') values that explain the
type of operation that is now being performed by the application.

<a name='M-MFR-Operations-Descriptions-Factories-GetOperationDescriptionText-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Gets a text [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value that contains user-friendly
text to describe that the application is now performing the operation of the
specified `type`.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') enumeration values that
describes what type of operation the application is performing. |

##### Remarks

If the specified `type` of operation is not supported, then
this method returns [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty').

<a name='T-MFR-Operations-Descriptions-Factories-GetOperationStartedDescription'></a>
## GetOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Obtains references to instances of objects that implement the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that change depending on the strategy desired.

<a name='M-MFR-Operations-Descriptions-Factories-GetOperationStartedDescription-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Obtains a reference to an instance of an object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface which corresponds to the specified meeting `type`.

##### Returns

Reference to the instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface which corresponds to the specific enumeration value that is specified
for the argument of the `type` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') enumeration values that
describes the type of operation that is to be performed by the application.. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if there is no corresponding concrete type defined that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface and which corresponds to the specific enumeration value that was
passed for the argument of the `type` parameter, if it is not
supported. |

##### Remarks

This method will throw an exception if there are no types implemented
that correspond to the enumeration value passed for the argument of the
`type` parameter.

<a name='T-MFR-Operations-Descriptions-Factories-GetOperationStartedDescriptionText'></a>
## GetOperationStartedDescriptionText `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Obtains text strings for the operations that this application performs, that
indicate that the desired operation is about to begin.



Such messages are useful, e.g., for display on the console or in progress
indicators.

<a name='M-MFR-Operations-Descriptions-Factories-GetOperationStartedDescriptionText-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Obtains text [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')s that indicate that the operation
of the specified `type` is about to begin.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) |

<a name='T-MFR-Operations-Descriptions-Factories-GetRenameFilesInFolderOperationDescription'></a>
## GetRenameFilesInFolderOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which emits user-friendly text that describes that the
application is renaming files in a folder.

<a name='M-MFR-Operations-Descriptions-Factories-GetRenameFilesInFolderOperationDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which emits user-friendly text that describes that the
application is renaming files in a folder.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetRenameFilesInFolderOperationStartedDescription'></a>
## GetRenameFilesInFolderOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that explains that the application is beginning the process of
renaming files in a folder according to the search-and-replace parameters that
the user has requested.

<a name='M-MFR-Operations-Descriptions-Factories-GetRenameFilesInFolderOperationStartedDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that explains that the application is beginning the process of
renaming files in a folder according to the search-and-replace parameters that
the user has requested.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetRenameSolutionFoldersOperationDescription'></a>
## GetRenameSolutionFoldersOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface that represents the text that is displayed while we are renaming the
folder(s) of Solution(s) that are found within the search directory tree.

<a name='M-MFR-Operations-Descriptions-Factories-GetRenameSolutionFoldersOperationDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface that represents the text that is displayed while we are renaming the
folder(s) of Solution(s) that are found within the search directory tree.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetRenameSolutionFoldersOperationStartedDescription'></a>
## GetRenameSolutionFoldersOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that represents the description to display to the user when we are
beginning the operation to rename the folder that a Solution lives in.

<a name='M-MFR-Operations-Descriptions-Factories-GetRenameSolutionFoldersOperationStartedDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that represents the description to display to the user when we are
beginning the operation to rename the folder that a Solution lives in.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetRenameSubFoldersOperationDescription'></a>
## GetRenameSubFoldersOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains that the
application is currently in the process of renaming subfolders of the root
directory.

<a name='M-MFR-Operations-Descriptions-Factories-GetRenameSubFoldersOperationDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains that the
application is currently in the process of renaming subfolders of the root
directory.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetRenameSubFoldersOperationStartedDescription'></a>
## GetRenameSubFoldersOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface and which provides user-friendly text that explains to the user that
the application is getting ready to begin the process of renaming folders
within a directory tree according to a text-replacement pattern that was
specified by the user.

<a name='M-MFR-Operations-Descriptions-Factories-GetRenameSubFoldersOperationStartedDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface and which provides user-friendly text that explains to the user that
the application is getting ready to begin the process of renaming folders
within a directory tree according to a text-replacement pattern that was
specified by the user.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetReplaceTextInFilesOperationDescription'></a>
## GetReplaceTextInFilesOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that describes that the
operation of replacing the text in the individual files that are contained
within a given folder is proceeding.

<a name='M-MFR-Operations-Descriptions-Factories-GetReplaceTextInFilesOperationDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface, and returns
a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that describes that the
operation of replacing the text in the individual files that are contained
within a given folder is proceeding.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetReplaceTextInFilesOperationStartedDescription'></a>
## GetReplaceTextInFilesOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that describes, using user-friendly text, that the  application is
about to begin the operation of replacing textual content within the files
under the specified starting directory according to the text-replacement
pattern that was specified by the user.

<a name='M-MFR-Operations-Descriptions-Factories-GetReplaceTextInFilesOperationStartedDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that describes, using user-friendly text, that the  application is
about to begin the operation of replacing textual content within the files
under the specified starting directory according to the text-replacement
pattern that was specified by the user.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetScanDirectoryTreeForSolutionFilesOperationStartedDescription'></a>
## GetScanDirectoryTreeForSolutionFilesOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that announces we are beginning the process of scanning a directory
tree for Visual Studio Solution (`*.sln`) files.

<a name='M-MFR-Operations-Descriptions-Factories-GetScanDirectoryTreeForSolutionFilesOperationStartedDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that announces we are beginning the process of scanning a directory
tree for Visual Studio Solution (`*.sln`) files.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-GetUnloadAllSolutionsInFolderOperationDescription'></a>
## GetUnloadAllSolutionsInFolderOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains that the
application is currently attempting to close all the instances of Visual Studio
Solution(s) that this application may be working on.

<a name='M-MFR-Operations-Descriptions-Factories-GetUnloadAllSolutionsInFolderOperationDescription-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains that the
application is currently attempting to close all the instances of Visual Studio
Solution(s) that this application may be working on.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Operations.Descriptions.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Operations-Descriptions-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Operations-Descriptions-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
