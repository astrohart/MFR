<a name='assembly'></a>
# mfr

## Contents

- [Program](#T-MFR-GUI-Program 'MFR.GUI.Program')
  - [CommandLineInfo](#P-MFR-GUI-Program-CommandLineInfo 'MFR.GUI.Program.CommandLineInfo')
  - [Main(args)](#M-MFR-GUI-Program-Main-System-String[]- 'MFR.GUI.Program.Main(System.String[])')
  - [OnCommandLineInfoInvalid(sender,e)](#M-MFR-GUI-Program-OnCommandLineInfoInvalid-System-Object,MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs- 'MFR.GUI.Program.OnCommandLineInfoInvalid(System.Object,MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs)')
  - [OnRootDirectoryInvalid(sender,e)](#M-MFR-GUI-Program-OnRootDirectoryInvalid-System-Object,MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs- 'MFR.GUI.Program.OnRootDirectoryInvalid(System.Object,MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs)')
  - [OnThreadException(sender,e)](#M-MFR-GUI-Program-OnThreadException-System-Object,System-Threading-ThreadExceptionEventArgs- 'MFR.GUI.Program.OnThreadException(System.Object,System.Threading.ThreadExceptionEventArgs)')
  - [ParseCommandLine(args)](#M-MFR-GUI-Program-ParseCommandLine-System-String[]- 'MFR.GUI.Program.ParseCommandLine(System.String[])')
  - [ProcessCommandLine()](#M-MFR-GUI-Program-ProcessCommandLine 'MFR.GUI.Program.ProcessCommandLine')
  - [SetDisplayParameters()](#M-MFR-GUI-Program-SetDisplayParameters 'MFR.GUI.Program.SetDisplayParameters')
  - [SetUpCommandLineValidation()](#M-MFR-GUI-Program-SetUpCommandLineValidation 'MFR.GUI.Program.SetUpCommandLineValidation')
  - [SetUpExceptionHandling()](#M-MFR-GUI-Program-SetUpExceptionHandling 'MFR.GUI.Program.SetUpExceptionHandling')
  - [SetUpLogging()](#M-MFR-GUI-Program-SetUpLogging 'MFR.GUI.Program.SetUpLogging')
  - [ShowValidationFailureMessage(message)](#M-MFR-GUI-Program-ShowValidationFailureMessage-System-String- 'MFR.GUI.Program.ShowValidationFailureMessage(System.String)')
- [Resources](#T-MFR-GUI-Properties-Resources 'MFR.GUI.Properties.Resources')
  - [ConfigFilename](#P-MFR-GUI-Properties-Resources-ConfigFilename 'MFR.GUI.Properties.Resources.ConfigFilename')
  - [Culture](#P-MFR-GUI-Properties-Resources-Culture 'MFR.GUI.Properties.Resources.Culture')
  - [Error_ConfigFileNotFound](#P-MFR-GUI-Properties-Resources-Error_ConfigFileNotFound 'MFR.GUI.Properties.Resources.Error_ConfigFileNotFound')
  - [ResourceManager](#P-MFR-GUI-Properties-Resources-ResourceManager 'MFR.GUI.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Program'></a>
## Program `type`

##### Namespace

MFR.GUI

##### Summary

Provides the entry point for the program and all application-level
functionality.

<a name='P-MFR-GUI-Program-CommandLineInfo'></a>
### CommandLineInfo `property`

##### Summary

Gets a reference to an instance of a
[CommandLineInfo](#T-MFR-Objects-CommandLine-CommandLineInfo 'MFR.Objects.CommandLine.CommandLineInfo')
object that is
initialized with the values specified (if any) by the user on this
application's command line.

<a name='M-MFR-GUI-Program-Main-System-String[]-'></a>
### Main(args) `method`

##### Summary

The main entry point for the application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Optional.) Array of strings, each of which represents a different
command-line argument passed to this application. |

<a name='M-MFR-GUI-Program-OnCommandLineInfoInvalid-System-Object,MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-'></a>
### OnCommandLineInfoInvalid(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Objects-CommandLine-Validators-Interfaces-ICommandLineValidator-CommandLineInfoInvalid 'MFR.Objects.CommandLine.Validators.Interfaces.ICommandLineValidator.CommandLineInfoInvalid')
event raised by the command-line validator object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs](#T-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs 'MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs') | A
[CommandLineInfoInvalidEventArgs](#T-MFR-Objects-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs 'MFR.Objects.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs')
that contains the event data. |

##### Remarks

This method responds by showing an error message to the user.

<a name='M-MFR-GUI-Program-OnRootDirectoryInvalid-System-Object,MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs-'></a>
### OnRootDirectoryInvalid(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Objects-CommandLine-Validators-Interfaces-IRootDirectoryValidator-RootDirectoryInvalid 'MFR.Objects.CommandLine.Validators.Interfaces.IRootDirectoryValidator.RootDirectoryInvalid')
event raised by the root-directory validator object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs](#T-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs') | A
[RootDirectoryInvalidEventArgs](#T-MFR-Objects-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.Objects.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs')
that contains the event data. |

##### Remarks

This method responds by showing an error message to the user.

<a name='M-MFR-GUI-Program-OnThreadException-System-Object,System-Threading-ThreadExceptionEventArgs-'></a>
### OnThreadException(sender,e) `method`

##### Summary

Handles the
[](#E-System-Windows-Forms-Application-ThreadException 'System.Windows.Forms.Application.ThreadException')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The sender of this event. |
| e | [System.Threading.ThreadExceptionEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ThreadExceptionEventArgs 'System.Threading.ThreadExceptionEventArgs') | A [ThreadExceptionEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ThreadExceptionEventArgs 'System.Threading.ThreadExceptionEventArgs') that
contains the event data. |

##### Remarks

The event that this handler responds to typically is raised by the
application when an exception is thrown but goes unhandled by a
try/catch block that is not there in the code



This handler responds to the event by writing the exception
information to the log file and then by displaying a user-friendly
error dialog box.



From the dialog box thus displayed, the user can click a button to
open a Notepad window displaying the exception's type name, message,
and stack trace.

<a name='M-MFR-GUI-Program-ParseCommandLine-System-String[]-'></a>
### ParseCommandLine(args) `method`

##### Summary

Initializes a new instance of
[CommandLineInfo](#T-MFR-Objects-CommandLine-CommandLineInfo 'MFR.Objects.CommandLine.CommandLineInfo')
from the
arguments passed by the user on the command line, and initializes
the [CommandLineInfo](#P-MFR-GUI-Program-CommandLineInfo 'MFR.GUI.Program.CommandLineInfo') property with a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Optional.) Array of strings, each of which represents a different
command-line argument passed to this application. |

##### Remarks

This method also runs validation rules on the command-line parameters.



If any validation failures occur, then the app is terminated.

<a name='M-MFR-GUI-Program-ProcessCommandLine'></a>
### ProcessCommandLine() `method`

##### Summary

Takes actions based on what arguments were passed to the application.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Program-SetDisplayParameters'></a>
### SetDisplayParameters() `method`

##### Summary

Configures the display settings, such as DPI-awareness and visual
styles etc.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Program-SetUpCommandLineValidation'></a>
### SetUpCommandLineValidation() `method`

##### Summary

Configures the application's handling of validation failures of the
command-line parameters.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Program-SetUpExceptionHandling'></a>
### SetUpExceptionHandling() `method`

##### Summary

Configures the application's handling of exceptions that are not
caught elsewhere.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Program-SetUpLogging'></a>
### SetUpLogging() `method`

##### Summary

Configures the logging infrastructure.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Program-ShowValidationFailureMessage-System-String-'></a>
### ShowValidationFailureMessage(message) `method`

##### Summary

Shows the error `message` to the user.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the message to be displayed. |

##### Remarks

If the string value in `message` is blank, then
this method does nothing.

<a name='T-MFR-GUI-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Properties-Resources-ConfigFilename'></a>
### ConfigFilename `property`

##### Summary

Looks up a localized string similar to config.json.

<a name='P-MFR-GUI-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Properties-Resources-Error_ConfigFileNotFound'></a>
### Error_ConfigFileNotFound `property`

##### Summary

Looks up a localized string similar to Could not find the configuration file..

<a name='P-MFR-GUI-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
