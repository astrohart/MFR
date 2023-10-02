<a name='assembly'></a>
# MFR.GUI.Application.Interfaces

## Contents

- [IWinApp](#T-MFR-GUI-Application-Interfaces-IWinApp 'MFR.GUI.Application.Interfaces.IWinApp')
  - [AppId](#P-MFR-GUI-Application-Interfaces-IWinApp-AppId 'MFR.GUI.Application.Interfaces.IWinApp.AppId')
  - [AutoStart](#P-MFR-GUI-Application-Interfaces-IWinApp-AutoStart 'MFR.GUI.Application.Interfaces.IWinApp.AutoStart')
  - [CommandLineInfo](#P-MFR-GUI-Application-Interfaces-IWinApp-CommandLineInfo 'MFR.GUI.Application.Interfaces.IWinApp.CommandLineInfo')
  - [CommandLineSpecified](#P-MFR-GUI-Application-Interfaces-IWinApp-CommandLineSpecified 'MFR.GUI.Application.Interfaces.IWinApp.CommandLineSpecified')
  - [WinInit(args)](#M-MFR-GUI-Application-Interfaces-IWinApp-WinInit-System-String[]- 'MFR.GUI.Application.Interfaces.IWinApp.WinInit(System.String[])')
- [Resources](#T-MFR-GUI-Application-Interfaces-Properties-Resources 'MFR.GUI.Application.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-GUI-Application-Interfaces-Properties-Resources-Culture 'MFR.GUI.Application.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Application-Interfaces-Properties-Resources-ResourceManager 'MFR.GUI.Application.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Application-Interfaces-IWinApp'></a>
## IWinApp `type`

##### Namespace

MFR.GUI.Application.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an application object.

<a name='P-MFR-GUI-Application-Interfaces-IWinApp-AppId'></a>
### AppId `property`

##### Summary

A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that uniquely identifies this product.

<a name='P-MFR-GUI-Application-Interfaces-IWinApp-AutoStart'></a>
### AutoStart `property`

##### Summary

Gets a value indicating whether the application should automatically process
operations requested by the user from the command line.

<a name='P-MFR-GUI-Application-Interfaces-IWinApp-CommandLineInfo'></a>
### CommandLineInfo `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface.

<a name='P-MFR-GUI-Application-Interfaces-IWinApp-CommandLineSpecified'></a>
### CommandLineSpecified `property`

##### Summary

Gets or sets a value that indicates whether the user specified any arguments on
this application's command line at startup or not.

<a name='M-MFR-GUI-Application-Interfaces-IWinApp-WinInit-System-String[]-'></a>
### WinInit(args) `method`

##### Summary

Called to instruct the application to begin processing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) An array of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
values, each of which corresponds to a value that was passed by the user on the
application's command line. |

<a name='T-MFR-GUI-Application-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Application.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Application-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Application-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
