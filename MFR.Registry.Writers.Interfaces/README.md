<a name='assembly'></a>
# MFR.Registry.Writers.Interfaces

## Contents

- [IStringWriter](#T-MFR-Registry-Writers-Interfaces-IStringWriter 'MFR.Registry.Writers.Interfaces.IStringWriter')
  - [ToRegistry(keyName,valueName,data)](#M-MFR-Registry-Writers-Interfaces-IStringWriter-ToRegistry-System-String,System-String,System-String- 'MFR.Registry.Writers.Interfaces.IStringWriter.ToRegistry(System.String,System.String,System.String)')
- [Resources](#T-MFR-Registry-Writers-Interfaces-Properties-Resources 'MFR.Registry.Writers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Registry-Writers-Interfaces-Properties-Resources-Culture 'MFR.Registry.Writers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Registry-Writers-Interfaces-Properties-Resources-ResourceManager 'MFR.Registry.Writers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Registry-Writers-Interfaces-IStringWriter'></a>
## IStringWriter `type`

##### Namespace

MFR.Registry.Writers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that loads
textual data to the system Registry.

<a name='M-MFR-Registry-Writers-Interfaces-IStringWriter-ToRegistry-System-String,System-String,System-String-'></a>
### ToRegistry(keyName,valueName,data) `method`

##### Summary

Writes a data value to the system Registry key.

##### Returns

Reference to an object containing the value data, or the value of the
`data`
parameter if the value was not found or a
problem occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the subkey under which the
value resides, or is to be written.



If the key does not exist, it will be created. |
| valueName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Name of the Registry value of type `REG_SZ` that
contains the information requested. |
| data | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Value data to be written to the system Registry./// |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `keyName`, is blank. |

<a name='T-MFR-Registry-Writers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Registry.Writers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Registry-Writers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Registry-Writers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
