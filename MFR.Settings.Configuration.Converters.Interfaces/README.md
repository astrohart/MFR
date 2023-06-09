<a name='assembly'></a>
# MFR.Settings.Configuration.Converters.Interfaces

## Contents

- [IOperationTypeInfoConverter](#T-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter 'MFR.Settings.Configuration.Converters.Interfaces.IOperationTypeInfoConverter')
  - [CanRead](#P-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter-CanRead 'MFR.Settings.Configuration.Converters.Interfaces.IOperationTypeInfoConverter.CanRead')
  - [CanWrite](#P-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter-CanWrite 'MFR.Settings.Configuration.Converters.Interfaces.IOperationTypeInfoConverter.CanWrite')
  - [CanConvert(objectType)](#M-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter-CanConvert-System-Type- 'MFR.Settings.Configuration.Converters.Interfaces.IOperationTypeInfoConverter.CanConvert(System.Type)')
  - [ReadJson(reader,objectType,existingValue,serializer)](#M-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter-ReadJson-Newtonsoft-Json-JsonReader,System-Type,System-Object,Newtonsoft-Json-JsonSerializer- 'MFR.Settings.Configuration.Converters.Interfaces.IOperationTypeInfoConverter.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)')
  - [WriteJson(writer,value,serializer)](#M-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter-WriteJson-Newtonsoft-Json-JsonWriter,System-Object,Newtonsoft-Json-JsonSerializer- 'MFR.Settings.Configuration.Converters.Interfaces.IOperationTypeInfoConverter.WriteJson(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.JsonSerializer)')
- [Resources](#T-MFR-Settings-Configuration-Converters-Interfaces-Properties-Resources 'MFR.Settings.Configuration.Converters.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Converters-Interfaces-Properties-Resources-Culture 'MFR.Settings.Configuration.Converters.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Converters-Interfaces-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Converters.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter'></a>
## IOperationTypeInfoConverter `type`

##### Namespace

MFR.Settings.Configuration.Converters.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that converts instances of objects implementing the [IOperationTypeInfo](#T-MFR-GUI-Models-Interfaces-IOperationTypeInfo 'MFR.GUI.Models.Interfaces.IOperationTypeInfo') interface to and from JSON.

<a name='P-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter-CanRead'></a>
### CanRead `property`

##### Summary

Gets a value indicating whether values can be read from JSON.

<a name='P-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter-CanWrite'></a>
### CanWrite `property`

##### Summary

Gets a value indicating whether values can be written to JSON.

<a name='M-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter-CanConvert-System-Type-'></a>
### CanConvert(objectType) `method`

##### Summary

Determines whether this instance can convert the specified object type.

##### Returns

`true` if this instance can convert the specified object type; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objectType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the object. |

<a name='M-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter-ReadJson-Newtonsoft-Json-JsonReader,System-Type,System-Object,Newtonsoft-Json-JsonSerializer-'></a>
### ReadJson(reader,objectType,existingValue,serializer) `method`

##### Summary

Reads the JSON representation of the object.

##### Returns

The object value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [Newtonsoft.Json.JsonReader](#T-Newtonsoft-Json-JsonReader 'Newtonsoft.Json.JsonReader') | The [JsonReader](#T-Newtonsoft-Json-JsonReader 'Newtonsoft.Json.JsonReader') to read
from. |
| objectType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the object. |
| existingValue | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The existing value of object being read. |
| serializer | [Newtonsoft.Json.JsonSerializer](#T-Newtonsoft-Json-JsonSerializer 'Newtonsoft.Json.JsonSerializer') | The calling serializer. |

<a name='M-MFR-Settings-Configuration-Converters-Interfaces-IOperationTypeInfoConverter-WriteJson-Newtonsoft-Json-JsonWriter,System-Object,Newtonsoft-Json-JsonSerializer-'></a>
### WriteJson(writer,value,serializer) `method`

##### Summary

Writes the JSON representation of the object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| writer | [Newtonsoft.Json.JsonWriter](#T-Newtonsoft-Json-JsonWriter 'Newtonsoft.Json.JsonWriter') | The [JsonWriter](#T-Newtonsoft-Json-JsonWriter 'Newtonsoft.Json.JsonWriter') to write
to. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value. |
| serializer | [Newtonsoft.Json.JsonSerializer](#T-Newtonsoft-Json-JsonSerializer 'Newtonsoft.Json.JsonSerializer') | The calling serializer. |

<a name='T-MFR-Settings-Configuration-Converters-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Converters.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Converters-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Converters-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
