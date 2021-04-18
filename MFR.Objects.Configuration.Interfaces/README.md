<a name='assembly'></a>
# MFR.Objects.Configuration.Interfaces

## Contents

- [IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Objects.Configuration.Interfaces.IConfiguration')
  - [FindWhat](#P-MFR-Objects-Configuration-Interfaces-IConfiguration-FindWhat 'MFR.Objects.Configuration.Interfaces.IConfiguration.FindWhat')
  - [FindWhatHistory](#P-MFR-Objects-Configuration-Interfaces-IConfiguration-FindWhatHistory 'MFR.Objects.Configuration.Interfaces.IConfiguration.FindWhatHistory')
  - [IsFolded](#P-MFR-Objects-Configuration-Interfaces-IConfiguration-IsFolded 'MFR.Objects.Configuration.Interfaces.IConfiguration.IsFolded')
  - [MatchCase](#P-MFR-Objects-Configuration-Interfaces-IConfiguration-MatchCase 'MFR.Objects.Configuration.Interfaces.IConfiguration.MatchCase')
  - [MatchExactWord](#P-MFR-Objects-Configuration-Interfaces-IConfiguration-MatchExactWord 'MFR.Objects.Configuration.Interfaces.IConfiguration.MatchExactWord')
  - [ReOpenSolution](#P-MFR-Objects-Configuration-Interfaces-IConfiguration-ReOpenSolution 'MFR.Objects.Configuration.Interfaces.IConfiguration.ReOpenSolution')
  - [RenameFiles](#P-MFR-Objects-Configuration-Interfaces-IConfiguration-RenameFiles 'MFR.Objects.Configuration.Interfaces.IConfiguration.RenameFiles')
  - [RenameSubfolders](#P-MFR-Objects-Configuration-Interfaces-IConfiguration-RenameSubfolders 'MFR.Objects.Configuration.Interfaces.IConfiguration.RenameSubfolders')
  - [ReplaceInFiles](#P-MFR-Objects-Configuration-Interfaces-IConfiguration-ReplaceInFiles 'MFR.Objects.Configuration.Interfaces.IConfiguration.ReplaceInFiles')
  - [ReplaceWith](#P-MFR-Objects-Configuration-Interfaces-IConfiguration-ReplaceWith 'MFR.Objects.Configuration.Interfaces.IConfiguration.ReplaceWith')
  - [ReplaceWithHistory](#P-MFR-Objects-Configuration-Interfaces-IConfiguration-ReplaceWithHistory 'MFR.Objects.Configuration.Interfaces.IConfiguration.ReplaceWithHistory')
  - [SelectedOptionTab](#P-MFR-Objects-Configuration-Interfaces-IConfiguration-SelectedOptionTab 'MFR.Objects.Configuration.Interfaces.IConfiguration.SelectedOptionTab')
  - [StartingFolder](#P-MFR-Objects-Configuration-Interfaces-IConfiguration-StartingFolder 'MFR.Objects.Configuration.Interfaces.IConfiguration.StartingFolder')
  - [StartingFolderHistory](#P-MFR-Objects-Configuration-Interfaces-IConfiguration-StartingFolderHistory 'MFR.Objects.Configuration.Interfaces.IConfiguration.StartingFolderHistory')
- [IConfigurationComposedObject](#T-MFR-Objects-Configuration-Interfaces-IConfigurationComposedObject 'MFR.Objects.Configuration.Interfaces.IConfigurationComposedObject')
  - [Configuration](#P-MFR-Objects-Configuration-Interfaces-IConfigurationComposedObject-Configuration 'MFR.Objects.Configuration.Interfaces.IConfigurationComposedObject.Configuration')
  - [AndAttachConfiguration()](#M-MFR-Objects-Configuration-Interfaces-IConfigurationComposedObject-AndAttachConfiguration-MFR-Objects-Configuration-Interfaces-IConfiguration- 'MFR.Objects.Configuration.Interfaces.IConfigurationComposedObject.AndAttachConfiguration(MFR.Objects.Configuration.Interfaces.IConfiguration)')
  - [UpdateConfiguration(configuration)](#M-MFR-Objects-Configuration-Interfaces-IConfigurationComposedObject-UpdateConfiguration-MFR-Objects-Configuration-Interfaces-IConfiguration- 'MFR.Objects.Configuration.Interfaces.IConfigurationComposedObject.UpdateConfiguration(MFR.Objects.Configuration.Interfaces.IConfiguration)')
  - [VerifyConfigurationAttached()](#M-MFR-Objects-Configuration-Interfaces-IConfigurationComposedObject-VerifyConfigurationAttached 'MFR.Objects.Configuration.Interfaces.IConfigurationComposedObject.VerifyConfigurationAttached')
- [IFixedTextMatchingConfigurationSpecificObject](#T-MFR-Objects-Configuration-Interfaces-IFixedTextMatchingConfigurationSpecificObject 'MFR.Objects.Configuration.Interfaces.IFixedTextMatchingConfigurationSpecificObject')
  - [TextMatchingConfiguration](#P-MFR-Objects-Configuration-Interfaces-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.Objects.Configuration.Interfaces.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
- [Resources](#T-MFR-Objects-Configuration-Interfaces-Properties-Resources 'MFR.Objects.Configuration.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Configuration-Interfaces-Properties-Resources-Culture 'MFR.Objects.Configuration.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Configuration-Interfaces-Properties-Resources-ResourceManager 'MFR.Objects.Configuration.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Configuration-Interfaces-IConfiguration'></a>
## IConfiguration `type`

##### Namespace

MFR.Objects.Configuration.Interfaces

##### Summary

Defines the public-exposed methods and properties of a configuration object.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfiguration-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets the text to be found that was most-recently specified
by the user.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfiguration-FindWhatHistory'></a>
### FindWhatHistory `property`

##### Summary

Gets or sets a collection of strings consisting of the most-recently
utilized values for Find What.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfiguration-IsFolded'></a>
### IsFolded `property`

##### Summary

Gets a value indicating whether the form is in the Folded state.

##### Remarks

If this value is `true` when the form is loaded, then ensure
that the form displays in the folded state.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfiguration-MatchCase'></a>
### MatchCase `property`

##### Summary

Gets or sets a value indicating whether we should match the case on
found text.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfiguration-MatchExactWord'></a>
### MatchExactWord `property`

##### Summary

Gets or sets a value indicating whether we should match the whole
word on found text.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfiguration-ReOpenSolution'></a>
### ReOpenSolution `property`

##### Summary

Gets or sets a flag that indicates whether to attempt to close and
then re-open the Visual Studio solution, if open, that contains the
project(s) being renamed.

##### Remarks

If this is set to `true`, and the containing solution is open,
then the solution will be closed prior to the start of the selected
operation(s) and then re-opened when the selected operation(s) are complete.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfiguration-RenameFiles'></a>
### RenameFiles `property`

##### Summary

Gets or sets a value that indicates whether we should rename files
in the folders encountered.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfiguration-RenameSubfolders'></a>
### RenameSubfolders `property`

##### Summary

Gets or sets a value that indicates whether we should rename subfolders.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfiguration-ReplaceInFiles'></a>
### ReplaceInFiles `property`

##### Summary

Gets or sets a value that indicates whether we should replace text
in files.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfiguration-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets the text that found text should be replaced with.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfiguration-ReplaceWithHistory'></a>
### ReplaceWithHistory `property`

##### Summary

Gets or sets a collection of strings that correspond to the
most-recently-used values for Replace With.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfiguration-SelectedOptionTab'></a>
### SelectedOptionTab `property`

##### Summary

Gets or sets a number from 0...N, where N is the number of option
tabs, of the one that is currently selected.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfiguration-StartingFolder'></a>
### StartingFolder `property`

##### Summary

Gets or sets a string containing the path to the starting folder of
the search.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfiguration-StartingFolderHistory'></a>
### StartingFolderHistory `property`

##### Summary

Gets or sets a collection of strings that correspond to the
most-recently-used values for Starting Folder.

<a name='T-MFR-Objects-Configuration-Interfaces-IConfigurationComposedObject'></a>
## IConfigurationComposedObject `type`

##### Namespace

MFR.Objects.Configuration.Interfaces

##### Summary

Defines the public-exposed methods and properties of an object that is
composed with an instance of another object that implements the
[IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Objects.Configuration.Interfaces.IConfiguration')
interface.

<a name='P-MFR-Objects-Configuration-Interfaces-IConfigurationComposedObject-Configuration'></a>
### Configuration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the [IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Objects.Configuration.Interfaces.IConfiguration') interface.

<a name='M-MFR-Objects-Configuration-Interfaces-IConfigurationComposedObject-AndAttachConfiguration-MFR-Objects-Configuration-Interfaces-IConfiguration-'></a>
### AndAttachConfiguration() `method`

##### Summary

Associates user settings, in the form of an instance of an object
that implements the
[IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Objects.Configuration.Interfaces.IConfiguration')
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

The [IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Objects.Configuration.Interfaces.IConfiguration')
-implementing configuration object controls the behavior of this
text-expression matcher object by dint of the settings chosen by the
user at runtime.

<a name='M-MFR-Objects-Configuration-Interfaces-IConfigurationComposedObject-UpdateConfiguration-MFR-Objects-Configuration-Interfaces-IConfiguration-'></a>
### UpdateConfiguration(configuration) `method`

##### Summary

Updates the configuration currently being used with a new value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [MFR.Objects.Configuration.Interfaces.IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Objects.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the [IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Objects.Configuration.Interfaces.IConfiguration') interface
which has the new settings. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `configuration`,
is passed a `null` value. |

##### Remarks

The settings in the object specified will be used for all matching
from this point forward.

<a name='M-MFR-Objects-Configuration-Interfaces-IConfigurationComposedObject-VerifyConfigurationAttached'></a>
### VerifyConfigurationAttached() `method`

##### Summary

Verifies that configuration has been attached to this object.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [MFR.Objects.ConfigurationNotAttachedException](#T-MFR-Objects-ConfigurationNotAttachedException 'MFR.Objects.ConfigurationNotAttachedException') | Thrown if no configuration data is attached to this object. |

##### Remarks

If no configuration is attached to this object, then a new
[ConfigurationNotAttachedException](#T-MFR-Objects-ConfigurationNotAttachedException 'MFR.Objects.ConfigurationNotAttachedException')
exception is thrown.

<a name='T-MFR-Objects-Configuration-Interfaces-IFixedTextMatchingConfigurationSpecificObject'></a>
## IFixedTextMatchingConfigurationSpecificObject `type`

##### Namespace

MFR.Objects.Configuration.Interfaces

##### Summary

Defines the public-exposed methods and properties of an object that is
tagged with one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values.

##### Remarks

This interface represents an object for which the operation type is immutable.

<a name='P-MFR-Objects-Configuration-Interfaces-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='T-MFR-Objects-Configuration-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Configuration.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Configuration-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Configuration-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
