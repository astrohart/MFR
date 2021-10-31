<a name='assembly'></a>
# MFR.Configuration.Helpers

## Contents

- [ConfigurationExtensions](#T-MFR-Objects-Configuration-Helpers-ConfigurationExtensions 'MFR.Configuration.Helpers.ConfigurationExtensions')
  - [GetTextMatchingConfiguration(config)](#M-MFR-Objects-Configuration-Helpers-ConfigurationExtensions-GetTextMatchingConfiguration-MFR-Objects-Configuration-Interfaces-IConfiguration- 'MFR.Configuration.Helpers.ConfigurationExtensions.GetTextMatchingConfiguration(MFR.Configuration.Interfaces.IConfiguration)')
  - [SaveCurrentFindWhatAndHistory(config,comboBox)](#M-MFR-Objects-Configuration-Helpers-ConfigurationExtensions-SaveCurrentFindWhatAndHistory-MFR-Objects-Configuration-Interfaces-IConfiguration,MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox- 'MFR.Configuration.Helpers.ConfigurationExtensions.SaveCurrentFindWhatAndHistory(MFR.Configuration.Interfaces.IConfiguration,MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox)')
  - [SaveCurrentReplaceWithAndHistory(config,comboBox)](#M-MFR-Objects-Configuration-Helpers-ConfigurationExtensions-SaveCurrentReplaceWithAndHistory-MFR-Objects-Configuration-Interfaces-IConfiguration,MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox- 'MFR.Configuration.Helpers.ConfigurationExtensions.SaveCurrentReplaceWithAndHistory(MFR.Configuration.Interfaces.IConfiguration,MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox)')
  - [SaveCurrentStartingFolderAndHistory(config,comboBox)](#M-MFR-Objects-Configuration-Helpers-ConfigurationExtensions-SaveCurrentStartingFolderAndHistory-MFR-Objects-Configuration-Interfaces-IConfiguration,MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox- 'MFR.Configuration.Helpers.ConfigurationExtensions.SaveCurrentStartingFolderAndHistory(MFR.Configuration.Interfaces.IConfiguration,MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox)')
- [Resources](#T-MFR-Objects-Configuration-Helpers-Properties-Resources 'MFR.Configuration.Helpers.Properties.Resources')
  - [Culture](#P-MFR-Objects-Configuration-Helpers-Properties-Resources-Culture 'MFR.Configuration.Helpers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Configuration-Helpers-Properties-Resources-ResourceManager 'MFR.Configuration.Helpers.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Configuration-Helpers-ConfigurationExtensions'></a>
## ConfigurationExtensions `type`

##### Namespace

MFR.Configuration.Helpers

##### Summary

Extension methods for objects implementing the [IConfiguration](#T-MFR-GUI-IConfiguration 'MFR.GUI.IConfiguration') interface.

<a name='M-MFR-Objects-Configuration-Helpers-ConfigurationExtensions-GetTextMatchingConfiguration-MFR-Objects-Configuration-Interfaces-IConfiguration-'></a>
### GetTextMatchingConfiguration(config) `method`

##### Summary

Gets the [TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration') value
that corresponds to the values set in the configuration object, a
reference to which is passed by the `config` parameter.

##### Returns

The [TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration') value that
corresponds to the values of the [IConfigurationMatchCase](#P-MFR-Objects-Configuration-Interfaces-IConfigurationMatchCase 'MFR.Configuration.Interfaces.IConfigurationMatchCase')
and [IConfigurationMatchExactWord](#P-MFR-Objects-Configuration-Interfaces-IConfigurationMatchExactWord 'MFR.Configuration.Interfaces.IConfigurationMatchExactWord') properties.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Configuration.Interfaces.IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Configuration.Interfaces.IConfiguration') | Reference to an instance of an object that implements the [IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration') interface. |

<a name='M-MFR-Objects-Configuration-Helpers-ConfigurationExtensions-SaveCurrentFindWhatAndHistory-MFR-Objects-Configuration-Interfaces-IConfiguration,MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox-'></a>
### SaveCurrentFindWhatAndHistory(config,comboBox) `method`

##### Summary

Saves the currently-selected Find What text item and the history to
the configuration.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Configuration.Interfaces.IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the [IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration') interface and which
allows access to the configuration data. |
| comboBox | [MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') | (Required.) Reference to an instance of an object that implements
the [IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox')
interface that is the control displaying the Find What content to the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if either of the required parameters, `config` or `comboBox`, are passed a `null` value. |

<a name='M-MFR-Objects-Configuration-Helpers-ConfigurationExtensions-SaveCurrentReplaceWithAndHistory-MFR-Objects-Configuration-Interfaces-IConfiguration,MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox-'></a>
### SaveCurrentReplaceWithAndHistory(config,comboBox) `method`

##### Summary

Saves the currently-selected Replace With text item and the history
to the configuration.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Configuration.Interfaces.IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the [IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration') interface and which
allows access to the configuration data. |
| comboBox | [MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') | (Required.) Reference to an instance of an object that implements
the [IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox')
interface that is the control displaying the Replace With content to the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if either of the required parameters, `config` or `comboBox`, are passed a `null` value. |

<a name='M-MFR-Objects-Configuration-Helpers-ConfigurationExtensions-SaveCurrentStartingFolderAndHistory-MFR-Objects-Configuration-Interfaces-IConfiguration,MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox-'></a>
### SaveCurrentStartingFolderAndHistory(config,comboBox) `method`

##### Summary

Saves the currently-selected Starting Folder text item and the
history to the configuration.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Configuration.Interfaces.IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the [IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration') interface and which
allows access to the configuration data. |
| comboBox | [MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox') | (Required.) Reference to an instance of an object that implements
the [IEntryRespectingComboBox](#T-MFR-GUI-Controls-Interfaces-IEntryRespectingComboBox 'MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox')
interface that is the control displaying the Starting Folder
content to the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if either of the required parameters, `config` or `comboBox`, are passed a `null` value. |

<a name='T-MFR-Objects-Configuration-Helpers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Configuration.Helpers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Configuration-Helpers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Configuration-Helpers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
