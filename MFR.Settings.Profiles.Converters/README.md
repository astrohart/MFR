<a name='assembly'></a>
# MFR.Settings.Profiles.Converters

## Contents

- [ProfileConverter\`1](#T-MFR-Settings-Profiles-Converters-ProfileConverter`1 'MFR.Settings.Profiles.Converters.ProfileConverter`1')
  - [CanConvert(objectType)](#M-MFR-Settings-Profiles-Converters-ProfileConverter`1-CanConvert-System-Type- 'MFR.Settings.Profiles.Converters.ProfileConverter`1.CanConvert(System.Type)')
  - [ReadJson(reader,objectType,existingValue,serializer)](#M-MFR-Settings-Profiles-Converters-ProfileConverter`1-ReadJson-Newtonsoft-Json-JsonReader,System-Type,System-Object,Newtonsoft-Json-JsonSerializer- 'MFR.Settings.Profiles.Converters.ProfileConverter`1.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)')
  - [WriteJson(writer,value,serializer)](#M-MFR-Settings-Profiles-Converters-ProfileConverter`1-WriteJson-Newtonsoft-Json-JsonWriter,System-Object,Newtonsoft-Json-JsonSerializer- 'MFR.Settings.Profiles.Converters.ProfileConverter`1.WriteJson(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.JsonSerializer)')
- [Resources](#T-MFR-Settings-Profiles-Converters-Properties-Resources 'MFR.Settings.Profiles.Converters.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Converters-Properties-Resources-Culture 'MFR.Settings.Profiles.Converters.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Converters-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Converters.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Converters-ProfileConverter`1'></a>
## ProfileConverter\`1 `type`

##### Namespace

MFR.Settings.Profiles.Converters

##### Summary

Converts incoming/outgoing JSON to/from the proper concrete types for
Profiles.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of a concrete object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile') interface. |

##### Remarks

The type parameter is used here since we are converting properties
based on the [IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile') interface, and not any of
its concrete types.



Since this class has no way of knowing which of the concrete implementations of
the [IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile') interface we will be using, we
supply the type parameter in order to let the user of this class decide for us.

<a name='M-MFR-Settings-Profiles-Converters-ProfileConverter`1-CanConvert-System-Type-'></a>
### CanConvert(objectType) `method`

##### Summary

Determines whether this instance can convert the specified object type.

##### Returns

`true` if this instance can convert the specified object type; otherwise,
`false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objectType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type of the object. |

<a name='M-MFR-Settings-Profiles-Converters-ProfileConverter`1-ReadJson-Newtonsoft-Json-JsonReader,System-Type,System-Object,Newtonsoft-Json-JsonSerializer-'></a>
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
| objectType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type of the object. |
| existingValue | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The existing value of object being read. |
| serializer | [Newtonsoft.Json.JsonSerializer](#T-Newtonsoft-Json-JsonSerializer 'Newtonsoft.Json.JsonSerializer') | The calling serializer. |

<a name='M-MFR-Settings-Profiles-Converters-ProfileConverter`1-WriteJson-Newtonsoft-Json-JsonWriter,System-Object,Newtonsoft-Json-JsonSerializer-'></a>
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

<a name='T-MFR-Settings-Profiles-Converters-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Converters.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Converters-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Converters-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
