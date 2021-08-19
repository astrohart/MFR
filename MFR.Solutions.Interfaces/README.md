<a name='assembly'></a>
# MFR.Objects.Solutions.Interfaces

## Contents

- [IVisualStudioSolution](#T-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution 'MFR.Objects.Solutions.Interfaces.IVisualStudioSolution')
  - [ContainingFolder](#P-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution-ContainingFolder 'MFR.Objects.Solutions.Interfaces.IVisualStudioSolution.ContainingFolder')
  - [IsLoaded](#P-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution-IsLoaded 'MFR.Objects.Solutions.Interfaces.IVisualStudioSolution.IsLoaded')
  - [Path](#P-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution-Path 'MFR.Objects.Solutions.Interfaces.IVisualStudioSolution.Path')
  - [ShouldReopen](#P-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution-ShouldReopen 'MFR.Objects.Solutions.Interfaces.IVisualStudioSolution.ShouldReopen')
  - [Load()](#M-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution-Load 'MFR.Objects.Solutions.Interfaces.IVisualStudioSolution.Load')
  - [Unload()](#M-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution-Unload 'MFR.Objects.Solutions.Interfaces.IVisualStudioSolution.Unload')
- [Resources](#T-MFR-Objects-Solutions-Interfaces-Properties-Resources 'MFR.Objects.Solutions.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Solutions-Interfaces-Properties-Resources-Culture 'MFR.Objects.Solutions.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Solutions-Interfaces-Properties-Resources-ResourceManager 'MFR.Objects.Solutions.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution'></a>
## IVisualStudioSolution `type`

##### Namespace

MFR.Objects.Solutions.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a Visual Studio
solution.

##### Remarks

Objects that are expected to be implementers of this interface are
little more than `POCO` s.

<a name='P-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution-ContainingFolder'></a>
### ContainingFolder `property`

##### Summary

Gets a string containing the path to the folder that contains the solution.

<a name='P-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution-IsLoaded'></a>
### IsLoaded `property`

##### Summary

Gets a value that indicates whether this solution file is currently
loaded in a running instance of Visual Studio.

<a name='P-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution-Path'></a>
### Path `property`

##### Summary

Gets a string that contains the fully-qualified pathname of the
Visual Studio Solution (*.sln) file.

<a name='P-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution-ShouldReopen'></a>
### ShouldReopen `property`

##### Summary

Gets or sets a value that specifies whether the solution should be
closed and then reopened during an operation. `true`
by default.

<a name='M-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution-Load'></a>
### Load() `method`

##### Summary

Forces either a currently-running instance of Visual Studio to load
the solution, or opens the solution in a new instance of `devenv.exe`.

##### Returns

`true` if the operation completed successfully;
`false`
otherwise.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution-Unload'></a>
### Unload() `method`

##### Summary

Forces the particular, and currently-running, instance of Visual
Studio that currently has the solution open to unload (i.e., close) it.

##### Returns

`true` if the operation completed successfully;
`false`
otherwise.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Solutions-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Solutions.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Solutions-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Solutions-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
