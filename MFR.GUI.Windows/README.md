<a name='assembly'></a>
# MFR.GUI.Windows

## Contents

- [MainWindow](#T-MFR-GUI-Windows-MainWindow 'MFR.GUI.Windows.MainWindow')
  - [#ctor()](#M-MFR-GUI-Windows-MainWindow-#ctor 'MFR.GUI.Windows.MainWindow.#ctor')
  - [_presenter](#F-MFR-GUI-Windows-MainWindow-_presenter 'MFR.GUI.Windows.MainWindow._presenter')
  - [components](#F-MFR-GUI-Windows-MainWindow-components 'MFR.GUI.Windows.MainWindow.components')
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
  - [ReplaceWithComboBox](#P-MFR-GUI-Windows-MainWindow-ReplaceWithComboBox 'MFR.GUI.Windows.MainWindow.ReplaceWithComboBox')
  - [SelectAll](#P-MFR-GUI-Windows-MainWindow-SelectAll 'MFR.GUI.Windows.MainWindow.SelectAll')
  - [SelectedOptionTab](#P-MFR-GUI-Windows-MainWindow-SelectedOptionTab 'MFR.GUI.Windows.MainWindow.SelectedOptionTab')
  - [StartingFolderComboBox](#P-MFR-GUI-Windows-MainWindow-StartingFolderComboBox 'MFR.GUI.Windows.MainWindow.StartingFolderComboBox')
  - [Version](#P-MFR-GUI-Windows-MainWindow-Version 'MFR.GUI.Windows.MainWindow.Version')
  - [#cctor()](#M-MFR-GUI-Windows-MainWindow-#cctor 'MFR.GUI.Windows.MainWindow.#cctor')
  - [Dispose(disposing)](#M-MFR-GUI-Windows-MainWindow-Dispose-System-Boolean- 'MFR.GUI.Windows.MainWindow.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Windows-MainWindow-InitializeComponent 'MFR.GUI.Windows.MainWindow.InitializeComponent')
  - [InitializePresenter(configurationPathname)](#M-MFR-GUI-Windows-MainWindow-InitializePresenter 'MFR.GUI.Windows.MainWindow.InitializePresenter')
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
  - [OnPresenterAllHistoryCleared(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterAllHistoryCleared-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterAllHistoryCleared(System.Object,System.EventArgs)')
  - [OnPresenterConfigurationExported(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterConfigurationExported-System-Object,MFR-Objects-Configuration-Events-ConfigurationExportedEventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterConfigurationExported(System.Object,MFR.Objects.Configuration.Events.ConfigurationExportedEventArgs)')
  - [OnPresenterConfigurationImported(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterConfigurationImported-System-Object,MFR-Objects-Configuration-Events-ConfigurationImportedEventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterConfigurationImported(System.Object,MFR.Objects.Configuration.Events.ConfigurationImportedEventArgs)')
  - [OnPresenterDataOperationStarted(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterDataOperationStarted-System-Object,MFR-Objects-Operations-Events-DataOperationEventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterDataOperationStarted(System.Object,MFR.Objects.Operations.Events.DataOperationEventArgs)')
  - [OnPresenterFinished(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterFinished-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterFinished(System.Object,System.EventArgs)')
  - [OnPresenterStarted(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterStarted-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterStarted(System.Object,System.EventArgs)')
  - [OnSelChangeComboBox(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnSelChangeComboBox-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnSelChangeComboBox(System.Object,System.EventArgs)')
  - [OnToolsConfigImport(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnToolsConfigImport-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnToolsConfigImport(System.Object,System.EventArgs)')
  - [OnToolsExportConfig(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnToolsExportConfig-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnToolsExportConfig(System.Object,System.EventArgs)')
  - [OnToolsHistoryClearAll(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnToolsHistoryClearAll-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnToolsHistoryClearAll(System.Object,System.EventArgs)')
  - [OnToolsOptions(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnToolsOptions-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnToolsOptions(System.Object,System.EventArgs)')
  - [OnUpdateCmdUI(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnUpdateCmdUI-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnUpdateCmdUI(System.Object,System.EventArgs)')
  - [OnViewStatusBar(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnViewStatusBar-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnViewStatusBar(System.Object,System.EventArgs)')
  - [OnViewToolBar(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnViewToolBar-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnViewToolBar(System.Object,System.EventArgs)')
  - [UpdateSize(newSize)](#M-MFR-GUI-Windows-MainWindow-UpdateSize-System-Drawing-Size- 'MFR.GUI.Windows.MainWindow.UpdateSize(System.Drawing.Size)')
  - [ValidateData()](#M-MFR-GUI-Windows-MainWindow-ValidateData 'MFR.GUI.Windows.MainWindow.ValidateData')
- [Resources](#T-MFR-GUI-Windows-Properties-Resources 'MFR.GUI.Windows.Properties.Resources')
  - [AppIdle](#P-MFR-GUI-Windows-Properties-Resources-AppIdle 'MFR.GUI.Windows.Properties.Resources.AppIdle')
  - [Culture](#P-MFR-GUI-Windows-Properties-Resources-Culture 'MFR.GUI.Windows.Properties.Resources.Culture')
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

<a name='F-MFR-GUI-Windows-MainWindow-_presenter'></a>
### _presenter `constants`

##### Summary

Reference to the presenter for this form.

<a name='F-MFR-GUI-Windows-MainWindow-components'></a>
### components `constants`

##### Summary

Required designer variable.

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
that controls
whether the form is the folded (smaller) size or unfolded (larger,
with more options visible) size.

<a name='P-MFR-GUI-Windows-MainWindow-FullApplicationName'></a>
### FullApplicationName `property`

##### Summary

Gets the full name of this application, including the current version.

<a name='P-MFR-GUI-Windows-MainWindow-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MainWindow](#T-MFR-GUI-Windows-MainWindow 'MFR.GUI.Windows.MainWindow').

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

<a name='P-MFR-GUI-Windows-MainWindow-ReplaceWithComboBox'></a>
### ReplaceWithComboBox `property`

##### Summary

Gets a reference to the text box control that allows the user to
specify the text to replace found text with.

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

<a name='M-MFR-GUI-Windows-MainWindow-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-MainWindow-InitializePresenter'></a>
### InitializePresenter(configurationPathname) `method`

##### Summary

Sets up the presenter object and attaches handlers to events that it exposes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configurationPathname | [M:MFR.GUI.Windows.MainWindow.InitializePresenter](#T-M-MFR-GUI-Windows-MainWindow-InitializePresenter 'M:MFR.GUI.Windows.MainWindow.InitializePresenter') | (Required.) String containing the pathname of the configuration file. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the `configurationPathname` parameter is blank. |

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
| e | [MFR.GUI.Controls.Events.FormFoldedEventArgs](#T-MFR-GUI-Controls-Events-FormFoldedEventArgs 'MFR.GUI.Controls.Events.FormFoldedEventArgs') | A [FormFoldedEventArgs](#T-MFR-Objects-FormFoldedEventArgs 'MFR.Objects.FormFoldedEventArgs') that
contains the event data. |

##### Remarks



<a name='M-MFR-GUI-Windows-MainWindow-OnHelpAbout-System-Object,System-EventArgs-'></a>
### OnHelpAbout(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event raised by the user clicking on the About command on the Help menu.

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
event raised by the message of the user clicking on the Help menu to
open it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to the event by ensuring that the text of the
Help menu's About command contains the full name of this application.

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

Handles the
[](#E-MFR-GUI-OptionsDialog-Modified 'MFR.GUI.OptionsDialog.Modified')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.GUI.Dialogs.Events.ModifiedEventArgs](#T-MFR-GUI-Dialogs-Events-ModifiedEventArgs 'MFR.GUI.Dialogs.Events.ModifiedEventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to the Apply button being clicked in the
property sheet displayed by the Tools -> Options menu command.

<a name='M-MFR-GUI-Windows-MainWindow-OnPresenterAllHistoryCleared-System-Object,System-EventArgs-'></a>
### OnPresenterAllHistoryCleared(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-GUI-IMainWindowPresenter-AllHistoryCleared 'MFR.GUI.IMainWindowPresenter.AllHistoryCleared')
event raised by the presenter object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to the event by clearing out all the text in
the combo boxes on this form.

<a name='M-MFR-GUI-Windows-MainWindow-OnPresenterConfigurationExported-System-Object,MFR-Objects-Configuration-Events-ConfigurationExportedEventArgs-'></a>
### OnPresenterConfigurationExported(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-GUI-IMainWindowPresenter-ConfigurationExported 'MFR.GUI.IMainWindowPresenter.ConfigurationExported')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Objects.Configuration.Events.ConfigurationExportedEventArgs](#T-MFR-Objects-Configuration-Events-ConfigurationExportedEventArgs 'MFR.Objects.Configuration.Events.ConfigurationExportedEventArgs') | An
[ConfigurationExportedEventArgs](#T-MFR-Objects-ConfigurationExportedEventArgs 'MFR.Objects.ConfigurationExportedEventArgs')
that contains the event data. |

##### Remarks

This method is called when an export of the configuration has been
successfully completed. This method responds to the event by
informing the user that the operation has completed successfully.

<a name='M-MFR-GUI-Windows-MainWindow-OnPresenterConfigurationImported-System-Object,MFR-Objects-Configuration-Events-ConfigurationImportedEventArgs-'></a>
### OnPresenterConfigurationImported(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-GUI-IMainWindowPresenter-ConfigurationImported 'MFR.GUI.IMainWindowPresenter.ConfigurationImported')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Objects.Configuration.Events.ConfigurationImportedEventArgs](#T-MFR-Objects-Configuration-Events-ConfigurationImportedEventArgs 'MFR.Objects.Configuration.Events.ConfigurationImportedEventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to the event by triggering an update of the
screen from values stored in the configuration object in the
[Configuration](#P-MFR-GUI-MainWindowPresenter-Configuration 'MFR.GUI.MainWindowPresenter.Configuration')
property. This happens most often as a the result of the Import
Configuration command on the Tools menu.

<a name='M-MFR-GUI-Windows-MainWindow-OnPresenterDataOperationStarted-System-Object,MFR-Objects-Operations-Events-DataOperationEventArgs-'></a>
### OnPresenterDataOperationStarted(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-GUI-IMainWindowPresenter-DataOperationStarted 'MFR.GUI.IMainWindowPresenter.DataOperationStarted')
event raised by the presenter object when it's about to start an
operation that involves interaction with a data source.



Depending on the data source, this operation can be fast or it can
be slow, so the presenter object informs us in case we want to
update the user interface in order to tell the user what is going on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Objects.Operations.Events.DataOperationEventArgs](#T-MFR-Objects-Operations-Events-DataOperationEventArgs 'MFR.Objects.Operations.Events.DataOperationEventArgs') | A [DataOperationEventArgs](#T-MFR-Objects-DataOperationEventArgs 'MFR.Objects.DataOperationEventArgs')
that contains the event data. |

##### Remarks

This method responds to the event by displaying the marquee progress
control in the status bar and updating the status bar's Message
indicator to display the text that is passed in the
[Message](#P-MFR-Objects-DataOperationEventArgs-Message 'MFR.Objects.DataOperationEventArgs.Message')
property.



If the status bar is not presently visible, then this method does nothing.

<a name='M-MFR-GUI-Windows-MainWindow-OnPresenterFinished-System-Object,System-EventArgs-'></a>
### OnPresenterFinished(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-GUI-IMainWindowPresenter-Finished 'MFR.GUI.IMainWindowPresenter.Finished')
event.

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

Handles the
[](#E-MFR-GUI-IMainWindowPresenter-Started 'MFR.GUI.IMainWindowPresenter.Started')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This handler is called when the
[ProcessAll](#M-MFR-Objects-FileRenamer-ProcessAll 'MFR.Objects.FileRenamer.ProcessAll')
begins its
execution. This method responds by showing the progress dialog.

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