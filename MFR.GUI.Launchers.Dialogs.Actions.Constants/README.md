<a name='assembly'></a>
# MFR.GUI.Launchers.Dialogs.Actions.Constants

## Contents

- [DialogLauncherActionType](#T-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType 'MFR.GUI.Launchers.Dialogs.Actions.Constants.DialogLauncherActionType')
  - [#ctor(messageId)](#M-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType-#ctor-System-Guid- 'MFR.GUI.Launchers.Dialogs.Actions.Constants.DialogLauncherActionType.#ctor(System.Guid)')
  - [#ctor(description,messageId)](#M-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType-#ctor-System-Guid,System-String- 'MFR.GUI.Launchers.Dialogs.Actions.Constants.DialogLauncherActionType.#ctor(System.Guid,System.String)')
  - [LaunchErrorReportDialog](#F-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType-LaunchErrorReportDialog 'MFR.GUI.Launchers.Dialogs.Actions.Constants.DialogLauncherActionType.LaunchErrorReportDialog')
  - [LaunchHelpExplainerDialog](#F-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType-LaunchHelpExplainerDialog 'MFR.GUI.Launchers.Dialogs.Actions.Constants.DialogLauncherActionType.LaunchHelpExplainerDialog')
  - [LaunchProfileNameDialog](#F-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType-LaunchProfileNameDialog 'MFR.GUI.Launchers.Dialogs.Actions.Constants.DialogLauncherActionType.LaunchProfileNameDialog')
- [Resources](#T-MFR-GUI-Launchers-Dialogs-Actions-Constants-Properties-Resources 'MFR.GUI.Launchers.Dialogs.Actions.Constants.Properties.Resources')
  - [Culture](#P-MFR-GUI-Launchers-Dialogs-Actions-Constants-Properties-Resources-Culture 'MFR.GUI.Launchers.Dialogs.Actions.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Launchers-Dialogs-Actions-Constants-Properties-Resources-ResourceManager 'MFR.GUI.Launchers.Dialogs.Actions.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType'></a>
## DialogLauncherActionType `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Actions.Constants

##### Summary

Available commands for use when working with error reports.

<a name='M-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[DialogLauncherActionType](#T-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType 'MFR.GUI.Launchers.Dialogs.Actions.Constants.DialogLauncherActionType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='M-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType-#ctor-System-Guid,System-String-'></a>
### #ctor(description,messageId) `constructor`

##### Summary

Constructs a new instance of
[DialogLauncherActionType](#T-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType 'MFR.GUI.Launchers.Dialogs.Actions.Constants.DialogLauncherActionType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a user-friendly
descriptive name for this message type. |
| messageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType-LaunchErrorReportDialog'></a>
### LaunchErrorReportDialog `constants`

##### Summary

Launches the Profile Name dialog box.

<a name='F-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType-LaunchHelpExplainerDialog'></a>
### LaunchHelpExplainerDialog `constants`

##### Summary

Launches the Help dialog that explains what Profiles are.

<a name='F-MFR-GUI-Launchers-Dialogs-Actions-Constants-DialogLauncherActionType-LaunchProfileNameDialog'></a>
### LaunchProfileNameDialog `constants`

##### Summary

Launches the Profile Name dialog box.

<a name='T-MFR-GUI-Launchers-Dialogs-Actions-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Actions.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Launchers-Dialogs-Actions-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Launchers-Dialogs-Actions-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
