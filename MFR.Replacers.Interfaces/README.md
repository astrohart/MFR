<a name='assembly'></a>
# MFR.Replacers.Interfaces

## Contents

- [IStringReplacer](#T-MFR-Replacers-Interfaces-IStringReplacer 'MFR.Replacers.Interfaces.IStringReplacer')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-Interfaces-IStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.Interfaces.IStringReplacer.Replace(System.String,System.String,System.String)')
- [Resources](#T-MFR-Replacers-Interfaces-Properties-Resources 'MFR.Replacers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Replacers-Interfaces-Properties-Resources-Culture 'MFR.Replacers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Replacers-Interfaces-Properties-Resources-ResourceManager 'MFR.Replacers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Replacers-Interfaces-IStringReplacer'></a>
## IStringReplacer `type`

##### Namespace

MFR.Replacers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that
performs replacement on strings, said replacement operation differing
depending on the type of file- or folder-rename operation type being
performed and how the matching is configured.

<a name='M-MFR-Replacers-Interfaces-IStringReplacer-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Default is blank. String containing the new data that
should be substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Replacers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Replacers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Replacers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
