<a name='assembly'></a>
# MFR.CommandLine.Models

## Contents

- [CommandLineInfo](#T-MFR-CommandLine-Models-CommandLineInfo 'MFR.CommandLine.Models.CommandLineInfo')
  - [#ctor()](#M-MFR-CommandLine-Models-CommandLineInfo-#ctor 'MFR.CommandLine.Models.CommandLineInfo.#ctor')
  - [AutoQuitOnCompletion](#P-MFR-CommandLine-Models-CommandLineInfo-AutoQuitOnCompletion 'MFR.CommandLine.Models.CommandLineInfo.AutoQuitOnCompletion')
  - [AutoStart](#P-MFR-CommandLine-Models-CommandLineInfo-AutoStart 'MFR.CommandLine.Models.CommandLineInfo.AutoStart')
  - [FindWhat](#P-MFR-CommandLine-Models-CommandLineInfo-FindWhat 'MFR.CommandLine.Models.CommandLineInfo.FindWhat')
  - [MatchCase](#P-MFR-CommandLine-Models-CommandLineInfo-MatchCase 'MFR.CommandLine.Models.CommandLineInfo.MatchCase')
  - [MatchExactWord](#P-MFR-CommandLine-Models-CommandLineInfo-MatchExactWord 'MFR.CommandLine.Models.CommandLineInfo.MatchExactWord')
  - [ReOpenSolution](#P-MFR-CommandLine-Models-CommandLineInfo-ReOpenSolution 'MFR.CommandLine.Models.CommandLineInfo.ReOpenSolution')
  - [RenameFilesInFolder](#P-MFR-CommandLine-Models-CommandLineInfo-RenameFilesInFolder 'MFR.CommandLine.Models.CommandLineInfo.RenameFilesInFolder')
  - [RenameSolutionFolders](#P-MFR-CommandLine-Models-CommandLineInfo-RenameSolutionFolders 'MFR.CommandLine.Models.CommandLineInfo.RenameSolutionFolders')
  - [RenameSubFolders](#P-MFR-CommandLine-Models-CommandLineInfo-RenameSubFolders 'MFR.CommandLine.Models.CommandLineInfo.RenameSubFolders')
  - [ReplaceTextInFiles](#P-MFR-CommandLine-Models-CommandLineInfo-ReplaceTextInFiles 'MFR.CommandLine.Models.CommandLineInfo.ReplaceTextInFiles')
  - [ReplaceWith](#P-MFR-CommandLine-Models-CommandLineInfo-ReplaceWith 'MFR.CommandLine.Models.CommandLineInfo.ReplaceWith')
  - [ShouldCommitPendingChanges](#P-MFR-CommandLine-Models-CommandLineInfo-ShouldCommitPendingChanges 'MFR.CommandLine.Models.CommandLineInfo.ShouldCommitPendingChanges')
  - [ShouldCommitPostOperationChanges](#P-MFR-CommandLine-Models-CommandLineInfo-ShouldCommitPostOperationChanges 'MFR.CommandLine.Models.CommandLineInfo.ShouldCommitPostOperationChanges')
  - [StartingFolder](#P-MFR-CommandLine-Models-CommandLineInfo-StartingFolder 'MFR.CommandLine.Models.CommandLineInfo.StartingFolder')
  - [UpdateGitOnAutoStart](#P-MFR-CommandLine-Models-CommandLineInfo-UpdateGitOnAutoStart 'MFR.CommandLine.Models.CommandLineInfo.UpdateGitOnAutoStart')
  - [#cctor()](#M-MFR-CommandLine-Models-CommandLineInfo-#cctor 'MFR.CommandLine.Models.CommandLineInfo.#cctor')
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

<a name='M-MFR-CommandLine-Models-CommandLineInfo-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of
[CommandLineInfo](#T-MFR-CommandLine-Models-CommandLineInfo 'MFR.CommandLine.Models.CommandLineInfo') and returns a reference
to it.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor is marked `protected`
due to the fact that this class is marked `abstract`.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-AutoQuitOnCompletion'></a>
### AutoQuitOnCompletion `property`

##### Summary

Gets or sets a value that indicates that the application should quit when the
operations are finished.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-AutoStart'></a>
### AutoStart `property`

##### Summary

Gets or sets a value indicating whether processing starts when the application
starts.

##### Remarks

If nothing was specified on the command line for this property, then
its value is `false`.

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

If nothing was specified on the command line for this property, then
its value is `null`.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-MatchExactWord'></a>
### MatchExactWord `property`

##### Summary

Gets or sets a value indicating whether a whole-word search should be done.

##### Remarks

If nothing was specified on the command line for this property, then
its value is `null`.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-ReOpenSolution'></a>
### ReOpenSolution `property`

##### Summary

Gets or sets a value that indicates that the Solution is to be reloaded when
the operations are finished.

##### Remarks

If nothing was specified on the command line for this property, then
its value is `null`.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-RenameFilesInFolder'></a>
### RenameFilesInFolder `property`

##### Summary

Gets or sets a value indicating whether the files are to be renamed.

##### Remarks

The default value of this property is `true`.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-RenameSolutionFolders'></a>
### RenameSolutionFolders `property`

##### Summary

Gets or sets a value indicating whether we are to rename folder(s) that contain
Solution(s).

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

If nothing was specified on the command line for this property, then
its value is set to `true`.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets a string containing the content to be replaced in the file system
entries.

##### Remarks

This property's value is set to the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value if it is not specified on the
command line.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-ShouldCommitPendingChanges'></a>
### ShouldCommitPendingChanges `property`

##### Summary

Gets or sets a value that indicates whether we are to attempt to commit pending
changes to the user's local Git repository, on the current branch, prior to
executing the operations.

##### Remarks

If nothing was specified on the command line for this property, then
its value is `null`.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-ShouldCommitPostOperationChanges'></a>
### ShouldCommitPostOperationChanges `property`

##### Summary

Gets or sets a value that indicates whether we are to attempt to commit pending
changes to the user's local Git repository, and on the current branch, the
changes that have resulted from the operations we've performed.

##### Remarks

If nothing was specified on the command line for this property, then
its value is `null`.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-StartingFolder'></a>
### StartingFolder `property`

##### Summary

Gets or sets a string that contains the starting folder.

<a name='P-MFR-CommandLine-Models-CommandLineInfo-UpdateGitOnAutoStart'></a>
### UpdateGitOnAutoStart `property`

##### Summary

Gets or sets a value indicating whether to update the user's local Git
repository even when running in `Auto Start` mode.

##### Remarks

If this property has a `null` value, then that means
the user did not specify the corresponding flag on the command line at all.



The default value of this property is `null`.

<a name='M-MFR-CommandLine-Models-CommandLineInfo-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [CommandLineInfo](#T-MFR-CommandLine-Models-CommandLineInfo 'MFR.CommandLine.Models.CommandLineInfo') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.

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
