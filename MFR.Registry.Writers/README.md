<a name='assembly'></a>
# MFR.Registry.Writers

## Contents

- [Resources](#T-MFR-Registry-Writers-Properties-Resources 'MFR.Registry.Writers.Properties.Resources')
  - [Culture](#P-MFR-Registry-Writers-Properties-Resources-Culture 'MFR.Registry.Writers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Registry-Writers-Properties-Resources-ResourceManager 'MFR.Registry.Writers.Properties.Resources.ResourceManager')
- [StringWriter](#T-MFR-Registry-Writers-StringWriter 'MFR.Registry.Writers.StringWriter')
  - [#ctor()](#M-MFR-Registry-Writers-StringWriter-#ctor 'MFR.Registry.Writers.StringWriter.#ctor')
  - [Instance](#P-MFR-Registry-Writers-StringWriter-Instance 'MFR.Registry.Writers.StringWriter.Instance')
  - [#cctor()](#M-MFR-Registry-Writers-StringWriter-#cctor 'MFR.Registry.Writers.StringWriter.#cctor')
  - [ToRegistry(keyName,valueName,data)](#M-MFR-Registry-Writers-StringWriter-ToRegistry-System-String,System-String,System-String- 'MFR.Registry.Writers.StringWriter.ToRegistry(System.String,System.String,System.String)')
- [Writer\`1](#T-MFR-Registry-Writers-Writer`1 'MFR.Registry.Writers.Writer`1')
  - [ToRegistry(keyName,valueName,data)](#M-MFR-Registry-Writers-Writer`1-ToRegistry-System-String,System-String,`0- 'MFR.Registry.Writers.Writer`1.ToRegistry(System.String,System.String,`0)')

<a name='T-MFR-Registry-Writers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Registry.Writers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Registry-Writers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Registry-Writers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Registry-Writers-StringWriter'></a>
## StringWriter `type`

##### Namespace

MFR.Registry.Writers

##### Summary

Writes string data to the system Registry.

<a name='M-MFR-Registry-Writers-StringWriter-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Registry-Writers-StringWriter-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [StringWriter](#T-MFR-Registry-Writers-StringWriter 'MFR.Registry.Writers.StringWriter').

<a name='M-MFR-Registry-Writers-StringWriter-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Registry-Writers-StringWriter-ToRegistry-System-String,System-String,System-String-'></a>
### ToRegistry(keyName,valueName,data) `method`

##### Summary

Writes a data value to the system Registry key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the subkey under which the
value resides, or is to be written.



If the key does not exist, it will be created. |
| valueName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Name of the Registry value of type `REG_SZ` that
contains the information requested. |
| data | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Value data to be written to the system Registry. |

<a name='T-MFR-Registry-Writers-Writer`1'></a>
## Writer\`1 `type`

##### Namespace

MFR.Registry.Writers

##### Summary

Defines the events, methods, properties, and behaviors for all writers of data
to the system Registry.

<a name='M-MFR-Registry-Writers-Writer`1-ToRegistry-System-String,System-String,`0-'></a>
### ToRegistry(keyName,valueName,data) `method`

##### Summary

Writes a data value to the system Registry key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the subkey under which the
value resides, or is to be written.



If the key does not exist, it will be created. |
| valueName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Name of the Registry value of type `REG_SZ` that
contains the information requested. |
| data | [\`0](#T-`0 '`0') | (Required.) Value data to be written to the system Registry./// |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `keyName`, is blank. |
