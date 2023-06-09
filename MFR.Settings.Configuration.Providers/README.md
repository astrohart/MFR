<a name='assembly'></a>
# MFR.Settings.Configuration.Providers

## Contents

- [ProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider')
  - [#ctor()](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-#ctor 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.#ctor')
  - [_configurationFilePath](#F-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-_configurationFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider._configurationFilePath')
  - [ConfigurationFilePath](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigurationFilePath')
  - [ConfigurationFilePathKeyName](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationFilePathKeyName 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigurationFilePathKeyName')
  - [ConfigurationFilePathValueName](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationFilePathValueName 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigurationFilePathValueName')
  - [CurrentConfiguration](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-CurrentConfiguration 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.CurrentConfiguration')
  - [DefaultConfigDir](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-DefaultConfigDir 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.DefaultConfigDir')
  - [DefaultConfigFileName](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-DefaultConfigFileName 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.DefaultConfigFileName')
  - [Instance](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Instance 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.Instance')
  - [LoadConfigPathAction](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-LoadConfigPathAction 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.LoadConfigPathAction')
  - [#cctor()](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-#cctor 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.#cctor')
  - [CanLoad(pathname)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-CanLoad-System-String@- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.CanLoad(System.String@)')
  - [Export(exportFileName)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Export-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.Export(System.String)')
  - [Import(sourceFilePath)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Import-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.Import(System.String)')
  - [Load(pathname)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Load-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.Load(System.String)')
  - [OnConfigurationFilePathChanged(e)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-OnConfigurationFilePathChanged-MFR-Settings-Configuration-Providers-Events-ConfigurationFilePathChangedEventArgs- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.OnConfigurationFilePathChanged(MFR.Settings.Configuration.Providers.Events.ConfigurationFilePathChangedEventArgs)')
  - [OnConfigurationLoaded()](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-OnConfigurationLoaded 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.OnConfigurationLoaded')
  - [Save(pathname)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Save-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.Save(System.String)')
  - [SaveCopyAs(pathname)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-SaveCopyAs-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.SaveCopyAs(System.String)')
- [Resources](#T-MFR-Settings-Configuration-Providers-Properties-Resources 'MFR.Settings.Configuration.Providers.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Providers-Properties-Resources-Culture 'MFR.Settings.Configuration.Providers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Providers-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Providers.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider'></a>
## ProjectFileRenamerConfigurationProvider `type`

##### Namespace

MFR.Settings.Configuration.Providers

##### Summary

Provides shared functionality for obtaining and storing the path to the
user's configuration file.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-_configurationFilePath'></a>
### _configurationFilePath `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified pathname of
the application's configuration file.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationFilePath'></a>
### ConfigurationFilePath `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the application's configuration file.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationFilePathKeyName'></a>
### ConfigurationFilePathKeyName `property`

##### Summary

Gets a string whose value is the pathname of the system Registry key in which
configuration settings are stored.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationFilePathValueName'></a>
### ConfigurationFilePathValueName `property`

##### Summary

Gets a string whose value is the Registry value under which we store the path
to the configuration file.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets a reference to the instance of the object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface
and which
exposes settings changed by the user in order to modify the
application's behavior.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-DefaultConfigDir'></a>
### DefaultConfigDir `property`

##### Summary

Gets the default folder for the configuration file.

##### Remarks

We store the config file, by default, in a folder under
%USERPROFILE%\AppData\Local.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-DefaultConfigFileName'></a>
### DefaultConfigFileName `property`

##### Summary

Gets the default filename for the config file.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[ProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider')
.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-LoadConfigPathAction'></a>
### LoadConfigPathAction `property`

##### Summary

Default action to be utilized for loading the path to the configuration file
from the system Registry.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-CanLoad-System-String@-'></a>
### CanLoad(pathname) `method`

##### Summary

Determines whether the configuration should be loaded from the file whose path
is specified in the `pathname` parameter, or whether no data
actually exists at that location and we should, instead, just use
the default value of the
[ProjectFileRenamerConfiguration](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenamerConfigurationProvider-ProjectFileRenamerConfiguration 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenamerConfigurationProvider.ProjectFileRenamerConfiguration')
property.

##### Returns

`true` if the file at the path specified by
`pathname` exists on the disk, or if the file whose path is
given by the value of the
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenamerConfigurationProvider.ConfigurationFilePath')
property exists on the disk; `false` otherwise.



If the `pathname` passed is blank, then this method updates
it to have the value of the
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenamerConfigurationProvider.ConfigurationFilePath')
property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') | (Required.) Address of the string containing the fully-qualified pathname of
the configuration
file.



If this parameter is blank, then the value of the
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenamerConfigurationProvider.ConfigurationFilePath')
property is used. |

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Export-System-String-'></a>
### Export(exportFileName) `method`

##### Summary

Exports configuration data to a file other than the master
configuration file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exportFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `exportFileName`,
is passed a blank or `null` string for a value. |

##### Remarks

Before performing the export, the method first saves the latest
settings out to the master configuration file.



It goes without saying that an alternative to calling this method in
the first place is to simply call the
[Save](#M-MFR-Settings-ProjectFileRenamerConfigurationProvider-Save 'MFR.Settings.ProjectFileRenamerConfigurationProvider.Save')
method with a
value for its pathname parameter.



However, doing this will not save the user's settings to the master
file, which is important enough that we write a special method to
handle this.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Import-System-String-'></a>
### Import(sourceFilePath) `method`

##### Summary

Imports configuration data from a file whose path is
`sourceFilePath`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of the
file from which to import the configuration data. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `sourceFilePath`,
is passed a blank or `null` string for a value. |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the file, the path to which is specified by the
`sourceFilePath`
parameter, cannot be located on the disk. |

##### Remarks

First, this method loads the data from the file specified into the
application's configuration object.



Then, the method saves the new data out to the master
configuration file.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads the configuration from the disk.



The
[ProjectFileRenamerConfiguration](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenamerConfigurationProvider-ProjectFileRenamerConfiguration 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenamerConfigurationProvider.ProjectFileRenamerConfiguration')
property is then initialized to point to the data that has been loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the pathname to a file to be loaded
from disk, that contains the configuration data in JSON format.



If this value is blank, then the file whose path is stored in the
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenamerConfigurationProvider.ConfigurationFilePath')
property is used instead. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the file whose pathname is passed in the
`pathname`
parameter cannot be located on the disk. |

##### Remarks

The value of the
[ProjectFileRenamerConfiguration](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenamerConfigurationProvider-ProjectFileRenamerConfiguration 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenamerConfigurationProvider.ProjectFileRenamerConfiguration')
property is set to `null` if an error occurs during loading.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-OnConfigurationFilePathChanged-MFR-Settings-Configuration-Providers-Events-ConfigurationFilePathChangedEventArgs-'></a>
### OnConfigurationFilePathChanged(e) `method`

##### Summary

Raises the
[](#E-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationFilePathChanged 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigurationFilePathChanged')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Settings.Configuration.Providers.Events.ConfigurationFilePathChangedEventArgs](#T-MFR-Settings-Configuration-Providers-Events-ConfigurationFilePathChangedEventArgs 'MFR.Settings.Configuration.Providers.Events.ConfigurationFilePathChangedEventArgs') | A
[ConfigurationFilePathChangedEventArgs](#T-MFR-Settings-Configuration-Providers-Events-ConfigurationFilePathChangedEventArgs 'MFR.Settings.Configuration.Providers.Events.ConfigurationFilePathChangedEventArgs')
that contains the event data. |

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-OnConfigurationLoaded'></a>
### OnConfigurationLoaded() `method`

##### Summary

Raises the
[](#E-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationLoaded 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigurationLoaded')
event.

##### Parameters

This method has no parameters.

##### Remarks

This event is raised when this object has successfully completed the operation
of loading the configuration settings.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Save-System-String-'></a>
### Save(pathname) `method`

##### Summary

Saves configuration data to a file on the disk having path
`pathname`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the path to where the data should be
saved in JSON format.



If this parameter is blank, then the data is saved to the path that
is stored in the
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenamerConfigurationProvider.ConfigurationFilePath')
property. |

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-SaveCopyAs-System-String-'></a>
### SaveCopyAs(pathname) `method`

##### Summary

Saves configuration data to a file on the disk having path
`pathname`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the path to where the data should be
saved in JSON format.



If this parameter is blank, then the data is saved to the path that
is stored in the
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenamerConfigurationProvider.ConfigurationFilePath')
property. |

##### Remarks

If the
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenamerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenamerConfigurationProvider.ConfigurationFilePath')
property is blank, then this method does nothing.

<a name='T-MFR-Settings-Configuration-Providers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Providers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Providers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Providers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
