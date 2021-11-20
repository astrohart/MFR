<a name='assembly'></a>
# MFR.Metadata.Registry.Factories

## Contents

- [MakeNewRegOperationMetadata](#T-MFR-Metadata-Registry-Factories-MakeNewRegOperationMetadata 'MFR.Metadata.Registry.Factories.MakeNewRegOperationMetadata')
  - [FromScatch\`\`1()](#M-MFR-Metadata-Registry-Factories-MakeNewRegOperationMetadata-FromScatch``1 'MFR.Metadata.Registry.Factories.MakeNewRegOperationMetadata.FromScatch``1')
- [Resources](#T-MFR-Metadata-Registry-Factories-Properties-Resources 'MFR.Metadata.Registry.Factories.Properties.Resources')
  - [Culture](#P-MFR-Metadata-Registry-Factories-Properties-Resources-Culture 'MFR.Metadata.Registry.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Metadata-Registry-Factories-Properties-Resources-ResourceManager 'MFR.Metadata.Registry.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Metadata-Registry-Factories-MakeNewRegOperationMetadata'></a>
## MakeNewRegOperationMetadata `type`

##### Namespace

MFR.Metadata.Registry.Factories

##### Summary

Creates instances of objects that implement the
[IRegOperationMetadata{T}](#T-MFR-IRegOperationMetadata{T} 'MFR.IRegOperationMetadata{T}')
interface.

<a name='M-MFR-Metadata-Registry-Factories-MakeNewRegOperationMetadata-FromScatch``1'></a>
### FromScatch\`\`1() `method`

##### Summary

Creates a new instance of an object that implements the
[IRegOperationMetadata{T}](#T-MFR-IRegOperationMetadata{T} 'MFR.IRegOperationMetadata{T}')
interface
and returns a reference to it.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the class that is the data type of the value to be obtained
from the system Registry. |

##### Remarks

Callers of this method must then invoke the fluent-builder methods
[ForKeyPath](#M-MFR-IRegOperationMetadata-ForKeyPath 'MFR.IRegOperationMetadata.ForKeyPath')
,
[AndValueName](#M-MFR-IRegOperationMetadata-AndValueName 'MFR.IRegOperationMetadata.AndValueName')
, and, optionally, the
[WithDefaultValue](#M-MFR-IRegOperationMetadata-WithDefaultValue 'MFR.IRegOperationMetadata.WithDefaultValue')
(if needed), to set the properties of the resultant object.



NOTE: The object's properties are also publicly-exposed, meaning an
object initializer statement may also be utilized.



Callers are free to pick whichever instantiation method they feel is best.

<a name='T-MFR-Metadata-Registry-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Metadata.Registry.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Metadata-Registry-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Metadata-Registry-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
