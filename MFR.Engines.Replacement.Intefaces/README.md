<a name='assembly'></a>
# MFR.Engines.Replacement.Intefaces

## Contents

- [ITextReplacementEngine](#T-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine')
  - [Replace(value,pattern,dest)](#M-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine-Replace-System-String,System-String,System-String- 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine.Replace(System.String,System.String,System.String)')
  - [Replace(expression)](#M-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine-Replace-MFR-Expressions-Matches-Interfaces-IMatchExpression- 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine.Replace(MFR.Expressions.Matches.Interfaces.IMatchExpression)')
- [Resources](#T-MFR-Engines-Replacement-Intefaces-Properties-Resources 'MFR.Engines.Replacement.Intefaces.Properties.Resources')
  - [Culture](#P-MFR-Engines-Replacement-Intefaces-Properties-Resources-Culture 'MFR.Engines.Replacement.Intefaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Replacement-Intefaces-Properties-Resources-ResourceManager 'MFR.Engines.Replacement.Intefaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine'></a>
## ITextReplacementEngine `type`

##### Namespace

MFR.Engines.Replacement.Intefaces

##### Summary

Defines the public-exposed methods and properties of a text-replacement object.

##### Remarks

These objects specify rules as to how to replace text when matches have
already been located.

<a name='M-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine-Replace-System-String,System-String,System-String-'></a>
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
or `pattern`, are passed blank or
`null` string for values. |

<a name='M-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine-Replace-MFR-Expressions-Matches-Interfaces-IMatchExpression-'></a>
### Replace(expression) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `expression`. Returns a string
containing the results.

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [MFR.Expressions.Matches.Interfaces.IMatchExpression](#T-MFR-Expressions-Matches-Interfaces-IMatchExpression 'MFR.Expressions.Matches.Interfaces.IMatchExpression') | (Required.) Reference to an instance of an object that implements
the [IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression')
interface that contains the replacement data. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `expression`, is
passed a `null` value. |

<a name='T-MFR-Engines-Replacement-Intefaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Replacement.Intefaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Replacement-Intefaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Replacement-Intefaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
