<a name='assembly'></a>
# MFR.GUI.Launchers.Dialogs.Actions.Factories

## Contents

- [GetDialogLauncherAction](#T-MFR-GUI-Launchers-Dialogs-Actions-Factories-GetDialogLauncherAction 'MFR.GUI.Launchers.Dialogs.Actions.Factories.GetDialogLauncherAction')
  - [#cctor()](#M-MFR-GUI-Launchers-Dialogs-Actions-Factories-GetDialogLauncherAction-#cctor 'MFR.GUI.Launchers.Dialogs.Actions.Factories.GetDialogLauncherAction.#cctor')
  - [For\`\`2(actionType)](#M-MFR-GUI-Launchers-Dialogs-Actions-Factories-GetDialogLauncherAction-For``2-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType- 'MFR.GUI.Launchers.Dialogs.Actions.Factories.GetDialogLauncherAction.For``2(MFR.GUI.Launchers.Dialogs.Actions.Constants.DialogLauncherActionType)')
- [Resources](#T-MFR-GUI-Launchers-Dialogs-Actions-Factories-Properties-Resources 'MFR.GUI.Launchers.Dialogs.Actions.Factories.Properties.Resources')
  - [Culture](#P-MFR-GUI-Launchers-Dialogs-Actions-Factories-Properties-Resources-Culture 'MFR.GUI.Launchers.Dialogs.Actions.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Launchers-Dialogs-Actions-Factories-Properties-Resources-ResourceManager 'MFR.GUI.Launchers.Dialogs.Actions.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Launchers-Dialogs-Actions-Factories-GetDialogLauncherAction'></a>
## GetDialogLauncherAction `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Actions.Factories

##### Summary

Creates instances of objects that implement the
[IAction](#T-MFR-Messages-Actions-Interfaces-IAction 'MFR.Messages.Actions.Interfaces.IAction')
interface and that summon and collect results from the various dialog boxes
that are invoked by the commands in this application.

<a name='M-MFR-GUI-Launchers-Dialogs-Actions-Factories-GetDialogLauncherAction-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[GetDialogLauncherAction](#T-MFR-GUI-Launchers-Dialogs-Actions-Factories-GetDialogLauncherAction 'MFR.GUI.Launchers.Dialogs.Actions.Factories.GetDialogLauncherAction')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-GUI-Launchers-Dialogs-Actions-Factories-GetDialogLauncherAction-For``2-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType-'></a>
### For\`\`2(actionType) `method`

##### Summary

Creates a new instance of an object that implements the
[IAction](#T-MFR-Messages-Actions-Interfaces-IAction 'MFR.Messages.Actions.Interfaces.IAction')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IAction](#T-MFR-Messages-Actions-Interfaces-IAction 'MFR.Messages.Actions.Interfaces.IAction')
interface
that corresponds to the specified
[MessageType](#T-MFR-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionType | [MFR.GUI.Launchers.Dialogs.Actions.Constants.DialogLauncherActionType](#T-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType 'MFR.GUI.Launchers.Dialogs.Actions.Constants.DialogLauncherActionType') | (Required.) A
[MessageType](#T-MFR-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType')
value that
indicates what action to execute. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if no action is available that corresponds to the
[MessageType](#T-MFR-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType')
value provided
in the `actionType` parameter. |

<a name='T-MFR-GUI-Launchers-Dialogs-Actions-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Actions.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Launchers-Dialogs-Actions-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Launchers-Dialogs-Actions-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
