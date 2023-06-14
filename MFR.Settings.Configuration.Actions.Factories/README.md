<a name='assembly'></a>
# MFR.Settings.Configuration.Actions.Factories

## Contents

- [GetConfigAction](#T-MFR-Settings-Configuration-Actions-Factories-GetConfigAction 'MFR.Settings.Configuration.Actions.Factories.GetConfigAction')
  - [For\`\`2(actionType)](#M-MFR-Settings-Configuration-Actions-Factories-GetConfigAction-For``2-MFR-Settings-Configuration-Actions-Constants-ConfigActionType- 'MFR.Settings.Configuration.Actions.Factories.GetConfigAction.For``2(MFR.Settings.Configuration.Actions.Constants.ConfigActionType)')
- [GetLoadConfigurationFilePathFromRegistryAction](#T-MFR-Settings-Configuration-Actions-Factories-GetLoadConfigurationFilePathFromRegistryAction 'MFR.Settings.Configuration.Actions.Factories.GetLoadConfigurationFilePathFromRegistryAction')
  - [SoleInstance()](#M-MFR-Settings-Configuration-Actions-Factories-GetLoadConfigurationFilePathFromRegistryAction-SoleInstance 'MFR.Settings.Configuration.Actions.Factories.GetLoadConfigurationFilePathFromRegistryAction.SoleInstance')
- [GetLoadConfigurationFromFileAction](#T-MFR-Settings-Configuration-Actions-Factories-GetLoadConfigurationFromFileAction 'MFR.Settings.Configuration.Actions.Factories.GetLoadConfigurationFromFileAction')
  - [SoleInstance()](#M-MFR-Settings-Configuration-Actions-Factories-GetLoadConfigurationFromFileAction-SoleInstance 'MFR.Settings.Configuration.Actions.Factories.GetLoadConfigurationFromFileAction.SoleInstance')
- [Resources](#T-MFR-Settings-Configuration-Actions-Factories-Properties-Resources 'MFR.Settings.Configuration.Actions.Factories.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Actions-Factories-Properties-Resources-Culture 'MFR.Settings.Configuration.Actions.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Actions-Factories-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Actions.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Actions-Factories-GetConfigAction'></a>
## GetConfigAction `type`

##### Namespace

MFR.Settings.Configuration.Actions.Factories

##### Summary

Creates instances of objects that implement the
[IAction](#T-MFR-Messages-Actions-Interfaces-IAction 'MFR.Messages.Actions.Interfaces.IAction')
interface.

<a name='M-MFR-Settings-Configuration-Actions-Factories-GetConfigAction-For``2-MFR-Settings-Configuration-Actions-Constants-ConfigActionType-'></a>
### For\`\`2(actionType) `method`

##### Summary

Creates a new instance of an object that implements the
[IAction](#T-MFR-Messages-Actions-Interfaces-IAction 'MFR.Messages.Actions.Interfaces.IAction')
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
| actionType | [MFR.Settings.Configuration.Actions.Constants.ConfigActionType](#T-MFR-Settings-Configuration-Actions-Constants-ConfigActionType 'MFR.Settings.Configuration.Actions.Constants.ConfigActionType') | (Required.) A
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

<a name='T-MFR-Settings-Configuration-Actions-Factories-GetLoadConfigurationFilePathFromRegistryAction'></a>
## GetLoadConfigurationFilePathFromRegistryAction `type`

##### Namespace

MFR.Settings.Configuration.Actions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IFileSystemEntry}](#T-MFR-Messages-Actions-Interfaces-ICachedResultAction{MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String}, MFR-FileSystem-Interfaces-IFileSystemEntry} 'MFR.Messages.Actions.Interfaces.ICachedResultAction{MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String}, MFR.FileSystem.Interfaces.IFileSystemEntry}')
interface.

<a name='M-MFR-Settings-Configuration-Actions-Factories-GetLoadConfigurationFilePathFromRegistryAction-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IFileSystemEntry}](#T-MFR-Messages-Actions-Interfaces-ICachedResultAction{MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String}, MFR-FileSystem-Interfaces-IFileSystemEntry} 'MFR.Messages.Actions.Interfaces.ICachedResultAction{MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String}, MFR.FileSystem.Interfaces.IFileSystemEntry}')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IFileSystemEntry}](#T-MFR-Messages-Actions-Interfaces-ICachedResultAction{MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String}, MFR-FileSystem-Interfaces-IFileSystemEntry} 'MFR.Messages.Actions.Interfaces.ICachedResultAction{MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String}, MFR.FileSystem.Interfaces.IFileSystemEntry}')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Actions-Factories-GetLoadConfigurationFromFileAction'></a>
## GetLoadConfigurationFromFileAction `type`

##### Namespace

MFR.Settings.Configuration.Actions.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IProjectFileRenamerConfiguration}](#T-MFR-Messages-Actions-Interfaces-IAction{MFR-FileSystem-Interfaces-IFileSystemEntry, MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration} 'MFR.Messages.Actions.Interfaces.IAction{MFR.FileSystem.Interfaces.IFileSystemEntry, MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration}')
interface.

<a name='M-MFR-Settings-Configuration-Actions-Factories-GetLoadConfigurationFromFileAction-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IProjectFileRenamerConfiguration}](#T-MFR-Messages-Actions-Interfaces-IAction{MFR-FileSystem-Interfaces-IFileSystemEntry, MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration} 'MFR.Messages.Actions.Interfaces.IAction{MFR.FileSystem.Interfaces.IFileSystemEntry, MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration}')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IProjectFileRenamerConfiguration}](#T-MFR-Messages-Actions-Interfaces-IAction{MFR-FileSystem-Interfaces-IFileSystemEntry, MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration} 'MFR.Messages.Actions.Interfaces.IAction{MFR.FileSystem.Interfaces.IFileSystemEntry, MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration}')
interface.

##### Parameters

This method has no parameters.

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
