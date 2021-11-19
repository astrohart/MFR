<a name='assembly'></a>
# MFR.Settings.Configuration.Commands.Constants

## Contents

- [ConfigurationCommand](#T-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommand 'MFR.Settings.Configuration.Commands.Constants.ConfigurationCommand')
  - [#ctor(messageId)](#M-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommand-#ctor-System-Guid- 'MFR.Settings.Configuration.Commands.Constants.ConfigurationCommand.#ctor(System.Guid)')
  - [SaveConfigurationFilePathToRegistry](#F-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommand-SaveConfigurationFilePathToRegistry 'MFR.Settings.Configuration.Commands.Constants.ConfigurationCommand.SaveConfigurationFilePathToRegistry')
  - [SaveConfigurationToFile](#F-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommand-SaveConfigurationToFile 'MFR.Settings.Configuration.Commands.Constants.ConfigurationCommand.SaveConfigurationToFile')
  - [Unknown](#F-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommand-Unknown 'MFR.Settings.Configuration.Commands.Constants.ConfigurationCommand.Unknown')
- [Resources](#T-MFR-Settings-Configuration-Commands-Constants-Properties-Resources 'MFR.Settings.Configuration.Commands.Constants.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Commands-Constants-Properties-Resources-Culture 'MFR.Settings.Configuration.Commands.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Commands-Constants-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Commands.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommand'></a>
## ConfigurationCommand `type`

##### Namespace

MFR.Settings.Configuration.Commands.Constants

##### Summary

Available commands for use when working with configuration.

<a name='M-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommand-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[ConfigurationCommand](#T-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommand 'MFR.Settings.Configuration.Commands.Constants.ConfigurationCommand')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommand-SaveConfigurationFilePathToRegistry'></a>
### SaveConfigurationFilePathToRegistry `constants`

##### Summary

Saves a string value to the system Registry.

<a name='F-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommand-SaveConfigurationToFile'></a>
### SaveConfigurationToFile `constants`

##### Summary

Saves the configuration to a file.

<a name='F-MFR-Settings-Configuration-Commands-Constants-ConfigurationCommand-Unknown'></a>
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
