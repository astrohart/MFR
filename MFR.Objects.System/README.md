<a name='assembly'></a>
# MFR.Objects.System

## Contents

- [Resources](#T-MFR-Objects-System-Properties-Resources 'MFR.Objects.System.Properties.Resources')
  - [Culture](#P-MFR-Objects-System-Properties-Resources-Culture 'MFR.Objects.System.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-System-Properties-Resources-ResourceManager 'MFR.Objects.System.Properties.Resources.ResourceManager')
- [SystemPreparer](#T-MFR-Objects-System-SystemPreparer 'MFR.Objects.System.SystemPreparer')
  - [CreateOrOpenConfigFile(folderName,fileName)](#M-MFR-Objects-System-SystemPreparer-CreateOrOpenConfigFile-System-String,System-String- 'MFR.Objects.System.SystemPreparer.CreateOrOpenConfigFile(System.String,System.String)')
  - [GetRegistryString(keyName,valueName,defaultValue)](#M-MFR-Objects-System-SystemPreparer-GetRegistryString-System-String,System-String,System-String- 'MFR.Objects.System.SystemPreparer.GetRegistryString(System.String,System.String,System.String)')
  - [SetRegistryString(keyName,valueName,valueData)](#M-MFR-Objects-System-SystemPreparer-SetRegistryString-System-String,System-String,System-String- 'MFR.Objects.System.SystemPreparer.SetRegistryString(System.String,System.String,System.String)')

<a name='T-MFR-Objects-System-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.System.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-System-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-System-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-System-SystemPreparer'></a>
## SystemPreparer `type`

##### Namespace

MFR.Objects.System

##### Summary

Provides methods that prepare the computer for the use of this application.

<a name='M-MFR-Objects-System-SystemPreparer-CreateOrOpenConfigFile-System-String,System-String-'></a>
### CreateOrOpenConfigFile(folderName,fileName) `method`

##### Summary

Creates a blank config.json file in the specified folder. This
method also attempts to create the folder if it does not already exist.

##### Returns

String containing the fully-qualified pathname to the config.json
file. Blank if a problem occurred (either invalid permissions or
some such.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Path to the folder in which to store the config.json file. |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Filename to use for the config file. Config.json is the
default. If this parameter is specified, it can't be a blank string
and must be a valid filename. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the `folderName` or `fileName` parameters are blank. |

##### Remarks

This method simply returns the fully-qualified path to the
configuration file if it already exists.

<a name='M-MFR-Objects-System-SystemPreparer-GetRegistryString-System-String,System-String,System-String-'></a>
### GetRegistryString(keyName,valueName,defaultValue) `method`

##### Summary

Obtains a string value from the system Registry key.

##### Returns

String containing the value data, or the value of the `defaultValue` parameter if the value was not found or a
problem occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the subkey under which the
value resides. |
| valueName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Name of the Registry value of type `REG_SZ` that
contains the information requested. |
| defaultValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Default value to return if the key/value is not found.
This parameter is blank by default. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `keyName`, is blank. |

<a name='M-MFR-Objects-System-SystemPreparer-SetRegistryString-System-String,System-String,System-String-'></a>
### SetRegistryString(keyName,valueName,valueData) `method`

##### Summary

Writes profile data (i.e., application settings) to the system
Registry.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the path to the subkey. |
| valueName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the Registry value whose
data should be altered. |
| valueData | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the new data for the value. Set to
blank if you want to set the value's new data to be blank. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `keyName`, is blank. |
