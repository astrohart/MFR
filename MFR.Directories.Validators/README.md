<a name='assembly'></a>
# MFR.Directories.Validators

## Contents

- [Resources](#T-MFR-Directories-Validators-Properties-Resources 'MFR.Directories.Validators.Properties.Resources')
  - [Culture](#P-MFR-Directories-Validators-Properties-Resources-Culture 'MFR.Directories.Validators.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Validators-Properties-Resources-ResourceManager 'MFR.Directories.Validators.Properties.Resources.ResourceManager')
- [RootDirectoryValidator](#T-MFR-Directories-Validators-RootDirectoryValidator 'MFR.Directories.Validators.RootDirectoryValidator')
  - [#ctor()](#M-MFR-Directories-Validators-RootDirectoryValidator-#ctor 'MFR.Directories.Validators.RootDirectoryValidator.#ctor')
  - [Errors](#P-MFR-Directories-Validators-RootDirectoryValidator-Errors 'MFR.Directories.Validators.RootDirectoryValidator.Errors')
  - [Instance](#P-MFR-Directories-Validators-RootDirectoryValidator-Instance 'MFR.Directories.Validators.RootDirectoryValidator.Instance')
  - [VWarnings](#P-MFR-Directories-Validators-RootDirectoryValidator-VWarnings 'MFR.Directories.Validators.RootDirectoryValidator.VWarnings')
  - [ValidationFailures](#P-MFR-Directories-Validators-RootDirectoryValidator-ValidationFailures 'MFR.Directories.Validators.RootDirectoryValidator.ValidationFailures')
  - [#cctor()](#M-MFR-Directories-Validators-RootDirectoryValidator-#cctor 'MFR.Directories.Validators.RootDirectoryValidator.#cctor')
  - [OnRootDirectoryInvalid(e)](#M-MFR-Directories-Validators-RootDirectoryValidator-OnRootDirectoryInvalid-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs- 'MFR.Directories.Validators.RootDirectoryValidator.OnRootDirectoryInvalid(MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs)')
  - [Validate(rootDirectory)](#M-MFR-Directories-Validators-RootDirectoryValidator-Validate-System-String- 'MFR.Directories.Validators.RootDirectoryValidator.Validate(System.String)')

<a name='T-MFR-Directories-Validators-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Directories.Validators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Directories-Validators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Directories-Validators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Directories-Validators-RootDirectoryValidator'></a>
## RootDirectoryValidator `type`

##### Namespace

MFR.Directories.Validators

##### Summary

Validates the root directory of a project-rename operation.

<a name='M-MFR-Directories-Validators-RootDirectoryValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Directories-Validators-RootDirectoryValidator-Errors'></a>
### Errors `property`

##### Summary

Gets a collection of strings, each of which contains an error message.

<a name='P-MFR-Directories-Validators-RootDirectoryValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[RootDirectoryValidator](#T-MFR-Directories-Validators-RootDirectoryValidator 'MFR.Directories.Validators.RootDirectoryValidator').

<a name='P-MFR-Directories-Validators-RootDirectoryValidator-VWarnings'></a>
### VWarnings `property`

##### Summary

Gets a collection of strings, each of which contains a warning message.

<a name='P-MFR-Directories-Validators-RootDirectoryValidator-ValidationFailures'></a>
### ValidationFailures `property`

##### Summary

Gets a count of validation failures that occurred the last time the
[IsValid](#M-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator-IsValid 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.IsValid')
method was called.

<a name='M-MFR-Directories-Validators-RootDirectoryValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Directories-Validators-RootDirectoryValidator-OnRootDirectoryInvalid-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-'></a>
### OnRootDirectoryInvalid(e) `method`

##### Summary

Raises the
[](#E-MFR-CommandLine-Validators-RootDirectoryValidator-RootDirectoryInvalid 'MFR.CommandLine.Validators.RootDirectoryValidator.RootDirectoryInvalid')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs](#T-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs') | A
[RootDirectoryInvalidEventArgs](#T-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs')
that contains the event data. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `e`, is passed a `null` value. |

<a name='M-MFR-Directories-Validators-RootDirectoryValidator-Validate-System-String-'></a>
### Validate(rootDirectory) `method`

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
