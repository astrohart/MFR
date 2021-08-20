<a name='assembly'></a>
# MFR.Configuration.Converters

## Contents

- [ConvertConfiguration](#T-MFR-Objects-Configuration-Converters-ConvertConfiguration 'MFR.Configuration.Converters.ConvertConfiguration')
  - [Settings](#F-MFR-Objects-Configuration-Converters-ConvertConfiguration-Settings 'MFR.Configuration.Converters.ConvertConfiguration.Settings')
  - [FromJson(json)](#M-MFR-Objects-Configuration-Converters-ConvertConfiguration-FromJson-System-String- 'MFR.Configuration.Converters.ConvertConfiguration.FromJson(System.String)')
  - [ToJson(configuration)](#M-MFR-Objects-Configuration-Converters-ConvertConfiguration-ToJson-MFR-Objects-Configuration-Interfaces-IConfiguration- 'MFR.Configuration.Converters.ConvertConfiguration.ToJson(MFR.Configuration.Interfaces.IConfiguration)')
- [Resources](#T-MFR-Objects-Configuration-Converters-Properties-Resources 'MFR.Configuration.Converters.Properties.Resources')
  - [Culture](#P-MFR-Objects-Configuration-Converters-Properties-Resources-Culture 'MFR.Configuration.Converters.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Configuration-Converters-Properties-Resources-ResourceManager 'MFR.Configuration.Converters.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Configuration-Converters-ConvertConfiguration'></a>
## ConvertConfiguration `type`

##### Namespace

MFR.Configuration.Converters

##### Summary

Converts JSON-formatted text to and from instances of C# objects that
implement the [IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration')
interface.

<a name='F-MFR-Objects-Configuration-Converters-ConvertConfiguration-Settings'></a>
### Settings `constants`

##### Summary

Obtains a reference to an instance of
[JsonSerializerSettings](#T-Newtonsoft-Json-JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')
that specifies how
to serialize objects to/from JSON.

<a name='M-MFR-Objects-Configuration-Converters-ConvertConfiguration-FromJson-System-String-'></a>
### FromJson(json) `method`

##### Summary

Converts a string containing JSON-formatted text into an instance of
an object that implements the
[IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration')
interface and
returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration')
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

<a name='M-MFR-Objects-Configuration-Converters-ConvertConfiguration-ToJson-MFR-Objects-Configuration-Interfaces-IConfiguration-'></a>
### ToJson(configuration) `method`

##### Summary

Converts an instance of an object that implements the
[IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration')
interface into a
JSON-formatted string and returns the resultant string.

##### Returns

String containing the JSON equivalent of the
`configuration`
object fed in.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [MFR.Configuration.Interfaces.IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Configuration.Interfaces.IConfiguration') | (Required.) Reference to an instance of an object that implements
the [IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration') interface
that is to be converted into JSON-formatted text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `configuration`,
is passed a `null` value. |

<a name='T-MFR-Objects-Configuration-Converters-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Configuration.Converters.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Configuration-Converters-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Configuration-Converters-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
