<a name='assembly'></a>
# MFR.Settings.Configuration.Commands.Constants

## Contents

- [ConfigurationCommandType](#T-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommandType 'MFR.Settings.Configuration.Commands.Constants.ConfigurationCommandType')
  - [#ctor(messageId)](#M-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommandType-#ctor-System-Guid- 'MFR.Settings.Configuration.Commands.Constants.ConfigurationCommandType.#ctor(System.Guid)')
  - [#ctor(description,messageId)](#M-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommandType-#ctor-System-Guid,System-String- 'MFR.Settings.Configuration.Commands.Constants.ConfigurationCommandType.#ctor(System.Guid,System.String)')
  - [SaveConfigurationFilePathToRegistry](#F-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommandType-SaveConfigurationFilePathToRegistry 'MFR.Settings.Configuration.Commands.Constants.ConfigurationCommandType.SaveConfigurationFilePathToRegistry')
  - [SaveConfigurationToFile](#F-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommandType-SaveConfigurationToFile 'MFR.Settings.Configuration.Commands.Constants.ConfigurationCommandType.SaveConfigurationToFile')
  - [Unknown](#F-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommandType-Unknown 'MFR.Settings.Configuration.Commands.Constants.ConfigurationCommandType.Unknown')
- [Resources](#T-MFR-Settings-Configuration-Commands-Constants-Properties-Resources 'MFR.Settings.Configuration.Commands.Constants.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Commands-Constants-Properties-Resources-Culture 'MFR.Settings.Configuration.Commands.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Commands-Constants-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Commands.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommandType'></a>
## ConfigurationCommandType `type`

##### Namespace

MFR.Settings.Configuration.Commands.Constants

##### Summary

Available commands for use when working with configuration.

<a name='M-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommandType-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[ConfigurationCommandType](#T-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommandType 'MFR.Settings.Configuration.Commands.Constants.ConfigurationCommandType')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='M-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommandType-#ctor-System-Guid,System-String-'></a>
### #ctor(description,messageId) `constructor`

##### Summary

Constructs a new instance of
[ConfigurationCommandType](#T-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommandType 'MFR.Settings.Configuration.Commands.Constants.ConfigurationCommandType')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a user-friendly
descriptive name for this message type. |
| messageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommandType-SaveConfigurationFilePathToRegistry'></a>
### SaveConfigurationFilePathToRegistry `constants`

##### Summary

Saves a string value to the system Registry.

<a name='F-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommandType-SaveConfigurationToFile'></a>
### SaveConfigurationToFile `constants`

##### Summary

Saves the configuration to a file.

<a name='F-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommandType-Unknown'></a>
### Unknown `constants`

##### Summary

Generic, unknown message.

<a name='T-MFR-Settings-Configuration-Commands-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Commands.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Commands-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Commands-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
