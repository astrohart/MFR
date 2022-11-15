<a name='assembly'></a>
# MFR.Directories.Validators.Factories

## Contents

- [GetRootDirectoryValidator](#T-MFR-Directories-Validators-Factories-GetRootDirectoryValidator 'MFR.Directories.Validators.Factories.GetRootDirectoryValidator')
  - [SoleInstance()](#M-MFR-Directories-Validators-Factories-GetRootDirectoryValidator-SoleInstance 'MFR.Directories.Validators.Factories.GetRootDirectoryValidator.SoleInstance')
- [Resources](#T-MFR-Directories-Validators-Factories-Properties-Resources 'MFR.Directories.Validators.Factories.Properties.Resources')
  - [Culture](#P-MFR-Directories-Validators-Factories-Properties-Resources-Culture 'MFR.Directories.Validators.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Validators-Factories-Properties-Resources-ResourceManager 'MFR.Directories.Validators.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Directories-Validators-Factories-GetRootDirectoryValidator'></a>
## GetRootDirectoryValidator `type`

##### Namespace

MFR.Directories.Validators.Factories

##### Summary

Provides access to the sole instance of the object that implements the
[IRootDirectoryValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryValidator')
interface.

<a name='M-MFR-Directories-Validators-Factories-GetRootDirectoryValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Provides access to the sole instance of the object that implements
the
[IRootDirectoryValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryValidator')
interface.

##### Returns

Reference to an instance of an object that implements the
[IRootDirectoryValidator](#T-MFR-Directories-Validators-Interfaces-IRootDirectoryValidator 'MFR.Directories.Validators.Interfaces.IRootDirectoryValidator')
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
