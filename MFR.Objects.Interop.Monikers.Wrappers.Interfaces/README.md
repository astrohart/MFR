<a name='assembly'></a>
# MFR.Objects.Interop.Monikers.Wrappers.Interfaces

## Contents

- [IMonikerWrapper](#T-MFR-Objects-Interop-Monikers-Wrappers-Interfaces-IMonikerWrapper 'MFR.Objects.Interop.Monikers.Wrappers.Interfaces.IMonikerWrapper')
  - [ComObject](#P-MFR-Objects-Interop-Monikers-Wrappers-Interfaces-IMonikerWrapper-ComObject 'MFR.Objects.Interop.Monikers.Wrappers.Interfaces.IMonikerWrapper.ComObject')
  - [DisplayName](#P-MFR-Objects-Interop-Monikers-Wrappers-Interfaces-IMonikerWrapper-DisplayName 'MFR.Objects.Interop.Monikers.Wrappers.Interfaces.IMonikerWrapper.DisplayName')
  - [Moniker](#P-MFR-Objects-Interop-Monikers-Wrappers-Interfaces-IMonikerWrapper-Moniker 'MFR.Objects.Interop.Monikers.Wrappers.Interfaces.IMonikerWrapper.Moniker')
- [Resources](#T-MFR-Objects-Interop-Monikers-Wrappers-Interfaces-Properties-Resources 'MFR.Objects.Interop.Monikers.Wrappers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Interop-Monikers-Wrappers-Interfaces-Properties-Resources-Culture 'MFR.Objects.Interop.Monikers.Wrappers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Interop-Monikers-Wrappers-Interfaces-Properties-Resources-ResourceManager 'MFR.Objects.Interop.Monikers.Wrappers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Interop-Monikers-Wrappers-Interfaces-IMonikerWrapper'></a>
## IMonikerWrapper `type`

##### Namespace

MFR.Objects.Interop.Monikers.Wrappers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object wraps
an instance of an object that implements the
[IMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IMoniker 'System.Runtime.InteropServices.ComTypes.IMoniker')
interface.

<a name='P-MFR-Objects-Interop-Monikers-Wrappers-Interfaces-IMonikerWrapper-ComObject'></a>
### ComObject `property`

##### Summary

Gets a reference to an instance of the COM object that corresponds
to the moniker.

<a name='P-MFR-Objects-Interop-Monikers-Wrappers-Interfaces-IMonikerWrapper-DisplayName'></a>
### DisplayName `property`

##### Summary

Gets a string that contains the object's display name.

<a name='P-MFR-Objects-Interop-Monikers-Wrappers-Interfaces-IMonikerWrapper-Moniker'></a>
### Moniker `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IMoniker 'System.Runtime.InteropServices.ComTypes.IMoniker') interface.

<a name='T-MFR-Objects-Interop-Monikers-Wrappers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Interop.Monikers.Wrappers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Interop-Monikers-Wrappers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Interop-Monikers-Wrappers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
