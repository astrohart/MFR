<a name='assembly'></a>
# MFR.Solutions.Providers

## Contents

- [LoadedSolutionProvider](#T-MFR-Solutions-Providers-LoadedSolutionProvider 'MFR.Solutions.Providers.LoadedSolutionProvider')
  - [#ctor()](#M-MFR-Solutions-Providers-LoadedSolutionProvider-#ctor 'MFR.Solutions.Providers.LoadedSolutionProvider.#ctor')
  - [_loadedSolutions](#F-MFR-Solutions-Providers-LoadedSolutionProvider-_loadedSolutions 'MFR.Solutions.Providers.LoadedSolutionProvider._loadedSolutions')
  - [_rootDirectoryPath](#F-MFR-Solutions-Providers-LoadedSolutionProvider-_rootDirectoryPath 'MFR.Solutions.Providers.LoadedSolutionProvider._rootDirectoryPath')
  - [Instance](#P-MFR-Solutions-Providers-LoadedSolutionProvider-Instance 'MFR.Solutions.Providers.LoadedSolutionProvider.Instance')
  - [LoadedSolutions](#P-MFR-Solutions-Providers-LoadedSolutionProvider-LoadedSolutions 'MFR.Solutions.Providers.LoadedSolutionProvider.LoadedSolutions')
  - [RootDirectoryPath](#P-MFR-Solutions-Providers-LoadedSolutionProvider-RootDirectoryPath 'MFR.Solutions.Providers.LoadedSolutionProvider.RootDirectoryPath')
  - [#cctor()](#M-MFR-Solutions-Providers-LoadedSolutionProvider-#cctor 'MFR.Solutions.Providers.LoadedSolutionProvider.#cctor')
  - [OnRootDirectoryPathChanged()](#M-MFR-Solutions-Providers-LoadedSolutionProvider-OnRootDirectoryPathChanged 'MFR.Solutions.Providers.LoadedSolutionProvider.OnRootDirectoryPathChanged')
  - [SetRootDirectoryPath(pathname)](#M-MFR-Solutions-Providers-LoadedSolutionProvider-SetRootDirectoryPath-System-String- 'MFR.Solutions.Providers.LoadedSolutionProvider.SetRootDirectoryPath(System.String)')
- [Resources](#T-MFR-Solutions-Providers-Properties-Resources 'MFR.Solutions.Providers.Properties.Resources')
  - [Culture](#P-MFR-Solutions-Providers-Properties-Resources-Culture 'MFR.Solutions.Providers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Solutions-Providers-Properties-Resources-ResourceManager 'MFR.Solutions.Providers.Properties.Resources.ResourceManager')

<a name='T-MFR-Solutions-Providers-LoadedSolutionProvider'></a>
## LoadedSolutionProvider `type`

##### Namespace

MFR.Solutions.Providers

##### Summary

Manages the Visual Studio Solution (`*.sln`) files that are currently
loaded in running instances of Visual Studio.

<a name='M-MFR-Solutions-Providers-LoadedSolutionProvider-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Solutions-Providers-LoadedSolutionProvider-_loadedSolutions'></a>
### _loadedSolutions `constants`

##### Summary

Reference to an instance of a collection of instances of objects that implement
the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface.

<a name='F-MFR-Solutions-Providers-LoadedSolutionProvider-_rootDirectoryPath'></a>
### _rootDirectoryPath `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified pathname of
the folder in which the operation(s) that are selected by the user start.

<a name='P-MFR-Solutions-Providers-LoadedSolutionProvider-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[ILoadedSolutionProvider](#T-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider')
interface.

<a name='P-MFR-Solutions-Providers-LoadedSolutionProvider-LoadedSolutions'></a>
### LoadedSolutions `property`

##### Summary

Gets a reference to a collection, each element of which implements the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface.

##### Remarks

Each element of the collection represents a Visual Studio Solution (*.sln) that
is loaded in a running instance of Visual Studio.

<a name='P-MFR-Solutions-Providers-LoadedSolutionProvider-RootDirectoryPath'></a>
### RootDirectoryPath `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the folder in which the operation(s) that are selected by the user
start.

##### Remarks

If the value of this property is updated, then the
[](#E-MFR-Solutions-Providers-LoadedSolutionProvider-RootDirectoryPathChanged 'MFR.Solutions.Providers.LoadedSolutionProvider.RootDirectoryPathChanged')
event is raised.

<a name='M-MFR-Solutions-Providers-LoadedSolutionProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Solutions-Providers-LoadedSolutionProvider-OnRootDirectoryPathChanged'></a>
### OnRootDirectoryPathChanged() `method`

##### Summary

Raises the
[](#E-MFR-Solutions-Providers-LoadedSolutionProvider-RootDirectoryPathChanged 'MFR.Solutions.Providers.LoadedSolutionProvider.RootDirectoryPathChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Solutions-Providers-LoadedSolutionProvider-SetRootDirectoryPath-System-String-'></a>
### SetRootDirectoryPath(pathname) `method`

##### Summary

Updates the value of the
[RootDirectoryPath](#P-MFR-Solutions-Providers-LoadedSolutionProvider-RootDirectoryPath 'MFR.Solutions.Providers.LoadedSolutionProvider.RootDirectoryPath')
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



When this method has updated the value of the property, then the
[](#E-MFR-Solutions-Providers-LoadedSolutionProvider-RootDirectoryPathChanged 'MFR.Solutions.Providers.LoadedSolutionProvider.RootDirectoryPathChanged')
event is raised.

<a name='T-MFR-Solutions-Providers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Solutions.Providers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Solutions-Providers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Solutions-Providers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
