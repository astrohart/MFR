<a name='assembly'></a>
# MFR.Solutions.Providers.Interfaces

## Contents

- [ILoadedSolutionProvider](#T-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider')
  - [LoadedSolutions](#P-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider-LoadedSolutions 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.LoadedSolutions')
  - [RootDirectoryPath](#P-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider-RootDirectoryPath 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPath')
  - [SetRootDirectoryPath(pathname)](#M-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider-SetRootDirectoryPath-System-String- 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.SetRootDirectoryPath(System.String)')
- [Resources](#T-MFR-Solutions-Providers-Interfaces-Properties-Resources 'MFR.Solutions.Providers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Solutions-Providers-Interfaces-Properties-Resources-Culture 'MFR.Solutions.Providers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Solutions-Providers-Interfaces-Properties-Resources-ResourceManager 'MFR.Solutions.Providers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider'></a>
## ILoadedSolutionProvider `type`

##### Namespace

MFR.Solutions.Providers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that manages
the Visual Studio Solution (`*.sln`) files that are currently loaded in
running instances of Visual Studio..

<a name='P-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider-LoadedSolutions'></a>
### LoadedSolutions `property`

##### Summary

Gets a reference to a collection, each element of which implements the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface.

##### Remarks

Each element of the collection represents a Visual Studio Solution (*.sln) that
is loaded in a running instance of Visual Studio.

<a name='P-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider-RootDirectoryPath'></a>
### RootDirectoryPath `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the folder in which the operation(s) that are selected by the user
start.

##### Remarks

If the value of this property is updated, then the
[](#E-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider-RootDirectoryPathChanged 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPathChanged')
event is raised.

<a name='M-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider-SetRootDirectoryPath-System-String-'></a>
### SetRootDirectoryPath(pathname) `method`

##### Summary

Updates the value of the
[RootDirectoryPath](#P-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider-RootDirectoryPath 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPath')
property with the specified folder `pathname`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the fully-qualified pathname of the folder that should be set as the
new root directory value. |

##### Remarks

The term "root directory" pertains to the folder in which the operation(s)
specified by the user for this application to execute, start.



If the argument of the `pathname` parameter does not refer to
a folder that exists on the file system, then this method does nothing.



When this method has updated the value of the
[RootDirectoryPath](#P-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider-RootDirectoryPath 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPath')
property, then the
[](#E-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider-RootDirectoryPathChanged 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPathChanged')
event is raised.

<a name='T-MFR-Solutions-Providers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Solutions.Providers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Solutions-Providers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Solutions-Providers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
