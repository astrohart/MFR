<a name='assembly'></a>
# MFR.CommandLine.Validators

## Contents

- [CommandLineValidator](#T-MFR-CommandLine-Validators-CommandLineValidator 'MFR.CommandLine.Validators.CommandLineValidator')
  - [#ctor()](#M-MFR-CommandLine-Validators-CommandLineValidator-#ctor 'MFR.CommandLine.Validators.CommandLineValidator.#ctor')
  - [Errors](#P-MFR-CommandLine-Validators-CommandLineValidator-Errors 'MFR.CommandLine.Validators.CommandLineValidator.Errors')
  - [Instance](#P-MFR-CommandLine-Validators-CommandLineValidator-Instance 'MFR.CommandLine.Validators.CommandLineValidator.Instance')
  - [RootDirectoryPathValidator](#P-MFR-CommandLine-Validators-CommandLineValidator-RootDirectoryPathValidator 'MFR.CommandLine.Validators.CommandLineValidator.RootDirectoryPathValidator')
  - [VWarnings](#P-MFR-CommandLine-Validators-CommandLineValidator-VWarnings 'MFR.CommandLine.Validators.CommandLineValidator.VWarnings')
  - [ValidationFailures](#P-MFR-CommandLine-Validators-CommandLineValidator-ValidationFailures 'MFR.CommandLine.Validators.CommandLineValidator.ValidationFailures')
  - [#cctor()](#M-MFR-CommandLine-Validators-CommandLineValidator-#cctor 'MFR.CommandLine.Validators.CommandLineValidator.#cctor')
  - [IsValid(cmdInfo)](#M-MFR-CommandLine-Validators-CommandLineValidator-IsValid-MFR-CommandLine-Models-Interfaces-ICommandLineInfo- 'MFR.CommandLine.Validators.CommandLineValidator.IsValid(MFR.CommandLine.Models.Interfaces.ICommandLineInfo)')
  - [OnCommandLineInfoInvalid(e)](#M-MFR-CommandLine-Validators-CommandLineValidator-OnCommandLineInfoInvalid-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs- 'MFR.CommandLine.Validators.CommandLineValidator.OnCommandLineInfoInvalid(MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs)')
- [Resources](#T-MFR-CommandLine-Validators-Properties-Resources 'MFR.CommandLine.Validators.Properties.Resources')
  - [Culture](#P-MFR-CommandLine-Validators-Properties-Resources-Culture 'MFR.CommandLine.Validators.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-CommandLine-Validators-Properties-Resources-ResourceManager 'MFR.CommandLine.Validators.Properties.Resources.ResourceManager')

<a name='T-MFR-CommandLine-Validators-CommandLineValidator'></a>
## CommandLineValidator `type`

##### Namespace

MFR.CommandLine.Validators

##### Summary

Validates instances of [CommandLineInfo](#T-MFR-CommandLine-CommandLineInfo 'MFR.CommandLine.CommandLineInfo') to
ensure they contain values that the application can work with.

<a name='M-MFR-CommandLine-Validators-CommandLineValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-CommandLine-Validators-CommandLineValidator-Errors'></a>
### Errors `property`

##### Summary

Gets a collection of strings, each of which contains an error message.

<a name='P-MFR-CommandLine-Validators-CommandLineValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[CommandLineValidator](#T-MFR-CommandLine-Validators-CommandLineValidator 'MFR.CommandLine.Validators.CommandLineValidator').

<a name='P-MFR-CommandLine-Validators-CommandLineValidator-RootDirectoryPathValidator'></a>
### RootDirectoryPathValidator `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IRootDirectoryPathValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryPathValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator')
interface.

<a name='P-MFR-CommandLine-Validators-CommandLineValidator-VWarnings'></a>
### VWarnings `property`

##### Summary

Gets a collection of strings, each of which contains a warning message.

<a name='P-MFR-CommandLine-Validators-CommandLineValidator-ValidationFailures'></a>
### ValidationFailures `property`

##### Summary

Gets a count of validation failures that occurred the last time the
[IsValid](#M-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator-IsValid 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.IsValid')
method was called.

<a name='M-MFR-CommandLine-Validators-CommandLineValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-CommandLine-Validators-CommandLineValidator-IsValid-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-'></a>
### IsValid(cmdInfo) `method`

##### Summary

Gets a value indicating whether the specified
`cmdInfo`
refers to a valid set of command-line argument values.

##### Returns

`true` if the `cmdInfo` object's
properties contain valid values, according to the current validation rules.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cmdInfo | [MFR.CommandLine.Models.Interfaces.ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') | (Required.) Reference to an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface
that represents the object whose properties' values are to be validated. |

##### Remarks

If the `cmdInfo` parameter is passed a
`null` reference, this method raises the
[](#E-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator-CommandLineInfoInvalid 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.CommandLineInfoInvalid')
event and then increments the value of the
[ValidationFailures](#P-MFR-CommandLine-Validators-Interfaces-IValidator-ValidationFailures 'MFR.CommandLine.Validators.Interfaces.IValidator.ValidationFailures')
property, and then this method does no further processing.



Otherwise, the object whose reference is passed in the
`cmdInfo` parameter is validated.  The
[ValidationFailures](#P-MFR-CommandLine-Validators-Interfaces-IValidator-ValidationFailures 'MFR.CommandLine.Validators.Interfaces.IValidator.ValidationFailures')
property is used to keep track of the number of validation failures that occur.



At the beginning of this method's execution, the
[ValidationFailures](#P-MFR-CommandLine-Validators-Interfaces-IValidator-ValidationFailures 'MFR.CommandLine.Validators.Interfaces.IValidator.ValidationFailures')
property's value is set to zero.

<a name='M-MFR-CommandLine-Validators-CommandLineValidator-OnCommandLineInfoInvalid-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-'></a>
### OnCommandLineInfoInvalid(e) `method`

##### Summary

Raises the
[](#E-MFR-CommandLine-Validators-CommandLineValidator-CommandLineInfoInvalid 'MFR.CommandLine.Validators.CommandLineValidator.CommandLineInfoInvalid')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs](#T-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs') | A
[CommandLineInfoInvalidEventArgs](#T-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs')
that contains the event data. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `e`, is passed a `null` value. |

<a name='T-MFR-CommandLine-Validators-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.CommandLine.Validators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-CommandLine-Validators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-CommandLine-Validators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
