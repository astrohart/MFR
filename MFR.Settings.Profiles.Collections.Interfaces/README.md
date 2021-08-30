<a name='assembly'></a>
# MFR.Settings.Profiles.Collections.Interfaces

## Contents

- [IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
  - [HasProfileNamed(name)](#M-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection-HasProfileNamed-System-String- 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection.HasProfileNamed(System.String)')
- [Resources](#T-MFR-Settings-Profiles-Collections-Interfaces-Properties-Resources 'MFR.Settings.Profiles.Collections.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Collections-Interfaces-Properties-Resources-Culture 'MFR.Settings.Profiles.Collections.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Collections-Interfaces-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Collections.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection'></a>
## IProfileCollection `type`

##### Namespace

MFR.Settings.Profiles.Collections.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a `Profile Collection` object.

##### Remarks

A `Profile Collection` object is what it sounds like -- a container of profiles.

<a name='M-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection-HasProfileNamed-System-String-'></a>
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

<a name='T-MFR-Settings-Profiles-Collections-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Collections.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Collections-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Collections-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
