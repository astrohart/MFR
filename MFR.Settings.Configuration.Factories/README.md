<a name='assembly'></a>
# MFR.Settings.Configuration.Factories

## Contents

- [GetBlankProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Factories-GetBlankProjectFileRenamerConfig 'MFR.Settings.Configuration.Factories.GetBlankProjectFileRenamerConfig')
  - [SoleInstance()](#M-MFR-Settings-Configuration-Factories-GetBlankProjectFileRenamerConfig-SoleInstance 'MFR.Settings.Configuration.Factories.GetBlankProjectFileRenamerConfig.SoleInstance')
- [MakeNewProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig')
  - [AndFindWhat(self,findWhat)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndFindWhat-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-String- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.AndFindWhat(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.String)')
  - [AndFindWhatHistory(self,findWhatHistory)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndFindWhatHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Collections-Generic-List{System-String}- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.AndFindWhatHistory(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Collections.Generic.List{System.String})')
  - [AndIsFolded(self,isFolded)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndIsFolded-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.AndIsFolded(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Boolean)')
  - [AndMatchCase(self,matchCase)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndMatchCase-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.AndMatchCase(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Boolean)')
  - [AndMatchExactWord(self,matchExactWord)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndMatchExactWord-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.AndMatchExactWord(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Boolean)')
  - [AndReplaceWith(self,replaceWith)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndReplaceWith-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-String- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.AndReplaceWith(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.String)')
  - [AndReplaceWithHistory(self,replaceWithHistory)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndReplaceWithHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Collections-Generic-List{System-String}- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.AndReplaceWithHistory(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Collections.Generic.List{System.String})')
  - [AndSelectedOptionTab(self,selectedOptionTab)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndSelectedOptionTab-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Int32- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.AndSelectedOptionTab(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Int32)')
  - [AndShouldReOpenSolution(self,reOpenSolution)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndShouldReOpenSolution-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Nullable{System-Boolean}- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.AndShouldReOpenSolution(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Nullable{System.Boolean})')
  - [AndShouldRenameSolutionFolders(self,renameSolutionFolders)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndShouldRenameSolutionFolders-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.AndShouldRenameSolutionFolders(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Boolean)')
  - [AndShouldRenameSubFolders(self,renameSubFolders)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndShouldRenameSubFolders-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.AndShouldRenameSubFolders(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Boolean)')
  - [AndShouldReplaceTextInFiles(self,replaceTextInFiles)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndShouldReplaceTextInFiles-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.AndShouldReplaceTextInFiles(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Boolean)')
  - [AndStartingFolderHistory(self,startingFolderHistory)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndStartingFolderHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Collections-Generic-List{System-String}- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.AndStartingFolderHistory(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Collections.Generic.List{System.String})')
  - [ForStartingFolder(self,startingFolder)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-ForStartingFolder-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-String- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.ForStartingFolder(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.String)')
  - [FromScratch()](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-FromScratch 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.FromScratch')
  - [HavingInvokableOperations(self,operationsToPerform)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-HavingInvokableOperations-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Collections-Generic-IList{MFR-GUI-Models-Interfaces-IOperationTypeInfo}- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.HavingInvokableOperations(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Collections.Generic.IList{MFR.GUI.Models.Interfaces.IOperationTypeInfo})')
  - [SetIsFromCommandLine(self,isFromCommandLine)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-SetIsFromCommandLine-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.SetIsFromCommandLine(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Boolean)')
  - [ShouldAutoStart(self,autoStart)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-ShouldAutoStart-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.ShouldAutoStart(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Boolean)')
  - [ShouldCommitPendingChanges(self,shouldCommitPendingChanges)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-ShouldCommitPendingChanges-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.ShouldCommitPendingChanges(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Boolean)')
  - [ShouldCommitPostOperationChanges(self,shouldCommitPostOperationChanges)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-ShouldCommitPostOperationChanges-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.ShouldCommitPostOperationChanges(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Boolean)')
  - [ShouldRenameFilesInFolder(self,renameFiles)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-ShouldRenameFilesInFolder-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfig.ShouldRenameFilesInFolder(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,System.Boolean)')
- [Resources](#T-MFR-Settings-Configuration-Factories-Properties-Resources 'MFR.Settings.Configuration.Factories.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Factories-Properties-Resources-Culture 'MFR.Settings.Configuration.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Factories-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Factories-GetBlankProjectFileRenamerConfig'></a>
## GetBlankProjectFileRenamerConfig `type`

##### Namespace

MFR.Settings.Configuration.Factories

##### Summary

Gets the sole reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface that represents the blank config initialized with the default
invokable operations and other settings.

<a name='M-MFR-Settings-Configuration-Factories-GetBlankProjectFileRenamerConfig-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Gets a reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface that represents the blank config initialized with the default
invokable operations and other settings.

##### Returns

Reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface that represents the blank config initialized with the default
invokable operations and other settings.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig'></a>
## MakeNewProjectFileRenamerConfig `type`

##### Namespace

MFR.Settings.Configuration.Factories

##### Summary

Creates new instances of objects that implement the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface, and returns references to them.

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndFindWhat-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-String-'></a>
### AndFindWhat(self,findWhat) `method`

##### Summary

Builder extension method that initializes the
[FindWhat](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-FindWhat 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.FindWhat')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndFindWhatHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Collections-Generic-List{System-String}-'></a>
### AndFindWhatHistory(self,findWhatHistory) `method`

##### Summary

Builder extension method that initializes the
[FindWhatHistory](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-FindWhatHistory 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.FindWhatHistory')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| findWhatHistory | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | (Required.) Reference to an instance of an enumerable collection of instances
of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndIsFolded-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean-'></a>
### AndIsFolded(self,isFolded) `method`

##### Summary

Builder extension method that initializes the
[IsFolded](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-IsFolded 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.IsFolded')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| isFolded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndMatchCase-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean-'></a>
### AndMatchCase(self,matchCase) `method`

##### Summary

Builder extension method that initializes the
[MatchCase](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-MatchCase 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.MatchCase')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| matchCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndMatchExactWord-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean-'></a>
### AndMatchExactWord(self,matchExactWord) `method`

##### Summary

Builder extension method that initializes the
[MatchExactWord](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-MatchExactWord 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.MatchExactWord')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| matchExactWord | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndReplaceWith-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-String-'></a>
### AndReplaceWith(self,replaceWith) `method`

##### Summary

Builder extension method that initializes the
[ReplaceWith](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ReplaceWith 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ReplaceWith')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndReplaceWithHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Collections-Generic-List{System-String}-'></a>
### AndReplaceWithHistory(self,replaceWithHistory) `method`

##### Summary

Builder extension method that initializes the
[ReplaceWithHistory](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ReplaceWithHistory 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ReplaceWithHistory')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| replaceWithHistory | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | (Required.) Reference to an instance of an enumerable collection of instances
of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndSelectedOptionTab-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Int32-'></a>
### AndSelectedOptionTab(self,selectedOptionTab) `method`

##### Summary

Builder extension method that initializes the
[SelectedOptionTab](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-SelectedOptionTab 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.SelectedOptionTab')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| selectedOptionTab | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Reference to an instance of an object that implements the
[Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndShouldReOpenSolution-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Nullable{System-Boolean}-'></a>
### AndShouldReOpenSolution(self,reOpenSolution) `method`

##### Summary

Builder extension method that initializes the
[ReOpenSolution](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ReOpenSolution 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ReOpenSolution')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| reOpenSolution | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | (Required.) Value indicating whether any currently-loaded Solution in the
target directory should be re-loaded when the operation(s) are completed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndShouldRenameSolutionFolders-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean-'></a>
### AndShouldRenameSolutionFolders(self,renameSolutionFolders) `method`

##### Summary

Builder extension method that initializes the
[RenameSolutionFolders](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-RenameSolutionFolders 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.RenameSolutionFolders')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| renameSolutionFolders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value that indicates whether the
application should process the `Rename Folder(s) that Contain Solution(s)`
operation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndShouldRenameSubFolders-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean-'></a>
### AndShouldRenameSubFolders(self,renameSubFolders) `method`

##### Summary

Builder extension method that initializes the
[RenameSubFolders](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-RenameSubFolders 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.RenameSubFolders')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| renameSubFolders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndShouldReplaceTextInFiles-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean-'></a>
### AndShouldReplaceTextInFiles(self,replaceTextInFiles) `method`

##### Summary

Builder extension method that initializes the
[ReplaceTextInFiles](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ReplaceTextInFiles 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ReplaceTextInFiles')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| replaceTextInFiles | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-AndStartingFolderHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Collections-Generic-List{System-String}-'></a>
### AndStartingFolderHistory(self,startingFolderHistory) `method`

##### Summary

Builder extension method that initializes the
[StartingFolderHistory](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-StartingFolderHistory 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.StartingFolderHistory')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| startingFolderHistory | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | (Required.) Reference to an instance of an enumerable collection of instances
of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-ForStartingFolder-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-String-'></a>
### ForStartingFolder(self,startingFolder) `method`

##### Summary

Builder extension method that initializes the
[StartingFolder](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-StartingFolder 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.StartingFolder')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| startingFolder | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface
and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-HavingInvokableOperations-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Collections-Generic-IList{MFR-GUI-Models-Interfaces-IOperationTypeInfo}-'></a>
### HavingInvokableOperations(self,operationsToPerform) `method`

##### Summary

Builder extension method that initializes the
[InvokableOperations](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-InvokableOperations 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.InvokableOperations')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| operationsToPerform | [System.Collections.Generic.IList{MFR.GUI.Models.Interfaces.IOperationTypeInfo}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{MFR.GUI.Models.Interfaces.IOperationTypeInfo}') | (Required.) Reference to an instance of an enumerable collection of instances
of [OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo') that contains the desired
value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-SetIsFromCommandLine-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean-'></a>
### SetIsFromCommandLine(self,isFromCommandLine) `method`

##### Summary

Builder extension method that initializes the
[IsFromCommandLine](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-IsFromCommandLine 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.IsFromCommandLine')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| isFromCommandLine | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-ShouldAutoStart-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean-'></a>
### ShouldAutoStart(self,autoStart) `method`

##### Summary

Builder extension method that initializes the
[AutoStart](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-AutoStart 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.AutoStart')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| autoStart | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) Sets a value indicating whether the specified operation(s) should
be automatically processed when the application starts. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-ShouldCommitPendingChanges-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean-'></a>
### ShouldCommitPendingChanges(self,shouldCommitPendingChanges) `method`

##### Summary

Builder extension method that initializes the
[ShouldCommitPendingChanges](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ShouldCommitPendingChanges 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ShouldCommitPendingChanges')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| shouldCommitPendingChanges | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value indicating whether the
user's pending changes are to be committed prior to the start of the selected
rename operation(s). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-ShouldCommitPostOperationChanges-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean-'></a>
### ShouldCommitPostOperationChanges(self,shouldCommitPostOperationChanges) `method`

##### Summary

Builder extension method that initializes the
[ShouldCommitPostOperationChanges](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ShouldCommitPostOperationChanges 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ShouldCommitPostOperationChanges')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| shouldCommitPostOperationChanges | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value that indicates whether the
changes that this application makes are to be committed to the local Git
repository when the selected renaming operation(s) have completed their
execution. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfig-ShouldRenameFilesInFolder-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,System-Boolean-'></a>
### ShouldRenameFilesInFolder(self,renameFiles) `method`

##### Summary

Builder extension method that initializes the
[RenameFilesInFolder](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-RenameFilesInFolder 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.RenameFilesInFolder')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |
| renameFiles | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='T-MFR-Settings-Configuration-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
