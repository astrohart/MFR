<a name='assembly'></a>
# MFR.GUI.Launchers.Dialogs.Actions

## Contents

- [LaunchErrorReportDialogAction](#T-MFR-GUI-Launchers-Dialogs-Actions-LaunchErrorReportDialogAction 'MFR.GUI.Launchers.Dialogs.Actions.LaunchErrorReportDialogAction')
  - [#ctor()](#M-MFR-GUI-Launchers-Dialogs-Actions-LaunchErrorReportDialogAction-#ctor 'MFR.GUI.Launchers.Dialogs.Actions.LaunchErrorReportDialogAction.#ctor')
  - [Instance](#P-MFR-GUI-Launchers-Dialogs-Actions-LaunchErrorReportDialogAction-Instance 'MFR.GUI.Launchers.Dialogs.Actions.LaunchErrorReportDialogAction.Instance')
  - [MessageType](#P-MFR-GUI-Launchers-Dialogs-Actions-LaunchErrorReportDialogAction-MessageType 'MFR.GUI.Launchers.Dialogs.Actions.LaunchErrorReportDialogAction.MessageType')
  - [#cctor()](#M-MFR-GUI-Launchers-Dialogs-Actions-LaunchErrorReportDialogAction-#cctor 'MFR.GUI.Launchers.Dialogs.Actions.LaunchErrorReportDialogAction.#cctor')
  - [CommonExecute()](#M-MFR-GUI-Launchers-Dialogs-Actions-LaunchErrorReportDialogAction-CommonExecute 'MFR.GUI.Launchers.Dialogs.Actions.LaunchErrorReportDialogAction.CommonExecute')
- [Resources](#T-MFR-GUI-Launchers-Dialogs-Actions-Properties-Resources 'MFR.GUI.Launchers.Dialogs.Actions.Properties.Resources')
  - [Culture](#P-MFR-GUI-Launchers-Dialogs-Actions-Properties-Resources-Culture 'MFR.GUI.Launchers.Dialogs.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Launchers-Dialogs-Actions-Properties-Resources-ResourceManager 'MFR.GUI.Launchers.Dialogs.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Launchers-Dialogs-Actions-LaunchErrorReportDialogAction'></a>
## LaunchErrorReportDialogAction `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Actions

##### Summary

Launches the Error aReport dialog box and collects the results.

<a name='M-MFR-GUI-Launchers-Dialogs-Actions-LaunchErrorReportDialogAction-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-GUI-Launchers-Dialogs-Actions-LaunchErrorReportDialogAction-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[LaunchErrorReportDialogAction](#T-MFR-GUI-Launchers-Dialogs-Actions-LaunchErrorReportDialogAction 'MFR.GUI.Launchers.Dialogs.Actions.LaunchErrorReportDialogAction')
.

<a name='P-MFR-GUI-Launchers-Dialogs-Actions-LaunchErrorReportDialogAction-MessageType'></a>
### MessageType `property`

##### Summary

Gets the
[MessageType](#T-MFR-MessageType 'MFR.MessageType')
that is
being used to identify which message this is.

<a name='M-MFR-GUI-Launchers-Dialogs-Actions-LaunchErrorReportDialogAction-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Launchers-Dialogs-Actions-LaunchErrorReportDialogAction-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Executes this message.

##### Returns

Reference to an instance of an object that implements the
[IErrorReportDialogLaunchResults](#T-MFR-GUI-Launchers-Dialogs-Results-Interfaces-IErrorReportDialogLaunchResults 'MFR.GUI.Launchers.Dialogs.Results.Interfaces.IErrorReportDialogLaunchResults')
interface.



This object's properties are initialized with the results of the user's choices
in the dialog box.

##### Parameters

This method has no parameters.

##### Remarks

Implementers shall override this method to provide the functionality
of the request.

<a name='T-MFR-GUI-Launchers-Dialogs-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Launchers-Dialogs-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Launchers-Dialogs-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
