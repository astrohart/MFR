<a name='assembly'></a>
# MFR.CommandLine.Validators.Factories

## Contents

- [GetCommandLineValidator](#T-MFR-CommandLine-Validators-Factories-GetCommandLineValidator 'MFR.CommandLine.Validators.Factories.GetCommandLineValidator')
  - [#cctor()](#M-MFR-CommandLine-Validators-Factories-GetCommandLineValidator-#cctor 'MFR.CommandLine.Validators.Factories.GetCommandLineValidator.#cctor')
  - [SoleInstance()](#M-MFR-CommandLine-Validators-Factories-GetCommandLineValidator-SoleInstance 'MFR.CommandLine.Validators.Factories.GetCommandLineValidator.SoleInstance')
- [Resources](#T-MFR-CommandLine-Validators-Factories-Properties-Resources 'MFR.CommandLine.Validators.Factories.Properties.Resources')
  - [Culture](#P-MFR-CommandLine-Validators-Factories-Properties-Resources-Culture 'MFR.CommandLine.Validators.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-CommandLine-Validators-Factories-Properties-Resources-ResourceManager 'MFR.CommandLine.Validators.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-CommandLine-Validators-Factories-GetCommandLineValidator'></a>
## GetCommandLineValidator `type`

##### Namespace

MFR.CommandLine.Validators.Factories

##### Summary

Provides access to the sole instance of the object that implements the
[ICommandLineValidator](#T-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator')
interface.

<a name='M-MFR-CommandLine-Validators-Factories-GetCommandLineValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[GetCommandLineValidator](#T-MFR-CommandLine-Validators-Factories-GetCommandLineValidator 'MFR.CommandLine.Validators.Factories.GetCommandLineValidator')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-CommandLine-Validators-Factories-GetCommandLineValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Provides access to the sole instance of the object that implements
the
[ICommandLineValidator](#T-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator')
interface.

##### Returns

Reference to an instance of an object that implements the
[ICommandLineValidator](#T-MFR-CommandLine-Validators-Interfaces-ICommandLineValidator 'MFR.CommandLine.Validators.Interfaces.ICommandLineValidator')
interface.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object type requested is not supported. |

<a name='T-MFR-CommandLine-Validators-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.CommandLine.Validators.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-CommandLine-Validators-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-CommandLine-Validators-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
