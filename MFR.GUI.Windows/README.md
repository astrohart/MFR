<a name='assembly'></a>
# MFR.GUI.Windows

## Contents

- [Is](#T-MFR-GUI-Windows-MainWindow-Is 'MFR.GUI.Windows.MainWindow.Is')
  - [SolutionFIle(pathname)](#M-MFR-GUI-Windows-MainWindow-Is-SolutionFIle-System-String- 'MFR.GUI.Windows.MainWindow.Is.SolutionFIle(System.String)')
- [MainWindow](#T-MFR-GUI-Windows-MainWindow 'MFR.GUI.Windows.MainWindow')
  - [#ctor()](#M-MFR-GUI-Windows-MainWindow-#ctor 'MFR.GUI.Windows.MainWindow.#ctor')
  - [_cmdInfo](#F-MFR-GUI-Windows-MainWindow-_cmdInfo 'MFR.GUI.Windows.MainWindow._cmdInfo')
  - [_operationEngine](#F-MFR-GUI-Windows-MainWindow-_operationEngine 'MFR.GUI.Windows.MainWindow._operationEngine')
  - [_state](#F-MFR-GUI-Windows-MainWindow-_state 'MFR.GUI.Windows.MainWindow._state')
  - [components](#F-MFR-GUI-Windows-MainWindow-components 'MFR.GUI.Windows.MainWindow.components')
  - [CommandLineInfo](#P-MFR-GUI-Windows-MainWindow-CommandLineInfo 'MFR.GUI.Windows.MainWindow.CommandLineInfo')
  - [ConfigProvider](#P-MFR-GUI-Windows-MainWindow-ConfigProvider 'MFR.GUI.Windows.MainWindow.ConfigProvider')
  - [CreateParams](#P-MFR-GUI-Windows-MainWindow-CreateParams 'MFR.GUI.Windows.MainWindow.CreateParams')
  - [CurrentConfiguration](#P-MFR-GUI-Windows-MainWindow-CurrentConfiguration 'MFR.GUI.Windows.MainWindow.CurrentConfiguration')
  - [FindWhat](#P-MFR-GUI-Windows-MainWindow-FindWhat 'MFR.GUI.Windows.MainWindow.FindWhat')
  - [FindWhatComboBox](#P-MFR-GUI-Windows-MainWindow-FindWhatComboBox 'MFR.GUI.Windows.MainWindow.FindWhatComboBox')
  - [FoldButton](#P-MFR-GUI-Windows-MainWindow-FoldButton 'MFR.GUI.Windows.MainWindow.FoldButton')
  - [FullApplicationName](#P-MFR-GUI-Windows-MainWindow-FullApplicationName 'MFR.GUI.Windows.MainWindow.FullApplicationName')
  - [Instance](#P-MFR-GUI-Windows-MainWindow-Instance 'MFR.GUI.Windows.MainWindow.Instance')
  - [IsDataValid](#P-MFR-GUI-Windows-MainWindow-IsDataValid 'MFR.GUI.Windows.MainWindow.IsDataValid')
  - [IsFolded](#P-MFR-GUI-Windows-MainWindow-IsFolded 'MFR.GUI.Windows.MainWindow.IsFolded')
  - [IsHistoryClear](#P-MFR-GUI-Windows-MainWindow-IsHistoryClear 'MFR.GUI.Windows.MainWindow.IsHistoryClear')
  - [MatchCase](#P-MFR-GUI-Windows-MainWindow-MatchCase 'MFR.GUI.Windows.MainWindow.MatchCase')
  - [MatchExactWord](#P-MFR-GUI-Windows-MainWindow-MatchExactWord 'MFR.GUI.Windows.MainWindow.MatchExactWord')
  - [OperationEngine](#P-MFR-GUI-Windows-MainWindow-OperationEngine 'MFR.GUI.Windows.MainWindow.OperationEngine')
  - [OperationsCheckedListBox](#P-MFR-GUI-Windows-MainWindow-OperationsCheckedListBox 'MFR.GUI.Windows.MainWindow.OperationsCheckedListBox')
  - [Presenter](#P-MFR-GUI-Windows-MainWindow-Presenter 'MFR.GUI.Windows.MainWindow.Presenter')
  - [ProfileCollectionComboBox](#P-MFR-GUI-Windows-MainWindow-ProfileCollectionComboBox 'MFR.GUI.Windows.MainWindow.ProfileCollectionComboBox')
  - [ReplaceWith](#P-MFR-GUI-Windows-MainWindow-ReplaceWith 'MFR.GUI.Windows.MainWindow.ReplaceWith')
  - [ReplaceWithComboBox](#P-MFR-GUI-Windows-MainWindow-ReplaceWithComboBox 'MFR.GUI.Windows.MainWindow.ReplaceWithComboBox')
  - [RootDirectoryPathValidator](#P-MFR-GUI-Windows-MainWindow-RootDirectoryPathValidator 'MFR.GUI.Windows.MainWindow.RootDirectoryPathValidator')
  - [SelectAll](#P-MFR-GUI-Windows-MainWindow-SelectAll 'MFR.GUI.Windows.MainWindow.SelectAll')
  - [SelectedOptionTab](#P-MFR-GUI-Windows-MainWindow-SelectedOptionTab 'MFR.GUI.Windows.MainWindow.SelectedOptionTab')
  - [StartingFolder](#P-MFR-GUI-Windows-MainWindow-StartingFolder 'MFR.GUI.Windows.MainWindow.StartingFolder')
  - [StartingFolderComboBox](#P-MFR-GUI-Windows-MainWindow-StartingFolderComboBox 'MFR.GUI.Windows.MainWindow.StartingFolderComboBox')
  - [State](#P-MFR-GUI-Windows-MainWindow-State 'MFR.GUI.Windows.MainWindow.State')
  - [TaskPool](#P-MFR-GUI-Windows-MainWindow-TaskPool 'MFR.GUI.Windows.MainWindow.TaskPool')
  - [Version](#P-MFR-GUI-Windows-MainWindow-Version 'MFR.GUI.Windows.MainWindow.Version')
  - [#cctor()](#M-MFR-GUI-Windows-MainWindow-#cctor 'MFR.GUI.Windows.MainWindow.#cctor')
  - [AttachCommandLineInfo(cmdInfo)](#M-MFR-GUI-Windows-MainWindow-AttachCommandLineInfo-MFR-CommandLine-Models-Interfaces-ICommandLineInfo- 'MFR.GUI.Windows.MainWindow.AttachCommandLineInfo(MFR.CommandLine.Models.Interfaces.ICommandLineInfo)')
  - [ConfigureAutocompletionForFindWhatComboBox()](#M-MFR-GUI-Windows-MainWindow-ConfigureAutocompletionForFindWhatComboBox 'MFR.GUI.Windows.MainWindow.ConfigureAutocompletionForFindWhatComboBox')
  - [DeselectAllOperations()](#M-MFR-GUI-Windows-MainWindow-DeselectAllOperations 'MFR.GUI.Windows.MainWindow.DeselectAllOperations')
  - [Dispose(disposing)](#M-MFR-GUI-Windows-MainWindow-Dispose-System-Boolean- 'MFR.GUI.Windows.MainWindow.Dispose(System.Boolean)')
  - [DoInitializeWindow()](#M-MFR-GUI-Windows-MainWindow-DoInitializeWindow 'MFR.GUI.Windows.MainWindow.DoInitializeWindow')
  - [DoUpdateConfiguredStartingFolder()](#M-MFR-GUI-Windows-MainWindow-DoUpdateConfiguredStartingFolder 'MFR.GUI.Windows.MainWindow.DoUpdateConfiguredStartingFolder')
  - [DoesDirectoryContainSolutionFile(path)](#M-MFR-GUI-Windows-MainWindow-DoesDirectoryContainSolutionFile-System-String- 'MFR.GUI.Windows.MainWindow.DoesDirectoryContainSolutionFile(System.String)')
  - [InitializeComponent()](#M-MFR-GUI-Windows-MainWindow-InitializeComponent 'MFR.GUI.Windows.MainWindow.InitializeComponent')
  - [InitializeConfiguration()](#M-MFR-GUI-Windows-MainWindow-InitializeConfiguration 'MFR.GUI.Windows.MainWindow.InitializeConfiguration')
  - [InitializeOperationEngine()](#M-MFR-GUI-Windows-MainWindow-InitializeOperationEngine 'MFR.GUI.Windows.MainWindow.InitializeOperationEngine')
  - [InitializePresenter()](#M-MFR-GUI-Windows-MainWindow-InitializePresenter 'MFR.GUI.Windows.MainWindow.InitializePresenter')
  - [InitializeStartingFolder()](#M-MFR-GUI-Windows-MainWindow-InitializeStartingFolder 'MFR.GUI.Windows.MainWindow.InitializeStartingFolder')
  - [OnCheckedChangedSelectDeselectAllCheckBox(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnCheckedChangedSelectDeselectAllCheckBox-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnCheckedChangedSelectDeselectAllCheckBox(System.Object,System.EventArgs)')
  - [OnClickBrowseForStartingFolder(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnClickBrowseForStartingFolder-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnClickBrowseForStartingFolder(System.Object,System.EventArgs)')
  - [OnClickPerformOperation(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnClickPerformOperation-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnClickPerformOperation(System.Object,System.EventArgs)')
  - [OnClickSwitchButton(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnClickSwitchButton-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnClickSwitchButton(System.Object,System.EventArgs)')
  - [OnConfiguredStartingFolderChanged(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnConfiguredStartingFolderChanged-System-Object,MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs- 'MFR.GUI.Windows.MainWindow.OnConfiguredStartingFolderChanged(System.Object,MFR.Settings.Configuration.Events.StartingFolderChangedEventArgs)')
  - [OnFileDropDownOpening(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnFileDropDownOpening-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnFileDropDownOpening(System.Object,System.EventArgs)')
  - [OnFileExit(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnFileExit-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnFileExit(System.Object,System.EventArgs)')
  - [OnFileSave(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnFileSave-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnFileSave(System.Object,System.EventArgs)')
  - [OnFormClosing(e)](#M-MFR-GUI-Windows-MainWindow-OnFormClosing-System-Windows-Forms-FormClosingEventArgs- 'MFR.GUI.Windows.MainWindow.OnFormClosing(System.Windows.Forms.FormClosingEventArgs)')
  - [OnFormFolded(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnFormFolded-System-Object,MFR-GUI-Controls-Events-FormFoldedEventArgs- 'MFR.GUI.Windows.MainWindow.OnFormFolded(System.Object,MFR.GUI.Controls.Events.FormFoldedEventArgs)')
  - [OnHelpAbout(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnHelpAbout-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnHelpAbout(System.Object,System.EventArgs)')
  - [OnHelpMenuDropDownOpening(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnHelpMenuDropDownOpening-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnHelpMenuDropDownOpening(System.Object,System.EventArgs)')
  - [OnOperationsPerform(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnOperationsPerform-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnOperationsPerform(System.Object,System.EventArgs)')
  - [OnOptionsModified(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnOptionsModified-System-Object,MFR-GUI-Dialogs-Events-ModifiedEventArgs- 'MFR.GUI.Windows.MainWindow.OnOptionsModified(System.Object,MFR.GUI.Dialogs.Events.ModifiedEventArgs)')
  - [OnPresenterAddNewProfileFailed(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterAddNewProfileFailed-System-Object,MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterAddNewProfileFailed(System.Object,MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs)')
  - [OnPresenterAllHistoryCleared(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterAllHistoryCleared-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterAllHistoryCleared(System.Object,System.EventArgs)')
  - [OnPresenterConfigurationExported(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterConfigurationExported-System-Object,MFR-Settings-Configuration-Events-ConfigurationExportedEventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterConfigurationExported(System.Object,MFR.Settings.Configuration.Events.ConfigurationExportedEventArgs)')
  - [OnPresenterConfigurationImported(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterConfigurationImported-System-Object,MFR-Settings-Configuration-Events-ConfigurationImportedEventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterConfigurationImported(System.Object,MFR.Settings.Configuration.Events.ConfigurationImportedEventArgs)')
  - [OnPresenterDataOperationFinished(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterDataOperationFinished-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterDataOperationFinished(System.Object,System.EventArgs)')
  - [OnPresenterDataOperationStarted(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterDataOperationStarted-System-Object,MFR-Operations-Events-DataOperationEventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterDataOperationStarted(System.Object,MFR.Operations.Events.DataOperationEventArgs)')
  - [OnPresenterFinished(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnPresenterFinished-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnPresenterFinished(System.Object,System.EventArgs)')
  - [OnRootDirectoryInvalid(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnRootDirectoryInvalid-System-Object,MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs- 'MFR.GUI.Windows.MainWindow.OnRootDirectoryInvalid(System.Object,MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs)')
  - [OnShown(e)](#M-MFR-GUI-Windows-MainWindow-OnShown-System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnShown(System.EventArgs)')
  - [OnStateChanged(e)](#M-MFR-GUI-Windows-MainWindow-OnStateChanged-MFR-GUI-Windows-Events-MainWindowStateChangedEventArgs- 'MFR.GUI.Windows.MainWindow.OnStateChanged(MFR.GUI.Windows.Events.MainWindowStateChangedEventArgs)')
  - [OnToolsConfigExport(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnToolsConfigExport-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnToolsConfigExport(System.Object,System.EventArgs)')
  - [OnToolsConfigImport(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnToolsConfigImport-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnToolsConfigImport(System.Object,System.EventArgs)')
  - [OnToolsConfigurationNewProfile(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnToolsConfigurationNewProfile-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnToolsConfigurationNewProfile(System.Object,System.EventArgs)')
  - [OnToolsHistoryClearAll(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnToolsHistoryClearAll-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnToolsHistoryClearAll(System.Object,System.EventArgs)')
  - [OnToolsOptions(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnToolsOptions-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnToolsOptions(System.Object,System.EventArgs)')
  - [OnUpdateCmdUI(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnUpdateCmdUI-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnUpdateCmdUI(System.Object,System.EventArgs)')
  - [OnViewDarkTheme(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnViewDarkTheme-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnViewDarkTheme(System.Object,System.EventArgs)')
  - [OnViewStatusBar(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnViewStatusBar-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnViewStatusBar(System.Object,System.EventArgs)')
  - [OnViewToolBar(sender,e)](#M-MFR-GUI-Windows-MainWindow-OnViewToolBar-System-Object,System-EventArgs- 'MFR.GUI.Windows.MainWindow.OnViewToolBar(System.Object,System.EventArgs)')
  - [ResetProfileCollectionComboBox()](#M-MFR-GUI-Windows-MainWindow-ResetProfileCollectionComboBox 'MFR.GUI.Windows.MainWindow.ResetProfileCollectionComboBox')
  - [SaveUserSettingsOnExit()](#M-MFR-GUI-Windows-MainWindow-SaveUserSettingsOnExit 'MFR.GUI.Windows.MainWindow.SaveUserSettingsOnExit')
  - [SelectAllOperations()](#M-MFR-GUI-Windows-MainWindow-SelectAllOperations 'MFR.GUI.Windows.MainWindow.SelectAllOperations')
  - [SetState(newState)](#M-MFR-GUI-Windows-MainWindow-SetState-MFR-GUI-Windows-Constants-MainWindowState- 'MFR.GUI.Windows.MainWindow.SetState(MFR.GUI.Windows.Constants.MainWindowState)')
  - [ShouldNotProceedDueToPotentialOverwrites()](#M-MFR-GUI-Windows-MainWindow-ShouldNotProceedDueToPotentialOverwrites 'MFR.GUI.Windows.MainWindow.ShouldNotProceedDueToPotentialOverwrites')
  - [UpdateData(bSaveAndValidate)](#M-MFR-GUI-Windows-MainWindow-UpdateData-System-Boolean- 'MFR.GUI.Windows.MainWindow.UpdateData(System.Boolean)')
  - [UpdateSize(newSize)](#M-MFR-GUI-Windows-MainWindow-UpdateSize-System-Drawing-Size- 'MFR.GUI.Windows.MainWindow.UpdateSize(System.Drawing.Size)')
  - [ValidateData()](#M-MFR-GUI-Windows-MainWindow-ValidateData 'MFR.GUI.Windows.MainWindow.ValidateData')
- [Resources](#T-MFR-GUI-Windows-Properties-Resources 'MFR.GUI.Windows.Properties.Resources')
  - [AppIdle](#P-MFR-GUI-Windows-Properties-Resources-AppIdle 'MFR.GUI.Windows.Properties.Resources.AppIdle')
  - [Confirm_ReplaceTextThatWouldOverwriteExistingFiles](#P-MFR-GUI-Windows-Properties-Resources-Confirm_ReplaceTextThatWouldOverwriteExistingFiles 'MFR.GUI.Windows.Properties.Resources.Confirm_ReplaceTextThatWouldOverwriteExistingFiles')
  - [Culture](#P-MFR-GUI-Windows-Properties-Resources-Culture 'MFR.GUI.Windows.Properties.Resources.Culture')
  - [Error_CantSetUpFindWhatComboStartFolderNotExists](#P-MFR-GUI-Windows-Properties-Resources-Error_CantSetUpFindWhatComboStartFolderNotExists 'MFR.GUI.Windows.Properties.Resources.Error_CantSetUpFindWhatComboStartFolderNotExists')
  - [Error_FindWhat_MissingValue](#P-MFR-GUI-Windows-Properties-Resources-Error_FindWhat_MissingValue 'MFR.GUI.Windows.Properties.Resources.Error_FindWhat_MissingValue')
  - [Error_FindWhat_ReplaceWith_Identical](#P-MFR-GUI-Windows-Properties-Resources-Error_FindWhat_ReplaceWith_Identical 'MFR.GUI.Windows.Properties.Resources.Error_FindWhat_ReplaceWith_Identical')
  - [Error_NoOperationSelected](#P-MFR-GUI-Windows-Properties-Resources-Error_NoOperationSelected 'MFR.GUI.Windows.Properties.Resources.Error_NoOperationSelected')
  - [Error_Specify_ReplaceWith](#P-MFR-GUI-Windows-Properties-Resources-Error_Specify_ReplaceWith 'MFR.GUI.Windows.Properties.Resources.Error_Specify_ReplaceWith')
  - [Error_StartingFolderMustContainSolutionFile](#P-MFR-GUI-Windows-Properties-Resources-Error_StartingFolderMustContainSolutionFile 'MFR.GUI.Windows.Properties.Resources.Error_StartingFolderMustContainSolutionFile')
  - [Info_PreparingStartOperations](#P-MFR-GUI-Windows-Properties-Resources-Info_PreparingStartOperations 'MFR.GUI.Windows.Properties.Resources.Info_PreparingStartOperations')
  - [ResourceManager](#P-MFR-GUI-Windows-Properties-Resources-ResourceManager 'MFR.GUI.Windows.Properties.Resources.ResourceManager')
  - [SwitchUpDown_16x](#P-MFR-GUI-Windows-Properties-Resources-SwitchUpDown_16x 'MFR.GUI.Windows.Properties.Resources.SwitchUpDown_16x')

<a name='T-MFR-GUI-Windows-MainWindow-Is'></a>
## Is `type`

##### Namespace

MFR.GUI.Windows.MainWindow

##### Summary

Exposes static methods to make determinations about data and the state of the
system.

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

<a name='F-MFR-GUI-Windows-MainWindow-_cmdInfo'></a>
### _cmdInfo `constants`

##### Summary

Reference to an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface
that contains the settings that were specified by the user on the command line
when this application was launched.

<a name='F-MFR-GUI-Windows-MainWindow-_operationEngine'></a>
### _operationEngine `constants`

##### Summary

Reference to an instance of an object that implements the
[IFullGuiOperationEngine](#T-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine')
interface.

##### Remarks

Needed to make the
[OperationEngine](#P-MFR-GUI-Windows-MainWindow-OperationEngine 'MFR.GUI.Windows.MainWindow.OperationEngine') property
compute-once and store without having to use a static context.



This is due to the use of `dynamic` in the computation.

<a name='F-MFR-GUI-Windows-MainWindow-_state'></a>
### _state `constants`

##### Summary

One of the [MainWindowState](#T-MFR-GUI-Windows-Constants-MainWindowState 'MFR.GUI.Windows.Constants.MainWindowState')
enumeration values that describes the current state of processing.

<a name='F-MFR-GUI-Windows-MainWindow-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Windows-MainWindow-CommandLineInfo'></a>
### CommandLineInfo `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface
that contains the settings that were specified by the user on the command line
when this application was launched.

<a name='P-MFR-GUI-Windows-MainWindow-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

##### Remarks

This object allows access to the user config and the
actions
associated with it.

<a name='P-MFR-GUI-Windows-MainWindow-CreateParams'></a>
### CreateParams `property`

##### Summary

Gets the required creation parameters when the control handle is
created.

##### Returns

A [CreateParams](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.CreateParams 'System.Windows.Forms.CreateParams') that contains the
required creation parameters when the handle to the control is created.

<a name='P-MFR-GUI-Windows-MainWindow-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

<a name='P-MFR-GUI-Windows-MainWindow-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets the text displayed in the edit portion of the 
combo box.

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

<a name='P-MFR-GUI-Windows-MainWindow-OperationEngine'></a>
### OperationEngine `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFullGuiOperationEngine](#T-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine')
interface that represents the engine that carries out the user's requested
operations.

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

<a name='P-MFR-GUI-Windows-MainWindow-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets the text displayed in the edit portion of the 
combo box.

<a name='P-MFR-GUI-Windows-MainWindow-ReplaceWithComboBox'></a>
### ReplaceWithComboBox `property`

##### Summary

Gets a reference to the text box control that allows the user to
specify the text to replace found text with.

<a name='P-MFR-GUI-Windows-MainWindow-RootDirectoryPathValidator'></a>
### RootDirectoryPathValidator `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IRootDirectoryPathValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryPathValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator')
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

<a name='P-MFR-GUI-Windows-MainWindow-StartingFolder'></a>
### StartingFolder `property`

##### Summary

Gets or sets the text displayed in the edit portion of the
combo box.

<a name='P-MFR-GUI-Windows-MainWindow-StartingFolderComboBox'></a>
### StartingFolderComboBox `property`

##### Summary

Gets a reference to the control that allows the user to specify the
path to the starting folder.

<a name='P-MFR-GUI-Windows-MainWindow-State'></a>
### State `property`

##### Summary

Gets  the [MainWindowState](#T-MFR-GUI-Windows-Constants-MainWindowState 'MFR.GUI.Windows.Constants.MainWindowState')
enumeration value that describes the current state.

<a name='P-MFR-GUI-Windows-MainWindow-TaskPool'></a>
### TaskPool `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ITaskPool](#T-xyLOGIX-Pools-Tasks-Interfaces-ITaskPool 'xyLOGIX.Pools.Tasks.Interfaces.ITaskPool') interface.

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

<a name='M-MFR-GUI-Windows-MainWindow-AttachCommandLineInfo-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-'></a>
### AttachCommandLineInfo(cmdInfo) `method`

##### Summary

Associates the specified `cmdInfo` object with this window.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cmdInfo | [MFR.CommandLine.Models.Interfaces.ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') | (Required.) Reference to an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface
that contains the settings specified by the user on the command line when this
application was launched. |

##### Remarks

If a `null` reference is passed for the argument of
the `cmdInfo` parameter, then this method does nothing.

<a name='M-MFR-GUI-Windows-MainWindow-ConfigureAutocompletionForFindWhatComboBox'></a>
### ConfigureAutocompletionForFindWhatComboBox() `method`

##### Summary

Configures the combo box.

##### Parameters

This method has no parameters.

##### Remarks

One of the things method does is get a list of all the `*.csproj` files in
the stating folder and builds an auto-completion suggestion list consisting of
just their names (with no folder path or file extension).

<a name='M-MFR-GUI-Windows-MainWindow-DeselectAllOperations'></a>
### DeselectAllOperations() `method`

##### Summary

Deselects all the available operations that are listed on the 
tab.

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

<a name='M-MFR-GUI-Windows-MainWindow-DoInitializeWindow'></a>
### DoInitializeWindow() `method`

##### Summary

Carries out a series of actions to initialize the GUI.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-MainWindow-DoUpdateConfiguredStartingFolder'></a>
### DoUpdateConfiguredStartingFolder() `method`

##### Summary

Responds to the `ConfiguredStartingFolderChanged` event by updating the
value of the combo box and ensuring the new value for
the starting folder is added to the history.

##### Parameters

This method has no parameters.

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

<a name='M-MFR-GUI-Windows-MainWindow-InitializeConfiguration'></a>
### InitializeConfiguration() `method`

##### Summary

Checks whether the value of the
[CurrentConfiguration](#P-MFR-GUI-Windows-MainWindow-CurrentConfiguration 'MFR.GUI.Windows.MainWindow.CurrentConfiguration') property is
`null`.



If so, then calls the
[Load](#M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-Load 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider.Load')
method to load the application config.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-MainWindow-InitializeOperationEngine'></a>
### InitializeOperationEngine() `method`

##### Summary

Sets up the operation engine object.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-MainWindow-InitializePresenter'></a>
### InitializePresenter() `method`

##### Summary

Sets up the presenter object and attaches handlers to events that it exposes.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-MainWindow-InitializeStartingFolder'></a>
### InitializeStartingFolder() `method`

##### Summary

Called to check whether a Starting Folder has been configured (e.g., from
command-line options) and, if so, and if that folder exists, then the text of
the combo box is updated to match.

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

<a name='M-MFR-GUI-Windows-MainWindow-OnConfiguredStartingFolderChanged-System-Object,MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs-'></a>
### OnConfiguredStartingFolderChanged(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-StartingFolderChanged 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.StartingFolderChanged')
event raised by the object instance that represents the currently-loaded
application config.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [MFR.Settings.Configuration.Events.StartingFolderChangedEventArgs](#T-MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs 'MFR.Settings.Configuration.Events.StartingFolderChangedEventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method responds by invoking the
[DoUpdateConfiguredStartingFolder](#M-MFR-GUI-Windows-MainWindow-DoUpdateConfiguredStartingFolder 'MFR.GUI.Windows.MainWindow.DoUpdateConfiguredStartingFolder')
method, and, if required, marshaling the method call to the UI thread.

<a name='M-MFR-GUI-Windows-MainWindow-OnFileDropDownOpening-System-Object,System-EventArgs-'></a>
### OnFileDropDownOpening(sender,e) `method`

##### Summary

Handles the
[](#E-System-Windows-Forms-ToolStripDropDownItem-DropDownOpening 'System.Windows.Forms.ToolStripDropDownItem.DropDownOpening')
event raised by the menu when the user clicks on it but before the
items are shown to the user.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method responds by enabling and disabling menu items in a manner
that corresponds to the current state of the application.

<a name='M-MFR-GUI-Windows-MainWindow-OnFileExit-System-Object,System-EventArgs-'></a>
### OnFileExit(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event for the command on the menu.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called to handle the message of the user clicking the
Exit command on the File menu. This method saves the config
and then closes this window. Since this window is the main window of
the application, closing this window ends the lifecycle of the application.

<a name='M-MFR-GUI-Windows-MainWindow-OnFileSave-System-Object,System-EventArgs-'></a>
### OnFileSave(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click') event
raised by the button on the toolbar or the
item on the menu.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method responds by saving the configuration to the disk.

<a name='M-MFR-GUI-Windows-MainWindow-OnFormClosing-System-Windows-Forms-FormClosingEventArgs-'></a>
### OnFormClosing(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-FormClosing 'System.Windows.Forms.Form.FormClosing')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Windows.Forms.FormClosingEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosingEventArgs 'System.Windows.Forms.FormClosingEventArgs') | A [FormClosingEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosingEventArgs 'System.Windows.Forms.FormClosingEventArgs')
that contains the event data. |

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

This method is called when an export of the config has been
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
screen from values stored in the config object in the
[ProjectFileRenamerConfig](#P-MFR-GUI-MainWindowPresenter-ProjectFileRenamerConfig 'MFR.GUI.MainWindowPresenter.ProjectFileRenamerConfig')
property. This happens most often as a result of the
command on the menu.

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



Depending on the data source, this operation can be fast, or it can
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

<a name='M-MFR-GUI-Windows-MainWindow-OnRootDirectoryInvalid-System-Object,MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-'></a>
### OnRootDirectoryInvalid(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-CommandLine-Validators-Interfaces-IRootDirectoryPathValidator-RootDirectoryInvalid 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryPathValidator.RootDirectoryInvalid')
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

<a name='M-MFR-GUI-Windows-MainWindow-OnShown-System-EventArgs-'></a>
### OnShown(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Shown 'System.Windows.Forms.Form.Shown') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='M-MFR-GUI-Windows-MainWindow-OnStateChanged-MFR-GUI-Windows-Events-MainWindowStateChangedEventArgs-'></a>
### OnStateChanged(e) `method`

##### Summary

Raises the [](#E-MFR-GUI-Windows-MainWindow-StateChanged 'MFR.GUI.Windows.MainWindow.StateChanged') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.GUI.Windows.Events.MainWindowStateChangedEventArgs](#T-MFR-GUI-Windows-Events-MainWindowStateChangedEventArgs 'MFR.GUI.Windows.Events.MainWindowStateChangedEventArgs') | (Required.) A
[MainWindowStateChangedEventArgs](#T-MFR-GUI-Windows-Events-MainWindowStateChangedEventArgs 'MFR.GUI.Windows.Events.MainWindowStateChangedEventArgs') that
contains the event data. |

<a name='M-MFR-GUI-Windows-MainWindow-OnToolsConfigExport-System-Object,System-EventArgs-'></a>
### OnToolsConfigExport(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event for the Tools -> Import and Export ProjectFileRenamerConfig -
>
Export ProjectFileRenamerConfig menu command.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called when the user chooses the Export
ProjectFileRenamerConfig
menu command from the Import and Export ProjectFileRenamerConfig submenu
of the
Tools menu. This method responds to the event by showing the user a
dialog that the user can utilize to select the pathname of the file
that the user wants the config data to be exported to.

<a name='M-MFR-GUI-Windows-MainWindow-OnToolsConfigImport-System-Object,System-EventArgs-'></a>
### OnToolsConfigImport(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click')
event for the Tools -> Import and Export ProjectFileRenamerConfig -
>
Import ProjectFileRenamerConfig menu command.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called when the user chooses the Import
ProjectFileRenamerConfig
menu command from the Import and Export ProjectFileRenamerConfig submenu
of the
Tools menu. This method responds to the event by showing the user a
dialog that the user can utilize to select the file they want to
import, and then calls the presenter to perform the import operation.

<a name='M-MFR-GUI-Windows-MainWindow-OnToolsConfigurationNewProfile-System-Object,System-EventArgs-'></a>
### OnToolsConfigurationNewProfile(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click') event
raised by the New Profile toolbar button and/or Tools ->
ProjectFileRenamerConfig -> New
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
history lists in the config, saving it to the config
data source, and then reloading the screen from the config.

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

<a name='M-MFR-GUI-Windows-MainWindow-OnViewDarkTheme-System-Object,System-EventArgs-'></a>
### OnViewDarkTheme(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-ToolStripItem-Click 'System.Windows.Forms.ToolStripItem.Click') event
raised by the command on the menu.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method responds by toggling the Dark Theme on and off.

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
event for the View -> Toolbar command.

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

<a name='M-MFR-GUI-Windows-MainWindow-SaveUserSettingsOnExit'></a>
### SaveUserSettingsOnExit() `method`

##### Summary

Saves the user's settings to the config object in memory, and shows a
progress dialog to the user while doing so.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-MainWindow-SelectAllOperations'></a>
### SelectAllOperations() `method`

##### Summary

Selects all the available operations that are listed on the 
tab.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-MainWindow-SetState-MFR-GUI-Windows-Constants-MainWindowState-'></a>
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

<a name='M-MFR-GUI-Windows-MainWindow-ShouldNotProceedDueToPotentialOverwrites'></a>
### ShouldNotProceedDueToPotentialOverwrites() `method`

##### Summary

Warns the user about a potentially destructive operation.

##### Returns

`true` if the selected operation(s) should NOT be
processed; `false` otherwise.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Windows-MainWindow-UpdateData-System-Boolean-'></a>
### UpdateData(bSaveAndValidate) `method`

##### Summary

Moves data from this dialog's controls to the config object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bSaveAndValidate | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')
that specifies whether to save information from the screen into data variables.
`false` to load data to the screen. |

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

<a name='P-MFR-GUI-Windows-Properties-Resources-Confirm_ReplaceTextThatWouldOverwriteExistingFiles'></a>
### Confirm_ReplaceTextThatWouldOverwriteExistingFiles `property`

##### Summary

Looks up a localized string similar to Project File Renamer has detected that subFolder(s) or C# project(s) exist in directory tree of the Starting Folder who would be overwritten by your proposed change(s).

Such an operation could be very destructive of many hours or days of previous work.

Do you still wish to continue?.

<a name='P-MFR-GUI-Windows-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Windows-Properties-Resources-Error_CantSetUpFindWhatComboStartFolderNotExists'></a>
### Error_CantSetUpFindWhatComboStartFolderNotExists `property`

##### Summary

Looks up a localized string similar to *** ERROR *** The folder '{0}' (currently-configured starting folder) does  not exist.  Therefore, we cannot set up the auto-completion of the Find What combo box using its subfolders that contain projects..

<a name='P-MFR-GUI-Windows-Properties-Resources-Error_FindWhat_MissingValue'></a>
### Error_FindWhat_MissingValue `property`

##### Summary

Looks up a localized string similar to Please provide a value for the text to be located during the search..

<a name='P-MFR-GUI-Windows-Properties-Resources-Error_FindWhat_ReplaceWith_Identical'></a>
### Error_FindWhat_ReplaceWith_Identical `property`

##### Summary

Looks up a localized string similar to Please type different values in the Text to Be Replaced and With What fields..

<a name='P-MFR-GUI-Windows-Properties-Resources-Error_NoOperationSelected'></a>
### Error_NoOperationSelected `property`

##### Summary

Looks up a localized string similar to Please select at least one operation on the Operations tab.
NOTE: To show the Operations tab (if it isn't already visible), click the More button.

Would you like to select all operations now, and try again?.

<a name='P-MFR-GUI-Windows-Properties-Resources-Error_Specify_ReplaceWith'></a>
### Error_Specify_ReplaceWith `property`

##### Summary

Looks up a localized string similar to Please provide a value for the replacement value to be used during the search..

<a name='P-MFR-GUI-Windows-Properties-Resources-Error_StartingFolderMustContainSolutionFile'></a>
### Error_StartingFolderMustContainSolutionFile `property`

##### Summary

Looks up a localized string similar to Please select a directory that contains a Visual Studio Solution (*.sln) file for the What Folder Should the Operation Start In field.

Do you want to proceed regardless?  CAUTION: Unpredictable things may happen.  Don't say we did not warn you..

<a name='P-MFR-GUI-Windows-Properties-Resources-Info_PreparingStartOperations'></a>
### Info_PreparingStartOperations `property`

##### Summary

Looks up a localized string similar to Getting ready to start the operations....

<a name='P-MFR-GUI-Windows-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-MFR-GUI-Windows-Properties-Resources-SwitchUpDown_16x'></a>
### SwitchUpDown_16x `property`

##### Summary

Looks up a localized resource of type System.Drawing.Bitmap.
