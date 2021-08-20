<a name='assembly'></a>
# MFR.Profiles.Collections

## Contents

- [ProfileCollection](#T-MFR-Profiles-Collections-ProfileCollection 'MFR.Profiles.Collections.ProfileCollection')
  - [ActiveProfile](#P-MFR-Profiles-Collections-ProfileCollection-ActiveProfile 'MFR.Profiles.Collections.ProfileCollection.ActiveProfile')
  - [HasProfileNamed(name)](#M-MFR-Profiles-Collections-ProfileCollection-HasProfileNamed-System-String- 'MFR.Profiles.Collections.ProfileCollection.HasProfileNamed(System.String)')
- [Resources](#T-MFR-Profiles-Collections-Properties-Resources 'MFR.Profiles.Collections.Properties.Resources')
  - [Culture](#P-MFR-Profiles-Collections-Properties-Resources-Culture 'MFR.Profiles.Collections.Properties.Resources.Culture')
  - [Error_ValueCannotBeNullOrWhiteSpace](#P-MFR-Profiles-Collections-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace 'MFR.Profiles.Collections.Properties.Resources.Error_ValueCannotBeNullOrWhiteSpace')
  - [ResourceManager](#P-MFR-Profiles-Collections-Properties-Resources-ResourceManager 'MFR.Profiles.Collections.Properties.Resources.ResourceManager')

<a name='T-MFR-Profiles-Collections-ProfileCollection'></a>
## ProfileCollection `type`

##### Namespace

MFR.Profiles.Collections

##### Summary

Implements the methods and properties of a `Profile Collection`
    object.

##### Remarks

A `Profile Collection` object is just that -- a container for
    `Profile` s.

<a name='P-MFR-Profiles-Collections-ProfileCollection-ActiveProfile'></a>
### ActiveProfile `property`

##### Summary

A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that delineates which profile is
    currently "active" i.e., is in use.

<a name='M-MFR-Profiles-Collections-ProfileCollection-HasProfileNamed-System-String-'></a>
### HasProfileNamed(name) `method`

##### Summary

Determines whether the profile collection already has a profile with the
    name provided.



There can only be one profile with a given name, case-insensitive.

##### Returns

`true` if a profile having the given name is found;
    `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Name of the profile to be searched for. |

<a name='T-MFR-Profiles-Collections-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Profiles.Collections.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Profiles-Collections-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Profiles-Collections-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace'></a>
### Error_ValueCannotBeNullOrWhiteSpace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or whitespace..

<a name='P-MFR-Profiles-Collections-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
