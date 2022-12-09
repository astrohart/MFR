<a name='assembly'></a>
# MFR.GUI.Dialogs

## Contents

- [AboutDialog](#T-MFR-GUI-Dialogs-AboutDialog 'MFR.GUI.Dialogs.AboutDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-AboutDialog-#ctor 'MFR.GUI.Dialogs.AboutDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-AboutDialog-components 'MFR.GUI.Dialogs.AboutDialog.components')
  - [AssemblyCompany](#P-MFR-GUI-Dialogs-AboutDialog-AssemblyCompany 'MFR.GUI.Dialogs.AboutDialog.AssemblyCompany')
  - [AssemblyCopyright](#P-MFR-GUI-Dialogs-AboutDialog-AssemblyCopyright 'MFR.GUI.Dialogs.AboutDialog.AssemblyCopyright')
  - [AssemblyDescription](#P-MFR-GUI-Dialogs-AboutDialog-AssemblyDescription 'MFR.GUI.Dialogs.AboutDialog.AssemblyDescription')
  - [AssemblyProduct](#P-MFR-GUI-Dialogs-AboutDialog-AssemblyProduct 'MFR.GUI.Dialogs.AboutDialog.AssemblyProduct')
  - [AssemblyTitle](#P-MFR-GUI-Dialogs-AboutDialog-AssemblyTitle 'MFR.GUI.Dialogs.AboutDialog.AssemblyTitle')
  - [AssemblyVersion](#P-MFR-GUI-Dialogs-AboutDialog-AssemblyVersion 'MFR.GUI.Dialogs.AboutDialog.AssemblyVersion')
  - [Display(owner)](#M-MFR-GUI-Dialogs-AboutDialog-Display-System-Windows-Forms-IWin32Window- 'MFR.GUI.Dialogs.AboutDialog.Display(System.Windows.Forms.IWin32Window)')
  - [Dispose()](#M-MFR-GUI-Dialogs-AboutDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.AboutDialog.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-AboutDialog-InitializeComponent 'MFR.GUI.Dialogs.AboutDialog.InitializeComponent')
- [CancellableProgressDialog](#T-MFR-GUI-Dialogs-CancellableProgressDialog 'MFR.GUI.Dialogs.CancellableProgressDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-CancellableProgressDialog-#ctor 'MFR.GUI.Dialogs.CancellableProgressDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-CancellableProgressDialog-components 'MFR.GUI.Dialogs.CancellableProgressDialog.components')
  - [CanCancel](#P-MFR-GUI-Dialogs-CancellableProgressDialog-CanCancel 'MFR.GUI.Dialogs.CancellableProgressDialog.CanCancel')
  - [CurrentFile](#P-MFR-GUI-Dialogs-CancellableProgressDialog-CurrentFile 'MFR.GUI.Dialogs.CancellableProgressDialog.CurrentFile')
  - [ProgressBar](#P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBar 'MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBar')
  - [ProgressBarMaximum](#P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarMaximum 'MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarMaximum')
  - [ProgressBarMinimum](#P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarMinimum 'MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarMinimum')
  - [ProgressBarStyle](#P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarStyle 'MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarStyle')
  - [ProgressBarValue](#P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarValue 'MFR.GUI.Dialogs.CancellableProgressDialog.ProgressBarValue')
  - [Status](#P-MFR-GUI-Dialogs-CancellableProgressDialog-Status 'MFR.GUI.Dialogs.CancellableProgressDialog.Status')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-CancellableProgressDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.CancellableProgressDialog.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-CancellableProgressDialog-InitializeComponent 'MFR.GUI.Dialogs.CancellableProgressDialog.InitializeComponent')
  - [OnCancel(sender,e)](#M-MFR-GUI-Dialogs-CancellableProgressDialog-OnCancel-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.CancellableProgressDialog.OnCancel(System.Object,System.EventArgs)')
  - [OnCancelRequested()](#M-MFR-GUI-Dialogs-CancellableProgressDialog-OnCancelRequested 'MFR.GUI.Dialogs.CancellableProgressDialog.OnCancelRequested')
  - [OnLoad(e)](#M-MFR-GUI-Dialogs-CancellableProgressDialog-OnLoad-System-EventArgs- 'MFR.GUI.Dialogs.CancellableProgressDialog.OnLoad(System.EventArgs)')
  - [OnShown(e)](#M-MFR-GUI-Dialogs-CancellableProgressDialog-OnShown-System-EventArgs- 'MFR.GUI.Dialogs.CancellableProgressDialog.OnShown(System.EventArgs)')
  - [RedrawDisplay()](#M-MFR-GUI-Dialogs-CancellableProgressDialog-RedrawDisplay 'MFR.GUI.Dialogs.CancellableProgressDialog.RedrawDisplay')
  - [Reset()](#M-MFR-GUI-Dialogs-CancellableProgressDialog-Reset 'MFR.GUI.Dialogs.CancellableProgressDialog.Reset')
- [ErrorReportDialog](#T-MFR-GUI-Dialogs-ErrorReportDialog 'MFR.GUI.Dialogs.ErrorReportDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-ErrorReportDialog-#ctor 'MFR.GUI.Dialogs.ErrorReportDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-ErrorReportDialog-components 'MFR.GUI.Dialogs.ErrorReportDialog.components')
  - [ErrorReportContents](#P-MFR-GUI-Dialogs-ErrorReportDialog-ErrorReportContents 'MFR.GUI.Dialogs.ErrorReportDialog.ErrorReportContents')
  - [Exception](#P-MFR-GUI-Dialogs-ErrorReportDialog-Exception 'MFR.GUI.Dialogs.ErrorReportDialog.Exception')
  - [ReproductionSteps](#P-MFR-GUI-Dialogs-ErrorReportDialog-ReproductionSteps 'MFR.GUI.Dialogs.ErrorReportDialog.ReproductionSteps')
  - [ViewReportLinkLabel](#P-MFR-GUI-Dialogs-ErrorReportDialog-ViewReportLinkLabel 'MFR.GUI.Dialogs.ErrorReportDialog.ViewReportLinkLabel')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-ErrorReportDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.ErrorReportDialog.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-ErrorReportDialog-InitializeComponent 'MFR.GUI.Dialogs.ErrorReportDialog.InitializeComponent')
  - [OnClickSendReportButton(sender,e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnClickSendReportButton-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnClickSendReportButton(System.Object,System.EventArgs)')
  - [OnFormClosed(e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnFormClosed-System-Windows-Forms-FormClosedEventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnFormClosed(System.Windows.Forms.FormClosedEventArgs)')
  - [OnLinkClickedViewErrorReportLinkLabel(sender,e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnLinkClickedViewErrorReportLinkLabel-System-Object,System-Windows-Forms-LinkLabelLinkClickedEventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnLinkClickedViewErrorReportLinkLabel(System.Object,System.Windows.Forms.LinkLabelLinkClickedEventArgs)')
  - [OnLoad(e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnLoad-System-EventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnLoad(System.EventArgs)')
  - [OnSendErrorReportRequested(e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnSendErrorReportRequested-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnSendErrorReportRequested(MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs)')
  - [OnViewErrorReportRequested(e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnViewErrorReportRequested-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnViewErrorReportRequested(MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs)')
- [FolderSelectDialog](#T-MFR-GUI-Dialogs-FolderSelectDialog 'MFR.GUI.Dialogs.FolderSelectDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-FolderSelectDialog-#ctor 'MFR.GUI.Dialogs.FolderSelectDialog.#ctor')
  - [FileName](#P-MFR-GUI-Dialogs-FolderSelectDialog-FileName 'MFR.GUI.Dialogs.FolderSelectDialog.FileName')
  - [InitialDirectory](#P-MFR-GUI-Dialogs-FolderSelectDialog-InitialDirectory 'MFR.GUI.Dialogs.FolderSelectDialog.InitialDirectory')
  - [Title](#P-MFR-GUI-Dialogs-FolderSelectDialog-Title 'MFR.GUI.Dialogs.FolderSelectDialog.Title')
  - [Dispose()](#M-MFR-GUI-Dialogs-FolderSelectDialog-Dispose 'MFR.GUI.Dialogs.FolderSelectDialog.Dispose')
  - [InternalShowDialog()](#M-MFR-GUI-Dialogs-FolderSelectDialog-InternalShowDialog 'MFR.GUI.Dialogs.FolderSelectDialog.InternalShowDialog')
  - [InternalShowDialog(hWndOwner)](#M-MFR-GUI-Dialogs-FolderSelectDialog-InternalShowDialog-System-IntPtr- 'MFR.GUI.Dialogs.FolderSelectDialog.InternalShowDialog(System.IntPtr)')
  - [ShowDialog()](#M-MFR-GUI-Dialogs-FolderSelectDialog-ShowDialog 'MFR.GUI.Dialogs.FolderSelectDialog.ShowDialog')
  - [ShowDialog(owner)](#M-MFR-GUI-Dialogs-FolderSelectDialog-ShowDialog-System-Windows-Forms-IWin32Window- 'MFR.GUI.Dialogs.FolderSelectDialog.ShowDialog(System.Windows.Forms.IWin32Window)')
- [OperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-OperationDrivenProgressDialog 'MFR.GUI.Dialogs.OperationDrivenProgressDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-#ctor 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.#ctor')
  - [_worker](#F-MFR-GUI-Dialogs-OperationDrivenProgressDialog-_worker 'MFR.GUI.Dialogs.OperationDrivenProgressDialog._worker')
  - [components](#F-MFR-GUI-Dialogs-OperationDrivenProgressDialog-components 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.components')
  - [Argument](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Argument 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Argument')
  - [Proc](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Proc 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Proc')
  - [ProgressBar](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBar 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.ProgressBar')
  - [ProgressBarMaximum](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarMaximum 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.ProgressBarMaximum')
  - [ProgressBarMinimum](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarMinimum 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.ProgressBarMinimum')
  - [ProgressBarStyle](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarStyle 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.ProgressBarStyle')
  - [ProgressBarValue](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarValue 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.ProgressBarValue')
  - [Result](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Result 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Result')
  - [Status](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Status 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Status')
  - [Clear()](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Clear 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Clear')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Dispose(System.Boolean)')
  - [InitializeBackgroundWorker()](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-InitializeBackgroundWorker 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.InitializeBackgroundWorker')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-InitializeComponent 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.InitializeComponent')
  - [OnDoWork(sender,e)](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnDoWork-System-Object,System-ComponentModel-DoWorkEventArgs- 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.OnDoWork(System.Object,System.ComponentModel.DoWorkEventArgs)')
  - [OnLoad(e)](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnLoad-System-EventArgs- 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.OnLoad(System.EventArgs)')
  - [OnRunWorkerCompleted(sender,e)](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnRunWorkerCompleted-System-Object,System-ComponentModel-RunWorkerCompletedEventArgs- 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.OnRunWorkerCompleted(System.Object,System.ComponentModel.RunWorkerCompletedEventArgs)')
  - [OnShown(e)](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnShown-System-EventArgs- 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.OnShown(System.EventArgs)')
  - [RedrawDisplay()](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-RedrawDisplay 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.RedrawDisplay')
  - [Reset()](#M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Reset 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Reset')
- [OptionsDialog](#T-MFR-GUI-Dialogs-OptionsDialog 'MFR.GUI.Dialogs.OptionsDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-OptionsDialog-#ctor 'MFR.GUI.Dialogs.OptionsDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-OptionsDialog-components 'MFR.GUI.Dialogs.OptionsDialog.components')
  - [ConfigPathname](#P-MFR-GUI-Dialogs-OptionsDialog-ConfigPathname 'MFR.GUI.Dialogs.OptionsDialog.ConfigPathname')
  - [ConfigurationProvider](#P-MFR-GUI-Dialogs-OptionsDialog-ConfigurationProvider 'MFR.GUI.Dialogs.OptionsDialog.ConfigurationProvider')
  - [IsModified](#P-MFR-GUI-Dialogs-OptionsDialog-IsModified 'MFR.GUI.Dialogs.OptionsDialog.IsModified')
  - [ShouldReOpenVisualStudioSolution](#P-MFR-GUI-Dialogs-OptionsDialog-ShouldReOpenVisualStudioSolution 'MFR.GUI.Dialogs.OptionsDialog.ShouldReOpenVisualStudioSolution')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-OptionsDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.OptionsDialog.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-OptionsDialog-InitializeComponent 'MFR.GUI.Dialogs.OptionsDialog.InitializeComponent')
  - [OnClickApply(sender,e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnClickApply-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnClickApply(System.Object,System.EventArgs)')
  - [OnClickConfigPathnameBrowseButton(sender,e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnClickConfigPathnameBrowseButton-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnClickConfigPathnameBrowseButton(System.Object,System.EventArgs)')
  - [OnModified(e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnModified-MFR-GUI-Dialogs-Events-ModifiedEventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnModified(MFR.GUI.Dialogs.Events.ModifiedEventArgs)')
  - [OnShown(e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnShown-System-EventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnShown(System.EventArgs)')
  - [OnTextChangedConfiguraitonFilePathname(sender,e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnTextChangedConfiguraitonFilePathname-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnTextChangedConfiguraitonFilePathname(System.Object,System.EventArgs)')
  - [OnUpdateCmdUI(sender,e)](#M-MFR-GUI-Dialogs-OptionsDialog-OnUpdateCmdUI-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.OptionsDialog.OnUpdateCmdUI(System.Object,System.EventArgs)')
  - [SetModifiedFlag(dirty)](#M-MFR-GUI-Dialogs-OptionsDialog-SetModifiedFlag-System-Boolean- 'MFR.GUI.Dialogs.OptionsDialog.SetModifiedFlag(System.Boolean)')
- [ProfileManagementDialogBox](#T-MFR-GUI-Dialogs-ProfileManagementDialogBox 'MFR.GUI.Dialogs.ProfileManagementDialogBox')
  - [#ctor()](#M-MFR-GUI-Dialogs-ProfileManagementDialogBox-#ctor 'MFR.GUI.Dialogs.ProfileManagementDialogBox.#ctor')
  - [components](#F-MFR-GUI-Dialogs-ProfileManagementDialogBox-components 'MFR.GUI.Dialogs.ProfileManagementDialogBox.components')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-ProfileManagementDialogBox-Dispose-System-Boolean- 'MFR.GUI.Dialogs.ProfileManagementDialogBox.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-ProfileManagementDialogBox-InitializeComponent 'MFR.GUI.Dialogs.ProfileManagementDialogBox.InitializeComponent')
- [ProfileNameDialog](#T-MFR-GUI-Dialogs-ProfileNameDialog 'MFR.GUI.Dialogs.ProfileNameDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-ProfileNameDialog-#ctor 'MFR.GUI.Dialogs.ProfileNameDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-ProfileNameDialog-components 'MFR.GUI.Dialogs.ProfileNameDialog.components')
  - [OperationType](#P-MFR-GUI-Dialogs-ProfileNameDialog-OperationType 'MFR.GUI.Dialogs.ProfileNameDialog.OperationType')
  - [ProfileName](#P-MFR-GUI-Dialogs-ProfileNameDialog-ProfileName 'MFR.GUI.Dialogs.ProfileNameDialog.ProfileName')
  - [ProfileProvider](#P-MFR-GUI-Dialogs-ProfileNameDialog-ProfileProvider 'MFR.GUI.Dialogs.ProfileNameDialog.ProfileProvider')
  - [CanClose()](#M-MFR-GUI-Dialogs-ProfileNameDialog-CanClose 'MFR.GUI.Dialogs.ProfileNameDialog.CanClose')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-ProfileNameDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.ProfileNameDialog.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-ProfileNameDialog-InitializeComponent 'MFR.GUI.Dialogs.ProfileNameDialog.InitializeComponent')
  - [OnClickReadMoreAboutProfilesLinkLabel(sender,e)](#M-MFR-GUI-Dialogs-ProfileNameDialog-OnClickReadMoreAboutProfilesLinkLabel-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.ProfileNameDialog.OnClickReadMoreAboutProfilesLinkLabel(System.Object,System.EventArgs)')
  - [OnFormClosing(e)](#M-MFR-GUI-Dialogs-ProfileNameDialog-OnFormClosing-System-Windows-Forms-FormClosingEventArgs- 'MFR.GUI.Dialogs.ProfileNameDialog.OnFormClosing(System.Windows.Forms.FormClosingEventArgs)')
  - [OnLoad(e)](#M-MFR-GUI-Dialogs-ProfileNameDialog-OnLoad-System-EventArgs- 'MFR.GUI.Dialogs.ProfileNameDialog.OnLoad(System.EventArgs)')
- [Resources](#T-MFR-GUI-Dialogs-Properties-Resources 'MFR.GUI.Dialogs.Properties.Resources')
  - [Culture](#P-MFR-GUI-Dialogs-Properties-Resources-Culture 'MFR.GUI.Dialogs.Properties.Resources.Culture')
  - [FolderSelectDialogFIlters](#P-MFR-GUI-Dialogs-Properties-Resources-FolderSelectDialogFIlters 'MFR.GUI.Dialogs.Properties.Resources.FolderSelectDialogFIlters')
  - [ResourceManager](#P-MFR-GUI-Dialogs-Properties-Resources-ResourceManager 'MFR.GUI.Dialogs.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Dialogs-AboutDialog'></a>
## AboutDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Dialog box that displays information about this application to the user.

<a name='M-MFR-GUI-Dialogs-AboutDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [AboutDialog](#T-MFR-GUI-Dialogs-AboutDialog 'MFR.GUI.Dialogs.AboutDialog') and returns a reference
to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-AboutDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-AboutDialog-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets the name of the company that produced this software.

<a name='P-MFR-GUI-Dialogs-AboutDialog-AssemblyCopyright'></a>
### AssemblyCopyright `property`

##### Summary

Gets the copyright string for this application.

<a name='P-MFR-GUI-Dialogs-AboutDialog-AssemblyDescription'></a>
### AssemblyDescription `property`

##### Summary

Gets the description of this application.

<a name='P-MFR-GUI-Dialogs-AboutDialog-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets the product name of the application.

<a name='P-MFR-GUI-Dialogs-AboutDialog-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets the title string for this application.

<a name='P-MFR-GUI-Dialogs-AboutDialog-AssemblyVersion'></a>
### AssemblyVersion `property`

##### Summary

Gets the full version of the application.

<a name='M-MFR-GUI-Dialogs-AboutDialog-Display-System-Windows-Forms-IWin32Window-'></a>
### Display(owner) `method`

##### Summary

Displays this dialog box and does not return until the user has
dismissed it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Optional.) Reference to an instance of an object that implements
the [IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface and
which represents the parent window of this dialog box. |

<a name='M-MFR-GUI-Dialogs-AboutDialog-Dispose-System-Boolean-'></a>
### Dispose() `method`

##### Summary

Clean up any resources being used.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-AboutDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-CancellableProgressDialog'></a>
## CancellableProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Window that displays progress of an operation.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[CancellableProgressDialog](#T-MFR-GUI-Dialogs-CancellableProgressDialog 'MFR.GUI.Dialogs.CancellableProgressDialog')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-CancellableProgressDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-CanCancel'></a>
### CanCancel `property`

##### Summary

Gets or sets a value indicating whether the operation can be cancelled.

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-CurrentFile'></a>
### CurrentFile `property`

##### Summary

Gets or sets a string containing the new detailed status.

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBar'></a>
### ProgressBar `property`

##### Summary

Gets a reference to the progress bar control.

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarMaximum'></a>
### ProgressBarMaximum `property`

##### Summary

Gets or sets the maximum value of the range of the progress bar control.

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarMinimum'></a>
### ProgressBarMinimum `property`

##### Summary

Get or sets the minimum value of the range of the progress bar control.

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarStyle'></a>
### ProgressBarStyle `property`

##### Summary

Gets or sets the manner in which progress should

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-ProgressBarValue'></a>
### ProgressBarValue `property`

##### Summary

Gets or sets the current position of the progress bar.

<a name='P-MFR-GUI-Dialogs-CancellableProgressDialog-Status'></a>
### Status `property`

##### Summary

Gets or sets a string containing the new status.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-OnCancel-System-Object,System-EventArgs-'></a>
### OnCancel(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event
for the Cancel button.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called when the user chooses the Cancel button or
presses the ESCAPE key. This method responds merely by raising the
[](#E-MFR-GUI-CancellableProgressDialog-CancelRequested 'MFR.GUI.CancellableProgressDialog.CancelRequested')
event. This event directs the caller of this dialog box to attempt
to abort the operation and close down this dialog box from its GUI thread.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-OnCancelRequested'></a>
### OnCancelRequested() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Dialogs-CancellableProgressDialog-CancelRequested 'MFR.GUI.Dialogs.CancellableProgressDialog.CancelRequested')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method sets the title of the dialog to match the application's name.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-OnShown-System-EventArgs-'></a>
### OnShown(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Shown 'System.Windows.Forms.Form.Shown') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-RedrawDisplay'></a>
### RedrawDisplay() `method`

##### Summary

Directs the application to update the user's display.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-CancellableProgressDialog-Reset'></a>
### Reset() `method`

##### Summary

Clears the status text and progress bar.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-ErrorReportDialog'></a>
## ErrorReportDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Displays information to the user about an exception or error.

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ErrorReportDialog](#T-MFR-GUI-Dialogs-ErrorReportDialog 'MFR.GUI.Dialogs.ErrorReportDialog')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-ErrorReportDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-ErrorReportDialog-ErrorReportContents'></a>
### ErrorReportContents `property`

##### Summary

Gets a string that contains the contents of an error report, given the value of
the [Exception](#P-MFR-GUI-Dialogs-ErrorReportDialog-Exception 'MFR.GUI.Dialogs.ErrorReportDialog.Exception') property.

<a name='P-MFR-GUI-Dialogs-ErrorReportDialog-Exception'></a>
### Exception `property`

##### Summary

Gets or sets the [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes the error
that occurred.

<a name='P-MFR-GUI-Dialogs-ErrorReportDialog-ReproductionSteps'></a>
### ReproductionSteps `property`

##### Summary

Gets or sets the value of the Reproduction Steps text box.

<a name='P-MFR-GUI-Dialogs-ErrorReportDialog-ViewReportLinkLabel'></a>
### ViewReportLinkLabel `property`

##### Summary

Gets a reference to the View Report link-label control.

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-OnClickSendReportButton-System-Object,System-EventArgs-'></a>
### OnClickSendReportButton(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event raised by
the Send Report button.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method responds by raising the
[](#E-MFR-GUI-Dialogs-ErrorReportDialog-SendErrorReportRequested 'MFR.GUI.Dialogs.ErrorReportDialog.SendErrorReportRequested')
event.



Doing so allows the invoker of this dialog to decide how to carry out the
action.

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-OnFormClosed-System-Windows-Forms-FormClosedEventArgs-'></a>
### OnFormClosed(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-FormClosed 'System.Windows.Forms.Form.FormClosed') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Windows.Forms.FormClosedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosedEventArgs 'System.Windows.Forms.FormClosedEventArgs') | A [FormClosedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosedEventArgs 'System.Windows.Forms.FormClosedEventArgs') that
contains the event data. |

##### Remarks

This override forcibly terminates the application by calling
[Exit](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Environment.Exit 'System.Environment.Exit')
with an exit code of `-1`.

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-OnLinkClickedViewErrorReportLinkLabel-System-Object,System-Windows-Forms-LinkLabelLinkClickedEventArgs-'></a>
### OnLinkClickedViewErrorReportLinkLabel(sender,e) `method`

##### Summary

Handles the
[](#E-System-Windows-Forms-LinkLabel-LinkClicked 'System.Windows.Forms.LinkLabel.LinkClicked')
event raised
by the View Report hyperlink.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.Windows.Forms.LinkLabelLinkClickedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.LinkLabelLinkClickedEventArgs 'System.Windows.Forms.LinkLabelLinkClickedEventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds by raising the
[](#E-MFR-GUI-Dialogs-ErrorReportDialog-ViewErrorReportRequested 'MFR.GUI.Dialogs.ErrorReportDialog.ViewErrorReportRequested')
event.



Doing this allows the caller of this dialog to attach their own custom
event-handling logic.

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-OnSendErrorReportRequested-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-'></a>
### OnSendErrorReportRequested(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-Dialogs-ErrorReportDialog-SendErrorReportRequested 'MFR.GUI.Dialogs.ErrorReportDialog.SendErrorReportRequested')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs') | A [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that contains the event
data. |

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-OnViewErrorReportRequested-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs-'></a>
### OnViewErrorReportRequested(e) `method`

##### Summary

Raises the
[](#E-MFR-GUI-Dialogs-ErrorReportDialog-ViewErrorReportRequested 'MFR.GUI.Dialogs.ErrorReportDialog.ViewErrorReportRequested')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs') | A
[ViewErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs') that
contains the event data. |

<a name='T-MFR-GUI-Dialogs-FolderSelectDialog'></a>
## FolderSelectDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Wraps System.Windows.Forms.OpenFileDialog to make it present a
vista-style Folder Select dialog.

<a name='M-MFR-GUI-Dialogs-FolderSelectDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs an instance of [FolderSelectDialog](#T-MFR-GUI-Dialogs-FolderSelectDialog 'MFR.GUI.Dialogs.FolderSelectDialog')
and returns a
reference to the new instance.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-GUI-Dialogs-FolderSelectDialog-FileName'></a>
### FileName `property`

##### Summary

Gets the selected folder

<a name='P-MFR-GUI-Dialogs-FolderSelectDialog-InitialDirectory'></a>
### InitialDirectory `property`

##### Summary

Gets/Sets the initial folder to be selected. A null value selects
the current directory.

<a name='P-MFR-GUI-Dialogs-FolderSelectDialog-Title'></a>
### Title `property`

##### Summary

Gets/Sets the title to show in the dialog

<a name='M-MFR-GUI-Dialogs-FolderSelectDialog-Dispose'></a>
### Dispose() `method`

##### Summary

Performs application-defined tasks associated with freeing,
releasing, or resetting unmanaged resources.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-FolderSelectDialog-InternalShowDialog'></a>
### InternalShowDialog() `method`

##### Summary

Shows the dialog.

##### Returns

`true` if the user presses OK else `false`.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-FolderSelectDialog-InternalShowDialog-System-IntPtr-'></a>
### InternalShowDialog(hWndOwner) `method`

##### Summary

Shows this [FolderSelectDialog](#T-MFR-GUI-Dialogs-FolderSelectDialog 'MFR.GUI.Dialogs.FolderSelectDialog') to the user to
allow
the user to select a folder on their computer. Returns a value
indicating whether the dialog ended with the OK or Cancel button
being clicked.

##### Returns

`true` if the user presses OK else `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hWndOwner | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | Handle of the control to be parent |

<a name='M-MFR-GUI-Dialogs-FolderSelectDialog-ShowDialog'></a>
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

<a name='M-MFR-GUI-Dialogs-FolderSelectDialog-ShowDialog-System-Windows-Forms-IWin32Window-'></a>
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

<a name='T-MFR-GUI-Dialogs-OperationDrivenProgressDialog'></a>
## OperationDrivenProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Progress dialog that always displays a Marquee progress bar during an
operation.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[OperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-OperationDrivenProgressDialog 'MFR.GUI.Dialogs.OperationDrivenProgressDialog') and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-OperationDrivenProgressDialog-_worker'></a>
### _worker `constants`

##### Summary

A [BackgroundWorker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.BackgroundWorker 'System.ComponentModel.BackgroundWorker') that manages the work
done by this Progress Dialog's work.

<a name='F-MFR-GUI-Dialogs-OperationDrivenProgressDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Argument'></a>
### Argument `property`

##### Summary

Gets or sets a reference to an object to be supplied to the code that is
executed by this dialog.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Proc'></a>
### Proc `property`

##### Summary

Gets or sets a [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func') delegate, taking an object as a
parameter and returning an object as a result, that refers to code to be
executed while the dialog is displayed.  When the code finishes, the dialog is
dismissed.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBar'></a>
### ProgressBar `property`

##### Summary

Gets a reference to the progress bar control.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarMaximum'></a>
### ProgressBarMaximum `property`

##### Summary

Gets or sets the maximum value of the range of the progress bar control.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarMinimum'></a>
### ProgressBarMinimum `property`

##### Summary

Get or sets the minimum value of the range of the progress bar control.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarStyle'></a>
### ProgressBarStyle `property`

##### Summary

Gets or sets the manner in which progress should

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-ProgressBarValue'></a>
### ProgressBarValue `property`

##### Summary

Gets or sets the current position of the progress bar.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Result'></a>
### Result `property`

##### Summary

Gets a reference to an instance of an object that is supplied as the result of
the code that is executed by this dialog.

<a name='P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Status'></a>
### Status `property`

##### Summary

Gets or sets a string containing the new status.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Clear'></a>
### Clear() `method`

##### Summary

Resets all properties to their default values.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-InitializeBackgroundWorker'></a>
### InitializeBackgroundWorker() `method`

##### Summary

Initializes the internal
[BackgroundWorker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.BackgroundWorker 'System.ComponentModel.BackgroundWorker') object.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnDoWork-System-Object,System-ComponentModel-DoWorkEventArgs-'></a>
### OnDoWork(sender,e) `method`

##### Summary

Handles the [](#E-System-ComponentModel-BackgroundWorker-DoWork 'System.ComponentModel.BackgroundWorker.DoWork')
event raised by the internal background worker managed by this dialog box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.ComponentModel.DoWorkEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DoWorkEventArgs 'System.ComponentModel.DoWorkEventArgs') | A [DoWorkEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DoWorkEventArgs 'System.ComponentModel.DoWorkEventArgs') that
contains the event data. |

##### Remarks

This method runs the code referred to by the contents of the delegate
referred to by the
[Proc](#P-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Proc 'MFR.GUI.Dialogs.OperationDrivenProgressDialog.Proc') property.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnRunWorkerCompleted-System-Object,System-ComponentModel-RunWorkerCompletedEventArgs-'></a>
### OnRunWorkerCompleted(sender,e) `method`

##### Summary

Handles the
[](#E-System-ComponentModel-BackgroundWorker-RunWorkerCompleted 'System.ComponentModel.BackgroundWorker.RunWorkerCompleted')
event raised by the internal background worker thread managed by this dialog
box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.ComponentModel.RunWorkerCompletedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.RunWorkerCompletedEventArgs 'System.ComponentModel.RunWorkerCompletedEventArgs') | A
[RunWorkerCompletedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.RunWorkerCompletedEventArgs 'System.ComponentModel.RunWorkerCompletedEventArgs') that
contains the event data. |

##### Remarks

This method responds by gathering the result of the operation and then
dismissing the dialog box.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-OnShown-System-EventArgs-'></a>
### OnShown(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Shown 'System.Windows.Forms.Form.Shown') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-RedrawDisplay'></a>
### RedrawDisplay() `method`

##### Summary

Directs the application to update the user's display.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-OperationDrivenProgressDialog-Reset'></a>
### Reset() `method`

##### Summary

Clears the status text and progress bar.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-OptionsDialog'></a>
## OptionsDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Provides options to the user that allow the user to modify the
application's behavior.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[OptionsDialog](#T-MFR-GUI-Dialogs-OptionsDialog 'MFR.GUI.Dialogs.OptionsDialog')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-OptionsDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-ConfigPathname'></a>
### ConfigPathname `property`

##### Summary

Gets or sets the text of the ProjectFileRenamerConfiguration File Pathname text box.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-ConfigurationProvider'></a>
### ConfigurationProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IConfigurationProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider')
interface.

##### Remarks

This object allows access to the user projectFileRenamerConfiguration and the actions
associated with it.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-IsModified'></a>
### IsModified `property`

##### Summary

Gets a value that indicates whether the data in this dialog box has
been modified.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-ShouldReOpenVisualStudioSolution'></a>
### ShouldReOpenVisualStudioSolution `property`

##### Summary

Gets or sets the value of the Reopen Visual Studio Solution checkbox

<a name='M-MFR-GUI-Dialogs-OptionsDialog-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-OptionsDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnClickApply-System-Object,System-EventArgs-'></a>
### OnClickApply(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called in response to the user clicking the Apply
button. We merely raise the
[](#E-MFR-GUI-OptionsDialog-Modified 'MFR.GUI.OptionsDialog.Modified')
event in order to prompt
the client of this dialog box to update data.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnClickConfigPathnameBrowseButton-System-Object,System-EventArgs-'></a>
### OnClickConfigPathnameBrowseButton(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event
for the Browse button on the ProjectFileRenamerConfiguration File Pathname text box..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to a click of the '...' button that lies next
to the text box that accepts the pathname of the application's
projectFileRenamerConfiguration file.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnModified-MFR-GUI-Dialogs-Events-ModifiedEventArgs-'></a>
### OnModified(e) `method`

##### Summary

Raises the [](#E-MFR-GUI-OptionsDialog-Modified 'MFR.GUI.OptionsDialog.Modified') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.GUI.Dialogs.Events.ModifiedEventArgs](#T-MFR-GUI-Dialogs-Events-ModifiedEventArgs 'MFR.GUI.Dialogs.Events.ModifiedEventArgs') | A [ModifiedEventArgs](#T-MFR-ModifiedEventArgs 'MFR.ModifiedEventArgs') that contains the
event data. |

##### Remarks

If the [Handled](#P-MFR-ModifiedEventArgs-Handled 'MFR.ModifiedEventArgs.Handled')
property is set `true` by the event's handler, then
the [IsModified](#P-MFR-GUI-OptionsDialog-IsModified 'MFR.GUI.OptionsDialog.IsModified') will be set to
`false`.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnShown-System-EventArgs-'></a>
### OnShown(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Shown 'System.Windows.Forms.Form.Shown') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnTextChangedConfiguraitonFilePathname-System-Object,System-EventArgs-'></a>
### OnTextChangedConfiguraitonFilePathname(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-TextChanged 'System.Windows.Forms.Control.TextChanged') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called to respond to the value of the text inside the
ProjectFileRenamerConfiguration File Pathname text box being changed. This method
responds to such a happenstance by updating the value of the
[IsModified](#P-MFR-GUI-OptionsDialog-IsModified 'MFR.GUI.OptionsDialog.IsModified')
property to be
`true`
by calling the
[SetModifiedFlag](#M-MFR-GUI-OptionsDialog-SetModifiedFlag 'MFR.GUI.OptionsDialog.SetModifiedFlag')
method.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnUpdateCmdUI-System-Object,System-EventArgs-'></a>
### OnUpdateCmdUI(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Application-Idle 'System.Windows.Forms.Application.Idle') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method is called to update the enabled or disabled state of controls.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-SetModifiedFlag-System-Boolean-'></a>
### SetModifiedFlag(dirty) `method`

##### Summary

Sets the dirty state of the data of this dialog box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dirty | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set to `true` to indicate data has changed;
`false`
otherwise. Default is `true`. |

<a name='T-MFR-GUI-Dialogs-ProfileManagementDialogBox'></a>
## ProfileManagementDialogBox `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Dialog box to assist the user in managing projectFileRenamerConfiguration profiles.

<a name='M-MFR-GUI-Dialogs-ProfileManagementDialogBox-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ProfileManagementDialogBox](#T-MFR-GUI-Dialogs-ProfileManagementDialogBox 'MFR.GUI.Dialogs.ProfileManagementDialogBox') and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-ProfileManagementDialogBox-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-MFR-GUI-Dialogs-ProfileManagementDialogBox-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-ProfileManagementDialogBox-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-ProfileNameDialog'></a>
## ProfileNameDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Displayed to the user to allow the user to create a blank profile with a given
name and/or save a profile.

<a name='M-MFR-GUI-Dialogs-ProfileNameDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ProfileNameDialog](#T-MFR-GUI-Dialogs-ProfileNameDialog 'MFR.GUI.Dialogs.ProfileNameDialog') and returns a reference
to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-ProfileNameDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-ProfileNameDialog-OperationType'></a>
### OperationType `property`

##### Summary

Gets or sets the
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') value
that controls what type of profile-creation operation (e.g., New, Save As etc.)
is being done.

<a name='P-MFR-GUI-Dialogs-ProfileNameDialog-ProfileName'></a>
### ProfileName `property`

##### Summary

Gets or sets the value of the Profile Name text box.

<a name='P-MFR-GUI-Dialogs-ProfileNameDialog-ProfileProvider'></a>
### ProfileProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProfileProvider](#T-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider')
interface.

<a name='M-MFR-GUI-Dialogs-ProfileNameDialog-CanClose'></a>
### CanClose() `method`

##### Summary

Determines whether this dialog can be closed.



Whether or not this is the case, depends on several factors; for instance,
whether the input is valid.



If validation rules fail, then the user is presented with an error message box
telling them what to do.



If the dialog box's `Cancel` button is clicked, or the
`ESC` key is pressed on the keyboard, then this method always returns
`true`.

##### Returns

`true` if the dialog is allowed to be closed;
`false` otherwise.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-ProfileNameDialog-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-ProfileNameDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-ProfileNameDialog-OnClickReadMoreAboutProfilesLinkLabel-System-Object,System-EventArgs-'></a>
### OnClickReadMoreAboutProfilesLinkLabel(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event raised by
the Read More About Profiles link label.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method is called when the user clicks the
link.



The default action is to bring up a Help window that describes profiles and
what can be done with them.

<a name='M-MFR-GUI-Dialogs-ProfileNameDialog-OnFormClosing-System-Windows-Forms-FormClosingEventArgs-'></a>
### OnFormClosing(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-FormClosing 'System.Windows.Forms.Form.FormClosing')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Windows.Forms.FormClosingEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosingEventArgs 'System.Windows.Forms.FormClosingEventArgs') | A [FormClosingEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.FormClosingEventArgs 'System.Windows.Forms.FormClosingEventArgs')
that contains the event data. |

<a name='M-MFR-GUI-Dialogs-ProfileNameDialog-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='T-MFR-GUI-Dialogs-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Dialogs.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Dialogs-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Dialogs-Properties-Resources-FolderSelectDialogFIlters'></a>
### FolderSelectDialogFIlters `property`

##### Summary

Looks up a localized string similar to Folders|.

<a name='P-MFR-GUI-Dialogs-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
