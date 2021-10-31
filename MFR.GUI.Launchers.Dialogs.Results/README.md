<a name='assembly'></a>
# MFR.GUI.Launchers.Dialogs.Results

## Contents

- [DialogBoxResultsBase](#T-MFR-GUI-Launchers-Dialogs-Results-DialogBoxResultsBase 'MFR.GUI.Launchers.Dialogs.Results.DialogBoxResultsBase')
  - [#ctor()](#M-MFR-GUI-Launchers-Dialogs-Results-DialogBoxResultsBase-#ctor-System-Windows-Forms-DialogResult- 'MFR.GUI.Launchers.Dialogs.Results.DialogBoxResultsBase.#ctor(System.Windows.Forms.DialogResult)')
  - [DialogResult](#P-MFR-GUI-Launchers-Dialogs-Results-DialogBoxResultsBase-DialogResult 'MFR.GUI.Launchers.Dialogs.Results.DialogBoxResultsBase.DialogResult')
- [ErrorReportDialogLaunchResults](#T-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults 'MFR.GUI.Launchers.Dialogs.Results.ErrorReportDialogLaunchResults')
  - [#ctor(dialogResult,exception,errorReportContents,reproductionSteps)](#M-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults-#ctor-System-Windows-Forms-DialogResult,System-Exception,System-String,System-String- 'MFR.GUI.Launchers.Dialogs.Results.ErrorReportDialogLaunchResults.#ctor(System.Windows.Forms.DialogResult,System.Exception,System.String,System.String)')
  - [ErrorReportContents](#P-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults-ErrorReportContents 'MFR.GUI.Launchers.Dialogs.Results.ErrorReportDialogLaunchResults.ErrorReportContents')
  - [Exception](#P-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults-Exception 'MFR.GUI.Launchers.Dialogs.Results.ErrorReportDialogLaunchResults.Exception')
  - [ReproductionSteps](#P-MFR-GUI-Launchers-Dialogs-Results-ErrorReportDialogLaunchResults-ReproductionSteps 'MFR.GUI.Launchers.Dialogs.Results.ErrorReportDialogLaunchResults.ReproductionSteps')
- [ProfileNameDialogResults](#T-MFR-GUI-Launchers-Dialogs-Results-ProfileNameDialogResults 'MFR.GUI.Launchers.Dialogs.Results.ProfileNameDialogResults')
  - [#ctor(profileName,type,dialogResult)](#M-MFR-GUI-Launchers-Dialogs-Results-ProfileNameDialogResults-#ctor-System-String,MFR-GUI-Dialogs-Constants-ProfileCreateOperationType,System-Windows-Forms-DialogResult- 'MFR.GUI.Launchers.Dialogs.Results.ProfileNameDialogResults.#ctor(System.String,MFR.GUI.Dialogs.Constants.ProfileCreateOperationType,System.Windows.Forms.DialogResult)')
  - [CreateOperationType](#P-MFR-GUI-Launchers-Dialogs-Results-ProfileNameDialogResults-CreateOperationType 'MFR.GUI.Launchers.Dialogs.Results.ProfileNameDialogResults.CreateOperationType')
  - [ProfileName](#P-MFR-GUI-Launchers-Dialogs-Results-ProfileNameDialogResults-ProfileName 'MFR.GUI.Launchers.Dialogs.Results.ProfileNameDialogResults.ProfileName')
- [Resources](#T-MFR-GUI-Launchers-Dialogs-Results-Properties-Resources 'MFR.GUI.Launchers.Dialogs.Results.Properties.Resources')
  - [Culture](#P-MFR-GUI-Launchers-Dialogs-Results-Properties-Resources-Culture 'MFR.GUI.Launchers.Dialogs.Results.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Launchers-Dialogs-Results-Properties-Resources-ResourceManager 'MFR.GUI.Launchers.Dialogs.Results.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Launchers-Dialogs-Results-DialogBoxResultsBase'></a>
## DialogBoxResultsBase `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Results

##### Summary

Methods and properties common to all results objects for dialog boxes.

<a name='M-MFR-GUI-Launchers-Dialogs-Results-DialogBoxResultsBase-#ctor-System-Windows-Forms-DialogResult-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the
[DialogBoxResultsBase](#T-MFR-GUI-Launchers-Dialogs-Results-DialogBoxResultsBase 'MFR.GUI.Launchers.Dialogs.Results.DialogBoxResultsBase') class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-DialogBoxResultsBase-DialogResult'></a>
### DialogResult `property`

##### Summary

Gets a [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') value that describes
the action that the user chose in order to dismiss the dialog box.

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

<a name='T-MFR-GUI-Launchers-Dialogs-Results-ProfileNameDialogResults'></a>
## ProfileNameDialogResults `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Results

##### Summary

Results from a dialog box that prompts the user for the name to use for a
Profile.

<a name='M-MFR-GUI-Launchers-Dialogs-Results-ProfileNameDialogResults-#ctor-System-String,MFR-GUI-Dialogs-Constants-ProfileCreateOperationType,System-Windows-Forms-DialogResult-'></a>
### #ctor(profileName,type,dialogResult) `constructor`

##### Summary

Constructs a new instance of
[ProfileNameDialogResults](#T-MFR-GUI-Launchers-Dialogs-Results-ProfileNameDialogResults 'MFR.GUI.Launchers.Dialogs.Results.ProfileNameDialogResults')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| profileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name to give the Profile. |
| type | [MFR.GUI.Dialogs.Constants.ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') | (Required.) A
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') that
describes for what operation the dialog box is being summoned. |
| dialogResult | [System.Windows.Forms.DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') | (Required.) A [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') that indicates
how the user dismissed the dialog box. |

<a name='P-MFR-GUI-Launchers-Dialogs-Results-ProfileNameDialogResults-CreateOperationType'></a>
### CreateOperationType `property`

##### Summary

Gets or sets of the
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') values
that says what use case this dialog is being used for.

<a name='P-MFR-GUI-Launchers-Dialogs-Results-ProfileNameDialogResults-ProfileName'></a>
### ProfileName `property`

##### Summary

Gets or sets a string that contains the name that the user wants to assign to
the Profile.

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
