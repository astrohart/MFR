<a name='assembly'></a>
# MFR.Settings.Configuration

## Contents

- [ConfigurationComposedObjectBase](#T-MFR-Settings-Configuration-ConfigurationComposedObjectBase 'MFR.Settings.Configuration.ConfigurationComposedObjectBase')
  - [#ctor()](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-#ctor 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.#ctor')
  - [#ctor(config)](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [CurrentConfiguration](#P-MFR-Settings-Configuration-ConfigurationComposedObjectBase-CurrentConfiguration 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.CurrentConfiguration')
  - [IsConfigurationAttached](#P-MFR-Settings-Configuration-ConfigurationComposedObjectBase-IsConfigurationAttached 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.IsConfigurationAttached')
  - [AndAttachConfiguration()](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-AndAttachConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.AndAttachConfiguration(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [UpdateConfiguration(config)](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.UpdateConfiguration(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [VerifyConfigurationAttached()](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-VerifyConfigurationAttached 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.VerifyConfigurationAttached')
- [ProjectFileRenamerConfig](#T-MFR-Settings-Configuration-ProjectFileRenamerConfig 'MFR.Settings.Configuration.ProjectFileRenamerConfig')
  - [#ctor()](#M-MFR-Settings-Configuration-ProjectFileRenamerConfig-#ctor 'MFR.Settings.Configuration.ProjectFileRenamerConfig.#ctor')
  - [#ctor(source)](#M-MFR-Settings-Configuration-ProjectFileRenamerConfig-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Settings.Configuration.ProjectFileRenamerConfig.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [#ctor(errantProcesses,operations)](#M-MFR-Settings-Configuration-ProjectFileRenamerConfig-#ctor-System-Collections-Generic-IEnumerable{System-String},System-Collections-Generic-IEnumerable{MFR-GUI-Models-Interfaces-IOperationTypeInfo}- 'MFR.Settings.Configuration.ProjectFileRenamerConfig.#ctor(System.Collections.Generic.IEnumerable{System.String},System.Collections.Generic.IEnumerable{MFR.GUI.Models.Interfaces.IOperationTypeInfo})')
  - [_startingFolder](#F-MFR-Settings-Configuration-ProjectFileRenamerConfig-_startingFolder 'MFR.Settings.Configuration.ProjectFileRenamerConfig._startingFolder')
  - [AutoQuitOnCompletion](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-AutoQuitOnCompletion 'MFR.Settings.Configuration.ProjectFileRenamerConfig.AutoQuitOnCompletion')
  - [AutoStart](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-AutoStart 'MFR.Settings.Configuration.ProjectFileRenamerConfig.AutoStart')
  - [CommitAuthorEmail](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-CommitAuthorEmail 'MFR.Settings.Configuration.ProjectFileRenamerConfig.CommitAuthorEmail')
  - [CommitAuthorName](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-CommitAuthorName 'MFR.Settings.Configuration.ProjectFileRenamerConfig.CommitAuthorName')
  - [ErrantProcessesList](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-ErrantProcessesList 'MFR.Settings.Configuration.ProjectFileRenamerConfig.ErrantProcessesList')
  - [FindWhat](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-FindWhat 'MFR.Settings.Configuration.ProjectFileRenamerConfig.FindWhat')
  - [FindWhatHistory](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-FindWhatHistory 'MFR.Settings.Configuration.ProjectFileRenamerConfig.FindWhatHistory')
  - [InvokableOperations](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-InvokableOperations 'MFR.Settings.Configuration.ProjectFileRenamerConfig.InvokableOperations')
  - [IsFolded](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-IsFolded 'MFR.Settings.Configuration.ProjectFileRenamerConfig.IsFolded')
  - [IsFromCommandLine](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-IsFromCommandLine 'MFR.Settings.Configuration.ProjectFileRenamerConfig.IsFromCommandLine')
  - [MatchCase](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-MatchCase 'MFR.Settings.Configuration.ProjectFileRenamerConfig.MatchCase')
  - [MatchExactWord](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-MatchExactWord 'MFR.Settings.Configuration.ProjectFileRenamerConfig.MatchExactWord')
  - [PendingChangesCommitMessageFormat](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-PendingChangesCommitMessageFormat 'MFR.Settings.Configuration.ProjectFileRenamerConfig.PendingChangesCommitMessageFormat')
  - [PendingChangesDetailedCommitMessageFormat](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-PendingChangesDetailedCommitMessageFormat 'MFR.Settings.Configuration.ProjectFileRenamerConfig.PendingChangesDetailedCommitMessageFormat')
  - [PostOperationCommitMessageFormat](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-PostOperationCommitMessageFormat 'MFR.Settings.Configuration.ProjectFileRenamerConfig.PostOperationCommitMessageFormat')
  - [PostOperationDetailedCommitMessageFormat](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-PostOperationDetailedCommitMessageFormat 'MFR.Settings.Configuration.ProjectFileRenamerConfig.PostOperationDetailedCommitMessageFormat')
  - [PromptUserToReloadOpenSolution](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-PromptUserToReloadOpenSolution 'MFR.Settings.Configuration.ProjectFileRenamerConfig.PromptUserToReloadOpenSolution')
  - [PushChangesToRemoteWhenDone](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-PushChangesToRemoteWhenDone 'MFR.Settings.Configuration.ProjectFileRenamerConfig.PushChangesToRemoteWhenDone')
  - [ReOpenSolution](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-ReOpenSolution 'MFR.Settings.Configuration.ProjectFileRenamerConfig.ReOpenSolution')
  - [RenameFilesInFolder](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-RenameFilesInFolder 'MFR.Settings.Configuration.ProjectFileRenamerConfig.RenameFilesInFolder')
  - [RenameSolutionFolders](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-RenameSolutionFolders 'MFR.Settings.Configuration.ProjectFileRenamerConfig.RenameSolutionFolders')
  - [RenameSubFolders](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-RenameSubFolders 'MFR.Settings.Configuration.ProjectFileRenamerConfig.RenameSubFolders')
  - [ReplaceTextInFiles](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-ReplaceTextInFiles 'MFR.Settings.Configuration.ProjectFileRenamerConfig.ReplaceTextInFiles')
  - [ReplaceWith](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-ReplaceWith 'MFR.Settings.Configuration.ProjectFileRenamerConfig.ReplaceWith')
  - [ReplaceWithHistory](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-ReplaceWithHistory 'MFR.Settings.Configuration.ProjectFileRenamerConfig.ReplaceWithHistory')
  - [SelectedOptionTab](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-SelectedOptionTab 'MFR.Settings.Configuration.ProjectFileRenamerConfig.SelectedOptionTab')
  - [ShouldCommitPendingChanges](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-ShouldCommitPendingChanges 'MFR.Settings.Configuration.ProjectFileRenamerConfig.ShouldCommitPendingChanges')
  - [ShouldCommitPostOperationChanges](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-ShouldCommitPostOperationChanges 'MFR.Settings.Configuration.ProjectFileRenamerConfig.ShouldCommitPostOperationChanges')
  - [StartingFolder](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-StartingFolder 'MFR.Settings.Configuration.ProjectFileRenamerConfig.StartingFolder')
  - [StartingFolderHistory](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-StartingFolderHistory 'MFR.Settings.Configuration.ProjectFileRenamerConfig.StartingFolderHistory')
  - [UpdateGitOnAutoStart](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-UpdateGitOnAutoStart 'MFR.Settings.Configuration.ProjectFileRenamerConfig.UpdateGitOnAutoStart')
  - [AddErrantProcessEntries(errantProcesses)](#M-MFR-Settings-Configuration-ProjectFileRenamerConfig-AddErrantProcessEntries-System-Collections-Generic-IEnumerable{System-String}- 'MFR.Settings.Configuration.ProjectFileRenamerConfig.AddErrantProcessEntries(System.Collections.Generic.IEnumerable{System.String})')
  - [AddInvokableOperationEntries(operations)](#M-MFR-Settings-Configuration-ProjectFileRenamerConfig-AddInvokableOperationEntries-System-Collections-Generic-IEnumerable{MFR-GUI-Models-Interfaces-IOperationTypeInfo}- 'MFR.Settings.Configuration.ProjectFileRenamerConfig.AddInvokableOperationEntries(System.Collections.Generic.IEnumerable{MFR.GUI.Models.Interfaces.IOperationTypeInfo})')
  - [Equals(obj)](#M-MFR-Settings-Configuration-ProjectFileRenamerConfig-Equals-System-Object- 'MFR.Settings.Configuration.ProjectFileRenamerConfig.Equals(System.Object)')
  - [GetHashCode()](#M-MFR-Settings-Configuration-ProjectFileRenamerConfig-GetHashCode 'MFR.Settings.Configuration.ProjectFileRenamerConfig.GetHashCode')
  - [IsBlankOrNull(config)](#M-MFR-Settings-Configuration-ProjectFileRenamerConfig-IsBlankOrNull-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Settings.Configuration.ProjectFileRenamerConfig.IsBlankOrNull(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [OnStartingFolderChanged(e)](#M-MFR-Settings-Configuration-ProjectFileRenamerConfig-OnStartingFolderChanged-MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs- 'MFR.Settings.Configuration.ProjectFileRenamerConfig.OnStartingFolderChanged(MFR.Settings.Configuration.Events.StartingFolderChangedEventArgs)')
  - [Reset()](#M-MFR-Settings-Configuration-ProjectFileRenamerConfig-Reset 'MFR.Settings.Configuration.ProjectFileRenamerConfig.Reset')
- [Resources](#T-MFR-Settings-Configuration-Properties-Resources 'MFR.Settings.Configuration.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Properties-Resources-Culture 'MFR.Settings.Configuration.Properties.Resources.Culture')
  - [Default_PendingChangesCommitMessage](#P-MFR-Settings-Configuration-Properties-Resources-Default_PendingChangesCommitMessage 'MFR.Settings.Configuration.Properties.Resources.Default_PendingChangesCommitMessage')
  - [Default_PendingChangesDetailedCommitMessage](#P-MFR-Settings-Configuration-Properties-Resources-Default_PendingChangesDetailedCommitMessage 'MFR.Settings.Configuration.Properties.Resources.Default_PendingChangesDetailedCommitMessage')
  - [Default_PostOperationCommitMessage](#P-MFR-Settings-Configuration-Properties-Resources-Default_PostOperationCommitMessage 'MFR.Settings.Configuration.Properties.Resources.Default_PostOperationCommitMessage')
  - [Default_PostOperationDetailedCommitMessage](#P-MFR-Settings-Configuration-Properties-Resources-Default_PostOperationDetailedCommitMessage 'MFR.Settings.Configuration.Properties.Resources.Default_PostOperationDetailedCommitMessage')
  - [ResourceManager](#P-MFR-Settings-Configuration-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-ConfigurationComposedObjectBase'></a>
## ConfigurationComposedObjectBase `type`

##### Namespace

MFR.Settings.Configuration

##### Summary

Provides common functionality for all those objects that get composed
with another object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ConfigurationComposedObjectBase](#T-MFR-Settings-Configuration-ConfigurationComposedObjectBase-ConfigurationComposedObjectBase 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.ConfigurationComposedObjectBase')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### #ctor(config) `constructor`

##### Summary

Constructs a new instance of
[TextExpressionMatchingEngineBase](#T-MFR-TextExpressionMatchingEngineBase 'MFR.TextExpressionMatchingEngineBase')
and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface
that holds settings that are specified by the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `config`,
is passed a `null` value. |

<a name='P-MFR-Settings-Configuration-ConfigurationComposedObjectBase-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

##### Remarks

This object's properties give us access to the settings configured
by the user of the application.

<a name='P-MFR-Settings-Configuration-ConfigurationComposedObjectBase-IsConfigurationAttached'></a>
### IsConfigurationAttached `property`

##### Summary

Gets or sets a value indicating whether this object has been
properly composed with an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-AndAttachConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
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

The
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
-implementing config object controls the behavior of this
object by dint of the settings chosen by the user at runtime.

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### UpdateConfiguration(config) `method`

##### Summary

Updates the `config` currently being used with a new
value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface
which has the new settings. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `config`,
is passed a `null` value. |

##### Remarks

The settings in the object specified will be used for all matching
from this point forward.



NOTE:This member may be overriden by a child class. If this the
case, the overrider must call the base class method before doing any
of its own processing.

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-VerifyConfigurationAttached'></a>
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

If no config is attached to this object, then
[ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException')
is thrown.



Child classes may override this method, e.g., to make
attaching a config object optional.

<a name='T-MFR-Settings-Configuration-ProjectFileRenamerConfig'></a>
## ProjectFileRenamerConfig `type`

##### Namespace

MFR.Settings.Configuration

##### Summary

Contains properties whose values are set by the user.

##### Remarks

The values of this class' properties are used to affect the behavior of
the application.

<a name='M-MFR-Settings-Configuration-ProjectFileRenamerConfig-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ProjectFileRenamerConfig](#T-MFR-Settings-Configuration-ProjectFileRenamerConfig 'MFR.Settings.Configuration.ProjectFileRenamerConfig')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Settings-Configuration-ProjectFileRenamerConfig-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### #ctor(source) `constructor`

##### Summary

Constructs a new instance of
[ProjectFileRenamerConfig](#T-MFR-Settings-Configuration-ProjectFileRenamerConfig 'MFR.Settings.Configuration.ProjectFileRenamerConfig')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface
that contains existing config settings to copy into this object. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `source`, is passed a `null`
value. |

<a name='M-MFR-Settings-Configuration-ProjectFileRenamerConfig-#ctor-System-Collections-Generic-IEnumerable{System-String},System-Collections-Generic-IEnumerable{MFR-GUI-Models-Interfaces-IOperationTypeInfo}-'></a>
### #ctor(errantProcesses,operations) `constructor`

##### Summary

Constructs a new instance of
[ProjectFileRenamerConfig](#T-MFR-Settings-Configuration-ProjectFileRenamerConfig 'MFR.Settings.Configuration.ProjectFileRenamerConfig') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errantProcesses | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | (Required.) A collection of references to instances of
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), each element of which is the name of a process
that is to be killed prior to the start of an operation. |
| operations | [System.Collections.Generic.IEnumerable{MFR.GUI.Models.Interfaces.IOperationTypeInfo}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{MFR.GUI.Models.Interfaces.IOperationTypeInfo}') | (Required.) Reference to an instance of a collection of instances of objects
that implement the
[IOperationTypeInfo](#T-MFR-GUI-Models-Interfaces-IOperationTypeInfo 'MFR.GUI.Models.Interfaces.IOperationTypeInfo') interface, each
element of which specifies configuration information, such as whether the
operation is disabled, for each invokable operation. |

<a name='F-MFR-Settings-Configuration-ProjectFileRenamerConfig-_startingFolder'></a>
### _startingFolder `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified pathname of the
folder in which the selected operation(s) should be initiated.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-AutoQuitOnCompletion'></a>
### AutoQuitOnCompletion `property`

##### Summary

Gets or sets a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value indicating whether the
application should automatically terminate once the user's requested operations
are complete.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-AutoStart'></a>
### AutoStart `property`

##### Summary

Gets or sets a value indicating whether the specified operation(s) should be
automatically initiated when the application starts.  If this value is set to
`true` then the application quits automatically after the
specified operation(s) have been completed.

##### Remarks

This flag is ignored if this config did not originate from the command
line.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-CommitAuthorEmail'></a>
### CommitAuthorEmail `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the email address(es)
of the author(s) of commits made to a local Git repository(ies) by this
application.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-CommitAuthorName'></a>
### CommitAuthorName `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the name of the
author(s) of commits made to a local Git repository(ies) by this application.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-ErrantProcessesList'></a>
### ErrantProcessesList `property`

##### Summary

Gets a reference to an instance of a collection, each of whose elements are of
type [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), representing the list of errant processes
we should attempt to kill prior to the beginning of an operation.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets the text to be found that was most-recently specified
by the user.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-FindWhatHistory'></a>
### FindWhatHistory `property`

##### Summary

Gets or sets a collection of strings consisting of the most-recently
utilized values for Find What.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-InvokableOperations'></a>
### InvokableOperations `property`

##### Summary

Gets or sets a reference to a collection of instances of
[OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo') instances, that represents
all the operations the user can perform with this application.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-IsFolded'></a>
### IsFolded `property`

##### Summary

Gets a value indicating whether the form is in the Folded state.

##### Remarks

If this value is `true` when the form is loaded, then ensure
that the form displays in the folded state.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-IsFromCommandLine'></a>
### IsFromCommandLine `property`

##### Summary

Gets or sets a value indicating whether this config was specified by the
user on the command line.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-MatchCase'></a>
### MatchCase `property`

##### Summary

Gets or sets a value indicating whether we should match the case on
found text.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-MatchExactWord'></a>
### MatchExactWord `property`

##### Summary

Gets or sets a value indicating whether we should match the whole
word on found text.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-PendingChangesCommitMessageFormat'></a>
### PendingChangesCommitMessageFormat `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that, when formatted, becomes the
commit message for pending changes that are committed prior to the start of the
operations.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-PendingChangesDetailedCommitMessageFormat'></a>
### PendingChangesDetailedCommitMessageFormat `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that, when formatted, becomes the
detailed commit message for pending changes that are committed prior to the
start of the operations.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-PostOperationCommitMessageFormat'></a>
### PostOperationCommitMessageFormat `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that, when formatted, becomes the
commit message for the changed files once the operations have been completed.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-PostOperationDetailedCommitMessageFormat'></a>
### PostOperationDetailedCommitMessageFormat `property`

##### Summary

Gets or set a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that, when formatted, becomes the
detailed commit message for the changed files once the operations have been
completed.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-PromptUserToReloadOpenSolution'></a>
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

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-PushChangesToRemoteWhenDone'></a>
### PushChangesToRemoteWhenDone `property`

##### Summary

Gets or sets a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value indicating whether the
application should automatically push the commits it creates to the remote
repository when done with the requested operation(s).

##### Remarks

This property is set to `true` by default.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-ReOpenSolution'></a>
### ReOpenSolution `property`

##### Summary

Gets or sets a flag that indicates whether to attempt to close and
then re-open the Visual Studio solution, if open, that contains the
project(s) being renamed.

##### Remarks

If this set to `true`, and the containing solution is open,
then the solution will be closed prior to the start of the selected
operation(s) and then re-opened when the selected operation(s) are complete.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-RenameFilesInFolder'></a>
### RenameFilesInFolder `property`

##### Summary

Gets or sets a value that indicates whether we should rename files
in the folders encountered.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-RenameSolutionFolders'></a>
### RenameSolutionFolders `property`

##### Summary

Gets or sets a value that indicates whether we should rename folders that
contain Visual Studio Solution (`*.sln`) files.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-RenameSubFolders'></a>
### RenameSubFolders `property`

##### Summary

Gets or sets a value that indicates whether we should rename subfolders.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-ReplaceTextInFiles'></a>
### ReplaceTextInFiles `property`

##### Summary

Gets or sets a value that indicates whether we should replace text
in files.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets the text that found text should be replaced with.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-ReplaceWithHistory'></a>
### ReplaceWithHistory `property`

##### Summary

Gets or sets a collection of strings that correspond to the
most-recently-used values for Replace With.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-SelectedOptionTab'></a>
### SelectedOptionTab `property`

##### Summary

Gets or sets a number from 0...N, where N is the number of option
tabs, of the one that is currently selected.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-ShouldCommitPendingChanges'></a>
### ShouldCommitPendingChanges `property`

##### Summary

Gets or sets a value that indicates whether we are to attempt to commit pending
changes to the user's local Git repository, on the current branch, prior to
executing the operations.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-ShouldCommitPostOperationChanges'></a>
### ShouldCommitPostOperationChanges `property`

##### Summary

Gets or sets a value that indicates whether we are to attempt to commit pending
changes to the user's local Git repository, and on the current branch, the
changes that have resulted from the operations we've performed.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-StartingFolder'></a>
### StartingFolder `property`

##### Summary

Gets or sets a string containing the path to the starting folder of
the search.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-StartingFolderHistory'></a>
### StartingFolderHistory `property`

##### Summary

Gets or sets a collection of strings that correspond to the
most-recently-used values for Starting Folder.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerConfig-UpdateGitOnAutoStart'></a>
### UpdateGitOnAutoStart `property`

##### Summary

Gets or sets a value indicating whether to update the user's local Git
repository even when running in `Auto Start` mode.

##### Remarks

The default value of this property is `true`.

<a name='M-MFR-Settings-Configuration-ProjectFileRenamerConfig-AddErrantProcessEntries-System-Collections-Generic-IEnumerable{System-String}-'></a>
### AddErrantProcessEntries(errantProcesses) `method`

##### Summary

Adds the specified `errantProcesses` to the configured list
of errant processes that are to be killed prior to performing certain
operations.

##### Returns

`true` if the invokable operation(s) were
successfully added to the internal collection; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errantProcesses | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | (Required.) A collection of references to instances of
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), each element of which is the name of a process
that is to be killed prior to the start of an operation. |

<a name='M-MFR-Settings-Configuration-ProjectFileRenamerConfig-AddInvokableOperationEntries-System-Collections-Generic-IEnumerable{MFR-GUI-Models-Interfaces-IOperationTypeInfo}-'></a>
### AddInvokableOperationEntries(operations) `method`

##### Summary

Adds the specified `operations` to the configured list of
invokable operations.

##### Returns

`true` if the invokable operation(s) were
successfully added to the internal collection; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operations | [System.Collections.Generic.IEnumerable{MFR.GUI.Models.Interfaces.IOperationTypeInfo}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{MFR.GUI.Models.Interfaces.IOperationTypeInfo}') | (Required.) Reference to an instance of a collection of instances of objects
that implement the
[IOperationTypeInfo](#T-MFR-GUI-Models-Interfaces-IOperationTypeInfo 'MFR.GUI.Models.Interfaces.IOperationTypeInfo') interface, each
element of which specifies configuration information, such as whether the
operation is disabled, for each invokable operation. |

<a name='M-MFR-Settings-Configuration-ProjectFileRenamerConfig-Equals-System-Object-'></a>
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

<a name='M-MFR-Settings-Configuration-ProjectFileRenamerConfig-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Serves as the default hash function.

##### Returns

A hash code for the current object.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-ProjectFileRenamerConfig-IsBlankOrNull-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### IsBlankOrNull(config) `method`

##### Summary

Determines whether the specified `config` object
instance is blank or a `null` reference.

##### Returns

`true` if the specified
`config` object instance is blank or a
`null` reference.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface that represents the object instance that is to be examined. |

<a name='M-MFR-Settings-Configuration-ProjectFileRenamerConfig-OnStartingFolderChanged-MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs-'></a>
### OnStartingFolderChanged(e) `method`

##### Summary

Raises the
[](#E-MFR-Settings-ProjectFileRenamerConfig-ProjectFileRenamerConfig-StartingFolderChanged 'MFR.Settings.ProjectFileRenamerConfig.ProjectFileRenamerConfig.StartingFolderChanged')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Settings.Configuration.Events.StartingFolderChangedEventArgs](#T-MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs 'MFR.Settings.Configuration.Events.StartingFolderChangedEventArgs') | (Required.) A
[StartingFolderChangedEventArgs](#T-MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs 'MFR.Settings.Configuration.Events.StartingFolderChangedEventArgs')
that contains the event's data. |

##### Remarks

This event is supposed to be raised when the value of the
[StartingFolder](#P-MFR-Settings-Configuration-ProjectFileRenamerConfig-StartingFolder 'MFR.Settings.Configuration.ProjectFileRenamerConfig.StartingFolder')
property is updated.

<a name='M-MFR-Settings-Configuration-ProjectFileRenamerConfig-Reset'></a>
### Reset() `method`

##### Summary

Sets the values of this class' properties to their default values.

##### Parameters

This method has no parameters.

##### Remarks

This method typically is called from a class constructor.

<a name='T-MFR-Settings-Configuration-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Properties-Resources-Default_PendingChangesCommitMessage'></a>
### Default_PendingChangesCommitMessage `property`

##### Summary

Looks up a localized string similar to Latest updates on {{shortDate}} at {{shortTime}} {{timezone}}.

<a name='P-MFR-Settings-Configuration-Properties-Resources-Default_PendingChangesDetailedCommitMessage'></a>
### Default_PendingChangesDetailedCommitMessage `property`

##### Summary

Looks up a localized string similar to At {{shortTime}} on {{shortDate}} {{timezone}}, the Project File Renamer was invoked, and is about to replace all occurrences of '{{findWhat}}' with '{{replaceWith}}' in the files, folders, and names of folders of the '{{rootDir}}' folder..

<a name='P-MFR-Settings-Configuration-Properties-Resources-Default_PostOperationCommitMessage'></a>
### Default_PostOperationCommitMessage `property`

##### Summary

Looks up a localized string similar to Used the Project File Renamer.

<a name='P-MFR-Settings-Configuration-Properties-Resources-Default_PostOperationDetailedCommitMessage'></a>
### Default_PostOperationDetailedCommitMessage `property`

##### Summary

Looks up a localized string similar to At {{shortTime}} on {{shortDate}} {{timezone}}, the Project File Renamer was used to replace all occurrences of '{{findWhat}}' with '{{replaceWith}}' in the files, folders, and names of folders of the '{{rootDir}}' folder.

--
Produced by xyLOGIX Project File Renamer, copyright ? 2019-23 by xyLOGIX, LLC.  All rights reserved..

<a name='P-MFR-Settings-Configuration-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
