<a name='assembly'></a>
# MFR.GUI.Launchers.Dialogs.Results.Factories

## Contents

- [MakeNewErrorReportDialogLaunchResults](#T-MFR-GUI-Launchers-Dialogs-Results-Factories-MakeNewErrorReportDialogLaunchResults 'MFR.GUI.Launchers.Dialogs.Results.Factories.MakeNewErrorReportDialogLaunchResults')
  - [WithPropertyValues(dialogResult,exception,errorReportContents,reproductionSteps)](#M-MFR-GUI-Launchers-Dialogs-Results-Factories-MakeNewErrorReportDialogLaunchResults-WithPropertyValues-System-Windows-Forms-DialogResult,System-Exception,System-String,System-String- 'MFR.GUI.Launchers.Dialogs.Results.Factories.MakeNewErrorReportDialogLaunchResults.WithPropertyValues(System.Windows.Forms.DialogResult,System.Exception,System.String,System.String)')
- [Resources](#T-MFR-GUI-Launchers-Dialogs-Results-Factories-Properties-Resources 'MFR.GUI.Launchers.Dialogs.Results.Factories.Properties.Resources')
  - [Culture](#P-MFR-GUI-Launchers-Dialogs-Results-Factories-Properties-Resources-Culture 'MFR.GUI.Launchers.Dialogs.Results.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Launchers-Dialogs-Results-Factories-Properties-Resources-ResourceManager 'MFR.GUI.Launchers.Dialogs.Results.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Launchers-Dialogs-Results-Factories-MakeNewErrorReportDialogLaunchResults'></a>
## MakeNewErrorReportDialogLaunchResults `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Results.Factories

##### Summary

Creates new instances of objects that implement the
[IErrorReportDialogLaunchResults](#T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IErrorReportDialogLaunchResults 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults')
interface, and returns references to them.

<a name='M-MFR-GUI-Launchers-Dialogs-Results-Factories-MakeNewErrorReportDialogLaunchResults-WithPropertyValues-System-Windows-Forms-DialogResult,System-Exception,System-String,System-String-'></a>
### WithPropertyValues(dialogResult,exception,errorReportContents,reproductionSteps) `method`

##### Summary

Creates a new instance of an object that implements the
[IErrorReportDialogLaunchResults](#T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IErrorReportDialogLaunchResults 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IErrorReportDialogLaunchResults](#T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IErrorReportDialogLaunchResults 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults')
interface, initialized with the values of the parameters referenced above.

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

<a name='T-MFR-GUI-Launchers-Dialogs-Results-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Results.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
