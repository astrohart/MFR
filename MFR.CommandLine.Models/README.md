<a name='assembly'></a>
# MFR.CommandLine

## Contents

- [CommandLineInfo](#T-MFR-Objects-CommandLine-CommandLineInfo 'MFR.CommandLine.CommandLineInfo')
  - [RootDirectory](#P-MFR-Objects-CommandLine-CommandLineInfo-RootDirectory 'MFR.CommandLine.CommandLineInfo.RootDirectory')
  - [ParseCommandLine(args)](#M-MFR-Objects-CommandLine-CommandLineInfo-ParseCommandLine-System-String[]- 'MFR.CommandLine.CommandLineInfo.ParseCommandLine(System.String[])')
- [Resources](#T-MFR-Objects-CommandLine-Properties-Resources 'MFR.CommandLine.Properties.Resources')
  - [Culture](#P-MFR-Objects-CommandLine-Properties-Resources-Culture 'MFR.CommandLine.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-CommandLine-Properties-Resources-ResourceManager 'MFR.CommandLine.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-CommandLine-CommandLineInfo'></a>
## CommandLineInfo `type`

##### Namespace

MFR.CommandLine

##### Summary

Encapsulates this application's command line arguments.

##### Remarks

This class depends on the `FluentCommandLineParser` NuGet package.

<a name='P-MFR-Objects-CommandLine-CommandLineInfo-RootDirectory'></a>
### RootDirectory `property`

##### Summary

Gets or sets a string that contains the starting folder.

<a name='M-MFR-Objects-CommandLine-CommandLineInfo-ParseCommandLine-System-String[]-'></a>
### ParseCommandLine(args) `method`

##### Summary

Parses the application's command-line arguments and sets the properties
of a new instance of [CommandLineInfo](#T-UserQuery-CommandLineInfo 'UserQuery.CommandLineInfo') 
accordingly.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Required.) Array containing the command-line arguments passed to this application. |

<a name='T-MFR-Objects-CommandLine-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.CommandLine.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-CommandLine-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-CommandLine-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
