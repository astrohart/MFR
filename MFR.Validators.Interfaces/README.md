<a name='assembly'></a>
# MFR.Validators.Interfaces

## Contents

- [IValidator](#T-MFR-Validators-Interfaces-IValidator 'MFR.Validators.Interfaces.IValidator')
  - [Errors](#P-MFR-Validators-Interfaces-IValidator-Errors 'MFR.Validators.Interfaces.IValidator.Errors')
  - [VWarnings](#P-MFR-Validators-Interfaces-IValidator-VWarnings 'MFR.Validators.Interfaces.IValidator.VWarnings')
  - [ValidationFailures](#P-MFR-Validators-Interfaces-IValidator-ValidationFailures 'MFR.Validators.Interfaces.IValidator.ValidationFailures')
- [Resources](#T-MFR-Validators-Interfaces-Properties-Resources 'MFR.Validators.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Validators-Interfaces-Properties-Resources-Culture 'MFR.Validators.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Validators-Interfaces-Properties-Resources-ResourceManager 'MFR.Validators.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Validators-Interfaces-IValidator'></a>
## IValidator `type`

##### Namespace

MFR.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of all Validator objects.

<a name='P-MFR-Validators-Interfaces-IValidator-Errors'></a>
### Errors `property`

##### Summary

Gets a collection of strings, each of which contains an error message.

<a name='P-MFR-Validators-Interfaces-IValidator-VWarnings'></a>
### VWarnings `property`

##### Summary

Gets a collection of strings, each of which contains a warning message.

<a name='P-MFR-Validators-Interfaces-IValidator-ValidationFailures'></a>
### ValidationFailures `property`

##### Summary

Gets a count of validation failures that occurred the last time the
[IsValid](#M-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator-IsValid 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.IsValid')
method was called.

<a name='T-MFR-Validators-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Validators.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Validators-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Validators-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
