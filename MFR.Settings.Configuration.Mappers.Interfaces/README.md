<a name='assembly'></a>
# MFR.Settings.Configuration.Mappers.Interfaces

## Contents

- [IConfigurationStringMapper](#T-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper 'MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper')
  - [ReplaceCRLFWithNewline](#P-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper-ReplaceCRLFWithNewline 'MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper.ReplaceCRLFWithNewline')
  - [Type](#P-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper-Type 'MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper.Type')
  - [Map(input)](#M-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper-Map-System-String- 'MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper.Map(System.String)')
- [Resources](#T-MFR-Settings-Configuration-Mappers-Interfaces-Properties-Resources 'MFR.Settings.Configuration.Mappers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Mappers-Interfaces-Properties-Resources-Culture 'MFR.Settings.Configuration.Mappers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Mappers-Interfaces-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Mappers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper'></a>
## IConfigurationStringMapper `type`

##### Namespace

MFR.Settings.Configuration.Mappers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that carries
out string replacement on configuration setting values as defined in an
internal dictionary.

<a name='P-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper-ReplaceCRLFWithNewline'></a>
### ReplaceCRLFWithNewline `property`

##### Summary

Gets or sets a value that indicates whether this mapper replaces `\r\n`
with `\n` in strings that it receives.

<a name='P-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper-Type'></a>
### Type `property`

##### Summary

One of the
[ConfigurationStringMapperType](#T-MFR-Settings-Configuration-Mappers-Constants-ConfigurationStringMapperType 'MFR.Settings.Configuration.Mappers.Constants.ConfigurationStringMapperType')
enumeration values that defines what type of mapper object this.

<a name='M-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper-Map-System-String-'></a>
### Map(input) `method`

##### Summary

Carries out the replacement as configured.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value containing the replaced values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value to be
mapped. |

<a name='T-MFR-Settings-Configuration-Mappers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Mappers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Mappers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Mappers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
