<a name='assembly'></a>
# MFR.CommandLine.Models

## Contents

- [CommandLineInfo](#T-MFR-CommandLine-Models-CommandLineInfo 'MFR.CommandLine.Models.CommandLineInfo')
  - [FindWhat](#P-MFR-CommandLine-Models-CommandLineInfo-FindWhat 'MFR.CommandLine.Models.CommandLineInfo.FindWhat')
  - [MatchCase](#P-MFR-CommandLine-Models-CommandLineInfo-MatchCase 'MFR.CommandLine.Models.CommandLineInfo.MatchCase')
  - [MatchWholeWord](#P-MFR-CommandLine-Models-CommandLineInfo-MatchWholeWord 'MFR.CommandLine.Models.CommandLineInfo.MatchWholeWord')
  - [RenameFiles](#P-MFR-CommandLine-Models-CommandLineInfo-RenameFiles 'MFR.CommandLine.Models.CommandLineInfo.RenameFiles')
  - [RenameSubFolders](#P-MFR-CommandLine-Models-CommandLineInfo-RenameSubFolders 'MFR.CommandLine.Models.CommandLineInfo.RenameSubFolders')
  - [ReplaceWith](#P-MFR-CommandLine-Models-CommandLineInfo-ReplaceWith 'MFR.CommandLine.Models.CommandLineInfo.ReplaceWith')
  - [ReplaceinFiles](#P-MFR-CommandLine-Models-CommandLineInfo-ReplaceinFiles 'MFR.CommandLine.Models.CommandLineInfo.ReplaceinFiles')
  - [RootDirectory](#P-MFR-CommandLine-Models-CommandLineInfo-RootDirectory 'MFR.CommandLine.Models.CommandLineInfo.RootDirectory')
- [Resources](#T-MFR-CommandLine-Models-Properties-Resources 'MFR.CommandLine.Models.Properties.Resources')
  - [Culture](#P-MFR-CommandLine-Models-Properties-Resources-Culture 'MFR.CommandLine.Models.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-CommandLine-Models-Properties-Resources-ResourceManager 'MFR.CommandLine.Models.Properties.Resources.ResourceManager')

<a name='T-MFR-CommandLine-Models-CommandLineInfo'></a>
## CommandLineInfo `type`

##### Namespace

MFR.CommandLine.Models

##### Summary

Encapsulates this application's command line arguments.

##### Remarks

This class depends on the `FluentCommandLineParser` NuGet package.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets a string containing the content to be found in the file system
entries.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-MatchCase'></a>
### MatchCase `property`

##### Summary

Gets or sets a value indicating whether a case-sensitive search should be done.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-MatchWholeWord'></a>
### MatchWholeWord `property`

##### Summary

Gets or sets a value indicating whether a whole-word search should be done.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-RenameFiles'></a>
### RenameFiles `property`

##### Summary

Gets or sets a value indicating whether the files are to be renamed.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-RenameSubFolders'></a>
### RenameSubFolders `property`

##### Summary

Gets or sets a value indicating whether sub folders should be renamed.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets a string containing the content to be replaced in the file system
entries.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-ReplaceinFiles'></a>
### ReplaceinFiles `property`

##### Summary

Gets or sets a value indicating whether text in files should be replaced.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-RootDirectory'></a>
### RootDirectory `property`

##### Summary

Gets or sets a string that contains the starting folder.

<a name='T-MFR-CommandLine-Models-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.CommandLine.Models.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-CommandLine-Models-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-CommandLine-Models-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
