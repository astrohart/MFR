<a name='assembly'></a>
# MFR.Objects.CommandLine

## Contents

- [CommandLineInfo](#T-MFR-Objects-CommandLine-CommandLineInfo 'MFR.Objects.CommandLine.CommandLineInfo')
  - [NoBackup](#P-MFR-Objects-CommandLine-CommandLineInfo-NoBackup 'MFR.Objects.CommandLine.CommandLineInfo.NoBackup')
  - [RootDirectory](#P-MFR-Objects-CommandLine-CommandLineInfo-RootDirectory 'MFR.Objects.CommandLine.CommandLineInfo.RootDirectory')
  - [ParseCommandLine(args)](#M-MFR-Objects-CommandLine-CommandLineInfo-ParseCommandLine-System-String[]- 'MFR.Objects.CommandLine.CommandLineInfo.ParseCommandLine(System.String[])')
- [Resources](#T-MFR-Objects-CommandLine-Properties-Resources 'MFR.Objects.CommandLine.Properties.Resources')
  - [Culture](#P-MFR-Objects-CommandLine-Properties-Resources-Culture 'MFR.Objects.CommandLine.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-CommandLine-Properties-Resources-ResourceManager 'MFR.Objects.CommandLine.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-CommandLine-CommandLineInfo'></a>
## CommandLineInfo `type`

##### Namespace

MFR.Objects.CommandLine

##### Summary

Encapsulates this application's command line arguments.

##### Remarks

This class depends on the `FluentCommandLineParser` NuGet package.

<a name='P-MFR-Objects-CommandLine-CommandLineInfo-NoBackup'></a>
### NoBackup `property`

##### Summary

Gets or sets a value that indicates whether files should be
backed up prior to being altered.

##### Remarks

The default value of this property is `false`.

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

MFR.Objects.CommandLine.Properties

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