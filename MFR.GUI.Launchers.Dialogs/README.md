<a name='assembly'></a>
# MFR.GUI.Launchers.Dialogs

## Contents

- [ErrorDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-ErrorDialogLauncher 'MFR.GUI.Launchers.Dialogs.ErrorDialogLauncher')
  - [Display(owner,exception)](#M-MFR-GUI-Launchers-Dialogs-ErrorDialogLauncher-Display-System-Windows-Forms-IWin32Window,System-Exception- 'MFR.GUI.Launchers.Dialogs.ErrorDialogLauncher.Display(System.Windows.Forms.IWin32Window,System.Exception)')
- [Resources](#T-MFR-GUI-Launchers-Dialogs-Properties-Resources 'MFR.GUI.Launchers.Dialogs.Properties.Resources')
  - [Culture](#P-MFR-GUI-Launchers-Dialogs-Properties-Resources-Culture 'MFR.GUI.Launchers.Dialogs.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Launchers-Dialogs-Properties-Resources-ResourceManager 'MFR.GUI.Launchers.Dialogs.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Launchers-Dialogs-ErrorDialogLauncher'></a>
## ErrorDialogLauncher `type`

##### Namespace

MFR.GUI.Launchers.Dialogs

##### Summary

Provides helper methods to launch the error dialog.

##### Remarks

The error dialog typically is utilized to provide the user with a
helpful way to deal with, basically, otherwise-unhandled exceptions, and
to send the resulting error information to xyLOGIX.

<a name='M-MFR-GUI-Launchers-Dialogs-ErrorDialogLauncher-Display-System-Windows-Forms-IWin32Window,System-Exception-'></a>
### Display(owner,exception) `method`

##### Summary

Displays a user-friendly dialog box that assists the user with
recovering from an application-specific error i.e., an
otherwise-unhandled exception.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements
the [IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.
This object acts as the parent window of the dialog box. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | An [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that contains the error information. |

<a name='T-MFR-GUI-Launchers-Dialogs-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Launchers-Dialogs-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Launchers-Dialogs-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
