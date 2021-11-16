<a name='assembly'></a>
# MFR.Settings.Configuration

## Contents

- [Configuration](#T-MFR-Settings-Configuration-Configuration 'MFR.Settings.Configuration.Configuration')
  - [#ctor()](#M-MFR-Settings-Configuration-Configuration-#ctor 'MFR.Settings.Configuration.Configuration.#ctor')
  - [#ctor(source)](#M-MFR-Settings-Configuration-Configuration-#ctor-MFR-Settings-Configuration-Interfaces-IConfiguration- 'MFR.Settings.Configuration.Configuration.#ctor(MFR.Settings.Configuration.Interfaces.IConfiguration)')
  - [FindWhat](#P-MFR-Settings-Configuration-Configuration-FindWhat 'MFR.Settings.Configuration.Configuration.FindWhat')
  - [FindWhatHistory](#P-MFR-Settings-Configuration-Configuration-FindWhatHistory 'MFR.Settings.Configuration.Configuration.FindWhatHistory')
  - [IsFolded](#P-MFR-Settings-Configuration-Configuration-IsFolded 'MFR.Settings.Configuration.Configuration.IsFolded')
  - [MatchCase](#P-MFR-Settings-Configuration-Configuration-MatchCase 'MFR.Settings.Configuration.Configuration.MatchCase')
  - [MatchExactWord](#P-MFR-Settings-Configuration-Configuration-MatchExactWord 'MFR.Settings.Configuration.Configuration.MatchExactWord')
  - [OperationsToPerform](#P-MFR-Settings-Configuration-Configuration-OperationsToPerform 'MFR.Settings.Configuration.Configuration.OperationsToPerform')
  - [ReOpenSolution](#P-MFR-Settings-Configuration-Configuration-ReOpenSolution 'MFR.Settings.Configuration.Configuration.ReOpenSolution')
  - [RenameFiles](#P-MFR-Settings-Configuration-Configuration-RenameFiles 'MFR.Settings.Configuration.Configuration.RenameFiles')
  - [RenameSubfolders](#P-MFR-Settings-Configuration-Configuration-RenameSubfolders 'MFR.Settings.Configuration.Configuration.RenameSubfolders')
  - [ReplaceInFiles](#P-MFR-Settings-Configuration-Configuration-ReplaceInFiles 'MFR.Settings.Configuration.Configuration.ReplaceInFiles')
  - [ReplaceWith](#P-MFR-Settings-Configuration-Configuration-ReplaceWith 'MFR.Settings.Configuration.Configuration.ReplaceWith')
  - [ReplaceWithHistory](#P-MFR-Settings-Configuration-Configuration-ReplaceWithHistory 'MFR.Settings.Configuration.Configuration.ReplaceWithHistory')
  - [SelectedOptionTab](#P-MFR-Settings-Configuration-Configuration-SelectedOptionTab 'MFR.Settings.Configuration.Configuration.SelectedOptionTab')
  - [StartingFolder](#P-MFR-Settings-Configuration-Configuration-StartingFolder 'MFR.Settings.Configuration.Configuration.StartingFolder')
  - [StartingFolderHistory](#P-MFR-Settings-Configuration-Configuration-StartingFolderHistory 'MFR.Settings.Configuration.Configuration.StartingFolderHistory')
  - [Reset()](#M-MFR-Settings-Configuration-Configuration-Reset 'MFR.Settings.Configuration.Configuration.Reset')
- [ConfigurationComposedObjectBase](#T-MFR-Settings-Configuration-ConfigurationComposedObjectBase 'MFR.Settings.Configuration.ConfigurationComposedObjectBase')
  - [#ctor()](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-#ctor 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.#ctor')
  - [#ctor(configuration)](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-#ctor-MFR-Settings-Configuration-Interfaces-IConfiguration- 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.#ctor(MFR.Settings.Configuration.Interfaces.IConfiguration)')
  - [Configuration](#P-MFR-Settings-Configuration-ConfigurationComposedObjectBase-Configuration 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.Configuration')
  - [IsConfigurationAttached](#P-MFR-Settings-Configuration-ConfigurationComposedObjectBase-IsConfigurationAttached 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.IsConfigurationAttached')
  - [AndAttachConfiguration()](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-AndAttachConfiguration-MFR-Settings-Configuration-Interfaces-IConfiguration- 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.AndAttachConfiguration(MFR.Settings.Configuration.Interfaces.IConfiguration)')
  - [UpdateConfiguration(configuration)](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IConfiguration- 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.UpdateConfiguration(MFR.Settings.Configuration.Interfaces.IConfiguration)')
  - [VerifyConfigurationAttached()](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-VerifyConfigurationAttached 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.VerifyConfigurationAttached')
- [Resources](#T-MFR-Settings-Configuration-Properties-Resources 'MFR.Settings.Configuration.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Properties-Resources-Culture 'MFR.Settings.Configuration.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Configuration'></a>
## Configuration `type`

##### Namespace

MFR.Settings.Configuration

##### Summary

Contains properties whose values are set by the user.

##### Remarks

The values of this class' properties are used to affect the behavior of
the application.

<a name='M-MFR-Settings-Configuration-Configuration-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[Configuration](#T-MFR-Settings-Configuration-Configuration 'MFR.Settings.Configuration.Configuration')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Settings-Configuration-Configuration-#ctor-MFR-Settings-Configuration-Interfaces-IConfiguration-'></a>
### #ctor(source) `constructor`

##### Summary

Constructs a new instance of
[Configuration](#T-MFR-Settings-Configuration-Configuration 'MFR.Settings.Configuration.Configuration')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') interface
that contains existing configuration settings to copy into this object. |

<a name='P-MFR-Settings-Configuration-Configuration-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets the text to be found that was most-recently specified
by the user.

<a name='P-MFR-Settings-Configuration-Configuration-FindWhatHistory'></a>
### FindWhatHistory `property`

##### Summary

Gets or sets a collection of strings consisting of the most-recently
utilized values for Find What.

<a name='P-MFR-Settings-Configuration-Configuration-IsFolded'></a>
### IsFolded `property`

##### Summary

Gets a value indicating whether the form is in the Folded state.

##### Remarks

If this value is `true` when the form is loaded, then ensure
that the form displays in the folded state.

<a name='P-MFR-Settings-Configuration-Configuration-MatchCase'></a>
### MatchCase `property`

##### Summary

Gets or sets a value indicating whether we should match the case on
found text.

<a name='P-MFR-Settings-Configuration-Configuration-MatchExactWord'></a>
### MatchExactWord `property`

##### Summary

Gets or sets a value indicating whether we should match the whole
word on found text.

<a name='P-MFR-Settings-Configuration-Configuration-OperationsToPerform'></a>
### OperationsToPerform `property`

##### Summary

Gets or sets a reference to a collection of instances of
[OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo') instances, that can turn the
operations to be performed on or off.

<a name='P-MFR-Settings-Configuration-Configuration-ReOpenSolution'></a>
### ReOpenSolution `property`

##### Summary

Gets or sets a flag that indicates whether to attempt to close and
then re-open the Visual Studio solution, if open, that contains the
project(s) being renamed.

##### Remarks

If this is set to `true`, and the containing solution is open,
then the solution will be closed prior to the start of the selected
operation(s) and then re-opened when the selected operation(s) are complete.

<a name='P-MFR-Settings-Configuration-Configuration-RenameFiles'></a>
### RenameFiles `property`

##### Summary

Gets or sets a value that indicates whether we should rename files
in the folders encountered.

<a name='P-MFR-Settings-Configuration-Configuration-RenameSubfolders'></a>
### RenameSubfolders `property`

##### Summary

Gets or sets a value that indicates whether we should rename subfolders.

<a name='P-MFR-Settings-Configuration-Configuration-ReplaceInFiles'></a>
### ReplaceInFiles `property`

##### Summary

Gets or sets a value that indicates whether we should replace text
in files.

<a name='P-MFR-Settings-Configuration-Configuration-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets the text that found text should be replaced with.

<a name='P-MFR-Settings-Configuration-Configuration-ReplaceWithHistory'></a>
### ReplaceWithHistory `property`

##### Summary

Gets or sets a collection of strings that correspond to the
most-recently-used values for Replace With.

<a name='P-MFR-Settings-Configuration-Configuration-SelectedOptionTab'></a>
### SelectedOptionTab `property`

##### Summary

Gets or sets a number from 0...N, where N is the number of option
tabs, of the one that is currently selected.

<a name='P-MFR-Settings-Configuration-Configuration-StartingFolder'></a>
### StartingFolder `property`

##### Summary

Gets or sets a string containing the path to the starting folder of
the search.

<a name='P-MFR-Settings-Configuration-Configuration-StartingFolderHistory'></a>
### StartingFolderHistory `property`

##### Summary

Gets or sets a collection of strings that correspond to the
most-recently-used values for Starting Folder.

<a name='M-MFR-Settings-Configuration-Configuration-Reset'></a>
### Reset() `method`

##### Summary

Sets the values of this class' properties to their default values.

##### Parameters

This method has no parameters.

##### Remarks

This method typically is called from a class constructor.

<a name='T-MFR-Settings-Configuration-ConfigurationComposedObjectBase'></a>
## ConfigurationComposedObjectBase `type`

##### Namespace

MFR.Settings.Configuration

##### Summary

Provides common functionality for all those objects that get composed
with another object that implements the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface.

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ConfigurationComposedObjectBase](#T-MFR-Settings-ConfigurationComposedObjectBase 'MFR.Settings.ConfigurationComposedObjectBase')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-#ctor-MFR-Settings-Configuration-Interfaces-IConfiguration-'></a>
### #ctor(configuration) `constructor`

##### Summary

Constructs a new instance of
[TextExpressionMatchingEngineBase](#T-MFR-TextExpressionMatchingEngineBase 'MFR.TextExpressionMatchingEngineBase')
and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the [IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') interface
that holds settings that are specified by the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `configuration`,
is passed a `null` value. |

<a name='P-MFR-Settings-Configuration-ConfigurationComposedObjectBase-Configuration'></a>
### Configuration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the [IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') interface.

##### Remarks

This object's properties give us access to the settings configured
by the user of the application.

<a name='P-MFR-Settings-Configuration-ConfigurationComposedObjectBase-IsConfigurationAttached'></a>
### IsConfigurationAttached `property`

##### Summary

Gets or sets a value indicating whether this object has been
properly composed with an instance of an object that implements the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') interface.

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-AndAttachConfiguration-MFR-Settings-Configuration-Interfaces-IConfiguration-'></a>
### AndAttachConfiguration() `method`

##### Summary

Associates user settings, in the form of an instance of an object
that implements the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
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

The [IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
-implementing configuration object controls the behavior of this
object by dint of the settings chosen by the user at runtime.

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IConfiguration-'></a>
### UpdateConfiguration(configuration) `method`

##### Summary

Updates the configuration currently being used with a new value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the [IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') interface
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

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-VerifyConfigurationAttached'></a>
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

If no configuration is attached to this object, then
[ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException')
is thrown.



Child classes may override this method, e.g., to make
attaching a configuration object optional.

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

<a name='P-MFR-Settings-Configuration-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
