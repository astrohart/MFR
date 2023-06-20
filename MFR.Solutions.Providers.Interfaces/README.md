<a name='assembly'></a>
# MFR.Solutions.Providers.Interfaces

## Contents

- [ILoadedSolutionProvider](#T-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider')
  - [LoadedSolutions](#P-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider-LoadedSolutions 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.LoadedSolutions')
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
