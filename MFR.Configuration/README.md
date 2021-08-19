<a name='assembly'></a>
# MFR.Configuration

## Contents

- [Configuration](#T-MFR-Objects-Configuration-Configuration 'MFR.Configuration.Configuration')
  - [#ctor()](#M-MFR-Objects-Configuration-Configuration-#ctor 'MFR.Configuration.Configuration.#ctor')
  - [FindWhat](#P-MFR-Objects-Configuration-Configuration-FindWhat 'MFR.Configuration.Configuration.FindWhat')
  - [FindWhatHistory](#P-MFR-Objects-Configuration-Configuration-FindWhatHistory 'MFR.Configuration.Configuration.FindWhatHistory')
  - [IsFolded](#P-MFR-Objects-Configuration-Configuration-IsFolded 'MFR.Configuration.Configuration.IsFolded')
  - [MatchCase](#P-MFR-Objects-Configuration-Configuration-MatchCase 'MFR.Configuration.Configuration.MatchCase')
  - [MatchExactWord](#P-MFR-Objects-Configuration-Configuration-MatchExactWord 'MFR.Configuration.Configuration.MatchExactWord')
  - [ReOpenSolution](#P-MFR-Objects-Configuration-Configuration-ReOpenSolution 'MFR.Configuration.Configuration.ReOpenSolution')
  - [RenameFiles](#P-MFR-Objects-Configuration-Configuration-RenameFiles 'MFR.Configuration.Configuration.RenameFiles')
  - [RenameSubfolders](#P-MFR-Objects-Configuration-Configuration-RenameSubfolders 'MFR.Configuration.Configuration.RenameSubfolders')
  - [ReplaceInFiles](#P-MFR-Objects-Configuration-Configuration-ReplaceInFiles 'MFR.Configuration.Configuration.ReplaceInFiles')
  - [ReplaceWith](#P-MFR-Objects-Configuration-Configuration-ReplaceWith 'MFR.Configuration.Configuration.ReplaceWith')
  - [ReplaceWithHistory](#P-MFR-Objects-Configuration-Configuration-ReplaceWithHistory 'MFR.Configuration.Configuration.ReplaceWithHistory')
  - [SelectedOptionTab](#P-MFR-Objects-Configuration-Configuration-SelectedOptionTab 'MFR.Configuration.Configuration.SelectedOptionTab')
  - [StartingFolder](#P-MFR-Objects-Configuration-Configuration-StartingFolder 'MFR.Configuration.Configuration.StartingFolder')
  - [StartingFolderHistory](#P-MFR-Objects-Configuration-Configuration-StartingFolderHistory 'MFR.Configuration.Configuration.StartingFolderHistory')
  - [Reset()](#M-MFR-Objects-Configuration-Configuration-Reset 'MFR.Configuration.Configuration.Reset')
- [ConfigurationComposedObjectBase](#T-MFR-Objects-Configuration-ConfigurationComposedObjectBase 'MFR.Configuration.ConfigurationComposedObjectBase')
  - [#ctor()](#M-MFR-Objects-Configuration-ConfigurationComposedObjectBase-#ctor 'MFR.Configuration.ConfigurationComposedObjectBase.#ctor')
  - [#ctor(configuration)](#M-MFR-Objects-Configuration-ConfigurationComposedObjectBase-#ctor-MFR-Objects-Configuration-Interfaces-IConfiguration- 'MFR.Configuration.ConfigurationComposedObjectBase.#ctor(MFR.Configuration.Interfaces.IConfiguration)')
  - [Configuration](#P-MFR-Objects-Configuration-ConfigurationComposedObjectBase-Configuration 'MFR.Configuration.ConfigurationComposedObjectBase.Configuration')
  - [IsConfigurationAttached](#P-MFR-Objects-Configuration-ConfigurationComposedObjectBase-IsConfigurationAttached 'MFR.Configuration.ConfigurationComposedObjectBase.IsConfigurationAttached')
  - [AndAttachConfiguration()](#M-MFR-Objects-Configuration-ConfigurationComposedObjectBase-AndAttachConfiguration-MFR-Objects-Configuration-Interfaces-IConfiguration- 'MFR.Configuration.ConfigurationComposedObjectBase.AndAttachConfiguration(MFR.Configuration.Interfaces.IConfiguration)')
  - [UpdateConfiguration(configuration)](#M-MFR-Objects-Configuration-ConfigurationComposedObjectBase-UpdateConfiguration-MFR-Objects-Configuration-Interfaces-IConfiguration- 'MFR.Configuration.ConfigurationComposedObjectBase.UpdateConfiguration(MFR.Configuration.Interfaces.IConfiguration)')
  - [VerifyConfigurationAttached()](#M-MFR-Objects-Configuration-ConfigurationComposedObjectBase-VerifyConfigurationAttached 'MFR.Configuration.ConfigurationComposedObjectBase.VerifyConfigurationAttached')
- [Resources](#T-MFR-Objects-Configuration-Properties-Resources 'MFR.Configuration.Properties.Resources')
  - [Culture](#P-MFR-Objects-Configuration-Properties-Resources-Culture 'MFR.Configuration.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Configuration-Properties-Resources-ResourceManager 'MFR.Configuration.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Configuration-Configuration'></a>
## Configuration `type`

##### Namespace

MFR.Configuration

##### Summary

Contains properties whose values are set by the user.

##### Remarks

The values of this class' properties are used to affect the behavior of
the application.

<a name='M-MFR-Objects-Configuration-Configuration-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[Configuration](#T-MFR-Objects-Configuration-Configuration 'MFR.Configuration.Configuration')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Configuration-Configuration-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets the text to be found that was most-recently specified
by the user.

<a name='P-MFR-Objects-Configuration-Configuration-FindWhatHistory'></a>
### FindWhatHistory `property`

##### Summary

Gets or sets a collection of strings consisting of the most-recently
utilized values for Find What.

<a name='P-MFR-Objects-Configuration-Configuration-IsFolded'></a>
### IsFolded `property`

##### Summary

Gets a value indicating whether the form is in the Folded state.

##### Remarks

If this value is `true` when the form is loaded, then ensure
that the form displays in the folded state.

<a name='P-MFR-Objects-Configuration-Configuration-MatchCase'></a>
### MatchCase `property`

##### Summary

Gets or sets a value indicating whether we should match the case on
found text.

<a name='P-MFR-Objects-Configuration-Configuration-MatchExactWord'></a>
### MatchExactWord `property`

##### Summary

Gets or sets a value indicating whether we should match the whole
word on found text.

<a name='P-MFR-Objects-Configuration-Configuration-ReOpenSolution'></a>
### ReOpenSolution `property`

##### Summary

Gets or sets a flag that indicates whether to attempt to close and
then re-open the Visual Studio solution, if open, that contains the
project(s) being renamed.

##### Remarks

If this is set to `true`, and the containing solution is open,
then the solution will be closed prior to the start of the selected
operation(s) and then re-opened when the selected operation(s) are complete.

<a name='P-MFR-Objects-Configuration-Configuration-RenameFiles'></a>
### RenameFiles `property`

##### Summary

Gets or sets a value that indicates whether we should rename files
in the folders encountered.

<a name='P-MFR-Objects-Configuration-Configuration-RenameSubfolders'></a>
### RenameSubfolders `property`

##### Summary

Gets or sets a value that indicates whether we should rename subfolders.

<a name='P-MFR-Objects-Configuration-Configuration-ReplaceInFiles'></a>
### ReplaceInFiles `property`

##### Summary

Gets or sets a value that indicates whether we should replace text
in files.

<a name='P-MFR-Objects-Configuration-Configuration-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets the text that found text should be replaced with.

<a name='P-MFR-Objects-Configuration-Configuration-ReplaceWithHistory'></a>
### ReplaceWithHistory `property`

##### Summary

Gets or sets a collection of strings that correspond to the
most-recently-used values for Replace With.

<a name='P-MFR-Objects-Configuration-Configuration-SelectedOptionTab'></a>
### SelectedOptionTab `property`

##### Summary

Gets or sets a number from 0...N, where N is the number of option
tabs, of the one that is currently selected.

<a name='P-MFR-Objects-Configuration-Configuration-StartingFolder'></a>
### StartingFolder `property`

##### Summary

Gets or sets a string containing the path to the starting folder of
the search.

<a name='P-MFR-Objects-Configuration-Configuration-StartingFolderHistory'></a>
### StartingFolderHistory `property`

##### Summary

Gets or sets a collection of strings that correspond to the
most-recently-used values for Starting Folder.

<a name='M-MFR-Objects-Configuration-Configuration-Reset'></a>
### Reset() `method`

##### Summary

Sets the values of this class' properties to their default values.

##### Parameters

This method has no parameters.

##### Remarks

This method typically is called from a class constructor.

<a name='T-MFR-Objects-Configuration-ConfigurationComposedObjectBase'></a>
## ConfigurationComposedObjectBase `type`

##### Namespace

MFR.Configuration

##### Summary

Provides common functionality for all those objects that get composed
with another object that implements the
[IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration')
interface.

<a name='M-MFR-Objects-Configuration-ConfigurationComposedObjectBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ConfigurationComposedObjectBase](#T-MFR-Objects-ConfigurationComposedObjectBase 'MFR.ConfigurationComposedObjectBase')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor calls the
[EnforceClientRequirementToCallAttachConfiguration](#M-MFR-Objects-ConfigurationComposedObjectBase-EnforceClientRequirementToCallAttachConfiguration 'MFR.ConfigurationComposedObjectBase.EnforceClientRequirementToCallAttachConfiguration')
method in order to enforce a fluent method call to the
[AndAttachConfiguration](#M-MFR-Objects-IConfigurationComposedObject-AndAttachConfiguration 'MFR.IConfigurationComposedObject.AndAttachConfiguration')
method by whosoever invokes this constructor in order to finish
building this object.

<a name='M-MFR-Objects-Configuration-ConfigurationComposedObjectBase-#ctor-MFR-Objects-Configuration-Interfaces-IConfiguration-'></a>
### #ctor(configuration) `constructor`

##### Summary

Constructs a new instance of
[TextExpressionMatchingEngineBase](#T-MFR-Objects-TextExpressionMatchingEngineBase 'MFR.TextExpressionMatchingEngineBase')
and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [MFR.Configuration.Interfaces.IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the [IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration') interface
that holds settings that are specified by the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `configuration`,
is passed a `null` value. |

<a name='P-MFR-Objects-Configuration-ConfigurationComposedObjectBase-Configuration'></a>
### Configuration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the [IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration') interface.

##### Remarks

This object's properties give us access to the settings configured
by the user of the application.

<a name='P-MFR-Objects-Configuration-ConfigurationComposedObjectBase-IsConfigurationAttached'></a>
### IsConfigurationAttached `property`

##### Summary

Gets or sets a value indicating whether this object has been
properly composed with an instance of an object that implements the
[IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration') interface.

<a name='M-MFR-Objects-Configuration-ConfigurationComposedObjectBase-AndAttachConfiguration-MFR-Objects-Configuration-Interfaces-IConfiguration-'></a>
### AndAttachConfiguration() `method`

##### Summary

Associates user settings, in the form of an instance of an object
that implements the
[IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration')
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

The [IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration')
-implementing object controls the behavior of this text-expression
matcher object by dint of the settings chosen by the user at runtime.

<a name='M-MFR-Objects-Configuration-ConfigurationComposedObjectBase-UpdateConfiguration-MFR-Objects-Configuration-Interfaces-IConfiguration-'></a>
### UpdateConfiguration(configuration) `method`

##### Summary

Updates the configuration currently being used with a new value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [MFR.Configuration.Interfaces.IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the [IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration') interface
which has the new settings. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `configuration`,
is passed a `null` value. |

##### Remarks

The settings in the object specified will be used for all matching
from this point forward.



NOTE:This member may be overriden by a child class. If this is the
case, the overrider must call the base class method before doing any
of its own processing.

<a name='M-MFR-Objects-Configuration-ConfigurationComposedObjectBase-VerifyConfigurationAttached'></a>
### VerifyConfigurationAttached() `method`

##### Summary

Verifies that configuration has been attached to this object.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [MFR.ConfigurationNotAttachedException](#T-MFR-Objects-ConfigurationNotAttachedException 'MFR.ConfigurationNotAttachedException') | Thrown if no configuration data is attached to this object. |

##### Remarks

If no configuration is attached to this object, then a new
[ConfigurationNotAttachedException](#T-MFR-Objects-ConfigurationNotAttachedException 'MFR.ConfigurationNotAttachedException')
exception is thrown.

<a name='T-MFR-Objects-Configuration-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Configuration.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Configuration-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Configuration-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
