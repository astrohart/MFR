<a name='assembly'></a>
# MFR.Settings.Configuration.Mappers

## Contents

- [CommitMessageMapper](#T-MFR-Settings-Configuration-Mappers-CommitMessageMapper 'MFR.Settings.Configuration.Mappers.CommitMessageMapper')
  - [#ctor()](#M-MFR-Settings-Configuration-Mappers-CommitMessageMapper-#ctor 'MFR.Settings.Configuration.Mappers.CommitMessageMapper.#ctor')
  - [Instance](#P-MFR-Settings-Configuration-Mappers-CommitMessageMapper-Instance 'MFR.Settings.Configuration.Mappers.CommitMessageMapper.Instance')
  - [ReplaceCRLFWithNewline](#P-MFR-Settings-Configuration-Mappers-CommitMessageMapper-ReplaceCRLFWithNewline 'MFR.Settings.Configuration.Mappers.CommitMessageMapper.ReplaceCRLFWithNewline')
  - [Type](#P-MFR-Settings-Configuration-Mappers-CommitMessageMapper-Type 'MFR.Settings.Configuration.Mappers.CommitMessageMapper.Type')
  - [#cctor()](#M-MFR-Settings-Configuration-Mappers-CommitMessageMapper-#cctor 'MFR.Settings.Configuration.Mappers.CommitMessageMapper.#cctor')
  - [OnInitializeMapping()](#M-MFR-Settings-Configuration-Mappers-CommitMessageMapper-OnInitializeMapping 'MFR.Settings.Configuration.Mappers.CommitMessageMapper.OnInitializeMapping')
- [MapperBase](#T-MFR-Settings-Configuration-Mappers-MapperBase 'MFR.Settings.Configuration.Mappers.MapperBase')
  - [#ctor()](#M-MFR-Settings-Configuration-Mappers-MapperBase-#ctor 'MFR.Settings.Configuration.Mappers.MapperBase.#ctor')
  - [InternalMappingDictionary](#P-MFR-Settings-Configuration-Mappers-MapperBase-InternalMappingDictionary 'MFR.Settings.Configuration.Mappers.MapperBase.InternalMappingDictionary')
  - [ReplaceCRLFWithNewline](#P-MFR-Settings-Configuration-Mappers-MapperBase-ReplaceCRLFWithNewline 'MFR.Settings.Configuration.Mappers.MapperBase.ReplaceCRLFWithNewline')
  - [Type](#P-MFR-Settings-Configuration-Mappers-MapperBase-Type 'MFR.Settings.Configuration.Mappers.MapperBase.Type')
  - [#cctor()](#M-MFR-Settings-Configuration-Mappers-MapperBase-#cctor 'MFR.Settings.Configuration.Mappers.MapperBase.#cctor')
  - [InitializeMappingDictionary()](#M-MFR-Settings-Configuration-Mappers-MapperBase-InitializeMappingDictionary 'MFR.Settings.Configuration.Mappers.MapperBase.InitializeMappingDictionary')
  - [Map(input)](#M-MFR-Settings-Configuration-Mappers-MapperBase-Map-System-String- 'MFR.Settings.Configuration.Mappers.MapperBase.Map(System.String)')
  - [OnInitializeMapping()](#M-MFR-Settings-Configuration-Mappers-MapperBase-OnInitializeMapping 'MFR.Settings.Configuration.Mappers.MapperBase.OnInitializeMapping')
- [Resources](#T-MFR-Settings-Configuration-Mappers-Properties-Resources 'MFR.Settings.Configuration.Mappers.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Mappers-Properties-Resources-Culture 'MFR.Settings.Configuration.Mappers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Mappers-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Mappers.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Mappers-CommitMessageMapper'></a>
## CommitMessageMapper `type`

##### Namespace

MFR.Settings.Configuration.Mappers

##### Summary

Maps values that are user-configured for replacement parameters in a default
commit message to format specifiers for the actual message value.

<a name='M-MFR-Settings-Configuration-Mappers-CommitMessageMapper-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Configuration-Mappers-CommitMessageMapper-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IConfigurationStringMapper](#T-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper 'MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper')
interface that represents a configuration string mapper object that is meant to
act on replacement parameters that are found in detailed commit messages.

<a name='P-MFR-Settings-Configuration-Mappers-CommitMessageMapper-ReplaceCRLFWithNewline'></a>
### ReplaceCRLFWithNewline `property`

##### Summary

Gets or sets a value that indicates whether this mapper replaces `\r\n`
with `\n` in strings that it receives.

<a name='P-MFR-Settings-Configuration-Mappers-CommitMessageMapper-Type'></a>
### Type `property`

##### Summary

One of the
[ConfigurationStringMapperType](#T-MFR-Settings-Configuration-Mappers-Constants-ConfigurationStringMapperType 'MFR.Settings.Configuration.Mappers.Constants.ConfigurationStringMapperType')
enumeration values that defines what type of mapper object this.

<a name='M-MFR-Settings-Configuration-Mappers-CommitMessageMapper-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Mappers-CommitMessageMapper-OnInitializeMapping'></a>
### OnInitializeMapping() `method`

##### Summary

Called to initialize the mapping dictionary for the replacement parameters.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Mappers-MapperBase'></a>
## MapperBase `type`

##### Namespace

MFR.Settings.Configuration.Mappers

##### Summary

Defines the events, methods, properties, and behaviors for all
configuration-string mapper classes.

<a name='M-MFR-Settings-Configuration-Mappers-MapperBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[MapperBase](#T-MFR-Settings-Configuration-Mappers-MapperBase 'MFR.Settings.Configuration.Mappers.MapperBase') and returns a
reference to it.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor is marked `protected`
due to the
fact that this class is marked `abstract`.

<a name='P-MFR-Settings-Configuration-Mappers-MapperBase-InternalMappingDictionary'></a>
### InternalMappingDictionary `property`

##### Summary

Gets a reference to the replacement dictionary to be used for mapping.

<a name='P-MFR-Settings-Configuration-Mappers-MapperBase-ReplaceCRLFWithNewline'></a>
### ReplaceCRLFWithNewline `property`

##### Summary

Gets or sets a value that indicates whether this mapper replaces `\r\n`
with `\n` in strings that it receives.

<a name='P-MFR-Settings-Configuration-Mappers-MapperBase-Type'></a>
### Type `property`

##### Summary

One of the
[ConfigurationStringMapperType](#T-MFR-Settings-Configuration-Mappers-Constants-ConfigurationStringMapperType 'MFR.Settings.Configuration.Mappers.Constants.ConfigurationStringMapperType')
enumeration values that defines what type of mapper object this.

<a name='M-MFR-Settings-Configuration-Mappers-MapperBase-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [MapperBase](#T-MFR-Settings-Configuration-Mappers-MapperBase 'MFR.Settings.Configuration.Mappers.MapperBase') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-Settings-Configuration-Mappers-MapperBase-InitializeMappingDictionary'></a>
### InitializeMappingDictionary() `method`

##### Summary

Called to initialize the mapping dictionary for the replacement parameters.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Mappers-MapperBase-Map-System-String-'></a>
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

<a name='M-MFR-Settings-Configuration-Mappers-MapperBase-OnInitializeMapping'></a>
### OnInitializeMapping() `method`

##### Summary

Called to initialize the mapping dictionary for the replacement parameters.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Mappers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Mappers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Mappers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Mappers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
