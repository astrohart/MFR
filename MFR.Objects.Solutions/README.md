<a name='assembly'></a>
# MFR.Objects.Solutions

## Contents

- [Resources](#T-MFR-Objects-Solutions-Properties-Resources 'MFR.Objects.Solutions.Properties.Resources')
  - [Culture](#P-MFR-Objects-Solutions-Properties-Resources-Culture 'MFR.Objects.Solutions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Solutions-Properties-Resources-ResourceManager 'MFR.Objects.Solutions.Properties.Resources.ResourceManager')
- [VisualStudioSolution](#T-MFR-Objects-Solutions-VisualStudioSolution 'MFR.Objects.Solutions.VisualStudioSolution')
  - [#ctor()](#M-MFR-Objects-Solutions-VisualStudioSolution-#ctor 'MFR.Objects.Solutions.VisualStudioSolution.#ctor')
  - [#ctor(dte)](#M-MFR-Objects-Solutions-VisualStudioSolution-#ctor-EnvDTE-DTE- 'MFR.Objects.Solutions.VisualStudioSolution.#ctor(EnvDTE.DTE)')
  - [_dte](#F-MFR-Objects-Solutions-VisualStudioSolution-_dte 'MFR.Objects.Solutions.VisualStudioSolution._dte')
  - [ContainingFolder](#P-MFR-Objects-Solutions-VisualStudioSolution-ContainingFolder 'MFR.Objects.Solutions.VisualStudioSolution.ContainingFolder')
  - [IsLoaded](#P-MFR-Objects-Solutions-VisualStudioSolution-IsLoaded 'MFR.Objects.Solutions.VisualStudioSolution.IsLoaded')
  - [Path](#P-MFR-Objects-Solutions-VisualStudioSolution-Path 'MFR.Objects.Solutions.VisualStudioSolution.Path')
  - [ShouldReopen](#P-MFR-Objects-Solutions-VisualStudioSolution-ShouldReopen 'MFR.Objects.Solutions.VisualStudioSolution.ShouldReopen')
  - [AssertDteInitialized()](#M-MFR-Objects-Solutions-VisualStudioSolution-AssertDteInitialized 'MFR.Objects.Solutions.VisualStudioSolution.AssertDteInitialized')
  - [CommonConstruct()](#M-MFR-Objects-Solutions-VisualStudioSolution-CommonConstruct 'MFR.Objects.Solutions.VisualStudioSolution.CommonConstruct')
  - [Finalize()](#M-MFR-Objects-Solutions-VisualStudioSolution-Finalize 'MFR.Objects.Solutions.VisualStudioSolution.Finalize')
  - [Initialize(dte,path)](#M-MFR-Objects-Solutions-VisualStudioSolution-Initialize-EnvDTE-DTE,System-String- 'MFR.Objects.Solutions.VisualStudioSolution.Initialize(EnvDTE.DTE,System.String)')
  - [Load()](#M-MFR-Objects-Solutions-VisualStudioSolution-Load 'MFR.Objects.Solutions.VisualStudioSolution.Load')
  - [Unload()](#M-MFR-Objects-Solutions-VisualStudioSolution-Unload 'MFR.Objects.Solutions.VisualStudioSolution.Unload')

<a name='T-MFR-Objects-Solutions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Solutions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Solutions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Solutions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-Solutions-VisualStudioSolution'></a>
## VisualStudioSolution `type`

##### Namespace

MFR.Objects.Solutions

##### Summary

Encapsulates the data and actions that are applicable to a Visual Studio
Solution (*.sln) file.

<a name='M-MFR-Objects-Solutions-VisualStudioSolution-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[Solution](#T-MFR-Objects-Solutions-Solution 'MFR.Objects.Solutions.Solution')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Objects-Solutions-VisualStudioSolution-#ctor-EnvDTE-DTE-'></a>
### #ctor(dte) `constructor`

##### Summary

Constructs a new instance of
[Solution](#T-MFR-Objects-Solutions-Solution 'MFR.Objects.Solutions.Solution')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dte | [EnvDTE.DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') | (Required.) Reference to an instance of an object that implements
the [DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `dte`, is passed
a `null` value. |

<a name='F-MFR-Objects-Solutions-VisualStudioSolution-_dte'></a>
### _dte `constants`

##### Summary

Reference to an instance of an object that implements the
[DTE](#T-EnvDTE-DTE 'EnvDTE.DTE')
interface.

<a name='P-MFR-Objects-Solutions-VisualStudioSolution-ContainingFolder'></a>
### ContainingFolder `property`

##### Summary

Gets a string containing the path to the folder that contains the solution.

<a name='P-MFR-Objects-Solutions-VisualStudioSolution-IsLoaded'></a>
### IsLoaded `property`

##### Summary

Gets a value that indicates whether this solution file is currently
loaded in a running instance of Visual Studio.

<a name='P-MFR-Objects-Solutions-VisualStudioSolution-Path'></a>
### Path `property`

##### Summary

Gets a string that contains the fully-qualified pathname of the
Visual Studio Solution (*.sln) file.

<a name='P-MFR-Objects-Solutions-VisualStudioSolution-ShouldReopen'></a>
### ShouldReopen `property`

##### Summary

Gets or sets a value that specifies whether the solution should be
closed and then reopened during an operation. `true`
by default.

<a name='M-MFR-Objects-Solutions-VisualStudioSolution-AssertDteInitialized'></a>
### AssertDteInitialized() `method`

##### Summary

Asserts that the [_dte](#F-MFR-Objects-Solutions-Solution-_dte 'MFR.Objects.Solutions.Solution._dte')
field has been set to a value other than `null`.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [MFR.Objects.Solutions.Exceptions.DteNotInitializedException](#T-MFR-Objects-Solutions-Exceptions-DteNotInitializedException 'MFR.Objects.Solutions.Exceptions.DteNotInitializedException') | Thrown if the [_dte](#F-MFR-Objects-Solutions-Solution-_dte 'MFR.Objects.Solutions.Solution._dte')
field has a `null` value. |

##### Remarks

This method does nothing in the event that the
[_dte](#F-MFR-Objects-Solutions-Solution-_dte 'MFR.Objects.Solutions.Solution._dte')
field has a value.

<a name='M-MFR-Objects-Solutions-VisualStudioSolution-CommonConstruct'></a>
### CommonConstruct() `method`

##### Summary

Processes actions that occur no matter which constructor overload is called.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Solutions-VisualStudioSolution-Finalize'></a>
### Finalize() `method`

##### Summary

Allows an object to try to free resources and perform other cleanup
operations before it is reclaimed by garbage collection.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Solutions-VisualStudioSolution-Initialize-EnvDTE-DTE,System-String-'></a>
### Initialize(dte,path) `method`

##### Summary

Initializes this object with a reference to an instance of an object
that implements the [DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dte | [EnvDTE.DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') | (Required.) Reference to an instance of an object that implements
the [DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') interface. |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Fully-qualified pathname of the solution (*.sln) file. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the contents of the `path` parameter are
not the fully-qualified path of a `*.sln` file. |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `dte`, is passed
a `null` value. |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the contents of the `path` parameter are
no the fully-qualified pathname of a file that exists on the disk. |

##### Remarks

Only call this method if you've used the default
constructor to instantiate this object.

<a name='M-MFR-Objects-Solutions-VisualStudioSolution-Load'></a>
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

<a name='M-MFR-Objects-Solutions-VisualStudioSolution-Unload'></a>
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
