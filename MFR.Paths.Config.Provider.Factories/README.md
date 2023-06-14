<a name='assembly'></a>
# MFR.Paths.Config.Provider.Factories

## Contents

- [GetConfigPathProvider](#T-MFR-Paths-Config-Provider-Factories-GetConfigPathProvider 'MFR.Paths.Config.Provider.Factories.GetConfigPathProvider')
  - [SoleInstance()](#M-MFR-Paths-Config-Provider-Factories-GetConfigPathProvider-SoleInstance 'MFR.Paths.Config.Provider.Factories.GetConfigPathProvider.SoleInstance')
- [Resources](#T-MFR-Paths-Config-Provider-Factories-Properties-Resources 'MFR.Paths.Config.Provider.Factories.Properties.Resources')
  - [Culture](#P-MFR-Paths-Config-Provider-Factories-Properties-Resources-Culture 'MFR.Paths.Config.Provider.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Paths-Config-Provider-Factories-Properties-Resources-ResourceManager 'MFR.Paths.Config.Provider.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Paths-Config-Provider-Factories-GetConfigPathProvider'></a>
## GetConfigPathProvider `type`

##### Namespace

MFR.Paths.Config.Provider.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IConfigPathProvider](#T-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider')
interface that manages the loading and storing of the application configuration
file's pathname to/from the system Registry.

<a name='M-MFR-Paths-Config-Provider-Factories-GetConfigPathProvider-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IConfigPathProvider](#T-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IConfigPathProvider](#T-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider')
interface that manages the loading and storing of the application configuration
file's pathname to/from the system Registry.

##### Parameters

This method has no parameters.

<a name='T-MFR-Paths-Config-Provider-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Paths.Config.Provider.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Paths-Config-Provider-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Paths-Config-Provider-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
