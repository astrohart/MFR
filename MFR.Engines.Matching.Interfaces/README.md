<a name='assembly'></a>
# MFR.Engines.Matching.Interfaces

## Contents

- [ITextExpressionMatchingEngine](#T-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine-IsMatch-System-String,System-String,System-String- 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine.IsMatch(System.String,System.String,System.String)')
  - [IsMatch(expression)](#M-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine-IsMatch-MFR-Expressions-Matches-Interfaces-IMatchExpression- 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine.IsMatch(MFR.Expressions.Matches.Interfaces.IMatchExpression)')
- [Resources](#T-MFR-Engines-Matching-Interfaces-Properties-Resources 'MFR.Engines.Matching.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Engines-Matching-Interfaces-Properties-Resources-Culture 'MFR.Engines.Matching.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Matching-Interfaces-Properties-Resources-ResourceManager 'MFR.Engines.Matching.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine'></a>
## ITextExpressionMatchingEngine `type`

##### Namespace

MFR.Engines.Matching.Interfaces

##### Summary

Defines the public-exposed methods and properties of a filename-matcher object.

<a name='M-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine-IsMatch-System-String,System-String,System-String-'></a>
### IsMatch(value,findWhat,replaceWith) `method`

##### Summary

Determines whether a `value` string is a match
against a `findWhat`, according to how the
application is configured.

##### Returns

Returns `true` if the `value` is a
match against the provided `findWhat`;
`false`
if no matches are found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value to check for matches. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the pattern that specifies the search criteria. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data that all instances of
`findWhat` in `value` are to be
replaced with. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
or `findWhat`, are passed blank or
`null` string for values. |

<a name='M-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine-IsMatch-MFR-Expressions-Matches-Interfaces-IMatchExpression-'></a>
### IsMatch(expression) `method`

##### Summary

Determines whether data and a search patterned, bound up together in
the form of the `expression` provided, contain a
data match according to rules specified by the user in the object, a
reference to which is specified in the
[Configuration](#P-MFR-ITextExpressionMatchingEngine-Configuration 'MFR.ITextExpressionMatchingEngine.Configuration')
property.

##### Returns

`true` if more than zero matches are found;
`false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [MFR.Expressions.Matches.Interfaces.IMatchExpression](#T-MFR-Expressions-Matches-Interfaces-IMatchExpression 'MFR.Expressions.Matches.Interfaces.IMatchExpression') | (Required.) Reference to an instance of an object that implements
the [IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression')
interface and whose properties contain the match and pattern data. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `expression`, is
passed a `null` value. |

<a name='T-MFR-Engines-Matching-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Matching.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Matching-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Matching-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
