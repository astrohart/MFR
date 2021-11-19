<a name='assembly'></a>
# MFR.Settings.Configuration.Actions.Factories

## Contents

- [GetConfigurationAction](#T-MFR-Settings-Configuration-Actions-Factories-GetConfigurationAction 'MFR.Settings.Configuration.Actions.Factories.GetConfigurationAction')
  - [For\`\`2(actionType)](#M-MFR-Settings-Configuration-Actions-Factories-GetConfigurationAction-For``2-MFR-Settings-Configuration-Actions-Constants-ConfigurationAction- 'MFR.Settings.Configuration.Actions.Factories.GetConfigurationAction.For``2(MFR.Settings.Configuration.Actions.Constants.ConfigurationAction)')
- [Resources](#T-MFR-Settings-Configuration-Actions-Factories-Properties-Resources 'MFR.Settings.Configuration.Actions.Factories.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Actions-Factories-Properties-Resources-Culture 'MFR.Settings.Configuration.Actions.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Actions-Factories-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Actions.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Actions-Factories-GetConfigurationAction'></a>
## GetConfigurationAction `type`

##### Namespace

MFR.Settings.Configuration.Actions.Factories

##### Summary

Creates instances of objects that implement the
[IAction](#T-MFR-IAction 'MFR.IAction')
interface.

<a name='M-MFR-Settings-Configuration-Actions-Factories-GetConfigurationAction-For``2-MFR-Settings-Configuration-Actions-Constants-ConfigurationAction-'></a>
### For\`\`2(actionType) `method`

##### Summary

Creates a new instance of an object that implements the
[IAction](#T-MFR-IAction 'MFR.IAction')
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
| actionType | [MFR.Settings.Configuration.Actions.Constants.ConfigurationAction](#T-MFR-Settings-Configuration-Actions-Constants-ConfigurationAction 'MFR.Settings.Configuration.Actions.Constants.ConfigurationAction') | (Required.) A
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

<a name='T-MFR-Settings-Configuration-Actions-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Actions.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Actions-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Actions-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
