<a name='assembly'></a>
# MFR.Harnesses.LoadedSolutions

## Contents

- [LoadedSolutionHarness](#T-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness')
  - [#ctor()](#M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-#ctor-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution- 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.#ctor(xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution)')
  - [_targetSolution](#F-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-_targetSolution 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness._targetSolution')
  - [ContainingFolder](#P-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-ContainingFolder 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.ContainingFolder')
  - [FullName](#P-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-FullName 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.FullName')
  - [IsInRootDirectoryTree](#P-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-IsInRootDirectoryTree 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.IsInRootDirectoryTree')
  - [IsLoaded](#P-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-IsLoaded 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.IsLoaded')
  - [TargetSolution](#P-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-TargetSolution 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.TargetSolution')
  - [Load()](#M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Load 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Load')
  - [OnLoaded()](#M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnLoaded 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.OnLoaded')
  - [OnLoading(e)](#M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnLoading-System-ComponentModel-CancelEventArgs- 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.OnLoading(System.ComponentModel.CancelEventArgs)')
  - [OnQuitted()](#M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnQuitted 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.OnQuitted')
  - [OnQuitting(e)](#M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnQuitting-System-ComponentModel-CancelEventArgs- 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.OnQuitting(System.ComponentModel.CancelEventArgs)')
  - [OnShellOpened()](#M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnShellOpened 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.OnShellOpened')
  - [OnShellOpening(e)](#M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnShellOpening-System-ComponentModel-CancelEventArgs- 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.OnShellOpening(System.ComponentModel.CancelEventArgs)')
  - [OnTargetSolutionChanged()](#M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnTargetSolutionChanged 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.OnTargetSolutionChanged')
  - [OnUnloaded()](#M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnUnloaded 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.OnUnloaded')
  - [OnUnloading(e)](#M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnUnloading-System-ComponentModel-CancelEventArgs- 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.OnUnloading(System.ComponentModel.CancelEventArgs)')
  - [Quit()](#M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Quit 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Quit')
  - [ShellOpen()](#M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-ShellOpen 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.ShellOpen')
  - [Unload()](#M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Unload 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Unload')
- [Resources](#T-MFR-Harnesses-LoadedSolutions-Properties-Resources 'MFR.Harnesses.LoadedSolutions.Properties.Resources')
  - [Culture](#P-MFR-Harnesses-LoadedSolutions-Properties-Resources-Culture 'MFR.Harnesses.LoadedSolutions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Harnesses-LoadedSolutions-Properties-Resources-ResourceManager 'MFR.Harnesses.LoadedSolutions.Properties.Resources.ResourceManager')

<a name='T-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness'></a>
## LoadedSolutionHarness `type`

##### Namespace

MFR.Harnesses.LoadedSolutions

##### Summary

Provides a `harness` that links a Visual Studio Solution (`*.sln`)
file together with the additional parameters and properties that enable the
application to work with it.

##### Remarks

A `harness` object to associate a Visual Studio Solution (`*.sln`)
file that
is loaded in a target running instance of Visual Studio with additional
parameters and options that make ti possible for the Project File Renamer
application to effectively manage it, regardless of whether the Visual Studio
Solution (`*.sln`) in question is in or out of the directory tree of the
root directory (i.e., the folder that the user has chosen to start the Project
File Renamer operations in).

<a name='M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-#ctor-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution-'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[LoadedSolutionHarness](#T-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness') and
returns a reference to it.

##### Parameters

This constructor has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `targetSolution`, is passed a
`null` value. |

<a name='F-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-_targetSolution'></a>
### _targetSolution `constants`

##### Summary

Reference to an instance of an object that implements the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface that represents the Visual Studio Solution (`*.sln`) that is
targeted by this harness.

<a name='P-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-ContainingFolder'></a>
### ContainingFolder `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the folder that the target Solution is located in.

##### Remarks

This property returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value
in the case that the value cannot be determined.

<a name='P-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-FullName'></a>
### FullName `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the target Visual Studio Solution (`*.sln`) file.

<a name='P-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-IsInRootDirectoryTree'></a>
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

<a name='P-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-IsLoaded'></a>
### IsLoaded `property`

##### Summary

Gets a value that indicates whether the target Visual Studio Solution (
`*.sln`) file is loaded in a running instance of Visual Studio.

<a name='P-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-TargetSolution'></a>
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

<a name='M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Load'></a>
### Load() `method`

##### Summary

Opens the target Visual Studio Solution (`*.sln`) file in the target
running instance of Visual Studio.

##### Returns

`true` if the operation completed successfully;
`false` otherwise or if the value of the
[TargetSolution](#P-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-TargetSolution 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.TargetSolution')
property is `null`.

##### Parameters

This method has no parameters.

##### Remarks

The
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Loading 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Loading')
event is raised before the operation is carried out.  Handlers have a chance to
request that the operation be cancelled.



The
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Loaded 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Loaded')
event is raised when this method has completed executing the requested
operations.

<a name='M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnLoaded'></a>
### OnLoaded() `method`

##### Summary

Raises the
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Loaded 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Loaded')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnLoading-System-ComponentModel-CancelEventArgs-'></a>
### OnLoading(e) `method`

##### Summary

Raises the
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Loading 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Loading')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.ComponentModel.CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') | A [CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') that
allows us to cancel the operation that this event is notifying the caller of.



To cancel the operation, handlers should set the value of the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true`. |

<a name='M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnQuitted'></a>
### OnQuitted() `method`

##### Summary

Raises the
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Quitted 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Quitted')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnQuitting-System-ComponentModel-CancelEventArgs-'></a>
### OnQuitting(e) `method`

##### Summary

Raises the
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Quitting 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Quitting')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.ComponentModel.CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') | A [CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') that
allows us to cancel the operation that this event is notifying the caller of.



To cancel the operation, handlers should set the value of the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true`. |

<a name='M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnShellOpened'></a>
### OnShellOpened() `method`

##### Summary

Raises the
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-ShellOpened 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.ShellOpened')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnShellOpening-System-ComponentModel-CancelEventArgs-'></a>
### OnShellOpening(e) `method`

##### Summary

Raises the
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-ShellOpening 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.ShellOpening')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.ComponentModel.CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') | A [CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') that
allows us to cancel the operation that this event is notifying the caller of.



To cancel the operation, handlers should set the value of the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true`. |

<a name='M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnTargetSolutionChanged'></a>
### OnTargetSolutionChanged() `method`

##### Summary

Raises the
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-TargetSolutionChanged 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.TargetSolutionChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnUnloaded'></a>
### OnUnloaded() `method`

##### Summary

Raises the
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Unloaded 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Unloaded')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-OnUnloading-System-ComponentModel-CancelEventArgs-'></a>
### OnUnloading(e) `method`

##### Summary

Raises the
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Unloading 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Unloading')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.ComponentModel.CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') | A [CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') that
allows us to cancel the operation that this event is notifying the caller of.



To cancel the operation, handlers should set the value of the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true`. |

<a name='M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Quit'></a>
### Quit() `method`

##### Summary

Exits the running instance of Visual Studio that has the target Visual Studio
Solution (`*.sln`) file open.

##### Parameters

This method has no parameters.

<a name='M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-ShellOpen'></a>
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
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-ShellOpening 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.ShellOpening')
event is raised before the operation is carried out.  Handlers have a chance to
request that the operation be cancelled.



The
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-ShellOpened 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.ShellOpened')
event is raised when this method has completed executing the requested
operations.

<a name='M-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Unload'></a>
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
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Unloading 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Unloading')
event is raised before the operation is carried out.  Handlers have a chance to
request that the operation be cancelled.



The
[](#E-MFR-Harnesses-LoadedSolutions-LoadedSolutionHarness-Unloaded 'MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Unloaded')
event is raised when this method has completed executing the requested
operations.

<a name='T-MFR-Harnesses-LoadedSolutions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Harnesses.LoadedSolutions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Harnesses-LoadedSolutions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Harnesses-LoadedSolutions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
