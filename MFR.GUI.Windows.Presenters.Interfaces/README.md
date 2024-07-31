<a name='assembly'></a>
# MFR.GUI.Windows.Presenters.Interfaces

## Contents

- [IMainWindowPresenter](#T-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter')
  - [CommandLineInfo](#P-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-CommandLineInfo 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.CommandLineInfo')
  - [IsDirty](#P-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-IsDirty 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.IsDirty')
  - [IsProfileLoaded](#P-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-IsProfileLoaded 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.IsProfileLoaded')
  - [AddProfile(name)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-AddProfile-System-String- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.AddProfile(System.String)')
  - [AndHistoryManager(historyManager)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-AndHistoryManager-MFR-Managers-History-Interfaces-IHistoryManager- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.AndHistoryManager(MFR.Managers.History.Interfaces.IHistoryManager)')
  - [ClearAllHistory()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ClearAllHistory 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ClearAllHistory')
  - [DoSelectedOperations()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-DoSelectedOperations 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.DoSelectedOperations')
  - [ExportConfiguration(pathname)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ExportConfiguration-System-String- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ExportConfiguration(System.String)')
  - [FileExist(pathname)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-FileExist-System-String- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.FileExist(System.String)')
  - [FillProfileDropDownList()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-FillProfileDropDownList 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.FillProfileDropDownList')
  - [ImportConfiguration(pathname)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ImportConfiguration-System-String- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ImportConfiguration(System.String)')
  - [InitializeOperationSelections()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-InitializeOperationSelections 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.InitializeOperationSelections')
  - [ProfileAlreadyExist(profileName)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ProfileAlreadyExist-System-String- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ProfileAlreadyExist(System.String)')
  - [RenameConfigFileToMatchNewName(newConfigFilePath)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-RenameConfigFileToMatchNewName-System-String- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.RenameConfigFileToMatchNewName(System.String)')
  - [SaveConfiguration()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-SaveConfiguration 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.SaveConfiguration')
  - [SaveConfigurationDataFrom(dialog)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-SaveConfigurationDataFrom-MFR-GUI-Dialogs-Interfaces-IOptionsDialog- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.SaveConfigurationDataFrom(MFR.GUI.Dialogs.Interfaces.IOptionsDialog)')
  - [SaveCurrentConfigurationurationAsProfile(profileName)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-SaveCurrentConfigurationurationAsProfile-System-String- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.SaveCurrentConfigurationurationAsProfile(System.String)')
  - [SetCommandLineInfo(cmdInfo)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-SetCommandLineInfo-MFR-CommandLine-Models-Interfaces-ICommandLineInfo- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.SetCommandLineInfo(MFR.CommandLine.Models.Interfaces.ICommandLineInfo)')
  - [WithOperationEngine(operationEngine)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-WithOperationEngine-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.WithOperationEngine(MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine)')
- [Resources](#T-MFR-GUI-Windows-Presenters-Interfaces-Properties-Resources 'MFR.GUI.Windows.Presenters.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-GUI-Windows-Presenters-Interfaces-Properties-Resources-Culture 'MFR.GUI.Windows.Presenters.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Windows-Presenters-Interfaces-Properties-Resources-ResourceManager 'MFR.GUI.Windows.Presenters.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter'></a>
## IMainWindowPresenter `type`

##### Namespace

MFR.GUI.Windows.Presenters.Interfaces

##### Summary

Defines the public-exposed methods and properties of the presenter
object for the main application window.

<a name='P-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-CommandLineInfo'></a>
### CommandLineInfo `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface,
containing the settings that were specified by the user on the command line
when this application  was launched.

##### Remarks

This property raises the
[](#E-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-CommandLineInfoChanged 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.CommandLineInfoChanged')
event when its value is updated.

<a name='P-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-IsDirty'></a>
### IsDirty `property`

##### Summary

Gets a value that indicates whether the values displayed to the user differ
from those in the configuration file.

<a name='P-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-IsProfileLoaded'></a>
### IsProfileLoaded `property`

##### Summary

Gets a value that indicates whether a Profile is currently loaded.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-AddProfile-System-String-'></a>
### AddProfile(name) `method`

##### Summary

Creates a 'profile' (really a way of saving a group of
config
settings) and then adds it to the collection of profiles that the user has.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A descriptive name for the profile.



The name of the profile can't be reused. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the `name` parameter has a
 reference, or is the blank or whitespace string.



The `name` parameter is required. |

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-AndHistoryManager-MFR-Managers-History-Interfaces-IHistoryManager-'></a>
### AndHistoryManager(historyManager) `method`

##### Summary

Fluent-builder method for initializing the history manager
dependency of this Presenter class. History Manager objects control
the flow of values into and out of the list of previously-specified
values in prior searches.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| historyManager | [MFR.Managers.History.Interfaces.IHistoryManager](#T-MFR-Managers-History-Interfaces-IHistoryManager 'MFR.Managers.History.Interfaces.IHistoryManager') | Reference to an instance of an object that implements the
[IHistoryManager](#T-MFR-IHistoryManager 'MFR.IHistoryManager')
on which this Presenter
should depend. |

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ClearAllHistory'></a>
### ClearAllHistory() `method`

##### Summary

Clears all the history lists in the config.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-DoSelectedOperations'></a>
### DoSelectedOperations() `method`

##### Summary

Executes the operations selected by the user.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ExportConfiguration-System-String-'></a>
### ExportConfiguration(pathname) `method`

##### Summary

Exports the current config data to the file on the
user's hard drive having the specified `pathname`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file to which the config should be exported. |

##### Remarks

If a file having the specified `pathname` already
exists on the file system at the time the export operation is performed, it will be
overwritten.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-FileExist-System-String-'></a>
### FileExist(pathname) `method`

##### Summary

Determines whether the file having the specified `pathname`
exists.

##### Returns

`true` if the `pathname` is
non-blank and contains the fully-qualified pathname of a file that exists;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file to be searched for. |

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-FillProfileDropDownList'></a>
### FillProfileDropDownList() `method`

##### Summary

This method is called to populate the Profiles combo box.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ImportConfiguration-System-String-'></a>
### ImportConfiguration(pathname) `method`

##### Summary

Imports the config data for this application from the file with the
specified `pathname`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file from which the config should be imported. |

##### Remarks

The data is presumed to be located inside a JSON-formatted file
that exists on the user's hard drive and has the `.json` extension.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-InitializeOperationSelections'></a>
### InitializeOperationSelections() `method`

##### Summary

Sets the state of the Operations to Perform checked list box items
based on config settings.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ProfileAlreadyExist-System-String-'></a>
### ProfileAlreadyExist(profileName) `method`

##### Summary

Determines whether a Profile having the specified
`profileName` is already defined.



The match that is done is case-insensitive.

##### Returns

`true` if a Profile having the specified
`profileName` is defined; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| profileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the Profile
to search for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`profileName`, is passed a blank or `null`
string for a value. |

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-RenameConfigFileToMatchNewName-System-String-'></a>
### RenameConfigFileToMatchNewName(newConfigFilePath) `method`

##### Summary

If the user has changed the pathname of where the config file is to be
stored, this method renames the existing config file to match.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newConfigFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the new value of the
fully-qualified pathname of the config file. |

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-SaveConfiguration'></a>
### SaveConfiguration() `method`

##### Summary

Saves data from the screen control and then saves the
config to the persistence location.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-SaveConfigurationDataFrom-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-'></a>
### SaveConfigurationDataFrom(dialog) `method`

##### Summary

Runs code that should execute when either the OK or Apply buttons
are clicked on the Tools -> Options dialog box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dialog | [MFR.GUI.Dialogs.Interfaces.IOptionsDialog](#T-MFR-GUI-Dialogs-Interfaces-IOptionsDialog 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog') | (Required.) Reference to an instance of an object that implements
the [IOptionsDialog](#T-MFR-GUI-Dialogs-Interfaces-IOptionsDialog 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `dialog`, is
passed a `null` value. |

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-SaveCurrentConfigurationurationAsProfile-System-String-'></a>
### SaveCurrentConfigurationurationAsProfile(profileName) `method`

##### Summary

Transforms the current value of the
[ProjectFileRenamerConfig](#P-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-ProjectFileRenamerConfig 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.ProjectFileRenamerConfig')
property into a Profile with the `profileName` specified.



If a Profile with the same name is already defined, then this method does
nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| profileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name to give the
new Profile. |

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-SetCommandLineInfo-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-'></a>
### SetCommandLineInfo(cmdInfo) `method`

##### Summary

Updates the value of the
[CommandLineInfo](#P-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-CommandLineInfo 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.CommandLineInfo')
property with the specified `cmdInfo` reference.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cmdInfo | [MFR.CommandLine.Models.Interfaces.ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') | (Required.) Reference to an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface. |

##### Remarks

If this method updates the value of the
[CommandLineInfo](#P-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-CommandLineInfo 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.CommandLineInfo')
property, then the
[](#E-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-CommandLineInfoChanged 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.CommandLineInfoChanged')
event is raised.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-WithOperationEngine-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-'></a>
### WithOperationEngine(operationEngine) `method`

##### Summary

Fluent-builder method for initializing the operation engine object.  This
the object that actually schedules and runs the file-renaming tasks and
provides user feedback.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| operationEngine | [MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine](#T-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine') | (Required.) Reference to an instance of an object that implements the
[IFullGuiOperationEngine](#T-MFR-Engines-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Interfaces.IFullGuiOperationEngine') interface on
which this Presenter should depend. |

<a name='T-MFR-GUI-Windows-Presenters-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Windows.Presenters.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Windows-Presenters-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Windows-Presenters-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
