<a name='assembly'></a>
# MFR.GUI.Launchers.Dialogs.Params

## Contents

- [DialogLaunchParamBase](#T-MFR-GUI-Launchers-Dialogs-Params-DialogLaunchParamBase 'MFR.GUI.Launchers.Dialogs.Params.DialogLaunchParamBase')
  - [Owner](#P-MFR-GUI-Launchers-Dialogs-Params-DialogLaunchParamBase-Owner 'MFR.GUI.Launchers.Dialogs.Params.DialogLaunchParamBase.Owner')
- [ErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-ErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.ErrorReportDialogLaunchParams')
  - [Exception](#P-MFR-GUI-Launchers-Dialogs-Params-ErrorReportDialogLaunchParams-Exception 'MFR.GUI.Launchers.Dialogs.Params.ErrorReportDialogLaunchParams.Exception')
  - [SendHandler](#P-MFR-GUI-Launchers-Dialogs-Params-ErrorReportDialogLaunchParams-SendHandler 'MFR.GUI.Launchers.Dialogs.Params.ErrorReportDialogLaunchParams.SendHandler')
  - [ViewHandler](#P-MFR-GUI-Launchers-Dialogs-Params-ErrorReportDialogLaunchParams-ViewHandler 'MFR.GUI.Launchers.Dialogs.Params.ErrorReportDialogLaunchParams.ViewHandler')
- [Resources](#T-MFR-GUI-Launchers-Dialogs-Params-Properties-Resources 'MFR.GUI.Launchers.Dialogs.Params.Properties.Resources')
  - [Culture](#P-MFR-GUI-Launchers-Dialogs-Params-Properties-Resources-Culture 'MFR.GUI.Launchers.Dialogs.Params.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Launchers-Dialogs-Params-Properties-Resources-ResourceManager 'MFR.GUI.Launchers.Dialogs.Params.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Launchers-Dialogs-Params-DialogLaunchParamBase'></a>
## DialogLaunchParamBase `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Params

##### Summary

Common base class for all dialog-launch params.

<a name='P-MFR-GUI-Launchers-Dialogs-Params-DialogLaunchParamBase-Owner'></a>
### Owner `property`

##### Summary

Gets or sets a reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface that represents
the parent window of the new dialog box.

<a name='T-MFR-GUI-Launchers-Dialogs-Params-ErrorReportDialogLaunchParams'></a>
## ErrorReportDialogLaunchParams `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Params

##### Summary

Parameters for launching an Error Report dialog.

<a name='P-MFR-GUI-Launchers-Dialogs-Params-ErrorReportDialogLaunchParams-Exception'></a>
### Exception `property`

##### Summary

Gets or sets a reference to a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes
the error being reported.

<a name='P-MFR-GUI-Launchers-Dialogs-Params-ErrorReportDialogLaunchParams-SendHandler'></a>
### SendHandler `property`

##### Summary

Gets or sets a reference to the
[SendErrorReportRequestedEventHandler](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventHandler 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler')
-typed delegate that will be called when the user requests to send the detailed
error report.

<a name='P-MFR-GUI-Launchers-Dialogs-Params-ErrorReportDialogLaunchParams-ViewHandler'></a>
### ViewHandler `property`

##### Summary

Gets or sets a reference to the
[ViewHandler](#T-MFR-GUI-Dialogs-Events-ViewHandler 'MFR.GUI.Dialogs.Events.ViewHandler')
-typed delegate that will be called when the user requests to view the detailed
error report.

<a name='T-MFR-GUI-Launchers-Dialogs-Params-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Params.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Launchers-Dialogs-Params-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Launchers-Dialogs-Params-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
