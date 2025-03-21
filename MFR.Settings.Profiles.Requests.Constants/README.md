<a name='assembly'></a>
# MFR.Settings.Profiles.Requests.Constants

## Contents

- [ProfileCollectionRequestType](#T-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequestType 'MFR.Settings.Profiles.Requests.Constants.ProfileCollectionRequestType')
  - [#ctor(messageId)](#M-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequestType-#ctor-System-Guid- 'MFR.Settings.Profiles.Requests.Constants.ProfileCollectionRequestType.#ctor(System.Guid)')
  - [#ctor(description,messageId)](#M-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequestType-#ctor-System-Guid,System-String- 'MFR.Settings.Profiles.Requests.Constants.ProfileCollectionRequestType.#ctor(System.Guid,System.String)')
  - [CreateNewBlankProfile](#F-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequestType-CreateNewBlankProfile 'MFR.Settings.Profiles.Requests.Constants.ProfileCollectionRequestType.CreateNewBlankProfile')
  - [Unknown](#F-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequestType-Unknown 'MFR.Settings.Profiles.Requests.Constants.ProfileCollectionRequestType.Unknown')
- [Resources](#T-MFR-Settings-Profiles-Requests-Constants-Properties-Resources 'MFR.Settings.Profiles.Requests.Constants.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Requests-Constants-Properties-Resources-Culture 'MFR.Settings.Profiles.Requests.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Requests-Constants-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Requests.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequestType'></a>
## ProfileCollectionRequestType `type`

##### Namespace

MFR.Settings.Profiles.Requests.Constants

##### Summary

Available requests for use when working with `Profile` objects.

<a name='M-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequestType-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[ProfileCollectionRequestType](#T-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequestType 'MFR.Settings.Profiles.Requests.Constants.ProfileCollectionRequestType')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='M-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequestType-#ctor-System-Guid,System-String-'></a>
### #ctor(description,messageId) `constructor`

##### Summary

Constructs a new instance of
[ProfileCollectionRequestType](#T-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequestType 'MFR.Settings.Profiles.Requests.Constants.ProfileCollectionRequestType')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a user-friendly
descriptive name for this message type. |
| messageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequestType-CreateNewBlankProfile'></a>
### CreateNewBlankProfile `constants`

##### Summary

Creates a new (blank) profile.

<a name='F-MFR-Settings-Profiles-Requests-Constants-ProfileCollectionRequestType-Unknown'></a>
### Unknown `constants`

##### Summary

Generic, unknown message.

<a name='T-MFR-Settings-Profiles-Requests-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Requests.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Requests-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Requests-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
