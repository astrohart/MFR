<a name='assembly'></a>
# MFR.GUI.Launchers.Dialogs.Results

## Contents

- [ErrorReportDialogLaunchResults](#T-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults 'MFR.GUI.Launchers.Dialogs.Results.ErrorReportDialogLaunchResults')
  - [#ctor(dialogResult,exception,errorReportContents,reproductionSteps)](#M-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults-#ctor-System-Windows-Forms-DialogResult,System-Exception,System-String,System-String- 'MFR.GUI.Launchers.Dialogs.Results.ErrorReportDialogLaunchResults.#ctor(System.Windows.Forms.DialogResult,System.Exception,System.String,System.String)')
  - [DialogResult](#P-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults-DialogResult 'MFR.GUI.Launchers.Dialogs.Results.ErrorReportDialogLaunchResults.DialogResult')
  - [ErrorReportContents](#P-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults-ErrorReportContents 'MFR.GUI.Launchers.Dialogs.Results.ErrorReportDialogLaunchResults.ErrorReportContents')
  - [Exception](#P-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults-Exception 'MFR.GUI.Launchers.Dialogs.Results.ErrorReportDialogLaunchResults.Exception')
  - [ReproductionSteps](#P-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults-ReproductionSteps 'MFR.GUI.Launchers.Dialogs.Results.ErrorReportDialogLaunchResults.ReproductionSteps')
- [Resources](#T-MFR-GUI-Launchers-Dialogs-Results-Properties-Resources 'MFR.GUI.Launchers.Dialogs.Results.Properties.Resources')
  - [Culture](#P-MFR-GUI-Launchers-Dialogs-Results-Properties-Resources-Culture 'MFR.GUI.Launchers.Dialogs.Results.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Launchers-Dialogs-Results-Properties-Resources-ResourceManager 'MFR.GUI.Launchers.Dialogs.Results.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults'></a>
## ErrorReportDialogLaunchResults `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Results

##### Summary

POCO that contains the results of the operation of showing the Error Report
dialog box to the user.

<a name='M-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults-#ctor-System-Windows-Forms-DialogResult,System-Exception,System-String,System-String-'></a>
### #ctor(dialogResult,exception,errorReportContents,reproductionSteps) `constructor`

##### Summary

Constructs a new instance of
[ErrorReportDialogLaunchResults](#T-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults 'MFR.GUI.Launchers.Dialogs.Results.ErrorReportDialogLaunchResults')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dialogResult | [System.Windows.Forms.DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') | (Required.) A [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') value that
explains what action the user took to dismiss the dialog box. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) Reference to an instance of a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception')
object that describes the error that occurred. |
| errorReportContents | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the contents of the detailed error report. |
| reproductionSteps | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the user's description of the steps that led up
to the error. |

<a name='P-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults-DialogResult'></a>
### DialogResult `property`

##### Summary

Gets a [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') value that describes
the action that the user chose in order to dismiss the dialog box.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults-ErrorReportContents'></a>
### ErrorReportContents `property`

##### Summary

Gets a string tht contains the detailed error report.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults-Exception'></a>
### Exception `property`

##### Summary

Gets a reference to an instance of an [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') object
that describes, in detail, the error which occurred.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults-ReproductionSteps'></a>
### ReproductionSteps `property`

##### Summary

Gets a string that contains the user's description of the events leading up to
the error.

<a name='T-MFR-GUI-Launchers-Dialogs-Results-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Results.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
