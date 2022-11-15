<a name='assembly'></a>
# MFR.CommandLine.Validators.Constants.Generators

## Contents

- [GetCommandLineValidationFailedMessage](#T-MFR-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage 'MFR.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage')
  - [#ctor()](#M-MFR-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-#ctor 'MFR.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage.#ctor')
  - [For](#P-MFR-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-For 'MFR.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage.For')
  - [MessageFormat](#P-MFR-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-MessageFormat 'MFR.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage.MessageFormat')
  - [#cctor()](#M-MFR-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-#cctor 'MFR.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage.#cctor')
  - [ForReason(reason)](#M-MFR-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-ForReason-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason- 'MFR.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage.ForReason(MFR.CommandLine.Validators.Constants.CommandLineInvalidReason)')
- [Resources](#T-MFR-CommandLine-Validators-Constants-Generators-Properties-Resources 'MFR.CommandLine.Validators.Constants.Generators.Properties.Resources')
  - [Culture](#P-MFR-CommandLine-Validators-Constants-Generators-Properties-Resources-Culture 'MFR.CommandLine.Validators.Constants.Generators.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-CommandLine-Validators-Constants-Generators-Properties-Resources-ResourceManager 'MFR.CommandLine.Validators.Constants.Generators.Properties.Resources.ResourceManager')

<a name='T-MFR-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage'></a>
## GetCommandLineValidationFailedMessage `type`

##### Namespace

MFR.CommandLine.Validators.Constants.Generators

##### Summary

Fluent builder object that crafts a validation failed message for a root
directory that is also formatted with the value of the directory path
that failed.

<a name='M-MFR-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-For'></a>
### For `property`

##### Summary

Gets a reference to the one and only instance of
[GetCommandLineValidationFailedMessage](#T-MFR-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage 'MFR.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage')
.

<a name='P-MFR-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-MessageFormat'></a>
### MessageFormat `property`

##### Summary

Gets or sets a string that contains the formatted validation-failure message.

<a name='M-MFR-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-ForReason-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-'></a>
### ForReason(reason) `method`

##### Summary

Gets a user-friendly message string to be displayed when a
command-line argument object fails one or more validation rules.

##### Returns

String containing the user-friendly message that corresponds to the
`reason` that was given, or blank if nothing can be found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [MFR.CommandLine.Validators.Constants.CommandLineInvalidReason](#T-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason') | One of the
[CommandLineInvalidReason](#T-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason')
values that specifies the reason for the failure. |

<a name='T-MFR-CommandLine-Validators-Constants-Generators-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.CommandLine.Validators.Constants.Generators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-CommandLine-Validators-Constants-Generators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-CommandLine-Validators-Constants-Generators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
