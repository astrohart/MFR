<a name='assembly'></a>
# MFR.Registry.Loaders

## Contents

- [Loader\`1](#T-MFR-Registry-Loaders-Loader`1 'MFR.Registry.Loaders.Loader`1')
  - [FromRegistry(keyName,valueName,defaultValue)](#M-MFR-Registry-Loaders-Loader`1-FromRegistry-System-String,System-String,`0- 'MFR.Registry.Loaders.Loader`1.FromRegistry(System.String,System.String,`0)')
- [Resources](#T-MFR-Registry-Loaders-Properties-Resources 'MFR.Registry.Loaders.Properties.Resources')
  - [Culture](#P-MFR-Registry-Loaders-Properties-Resources-Culture 'MFR.Registry.Loaders.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Registry-Loaders-Properties-Resources-ResourceManager 'MFR.Registry.Loaders.Properties.Resources.ResourceManager')
- [StringLoader](#T-MFR-Registry-Loaders-StringLoader 'MFR.Registry.Loaders.StringLoader')
  - [#ctor()](#M-MFR-Registry-Loaders-StringLoader-#ctor 'MFR.Registry.Loaders.StringLoader.#ctor')
  - [Instance](#P-MFR-Registry-Loaders-StringLoader-Instance 'MFR.Registry.Loaders.StringLoader.Instance')
  - [#cctor()](#M-MFR-Registry-Loaders-StringLoader-#cctor 'MFR.Registry.Loaders.StringLoader.#cctor')
  - [FromRegistry(keyName,valueName,defaultValue)](#M-MFR-Registry-Loaders-StringLoader-FromRegistry-System-String,System-String,System-String- 'MFR.Registry.Loaders.StringLoader.FromRegistry(System.String,System.String,System.String)')

<a name='T-MFR-Registry-Loaders-Loader`1'></a>
## Loader\`1 `type`

##### Namespace

MFR.Registry.Loaders

##### Summary

Defines the events, methods, properties, and behaviors for all loaders of data
from the system Registry.

<a name='M-MFR-Registry-Loaders-Loader`1-FromRegistry-System-String,System-String,`0-'></a>
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
| defaultValue | [\`0](#T-`0 '`0') | (Optional.) Default value to return if the key/value is not found.
This parameter is `null` by default. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `keyName`, is blank. |

<a name='T-MFR-Registry-Loaders-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Registry.Loaders.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Registry-Loaders-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Registry-Loaders-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Registry-Loaders-StringLoader'></a>
## StringLoader `type`

##### Namespace

MFR.Registry.Loaders

##### Summary

Obtains string data from the system Registry.

<a name='M-MFR-Registry-Loaders-StringLoader-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Registry-Loaders-StringLoader-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [StringLoader](#T-MFR-Registry-Loaders-StringLoader 'MFR.Registry.Loaders.StringLoader').

<a name='M-MFR-Registry-Loaders-StringLoader-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Registry-Loaders-StringLoader-FromRegistry-System-String,System-String,System-String-'></a>
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
