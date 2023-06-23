<a name='assembly'></a>
# MFR.Engines.Operations.Factories

## Contents

- [GetConsoleOperationEngine](#T-MFR-Engines-Operations-Factories-GetConsoleOperationEngine 'MFR.Engines.Operations.Factories.GetConsoleOperationEngine')
  - [SoleInstance()](#M-MFR-Engines-Operations-Factories-GetConsoleOperationEngine-SoleInstance 'MFR.Engines.Operations.Factories.GetConsoleOperationEngine.SoleInstance')
- [GetFullGuiOperationEngine](#T-MFR-Engines-Operations-Factories-GetFullGuiOperationEngine 'MFR.Engines.Operations.Factories.GetFullGuiOperationEngine')
  - [SoleInstance()](#M-MFR-Engines-Operations-Factories-GetFullGuiOperationEngine-SoleInstance 'MFR.Engines.Operations.Factories.GetFullGuiOperationEngine.SoleInstance')
- [GetOperationEngine](#T-MFR-Engines-Operations-Factories-GetOperationEngine 'MFR.Engines.Operations.Factories.GetOperationEngine')
  - [OfType\`\`1(type)](#M-MFR-Engines-Operations-Factories-GetOperationEngine-OfType``1-MFR-Engines-Constants-OperationEngineType- 'MFR.Engines.Operations.Factories.GetOperationEngine.OfType``1(MFR.Engines.Constants.OperationEngineType)')
- [Resources](#T-MFR-Engines-Operations-Factories-Properties-Resources 'MFR.Engines.Operations.Factories.Properties.Resources')
  - [Culture](#P-MFR-Engines-Operations-Factories-Properties-Resources-Culture 'MFR.Engines.Operations.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Operations-Factories-Properties-Resources-ResourceManager 'MFR.Engines.Operations.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Operations-Factories-GetConsoleOperationEngine'></a>
## GetConsoleOperationEngine `type`

##### Namespace

MFR.Engines.Operations.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IConsoleOperationEngine](#T-MFR-Engines-Operations-Interfaces-IConsoleOperationEngine 'MFR.Engines.Operations.Interfaces.IConsoleOperationEngine')
interface.

<a name='M-MFR-Engines-Operations-Factories-GetConsoleOperationEngine-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IConsoleOperationEngine](#T-MFR-Engines-Operations-Interfaces-IConsoleOperationEngine 'MFR.Engines.Operations.Interfaces.IConsoleOperationEngine')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IConsoleOperationEngine](#T-MFR-Engines-Operations-Interfaces-IConsoleOperationEngine 'MFR.Engines.Operations.Interfaces.IConsoleOperationEngine')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-Operations-Factories-GetFullGuiOperationEngine'></a>
## GetFullGuiOperationEngine `type`

##### Namespace

MFR.Engines.Operations.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IFullGuiOperationEngine](#T-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine')
interface.

<a name='M-MFR-Engines-Operations-Factories-GetFullGuiOperationEngine-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IFullGuiOperationEngine](#T-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IFullGuiOperationEngine](#T-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-Operations-Factories-GetOperationEngine'></a>
## GetOperationEngine `type`

##### Namespace

MFR.Engines.Operations.Factories

##### Summary

Creates instances of objects that implement the
[IOperationEngine](#T-MFR-Engines-Interfaces-IOperationEngine 'MFR.Engines.Interfaces.IOperationEngine') interface.

<a name='M-MFR-Engines-Operations-Factories-GetOperationEngine-OfType``1-MFR-Engines-Constants-OperationEngineType-'></a>
### OfType\`\`1(type) `method`

##### Summary

Creates an instance of an object implementing the
[IOperationEngine](#T-MFR-Engines-Interfaces-IOperationEngine 'MFR.Engines.Interfaces.IOperationEngine') interface which
corresponds to the value specified in `type`, and returns a
reference to it.

##### Returns

A reference to the instance of the object that implements the
[IOperationEngine](#T-MFR-Engines-Interfaces-IOperationEngine 'MFR.Engines.Interfaces.IOperationEngine') interface which
corresponds to the value specified in `type`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Engines.Constants.OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType') | One of the
[OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType') values that
describes what type of object you want. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of any interface that implements
[IOperationEngine](#T-MFR-Engines-Interfaces-IOperationEngine 'MFR.Engines.Interfaces.IOperationEngine') to which the returned
object should be cast.



Obviously, the object that is being returned should also implement the
interface that you are specifying in this type parameter. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if there is no
corresponding concrete type defined that implements the
[IOperationEngine](#T-MFR-Engines-Interfaces-IOperationEngine 'MFR.Engines.Interfaces.IOperationEngine') interface and which
corresponds to the value passed in the `type` parameter. |

##### Remarks

This method will throw an exception if there are no types implemented
that correspond to the value of `type`.

<a name='T-MFR-Engines-Operations-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Operations.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Operations-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Operations-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
