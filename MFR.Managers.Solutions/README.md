<a name='assembly'></a>
# MFR.Managers.Solutions

## Contents

- [Resources](#T-MFR-Managers-Solutions-Properties-Resources 'MFR.Managers.Solutions.Properties.Resources')
  - [Culture](#P-MFR-Managers-Solutions-Properties-Resources-Culture 'MFR.Managers.Solutions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Managers-Solutions-Properties-Resources-ResourceManager 'MFR.Managers.Solutions.Properties.Resources.ResourceManager')
- [VisualStudioSolutionService](#T-MFR-Managers-Solutions-VisualStudioSolutionService 'MFR.Managers.Solutions.VisualStudioSolutionService')
  - [#ctor()](#M-MFR-Managers-Solutions-VisualStudioSolutionService-#ctor 'MFR.Managers.Solutions.VisualStudioSolutionService.#ctor')
  - [Instance](#P-MFR-Managers-Solutions-VisualStudioSolutionService-Instance 'MFR.Managers.Solutions.VisualStudioSolutionService.Instance')
  - [#cctor()](#M-MFR-Managers-Solutions-VisualStudioSolutionService-#cctor 'MFR.Managers.Solutions.VisualStudioSolutionService.#cctor')
  - [ContainsLoadedSolutions(folder)](#M-MFR-Managers-Solutions-VisualStudioSolutionService-ContainsLoadedSolutions-System-String- 'MFR.Managers.Solutions.VisualStudioSolutionService.ContainsLoadedSolutions(System.String)')
  - [GetLoadedSolutionsInFolder(folder)](#M-MFR-Managers-Solutions-VisualStudioSolutionService-GetLoadedSolutionsInFolder-System-String- 'MFR.Managers.Solutions.VisualStudioSolutionService.GetLoadedSolutionsInFolder(System.String)')
  - [LoadAll(solutions)](#M-MFR-Managers-Solutions-VisualStudioSolutionService-LoadAll-System-Collections-Generic-IReadOnlyList{xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution}- 'MFR.Managers.Solutions.VisualStudioSolutionService.LoadAll(System.Collections.Generic.IReadOnlyList{xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution})')
  - [ShouldSkipFile(path)](#M-MFR-Managers-Solutions-VisualStudioSolutionService-ShouldSkipFile-System-String- 'MFR.Managers.Solutions.VisualStudioSolutionService.ShouldSkipFile(System.String)')
  - [UnloadAll(solutions)](#M-MFR-Managers-Solutions-VisualStudioSolutionService-UnloadAll-System-Collections-Generic-IReadOnlyList{xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution}- 'MFR.Managers.Solutions.VisualStudioSolutionService.UnloadAll(System.Collections.Generic.IReadOnlyList{xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution})')

<a name='T-MFR-Managers-Solutions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Managers.Solutions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Managers-Solutions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Managers-Solutions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Managers-Solutions-VisualStudioSolutionService'></a>
## VisualStudioSolutionService `type`

##### Namespace

MFR.Managers.Solutions

##### Summary

Manages running instances of Visual Studio that have solutions in
specified folder(s) loaded.

<a name='M-MFR-Managers-Solutions-VisualStudioSolutionService-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Managers-Solutions-VisualStudioSolutionService-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [VisualStudioSolutionService](#T-MFR-Managers-Solutions-VisualStudioSolutionService 'MFR.Managers.Solutions.VisualStudioSolutionService').

<a name='M-MFR-Managers-Solutions-VisualStudioSolutionService-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Managers-Solutions-VisualStudioSolutionService-ContainsLoadedSolutions-System-String-'></a>
### ContainsLoadedSolutions(folder) `method`

##### Summary

Determines whether the folder having path passed in the
`folder`
parameter contains any `*.sln` files that represent
solutions currently loaded by running instances of Visual Studio.

##### Returns

`true` if the specified `folder`
contains `*.sln` files that are currently loaded by running instances
of Visual Studio; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folder | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of a
folder that should be scanned for `*.sln` files. |

<a name='M-MFR-Managers-Solutions-VisualStudioSolutionService-GetLoadedSolutionsInFolder-System-String-'></a>
### GetLoadedSolutionsInFolder(folder) `method`

##### Summary

Scans the folder whose path is provided in the
`folder`
parameter for `*.sln` files, and, for each file
located, determines whether a running instance of Visual Studio has
it loaded.



If this is so, then information about the loaded solution is
returned as an element of a collection of any other such solutions.

##### Returns

Read-only list of references to instances of objects that implement
the
[IVisualStudioSolution](#T-MFR-Solutions-Interfaces-IVisualStudioSolution 'MFR.Solutions.Interfaces.IVisualStudioSolution')
interface for each instance of Visual Studio that has that solution loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folder | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of a
folder that should be scanned for `*.sln` files. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `folder`, is
passed a blank or `null` string for a value. |
| [DirectoryNotFoundException](#T-DirectoryNotFoundException 'DirectoryNotFoundException') | Thrown if the directory whose fully-qualified path is passed in the
`folder` parameter cannot be found on the disk. |

<a name='M-MFR-Managers-Solutions-VisualStudioSolutionService-LoadAll-System-Collections-Generic-IReadOnlyList{xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution}-'></a>
### LoadAll(solutions) `method`

##### Summary

Instructs the appropriate currently-running instances of Visual
Studio who had solutions in the specified collection open at one
time, to load them again.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| solutions | [System.Collections.Generic.IReadOnlyList{xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution}') | (Required.) Reference to a collection of references to instances of
objects that implement the
[IVisualStudioSolution](#T-MFR-Solutions-Interfaces-IVisualStudioSolution 'MFR.Solutions.Interfaces.IVisualStudioSolution')
interface that represent the solution(s) to be loaded. |

<a name='M-MFR-Managers-Solutions-VisualStudioSolutionService-ShouldSkipFile-System-String-'></a>
### ShouldSkipFile(path) `method`

##### Summary

Determines whether a file with the `path` should be
skipped in a search.

##### Returns

`true` if the `path` provided
should not be included in the results; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the path to be checked. |

<a name='M-MFR-Managers-Solutions-VisualStudioSolutionService-UnloadAll-System-Collections-Generic-IReadOnlyList{xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution}-'></a>
### UnloadAll(solutions) `method`

##### Summary

Instructs the appropriate currently-running instances of Visual
Studio who had solutions in the specified collection not loaded at
one time, to unload them again.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| solutions | [System.Collections.Generic.IReadOnlyList{xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution}') | (Required.) Reference to a collection of references to instances of
objects that implement the
[IVisualStudioSolution](#T-MFR-Solutions-Interfaces-IVisualStudioSolution 'MFR.Solutions.Interfaces.IVisualStudioSolution')
interface which represent the solution(s) to be unloaded. |
