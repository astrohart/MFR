<a name='assembly'></a>
# MFR.Profiles

## Contents

- [Profile](#T-MFR-Profiles-Profile 'MFR.Profiles.Profile')
  - [#ctor()](#M-MFR-Profiles-Profile-#ctor 'MFR.Profiles.Profile.#ctor')
  - [#ctor(name)](#M-MFR-Profiles-Profile-#ctor-System-String- 'MFR.Profiles.Profile.#ctor(System.String)')
  - [Name](#P-MFR-Profiles-Profile-Name 'MFR.Profiles.Profile.Name')
  - [ProfileId](#P-MFR-Profiles-Profile-ProfileId 'MFR.Profiles.Profile.ProfileId')
  - [ToString()](#M-MFR-Profiles-Profile-ToString 'MFR.Profiles.Profile.ToString')
- [Resources](#T-MFR-Profiles-Properties-Resources 'MFR.Profiles.Properties.Resources')
  - [Culture](#P-MFR-Profiles-Properties-Resources-Culture 'MFR.Profiles.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Profiles-Properties-Resources-ResourceManager 'MFR.Profiles.Properties.Resources.ResourceManager')

<a name='T-MFR-Profiles-Profile'></a>
## Profile `type`

##### Namespace

MFR.Profiles

##### Summary

A `Profile` is basically a `Configuration`, just with an ID
and a name.

##### Remarks

`Profile` s allow the user to hot-swap settings mid-flight, without
actually leaving the app and coming back in.

<a name='M-MFR-Profiles-Profile-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [Profile](#T-MFR-Profiles-Profile 'MFR.Profiles.Profile')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor overload is here simply to define the behavior of
setting the [Name](#P-MFR-Profiles-Profile-Name 'MFR.Profiles.Profile.Name') property to
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty').

<a name='M-MFR-Profiles-Profile-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Constructs a new instance of [Profile](#T-MFR-Profiles-Profile 'MFR.Profiles.Profile')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of this profile. Cannot be empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `name`, is passed
a blank or `null` string for a value. |

<a name='P-MFR-Profiles-Profile-Name'></a>
### Name `property`

##### Summary

Gets or sets a string value that is the name of this profile.

<a name='P-MFR-Profiles-Profile-ProfileId'></a>
### ProfileId `property`

##### Summary

Gets a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that uniquely identifies
this [Profile](#T-MFR-Profiles-Profile 'MFR.Profiles.Profile').

##### Remarks

This property is automatically initialized with a newly-generated
`GUID` upon construction.

<a name='M-MFR-Profiles-Profile-ToString'></a>
### ToString() `method`

##### Summary

Returns a string that represents the current object.

##### Returns

A string that represents the current object.

##### Parameters

This method has no parameters.

<a name='T-MFR-Profiles-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Profiles.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Profiles-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Profiles-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
