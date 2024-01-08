<a name='assembly'></a>
# MFR.CommandLine.Models

## Contents

- [CommandLineInfo](#T-MFR-CommandLine-Models-CommandLineInfo 'MFR.CommandLine.Models.CommandLineInfo')
  - [AutoStart](#P-MFR-CommandLine-Models-CommandLineInfo-AutoStart 'MFR.CommandLine.Models.CommandLineInfo.AutoStart')
  - [FindWhat](#P-MFR-CommandLine-Models-CommandLineInfo-FindWhat 'MFR.CommandLine.Models.CommandLineInfo.FindWhat')
  - [MatchCase](#P-MFR-CommandLine-Models-CommandLineInfo-MatchCase 'MFR.CommandLine.Models.CommandLineInfo.MatchCase')
  - [MatchWholeWord](#P-MFR-CommandLine-Models-CommandLineInfo-MatchWholeWord 'MFR.CommandLine.Models.CommandLineInfo.MatchWholeWord')
  - [ReOpenSolution](#P-MFR-CommandLine-Models-CommandLineInfo-ReOpenSolution 'MFR.CommandLine.Models.CommandLineInfo.ReOpenSolution')
  - [RenameFilesInFolder](#P-MFR-CommandLine-Models-CommandLineInfo-RenameFilesInFolder 'MFR.CommandLine.Models.CommandLineInfo.RenameFilesInFolder')
  - [RenameSolutionFolders](#P-MFR-CommandLine-Models-CommandLineInfo-RenameSolutionFolders 'MFR.CommandLine.Models.CommandLineInfo.RenameSolutionFolders')
  - [RenameSubFolders](#P-MFR-CommandLine-Models-CommandLineInfo-RenameSubFolders 'MFR.CommandLine.Models.CommandLineInfo.RenameSubFolders')
  - [ReplaceTextInFiles](#P-MFR-CommandLine-Models-CommandLineInfo-ReplaceTextInFiles 'MFR.CommandLine.Models.CommandLineInfo.ReplaceTextInFiles')
  - [ReplaceWith](#P-MFR-CommandLine-Models-CommandLineInfo-ReplaceWith 'MFR.CommandLine.Models.CommandLineInfo.ReplaceWith')
  - [ShouldCommitPendingChanges](#P-MFR-CommandLine-Models-CommandLineInfo-ShouldCommitPendingChanges 'MFR.CommandLine.Models.CommandLineInfo.ShouldCommitPendingChanges')
  - [ShouldCommitPostOperationChanges](#P-MFR-CommandLine-Models-CommandLineInfo-ShouldCommitPostOperationChanges 'MFR.CommandLine.Models.CommandLineInfo.ShouldCommitPostOperationChanges')
  - [StartingFolder](#P-MFR-CommandLine-Models-CommandLineInfo-StartingFolder 'MFR.CommandLine.Models.CommandLineInfo.StartingFolder')
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

<a name='P-MFR-CommandLine-Models-CommandLineInfo-AutoStart'></a>
### AutoStart `property`

##### Summary

Gets or sets a value indicating whether processing starts when the application
starts.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets a string containing the content to be found in the file system
entries.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-MatchCase'></a>
### MatchCase `property`

##### Summary

Gets or sets a value indicating whether a case-sensitive search should be done.

##### Remarks

The default value of this property is `true`.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-MatchWholeWord'></a>
### MatchWholeWord `property`

##### Summary

Gets or sets a value indicating whether a whole-word search should be done.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-ReOpenSolution'></a>
### ReOpenSolution `property`

##### Summary

Gets or sets a value that indicates that the Solution is to be reloaded when
the operations are finished.

##### Remarks

The default value of this property is `true`.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-RenameFilesInFolder'></a>
### RenameFilesInFolder `property`

##### Summary

Gets or sets a value indicating whether the files are to be renamed.

##### Remarks

The default value of this property is `true`.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-RenameSolutionFolders'></a>
### RenameSolutionFolders `property`

##### Summary

Gets or sets a value indicating whether we are to rename folder(s) that contain Solution(s).

<a name='P-MFR-CommandLine-Models-CommandLineInfo-RenameSubFolders'></a>
### RenameSubFolders `property`

##### Summary

Gets or sets a value indicating whether sub folders should be renamed.

##### Remarks

The default value of this property is `true`.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-ReplaceTextInFiles'></a>
### ReplaceTextInFiles `property`

##### Summary

Gets or sets a value indicating whether text in files should be replaced.

##### Remarks

The default value of this property is `true`.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets a string containing the content to be replaced in the file system
entries.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-ShouldCommitPendingChanges'></a>
### ShouldCommitPendingChanges `property`

##### Summary

Gets or sets a value that indicates whether we are to attempt to commit pending
changes to the user's local Git repository, on the current branch, prior to
executing the operations.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-ShouldCommitPostOperationChanges'></a>
### ShouldCommitPostOperationChanges `property`

##### Summary

Gets or sets a value that indicates whether we are to attempt to commit pending
changes to the user's local Git repository, and on the current branch, the
changes that have resulted from the operations we've performed.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-StartingFolder'></a>
### StartingFolder `property`

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
