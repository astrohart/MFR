<a name='assembly'></a>
# MFR.GUI.Application

## Contents

- [ProjectFileRenamerApp](#T-MFR-GUI-Application-ProjectFileRenamerApp 'MFR.GUI.Application.ProjectFileRenamerApp')
  - [#ctor()](#M-MFR-GUI-Application-ProjectFileRenamerApp-#ctor 'MFR.GUI.Application.ProjectFileRenamerApp.#ctor')
  - [AppId](#P-MFR-GUI-Application-ProjectFileRenamerApp-AppId 'MFR.GUI.Application.ProjectFileRenamerApp.AppId')
  - [AutoStart](#P-MFR-GUI-Application-ProjectFileRenamerApp-AutoStart 'MFR.GUI.Application.ProjectFileRenamerApp.AutoStart')
  - [CommandLineInfo](#P-MFR-GUI-Application-ProjectFileRenamerApp-CommandLineInfo 'MFR.GUI.Application.ProjectFileRenamerApp.CommandLineInfo')
  - [CommandLineParser](#P-MFR-GUI-Application-ProjectFileRenamerApp-CommandLineParser 'MFR.GUI.Application.ProjectFileRenamerApp.CommandLineParser')
  - [CommandLineSpecified](#P-MFR-GUI-Application-ProjectFileRenamerApp-CommandLineSpecified 'MFR.GUI.Application.ProjectFileRenamerApp.CommandLineSpecified')
  - [CommandLineValidator](#P-MFR-GUI-Application-ProjectFileRenamerApp-CommandLineValidator 'MFR.GUI.Application.ProjectFileRenamerApp.CommandLineValidator')
  - [ConfigProvider](#P-MFR-GUI-Application-ProjectFileRenamerApp-ConfigProvider 'MFR.GUI.Application.ProjectFileRenamerApp.ConfigProvider')
  - [Instance](#P-MFR-GUI-Application-ProjectFileRenamerApp-Instance 'MFR.GUI.Application.ProjectFileRenamerApp.Instance')
  - [ProfileProvider](#P-MFR-GUI-Application-ProjectFileRenamerApp-ProfileProvider 'MFR.GUI.Application.ProjectFileRenamerApp.ProfileProvider')
  - [RootDirectoryPathValidator](#P-MFR-GUI-Application-ProjectFileRenamerApp-RootDirectoryPathValidator 'MFR.GUI.Application.ProjectFileRenamerApp.RootDirectoryPathValidator')
  - [#cctor()](#M-MFR-GUI-Application-ProjectFileRenamerApp-#cctor 'MFR.GUI.Application.ProjectFileRenamerApp.#cctor')
  - [ExitApplication()](#M-MFR-GUI-Application-ProjectFileRenamerApp-ExitApplication 'MFR.GUI.Application.ProjectFileRenamerApp.ExitApplication')
  - [InitApplication(args)](#M-MFR-GUI-Application-ProjectFileRenamerApp-InitApplication-System-String[]- 'MFR.GUI.Application.ProjectFileRenamerApp.InitApplication(System.String[])')
  - [IsAutoStarted(args)](#M-MFR-GUI-Application-ProjectFileRenamerApp-IsAutoStarted-System-Collections-Generic-IEnumerable{System-String}- 'MFR.GUI.Application.ProjectFileRenamerApp.IsAutoStarted(System.Collections.Generic.IEnumerable{System.String})')
  - [OnCommandLineInfoInvalid(sender,e)](#M-MFR-GUI-Application-ProjectFileRenamerApp-OnCommandLineInfoInvalid-System-Object,MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs- 'MFR.GUI.Application.ProjectFileRenamerApp.OnCommandLineInfoInvalid(System.Object,MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs)')
  - [OnCommandLineParserDisplayHelp(sender,e)](#M-MFR-GUI-Application-ProjectFileRenamerApp-OnCommandLineParserDisplayHelp-System-Object,MFR-CommandLine-Parsers-Events-DisplayHelpEventArgs- 'MFR.GUI.Application.ProjectFileRenamerApp.OnCommandLineParserDisplayHelp(System.Object,MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs)')
  - [OnInitialized()](#M-MFR-GUI-Application-ProjectFileRenamerApp-OnInitialized 'MFR.GUI.Application.ProjectFileRenamerApp.OnInitialized')
  - [OnRootDirectoryInvalid(sender,e)](#M-MFR-GUI-Application-ProjectFileRenamerApp-OnRootDirectoryInvalid-System-Object,MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs- 'MFR.GUI.Application.ProjectFileRenamerApp.OnRootDirectoryInvalid(System.Object,MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs)')
  - [OnThreadException(sender,e)](#M-MFR-GUI-Application-ProjectFileRenamerApp-OnThreadException-System-Object,System-Threading-ThreadExceptionEventArgs- 'MFR.GUI.Application.ProjectFileRenamerApp.OnThreadException(System.Object,System.Threading.ThreadExceptionEventArgs)')
  - [ParseCommandLine(args)](#M-MFR-GUI-Application-ProjectFileRenamerApp-ParseCommandLine-System-String[]- 'MFR.GUI.Application.ProjectFileRenamerApp.ParseCommandLine(System.String[])')
  - [ProcessCommandLine()](#M-MFR-GUI-Application-ProjectFileRenamerApp-ProcessCommandLine 'MFR.GUI.Application.ProjectFileRenamerApp.ProcessCommandLine')
  - [SetDisplayParameters()](#M-MFR-GUI-Application-ProjectFileRenamerApp-SetDisplayParameters 'MFR.GUI.Application.ProjectFileRenamerApp.SetDisplayParameters')
  - [SetUpCommandLineValidation()](#M-MFR-GUI-Application-ProjectFileRenamerApp-SetUpCommandLineValidation 'MFR.GUI.Application.ProjectFileRenamerApp.SetUpCommandLineValidation')
  - [SetUpExceptionHandling()](#M-MFR-GUI-Application-ProjectFileRenamerApp-SetUpExceptionHandling 'MFR.GUI.Application.ProjectFileRenamerApp.SetUpExceptionHandling')
  - [ShowValidationFailureMessage(message)](#M-MFR-GUI-Application-ProjectFileRenamerApp-ShowValidationFailureMessage-System-String- 'MFR.GUI.Application.ProjectFileRenamerApp.ShowValidationFailureMessage(System.String)')
  - [WinInit(args)](#M-MFR-GUI-Application-ProjectFileRenamerApp-WinInit-System-String[]- 'MFR.GUI.Application.ProjectFileRenamerApp.WinInit(System.String[])')
- [Resources](#T-MFR-GUI-Application-Properties-Resources 'MFR.GUI.Application.Properties.Resources')
  - [Culture](#P-MFR-GUI-Application-Properties-Resources-Culture 'MFR.GUI.Application.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Application-Properties-Resources-ResourceManager 'MFR.GUI.Application.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Application-ProjectFileRenamerApp'></a>
## ProjectFileRenamerApp `type`

##### Namespace

MFR.GUI.Application

##### Summary

Provides the entry point for the program and all application-level
functionality.

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-GUI-Application-ProjectFileRenamerApp-AppId'></a>
### AppId `property`

##### Summary

A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that uniquely identifies this product.

<a name='P-MFR-GUI-Application-ProjectFileRenamerApp-AutoStart'></a>
### AutoStart `property`

##### Summary

Gets a value indicating whether the application should automatically process
operations requested by the user from the command line.

<a name='P-MFR-GUI-Application-ProjectFileRenamerApp-CommandLineInfo'></a>
### CommandLineInfo `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface.

<a name='P-MFR-GUI-Application-ProjectFileRenamerApp-CommandLineParser'></a>
### CommandLineParser `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ICommandLineParser](#T-MFR-CommandLine-Parsers-Interfaces-ICommandLineParser 'MFR.CommandLine.Parsers.Interfaces.ICommandLineParser')
interface.

<a name='P-MFR-GUI-Application-ProjectFileRenamerApp-CommandLineSpecified'></a>
### CommandLineSpecified `property`

##### Summary

Gets or sets a value that indicates whether the user specified any arguments on
this application's command line at startup or not.

<a name='P-MFR-GUI-Application-ProjectFileRenamerApp-CommandLineValidator'></a>
### CommandLineValidator `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ICommandLineValidator](#T-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator')
interface.

<a name='P-MFR-GUI-Application-ProjectFileRenamerApp-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

##### Remarks

This object allows access to the user config and the
actions
associated with it.

<a name='P-MFR-GUI-Application-ProjectFileRenamerApp-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[ProjectFileRenamerApp](#T-MFR-GUI-Application-ProjectFileRenamerApp 'MFR.GUI.Application.ProjectFileRenamerApp').

<a name='P-MFR-GUI-Application-ProjectFileRenamerApp-ProfileProvider'></a>
### ProfileProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProfileProvider](#T-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider')
interface.

<a name='P-MFR-GUI-Application-ProjectFileRenamerApp-RootDirectoryPathValidator'></a>
### RootDirectoryPathValidator `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IRootDirectoryPathValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryPathValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator')
interface.

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-ExitApplication'></a>
### ExitApplication() `method`

##### Summary

Performs operations that should be undertaken when the application exits.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-InitApplication-System-String[]-'></a>
### InitApplication(args) `method`

##### Summary

Called to perform a one-time initialization of the application.

##### Returns

`true` if the application was initialized
successfully; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) An array of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
values, each of which corresponds to a value that was passed by the user on the
application's command line. |

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-IsAutoStarted-System-Collections-Generic-IEnumerable{System-String}-'></a>
### IsAutoStarted(args) `method`

##### Summary

Determines whether the app was auto-started.  It does this by scanning the
command-line arguments.

##### Returns

`true` if the application was auto-started;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | (Required.) An array of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
values, each of which corresponds to a value that was passed by the user on the
application's command line. |

##### Remarks

If one of the arguments is `--autoStart`, then the app was auto-started;
otherwise, it was not.

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-OnCommandLineInfoInvalid-System-Object,MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs-'></a>
### OnCommandLineInfoInvalid(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator-CommandLineInfoInvalid 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.CommandLineInfoInvalid')
event raised by the command-line validator object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs](#T-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs') | A
[CommandLineInfoInvalidEventArgs](#T-MFR-CommandLine-Validators-Events-CommandLineInfoInvalidEventArgs 'MFR.CommandLine.Validators.Events.CommandLineInfoInvalidEventArgs')
that contains the event data. |

##### Remarks

This method responds by showing an error message to the user.

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-OnCommandLineParserDisplayHelp-System-Object,MFR-CommandLine-Parsers-Events-DisplayHelpEventArgs-'></a>
### OnCommandLineParserDisplayHelp(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-CommandLine-Parsers-Interfaces-ICommandLineParser-DisplayHelp 'MFR.CommandLine.Parsers.Interfaces.ICommandLineParser.DisplayHelp')
event raised by the command-line parser.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs](#T-MFR-CommandLine-Parsers-Events-DisplayHelpEventArgs 'MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method shows a message box and then quits the application.

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-OnInitialized'></a>
### OnInitialized() `method`

##### Summary

Raises the
[](#E-MFR-GUI-Application-ProjectFileRenamerApp-Initialized 'MFR.GUI.Application.ProjectFileRenamerApp.Initialized') event.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-OnRootDirectoryInvalid-System-Object,MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs-'></a>
### OnRootDirectoryInvalid(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-CommandLine-Validators-Interfaces-IRootDirectoryPathValidator-RootDirectoryInvalid 'MFR.CommandLine.Validators.Interfaces.IRootDirectoryPathValidator.RootDirectoryInvalid')
event raised by the root-directory validator object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs](#T-MFR-Directories-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.Directories.Validators.Events.RootDirectoryInvalidEventArgs') | A
[RootDirectoryInvalidEventArgs](#T-MFR-CommandLine-Validators-Events-RootDirectoryInvalidEventArgs 'MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs')
that contains the event data. |

##### Remarks

This method responds by showing an error message to the user.

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-OnThreadException-System-Object,System-Threading-ThreadExceptionEventArgs-'></a>
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

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-ParseCommandLine-System-String[]-'></a>
### ParseCommandLine(args) `method`

##### Summary

Initializes a new instance of
[CommandLineInfo](#T-MFR-CommandLine-CommandLineInfo 'MFR.CommandLine.CommandLineInfo')
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

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-ProcessCommandLine'></a>
### ProcessCommandLine() `method`

##### Summary

Takes actions based on what arguments were passed to the application.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-SetDisplayParameters'></a>
### SetDisplayParameters() `method`

##### Summary

Configures the display settings, such as DPI-awareness and visual
styles etc.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-SetUpCommandLineValidation'></a>
### SetUpCommandLineValidation() `method`

##### Summary

Configures the application's handling of validation failures of the
command-line parameters.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-SetUpExceptionHandling'></a>
### SetUpExceptionHandling() `method`

##### Summary

Configures the application's handling of exceptions that are not
caught elsewhere.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-ShowValidationFailureMessage-System-String-'></a>
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

<a name='M-MFR-GUI-Application-ProjectFileRenamerApp-WinInit-System-String[]-'></a>
### WinInit(args) `method`

##### Summary

Called to instruct the application to begin processing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) An array of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
values, each of which corresponds to a value that was passed by the user on the
application's command line. |

<a name='T-MFR-GUI-Application-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Application.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Application-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Application-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
