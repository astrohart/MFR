<a name='assembly'></a>
# MFR.Metadata.Registry

## Contents

- [RegMetadataBase](#T-MFR-Metadata-Registry-RegMetadataBase 'MFR.Metadata.Registry.RegMetadataBase')
  - [_keyPath](#F-MFR-Metadata-Registry-RegMetadataBase-_keyPath 'MFR.Metadata.Registry.RegMetadataBase._keyPath')
  - [Hive](#P-MFR-Metadata-Registry-RegMetadataBase-Hive 'MFR.Metadata.Registry.RegMetadataBase.Hive')
  - [KeyPath](#P-MFR-Metadata-Registry-RegMetadataBase-KeyPath 'MFR.Metadata.Registry.RegMetadataBase.KeyPath')
  - [DetermineRegistryHiveFromKeyPath(keyPath)](#M-MFR-Metadata-Registry-RegMetadataBase-DetermineRegistryHiveFromKeyPath-System-String- 'MFR.Metadata.Registry.RegMetadataBase.DetermineRegistryHiveFromKeyPath(System.String)')
- [RegOperationMetadata\`1](#T-MFR-Metadata-Registry-RegOperationMetadata`1 'MFR.Metadata.Registry.RegOperationMetadata`1')
  - [Value](#P-MFR-Metadata-Registry-RegOperationMetadata`1-Value 'MFR.Metadata.Registry.RegOperationMetadata`1.Value')
  - [ValueName](#P-MFR-Metadata-Registry-RegOperationMetadata`1-ValueName 'MFR.Metadata.Registry.RegOperationMetadata`1.ValueName')
  - [AndValueName(valueName)](#M-MFR-Metadata-Registry-RegOperationMetadata`1-AndValueName-System-String- 'MFR.Metadata.Registry.RegOperationMetadata`1.AndValueName(System.String)')
  - [ForKeyPath()](#M-MFR-Metadata-Registry-RegOperationMetadata`1-ForKeyPath-System-String- 'MFR.Metadata.Registry.RegOperationMetadata`1.ForKeyPath(System.String)')
  - [WithValue(value)](#M-MFR-Metadata-Registry-RegOperationMetadata`1-WithValue-`0- 'MFR.Metadata.Registry.RegOperationMetadata`1.WithValue(`0)')
- [Resources](#T-MFR-Metadata-Registry-Properties-Resources 'MFR.Metadata.Registry.Properties.Resources')
  - [Culture](#P-MFR-Metadata-Registry-Properties-Resources-Culture 'MFR.Metadata.Registry.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Metadata-Registry-Properties-Resources-ResourceManager 'MFR.Metadata.Registry.Properties.Resources.ResourceManager')

<a name='T-MFR-Metadata-Registry-RegMetadataBase'></a>
## RegMetadataBase `type`

##### Namespace

MFR.Metadata.Registry

##### Summary

Base class for the common methods, properties, fields, and events
between implementers of the
[IRegQueryExpression](#T-MFR-IRegQueryExpression 'MFR.IRegQueryExpression')
interface and the
[IRegOperationMetadata](#T-MFR-IRegOperationMetadata 'MFR.IRegOperationMetadata') interface.

<a name='F-MFR-Metadata-Registry-RegMetadataBase-_keyPath'></a>
### _keyPath `constants`

##### Summary

String containing the fully-qualified pathname of a Registry key.

<a name='P-MFR-Metadata-Registry-RegMetadataBase-Hive'></a>
### Hive `property`

##### Summary

Gets the [RegistryHive](#T-Microsoft-Win32-RegistryHive 'Microsoft.Win32.RegistryHive') value that
corresponds to the hive specified by the user, either by default or explicitly.

<a name='P-MFR-Metadata-Registry-RegMetadataBase-KeyPath'></a>
### KeyPath `property`

##### Summary

Gets or sets the path to the Registry key under which the desired
data is stored.

##### Remarks

Whenever the value of this property is updated, the value of the
[Hive](#P-MFR-IRegOperationMetadata-Hive 'MFR.IRegOperationMetadata.Hive')
property is updated to match.

<a name='M-MFR-Metadata-Registry-RegMetadataBase-DetermineRegistryHiveFromKeyPath-System-String-'></a>
### DetermineRegistryHiveFromKeyPath(keyPath) `method`

##### Summary

Attempts to parse the corresponding
[RegistryHive](#T-Microsoft-Win32-RegistryHive 'Microsoft.Win32.RegistryHive')
enumeration value from the
`keyPath` in the string provided.



Sets the value of the
[Hive](#P-MFR-RegQueryExpression-Hive 'MFR.RegQueryExpression.Hive')
property
to the result.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing a fully-qualified pathname to a key in
the system Registry. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if `keyPath` is not a valid key pathname. |

##### Remarks

If the hive name cannot be parsed from `keyPath`,
then the
[Hive](#P-MFR-RegQueryExpression-Hive 'MFR.RegQueryExpression.Hive')
property
is set to [CurrentUser](#T-Microsoft-Win32-RegistryHive-CurrentUser 'Microsoft.Win32.RegistryHive.CurrentUser'),
except in the case where `keyPath` is blank; if
this the case, then this method does nothing.

<a name='T-MFR-Metadata-Registry-RegOperationMetadata`1'></a>
## RegOperationMetadata\`1 `type`

##### Namespace

MFR.Metadata.Registry

##### Summary

Provides metadata for querying the data stored in a value contained
within a key in the Windows system Registry database.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the data to be accessed. |

##### Remarks

You may ask, what is the difference between this and a Registry Query
Expression object?



The difference is in semantics only; the two types of object have exactly the
same structure in terms of methods and properties.



A Registry Operation Metadata object is for
, whereas a
object is for

<a name='P-MFR-Metadata-Registry-RegOperationMetadata`1-Value'></a>
### Value `property`

##### Summary

Gets or sets the instance of `T` that is used
as the data to be written to the system Registry.

<a name='P-MFR-Metadata-Registry-RegOperationMetadata`1-ValueName'></a>
### ValueName `property`

##### Summary

Gets or sets the name of the value under which data is to be stored
or from which data is to be retrieved.

##### Remarks

Set this property to `null` to retrieve data from, or store
data to, the (Default) value under a particular registry key.

<a name='M-MFR-Metadata-Registry-RegOperationMetadata`1-AndValueName-System-String-'></a>
### AndValueName(valueName) `method`

##### Summary

Assigns a value to the
[ValueName](#P-MFR-IRegOperationMetadata-ValueName 'MFR.IRegOperationMetadata.ValueName')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new value for the property. |

<a name='M-MFR-Metadata-Registry-RegOperationMetadata`1-ForKeyPath-System-String-'></a>
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

<a name='M-MFR-Metadata-Registry-RegOperationMetadata`1-WithValue-`0-'></a>
### WithValue(value) `method`

##### Summary

Assigns data to be written to the system Registry to the
[Value](#P-MFR-IRegOperationMetadata-Value 'MFR.IRegOperationMetadata.Value')
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

<a name='T-MFR-Metadata-Registry-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Metadata.Registry.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Metadata-Registry-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Metadata-Registry-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
