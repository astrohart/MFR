<a name='assembly'></a>
# MFR.GUI.Dialogs.Interfaces

## Contents

- [IAutoStartCancellableProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IAutoStartCancellableProgressDialog 'MFR.GUI.Dialogs.Interfaces.IAutoStartCancellableProgressDialog')
- [ICancellableProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-ICancellableProgressDialog 'MFR.GUI.Dialogs.Interfaces.ICancellableProgressDialog')
  - [CanCancel](#P-MFR-GUI-Dialogs-Interfaces-ICancellableProgressDialog-CanCancel 'MFR.GUI.Dialogs.Interfaces.ICancellableProgressDialog.CanCancel')
  - [CurrentFile](#P-MFR-GUI-Dialogs-Interfaces-ICancellableProgressDialog-CurrentFile 'MFR.GUI.Dialogs.Interfaces.ICancellableProgressDialog.CurrentFile')
- [ICustomizeOperationsDialog](#T-MFR-GUI-Dialogs-Interfaces-ICustomizeOperationsDialog 'MFR.GUI.Dialogs.Interfaces.ICustomizeOperationsDialog')
  - [OperationListBuilder](#P-MFR-GUI-Dialogs-Interfaces-ICustomizeOperationsDialog-OperationListBuilder 'MFR.GUI.Dialogs.Interfaces.ICustomizeOperationsDialog.OperationListBuilder')
- [IErrorReportDialog](#T-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog')
  - [ErrorReportContents](#P-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog-ErrorReportContents 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog.ErrorReportContents')
  - [Exception](#P-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog-Exception 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog.Exception')
  - [ReproductionSteps](#P-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog-ReproductionSteps 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog.ReproductionSteps')
  - [ViewReportLinkLabel](#P-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog-ViewReportLinkLabel 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog.ViewReportLinkLabel')
- [IFolderSelectDialog](#T-MFR-GUI-Dialogs-Interfaces-IFolderSelectDialog 'MFR.GUI.Dialogs.Interfaces.IFolderSelectDialog')
  - [FileName](#P-MFR-GUI-Dialogs-Interfaces-IFolderSelectDialog-FileName 'MFR.GUI.Dialogs.Interfaces.IFolderSelectDialog.FileName')
  - [InitialDirectory](#P-MFR-GUI-Dialogs-Interfaces-IFolderSelectDialog-InitialDirectory 'MFR.GUI.Dialogs.Interfaces.IFolderSelectDialog.InitialDirectory')
  - [Title](#P-MFR-GUI-Dialogs-Interfaces-IFolderSelectDialog-Title 'MFR.GUI.Dialogs.Interfaces.IFolderSelectDialog.Title')
  - [ShowDialog()](#M-MFR-GUI-Dialogs-Interfaces-IFolderSelectDialog-ShowDialog 'MFR.GUI.Dialogs.Interfaces.IFolderSelectDialog.ShowDialog')
  - [ShowDialog(owner)](#M-MFR-GUI-Dialogs-Interfaces-IFolderSelectDialog-ShowDialog-System-Windows-Forms-IWin32Window- 'MFR.GUI.Dialogs.Interfaces.IFolderSelectDialog.ShowDialog(System.Windows.Forms.IWin32Window)')
- [IOperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog')
  - [Argument](#P-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog-Argument 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Argument')
  - [Proc](#P-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog-Proc 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Proc')
  - [Result](#P-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog-Result 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Result')
- [IOptionsDialog](#T-MFR-GUI-Dialogs-Interfaces-IOptionsDialog 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog')
  - [AutoQuitOnCompletion](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-AutoQuitOnCompletion 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.AutoQuitOnCompletion')
  - [CommitAuthorEmail](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-CommitAuthorEmail 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.CommitAuthorEmail')
  - [CommitAuthorName](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-CommitAuthorName 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.CommitAuthorName')
  - [ConfigPathname](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-ConfigPathname 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.ConfigPathname')
  - [DontPromptUserToReloadOpenSolution](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-DontPromptUserToReloadOpenSolution 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.DontPromptUserToReloadOpenSolution')
  - [ErrantProcesses](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-ErrantProcesses 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.ErrantProcesses')
  - [HasErrantProcesses](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-HasErrantProcesses 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.HasErrantProcesses')
  - [IsErrantProcessSelected](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-IsErrantProcessSelected 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.IsErrantProcessSelected')
  - [IsModified](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-IsModified 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.IsModified')
  - [PushChangesToRemoteWhenDone](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-PushChangesToRemoteWhenDone 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.PushChangesToRemoteWhenDone')
  - [ReOpenSolution](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-ReOpenSolution 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.ReOpenSolution')
  - [SelectedErrantProcess](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-SelectedErrantProcess 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.SelectedErrantProcess')
  - [ShouldCommitPendingChanges](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-ShouldCommitPendingChanges 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.ShouldCommitPendingChanges')
  - [ShouldCommitPostOperationChanges](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-ShouldCommitPostOperationChanges 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.ShouldCommitPostOperationChanges')
  - [UpdateGitOnAutoStart](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-UpdateGitOnAutoStart 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.UpdateGitOnAutoStart')
- [IProfileNameDialog](#T-MFR-GUI-Dialogs-Interfaces-IProfileNameDialog 'MFR.GUI.Dialogs.Interfaces.IProfileNameDialog')
  - [OperationType](#P-MFR-GUI-Dialogs-Interfaces-IProfileNameDialog-OperationType 'MFR.GUI.Dialogs.Interfaces.IProfileNameDialog.OperationType')
  - [ProfileName](#P-MFR-GUI-Dialogs-Interfaces-IProfileNameDialog-ProfileName 'MFR.GUI.Dialogs.Interfaces.IProfileNameDialog.ProfileName')
- [IProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IProgressDialog 'MFR.GUI.Dialogs.Interfaces.IProgressDialog')
  - [ProgressBar](#P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-ProgressBar 'MFR.GUI.Dialogs.Interfaces.IProgressDialog.ProgressBar')
  - [ProgressBarMaximum](#P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-ProgressBarMaximum 'MFR.GUI.Dialogs.Interfaces.IProgressDialog.ProgressBarMaximum')
  - [ProgressBarMinimum](#P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-ProgressBarMinimum 'MFR.GUI.Dialogs.Interfaces.IProgressDialog.ProgressBarMinimum')
  - [ProgressBarStyle](#P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-ProgressBarStyle 'MFR.GUI.Dialogs.Interfaces.IProgressDialog.ProgressBarStyle')
  - [ProgressBarValue](#P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-ProgressBarValue 'MFR.GUI.Dialogs.Interfaces.IProgressDialog.ProgressBarValue')
  - [Status](#P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-Status 'MFR.GUI.Dialogs.Interfaces.IProgressDialog.Status')
  - [Reset()](#M-MFR-GUI-Dialogs-Interfaces-IProgressDialog-Reset 'MFR.GUI.Dialogs.Interfaces.IProgressDialog.Reset')
- [Resources](#T-MFR-GUI-Dialogs-Interfaces-Properties-Resources 'MFR.GUI.Dialogs.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-GUI-Dialogs-Interfaces-Properties-Resources-Culture 'MFR.GUI.Dialogs.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Dialogs-Interfaces-Properties-Resources-ResourceManager 'MFR.GUI.Dialogs.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Dialogs-Interfaces-IAutoStartCancellableProgressDialog'></a>
## IAutoStartCancellableProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a dialog box that shows
the progress of a file-rename operation that has been launched from the command
line with the `--autoStart` flag set.

<a name='T-MFR-GUI-Dialogs-Interfaces-ICancellableProgressDialog'></a>
## ICancellableProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs.Interfaces

##### Summary

Defines the public-exposed methods and properties of a progress window..

<a name='P-MFR-GUI-Dialogs-Interfaces-ICancellableProgressDialog-CanCancel'></a>
### CanCancel `property`

##### Summary

Gets or sets a value indicating whether the operation can be cancelled.

<a name='P-MFR-GUI-Dialogs-Interfaces-ICancellableProgressDialog-CurrentFile'></a>
### CurrentFile `property`

##### Summary

Gets or sets a string containing the new detailed status.

<a name='T-MFR-GUI-Dialogs-Interfaces-ICustomizeOperationsDialog'></a>
## ICustomizeOperationsDialog `type`

##### Namespace

MFR.GUI.Dialogs.Interfaces

<a name='P-MFR-GUI-Dialogs-Interfaces-ICustomizeOperationsDialog-OperationListBuilder'></a>
### OperationListBuilder `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IDarkListBuilderControl](#T-xyLOGIX-UI-Dark-Controls-Interfaces-IDarkListBuilderControl 'xyLOGIX.UI.Dark.Controls.Interfaces.IDarkListBuilderControl')
interface.

<a name='T-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog'></a>
## IErrorReportDialog `type`

##### Namespace

MFR.GUI.Dialogs.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of the Error Report dialog.

##### Remarks

This dialog lets the user of the application know that an error has
occurred and gives the user options as to what to do with the information.

<a name='P-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog-ErrorReportContents'></a>
### ErrorReportContents `property`

##### Summary

Gets a string that contains the contents of an error report, given the value of
the [Exception](#P-MFR-GUI-Dialogs-ErrorReportDialog-Exception 'MFR.GUI.Dialogs.ErrorReportDialog.Exception') property.

<a name='P-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog-Exception'></a>
### Exception `property`

##### Summary

Gets or sets the [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes the error
that occurred.

<a name='P-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog-ReproductionSteps'></a>
### ReproductionSteps `property`

##### Summary

Gets or sets the value of the Reproduction Steps text box.

<a name='P-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog-ViewReportLinkLabel'></a>
### ViewReportLinkLabel `property`

##### Summary

Gets a reference to the View Report link-label control.

<a name='T-MFR-GUI-Dialogs-Interfaces-IFolderSelectDialog'></a>
## IFolderSelectDialog `type`

##### Namespace

MFR.GUI.Dialogs.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a Folder Selection dialog box.

<a name='P-MFR-GUI-Dialogs-Interfaces-IFolderSelectDialog-FileName'></a>
### FileName `property`

##### Summary

Gets the fully-qualified pathname of the folder that the user selected.

<a name='P-MFR-GUI-Dialogs-Interfaces-IFolderSelectDialog-InitialDirectory'></a>
### InitialDirectory `property`

##### Summary

Gets/Sets the initial folder to be selected. A `null` value selects
the current directory.

<a name='P-MFR-GUI-Dialogs-Interfaces-IFolderSelectDialog-Title'></a>
### Title `property`

##### Summary

Gets or sets a string containing the text to be displayed in the title bar

<a name='M-MFR-GUI-Dialogs-Interfaces-IFolderSelectDialog-ShowDialog'></a>
### ShowDialog() `method`

##### Summary

Shows the form as a modal dialog box.

##### Returns

One of the [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') values.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | The form being shown is already visible.
-or- The form being shown is disabled.
-or- The form being shown is not a top-level window.
-or- The form being shown as a dialog box is already a modal form.
-or- The current process is not running in user interactive mode (for
more information, see
[UserInteractive](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SystemInformation.UserInteractive 'System.Windows.Forms.SystemInformation.UserInteractive')). |

<a name='M-MFR-GUI-Dialogs-Interfaces-IFolderSelectDialog-ShowDialog-System-Windows-Forms-IWin32Window-'></a>
### ShowDialog(owner) `method`

##### Summary

Shows the form as a modal dialog box with the specified owner.

##### Returns

One of the [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | Any object that implements
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window')
that represents the
top-level window that will own the modal dialog box. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The form specified in the `owner` parameter is the same
as the form being shown. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | The form being shown is already visible.
-or- The form being shown is disabled.
-or- The form being shown is not a top-level window.
-or- The form being shown as a dialog box is already a modal form.
-or- The current process is not running in user interactive mode (for
more information, see
[UserInteractive](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.SystemInformation.UserInteractive 'System.Windows.Forms.SystemInformation.UserInteractive')). |

<a name='T-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog'></a>
## IOperationDrivenProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a dialog box that
displays a marquee progress bar while an operation of indeterminate length
proceeds.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog-Argument'></a>
### Argument `property`

##### Summary

Gets or sets a reference to an object to be supplied to the code that is
executed by this dialog.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog-Proc'></a>
### Proc `property`

##### Summary

Gets or sets a [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func') delegate that refers to code to
be executed while the dialog is displayed.  When the code finishes, the dialog
is dismissed.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog-Result'></a>
### Result `property`

##### Summary

Gets a reference to an instance of an object that is supplied as the result of
the code that is executed by this dialog.

<a name='T-MFR-GUI-Dialogs-Interfaces-IOptionsDialog'></a>
## IOptionsDialog `type`

##### Namespace

MFR.GUI.Dialogs.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a dialog box that
allows the user to configure the application.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-AutoQuitOnCompletion'></a>
### AutoQuitOnCompletion `property`

##### Summary

Gets or sets the value of the
checkbox.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-CommitAuthorEmail'></a>
### CommitAuthorEmail `property`

##### Summary

Gets or sets the value of the text box in the
group box on the tab.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-CommitAuthorName'></a>
### CommitAuthorName `property`

##### Summary

Gets or sets the value of the text box in the
group box on the tab.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-ConfigPathname'></a>
### ConfigPathname `property`

##### Summary

Gets or sets the text of the configuration File Pathname text box.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-DontPromptUserToReloadOpenSolution'></a>
### DontPromptUserToReloadOpenSolution `property`

##### Summary

Gets or sets the value of the

checkbox

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-ErrantProcesses'></a>
### ErrantProcesses `property`

##### Summary

Gets a reference to a collection, each element of which implements the
[IErrantProcessInfo](#T-MFR-GUI-Models-Interfaces-IErrantProcessInfo 'MFR.GUI.Models.Interfaces.IErrantProcessInfo') interface,
representing the process(es), if running, that should be forcibly terminated
prior to the execution of the `Rename Files in Folder` and
`Rename Sub Folders` operations.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-HasErrantProcesses'></a>
### HasErrantProcesses `property`

##### Summary

Gets a value that indicates whether the user has configured more than zero
`Errant Process` entry(ies) in the list box.

##### Returns

`true` if there are more than zero
`Errant Process` entry(ies) in the list box;
`false` otherwise.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-IsErrantProcessSelected'></a>
### IsErrantProcessSelected `property`

##### Summary

Gets a value indicating whether an entry is currently selected in the
list box.

##### Returns

`true` if an entry is currently selected in the
list box; `false` otherwise.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-IsModified'></a>
### IsModified `property`

##### Summary

Gets a value that indicates whether the data in this dialog box has
been modified.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-PushChangesToRemoteWhenDone'></a>
### PushChangesToRemoteWhenDone `property`

##### Summary

Gets or sets the value of the checkbox.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-ReOpenSolution'></a>
### ReOpenSolution `property`

##### Summary

Gets or sets the value of the checkbox.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-SelectedErrantProcess'></a>
### SelectedErrantProcess `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IErrantProcessInfo](#T-MFR-GUI-Models-Interfaces-IErrantProcessInfo 'MFR.GUI.Models.Interfaces.IErrantProcessInfo') interface that
represents the item that is currently selected, if any, in the
list box on the tab.

##### Returns

If successful, a reference to an instance of an object that implements
the [IErrantProcessInfo](#T-MFR-GUI-Models-Interfaces-IErrantProcessInfo 'MFR.GUI.Models.Interfaces.IErrantProcessInfo') interface;
otherwise, a `null` reference is returned.

##### Remarks

If there are no items currently in the list box, or none are currently
selected, then this property returns a `null` reference.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-ShouldCommitPendingChanges'></a>
### ShouldCommitPendingChanges `property`

##### Summary

Gets or sets the value of the checkbox.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-ShouldCommitPostOperationChanges'></a>
### ShouldCommitPostOperationChanges `property`

##### Summary

Gets or sets the value of the 
checkbox.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-UpdateGitOnAutoStart'></a>
### UpdateGitOnAutoStart `property`

##### Summary

Gets or sets the value of the
checkbox.

<a name='T-MFR-GUI-Dialogs-Interfaces-IProfileNameDialog'></a>
## IProfileNameDialog `type`

##### Namespace

MFR.GUI.Dialogs.Interfaces

##### Summary

Defines the methods and properties of a New Profile Name dialog box.

<a name='P-MFR-GUI-Dialogs-Interfaces-IProfileNameDialog-OperationType'></a>
### OperationType `property`

##### Summary

Gets or sets the
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') value
that controls what type of profile-creation operation (e.g., New, Save As etc.)
is being done.

<a name='P-MFR-GUI-Dialogs-Interfaces-IProfileNameDialog-ProfileName'></a>
### ProfileName `property`

##### Summary

Gets or sets the value of the Profile Name text box.

<a name='T-MFR-GUI-Dialogs-Interfaces-IProgressDialog'></a>
## IProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a Progress Dialog.

<a name='P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-ProgressBar'></a>
### ProgressBar `property`

##### Summary

Gets a reference to the progress bar control.

<a name='P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-ProgressBarMaximum'></a>
### ProgressBarMaximum `property`

##### Summary

Gets or sets the maximum value of the range of the progress bar control.

<a name='P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-ProgressBarMinimum'></a>
### ProgressBarMinimum `property`

##### Summary

Get or sets the minimum value of the range of the progress bar control.

<a name='P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-ProgressBarStyle'></a>
### ProgressBarStyle `property`

##### Summary

Gets or sets the manner in which progress should

<a name='P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-ProgressBarValue'></a>
### ProgressBarValue `property`

##### Summary

Gets or sets the current position of the progress bar.

<a name='P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-Status'></a>
### Status `property`

##### Summary

Gets or sets a string containing the new status.

<a name='M-MFR-GUI-Dialogs-Interfaces-IProgressDialog-Reset'></a>
### Reset() `method`

##### Summary

Clears the status text and progress bar.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Dialogs.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Dialogs-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Dialogs-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
