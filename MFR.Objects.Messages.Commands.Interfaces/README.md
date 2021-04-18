<a name='assembly'></a>
# MFR.Objects.Messages.Commands.Interfaces

## Contents

- [ICommand\`1](#T-MFR-Objects-Messages-Commands-Interfaces-ICommand`1 'MFR.Objects.Messages.Commands.Interfaces.ICommand`1')
  - [WithInput(input)](#M-MFR-Objects-Messages-Commands-Interfaces-ICommand`1-WithInput-`0- 'MFR.Objects.Messages.Commands.Interfaces.ICommand`1.WithInput(`0)')
- [Resources](#T-MFR-Objects-Messages-Commands-Interfaces-Properties-Resources 'MFR.Objects.Messages.Commands.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Messages-Commands-Interfaces-Properties-Resources-Culture 'MFR.Objects.Messages.Commands.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Messages-Commands-Interfaces-Properties-Resources-ResourceManager 'MFR.Objects.Messages.Commands.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Messages-Commands-Interfaces-ICommand`1'></a>
## ICommand\`1 `type`

##### Namespace

MFR.Objects.Messages.Commands.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a command object.



In our vocabulary, a `command` object is an object that performs an
operation but only accepts input and never returns any output.

<a name='M-MFR-Objects-Messages-Commands-Interfaces-ICommand`1-WithInput-`0-'></a>
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

<a name='T-MFR-Objects-Messages-Commands-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Messages.Commands.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Messages-Commands-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Messages-Commands-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
