<a name='assembly'></a>
# MFR.Settings.Profiles.Commands.Constants

## Contents

- [ProfileCollectionCommandType](#T-MFR-Settings-Profiles-Commands-Constants-ProfileCollectionCommandType 'MFR.Settings.Profiles.Commands.Constants.ProfileCollectionCommandType')
  - [#ctor(messageId)](#M-MFR-Settings-Profiles-Commands-Constants-ProfileCollectionCommandType-#ctor-System-Guid- 'MFR.Settings.Profiles.Commands.Constants.ProfileCollectionCommandType.#ctor(System.Guid)')
  - [#ctor(description,messageId)](#M-MFR-Settings-Profiles-Commands-Constants-ProfileCollectionCommandType-#ctor-System-Guid,System-String- 'MFR.Settings.Profiles.Commands.Constants.ProfileCollectionCommandType.#ctor(System.Guid,System.String)')
  - [SaveProfileCollectionPathToRegistry](#F-MFR-Settings-Profiles-Commands-Constants-ProfileCollectionCommandType-SaveProfileCollectionPathToRegistry 'MFR.Settings.Profiles.Commands.Constants.ProfileCollectionCommandType.SaveProfileCollectionPathToRegistry')
  - [SaveProfileCollectionToFile](#F-MFR-Settings-Profiles-Commands-Constants-ProfileCollectionCommandType-SaveProfileCollectionToFile 'MFR.Settings.Profiles.Commands.Constants.ProfileCollectionCommandType.SaveProfileCollectionToFile')
  - [Unknown](#F-MFR-Settings-Profiles-Commands-Constants-ProfileCollectionCommandType-Unknown 'MFR.Settings.Profiles.Commands.Constants.ProfileCollectionCommandType.Unknown')
- [Resources](#T-MFR-Settings-Profiles-Commands-Constants-Properties-Resources 'MFR.Settings.Profiles.Commands.Constants.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Commands-Constants-Properties-Resources-Culture 'MFR.Settings.Profiles.Commands.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Commands-Constants-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Commands.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Commands-Constants-ProfileCollectionCommandType'></a>
## ProfileCollectionCommandType `type`

##### Namespace

MFR.Settings.Profiles.Commands.Constants

##### Summary

Available commands for use when working with profile list.

<a name='M-MFR-Settings-Profiles-Commands-Constants-ProfileCollectionCommandType-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[ProfileCollectionCommandType](#T-MFR-Settings-Profiles-Commands-Constants-ProfileCollectionCommandType 'MFR.Settings.Profiles.Commands.Constants.ProfileCollectionCommandType')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='M-MFR-Settings-Profiles-Commands-Constants-ProfileCollectionCommandType-#ctor-System-Guid,System-String-'></a>
### #ctor(description,messageId) `constructor`

##### Summary

Constructs a new instance of
[ProfileCollectionCommandType](#T-MFR-Settings-Profiles-Commands-Constants-ProfileCollectionCommandType 'MFR.Settings.Profiles.Commands.Constants.ProfileCollectionCommandType')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a user-friendly
descriptive name for this message type. |
| messageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-Settings-Profiles-Commands-Constants-ProfileCollectionCommandType-SaveProfileCollectionPathToRegistry'></a>
### SaveProfileCollectionPathToRegistry `constants`

##### Summary

Saves a string value to the system Registry.

<a name='F-MFR-Settings-Profiles-Commands-Constants-ProfileCollectionCommandType-SaveProfileCollectionToFile'></a>
### SaveProfileCollectionToFile `constants`

##### Summary

Saves the profile list to a file.

<a name='F-MFR-Settings-Profiles-Commands-Constants-ProfileCollectionCommandType-Unknown'></a>
### Unknown `constants`

##### Summary

Generic, unknown message.

<a name='T-MFR-Settings-Profiles-Commands-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Commands.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Commands-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Commands-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
