<a name='assembly'></a>
# MFR.Messages.Commands

## Contents

- [CommandBase\`1](#T-MFR-Messages-Commands-CommandBase`1 'MFR.Messages.Commands.CommandBase`1')
  - [#ctor()](#M-MFR-Messages-Commands-CommandBase`1-#ctor 'MFR.Messages.Commands.CommandBase`1.#ctor')
  - [#ctor()](#M-MFR-Messages-Commands-CommandBase`1-#ctor-`0- 'MFR.Messages.Commands.CommandBase`1.#ctor(`0)')
  - [Input](#P-MFR-Messages-Commands-CommandBase`1-Input 'MFR.Messages.Commands.CommandBase`1.Input')
  - [CommonExecute()](#M-MFR-Messages-Commands-CommandBase`1-CommonExecute 'MFR.Messages.Commands.CommandBase`1.CommonExecute')
  - [Execute()](#M-MFR-Messages-Commands-CommandBase`1-Execute 'MFR.Messages.Commands.CommandBase`1.Execute')
  - [ExecuteAsync()](#M-MFR-Messages-Commands-CommandBase`1-ExecuteAsync 'MFR.Messages.Commands.CommandBase`1.ExecuteAsync')
  - [WithInput(input)](#M-MFR-Messages-Commands-CommandBase`1-WithInput-`0- 'MFR.Messages.Commands.CommandBase`1.WithInput(`0)')
- [Resources](#T-MFR-Messages-Commands-Properties-Resources 'MFR.Messages.Commands.Properties.Resources')
  - [Culture](#P-MFR-Messages-Commands-Properties-Resources-Culture 'MFR.Messages.Commands.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Messages-Commands-Properties-Resources-ResourceManager 'MFR.Messages.Commands.Properties.Resources.ResourceManager')
- [SaveStringToRegistryCommand](#T-MFR-Messages-Commands-SaveStringToRegistryCommand 'MFR.Messages.Commands.SaveStringToRegistryCommand')
  - [#ctor()](#M-MFR-Messages-Commands-SaveStringToRegistryCommand-#ctor 'MFR.Messages.Commands.SaveStringToRegistryCommand.#ctor')
  - [Instance](#P-MFR-Messages-Commands-SaveStringToRegistryCommand-Instance 'MFR.Messages.Commands.SaveStringToRegistryCommand.Instance')
  - [MessageType](#P-MFR-Messages-Commands-SaveStringToRegistryCommand-MessageType 'MFR.Messages.Commands.SaveStringToRegistryCommand.MessageType')
  - [#cctor()](#M-MFR-Messages-Commands-SaveStringToRegistryCommand-#cctor 'MFR.Messages.Commands.SaveStringToRegistryCommand.#cctor')
  - [CommonExecute()](#M-MFR-Messages-Commands-SaveStringToRegistryCommand-CommonExecute 'MFR.Messages.Commands.SaveStringToRegistryCommand.CommonExecute')

<a name='T-MFR-Messages-Commands-CommandBase`1'></a>
## CommandBase\`1 `type`

##### Namespace

MFR.Messages.Commands

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

<a name='M-MFR-Messages-Commands-CommandBase`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ActionBase](#T-MFR-ActionBase 'MFR.ActionBase')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Messages-Commands-CommandBase`1-#ctor-`0-'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ActionBase](#T-MFR-ActionBase 'MFR.ActionBase')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Messages-Commands-CommandBase`1-Input'></a>
### Input `property`

##### Summary

Reference to an instance of `TInput` that
contains the input data.

<a name='M-MFR-Messages-Commands-CommandBase`1-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

##### Remarks

Implementers must override this method in order to return this
object's functionality.

<a name='M-MFR-Messages-Commands-CommandBase`1-Execute'></a>
### Execute() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

<a name='M-MFR-Messages-Commands-CommandBase`1-ExecuteAsync'></a>
### ExecuteAsync() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

<a name='M-MFR-Messages-Commands-CommandBase`1-WithInput-`0-'></a>
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

<a name='T-MFR-Messages-Commands-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Messages.Commands.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Messages-Commands-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Messages-Commands-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Messages-Commands-SaveStringToRegistryCommand'></a>
## SaveStringToRegistryCommand `type`

##### Namespace

MFR.Messages.Commands

##### Summary

Saves a string to a key in the system Registry.

<a name='M-MFR-Messages-Commands-SaveStringToRegistryCommand-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Messages-Commands-SaveStringToRegistryCommand-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[SavePathToRegistryAction](#T-MFR-SavePathToRegistryAction 'MFR.SavePathToRegistryAction')
.

<a name='P-MFR-Messages-Commands-SaveStringToRegistryCommand-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-MessageType 'MFR.MessageType') that is
being used to identify which message this.

<a name='M-MFR-Messages-Commands-SaveStringToRegistryCommand-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Messages-Commands-SaveStringToRegistryCommand-CommonExecute'></a>
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
