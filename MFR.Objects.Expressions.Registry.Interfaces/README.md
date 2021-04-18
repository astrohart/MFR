<a name='assembly'></a>
# MFR.Objects.Expressions.Registry.Interfaces

## Contents

- [IRegQueryExpression\`1](#T-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1 'MFR.Objects.Expressions.Registry.Interfaces.IRegQueryExpression`1')
  - [DefaultValue](#P-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1-DefaultValue 'MFR.Objects.Expressions.Registry.Interfaces.IRegQueryExpression`1.DefaultValue')
  - [Hive](#P-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1-Hive 'MFR.Objects.Expressions.Registry.Interfaces.IRegQueryExpression`1.Hive')
  - [KeyPath](#P-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1-KeyPath 'MFR.Objects.Expressions.Registry.Interfaces.IRegQueryExpression`1.KeyPath')
  - [ValueName](#P-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1-ValueName 'MFR.Objects.Expressions.Registry.Interfaces.IRegQueryExpression`1.ValueName')
  - [AndValueName(valueName)](#M-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1-AndValueName-System-String- 'MFR.Objects.Expressions.Registry.Interfaces.IRegQueryExpression`1.AndValueName(System.String)')
  - [ForKeyPath()](#M-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1-ForKeyPath-System-String- 'MFR.Objects.Expressions.Registry.Interfaces.IRegQueryExpression`1.ForKeyPath(System.String)')
  - [WithDefaultValue(defaultValue)](#M-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1-WithDefaultValue-`0- 'MFR.Objects.Expressions.Registry.Interfaces.IRegQueryExpression`1.WithDefaultValue(`0)')
- [Resources](#T-MFR-Objects-Expressions-Registry-Interfaces-Properties-Resources 'MFR.Objects.Expressions.Registry.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Expressions-Registry-Interfaces-Properties-Resources-Culture 'MFR.Objects.Expressions.Registry.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Expressions-Registry-Interfaces-Properties-Resources-ResourceManager 'MFR.Objects.Expressions.Registry.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1'></a>
## IRegQueryExpression\`1 `type`

##### Namespace

MFR.Objects.Expressions.Registry.Interfaces

##### Summary

Defines the public-exposed methods and properties of an object that
contains the metadata for a query of a value in the system Registry.

<a name='P-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1-DefaultValue'></a>
### DefaultValue `property`

##### Summary

Gets or sets `T` that is used as the default
value in case data cannot otherwise be accessed from the Registry.

<a name='P-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1-Hive'></a>
### Hive `property`

##### Summary

Gets the [RegistryHive](#T-Microsoft-Win32-RegistryHive 'Microsoft.Win32.RegistryHive') value that
corresponds to the hive specified by the user, either by default or explicitly.

<a name='P-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1-KeyPath'></a>
### KeyPath `property`

##### Summary

Gets or sets the path to the Registry key under which the desired
data is stored.

##### Remarks

This property should be set to the fully-qualified path of a key
under the `HKEY_CURRENT_USER` hive. Other hives are not supported.

<a name='P-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1-ValueName'></a>
### ValueName `property`

##### Summary

Gets or sets the name of the value under which data is to be stored
or from which data is to be retrieved.

##### Remarks

Set this property to `null` to retrieve data from, or store
data to, the (Default) value under a particular registry key.

<a name='M-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1-AndValueName-System-String-'></a>
### AndValueName(valueName) `method`

##### Summary

Assigns a value to the
[ValueName](#P-MFR-Objects-IRegQueryExpression-ValueName 'MFR.Objects.IRegQueryExpression.ValueName')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new value for the property. |

<a name='M-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1-ForKeyPath-System-String-'></a>
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

<a name='M-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression`1-WithDefaultValue-`0-'></a>
### WithDefaultValue(defaultValue) `method`

##### Summary

Assigns a value to the
[ValueName](#P-MFR-Objects-IRegQueryExpression-ValueName 'MFR.Objects.IRegQueryExpression.ValueName')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| defaultValue | [\`0](#T-`0 '`0') | (Required.) Instance of `T` that should serve
as the default value to be returned in case no data is found. |

##### Remarks

Calling this method is optional.

<a name='T-MFR-Objects-Expressions-Registry-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Expressions.Registry.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Expressions-Registry-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Expressions-Registry-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
