<a name='assembly'></a>
# MFR.Directories.Validators.Factories

## Contents

- [GetRootDirectoryInvalidReasonValidator](#T-MFR-Directories-Validators-Factories-GetRootDirectoryInvalidReasonValidator 'MFR.Directories.Validators.Factories.GetRootDirectoryInvalidReasonValidator')
  - [#cctor()](#M-MFR-Directories-Validators-Factories-GetRootDirectoryInvalidReasonValidator-#cctor 'MFR.Directories.Validators.Factories.GetRootDirectoryInvalidReasonValidator.#cctor')
  - [SoleInstance()](#M-MFR-Directories-Validators-Factories-GetRootDirectoryInvalidReasonValidator-SoleInstance 'MFR.Directories.Validators.Factories.GetRootDirectoryInvalidReasonValidator.SoleInstance')
- [GetRootDirectoryPathValidator](#T-MFR-Directories-Validators-Factories-GetRootDirectoryPathValidator 'MFR.Directories.Validators.Factories.GetRootDirectoryPathValidator')
  - [SoleInstance()](#M-MFR-Directories-Validators-Factories-GetRootDirectoryPathValidator-SoleInstance 'MFR.Directories.Validators.Factories.GetRootDirectoryPathValidator.SoleInstance')
- [Resources](#T-MFR-Directories-Validators-Factories-Properties-Resources 'MFR.Directories.Validators.Factories.Properties.Resources')
  - [Culture](#P-MFR-Directories-Validators-Factories-Properties-Resources-Culture 'MFR.Directories.Validators.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Validators-Factories-Properties-Resources-ResourceManager 'MFR.Directories.Validators.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Directories-Validators-Factories-GetRootDirectoryInvalidReasonValidator'></a>
## GetRootDirectoryInvalidReasonValidator `type`

##### Namespace

MFR.Directories.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IRootDirectoryInvalidReasonValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryInvalidReasonValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryInvalidReasonValidator')
interface.

<a name='M-MFR-Directories-Validators-Factories-GetRootDirectoryInvalidReasonValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[GetRootDirectoryInvalidReasonValidator](#T-MFR-Directories-Validators-Factories-GetRootDirectoryInvalidReasonValidator 'MFR.Directories.Validators.Factories.GetRootDirectoryInvalidReasonValidator')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-MFR-Directories-Validators-Factories-GetRootDirectoryInvalidReasonValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IRootDirectoryInvalidReasonValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryInvalidReasonValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryInvalidReasonValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IRootDirectoryInvalidReasonValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryInvalidReasonValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryInvalidReasonValidator')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-Directories-Validators-Factories-GetRootDirectoryPathValidator'></a>
## GetRootDirectoryPathValidator `type`

##### Namespace

MFR.Directories.Validators.Factories

##### Summary

Provides access to the sole instance of the object that implements the
[IRootDirectoryPathValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryPathValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator')
interface.

<a name='M-MFR-Directories-Validators-Factories-GetRootDirectoryPathValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Provides access to the sole instance of the object that implements
the
[IRootDirectoryPathValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryPathValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator')
interface.

##### Returns

Reference to an instance of an object that implements the
[IRootDirectoryPathValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryPathValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator')
interface.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object type requested is not supported. |

<a name='T-MFR-Directories-Validators-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Directories.Validators.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Directories-Validators-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Directories-Validators-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
