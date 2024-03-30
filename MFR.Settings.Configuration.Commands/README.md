<a name='assembly'></a>
# MFR.Settings.Configuration.Commands

## Contents

- [Resources](#T-MFR-Settings-Configuration-Commands-Properties-Resources 'MFR.Settings.Configuration.Commands.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Commands-Properties-Resources-Culture 'MFR.Settings.Configuration.Commands.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Commands-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Commands.Properties.Resources.ResourceManager')
- [SaveConfigurationToFileCommand](#T-MFR-Settings-Configuration-Commands-SaveConfigurationToFileCommand 'MFR.Settings.Configuration.Commands.SaveConfigurationToFileCommand')
  - [#ctor()](#M-MFR-Settings-Configuration-Commands-SaveConfigurationToFileCommand-#ctor 'MFR.Settings.Configuration.Commands.SaveConfigurationToFileCommand.#ctor')
  - [Instance](#P-MFR-Settings-Configuration-Commands-SaveConfigurationToFileCommand-Instance 'MFR.Settings.Configuration.Commands.SaveConfigurationToFileCommand.Instance')
  - [MessageType](#P-MFR-Settings-Configuration-Commands-SaveConfigurationToFileCommand-MessageType 'MFR.Settings.Configuration.Commands.SaveConfigurationToFileCommand.MessageType')
  - [#cctor()](#M-MFR-Settings-Configuration-Commands-SaveConfigurationToFileCommand-#cctor 'MFR.Settings.Configuration.Commands.SaveConfigurationToFileCommand.#cctor')
  - [CommonExecute()](#M-MFR-Settings-Configuration-Commands-SaveConfigurationToFileCommand-CommonExecute 'MFR.Settings.Configuration.Commands.SaveConfigurationToFileCommand.CommonExecute')

<a name='T-MFR-Settings-Configuration-Commands-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Commands.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Commands-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Commands-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Settings-Configuration-Commands-SaveConfigurationToFileCommand'></a>
## SaveConfigurationToFileCommand `type`

##### Namespace

MFR.Settings.Configuration.Commands

##### Summary

Saves a config object, i.e., one that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface, to a JSON file.

##### Remarks

This command takes a reference to an instance of an object that
implements the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface as input, and does not return any output.



This command requires that the
[Path](#P-MFR-IFileSystemEntry-Path 'MFR.IFileSystemEntry.Path')
property be
initialized to the pathname where the config data should be
saved; preferably, the file should have the .json extension.



This command also requires that the
[UserState](#P-MFR-IFileSystemEntry-UserState 'MFR.IFileSystemEntry.UserState')
property
be initialized to a reference to the config object containing the
data that is to be saved.

<a name='M-MFR-Settings-Configuration-Commands-SaveConfigurationToFileCommand-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Configuration-Commands-SaveConfigurationToFileCommand-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[SavePathToRegistryAction](#T-MFR-SavePathToRegistryAction 'MFR.SavePathToRegistryAction')
.

<a name='P-MFR-Settings-Configuration-Commands-SaveConfigurationToFileCommand-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-MessageType 'MFR.MessageType') that is
being used to identify which message this.

<a name='M-MFR-Settings-Configuration-Commands-SaveConfigurationToFileCommand-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Commands-SaveConfigurationToFileCommand-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

##### Remarks

Implementers must override this method in order to return this
object's functionality.



This method is to stop executing, without throwing any exceptions,
if the input is `null`.
