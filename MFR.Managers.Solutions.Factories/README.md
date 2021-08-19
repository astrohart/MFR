<a name='assembly'></a>
# MFR.Objects.Managers.Solutions.Factories

## Contents

- [GetVisualStudioSolutionService](#T-MFR-Objects-Managers-Solutions-Factories-GetVisualStudioSolutionService 'MFR.Objects.Managers.Solutions.Factories.GetVisualStudioSolutionService')
  - [SoleInstance()](#M-MFR-Objects-Managers-Solutions-Factories-GetVisualStudioSolutionService-SoleInstance 'MFR.Objects.Managers.Solutions.Factories.GetVisualStudioSolutionService.SoleInstance')
- [Resources](#T-MFR-Objects-Managers-Solutions-Factories-Properties-Resources 'MFR.Objects.Managers.Solutions.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Managers-Solutions-Factories-Properties-Resources-Culture 'MFR.Objects.Managers.Solutions.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Managers-Solutions-Factories-Properties-Resources-ResourceManager 'MFR.Objects.Managers.Solutions.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Managers-Solutions-Factories-GetVisualStudioSolutionService'></a>
## GetVisualStudioSolutionService `type`

##### Namespace

MFR.Objects.Managers.Solutions.Factories

##### Summary

Creates instances of objects that implement the
[IVisualStudioSolutionService](#T-MFR-Objects-Managers-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Objects.Managers.Solutions.Interfaces.IVisualStudioSolutionService')
interface.

<a name='M-MFR-Objects-Managers-Solutions-Factories-GetVisualStudioSolutionService-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Creates a new instance of an object that implements the
[IVisualStudioSolutionService](#T-MFR-Objects-Managers-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Objects.Managers.Solutions.Interfaces.IVisualStudioSolutionService')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IVisualStudioSolutionService](#T-MFR-Objects-Managers-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Objects.Managers.Solutions.Interfaces.IVisualStudioSolutionService')
interface.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object type requested is not supported. |

<a name='T-MFR-Objects-Managers-Solutions-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Managers.Solutions.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Managers-Solutions-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Managers-Solutions-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
