<a name='assembly'></a>
# MFR.Metadata.Registry.Validators

## Contents

- [RegOperationMetadataValidator\`1](#T-MFR-Metadata-Registry-Validators-RegOperationMetadataValidator`1 'MFR.Metadata.Registry.Validators.RegOperationMetadataValidator`1')
  - [#ctor()](#M-MFR-Metadata-Registry-Validators-RegOperationMetadataValidator`1-#ctor 'MFR.Metadata.Registry.Validators.RegOperationMetadataValidator`1.#ctor')
  - [Instance](#P-MFR-Metadata-Registry-Validators-RegOperationMetadataValidator`1-Instance 'MFR.Metadata.Registry.Validators.RegOperationMetadataValidator`1.Instance')
  - [Metadata](#P-MFR-Metadata-Registry-Validators-RegOperationMetadataValidator`1-Metadata 'MFR.Metadata.Registry.Validators.RegOperationMetadataValidator`1.Metadata')
  - [#cctor()](#M-MFR-Metadata-Registry-Validators-RegOperationMetadataValidator`1-#cctor 'MFR.Metadata.Registry.Validators.RegOperationMetadataValidator`1.#cctor')
  - [ForRegOperationMetadata()](#M-MFR-Metadata-Registry-Validators-RegOperationMetadataValidator`1-ForRegOperationMetadata-MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{`0}- 'MFR.Metadata.Registry.Validators.RegOperationMetadataValidator`1.ForRegOperationMetadata(MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{`0})')
  - [Validate()](#M-MFR-Metadata-Registry-Validators-RegOperationMetadataValidator`1-Validate 'MFR.Metadata.Registry.Validators.RegOperationMetadataValidator`1.Validate')
- [Resources](#T-MFR-Metadata-Registry-Validators-Properties-Resources 'MFR.Metadata.Registry.Validators.Properties.Resources')
  - [Culture](#P-MFR-Metadata-Registry-Validators-Properties-Resources-Culture 'MFR.Metadata.Registry.Validators.Properties.Resources.Culture')
  - [Error_MetadataPropertyIsNull](#P-MFR-Metadata-Registry-Validators-Properties-Resources-Error_MetadataPropertyIsNull 'MFR.Metadata.Registry.Validators.Properties.Resources.Error_MetadataPropertyIsNull')
  - [Error_RegistryKeyPathnameBlank](#P-MFR-Metadata-Registry-Validators-Properties-Resources-Error_RegistryKeyPathnameBlank 'MFR.Metadata.Registry.Validators.Properties.Resources.Error_RegistryKeyPathnameBlank')
  - [Error_RegistryKeyPathnameDoesNotStartWithValidHive](#P-MFR-Metadata-Registry-Validators-Properties-Resources-Error_RegistryKeyPathnameDoesNotStartWithValidHive 'MFR.Metadata.Registry.Validators.Properties.Resources.Error_RegistryKeyPathnameDoesNotStartWithValidHive')
  - [ResourceManager](#P-MFR-Metadata-Registry-Validators-Properties-Resources-ResourceManager 'MFR.Metadata.Registry.Validators.Properties.Resources.ResourceManager')

<a name='T-MFR-Metadata-Registry-Validators-RegOperationMetadataValidator`1'></a>
## RegOperationMetadataValidator\`1 `type`

##### Namespace

MFR.Metadata.Registry.Validators

##### Summary

Validates the data in the properties of instances of objects that
implement the
[IRegOperationMetadata{T}](#T-MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{T} 'MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{T}')
interface.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the type of data that is being fetched from, or written to, the
system Registry. |

<a name='M-MFR-Metadata-Registry-Validators-RegOperationMetadataValidator`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Metadata-Registry-Validators-RegOperationMetadataValidator`1-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[RegOperationMetadataValidator](#T-MFR-RegOperationMetadataValidator 'MFR.RegOperationMetadataValidator').

<a name='P-MFR-Metadata-Registry-Validators-RegOperationMetadataValidator`1-Metadata'></a>
### Metadata `property`

##### Summary

Gets the instance of the object that implements the
[IRegOperationMetadata](#T-MFR-IRegOperationMetadata 'MFR.IRegOperationMetadata')
interface that is being validated.

<a name='M-MFR-Metadata-Registry-Validators-RegOperationMetadataValidator`1-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Metadata-Registry-Validators-RegOperationMetadataValidator`1-ForRegOperationMetadata-MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{`0}-'></a>
### ForRegOperationMetadata() `method`

##### Summary

Initializes the value of the
[Metadata](#P-MFR-IRegOperationMetadataValidator-Metadata 'MFR.IRegOperationMetadataValidator.Metadata')
property to refer to the data that is to be validated.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `expression`, is
passed a `null` value. |

<a name='M-MFR-Metadata-Registry-Validators-RegOperationMetadataValidator`1-Validate'></a>
### Validate() `method`

##### Summary

Validates the data.

##### Returns

`true` if the value of the
[Metadata](#P-MFR-Metadata-Registry-Validators-Interfaces-IRegOperationMetadataValidator{T}-Metadata 'MFR.Metadata.Registry.Validators.Interfaces.IRegOperationMetadataValidator{T}.Metadata')
property is valid; `false` otherwise.

##### Parameters

This method has no parameters.

<a name='T-MFR-Metadata-Registry-Validators-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Metadata.Registry.Validators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Metadata-Registry-Validators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Metadata-Registry-Validators-Properties-Resources-Error_MetadataPropertyIsNull'></a>
### Error_MetadataPropertyIsNull `property`

##### Summary

Looks up a localized string similar to Please initialize the value of the Metadata property before calling this method..

<a name='P-MFR-Metadata-Registry-Validators-Properties-Resources-Error_RegistryKeyPathnameBlank'></a>
### Error_RegistryKeyPathnameBlank `property`

##### Summary

Looks up a localized string similar to The specified expression's Registry key path is blank..

<a name='P-MFR-Metadata-Registry-Validators-Properties-Resources-Error_RegistryKeyPathnameDoesNotStartWithValidHive'></a>
### Error_RegistryKeyPathnameDoesNotStartWithValidHive `property`

##### Summary

Looks up a localized string similar to The specified expression's Registry key path must be the fully-qualified path, including the Registry hive (HKEY_CLASSES_ROOT etc)..

<a name='P-MFR-Metadata-Registry-Validators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
