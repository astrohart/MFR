<a name='assembly'></a>
# MFR.Configuration.Commands.Constants

## Contents

- [ConfigurationCommand](#T-MFR-Objects-Configuration-Commands-Constants-ConfigurationCommand 'MFR.Configuration.Commands.Constants.ConfigurationCommand')
  - [#ctor(messageId)](#M-MFR-Objects-Configuration-Commands-Constants-ConfigurationCommand-#ctor-System-Guid- 'MFR.Configuration.Commands.Constants.ConfigurationCommand.#ctor(System.Guid)')
  - [SaveConfigurationToFile](#F-MFR-Objects-Configuration-Commands-Constants-ConfigurationCommand-SaveConfigurationToFile 'MFR.Configuration.Commands.Constants.ConfigurationCommand.SaveConfigurationToFile')
  - [SaveStringToRegistry](#F-MFR-Objects-Configuration-Commands-Constants-ConfigurationCommand-SaveStringToRegistry 'MFR.Configuration.Commands.Constants.ConfigurationCommand.SaveStringToRegistry')
  - [Unknown](#F-MFR-Objects-Configuration-Commands-Constants-ConfigurationCommand-Unknown 'MFR.Configuration.Commands.Constants.ConfigurationCommand.Unknown')
- [ConfigurationCommandX](#T-MFR-Objects-Configuration-Commands-Constants-ConfigurationCommandX 'MFR.Configuration.Commands.Constants.ConfigurationCommandX')
- [Resources](#T-MFR-Objects-Configuration-Commands-Constants-Properties-Resources 'MFR.Configuration.Commands.Constants.Properties.Resources')
  - [Culture](#P-MFR-Objects-Configuration-Commands-Constants-Properties-Resources-Culture 'MFR.Configuration.Commands.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Configuration-Commands-Constants-Properties-Resources-ResourceManager 'MFR.Configuration.Commands.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Configuration-Commands-Constants-ConfigurationCommand'></a>
## ConfigurationCommand `type`

##### Namespace

MFR.Configuration.Commands.Constants

##### Summary

Available commands for use when working with configuration.

<a name='M-MFR-Objects-Configuration-Commands-Constants-ConfigurationCommand-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[ConfigurationCommand](#T-MFR-Objects-Configuration-Commands-Constants-ConfigurationCommand 'MFR.Configuration.Commands.Constants.ConfigurationCommand')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-Objects-Configuration-Commands-Constants-ConfigurationCommand-SaveConfigurationToFile'></a>
### SaveConfigurationToFile `constants`

##### Summary

Saves the configuration to a file.

<a name='F-MFR-Objects-Configuration-Commands-Constants-ConfigurationCommand-SaveStringToRegistry'></a>
### SaveStringToRegistry `constants`

##### Summary

Saves a string value to the system Registry.

<a name='F-MFR-Objects-Configuration-Commands-Constants-ConfigurationCommand-Unknown'></a>
### Unknown `constants`

##### Summary

Generic, unknown message.

<a name='T-MFR-Objects-Configuration-Commands-Constants-ConfigurationCommandX'></a>
## ConfigurationCommandX `type`

##### Namespace

MFR.Configuration.Commands.Constants

##### Summary

TODO

<a name='T-MFR-Objects-Configuration-Commands-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Configuration.Commands.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Configuration-Commands-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Configuration-Commands-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
