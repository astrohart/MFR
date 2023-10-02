<a name='assembly'></a>
# MFR.Directories.Validators.Constants.Generators

## Contents

- [GetRootDirectoryValidationFailedMessage](#T-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage 'MFR.Directories.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage')
  - [#ctor()](#M-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-#ctor 'MFR.Directories.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage.#ctor')
  - [For](#P-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-For 'MFR.Directories.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage.For')
  - [MessageFormat](#P-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-MessageFormat 'MFR.Directories.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage.MessageFormat')
  - [#cctor()](#M-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-#cctor 'MFR.Directories.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage.#cctor')
  - [AndRootDirectoryValue(value)](#M-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-AndRootDirectoryValue-System-String- 'MFR.Directories.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage.AndRootDirectoryValue(System.String)')
  - [ForReason(reason)](#M-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-ForReason-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason- 'MFR.Directories.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage.ForReason(MFR.Directories.Validators.Constants.RootDirectoryInvalidReason)')
- [Resources](#T-MFR-Directories-Validators-Constants-Generators-Properties-Resources 'MFR.Directories.Validators.Constants.Generators.Properties.Resources')
  - [Culture](#P-MFR-Directories-Validators-Constants-Generators-Properties-Resources-Culture 'MFR.Directories.Validators.Constants.Generators.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Validators-Constants-Generators-Properties-Resources-ResourceManager 'MFR.Directories.Validators.Constants.Generators.Properties.Resources.ResourceManager')

<a name='T-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage'></a>
## GetRootDirectoryValidationFailedMessage `type`

##### Namespace

MFR.Directories.Validators.Constants.Generators

##### Summary

Fluent builder object that crafts a validation failed message for a root
directory that is also formatted with the value of the directory path
that failed.

<a name='M-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-For'></a>
### For `property`

##### Summary

Gets a reference to the one and only instance of
[GetRootDirectoryValidationFailedMessage](#T-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage 'MFR.Directories.Validators.Constants.Generators.GetRootDirectoryValidationFailedMessage')
.

<a name='P-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-MessageFormat'></a>
### MessageFormat `property`

##### Summary

Gets or sets a string that contains the formatted validation-failure message.

<a name='M-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-AndRootDirectoryValue-System-String-'></a>
### AndRootDirectoryValue(value) `method`

##### Summary

Formats the validation-failure message obtained with a call to the
[ValidationFailedReason](#M-MFR-CommandLine-Validators-Constants-Generators-Factories-GetRootDirectoryValidationFailedMessage-ValidationFailedReason 'MFR.CommandLine.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.ValidationFailedReason')
method with the value attempted to be passed by the user.

##### Returns

Message formatted with the string specified by
`value`
; empty if the
[MessageFormat](#P-MFR-Directories-Validators-Constants-Generators-Factories-GetRootDirectoryValidationFailedMessage-MessageFormat 'MFR.Directories.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.MessageFormat')
property has not yet been initialized.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value to be substituted in the
message format. |

##### Remarks

Before this method can be called, the
[ValidationFailedReason](#M-MFR-CommandLine-Validators-Constants-Generators-Factories-GetRootDirectoryValidationFailedMessage-ValidationFailedReason 'MFR.CommandLine.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.ValidationFailedReason')
method must first be called and then chained with a call to this one.

<a name='M-MFR-Directories-Validators-Constants-Generators-GetRootDirectoryValidationFailedMessage-ForReason-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason-'></a>
### ForReason(reason) `method`

##### Summary

s
Initializes the
[MessageFormat](#P-MFR-Directories-Validators-Constants-Generators-Factories-GetRootDirectoryValidationFailedMessage-MessageFormat 'MFR.Directories.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.MessageFormat')
property with the message format string, if any, that corresponds to
the
[RootDirectoryInvalidReason](#T-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason 'MFR.Directories.Validators.Constants.RootDirectoryInvalidReason')
value passed in the `reason` parameter.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [MFR.Directories.Validators.Constants.RootDirectoryInvalidReason](#T-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason 'MFR.Directories.Validators.Constants.RootDirectoryInvalidReason') | A
[RootDirectoryInvalidReason](#T-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason 'MFR.Directories.Validators.Constants.RootDirectoryInvalidReason')
value that indicates the reason why validation failed. |

##### Remarks

After calling this method, callers must chain it with a call to the
[AndRootDirectoryValue](#M-MFR-CommandLine-Validators-Constants-Generators-Factories-GetRootDirectoryValidationFailedMessage-AndRootDirectoryValue 'MFR.CommandLine.Validators.Constants.Generators.Factories.GetRootDirectoryValidationFailedMessage.AndRootDirectoryValue')
method before the return value can be assigned to a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
-valued message property.

<a name='T-MFR-Directories-Validators-Constants-Generators-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Directories.Validators.Constants.Generators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Directories-Validators-Constants-Generators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Directories-Validators-Constants-Generators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
