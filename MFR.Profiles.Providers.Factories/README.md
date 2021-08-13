<a name='assembly'></a>
# MFR.Profiles.Providers.Factories

## Contents

- [GetProfileProvider](#T-MFR-Profiles-Providers-Factories-GetProfileProvider 'MFR.Profiles.Providers.Factories.GetProfileProvider')
  - [SoleInstance()](#M-MFR-Profiles-Providers-Factories-GetProfileProvider-SoleInstance 'MFR.Profiles.Providers.Factories.GetProfileProvider.SoleInstance')
- [Resources](#T-MFR-Profiles-Providers-Factories-Properties-Resources 'MFR.Profiles.Providers.Factories.Properties.Resources')
  - [Culture](#P-MFR-Profiles-Providers-Factories-Properties-Resources-Culture 'MFR.Profiles.Providers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Profiles-Providers-Factories-Properties-Resources-ResourceManager 'MFR.Profiles.Providers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Profiles-Providers-Factories-GetProfileProvider'></a>
## GetProfileProvider `type`

##### Namespace

MFR.Profiles.Providers.Factories

##### Summary

Creates instances of objects that implement the
[IProfileProvider](#T-MFR-Profiles-Providers-Interfaces-IProfileProvider 'MFR.Profiles.Providers.Interfaces.IProfileProvider')
interface.

<a name='M-MFR-Profiles-Providers-Factories-GetProfileProvider-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IProfileProvider](#T-MFR-Profiles-Providers-Interfaces-IProfileProvider 'MFR.Profiles.Providers.Interfaces.IProfileProvider')
interface.

##### Returns

Reference to an instance of an object that implements the
[IProfileProvider](#T-MFR-Profiles-Providers-Interfaces-IProfileProvider 'MFR.Profiles.Providers.Interfaces.IProfileProvider')
interface.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object type requested is not supported. |

<a name='T-MFR-Profiles-Providers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Profiles.Providers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Profiles-Providers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Profiles-Providers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
