<a name='assembly'></a>
# MFR.GUI.Launchers.Dialogs.Interfaces

## Contents

- [IErrorReportDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-Interfaces-IErrorReportDialogLauncher 'MFR.GUI.Launchers.Dialogs.Interfaces.IErrorReportDialogLauncher')
  - [Launch(parms)](#M-MFR-GUI-Launchers-Dialogs-Interfaces-IErrorReportDialogLauncher-Launch-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams- 'MFR.GUI.Launchers.Dialogs.Interfaces.IErrorReportDialogLauncher.Launch(MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams)')
- [IHelpProfileExplainerDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-Interfaces-IHelpProfileExplainerDialogLauncher 'MFR.GUI.Launchers.Dialogs.Interfaces.IHelpProfileExplainerDialogLauncher')
  - [Launch(owner)](#M-MFR-GUI-Launchers-Dialogs-Interfaces-IHelpProfileExplainerDialogLauncher-Launch-System-Windows-Forms-IWin32Window- 'MFR.GUI.Launchers.Dialogs.Interfaces.IHelpProfileExplainerDialogLauncher.Launch(System.Windows.Forms.IWin32Window)')
- [Resources](#T-MFR-GUI-Launchers-Dialogs-Interfaces-Properties-Resources 'MFR.GUI.Launchers.Dialogs.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-GUI-Launchers-Dialogs-Interfaces-Properties-Resources-Culture 'MFR.GUI.Launchers.Dialogs.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Launchers-Dialogs-Interfaces-Properties-Resources-ResourceManager 'MFR.GUI.Launchers.Dialogs.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Launchers-Dialogs-Interfaces-IErrorReportDialogLauncher'></a>
## IErrorReportDialogLauncher `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that launches
the error report dialog.

<a name='M-MFR-GUI-Launchers-Dialogs-Interfaces-IErrorReportDialogLauncher-Launch-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams-'></a>
### Launch(parms) `method`

##### Summary

Displays a user-friendly dialog box that assists the user with
recovering from an application-specific error i.e., an
otherwise-unhandled exception.

##### Returns

Reference to an instance of an object that implements the
[IErrorReportDialogLaunchResults](#T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IErrorReportDialogLaunchResults 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parms | [MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams') | (Required.) Reference to an instance of an object that implements the
[IErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams')
interface.



This object describes the values of the parameters this method needs to launch
the dialog. |

<a name='T-MFR-GUI-Launchers-Dialogs-Interfaces-IHelpProfileExplainerDialogLauncher'></a>
## IHelpProfileExplainerDialogLauncher `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that launches
the Help dialog that explains how Profiles work.

<a name='M-MFR-GUI-Launchers-Dialogs-Interfaces-IHelpProfileExplainerDialogLauncher-Launch-System-Windows-Forms-IWin32Window-'></a>
### Launch(owner) `method`

##### Summary

Displays a user-friendly dialog box that provides Help on Profiles.

##### Returns

A [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') value that
corresponds to the means used by the user to dismiss the dialog.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements
the [IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.
This object acts as the parent window of the dialog box. |

<a name='T-MFR-GUI-Launchers-Dialogs-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Launchers-Dialogs-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Launchers-Dialogs-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
