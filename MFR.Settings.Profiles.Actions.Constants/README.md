<a name='assembly'></a>
# MFR.Profiles.Actions.Constants

## Contents

- [ProfileListAction](#T-MFR-Profiles-Actions-Constants-ProfileListAction 'MFR.Profiles.Actions.Constants.ProfileListAction')
  - [#ctor(messageId)](#M-MFR-Profiles-Actions-Constants-ProfileListAction-#ctor-System-Guid- 'MFR.Profiles.Actions.Constants.ProfileListAction.#ctor(System.Guid)')
  - [LoadProfileListFromFile](#F-MFR-Profiles-Actions-Constants-ProfileListAction-LoadProfileListFromFile 'MFR.Profiles.Actions.Constants.ProfileListAction.LoadProfileListFromFile')
  - [LoadStringFromRegistry](#F-MFR-Profiles-Actions-Constants-ProfileListAction-LoadStringFromRegistry 'MFR.Profiles.Actions.Constants.ProfileListAction.LoadStringFromRegistry')
- [Resources](#T-MFR-Profiles-Actions-Constants-Properties-Resources 'MFR.Profiles.Actions.Constants.Properties.Resources')
  - [Culture](#P-MFR-Profiles-Actions-Constants-Properties-Resources-Culture 'MFR.Profiles.Actions.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Profiles-Actions-Constants-Properties-Resources-ResourceManager 'MFR.Profiles.Actions.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Profiles-Actions-Constants-ProfileListAction'></a>
## ProfileListAction `type`

##### Namespace

MFR.Profiles.Actions.Constants

##### Summary

Available actions for use when working with configuration.

<a name='M-MFR-Profiles-Actions-Constants-ProfileListAction-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[ProfileListAction](#T-MFR-Profiles-Actions-Constants-ProfileListAction 'MFR.Profiles.Actions.Constants.ProfileListAction')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-Profiles-Actions-Constants-ProfileListAction-LoadProfileListFromFile'></a>
### LoadProfileListFromFile `constants`

##### Summary

Loads the configuration from a file.

<a name='F-MFR-Profiles-Actions-Constants-ProfileListAction-LoadStringFromRegistry'></a>
### LoadStringFromRegistry `constants`

##### Summary

Loads a string value from the system Registry.

<a name='T-MFR-Profiles-Actions-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Profiles.Actions.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Profiles-Actions-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Profiles-Actions-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
