<a name='assembly'></a>
# MFR.Registry.Loaders.Interfaces

## Contents

- [IStringLoader](#T-MFR-Registry-Loaders-Interfaces-IStringLoader 'MFR.Registry.Loaders.Interfaces.IStringLoader')
  - [FromRegistry(keyName,valueName,defaultValue)](#M-MFR-Registry-Loaders-Interfaces-IStringLoader-FromRegistry-System-String,System-String,System-String- 'MFR.Registry.Loaders.Interfaces.IStringLoader.FromRegistry(System.String,System.String,System.String)')
- [Resources](#T-MFR-Registry-Loaders-Interfaces-Properties-Resources 'MFR.Registry.Loaders.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Registry-Loaders-Interfaces-Properties-Resources-Culture 'MFR.Registry.Loaders.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Registry-Loaders-Interfaces-Properties-Resources-ResourceManager 'MFR.Registry.Loaders.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Registry-Loaders-Interfaces-IStringLoader'></a>
## IStringLoader `type`

##### Namespace

MFR.Registry.Loaders.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that loads
textual data from the system Registry.

<a name='M-MFR-Registry-Loaders-Interfaces-IStringLoader-FromRegistry-System-String,System-String,System-String-'></a>
### FromRegistry(keyName,valueName,defaultValue) `method`

##### Summary

Obtains a data value from the system Registry key.

##### Returns

Reference to an object containing the value data, or the value of the
`defaultValue`
parameter if the value was not found or a
problem occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the subkey under which the
value resides. |
| valueName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Name of the Registry value of type `REG_SZ` that
contains the information requested. |
| defaultValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Default value to return if the key/value is not found.
This parameter is `null` by default. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `keyName`, is blank. |

<a name='T-MFR-Registry-Loaders-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Registry.Loaders.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Registry-Loaders-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Registry-Loaders-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
