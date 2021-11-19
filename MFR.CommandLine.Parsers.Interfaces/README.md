<a name='assembly'></a>
# MFR.CommandLine.Parsers.Interfaces

## Contents

- [ICommandLineParser](#T-MFR-CommandLine-Parsers-Interfaces-ICommandLineParser 'MFR.CommandLine.Parsers.Interfaces.ICommandLineParser')
  - [Parse(args)](#M-MFR-CommandLine-Parsers-Interfaces-ICommandLineParser-Parse-System-String[]- 'MFR.CommandLine.Parsers.Interfaces.ICommandLineParser.Parse(System.String[])')
- [Resources](#T-xyLOGIXModule-Interfaces-Properties-Resources 'xyLOGIXModule.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIXModule-Interfaces-Properties-Resources-Culture 'xyLOGIXModule.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIXModule-Interfaces-Properties-Resources-ResourceManager 'xyLOGIXModule.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-CommandLine-Parsers-Interfaces-ICommandLineParser'></a>
## ICommandLineParser `type`

##### Namespace

MFR.CommandLine.Parsers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that parses
the command line of the application.

<a name='M-MFR-CommandLine-Parsers-Interfaces-ICommandLineParser-Parse-System-String[]-'></a>
### Parse(args) `method`

##### Summary

Parses the application's command-line arguments and sets the properties of a
new instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface
accordingly.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) Array containing the command-line arguments passed to this
application. |

<a name='T-xyLOGIXModule-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIXModule.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIXModule-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIXModule-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
