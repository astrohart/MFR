<a name='assembly'></a>
# MFR.GUI.Windows.Presenters

## Contents

- [MainWindowPresenter](#T-MFR-GUI-Windows-Presenters-MainWindowPresenter 'MFR.GUI.Windows.Presenters.MainWindowPresenter')
  - [#ctor()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-#ctor 'MFR.GUI.Windows.Presenters.MainWindowPresenter.#ctor')
  - [_historyManager](#F-MFR-GUI-Windows-Presenters-MainWindowPresenter-_historyManager 'MFR.GUI.Windows.Presenters.MainWindowPresenter._historyManager')
  - [ConfigFilePath](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-ConfigFilePath 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ConfigFilePath')
  - [ConfigurationProvider](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-ConfigurationProvider 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ConfigurationProvider')
  - [CurrentConfiguration](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-CurrentConfiguration 'MFR.GUI.Windows.Presenters.MainWindowPresenter.CurrentConfiguration')
  - [CurrentProfileName](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-CurrentProfileName 'MFR.GUI.Windows.Presenters.MainWindowPresenter.CurrentProfileName')
  - [Does](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-Does 'MFR.GUI.Windows.Presenters.MainWindowPresenter.Does')
  - [FileRenamer](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-FileRenamer 'MFR.GUI.Windows.Presenters.MainWindowPresenter.FileRenamer')
  - [FindWhat](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-FindWhat 'MFR.GUI.Windows.Presenters.MainWindowPresenter.FindWhat')
  - [FindWhatComboBox](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-FindWhatComboBox 'MFR.GUI.Windows.Presenters.MainWindowPresenter.FindWhatComboBox')
  - [IsProfileLoaded](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-IsProfileLoaded 'MFR.GUI.Windows.Presenters.MainWindowPresenter.IsProfileLoaded')
  - [OperationEngine](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-OperationEngine 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OperationEngine')
  - [ProfileProvider](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-ProfileProvider 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ProfileProvider')
  - [ReplaceWith](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-ReplaceWith 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ReplaceWith')
  - [ReplaceWithComboBox](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-ReplaceWithComboBox 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ReplaceWithComboBox')
  - [StartingFolder](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-StartingFolder 'MFR.GUI.Windows.Presenters.MainWindowPresenter.StartingFolder')
  - [StartingFolderComboBox](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-StartingFolderComboBox 'MFR.GUI.Windows.Presenters.MainWindowPresenter.StartingFolderComboBox')
  - [View](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-View 'MFR.GUI.Windows.Presenters.MainWindowPresenter.View')
  - [AddProfile(name)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-AddProfile-System-String- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.AddProfile(System.String)')
  - [AndHistoryManager(historyManager)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-AndHistoryManager-MFR-Managers-History-Interfaces-IHistoryManager- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.AndHistoryManager(MFR.Managers.History.Interfaces.IHistoryManager)')
  - [ClearAllHistory()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ClearAllHistory 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ClearAllHistory')
  - [DoSelectedOperations()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-DoSelectedOperations 'MFR.GUI.Windows.Presenters.MainWindowPresenter.DoSelectedOperations')
  - [ExportConfiguration(pathname)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ExportConfiguration-System-String- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ExportConfiguration(System.String)')
  - [FileExist(pathname)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-FileExist-System-String- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.FileExist(System.String)')
  - [FillProfileDropDownList()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-FillProfileDropDownList 'MFR.GUI.Windows.Presenters.MainWindowPresenter.FillProfileDropDownList')
  - [HavingWindowReference(view)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-HavingWindowReference-MFR-GUI-Windows-Interfaces-IMainWindow- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.HavingWindowReference(MFR.GUI.Windows.Interfaces.IMainWindow)')
  - [ImportConfiguration()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ImportConfiguration-System-String- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ImportConfiguration(System.String)')
  - [InitializeConfiguration()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-InitializeConfiguration 'MFR.GUI.Windows.Presenters.MainWindowPresenter.InitializeConfiguration')
  - [InitializeOperationSelections()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-InitializeOperationSelections 'MFR.GUI.Windows.Presenters.MainWindowPresenter.InitializeOperationSelections')
  - [OnAddProfileFailed(e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnAddProfileFailed-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnAddProfileFailed(MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs)')
  - [OnAllHistoryCleared()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnAllHistoryCleared 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnAllHistoryCleared')
  - [OnCancellableProgressDialogRequestedCancel(sender,e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnCancellableProgressDialogRequestedCancel-System-Object,System-EventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnCancellableProgressDialogRequestedCancel(System.Object,System.EventArgs)')
  - [OnConfigurationExported(e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnConfigurationExported-MFR-Settings-Configuration-Events-ConfigurationExportedEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnConfigurationExported(MFR.Settings.Configuration.Events.ConfigurationExportedEventArgs)')
  - [OnConfigurationImported(e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnConfigurationImported-MFR-Settings-Configuration-Events-ConfigurationImportedEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnConfigurationImported(MFR.Settings.Configuration.Events.ConfigurationImportedEventArgs)')
  - [OnCreateNewBlankProfileRequested(e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnCreateNewBlankProfileRequested-MFR-GUI-Windows-Presenters-Events-CreateNewBlankProfileRequestedEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnCreateNewBlankProfileRequested(MFR.GUI.Windows.Presenters.Events.CreateNewBlankProfileRequestedEventArgs)')
  - [OnDataOperationError(e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnDataOperationError-MFR-Operations-Events-DataOperationErrorEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnDataOperationError(MFR.Operations.Events.DataOperationErrorEventArgs)')
  - [OnDataOperationFinished()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnDataOperationFinished 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnDataOperationFinished')
  - [OnDataOperationStarted(e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnDataOperationStarted-MFR-Operations-Events-DataOperationEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnDataOperationStarted(MFR.Operations.Events.DataOperationEventArgs)')
  - [OnFinished()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFinished 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnFinished')
  - [OnOperationError(e)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnOperationError-MFR-Events-Common-ExceptionRaisedEventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnOperationError(MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnProcessingFinished()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnProcessingFinished-System-Object,System-EventArgs- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OnProcessingFinished(System.Object,System.EventArgs)')
  - [ProfileAlreadyExist(profileName)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ProfileAlreadyExist-System-String- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ProfileAlreadyExist(System.String)')
  - [RenameConfigFileToMatchNewName(newConfigFilePath)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-RenameConfigFileToMatchNewName-System-String- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.RenameConfigFileToMatchNewName(System.String)')
  - [SaveConfiguration()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-SaveConfiguration 'MFR.GUI.Windows.Presenters.MainWindowPresenter.SaveConfiguration')
  - [SaveConfigurationDataFrom(dialog)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-SaveConfigurationDataFrom-MFR-GUI-Dialogs-Interfaces-IOptionsDialog- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.SaveConfigurationDataFrom(MFR.GUI.Dialogs.Interfaces.IOptionsDialog)')
  - [SaveCurrentConfigurationAsProfile(profileName)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-SaveCurrentConfigurationAsProfile-System-String- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.SaveCurrentConfigurationAsProfile(System.String)')
  - [SaveOperationSelections()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-SaveOperationSelections 'MFR.GUI.Windows.Presenters.MainWindowPresenter.SaveOperationSelections')
  - [UpdateConfiguration(configuration)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.UpdateConfiguration(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration)')
  - [UpdateData(bSavingAndValidating)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-UpdateData-System-Boolean- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.UpdateData(System.Boolean)')
  - [ValidateInputs()](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ValidateInputs 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ValidateInputs')
  - [WindowReference(mainWindow)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-WindowReference-MFR-GUI-Windows-Interfaces-IMainWindow- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.WindowReference(MFR.GUI.Windows.Interfaces.IMainWindow)')
  - [WithOperationEngine(operationEngine)](#M-MFR-GUI-Windows-Presenters-MainWindowPresenter-WithOperationEngine-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine- 'MFR.GUI.Windows.Presenters.MainWindowPresenter.WithOperationEngine(MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine)')
- [Resources](#T-MFR-GUI-Windows-Presenters-Properties-Resources 'MFR.GUI.Windows.Presenters.Properties.Resources')
  - [Culture](#P-MFR-GUI-Windows-Presenters-Properties-Resources-Culture 'MFR.GUI.Windows.Presenters.Properties.Resources.Culture')
  - [Error_FindWhatRequired](#P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_FindWhatRequired 'MFR.GUI.Windows.Presenters.Properties.Resources.Error_FindWhatRequired')
  - [Error_ProfileWithNameAlreadyExists](#P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_ProfileWithNameAlreadyExists 'MFR.GUI.Windows.Presenters.Properties.Resources.Error_ProfileWithNameAlreadyExists')
  - [Error_ReplaceWithBlank](#P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_ReplaceWithBlank 'MFR.GUI.Windows.Presenters.Properties.Resources.Error_ReplaceWithBlank')
  - [Error_RootDirectoryNotFound](#P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_RootDirectoryNotFound 'MFR.GUI.Windows.Presenters.Properties.Resources.Error_RootDirectoryNotFound')
  - [Error_ValueCannotBeNullOrWhiteSpace](#P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace 'MFR.GUI.Windows.Presenters.Properties.Resources.Error_ValueCannotBeNullOrWhiteSpace')
  - [ResourceManager](#P-MFR-GUI-Windows-Presenters-Properties-Resources-ResourceManager 'MFR.GUI.Windows.Presenters.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Windows-Presenters-MainWindowPresenter'></a>
## MainWindowPresenter `type`

##### Namespace

MFR.GUI.Windows.Presenters

##### Summary

Presenter for the main application window.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[MainWindowPresenter](#T-MFR-GUI-MainWindowPresenter 'MFR.GUI.MainWindowPresenter')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Windows-Presenters-MainWindowPresenter-_historyManager'></a>
### _historyManager `constants`

##### Summary

Reference to an instance of an object that implements the
[IHistoryManager](#T-MFR-IHistoryManager 'MFR.IHistoryManager')
interface.

##### Remarks

This object's sole purpose in life is to provide the service of
maintaining the history lists in the configuration data
source.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-ConfigFilePath'></a>
### ConfigFilePath `property`

##### Summary

Gets or sets the pathname of the configuration file.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-ConfigurationProvider'></a>
### ConfigurationProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider')
interface.

##### Remarks

This object allows access to the user configuration and the
actions
associated with it.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-CurrentProfileName'></a>
### CurrentProfileName `property`

##### Summary

Gets the name of the currently-selected profile.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-Does'></a>
### Does `property`

##### Summary

Gets a reference to this object instance.

##### Remarks

This property is here to maintain method call semantics.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-FileRenamer'></a>
### FileRenamer `property`

##### Summary

Reference to an instance of an object that implements the
[IFileRenamer](#T-MFR-IFileRenamer 'MFR.IFileRenamer')
interface.

##### Remarks

THis object provides the core services that this application offers.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets the text to be searched for during the operations.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-FindWhatComboBox'></a>
### FindWhatComboBox `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') interface
that plays the role of the Find What combo box.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-IsProfileLoaded'></a>
### IsProfileLoaded `property`

##### Summary

Gets a value that indicates whether a Profile is currently loaded.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-OperationEngine'></a>
### OperationEngine `property`

##### Summary

Reference to an instance of an object that implements the
[IFullGuiOperationEngine](#T-MFR-Engines-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Interfaces.IFullGuiOperationEngine') interface and
which actually performs the behavior of this Presenter.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-ProfileProvider'></a>
### ProfileProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProfileProvider](#T-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider')
interface.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets the replacement text to be used during the operations.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-ReplaceWithComboBox'></a>
### ReplaceWithComboBox `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') interface
that plays the role of the Replace With combo box on the main user interface.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-StartingFolder'></a>
### StartingFolder `property`

##### Summary

Gets the path to the starting folder of the search.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-StartingFolderComboBox'></a>
### StartingFolderComboBox `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') interface
that plays the role of the Starting Folder combo box on the main user
interface.

<a name='P-MFR-GUI-Windows-Presenters-MainWindowPresenter-View'></a>
### View `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IMainWindow](#T-MFR-GUI-IMainWindow 'MFR.GUI.IMainWindow')
interface.

##### Remarks

This object provides the functionality of the main window of the application.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-AddProfile-System-String-'></a>
### AddProfile(name) `method`

##### Summary

Creates a 'profile' (really a way of saving a group of
configuration
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

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-AndHistoryManager-MFR-Managers-History-Interfaces-IHistoryManager-'></a>
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

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ClearAllHistory'></a>
### ClearAllHistory() `method`

##### Summary

Clears all the history lists in the configuration.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-DoSelectedOperations'></a>
### DoSelectedOperations() `method`

##### Summary

Begins the rename operation.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ExportConfiguration-System-String-'></a>
### ExportConfiguration(pathname) `method`

##### Summary

Exports the current configuration data to a file on the
user's hard drive.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file to which the configuration should be exported. |

##### Remarks

If a file having the specified `pathname` already
exists on the disk at the time the export operation is performed, it will be
overwritten.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-FileExist-System-String-'></a>
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

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-FillProfileDropDownList'></a>
### FillProfileDropDownList() `method`

##### Summary

This method is called to populate the Profiles combo box.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-HavingWindowReference-MFR-GUI-Windows-Interfaces-IMainWindow-'></a>
### HavingWindowReference(view) `method`

##### Summary

Fluent-builder method to set a reference to the main window of the application.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| view | [MFR.GUI.Windows.Interfaces.IMainWindow](#T-MFR-GUI-Windows-Interfaces-IMainWindow 'MFR.GUI.Windows.Interfaces.IMainWindow') | (Required.) Reference to an instance of an object that implements
the [IMainWindow](#T-MFR-GUI-Windows-Interfaces-IMainWindow 'MFR.GUI.Windows.Interfaces.IMainWindow')
interface, and which represents the form that is to be associated
with this presenter. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `view`, is passed
a `null` value. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ImportConfiguration-System-String-'></a>
### ImportConfiguration() `method`

##### Summary

Imports the configuration data for this application.

##### Parameters

This method has no parameters.

##### Remarks

The data is presumed to be located inside of a JSON-formatted file
that exists on the user's hard drive and has the `.json` extension.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-InitializeConfiguration'></a>
### InitializeConfiguration() `method`

##### Summary

Initializes the currently-loaded configuration object.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-InitializeOperationSelections'></a>
### InitializeOperationSelections() `method`

##### Summary

Sets the state of the Operations to Perform checked list box items
based on configuration settings.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnAddProfileFailed-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs-'></a>
### OnAddProfileFailed(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-Windows-Presenters-MainWindowPresenter-AddProfileFailed 'MFR.GUI.Windows.Presenters.MainWindowPresenter.AddProfileFailed')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs](#T-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs 'MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs') | (Required.) Reference to an instance of
[AddProfileFailedEventArgs](#T-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs 'MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs')
that contains the event data. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnAllHistoryCleared'></a>
### OnAllHistoryCleared() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Windows-Presenters-MainWindowPresenter-AllHistoryCleared 'MFR.GUI.Windows.Presenters.MainWindowPresenter.AllHistoryCleared')
event.

##### Parameters

This method has no parameters.

##### Remarks

The objective of calling this method is to inform interested parties
that the operation of clearing all the history is complete.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnCancellableProgressDialogRequestedCancel-System-Object,System-EventArgs-'></a>
### OnCancellableProgressDialogRequestedCancel(sender,e) `method`

##### Summary

Handles the [](#E-MFR-GUI-ICancellableProgressDialog-CancelRequested 'MFR.GUI.ICancellableProgressDialog.CancelRequested')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method handles the situation in which the user has clicked the
Cancel button on the progress dialog. The message taken by this
method is to tell the File Renamer Object to attempt to abort.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnConfigurationExported-MFR-Settings-Configuration-Events-ConfigurationExportedEventArgs-'></a>
### OnConfigurationExported(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-MainWindowPresenter-ConfigurationExported 'MFR.GUI.MainWindowPresenter.ConfigurationExported')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Settings.Configuration.Events.ConfigurationExportedEventArgs](#T-MFR-Settings-Configuration-Events-ConfigurationExportedEventArgs 'MFR.Settings.Configuration.Events.ConfigurationExportedEventArgs') | A [ConfigurationExportedEventArgs](#T-MFR-Settings-ConfigurationExportedEventArgs 'MFR.Settings.ConfigurationExportedEventArgs') that
contains the event data. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnConfigurationImported-MFR-Settings-Configuration-Events-ConfigurationImportedEventArgs-'></a>
### OnConfigurationImported(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-MainWindowPresenter-ConfigurationImported 'MFR.GUI.MainWindowPresenter.ConfigurationImported')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Settings.Configuration.Events.ConfigurationImportedEventArgs](#T-MFR-Settings-Configuration-Events-ConfigurationImportedEventArgs 'MFR.Settings.Configuration.Events.ConfigurationImportedEventArgs') | A [ConfigurationImportedEventArgs](#T-MFR-Settings-ConfigurationImportedEventArgs 'MFR.Settings.ConfigurationImportedEventArgs') that
contains the event data. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnCreateNewBlankProfileRequested-MFR-GUI-Windows-Presenters-Events-CreateNewBlankProfileRequestedEventArgs-'></a>
### OnCreateNewBlankProfileRequested(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-Windows-Presenters-MainWindowPresenter-CreateNewBlankProfileRequested 'MFR.GUI.Windows.Presenters.MainWindowPresenter.CreateNewBlankProfileRequested')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.GUI.Windows.Presenters.Events.CreateNewBlankProfileRequestedEventArgs](#T-MFR-GUI-Windows-Presenters-Events-CreateNewBlankProfileRequestedEventArgs 'MFR.GUI.Windows.Presenters.Events.CreateNewBlankProfileRequestedEventArgs') | A
[CreateNewBlankProfileRequestedEventArgs](#T-MFR-GUI-Windows-Presenters-Events-CreateNewBlankProfileRequestedEventArgs 'MFR.GUI.Windows.Presenters.Events.CreateNewBlankProfileRequestedEventArgs')
that contains the event data. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnDataOperationError-MFR-Operations-Events-DataOperationErrorEventArgs-'></a>
### OnDataOperationError(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-MainWindowPresenter-DataOperationError 'MFR.GUI.MainWindowPresenter.DataOperationError')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Operations.Events.DataOperationErrorEventArgs](#T-MFR-Operations-Events-DataOperationErrorEventArgs 'MFR.Operations.Events.DataOperationErrorEventArgs') | A [DataOperationErrorEventArgs](#T-MFR-DataOperationErrorEventArgs 'MFR.DataOperationErrorEventArgs') that
contains the event data. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnDataOperationFinished'></a>
### OnDataOperationFinished() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Windows-Presenters-MainWindowPresenter-DataOperationFinished 'MFR.GUI.Windows.Presenters.MainWindowPresenter.DataOperationFinished')
event.

##### Parameters

This method has no parameters.

##### Remarks

Ideally, it should be the main application window that handles this
event by simply displaying a marquee progress bar on the status bar
of the application window but otherwise maintaining the ability of
the user to use the GUI. This is because moving data to and from the
configuration data source, while a mildly lengthy operation,
is
nowhere near as involved as the file operations we would normally undertake.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnDataOperationStarted-MFR-Operations-Events-DataOperationEventArgs-'></a>
### OnDataOperationStarted(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-MainWindowPresenter-DataOperationStarted 'MFR.GUI.MainWindowPresenter.DataOperationStarted')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Operations.Events.DataOperationEventArgs](#T-MFR-Operations-Events-DataOperationEventArgs 'MFR.Operations.Events.DataOperationEventArgs') | (Required.) A [DataOperationEventArgs](#T-MFR-DataOperationEventArgs 'MFR.DataOperationEventArgs')
that contains the event data. |

##### Remarks

Ideally, it should be the main application window that handles this
event by simply displaying a marquee progress bar on the status bar
of the application window but otherwise maintaining the ability of
the user to use the GUI. This is because moving data to and from the
configuration data source, while a mildly lengthy operation,
is
nowhere near as involved as the file operations we would normally undertake.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnFinished'></a>
### OnFinished() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Windows-Presenters-MainWindowPresenter-Finished 'MFR.GUI.Windows.Presenters.MainWindowPresenter.Finished')
event.

##### Parameters

This method has no parameters.

##### Remarks

This event lets client objects know that the presenter is about to
finish an operation. Typically, the client object is the main
application window, which should respond by dismissing any progress
dialog that may have been previously shown during the operation and
re-enabling user input.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnOperationError-MFR-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnOperationError(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-Windows-Presenters-MainWindowPresenter-OperationError 'MFR.GUI.Windows.Presenters.MainWindowPresenter.OperationError')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.Common.ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs') | A [ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs')
that contains the event data. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-OnProcessingFinished-System-Object,System-EventArgs-'></a>
### OnProcessingFinished() `method`

##### Summary

This method is called when the Operation Engine sends the
`OE_PROCESSING_FINISHED` message.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ProfileAlreadyExist-System-String-'></a>
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

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-RenameConfigFileToMatchNewName-System-String-'></a>
### RenameConfigFileToMatchNewName(newConfigFilePath) `method`

##### Summary

If the user has changed the pathname of where the configuration file is to be
stored, this method renames the existing configuration file to match.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newConfigFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the new value of the
fully-qualified pathname of the configuration file. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-SaveConfiguration'></a>
### SaveConfiguration() `method`

##### Summary

Saves data from the screen control and then saves the
configuration to the
persistence location.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-SaveConfigurationDataFrom-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-'></a>
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

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-SaveCurrentConfigurationAsProfile-System-String-'></a>
### SaveCurrentConfigurationAsProfile(profileName) `method`

##### Summary

Transforms the current value of the
[ProjectFileRenamerConfiguration](#P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-ProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.ProjectFileRenamerConfiguration')
property into a Profile with the `profileName` specified.



If a Profile with the same name is already defined, then this method does
nothing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| profileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name to give the
new Profile. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-SaveOperationSelections'></a>
### SaveOperationSelections() `method`

##### Summary

Saves the selections made in the Operations to Perform checked list
box into the
[ProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-ProjectFileRenamerConfiguration 'MFR.Settings.Configuration.ProjectFileRenamerConfiguration')
object.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-UpdateConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-'></a>
### UpdateConfiguration(configuration) `method`

##### Summary

Updates the configuration currently being used with a new
value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface which has
the new settings. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter,
`configuration`,
is passed a `null` value. |

##### Remarks

The settings in the object specified will be used for all matching
from this point forward.



NOTE:This member may be overriden by a child class. If this is the
case, the overrider must call the base class method before doing any
of its own processing.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-UpdateData-System-Boolean-'></a>
### UpdateData(bSavingAndValidating) `method`

##### Summary

Updates data. Moves data from the screen to the model (
`bSavingAndValidating`
equals `true`) or from
the model to the screen ( `bSavingAndValidating`
equals `false`).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bSavingAndValidating | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set to `true` to move data from the screen to the
model; `false` to move data from the model to the screen. |

##### Remarks

Note that whatever operations this method performs may potentially
throw exceptions.

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-ValidateInputs'></a>
### ValidateInputs() `method`

##### Summary

Runs rules to ensure that the entries on the main window's form are
valid. Throws a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') if a validation
rule fails.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the directory whose pathname is referenced by
[StartingFolder](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-StartingFolder 'MFR.GUI.Windows.Presenters.MainWindowPresenter.StartingFolder')
is not found on the disk. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if either of the
[FindWhat](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-FindWhat 'MFR.GUI.Windows.Presenters.MainWindowPresenter.FindWhat')
or
[ReplaceWith](#P-MFR-GUI-Windows-Presenters-MainWindowPresenter-ReplaceWith 'MFR.GUI.Windows.Presenters.MainWindowPresenter.ReplaceWith')
properties are blank. |

##### Remarks

This method should be called in a try/catch handler. Upon catching
an exception, instead of logging the error, the application should
also respond by displaying a Stop message box to the user with the
value of the [Message](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception.Message 'System.Exception.Message') property of
the caught exception as its text, and then set the focus to the
offending field (if feasible).

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-WindowReference-MFR-GUI-Windows-Interfaces-IMainWindow-'></a>
### WindowReference(mainWindow) `method`

##### Summary

Fluent-builder method to set a reference to the main window of the application.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mainWindow | [MFR.GUI.Windows.Interfaces.IMainWindow](#T-MFR-GUI-Windows-Interfaces-IMainWindow 'MFR.GUI.Windows.Interfaces.IMainWindow') | (Required.) Reference to an instance of an object that implements
the [IMainWindow](#T-MFR-GUI-IMainWindow 'MFR.GUI.IMainWindow') interface and which
represents the main window of the application. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `mainWindow`, is
passed a `null` value. |

<a name='M-MFR-GUI-Windows-Presenters-MainWindowPresenter-WithOperationEngine-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-'></a>
### WithOperationEngine(operationEngine) `method`

##### Summary

Fluent-builder method for initializing the operation engine object.  This is
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

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `operationEngine`, is passed a
`null` value. |

<a name='T-MFR-GUI-Windows-Presenters-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Windows.Presenters.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Windows-Presenters-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_FindWhatRequired'></a>
### Error_FindWhatRequired `property`

##### Summary

Looks up a localized string similar to The text to be found cannot be blank.

Type the text you want replaced, and then try again..

<a name='P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_ProfileWithNameAlreadyExists'></a>
### Error_ProfileWithNameAlreadyExists `property`

##### Summary

Looks up a localized string similar to A profile with the name '{0}' already exists.

You can't use the same name, even with different upper- and lower-case letters, as an existing profile..

<a name='P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_ReplaceWithBlank'></a>
### Error_ReplaceWithBlank `property`

##### Summary

Looks up a localized string similar to The text to use as replacement text cannot be blank.

Type a value for this text, and then try again..

<a name='P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_RootDirectoryNotFound'></a>
### Error_RootDirectoryNotFound `property`

##### Summary

Looks up a localized string similar to Could not locate the folder '{0}' on the disk.

Please specify a folder path of click the '...' button to browse for one..

<a name='P-MFR-GUI-Windows-Presenters-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace'></a>
### Error_ValueCannotBeNullOrWhiteSpace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or whitespace..

<a name='P-MFR-GUI-Windows-Presenters-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
