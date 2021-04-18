<a name='assembly'></a>
# MFR.GUI.Dialogs.Interfaces

## Contents

- [IOptionsDialog](#T-MFR-GUI-Dialogs-Interfaces-IOptionsDialog 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog')
  - [ConfigPathname](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-ConfigPathname 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.ConfigPathname')
  - [IsModified](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-IsModified 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.IsModified')
  - [ShouldReOpenVisualStudioSolution](#P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-ShouldReOpenVisualStudioSolution 'MFR.GUI.Dialogs.Interfaces.IOptionsDialog.ShouldReOpenVisualStudioSolution')
- [IProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IProgressDialog 'MFR.GUI.Dialogs.Interfaces.IProgressDialog')
  - [CurrentFile](#P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-CurrentFile 'MFR.GUI.Dialogs.Interfaces.IProgressDialog.CurrentFile')
  - [ProgressBarMaximum](#P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-ProgressBarMaximum 'MFR.GUI.Dialogs.Interfaces.IProgressDialog.ProgressBarMaximum')
  - [ProgressBarMinimum](#P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-ProgressBarMinimum 'MFR.GUI.Dialogs.Interfaces.IProgressDialog.ProgressBarMinimum')
  - [ProgressBarStyle](#P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-ProgressBarStyle 'MFR.GUI.Dialogs.Interfaces.IProgressDialog.ProgressBarStyle')
  - [ProgressBarValue](#P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-ProgressBarValue 'MFR.GUI.Dialogs.Interfaces.IProgressDialog.ProgressBarValue')
  - [Status](#P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-Status 'MFR.GUI.Dialogs.Interfaces.IProgressDialog.Status')
  - [Reset()](#M-MFR-GUI-Dialogs-Interfaces-IProgressDialog-Reset 'MFR.GUI.Dialogs.Interfaces.IProgressDialog.Reset')
- [Resources](#T-MFR-GUI-Dialogs-Interfaces-Properties-Resources 'MFR.GUI.Dialogs.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-GUI-Dialogs-Interfaces-Properties-Resources-Culture 'MFR.GUI.Dialogs.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Dialogs-Interfaces-Properties-Resources-ResourceManager 'MFR.GUI.Dialogs.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Dialogs-Interfaces-IOptionsDialog'></a>
## IOptionsDialog `type`

##### Namespace

MFR.GUI.Dialogs.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a dialog box that
allows the user to configure the application.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-ConfigPathname'></a>
### ConfigPathname `property`

##### Summary

Gets or sets the text of the Configuration File Pathname text box.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-IsModified'></a>
### IsModified `property`

##### Summary

Gets a value that indicates whether the data in this dialog box has
been modified.

<a name='P-MFR-GUI-Dialogs-Interfaces-IOptionsDialog-ShouldReOpenVisualStudioSolution'></a>
### ShouldReOpenVisualStudioSolution `property`

##### Summary

Gets or sets the value of the Reopen Visual Studio Solution checkbox

<a name='T-MFR-GUI-Dialogs-Interfaces-IProgressDialog'></a>
## IProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs.Interfaces

##### Summary

Defines the public-exposed methods and properties of a progress window..

<a name='P-MFR-GUI-Dialogs-Interfaces-IProgressDialog-CurrentFile'></a>
### CurrentFile `property`

##### Summary

Gets or sets a string containing the new detailed status.

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
