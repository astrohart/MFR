<a name='assembly'></a>
# MFR.File.Stream.Providers.Factories

## Contents

- [GetFileHostProvider](#T-MFR-File-Stream-Providers-Factories-GetFileHostProvider 'MFR.File.Stream.Providers.Factories.GetFileHostProvider')
  - [#cctor()](#M-MFR-File-Stream-Providers-Factories-GetFileHostProvider-#cctor 'MFR.File.Stream.Providers.Factories.GetFileHostProvider.#cctor')
  - [SoleInstance()](#M-MFR-File-Stream-Providers-Factories-GetFileHostProvider-SoleInstance 'MFR.File.Stream.Providers.Factories.GetFileHostProvider.SoleInstance')
- [Resources](#T-MFR-File-Stream-Providers-Factories-Properties-Resources 'MFR.File.Stream.Providers.Factories.Properties.Resources')
  - [Culture](#P-MFR-File-Stream-Providers-Factories-Properties-Resources-Culture 'MFR.File.Stream.Providers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-File-Stream-Providers-Factories-Properties-Resources-ResourceManager 'MFR.File.Stream.Providers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-File-Stream-Providers-Factories-GetFileHostProvider'></a>
## GetFileHostProvider `type`

##### Namespace

MFR.File.Stream.Providers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IFileHostProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileHostProvider 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider')
interface.

<a name='M-MFR-File-Stream-Providers-Factories-GetFileHostProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[GetFileHostProvider](#T-MFR-File-Stream-Providers-Factories-GetFileHostProvider 'MFR.File.Stream.Providers.Factories.GetFileHostProvider') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-File-Stream-Providers-Factories-GetFileHostProvider-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IFileHostProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileHostProvider 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IFileHostProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileHostProvider 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-File-Stream-Providers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.File.Stream.Providers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-File-Stream-Providers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-File-Stream-Providers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
