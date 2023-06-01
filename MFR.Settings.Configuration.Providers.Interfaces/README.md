<a name='assembly'></a>
# MFR.Settings.Configuration.Providers.Interfaces

## Contents

- [IConfigurationProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider')
  - [Configuration](#P-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-Configuration 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.Configuration')
  - [ConfigurationFilePath](#P-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-ConfigurationFilePath 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.ConfigurationFilePath')
  - [ConfigurationFilePathKeyName](#P-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-ConfigurationFilePathKeyName 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.ConfigurationFilePathKeyName')
  - [ConfigurationFilePathValueName](#P-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-ConfigurationFilePathValueName 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.ConfigurationFilePathValueName')
  - [DefaultConfigDir](#P-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-DefaultConfigDir 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.DefaultConfigDir')
  - [DefaultConfigFileName](#P-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-DefaultConfigFileName 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.DefaultConfigFileName')
  - [Export(exportFileName)](#M-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-Export-System-String- 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.Export(System.String)')
  - [Import(sourceFilePath)](#M-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-Import-System-String- 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.Import(System.String)')
  - [Load(pathname)](#M-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-Load-System-String- 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.Load(System.String)')
  - [Save(pathname)](#M-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-Save-System-String- 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.Save(System.String)')
- [Resources](#T-MFR-Settings-Configuration-Providers-Interfaces-Properties-Resources 'MFR.Settings.Configuration.Providers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Providers-Interfaces-Properties-Resources-Culture 'MFR.Settings.Configuration.Providers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Providers-Interfaces-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Providers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider'></a>
## IConfigurationProvider `type`

##### Namespace

MFR.Settings.Configuration.Providers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a Configuration Provider object.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-Configuration'></a>
### Configuration `property`

##### Summary

Gets a reference to the instance of the object that implements the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') interface and which
exposes settings changed by the user in order to modify the
application's behavior.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-ConfigurationFilePath'></a>
### ConfigurationFilePath `property`

##### Summary

Gets or sets the pathname of the configuration file.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-ConfigurationFilePathKeyName'></a>
### ConfigurationFilePathKeyName `property`

##### Summary

Gets a string whose value is the pathname of the system Registry key in which configuration settings are stored.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-ConfigurationFilePathValueName'></a>
### ConfigurationFilePathValueName `property`

##### Summary

Gets a string whose value is the Registry value under which we store the path to the configuration file.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-DefaultConfigDir'></a>
### DefaultConfigDir `property`

##### Summary

Gets the default folder for the configuration file.

##### Remarks

We store the config file, by default, in a folder under %USERPROFILE%\AppData\Local.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-DefaultConfigFileName'></a>
### DefaultConfigFileName `property`

##### Summary

Gets the default filename for the config file.

<a name='M-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-Export-System-String-'></a>
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
[Save](#M-MFR-Settings-ConfigurationProvider-Save 'MFR.Settings.ConfigurationProvider.Save')
method with a
value for its pathname parameter.



However, doing this will not save the user's settings to the master
file, which is important enough that we write a special method to
handle this.

<a name='M-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-Import-System-String-'></a>
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



Then, the method saves the new data out to the master configuration file.

<a name='M-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads the configuration from the disk.



The
[Configuration](#P-MFR-Settings-Configuration-Providers-ConfigurationProvider-Configuration 'MFR.Settings.Configuration.Providers.ConfigurationProvider.Configuration')
property is then initialized to point to the data that has been loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the pathname to a file to be loaded
from disk, that contains the configuration data in JSON format.



If this value is blank, then the file whose path is stored in the
[ConfigurationFilePath](#P-MFR-Settings-Configuration-Providers-ConfigurationProvider-ConfigurationFilePath 'MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath')
property is used instead. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the file whose pathname is passed in the
`pathname`
parameter cannot be located on the disk. |

##### Remarks

The value of the
[Configuration](#P-MFR-Settings-Configuration-Providers-ConfigurationProvider-Configuration 'MFR.Settings.Configuration.Providers.ConfigurationProvider.Configuration')
property is set to `null` if an error occurs during loading.

<a name='M-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider-Save-System-String-'></a>
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
[ConfigurationFilePath](#P-MFR-Settings-Configuration-Providers-ConfigurationProvider-ConfigurationFilePath 'MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath')
property. |

##### Remarks

If the
[ConfigurationFilePath](#P-MFR-Settings-Configuration-Providers-ConfigurationProvider-ConfigurationFilePath 'MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath')
property is blank, then this method does nothing.

<a name='T-MFR-Settings-Configuration-Providers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Providers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
