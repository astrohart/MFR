<a name='assembly'></a>
# MFR.Settings.Configuration.Serializers

## Contents

- [ConfigurationSerializer](#T-MFR-Settings-Configuration-Serializers-ConfigurationSerializer 'MFR.Settings.Configuration.Serializers.ConfigurationSerializer')
  - [Load(pathname)](#M-MFR-Settings-Configuration-Serializers-ConfigurationSerializer-Load-System-String- 'MFR.Settings.Configuration.Serializers.ConfigurationSerializer.Load(System.String)')
  - [Save(pathname,projectFileRenamerConfiguration)](#M-MFR-Settings-Configuration-Serializers-ConfigurationSerializer-Save-System-String,MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration- 'MFR.Settings.Configuration.Serializers.ConfigurationSerializer.Save(System.String,MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration)')
- [Resources](#T-MFR-Settings-Configuration-Serializers-Properties-Resources 'MFR.Settings.Configuration.Serializers.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Serializers-Properties-Resources-Culture 'MFR.Settings.Configuration.Serializers.Properties.Resources.Culture')
  - [Error_ValueCannotBeNullOrWhiteSpace](#P-MFR-Settings-Configuration-Serializers-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace 'MFR.Settings.Configuration.Serializers.Properties.Resources.Error_ValueCannotBeNullOrWhiteSpace')
  - [ResourceManager](#P-MFR-Settings-Configuration-Serializers-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Serializers.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Serializers-ConfigurationSerializer'></a>
## ConfigurationSerializer `type`

##### Namespace

MFR.Settings.Configuration.Serializers

##### Summary

Provides helper methods for storing the configuration data to, and
loading it from, a file on the disk.

<a name='M-MFR-Settings-Configuration-Serializers-ConfigurationSerializer-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads the configuration data from the file on the disk that has the
specified `pathname`.

##### Returns

Reference to an instance of an object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile')
interface that has been
initialized with the data present in the file; or
`null`
if a problem occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of a
JSON-formatted data file on the disk that contains the configuration data. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `pathname`, is
passed a blank or `null` string for a value. |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the file, the path to which is specified by the
`pathname`
parameter, cannot be located on the disk. |

<a name='M-MFR-Settings-Configuration-Serializers-ConfigurationSerializer-Save-System-String,MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-'></a>
### Save(pathname,projectFileRenamerConfiguration) `method`

##### Summary

Saves projectFileRenamerConfiguration data to a file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname of the file that the data
is to be saved to. |
| projectFileRenamerConfiguration | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface. |

<a name='T-MFR-Settings-Configuration-Serializers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Serializers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Serializers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Serializers-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace'></a>
### Error_ValueCannotBeNullOrWhiteSpace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or whitespace..

<a name='P-MFR-Settings-Configuration-Serializers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
