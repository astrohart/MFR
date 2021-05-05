<a name='assembly'></a>
# MFR.Objects.CommandLine.Validators.Factories

## Contents

- [GetCommandLineValidator](#T-MFR-Objects-CommandLine-Validators-Factories-GetCommandLineValidator 'MFR.Objects.CommandLine.Validators.Factories.GetCommandLineValidator')
  - [SoleInstance()](#M-MFR-Objects-CommandLine-Validators-Factories-GetCommandLineValidator-SoleInstance 'MFR.Objects.CommandLine.Validators.Factories.GetCommandLineValidator.SoleInstance')
- [GetRootDirectoryValidator](#T-MFR-Objects-CommandLine-Validators-Factories-GetRootDirectoryValidator 'MFR.Objects.CommandLine.Validators.Factories.GetRootDirectoryValidator')
  - [SoleInstance()](#M-MFR-Objects-CommandLine-Validators-Factories-GetRootDirectoryValidator-SoleInstance 'MFR.Objects.CommandLine.Validators.Factories.GetRootDirectoryValidator.SoleInstance')
- [Resources](#T-MFR-Objects-CommandLine-Validators-Factories-Properties-Resources 'MFR.Objects.CommandLine.Validators.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-CommandLine-Validators-Factories-Properties-Resources-Culture 'MFR.Objects.CommandLine.Validators.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-CommandLine-Validators-Factories-Properties-Resources-ResourceManager 'MFR.Objects.CommandLine.Validators.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-CommandLine-Validators-Factories-GetCommandLineValidator'></a>
## GetCommandLineValidator `type`

##### Namespace

MFR.Objects.CommandLine.Validators.Factories

##### Summary

Provides access to the sole instance of the object that implements the
[ICommandLineValidator](#T-MFR-Objects-CommandLine-Validators-Interfaces-ICommandLineValidator 'MFR.Objects.CommandLine.Validators.Interfaces.ICommandLineValidator')
interface.

<a name='M-MFR-Objects-CommandLine-Validators-Factories-GetCommandLineValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Provides access to the sole instance of the object that implements
the
[ICommandLineValidator](#T-MFR-Objects-CommandLine-Validators-Interfaces-ICommandLineValidator 'MFR.Objects.CommandLine.Validators.Interfaces.ICommandLineValidator')
interface.

##### Returns

Reference to an instance of an object that implements the
[ICommandLineValidator](#T-MFR-Objects-CommandLine-Validators-Interfaces-ICommandLineValidator 'MFR.Objects.CommandLine.Validators.Interfaces.ICommandLineValidator')
interface.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object type requested is not supported. |

<a name='T-MFR-Objects-CommandLine-Validators-Factories-GetRootDirectoryValidator'></a>
## GetRootDirectoryValidator `type`

##### Namespace

MFR.Objects.CommandLine.Validators.Factories

##### Summary

Provides access to the sole instance of the object that implements the
[IRootDirectoryValidator](#T-MFR-Objects-CommandLine-Validators-Interfaces-IRootDirectoryValidator 'MFR.Objects.CommandLine.Validators.Interfaces.IRootDirectoryValidator')
interface.

<a name='M-MFR-Objects-CommandLine-Validators-Factories-GetRootDirectoryValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Provides access to the sole instance of the object that implements
the
[IRootDirectoryValidator](#T-MFR-Objects-CommandLine-Validators-Interfaces-IRootDirectoryValidator 'MFR.Objects.CommandLine.Validators.Interfaces.IRootDirectoryValidator')
interface.

##### Returns

Reference to an instance of an object that implements the
[IRootDirectoryValidator](#T-MFR-Objects-CommandLine-Validators-Interfaces-IRootDirectoryValidator 'MFR.Objects.CommandLine.Validators.Interfaces.IRootDirectoryValidator')
interface.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object type requested is not supported. |

<a name='T-MFR-Objects-CommandLine-Validators-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.CommandLine.Validators.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-CommandLine-Validators-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-CommandLine-Validators-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
