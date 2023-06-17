<a name='assembly'></a>
# MFR.Settings.Profiles.Collections.Factories

## Contents

- [GetEmptyProfileCollection](#T-MFR-Settings-Profiles-Collections-Factories-GetEmptyProfileCollection 'MFR.Settings.Profiles.Collections.Factories.GetEmptyProfileCollection')
  - [SoleInstance()](#M-MFR-Settings-Profiles-Collections-Factories-GetEmptyProfileCollection-SoleInstance 'MFR.Settings.Profiles.Collections.Factories.GetEmptyProfileCollection.SoleInstance')
- [MakeNewProfileCollection](#T-MFR-Settings-Profiles-Collections-Factories-MakeNewProfileCollection 'MFR.Settings.Profiles.Collections.Factories.MakeNewProfileCollection')
  - [FromScratch()](#M-MFR-Settings-Profiles-Collections-Factories-MakeNewProfileCollection-FromScratch 'MFR.Settings.Profiles.Collections.Factories.MakeNewProfileCollection.FromScratch')
- [Resources](#T-MFR-Settings-Profiles-Collections-Factories-Properties-Resources 'MFR.Settings.Profiles.Collections.Factories.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Collections-Factories-Properties-Resources-Culture 'MFR.Settings.Profiles.Collections.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Collections-Factories-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Collections.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Collections-Factories-GetEmptyProfileCollection'></a>
## GetEmptyProfileCollection `type`

##### Namespace

MFR.Settings.Profiles.Collections.Factories

##### Summary

Gets access to the empty `ProfileCollection`.

<a name='M-MFR-Settings-Profiles-Collections-Factories-GetEmptyProfileCollection-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Gets a reference to an instance of an object that implements the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface that represents the empty collection.

##### Returns

Reference to an instance of an object that implements the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface that represents the empty collection.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Profiles-Collections-Factories-MakeNewProfileCollection'></a>
## MakeNewProfileCollection `type`

##### Namespace

MFR.Settings.Profiles.Collections.Factories

##### Summary

Creates new instances of objects that implement the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface, and returns references to them.

<a name='M-MFR-Settings-Profiles-Collections-Factories-MakeNewProfileCollection-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Profiles-Collections-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Collections.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Collections-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Collections-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
