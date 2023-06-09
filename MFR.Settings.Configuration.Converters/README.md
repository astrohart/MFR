<a name='assembly'></a>
# MFR.Settings.Configuration.Converters

## Contents

- [ConvertProfileCollection](#T-MFR-Settings-Configuration-Converters-ConvertProfileCollection 'MFR.Settings.Configuration.Converters.ConvertProfileCollection')
  - [Settings](#F-MFR-Settings-Configuration-Converters-ConvertProfileCollection-Settings 'MFR.Settings.Configuration.Converters.ConvertProfileCollection.Settings')
  - [FromJson(json)](#M-MFR-Settings-Configuration-Converters-ConvertProfileCollection-FromJson-System-String- 'MFR.Settings.Configuration.Converters.ConvertProfileCollection.FromJson(System.String)')
  - [ToJson(collection)](#M-MFR-Settings-Configuration-Converters-ConvertProfileCollection-ToJson-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection- 'MFR.Settings.Configuration.Converters.ConvertProfileCollection.ToJson(MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection)')
- [ConvertProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Converters-ConvertProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Converters.ConvertProjectFileRenamerConfiguration')
  - [Settings](#F-MFR-Settings-Configuration-Converters-ConvertProjectFileRenamerConfiguration-Settings 'MFR.Settings.Configuration.Converters.ConvertProjectFileRenamerConfiguration.Settings')
  - [FromJson(json)](#M-MFR-Settings-Configuration-Converters-ConvertProjectFileRenamerConfiguration-FromJson-System-String- 'MFR.Settings.Configuration.Converters.ConvertProjectFileRenamerConfiguration.FromJson(System.String)')
  - [ToJson(configuration)](#M-MFR-Settings-Configuration-Converters-ConvertProjectFileRenamerConfiguration-ToJson-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration- 'MFR.Settings.Configuration.Converters.ConvertProjectFileRenamerConfiguration.ToJson(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration)')
- [OperationTypeInfoConverter\`1](#T-MFR-Settings-Configuration-Converters-OperationTypeInfoConverter`1 'MFR.Settings.Configuration.Converters.OperationTypeInfoConverter`1')
  - [CanConvert(objectType)](#M-MFR-Settings-Configuration-Converters-OperationTypeInfoConverter`1-CanConvert-System-Type- 'MFR.Settings.Configuration.Converters.OperationTypeInfoConverter`1.CanConvert(System.Type)')
  - [ReadJson(reader,objectType,existingValue,serializer)](#M-MFR-Settings-Configuration-Converters-OperationTypeInfoConverter`1-ReadJson-Newtonsoft-Json-JsonReader,System-Type,System-Object,Newtonsoft-Json-JsonSerializer- 'MFR.Settings.Configuration.Converters.OperationTypeInfoConverter`1.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Object,Newtonsoft.Json.JsonSerializer)')
  - [WriteJson(writer,value,serializer)](#M-MFR-Settings-Configuration-Converters-OperationTypeInfoConverter`1-WriteJson-Newtonsoft-Json-JsonWriter,System-Object,Newtonsoft-Json-JsonSerializer- 'MFR.Settings.Configuration.Converters.OperationTypeInfoConverter`1.WriteJson(Newtonsoft.Json.JsonWriter,System.Object,Newtonsoft.Json.JsonSerializer)')
- [Resources](#T-MFR-Settings-Configuration-Converters-Properties-Resources 'MFR.Settings.Configuration.Converters.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Converters-Properties-Resources-Culture 'MFR.Settings.Configuration.Converters.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Converters-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Converters.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Converters-ConvertProfileCollection'></a>
## ConvertProfileCollection `type`

##### Namespace

MFR.Settings.Configuration.Converters

##### Summary

Converts JSON-formatted text to and from instances of C# objects that
implement the
[IProfileCollection](#T-MFR-Settings-Configuration-Interfaces-IProfileCollection 'MFR.Settings.Configuration.Interfaces.IProfileCollection')
interface.

<a name='F-MFR-Settings-Configuration-Converters-ConvertProfileCollection-Settings'></a>
### Settings `constants`

##### Summary

Obtains a reference to an instance of
[JsonSerializerSettings](#T-Newtonsoft-Json-JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')
that specifies how
to serialize objects to/from JSON.

<a name='M-MFR-Settings-Configuration-Converters-ConvertProfileCollection-FromJson-System-String-'></a>
### FromJson(json) `method`

##### Summary

Converts a string containing JSON-formatted text into an instance of
an object that implements the
[IProfileCollection](#T-MFR-Settings-Configuration-Interfaces-IProfileCollection 'MFR.Settings.Configuration.Interfaces.IProfileCollection')
interface and
returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IProfileCollection](#T-MFR-Settings-Configuration-Interfaces-IProfileCollection 'MFR.Settings.Configuration.Interfaces.IProfileCollection')
interface whose
properties are initialized to the data values read in from the JSON
text, or `null` if a problem occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| json | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the JSON to convert. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `json`, is passed
a blank or `null` string for a value. |

<a name='M-MFR-Settings-Configuration-Converters-ConvertProfileCollection-ToJson-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection-'></a>
### ToJson(collection) `method`

##### Summary

Converts an instance of an object that implements the
[IProfileCollection](#T-MFR-Settings-Configuration-Interfaces-IProfileCollection 'MFR.Settings.Configuration.Interfaces.IProfileCollection')
interface into a
JSON-formatted string and returns the resultant string.

##### Returns

String containing the JSON equivalent of the
`collection`
object fed in.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection') | (Required.) Reference to an instance of an object that implements
the [IProfileCollection](#T-MFR-Settings-Configuration-Interfaces-IProfileCollection 'MFR.Settings.Configuration.Interfaces.IProfileCollection')
interface
that is to be converted into JSON-formatted text. |

##### Remarks

If a `null` reference is passed for the argument of the
`collection` parameter, or if the
deserialization-from-JSON operation fails, then the empty
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') is returned.



The empty [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') is also returned in the event that the
specified `collection` contains zero elements.

<a name='T-MFR-Settings-Configuration-Converters-ConvertProjectFileRenamerConfiguration'></a>
## ConvertProjectFileRenamerConfiguration `type`

##### Namespace

MFR.Settings.Configuration.Converters

##### Summary

Converts JSON-formatted text to and from instances of C# objects that
implement the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface.

<a name='F-MFR-Settings-Configuration-Converters-ConvertProjectFileRenamerConfiguration-Settings'></a>
### Settings `constants`

##### Summary

Obtains a reference to an instance of
[JsonSerializerSettings](#T-Newtonsoft-Json-JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')
that specifies how
to serialize objects to/from JSON.

<a name='M-MFR-Settings-Configuration-Converters-ConvertProjectFileRenamerConfiguration-FromJson-System-String-'></a>
### FromJson(json) `method`

##### Summary

Converts a string containing JSON-formatted text into an instance of
an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface and
returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface whose
properties are initialized to the data values read in from the JSON
text, or `null` if a problem occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| json | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the JSON to convert. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `json`, is passed
a blank or `null` string for a value. |

<a name='M-MFR-Settings-Configuration-Converters-ConvertProjectFileRenamerConfiguration-ToJson-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-'></a>
### ToJson(configuration) `method`

##### Summary

Converts an instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface into a
JSON-formatted string and returns the resultant string.

##### Returns

String containing the JSON equivalent of the
`configuration`
object fed in.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface
that is to be converted into JSON-formatted text. |

##### Remarks

This method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value in the event
that either a `null` reference was passed as the argument of
the `configuration` parameter, or if the deserialization
operation fails.

<a name='T-MFR-Settings-Configuration-Converters-OperationTypeInfoConverter`1'></a>
## OperationTypeInfoConverter\`1 `type`

##### Namespace

MFR.Settings.Configuration.Converters

##### Summary

Converts incoming/outgoing JSON to/from the proper concrete types for
`OperationTypeInfo`s.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of a concrete object that implements the
[IOperationTypeInfo](#T-MFR-GUI-Models-Interfaces-IOperationTypeInfo 'MFR.GUI.Models.Interfaces.IOperationTypeInfo') interface. |

##### Remarks

The type parameter is used here since we are converting properties based on the
[IOperationTypeInfo](#T-MFR-GUI-Models-Interfaces-IOperationTypeInfo 'MFR.GUI.Models.Interfaces.IOperationTypeInfo') interface, and
not any of its concrete types.



Since this class has no way of knowing which of the concrete implementations of
the [IOperationTypeInfo](#T-MFR-GUI-Models-Interfaces-IOperationTypeInfo 'MFR.GUI.Models.Interfaces.IOperationTypeInfo') interface we
will be using, we supply the type parameter in order to let the user of this
class decide for us.

<a name='M-MFR-Settings-Configuration-Converters-OperationTypeInfoConverter`1-CanConvert-System-Type-'></a>
### CanConvert(objectType) `method`

##### Summary

Determines whether this instance can convert the specified object type.

##### Returns

`true` if this instance can convert the specified object type;
otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objectType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the object. |

<a name='M-MFR-Settings-Configuration-Converters-OperationTypeInfoConverter`1-ReadJson-Newtonsoft-Json-JsonReader,System-Type,System-Object,Newtonsoft-Json-JsonSerializer-'></a>
### ReadJson(reader,objectType,existingValue,serializer) `method`

##### Summary

Reads the JSON representation of the object.

##### Returns

The object value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [Newtonsoft.Json.JsonReader](#T-Newtonsoft-Json-JsonReader 'Newtonsoft.Json.JsonReader') | The [JsonReader](#T-Newtonsoft-Json-JsonReader 'Newtonsoft.Json.JsonReader') to read from. |
| objectType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the object. |
| existingValue | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The existing value of object being read. |
| serializer | [Newtonsoft.Json.JsonSerializer](#T-Newtonsoft-Json-JsonSerializer 'Newtonsoft.Json.JsonSerializer') | The calling serializer. |

<a name='M-MFR-Settings-Configuration-Converters-OperationTypeInfoConverter`1-WriteJson-Newtonsoft-Json-JsonWriter,System-Object,Newtonsoft-Json-JsonSerializer-'></a>
### WriteJson(writer,value,serializer) `method`

##### Summary

Writes the JSON representation of the object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| writer | [Newtonsoft.Json.JsonWriter](#T-Newtonsoft-Json-JsonWriter 'Newtonsoft.Json.JsonWriter') | The [JsonWriter](#T-Newtonsoft-Json-JsonWriter 'Newtonsoft.Json.JsonWriter') to write to. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value. |
| serializer | [Newtonsoft.Json.JsonSerializer](#T-Newtonsoft-Json-JsonSerializer 'Newtonsoft.Json.JsonSerializer') | The calling serializer. |

<a name='T-MFR-Settings-Configuration-Converters-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Converters.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Converters-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Converters-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
