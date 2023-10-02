<a name='assembly'></a>
# MFR.Directories.Validators.Factories

## Contents

- [GetRootDirectoryPathValidator](#T-MFR-Directories-Validators-Factories-GetRootDirectoryPathValidator 'MFR.Directories.Validators.Factories.GetRootDirectoryPathValidator')
  - [SoleInstance()](#M-MFR-Directories-Validators-Factories-GetRootDirectoryPathValidator-SoleInstance 'MFR.Directories.Validators.Factories.GetRootDirectoryPathValidator.SoleInstance')
- [Resources](#T-MFR-Directories-Validators-Factories-Properties-Resources 'MFR.Directories.Validators.Factories.Properties.Resources')
  - [Culture](#P-MFR-Directories-Validators-Factories-Properties-Resources-Culture 'MFR.Directories.Validators.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Validators-Factories-Properties-Resources-ResourceManager 'MFR.Directories.Validators.Factories.Properties.Resources.ResourceManager')

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
