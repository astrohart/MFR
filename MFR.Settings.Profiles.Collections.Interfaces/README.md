<a name='assembly'></a>
# MFR.Settings.Profiles.Collections.Interfaces

## Contents

- [IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
  - [Item](#P-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection-Item-System-Int32- 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection.Item(System.Int32)')
  - [HasProfileNamed(name)](#M-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection-HasProfileNamed-System-String- 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection.HasProfileNamed(System.String)')
  - [RemoveAll(predicate)](#M-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection-RemoveAll-System-Predicate{MFR-Settings-Profiles-Interfaces-IProfile}- 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection.RemoveAll(System.Predicate{MFR.Settings.Profiles.Interfaces.IProfile})')
- [Resources](#T-MFR-Settings-Profiles-Collections-Interfaces-Properties-Resources 'MFR.Settings.Profiles.Collections.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Collections-Interfaces-Properties-Resources-Culture 'MFR.Settings.Profiles.Collections.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Collections-Interfaces-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Collections.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection'></a>
## IProfileCollection `type`

##### Namespace

MFR.Settings.Profiles.Collections.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a
`Profile Collection` object.

##### Remarks

A `Profile Collection` object is what it sounds like -- a
container of profiles.

<a name='P-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection-Item-System-Int32-'></a>
### Item `property`

##### Summary

Gets the object implementing the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile') interface at the
position `i` in the collection.

##### Returns

Reference to an instance of an object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile') interface that
exists at the specified index.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| i | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Integer, that is zero or greater, referring to the
index of the desired element. |

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

<a name='M-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection-RemoveAll-System-Predicate{MFR-Settings-Profiles-Interfaces-IProfile}-'></a>
### RemoveAll(predicate) `method`

##### Summary

Removes all of those elements from the collection that satisfy the specified
`predicate`.

##### Returns

`true` if the element(s) matching the specified
`predicate` were removed successfully, or if the collection
is empty; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| predicate | [System.Predicate{MFR.Settings.Profiles.Interfaces.IProfile}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{MFR.Settings.Profiles.Interfaces.IProfile}') | (Required.) A predicate that returns
`true` if a specific item is to be removed from the
collection. |

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
