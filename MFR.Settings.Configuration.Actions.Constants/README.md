<a name='assembly'></a>
# MFR.Settings.Configuration.Actions.Constants

## Contents

- [ConfigActionType](#T-MFR-Settings-Configuration-Actions-Constants-ConfigActionType 'MFR.Settings.Configuration.Actions.Constants.ConfigActionType')
  - [#ctor(messageId)](#M-MFR-Settings-Configuration-Actions-Constants-ConfigActionType-#ctor-System-Guid- 'MFR.Settings.Configuration.Actions.Constants.ConfigActionType.#ctor(System.Guid)')
  - [#ctor(description,messageId)](#M-MFR-Settings-Configuration-Actions-Constants-ConfigActionType-#ctor-System-Guid,System-String- 'MFR.Settings.Configuration.Actions.Constants.ConfigActionType.#ctor(System.Guid,System.String)')
  - [LoadConfigFilePathFromRegistry](#F-MFR-Settings-Configuration-Actions-Constants-ConfigActionType-LoadConfigFilePathFromRegistry 'MFR.Settings.Configuration.Actions.Constants.ConfigActionType.LoadConfigFilePathFromRegistry')
  - [LoadConfigFromFile](#F-MFR-Settings-Configuration-Actions-Constants-ConfigActionType-LoadConfigFromFile 'MFR.Settings.Configuration.Actions.Constants.ConfigActionType.LoadConfigFromFile')
- [Resources](#T-MFR-Settings-Configuration-Actions-Constants-Properties-Resources 'MFR.Settings.Configuration.Actions.Constants.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Actions-Constants-Properties-Resources-Culture 'MFR.Settings.Configuration.Actions.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Actions-Constants-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Actions.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Actions-Constants-ConfigActionType'></a>
## ConfigActionType `type`

##### Namespace

MFR.Settings.Configuration.Actions.Constants

##### Summary

Available actions for use when working with configuration.

<a name='M-MFR-Settings-Configuration-Actions-Constants-ConfigActionType-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[ConfigurationAction](#T-MFR-Settings-Configuration-Actions-Constants-ConfigurationAction 'MFR.Settings.Configuration.Actions.Constants.ConfigurationAction')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='M-MFR-Settings-Configuration-Actions-Constants-ConfigActionType-#ctor-System-Guid,System-String-'></a>
### #ctor(description,messageId) `constructor`

##### Summary

Constructs a new instance of
[ConfigurationAction](#T-MFR-Settings-Configuration-Actions-Constants-ConfigurationAction 'MFR.Settings.Configuration.Actions.Constants.ConfigurationAction')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a user-friendly
descriptive name for this message type. |
| messageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-Settings-Configuration-Actions-Constants-ConfigActionType-LoadConfigFilePathFromRegistry'></a>
### LoadConfigFilePathFromRegistry `constants`

##### Summary

Loads a string value from the system Registry.

<a name='F-MFR-Settings-Configuration-Actions-Constants-ConfigActionType-LoadConfigFromFile'></a>
### LoadConfigFromFile `constants`

##### Summary

Loads the configuration from a file.

<a name='T-MFR-Settings-Configuration-Actions-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Actions.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Actions-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Actions-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
