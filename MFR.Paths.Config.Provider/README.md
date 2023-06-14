<a name='assembly'></a>
# MFR.Paths.Config.Provider

## Contents

- [ConfigPathProvider](#T-MFR-Paths-Config-Provider-ConfigPathProvider 'MFR.Paths.Config.Provider.ConfigPathProvider')
  - [#ctor()](#M-MFR-Paths-Config-Provider-ConfigPathProvider-#ctor 'MFR.Paths.Config.Provider.ConfigPathProvider.#ctor')
  - [_configFilePath](#F-MFR-Paths-Config-Provider-ConfigPathProvider-_configFilePath 'MFR.Paths.Config.Provider.ConfigPathProvider._configFilePath')
  - [ConfigFilePath](#P-MFR-Paths-Config-Provider-ConfigPathProvider-ConfigFilePath 'MFR.Paths.Config.Provider.ConfigPathProvider.ConfigFilePath')
  - [Instance](#P-MFR-Paths-Config-Provider-ConfigPathProvider-Instance 'MFR.Paths.Config.Provider.ConfigPathProvider.Instance')
  - [#cctor()](#M-MFR-Paths-Config-Provider-ConfigPathProvider-#cctor 'MFR.Paths.Config.Provider.ConfigPathProvider.#cctor')
  - [Load()](#M-MFR-Paths-Config-Provider-ConfigPathProvider-Load 'MFR.Paths.Config.Provider.ConfigPathProvider.Load')
  - [OnConfigCollectListPathSaveFailed(e)](#M-MFR-Paths-Config-Provider-ConfigPathProvider-OnConfigCollectListPathSaveFailed-MFR-Events-Common-ExceptionRaisedEventArgs- 'MFR.Paths.Config.Provider.ConfigPathProvider.OnConfigCollectListPathSaveFailed(MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnConfigFilePathChanged()](#M-MFR-Paths-Config-Provider-ConfigPathProvider-OnConfigFilePathChanged 'MFR.Paths.Config.Provider.ConfigPathProvider.OnConfigFilePathChanged')
  - [OnConfigFilePathLoadFailed(e)](#M-MFR-Paths-Config-Provider-ConfigPathProvider-OnConfigFilePathLoadFailed-MFR-Events-Common-ExceptionRaisedEventArgs- 'MFR.Paths.Config.Provider.ConfigPathProvider.OnConfigFilePathLoadFailed(MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnConfigFilePathLoaded()](#M-MFR-Paths-Config-Provider-ConfigPathProvider-OnConfigFilePathLoaded 'MFR.Paths.Config.Provider.ConfigPathProvider.OnConfigFilePathLoaded')
  - [OnConfigFilePathSaved()](#M-MFR-Paths-Config-Provider-ConfigPathProvider-OnConfigFilePathSaved 'MFR.Paths.Config.Provider.ConfigPathProvider.OnConfigFilePathSaved')
  - [OnLoadingConfigFilePath(e)](#M-MFR-Paths-Config-Provider-ConfigPathProvider-OnLoadingConfigFilePath-System-ComponentModel-CancelEventArgs- 'MFR.Paths.Config.Provider.ConfigPathProvider.OnLoadingConfigFilePath(System.ComponentModel.CancelEventArgs)')
  - [OnSavingConfigFilePath(e)](#M-MFR-Paths-Config-Provider-ConfigPathProvider-OnSavingConfigFilePath-System-ComponentModel-CancelEventArgs- 'MFR.Paths.Config.Provider.ConfigPathProvider.OnSavingConfigFilePath(System.ComponentModel.CancelEventArgs)')
  - [Save()](#M-MFR-Paths-Config-Provider-ConfigPathProvider-Save 'MFR.Paths.Config.Provider.ConfigPathProvider.Save')
- [Resources](#T-MFR-Paths-Config-Provider-Properties-Resources 'MFR.Paths.Config.Provider.Properties.Resources')
  - [Culture](#P-MFR-Paths-Config-Provider-Properties-Resources-Culture 'MFR.Paths.Config.Provider.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Paths-Config-Provider-Properties-Resources-ResourceManager 'MFR.Paths.Config.Provider.Properties.Resources.ResourceManager')

<a name='T-MFR-Paths-Config-Provider-ConfigPathProvider'></a>
## ConfigPathProvider `type`

##### Namespace

MFR.Paths.Config.Provider

##### Summary

Manages the loading and the storing of the pathname of the `config.json`
file to/from the system Registry.

<a name='M-MFR-Paths-Config-Provider-ConfigPathProvider-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Paths-Config-Provider-ConfigPathProvider-_configFilePath'></a>
### _configFilePath `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that holds the path the JSON file that stores
profiles.

<a name='P-MFR-Paths-Config-Provider-ConfigPathProvider-ConfigFilePath'></a>
### ConfigFilePath `property`

##### Summary

Gets a string whose value is the fully-qualified pathname of the profile list
file.

##### Remarks

When this property's value is updated, the
[](#E-MFR-Settings-Config-Providers-ConfigProvider-ConfigFilePathChanged 'MFR.Settings.Config.Providers.ConfigProvider.ConfigFilePathChanged')
event  is raised.

<a name='P-MFR-Paths-Config-Provider-ConfigPathProvider-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IConfigPathProvider](#T-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider')
interface.

<a name='M-MFR-Paths-Config-Provider-ConfigPathProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Paths-Config-Provider-ConfigPathProvider-Load'></a>
### Load() `method`

##### Summary

Loads the value of the
[ConfigFilePath](#P-MFR-Paths-Config-Provider-ConfigPathProvider-ConfigFilePath 'MFR.Paths.Config.Provider.ConfigPathProvider.ConfigFilePath')
property from the system Registry.

##### Parameters

This method has no parameters.

##### Remarks

The
[](#E-MFR-Paths-Config-Provider-ConfigPathProvider-LoadingConfigFilePath 'MFR.Paths.Config.Provider.ConfigPathProvider.LoadingConfigFilePath')
event is raised before this method begins its operations.  Setting the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true` on this event will prevent this method from executing
further.



If the operation of obtaining the value of the
[ConfigFilePath](#P-MFR-Paths-Config-Provider-ConfigPathProvider-ConfigFilePath 'MFR.Paths.Config.Provider.ConfigPathProvider.ConfigFilePath')
property from the system Registry was successful, then the
[](#E-MFR-Paths-Config-Provider-ConfigPathProvider-ConfigFilePathLoaded 'MFR.Paths.Config.Provider.ConfigPathProvider.ConfigFilePathLoaded')
event is raised.



Otherwise, if a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') is raised during the
processing of the operation, then this method raises the
[](#E-MFR-Paths-Config-Provider-ConfigPathProvider-ConfigFilePathLoadFailed 'MFR.Paths.Config.Provider.ConfigPathProvider.ConfigFilePathLoadFailed')
event.

<a name='M-MFR-Paths-Config-Provider-ConfigPathProvider-OnConfigCollectListPathSaveFailed-MFR-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnConfigCollectListPathSaveFailed(e) `method`

##### Summary

Raises the
[](#E-MFR-Paths-Config-Provider-ConfigPathProvider-ConfigFilePathSaveFailed 'MFR.Paths.Config.Provider.ConfigPathProvider.ConfigFilePathSaveFailed')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.Common.ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs') | A [ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs')
that contains the event data. |

<a name='M-MFR-Paths-Config-Provider-ConfigPathProvider-OnConfigFilePathChanged'></a>
### OnConfigFilePathChanged() `method`

##### Summary

Raises the
[](#E-MFR-Settings-Config-Providers-ConfigProvider-ConfigFilePathChanged 'MFR.Settings.Config.Providers.ConfigProvider.ConfigFilePathChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Paths-Config-Provider-ConfigPathProvider-OnConfigFilePathLoadFailed-MFR-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnConfigFilePathLoadFailed(e) `method`

##### Summary

Raises the
[](#E-MFR-Paths-Config-Provider-ConfigPathProvider-ConfigFilePathLoadFailed 'MFR.Paths.Config.Provider.ConfigPathProvider.ConfigFilePathLoadFailed')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.Common.ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs') | A [ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs')
that contains the event data. |

<a name='M-MFR-Paths-Config-Provider-ConfigPathProvider-OnConfigFilePathLoaded'></a>
### OnConfigFilePathLoaded() `method`

##### Summary

Raises the
[](#E-MFR-Paths-Config-Provider-ConfigPathProvider-ConfigFilePathLoaded 'MFR.Paths.Config.Provider.ConfigPathProvider.ConfigFilePathLoaded')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Paths-Config-Provider-ConfigPathProvider-OnConfigFilePathSaved'></a>
### OnConfigFilePathSaved() `method`

##### Summary

Raises the
[](#E-MFR-Paths-Config-Provider-ConfigPathProvider-ConfigFilePathSaved 'MFR.Paths.Config.Provider.ConfigPathProvider.ConfigFilePathSaved')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Paths-Config-Provider-ConfigPathProvider-OnLoadingConfigFilePath-System-ComponentModel-CancelEventArgs-'></a>
### OnLoadingConfigFilePath(e) `method`

##### Summary

Raises the
[](#E-MFR-Paths-Config-Provider-ConfigPathProvider-LoadingConfigFilePath 'MFR.Paths.Config.Provider.ConfigPathProvider.LoadingConfigFilePath')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.ComponentModel.CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') | A [CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') that
allows us to cancel the operation that this event is notifying the caller of.



To cancel the operation, handlers should set the value of the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true`. |

<a name='M-MFR-Paths-Config-Provider-ConfigPathProvider-OnSavingConfigFilePath-System-ComponentModel-CancelEventArgs-'></a>
### OnSavingConfigFilePath(e) `method`

##### Summary

Raises the
[](#E-MFR-Paths-Config-Provider-ConfigPathProvider-SavingConfigFilePath 'MFR.Paths.Config.Provider.ConfigPathProvider.SavingConfigFilePath')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.ComponentModel.CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') | A [CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') that
allows us to cancel the operation that this event is notifying the caller of.



To cancel the operation, handlers should set the value of the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true`. |

<a name='M-MFR-Paths-Config-Provider-ConfigPathProvider-Save'></a>
### Save() `method`

##### Summary

Saves the value of the
[ConfigFilePath](#P-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-ConfigFilePath 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath')
property to the system Registry.

##### Parameters

This method has no parameters.

##### Remarks

The
[](#E-MFR-Paths-Config-Provider-ConfigPathProvider-SavingConfigFilePath 'MFR.Paths.Config.Provider.ConfigPathProvider.SavingConfigFilePath')
event is raised before this method begins its operations.  Setting the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true` on this event will prevent this method from executing
further.



If the operation of storing the value of the
[ConfigFilePath](#P-MFR-Paths-Config-Provider-ConfigPathProvider-ConfigFilePath 'MFR.Paths.Config.Provider.ConfigPathProvider.ConfigFilePath')
property to the system Registry was successful, then the
[](#E-MFR-Paths-Config-Provider-ConfigPathProvider-ConfigFilePathSaved 'MFR.Paths.Config.Provider.ConfigPathProvider.ConfigFilePathSaved')
event is raised.



Otherwise, if a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') is raised during the
processing of the operation, then this method raises the
[](#E-MFR-Paths-Config-Provider-ConfigPathProvider-ConfigFilePathSaveFailed 'MFR.Paths.Config.Provider.ConfigPathProvider.ConfigFilePathSaveFailed')
event.

<a name='T-MFR-Paths-Config-Provider-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Paths.Config.Provider.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Paths-Config-Provider-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Paths-Config-Provider-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
