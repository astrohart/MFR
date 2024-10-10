<a name='assembly'></a>
# MFR.GUI.Displayers

## Contents

- [Display](#T-MFR-GUI-Displayers-Display 'MFR.GUI.Displayers.Display')
  - [ErrorReportDialog(exception)](#M-MFR-GUI-Displayers-Display-ErrorReportDialog-System-Exception- 'MFR.GUI.Displayers.Display.ErrorReportDialog(System.Exception)')
  - [ErrorReportDialog(owner,exception)](#M-MFR-GUI-Displayers-Display-ErrorReportDialog-System-Windows-Forms-IWin32Window,System-Exception- 'MFR.GUI.Displayers.Display.ErrorReportDialog(System.Windows.Forms.IWin32Window,System.Exception)')
  - [HelpProfileExplainerDialog(owner)](#M-MFR-GUI-Displayers-Display-HelpProfileExplainerDialog-System-Windows-Forms-IWin32Window- 'MFR.GUI.Displayers.Display.HelpProfileExplainerDialog(System.Windows.Forms.IWin32Window)')
  - [HelpProfileExplainerDialog()](#M-MFR-GUI-Displayers-Display-HelpProfileExplainerDialog 'MFR.GUI.Displayers.Display.HelpProfileExplainerDialog')
  - [OnSendErrorReportRequested(sender,e)](#M-MFR-GUI-Displayers-Display-OnSendErrorReportRequested-System-Object,MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs- 'MFR.GUI.Displayers.Display.OnSendErrorReportRequested(System.Object,MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs)')
  - [OnViewErrorReportRequested(sender,e)](#M-MFR-GUI-Displayers-Display-OnViewErrorReportRequested-System-Object,MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs- 'MFR.GUI.Displayers.Display.OnViewErrorReportRequested(System.Object,MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs)')
  - [ProfileNameDialogBox(type)](#M-MFR-GUI-Displayers-Display-ProfileNameDialogBox-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType- 'MFR.GUI.Displayers.Display.ProfileNameDialogBox(MFR.GUI.Dialogs.Constants.ProfileCreateOperationType)')
  - [ProfileNameDialogBox(type,owner)](#M-MFR-GUI-Displayers-Display-ProfileNameDialogBox-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType,System-Windows-Forms-IWin32Window- 'MFR.GUI.Displayers.Display.ProfileNameDialogBox(MFR.GUI.Dialogs.Constants.ProfileCreateOperationType,System.Windows.Forms.IWin32Window)')
- [Resources](#T-MFR-GUI-Displayers-Properties-Resources 'MFR.GUI.Displayers.Properties.Resources')
  - [Culture](#P-MFR-GUI-Displayers-Properties-Resources-Culture 'MFR.GUI.Displayers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Displayers-Properties-Resources-ResourceManager 'MFR.GUI.Displayers.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Displayers-Display'></a>
## Display `type`

##### Namespace

MFR.GUI.Displayers

##### Summary

Contains methods to display dialog boxes.

<a name='M-MFR-GUI-Displayers-Display-ErrorReportDialog-System-Exception-'></a>
### ErrorReportDialog(exception) `method`

##### Summary

Launches a dialog box to display a report that an error occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | A [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes the
error to be reported. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `exception`, is passed a `null`
value. |

##### Remarks

This method invokes a user-friendly dialog box that prompts the user
to type in what happened that led to the error encountered.



This method associates the
[OnViewErrorReportRequested](#M-MFR-GUI-Displayers-Display-OnViewErrorReportRequested 'MFR.GUI.Displayers.Display.OnViewErrorReportRequested') method
as a handler of the
[](#E-MFR-GUI-Dialogs-ErrorReportDialog-ViewErrorReportRequested 'MFR.GUI.Dialogs.ErrorReportDialog.ViewErrorReportRequested')
event.

<a name='M-MFR-GUI-Displayers-Display-ErrorReportDialog-System-Windows-Forms-IWin32Window,System-Exception-'></a>
### ErrorReportDialog(owner,exception) `method`

##### Summary

Launches a dialog box to display a report that an error occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that
implements the [IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.



The object that implements this interface represents the parent window of the
dialog box. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | A [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes the
error to be reported. |

##### Remarks

This method also associates the
[OnViewErrorReportRequested](#M-MFR-GUI-Displayers-Display-OnViewErrorReportRequested 'MFR.GUI.Displayers.Display.OnViewErrorReportRequested') method
as the handler for the
[](#E-MFR-GUI-Dialogs-ErrorReportDialog-ViewErrorReportRequested 'MFR.GUI.Dialogs.ErrorReportDialog.ViewErrorReportRequested')
event.

<a name='M-MFR-GUI-Displayers-Display-HelpProfileExplainerDialog-System-Windows-Forms-IWin32Window-'></a>
### HelpProfileExplainerDialog(owner) `method`

##### Summary

Shows a Help window that explains Profiles to the user.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that
implements the [IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.



The object that implements this interface represents the parent window of the
dialog box. |

<a name='M-MFR-GUI-Displayers-Display-HelpProfileExplainerDialog'></a>
### HelpProfileExplainerDialog() `method`

##### Summary

Shows a Help window that explains Profiles to the user.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Displayers-Display-OnSendErrorReportRequested-System-Object,MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-'></a>
### OnSendErrorReportRequested(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog-SendErrorReportRequested 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog.SendErrorReportRequested')
event raised by the Error Report dialog box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs') | A
[SendErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs') that
contains the event data. |

##### Remarks

This method responds by launching Notepad to view the detailed report.

<a name='M-MFR-GUI-Displayers-Display-OnViewErrorReportRequested-System-Object,MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs-'></a>
### OnViewErrorReportRequested(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog-ViewErrorReportRequested 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog.ViewErrorReportRequested')
event raised by the Error Report dialog box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs') | A
[ViewErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs') that
contains the event data. |

##### Remarks

This method responds by launching Notepad to view the detailed report.

<a name='M-MFR-GUI-Displayers-Display-ProfileNameDialogBox-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType-'></a>
### ProfileNameDialogBox(type) `method`

##### Summary

Launches a dialog box to display a report that an error occurred.

##### Returns

Reference to an instance of an object that implements the
[IProfileNameDialogLaunchResults](#T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IProfileNameDialogLaunchResults 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogLaunchResults')
interface whose properties are set to the results of the user's selections in
the dialog box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.GUI.Dialogs.Constants.ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') | A [ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') that
specifies whether the dialog should be launched to create a new profile, or
save an existing profile with a new name. |

<a name='M-MFR-GUI-Displayers-Display-ProfileNameDialogBox-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType,System-Windows-Forms-IWin32Window-'></a>
### ProfileNameDialogBox(type,owner) `method`

##### Summary

Launches a dialog box to display a report that an error occurred.

##### Returns

Reference to an instance of an object that implements the
[IProfileNameDialogLaunchResults](#T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IProfileNameDialogLaunchResults 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogLaunchResults')
interface whose properties are set to the results of the user's selections in
the dialog box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.GUI.Dialogs.Constants.ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') | A [ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') that
specifies whether the dialog should be launched to create a new profile, or
save an existing profile with a new name. |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.



This object plays the role of the parent window of the dialog box. |

<a name='T-MFR-GUI-Displayers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Displayers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Displayers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Displayers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
