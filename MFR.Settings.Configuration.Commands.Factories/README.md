<a name='assembly'></a>
# MFR.Settings.Configuration.Commands.Factories

## Contents

- [GetConfigurationCommand](#T-MFR-Settings-Configuration-Commands-Factories-GetConfigurationCommand 'MFR.Settings.Configuration.Commands.Factories.GetConfigurationCommand')
  - [For\`\`1()](#M-MFR-Settings-Configuration-Commands-Factories-GetConfigurationCommand-For``1-MFR-Messages-Constants-MessageType- 'MFR.Settings.Configuration.Commands.Factories.GetConfigurationCommand.For``1(MFR.Messages.Constants.MessageType)')
- [GetSaveConfigPathCommand](#T-MFR-Settings-Configuration-Commands-Factories-GetSaveConfigPathCommand 'MFR.Settings.Configuration.Commands.Factories.GetSaveConfigPathCommand')
  - [ForPath(keyPath,valueName,value)](#M-MFR-Settings-Configuration-Commands-Factories-GetSaveConfigPathCommand-ForPath-System-String,System-String,System-String- 'MFR.Settings.Configuration.Commands.Factories.GetSaveConfigPathCommand.ForPath(System.String,System.String,System.String)')
- [Resources](#T-MFR-Settings-Configuration-Commands-Factories-Properties-Resources 'MFR.Settings.Configuration.Commands.Factories.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Commands-Factories-Properties-Resources-Culture 'MFR.Settings.Configuration.Commands.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Commands-Factories-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Commands.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Commands-Factories-GetConfigurationCommand'></a>
## GetConfigurationCommand `type`

##### Namespace

MFR.Settings.Configuration.Commands.Factories

##### Summary

Creates instances of objects that implement the [ICommand](#T-MFR-ICommand 'MFR.ICommand') interface, that define operations on the configuration file and its data.

##### Remarks

In our vernacular, a `command` object is an object that performs an
operation that accepts input, but has no output.

<a name='M-MFR-Settings-Configuration-Commands-Factories-GetConfigurationCommand-For``1-MFR-Messages-Constants-MessageType-'></a>
### For\`\`1() `method`

##### Summary

Creates a new instance of an object that implements the [ICommand](#T-MFR-ICommand 'MFR.ICommand') interface and returns a reference to it.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Commands-Factories-GetSaveConfigPathCommand'></a>
## GetSaveConfigPathCommand `type`

##### Namespace

MFR.Settings.Configuration.Commands.Factories

##### Summary

Gets a reference to an instance of an object that implements the
[ICommand](#T-MFR-ICommand 'MFR.ICommand')
interface and provides access to the
operation of saving the path of a configuration file to the system Registry.

<a name='M-MFR-Settings-Configuration-Commands-Factories-GetSaveConfigPathCommand-ForPath-System-String,System-String,System-String-'></a>
### ForPath(keyPath,valueName,value) `method`

##### Summary

Provides access to the [ICommand](#T-MFR-ICommand 'MFR.ICommand')
-derived object that allows saving the pathname of a configuration
file to the system Registry.

##### Returns

Reference to an instance of an object that implements the
[ICommand](#T-MFR-Messages-Commands-Interfaces-ICommand 'MFR.Messages.Commands.Interfaces.ICommand')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the path to the key in the system
Registry under which the config file's pathname is to be saved. |
| valueName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the value under the
Registry key where the config file's pathname is to be saved. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Fully-qualified pathname that is to be saved in the
system Registry. This value can, optionally, be surrounded by double
quotation marks, which become mandatory in the case that the path
contains spaces. |

<a name='T-MFR-Settings-Configuration-Commands-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Commands.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Commands-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Commands-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
