<a name='assembly'></a>
# MFR.Objects.Configuration.Actions.Constants

## Contents

- [ConfigurationAction](#T-MFR-Objects-Configuration-Actions-Constants-ConfigurationAction 'MFR.Objects.Configuration.Actions.Constants.ConfigurationAction')
  - [#ctor(messageId)](#M-MFR-Objects-Configuration-Actions-Constants-ConfigurationAction-#ctor-System-Guid- 'MFR.Objects.Configuration.Actions.Constants.ConfigurationAction.#ctor(System.Guid)')
  - [LoadConfigurationFromFile](#F-MFR-Objects-Configuration-Actions-Constants-ConfigurationAction-LoadConfigurationFromFile 'MFR.Objects.Configuration.Actions.Constants.ConfigurationAction.LoadConfigurationFromFile')
  - [LoadStringFromRegistry](#F-MFR-Objects-Configuration-Actions-Constants-ConfigurationAction-LoadStringFromRegistry 'MFR.Objects.Configuration.Actions.Constants.ConfigurationAction.LoadStringFromRegistry')
- [Resources](#T-MFR-Objects-Configuration-Actions-Constants-Properties-Resources 'MFR.Objects.Configuration.Actions.Constants.Properties.Resources')
  - [Culture](#P-MFR-Objects-Configuration-Actions-Constants-Properties-Resources-Culture 'MFR.Objects.Configuration.Actions.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Configuration-Actions-Constants-Properties-Resources-ResourceManager 'MFR.Objects.Configuration.Actions.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Configuration-Actions-Constants-ConfigurationAction'></a>
## ConfigurationAction `type`

##### Namespace

MFR.Objects.Configuration.Actions.Constants

##### Summary

Available actions for use when working with configuration.

<a name='M-MFR-Objects-Configuration-Actions-Constants-ConfigurationAction-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[ConfigurationAction](#T-MFR-Objects-Configuration-Actions-Constants-ConfigurationAction 'MFR.Objects.Configuration.Actions.Constants.ConfigurationAction')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-Objects-Configuration-Actions-Constants-ConfigurationAction-LoadConfigurationFromFile'></a>
### LoadConfigurationFromFile `constants`

##### Summary

Loads the configuration from a file.

<a name='F-MFR-Objects-Configuration-Actions-Constants-ConfigurationAction-LoadStringFromRegistry'></a>
### LoadStringFromRegistry `constants`

##### Summary

Loads a string value from the system Registry.

<a name='T-MFR-Objects-Configuration-Actions-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Configuration.Actions.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Configuration-Actions-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Configuration-Actions-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
