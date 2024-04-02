<a name='assembly'></a>
# MFR.Harnesses.LoadedSolutions.Interfaces

## Contents

- [ILoadedSolutionHarness](#T-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness')
  - [ContainingFolder](#P-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-ContainingFolder 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.ContainingFolder')
  - [FullName](#P-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-FullName 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.FullName')
  - [IsInRootDirectoryTree](#P-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-IsInRootDirectoryTree 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.IsInRootDirectoryTree')
  - [IsLoaded](#P-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-IsLoaded 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.IsLoaded')
  - [TargetSolution](#P-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-TargetSolution 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.TargetSolution')
  - [Load()](#M-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-Load 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.Load')
  - [Quit()](#M-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-Quit 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.Quit')
  - [SetFullName(fullName)](#M-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-SetFullName-System-String- 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.SetFullName(System.String)')
  - [ShellOpen()](#M-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-ShellOpen 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.ShellOpen')
  - [Unload()](#M-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-Unload 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.Unload')
- [Resources](#T-MFR-Harnesses-LoadedSolutions-Interfaces-Properties-Resources 'MFR.Harnesses.LoadedSolutions.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Harnesses-LoadedSolutions-Interfaces-Properties-Resources-Culture 'MFR.Harnesses.LoadedSolutions.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Harnesses-LoadedSolutions-Interfaces-Properties-Resources-ResourceManager 'MFR.Harnesses.LoadedSolutions.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness'></a>
## ILoadedSolutionHarness `type`

##### Namespace

MFR.Harnesses.LoadedSolutions.Interfaces

<a name='P-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-ContainingFolder'></a>
### ContainingFolder `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the folder that the target Solution is located in.

##### Remarks

This property returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value
in the case that the value cannot be determined.

<a name='P-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-FullName'></a>
### FullName `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the target Visual Studio Solution (`*.sln`) file.

<a name='P-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-IsInRootDirectoryTree'></a>
### IsInRootDirectoryTree `property`

##### Summary

Gets or sets a value that indicates whether the Visual Studio Solution (
`*.sln`) file managed by the target instance of Visual Studio is in the
directory tree of the current Project File Renamer operation or not.

##### Remarks

This important because it may very well be the case that there may be
running instances of Visual Studio lying about, that have Visual Studio
Solution (`*.sln`) file(s) loaded, and these particular files are not
underneath the starting folder selected by the user in the Project File
Renamer.

<a name='P-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-IsLoaded'></a>
### IsLoaded `property`

##### Summary

Gets a value that indicates whether the target Visual Studio Solution (
`*.sln`) file is loaded in a running instance of Visual Studio.

<a name='P-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-TargetSolution'></a>
### TargetSolution `property`

##### Summary

Gets or sets a reference to an instance of an object that implements the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface.

##### Remarks

Such an object is utilized to automate the instance of Visual Studio that
controls the particular Visual Studio Solution (`*.sln`) file.



When the value of this property is updated, the
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-TargetSolutionChanged 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.TargetSolutionChanged')
event is raised.

<a name='M-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-Load'></a>
### Load() `method`

##### Summary

Opens the target Visual Studio Solution (`*.sln`) file in the target
running instance of Visual Studio.

##### Returns

`true` if the operation completed successfully;
`false` otherwise or if the value of the
[TargetSolution](#P-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-TargetSolution 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.TargetSolution')
property is `null`.

##### Parameters

This method has no parameters.

<a name='M-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-Quit'></a>
### Quit() `method`

##### Summary

Exits the running instance of Visual Studio that has the target Visual Studio
Solution (`*.sln`) file open.

##### Parameters

This method has no parameters.

<a name='M-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-SetFullName-System-String-'></a>
### SetFullName(fullName) `method`

##### Summary

Updates the value of the
[FullName](#P-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-FullName 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.FullName')
property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fullName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the fully-qualified pathname of the Visual Studio Solution (`*.sln`) file
that is represented by the target solution. |

##### Remarks

This method is used when the Project File Renamer algorithms have
renamed the Visual Studio Solution (`*.sln`) file that corresponds to the
Solution that is currently loaded in the target running instance of Visual
Studio.

<a name='M-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-ShellOpen'></a>
### ShellOpen() `method`

##### Summary

Open the target Visual Studio Solution (`*.sln`) file (if it exists) using
the Windows Shell.

##### Returns

`true` if the operation succeeded;
`false` otherwise, or if the operation is cancelled.

##### Parameters

This method has no parameters.

##### Remarks

The
[](#E-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-ShellOpening 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.ShellOpening')
event is raised before the operation is carried out.  Handlers have a chance to
request that the operation be cancelled.



The
[](#E-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-ShellOpened 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.ShellOpened')
event is raised when this method has completed executing the requested
operations.

<a name='M-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-Unload'></a>
### Unload() `method`

##### Summary

Unloads the target Visual Studio Solution (`*.sln`) file from the running
instance of Visual Studio that has it open.

##### Returns

`true` if the operation completed successfully;
`false` otherwise or if the value of the
[TargetSolution](#P-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-TargetSolution 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.TargetSolution')
property is `null`.

##### Parameters

This method has no parameters.

##### Remarks

The
[](#E-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-Unloading 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.Unloading')
event is raised before the operation is carried out.  Handlers have a chance to
request that the operation be cancelled.



The
[](#E-MFR-Harnesses-LoadedSolutions-Interfaces-ILoadedSolutionHarness-Unloaded 'MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.Unloaded')
event is raised when this method has completed executing the requested
operations.

<a name='T-MFR-Harnesses-LoadedSolutions-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Harnesses.LoadedSolutions.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Harnesses-LoadedSolutions-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Harnesses-LoadedSolutions-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
