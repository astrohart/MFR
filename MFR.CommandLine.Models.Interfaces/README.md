<a name='assembly'></a>
# MFR.CommandLine.Models.Interfaces

## Contents

- [ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo')
  - [FindWhat](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-FindWhat 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.FindWhat')
  - [MatchCase](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-MatchCase 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.MatchCase')
  - [MatchWholeWord](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-MatchWholeWord 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.MatchWholeWord')
  - [ReOpenSolution](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ReOpenSolution 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.ReOpenSolution')
  - [RenameFiles](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-RenameFiles 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.RenameFiles')
  - [RenameSubFolders](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-RenameSubFolders 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.RenameSubFolders')
  - [ReplaceTextInFiles](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ReplaceTextInFiles 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.ReplaceTextInFiles')
  - [ReplaceWith](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ReplaceWith 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.ReplaceWith')
  - [StartingFolder](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-StartingFolder 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.StartingFolder')
- [Resources](#T-MFR-CommandLine-Models-Interfaces-Properties-Resources 'MFR.CommandLine.Models.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-CommandLine-Models-Interfaces-Properties-Resources-Culture 'MFR.CommandLine.Models.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-CommandLine-Models-Interfaces-Properties-Resources-ResourceManager 'MFR.CommandLine.Models.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo'></a>
## ICommandLineInfo `type`

##### Namespace

MFR.CommandLine.Models.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that stores
the information supplied by the user on the application's command line.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets a string containing the content to be found in the file system
entries.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-MatchCase'></a>
### MatchCase `property`

##### Summary

Gets or sets a value indicating whether a case-sensitive search should be done.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-MatchWholeWord'></a>
### MatchWholeWord `property`

##### Summary

Gets or sets a value indicating whether a whole-word search should be done.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ReOpenSolution'></a>
### ReOpenSolution `property`

##### Summary

Gets or sets a value that indicates that the Solution is to be reloaded when
the operations are finished.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-RenameFiles'></a>
### RenameFiles `property`

##### Summary

Gets or sets a value indicating whether the files are to be renamed.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-RenameSubFolders'></a>
### RenameSubFolders `property`

##### Summary

Gets or sets a value indicating whether sub folders should be renamed.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ReplaceTextInFiles'></a>
### ReplaceTextInFiles `property`

##### Summary

Gets or sets a value indicating whether text in files should be replaced.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets a string containing the content to be replaced in the file system
entries.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-StartingFolder'></a>
### StartingFolder `property`

##### Summary

Gets or sets a string that contains the starting folder.

<a name='T-MFR-CommandLine-Models-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.CommandLine.Models.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-CommandLine-Models-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-CommandLine-Models-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
