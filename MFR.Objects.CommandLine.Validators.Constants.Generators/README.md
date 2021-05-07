<a name='assembly'></a>
# MFR.Objects.CommandLine.Validators.Constants.Generators

## Contents

- [GetCommandLineValidationFailedMessage](#T-MFR-Objects-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage')
  - [#ctor()](#M-MFR-Objects-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-#ctor 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage.#ctor')
  - [For](#P-MFR-Objects-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-For 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage.For')
  - [MessageFormat](#P-MFR-Objects-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-MessageFormat 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage.MessageFormat')
  - [#cctor()](#M-MFR-Objects-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-#cctor 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage.#cctor')
  - [ValidationFailedReason(reason)](#M-MFR-Objects-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-ValidationFailedReason-MFR-Objects-CommandLine-Validators-Constants-CommandLineInvalidReason- 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage.ValidationFailedReason(MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason)')
- [GetRootDirectoryValidationFailedMessage](#T-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage')
  - [#ctor()](#M-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-#ctor 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage.#ctor')
  - [For](#P-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-For 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage.For')
  - [MessageFormat](#P-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-MessageFormat 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage.MessageFormat')
  - [#cctor()](#M-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-#cctor 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage.#cctor')
  - [AndRootDirectoryValue(value)](#M-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-AndRootDirectoryValue-System-String- 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage.AndRootDirectoryValue(System.String)')
  - [ValidationFailedReason(reason)](#M-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-ValidationFailedReason-MFR-Objects-CommandLine-Validators-Constants-RootDirectoryInvalidReason- 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage.ValidationFailedReason(MFR.Objects.CommandLine.Validators.Constants.RootDirectoryInvalidReason)')
- [Resources](#T-MFR-Objects-CommandLine-Validators-Constants-Generators-Properties-Resources 'MFR.Objects.CommandLine.Validators.Constants.Generators.Properties.Resources')
  - [Culture](#P-MFR-Objects-CommandLine-Validators-Constants-Generators-Properties-Resources-Culture 'MFR.Objects.CommandLine.Validators.Constants.Generators.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-CommandLine-Validators-Constants-Generators-Properties-Resources-ResourceManager 'MFR.Objects.CommandLine.Validators.Constants.Generators.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage'></a>
## GetCommandLineValidationFailedMessage `type`

##### Namespace

MFR.Objects.CommandLine.Validators.Constants.Generators

##### Summary

Fluent builder object that crafts a validation failed message for a root
directory that is also formatted with the value of the directory path
that failed.

<a name='M-MFR-Objects-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-For'></a>
### For `property`

##### Summary

Gets a reference to the one and only instance of
[GetCommandLineValidationFailedMessage](#T-MFR-Objects-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetCommandLineValidationFailedMessage')
.

<a name='P-MFR-Objects-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-MessageFormat'></a>
### MessageFormat `property`

##### Summary

Gets or sets a string that contains the formatted validation-failure message.

<a name='M-MFR-Objects-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-CommandLine-Validators-Constants-Generators-GetCommandLineValidationFailedMessage-ValidationFailedReason-MFR-Objects-CommandLine-Validators-Constants-CommandLineInvalidReason-'></a>
### ValidationFailedReason(reason) `method`

##### Summary

Gets a user-friendly message string to be displayed when a
command-line argument object fails one or more validation rules.

##### Returns

String containing the user-friendly message that corresponds to the
`reason` that was given, or blank if nothing can be found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason') | One of the
[CommandLineInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason')
values that specifies the reason for the failure. |

<a name='T-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage'></a>
## GetRootDirectoryValidationFailedMessage `type`

##### Namespace

MFR.Objects.CommandLine.Validators.Constants.Generators

##### Summary

Fluent builder object that crafts a validation failed message for a root
directory that is also formatted with the value of the directory path
that failed.

<a name='M-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-For'></a>
### For `property`

##### Summary

Gets a reference to the one and only instance of
[GetRootDirectoryValidationFailedMessage](#T-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage 'MFR.Objects.CommandLine.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage')
.

<a name='P-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-MessageFormat'></a>
### MessageFormat `property`

##### Summary

Gets or sets a string that contains the formatted validation-failure message.

<a name='M-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-AndRootDirectoryValue-System-String-'></a>
### AndRootDirectoryValue(value) `method`

##### Summary

Formats the validation-failure message obtained with a call to the
[ValidationFailedReason](#M-MFR-Objects-CommandLine-Validators-Constants-Generators-Factories-GetRootDirectoryValidationFailedMessage-ValidationFailedReason 'MFR.Objects.CommandLine.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.ValidationFailedReason')
method with the value attempted to be passed by the user.

##### Returns

Message formatted with the string specified by
`value`
; empty if the
[MessageFormat](#P-MFR-Objects-CommandLine-Validators-Constants-Generators-Factories-GetRootDirectoryValidationFailedMessage-MessageFormat 'MFR.Objects.CommandLine.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.MessageFormat')
property has not yet been initialized.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value to be substituted in the
message format. |

##### Remarks

Before this method can be called, the
[ValidationFailedReason](#M-MFR-Objects-CommandLine-Validators-Constants-Generators-Factories-GetRootDirectoryValidationFailedMessage-ValidationFailedReason 'MFR.Objects.CommandLine.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.ValidationFailedReason')
method must first be called and then chained with a call to this one.

<a name='M-MFR-Objects-CommandLine-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-ValidationFailedReason-MFR-Objects-CommandLine-Validators-Constants-RootDirectoryInvalidReason-'></a>
### ValidationFailedReason(reason) `method`

##### Summary

s
Initializes the
[MessageFormat](#P-MFR-Objects-CommandLine-Validators-Constants-Generators-Factories-GetRootDirectoryValidationFailedMessage-MessageFormat 'MFR.Objects.CommandLine.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.MessageFormat')
property with the message format string, if any, that corresponds to
the
[RootDirectoryInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-RootDirectoryInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.RootDirectoryInvalidReason')
value passed in the `reason` parameter.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [MFR.Objects.CommandLine.Validators.Constants.RootDirectoryInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-RootDirectoryInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.RootDirectoryInvalidReason') | A
[RootDirectoryInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-RootDirectoryInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.RootDirectoryInvalidReason')
value that indicates the reason why validation failed. |

##### Remarks

After calling this method, callers must chain it with a call to the
[AndRootDirectoryValue](#M-MFR-Objects-CommandLine-Validators-Constants-Generators-Factories-GetRootDirectoryValidationFailedMessage-AndRootDirectoryValue 'MFR.Objects.CommandLine.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.AndRootDirectoryValue')
method before the return value can be assigned to a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
-valued message property.

<a name='T-MFR-Objects-CommandLine-Validators-Constants-Generators-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.CommandLine.Validators.Constants.Generators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-CommandLine-Validators-Constants-Generators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-CommandLine-Validators-Constants-Generators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
