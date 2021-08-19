<a name='assembly'></a>
# MFR.Objects.Interop.Monikers.Wrappers

## Contents

- [MonikerWrapper](#T-MFR-Objects-Interop-Monikers-Wrappers-MonikerWrapper 'MFR.Objects.Interop.Monikers.Wrappers.MonikerWrapper')
  - [#ctor()](#M-MFR-Objects-Interop-Monikers-Wrappers-MonikerWrapper-#ctor 'MFR.Objects.Interop.Monikers.Wrappers.MonikerWrapper.#ctor')
  - [ComObject](#P-MFR-Objects-Interop-Monikers-Wrappers-MonikerWrapper-ComObject 'MFR.Objects.Interop.Monikers.Wrappers.MonikerWrapper.ComObject')
  - [DisplayName](#P-MFR-Objects-Interop-Monikers-Wrappers-MonikerWrapper-DisplayName 'MFR.Objects.Interop.Monikers.Wrappers.MonikerWrapper.DisplayName')
  - [Moniker](#P-MFR-Objects-Interop-Monikers-Wrappers-MonikerWrapper-Moniker 'MFR.Objects.Interop.Monikers.Wrappers.MonikerWrapper.Moniker')
- [Resources](#T-MFR-Objects-Interop-Monikers-Wrappers-Properties-Resources 'MFR.Objects.Interop.Monikers.Wrappers.Properties.Resources')
  - [Culture](#P-MFR-Objects-Interop-Monikers-Wrappers-Properties-Resources-Culture 'MFR.Objects.Interop.Monikers.Wrappers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Interop-Monikers-Wrappers-Properties-Resources-ResourceManager 'MFR.Objects.Interop.Monikers.Wrappers.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Interop-Monikers-Wrappers-MonikerWrapper'></a>
## MonikerWrapper `type`

##### Namespace

MFR.Objects.Interop.Monikers.Wrappers

##### Summary

POCO that encapsulates the information from the moniker table provided
by the operating system.

<a name='M-MFR-Objects-Interop-Monikers-Wrappers-MonikerWrapper-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[MonikerWrapper](#T-MFR-Objects-Interop-Monikers-Wrappers-MonikerWrapper 'MFR.Objects.Interop.Monikers.Wrappers.MonikerWrapper')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Interop-Monikers-Wrappers-MonikerWrapper-ComObject'></a>
### ComObject `property`

##### Summary

Gets a reference to an instance of the COM object that corresponds
to the moniker.

<a name='P-MFR-Objects-Interop-Monikers-Wrappers-MonikerWrapper-DisplayName'></a>
### DisplayName `property`

##### Summary

Gets a string that contains the object's display name.

<a name='P-MFR-Objects-Interop-Monikers-Wrappers-MonikerWrapper-Moniker'></a>
### Moniker `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IMoniker 'System.Runtime.InteropServices.ComTypes.IMoniker') interface.

<a name='T-MFR-Objects-Interop-Monikers-Wrappers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Interop.Monikers.Wrappers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Interop-Monikers-Wrappers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Interop-Monikers-Wrappers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
