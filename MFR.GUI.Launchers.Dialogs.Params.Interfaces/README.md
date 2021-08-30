<a name='assembly'></a>
# MFR.GUI.Launchers.Dialogs.Params.Interfaces

## Contents

- [IDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IDialogLaunchParams')
  - [Owner](#P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IDialogLaunchParams-Owner 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IDialogLaunchParams.Owner')
- [IErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams')
  - [Exception](#P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams-Exception 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams.Exception')
  - [SendHandler](#P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams-SendHandler 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams.SendHandler')
  - [ViewHandler](#P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams-ViewHandler 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams.ViewHandler')
- [Resources](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-Properties-Resources 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-Properties-Resources-Culture 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-Properties-Resources-ResourceManager 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IDialogLaunchParams'></a>
## IDialogLaunchParams `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Params.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a parameter POCO for
launching a dialog box.

##### Remarks

This interface exposes the methods and properties that are common to all
parameter POCOs for launching dialog boxes.

<a name='P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IDialogLaunchParams-Owner'></a>
### Owner `property`

##### Summary

Gets or sets a reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface that represents
the parent window of the new dialog box.

<a name='T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams'></a>
## IErrorReportDialogLaunchParams `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Params.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a parameter POCO for launching the Error Report dialog.

<a name='P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams-Exception'></a>
### Exception `property`

##### Summary

Gets or sets a reference to a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes
the error being reported.

<a name='P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams-SendHandler'></a>
### SendHandler `property`

##### Summary

Gets or sets a reference to the
[SendErrorReportRequestedEventHandler](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventHandler 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler')
-typed delegate that will be called when the user requests to send the detailed
error report.

<a name='P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams-ViewHandler'></a>
### ViewHandler `property`

##### Summary

Gets or sets a reference to the
[ViewHandler](#T-MFR-GUI-Dialogs-Events-ViewHandler 'MFR.GUI.Dialogs.Events.ViewHandler')
-typed delegate that will be called when the user requests to view the detailed
error report.

<a name='T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Params.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
