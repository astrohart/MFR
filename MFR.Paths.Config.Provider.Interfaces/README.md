<a name='assembly'></a>
# MFR.Paths.Config.Provider.Interfaces

## Contents

- [IConfigPathProvider](#T-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider')
  - [ConfigFilePath](#P-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-ConfigFilePath 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath')
  - [Load()](#M-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-Load 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.Load')
  - [Save()](#M-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-Save 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.Save')
- [Resources](#T-MFR-Paths-Config-Provider-Interfaces-Properties-Resources 'MFR.Paths.Config.Provider.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Paths-Config-Provider-Interfaces-Properties-Resources-Culture 'MFR.Paths.Config.Provider.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Paths-Config-Provider-Interfaces-Properties-Resources-ResourceManager 'MFR.Paths.Config.Provider.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider'></a>
## IConfigPathProvider `type`

##### Namespace

MFR.Paths.Config.Provider.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that provides
access to the fully-qualified pathname of the application configuration file.

<a name='P-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-ConfigFilePath'></a>
### ConfigFilePath `property`

##### Summary

Gets a string whose value is the fully-qualified pathname of the application configuration file.

##### Remarks

When this property's value is updated, the
[](#E-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-ConfigFilePathChanged 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePathChanged')
event  is raised.

<a name='M-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-Load'></a>
### Load() `method`

##### Summary

Loads the value of the
[ConfigFilePath](#P-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-ConfigFilePath 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath')
property from the system Registry.

##### Parameters

This method has no parameters.

##### Remarks

The
[](#E-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-LoadingConfigFilePath 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.LoadingConfigFilePath')
event is raised before this method begins its operations.  Setting the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true` on this event will prevent this method from executing
further.



If the operation of obtaining the value of the
[ConfigFilePath](#P-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-ConfigFilePath 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath')
property from the system Registry was successful, then the
[](#E-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-ConfigFilePathLoaded 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePathLoaded')
event is raised.



Otherwise, if a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') is raised during the
processing of the operation, then this method raises the
[](#E-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-ConfigFilePathLoadFailed 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePathLoadFailed')
event.

<a name='M-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-Save'></a>
### Save() `method`

##### Summary

Saves the value of the
[ConfigFilePath](#P-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-ConfigFilePath 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath')
property to the system Registry.

##### Parameters

This method has no parameters.

##### Remarks

The
[](#E-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-SavingConfigFilePath 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.SavingConfigFilePath')
event is raised before this method begins its operations.  Setting the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true` on this event will prevent this method from executing
further.



If the operation of storing the value of the
[ConfigFilePath](#P-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-ConfigFilePath 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath')
property to the system Registry was successful, then the
[](#E-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-ConfigFilePathSaved 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePathSaved')
event is raised.



Otherwise, if a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') is raised during the
processing of the operation, then this method raises the
[](#E-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider-ConfigFilePathSaveFailed 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePathSaveFailed')
event.

<a name='T-MFR-Paths-Config-Provider-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Paths.Config.Provider.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Paths-Config-Provider-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Paths-Config-Provider-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
