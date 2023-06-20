<a name='assembly'></a>
# MFR.Solutions.Providers

## Contents

- [LoadedSolutionProvider](#T-MFR-Solutions-Providers-LoadedSolutionProvider 'MFR.Solutions.Providers.LoadedSolutionProvider')
  - [#ctor()](#M-MFR-Solutions-Providers-LoadedSolutionProvider-#ctor 'MFR.Solutions.Providers.LoadedSolutionProvider.#ctor')
  - [Instance](#P-MFR-Solutions-Providers-LoadedSolutionProvider-Instance 'MFR.Solutions.Providers.LoadedSolutionProvider.Instance')
  - [LoadedSolutions](#P-MFR-Solutions-Providers-LoadedSolutionProvider-LoadedSolutions 'MFR.Solutions.Providers.LoadedSolutionProvider.LoadedSolutions')
  - [#cctor()](#M-MFR-Solutions-Providers-LoadedSolutionProvider-#cctor 'MFR.Solutions.Providers.LoadedSolutionProvider.#cctor')
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

<a name='M-MFR-Solutions-Providers-LoadedSolutionProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

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
