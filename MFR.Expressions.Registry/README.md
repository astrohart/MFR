<a name='assembly'></a>
# MFR.Expressions.Registry

## Contents

- [RegQueryExpression\`1](#T-MFR-Objects-Expressions-Registry-RegQueryExpression`1 'MFR.Expressions.Registry.RegQueryExpression`1')
  - [DefaultValue](#P-MFR-Objects-Expressions-Registry-RegQueryExpression`1-DefaultValue 'MFR.Expressions.Registry.RegQueryExpression`1.DefaultValue')
  - [ValueName](#P-MFR-Objects-Expressions-Registry-RegQueryExpression`1-ValueName 'MFR.Expressions.Registry.RegQueryExpression`1.ValueName')
  - [AndValueName(valueName)](#M-MFR-Objects-Expressions-Registry-RegQueryExpression`1-AndValueName-System-String- 'MFR.Expressions.Registry.RegQueryExpression`1.AndValueName(System.String)')
  - [ForKeyPath()](#M-MFR-Objects-Expressions-Registry-RegQueryExpression`1-ForKeyPath-System-String- 'MFR.Expressions.Registry.RegQueryExpression`1.ForKeyPath(System.String)')
  - [WithDefaultValue(defaultValue)](#M-MFR-Objects-Expressions-Registry-RegQueryExpression`1-WithDefaultValue-`0- 'MFR.Expressions.Registry.RegQueryExpression`1.WithDefaultValue(`0)')
- [Resources](#T-MFR-Objects-Expressions-Registry-Properties-Resources 'MFR.Expressions.Registry.Properties.Resources')
  - [Culture](#P-MFR-Objects-Expressions-Registry-Properties-Resources-Culture 'MFR.Expressions.Registry.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Expressions-Registry-Properties-Resources-ResourceManager 'MFR.Expressions.Registry.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Expressions-Registry-RegQueryExpression`1'></a>
## RegQueryExpression\`1 `type`

##### Namespace

MFR.Expressions.Registry

##### Summary

Provides metadata for querying the data stored in a value contained
within a key in the Windows system Registry database.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the data to be accessed. |

<a name='P-MFR-Objects-Expressions-Registry-RegQueryExpression`1-DefaultValue'></a>
### DefaultValue `property`

##### Summary

Gets or sets `T` that is used as the default
value in case data cannot otherwise be accessed from the Registry.

<a name='P-MFR-Objects-Expressions-Registry-RegQueryExpression`1-ValueName'></a>
### ValueName `property`

##### Summary

Gets or sets the name of the value under which data is to be stored
or from which data is to be retrieved.

##### Remarks

Set this property to `null` to retrieve data from, or store
data to, the (Default) value under a particular registry key.

<a name='M-MFR-Objects-Expressions-Registry-RegQueryExpression`1-AndValueName-System-String-'></a>
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

<a name='M-MFR-Objects-Expressions-Registry-RegQueryExpression`1-ForKeyPath-System-String-'></a>
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

<a name='M-MFR-Objects-Expressions-Registry-RegQueryExpression`1-WithDefaultValue-`0-'></a>
### WithDefaultValue(defaultValue) `method`

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
| defaultValue | [\`0](#T-`0 '`0') | (Required.) Instance of `T` that should serve
as the default value to be returned in case no data is found. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `defaultValue`,
is passed `null`. |

##### Remarks

Calling this method is optional.



NOTE: If this method is called, then the value `null` is not
acceptable to be passed for the `defaultValue` parameter.



If `null` is passed, then this method throws
[ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException').

<a name='T-MFR-Objects-Expressions-Registry-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Expressions.Registry.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Expressions-Registry-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Expressions-Registry-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
