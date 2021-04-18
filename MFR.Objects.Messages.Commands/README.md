<a name='assembly'></a>
# MFR.Objects.Messages.Commands

## Contents

- [CommandBase\`1](#T-MFR-Objects-Messages-Commands-CommandBase`1 'MFR.Objects.Messages.Commands.CommandBase`1')
  - [#ctor()](#M-MFR-Objects-Messages-Commands-CommandBase`1-#ctor 'MFR.Objects.Messages.Commands.CommandBase`1.#ctor')
  - [#ctor()](#M-MFR-Objects-Messages-Commands-CommandBase`1-#ctor-`0- 'MFR.Objects.Messages.Commands.CommandBase`1.#ctor(`0)')
  - [_input](#F-MFR-Objects-Messages-Commands-CommandBase`1-_input 'MFR.Objects.Messages.Commands.CommandBase`1._input')
  - [CommonExecute()](#M-MFR-Objects-Messages-Commands-CommandBase`1-CommonExecute 'MFR.Objects.Messages.Commands.CommandBase`1.CommonExecute')
  - [Execute()](#M-MFR-Objects-Messages-Commands-CommandBase`1-Execute 'MFR.Objects.Messages.Commands.CommandBase`1.Execute')
  - [ExecuteAsync()](#M-MFR-Objects-Messages-Commands-CommandBase`1-ExecuteAsync 'MFR.Objects.Messages.Commands.CommandBase`1.ExecuteAsync')
  - [WithInput(input)](#M-MFR-Objects-Messages-Commands-CommandBase`1-WithInput-`0- 'MFR.Objects.Messages.Commands.CommandBase`1.WithInput(`0)')
- [Resources](#T-MFR-Objects-Messages-Commands-Properties-Resources 'MFR.Objects.Messages.Commands.Properties.Resources')
  - [Culture](#P-MFR-Objects-Messages-Commands-Properties-Resources-Culture 'MFR.Objects.Messages.Commands.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Messages-Commands-Properties-Resources-ResourceManager 'MFR.Objects.Messages.Commands.Properties.Resources.ResourceManager')
- [SaveConfigurationToFileCommand](#T-MFR-Objects-Messages-Commands-SaveConfigurationToFileCommand 'MFR.Objects.Messages.Commands.SaveConfigurationToFileCommand')
  - [#ctor()](#M-MFR-Objects-Messages-Commands-SaveConfigurationToFileCommand-#ctor 'MFR.Objects.Messages.Commands.SaveConfigurationToFileCommand.#ctor')
  - [Instance](#P-MFR-Objects-Messages-Commands-SaveConfigurationToFileCommand-Instance 'MFR.Objects.Messages.Commands.SaveConfigurationToFileCommand.Instance')
  - [MessageType](#P-MFR-Objects-Messages-Commands-SaveConfigurationToFileCommand-MessageType 'MFR.Objects.Messages.Commands.SaveConfigurationToFileCommand.MessageType')
  - [#cctor()](#M-MFR-Objects-Messages-Commands-SaveConfigurationToFileCommand-#cctor 'MFR.Objects.Messages.Commands.SaveConfigurationToFileCommand.#cctor')
  - [CommonExecute()](#M-MFR-Objects-Messages-Commands-SaveConfigurationToFileCommand-CommonExecute 'MFR.Objects.Messages.Commands.SaveConfigurationToFileCommand.CommonExecute')
- [SaveStringToRegistryCommand](#T-MFR-Objects-Messages-Commands-SaveStringToRegistryCommand 'MFR.Objects.Messages.Commands.SaveStringToRegistryCommand')
  - [#ctor()](#M-MFR-Objects-Messages-Commands-SaveStringToRegistryCommand-#ctor 'MFR.Objects.Messages.Commands.SaveStringToRegistryCommand.#ctor')
  - [Instance](#P-MFR-Objects-Messages-Commands-SaveStringToRegistryCommand-Instance 'MFR.Objects.Messages.Commands.SaveStringToRegistryCommand.Instance')
  - [MessageType](#P-MFR-Objects-Messages-Commands-SaveStringToRegistryCommand-MessageType 'MFR.Objects.Messages.Commands.SaveStringToRegistryCommand.MessageType')
  - [#cctor()](#M-MFR-Objects-Messages-Commands-SaveStringToRegistryCommand-#cctor 'MFR.Objects.Messages.Commands.SaveStringToRegistryCommand.#cctor')
  - [CommonExecute()](#M-MFR-Objects-Messages-Commands-SaveStringToRegistryCommand-CommonExecute 'MFR.Objects.Messages.Commands.SaveStringToRegistryCommand.CommonExecute')

<a name='T-MFR-Objects-Messages-Commands-CommandBase`1'></a>
## CommandBase\`1 `type`

##### Namespace

MFR.Objects.Messages.Commands

##### Summary

Defines the methods, properties, events, and other functionality that is
shared among all command objects.



In our vocabulary, a `command` object is an object that performs an
operation but only accepts input and never returns any output.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TInput | Name of the class or data type that contains information used to execute
the message.



This object is composed with the message object at runtime. |

<a name='M-MFR-Objects-Messages-Commands-CommandBase`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ActionBase](#T-MFR-Objects-ActionBase 'MFR.Objects.ActionBase')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Objects-Messages-Commands-CommandBase`1-#ctor-`0-'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ActionBase](#T-MFR-Objects-ActionBase 'MFR.Objects.ActionBase')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Objects-Messages-Commands-CommandBase`1-_input'></a>
### _input `constants`

##### Summary

Reference to an instance of `TInput` that
contains the input data.

<a name='M-MFR-Objects-Messages-Commands-CommandBase`1-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

##### Remarks

Implementers must override this method in order to return this
object's functionality.

<a name='M-MFR-Objects-Messages-Commands-CommandBase`1-Execute'></a>
### Execute() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Messages-Commands-CommandBase`1-ExecuteAsync'></a>
### ExecuteAsync() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Messages-Commands-CommandBase`1-WithInput-`0-'></a>
### WithInput(input) `method`

##### Summary

Composes this object's `input` with it.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [\`0](#T-`0 '`0') | (Required.) Reference to an instance of
`TInput`
that contains data to be provided to the message. |

<a name='T-MFR-Objects-Messages-Commands-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Messages.Commands.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Messages-Commands-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Messages-Commands-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-Messages-Commands-SaveConfigurationToFileCommand'></a>
## SaveConfigurationToFileCommand `type`

##### Namespace

MFR.Objects.Messages.Commands

##### Summary

Saves a configuration object, i.e., one that implements the
[IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.Objects.IConfiguration')
interface, to a JSON file.

##### Remarks

This command takes a reference to an instance of an object that
implements the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
interface as input, and does not return any output.



This command requires that the
[Path](#P-MFR-Objects-IFileSystemEntry-Path 'MFR.Objects.IFileSystemEntry.Path')
property be
initialized to the pathname where the configuration data should be
saved; preferably, the file should have the .json extension.



This command also requires that the
[UserState](#P-MFR-Objects-IFileSystemEntry-UserState 'MFR.Objects.IFileSystemEntry.UserState')
property
be initialized to a reference to the configuration object containing the
data that is to be saved.

<a name='M-MFR-Objects-Messages-Commands-SaveConfigurationToFileCommand-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Messages-Commands-SaveConfigurationToFileCommand-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[SavePathToRegistryAction](#T-MFR-Objects-SavePathToRegistryAction 'MFR.Objects.SavePathToRegistryAction')
.

<a name='P-MFR-Objects-Messages-Commands-SaveConfigurationToFileCommand-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-Objects-MessageType 'MFR.Objects.MessageType') that is
being used to identify which message this is.

<a name='M-MFR-Objects-Messages-Commands-SaveConfigurationToFileCommand-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Messages-Commands-SaveConfigurationToFileCommand-CommonExecute'></a>
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

<a name='T-MFR-Objects-Messages-Commands-SaveStringToRegistryCommand'></a>
## SaveStringToRegistryCommand `type`

##### Namespace

MFR.Objects.Messages.Commands

##### Summary

Saves a string to a key in the system Registry.

<a name='M-MFR-Objects-Messages-Commands-SaveStringToRegistryCommand-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Messages-Commands-SaveStringToRegistryCommand-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[SavePathToRegistryAction](#T-MFR-Objects-SavePathToRegistryAction 'MFR.Objects.SavePathToRegistryAction')
.

<a name='P-MFR-Objects-Messages-Commands-SaveStringToRegistryCommand-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-Objects-MessageType 'MFR.Objects.MessageType') that is
being used to identify which message this is.

<a name='M-MFR-Objects-Messages-Commands-SaveStringToRegistryCommand-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Messages-Commands-SaveStringToRegistryCommand-CommonExecute'></a>
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
