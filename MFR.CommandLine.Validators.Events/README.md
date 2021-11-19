<a name='assembly'></a>
# MFR.CommandLine.Validators.Events

## Contents

- [CommandLineInfoInvalidEventArgs](#T-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs')
  - [#ctor(cmdInfo,reason)](#M-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-#ctor-MFR-CommandLine-Models-Interfaces-ICommandLineInfo,MFR-CommandLine-Validators-Constants-CommandLineInvalidReason- 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs.#ctor(MFR.CommandLine.Models.Interfaces.ICommandLineInfo,MFR.CommandLine.Validators.Constants.CommandLineInvalidReason)')
  - [#ctor(cmdInfo,reason,exception)](#M-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-#ctor-MFR-CommandLine-Models-Interfaces-ICommandLineInfo,MFR-CommandLine-Validators-Constants-CommandLineInvalidReason,System-Exception- 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs.#ctor(MFR.CommandLine.Models.Interfaces.ICommandLineInfo,MFR.CommandLine.Validators.Constants.CommandLineInvalidReason,System.Exception)')
  - [CmdInfo](#P-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-CmdInfo 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs.CmdInfo')
  - [Exception](#P-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-Exception 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs.Exception')
  - [Message](#P-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-Message 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs.Message')
  - [Reason](#P-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-Reason 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs.Reason')
- [CommandLineInfoInvalidEventHandler](#T-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventHandler 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventHandler')
- [Resources](#T-MFR-CommandLine-Validators-Events-Properties-Resources 'MFR.CommandLine.Validators.Events.Properties.Resources')
  - [Culture](#P-MFR-CommandLine-Validators-Events-Properties-Resources-Culture 'MFR.CommandLine.Validators.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-CommandLine-Validators-Events-Properties-Resources-ResourceManager 'MFR.CommandLine.Validators.Events.Properties.Resources.ResourceManager')
- [RootDirectoryInvalidEventArgs](#T-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs')
  - [#ctor(reason,rootDirectory)](#M-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-#ctor-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason,System-String- 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs.#ctor(MFR.CommandLine.Validators.Constants.RootDirectoryInvalidReason,System.String)')
  - [#ctor(reason,rootDirectory,exception)](#M-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-#ctor-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason,System-String,System-Exception- 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs.#ctor(MFR.CommandLine.Validators.Constants.RootDirectoryInvalidReason,System.String,System.Exception)')
  - [Exception](#P-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-Exception 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs.Exception')
  - [Message](#P-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-Message 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs.Message')
  - [Reason](#P-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-Reason 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs.Reason')
  - [RootDirectory](#P-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-RootDirectory 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs.RootDirectory')
- [RootDirectoryInvalidEventHandler](#T-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventHandler 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventHandler')

<a name='T-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs'></a>
## CommandLineInfoInvalidEventArgs `type`

##### Namespace

MFR.CommandLine.Validators.Events

##### Summary

Provides information for CommandLineInfoInvalid event handlers.

<a name='M-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-#ctor-MFR-CommandLine-Models-Interfaces-ICommandLineInfo,MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-'></a>
### #ctor(cmdInfo,reason) `constructor`

##### Summary

Constructs a new instance of
[CommandLineInfoInvalidEventArgs](#T-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cmdInfo | [MFR.CommandLine.Models.Interfaces.ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') | (Required.) Reference to an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface
that represents the command-line data object whose properties were found to
contain invalid data. |
| reason | [MFR.CommandLine.Validators.Constants.CommandLineInvalidReason](#T-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason') | (Required.) A
[CommandLineInvalidReason](#T-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason')
value that explains why the validation failed. |

<a name='M-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-#ctor-MFR-CommandLine-Models-Interfaces-ICommandLineInfo,MFR-CommandLine-Validators-Constants-CommandLineInvalidReason,System-Exception-'></a>
### #ctor(cmdInfo,reason,exception) `constructor`

##### Summary

Constructs a new instance of
[CommandLineInfoInvalidEventArgs](#T-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cmdInfo | [MFR.CommandLine.Models.Interfaces.ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') | (Required.) Reference to an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface
that represents the command-line data object whose properties were found to
contain invalid data. |
| reason | [MFR.CommandLine.Validators.Constants.CommandLineInvalidReason](#T-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason') | (Required.) A
[CommandLineInvalidReason](#T-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason')
value that explains why the validation failed. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) Reference to an instance of
[Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception')
that contains detailed error information. |

<a name='P-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-CmdInfo'></a>
### CmdInfo `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface
whose properties were found to contain invalid data.

<a name='P-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a reference to an instance of [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception')
that describes an error in more detail.

##### Remarks

This property might be `null`.

<a name='P-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-Message'></a>
### Message `property`

##### Summary

Gets a string containing an error message to be displayed to the user.

<a name='P-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-Reason'></a>
### Reason `property`

##### Summary

Gets a
[CommandLineInvalidReason](#T-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason')
value that corresponds to the reason that validation failed.

<a name='T-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventHandler'></a>
## CommandLineInfoInvalidEventHandler `type`

##### Namespace

MFR.CommandLine.Validators.Events

##### Summary

Represents a handler for a CommandLineInfoInvalid event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventHandler](#T-T-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventHandler 'T:MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle
the CommandLineInfoInvalid event.

<a name='T-MFR-CommandLine-Validators-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.CommandLine.Validators.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-CommandLine-Validators-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-CommandLine-Validators-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs'></a>
## RootDirectoryInvalidEventArgs `type`

##### Namespace

MFR.CommandLine.Validators.Events

##### Summary

Provides information for RootDirectoryInvalid event handlers.

<a name='M-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-#ctor-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason,System-String-'></a>
### #ctor(reason,rootDirectory) `constructor`

##### Summary

Constructs a new instance of
[RootDirectoryInvalidEventArgs](#T-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [MFR.CommandLine.Validators.Constants.RootDirectoryInvalidReason](#T-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason 'MFR.CommandLine.Validators.Constants.RootDirectoryInvalidReason') | (Required.) A
[RootDirectoryInvalidReason](#T-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason 'MFR.CommandLine.Validators.Constants.RootDirectoryInvalidReason')
value specifying why the validation failed. |
| rootDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value of the root directory
specified by the user on the command line. |

<a name='M-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-#ctor-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason,System-String,System-Exception-'></a>
### #ctor(reason,rootDirectory,exception) `constructor`

##### Summary

Constructs a new instance of
[RootDirectoryInvalidEventArgs](#T-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [MFR.CommandLine.Validators.Constants.RootDirectoryInvalidReason](#T-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason 'MFR.CommandLine.Validators.Constants.RootDirectoryInvalidReason') | (Required.) A
[RootDirectoryInvalidReason](#T-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason 'MFR.CommandLine.Validators.Constants.RootDirectoryInvalidReason')
value specifying why the validation failed. |
| rootDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value of the root directory
specified by the user on the command line. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) An [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that provides
detailed error information. |

<a name='P-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes the error in
more detail.

<a name='P-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-Message'></a>
### Message `property`

##### Summary

Gets a string containing an error message to be displayed to the user.

<a name='P-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-Reason'></a>
### Reason `property`

##### Summary

Gets a
[RootDirectoryInvalidReason](#T-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason 'MFR.CommandLine.Validators.Constants.RootDirectoryInvalidReason')
value that specifies why the validation failed.

<a name='P-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-RootDirectory'></a>
### RootDirectory `property`

##### Summary

Gets the string containing the root directory that was specified by
the user on the command line.

<a name='T-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventHandler'></a>
## RootDirectoryInvalidEventHandler `type`

##### Namespace

MFR.CommandLine.Validators.Events

##### Summary

Represents a handler for a RootDirectoryInvalid event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventHandler](#T-T-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventHandler 'T:MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle
the RootDirectoryInvalid event.
