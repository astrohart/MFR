<a name='assembly'></a>
# MFR.Managers.Solutions.Interfaces

## Contents

- [IVisualStudioSolutionService](#T-MFR-Objects-Managers-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService')
  - [ContainsLoadedSolutions(folder)](#M-MFR-Objects-Managers-Solutions-Interfaces-IVisualStudioSolutionService-ContainsLoadedSolutions-System-String- 'MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService.ContainsLoadedSolutions(System.String)')
  - [GetLoadedSolutionsInFolder(folder)](#M-MFR-Objects-Managers-Solutions-Interfaces-IVisualStudioSolutionService-GetLoadedSolutionsInFolder-System-String- 'MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService.GetLoadedSolutionsInFolder(System.String)')
  - [LoadAll(solutions)](#M-MFR-Objects-Managers-Solutions-Interfaces-IVisualStudioSolutionService-LoadAll-System-Collections-Generic-IReadOnlyList{MFR-Objects-Solutions-Interfaces-IVisualStudioSolution}- 'MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService.LoadAll(System.Collections.Generic.IReadOnlyList{MFR.Solutions.Interfaces.IVisualStudioSolution})')
  - [UnloadAll(solutions)](#M-MFR-Objects-Managers-Solutions-Interfaces-IVisualStudioSolutionService-UnloadAll-System-Collections-Generic-IReadOnlyList{MFR-Objects-Solutions-Interfaces-IVisualStudioSolution}- 'MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService.UnloadAll(System.Collections.Generic.IReadOnlyList{MFR.Solutions.Interfaces.IVisualStudioSolution})')
- [Resources](#T-MFR-Objects-Managers-Solutions-Interfaces-Properties-Resources 'MFR.Managers.Solutions.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Managers-Solutions-Interfaces-Properties-Resources-Culture 'MFR.Managers.Solutions.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Managers-Solutions-Interfaces-Properties-Resources-ResourceManager 'MFR.Managers.Solutions.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Managers-Solutions-Interfaces-IVisualStudioSolutionService'></a>
## IVisualStudioSolutionService `type`

##### Namespace

MFR.Managers.Solutions.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a ` Solution
            Service ` object.

##### Remarks

`Solution Service` objects allow management of Visual Studio Solution
(*.sln) files, such as scanning for them, detecting if they're loaded,
and loading / unloading them in open instances of Visual Studio.

<a name='M-MFR-Objects-Managers-Solutions-Interfaces-IVisualStudioSolutionService-ContainsLoadedSolutions-System-String-'></a>
### ContainsLoadedSolutions(folder) `method`

##### Summary

Determines whether the folder having path passed in the `folder` parameter contains any *.sln files that represent
solutions currently loaded by running instances of Visual Studio.

##### Returns

`true` if the specified `folder`
contains *.sln files that are currently loaded by running instances
of Visual Studio; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folder | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of a
folder that should be scanned for *.sln files. |

<a name='M-MFR-Objects-Managers-Solutions-Interfaces-IVisualStudioSolutionService-GetLoadedSolutionsInFolder-System-String-'></a>
### GetLoadedSolutionsInFolder(folder) `method`

##### Summary

Scans the folder whose path is provided in the `folder` parameter for *.sln files, and, for each file
located, determines whether a running instance of Visual Studio has
it loaded.



If this is so, then information about the loaded solution is
returned as an element of a collection of any other such solutions.

##### Returns

Read-only list of references to instances of objects that implement
the [IVisualStudioSolution](#T-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution 'MFR.Solutions.Interfaces.IVisualStudioSolution')
interface for each instance of Visual Studio that has that solution loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folder | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of a
folder that should be scanned for *.sln files. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `folder`, is
passed a blank or `null` string for a value. |
| [DirectoryNotFoundException](#T-DirectoryNotFoundException 'DirectoryNotFoundException') | Thrown if the directory whose fully-qualified path is passed in the
`folder` parameter cannot be found on the disk. |

<a name='M-MFR-Objects-Managers-Solutions-Interfaces-IVisualStudioSolutionService-LoadAll-System-Collections-Generic-IReadOnlyList{MFR-Objects-Solutions-Interfaces-IVisualStudioSolution}-'></a>
### LoadAll(solutions) `method`

##### Summary

Instructs the appropriate currently-running instances of Visual
Studio who had solutions in the specified collection open at one
time, to load them again.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| solutions | [System.Collections.Generic.IReadOnlyList{MFR.Solutions.Interfaces.IVisualStudioSolution}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{MFR.Solutions.Interfaces.IVisualStudioSolution}') | (Required.) Reference to a collection of references to instances of
objects that implement the [IVisualStudioSolution](#T-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution 'MFR.Solutions.Interfaces.IVisualStudioSolution')
interface that represent the solution(s) to be loaded. |

<a name='M-MFR-Objects-Managers-Solutions-Interfaces-IVisualStudioSolutionService-UnloadAll-System-Collections-Generic-IReadOnlyList{MFR-Objects-Solutions-Interfaces-IVisualStudioSolution}-'></a>
### UnloadAll(solutions) `method`

##### Summary

Instructs the appropriate currently-running instances of Visual
Studio who had solutions in the specified collection not loaded at
one time, to unload them again.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| solutions | [System.Collections.Generic.IReadOnlyList{MFR.Solutions.Interfaces.IVisualStudioSolution}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{MFR.Solutions.Interfaces.IVisualStudioSolution}') | (Required.) Reference to a collection of references to instances of
objects that implement the [IVisualStudioSolution](#T-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution 'MFR.Solutions.Interfaces.IVisualStudioSolution')
interface which represent the solution(s) to be unloaded. |

<a name='T-MFR-Objects-Managers-Solutions-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Managers.Solutions.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Managers-Solutions-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Managers-Solutions-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
