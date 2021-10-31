<a name='assembly'></a>
# MFR.Configuration.Serializers

## Contents

- [ConfigurationSerializer](#T-MFR-Objects-Configuration-Serializers-ConfigurationSerializer 'MFR.Configuration.Serializers.ConfigurationSerializer')
  - [Load(pathname)](#M-MFR-Objects-Configuration-Serializers-ConfigurationSerializer-Load-System-String- 'MFR.Configuration.Serializers.ConfigurationSerializer.Load(System.String)')
  - [Save(pathname,configuration)](#M-MFR-Objects-Configuration-Serializers-ConfigurationSerializer-Save-System-String,MFR-Objects-Configuration-Interfaces-IConfiguration- 'MFR.Configuration.Serializers.ConfigurationSerializer.Save(System.String,MFR.Configuration.Interfaces.IConfiguration)')
- [Resources](#T-MFR-Objects-Configuration-Serializers-Properties-Resources 'MFR.Configuration.Serializers.Properties.Resources')
  - [Culture](#P-MFR-Objects-Configuration-Serializers-Properties-Resources-Culture 'MFR.Configuration.Serializers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Configuration-Serializers-Properties-Resources-ResourceManager 'MFR.Configuration.Serializers.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Configuration-Serializers-ConfigurationSerializer'></a>
## ConfigurationSerializer `type`

##### Namespace

MFR.Configuration.Serializers

##### Summary

Provides helper methods for storing the configuration data to, and
loading it from, a file on the disk.

<a name='M-MFR-Objects-Configuration-Serializers-ConfigurationSerializer-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads the configuration data from the file on the disk that has the
specified `pathname`.

##### Returns

Reference to an instance of an object that implements the
[IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration')
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

<a name='M-MFR-Objects-Configuration-Serializers-ConfigurationSerializer-Save-System-String,MFR-Objects-Configuration-Interfaces-IConfiguration-'></a>
### Save(pathname,configuration) `method`

##### Summary

Saves configuration data to a file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname of the file that the data
is to be saved to. |
| configuration | [MFR.Configuration.Interfaces.IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Configuration.Interfaces.IConfiguration')
interface. |

<a name='T-MFR-Objects-Configuration-Serializers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Configuration.Serializers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Configuration-Serializers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Configuration-Serializers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
