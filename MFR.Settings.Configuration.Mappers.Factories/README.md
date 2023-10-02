<a name='assembly'></a>
# MFR.Settings.Configuration.Mappers.Factories

## Contents

- [GetCommitMessageMapper](#T-MFR-Settings-Configuration-Mappers-Factories-GetCommitMessageMapper 'MFR.Settings.Configuration.Mappers.Factories.GetCommitMessageMapper')
  - [SoleInstance()](#M-MFR-Settings-Configuration-Mappers-Factories-GetCommitMessageMapper-SoleInstance 'MFR.Settings.Configuration.Mappers.Factories.GetCommitMessageMapper.SoleInstance')
- [GetConfigurationStringMapper](#T-MFR-Settings-Configuration-Mappers-GetConfigurationStringMapper 'MFR.Settings.Configuration.Mappers.GetConfigurationStringMapper')
  - [OfType(type)](#M-MFR-Settings-Configuration-Mappers-GetConfigurationStringMapper-OfType-MFR-Settings-Configuration-Mappers-Constants-ConfigurationStringMapperType- 'MFR.Settings.Configuration.Mappers.GetConfigurationStringMapper.OfType(MFR.Settings.Configuration.Mappers.Constants.ConfigurationStringMapperType)')
- [Resources](#T-MFR-Settings-Configuration-Mappers-Factories-Properties-Resources 'MFR.Settings.Configuration.Mappers.Factories.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Mappers-Factories-Properties-Resources-Culture 'MFR.Settings.Configuration.Mappers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Mappers-Factories-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Mappers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Mappers-Factories-GetCommitMessageMapper'></a>
## GetCommitMessageMapper `type`

##### Namespace

MFR.Settings.Configuration.Mappers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IConfigurationStringMapper](#T-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper 'MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper')
interface that represents a configuration string mapper object that is meant to
act on replacement parameters that are found in commit messages.

<a name='M-MFR-Settings-Configuration-Mappers-Factories-GetCommitMessageMapper-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IConfigurationStringMapper](#T-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper 'MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IConfigurationStringMapper](#T-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper 'MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper')
interface that represents a configuration string mapper object that is meant to
act on replacement parameters that are found in commit messages.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Mappers-GetConfigurationStringMapper'></a>
## GetConfigurationStringMapper `type`

##### Namespace

MFR.Settings.Configuration.Mappers

##### Summary

Obtains references to instances of objects that implement the
[IConfigurationStringMapper](#T-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper 'MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper')
interface for the various supported
[ConfigurationStringMapperType](#T-MFR-Settings-Configuration-Mappers-Constants-ConfigurationStringMapperType 'MFR.Settings.Configuration.Mappers.Constants.ConfigurationStringMapperType')
enumeration values.

<a name='M-MFR-Settings-Configuration-Mappers-GetConfigurationStringMapper-OfType-MFR-Settings-Configuration-Mappers-Constants-ConfigurationStringMapperType-'></a>
### OfType(type) `method`

##### Summary

Attempts to obtain a reference to an instance of an object that implements the
[IConfigurationStringMapper](#T-MFR-Settings-Configuration-Mappers-Interfaces-IConfigurationStringMapper 'MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper')
interface for the specified `type` of configuration-string
mapper.

##### Returns

If a mapper object of the specified `type` is found,
then a reference to an instance of the object is returned; otherwise, a
`null` reference is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Settings.Configuration.Mappers.Constants.ConfigurationStringMapperType](#T-MFR-Settings-Configuration-Mappers-Constants-ConfigurationStringMapperType 'MFR.Settings.Configuration.Mappers.Constants.ConfigurationStringMapperType') | (Required.) One of the
[ConfigurationStringMapperType](#T-MFR-Settings-Configuration-Mappers-Constants-ConfigurationStringMapperType 'MFR.Settings.Configuration.Mappers.Constants.ConfigurationStringMapperType')
values that indicates the type of mapper you wish to obtain a reference to. |

<a name='T-MFR-Settings-Configuration-Mappers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Mappers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Mappers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Mappers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
