<a name='assembly'></a>
# MFR.Settings.Profiles.Factories

## Contents

- [MakeNewProfile](#T-MFR-Settings-Profiles-Factories-MakeNewProfile 'MFR.Settings.Profiles.Factories.MakeNewProfile')
  - [FromScratch()](#M-MFR-Settings-Profiles-Factories-MakeNewProfile-FromScratch 'MFR.Settings.Profiles.Factories.MakeNewProfile.FromScratch')
  - [HavingName(profile,name)](#M-MFR-Settings-Profiles-Factories-MakeNewProfile-HavingName-MFR-Settings-Profiles-Interfaces-IProfile,System-String- 'MFR.Settings.Profiles.Factories.MakeNewProfile.HavingName(MFR.Settings.Profiles.Interfaces.IProfile,System.String)')
  - [ToProfile(projectFileRenamerConfiguration,name)](#M-MFR-Settings-Profiles-Factories-MakeNewProfile-ToProfile-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-String- 'MFR.Settings.Profiles.Factories.MakeNewProfile.ToProfile(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration,System.String)')
- [Resources](#T-MFR-Settings-Profiles-Factories-Properties-Resources 'MFR.Settings.Profiles.Factories.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Factories-Properties-Resources-Culture 'MFR.Settings.Profiles.Factories.Properties.Resources.Culture')
  - [Error_ValueCannotBeNullOrWhiteSpace](#P-MFR-Settings-Profiles-Factories-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace 'MFR.Settings.Profiles.Factories.Properties.Resources.Error_ValueCannotBeNullOrWhiteSpace')
  - [ResourceManager](#P-MFR-Settings-Profiles-Factories-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Factories-MakeNewProfile'></a>
## MakeNewProfile `type`

##### Namespace

MFR.Settings.Profiles.Factories

##### Summary

Creates new instances of objects that implement the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile') interface, and
returns references to them.

<a name='M-MFR-Settings-Profiles-Factories-MakeNewProfile-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile') interface and
returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile') interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Factories-MakeNewProfile-HavingName-MFR-Settings-Profiles-Interfaces-IProfile,System-String-'></a>
### HavingName(profile,name) `method`

##### Summary

Assigns a name to the `profile` specified.

##### Returns

Reference to an instance of an object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile') interface, or
`null` if an error occurs.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| profile | [MFR.Settings.Profiles.Interfaces.IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile') | (Required.) Reference to an instance of an object that
implements the [IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile')
interface. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new name to be assigned to
the profile. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `profile`, is passed a `null`
value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`name`, is passed a blank or `null` string
for a value. |

##### Remarks

This method will not check whether a profile with the specified name already
exists.



Doing so is the job of the caller.



Along with assigning the specified `profile` a new name, this
method also generates a new GUID to use to identify the profile by.  This is
done because only one profile can be saved having the same name.

<a name='M-MFR-Settings-Profiles-Factories-MakeNewProfile-ToProfile-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration,System-String-'></a>
### ToProfile(projectFileRenamerConfiguration,name) `method`

##### Summary

Extension method that converts the specified `projectFileRenamerConfiguration`
object to a profile object.



The projectFileRenamerConfiguration settings in the source are copied to the new profile, and the
specified `name` is also assigned to the new profile.

##### Returns

Reference to an instance of an object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile') interface, or
`null` if an error occurs.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectFileRenamerConfiguration | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object
that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name to be assigned to the
new profile. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `projectFileRenamerConfiguration`, is passed a
`null` value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`name`, is passed a blank or `null` string
for a value. |

##### Remarks

This method will not check whether a profile with the specified name already
exists.



Doing so is the job of the caller.

<a name='T-MFR-Settings-Profiles-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Factories-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace'></a>
### Error_ValueCannotBeNullOrWhiteSpace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or whitespace..

<a name='P-MFR-Settings-Profiles-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
