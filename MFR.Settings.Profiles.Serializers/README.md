<a name='assembly'></a>
# MFR.Profiles.Serializers

## Contents

- [ProfileListSerializer](#T-MFR-Profiles-Serializers-ProfileListSerializer 'MFR.Profiles.Serializers.ProfileListSerializer')
  - [Load(pathname)](#M-MFR-Profiles-Serializers-ProfileListSerializer-Load-System-String- 'MFR.Profiles.Serializers.ProfileListSerializer.Load(System.String)')
  - [Save(pathname,profileList)](#M-MFR-Profiles-Serializers-ProfileListSerializer-Save-System-String,MFR-Profiles-Collections-Interfaces-IProfileCollection- 'MFR.Profiles.Serializers.ProfileListSerializer.Save(System.String,MFR.Profiles.Collections.Interfaces.IProfileCollection)')
- [Resources](#T-MFR-Profiles-Serializers-Properties-Resources 'MFR.Profiles.Serializers.Properties.Resources')
  - [Culture](#P-MFR-Profiles-Serializers-Properties-Resources-Culture 'MFR.Profiles.Serializers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Profiles-Serializers-Properties-Resources-ResourceManager 'MFR.Profiles.Serializers.Properties.Resources.ResourceManager')

<a name='T-MFR-Profiles-Serializers-ProfileListSerializer'></a>
## ProfileListSerializer `type`

##### Namespace

MFR.Profiles.Serializers

##### Summary

Loads and stores profile list information to/from a file.

##### Remarks

The profile information is used in code via the [IProfileCollection](#T-MFR-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Profiles.Collections.Interfaces.IProfileCollection') interface.

<a name='M-MFR-Profiles-Serializers-ProfileListSerializer-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads data about the list of profiles from the file with the path specified by the `pathname` parameter.

##### Returns

Reference to an instance of an object that implements the [IProfileCollection](#T-MFR-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Profiles.Collections.Interfaces.IProfileCollection') interface.



The object instance referenced contains access to the set of profiles listed in the file.



The `null` reference is returned in the event a problem occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of a JSON-formatted data file on the disk that contains the profile-list data. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `pathname`, is
passed a blank or `null` string for a value. |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the file, the path to which is specified by the
`pathname`
parameter, cannot be located on the disk. |

<a name='M-MFR-Profiles-Serializers-ProfileListSerializer-Save-System-String,MFR-Profiles-Collections-Interfaces-IProfileCollection-'></a>
### Save(pathname,profileList) `method`

##### Summary

Saves profile-list data to a file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname of the file that the data
    is to be saved to. |
| profileList | [MFR.Profiles.Collections.Interfaces.IProfileCollection](#T-MFR-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Profiles.Collections.Interfaces.IProfileCollection') | (Required.) Reference to an instance of an object that implements
    the
    [IProfileCollection](#T-MFR-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Profiles.Collections.Interfaces.IProfileCollection')
    interface, containing the data to be written to the disk. |

<a name='T-MFR-Profiles-Serializers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Profiles.Serializers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Profiles-Serializers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Profiles-Serializers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
