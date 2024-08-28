<a name='assembly'></a>
# MFR.Settings.Configuration.Providers.Interfaces

## Contents

- [IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
  - [ConfigFilePath](#P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider.ConfigFilePath')
  - [CurrentConfiguration](#P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-CurrentConfiguration 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider.CurrentConfiguration')
  - [Clear()](#M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-Clear 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider.Clear')
  - [Export(exportFileName)](#M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-Export-System-String- 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider.Export(System.String)')
  - [Import(sourceFilePath)](#M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-Import-System-String- 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider.Import(System.String)')
  - [Load(pathname)](#M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-Load-System-String- 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider.Load(System.String)')
  - [Save(pathname)](#M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-Save-System-String- 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider.Save(System.String)')
- [Resources](#T-MFR-Settings-Configuration-Providers-Interfaces-Properties-Resources 'MFR.Settings.Configuration.Providers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Providers-Interfaces-Properties-Resources-Culture 'MFR.Settings.Configuration.Providers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Providers-Interfaces-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Providers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider'></a>
## IProjectFileRenamerConfigProvider `type`

##### Namespace

MFR.Settings.Configuration.Providers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a
ProjectFileRenamerConfig Provider object.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-ConfigFilePath'></a>
### ConfigFilePath `property`

##### Summary

Gets or sets the pathname of the config file.

##### Remarks

This property raises the
[](#E-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-ConfigFilePathChanged 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider.ConfigFilePathChanged')
event when its value is updated.

<a name='P-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets a reference to the instance of the object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface and which
exposes settings changed by the user in order to modify the
application's behavior.

<a name='M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-Clear'></a>
### Clear() `method`

##### Summary

Resets the config to default values.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-Export-System-String-'></a>
### Export(exportFileName) `method`

##### Summary

Exports config data to a file other than the master
config file.

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
settings out to the master config file.



It goes without saying that an alternative to calling this method in
the first place is to simply call the
[Save](#M-MFR-Settings-ConfigurationProvider-Save 'MFR.Settings.ConfigurationProvider.Save')
method with a
value for its pathname parameter.



However, doing this will not save the user's settings to the master
file, which is important enough that we write a special method to
handle this.

<a name='M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-Import-System-String-'></a>
### Import(sourceFilePath) `method`

##### Summary

Imports config data from a file whose path is
`sourceFilePath`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of the
file from which to import the config data. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `sourceFilePath`,
is passed a blank or `null` string for a value. |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the file, the path to which is specified by the
`sourceFilePath`
parameter, cannot be located on the file system. |

##### Remarks

First, this method loads the data from the file specified into the
application's config object.



Then, the method saves the new data out to the master config file.

<a name='M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads the config from the file system.



The
[ProjectFileRenamerConfig](#P-MFR-Settings-Configuration-Providers-ConfigurationProvider-ProjectFileRenamerConfig 'MFR.Settings.Configuration.Providers.ConfigurationProvider.ProjectFileRenamerConfig')
property is then initialized to point to the data that has been loaded.

##### Returns

Reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface and which has been initialized with data from the config file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the pathname to a file to be loaded
from disk, that contains the config data in JSON format.



If this value is blank, then the file whose path is stored in the
[ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ConfigurationProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigFilePath')
property is used instead. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the file whose pathname is passed in the
`pathname`
parameter cannot be located on the file system. |

##### Remarks

The value of the
[ProjectFileRenamerConfig](#P-MFR-Settings-Configuration-Providers-ConfigurationProvider-ProjectFileRenamerConfig 'MFR.Settings.Configuration.Providers.ConfigurationProvider.ProjectFileRenamerConfig')
property is set to `null` if an error occurs during loading.

<a name='M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-Save-System-String-'></a>
### Save(pathname) `method`

##### Summary

Saves config data to a file on the file system having path
`pathname`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the path to where the data should be
saved in JSON format.



If this parameter is blank, then the data is saved to the path that
is stored in the
[ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ConfigurationProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigFilePath')
property. |

##### Remarks

If the
[ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ConfigurationProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigFilePath')
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
