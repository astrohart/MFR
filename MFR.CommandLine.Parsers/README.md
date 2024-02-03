<a name='assembly'></a>
# MFR.CommandLine.Parsers

## Contents

- [CommandLineParser](#T-MFR-CommandLine-Parsers-CommandLineParser 'MFR.CommandLine.Parsers.CommandLineParser')
  - [#ctor()](#M-MFR-CommandLine-Parsers-CommandLineParser-#ctor 'MFR.CommandLine.Parsers.CommandLineParser.#ctor')
  - [Instance](#P-MFR-CommandLine-Parsers-CommandLineParser-Instance 'MFR.CommandLine.Parsers.CommandLineParser.Instance')
  - [#cctor()](#M-MFR-CommandLine-Parsers-CommandLineParser-#cctor 'MFR.CommandLine.Parsers.CommandLineParser.#cctor')
  - [OnDisplayHelp(e)](#M-MFR-CommandLine-Parsers-CommandLineParser-OnDisplayHelp-MFR-CommandLine-Parsers-Events-DisplayHelpEventArgs- 'MFR.CommandLine.Parsers.CommandLineParser.OnDisplayHelp(MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs)')
  - [Parse(args)](#M-MFR-CommandLine-Parsers-CommandLineParser-Parse-System-String[]- 'MFR.CommandLine.Parsers.CommandLineParser.Parse(System.String[])')
- [Resources](#T-MFR-CommandLine-Parsers-Properties-Resources 'MFR.CommandLine.Parsers.Properties.Resources')
  - [Culture](#P-MFR-CommandLine-Parsers-Properties-Resources-Culture 'MFR.CommandLine.Parsers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-CommandLine-Parsers-Properties-Resources-ResourceManager 'MFR.CommandLine.Parsers.Properties.Resources.ResourceManager')

<a name='T-MFR-CommandLine-Parsers-CommandLineParser'></a>
## CommandLineParser `type`

##### Namespace

MFR.CommandLine.Parsers

##### Summary

Manages the parsing and validation of the command line of the application.

<a name='M-MFR-CommandLine-Parsers-CommandLineParser-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-CommandLine-Parsers-CommandLineParser-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[CommandLineParser](#T-MFR-CommandLine-Parsers-CommandLineParser 'MFR.CommandLine.Parsers.CommandLineParser').

<a name='M-MFR-CommandLine-Parsers-CommandLineParser-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-CommandLine-Parsers-CommandLineParser-OnDisplayHelp-MFR-CommandLine-Parsers-Events-DisplayHelpEventArgs-'></a>
### OnDisplayHelp(e) `method`

##### Summary

Raises the
[](#E-MFR-CommandLine-Parsers-CommandLineParser-DisplayHelp 'MFR.CommandLine.Parsers.CommandLineParser.DisplayHelp') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs](#T-MFR-CommandLine-Parsers-Events-DisplayHelpEventArgs 'MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs') | A
[DisplayHelpEventArgs](#T-MFR-CommandLine-Parsers-Events-DisplayHelpEventArgs 'MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs') that
contains the event data. |

<a name='M-MFR-CommandLine-Parsers-CommandLineParser-Parse-System-String[]-'></a>
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
application.
application. |

<a name='T-MFR-CommandLine-Parsers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.CommandLine.Parsers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-CommandLine-Parsers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-CommandLine-Parsers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
