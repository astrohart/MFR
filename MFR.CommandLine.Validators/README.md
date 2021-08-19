<a name='assembly'></a>
# MFR.CommandLine.Validators

## Contents

- [CommandLineValidator](#T-MFR-Objects-CommandLine-Validators-CommandLineValidator 'MFR.CommandLine.Validators.CommandLineValidator')
  - [#ctor()](#M-MFR-Objects-CommandLine-Validators-CommandLineValidator-#ctor 'MFR.CommandLine.Validators.CommandLineValidator.#ctor')
  - [_rootDirectoryValidator](#F-MFR-Objects-CommandLine-Validators-CommandLineValidator-_rootDirectoryValidator 'MFR.CommandLine.Validators.CommandLineValidator._rootDirectoryValidator')
  - [Instance](#P-MFR-Objects-CommandLine-Validators-CommandLineValidator-Instance 'MFR.CommandLine.Validators.CommandLineValidator.Instance')
  - [ValidationFailures](#P-MFR-Objects-CommandLine-Validators-CommandLineValidator-ValidationFailures 'MFR.CommandLine.Validators.CommandLineValidator.ValidationFailures')
  - [#cctor()](#M-MFR-Objects-CommandLine-Validators-CommandLineValidator-#cctor 'MFR.CommandLine.Validators.CommandLineValidator.#cctor')
  - [AssociateWithRootDirectoryValidator(rootDirectoryValidator)](#M-MFR-Objects-CommandLine-Validators-CommandLineValidator-AssociateWithRootDirectoryValidator-MFR-Objects-CommandLine-Validators-Interfaces-IRootDirectoryValidator- 'MFR.CommandLine.Validators.CommandLineValidator.AssociateWithRootDirectoryValidator(MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator)')
  - [IsValid(cmdInfo)](#M-MFR-Objects-CommandLine-Validators-CommandLineValidator-IsValid-MFR-Objects-CommandLine-CommandLineInfo- 'MFR.CommandLine.Validators.CommandLineValidator.IsValid(MFR.CommandLine.CommandLineInfo)')
  - [OnCommandLineInfoInvalid(e)](#M-MFR-Objects-CommandLine-Validators-CommandLineValidator-OnCommandLineInfoInvalid-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs- 'MFR.CommandLine.Validators.CommandLineValidator.OnCommandLineInfoInvalid(MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs)')
- [Resources](#T-MFR-Objects-CommandLine-Validators-Properties-Resources 'MFR.CommandLine.Validators.Properties.Resources')
  - [Culture](#P-MFR-Objects-CommandLine-Validators-Properties-Resources-Culture 'MFR.CommandLine.Validators.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-CommandLine-Validators-Properties-Resources-ResourceManager 'MFR.CommandLine.Validators.Properties.Resources.ResourceManager')
- [RootDirectoryValidator](#T-MFR-Objects-CommandLine-Validators-RootDirectoryValidator 'MFR.CommandLine.Validators.RootDirectoryValidator')
  - [#ctor()](#M-MFR-Objects-CommandLine-Validators-RootDirectoryValidator-#ctor 'MFR.CommandLine.Validators.RootDirectoryValidator.#ctor')
  - [Instance](#P-MFR-Objects-CommandLine-Validators-RootDirectoryValidator-Instance 'MFR.CommandLine.Validators.RootDirectoryValidator.Instance')
  - [ValidationFailures](#P-MFR-Objects-CommandLine-Validators-RootDirectoryValidator-ValidationFailures 'MFR.CommandLine.Validators.RootDirectoryValidator.ValidationFailures')
  - [#cctor()](#M-MFR-Objects-CommandLine-Validators-RootDirectoryValidator-#cctor 'MFR.CommandLine.Validators.RootDirectoryValidator.#cctor')
  - [IsValid(rootDirectory)](#M-MFR-Objects-CommandLine-Validators-RootDirectoryValidator-IsValid-System-String- 'MFR.CommandLine.Validators.RootDirectoryValidator.IsValid(System.String)')
  - [OnRootDirectoryInvalid(e)](#M-MFR-Objects-CommandLine-Validators-RootDirectoryValidator-OnRootDirectoryInvalid-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs- 'MFR.CommandLine.Validators.RootDirectoryValidator.OnRootDirectoryInvalid(MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs)')

<a name='T-MFR-Objects-CommandLine-Validators-CommandLineValidator'></a>
## CommandLineValidator `type`

##### Namespace

MFR.CommandLine.Validators

##### Summary

Validates instances of [CommandLineInfo](#T-MFR-Objects-CommandLine-CommandLineInfo 'MFR.CommandLine.CommandLineInfo') to ensure they
contain values that the application can work with.

<a name='M-MFR-Objects-CommandLine-Validators-CommandLineValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Objects-CommandLine-Validators-CommandLineValidator-_rootDirectoryValidator'></a>
### _rootDirectoryValidator `constants`

##### Summary

Reference to an instance of an object that implements the [IRootDirectoryValidator](#T-MFR-Objects-CommandLine-Validators-Interfaces-IRootDirectoryValidator 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator') interface.

<a name='P-MFR-Objects-CommandLine-Validators-CommandLineValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [CommandLineValidator](#T-MFR-Objects-CommandLine-Validators-CommandLineValidator 'MFR.CommandLine.Validators.CommandLineValidator').

<a name='P-MFR-Objects-CommandLine-Validators-CommandLineValidator-ValidationFailures'></a>
### ValidationFailures `property`

##### Summary

Gets a count of validation failures that occurred the last time the
[IsValid](#M-MFR-Objects-CommandLine-Validators-Interfaces-ICommandLineValidator-IsValid 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.IsValid')
method was called.

<a name='M-MFR-Objects-CommandLine-Validators-CommandLineValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-CommandLine-Validators-CommandLineValidator-AssociateWithRootDirectoryValidator-MFR-Objects-CommandLine-Validators-Interfaces-IRootDirectoryValidator-'></a>
### AssociateWithRootDirectoryValidator(rootDirectoryValidator) `method`

##### Summary

Associates an instance of an object that implements the [IRootDirectoryValidator](#T-MFR-Objects-CommandLine-Validators-Interfaces-IRootDirectoryValidator 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator')
interface with this validator object.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootDirectoryValidator | [MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator](#T-MFR-Objects-CommandLine-Validators-Interfaces-IRootDirectoryValidator 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator') | (Required.) Reference to an instance of an object that implements
the [IRootDirectoryValidator](#T-MFR-Objects-CommandLine-Validators-Interfaces-IRootDirectoryValidator 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `rootDirectoryValidator` , is passed a `null` value. |

<a name='M-MFR-Objects-CommandLine-Validators-CommandLineValidator-IsValid-MFR-Objects-CommandLine-CommandLineInfo-'></a>
### IsValid(cmdInfo) `method`

##### Summary

Gets a value indicating whether the specified
`cmdInfo`
refers to a valid set of command-line argument values.

##### Returns

`true` if the `cmdInfo` object's
properties contain valid values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cmdInfo | [MFR.CommandLine.CommandLineInfo](#T-MFR-Objects-CommandLine-CommandLineInfo 'MFR.CommandLine.CommandLineInfo') | (Required.) Reference to an instance of
[CommandLineInfo](#T-MFR-Objects-CommandLine-CommandLineInfo 'MFR.CommandLine.CommandLineInfo')
that is the
object to be validated. |

<a name='M-MFR-Objects-CommandLine-Validators-CommandLineValidator-OnCommandLineInfoInvalid-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-'></a>
### OnCommandLineInfoInvalid(e) `method`

##### Summary

Raises the [](#E-MFR-Objects-CommandLine-Validators-CommandLineValidator-CommandLineInfoInvalid 'MFR.CommandLine.Validators.CommandLineValidator.CommandLineInfoInvalid') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs](#T-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs') | A [CommandLineInfoInvalidEventArgs](#T-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs')
that contains the event data. |

<a name='T-MFR-Objects-CommandLine-Validators-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.CommandLine.Validators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-CommandLine-Validators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-CommandLine-Validators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-CommandLine-Validators-RootDirectoryValidator'></a>
## RootDirectoryValidator `type`

##### Namespace

MFR.CommandLine.Validators

##### Summary

Validates the root directory of a project-rename operation.

<a name='M-MFR-Objects-CommandLine-Validators-RootDirectoryValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-CommandLine-Validators-RootDirectoryValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[RootDirectoryValidator](#T-MFR-Objects-CommandLine-Validators-RootDirectoryValidator 'MFR.CommandLine.Validators.RootDirectoryValidator').

<a name='P-MFR-Objects-CommandLine-Validators-RootDirectoryValidator-ValidationFailures'></a>
### ValidationFailures `property`

##### Summary

Gets a count of validation failures that occurred the last time the
[IsValid](#M-MFR-Objects-CommandLine-Validators-Interfaces-ICommandLineValidator-IsValid 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.IsValid')
method was called.

<a name='M-MFR-Objects-CommandLine-Validators-RootDirectoryValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-CommandLine-Validators-RootDirectoryValidator-IsValid-System-String-'></a>
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
[](#E-MFR-Objects-CommandLine-Validators-Interfaces-IRootDirectoryValidator-RootDirectoryInvalid 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator.RootDirectoryInvalid')
event.

<a name='M-MFR-Objects-CommandLine-Validators-RootDirectoryValidator-OnRootDirectoryInvalid-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-'></a>
### OnRootDirectoryInvalid(e) `method`

##### Summary

Raises the
[](#E-MFR-Objects-CommandLine-Validators-RootDirectoryValidator-RootDirectoryInvalid 'MFR.CommandLine.Validators.RootDirectoryValidator.RootDirectoryInvalid')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs](#T-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs') | A
[RootDirectoryInvalidEventArgs](#T-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs')
that contains the event data. |
