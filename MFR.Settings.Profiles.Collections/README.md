<a name='assembly'></a>
# MFR.Settings.Profiles.Collections

## Contents

- [ProfileCollection](#T-MFR-Settings-Profiles-Collections-ProfileCollection 'MFR.Settings.Profiles.Collections.ProfileCollection')
  - [#ctor()](#M-MFR-Settings-Profiles-Collections-ProfileCollection-#ctor 'MFR.Settings.Profiles.Collections.ProfileCollection.#ctor')
  - [#ctor()](#M-MFR-Settings-Profiles-Collections-ProfileCollection-#ctor-System-Collections-Generic-IEnumerable{MFR-Settings-Profiles-Interfaces-IProfile}- 'MFR.Settings.Profiles.Collections.ProfileCollection.#ctor(System.Collections.Generic.IEnumerable{MFR.Settings.Profiles.Interfaces.IProfile})')
  - [ActiveProfile](#P-MFR-Settings-Profiles-Collections-ProfileCollection-ActiveProfile 'MFR.Settings.Profiles.Collections.ProfileCollection.ActiveProfile')
  - [Empty](#P-MFR-Settings-Profiles-Collections-ProfileCollection-Empty 'MFR.Settings.Profiles.Collections.ProfileCollection.Empty')
  - [HasProfileNamed(name)](#M-MFR-Settings-Profiles-Collections-ProfileCollection-HasProfileNamed-System-String- 'MFR.Settings.Profiles.Collections.ProfileCollection.HasProfileNamed(System.String)')
  - [RemoveAll(predicate)](#M-MFR-Settings-Profiles-Collections-ProfileCollection-RemoveAll-System-Predicate{MFR-Settings-Profiles-Interfaces-IProfile}- 'MFR.Settings.Profiles.Collections.ProfileCollection.RemoveAll(System.Predicate{MFR.Settings.Profiles.Interfaces.IProfile})')
- [Resources](#T-MFR-Settings-Profiles-Collections-Properties-Resources 'MFR.Settings.Profiles.Collections.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Collections-Properties-Resources-Culture 'MFR.Settings.Profiles.Collections.Properties.Resources.Culture')
  - [Error_ValueCannotBeNullOrWhiteSpace](#P-MFR-Settings-Profiles-Collections-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace 'MFR.Settings.Profiles.Collections.Properties.Resources.Error_ValueCannotBeNullOrWhiteSpace')
  - [ResourceManager](#P-MFR-Settings-Profiles-Collections-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Collections.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Collections-ProfileCollection'></a>
## ProfileCollection `type`

##### Namespace

MFR.Settings.Profiles.Collections

##### Summary

Implements the methods and properties of a `Profile Collection`
object.

##### Remarks

A `Profile Collection` object is just that -- a container for
`Profile` s.

<a name='M-MFR-Settings-Profiles-Collections-ProfileCollection-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ProfileCollection](#T-MFR-Settings-Profiles-Collections-ProfileCollection 'MFR.Settings.Profiles.Collections.ProfileCollection') and
returns a reference to it.

##### Parameters

This constructor has no parameters.

##### Remarks

The object instance reference returned by this constructor represents the empty
collection.

<a name='M-MFR-Settings-Profiles-Collections-ProfileCollection-#ctor-System-Collections-Generic-IEnumerable{MFR-Settings-Profiles-Interfaces-IProfile}-'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ProfileCollection](#T-MFR-Settings-Profiles-Collections-ProfileCollection 'MFR.Settings.Profiles.Collections.ProfileCollection') and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Profiles-Collections-ProfileCollection-ActiveProfile'></a>
### ActiveProfile `property`

##### Summary

A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that delineates which profile is
currently "active" i.e., is in use.

<a name='P-MFR-Settings-Profiles-Collections-ProfileCollection-Empty'></a>
### Empty `property`

##### Summary

Represents the empty `ProfileCollection`.

<a name='M-MFR-Settings-Profiles-Collections-ProfileCollection-HasProfileNamed-System-String-'></a>
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

<a name='M-MFR-Settings-Profiles-Collections-ProfileCollection-RemoveAll-System-Predicate{MFR-Settings-Profiles-Interfaces-IProfile}-'></a>
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

<a name='T-MFR-Settings-Profiles-Collections-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Collections.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Collections-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Collections-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace'></a>
### Error_ValueCannotBeNullOrWhiteSpace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or whitespace..

<a name='P-MFR-Settings-Profiles-Collections-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
