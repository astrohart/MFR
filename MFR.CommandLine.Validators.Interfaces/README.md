<a name='assembly'></a>
# MFR.CommandLine.Validators.Interfaces

## Contents

- [ICommandLineValidator](#T-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator')
  - [AssociateWithRootDirectoryValidator(rootDirectoryValidator)](#M-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator-AssociateWithRootDirectoryValidator-MFR-CommandLine-Validators-Interfaces-IRootDirectoryValidator- 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.AssociateWithRootDirectoryValidator(MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator)')
  - [IsValid(cmdInfo)](#M-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator-IsValid-MFR-CommandLine-Models-Interfaces-ICommandLineInfo- 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.IsValid(MFR.CommandLine.Models.Interfaces.ICommandLineInfo)')
- [IRootDirectoryValidator](#T-MFR-CommandLine-Validators-Interfaces-IRootDirectoryValidator 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator')
  - [IsValid(rootDirectory)](#M-MFR-CommandLine-Validators-Interfaces-IRootDirectoryValidator-IsValid-System-String- 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator.IsValid(System.String)')
- [IValidator](#T-MFR-CommandLine-Validators-Interfaces-IValidator 'MFR.CommandLine.Validators.Interfaces.IValidator')
  - [ValidationFailures](#P-MFR-CommandLine-Validators-Interfaces-IValidator-ValidationFailures 'MFR.CommandLine.Validators.Interfaces.IValidator.ValidationFailures')
- [Resources](#T-MFR-CommandLine-Validators-Interfaces-Properties-Resources 'MFR.CommandLine.Validators.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-CommandLine-Validators-Interfaces-Properties-Resources-Culture 'MFR.CommandLine.Validators.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-CommandLine-Validators-Interfaces-Properties-Resources-ResourceManager 'MFR.CommandLine.Validators.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator'></a>
## ICommandLineValidator `type`

##### Namespace

MFR.CommandLine.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a
`
            Command-Line Validator
            `
object.

<a name='M-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator-AssociateWithRootDirectoryValidator-MFR-CommandLine-Validators-Interfaces-IRootDirectoryValidator-'></a>
### AssociateWithRootDirectoryValidator(rootDirectoryValidator) `method`

##### Summary

Associates an instance of an object that implements the
[IRootDirectoryValidator](#T-MFR-CommandLine-Validators-Interfaces-IRootDirectoryValidator 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator')
interface with this validator object.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootDirectoryValidator | [MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator](#T-MFR-CommandLine-Validators-Interfaces-IRootDirectoryValidator 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator') | (Required.) Reference to an instance of an object that implements
the
[IRootDirectoryValidator](#T-MFR-CommandLine-Validators-Interfaces-IRootDirectoryValidator 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `rootDirectoryValidator`,
is passed a `null` value. |

<a name='M-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator-IsValid-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-'></a>
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

<a name='T-MFR-CommandLine-Validators-Interfaces-IRootDirectoryValidator'></a>
## IRootDirectoryValidator `type`

##### Namespace

MFR.CommandLine.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that
validates the pathnames of root directories; i.e., the folder where the
project-rename operation starts..

<a name='M-MFR-CommandLine-Validators-Interfaces-IRootDirectoryValidator-IsValid-System-String-'></a>
### IsValid(rootDirectory) `method`

##### Summary

Gets a value that determines whether the specified
`rootDirectory`
is valid or not.



A "root directory" is defined to be the starting folder of a
project-rename operation.



It must exist on the disk, and it must contain a Visual Studio
Solution (*.sln) file.

##### Returns

`true` if the pathname specified by the
`rootDirectory`
parameter refers to a valid directory;
`false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the pathname of a root directory to be validated. |

##### Remarks

In the event that validation fails, this method raises the
[](#E-MFR-CommandLine-Validators-Interfaces-IRootDirectoryValidator-RootDirectoryInvalid 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator.RootDirectoryInvalid')
event.

<a name='T-MFR-CommandLine-Validators-Interfaces-IValidator'></a>
## IValidator `type`

##### Namespace

MFR.CommandLine.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of all Validator objects.

<a name='P-MFR-CommandLine-Validators-Interfaces-IValidator-ValidationFailures'></a>
### ValidationFailures `property`

##### Summary

Gets a count of validation failures that occurred the last time the
[IsValid](#M-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator-IsValid 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.IsValid')
method was called.

<a name='T-MFR-CommandLine-Validators-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.CommandLine.Validators.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-CommandLine-Validators-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-CommandLine-Validators-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
