<a name='assembly'></a>
# MFR.Directories.Validators.Events

## Contents

- [Resources](#T-MFR-Directories-Validators-Events-Properties-Resources 'MFR.Directories.Validators.Events.Properties.Resources')
  - [Culture](#P-MFR-Directories-Validators-Events-Properties-Resources-Culture 'MFR.Directories.Validators.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Validators-Events-Properties-Resources-ResourceManager 'MFR.Directories.Validators.Events.Properties.Resources.ResourceManager')
- [RootDirectoryInvalidEventArgs](#T-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs')
  - [#ctor(reason,rootDirectory)](#M-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-#ctor-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason,System-String- 'MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs.#ctor(MFR.Directories.Validators.Constants.RootDirectoryInvalidReason,System.String)')
  - [#ctor(reason,rootDirectory,exception)](#M-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-#ctor-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason,System-String,System-Exception- 'MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs.#ctor(MFR.Directories.Validators.Constants.RootDirectoryInvalidReason,System.String,System.Exception)')
  - [Exception](#P-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-Exception 'MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs.Exception')
  - [Message](#P-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-Message 'MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs.Message')
  - [Reason](#P-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-Reason 'MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs.Reason')
  - [RootDirectory](#P-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-RootDirectory 'MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs.RootDirectory')
- [RootDirectoryInvalidEventHandler](#T-MFR-Directories-Validators-Events-RootDirectoryInvalidEventHandler 'MFR.Directories.Validators.Events.RootDirectoryInvalidEventHandler')

<a name='T-MFR-Directories-Validators-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Directories.Validators.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Directories-Validators-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Directories-Validators-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs'></a>
## RootDirectoryInvalidEventArgs `type`

##### Namespace

MFR.Directories.Validators.Events

##### Summary

Provides information for RootDirectoryInvalid event handlers.

<a name='M-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-#ctor-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason,System-String-'></a>
### #ctor(reason,rootDirectory) `constructor`

##### Summary

Constructs a new instance of
[RootDirectoryInvalidEventArgs](#T-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [MFR.Directories.Validators.Constants.RootDirectoryInvalidReason](#T-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason 'MFR.Directories.Validators.Constants.RootDirectoryInvalidReason') | (Required.) A
[RootDirectoryInvalidReason](#T-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason 'MFR.Directories.Validators.Constants.RootDirectoryInvalidReason')
value specifying why the validation failed. |
| rootDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value of the root directory
specified by the user on the command line. |

<a name='M-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-#ctor-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason,System-String,System-Exception-'></a>
### #ctor(reason,rootDirectory,exception) `constructor`

##### Summary

Constructs a new instance of
[RootDirectoryInvalidEventArgs](#T-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [MFR.Directories.Validators.Constants.RootDirectoryInvalidReason](#T-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason 'MFR.Directories.Validators.Constants.RootDirectoryInvalidReason') | (Required.) A
[RootDirectoryInvalidReason](#T-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason 'MFR.Directories.Validators.Constants.RootDirectoryInvalidReason')
value specifying why the validation failed. |
| rootDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value of the root directory
specified by the user on the command line. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) An [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that provides
detailed error information. |

<a name='P-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes the error in
more detail.

<a name='P-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-Message'></a>
### Message `property`

##### Summary

Gets a string containing an error message to be displayed to the user.

<a name='P-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-Reason'></a>
### Reason `property`

##### Summary

Gets a
[RootDirectoryInvalidReason](#T-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason 'MFR.Directories.Validators.Constants.RootDirectoryInvalidReason')
value that specifies why the validation failed.

<a name='P-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-RootDirectory'></a>
### RootDirectory `property`

##### Summary

Gets the string containing the root directory that was specified by
the user on the command line.

<a name='T-MFR-Directories-Validators-Events-RootDirectoryInvalidEventHandler'></a>
## RootDirectoryInvalidEventHandler `type`

##### Namespace

MFR.Directories.Validators.Events

##### Summary

Represents a handler for a RootDirectoryInvalid event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Directories.Validators.Events.RootDirectoryInvalidEventHandler](#T-T-MFR-Directories-Validators-Events-RootDirectoryInvalidEventHandler 'T:MFR.Directories.Validators.Events.RootDirectoryInvalidEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle
the RootDirectoryInvalid event.
