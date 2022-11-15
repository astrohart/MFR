<a name='assembly'></a>
# MFR.GUI.Windows

## Contents

- [Is](#T-MFR-GUI-Windows-MainWindow-Is 'MFR.GUI.Windows.MainWindow.Is')
  - [SolutionFIle(pathname)](#M-MFR-GUI-Windows-MainWindow-Is-SolutionFIle-System-String- 'MFR.GUI.Windows.MainWindow.Is.SolutionFIle(System.String)')
- [MainWindow](#T-MFR-GUI-Windows-MainWindow 'MFR.GUI.Windows.MainWindow')
  - [#ctor()](#M-MFR-GUI-Windows-MainWindow-#ctor 'MFR.GUI.Windows.MainWindow.#ctor')
  - [components](#F-MFR-GUI-Windows-MainWindow-components 'MFR.GUI.Windows.MainWindow.components')
  - [Configuration](#P-MFR-GUI-Windows-MainWindow-Configuration 'MFR.GUI.Windows.MainWindow.Configuration')
  - [ConfigurationProvider](#P-MFR-GUI-Windows-MainWindow-ConfigurationProvider 'MFR.GUI.Windows.MainWindow.ConfigurationProvider')
  - [FindWhatComboBox](#P-MFR-GUI-Windows-MainWindow-FindWhatComboBox 'MFR.GUI.Windows.MainWindow.FindWhatComboBox')
  - [FoldButton](#P-MFR-GUI-Windows-MainWindow-FoldButton 'MFR.GUI.Windows.MainWindow.FoldButton')
  - [FullApplicationName](#P-MFR-GUI-Windows-MainWindow-FullApplicationName 'MFR.GUI.Windows.MainWindow.FullApplicationName')
  - [Instance](#P-MFR-GUI-Windows-MainWindow-Instance 'MFR.GUI.Windows.MainWindow.Instance')
  - [IsDataValid](#P-MFR-GUI-Windows-MainWindow-IsDataValid 'MFR.GUI.Windows.MainWindow.IsDataValid')
  - [IsFolded](#P-MFR-GUI-Windows-MainWindow-IsFolded 'MFR.GUI.Windows.MainWindow.IsFolded')
  - [IsHistoryClear](#P-MFR-GUI-Windows-MainWindow-IsHistoryClear 'MFR.GUI.Windows.MainWindow.IsHistoryClear')
  - [MatchCase](#P-MFR-GUI-Windows-MainWindow-MatchCase 'MFR.GUI.Windows.MainWindow.MatchCase')
  - [MatchExactWord](#P-MFR-GUI-Windows-MainWindow-MatchExactWord 'MFR.GUI.Windows.MainWindow.MatchExactWord')
  - [OperationsCheckedListBox](#P-MFR-GUI-Windows-MainWindow-OperationsCheckedListBox 'MFR.GUI.Windows.MainWindow.OperationsCheckedListBox')
  - [Presenter](#P-MFR-GUI-Windows-MainWindow-Presenter 'MFR.GUI.Windows.MainWindow.Presenter')
  - [ProfileCollectionComboBox](#P-MFR-GUI-Windows-MainWindow-ProfileCollectionComboBox 'MFR.GUI.Windows.MainWindow.ProfileCollectionComboBox')
  - [ReplaceWithComboBox](#P-MFR-GUI-Windows-MainWindow-ReplaceWithComboBox 'MFR.GUI.Windows.MainWindow.ReplaceWithComboBox')
  - [RootDirectoryValidator](#P-MFR-GUI-Windows-MainWindow-RootDirectoryValidator 'MFR.GUI.Windows.MainWindow.RootDirectoryValidator')
  - [SelectAll](#P-MFR-GUI-Windows-MainWindow-SelectAll 'MFR.GUI.Windows.MainWindow.SelectAll')
  - [SelectedOptionTab](#P-MFR-GUI-Windows-MainWindow-SelectedOptionTab 'MFR.GUI.Windows.MainWindow.SelectedOptionTab')
  - [StartingFolderComboBox](#P-MFR-GUI-Windows-MainWindow-StartingFolderComboBox 'MFR.GUI.Windows.MainWindow.StartingFolderComboBox')
  - [Version](#P-MFR-GUI-Windows-MainWindow-Version 'MFR.GUI.Windows.MainWindow.Version')
  - [#cctor()](#M-MFR-GUI-Windows-MainWindow-#cctor 'MFR.GUI.Windows.MainWindow.#cctor')
  - [Dispose(disposing)](#M-MFR-GUI-Windows-MainWindow-Dispose-System-Boolean- 'MFR.GUI.Windows.MainWindow.Dispose(System.Boolean)')
  - [DoesDirectoryContainSolutionFile(path)](#M-MFR-GUI-Windows-MainWindow-DoesDirectoryContainSolutionFile-System-String- 'MFR.GUI.Windows.MainWindow.DoesDirectoryContainSolutionFile(System.String)')
  - [InitializeComponent()](#M-MFR-GUI-Windows-MainWindow-InitializeComponent 'MFR.GUI.Windows.MainWindow.InitializeComponent')
  - [InitializePresenter()](#M-MFR-GUI-Windows-MainWindow-InitializePresenter 'MFR.GUI.Windows.MainWindow.InitializePresenter')
  - [OnCheckedChangedSelectDeselectAllCheckBox(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnCheckedChangedSelectDeselectAllCheckBox-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnCheckedChangedSelectDeselectAllCheckBox(System.Object,System.EventArgs)')
  - [OnClickBrowseForStartingFolder(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnClickBrowseForStartingFolder-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnClickBrowseForStartingFolder(System.Object,System.EventArgs)')
  - [OnClickPerformOperation(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnClickPerformOperation-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnClickPerformOperation(System.Object,System.EventArgs)')
  - [OnClickSwitchButton(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnClickSwitchButton-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnClickSwitchButton(System.Object,System.EventArgs)')
  - [OnFileExit(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnFileExit-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnFileExit(System.Object,System.EventArgs)')
  - [OnFormClosing(e)](#M-MFR-GUI-Windows-MainWindow-OnFormClosing-System-Windows-Forms-FormClosingEventArgs- 'MFR.GUI.Windows.MainWindow.OnFormClosing(System.Windows.Forms.FormClosingEventArgs)')
  - [OnFormFolded(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnFormFolded-System-Object,MFR-GUI-Controls-Events-FormFoldedEventArgs- 'MFR.GUI.Windows.MainWindow.OnFormFolded(System.Object,MFR.GUI.Controls.Events.FormFoldedEventArgs)')
  - [OnHelpAbout(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnHelpAbout-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnHelpAbout(System.Object,System.EventArgs)')
  - [OnHelpMenuDropDownOpening(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnHelpMenuDropDownOpening-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnHelpMenuDropDownOpening(System.Object,System.EventArgs)')
  - [OnLoad(e)](#M-MFR-GUI-Windows-MainWindow-OnLoad-System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnLoad(System.EventArgs)')
  - [OnOperationsPerform(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnOperationsPerform-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnOperationsPerform(System.Object,System.EventArgs)')
  - [OnOptionsModified(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnOptionsModified-System-Object,MFR-GUI-Dialogs-Events-ModifiedEventArgs- 'MFR.GUI.Windows.MainWindow.OnOptionsModified(System.Object,MFR.GUI.Dialogs.Events.ModifiedEventArgs)')
  - [OnPresenterAddNewProfileFailed(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterAddNewProfileFailed-System-Object,MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterAddNewProfileFailed(System.Object,MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs)')
  - [OnPresenterAllHistoryCleared(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterAllHistoryCleared-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterAllHistoryCleared(System.Object,System.EventArgs)')
  - [OnPresenterConfigurationExported(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterConfigurationExported-System-Object,MFR-Settings-Configuration-Events-ConfigurationExportedEventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterConfigurationExported(System.Object,MFR.Settings.Configuration.Events.ConfigurationExportedEventArgs)')
  - [OnPresenterConfigurationImported(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterConfigurationImported-System-Object,MFR-Settings-Configuration-Events-ConfigurationImportedEventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterConfigurationImported(System.Object,MFR.Settings.Configuration.Events.ConfigurationImportedEventArgs)')
  - [OnPresenterDataOperationFinished(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterDataOperationFinished-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterDataOperationFinished(System.Object,System.EventArgs)')
  - [OnPresenterDataOperationStarted(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterDataOperationStarted-System-Object,MFR-Operations-Events-DataOperationEventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterDataOperationStarted(System.Object,MFR.Operations.Events.DataOperationEventArgs)')
  - [OnPresenterFinished(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterFinished-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterFinished(System.Object,System.EventArgs)')
  - [OnPresenterStarted(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterStarted-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterStarted(System.Object,System.EventArgs)')
  - [OnRootDirectoryInvalid(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnRootDirectoryInvalid-System-Object,MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs- 'MFR.GUI.Windows.MainWindow.OnRootDirectoryInvalid(System.Object,MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs)')
  - [OnSelChangeComboBox(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnSelChangeComboBox-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnSelChangeComboBox(System.Object,System.EventArgs)')
  - [OnToolsConfigImport(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnToolsConfigImport-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnToolsConfigImport(System.Object,System.EventArgs)')
  - [OnToolsConfigurationNewProfile(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnToolsConfigurationNewProfile-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnToolsConfigurationNewProfile(System.Object,System.EventArgs)')
  - [OnToolsExportConfig(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnToolsExportConfig-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnToolsExportConfig(System.Object,System.EventArgs)')
  - [OnToolsHistoryClearAll(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnToolsHistoryClearAll-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnToolsHistoryClearAll(System.Object,System.EventArgs)')
  - [OnToolsOptions(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnToolsOptions-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnToolsOptions(System.Object,System.EventArgs)')
  - [OnUpdateCmdUI(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnUpdateCmdUI-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnUpdateCmdUI(System.Object,System.EventArgs)')
  - [OnViewStatusBar(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnViewStatusBar-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnViewStatusBar(System.Object,System.EventArgs)')
  - [OnViewToolBar(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnViewToolBar-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnViewToolBar(System.Object,System.EventArgs)')
  - [ResetProfileCollectionComboBox()](#M-MFR-GUI-Windows-MainWindow-ResetProfileCollectionComboBox 'MFR.GUI.Windows.MainWindow.ResetProfileCollectionComboBox')
  - [UpdateSize(newSize)](#M-MFR-GUI-Windows-MainWindow-UpdateSize-System-Drawing-Size- 'MFR.GUI.Windows.MainWindow.UpdateSize(System.Drawing.Size)')
  - [ValidateData()](#M-MFR-GUI-Windows-MainWindow-ValidateData 'MFR.GUI.Windows.MainWindow.ValidateData')
- [Resources](#T-MFR-GUI-Windows-Properties-Resources 'MFR.GUI.Windows.Properties.Resources')
  - [AppIdle](#P-MFR-GUI-Windows-Properties-Resources-AppIdle 'MFR.GUI.Windows.Properties.Resources.AppIdle')
  - [Culture](#P-MFR-GUI-Windows-Properties-Resources-Culture 'MFR.GUI.Windows.Properties.Resources.Culture')
  - [Error_StartingFolderMustContainSolutionFile](#P-MFR-GUI-Windows-Properties-Resources-Error_StartingFolderMustContainSolutionFile 'MFR.GUI.Windows.Properties.Resources.Error_StartingFolderMustContainSolutionFile')
  - [ResourceManager](#P-MFR-GUI-Windows-Properties-Resources-ResourceManager 'MFR.GUI.Windows.Properties.Resources.ResourceManager')
  - [SwitchUpDown_16x](#P-MFR-GUI-Windows-Properties-Resources-SwitchUpDown_16x 'MFR.GUI.Windows.Properties.Resources.SwitchUpDown_16x')
- [TestBedForm](#T-MFR-GUI-Windows-TestBedForm 'MFR.GUI.Windows.TestBedForm')
  - [#ctor()](#M-MFR-GUI-Windows-TestBedForm-#ctor 'MFR.GUI.Windows.TestBedForm.#ctor')
  - [components](#F-MFR-GUI-Windows-TestBedForm-components 'MFR.GUI.Windows.TestBedForm.components')
  - [Instance](#P-MFR-GUI-Windows-TestBedForm-Instance 'MFR.GUI.Windows.TestBedForm.Instance')
  - [#cctor()](#M-MFR-GUI-Windows-TestBedForm-#cctor 'MFR.GUI.Windows.TestBedForm.#cctor')
  - [Dispose(disposing)](#M-MFR-GUI-Windows-TestBedForm-Dispose-System-Boolean- 'MFR.GUI.Windows.TestBedForm.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Windows-TestBedForm-InitializeComponent 'MFR.GUI.Windows.TestBedForm.InitializeComponent')
  - [OnLoad(e)](#M-MFR-GUI-Windows-TestBedForm-OnLoad-System-EventArgs- 'MFR.GUI.Windows.TestBedForm.OnLoad(System.EventArgs)')

<a name='T-MFR-GUI-Windows-MainWindow-Is'></a>
## Is `type`

##### Namespace

MFR.GUI.Windows.MainWindow

##### Summary

Exposes static methods to make determinations about data and the state of the
system..

<a name='M-MFR-GUI-Windows-MainWindow-Is-SolutionFIle-System-String-'></a>
### SolutionFIle(pathname) `method`

##### Summary

Determines whether the file having the specified `pathname`
is a Visual Studio Solution (*.sln) file.

##### Returns

`true` if the file having the specified
`pathname` is a Visual Studio Solution (*.sln) file;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file that is to be examined in order to determine whether it is a
Visual Studio Solution (*.sln) file. |

##### Remarks

This method also returns `false` if the
`pathname` that is passed is blank, `null`,
or refers to a file that does actually exist on the disk.

<a name='T-MFR-GUI-Windows-MainWindow'></a>
## MainWindow `type`

##### Namespace

MFR.GUI.Windows

##### Summary

Displays the main window of the application.

<a name='M-MFR-GUI-Windows-MainWindow-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[MainWindow](#T-MFR-GUI-Windows-MainWindow 'MFR.GUI.Windows.MainWindow')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Windows-MainWindow-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Windows-MainWindow-Configuration'></a>
### Configuration `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') interface
that represents the currently-loaded configuration.

<a name='P-MFR-GUI-Windows-MainWindow-ConfigurationProvider'></a>
### ConfigurationProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IConfigurationProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider')
interface.

##### Remarks

This object allows access to the user configuration and the actions
associated with it.

<a name='P-MFR-GUI-Windows-MainWindow-FindWhatComboBox'></a>
### FindWhatComboBox `property`

##### Summary

Gets a reference to the text box control that allows the user to
specify the text to be found.

<a name='P-MFR-GUI-Windows-MainWindow-FoldButton'></a>
### FoldButton `property`

##### Summary

Gets a reference to the
[FoldUnfoldButton](#T-MFR-GUI-Controls-FoldUnfoldButton 'MFR.GUI.Controls.FoldUnfoldButton')
that controls whether
the form is the folded (smaller) size or unfolded (larger, with more
options visible) size.

<a name='P-MFR-GUI-Windows-MainWindow-FullApplicationName'></a>
### FullApplicationName `property`

##### Summary

Gets the full name of this application, including the current version.

<a name='P-MFR-GUI-Windows-MainWindow-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only
[MainWindow](#T-MFR-GUI-Windows-MainWindow 'MFR.GUI.Windows.MainWindow') object in this application.

<a name='P-MFR-GUI-Windows-MainWindow-IsDataValid'></a>
### IsDataValid `property`

##### Summary

Gets a value indicating whether the data entered on this form is valid.

<a name='P-MFR-GUI-Windows-MainWindow-IsFolded'></a>
### IsFolded `property`

##### Summary

Gets or sets a value specifying whether the form is in the Folded state.

<a name='P-MFR-GUI-Windows-MainWindow-IsHistoryClear'></a>
### IsHistoryClear `property`

##### Summary

Gets a value that indicates whether the history is free of all
previous entries.

<a name='P-MFR-GUI-Windows-MainWindow-MatchCase'></a>
### MatchCase `property`

##### Summary

Gets or sets the value of the Match Case checkbox.

<a name='P-MFR-GUI-Windows-MainWindow-MatchExactWord'></a>
### MatchExactWord `property`

##### Summary

Gets or sets the value of the Match Exact Word checkbox.

<a name='P-MFR-GUI-Windows-MainWindow-OperationsCheckedListBox'></a>
### OperationsCheckedListBox `property`

##### Summary

Gets a reference to the
[CheckedListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckedListBox 'System.Windows.Forms.CheckedListBox')
that has the list of operations.

<a name='P-MFR-GUI-Windows-MainWindow-Presenter'></a>
### Presenter `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IMainWindowPresenter](#T-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter')
interface.

##### Remarks

This object plays the role of the Presenter for this form, which determines the
behavior of this form.

<a name='P-MFR-GUI-Windows-MainWindow-ProfileCollectionComboBox'></a>
### ProfileCollectionComboBox `property`

##### Summary

Gets a reference to a [ToolStripComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripComboBox 'System.Windows.Forms.ToolStripComboBox')
that has a drop-down list of the profiles that the user has created.

<a name='P-MFR-GUI-Windows-MainWindow-ReplaceWithComboBox'></a>
### ReplaceWithComboBox `property`

##### Summary

Gets a reference to the text box control that allows the user to
specify the text to replace found text with.

<a name='P-MFR-GUI-Windows-MainWindow-RootDirectoryValidator'></a>
### RootDirectoryValidator `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IRootDirectoryValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryValidator')
interface.

<a name='P-MFR-GUI-Windows-MainWindow-SelectAll'></a>
### SelectAll `property`

##### Summary

Gets or sets the value of the Select/Deselect All checkbox

<a name='P-MFR-GUI-Windows-MainWindow-SelectedOptionTab'></a>
### SelectedOptionTab `property`

##### Summary

Gets or sets the index of the tab that is selected in the Options
tab control.

<a name='P-MFR-GUI-Windows-MainWindow-StartingFolderComboBox'></a>
### StartingFolderComboBox `property`

##### Summary

Gets a reference to the control that allows the user to specify the
path to the starting folder.

<a name='P-MFR-GUI-Windows-MainWindow-Version'></a>
### Version `property`

##### Summary

Gets a string containing this application's version.

##### Remarks

Thanks to

's answer on the Microsoft forums.

<a name='M-MFR-GUI-Windows-MainWindow-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-MainWindow-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Windows-MainWindow-DoesDirectoryContainSolutionFile-System-String-'></a>
### DoesDirectoryContainSolutionFile(path) `method`

##### Summary

Determines whether the folder having the specified `path`
contains a Visual Studio Solution (*.sln) file.



NEW: Also searches subfolders.

##### Returns

`true` if the folder with the specified
`path` exists and contains at least one file with the
`.sln` file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the path of the folder to
check. |

<a name='M-MFR-GUI-Windows-MainWindow-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-MainWindow-InitializePresenter'></a>
### InitializePresenter() `method`

##### Summary

Sets up the presenter object and attaches handlers to events that it exposes.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-MainWindow-OnCheckedChangedSelectDeselectAllCheckBox-System-Object,System-EventArgs-'></a>
### OnCheckedChangedSelectDeselectAllCheckBox(sender,e) `method`

##### Summary

Handles the
[](#E-System-Windows-Forms-CheckBox-CheckedChanged 'System.Windows.Forms.CheckBox.CheckedChanged')
event for
the Select/Deselect All check box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to the event by toggling the Checked states of
all the boxes in the Operations To Perform checked list box.

<a name='M-MFR-GUI-Windows-MainWindow-OnClickBrowseForStartingFolder-System-Object,System-EventArgs-'></a>
### OnClickBrowseForStartingFolder(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event
for the Browse ("...") button.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

When the user clicks the "..." button, we want to show them a dialog
    box to select a folder.

The contents of the Starting Folder text box will then be
    initialized to hold the pathname to the folder that the user selects.

<a name='M-MFR-GUI-Windows-MainWindow-OnClickPerformOperation-System-Object,System-EventArgs-'></a>
### OnClickPerformOperation(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event
for the Perform Operation button.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The sender of this event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This handler starts the processing of renaming folders and files
when the Perform Operation button is clicked.

<a name='M-MFR-GUI-Windows-MainWindow-OnClickSwitchButton-System-Object,System-EventArgs-'></a>
### OnClickSwitchButton(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event
raised by the Switch button.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds by switching the contents of the Find What and
Replace With combo boxes.

<a name='M-MFR-GUI-Windows-MainWindow-OnFileExit-System-Object,System-EventArgs-'></a>
### OnFileExit(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event for the File -> Exit menu command.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called to handle the message of the user clicking the
Exit command on the File menu. This method saves the configuration
and then closes this window. Since this window is the main window of
the application, closing this window ends the lifecycle of the application.

<a name='M-MFR-GUI-Windows-MainWindow-OnFormClosing-System-Windows-Forms-FormClosingEventArgs-'></a>
### OnFormClosing(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-FormClosing 'System.Windows.Forms.Form.FormClosing') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Windows.Forms.FormClosingEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosingEventArgs 'System.Windows.Forms.FormClosingEventArgs') | A [FormClosingEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosingEventArgs 'System.Windows.Forms.FormClosingEventArgs') that
contains the event data. |

<a name='M-MFR-GUI-Windows-MainWindow-OnFormFolded-System-Object,MFR-GUI-Controls-Events-FormFoldedEventArgs-'></a>
### OnFormFolded(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-GUI-Controls-FoldUnfoldButton-FormFolded 'MFR.GUI.Controls.FoldUnfoldButton.FormFolded')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.GUI.Controls.Events.FormFoldedEventArgs](#T-MFR-GUI-Controls-Events-FormFoldedEventArgs 'MFR.GUI.Controls.Events.FormFoldedEventArgs') | A [FormFoldedEventArgs](#T-MFR-FormFoldedEventArgs 'MFR.FormFoldedEventArgs') that contains the
event data. |

##### Remarks



<a name='M-MFR-GUI-Windows-MainWindow-OnHelpAbout-System-Object,System-EventArgs-'></a>
### OnHelpAbout(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event raised by the user clicking on the About command on the
HelpProfileExplainerDialog menu.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to the event by displaying the About dialog box.

<a name='M-MFR-GUI-Windows-MainWindow-OnHelpMenuDropDownOpening-System-Object,System-EventArgs-'></a>
### OnHelpMenuDropDownOpening(sender,e) `method`

##### Summary

Handles the
[](#E-System-Windows-Forms-ToolStripDropDownItem-DropDownOpening 'System.Windows.Forms.ToolStripDropDownItem.DropDownOpening')
event raised by the message of the user clicking on the
HelpProfileExplainerDialog menu to
open it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to the event by ensuring that the text of the
HelpProfileExplainerDialog menu's About command contains the full name of this
application.

<a name='M-MFR-GUI-Windows-MainWindow-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

<a name='M-MFR-GUI-Windows-MainWindow-OnOperationsPerform-System-Object,System-EventArgs-'></a>
### OnOperationsPerform(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event on the Operations -> Perform menu command.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called in order to respond when the user clicks the
Perform command on the Operations menu. The handling of this event
is delegated to the Perform Operation button.

<a name='M-MFR-GUI-Windows-MainWindow-OnOptionsModified-System-Object,MFR-GUI-Dialogs-Events-ModifiedEventArgs-'></a>
### OnOptionsModified(sender,e) `method`

##### Summary

Handles the [](#E-MFR-GUI-OptionsDialog-Modified 'MFR.GUI.OptionsDialog.Modified') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.GUI.Dialogs.Events.ModifiedEventArgs](#T-MFR-GUI-Dialogs-Events-ModifiedEventArgs 'MFR.GUI.Dialogs.Events.ModifiedEventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to the Apply button being clicked in the
property sheet displayed by the Tools -> Options menu command.

<a name='M-MFR-GUI-Windows-MainWindow-OnPresenterAddNewProfileFailed-System-Object,MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs-'></a>
### OnPresenterAddNewProfileFailed(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-GUI-Windows-Presenters-Interfaces-IMainWindowPresenter-AddProfileFailed 'MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.AddProfileFailed')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs](#T-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs 'MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs') | A [AddProfileFailedEventArgs](#T-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs 'MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs')
that contains the event data. |

##### Remarks

This handler is called when the operation of creating a new profile fails.



This method responds by showing the user an error message box explaining what
happened.

<a name='M-MFR-GUI-Windows-MainWindow-OnPresenterAllHistoryCleared-System-Object,System-EventArgs-'></a>
### OnPresenterAllHistoryCleared(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-GUI-IMainWindowPresenter-AllHistoryCleared 'MFR.GUI.IMainWindowPresenter.AllHistoryCleared')
event
raised by the presenter object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to the event by clearing out all the text in
the combo boxes on this form.

<a name='M-MFR-GUI-Windows-MainWindow-OnPresenterConfigurationExported-System-Object,MFR-Settings-Configuration-Events-ConfigurationExportedEventArgs-'></a>
### OnPresenterConfigurationExported(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-GUI-IMainWindowPresenter-ConfigurationExported 'MFR.GUI.IMainWindowPresenter.ConfigurationExported')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Settings.Configuration.Events.ConfigurationExportedEventArgs](#T-MFR-Settings-Configuration-Events-ConfigurationExportedEventArgs 'MFR.Settings.Configuration.Events.ConfigurationExportedEventArgs') | An [ConfigurationExportedEventArgs](#T-MFR-Settings-ConfigurationExportedEventArgs 'MFR.Settings.ConfigurationExportedEventArgs') that
contains the event data. |

##### Remarks

This method is called when an export of the configuration has been
successfully completed. This method responds to the event by
informing the user that the operation has completed successfully.

<a name='M-MFR-GUI-Windows-MainWindow-OnPresenterConfigurationImported-System-Object,MFR-Settings-Configuration-Events-ConfigurationImportedEventArgs-'></a>
### OnPresenterConfigurationImported(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-GUI-IMainWindowPresenter-ConfigurationImported 'MFR.GUI.IMainWindowPresenter.ConfigurationImported')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Settings.Configuration.Events.ConfigurationImportedEventArgs](#T-MFR-Settings-Configuration-Events-ConfigurationImportedEventArgs 'MFR.Settings.Configuration.Events.ConfigurationImportedEventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to the event by triggering an update of the
screen from values stored in the configuration object in the
[Configuration](#P-MFR-GUI-MainWindowPresenter-Configuration 'MFR.GUI.MainWindowPresenter.Configuration')
property. This
happens most often as a the result of the Import Configuration
command on the Tools menu.

<a name='M-MFR-GUI-Windows-MainWindow-OnPresenterDataOperationFinished-System-Object,System-EventArgs-'></a>
### OnPresenterDataOperationFinished(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-GUI-IMainWindowPresenter-DataOperationFinished 'MFR.GUI.IMainWindowPresenter.DataOperationFinished')
event
raised by the presenter object when a data operation is finished.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to the event by removing the progress bar from
the status bar and setting the text of its message label back to the
idle text. We use the Invoke If Required methodology just in case
it's not the GUI thread that raised the event.



If the status bar is not presently visible, then this method does nothing.

<a name='M-MFR-GUI-Windows-MainWindow-OnPresenterDataOperationStarted-System-Object,MFR-Operations-Events-DataOperationEventArgs-'></a>
### OnPresenterDataOperationStarted(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-GUI-IMainWindowPresenter-DataOperationStarted 'MFR.GUI.IMainWindowPresenter.DataOperationStarted')
event
raised by the presenter object when it's about to start an operation
that involves interaction with a data source.



Depending on the data source, this operation can be fast or it can
be slow, so the presenter object informs us in case we want to
update the user interface in order to tell the user what is going on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Operations.Events.DataOperationEventArgs](#T-MFR-Operations-Events-DataOperationEventArgs 'MFR.Operations.Events.DataOperationEventArgs') | A [DataOperationEventArgs](#T-MFR-DataOperationEventArgs 'MFR.DataOperationEventArgs') that contains
the event data. |

##### Remarks

This method responds to the event by displaying the marquee progress
control in the status bar and updating the status bar's Message
indicator to display the text that is passed in the
[Message](#P-MFR-DataOperationEventArgs-Message 'MFR.DataOperationEventArgs.Message')
property.



If the status bar is not presently visible, then this method does nothing.

<a name='M-MFR-GUI-Windows-MainWindow-OnPresenterFinished-System-Object,System-EventArgs-'></a>
### OnPresenterFinished(sender,e) `method`

##### Summary

Handles the [](#E-MFR-GUI-IMainWindowPresenter-Finished 'MFR.GUI.IMainWindowPresenter.Finished') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method toggles UI state and dismisses the progress dialog.

<a name='M-MFR-GUI-Windows-MainWindow-OnPresenterStarted-System-Object,System-EventArgs-'></a>
### OnPresenterStarted(sender,e) `method`

##### Summary

Handles the [](#E-MFR-GUI-IMainWindowPresenter-Started 'MFR.GUI.IMainWindowPresenter.Started') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This handler is called when the
[ProcessAll](#M-MFR-FileRenamer-ProcessAll 'MFR.FileRenamer.ProcessAll')
begins its execution.
This method responds by showing the progress dialog.

<a name='M-MFR-GUI-Windows-MainWindow-OnRootDirectoryInvalid-System-Object,MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-'></a>
### OnRootDirectoryInvalid(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-CommandLine-Validators-Interfaces-IRootDirectoryValidator-RootDirectoryInvalid 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator.RootDirectoryInvalid')
event raised by the `Root Directory Validator` component.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs](#T-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs') | A
[RootDirectoryInvalidEventArgs](#T-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs')
that contains the event
data. |

##### Remarks

This method responds by displaying a message to the user about why the
validation failed, and then instructing the validator to stop the validation
process.

<a name='M-MFR-GUI-Windows-MainWindow-OnSelChangeComboBox-System-Object,System-EventArgs-'></a>
### OnSelChangeComboBox(sender,e) `method`

##### Summary

Handles the
[](#E-System-Windows-Forms-ComboBox-SelectedIndexChanged 'System.Windows.Forms.ComboBox.SelectedIndexChanged')
event
raised by the Starting Folder, Find What, and Replace With combo boxes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds by moving the input focus to a hidden label.
This is to get rid of that annoying highlight that remains in a
combo box when it loses the input focus.

<a name='M-MFR-GUI-Windows-MainWindow-OnToolsConfigImport-System-Object,System-EventArgs-'></a>
### OnToolsConfigImport(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event for the Tools -> Import and Export Configuration ->
Import Configuration menu command.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called when the user chooses the Import Configuration
menu command from the Import and Export Configuration submenu of the
Tools menu. This method responds to the event by showing the user a
dialog that the user can utilize to select the file they want to
import, and then calls the presenter to perform the import operation.

<a name='M-MFR-GUI-Windows-MainWindow-OnToolsConfigurationNewProfile-System-Object,System-EventArgs-'></a>
### OnToolsConfigurationNewProfile(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click') event
raised by the New Profile toolbar button and/or Tools -> Configuration -> New
Profile menu command.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method is called when the user click the New Profile toolbar
button or menu item.



The goal is to prompt the user for the name of their new profile, create it,
then add it to the list of profiles and then set it as the current profile.

<a name='M-MFR-GUI-Windows-MainWindow-OnToolsExportConfig-System-Object,System-EventArgs-'></a>
### OnToolsExportConfig(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event for the Tools -> Import and Export Configuration ->
Export Configuration menu command.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called when the user chooses the Export Configuration
menu command from the Import and Export Configuration submenu of the
Tools menu. This method responds to the event by showing the user a
dialog that the user can utilize to select the pathname of the file
that the user wants the configuration data to be exported to.

<a name='M-MFR-GUI-Windows-MainWindow-OnToolsHistoryClearAll-System-Object,System-EventArgs-'></a>
### OnToolsHistoryClearAll(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event raised by the user clicking the Tools menu, pointing to
History, and then choosing the Clear All command.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to the event by clearing the contents of all
history lists in the configuration, saving it to the configuration
data source, and then reloading the screen from the configuration.

<a name='M-MFR-GUI-Windows-MainWindow-OnToolsOptions-System-Object,System-EventArgs-'></a>
### OnToolsOptions(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event for the Tools -> Options menu command.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called when the user chooses the Options command on
the Tools menu. This method responds by showing the user an Options
dialog that the user can then utilize in order to configure this
application's behavior.

<a name='M-MFR-GUI-Windows-MainWindow-OnUpdateCmdUI-System-Object,System-EventArgs-'></a>
### OnUpdateCmdUI(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Application-Idle 'System.Windows.Forms.Application.Idle') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to the event by updating the enabled/disabled
state of controls and menu items, unless the
[Enabled](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.Control.Enabled 'System.Windows.Forms.Control.Enabled')
property is
`false`
, which means an operation is in progress.

<a name='M-MFR-GUI-Windows-MainWindow-OnViewStatusBar-System-Object,System-EventArgs-'></a>
### OnViewStatusBar(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called when the user clicks the Status Bar command on
the View menu. This method responds by toggling the value of the
Visible property of the status bar.

<a name='M-MFR-GUI-Windows-MainWindow-OnViewToolBar-System-Object,System-EventArgs-'></a>
### OnViewToolBar(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event for the View -> Toolbar command..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called when the user clicks the Toolbar command on
the View menu. This method responds by toggling the value of the
Visible property of the Standard toolbar.

<a name='M-MFR-GUI-Windows-MainWindow-ResetProfileCollectionComboBox'></a>
### ResetProfileCollectionComboBox() `method`

##### Summary

Clears all the items from the Profile List combo box and then adds the
`
            <No profile selected>
            `
item and then selects the first element in the
[Items](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripComboBox.Items 'System.Windows.Forms.ToolStripComboBox.Items') list.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-MainWindow-UpdateSize-System-Drawing-Size-'></a>
### UpdateSize(newSize) `method`

##### Summary

Resizes the form to that specified in the `newSize`
parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newSize | [System.Drawing.Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') | A [Size](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Size 'System.Drawing.Size') that specifies the new size to use. |

<a name='M-MFR-GUI-Windows-MainWindow-ValidateData'></a>
### ValidateData() `method`

##### Summary

Ensures the fields on the form have valid values, and prompts the
user if otherwise is the case.

##### Returns

Returns `true` if all the fields have valid data;
`false` otherwise.

##### Parameters

This method has no parameters.

##### Remarks

Use the return value of this method from the calling method to
decide whether to proceed with the operation. A return value of
`false`
means an operation should not proceed. If a value
is invalid, a message box is displayed to the user telling the user
what the user needs to fix. Then, the input focus is set to the
offending field.

<a name='T-MFR-GUI-Windows-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Windows.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Windows-Properties-Resources-AppIdle'></a>
### AppIdle `property`

##### Summary

Looks up a localized string similar to Ready.

<a name='P-MFR-GUI-Windows-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Windows-Properties-Resources-Error_StartingFolderMustContainSolutionFile'></a>
### Error_StartingFolderMustContainSolutionFile `property`

##### Summary

Looks up a localized string similar to Please select a directory that contains a Visual Studio Solution (*.sln) file for the What Folder Should the Operation Start In field.

Do you want to proceed regardless?  CAUTION: Unpredictable things may happen.  Don't say we did not warn you..

<a name='P-MFR-GUI-Windows-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-MFR-GUI-Windows-Properties-Resources-SwitchUpDown_16x'></a>
### SwitchUpDown_16x `property`

##### Summary

Looks up a localized resource of type System.Drawing.Bitmap.

<a name='T-MFR-GUI-Windows-TestBedForm'></a>
## TestBedForm `type`

##### Namespace

MFR.GUI.Windows

##### Summary

Form for putting controls on as a test bed.

<a name='M-MFR-GUI-Windows-TestBedForm-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Windows-TestBedForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Windows-TestBedForm-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[TestBedForm](#T-MFR-GUI-Windows-TestBedForm 'MFR.GUI.Windows.TestBedForm').

<a name='M-MFR-GUI-Windows-TestBedForm-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-TestBedForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Windows-TestBedForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-TestBedForm-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |
