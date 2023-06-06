<a name='assembly'></a>
# MFR.Expressions.Matches.Factories.Interfaces

## Contents

- [IMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory')
  - [FindWhat](#P-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory-FindWhat 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory.FindWhat')
  - [ReplaceWith](#P-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory-ReplaceWith 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory.ReplaceWith')
  - [Value](#P-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory-Value 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory.Value')
  - [AndReplaceItWith(replaceWith)](#M-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory-AndReplaceItWith-System-String- 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory.AndReplaceItWith(System.String)')
  - [ForTextValue(value)](#M-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory-ForTextValue-System-String- 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory.ForTextValue(System.String)')
  - [ToFindWhat(findWhat)](#M-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory-ToFindWhat-System-String- 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory.ToFindWhat(System.String)')
- [Resources](#T-MFR-Expressions-Matches-Factories-Interfaces-Properties-Resources 'MFR.Expressions.Matches.Factories.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Expressions-Matches-Factories-Interfaces-Properties-Resources-Culture 'MFR.Expressions.Matches.Factories.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Expressions-Matches-Factories-Interfaces-Properties-Resources-ResourceManager 'MFR.Expressions.Matches.Factories.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory'></a>
## IMatchExpressionFactory `type`

##### Namespace

MFR.Expressions.Matches.Factories.Interfaces

##### Summary

Creates instances of objects that implements the
[IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression')
interface for the
various operation types.

##### Remarks

This interface is meant to be implemented by fluent-builder objects
whose behavior is affected by the specific operation type and
projectFileRenamerConfiguration settings.

<a name='P-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets a string containing the pattern to be utilized as
search criteria.

<a name='P-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets a string containing the text that all occurrences of
the pattern in the
[ToFindWhat](#P-MFR-MatchExpressionFactoryBase-ToFindWhat 'MFR.MatchExpressionFactoryBase.ToFindWhat')
property get replaced with in the
[Value](#P-MFR-MatchExpressionFactoryBase-Value 'MFR.MatchExpressionFactoryBase.Value')
property.

<a name='P-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory-Value'></a>
### Value `property`

##### Summary

Gets or sets a string containing the text data to be searched.

<a name='M-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory-AndReplaceItWith-System-String-'></a>
### AndReplaceItWith(replaceWith) `method`

##### Summary

Initializes the value that text matching the pattern specified by
the
[ToFindWhat](#M-MFR-IMatchExpressionFactory-ToFindWhat 'MFR.IMatchExpressionFactory.ToFindWhat')
method will be replaced with.



Whitespace or the empty string is only allowed for the Replace in
Files operation type.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional for Replace in Files only.) String containing the text
that all occurrences of text matching the pattern are to be replaced with. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `replaceWith`, is
passed a blank or `null` string for a value, EXCEPT
for the Replace Text in Files operation type. |

##### Remarks

This method is the final method in the fluent-build chain,
outputting an instance of an object that implements the
[IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression')
interface as a result.



It is required to provide a non-blank, non-whitespace value for
`replaceWith` except for the Replace Text in Files operation.

<a name='M-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory-ForTextValue-System-String-'></a>
### ForTextValue(value) `method`

##### Summary

Sets the text data to be searched for a pattern.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data to be searched for a pattern. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `value`, is
passed a blank or `null` string for a value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `value`, is
passed either the empty or `null` string for a
value. Whitespace is allowed ONLY for the Replace Text in Files
operation type. |

##### Remarks

Among the fluent-builder methods of this class, this one must be
invoked first.



However, prior to even invoking this method, the
[AndAttachConfiguration](#M-MFR-IConfigurationComposedObject-AndAttachConfiguration 'MFR.IConfigurationComposedObject.AndAttachConfiguration')
method must be invoked; otherwise, a
[ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException')
will be thrown. It is incumbent upon invokers of this method to
first weed out any possible elements of the source value set that
may make the `value` parameter get passed a blank string.

<a name='M-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory-ToFindWhat-System-String-'></a>
### ToFindWhat(findWhat) `method`

##### Summary

Initializes the match expression with the pattern to be found in the
value data.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern to search the value data for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `findWhat`, is
passed a blank or `null` string for a value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `findWhat`, is
passed either the empty string or `null` string for
a value. Whitespace is allowed, but ONLY for the Replace Text in
Files operation type. |

##### Remarks

It is recommended to call this method after calling the
[ForTextValue](#M-MFR-IMatchExpressionFactory-ForTextValue 'MFR.IMatchExpressionFactory.ForTextValue')
method.



It is incumbent upon invokers of this method to first weed out any
possible elements of the source value set that may make the
`findWhat` parameter get passed a blank string.

<a name='T-MFR-Expressions-Matches-Factories-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Expressions.Matches.Factories.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Expressions-Matches-Factories-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Expressions-Matches-Factories-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
