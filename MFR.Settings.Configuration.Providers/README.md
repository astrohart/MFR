<a name='assembly'></a>
# MFR.Settings.Configuration.Providers

## Contents

- [ProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider')
  - [#ctor()](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-#ctor 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.#ctor')
  - [ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePath')
  - [ConfigPathProvider](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigPathProvider 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigPathProvider')
  - [CurrentConfiguration](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-CurrentConfiguration 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.CurrentConfiguration')
  - [Instance](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Instance 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.Instance')
  - [#cctor()](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-#cctor 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.#cctor')
  - [Clear()](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Clear 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.Clear')
  - [Export(exportFileName)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Export-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.Export(System.String)')
  - [Import(sourceFilePath)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Import-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.Import(System.String)')
  - [InitializeConfigPathProvider()](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-InitializeConfigPathProvider 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.InitializeConfigPathProvider')
  - [Load(pathname)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Load-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.Load(System.String)')
  - [OnConfigFilePathChanged(sender,e)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-OnConfigFilePathChanged-System-Object,System-EventArgs- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.OnConfigFilePathChanged(System.Object,System.EventArgs)')
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

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigFilePath'></a>
### ConfigFilePath `property`

##### Summary

Gets or sets the pathname of the configuration file.

##### Remarks

This property raises the
[](#E-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigFilePathChanged 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePathChanged')
event when its value is updated.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigPathProvider'></a>
### ConfigPathProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IConfigPathProvider](#T-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider')
interface.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets a reference to the instance of the object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface
and which
exposes settings changed by the user in order to modify the
application's behavior.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider')
interface.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Clear'></a>
### Clear() `method`

##### Summary

Resets the configuration to default values.

##### Parameters

This method has no parameters.

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

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-InitializeConfigPathProvider'></a>
### InitializeConfigPathProvider() `method`

##### Summary

Configures settings on the object, which we have as a dependency, that manages
the loading and storing of the pathname of the application configuration file
to/from the system Registry.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads the configuration from the disk.



The
[CurrentConfiguration](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-CurrentConfiguration 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.CurrentConfiguration')
property is then initialized to point to the data that has been loaded.



The value of the
[ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePath')
property is used as the pathname of the file that is to be loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of an application configuration file that is to be loaded.



If this parameter has a blank argument, or the application configuration file
having the specified `pathname` cannot be located on the
disk, then the value of the
[ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePath')
property is used instead. |

##### Remarks

The value of the
[CurrentConfiguration](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-CurrentConfiguration 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.CurrentConfiguration')
property is set to `null` if an error occurs during loading.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-OnConfigFilePathChanged-System-Object,System-EventArgs-'></a>
### OnConfigFilePathChanged(sender,e) `method`

##### Summary

Raises the
[](#E-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigFilePathChanged 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePathChanged')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to the instance of the object that
raised this event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | (Required.) A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains
the event data. |

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
[ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePath')
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
[ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePath')
property. |

##### Remarks

If the
[ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.ConfigFilePath')
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
