<a name='assembly'></a>
# MFR.Settings.Configuration.Factories

## Contents

- [MakeNewConfiguration](#T-MFR-Settings-Configuration-Factories-MakeNewConfiguration 'MFR.Settings.Configuration.Factories.MakeNewConfiguration')
  - [AndFindWhat(self,findWhat)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndFindWhat-MFR-Settings-Configuration-Interfaces-IConfiguration,System-String- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.AndFindWhat(MFR.Settings.Configuration.Interfaces.IConfiguration,System.String)')
  - [AndFindWhatHistory(self,findWhatHistory)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndFindWhatHistory-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Collections-Generic-List{System-String}- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.AndFindWhatHistory(MFR.Settings.Configuration.Interfaces.IConfiguration,System.Collections.Generic.List{System.String})')
  - [AndIsFolded(self,isFolded)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndIsFolded-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.AndIsFolded(MFR.Settings.Configuration.Interfaces.IConfiguration,System.Boolean)')
  - [AndMatchCase(self,matchCase)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndMatchCase-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.AndMatchCase(MFR.Settings.Configuration.Interfaces.IConfiguration,System.Boolean)')
  - [AndMatchExactWord(self,matchExactWord)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndMatchExactWord-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.AndMatchExactWord(MFR.Settings.Configuration.Interfaces.IConfiguration,System.Boolean)')
  - [AndOperationsToPerform(self,operationsToPerform)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndOperationsToPerform-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Collections-Generic-List{MFR-GUI-Models-OperationTypeInfo}- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.AndOperationsToPerform(MFR.Settings.Configuration.Interfaces.IConfiguration,System.Collections.Generic.List{MFR.GUI.Models.OperationTypeInfo})')
  - [AndReOpenSolution(self,reOpenSolution)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndReOpenSolution-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.AndReOpenSolution(MFR.Settings.Configuration.Interfaces.IConfiguration,System.Boolean)')
  - [AndReplaceWith(self,replaceWith)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndReplaceWith-MFR-Settings-Configuration-Interfaces-IConfiguration,System-String- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.AndReplaceWith(MFR.Settings.Configuration.Interfaces.IConfiguration,System.String)')
  - [AndReplaceWithHistory(self,replaceWithHistory)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndReplaceWithHistory-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Collections-Generic-List{System-String}- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.AndReplaceWithHistory(MFR.Settings.Configuration.Interfaces.IConfiguration,System.Collections.Generic.List{System.String})')
  - [AndSelectedOptionTab(self,selectedOptionTab)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndSelectedOptionTab-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Int32- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.AndSelectedOptionTab(MFR.Settings.Configuration.Interfaces.IConfiguration,System.Int32)')
  - [AndSetRenameSubFoldersTo(self,renameSubFolders)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndSetRenameSubFoldersTo-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.AndSetRenameSubFoldersTo(MFR.Settings.Configuration.Interfaces.IConfiguration,System.Boolean)')
  - [AndSetReplaceTextInFilesTo(self,replaceTextInFiles)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndSetReplaceTextInFilesTo-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.AndSetReplaceTextInFilesTo(MFR.Settings.Configuration.Interfaces.IConfiguration,System.Boolean)')
  - [AndShouldReOpenSolution(self,reOpenSolution)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndShouldReOpenSolution-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.AndShouldReOpenSolution(MFR.Settings.Configuration.Interfaces.IConfiguration,System.Boolean)')
  - [AndStartingFolderHistory(self,startingFolderHistory)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndStartingFolderHistory-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Collections-Generic-List{System-String}- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.AndStartingFolderHistory(MFR.Settings.Configuration.Interfaces.IConfiguration,System.Collections.Generic.List{System.String})')
  - [ForStartingFolder(self,startingFolder)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-ForStartingFolder-MFR-Settings-Configuration-Interfaces-IConfiguration,System-String- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.ForStartingFolder(MFR.Settings.Configuration.Interfaces.IConfiguration,System.String)')
  - [FromScratch()](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-FromScratch 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.FromScratch')
  - [SetIsFromCommandLine(self,isFromCommandLine)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-SetIsFromCommandLine-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.SetIsFromCommandLine(MFR.Settings.Configuration.Interfaces.IConfiguration,System.Boolean)')
  - [SetRenameFilesTo(self,renameFiles)](#M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-SetRenameFilesTo-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean- 'MFR.Settings.Configuration.Factories.MakeNewConfiguration.SetRenameFilesTo(MFR.Settings.Configuration.Interfaces.IConfiguration,System.Boolean)')
- [Resources](#T-MFR-Settings-Configuration-Factories-Properties-Resources 'MFR.Settings.Configuration.Factories.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Factories-Properties-Resources-Culture 'MFR.Settings.Configuration.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Factories-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Factories-MakeNewConfiguration'></a>
## MakeNewConfiguration `type`

##### Namespace

MFR.Settings.Configuration.Factories

##### Summary

Creates new instances of objects that implement the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface, and returns references to them.

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndFindWhat-MFR-Settings-Configuration-Interfaces-IConfiguration,System-String-'></a>
### AndFindWhat(self,findWhat) `method`

##### Summary

Builder extension method that initializes the
[FindWhat](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-FindWhat 'MFR.Settings.Configuration.Interfaces.IConfiguration.FindWhat')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndFindWhatHistory-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Collections-Generic-List{System-String}-'></a>
### AndFindWhatHistory(self,findWhatHistory) `method`

##### Summary

Builder extension method that initializes the
[FindWhatHistory](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-FindWhatHistory 'MFR.Settings.Configuration.Interfaces.IConfiguration.FindWhatHistory')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| findWhatHistory | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | (Required.) Reference to an instance of an enumerable collection of instances
of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndIsFolded-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean-'></a>
### AndIsFolded(self,isFolded) `method`

##### Summary

Builder extension method that initializes the
[IsFolded](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-IsFolded 'MFR.Settings.Configuration.Interfaces.IConfiguration.IsFolded')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| isFolded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndMatchCase-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean-'></a>
### AndMatchCase(self,matchCase) `method`

##### Summary

Builder extension method that initializes the
[MatchCase](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-MatchCase 'MFR.Settings.Configuration.Interfaces.IConfiguration.MatchCase')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| matchCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndMatchExactWord-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean-'></a>
### AndMatchExactWord(self,matchExactWord) `method`

##### Summary

Builder extension method that initializes the
[MatchExactWord](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-MatchExactWord 'MFR.Settings.Configuration.Interfaces.IConfiguration.MatchExactWord')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| matchExactWord | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndOperationsToPerform-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Collections-Generic-List{MFR-GUI-Models-OperationTypeInfo}-'></a>
### AndOperationsToPerform(self,operationsToPerform) `method`

##### Summary

Builder extension method that initializes the
[OperationsToPerform](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-OperationsToPerform 'MFR.Settings.Configuration.Interfaces.IConfiguration.OperationsToPerform')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| operationsToPerform | [System.Collections.Generic.List{MFR.GUI.Models.OperationTypeInfo}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{MFR.GUI.Models.OperationTypeInfo}') | (Required.) Reference to an instance of an enumerable collection of instances
of [OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo') that contains the desired
value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndReOpenSolution-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean-'></a>
### AndReOpenSolution(self,reOpenSolution) `method`

##### Summary

Builder extension method that initializes the
[ReOpenSolution](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-ReOpenSolution 'MFR.Settings.Configuration.Interfaces.IConfiguration.ReOpenSolution')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| reOpenSolution | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndReplaceWith-MFR-Settings-Configuration-Interfaces-IConfiguration,System-String-'></a>
### AndReplaceWith(self,replaceWith) `method`

##### Summary

Builder extension method that initializes the
[ReplaceWith](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-ReplaceWith 'MFR.Settings.Configuration.Interfaces.IConfiguration.ReplaceWith')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndReplaceWithHistory-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Collections-Generic-List{System-String}-'></a>
### AndReplaceWithHistory(self,replaceWithHistory) `method`

##### Summary

Builder extension method that initializes the
[ReplaceWithHistory](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-ReplaceWithHistory 'MFR.Settings.Configuration.Interfaces.IConfiguration.ReplaceWithHistory')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| replaceWithHistory | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | (Required.) Reference to an instance of an enumerable collection of instances
of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndSelectedOptionTab-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Int32-'></a>
### AndSelectedOptionTab(self,selectedOptionTab) `method`

##### Summary

Builder extension method that initializes the
[SelectedOptionTab](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-SelectedOptionTab 'MFR.Settings.Configuration.Interfaces.IConfiguration.SelectedOptionTab')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| selectedOptionTab | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Reference to an instance of an object that implements the
[Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndSetRenameSubFoldersTo-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean-'></a>
### AndSetRenameSubFoldersTo(self,renameSubFolders) `method`

##### Summary

Builder extension method that initializes the
[RenameSubFolders](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-RenameSubFolders 'MFR.Settings.Configuration.Interfaces.IConfiguration.RenameSubFolders')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| renameSubFolders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndSetReplaceTextInFilesTo-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean-'></a>
### AndSetReplaceTextInFilesTo(self,replaceTextInFiles) `method`

##### Summary

Builder extension method that initializes the
[ReplaceTextInFiles](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-ReplaceTextInFiles 'MFR.Settings.Configuration.Interfaces.IConfiguration.ReplaceTextInFiles')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| replaceTextInFiles | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndShouldReOpenSolution-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean-'></a>
### AndShouldReOpenSolution(self,reOpenSolution) `method`

##### Summary

Builder extension method that initializes the
[ReOpenSolution](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-ReOpenSolution 'MFR.Settings.Configuration.Interfaces.IConfiguration.ReOpenSolution')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| reOpenSolution | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) Value indicating whether any currently-loaded Solution in the
target directory should be re-loaded when the operation(s) are completed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-AndStartingFolderHistory-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Collections-Generic-List{System-String}-'></a>
### AndStartingFolderHistory(self,startingFolderHistory) `method`

##### Summary

Builder extension method that initializes the
[StartingFolderHistory](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-StartingFolderHistory 'MFR.Settings.Configuration.Interfaces.IConfiguration.StartingFolderHistory')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| startingFolderHistory | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | (Required.) Reference to an instance of an enumerable collection of instances
of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-ForStartingFolder-MFR-Settings-Configuration-Interfaces-IConfiguration,System-String-'></a>
### ForStartingFolder(self,startingFolder) `method`

##### Summary

Builder extension method that initializes the
[StartingFolder](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-StartingFolder 'MFR.Settings.Configuration.Interfaces.IConfiguration.StartingFolder')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| startingFolder | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the desired value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') interface
and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-SetIsFromCommandLine-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean-'></a>
### SetIsFromCommandLine(self,isFromCommandLine) `method`

##### Summary

Builder extension method that initializes the
[IsFromCommandLine](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-IsFromCommandLine 'MFR.Settings.Configuration.Interfaces.IConfiguration.IsFromCommandLine')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface. |
| isFromCommandLine | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Settings-Configuration-Factories-MakeNewConfiguration-SetRenameFilesTo-MFR-Settings-Configuration-Interfaces-IConfiguration,System-Boolean-'></a>
### SetRenameFilesTo(self,renameFiles) `method`

##### Summary

Builder extension method that initializes the
[RenameFiles](#P-MFR-Settings-Configuration-Interfaces-IConfiguration-RenameFiles 'MFR.Settings.Configuration.Interfaces.IConfiguration.RenameFiles')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
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
