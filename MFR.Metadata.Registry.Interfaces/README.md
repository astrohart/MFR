<a name='assembly'></a>
# MFR.Metadata.Registry.Interfaces

## Contents

- [IRegOperationMetadata\`1](#T-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1 'MFR.Metadata.Registry.Interfaces.IRegOperationMetadata`1')
  - [Hive](#P-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1-Hive 'MFR.Metadata.Registry.Interfaces.IRegOperationMetadata`1.Hive')
  - [KeyPath](#P-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1-KeyPath 'MFR.Metadata.Registry.Interfaces.IRegOperationMetadata`1.KeyPath')
  - [Value](#P-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1-Value 'MFR.Metadata.Registry.Interfaces.IRegOperationMetadata`1.Value')
  - [ValueName](#P-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1-ValueName 'MFR.Metadata.Registry.Interfaces.IRegOperationMetadata`1.ValueName')
  - [AndValueName(valueName)](#M-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1-AndValueName-System-String- 'MFR.Metadata.Registry.Interfaces.IRegOperationMetadata`1.AndValueName(System.String)')
  - [ForKeyPath()](#M-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1-ForKeyPath-System-String- 'MFR.Metadata.Registry.Interfaces.IRegOperationMetadata`1.ForKeyPath(System.String)')
  - [WithValue(value)](#M-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1-WithValue-`0- 'MFR.Metadata.Registry.Interfaces.IRegOperationMetadata`1.WithValue(`0)')
- [Resources](#T-MFR-Objects-Metadata-Registry-Interfaces-Properties-Resources 'MFR.Metadata.Registry.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Metadata-Registry-Interfaces-Properties-Resources-Culture 'MFR.Metadata.Registry.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Metadata-Registry-Interfaces-Properties-Resources-ResourceManager 'MFR.Metadata.Registry.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1'></a>
## IRegOperationMetadata\`1 `type`

##### Namespace

MFR.Metadata.Registry.Interfaces

##### Summary

Defines the public-exposed methods and properties of an object that
contains the metadata for a write operation to be performed on the
system Registry.

<a name='P-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1-Hive'></a>
### Hive `property`

##### Summary

Gets the [RegistryHive](#T-Microsoft-Win32-RegistryHive 'Microsoft.Win32.RegistryHive') value that
corresponds to the hive specified by the user, either by default or explicitly.

<a name='P-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1-KeyPath'></a>
### KeyPath `property`

##### Summary

Gets or sets the path to the Registry key under which the desired
data is stored.

##### Remarks

This property should be set to the fully-qualified path of a key
under the `HKEY_CURRENT_USER` hive. Other hives are not supported.

<a name='P-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1-Value'></a>
### Value `property`

##### Summary

Gets or sets the instance of `T` that is used
as the data to be written to the system Registry.

<a name='P-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1-ValueName'></a>
### ValueName `property`

##### Summary

Gets or sets the name of the value under which data is to be stored
or from which data is to be retrieved.

##### Remarks

Set this property to `null` to retrieve data from, or store
data to, the (Default) value under a particular registry key.

<a name='M-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1-AndValueName-System-String-'></a>
### AndValueName(valueName) `method`

##### Summary

Assigns a value to the
[ValueName](#P-MFR-Objects-IRegQueryExpression-ValueName 'MFR.IRegQueryExpression.ValueName')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new value for the property. |

<a name='M-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1-ForKeyPath-System-String-'></a>
### ForKeyPath() `method`

##### Summary

Initializes this object with the path to the Registry key you wish
to access.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `keyPath`, is
passed a blank or `null` string for a value. |

##### Remarks

If the hive ( `HKEY_`) is not included, then
`HKEY_CURRENT_USER` is assumed.

<a name='M-MFR-Objects-Metadata-Registry-Interfaces-IRegOperationMetadata`1-WithValue-`0-'></a>
### WithValue(value) `method`

##### Summary

Assigns data to be written to the system Registry to the
[Value](#P-MFR-Objects-IRegOperationMetadata-Value 'MFR.IRegOperationMetadata.Value')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`0](#T-`0 '`0') | (Required.) Instance of `T` that contains the
data to be written to the system Registry. |

##### Remarks

Calling this method is optional.

<a name='T-MFR-Objects-Metadata-Registry-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Metadata.Registry.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Metadata-Registry-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Metadata-Registry-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
