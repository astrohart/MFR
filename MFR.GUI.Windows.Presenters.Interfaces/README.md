<a name='assembly'></a>
# MFR.GUI.Windows.Presenters.Interfaces

## Contents

- [IMainWindowPresenter](#T-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter')
  - [AndHistoryManager(historyManager)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-AndHistoryManager-MFR-Objects-Managers-History-Interfaces-IHistoryManager- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.AndHistoryManager(MFR.Managers.History.Interfaces.IHistoryManager)')
  - [ClearAllHistory()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ClearAllHistory 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ClearAllHistory')
  - [ExportConfiguration()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ExportConfiguration 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ExportConfiguration')
  - [ImportConfiguration()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ImportConfiguration 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.ImportConfiguration')
  - [InitializeOperationSelections()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-InitializeOperationSelections 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.InitializeOperationSelections')
  - [Process()](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-Process 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.Process')
  - [SaveConfigurationDataFrom(dialog)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-SaveConfigurationDataFrom-MFR-GUI-Dialogs-Interfaces-IOptionsDialog- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.SaveConfigurationDataFrom(MFR.GUI.Dialogs.Interfaces.IOptionsDialog)')
  - [WithFileRenamer(fileRenamer)](#M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-WithFileRenamer-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer- 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.WithFileRenamer(MFR.Renamers.Files.Interfaces.IFileRenamer)')
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

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-AndHistoryManager-MFR-Objects-Managers-History-Interfaces-IHistoryManager-'></a>
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
| historyManager | [MFR.Managers.History.Interfaces.IHistoryManager](#T-MFR-Objects-Managers-History-Interfaces-IHistoryManager 'MFR.Managers.History.Interfaces.IHistoryManager') | Reference to an instance of an object that implements the
[IHistoryManager](#T-MFR-Objects-IHistoryManager 'MFR.IHistoryManager')
on which this Presenter
should depend. |

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ClearAllHistory'></a>
### ClearAllHistory() `method`

##### Summary

Clears all the history lists in the configuration.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-ExportConfiguration'></a>
### ExportConfiguration() `method`

##### Summary

Exports the current configuration data to a file on the user's hard drive.

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

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-Process'></a>
### Process() `method`

##### Summary

Begins the rename operation.

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

<a name='M-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-WithFileRenamer-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-'></a>
### WithFileRenamer(fileRenamer) `method`

##### Summary

Fluent-builder method for composing a file-renamer object with this presenter.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileRenamer | [MFR.Renamers.Files.Interfaces.IFileRenamer](#T-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer 'MFR.Renamers.Files.Interfaces.IFileRenamer') | (Required.) Reference to an instance of an object that implements
the [IFileRenamer](#T-MFR-Objects-IFileRenamer 'MFR.IFileRenamer') interface. |

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
