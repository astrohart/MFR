<a name='assembly'></a>
# MFR.Settings.Configuration.Helpers

## Contents

- [ConfigurationExtensions](#T-MFR-Settings-Configuration-Helpers-ConfigurationExtensions 'MFR.Settings.Configuration.Helpers.ConfigurationExtensions')
  - [AsProfile(config)](#M-MFR-Settings-Configuration-Helpers-ConfigurationExtensions-AsProfile-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Settings.Configuration.Helpers.ConfigurationExtensions.AsProfile(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [GetTextMatchingConfiguration(config)](#M-MFR-Settings-Configuration-Helpers-ConfigurationExtensions-GetTextMatchingConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Settings.Configuration.Helpers.ConfigurationExtensions.GetTextMatchingConfiguration(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [IsTemporaryProfile(config)](#M-MFR-Settings-Configuration-Helpers-ConfigurationExtensions-IsTemporaryProfile-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Settings.Configuration.Helpers.ConfigurationExtensions.IsTemporaryProfile(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [SaveCurrentFindWhatAndHistory(config,comboBox)](#M-MFR-Settings-Configuration-Helpers-ConfigurationExtensions-SaveCurrentFindWhatAndHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox- 'MFR.Settings.Configuration.Helpers.ConfigurationExtensions.SaveCurrentFindWhatAndHistory(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox)')
  - [SaveCurrentReplaceWithAndHistory(config,comboBox)](#M-MFR-Settings-Configuration-Helpers-ConfigurationExtensions-SaveCurrentReplaceWithAndHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox- 'MFR.Settings.Configuration.Helpers.ConfigurationExtensions.SaveCurrentReplaceWithAndHistory(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox)')
  - [SaveCurrentStartingFolderAndHistory(config,comboBox)](#M-MFR-Settings-Configuration-Helpers-ConfigurationExtensions-SaveCurrentStartingFolderAndHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox- 'MFR.Settings.Configuration.Helpers.ConfigurationExtensions.SaveCurrentStartingFolderAndHistory(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig,MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox)')
- [Create](#T-MFR-Settings-Configuration-Helpers-Create 'MFR.Settings.Configuration.Helpers.Create')
  - [BlankConfiguration()](#M-MFR-Settings-Configuration-Helpers-Create-BlankConfiguration 'MFR.Settings.Configuration.Helpers.Create.BlankConfiguration')
- [Resources](#T-MFR-Settings-Configuration-Helpers-Properties-Resources 'MFR.Settings.Configuration.Helpers.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Helpers-Properties-Resources-Culture 'MFR.Settings.Configuration.Helpers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Helpers-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Helpers.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Helpers-ConfigurationExtensions'></a>
## ConfigurationExtensions `type`

##### Namespace

MFR.Settings.Configuration.Helpers

##### Summary

Extension methods for objects implementing the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

<a name='M-MFR-Settings-Configuration-Helpers-ConfigurationExtensions-AsProfile-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### AsProfile(config) `method`

##### Summary

Allows us to work with the specified `config` object
as if it were a Profile.

##### Returns

Reference to an instance of an object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile') interface that
represents the specified `config`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object
that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `config`, is passed a
`null` value. |

<a name='M-MFR-Settings-Configuration-Helpers-ConfigurationExtensions-GetTextMatchingConfiguration-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### GetTextMatchingConfiguration(config) `method`

##### Summary

Gets the [TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration') value
that corresponds to the values set in the config object, a
reference to which is passed by the `config` parameter.

##### Returns

The [TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration') value that
corresponds to the values of the
[IConfigurationMatchCase](#P-MFR-Settings-Configuration-Interfaces-IConfigurationMatchCase 'MFR.Settings.Configuration.Interfaces.IConfigurationMatchCase')
and
[IConfigurationMatchExactWord](#P-MFR-Settings-Configuration-Interfaces-IConfigurationMatchExactWord 'MFR.Settings.Configuration.Interfaces.IConfigurationMatchExactWord')
properties.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | Reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |

<a name='M-MFR-Settings-Configuration-Helpers-ConfigurationExtensions-IsTemporaryProfile-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### IsTemporaryProfile(config) `method`

##### Summary

Determines whether the specified `config` actually
refers to a bona fide `Profile` or whether it was simply transformed into
a temporary `Profile` object (having a name beginning with `tmp`).

##### Returns

`true` if the specified
`config` is merely a temporary `Profile` object;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object
that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |

<a name='M-MFR-Settings-Configuration-Helpers-ConfigurationExtensions-SaveCurrentFindWhatAndHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox-'></a>
### SaveCurrentFindWhatAndHistory(config,comboBox) `method`

##### Summary

Saves the currently-selected Find What text item and the history to
the config.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the [IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface and which
allows access to the config data. |
| comboBox | [MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') | (Required.) Reference to an instance of an object that implements
the [IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox')
interface that is the control displaying the Find What content to the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if either of the required parameters,
`config`
or `comboBox`, are passed a
`null`
value. |

<a name='M-MFR-Settings-Configuration-Helpers-ConfigurationExtensions-SaveCurrentReplaceWithAndHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox-'></a>
### SaveCurrentReplaceWithAndHistory(config,comboBox) `method`

##### Summary

Saves the currently-selected Replace With text item and the history
to the config.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the [IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface and which
allows access to the config data. |
| comboBox | [MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') | (Required.) Reference to an instance of an object that implements
the [IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox')
interface that is the control displaying the Replace With content to the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if either of the required parameters,
`config`
or `comboBox`, are passed a
`null`
value. |

<a name='M-MFR-Settings-Configuration-Helpers-ConfigurationExtensions-SaveCurrentStartingFolderAndHistory-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig,MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox-'></a>
### SaveCurrentStartingFolderAndHistory(config,comboBox) `method`

##### Summary

Saves the currently-selected Starting Folder text item and the
history to the config.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the [IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface and which
allows access to the config data. |
| comboBox | [MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') | (Required.) Reference to an instance of an object that implements
the [IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox')
interface that is the control displaying the Starting Folder
content to the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if either of the required parameters,
`config`
or `comboBox`, are passed a
`null`
value. |

<a name='T-MFR-Settings-Configuration-Helpers-Create'></a>
## Create `type`

##### Namespace

MFR.Settings.Configuration.Helpers

##### Summary

Exposes static methods to create instances of objects and data.

<a name='M-MFR-Settings-Configuration-Helpers-Create-BlankConfiguration'></a>
### BlankConfiguration() `method`

##### Summary

Creates an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface and initializes it with the default invokable operations.

##### Returns

Reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface that is initialized with the default invokable operations.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Helpers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Helpers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Helpers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Helpers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
