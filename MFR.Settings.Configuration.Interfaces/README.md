<a name='assembly'></a>
# MFR.Settings.Configuration.Interfaces

## Contents

- [IConfigurationComposedObject](#T-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject 'MFR.Settings.Configuration.Interfaces.IConfigurationComposedObject')
  - [CurrentConfiguration](#P-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-CurrentConfiguration 'MFR.Settings.Configuration.Interfaces.IConfigurationComposedObject.CurrentConfiguration')
  - [AndAttachConfiguration()](#M-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-AndAttachConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration- 'MFR.Settings.Configuration.Interfaces.IConfigurationComposedObject.AndAttachConfiguration(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration)')
  - [UpdateConfiguration(configuration)](#M-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration- 'MFR.Settings.Configuration.Interfaces.IConfigurationComposedObject.UpdateConfiguration(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration)')
  - [VerifyConfigurationAttached()](#M-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-VerifyConfigurationAttached 'MFR.Settings.Configuration.Interfaces.IConfigurationComposedObject.VerifyConfigurationAttached')
- [IFixedTextMatchingConfigurationSpecificObject](#T-MFR-Settings-Configuration-Interfaces-IFixedTextMatchingConfigurationSpecificObject 'MFR.Settings.Configuration.Interfaces.IFixedTextMatchingConfigurationSpecificObject')
  - [TextMatchingConfiguration](#P-MFR-Settings-Configuration-Interfaces-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.Settings.Configuration.Interfaces.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
- [IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
  - [AutoQuitOnCompletion](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-AutoQuitOnCompletion 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.AutoQuitOnCompletion')
  - [AutoStart](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-AutoStart 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.AutoStart')
  - [FindWhat](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-FindWhat 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.FindWhat')
  - [FindWhatHistory](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-FindWhatHistory 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.FindWhatHistory')
  - [InvokableOperations](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-InvokableOperations 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.InvokableOperations')
  - [IsFolded](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-IsFolded 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.IsFolded')
  - [IsFromCommandLine](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-IsFromCommandLine 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.IsFromCommandLine')
  - [MatchCase](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-MatchCase 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.MatchCase')
  - [MatchExactWord](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-MatchExactWord 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.MatchExactWord')
  - [ReOpenSolution](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-ReOpenSolution 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.ReOpenSolution')
  - [RenameFilesInFolder](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-RenameFilesInFolder 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.RenameFilesInFolder')
  - [RenameSolutionFolders](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-RenameSolutionFolders 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.RenameSolutionFolders')
  - [RenameSubFolders](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-RenameSubFolders 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.RenameSubFolders')
  - [ReplaceTextInFiles](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-ReplaceTextInFiles 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.ReplaceTextInFiles')
  - [ReplaceWith](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-ReplaceWith 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.ReplaceWith')
  - [ReplaceWithHistory](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-ReplaceWithHistory 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.ReplaceWithHistory')
  - [SelectedOptionTab](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-SelectedOptionTab 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.SelectedOptionTab')
  - [StartingFolder](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-StartingFolder 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.StartingFolder')
  - [StartingFolderHistory](#P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-StartingFolderHistory 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.StartingFolderHistory')
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
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface.

<a name='P-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the [IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') interface.

<a name='M-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-AndAttachConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-'></a>
### AndAttachConfiguration() `method`

##### Summary

Associates user settings, in the form of an instance of an object
that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
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
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `configuration`,
is passed a `null` value. |

##### Remarks

The [IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
-implementing configuration object controls the behavior of this
object by dint of the settings chosen by the user at runtime.

<a name='M-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-'></a>
### UpdateConfiguration(configuration) `method`

##### Summary

Updates the `configuration` currently being used with a new value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the [IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') interface
which has the new settings. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `configuration`,
is passed a `null` value. |

##### Remarks

The settings in the object specified will be used for all matching
from this point forward.

<a name='M-MFR-Settings-Configuration-Interfaces-IConfigurationComposedObject-VerifyConfigurationAttached'></a>
### VerifyConfigurationAttached() `method`

##### Summary

Verifies that configuration has been attached to this object.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException') | Thrown if no configuration data is attached to this object. |

##### Remarks

If no configuration is attached to this object, then a new
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

<a name='T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration'></a>
## IProjectFileRenamerConfiguration `type`

##### Namespace

MFR.Settings.Configuration.Interfaces

##### Summary

Defines the public-exposed methods and properties of a
configuration object.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-AutoQuitOnCompletion'></a>
### AutoQuitOnCompletion `property`

##### Summary

Gets or sets a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value indicating whether the
application should automatically terminate once the user's requested operations
are complete.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-AutoStart'></a>
### AutoStart `property`

##### Summary

Gets or sets a value indicating whether the specified operation(s) should be
automatically initiated when the application starts.  If this value is set to
`true` then the application quits automatically after the
specified operation(s) have been completed.

##### Remarks

This flag is ignored if this configuration did not originate
from the command
line.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets the text to be found that was most-recently specified
by the user.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-FindWhatHistory'></a>
### FindWhatHistory `property`

##### Summary

Gets or sets a collection of strings consisting of the most-recently
utilized values for Find What.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-InvokableOperations'></a>
### InvokableOperations `property`

##### Summary

Gets or sets a reference to a collection of instances of
[OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo') instances, that represents
all the operations the user can perform with this application.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-IsFolded'></a>
### IsFolded `property`

##### Summary

Gets a value indicating whether the form is in the Folded state.

##### Remarks

If this value is `true` when the form is loaded, then ensure
that the form displays in the folded state.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-IsFromCommandLine'></a>
### IsFromCommandLine `property`

##### Summary

Gets or sets a value indicating whether this configuration
was specified by the
user on the command line.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-MatchCase'></a>
### MatchCase `property`

##### Summary

Gets or sets a value indicating whether we should match the case on
found text.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-MatchExactWord'></a>
### MatchExactWord `property`

##### Summary

Gets or sets a value indicating whether we should match the whole
word on found text.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-ReOpenSolution'></a>
### ReOpenSolution `property`

##### Summary

Gets or sets a flag that indicates whether to attempt to close and
then re-open the Visual Studio solution, if open, that contains the
project(s) being renamed.

##### Remarks

If this is set to `true`, and the containing solution is open,
then the solution will be closed prior to the start of the selected
operation(s) and then re-opened when the selected operation(s) are complete.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-RenameFilesInFolder'></a>
### RenameFilesInFolder `property`

##### Summary

Gets or sets a value that indicates whether we should rename files
in the folders encountered.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-RenameSolutionFolders'></a>
### RenameSolutionFolders `property`

##### Summary

Gets or sets a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value that indicates whether the
containing folder(s) of solution(s) contained in the search should be renamed.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-RenameSubFolders'></a>
### RenameSubFolders `property`

##### Summary

Gets or sets a value that indicates whether we should rename subfolders.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-ReplaceTextInFiles'></a>
### ReplaceTextInFiles `property`

##### Summary

Gets or sets a value that indicates whether we should replace text
in files.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets the text that found text should be replaced with.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-ReplaceWithHistory'></a>
### ReplaceWithHistory `property`

##### Summary

Gets or sets a collection of strings that correspond to the
most-recently-used values for Replace With.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-SelectedOptionTab'></a>
### SelectedOptionTab `property`

##### Summary

Gets or sets a number from 0...N, where N is the number of option
tabs, of the one that is currently selected.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-StartingFolder'></a>
### StartingFolder `property`

##### Summary

Gets or sets a string containing the path to the starting folder of
the search.

##### Remarks

The
[](#E-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-StartingFolderChanged 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration.StartingFolderChanged')
event is raised when this property's value is updated.

<a name='P-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-StartingFolderHistory'></a>
### StartingFolderHistory `property`

##### Summary

Gets or sets a collection of strings that correspond to the
most-recently-used values for Starting Folder.

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
