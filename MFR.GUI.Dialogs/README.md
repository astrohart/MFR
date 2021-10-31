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
- [ErrorReportDialog](#T-MFR-GUI-Dialogs-ErrorReportDialog 'MFR.GUI.Dialogs.ErrorReportDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-ErrorReportDialog-#ctor 'MFR.GUI.Dialogs.ErrorReportDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-ErrorReportDialog-components 'MFR.GUI.Dialogs.ErrorReportDialog.components')
  - [Exception](#P-MFR-GUI-Dialogs-ErrorReportDialog-Exception 'MFR.GUI.Dialogs.ErrorReportDialog.Exception')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-ErrorReportDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.ErrorReportDialog.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-ErrorReportDialog-InitializeComponent 'MFR.GUI.Dialogs.ErrorReportDialog.InitializeComponent')
  - [OnFormClosed(e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnFormClosed-System-Windows-Forms-FormClosedEventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnFormClosed(System.Windows.Forms.FormClosedEventArgs)')
  - [OnLinkClickedViewErrorReportLinkLabel(sender,e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnLinkClickedViewErrorReportLinkLabel-System-Object,System-Windows-Forms-LinkLabelLinkClickedEventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnLinkClickedViewErrorReportLinkLabel(System.Object,System.Windows.Forms.LinkLabelLinkClickedEventArgs)')
  - [OnLoad(e)](#M-MFR-GUI-Dialogs-ErrorReportDialog-OnLoad-System-EventArgs- 'MFR.GUI.Dialogs.ErrorReportDialog.OnLoad(System.EventArgs)')
- [FolderSelectDialog](#T-MFR-GUI-Dialogs-FolderSelectDialog 'MFR.GUI.Dialogs.FolderSelectDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-FolderSelectDialog-#ctor 'MFR.GUI.Dialogs.FolderSelectDialog.#ctor')
  - [FileName](#P-MFR-GUI-Dialogs-FolderSelectDialog-FileName 'MFR.GUI.Dialogs.FolderSelectDialog.FileName')
  - [InitialDirectory](#P-MFR-GUI-Dialogs-FolderSelectDialog-InitialDirectory 'MFR.GUI.Dialogs.FolderSelectDialog.InitialDirectory')
  - [Title](#P-MFR-GUI-Dialogs-FolderSelectDialog-Title 'MFR.GUI.Dialogs.FolderSelectDialog.Title')
  - [Dispose()](#M-MFR-GUI-Dialogs-FolderSelectDialog-Dispose 'MFR.GUI.Dialogs.FolderSelectDialog.Dispose')
  - [ShowDialog()](#M-MFR-GUI-Dialogs-FolderSelectDialog-ShowDialog 'MFR.GUI.Dialogs.FolderSelectDialog.ShowDialog')
  - [ShowDialog(hWndOwner)](#M-MFR-GUI-Dialogs-FolderSelectDialog-ShowDialog-System-IntPtr- 'MFR.GUI.Dialogs.FolderSelectDialog.ShowDialog(System.IntPtr)')
- [OptionsDialog](#T-MFR-GUI-Dialogs-OptionsDialog 'MFR.GUI.Dialogs.OptionsDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-OptionsDialog-#ctor 'MFR.GUI.Dialogs.OptionsDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-OptionsDialog-components 'MFR.GUI.Dialogs.OptionsDialog.components')
  - [ConfigPathname](#P-MFR-GUI-Dialogs-OptionsDialog-ConfigPathname 'MFR.GUI.Dialogs.OptionsDialog.ConfigPathname')
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
- [ProgressDialog](#T-MFR-GUI-Dialogs-ProgressDialog 'MFR.GUI.Dialogs.ProgressDialog')
  - [#ctor()](#M-MFR-GUI-Dialogs-ProgressDialog-#ctor 'MFR.GUI.Dialogs.ProgressDialog.#ctor')
  - [components](#F-MFR-GUI-Dialogs-ProgressDialog-components 'MFR.GUI.Dialogs.ProgressDialog.components')
  - [CurrentFile](#P-MFR-GUI-Dialogs-ProgressDialog-CurrentFile 'MFR.GUI.Dialogs.ProgressDialog.CurrentFile')
  - [ProgressBar](#P-MFR-GUI-Dialogs-ProgressDialog-ProgressBar 'MFR.GUI.Dialogs.ProgressDialog.ProgressBar')
  - [ProgressBarMaximum](#P-MFR-GUI-Dialogs-ProgressDialog-ProgressBarMaximum 'MFR.GUI.Dialogs.ProgressDialog.ProgressBarMaximum')
  - [ProgressBarMinimum](#P-MFR-GUI-Dialogs-ProgressDialog-ProgressBarMinimum 'MFR.GUI.Dialogs.ProgressDialog.ProgressBarMinimum')
  - [ProgressBarStyle](#P-MFR-GUI-Dialogs-ProgressDialog-ProgressBarStyle 'MFR.GUI.Dialogs.ProgressDialog.ProgressBarStyle')
  - [ProgressBarValue](#P-MFR-GUI-Dialogs-ProgressDialog-ProgressBarValue 'MFR.GUI.Dialogs.ProgressDialog.ProgressBarValue')
  - [Status](#P-MFR-GUI-Dialogs-ProgressDialog-Status 'MFR.GUI.Dialogs.ProgressDialog.Status')
  - [Dispose(disposing)](#M-MFR-GUI-Dialogs-ProgressDialog-Dispose-System-Boolean- 'MFR.GUI.Dialogs.ProgressDialog.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MFR-GUI-Dialogs-ProgressDialog-InitializeComponent 'MFR.GUI.Dialogs.ProgressDialog.InitializeComponent')
  - [OnCancel(sender,e)](#M-MFR-GUI-Dialogs-ProgressDialog-OnCancel-System-Object,System-EventArgs- 'MFR.GUI.Dialogs.ProgressDialog.OnCancel(System.Object,System.EventArgs)')
  - [OnCancelRequested()](#M-MFR-GUI-Dialogs-ProgressDialog-OnCancelRequested 'MFR.GUI.Dialogs.ProgressDialog.OnCancelRequested')
  - [OnLoad(e)](#M-MFR-GUI-Dialogs-ProgressDialog-OnLoad-System-EventArgs- 'MFR.GUI.Dialogs.ProgressDialog.OnLoad(System.EventArgs)')
  - [RedrawDisplay()](#M-MFR-GUI-Dialogs-ProgressDialog-RedrawDisplay 'MFR.GUI.Dialogs.ProgressDialog.RedrawDisplay')
  - [Reset()](#M-MFR-GUI-Dialogs-ProgressDialog-Reset 'MFR.GUI.Dialogs.ProgressDialog.Reset')
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

<a name='P-MFR-GUI-Dialogs-ErrorReportDialog-Exception'></a>
### Exception `property`

##### Summary

Gets or sets the [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes the error that occurred.

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

This method responds by dumping the current
[Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception')
's message and stack trace to a text file
in the user's temporary files folder, and then launches Notepad to
view it.

<a name='M-MFR-GUI-Dialogs-ErrorReportDialog-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

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

Constructs an instance of [FolderSelectDialog](#T-FolderSelectDialog 'FolderSelectDialog') and returns a
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

<a name='M-MFR-GUI-Dialogs-FolderSelectDialog-ShowDialog'></a>
### ShowDialog() `method`

##### Summary

Shows the dialog

##### Returns

True if the user presses OK else false

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-FolderSelectDialog-ShowDialog-System-IntPtr-'></a>
### ShowDialog(hWndOwner) `method`

##### Summary

Shows this [FolderSelectDialog](#T-FolderSelectDialog 'FolderSelectDialog') to the user to allow
the user to select a folder on their computer. Returns a value
indicating whether the dialog ended with the OK or Cancel button
being clicked.

##### Returns

True if the user presses OK else false

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hWndOwner | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | Handle of the control to be parent |

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

Constructs a new instance of [OptionsDialog](#T-MFR-GUI-Dialogs-OptionsDialog 'MFR.GUI.Dialogs.OptionsDialog') and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-OptionsDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-OptionsDialog-ConfigPathname'></a>
### ConfigPathname `property`

##### Summary

Gets or sets the text of the Configuration File Pathname text box.

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
button. We merely raise the [](#E-MFR-GUI-OptionsDialog-Modified 'MFR.GUI.OptionsDialog.Modified') event in order to prompt
the client of this dialog box to update data.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnClickConfigPathnameBrowseButton-System-Object,System-EventArgs-'></a>
### OnClickConfigPathnameBrowseButton(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event
for the Browse button on the Configuration File Pathname text box..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds to a click of the '...' button that lies next
to the text box that accepts the pathname of the application's
configuration file.

<a name='M-MFR-GUI-Dialogs-OptionsDialog-OnModified-MFR-GUI-Dialogs-Events-ModifiedEventArgs-'></a>
### OnModified(e) `method`

##### Summary

Raises the [](#E-MFR-GUI-OptionsDialog-Modified 'MFR.GUI.OptionsDialog.Modified') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.GUI.Dialogs.Events.ModifiedEventArgs](#T-MFR-GUI-Dialogs-Events-ModifiedEventArgs 'MFR.GUI.Dialogs.Events.ModifiedEventArgs') | A [ModifiedEventArgs](#T-MFR-Objects-ModifiedEventArgs 'MFR.ModifiedEventArgs') that contains the
event data. |

##### Remarks

If the [Handled](#P-MFR-Objects-ModifiedEventArgs-Handled 'MFR.ModifiedEventArgs.Handled')
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
Configuration File Pathname text box being changed. This method
responds to such a happenstance by updating the value of the [IsModified](#P-MFR-GUI-OptionsDialog-IsModified 'MFR.GUI.OptionsDialog.IsModified') property to be `true` by calling the [SetModifiedFlag](#M-MFR-GUI-OptionsDialog-SetModifiedFlag 'MFR.GUI.OptionsDialog.SetModifiedFlag') method.

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
| dirty | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set to `true` to indicate data has changed; `false` otherwise. Default is `true`. |

<a name='T-MFR-GUI-Dialogs-ProgressDialog'></a>
## ProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs

##### Summary

Window that displays progress of an operation.

<a name='M-MFR-GUI-Dialogs-ProgressDialog-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [ProgressDialog](#T-MFR-GUI-Dialogs-ProgressDialog 'MFR.GUI.Dialogs.ProgressDialog') and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-GUI-Dialogs-ProgressDialog-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MFR-GUI-Dialogs-ProgressDialog-CurrentFile'></a>
### CurrentFile `property`

##### Summary

Gets or sets a string containing the new detailed status.

<a name='P-MFR-GUI-Dialogs-ProgressDialog-ProgressBar'></a>
### ProgressBar `property`

##### Summary

Gets a reference to the progress bar control.

<a name='P-MFR-GUI-Dialogs-ProgressDialog-ProgressBarMaximum'></a>
### ProgressBarMaximum `property`

##### Summary

Gets or sets the maximum value of the range of the progress bar control.

<a name='P-MFR-GUI-Dialogs-ProgressDialog-ProgressBarMinimum'></a>
### ProgressBarMinimum `property`

##### Summary

Get or sets the minimum value of the range of the progress bar control.

<a name='P-MFR-GUI-Dialogs-ProgressDialog-ProgressBarStyle'></a>
### ProgressBarStyle `property`

##### Summary

Gets or sets the manner in which progress should

<a name='P-MFR-GUI-Dialogs-ProgressDialog-ProgressBarValue'></a>
### ProgressBarValue `property`

##### Summary

Gets or sets the current position of the progress bar.

<a name='P-MFR-GUI-Dialogs-ProgressDialog-Status'></a>
### Status `property`

##### Summary

Gets or sets a string containing the new status.

<a name='M-MFR-GUI-Dialogs-ProgressDialog-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MFR-GUI-Dialogs-ProgressDialog-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-ProgressDialog-OnCancel-System-Object,System-EventArgs-'></a>
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
[](#E-MFR-GUI-ProgressDialog-CancelRequested 'MFR.GUI.ProgressDialog.CancelRequested')
event. This event directs the caller of this dialog box to attempt
to abort the operation and close down this dialog box from its GUI thread.

<a name='M-MFR-GUI-Dialogs-ProgressDialog-OnCancelRequested'></a>
### OnCancelRequested() `method`

##### Summary

Raises the [](#E-MFR-GUI-Dialogs-ProgressDialog-CancelRequested 'MFR.GUI.Dialogs.ProgressDialog.CancelRequested') event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-ProgressDialog-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method sets the title of the dialog to match the application's name.

<a name='M-MFR-GUI-Dialogs-ProgressDialog-RedrawDisplay'></a>
### RedrawDisplay() `method`

##### Summary

Directs the application to update the user's display.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-ProgressDialog-Reset'></a>
### Reset() `method`

##### Summary

Clears the status text and progress bar.

##### Parameters

This method has no parameters.

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
