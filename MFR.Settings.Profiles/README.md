<a name='assembly'></a>
# MFR.Settings.Profiles

## Contents

- [Profile](#T-MFR-Settings-Profiles-Profile 'MFR.Settings.Profiles.Profile')
  - [#ctor()](#M-MFR-Settings-Profiles-Profile-#ctor 'MFR.Settings.Profiles.Profile.#ctor')
  - [#ctor(name)](#M-MFR-Settings-Profiles-Profile-#ctor-System-String- 'MFR.Settings.Profiles.Profile.#ctor(System.String)')
  - [#ctor(source,name)](#M-MFR-Settings-Profiles-Profile-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-String- 'MFR.Settings.Profiles.Profile.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.String)')
  - [Name](#P-MFR-Settings-Profiles-Profile-Name 'MFR.Settings.Profiles.Profile.Name')
  - [ProfileId](#P-MFR-Settings-Profiles-Profile-ProfileId 'MFR.Settings.Profiles.Profile.ProfileId')
  - [ToString()](#M-MFR-Settings-Profiles-Profile-ToString 'MFR.Settings.Profiles.Profile.ToString')
- [Resources](#T-MFR-Settings-Profiles-Properties-Resources 'MFR.Settings.Profiles.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Properties-Resources-Culture 'MFR.Settings.Profiles.Properties.Resources.Culture')
  - [Error_ValueCannotBeBlankOrNull](#P-MFR-Settings-Profiles-Properties-Resources-Error_ValueCannotBeBlankOrNull 'MFR.Settings.Profiles.Properties.Resources.Error_ValueCannotBeBlankOrNull')
  - [ResourceManager](#P-MFR-Settings-Profiles-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Profile'></a>
## Profile `type`

##### Namespace

MFR.Settings.Profiles

##### Summary

A `Profile` is basically a `ProjectFileRenamerConfiguration`, just with an ID
and a name.

##### Remarks

`Profile` s allow the user to hot-swap settings mid-flight, without
actually leaving the app and coming back in.

<a name='M-MFR-Settings-Profiles-Profile-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [Profile](#T-MFR-Settings-Profiles-Profile 'MFR.Settings.Profiles.Profile')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor overload is here simply to define the behavior of
setting the [Name](#P-MFR-Settings-Profiles-Profile-Name 'MFR.Settings.Profiles.Profile.Name') property to
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty').

<a name='M-MFR-Settings-Profiles-Profile-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Constructs a new instance of [Profile](#T-MFR-Settings-Profiles-Profile 'MFR.Settings.Profiles.Profile')
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

<a name='M-MFR-Settings-Profiles-Profile-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-String-'></a>
### #ctor(source,name) `constructor`

##### Summary

Constructs a new instance of [Profile](#T-MFR-Settings-Profiles-Profile 'MFR.Settings.Profiles.Profile') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') interface
that contains configuration settings to copy into this object. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the descriptive name that the user wants to use
for this profile. |

<a name='P-MFR-Settings-Profiles-Profile-Name'></a>
### Name `property`

##### Summary

Gets or sets a string value that is the name of this profile.

<a name='P-MFR-Settings-Profiles-Profile-ProfileId'></a>
### ProfileId `property`

##### Summary

Gets or sets a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that uniquely identifies
this [Profile](#T-MFR-Settings-Profiles-Profile 'MFR.Settings.Profiles.Profile').

##### Remarks

This property is automatically initialized with a newly-generated
`GUID` upon construction.

<a name='M-MFR-Settings-Profiles-Profile-ToString'></a>
### ToString() `method`

##### Summary

Returns a string that represents the current object.

##### Returns

A string that represents the current object.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Profiles-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Properties-Resources-Error_ValueCannotBeBlankOrNull'></a>
### Error_ValueCannotBeBlankOrNull `property`

##### Summary

Looks up a localized string similar to Value cannot be blank or null..

<a name='P-MFR-Settings-Profiles-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
