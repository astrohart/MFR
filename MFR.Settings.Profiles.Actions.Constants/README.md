<a name='assembly'></a>
# MFR.Settings.Profiles.Actions.Constants

## Contents

- [ProfileCollectionAction](#T-MFR-Settings-Profiles-Actions-Constants-ProfileCollectionAction 'MFR.Settings.Profiles.Actions.Constants.ProfileCollectionAction')
  - [#ctor(messageId)](#M-MFR-Settings-Profiles-Actions-Constants-ProfileCollectionAction-#ctor-System-Guid- 'MFR.Settings.Profiles.Actions.Constants.ProfileCollectionAction.#ctor(System.Guid)')
  - [CreateNewNamedProfile](#F-MFR-Settings-Profiles-Actions-Constants-ProfileCollectionAction-CreateNewNamedProfile 'MFR.Settings.Profiles.Actions.Constants.ProfileCollectionAction.CreateNewNamedProfile')
  - [LoadProfileCollectionFromFile](#F-MFR-Settings-Profiles-Actions-Constants-ProfileCollectionAction-LoadProfileCollectionFromFile 'MFR.Settings.Profiles.Actions.Constants.ProfileCollectionAction.LoadProfileCollectionFromFile')
  - [LoadStringFromRegistry](#F-MFR-Settings-Profiles-Actions-Constants-ProfileCollectionAction-LoadStringFromRegistry 'MFR.Settings.Profiles.Actions.Constants.ProfileCollectionAction.LoadStringFromRegistry')
- [Resources](#T-MFR-Settings-Profiles-Actions-Constants-Properties-Resources 'MFR.Settings.Profiles.Actions.Constants.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Actions-Constants-Properties-Resources-Culture 'MFR.Settings.Profiles.Actions.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Actions-Constants-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Actions.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Actions-Constants-ProfileCollectionAction'></a>
## ProfileCollectionAction `type`

##### Namespace

MFR.Settings.Profiles.Actions.Constants

##### Summary

Available actions for use when working with configuration.

<a name='M-MFR-Settings-Profiles-Actions-Constants-ProfileCollectionAction-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[ProfileCollectionAction](#T-MFR-Settings-Profiles-Actions-Constants-ProfileCollectionAction 'MFR.Settings.Profiles.Actions.Constants.ProfileCollectionAction')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-Settings-Profiles-Actions-Constants-ProfileCollectionAction-CreateNewNamedProfile'></a>
### CreateNewNamedProfile `constants`

##### Summary

Creates a new, named profile that can be added to the list.

<a name='F-MFR-Settings-Profiles-Actions-Constants-ProfileCollectionAction-LoadProfileCollectionFromFile'></a>
### LoadProfileCollectionFromFile `constants`

##### Summary

Loads the configuration from a file.

<a name='F-MFR-Settings-Profiles-Actions-Constants-ProfileCollectionAction-LoadStringFromRegistry'></a>
### LoadStringFromRegistry `constants`

##### Summary

Loads a string value from the system Registry.

<a name='T-MFR-Settings-Profiles-Actions-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Actions.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Actions-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Actions-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
