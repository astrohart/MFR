<a name='assembly'></a>
# MFR.Settings.Configuration.Converters

## Contents

- [ConvertConfiguration](#T-MFR-Settings-Configuration-Converters-ConvertConfiguration 'MFR.Settings.Configuration.Converters.ConvertConfiguration')
  - [Settings](#F-MFR-Settings-Configuration-Converters-ConvertConfiguration-Settings 'MFR.Settings.Configuration.Converters.ConvertConfiguration.Settings')
  - [FromJson(json)](#M-MFR-Settings-Configuration-Converters-ConvertConfiguration-FromJson-System-String- 'MFR.Settings.Configuration.Converters.ConvertConfiguration.FromJson(System.String)')
  - [ToJson(configuration)](#M-MFR-Settings-Configuration-Converters-ConvertConfiguration-ToJson-MFR-Settings-Configuration-Interfaces-IConfiguration- 'MFR.Settings.Configuration.Converters.ConvertConfiguration.ToJson(MFR.Settings.Configuration.Interfaces.IConfiguration)')
- [ConvertProfileCollection](#T-MFR-Settings-Configuration-Converters-ConvertProfileCollection 'MFR.Settings.Configuration.Converters.ConvertProfileCollection')
  - [Settings](#F-MFR-Settings-Configuration-Converters-ConvertProfileCollection-Settings 'MFR.Settings.Configuration.Converters.ConvertProfileCollection.Settings')
  - [FromJson(json)](#M-MFR-Settings-Configuration-Converters-ConvertProfileCollection-FromJson-System-String- 'MFR.Settings.Configuration.Converters.ConvertProfileCollection.FromJson(System.String)')
  - [ToJson(configuration)](#M-MFR-Settings-Configuration-Converters-ConvertProfileCollection-ToJson-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection- 'MFR.Settings.Configuration.Converters.ConvertProfileCollection.ToJson(MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection)')
- [Resources](#T-MFR-Settings-Configuration-Converters-Properties-Resources 'MFR.Settings.Configuration.Converters.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Converters-Properties-Resources-Culture 'MFR.Settings.Configuration.Converters.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Converters-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Converters.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Converters-ConvertConfiguration'></a>
## ConvertConfiguration `type`

##### Namespace

MFR.Settings.Configuration.Converters

##### Summary

Converts JSON-formatted text to and from instances of C# objects that
implement the [IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface.

<a name='F-MFR-Settings-Configuration-Converters-ConvertConfiguration-Settings'></a>
### Settings `constants`

##### Summary

Obtains a reference to an instance of
[JsonSerializerSettings](#T-Newtonsoft-Json-JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')
that specifies how
to serialize objects to/from JSON.

<a name='M-MFR-Settings-Configuration-Converters-ConvertConfiguration-FromJson-System-String-'></a>
### FromJson(json) `method`

##### Summary

Converts a string containing JSON-formatted text into an instance of
an object that implements the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface and
returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
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

<a name='M-MFR-Settings-Configuration-Converters-ConvertConfiguration-ToJson-MFR-Settings-Configuration-Interfaces-IConfiguration-'></a>
### ToJson(configuration) `method`

##### Summary

Converts an instance of an object that implements the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface into a
JSON-formatted string and returns the resultant string.

##### Returns

String containing the JSON equivalent of the
`configuration`
object fed in.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [MFR.Settings.Configuration.Interfaces.IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the [IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration') interface
that is to be converted into JSON-formatted text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `configuration`,
is passed a `null` value. |

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
### ToJson(configuration) `method`

##### Summary

Converts an instance of an object that implements the
[IProfileCollection](#T-MFR-Settings-Configuration-Interfaces-IProfileCollection 'MFR.Settings.Configuration.Interfaces.IProfileCollection')
interface into a
JSON-formatted string and returns the resultant string.

##### Returns

String containing the JSON equivalent of the
`configuration`
object fed in.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection') | (Required.) Reference to an instance of an object that implements
the [IProfileCollection](#T-MFR-Settings-Configuration-Interfaces-IProfileCollection 'MFR.Settings.Configuration.Interfaces.IProfileCollection')
interface
that is to be converted into JSON-formatted text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `configuration`,
is passed a `null` value. |

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
