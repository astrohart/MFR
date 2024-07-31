<a name='assembly'></a>
# MFR.Directories.Validators

## Contents

- [Resources](#T-MFR-Directories-Validators-Properties-Resources 'MFR.Directories.Validators.Properties.Resources')
  - [Culture](#P-MFR-Directories-Validators-Properties-Resources-Culture 'MFR.Directories.Validators.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Validators-Properties-Resources-ResourceManager 'MFR.Directories.Validators.Properties.Resources.ResourceManager')
- [RootDirectoryPathValidator](#T-MFR-Directories-Validators-RootDirectoryPathValidator 'MFR.Directories.Validators.RootDirectoryPathValidator')
  - [#ctor()](#M-MFR-Directories-Validators-RootDirectoryPathValidator-#ctor 'MFR.Directories.Validators.RootDirectoryPathValidator.#ctor')
  - [Errors](#P-MFR-Directories-Validators-RootDirectoryPathValidator-Errors 'MFR.Directories.Validators.RootDirectoryPathValidator.Errors')
  - [Instance](#P-MFR-Directories-Validators-RootDirectoryPathValidator-Instance 'MFR.Directories.Validators.RootDirectoryPathValidator.Instance')
  - [VWarnings](#P-MFR-Directories-Validators-RootDirectoryPathValidator-VWarnings 'MFR.Directories.Validators.RootDirectoryPathValidator.VWarnings')
  - [ValidationFailures](#P-MFR-Directories-Validators-RootDirectoryPathValidator-ValidationFailures 'MFR.Directories.Validators.RootDirectoryPathValidator.ValidationFailures')
  - [#cctor()](#M-MFR-Directories-Validators-RootDirectoryPathValidator-#cctor 'MFR.Directories.Validators.RootDirectoryPathValidator.#cctor')
  - [OnRootDirectoryInvalid(e)](#M-MFR-Directories-Validators-RootDirectoryPathValidator-OnRootDirectoryInvalid-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs- 'MFR.Directories.Validators.RootDirectoryPathValidator.OnRootDirectoryInvalid(MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs)')
  - [Validate(rootDirectory)](#M-MFR-Directories-Validators-RootDirectoryPathValidator-Validate-System-String- 'MFR.Directories.Validators.RootDirectoryPathValidator.Validate(System.String)')

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

<a name='T-MFR-Directories-Validators-RootDirectoryPathValidator'></a>
## RootDirectoryPathValidator `type`

##### Namespace

MFR.Directories.Validators

##### Summary

Validates the root directory of a project-rename operation.

<a name='M-MFR-Directories-Validators-RootDirectoryPathValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Directories-Validators-RootDirectoryPathValidator-Errors'></a>
### Errors `property`

##### Summary

Gets a collection of strings, each of which contains an error message.

<a name='P-MFR-Directories-Validators-RootDirectoryPathValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[RootDirectoryPathValidator](#T-MFR-Directories-Validators-RootDirectoryPathValidator 'MFR.Directories.Validators.RootDirectoryPathValidator').

<a name='P-MFR-Directories-Validators-RootDirectoryPathValidator-VWarnings'></a>
### VWarnings `property`

##### Summary

Gets a collection of strings, each of which contains a warning message.

<a name='P-MFR-Directories-Validators-RootDirectoryPathValidator-ValidationFailures'></a>
### ValidationFailures `property`

##### Summary

Gets a count of validation failures that occurred the last time the
[IsValid](#M-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator-IsValid 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.IsValid')
method was called.

<a name='M-MFR-Directories-Validators-RootDirectoryPathValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Directories-Validators-RootDirectoryPathValidator-OnRootDirectoryInvalid-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-'></a>
### OnRootDirectoryInvalid(e) `method`

##### Summary

Raises the
[](#E-MFR-CommandLine-Validators-RootDirectoryPathValidator-RootDirectoryInvalid 'MFR.CommandLine.Validators.RootDirectoryPathValidator.RootDirectoryInvalid')
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

<a name='M-MFR-Directories-Validators-RootDirectoryPathValidator-Validate-System-String-'></a>
### Validate(rootDirectory) `method`

##### Summary

Gets a value that determines whether the specified
`rootDirectory`
is valid or not.



A "root directory" is defined to be the starting folder of a
project-rename operation.



It must exist on the file system, and it must contain a Visual Studio
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
[](#E-MFR-CommandLine-Validators-Interfaces-IRootDirectoryPathValidator-RootDirectoryInvalid 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryPathValidator.RootDirectoryInvalid')
event.
