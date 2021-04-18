<a name='assembly'></a>
# mfr

## Contents

- [Program](#T-MFR-GUI-Program 'MFR.GUI.Program')
  - [Main()](#M-MFR-GUI-Program-Main 'MFR.GUI.Program.Main')
  - [OnThreadException(sender,e)](#M-MFR-GUI-Program-OnThreadException-System-Object,System-Threading-ThreadExceptionEventArgs- 'MFR.GUI.Program.OnThreadException(System.Object,System.Threading.ThreadExceptionEventArgs)')
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

<a name='M-MFR-GUI-Program-Main'></a>
### Main() `method`

##### Summary

The main entry point for the application.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Program-OnThreadException-System-Object,System-Threading-ThreadExceptionEventArgs-'></a>
### OnThreadException(sender,e) `method`

##### Summary

Handles the
[](#E-System-Windows-Forms-Application-ThreadException 'System.Windows.Forms.Application.ThreadException')
event
raised by the application when an exception is thrown but goes
unhandled by a try/catch block that is not there in the code.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.Threading.ThreadExceptionEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.ThreadExceptionEventArgs 'System.Threading.ThreadExceptionEventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This handler responds to the event by writing the exception
information to the log file and then by displaying a user-friendly
error dialog box.

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
