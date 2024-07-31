<a name='assembly'></a>
# MFR.Settings.Configuration.Providers

## Contents

- [ProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider')
  - [#ctor()](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-#ctor 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.#ctor')
  - [ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePath')
  - [ConfigPathProvider](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-ConfigPathProvider 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigPathProvider')
  - [CurrentConfiguration](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-CurrentConfiguration 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.CurrentConfiguration')
  - [Instance](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-Instance 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.Instance')
  - [#cctor()](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-#cctor 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.#cctor')
  - [Clear()](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-Clear 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.Clear')
  - [Export(exportFileName)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-Export-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.Export(System.String)')
  - [Import(sourceFilePath)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-Import-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.Import(System.String)')
  - [InitializeConfigPathProvider()](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-InitializeConfigPathProvider 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.InitializeConfigPathProvider')
  - [Load(pathname)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-Load-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.Load(System.String)')
  - [OnConfigFilePathChanged(sender,e)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-OnConfigFilePathChanged-System-Object,System-EventArgs- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.OnConfigFilePathChanged(System.Object,System.EventArgs)')
  - [Save(pathname)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-Save-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.Save(System.String)')
  - [SaveCopyAs(pathname)](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-SaveCopyAs-System-String- 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.SaveCopyAs(System.String)')
- [Resources](#T-MFR-Settings-Configuration-Providers-Properties-Resources 'MFR.Settings.Configuration.Providers.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Providers-Properties-Resources-Culture 'MFR.Settings.Configuration.Providers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Providers-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Providers.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider'></a>
## ProjectFileRenamerConfigProvider `type`

##### Namespace

MFR.Settings.Configuration.Providers

##### Summary

Provides shared functionality for obtaining and storing the path to the
user's config file.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-ConfigFilePath'></a>
### ConfigFilePath `property`

##### Summary

Gets or sets the pathname of the config file.

##### Remarks

This property raises the
[](#E-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-ConfigFilePathChanged 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePathChanged')
event when its value is updated.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-ConfigPathProvider'></a>
### ConfigPathProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IConfigPathProvider](#T-MFR-Paths-Config-Provider-Interfaces-IConfigPathProvider 'MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider')
interface.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets a reference to the instance of the object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface
and which
exposes settings changed by the user in order to modify the
application's behavior.

<a name='P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-Clear'></a>
### Clear() `method`

##### Summary

Resets the config to default values.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-Export-System-String-'></a>
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
[Save](#M-MFR-Settings-ProjectFileRenamerConfigProvider-Save 'MFR.Settings.ProjectFileRenamerConfigProvider.Save')
method with a
value for its pathname parameter.



However, doing this will not save the user's settings to the master
file, which is important enough that we write a special method to
handle this.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-Import-System-String-'></a>
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



Then, the method saves the new data out to the master
config file.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-InitializeConfigPathProvider'></a>
### InitializeConfigPathProvider() `method`

##### Summary

Configures settings on the object, which we have as a dependency, that manages
the loading and storing of the pathname of the application config file
to/from the system Registry.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads the config from the file system.



The
[CurrentConfiguration](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-CurrentConfiguration 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.CurrentConfiguration')
property is then initialized to point to the data that has been loaded.



The value of the
[ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePath')
property is used as the pathname of the file that is to be loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of an application config file that is to be loaded.



If this parameter has a blank argument, or the application config file
having the specified `pathname` cannot be located on the
disk, then the value of the
[ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePath')
property is used instead. |

##### Remarks

The value of the
[CurrentConfiguration](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-CurrentConfiguration 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.CurrentConfiguration')
property is set to `null` if an error occurs during loading.

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-OnConfigFilePathChanged-System-Object,System-EventArgs-'></a>
### OnConfigFilePathChanged(sender,e) `method`

##### Summary

Raises the
[](#E-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-ConfigFilePathChanged 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePathChanged')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to the instance of the object that
raised this event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | (Required.) A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains
the event data. |

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-Save-System-String-'></a>
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
[ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePath')
property. |

<a name='M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-SaveCopyAs-System-String-'></a>
### SaveCopyAs(pathname) `method`

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
[ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePath')
property. |

##### Remarks

If the
[ConfigFilePath](#P-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider-ConfigFilePath 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePath')
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
