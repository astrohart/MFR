<a name='assembly'></a>
# MFR.Objects.Configuration.Actions.Factories

## Contents

- [GetConfigurationAction](#T-MFR-Objects-Configuration-Actions-Factories-GetConfigurationAction 'MFR.Objects.Configuration.Actions.Factories.GetConfigurationAction')
  - [For\`\`2(actionType)](#M-MFR-Objects-Configuration-Actions-Factories-GetConfigurationAction-For``2-MFR-Objects-Configuration-Actions-Constants-ConfigurationAction- 'MFR.Objects.Configuration.Actions.Factories.GetConfigurationAction.For``2(MFR.Objects.Configuration.Actions.Constants.ConfigurationAction)')
- [Resources](#T-MFR-Objects-Configuration-Actions-Factories-Properties-Resources 'MFR.Objects.Configuration.Actions.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Configuration-Actions-Factories-Properties-Resources-Culture 'MFR.Objects.Configuration.Actions.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Configuration-Actions-Factories-Properties-Resources-ResourceManager 'MFR.Objects.Configuration.Actions.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Configuration-Actions-Factories-GetConfigurationAction'></a>
## GetConfigurationAction `type`

##### Namespace

MFR.Objects.Configuration.Actions.Factories

##### Summary

Creates instances of objects that implement the
[IAction](#T-MFR-Objects-IAction 'MFR.Objects.IAction')
interface.

<a name='M-MFR-Objects-Configuration-Actions-Factories-GetConfigurationAction-For``2-MFR-Objects-Configuration-Actions-Constants-ConfigurationAction-'></a>
### For\`\`2(actionType) `method`

##### Summary

Creates a new instance of an object that implements the
[IAction](#T-MFR-Objects-IAction 'MFR.Objects.IAction')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IAction](#T-MFR-Objects-Messages-Actions-Interfaces-IAction 'MFR.Objects.Messages.Actions.Interfaces.IAction')
interface
that corresponds to the specified
[MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Objects.Messages.Constants.MessageType').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionType | [MFR.Objects.Configuration.Actions.Constants.ConfigurationAction](#T-MFR-Objects-Configuration-Actions-Constants-ConfigurationAction 'MFR.Objects.Configuration.Actions.Constants.ConfigurationAction') | (Required.) A
[MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Objects.Messages.Constants.MessageType')
value that
indicates what action to execute. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if no action is available that corresponds to the
[MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Objects.Messages.Constants.MessageType')
value provided
in the `actionType` parameter. |

<a name='T-MFR-Objects-Configuration-Actions-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Configuration.Actions.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Configuration-Actions-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Configuration-Actions-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.