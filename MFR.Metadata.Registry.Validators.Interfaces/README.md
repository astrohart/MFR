<a name='assembly'></a>
# MFR.Metadata.Registry.Validators.Interfaces

## Contents

- [IRegOperationMetadataValidator\`1](#T-MFR-Metadata-Registry-Validators-Interfaces-IRegOperationMetadataValidator`1 'MFR.Metadata.Registry.Validators.Interfaces.IRegOperationMetadataValidator`1')
  - [Metadata](#P-MFR-Metadata-Registry-Validators-Interfaces-IRegOperationMetadataValidator`1-Metadata 'MFR.Metadata.Registry.Validators.Interfaces.IRegOperationMetadataValidator`1.Metadata')
  - [ForRegOperationMetadata()](#M-MFR-Metadata-Registry-Validators-Interfaces-IRegOperationMetadataValidator`1-ForRegOperationMetadata-MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{`0}- 'MFR.Metadata.Registry.Validators.Interfaces.IRegOperationMetadataValidator`1.ForRegOperationMetadata(MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{`0})')
  - [Validate()](#M-MFR-Metadata-Registry-Validators-Interfaces-IRegOperationMetadataValidator`1-Validate 'MFR.Metadata.Registry.Validators.Interfaces.IRegOperationMetadataValidator`1.Validate')
- [Resources](#T-MFR-Metadata-Registry-Validators-Interfaces-Properties-Resources 'MFR.Metadata.Registry.Validators.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Metadata-Registry-Validators-Interfaces-Properties-Resources-Culture 'MFR.Metadata.Registry.Validators.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Metadata-Registry-Validators-Interfaces-Properties-Resources-ResourceManager 'MFR.Metadata.Registry.Validators.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Metadata-Registry-Validators-Interfaces-IRegOperationMetadataValidator`1'></a>
## IRegOperationMetadataValidator\`1 `type`

##### Namespace

MFR.Metadata.Registry.Validators.Interfaces

##### Summary

Validates instances of objects that implement the
[IRegOperationMetadata{T}](#T-MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{T} 'MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{T}')
interface.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Name of the data type of the information that
to be accessed. |

<a name='P-MFR-Metadata-Registry-Validators-Interfaces-IRegOperationMetadataValidator`1-Metadata'></a>
### Metadata `property`

##### Summary

Gets the instance of the object that implements the
[IRegOperationMetadata](#T-MFR-IRegOperationMetadata 'MFR.IRegOperationMetadata')
interface
that is being validated.

<a name='M-MFR-Metadata-Registry-Validators-Interfaces-IRegOperationMetadataValidator`1-ForRegOperationMetadata-MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{`0}-'></a>
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

<a name='M-MFR-Metadata-Registry-Validators-Interfaces-IRegOperationMetadataValidator`1-Validate'></a>
### Validate() `method`

##### Summary

Validates the data.

##### Returns

`true` if the value of the
[Metadata](#P-MFR-Expressions-Registry-Validators-Interfaces-IRegOperationMetadataValidator{T}-Metadata 'MFR.Expressions.Registry.Validators.Interfaces.IRegOperationMetadataValidator{T}.Metadata')
property is valid; `false` otherwise.

##### Parameters

This method has no parameters.

<a name='T-MFR-Metadata-Registry-Validators-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Metadata.Registry.Validators.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Metadata-Registry-Validators-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Metadata-Registry-Validators-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
