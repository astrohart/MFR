<a name='assembly'></a>
# MFR.Settings.Configuration

## Contents

- [ConfigurationComposedObjectBase](#T-MFR-Settings-Configuration-ConfigurationComposedObjectBase 'MFR.Settings.Configuration.ConfigurationComposedObjectBase')
  - [#ctor()](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-#ctor 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.#ctor')
  - [#ctor(projectFileRenamerConfiguration)](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration- 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration)')
  - [CurrentConfiguration](#P-MFR-Settings-Configuration-ConfigurationComposedObjectBase-CurrentConfiguration 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.CurrentConfiguration')
  - [IsConfigurationAttached](#P-MFR-Settings-Configuration-ConfigurationComposedObjectBase-IsConfigurationAttached 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.IsConfigurationAttached')
  - [AndAttachConfiguration()](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-AndAttachConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration- 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.AndAttachConfiguration(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration)')
  - [UpdateConfiguration(configuration)](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration- 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.UpdateConfiguration(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration)')
  - [VerifyConfigurationAttached()](#M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-VerifyConfigurationAttached 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.VerifyConfigurationAttached')
- [ProjectFileRenamerProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration')
  - [#ctor()](#M-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-#ctor 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.#ctor')
  - [#ctor(source)](#M-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration- 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration)')
  - [_startingFolder](#F-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-_startingFolder 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration._startingFolder')
  - [AutoStart](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-AutoStart 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.AutoStart')
  - [FindWhat](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-FindWhat 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.FindWhat')
  - [FindWhatHistory](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-FindWhatHistory 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.FindWhatHistory')
  - [IsFolded](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-IsFolded 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.IsFolded')
  - [IsFromCommandLine](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-IsFromCommandLine 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.IsFromCommandLine')
  - [MatchCase](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-MatchCase 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.MatchCase')
  - [MatchExactWord](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-MatchExactWord 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.MatchExactWord')
  - [OperationsToPerform](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-OperationsToPerform 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.OperationsToPerform')
  - [ReOpenSolution](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-ReOpenSolution 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.ReOpenSolution')
  - [RenameFiles](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-RenameFiles 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.RenameFiles')
  - [RenameSubFolders](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-RenameSubFolders 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.RenameSubFolders')
  - [ReplaceTextInFiles](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-ReplaceTextInFiles 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.ReplaceTextInFiles')
  - [ReplaceWith](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-ReplaceWith 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.ReplaceWith')
  - [ReplaceWithHistory](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-ReplaceWithHistory 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.ReplaceWithHistory')
  - [SelectedOptionTab](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-SelectedOptionTab 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.SelectedOptionTab')
  - [StartingFolder](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-StartingFolder 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.StartingFolder')
  - [StartingFolderHistory](#P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-StartingFolderHistory 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.StartingFolderHistory')
  - [OnStartingFolderChanged()](#M-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-OnStartingFolderChanged 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.OnStartingFolderChanged')
  - [Reset()](#M-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-Reset 'MFR.Settings.Configuration.ProjectFileRenamerProjectFileRenamerConfiguration.Reset')
- [Resources](#T-MFR-Settings-Configuration-Properties-Resources 'MFR.Settings.Configuration.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Properties-Resources-Culture 'MFR.Settings.Configuration.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-ConfigurationComposedObjectBase'></a>
## ConfigurationComposedObjectBase `type`

##### Namespace

MFR.Settings.Configuration

##### Summary

Provides common functionality for all those objects that get composed
with another object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface.

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ConfigurationComposedObjectBase](#T-MFR-Settings-Configuration-ConfigurationComposedObjectBase-ConfigurationComposedObjectBase 'MFR.Settings.Configuration.ConfigurationComposedObjectBase.ConfigurationComposedObjectBase')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-'></a>
### #ctor(projectFileRenamerConfiguration) `constructor`

##### Summary

Constructs a new instance of
[TextExpressionMatchingEngineBase](#T-MFR-TextExpressionMatchingEngineBase 'MFR.TextExpressionMatchingEngineBase')
and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectFileRenamerConfiguration | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the [IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') interface
that holds settings that are specified by the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `projectFileRenamerConfiguration`,
is passed a `null` value. |

<a name='P-MFR-Settings-Configuration-ConfigurationComposedObjectBase-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the [IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') interface.

##### Remarks

This object's properties give us access to the settings configured
by the user of the application.

<a name='P-MFR-Settings-Configuration-ConfigurationComposedObjectBase-IsConfigurationAttached'></a>
### IsConfigurationAttached `property`

##### Summary

Gets or sets a value indicating whether this object has been
properly composed with an instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') interface.

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-AndAttachConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-'></a>
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
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `projectFileRenamerConfiguration`,
is passed a `null` value. |

##### Remarks

The [IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
-implementing projectFileRenamerConfiguration object controls the behavior of this
object by dint of the settings chosen by the user at runtime.

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-'></a>
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



NOTE:This member may be overriden by a child class. If this is the
case, the overrider must call the base class method before doing any
of its own processing.

<a name='M-MFR-Settings-Configuration-ConfigurationComposedObjectBase-VerifyConfigurationAttached'></a>
### VerifyConfigurationAttached() `method`

##### Summary

Verifies that projectFileRenamerConfiguration has been attached to this object.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException') | Thrown if no projectFileRenamerConfiguration data is attached to this object. |

##### Remarks

If no projectFileRenamerConfiguration is attached to this object, then
[ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException')
is thrown.



Child classes may override this method, e.g., to make
attaching a projectFileRenamerConfiguration object optional.

<a name='T-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration'></a>
## ProjectFileRenamerProjectFileRenamerConfiguration `type`

##### Namespace

MFR.Settings.Configuration

##### Summary

Contains properties whose values are set by the user.

##### Remarks

The values of this class' properties are used to affect the behavior of
the application.

<a name='M-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-ProjectFileRenamerConfiguration 'MFR.Settings.Configuration.ProjectFileRenamerConfiguration')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-'></a>
### #ctor(source) `constructor`

##### Summary

Constructs a new instance of
[ProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-ProjectFileRenamerConfiguration 'MFR.Settings.Configuration.ProjectFileRenamerConfiguration')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') interface
that contains existing projectFileRenamerConfiguration settings to copy into this object. |

<a name='F-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-_startingFolder'></a>
### _startingFolder `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified pathname of the
folder in which the selected operation(s) should be initiated.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-AutoStart'></a>
### AutoStart `property`

##### Summary

Gets or sets a value indicating whether the specified operation(s) should be
automatically initiated when the application starts.  If this value is set to
`true` then the application quits automatically after the
specified operation(s) have been completed.

##### Remarks

This flag is ignored if this projectFileRenamerConfiguration did not originate from the command
line.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets the text to be found that was most-recently specified
by the user.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-FindWhatHistory'></a>
### FindWhatHistory `property`

##### Summary

Gets or sets a collection of strings consisting of the most-recently
utilized values for Find What.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-IsFolded'></a>
### IsFolded `property`

##### Summary

Gets a value indicating whether the form is in the Folded state.

##### Remarks

If this value is `true` when the form is loaded, then ensure
that the form displays in the folded state.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-IsFromCommandLine'></a>
### IsFromCommandLine `property`

##### Summary

Gets or sets a value indicating whether this projectFileRenamerConfiguration was specified by the
user on the command line.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-MatchCase'></a>
### MatchCase `property`

##### Summary

Gets or sets a value indicating whether we should match the case on
found text.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-MatchExactWord'></a>
### MatchExactWord `property`

##### Summary

Gets or sets a value indicating whether we should match the whole
word on found text.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-OperationsToPerform'></a>
### OperationsToPerform `property`

##### Summary

Gets or sets a reference to a collection of instances of
[OperationTypeInfo](#T-MFR-GUI-Models-OperationTypeInfo 'MFR.GUI.Models.OperationTypeInfo') instances, that can turn the
operations to be performed on or off.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-ReOpenSolution'></a>
### ReOpenSolution `property`

##### Summary

Gets or sets a flag that indicates whether to attempt to close and
then re-open the Visual Studio solution, if open, that contains the
project(s) being renamed.

##### Remarks

If this is set to `true`, and the containing solution is open,
then the solution will be closed prior to the start of the selected
operation(s) and then re-opened when the selected operation(s) are complete.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-RenameFiles'></a>
### RenameFiles `property`

##### Summary

Gets or sets a value that indicates whether we should rename files
in the folders encountered.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-RenameSubFolders'></a>
### RenameSubFolders `property`

##### Summary

Gets or sets a value that indicates whether we should rename subfolders.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-ReplaceTextInFiles'></a>
### ReplaceTextInFiles `property`

##### Summary

Gets or sets a value that indicates whether we should replace text
in files.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets the text that found text should be replaced with.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-ReplaceWithHistory'></a>
### ReplaceWithHistory `property`

##### Summary

Gets or sets a collection of strings that correspond to the
most-recently-used values for Replace With.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-SelectedOptionTab'></a>
### SelectedOptionTab `property`

##### Summary

Gets or sets a number from 0...N, where N is the number of option
tabs, of the one that is currently selected.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-StartingFolder'></a>
### StartingFolder `property`

##### Summary

Gets or sets a string containing the path to the starting folder of
the search.

<a name='P-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-StartingFolderHistory'></a>
### StartingFolderHistory `property`

##### Summary

Gets or sets a collection of strings that correspond to the
most-recently-used values for Starting Folder.

<a name='M-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-OnStartingFolderChanged'></a>
### OnStartingFolderChanged() `method`

##### Summary

Raises the
[](#E-MFR-Settings-ProjectFileRenamerConfiguration-ProjectFileRenamerConfiguration-StartingFolderChanged 'MFR.Settings.ProjectFileRenamerConfiguration.ProjectFileRenamerConfiguration.StartingFolderChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-ProjectFileRenamerProjectFileRenamerConfiguration-Reset'></a>
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

<a name='P-MFR-Settings-Configuration-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
