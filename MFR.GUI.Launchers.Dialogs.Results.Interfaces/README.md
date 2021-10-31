<a name='assembly'></a>
# MFR.GUI.Launchers.Dialogs.Results.Interfaces

## Contents

- [IDialogBoxResults](#T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IDialogBoxResults 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IDialogBoxResults')
  - [DialogResult](#P-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IDialogBoxResults-DialogResult 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IDialogBoxResults.DialogResult')
- [IErrorReportDialogLaunchResults](#T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IErrorReportDialogLaunchResults 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults')
  - [ErrorReportContents](#P-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IErrorReportDialogLaunchResults-ErrorReportContents 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults.ErrorReportContents')
  - [Exception](#P-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IErrorReportDialogLaunchResults-Exception 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults.Exception')
  - [ReproductionSteps](#P-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IErrorReportDialogLaunchResults-ReproductionSteps 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults.ReproductionSteps')
- [IProfileNameDialogResults](#T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IProfileNameDialogResults 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogResults')
  - [ProfileName](#P-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IProfileNameDialogResults-ProfileName 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogResults.ProfileName')
- [Resources](#T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-Properties-Resources 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-GUI-Launchers-Dialogs-Results-Interfaces-Properties-Resources-Culture 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Launchers-Dialogs-Results-Interfaces-Properties-Resources-ResourceManager 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IDialogBoxResults'></a>
## IDialogBoxResults `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Results.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a dialog box's results object.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IDialogBoxResults-DialogResult'></a>
### DialogResult `property`

##### Summary

Gets a [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') value that describes
the action that the user chose in order to dismiss the dialog box.

<a name='T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IErrorReportDialogLaunchResults'></a>
## IErrorReportDialogLaunchResults `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Results.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a
`Error Report Dialog Launch Results` object.

##### Remarks

Such an object describes the output of the choices made by the user when the
`Error Report` dialog box is shown.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IErrorReportDialogLaunchResults-ErrorReportContents'></a>
### ErrorReportContents `property`

##### Summary

Gets a string tht contains the detailed error report.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IErrorReportDialogLaunchResults-Exception'></a>
### Exception `property`

##### Summary

Gets a reference to an instance of an [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') object
that describes, in detail, the error which occurred.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IErrorReportDialogLaunchResults-ReproductionSteps'></a>
### ReproductionSteps `property`

##### Summary

Gets a string that contains the user's description of the events leading up to
the error.

<a name='T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IProfileNameDialogResults'></a>
## IProfileNameDialogResults `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Results.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a Profile Name dialog
box's results object.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IProfileNameDialogResults-ProfileName'></a>
### ProfileName `property`

##### Summary

Gets or sets a string that contains the name that the user wants to assign to
the Profile.

<a name='T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Results.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
