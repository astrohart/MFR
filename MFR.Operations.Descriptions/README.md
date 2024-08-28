<a name='assembly'></a>
# MFR.Operations.Descriptions

## Contents

- [CalculateListOfFilesToBeRenamedOperationStartedDescription](#T-MFR-Operations-Descriptions-CalculateListOfFilesToBeRenamedOperationStartedDescription 'MFR.Operations.Descriptions.CalculateListOfFilesToBeRenamedOperationStartedDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-CalculateListOfFilesToBeRenamedOperationStartedDescription-#ctor 'MFR.Operations.Descriptions.CalculateListOfFilesToBeRenamedOperationStartedDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-CalculateListOfFilesToBeRenamedOperationStartedDescription-Instance 'MFR.Operations.Descriptions.CalculateListOfFilesToBeRenamedOperationStartedDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-CalculateListOfFilesToBeRenamedOperationStartedDescription-OperationType 'MFR.Operations.Descriptions.CalculateListOfFilesToBeRenamedOperationStartedDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-CalculateListOfFilesToBeRenamedOperationStartedDescription-Text 'MFR.Operations.Descriptions.CalculateListOfFilesToBeRenamedOperationStartedDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-CalculateListOfFilesToBeRenamedOperationStartedDescription-#cctor 'MFR.Operations.Descriptions.CalculateListOfFilesToBeRenamedOperationStartedDescription.#cctor')
- [CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription](#T-MFR-Operations-Descriptions-CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription 'MFR.Operations.Descriptions.CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription-#ctor 'MFR.Operations.Descriptions.CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription-Instance 'MFR.Operations.Descriptions.CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription-OperationType 'MFR.Operations.Descriptions.CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription-Text 'MFR.Operations.Descriptions.CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription-#cctor 'MFR.Operations.Descriptions.CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription.#cctor')
- [CleanFilesOperationDescription](#T-MFR-Operations-Descriptions-CleanFilesOperationDescription 'MFR.Operations.Descriptions.CleanFilesOperationDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-CleanFilesOperationDescription-#ctor 'MFR.Operations.Descriptions.CleanFilesOperationDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-CleanFilesOperationDescription-Instance 'MFR.Operations.Descriptions.CleanFilesOperationDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-CleanFilesOperationDescription-OperationType 'MFR.Operations.Descriptions.CleanFilesOperationDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-CleanFilesOperationDescription-Text 'MFR.Operations.Descriptions.CleanFilesOperationDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-CleanFilesOperationDescription-#cctor 'MFR.Operations.Descriptions.CleanFilesOperationDescription.#cctor')
- [CleanFilesOperationStartedDescription](#T-MFR-Operations-Descriptions-CleanFilesOperationStartedDescription 'MFR.Operations.Descriptions.CleanFilesOperationStartedDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-CleanFilesOperationStartedDescription-#ctor 'MFR.Operations.Descriptions.CleanFilesOperationStartedDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-CleanFilesOperationStartedDescription-Instance 'MFR.Operations.Descriptions.CleanFilesOperationStartedDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-CleanFilesOperationStartedDescription-OperationType 'MFR.Operations.Descriptions.CleanFilesOperationStartedDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-CleanFilesOperationStartedDescription-Text 'MFR.Operations.Descriptions.CleanFilesOperationStartedDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-CleanFilesOperationStartedDescription-#cctor 'MFR.Operations.Descriptions.CleanFilesOperationStartedDescription.#cctor')
- [CloseActiveSolutionOperationStartedDescription](#T-MFR-Operations-Descriptions-CloseActiveSolutionOperationStartedDescription 'MFR.Operations.Descriptions.CloseActiveSolutionOperationStartedDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-CloseActiveSolutionOperationStartedDescription-#ctor 'MFR.Operations.Descriptions.CloseActiveSolutionOperationStartedDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-CloseActiveSolutionOperationStartedDescription-Instance 'MFR.Operations.Descriptions.CloseActiveSolutionOperationStartedDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-CloseActiveSolutionOperationStartedDescription-OperationType 'MFR.Operations.Descriptions.CloseActiveSolutionOperationStartedDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-CloseActiveSolutionOperationStartedDescription-Text 'MFR.Operations.Descriptions.CloseActiveSolutionOperationStartedDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-CloseActiveSolutionOperationStartedDescription-#cctor 'MFR.Operations.Descriptions.CloseActiveSolutionOperationStartedDescription.#cctor')
- [CommitPendingChangesOperationDescription](#T-MFR-Operations-Descriptions-CommitPendingChangesOperationDescription 'MFR.Operations.Descriptions.CommitPendingChangesOperationDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-CommitPendingChangesOperationDescription-#ctor 'MFR.Operations.Descriptions.CommitPendingChangesOperationDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-CommitPendingChangesOperationDescription-Instance 'MFR.Operations.Descriptions.CommitPendingChangesOperationDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-CommitPendingChangesOperationDescription-OperationType 'MFR.Operations.Descriptions.CommitPendingChangesOperationDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-CommitPendingChangesOperationDescription-Text 'MFR.Operations.Descriptions.CommitPendingChangesOperationDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-CommitPendingChangesOperationDescription-#cctor 'MFR.Operations.Descriptions.CommitPendingChangesOperationDescription.#cctor')
- [CommitPendingChangesOperationStartedDescription](#T-MFR-Operations-Descriptions-CommitPendingChangesOperationStartedDescription 'MFR.Operations.Descriptions.CommitPendingChangesOperationStartedDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-CommitPendingChangesOperationStartedDescription-#ctor 'MFR.Operations.Descriptions.CommitPendingChangesOperationStartedDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-CommitPendingChangesOperationStartedDescription-Instance 'MFR.Operations.Descriptions.CommitPendingChangesOperationStartedDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-CommitPendingChangesOperationStartedDescription-OperationType 'MFR.Operations.Descriptions.CommitPendingChangesOperationStartedDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-CommitPendingChangesOperationStartedDescription-Text 'MFR.Operations.Descriptions.CommitPendingChangesOperationStartedDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-CommitPendingChangesOperationStartedDescription-#cctor 'MFR.Operations.Descriptions.CommitPendingChangesOperationStartedDescription.#cctor')
- [CommitResultsToGitOperationDescription](#T-MFR-Operations-Descriptions-CommitResultsToGitOperationDescription 'MFR.Operations.Descriptions.CommitResultsToGitOperationDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-CommitResultsToGitOperationDescription-#ctor 'MFR.Operations.Descriptions.CommitResultsToGitOperationDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-CommitResultsToGitOperationDescription-Instance 'MFR.Operations.Descriptions.CommitResultsToGitOperationDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-CommitResultsToGitOperationDescription-OperationType 'MFR.Operations.Descriptions.CommitResultsToGitOperationDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-CommitResultsToGitOperationDescription-Text 'MFR.Operations.Descriptions.CommitResultsToGitOperationDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-CommitResultsToGitOperationDescription-#cctor 'MFR.Operations.Descriptions.CommitResultsToGitOperationDescription.#cctor')
- [CommitResultsToGitOperationStartedDescription](#T-MFR-Operations-Descriptions-CommitResultsToGitOperationStartedDescription 'MFR.Operations.Descriptions.CommitResultsToGitOperationStartedDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-CommitResultsToGitOperationStartedDescription-#ctor 'MFR.Operations.Descriptions.CommitResultsToGitOperationStartedDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-CommitResultsToGitOperationStartedDescription-Instance 'MFR.Operations.Descriptions.CommitResultsToGitOperationStartedDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-CommitResultsToGitOperationStartedDescription-OperationType 'MFR.Operations.Descriptions.CommitResultsToGitOperationStartedDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-CommitResultsToGitOperationStartedDescription-Text 'MFR.Operations.Descriptions.CommitResultsToGitOperationStartedDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-CommitResultsToGitOperationStartedDescription-#cctor 'MFR.Operations.Descriptions.CommitResultsToGitOperationStartedDescription.#cctor')
- [FindVisualStudioOperationStartedDescription](#T-MFR-Operations-Descriptions-FindVisualStudioOperationStartedDescription 'MFR.Operations.Descriptions.FindVisualStudioOperationStartedDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-FindVisualStudioOperationStartedDescription-#ctor 'MFR.Operations.Descriptions.FindVisualStudioOperationStartedDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-FindVisualStudioOperationStartedDescription-Instance 'MFR.Operations.Descriptions.FindVisualStudioOperationStartedDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-FindVisualStudioOperationStartedDescription-OperationType 'MFR.Operations.Descriptions.FindVisualStudioOperationStartedDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-FindVisualStudioOperationStartedDescription-Text 'MFR.Operations.Descriptions.FindVisualStudioOperationStartedDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-FindVisualStudioOperationStartedDescription-#cctor 'MFR.Operations.Descriptions.FindVisualStudioOperationStartedDescription.#cctor')
- [InitializeApplicationOperationStartedDescription](#T-MFR-Operations-Descriptions-InitializeApplicationOperationStartedDescription 'MFR.Operations.Descriptions.InitializeApplicationOperationStartedDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-InitializeApplicationOperationStartedDescription-#ctor 'MFR.Operations.Descriptions.InitializeApplicationOperationStartedDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-InitializeApplicationOperationStartedDescription-Instance 'MFR.Operations.Descriptions.InitializeApplicationOperationStartedDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-InitializeApplicationOperationStartedDescription-OperationType 'MFR.Operations.Descriptions.InitializeApplicationOperationStartedDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-InitializeApplicationOperationStartedDescription-Text 'MFR.Operations.Descriptions.InitializeApplicationOperationStartedDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-InitializeApplicationOperationStartedDescription-#cctor 'MFR.Operations.Descriptions.InitializeApplicationOperationStartedDescription.#cctor')
- [LoadAllSolutionsInFolderOperationDescription](#T-MFR-Operations-Descriptions-LoadAllSolutionsInFolderOperationDescription 'MFR.Operations.Descriptions.LoadAllSolutionsInFolderOperationDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-LoadAllSolutionsInFolderOperationDescription-#ctor 'MFR.Operations.Descriptions.LoadAllSolutionsInFolderOperationDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-LoadAllSolutionsInFolderOperationDescription-Instance 'MFR.Operations.Descriptions.LoadAllSolutionsInFolderOperationDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-LoadAllSolutionsInFolderOperationDescription-OperationType 'MFR.Operations.Descriptions.LoadAllSolutionsInFolderOperationDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-LoadAllSolutionsInFolderOperationDescription-Text 'MFR.Operations.Descriptions.LoadAllSolutionsInFolderOperationDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-LoadAllSolutionsInFolderOperationDescription-#cctor 'MFR.Operations.Descriptions.LoadAllSolutionsInFolderOperationDescription.#cctor')
- [OpenActiveSolutionOperationStartedDescription](#T-MFR-Operations-Descriptions-OpenActiveSolutionOperationStartedDescription 'MFR.Operations.Descriptions.OpenActiveSolutionOperationStartedDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-OpenActiveSolutionOperationStartedDescription-#ctor 'MFR.Operations.Descriptions.OpenActiveSolutionOperationStartedDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-OpenActiveSolutionOperationStartedDescription-Instance 'MFR.Operations.Descriptions.OpenActiveSolutionOperationStartedDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-OpenActiveSolutionOperationStartedDescription-OperationType 'MFR.Operations.Descriptions.OpenActiveSolutionOperationStartedDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-OpenActiveSolutionOperationStartedDescription-Text 'MFR.Operations.Descriptions.OpenActiveSolutionOperationStartedDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-OpenActiveSolutionOperationStartedDescription-#cctor 'MFR.Operations.Descriptions.OpenActiveSolutionOperationStartedDescription.#cctor')
- [OperationDescriptionBase](#T-MFR-Operations-Descriptions-OperationDescriptionBase 'MFR.Operations.Descriptions.OperationDescriptionBase')
  - [OperationType](#P-MFR-Operations-Descriptions-OperationDescriptionBase-OperationType 'MFR.Operations.Descriptions.OperationDescriptionBase.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-OperationDescriptionBase-Text 'MFR.Operations.Descriptions.OperationDescriptionBase.Text')
  - [ToString()](#M-MFR-Operations-Descriptions-OperationDescriptionBase-ToString 'MFR.Operations.Descriptions.OperationDescriptionBase.ToString')
- [RenameFilesInFolderOperationDescription](#T-MFR-Operations-Descriptions-RenameFilesInFolderOperationDescription 'MFR.Operations.Descriptions.RenameFilesInFolderOperationDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-RenameFilesInFolderOperationDescription-#ctor 'MFR.Operations.Descriptions.RenameFilesInFolderOperationDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-RenameFilesInFolderOperationDescription-Instance 'MFR.Operations.Descriptions.RenameFilesInFolderOperationDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-RenameFilesInFolderOperationDescription-OperationType 'MFR.Operations.Descriptions.RenameFilesInFolderOperationDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-RenameFilesInFolderOperationDescription-Text 'MFR.Operations.Descriptions.RenameFilesInFolderOperationDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-RenameFilesInFolderOperationDescription-#cctor 'MFR.Operations.Descriptions.RenameFilesInFolderOperationDescription.#cctor')
- [RenameFilesInFolderOperationStartedDescription](#T-MFR-Operations-Descriptions-RenameFilesInFolderOperationStartedDescription 'MFR.Operations.Descriptions.RenameFilesInFolderOperationStartedDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-RenameFilesInFolderOperationStartedDescription-#ctor 'MFR.Operations.Descriptions.RenameFilesInFolderOperationStartedDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-RenameFilesInFolderOperationStartedDescription-Instance 'MFR.Operations.Descriptions.RenameFilesInFolderOperationStartedDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-RenameFilesInFolderOperationStartedDescription-OperationType 'MFR.Operations.Descriptions.RenameFilesInFolderOperationStartedDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-RenameFilesInFolderOperationStartedDescription-Text 'MFR.Operations.Descriptions.RenameFilesInFolderOperationStartedDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-RenameFilesInFolderOperationStartedDescription-#cctor 'MFR.Operations.Descriptions.RenameFilesInFolderOperationStartedDescription.#cctor')
- [RenameSolutionFoldersOperationDescription](#T-MFR-Operations-Descriptions-RenameSolutionFoldersOperationDescription 'MFR.Operations.Descriptions.RenameSolutionFoldersOperationDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-RenameSolutionFoldersOperationDescription-#ctor 'MFR.Operations.Descriptions.RenameSolutionFoldersOperationDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-RenameSolutionFoldersOperationDescription-Instance 'MFR.Operations.Descriptions.RenameSolutionFoldersOperationDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-RenameSolutionFoldersOperationDescription-OperationType 'MFR.Operations.Descriptions.RenameSolutionFoldersOperationDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-RenameSolutionFoldersOperationDescription-Text 'MFR.Operations.Descriptions.RenameSolutionFoldersOperationDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-RenameSolutionFoldersOperationDescription-#cctor 'MFR.Operations.Descriptions.RenameSolutionFoldersOperationDescription.#cctor')
- [RenameSolutionFoldersOperationStartedDescription](#T-MFR-Operations-Descriptions-RenameSolutionFoldersOperationStartedDescription 'MFR.Operations.Descriptions.RenameSolutionFoldersOperationStartedDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-RenameSolutionFoldersOperationStartedDescription-#ctor 'MFR.Operations.Descriptions.RenameSolutionFoldersOperationStartedDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-RenameSolutionFoldersOperationStartedDescription-Instance 'MFR.Operations.Descriptions.RenameSolutionFoldersOperationStartedDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-RenameSolutionFoldersOperationStartedDescription-OperationType 'MFR.Operations.Descriptions.RenameSolutionFoldersOperationStartedDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-RenameSolutionFoldersOperationStartedDescription-Text 'MFR.Operations.Descriptions.RenameSolutionFoldersOperationStartedDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-RenameSolutionFoldersOperationStartedDescription-#cctor 'MFR.Operations.Descriptions.RenameSolutionFoldersOperationStartedDescription.#cctor')
- [RenameSubFoldersOperationDescription](#T-MFR-Operations-Descriptions-RenameSubFoldersOperationDescription 'MFR.Operations.Descriptions.RenameSubFoldersOperationDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-RenameSubFoldersOperationDescription-#ctor 'MFR.Operations.Descriptions.RenameSubFoldersOperationDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-RenameSubFoldersOperationDescription-Instance 'MFR.Operations.Descriptions.RenameSubFoldersOperationDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-RenameSubFoldersOperationDescription-OperationType 'MFR.Operations.Descriptions.RenameSubFoldersOperationDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-RenameSubFoldersOperationDescription-Text 'MFR.Operations.Descriptions.RenameSubFoldersOperationDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-RenameSubFoldersOperationDescription-#cctor 'MFR.Operations.Descriptions.RenameSubFoldersOperationDescription.#cctor')
- [RenameSubFoldersOperationStartedDescription](#T-MFR-Operations-Descriptions-RenameSubFoldersOperationStartedDescription 'MFR.Operations.Descriptions.RenameSubFoldersOperationStartedDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-RenameSubFoldersOperationStartedDescription-#ctor 'MFR.Operations.Descriptions.RenameSubFoldersOperationStartedDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-RenameSubFoldersOperationStartedDescription-Instance 'MFR.Operations.Descriptions.RenameSubFoldersOperationStartedDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-RenameSubFoldersOperationStartedDescription-OperationType 'MFR.Operations.Descriptions.RenameSubFoldersOperationStartedDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-RenameSubFoldersOperationStartedDescription-Text 'MFR.Operations.Descriptions.RenameSubFoldersOperationStartedDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-RenameSubFoldersOperationStartedDescription-#cctor 'MFR.Operations.Descriptions.RenameSubFoldersOperationStartedDescription.#cctor')
- [ReplaceTextInFilesOperationDescription](#T-MFR-Operations-Descriptions-ReplaceTextInFilesOperationDescription 'MFR.Operations.Descriptions.ReplaceTextInFilesOperationDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-ReplaceTextInFilesOperationDescription-#ctor 'MFR.Operations.Descriptions.ReplaceTextInFilesOperationDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-ReplaceTextInFilesOperationDescription-Instance 'MFR.Operations.Descriptions.ReplaceTextInFilesOperationDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-ReplaceTextInFilesOperationDescription-OperationType 'MFR.Operations.Descriptions.ReplaceTextInFilesOperationDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-ReplaceTextInFilesOperationDescription-Text 'MFR.Operations.Descriptions.ReplaceTextInFilesOperationDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-ReplaceTextInFilesOperationDescription-#cctor 'MFR.Operations.Descriptions.ReplaceTextInFilesOperationDescription.#cctor')
- [ReplaceTextInFilesOperationStartedDescription](#T-MFR-Operations-Descriptions-ReplaceTextInFilesOperationStartedDescription 'MFR.Operations.Descriptions.ReplaceTextInFilesOperationStartedDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-ReplaceTextInFilesOperationStartedDescription-#ctor 'MFR.Operations.Descriptions.ReplaceTextInFilesOperationStartedDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-ReplaceTextInFilesOperationStartedDescription-Instance 'MFR.Operations.Descriptions.ReplaceTextInFilesOperationStartedDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-ReplaceTextInFilesOperationStartedDescription-OperationType 'MFR.Operations.Descriptions.ReplaceTextInFilesOperationStartedDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-ReplaceTextInFilesOperationStartedDescription-Text 'MFR.Operations.Descriptions.ReplaceTextInFilesOperationStartedDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-ReplaceTextInFilesOperationStartedDescription-#cctor 'MFR.Operations.Descriptions.ReplaceTextInFilesOperationStartedDescription.#cctor')
- [Resources](#T-MFR-Operations-Descriptions-Properties-Resources 'MFR.Operations.Descriptions.Properties.Resources')
  - [Culture](#P-MFR-Operations-Descriptions-Properties-Resources-Culture 'MFR.Operations.Descriptions.Properties.Resources.Culture')
  - [OperationDescription_CleanFiles](#P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_CleanFiles 'MFR.Operations.Descriptions.Properties.Resources.OperationDescription_CleanFiles')
  - [OperationDescription_CommitPendingChanges](#P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_CommitPendingChanges 'MFR.Operations.Descriptions.Properties.Resources.OperationDescription_CommitPendingChanges')
  - [OperationDescription_CommitResultsToGit](#P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_CommitResultsToGit 'MFR.Operations.Descriptions.Properties.Resources.OperationDescription_CommitResultsToGit')
  - [OperationDescription_LoadAllSolutionsInFolder](#P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_LoadAllSolutionsInFolder 'MFR.Operations.Descriptions.Properties.Resources.OperationDescription_LoadAllSolutionsInFolder')
  - [OperationDescription_RenameFilesInFolder](#P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_RenameFilesInFolder 'MFR.Operations.Descriptions.Properties.Resources.OperationDescription_RenameFilesInFolder')
  - [OperationDescription_RenameSolutionFolders](#P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_RenameSolutionFolders 'MFR.Operations.Descriptions.Properties.Resources.OperationDescription_RenameSolutionFolders')
  - [OperationDescription_RenameSubFolders](#P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_RenameSubFolders 'MFR.Operations.Descriptions.Properties.Resources.OperationDescription_RenameSubFolders')
  - [OperationDescription_ReplaceTextInFiles](#P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_ReplaceTextInFiles 'MFR.Operations.Descriptions.Properties.Resources.OperationDescription_ReplaceTextInFiles')
  - [OperationDescription_UnloadAllSolutionsInFolder](#P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_UnloadAllSolutionsInFolder 'MFR.Operations.Descriptions.Properties.Resources.OperationDescription_UnloadAllSolutionsInFolder')
  - [OperationStartedDescription_CalculateListOfFilesToBeRenamed](#P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_CalculateListOfFilesToBeRenamed 'MFR.Operations.Descriptions.Properties.Resources.OperationStartedDescription_CalculateListOfFilesToBeRenamed')
  - [OperationStartedDescription_CheckingWhetherChosenFolderContainsSolutions](#P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_CheckingWhetherChosenFolderContainsSolutions 'MFR.Operations.Descriptions.Properties.Resources.OperationStartedDescription_CheckingWhetherChosenFolderContainsSolutions')
  - [OperationStartedDescription_CleanFiles](#P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_CleanFiles 'MFR.Operations.Descriptions.Properties.Resources.OperationStartedDescription_CleanFiles')
  - [OperationStartedDescription_CloseActiveSolution](#P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_CloseActiveSolution 'MFR.Operations.Descriptions.Properties.Resources.OperationStartedDescription_CloseActiveSolution')
  - [OperationStartedDescription_CommitPendingChanges](#P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_CommitPendingChanges 'MFR.Operations.Descriptions.Properties.Resources.OperationStartedDescription_CommitPendingChanges')
  - [OperationStartedDescription_CommitResultsToGit](#P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_CommitResultsToGit 'MFR.Operations.Descriptions.Properties.Resources.OperationStartedDescription_CommitResultsToGit')
  - [OperationStartedDescription_FindVisualStudio](#P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_FindVisualStudio 'MFR.Operations.Descriptions.Properties.Resources.OperationStartedDescription_FindVisualStudio')
  - [OperationStartedDescription_GetListOfAllSolutionFilesInDirectoryTree](#P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_GetListOfAllSolutionFilesInDirectoryTree 'MFR.Operations.Descriptions.Properties.Resources.OperationStartedDescription_GetListOfAllSolutionFilesInDirectoryTree')
  - [OperationStartedDescription_InitializeApplication](#P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_InitializeApplication 'MFR.Operations.Descriptions.Properties.Resources.OperationStartedDescription_InitializeApplication')
  - [OperationStartedDescription_OpenActiveSolution](#P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_OpenActiveSolution 'MFR.Operations.Descriptions.Properties.Resources.OperationStartedDescription_OpenActiveSolution')
  - [OperationStartedDescription_RenameFilesInFolder](#P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_RenameFilesInFolder 'MFR.Operations.Descriptions.Properties.Resources.OperationStartedDescription_RenameFilesInFolder')
  - [OperationStartedDescription_RenameSolutionFolder](#P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_RenameSolutionFolder 'MFR.Operations.Descriptions.Properties.Resources.OperationStartedDescription_RenameSolutionFolder')
  - [OperationStartedDescription_RenameSubFolders](#P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_RenameSubFolders 'MFR.Operations.Descriptions.Properties.Resources.OperationStartedDescription_RenameSubFolders')
  - [OperationStartedDescription_ReplaceTextInFiles](#P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_ReplaceTextInFiles 'MFR.Operations.Descriptions.Properties.Resources.OperationStartedDescription_ReplaceTextInFiles')
  - [ResourceManager](#P-MFR-Operations-Descriptions-Properties-Resources-ResourceManager 'MFR.Operations.Descriptions.Properties.Resources.ResourceManager')
- [ScanDirectoryTreeForSolutionFilesOperationStartedDescription](#T-MFR-Operations-Descriptions-ScanDirectoryTreeForSolutionFilesOperationStartedDescription 'MFR.Operations.Descriptions.ScanDirectoryTreeForSolutionFilesOperationStartedDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-ScanDirectoryTreeForSolutionFilesOperationStartedDescription-#ctor 'MFR.Operations.Descriptions.ScanDirectoryTreeForSolutionFilesOperationStartedDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-ScanDirectoryTreeForSolutionFilesOperationStartedDescription-Instance 'MFR.Operations.Descriptions.ScanDirectoryTreeForSolutionFilesOperationStartedDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-ScanDirectoryTreeForSolutionFilesOperationStartedDescription-OperationType 'MFR.Operations.Descriptions.ScanDirectoryTreeForSolutionFilesOperationStartedDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-ScanDirectoryTreeForSolutionFilesOperationStartedDescription-Text 'MFR.Operations.Descriptions.ScanDirectoryTreeForSolutionFilesOperationStartedDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-ScanDirectoryTreeForSolutionFilesOperationStartedDescription-#cctor 'MFR.Operations.Descriptions.ScanDirectoryTreeForSolutionFilesOperationStartedDescription.#cctor')
- [UnloadAllSolutionsInFolderOperationDescription](#T-MFR-Operations-Descriptions-UnloadAllSolutionsInFolderOperationDescription 'MFR.Operations.Descriptions.UnloadAllSolutionsInFolderOperationDescription')
  - [#ctor()](#M-MFR-Operations-Descriptions-UnloadAllSolutionsInFolderOperationDescription-#ctor 'MFR.Operations.Descriptions.UnloadAllSolutionsInFolderOperationDescription.#ctor')
  - [Instance](#P-MFR-Operations-Descriptions-UnloadAllSolutionsInFolderOperationDescription-Instance 'MFR.Operations.Descriptions.UnloadAllSolutionsInFolderOperationDescription.Instance')
  - [OperationType](#P-MFR-Operations-Descriptions-UnloadAllSolutionsInFolderOperationDescription-OperationType 'MFR.Operations.Descriptions.UnloadAllSolutionsInFolderOperationDescription.OperationType')
  - [Text](#P-MFR-Operations-Descriptions-UnloadAllSolutionsInFolderOperationDescription-Text 'MFR.Operations.Descriptions.UnloadAllSolutionsInFolderOperationDescription.Text')
  - [#cctor()](#M-MFR-Operations-Descriptions-UnloadAllSolutionsInFolderOperationDescription-#cctor 'MFR.Operations.Descriptions.UnloadAllSolutionsInFolderOperationDescription.#cctor')

<a name='T-MFR-Operations-Descriptions-CalculateListOfFilesToBeRenamedOperationStartedDescription'></a>
## CalculateListOfFilesToBeRenamedOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user at the start of a
Rename Sub Folders Of operation.

<a name='M-MFR-Operations-Descriptions-CalculateListOfFilesToBeRenamedOperationStartedDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-CalculateListOfFilesToBeRenamedOperationStartedDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides user-friendly text that indicates we are calculating
the list of files that need to be renamed.

<a name='P-MFR-Operations-Descriptions-CalculateListOfFilesToBeRenamedOperationStartedDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-CalculateListOfFilesToBeRenamedOperationStartedDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-CalculateListOfFilesToBeRenamedOperationStartedDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription'></a>
## CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user at the start of a
Rename Sub Folders Of operation.

<a name='M-MFR-Operations-Descriptions-CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides a message that we display to the user when the
operation of checking whether a given folder even contains Visual Studio
Solutions, is starting.

<a name='P-MFR-Operations-Descriptions-CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-CheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-CleanFilesOperationDescription'></a>
## CleanFilesOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Description of the `Clean Files` operation.

<a name='M-MFR-Operations-Descriptions-CleanFilesOperationDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-CleanFilesOperationDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface.

<a name='P-MFR-Operations-Descriptions-CleanFilesOperationDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-CleanFilesOperationDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is currently being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-CleanFilesOperationDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-CleanFilesOperationStartedDescription'></a>
## CleanFilesOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user at the start of a
Replace Text In Files operation.

<a name='M-MFR-Operations-Descriptions-CleanFilesOperationStartedDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-CleanFilesOperationStartedDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that describes, using user-friendly text, that the  application is
about to begin the operation of replacing textual content within the files
under the specified starting directory according to the text-replacement
pattern that was specified by the user.

<a name='P-MFR-Operations-Descriptions-CleanFilesOperationStartedDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-CleanFilesOperationStartedDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-CleanFilesOperationStartedDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-CloseActiveSolutionOperationStartedDescription'></a>
## CloseActiveSolutionOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user at the start of an
operation that closes the active Solution containing the project(s) and file(s)
that are to be processed, before we begin moving files and renaming things.

<a name='M-MFR-Operations-Descriptions-CloseActiveSolutionOperationStartedDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-CloseActiveSolutionOperationStartedDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides a message that we display to the user when the
operation of closing the active Solution that is open in a running instance of
Visual Studio before we begin processing it.

<a name='P-MFR-Operations-Descriptions-CloseActiveSolutionOperationStartedDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-CloseActiveSolutionOperationStartedDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-CloseActiveSolutionOperationStartedDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-CommitPendingChangesOperationDescription'></a>
## CommitPendingChangesOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user during a Rename Sub
Folders Of operation.

<a name='M-MFR-Operations-Descriptions-CommitPendingChangesOperationDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-CommitPendingChangesOperationDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains to the user that
the application is currently processing committing the user's existing, pending
changes to the various local Git repository(ies) that reside within the
directory tree of the root folder, in order to baseline the current version of
the user's code.

<a name='P-MFR-Operations-Descriptions-CommitPendingChangesOperationDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-CommitPendingChangesOperationDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-CommitPendingChangesOperationDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-CommitPendingChangesOperationStartedDescription'></a>
## CommitPendingChangesOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user at the start of a
Rename Sub Folders Of operation.

<a name='M-MFR-Operations-Descriptions-CommitPendingChangesOperationStartedDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-CommitPendingChangesOperationStartedDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface and which provides user-friendly text that explains to the user that
the application is getting ready to begin the process of committing the
baseline pending changes of the user's code as it exists in the Git
repository(ies) that exist within the starting folder's directory tree.

<a name='P-MFR-Operations-Descriptions-CommitPendingChangesOperationStartedDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-CommitPendingChangesOperationStartedDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-CommitPendingChangesOperationStartedDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-CommitResultsToGitOperationDescription'></a>
## CommitResultsToGitOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user during a Rename Sub
Folders Of operation.

<a name='M-MFR-Operations-Descriptions-CommitResultsToGitOperationDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-CommitResultsToGitOperationDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains to the user that
the application is currently processing committing the results of running
the main renaming operations to the various local Git repository(ies) that reside within
the directory tree of the root folder.

<a name='P-MFR-Operations-Descriptions-CommitResultsToGitOperationDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-CommitResultsToGitOperationDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-CommitResultsToGitOperationDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-CommitResultsToGitOperationStartedDescription'></a>
## CommitResultsToGitOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user at the start of a
Rename Sub Folders Of operation.

<a name='M-MFR-Operations-Descriptions-CommitResultsToGitOperationStartedDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-CommitResultsToGitOperationStartedDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface and which provides user-friendly text that explains to the user that
the application is getting ready to begin the process of committing the results of running
the main renaming operations to the various local Git repository(ies) that reside within
the directory tree of the root folder.

<a name='P-MFR-Operations-Descriptions-CommitResultsToGitOperationStartedDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-CommitResultsToGitOperationStartedDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-CommitResultsToGitOperationStartedDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-FindVisualStudioOperationStartedDescription'></a>
## FindVisualStudioOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user at the start of a
Rename Sub Folders Of operation.

<a name='M-MFR-Operations-Descriptions-FindVisualStudioOperationStartedDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-FindVisualStudioOperationStartedDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides a user-friendly text status message that tells the user
that the application is beginning the process of determining whether the
Solution containing the project(s) and file(s) to be processed is currently
open in a running instance of Visual Studio.

<a name='P-MFR-Operations-Descriptions-FindVisualStudioOperationStartedDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-FindVisualStudioOperationStartedDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-FindVisualStudioOperationStartedDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-InitializeApplicationOperationStartedDescription'></a>
## InitializeApplicationOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user while the application is
initializing itself.

<a name='M-MFR-Operations-Descriptions-InitializeApplicationOperationStartedDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-InitializeApplicationOperationStartedDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that provides user-friendly text that indicates we are initializing
the application when it is launched.

<a name='P-MFR-Operations-Descriptions-InitializeApplicationOperationStartedDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-InitializeApplicationOperationStartedDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-InitializeApplicationOperationStartedDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-LoadAllSolutionsInFolderOperationDescription'></a>
## LoadAllSolutionsInFolderOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user during a Load All
Solutions in Folder operation.

<a name='M-MFR-Operations-Descriptions-LoadAllSolutionsInFolderOperationDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-LoadAllSolutionsInFolderOperationDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface that provides a descriptive text string that explains to the user of
the application that we are scanning a directory tree for (`*.sln`) files
that are within it, and then are opening each of them in Visual Studio.

<a name='P-MFR-Operations-Descriptions-LoadAllSolutionsInFolderOperationDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-LoadAllSolutionsInFolderOperationDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-LoadAllSolutionsInFolderOperationDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-OpenActiveSolutionOperationStartedDescription'></a>
## OpenActiveSolutionOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user at the start of a
Rename Sub Folders Of operation.

<a name='M-MFR-Operations-Descriptions-OpenActiveSolutionOperationStartedDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-OpenActiveSolutionOperationStartedDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface and which emits user-friendly text that explains that the application
is starting the operation of reloading the Visual Studio Solution(s) that
contain the item(s) that were processed.

<a name='P-MFR-Operations-Descriptions-OpenActiveSolutionOperationStartedDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-OpenActiveSolutionOperationStartedDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-OpenActiveSolutionOperationStartedDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-OperationDescriptionBase'></a>
## OperationDescriptionBase `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Defines the events, methods, properties, and behaviors for all classes that
provide text describing the description of an operation.

<a name='P-MFR-Operations-Descriptions-OperationDescriptionBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-OperationDescriptionBase-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is currently being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-OperationDescriptionBase-ToString'></a>
### ToString() `method`

##### Summary

Returns a string that represents the current object.

##### Returns

A string that represents the current object.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-RenameFilesInFolderOperationDescription'></a>
## RenameFilesInFolderOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user during a Rename
Files in Folder operation.

<a name='M-MFR-Operations-Descriptions-RenameFilesInFolderOperationDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-RenameFilesInFolderOperationDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which emits user-friendly text that describes that the
application is renaming files in a folder.

<a name='P-MFR-Operations-Descriptions-RenameFilesInFolderOperationDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-RenameFilesInFolderOperationDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-RenameFilesInFolderOperationDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-RenameFilesInFolderOperationStartedDescription'></a>
## RenameFilesInFolderOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user at the start of a Rename
Files in Folder operation.

<a name='M-MFR-Operations-Descriptions-RenameFilesInFolderOperationStartedDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-RenameFilesInFolderOperationStartedDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that explains that the application is beginning the process of
renaming files in a folder according to the search-and-replace parameters that
the user has requested.

<a name='P-MFR-Operations-Descriptions-RenameFilesInFolderOperationStartedDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-RenameFilesInFolderOperationStartedDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-RenameFilesInFolderOperationStartedDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-RenameSolutionFoldersOperationDescription'></a>
## RenameSolutionFoldersOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user during a `Rename Solution Folders` operation.

<a name='M-MFR-Operations-Descriptions-RenameSolutionFoldersOperationDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-RenameSolutionFoldersOperationDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains that the
application is currently in the process of renaming subfolders of the root
directory.

<a name='P-MFR-Operations-Descriptions-RenameSolutionFoldersOperationDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-RenameSolutionFoldersOperationDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-RenameSolutionFoldersOperationDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-RenameSolutionFoldersOperationStartedDescription'></a>
## RenameSolutionFoldersOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive, user-friendly text that is to be used in order to explain
to the user that the application is beginning the operation of renaming the
folder(s) that the Visual Studio Solution (`*.sln`) file(s) contained
within a specified directory tree live in, are to be renamed according to a
text-replacement pattern that has been specified by the user.

<a name='M-MFR-Operations-Descriptions-RenameSolutionFoldersOperationStartedDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-RenameSolutionFoldersOperationStartedDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that represents the description to display to the user when we are
beginning the operation to rename the folder that a Solution lives in.

<a name='P-MFR-Operations-Descriptions-RenameSolutionFoldersOperationStartedDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-RenameSolutionFoldersOperationStartedDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-RenameSolutionFoldersOperationStartedDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-RenameSubFoldersOperationDescription'></a>
## RenameSubFoldersOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user during a Rename Sub
Folders Of operation.

<a name='M-MFR-Operations-Descriptions-RenameSubFoldersOperationDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-RenameSubFoldersOperationDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains that the
application is currently in the process of renaming subfolders of the root
directory.

<a name='P-MFR-Operations-Descriptions-RenameSubFoldersOperationDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-RenameSubFoldersOperationDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-RenameSubFoldersOperationDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-RenameSubFoldersOperationStartedDescription'></a>
## RenameSubFoldersOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user at the start of a
Rename Sub Folders Of operation.

<a name='M-MFR-Operations-Descriptions-RenameSubFoldersOperationStartedDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-RenameSubFoldersOperationStartedDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface and which provides user-friendly text that explains to the user that
the application is getting ready to begin the process of renaming folders
within a directory tree according to a text-replacement pattern that was
specified by the user.

<a name='P-MFR-Operations-Descriptions-RenameSubFoldersOperationStartedDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-RenameSubFoldersOperationStartedDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-RenameSubFoldersOperationStartedDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-ReplaceTextInFilesOperationDescription'></a>
## ReplaceTextInFilesOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user during a Replace
Text In Files operation.

<a name='M-MFR-Operations-Descriptions-ReplaceTextInFilesOperationDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-ReplaceTextInFilesOperationDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that describes that the
operation of replacing the text in the individual files that are contained
within a given folder is proceeding.

<a name='P-MFR-Operations-Descriptions-ReplaceTextInFilesOperationDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-ReplaceTextInFilesOperationDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-ReplaceTextInFilesOperationDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-ReplaceTextInFilesOperationStartedDescription'></a>
## ReplaceTextInFilesOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user at the start of a
Replace Text In Files operation.

<a name='M-MFR-Operations-Descriptions-ReplaceTextInFilesOperationStartedDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-ReplaceTextInFilesOperationStartedDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that describes, using user-friendly text, that the  application is
about to begin the operation of replacing textual content within the files
under the specified starting directory according to the text-replacement
pattern that was specified by the user.

<a name='P-MFR-Operations-Descriptions-ReplaceTextInFilesOperationStartedDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-ReplaceTextInFilesOperationStartedDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-ReplaceTextInFilesOperationStartedDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Operations.Descriptions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Operations-Descriptions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_CleanFiles'></a>
### OperationDescription_CleanFiles `property`

##### Summary

Looks up a localized string similar to Cleaning file(s) touched by the Replace Text in Files operation....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_CommitPendingChanges'></a>
### OperationDescription_CommitPendingChanges `property`

##### Summary

Looks up a localized string similar to Committing pending changes to Git....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_CommitResultsToGit'></a>
### OperationDescription_CommitResultsToGit `property`

##### Summary

Looks up a localized string similar to Committing results of operation(s) to Git....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_LoadAllSolutionsInFolder'></a>
### OperationDescription_LoadAllSolutionsInFolder `property`

##### Summary

Looks up a localized string similar to Loading all Visual Studio Solutions in the starting folder....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_RenameFilesInFolder'></a>
### OperationDescription_RenameFilesInFolder `property`

##### Summary

Looks up a localized string similar to Renaming files...

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_RenameSolutionFolders'></a>
### OperationDescription_RenameSolutionFolders `property`

##### Summary

Looks up a localized string similar to Renaming folder(s) of Solution(s)....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_RenameSubFolders'></a>
### OperationDescription_RenameSubFolders `property`

##### Summary

Looks up a localized string similar to Renaming subfolders...

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_ReplaceTextInFiles'></a>
### OperationDescription_ReplaceTextInFiles `property`

##### Summary

Looks up a localized string similar to Replacing text in files...

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationDescription_UnloadAllSolutionsInFolder'></a>
### OperationDescription_UnloadAllSolutionsInFolder `property`

##### Summary

Looks up a localized string similar to Unloading all currenty-open Visual Studio Solutions in the starting folder....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_CalculateListOfFilesToBeRenamed'></a>
### OperationStartedDescription_CalculateListOfFilesToBeRenamed `property`

##### Summary

Looks up a localized string similar to Getting list of files to be renamed....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_CheckingWhetherChosenFolderContainsSolutions'></a>
### OperationStartedDescription_CheckingWhetherChosenFolderContainsSolutions `property`

##### Summary

Looks up a localized string similar to Checking whether the folder you selected (or its subfolders) contains a Visual Studio Solution (*.sln) file....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_CleanFiles'></a>
### OperationStartedDescription_CleanFiles `property`

##### Summary

Looks up a localized string similar to Determining which file(s) need to be cleaned....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_CloseActiveSolution'></a>
### OperationStartedDescription_CloseActiveSolution `property`

##### Summary

Looks up a localized string similar to Closing solution containing the item(s) to be processed....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_CommitPendingChanges'></a>
### OperationStartedDescription_CommitPendingChanges `property`

##### Summary

Looks up a localized string similar to Committing your existing pending change(s) to Git....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_CommitResultsToGit'></a>
### OperationStartedDescription_CommitResultsToGit `property`

##### Summary

Looks up a localized string similar to Committing the results to the Git repository(ies) that exist within the directory tree....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_FindVisualStudio'></a>
### OperationStartedDescription_FindVisualStudio `property`

##### Summary

Looks up a localized string similar to Determining whether Visual Studio is open....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_GetListOfAllSolutionFilesInDirectoryTree'></a>
### OperationStartedDescription_GetListOfAllSolutionFilesInDirectoryTree `property`

##### Summary

Looks up a localized string similar to Scanning directory tree for Visual Studio Solution (*.sln) files....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_InitializeApplication'></a>
### OperationStartedDescription_InitializeApplication `property`

##### Summary

Looks up a localized string similar to Loading user settings....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_OpenActiveSolution'></a>
### OperationStartedDescription_OpenActiveSolution `property`

##### Summary

Looks up a localized string similar to Reloading the solution(s) containing the item(s) that were processed....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_RenameFilesInFolder'></a>
### OperationStartedDescription_RenameFilesInFolder `property`

##### Summary

Looks up a localized string similar to Calculating files to be renamed...

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_RenameSolutionFolder'></a>
### OperationStartedDescription_RenameSolutionFolder `property`

##### Summary

Looks up a localized string similar to Getting ready to rename the folders of Solution(s) that happen to be within the directory tree....

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_RenameSubFolders'></a>
### OperationStartedDescription_RenameSubFolders `property`

##### Summary

Looks up a localized string similar to Calculating folders to be renamed...

<a name='P-MFR-Operations-Descriptions-Properties-Resources-OperationStartedDescription_ReplaceTextInFiles'></a>
### OperationStartedDescription_ReplaceTextInFiles `property`

##### Summary

Looks up a localized string similar to Calculating files in which to replace text...

<a name='P-MFR-Operations-Descriptions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Operations-Descriptions-ScanDirectoryTreeForSolutionFilesOperationStartedDescription'></a>
## ScanDirectoryTreeForSolutionFilesOperationStartedDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user that announces we are
beginning the process of scanning a directory tree for Visual Studio Solution (
`*.sln`) files.

<a name='M-MFR-Operations-Descriptions-ScanDirectoryTreeForSolutionFilesOperationStartedDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-ScanDirectoryTreeForSolutionFilesOperationStartedDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationStartedDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationStartedDescription 'MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription')
interface that announces we are beginning the process of scanning a directory
tree for Visual Studio Solution (`*.sln`) files.

<a name='P-MFR-Operations-Descriptions-ScanDirectoryTreeForSolutionFilesOperationStartedDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-ScanDirectoryTreeForSolutionFilesOperationStartedDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-ScanDirectoryTreeForSolutionFilesOperationStartedDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Operations-Descriptions-UnloadAllSolutionsInFolderOperationDescription'></a>
## UnloadAllSolutionsInFolderOperationDescription `type`

##### Namespace

MFR.Operations.Descriptions

##### Summary

Gets the descriptive text to be displayed to the user during a Unload
All Solutions in Folder operation.

<a name='M-MFR-Operations-Descriptions-UnloadAllSolutionsInFolderOperationDescription-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Operations-Descriptions-UnloadAllSolutionsInFolderOperationDescription-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IOperationDescription](#T-MFR-Operations-Descriptions-Interfaces-IOperationDescription 'MFR.Operations.Descriptions.Interfaces.IOperationDescription')
interface and which provides user-friendly text that explains that the
application is currently attempting to close all the instances of Visual Studio
Solution(s) that this application may be working on.

<a name='P-MFR-Operations-Descriptions-UnloadAllSolutionsInFolderOperationDescription-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='P-MFR-Operations-Descriptions-UnloadAllSolutionsInFolderOperationDescription-Text'></a>
### Text `property`

##### Summary

Gets a string to be displayed to the user, that corresponds to the
current type of operation that is being performed.

##### Remarks

It is up to the implementers of this interface to supply the proper text.

<a name='M-MFR-Operations-Descriptions-UnloadAllSolutionsInFolderOperationDescription-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.
