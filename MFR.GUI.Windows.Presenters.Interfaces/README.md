<a name='assembly'></a>
# MFR.GUI.Windows.Presenters.Interfaces

## Contents

- [IMainWindowPresenter](#T-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter')
  - [IsProfileLoaded](#P-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-IsProfileLoaded 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.IsProfileLoaded')
  - [AddProfile(name)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-AddProfile-System-String- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.AddProfile(System.String)')
  - [AndHistoryManager(historyManager)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-AndHistoryManager-MFR-Managers-History-Interfaces-IHistoryManager- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.AndHistoryManager(MFR.Managers.History.Interfaces.IHistoryManager)')
  - [ClearAllHistory()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ClearAllHistory 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ClearAllHistory')
  - [DoSelectedOperations()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-DoSelectedOperations 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.DoSelectedOperations')
  - [ExportConfiguration()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ExportConfiguration 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ExportConfiguration')
  - [FillProfileDropDownList()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-FillProfileDropDownList 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.FillProfileDropDownList')
  - [ImportConfiguration()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ImportConfiguration 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ImportConfiguration')
  - [InitializeOperationSelections()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-InitializeOperationSelections 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.InitializeOperationSelections')
  - [ProfileAlreadyExist(profileName)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ProfileAlreadyExist-System-String- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ProfileAlreadyExist(System.String)')
  - [SaveConfiguration()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-SaveConfiguration 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.SaveConfiguration')
  - [SaveConfigurationDataFrom(dialog)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-SaveConfigurationDataFrom-MFR-GUI-Dialogs-Interfaces-IOptionsDialog- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.SaveConfigurationDataFrom(MFR.GUI.Dialogs.Interfaces.IOptionsDialog)')
  - [SaveCurrentConfigurationAsProfile(profileName)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-SaveCurrentConfigurationAsProfile-System-String- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.SaveCurrentConfigurationAsProfile(System.String)')
  - [ShowCalculatingProgressBar(text,canCancel)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ShowCalculatingProgressBar-System-String,System-Boolean- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ShowCalculatingProgressBar(System.String,System.Boolean)')
  - [ShowProgressDialog(canCancel)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ShowProgressDialog-System-Boolean- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ShowProgressDialog(System.Boolean)')
  - [ShowProgressDialog(owner)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ShowProgressDialog-System-Windows-Forms-IWin32Window- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ShowProgressDialog(System.Windows.Forms.IWin32Window)')
  - [ShowProgressDialog(owner,canCancel)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ShowProgressDialog-System-Windows-Forms-IWin32Window,System-Boolean- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ShowProgressDialog(System.Windows.Forms.IWin32Window,System.Boolean)')
  - [WithFileRenamer(fileRenamer)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-WithFileRenamer-MFR-Renamers-Files-Interfaces-IFileRenamer- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.WithFileRenamer(MFR.Renamers.Files.Interfaces.IFileRenamer)')
- [Resources](#T-MFR-GUI-Windows-Presenters-Interfaces-Properties-Resources 'MFR.GUI.Windows.Presenters.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-GUI-Windows-Presenters-Interfaces-Properties-Resources-Culture 'MFR.GUI.Windows.Presenters.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Windows-Presenters-Interfaces-Properties-Resources-ResourceManager 'MFR.GUI.Windows.Presenters.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter'></a>
## IMainWindowPresenter `type`

##### Namespace

MFR.GUI.Windows.Presenters.Interfaces

##### Summary

Defines the public-exposed methods and properties of the presenter
object for the main application window..

<a name='P-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-IsProfileLoaded'></a>
### IsProfileLoaded `property`

##### Summary

Gets a value that indicates whether a Profile is currently loaded.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-AddProfile-System-String-'></a>
### AddProfile(name) `method`

##### Summary

Creates a 'profile' (really a way of saving a group of configuration
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

Clears all the history lists in the configuration.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-DoSelectedOperations'></a>
### DoSelectedOperations() `method`

##### Summary

Executes the operations selected by the user.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ExportConfiguration'></a>
### ExportConfiguration() `method`

##### Summary

Exports the current configuration data to a file on the user's hard drive.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-FillProfileDropDownList'></a>
### FillProfileDropDownList() `method`

##### Summary

This method is called to populate the Profiles combo box.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ImportConfiguration'></a>
### ImportConfiguration() `method`

##### Summary

Imports the configuration data for this application.

##### Parameters

This method has no parameters.

##### Remarks

The data is presumed to be located inside of a JSON-formatted file
that exists on the user's hard drive and has the `.json` extension.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-InitializeOperationSelections'></a>
### InitializeOperationSelections() `method`

##### Summary

Sets the state of the Operations to Perform checked list box items
based on configuration settings.

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

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-SaveConfiguration'></a>
### SaveConfiguration() `method`

##### Summary

Saves data from the screen control and then saves the configuration to the persistence location.

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

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-SaveCurrentConfigurationAsProfile-System-String-'></a>
### SaveCurrentConfigurationAsProfile(profileName) `method`

##### Summary

Transforms the current value of the
[Configuration](#P-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-Configuration 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.Configuration')
property into a Profile with the `profileName` specified.



If a Profile with the same name is already defined, then this method does
nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| profileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name to give the
new Profile. |

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ShowCalculatingProgressBar-System-String,System-Boolean-'></a>
### ShowCalculatingProgressBar(text,canCancel) `method`

##### Summary

Shows a marquee progress bar that indicates the application is
performing work but of an indeterminate length, such as calculating
the amount of files to process.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to display in the progress dialog. |
| canCancel | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) `true` to show a button in
the progress dialog; `false` to hide it. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `text`, is passed
a blank or `null` string for a value. |

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ShowProgressDialog-System-Boolean-'></a>
### ShowProgressDialog(canCancel) `method`

##### Summary

Shows the progress window.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| canCancel | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that controls whether the
button is displayed by the dialog box.



Set this parameter to `true` to display the button;
`false` to hide it. |

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ShowProgressDialog-System-Windows-Forms-IWin32Window-'></a>
### ShowProgressDialog(owner) `method`

##### Summary

Shows the progress window.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.



This object plays the role of the parent window of the dialog box. |

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ShowProgressDialog-System-Windows-Forms-IWin32Window,System-Boolean-'></a>
### ShowProgressDialog(owner,canCancel) `method`

##### Summary

Shows the progress window.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.



This object plays the role of the parent window of the dialog box. |
| canCancel | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that controls whether the
button is displayed by the dialog box.



Set this parameter to `true` to display the button;
`false` to hide it. |

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-WithFileRenamer-MFR-Renamers-Files-Interfaces-IFileRenamer-'></a>
### WithFileRenamer(fileRenamer) `method`

##### Summary

Fluent-builder method for composing a file-renamer object with this
presenter.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileRenamer | [MFR.Renamers.Files.Interfaces.IFileRenamer](#T-MFR-Renamers-Files-Interfaces-IFileRenamer 'MFR.Renamers.Files.Interfaces.IFileRenamer') | (Required.) Reference to an instance of an object that implements
the [IFileRenamer](#T-MFR-IFileRenamer 'MFR.IFileRenamer') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `fileRenamer`, is
passed a `null` value. |

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
