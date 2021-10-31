<a name='assembly'></a>
# MFR.Configuration.Providers

## Contents

- [ConfigurationProvider](#T-MFR-Objects-Configuration-Providers-ConfigurationProvider 'MFR.Configuration.Providers.ConfigurationProvider')
  - [Configuration](#P-MFR-Objects-Configuration-Providers-ConfigurationProvider-Configuration 'MFR.Configuration.Providers.ConfigurationProvider.Configuration')
  - [ConfigurationFilePath](#P-MFR-Objects-Configuration-Providers-ConfigurationProvider-ConfigurationFilePath 'MFR.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath')
  - [ConfigurationKeyName](#P-MFR-Objects-Configuration-Providers-ConfigurationProvider-ConfigurationKeyName 'MFR.Configuration.Providers.ConfigurationProvider.ConfigurationKeyName')
  - [ConfigurationPathValueName](#P-MFR-Objects-Configuration-Providers-ConfigurationProvider-ConfigurationPathValueName 'MFR.Configuration.Providers.ConfigurationProvider.ConfigurationPathValueName')
  - [DefaultConfigDir](#P-MFR-Objects-Configuration-Providers-ConfigurationProvider-DefaultConfigDir 'MFR.Configuration.Providers.ConfigurationProvider.DefaultConfigDir')
  - [DefaultConfigFileName](#P-MFR-Objects-Configuration-Providers-ConfigurationProvider-DefaultConfigFileName 'MFR.Configuration.Providers.ConfigurationProvider.DefaultConfigFileName')
  - [Export(exportFileName)](#M-MFR-Objects-Configuration-Providers-ConfigurationProvider-Export-System-String- 'MFR.Configuration.Providers.ConfigurationProvider.Export(System.String)')
  - [Import(sourceFilePath)](#M-MFR-Objects-Configuration-Providers-ConfigurationProvider-Import-System-String- 'MFR.Configuration.Providers.ConfigurationProvider.Import(System.String)')
  - [Load(pathname)](#M-MFR-Objects-Configuration-Providers-ConfigurationProvider-Load-System-String- 'MFR.Configuration.Providers.ConfigurationProvider.Load(System.String)')
  - [Save(pathname)](#M-MFR-Objects-Configuration-Providers-ConfigurationProvider-Save-System-String- 'MFR.Configuration.Providers.ConfigurationProvider.Save(System.String)')
- [Resources](#T-MFR-Objects-Configuration-Providers-Properties-Resources 'MFR.Configuration.Providers.Properties.Resources')
  - [Culture](#P-MFR-Objects-Configuration-Providers-Properties-Resources-Culture 'MFR.Configuration.Providers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Configuration-Providers-Properties-Resources-ResourceManager 'MFR.Configuration.Providers.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Configuration-Providers-ConfigurationProvider'></a>
## ConfigurationProvider `type`

##### Namespace

MFR.Configuration.Providers

##### Summary

Provides shared functionality for obtaining and storing the path to the
user's configuration file.

<a name='P-MFR-Objects-Configuration-Providers-ConfigurationProvider-Configuration'></a>
### Configuration `property`

##### Summary

Gets a reference to the instance of the object that implements the
[IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration') interface and
which exposes settings changed by the user in order to modify the
application's behavior.

<a name='P-MFR-Objects-Configuration-Providers-ConfigurationProvider-ConfigurationFilePath'></a>
### ConfigurationFilePath `property`

##### Summary

Gets or sets the pathname of the configuration file.

<a name='P-MFR-Objects-Configuration-Providers-ConfigurationProvider-ConfigurationKeyName'></a>
### ConfigurationKeyName `property`

##### Summary

Gets the path to the Registry subkey that stores information about
the paths of files.

<a name='P-MFR-Objects-Configuration-Providers-ConfigurationProvider-ConfigurationPathValueName'></a>
### ConfigurationPathValueName `property`

##### Summary

Gets the name of the Registry value that holds the path to the
configuration file.

<a name='P-MFR-Objects-Configuration-Providers-ConfigurationProvider-DefaultConfigDir'></a>
### DefaultConfigDir `property`

##### Summary

Gets the default folder for the configuration file.

##### Remarks

We store the config file, by default, in a folder under C:\ProgramData.

<a name='P-MFR-Objects-Configuration-Providers-ConfigurationProvider-DefaultConfigFileName'></a>
### DefaultConfigFileName `property`

##### Summary

Gets the default filename for the config file.

<a name='M-MFR-Objects-Configuration-Providers-ConfigurationProvider-Export-System-String-'></a>
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
[Save](#M-MFR-Objects-ConfigurationProvider-Save 'MFR.ConfigurationProvider.Save')
method
with a value for its pathname parameter.



However, doing this will not save the user's settings to the master
file, which is important enough that we write a special method to
handle this.

<a name='M-MFR-Objects-Configuration-Providers-ConfigurationProvider-Import-System-String-'></a>
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

<a name='M-MFR-Objects-Configuration-Providers-ConfigurationProvider-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads the configuration from the disk.



The
[Configuration](#P-MFR-Objects-Configuration-Providers-ConfigurationProvider-Configuration 'MFR.Configuration.Providers.ConfigurationProvider.Configuration')
property is then initialized to point to the data that has been loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the pathname to a file to be loaded
from disk, that contains the configuration data in JSON format.



If this value is blank, then the file whose path is stored in the
[ConfigurationFilePath](#P-MFR-Objects-Configuration-Providers-ConfigurationProvider-ConfigurationFilePath 'MFR.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath')
property is used instead. |

##### Remarks

The value of the
[Configuration](#P-MFR-Objects-Configuration-Providers-ConfigurationProvider-Configuration 'MFR.Configuration.Providers.ConfigurationProvider.Configuration')
property is set to `null` if an error occurs during loading.

<a name='M-MFR-Objects-Configuration-Providers-ConfigurationProvider-Save-System-String-'></a>
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
[ConfigurationFilePath](#P-MFR-Objects-Configuration-Providers-ConfigurationProvider-ConfigurationFilePath 'MFR.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath')
property. |

##### Remarks

If the
[ConfigurationFilePath](#P-MFR-Objects-Configuration-Providers-ConfigurationProvider-ConfigurationFilePath 'MFR.Configuration.Providers.ConfigurationProvider.ConfigurationFilePath')
property is blank, then this method does nothing.

<a name='T-MFR-Objects-Configuration-Providers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Configuration.Providers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Configuration-Providers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Configuration-Providers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
