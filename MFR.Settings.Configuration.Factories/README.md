<a name='assembly'></a>
# MFR.Settings.Configuration.Factories

## Contents

- [MakeNewProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration')
  - [AndFindWhat(self,findWhat)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndFindWhat-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-String- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.AndFindWhat(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.String)')
  - [AndFindWhatHistory(self,findWhatHistory)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndFindWhatHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Collections-Generic-List{System-String}- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.AndFindWhatHistory(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Collections.Generic.List{System.String})')
  - [AndIsFolded(self,isFolded)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndIsFolded-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.AndIsFolded(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Boolean)')
  - [AndMatchCase(self,matchCase)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndMatchCase-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.AndMatchCase(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Boolean)')
  - [AndMatchExactWord(self,matchExactWord)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndMatchExactWord-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.AndMatchExactWord(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Boolean)')
  - [AndOperationsToPerform(self,operationsToPerform)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndOperationsToPerform-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Collections-Generic-List{MFR-GUI-Models-OperationTypeInfo}- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.AndOperationsToPerform(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Collections.Generic.List{MFR.GUI.Models.OperationTypeInfo})')
  - [AndReOpenSolution(self,reOpenSolution)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndReOpenSolution-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.AndReOpenSolution(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Boolean)')
  - [AndReplaceWith(self,replaceWith)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndReplaceWith-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-String- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.AndReplaceWith(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.String)')
  - [AndReplaceWithHistory(self,replaceWithHistory)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndReplaceWithHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Collections-Generic-List{System-String}- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.AndReplaceWithHistory(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Collections.Generic.List{System.String})')
  - [AndSelectedOptionTab(self,selectedOptionTab)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndSelectedOptionTab-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Int32- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.AndSelectedOptionTab(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Int32)')
  - [AndSetRenameSubFoldersTo(self,renameSubFolders)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndSetRenameSubFoldersTo-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.AndSetRenameSubFoldersTo(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Boolean)')
  - [AndSetReplaceTextInFilesTo(self,replaceTextInFiles)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndSetReplaceTextInFilesTo-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.AndSetReplaceTextInFilesTo(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Boolean)')
  - [AndShouldReOpenSolution(self,reOpenSolution)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndShouldReOpenSolution-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.AndShouldReOpenSolution(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Boolean)')
  - [AndStartingFolderHistory(self,startingFolderHistory)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndStartingFolderHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Collections-Generic-List{System-String}- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.AndStartingFolderHistory(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Collections.Generic.List{System.String})')
  - [ForStartingFolder(self,startingFolder)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-ForStartingFolder-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-String- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.ForStartingFolder(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.String)')
  - [FromScratch()](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-FromScratch 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.FromScratch')
  - [SetIsFromCommandLine(self,isFromCommandLine)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-SetIsFromCommandLine-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.SetIsFromCommandLine(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Boolean)')
  - [SetRenameFilesTo(self,renameFiles)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-SetRenameFilesTo-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.SetRenameFilesTo(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Boolean)')
  - [ShouldAutoStart(self,autoStart)](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-ShouldAutoStart-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.ShouldAutoStart(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.Boolean)')
- [Resources](#T-MFR-Settings-Configuration-Factories-Properties-Resources 'MFR.Settings.Configuration.Factories.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Factories-Properties-Resources-Culture 'MFR.Settings.Configuration.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Factories-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration'></a>
## MakeNewProjectFileRenamerConfiguration `type`

##### Namespace

MFR.Settings.Configuration.Factories

##### Summary

Creates new instances of objects that implement the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface, and returns references to them.

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndFindWhat-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-String-'></a>
### AndFindWhat(self,findWhat) `method`

##### Summary

Builder extension method that initializes the
[FindWhat](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-FindWhat 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.FindWhat')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndFindWhatHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Collections-Generic-List{System-String}-'></a>
### AndFindWhatHistory(self,findWhatHistory) `method`

##### Summary

Builder extension method that initializes the
[FindWhatHistory](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-FindWhatHistory 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.FindWhatHistory')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| findWhatHistory | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | (Required.) Reference to an instance of an enumerable collection of instances
of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndIsFolded-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean-'></a>
### AndIsFolded(self,isFolded) `method`

##### Summary

Builder extension method that initializes the
[IsFolded](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-IsFolded 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.IsFolded')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| isFolded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndMatchCase-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean-'></a>
### AndMatchCase(self,matchCase) `method`

##### Summary

Builder extension method that initializes the
[MatchCase](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-MatchCase 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.MatchCase')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| matchCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndMatchExactWord-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean-'></a>
### AndMatchExactWord(self,matchExactWord) `method`

##### Summary

Builder extension method that initializes the
[MatchExactWord](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-MatchExactWord 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.MatchExactWord')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| matchExactWord | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndOperationsToPerform-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Collections-Generic-List{MFR-GUI-Models-OperationTypeInfo}-'></a>
### AndOperationsToPerform(self,operationsToPerform) `method`

##### Summary

Builder extension method that initializes the
[OperationsToPerform](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-OperationsToPerform 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.OperationsToPerform')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| operationsToPerform | [System.Collections.Generic.List{MFR.GUI.Models.OperationTypeInfo}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{MFR.GUI.Models.OperationTypeInfo}') | (Required.) Reference to an instance of an enumerable collection of instances
of [OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo') that contains the desired
value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndReOpenSolution-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean-'></a>
### AndReOpenSolution(self,reOpenSolution) `method`

##### Summary

Builder extension method that initializes the
[ReOpenSolution](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-ReOpenSolution 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.ReOpenSolution')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| reOpenSolution | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndReplaceWith-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-String-'></a>
### AndReplaceWith(self,replaceWith) `method`

##### Summary

Builder extension method that initializes the
[ReplaceWith](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-ReplaceWith 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.ReplaceWith')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndReplaceWithHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Collections-Generic-List{System-String}-'></a>
### AndReplaceWithHistory(self,replaceWithHistory) `method`

##### Summary

Builder extension method that initializes the
[ReplaceWithHistory](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-ReplaceWithHistory 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.ReplaceWithHistory')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| replaceWithHistory | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | (Required.) Reference to an instance of an enumerable collection of instances
of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndSelectedOptionTab-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Int32-'></a>
### AndSelectedOptionTab(self,selectedOptionTab) `method`

##### Summary

Builder extension method that initializes the
[SelectedOptionTab](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-SelectedOptionTab 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.SelectedOptionTab')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| selectedOptionTab | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Reference to an instance of an object that implements the
[Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndSetRenameSubFoldersTo-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean-'></a>
### AndSetRenameSubFoldersTo(self,renameSubFolders) `method`

##### Summary

Builder extension method that initializes the
[RenameSubFolders](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-RenameSubFolders 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.RenameSubFolders')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| renameSubFolders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndSetReplaceTextInFilesTo-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean-'></a>
### AndSetReplaceTextInFilesTo(self,replaceTextInFiles) `method`

##### Summary

Builder extension method that initializes the
[ReplaceTextInFiles](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-ReplaceTextInFiles 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.ReplaceTextInFiles')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| replaceTextInFiles | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndShouldReOpenSolution-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean-'></a>
### AndShouldReOpenSolution(self,reOpenSolution) `method`

##### Summary

Builder extension method that initializes the
[ReOpenSolution](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-ReOpenSolution 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.ReOpenSolution')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| reOpenSolution | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) Value indicating whether any currently-loaded Solution in the
target directory should be re-loaded when the operation(s) are completed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-AndStartingFolderHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Collections-Generic-List{System-String}-'></a>
### AndStartingFolderHistory(self,startingFolderHistory) `method`

##### Summary

Builder extension method that initializes the
[StartingFolderHistory](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-StartingFolderHistory 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.StartingFolderHistory')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| startingFolderHistory | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | (Required.) Reference to an instance of an enumerable collection of instances
of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-ForStartingFolder-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-String-'></a>
### ForStartingFolder(self,startingFolder) `method`

##### Summary

Builder extension method that initializes the
[StartingFolder](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-StartingFolder 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.StartingFolder')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| startingFolder | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') interface
and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-SetIsFromCommandLine-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean-'></a>
### SetIsFromCommandLine(self,isFromCommandLine) `method`

##### Summary

Builder extension method that initializes the
[IsFromCommandLine](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-IsFromCommandLine 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.IsFromCommandLine')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| isFromCommandLine | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-SetRenameFilesTo-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean-'></a>
### SetRenameFilesTo(self,renameFiles) `method`

##### Summary

Builder extension method that initializes the
[RenameFiles](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-RenameFiles 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.RenameFiles')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| renameFiles | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-ShouldAutoStart-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-Boolean-'></a>
### ShouldAutoStart(self,autoStart) `method`

##### Summary

Builder extension method that initializes the
[AutoStart](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IProjectFileRenamerConfiguration-AutoStart 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.AutoStart')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| autoStart | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) Sets a value indicating whether the specified operation(s) should
be automatically processed when the application starts. |

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
