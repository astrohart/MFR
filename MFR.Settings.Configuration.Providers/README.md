<a name='assembly'></a>
# MFR.Settings.Configuration.Providers

## Contents

- [ProjectFileRenmerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider')
  - [#ctor()](#M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-#ctor 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.#ctor')
  - [ConfigurationFilePath](#P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.ConfigurationFilePath')
  - [ConfigurationFilePathKeyName](#P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-ConfigurationFilePathKeyName 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.ConfigurationFilePathKeyName')
  - [ConfigurationFilePathValueName](#P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-ConfigurationFilePathValueName 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.ConfigurationFilePathValueName')
  - [CurrentConfiguration](#P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-CurrentConfiguration 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.CurrentConfiguration')
  - [DefaultConfigDir](#P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-DefaultConfigDir 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.DefaultConfigDir')
  - [DefaultConfigFileName](#P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-DefaultConfigFileName 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.DefaultConfigFileName')
  - [Instance](#P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-Instance 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.Instance')
  - [LoadConfigPathAction](#P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-LoadConfigPathAction 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.LoadConfigPathAction')
  - [#cctor()](#M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-#cctor 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.#cctor')
  - [CanLoad(pathname)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-CanLoad-System-String@- 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.CanLoad(System.String@)')
  - [Export(exportFileName)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-Export-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.Export(System.String)')
  - [Import(sourceFilePath)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-Import-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.Import(System.String)')
  - [Load(pathname)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-Load-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.Load(System.String)')
  - [Save(pathname)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-Save-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.Save(System.String)')
  - [SaveCopyAs(pathname)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-SaveCopyAs-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider.SaveCopyAs(System.String)')
- [Resources](#T-MFR-Settings-Configuration-Providers-Properties-Resources 'MFR.Settings.Configuration.Providers.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Providers-Properties-Resources-Culture 'MFR.Settings.Configuration.Providers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Providers-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Providers.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider'></a>
## ProjectFileRenmerConfigurationProvider `type`

##### Namespace

MFR.Settings.Configuration.Providers

##### Summary

Provides shared functionality for obtaining and storing the path to the
user's configuration file.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-ConfigurationFilePath'></a>
### ConfigurationFilePath `property`

##### Summary

Gets or sets the pathname of the configuration file.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-ConfigurationFilePathKeyName'></a>
### ConfigurationFilePathKeyName `property`

##### Summary

Gets a string whose value is the pathname of the system Registry key in which
configuration settings are stored.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-ConfigurationFilePathValueName'></a>
### ConfigurationFilePathValueName `property`

##### Summary

Gets a string whose value is the Registry value under which we store the path
to the configuration file.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets a reference to the instance of the object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface
and which
exposes settings changed by the user in order to modify the
application's behavior.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-DefaultConfigDir'></a>
### DefaultConfigDir `property`

##### Summary

Gets the default folder for the configuration file.

##### Remarks

We store the config file, by default, in a folder under
%USERPROFILE%\AppData\Local.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-DefaultConfigFileName'></a>
### DefaultConfigFileName `property`

##### Summary

Gets the default filename for the config file.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[ProjectFileRenmerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider').

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-LoadConfigPathAction'></a>
### LoadConfigPathAction `property`

##### Summary

Default action to be utilized for loading the path to the configuration file
from the system Registry.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-CanLoad-System-String@-'></a>
### CanLoad(pathname) `method`

##### Summary

Determines whether the configuration should be loaded from the file whose path
is specified in the `pathname` parameter, or whether no data
actually exists at that location and we should, instead, just use
the default value of the
[ProjectFileRenamerConfiguration](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenmerConfigurationProvider-ProjectFileRenamerConfiguration 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenmerConfigurationProvider.ProjectFileRenamerConfiguration')
property.

##### Returns

`true` if the file at the path specified by
`pathname` exists on the disk, or if the file whose path is
given by the value of the
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenmerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenmerConfigurationProvider.ConfigurationFilePath')
property exists on the disk; `false` otherwise.



If the `pathname` passed is blank, then this method updates
it to have the value of the
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenmerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenmerConfigurationProvider.ConfigurationFilePath')
property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') | (Required.) Address of the string containing the fully-qualified pathname of
the configuration
file.



If this parameter is blank, then the value of the
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenmerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenmerConfigurationProvider.ConfigurationFilePath')
property is used. |

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-Export-System-String-'></a>
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
[Save](#M-MFR-Settings-ProjectFileRenmerConfigurationProvider-Save 'MFR.Settings.ProjectFileRenmerConfigurationProvider.Save')
method with a
value for its pathname parameter.



However, doing this will not save the user's settings to the master
file, which is important enough that we write a special method to
handle this.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-Import-System-String-'></a>
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

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads the configuration from the disk.



The
[ProjectFileRenamerConfiguration](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenmerConfigurationProvider-ProjectFileRenamerConfiguration 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenmerConfigurationProvider.ProjectFileRenamerConfiguration')
property is then initialized to point to the data that has been loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the pathname to a file to be loaded
from disk, that contains the configuration data in JSON format.



If this value is blank, then the file whose path is stored in the
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenmerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenmerConfigurationProvider.ConfigurationFilePath')
property is used instead. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the file whose pathname is passed in the
`pathname`
parameter cannot be located on the disk. |

##### Remarks

The value of the
[ProjectFileRenamerConfiguration](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenmerConfigurationProvider-ProjectFileRenamerConfiguration 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenmerConfigurationProvider.ProjectFileRenamerConfiguration')
property is set to `null` if an error occurs during loading.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-Save-System-String-'></a>
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
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenmerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenmerConfigurationProvider.ConfigurationFilePath')
property. |

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider-SaveCopyAs-System-String-'></a>
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
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenmerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenmerConfigurationProvider.ConfigurationFilePath')
property. |

##### Remarks

If the
[ConfigurationFilePath](#P-MFR-Settings-ProjectFileRenamerConfiguration-Providers-ProjectFileRenmerConfigurationProvider-ConfigurationFilePath 'MFR.Settings.ProjectFileRenamerConfiguration.Providers.ProjectFileRenmerConfigurationProvider.ConfigurationFilePath')
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
