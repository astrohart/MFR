<a name='assembly'></a>
# MFR.GUI.Launchers.Dialogs

## Contents

- [ErrorReportDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-ErrorReportDialogLauncher 'MFR.GUI.Launchers.Dialogs.ErrorReportDialogLauncher')
  - [#ctor()](#M-MFR-GUI-Launchers-Dialogs-ErrorReportDialogLauncher-#ctor 'MFR.GUI.Launchers.Dialogs.ErrorReportDialogLauncher.#ctor')
  - [Instance](#P-MFR-GUI-Launchers-Dialogs-ErrorReportDialogLauncher-Instance 'MFR.GUI.Launchers.Dialogs.ErrorReportDialogLauncher.Instance')
  - [#cctor()](#M-MFR-GUI-Launchers-Dialogs-ErrorReportDialogLauncher-#cctor 'MFR.GUI.Launchers.Dialogs.ErrorReportDialogLauncher.#cctor')
  - [Launch(parms)](#M-MFR-GUI-Launchers-Dialogs-ErrorReportDialogLauncher-Launch-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams- 'MFR.GUI.Launchers.Dialogs.ErrorReportDialogLauncher.Launch(MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams)')
- [HelpProfileExplainerDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-HelpProfileExplainerDialogLauncher 'MFR.GUI.Launchers.Dialogs.HelpProfileExplainerDialogLauncher')
  - [#ctor()](#M-MFR-GUI-Launchers-Dialogs-HelpProfileExplainerDialogLauncher-#ctor 'MFR.GUI.Launchers.Dialogs.HelpProfileExplainerDialogLauncher.#ctor')
  - [Instance](#P-MFR-GUI-Launchers-Dialogs-HelpProfileExplainerDialogLauncher-Instance 'MFR.GUI.Launchers.Dialogs.HelpProfileExplainerDialogLauncher.Instance')
  - [#cctor()](#M-MFR-GUI-Launchers-Dialogs-HelpProfileExplainerDialogLauncher-#cctor 'MFR.GUI.Launchers.Dialogs.HelpProfileExplainerDialogLauncher.#cctor')
  - [Launch(owner)](#M-MFR-GUI-Launchers-Dialogs-HelpProfileExplainerDialogLauncher-Launch-System-Windows-Forms-IWin32Window- 'MFR.GUI.Launchers.Dialogs.HelpProfileExplainerDialogLauncher.Launch(System.Windows.Forms.IWin32Window)')
- [ProfileNameDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-ProfileNameDialogLauncher 'MFR.GUI.Launchers.Dialogs.ProfileNameDialogLauncher')
  - [#ctor()](#M-MFR-GUI-Launchers-Dialogs-ProfileNameDialogLauncher-#ctor 'MFR.GUI.Launchers.Dialogs.ProfileNameDialogLauncher.#ctor')
  - [Instance](#P-MFR-GUI-Launchers-Dialogs-ProfileNameDialogLauncher-Instance 'MFR.GUI.Launchers.Dialogs.ProfileNameDialogLauncher.Instance')
  - [#cctor()](#M-MFR-GUI-Launchers-Dialogs-ProfileNameDialogLauncher-#cctor 'MFR.GUI.Launchers.Dialogs.ProfileNameDialogLauncher.#cctor')
  - [Launch(parms)](#M-MFR-GUI-Launchers-Dialogs-ProfileNameDialogLauncher-Launch-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IProfileNameDialogLaunchParams- 'MFR.GUI.Launchers.Dialogs.ProfileNameDialogLauncher.Launch(MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams)')
- [Resources](#T-MFR-GUI-Launchers-Dialogs-Properties-Resources 'MFR.GUI.Launchers.Dialogs.Properties.Resources')
  - [Culture](#P-MFR-GUI-Launchers-Dialogs-Properties-Resources-Culture 'MFR.GUI.Launchers.Dialogs.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Launchers-Dialogs-Properties-Resources-ResourceManager 'MFR.GUI.Launchers.Dialogs.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Launchers-Dialogs-ErrorReportDialogLauncher'></a>
## ErrorReportDialogLauncher `type`

##### Namespace

MFR.GUI.Launchers.Dialogs

##### Summary

Provides helper methods to launch the error dialog.

##### Remarks

The error dialog typically is utilized to provide the user with a
helpful way to deal with, basically, otherwise-unhandled exceptions, and
to send the resulting error information to xyLOGIX.

<a name='M-MFR-GUI-Launchers-Dialogs-ErrorReportDialogLauncher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-GUI-Launchers-Dialogs-ErrorReportDialogLauncher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[ErrorReportDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-ErrorReportDialogLauncher 'MFR.GUI.Launchers.Dialogs.ErrorReportDialogLauncher').

<a name='M-MFR-GUI-Launchers-Dialogs-ErrorReportDialogLauncher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Launchers-Dialogs-ErrorReportDialogLauncher-Launch-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams-'></a>
### Launch(parms) `method`

##### Summary

Displays a user-friendly dialog box that assists the user with
recovering from an application-specific error i.e., an
otherwise-unhandled exception.

##### Returns

Reference to an instance of an object that implements the
[IErrorReportDialogLaunchResults](#T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IErrorReportDialogLaunchResults 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults')
interface that describes the results of the user's choices in the dialog box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parms | [MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams') | (Required.) Reference to an instance of an object that implements the
[IErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams')
interface.



This object describes the values of the parameters this method needs to launch
the dialog. |

<a name='T-MFR-GUI-Launchers-Dialogs-HelpProfileExplainerDialogLauncher'></a>
## HelpProfileExplainerDialogLauncher `type`

##### Namespace

MFR.GUI.Launchers.Dialogs

##### Summary

Provides helper methods to launch the explainer dialog that provides the user
with Help on what Profiles are.

<a name='M-MFR-GUI-Launchers-Dialogs-HelpProfileExplainerDialogLauncher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-GUI-Launchers-Dialogs-HelpProfileExplainerDialogLauncher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[HelpProfileExplainerDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-HelpProfileExplainerDialogLauncher 'MFR.GUI.Launchers.Dialogs.HelpProfileExplainerDialogLauncher').

<a name='M-MFR-GUI-Launchers-Dialogs-HelpProfileExplainerDialogLauncher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Launchers-Dialogs-HelpProfileExplainerDialogLauncher-Launch-System-Windows-Forms-IWin32Window-'></a>
### Launch(owner) `method`

##### Summary

Displays a user-friendly dialog box that assists the user with
recovering from an application-specific error i.e., an
otherwise-unhandled exception.

##### Returns

A [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') value that
corresponds to the means used by the user to dismiss the dialog.



If an error occurs, then the
[None](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult.None 'System.Windows.Forms.DialogResult.None') value is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements
the [IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.
This object acts as the parent window of the dialog box. |

<a name='T-MFR-GUI-Launchers-Dialogs-ProfileNameDialogLauncher'></a>
## ProfileNameDialogLauncher `type`

##### Namespace

MFR.GUI.Launchers.Dialogs

##### Summary

Provides helper methods to launch the explainer dialog that provides the user
with Help on what Profiles are.

<a name='M-MFR-GUI-Launchers-Dialogs-ProfileNameDialogLauncher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-GUI-Launchers-Dialogs-ProfileNameDialogLauncher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[ProfileNameDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-ProfileNameDialogLauncher 'MFR.GUI.Launchers.Dialogs.ProfileNameDialogLauncher').

<a name='M-MFR-GUI-Launchers-Dialogs-ProfileNameDialogLauncher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Launchers-Dialogs-ProfileNameDialogLauncher-Launch-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IProfileNameDialogLaunchParams-'></a>
### Launch(parms) `method`

##### Summary

Displays a user-friendly dialog box that assists the user with selecting a new
name for a new or existing profile.

##### Returns

Reference to an instance of an object that implements the
[IProfileNameDialogLaunchResults](#T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IProfileNameDialogLaunchResults 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogLaunchResults')
interface.



This object's properties' values contain the values chosen by the user,
including the [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') value that
corresponds to the button the user clicked in order to dismiss the dialog box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parms | [MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IProfileNameDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams') | (Required.) Reference to an instance of an object that implements the
[IProfileNameDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IProfileNameDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams')
interface.



This object contains the input parameter variables for the Profile Name dialog
box. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `parms`, is passed a `null`
value. |

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
