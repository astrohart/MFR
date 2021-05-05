<a name='assembly'></a>
# MFR.Objects.Solutions.Factories

## Contents

- [GetNewVisualStudioSolutionObject](#T-MFR-Objects-Solutions-Factories-GetNewVisualStudioSolutionObject 'MFR.Objects.Solutions.Factories.GetNewVisualStudioSolutionObject')
  - [AndPath(solution,path)](#M-MFR-Objects-Solutions-Factories-GetNewVisualStudioSolutionObject-AndPath-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution,System-String- 'MFR.Objects.Solutions.Factories.GetNewVisualStudioSolutionObject.AndPath(MFR.Objects.Solutions.Interfaces.IVisualStudioSolution,System.String)')
  - [ForVisualStudioInstance(dte)](#M-MFR-Objects-Solutions-Factories-GetNewVisualStudioSolutionObject-ForVisualStudioInstance-EnvDTE-DTE- 'MFR.Objects.Solutions.Factories.GetNewVisualStudioSolutionObject.ForVisualStudioInstance(EnvDTE.DTE)')
- [Resources](#T-MFR-Objects-Solutions-Factories-Properties-Resources 'MFR.Objects.Solutions.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Solutions-Factories-Properties-Resources-Culture 'MFR.Objects.Solutions.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Solutions-Factories-Properties-Resources-ResourceManager 'MFR.Objects.Solutions.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Solutions-Factories-GetNewVisualStudioSolutionObject'></a>
## GetNewVisualStudioSolutionObject `type`

##### Namespace

MFR.Objects.Solutions.Factories

##### Summary

Creates new instances of objects that implement the
[IVisualStudioSolution](#T-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution 'MFR.Objects.Solutions.Interfaces.IVisualStudioSolution')
interface, and returns references to them.

<a name='M-MFR-Objects-Solutions-Factories-GetNewVisualStudioSolutionObject-AndPath-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution,System-String-'></a>
### AndPath(solution,path) `method`

##### Summary

Builder method that initializes the
[Path](#P-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution-Path 'MFR.Objects.Solutions.Interfaces.IVisualStudioSolution.Path')
property with the value provided in the `path` parameter.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| solution | [MFR.Objects.Solutions.Interfaces.IVisualStudioSolution](#T-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution 'MFR.Objects.Solutions.Interfaces.IVisualStudioSolution') | (Required.) Reference to an instance of an object that implements
the
[IVisualStudioSolution](#T-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution 'MFR.Objects.Solutions.Interfaces.IVisualStudioSolution')
interface. |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of a
Visual Studio Solution (*.sln) file. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `path`, is passed
a blank or `null` string for a value, or if the
`path` parameter does not contain the
fully-qualified pathname of a Visual Studio Solution (*.sln) file. |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `solution`, is
passed a `null` value. |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the string passed to the `path` parameter
is not equal to the fully-qualified pathname of a file that exists
on the disk. |

<a name='M-MFR-Objects-Solutions-Factories-GetNewVisualStudioSolutionObject-ForVisualStudioInstance-EnvDTE-DTE-'></a>
### ForVisualStudioInstance(dte) `method`

##### Summary

Creates a new instance of an object that implements the
[IVisualStudioSolution](#T-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution 'MFR.Objects.Solutions.Interfaces.IVisualStudioSolution')
interface and returns a reference to it, initialized with the
reference to an instance of an object that implements the
[DTE](#T-EnvDTE-DTE 'EnvDTE.DTE')
interface provided in the
`dte`
parameter.

##### Returns

Reference to an instance of an object that implements the
[IVisualStudioSolution](#T-MFR-Objects-Solutions-Interfaces-IVisualStudioSolution 'MFR.Objects.Solutions.Interfaces.IVisualStudioSolution')
interface.

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

<a name='T-MFR-Objects-Solutions-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Solutions.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Solutions-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Solutions-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
