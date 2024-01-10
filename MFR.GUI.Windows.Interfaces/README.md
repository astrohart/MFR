<a name='assembly'></a>
# MFR.GUI.Windows.Interfaces

## Contents

- [IMainWindow](#T-MFR-GUI-Windows-Interfaces-IMainWindow 'MFR.GUI.Windows.Interfaces.IMainWindow')
  - [FindWhat](#P-MFR-GUI-Windows-Interfaces-IMainWindow-FindWhat 'MFR.GUI.Windows.Interfaces.IMainWindow.FindWhat')
  - [FindWhatComboBox](#P-MFR-GUI-Windows-Interfaces-IMainWindow-FindWhatComboBox 'MFR.GUI.Windows.Interfaces.IMainWindow.FindWhatComboBox')
  - [FoldButton](#P-MFR-GUI-Windows-Interfaces-IMainWindow-FoldButton 'MFR.GUI.Windows.Interfaces.IMainWindow.FoldButton')
  - [FullApplicationName](#P-MFR-GUI-Windows-Interfaces-IMainWindow-FullApplicationName 'MFR.GUI.Windows.Interfaces.IMainWindow.FullApplicationName')
  - [IsDataValid](#P-MFR-GUI-Windows-Interfaces-IMainWindow-IsDataValid 'MFR.GUI.Windows.Interfaces.IMainWindow.IsDataValid')
  - [IsFolded](#P-MFR-GUI-Windows-Interfaces-IMainWindow-IsFolded 'MFR.GUI.Windows.Interfaces.IMainWindow.IsFolded')
  - [MatchCase](#P-MFR-GUI-Windows-Interfaces-IMainWindow-MatchCase 'MFR.GUI.Windows.Interfaces.IMainWindow.MatchCase')
  - [MatchExactWord](#P-MFR-GUI-Windows-Interfaces-IMainWindow-MatchExactWord 'MFR.GUI.Windows.Interfaces.IMainWindow.MatchExactWord')
  - [OperationsCheckedListBox](#P-MFR-GUI-Windows-Interfaces-IMainWindow-OperationsCheckedListBox 'MFR.GUI.Windows.Interfaces.IMainWindow.OperationsCheckedListBox')
  - [ProfileCollectionComboBox](#P-MFR-GUI-Windows-Interfaces-IMainWindow-ProfileCollectionComboBox 'MFR.GUI.Windows.Interfaces.IMainWindow.ProfileCollectionComboBox')
  - [ReplaceWith](#P-MFR-GUI-Windows-Interfaces-IMainWindow-ReplaceWith 'MFR.GUI.Windows.Interfaces.IMainWindow.ReplaceWith')
  - [ReplaceWithComboBox](#P-MFR-GUI-Windows-Interfaces-IMainWindow-ReplaceWithComboBox 'MFR.GUI.Windows.Interfaces.IMainWindow.ReplaceWithComboBox')
  - [SelectAll](#P-MFR-GUI-Windows-Interfaces-IMainWindow-SelectAll 'MFR.GUI.Windows.Interfaces.IMainWindow.SelectAll')
  - [SelectedOptionTab](#P-MFR-GUI-Windows-Interfaces-IMainWindow-SelectedOptionTab 'MFR.GUI.Windows.Interfaces.IMainWindow.SelectedOptionTab')
  - [StartingFolder](#P-MFR-GUI-Windows-Interfaces-IMainWindow-StartingFolder 'MFR.GUI.Windows.Interfaces.IMainWindow.StartingFolder')
  - [StartingFolderComboBox](#P-MFR-GUI-Windows-Interfaces-IMainWindow-StartingFolderComboBox 'MFR.GUI.Windows.Interfaces.IMainWindow.StartingFolderComboBox')
  - [State](#P-MFR-GUI-Windows-Interfaces-IMainWindow-State 'MFR.GUI.Windows.Interfaces.IMainWindow.State')
  - [Version](#P-MFR-GUI-Windows-Interfaces-IMainWindow-Version 'MFR.GUI.Windows.Interfaces.IMainWindow.Version')
  - [DeselectAllOperations()](#M-MFR-GUI-Windows-Interfaces-IMainWindow-DeselectAllOperations 'MFR.GUI.Windows.Interfaces.IMainWindow.DeselectAllOperations')
  - [ResetProfileCollectionComboBox()](#M-MFR-GUI-Windows-Interfaces-IMainWindow-ResetProfileCollectionComboBox 'MFR.GUI.Windows.Interfaces.IMainWindow.ResetProfileCollectionComboBox')
  - [SelectAllOperations()](#M-MFR-GUI-Windows-Interfaces-IMainWindow-SelectAllOperations 'MFR.GUI.Windows.Interfaces.IMainWindow.SelectAllOperations')
  - [SetState(newState)](#M-MFR-GUI-Windows-Interfaces-IMainWindow-SetState-MFR-GUI-Windows-Constants-MainWindowState- 'MFR.GUI.Windows.Interfaces.IMainWindow.SetState(MFR.GUI.Windows.Constants.MainWindowState)')
- [Resources](#T-MFR-GUI-Windows-Interfaces-Properties-Resources 'MFR.GUI.Windows.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-GUI-Windows-Interfaces-Properties-Resources-Culture 'MFR.GUI.Windows.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Windows-Interfaces-Properties-Resources-ResourceManager 'MFR.GUI.Windows.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Windows-Interfaces-IMainWindow'></a>
## IMainWindow `type`

##### Namespace

MFR.GUI.Windows.Interfaces

##### Summary

Defines the public-exposed methods and properties of the main window of
the application.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets the text displayed in the edit portion of the 
combo box.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-FindWhatComboBox'></a>
### FindWhatComboBox `property`

##### Summary

Gets a reference to the text box control that allows the user to
specify the text to be found.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-FoldButton'></a>
### FoldButton `property`

##### Summary

Gets a reference to the
[FoldUnfoldButton](#T-MFR-GUI-Controls-FoldUnfoldButton 'MFR.GUI.Controls.FoldUnfoldButton')
that controls whether
the form is the folded (smaller) size or unfolded (larger, with more
options visible) size.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-FullApplicationName'></a>
### FullApplicationName `property`

##### Summary

Gets the full name of this application, including the current version.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-IsDataValid'></a>
### IsDataValid `property`

##### Summary

Gets a value indicating whether the data entered on this form is valid.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-IsFolded'></a>
### IsFolded `property`

##### Summary

Gets or sets a value specifying whether the form is in the Folded state.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-MatchCase'></a>
### MatchCase `property`

##### Summary

Gets or sets the value of the Match Case checkbox

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-MatchExactWord'></a>
### MatchExactWord `property`

##### Summary

Gets or sets the value of the Match Exact Word checkbox

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-OperationsCheckedListBox'></a>
### OperationsCheckedListBox `property`

##### Summary

Gets a reference to the
[CheckedListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CheckedListBox 'System.Windows.Forms.CheckedListBox')
that has the list of operations.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-ProfileCollectionComboBox'></a>
### ProfileCollectionComboBox `property`

##### Summary

Gets a reference to a [ToolStripComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.ToolStripComboBox 'System.Windows.Forms.ToolStripComboBox')
that has a drop-down list of the profiles that the user has created.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets the text displayed in the edit portion of the 
combo box.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-ReplaceWithComboBox'></a>
### ReplaceWithComboBox `property`

##### Summary

Gets a reference to the dropdown that allows the user to specify the
text to replace found text with.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-SelectAll'></a>
### SelectAll `property`

##### Summary

Gets or sets the value of the Select/Deselect All checkbox

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-SelectedOptionTab'></a>
### SelectedOptionTab `property`

##### Summary

Gets or sets the index of the tab that is selected in the Options
tab control.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-StartingFolder'></a>
### StartingFolder `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is configured as the folder
in which operations are to commence.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-StartingFolderComboBox'></a>
### StartingFolderComboBox `property`

##### Summary

Gets a reference to the control that allows the user to specify the
path to the starting folder.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-State'></a>
### State `property`

##### Summary

Gets  the [MainWindowState](#T-MFR-GUI-Windows-Constants-MainWindowState 'MFR.GUI.Windows.Constants.MainWindowState')
enumeration value that describes the current state.

<a name='P-MFR-GUI-Windows-Interfaces-IMainWindow-Version'></a>
### Version `property`

##### Summary

Gets a string containing this application's version.

##### Remarks

Thanks to

's answer on the Microsoft forums.

<a name='M-MFR-GUI-Windows-Interfaces-IMainWindow-DeselectAllOperations'></a>
### DeselectAllOperations() `method`

##### Summary

Deselects all the available operations that are listed on the 
tab.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Interfaces-IMainWindow-ResetProfileCollectionComboBox'></a>
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

<a name='M-MFR-GUI-Windows-Interfaces-IMainWindow-SelectAllOperations'></a>
### SelectAllOperations() `method`

##### Summary

Selects all the available operations that are listed on the 
tab.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-Interfaces-IMainWindow-SetState-MFR-GUI-Windows-Constants-MainWindowState-'></a>
### SetState(newState) `method`

##### Summary

Updates the value of the [State](#P-MFR-GUI-Windows-MainWindow-State 'MFR.GUI.Windows.MainWindow.State')
property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newState | [MFR.GUI.Windows.Constants.MainWindowState](#T-MFR-GUI-Windows-Constants-MainWindowState 'MFR.GUI.Windows.Constants.MainWindowState') | (Required.) One of the
[MainWindowState](#T-MFR-GUI-Windows-Constants-MainWindowState 'MFR.GUI.Windows.Constants.MainWindowState') values that
identifies the new state to be set. |

<a name='T-MFR-GUI-Windows-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Windows.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Windows-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Windows-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
