<a name='assembly'></a>
# MFR.Solutions.Providers.Factories

## Contents

- [GetLoadedSolutionProvider](#T-MFR-Solutions-Providers-Factories-GetLoadedSolutionProvider 'MFR.Solutions.Providers.Factories.GetLoadedSolutionProvider')
  - [SoleInstance()](#M-MFR-Solutions-Providers-Factories-GetLoadedSolutionProvider-SoleInstance 'MFR.Solutions.Providers.Factories.GetLoadedSolutionProvider.SoleInstance')
- [Resources](#T-MFR-Solutions-Providers-Factories-Properties-Resources 'MFR.Solutions.Providers.Factories.Properties.Resources')
  - [Culture](#P-MFR-Solutions-Providers-Factories-Properties-Resources-Culture 'MFR.Solutions.Providers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Solutions-Providers-Factories-Properties-Resources-ResourceManager 'MFR.Solutions.Providers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Solutions-Providers-Factories-GetLoadedSolutionProvider'></a>
## GetLoadedSolutionProvider `type`

##### Namespace

MFR.Solutions.Providers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[ILoadedSolutionProvider](#T-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider')
interface.

<a name='M-MFR-Solutions-Providers-Factories-GetLoadedSolutionProvider-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[ILoadedSolutionProvider](#T-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[ILoadedSolutionProvider](#T-MFR-Solutions-Providers-Interfaces-ILoadedSolutionProvider 'MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-Solutions-Providers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Solutions.Providers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Solutions-Providers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Solutions-Providers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
