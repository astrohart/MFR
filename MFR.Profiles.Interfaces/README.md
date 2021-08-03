<a name='assembly'></a>
# MFR.Profiles.Interfaces

## Contents

- [IProfile](#T-MFR-Profiles-Interfaces-IProfile 'MFR.Profiles.Interfaces.IProfile')
  - [Name](#P-MFR-Profiles-Interfaces-IProfile-Name 'MFR.Profiles.Interfaces.IProfile.Name')
  - [ProfileId](#P-MFR-Profiles-Interfaces-IProfile-ProfileId 'MFR.Profiles.Interfaces.IProfile.ProfileId')
- [Resources](#T-MFR-Profiles-Interfaces-Properties-Resources 'MFR.Profiles.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Profiles-Interfaces-Properties-Resources-Culture 'MFR.Profiles.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Profiles-Interfaces-Properties-Resources-ResourceManager 'MFR.Profiles.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Profiles-Interfaces-IProfile'></a>
## IProfile `type`

##### Namespace

MFR.Profiles.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a `Profile` object.

##### Remarks

`Profile` objects are basically hot-swappable variations on the
`Configuration` object.



Whereas `Configuration` objects have to be loaded from/saved to a
persistent store, such as a database or a file, `Profile` s have
this capability as well, but are also named with unique identifiers --
meaning we can allow the user to create profiles so they can hot-swap
the settings, say, for one solution versus another.

<a name='P-MFR-Profiles-Interfaces-IProfile-Name'></a>
### Name `property`

##### Summary

Gets or sets a string value that is the name of this profile.

<a name='P-MFR-Profiles-Interfaces-IProfile-ProfileId'></a>
### ProfileId `property`

##### Summary

Gets a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that uniquely identifies
this [Profile](#T-MFR-Profiles-Profile 'MFR.Profiles.Profile').

##### Remarks

This property is automatically initialized with a newly-generated
`GUID` upon construction.

<a name='T-MFR-Profiles-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Profiles.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Profiles-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Profiles-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
