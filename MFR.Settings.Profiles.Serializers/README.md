<a name='assembly'></a>
# MFR.Settings.Profiles.Serializers

## Contents

- [ProfileCollectionSerializer](#T-MFR-Settings-Profiles-Serializers-ProfileCollectionSerializer 'MFR.Settings.Profiles.Serializers.ProfileCollectionSerializer')
  - [Load(pathname)](#M-MFR-Settings-Profiles-Serializers-ProfileCollectionSerializer-Load-System-String- 'MFR.Settings.Profiles.Serializers.ProfileCollectionSerializer.Load(System.String)')
  - [Save(pathname,profileList)](#M-MFR-Settings-Profiles-Serializers-ProfileCollectionSerializer-Save-System-String,MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection- 'MFR.Settings.Profiles.Serializers.ProfileCollectionSerializer.Save(System.String,MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection)')
- [Resources](#T-MFR-Settings-Profiles-Serializers-Properties-Resources 'MFR.Settings.Profiles.Serializers.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Serializers-Properties-Resources-Culture 'MFR.Settings.Profiles.Serializers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Serializers-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Serializers.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Serializers-ProfileCollectionSerializer'></a>
## ProfileCollectionSerializer `type`

##### Namespace

MFR.Settings.Profiles.Serializers

##### Summary

Loads and stores profile list information to/from a file.

##### Remarks

The profile information is used in code via the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface.

<a name='M-MFR-Settings-Profiles-Serializers-ProfileCollectionSerializer-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads data about the list of profiles from the file with the path specified by
the `pathname` parameter.

##### Returns

Reference to an instance of an object that implements the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface.



The object instance referenced contains access to the set of profiles listed in
the file.



The `null` reference is returned in the event a problem
occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of a JSON-formatted
data file on the file system that contains the profile-list data. |

##### Remarks

If the `pathname` parameter is not passed the fully-qualified
pathname of a file that exists on the file system, or if an error occurs during the
execution of the `Load` operation, then the empty collection is returned.

<a name='M-MFR-Settings-Profiles-Serializers-ProfileCollectionSerializer-Save-System-String,MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection-'></a>
### Save(pathname,profileList) `method`

##### Summary

Saves profile-list data to a file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname of the file that the data
is to be saved to. |
| profileList | [MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection') | (Required.) Reference to an instance of an object that implements
the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface, containing the data to be written to the file system. |

<a name='T-MFR-Settings-Profiles-Serializers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Serializers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Serializers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Serializers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
