<a name='assembly'></a>
# MFR.Objects.CommandLine.Validators.Events

## Contents

- [CommandLineInfoInvalidEventArgs](#T-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs 'MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs')
  - [#ctor(cmdInfo,reason)](#M-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-#ctor-MFR-Objects-CommandLine-CommandLineInfo,MFR-Objects-CommandLine-Validators-Constants-CommandLineInvalidReason- 'MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs.#ctor(MFR.Objects.CommandLine.CommandLineInfo,MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason)')
  - [#ctor(cmdInfo,reason,exception)](#M-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-#ctor-MFR-Objects-CommandLine-CommandLineInfo,MFR-Objects-CommandLine-Validators-Constants-CommandLineInvalidReason,System-Exception- 'MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs.#ctor(MFR.Objects.CommandLine.CommandLineInfo,MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason,System.Exception)')
  - [CmdInfo](#P-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-CmdInfo 'MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs.CmdInfo')
  - [Exception](#P-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-Exception 'MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs.Exception')
  - [Message](#P-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-Message 'MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs.Message')
  - [Reason](#P-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-Reason 'MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs.Reason')
- [CommandLineInfoInvalidEventHandler](#T-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventHandler 'MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventHandler')
- [Resources](#T-MFR-Objects-CommandLine-Validators-Events-Properties-Resources 'MFR.Objects.CommandLine.Validators.Events.Properties.Resources')
  - [Culture](#P-MFR-Objects-CommandLine-Validators-Events-Properties-Resources-Culture 'MFR.Objects.CommandLine.Validators.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-CommandLine-Validators-Events-Properties-Resources-ResourceManager 'MFR.Objects.CommandLine.Validators.Events.Properties.Resources.ResourceManager')
- [RootDirectoryInvalidEventArgs](#T-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs')
  - [#ctor(reason,rootDirectory)](#M-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-#ctor-MFR-Objects-CommandLine-Validators-Constants-RootDirectoryInvalidReason,System-String- 'MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs.#ctor(MFR.Objects.CommandLine.Validators.Constants.RootDirectoryInvalidReason,System.String)')
  - [#ctor(reason,rootDirectory,exception)](#M-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-#ctor-MFR-Objects-CommandLine-Validators-Constants-RootDirectoryInvalidReason,System-String,System-Exception- 'MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs.#ctor(MFR.Objects.CommandLine.Validators.Constants.RootDirectoryInvalidReason,System.String,System.Exception)')
  - [Exception](#P-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-Exception 'MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs.Exception')
  - [Message](#P-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-Message 'MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs.Message')
  - [Reason](#P-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-Reason 'MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs.Reason')
  - [RootDirectory](#P-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-RootDirectory 'MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs.RootDirectory')
- [RootDirectoryInvalidEventHandler](#T-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventHandler 'MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventHandler')

<a name='T-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs'></a>
## CommandLineInfoInvalidEventArgs `type`

##### Namespace

MFR.Objects.CommandLine.Validators.Events

##### Summary

Provides information for CommandLineInfoInvalid event handlers.

<a name='M-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-#ctor-MFR-Objects-CommandLine-CommandLineInfo,MFR-Objects-CommandLine-Validators-Constants-CommandLineInvalidReason-'></a>
### #ctor(cmdInfo,reason) `constructor`

##### Summary

Constructs a new instance of
[CommandLineInfoInvalidEventArgs](#T-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs 'MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cmdInfo | [MFR.Objects.CommandLine.CommandLineInfo](#T-MFR-Objects-CommandLine-CommandLineInfo 'MFR.Objects.CommandLine.CommandLineInfo') | (Required.) Reference to that instance of
[CommandLineInfo](#T-MFR-Objects-CommandLine-CommandLineInfo 'MFR.Objects.CommandLine.CommandLineInfo')
whose properties
were found to contain invalid data. |
| reason | [MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason') | (Required.) A
[CommandLineInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason')
value that explains why the validation failed. |

<a name='M-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-#ctor-MFR-Objects-CommandLine-CommandLineInfo,MFR-Objects-CommandLine-Validators-Constants-CommandLineInvalidReason,System-Exception-'></a>
### #ctor(cmdInfo,reason,exception) `constructor`

##### Summary

Constructs a new instance of
[CommandLineInfoInvalidEventArgs](#T-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs 'MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cmdInfo | [MFR.Objects.CommandLine.CommandLineInfo](#T-MFR-Objects-CommandLine-CommandLineInfo 'MFR.Objects.CommandLine.CommandLineInfo') | (Required.) Reference to that instance of
[CommandLineInfo](#T-MFR-Objects-CommandLine-CommandLineInfo 'MFR.Objects.CommandLine.CommandLineInfo')
whose properties
were found to contain invalid data. |
| reason | [MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason') | (Required.) A
[CommandLineInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason')
value that explains why the validation failed. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) Reference to an instance of
[Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception')
that contains detailed error information. |

<a name='P-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-CmdInfo'></a>
### CmdInfo `property`

##### Summary

Gets a reference to the instance of
[CommandLineInfo](#T-MFR-Objects-CommandLine-CommandLineInfo 'MFR.Objects.CommandLine.CommandLineInfo')
whose properties
were found to have invalid values.

<a name='P-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a reference to an instance of [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception')
that describes an error in more detail.

##### Remarks

This property might be `null`.

<a name='P-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-Message'></a>
### Message `property`

##### Summary

Gets a string containing an error message to be displayed to the user.

<a name='P-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-Reason'></a>
### Reason `property`

##### Summary

Gets a
[CommandLineInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.CommandLineInvalidReason')
value that corresponds to the reason that validation failed.

<a name='T-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventHandler'></a>
## CommandLineInfoInvalidEventHandler `type`

##### Namespace

MFR.Objects.CommandLine.Validators.Events

##### Summary

Represents a handler for a CommandLineInfoInvalid event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventHandler](#T-T-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventHandler 'T:MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle
the CommandLineInfoInvalid event.

<a name='T-MFR-Objects-CommandLine-Validators-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.CommandLine.Validators.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-CommandLine-Validators-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-CommandLine-Validators-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs'></a>
## RootDirectoryInvalidEventArgs `type`

##### Namespace

MFR.Objects.CommandLine.Validators.Events

##### Summary

Provides information for RootDirectoryInvalid event handlers.

<a name='M-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-#ctor-MFR-Objects-CommandLine-Validators-Constants-RootDirectoryInvalidReason,System-String-'></a>
### #ctor(reason,rootDirectory) `constructor`

##### Summary

Constructs a new instance of
[RootDirectoryInvalidEventArgs](#T-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [MFR.Objects.CommandLine.Validators.Constants.RootDirectoryInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-RootDirectoryInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.RootDirectoryInvalidReason') | (Required.) A
[RootDirectoryInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-RootDirectoryInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.RootDirectoryInvalidReason')
value specifying why the validation failed. |
| rootDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value of the root directory
specified by the user on the command line. |

<a name='M-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-#ctor-MFR-Objects-CommandLine-Validators-Constants-RootDirectoryInvalidReason,System-String,System-Exception-'></a>
### #ctor(reason,rootDirectory,exception) `constructor`

##### Summary

Constructs a new instance of
[RootDirectoryInvalidEventArgs](#T-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [MFR.Objects.CommandLine.Validators.Constants.RootDirectoryInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-RootDirectoryInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.RootDirectoryInvalidReason') | (Required.) A
[RootDirectoryInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-RootDirectoryInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.RootDirectoryInvalidReason')
value specifying why the validation failed. |
| rootDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value of the root directory
specified by the user on the command line. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) An [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that provides
detailed error information. |

<a name='P-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes the error in
more detail.

<a name='P-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-Message'></a>
### Message `property`

##### Summary

Gets a string containing an error message to be displayed to the user.

<a name='P-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-Reason'></a>
### Reason `property`

##### Summary

Gets a
[RootDirectoryInvalidReason](#T-MFR-Objects-CommandLine-Validators-Constants-RootDirectoryInvalidReason 'MFR.Objects.CommandLine.Validators.Constants.RootDirectoryInvalidReason')
value that specifies why the validation failed.

<a name='P-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-RootDirectory'></a>
### RootDirectory `property`

##### Summary

Gets the string containing the root directory that was specified by
the user on the command line.

<a name='T-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventHandler'></a>
## RootDirectoryInvalidEventHandler `type`

##### Namespace

MFR.Objects.CommandLine.Validators.Events

##### Summary

Represents a handler for a RootDirectoryInvalid event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventHandler](#T-T-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventHandler 'T:MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle
the RootDirectoryInvalid event.
