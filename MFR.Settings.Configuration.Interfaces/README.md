<a name='assembly'></a>
# MFR.Settings.Configuration.Interfaces

## Contents

- [IConfigurationComposedObject](#T-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject 'MFR.Settings.Configuration.Interfaces.IConfigurationComposedObject')
  - [CurrentConfiguration](#P-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-CurrentConfiguration 'MFR.Settings.Configuration.Interfaces.IConfigurationComposedObject.CurrentConfiguration')
  - [AndAttachConfiguration()](#M-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-AndAttachConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Settings.Configuration.Interfaces.IConfigurationComposedObject.AndAttachConfiguration(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [UpdateConfiguration(config)](#M-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Settings.Configuration.Interfaces.IConfigurationComposedObject.UpdateConfiguration(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [VerifyConfigurationAttached()](#M-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-VerifyConfigurationAttached 'MFR.Settings.Configuration.Interfaces.IConfigurationComposedObject.VerifyConfigurationAttached')
- [IFixedTextMatchingConfigurationSpecificObject](#T-MFR-Settings-Configuration-Interfaces-IFixedTextMatchingConfigurationSpecificObject 'MFR.Settings.Configuration.Interfaces.IFixedTextMatchingConfigurationSpecificObject')
  - [TextMatchingConfiguration](#P-MFR-Settings-Configuration-Interfaces-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.Settings.Configuration.Interfaces.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
- [IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
  - [AutoQuitOnCompletion](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-AutoQuitOnCompletion 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.AutoQuitOnCompletion')
  - [AutoStart](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-AutoStart 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.AutoStart')
  - [CommitAuthorEmail](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-CommitAuthorEmail 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.CommitAuthorEmail')
  - [CommitAuthorName](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-CommitAuthorName 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.CommitAuthorName')
  - [FindWhat](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-FindWhat 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.FindWhat')
  - [FindWhatHistory](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-FindWhatHistory 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.FindWhatHistory')
  - [InvokableOperations](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-InvokableOperations 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.InvokableOperations')
  - [IsFolded](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-IsFolded 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.IsFolded')
  - [IsFromCommandLine](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-IsFromCommandLine 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.IsFromCommandLine')
  - [MatchCase](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-MatchCase 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.MatchCase')
  - [MatchExactWord](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-MatchExactWord 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.MatchExactWord')
  - [PendingChangesCommitMessageFormat](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-PendingChangesCommitMessageFormat 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.PendingChangesCommitMessageFormat')
  - [PendingChangesDetailedCommitMessageFormat](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-PendingChangesDetailedCommitMessageFormat 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.PendingChangesDetailedCommitMessageFormat')
  - [PostOperationCommitMessageFormat](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-PostOperationCommitMessageFormat 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.PostOperationCommitMessageFormat')
  - [PostOperationDetailedCommitMessageFormat](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-PostOperationDetailedCommitMessageFormat 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.PostOperationDetailedCommitMessageFormat')
  - [PromptUserToReloadOpenSolution](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-PromptUserToReloadOpenSolution 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.PromptUserToReloadOpenSolution')
  - [PushChangesToRemoteWhenDone](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-PushChangesToRemoteWhenDone 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.PushChangesToRemoteWhenDone')
  - [ReOpenSolution](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ReOpenSolution 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ReOpenSolution')
  - [RenameFilesInFolder](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-RenameFilesInFolder 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.RenameFilesInFolder')
  - [RenameSolutionFolders](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-RenameSolutionFolders 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.RenameSolutionFolders')
  - [RenameSubFolders](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-RenameSubFolders 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.RenameSubFolders')
  - [ReplaceTextInFiles](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ReplaceTextInFiles 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ReplaceTextInFiles')
  - [ReplaceWith](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ReplaceWith 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ReplaceWith')
  - [ReplaceWithHistory](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ReplaceWithHistory 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ReplaceWithHistory')
  - [SelectedOptionTab](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-SelectedOptionTab 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.SelectedOptionTab')
  - [ShouldCommitPendingChanges](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ShouldCommitPendingChanges 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ShouldCommitPendingChanges')
  - [ShouldCommitPostOperationChanges](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ShouldCommitPostOperationChanges 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ShouldCommitPostOperationChanges')
  - [StartingFolder](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-StartingFolder 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.StartingFolder')
  - [StartingFolderHistory](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-StartingFolderHistory 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.StartingFolderHistory')
  - [UpdateGitOnAutoStart](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-UpdateGitOnAutoStart 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.UpdateGitOnAutoStart')
  - [Equals(obj)](#M-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-Equals-System-Object- 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.Equals(System.Object)')
  - [GetHashCode()](#M-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-GetHashCode 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.GetHashCode')
  - [Reset()](#M-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-Reset 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.Reset')
- [Resources](#T-MFR-Settings-Configuration-Interfaces-Properties-Resources 'MFR.Settings.Configuration.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Interfaces-Properties-Resources-Culture 'MFR.Settings.Configuration.Interfaces.Properties.Resources.Culture')
  - [Error_ValueCannotBeBlankOrNull](#P-MFR-Settings-Configuration-Interfaces-Properties-Resources-Error_ValueCannotBeBlankOrNull 'MFR.Settings.Configuration.Interfaces.Properties.Resources.Error_ValueCannotBeBlankOrNull')
  - [ResourceManager](#P-MFR-Settings-Configuration-Interfaces-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject'></a>
## IConfigurationComposedObject `type`

##### Namespace

MFR.Settings.Configuration.Interfaces

##### Summary

Defines the public-exposed methods and properties of an object that is
composed with an instance of another object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

<a name='P-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the [IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') interface.

<a name='M-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-AndAttachConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### AndAttachConfiguration() `method`

##### Summary

Associates user settings, in the form of an instance of an object
that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface, with
this matcher.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `config`,
is passed a `null` value. |

##### Remarks

The [IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
-implementing config object controls the behavior of this
object by dint of the settings chosen by the user at runtime.

<a name='M-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### UpdateConfiguration(config) `method`

##### Summary

Updates the `config` currently being used with a new value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the [IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') interface
which has the new settings. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `config`,
is passed a `null` value. |

##### Remarks

The settings in the object specified will be used for all matching
from this point forward.

<a name='M-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-VerifyConfigurationAttached'></a>
### VerifyConfigurationAttached() `method`

##### Summary

Verifies that config has been attached to this object.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException') | Thrown if no config data is attached to this object. |

##### Remarks

If no config is attached to this object, then a new
[ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException')
exception is thrown.

<a name='T-MFR-Settings-Configuration-Interfaces-IFixedTextMatchingConfigurationSpecificObject'></a>
## IFixedTextMatchingConfigurationSpecificObject `type`

##### Namespace

MFR.Settings.Configuration.Interfaces

##### Summary

Defines the public-exposed methods and properties of an object that is
tagged with one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values.

##### Remarks

This interface represents an object for which the operation type is immutable.

<a name='P-MFR-Settings-Configuration-Interfaces-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig'></a>
## IProjectFileRenamerConfig `type`

##### Namespace

MFR.Settings.Configuration.Interfaces

##### Summary

Defines the public-exposed methods and properties of a
config object.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-AutoQuitOnCompletion'></a>
### AutoQuitOnCompletion `property`

##### Summary

Gets or sets a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value indicating whether the
application should automatically terminate once the user's requested operations
are complete.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-AutoStart'></a>
### AutoStart `property`

##### Summary

Gets or sets a value indicating whether the specified operation(s) should be
automatically initiated when the application starts.  If this value is set to
`true` then the application quits automatically after the
specified operation(s) have been completed.

##### Remarks

This flag is ignored if this config did not originate from the command
line.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-CommitAuthorEmail'></a>
### CommitAuthorEmail `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the email address(es)
of the author(s) of commits made to a local Git repository(ies) by this
application.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-CommitAuthorName'></a>
### CommitAuthorName `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the name of the
author(s) of commits made to a local Git repository(ies) by this application.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets the text to be found that was most-recently specified
by the user.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-FindWhatHistory'></a>
### FindWhatHistory `property`

##### Summary

Gets or sets a collection of strings consisting of the most-recently
utilized values for Find What.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-InvokableOperations'></a>
### InvokableOperations `property`

##### Summary

Gets or sets a reference to a collection of instances of
[OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo') instances, that represents
all the operations the user can perform with this application.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-IsFolded'></a>
### IsFolded `property`

##### Summary

Gets a value indicating whether the form is in the Folded state.

##### Remarks

If this value is `true` when the form is loaded, then ensure
that the form displays in the folded state.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-IsFromCommandLine'></a>
### IsFromCommandLine `property`

##### Summary

Gets or sets a value indicating whether this config was specified by the
user on the command line.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-MatchCase'></a>
### MatchCase `property`

##### Summary

Gets or sets a value indicating whether we should match the case on
found text.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-MatchExactWord'></a>
### MatchExactWord `property`

##### Summary

Gets or sets a value indicating whether we should match the whole
word on found text.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-PendingChangesCommitMessageFormat'></a>
### PendingChangesCommitMessageFormat `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that, when formatted, becomes the
commit message for pending changes that are committed prior to the start of the
operations.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-PendingChangesDetailedCommitMessageFormat'></a>
### PendingChangesDetailedCommitMessageFormat `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that, when formatted, becomes the
detailed commit message for pending changes that are committed prior to the
start of the operations.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-PostOperationCommitMessageFormat'></a>
### PostOperationCommitMessageFormat `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that, when formatted, becomes the
commit message for the changed files once the operations have been completed.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-PostOperationDetailedCommitMessageFormat'></a>
### PostOperationDetailedCommitMessageFormat `property`

##### Summary

Gets or set a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that, when formatted, becomes the
detailed commit message for the changed files once the operations have been
completed.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-PromptUserToReloadOpenSolution'></a>
### PromptUserToReloadOpenSolution `property`

##### Summary

Gets or sets a value indicating whether the application should prompt the user
if it detects that one or more instances of Visual Studio are open, but none of
them have the target Solution(s) loaded.

##### Remarks

The default value of this property is `true`.



Set to `false` to suppress the display of the warning message
box.  If users suppress the message box, and one or more of the
target Solution(s) are indeed loaded by a running instance of Visual Studio,
then there may be file-sharing/permissions issues during the operation(s).

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-PushChangesToRemoteWhenDone'></a>
### PushChangesToRemoteWhenDone `property`

##### Summary

Gets or sets a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value indicating whether the
application should automatically push the commits it creates to the remote
repository when done with the requested operation(s).

##### Remarks

This property is set to `true` by default.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ReOpenSolution'></a>
### ReOpenSolution `property`

##### Summary

Gets or sets a flag that indicates whether to attempt to close and
then re-open the Visual Studio solution, if open, that contains the
project(s) being renamed.

##### Remarks

If this set to `true`, and the containing solution is open,
then the solution will be closed prior to the start of the selected
operation(s) and then re-opened when the selected operation(s) are complete.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-RenameFilesInFolder'></a>
### RenameFilesInFolder `property`

##### Summary

Gets or sets a value that indicates whether we should rename files
in the folders encountered.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-RenameSolutionFolders'></a>
### RenameSolutionFolders `property`

##### Summary

Gets or sets a value that indicates whether we should rename folders that
contain Visual Studio Solution (`*.sln`) files.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-RenameSubFolders'></a>
### RenameSubFolders `property`

##### Summary

Gets or sets a value that indicates whether we should rename subfolders.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ReplaceTextInFiles'></a>
### ReplaceTextInFiles `property`

##### Summary

Gets or sets a value that indicates whether we should replace text
in files.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets the text that found text should be replaced with.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ReplaceWithHistory'></a>
### ReplaceWithHistory `property`

##### Summary

Gets or sets a collection of strings that correspond to the
most-recently-used values for Replace With.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-SelectedOptionTab'></a>
### SelectedOptionTab `property`

##### Summary

Gets or sets a number from 0...N, where N is the number of option
tabs, of the one that is currently selected.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ShouldCommitPendingChanges'></a>
### ShouldCommitPendingChanges `property`

##### Summary

Gets or sets a value that indicates whether we are to attempt to commit pending
changes to the user's local Git repository, on the current branch, prior to
executing the operations.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-ShouldCommitPostOperationChanges'></a>
### ShouldCommitPostOperationChanges `property`

##### Summary

Gets or sets a value that indicates whether we are to attempt to commit pending
changes to the user's local Git repository, and on the current branch, the
changes that have resulted from the operations we've performed.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-StartingFolder'></a>
### StartingFolder `property`

##### Summary

Gets or sets a string containing the path to the starting folder of
the search.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-StartingFolderHistory'></a>
### StartingFolderHistory `property`

##### Summary

Gets or sets a collection of strings that correspond to the
most-recently-used values for Starting Folder.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-UpdateGitOnAutoStart'></a>
### UpdateGitOnAutoStart `property`

##### Summary

Gets or sets a value indicating whether to update the user's local Git
repository even when running in `Auto Start` mode.

##### Remarks

The default value of this property is `true`.

<a name='M-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Determines whether the specified object is equal to the current
object.

##### Returns

`true` if the specified object  is equal to the current
object; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to compare with the current object. |

<a name='M-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Serves as the default hash function.

##### Returns

A hash code for the current object.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-Reset'></a>
### Reset() `method`

##### Summary

Sets the values of this class' properties to their default values.

##### Parameters

This method has no parameters.

##### Remarks

This method typically is called from a class constructor.

<a name='T-MFR-Settings-Configuration-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Interfaces-Properties-Resources-Error_ValueCannotBeBlankOrNull'></a>
### Error_ValueCannotBeBlankOrNull `property`

##### Summary

Looks up a localized string similar to Value cannot be blank or null..

<a name='P-MFR-Settings-Configuration-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
