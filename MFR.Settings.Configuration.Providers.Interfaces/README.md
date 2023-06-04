<a name='assembly'></a>
# MFR.Settings.Configuration.Providers.Interfaces

## Contents

- [IProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider')
  - [ConfigurationFilePath](#P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.ConfigurationFilePath')
  - [ConfigurationFilePathKeyName](#P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-ConfigurationFilePathKeyName 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.ConfigurationFilePathKeyName')
  - [ConfigurationFilePathValueName](#P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-ConfigurationFilePathValueName 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.ConfigurationFilePathValueName')
  - [CurrentConfiguration](#P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-CurrentConfiguration 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.CurrentConfiguration')
  - [DefaultConfigDir](#P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-DefaultConfigDir 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.DefaultConfigDir')
  - [DefaultConfigFileName](#P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-DefaultConfigFileName 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.DefaultConfigFileName')
  - [Export(exportFileName)](#M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-Export-System-String- 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.Export(System.String)')
  - [Import(sourceFilePath)](#M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-Import-System-String- 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.Import(System.String)')
  - [Load(pathname)](#M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-Load-System-String- 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.Load(System.String)')
  - [Save(pathname)](#M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-Save-System-String- 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.Save(System.String)')
- [Resources](#T-MFR-Settings-Configuration-Providers-Interfaces-Properties-Resources 'MFR.Settings.Configuration.Providers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Providers-Interfaces-Properties-Resources-Culture 'MFR.Settings.Configuration.Providers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Providers-Interfaces-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Providers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider'></a>
## IProjectFileRenamerConfigurationProvider `type`

##### Namespace

MFR.Settings.Configuration.Providers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a ProjectFileRenamerConfiguration Provider object.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-ConfigurationFilePath'></a>
### ConfigurationFilePath `property`

##### Summary

Gets or sets the pathname of the configuration file.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-ConfigurationFilePathKeyName'></a>
### ConfigurationFilePathKeyName `property`

##### Summary

Gets a string whose value is the pathname of the system Registry key in which configuration settings are stored.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-ConfigurationFilePathValueName'></a>
### ConfigurationFilePathValueName `property`

##### Summary

Gets a string whose value is the Registry value under which we store the path to the configuration file.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets a reference to the instance of the object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') interface and which
exposes settings changed by the user in order to modify the
application's behavior.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-DefaultConfigDir'></a>
### DefaultConfigDir `property`

##### Summary

Gets the default folder for the configuration file.

##### Remarks

We store the config file, by default, in a folder under %USERPROFILE%\AppData\Local.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-DefaultConfigFileName'></a>
### DefaultConfigFileName `property`

##### Summary

Gets the default filename for the config file.

<a name='M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-Export-System-String-'></a>
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

<a name='M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-Import-System-String-'></a>
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

<a name='M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads the configuration from the disk.



The
[ProjectFileRenamerConfiguration](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ConfigurationProvider-ProjectFileRenamerConfiguration 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ConfigurationProvider.ProjectFileRenamerConfiguration')
property is then initialized to point to the data that has been loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the pathname to a file to be loaded
from disk, that contains the configuration data in JSON format.



If this value is blank, then the file whose path is stored in the
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ConfigurationProvider.ConfigurationFilePath')
property is used instead. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the file whose pathname is passed in the
`pathname`
parameter cannot be located on the disk. |

##### Remarks

The value of the
[ProjectFileRenamerConfiguration](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ConfigurationProvider-ProjectFileRenamerConfiguration 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ConfigurationProvider.ProjectFileRenamerConfiguration')
property is set to `null` if an error occurs during loading.

<a name='M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-Save-System-String-'></a>
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
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ConfigurationProvider.ConfigurationFilePath')
property. |

##### Remarks

If the
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ConfigurationProvider.ConfigurationFilePath')
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
