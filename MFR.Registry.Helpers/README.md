<a name='assembly'></a>
# MFR.Registry.Helpers

## Contents

- [RegistryHiveExtensions](#T-MFR-Registry-Helpers-RegistryHiveExtensions 'MFR.Registry.Helpers.RegistryHiveExtensions')
  - [HasValueWithName(keyPath,valueName)](#M-MFR-Registry-Helpers-RegistryHiveExtensions-HasValueWithName-System-String,System-String- 'MFR.Registry.Helpers.RegistryHiveExtensions.HasValueWithName(System.String,System.String)')
  - [RemoveHiveName(keyPath)](#M-MFR-Registry-Helpers-RegistryHiveExtensions-RemoveHiveName-System-String- 'MFR.Registry.Helpers.RegistryHiveExtensions.RemoveHiveName(System.String)')
  - [StartsWithValidHiveName(keyPath)](#M-MFR-Registry-Helpers-RegistryHiveExtensions-StartsWithValidHiveName-System-String- 'MFR.Registry.Helpers.RegistryHiveExtensions.StartsWithValidHiveName(System.String)')
  - [ToRegistryHive(hiveName)](#M-MFR-Registry-Helpers-RegistryHiveExtensions-ToRegistryHive-System-String- 'MFR.Registry.Helpers.RegistryHiveExtensions.ToRegistryHive(System.String)')
- [Resources](#T-MFR-Registry-Helpers-Properties-Resources 'MFR.Registry.Helpers.Properties.Resources')
  - [Culture](#P-MFR-Registry-Helpers-Properties-Resources-Culture 'MFR.Registry.Helpers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Registry-Helpers-Properties-Resources-ResourceManager 'MFR.Registry.Helpers.Properties.Resources.ResourceManager')

<a name='T-MFR-Registry-Helpers-RegistryHiveExtensions'></a>
## RegistryHiveExtensions `type`

##### Namespace

MFR.Registry.Helpers

##### Summary

Helper methods for working with
[RegistryHive](#T-Microsoft-Win32-RegistryHive 'Microsoft.Win32.RegistryHive')
enumeration values.

<a name='M-MFR-Registry-Helpers-RegistryHiveExtensions-HasValueWithName-System-String,System-String-'></a>
### HasValueWithName(keyPath,valueName) `method`

##### Summary

Determines whether a value with the specified
`valueName`
exists under the Registry key with the
`keyPath`
given.

##### Returns

`true` if a value with the specified name exists under the
specified Registry key; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Fully-qualified path, including the hive, of the key you
want to access. |
| valueName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Name of the value.



This parameter is required to be non-blank. Normally,
if a blank value is specified for `valueName`, the
(Default) value would be accessed; however, since it's always the
case that such a value exists for every Registry key, this a
non-sequitur to this method. |

<a name='M-MFR-Registry-Helpers-RegistryHiveExtensions-RemoveHiveName-System-String-'></a>
### RemoveHiveName(keyPath) `method`

##### Summary

Attempts to strip the hive name from a path to a Registry key with
the specified `keyPath`.

##### Returns

The Registry key path with the hive name (if present) stripped.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the path to the Registry key that
might contain the name of a hive. |

##### Remarks

If the `keyPath`'s value does not contain
backslashes, is blank, or does not start with 'HKEY', then this
method devolves to the identity map.



The output of this method is also the same as that of the identity
map in the case where an exception is thrown by the system during
the parsing operation.

<a name='M-MFR-Registry-Helpers-RegistryHiveExtensions-StartsWithValidHiveName-System-String-'></a>
### StartsWithValidHiveName(keyPath) `method`

##### Summary

Determines whether the `keyPath` provided starts
with the name of a Registry hive.

##### Returns

`true` if the `keyPath` parameter is passed
the path of a valid Registry key; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of a
Registry key. |

<a name='M-MFR-Registry-Helpers-RegistryHiveExtensions-ToRegistryHive-System-String-'></a>
### ToRegistryHive(hiveName) `method`

##### Summary

Given a string containing the name of a Registry hive (i.e.,
`HKEY_CLASSES_ROOT`), attempts to translate such a string into
one of the [RegistryHive](#T-Microsoft-Win32-RegistryHive 'Microsoft.Win32.RegistryHive') values that
corresponds to it.

##### Returns

The [RegistryHive](#T-Microsoft-Win32-RegistryHive 'Microsoft.Win32.RegistryHive') value that
corresponds to the hive name passed.



If a matching value cannot be found, then
[ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')
is thrown.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hiveName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of a Registry hive. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if `hiveName` is `null`, whitespace,
blank, or not the name of a Registry hive, or contains a
fully-qualified pathname of a subkey. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if none of the [RegistryHive](#T-Microsoft-Win32-RegistryHive 'Microsoft.Win32.RegistryHive')
values corresponds to the value passed in `hiveName`. |

<a name='T-MFR-Registry-Helpers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Registry.Helpers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Registry-Helpers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Registry-Helpers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
