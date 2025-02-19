<a name='assembly'></a>
# MFR.CommandLine.Models.Interfaces

## Contents

- [ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo')
  - [AutoQuitOnCompletion](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-AutoQuitOnCompletion 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.AutoQuitOnCompletion')
  - [AutoStart](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-AutoStart 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.AutoStart')
  - [FindWhat](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-FindWhat 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.FindWhat')
  - [MatchCase](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-MatchCase 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.MatchCase')
  - [MatchExactWord](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-MatchExactWord 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.MatchExactWord')
  - [ReOpenSolution](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ReOpenSolution 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.ReOpenSolution')
  - [RenameFilesInFolder](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-RenameFilesInFolder 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.RenameFilesInFolder')
  - [RenameSolutionFolders](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-RenameSolutionFolders 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.RenameSolutionFolders')
  - [RenameSubFolders](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-RenameSubFolders 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.RenameSubFolders')
  - [ReplaceTextInFiles](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ReplaceTextInFiles 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.ReplaceTextInFiles')
  - [ReplaceWith](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ReplaceWith 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.ReplaceWith')
  - [ShouldCommitPendingChanges](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ShouldCommitPendingChanges 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.ShouldCommitPendingChanges')
  - [ShouldCommitPostOperationChanges](#P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ShouldCommitPostOperationChanges 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo.ShouldCommitPostOperationChanges')
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

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-AutoQuitOnCompletion'></a>
### AutoQuitOnCompletion `property`

##### Summary

Gets or sets a value that indicates that the application should quit when the
operations are finished.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-AutoStart'></a>
### AutoStart `property`

##### Summary

Gets or sets a value indicating whether processing starts when the application
starts.

##### Remarks

If nothing was specified on the command line for this property, then
its value is `false`.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets a string containing the content to be found in the file system
entries.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-MatchCase'></a>
### MatchCase `property`

##### Summary

Gets or sets a value indicating whether a case-sensitive search should be done.

##### Remarks

If nothing was specified on the command line for this property, then
its value is `null`.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-MatchExactWord'></a>
### MatchExactWord `property`

##### Summary

Gets or sets a value indicating whether a whole-word search should be done.

##### Remarks

If nothing was specified on the command line for this property, then
its value is `null`.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ReOpenSolution'></a>
### ReOpenSolution `property`

##### Summary

Gets or sets a value that indicates that the Solution is to be reloaded when
the operations are finished.

##### Remarks

If nothing was specified on the command line for this property, then
its value is `null`.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-RenameFilesInFolder'></a>
### RenameFilesInFolder `property`

##### Summary

Gets or sets a value indicating whether the files are to be renamed.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-RenameSolutionFolders'></a>
### RenameSolutionFolders `property`

##### Summary

Gets or sets a value indicating whether we are to rename folder(s) that contain
Solution(s).

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-RenameSubFolders'></a>
### RenameSubFolders `property`

##### Summary

Gets or sets a value indicating whether sub folders should be renamed.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ReplaceTextInFiles'></a>
### ReplaceTextInFiles `property`

##### Summary

Gets or sets a value indicating whether text in files should be replaced.

##### Remarks

If nothing was specified on the command line for this property, then
its value is set to `true`.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets a string containing the content to be replaced in the file system
entries.

##### Remarks

This property's value is set to the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value if it is not specified on the
command line.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ShouldCommitPendingChanges'></a>
### ShouldCommitPendingChanges `property`

##### Summary

Gets or sets a value that indicates whether we are to attempt to commit pending
changes to the user's local Git repository, on the current branch, prior to
executing the operations.

##### Remarks

If nothing was specified on the command line for this property, then
its value is `null`.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-ShouldCommitPostOperationChanges'></a>
### ShouldCommitPostOperationChanges `property`

##### Summary

Gets or sets a value that indicates whether we are to attempt to commit pending
changes to the user's local Git repository, and on the current branch, the
changes that have resulted from the operations we've performed.

##### Remarks

If nothing was specified on the command line for this property, then
its value is `null`.

<a name='P-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-StartingFolder'></a>
### StartingFolder `property`

##### Summary

Gets or sets a string that contains the starting folder.

##### Remarks

This property's value is set to the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value if it is not specified on the
command line.

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
