<a name='assembly'></a>
# MFR.GUI.Launchers.Dialogs.Factories

## Contents

- [GetErrorReportDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-Factories-GetErrorReportDialogLauncher 'MFR.GUI.Launchers.Dialogs.Factories.GetErrorReportDialogLauncher')
  - [SoleInstance()](#M-MFR-GUI-Launchers-Dialogs-Factories-GetErrorReportDialogLauncher-SoleInstance 'MFR.GUI.Launchers.Dialogs.Factories.GetErrorReportDialogLauncher.SoleInstance')
- [GetHelpProfileExplainerDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-Factories-GetHelpProfileExplainerDialogLauncher 'MFR.GUI.Launchers.Dialogs.Factories.GetHelpProfileExplainerDialogLauncher')
  - [SoleInstance()](#M-MFR-GUI-Launchers-Dialogs-Factories-GetHelpProfileExplainerDialogLauncher-SoleInstance 'MFR.GUI.Launchers.Dialogs.Factories.GetHelpProfileExplainerDialogLauncher.SoleInstance')
- [Resources](#T-MFR-GUI-Launchers-Dialogs-Factories-Properties-Resources 'MFR.GUI.Launchers.Dialogs.Factories.Properties.Resources')
  - [Culture](#P-MFR-GUI-Launchers-Dialogs-Factories-Properties-Resources-Culture 'MFR.GUI.Launchers.Dialogs.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Launchers-Dialogs-Factories-Properties-Resources-ResourceManager 'MFR.GUI.Launchers.Dialogs.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Launchers-Dialogs-Factories-GetErrorReportDialogLauncher'></a>
## GetErrorReportDialogLauncher `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Factories

##### Summary

Creates instances of objects that implement the
[IErrorReportDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-Interfaces-IErrorReportDialogLauncher 'MFR.GUI.Launchers.Dialogs.Interfaces.IErrorReportDialogLauncher')
interface.

<a name='M-MFR-GUI-Launchers-Dialogs-Factories-GetErrorReportDialogLauncher-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Creates a new instance of an object that implements the
[IErrorReportDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-Interfaces-IErrorReportDialogLauncher 'MFR.GUI.Launchers.Dialogs.Interfaces.IErrorReportDialogLauncher')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IErrorReportDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-Interfaces-IErrorReportDialogLauncher 'MFR.GUI.Launchers.Dialogs.Interfaces.IErrorReportDialogLauncher')
interface.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object type requested is not supported. |

<a name='T-MFR-GUI-Launchers-Dialogs-Factories-GetHelpProfileExplainerDialogLauncher'></a>
## GetHelpProfileExplainerDialogLauncher `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Factories

##### Summary

Creates instances of objects that implement the
[HelpProfileExplainerDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-Interfaces-HelpProfileExplainerDialogLauncher 'MFR.GUI.Launchers.Dialogs.Interfaces.HelpProfileExplainerDialogLauncher')
interface.

<a name='M-MFR-GUI-Launchers-Dialogs-Factories-GetHelpProfileExplainerDialogLauncher-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Creates a new instance of an object that implements the
[HelpProfileExplainerDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-Interfaces-HelpProfileExplainerDialogLauncher 'MFR.GUI.Launchers.Dialogs.Interfaces.HelpProfileExplainerDialogLauncher')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[HelpProfileExplainerDialogLauncher](#T-MFR-GUI-Launchers-Dialogs-Interfaces-HelpProfileExplainerDialogLauncher 'MFR.GUI.Launchers.Dialogs.Interfaces.HelpProfileExplainerDialogLauncher')
interface.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object type requested is not supported. |

<a name='T-MFR-GUI-Launchers-Dialogs-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Launchers-Dialogs-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Launchers-Dialogs-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
