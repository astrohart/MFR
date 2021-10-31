<a name='assembly'></a>
# MFR.Expressions.Registry.Validators.Interfaces

## Contents

- [IRegQueryExpressionValidator\`1](#T-MFR-Objects-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1 'MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator`1')
  - [Expression](#P-MFR-Objects-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1-Expression 'MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator`1.Expression')
  - [ForRegQueryExpression()](#M-MFR-Objects-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1-ForRegQueryExpression-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression{`0}- 'MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator`1.ForRegQueryExpression(MFR.Expressions.Registry.Interfaces.IRegQueryExpression{`0})')
  - [Validate()](#M-MFR-Objects-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1-Validate 'MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator`1.Validate')
- [Resources](#T-MFR-Objects-Expressions-Registry-Validators-Interfaces-Properties-Resources 'MFR.Expressions.Registry.Validators.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Expressions-Registry-Validators-Interfaces-Properties-Resources-Culture 'MFR.Expressions.Registry.Validators.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Expressions-Registry-Validators-Interfaces-Properties-Resources-ResourceManager 'MFR.Expressions.Registry.Validators.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1'></a>
## IRegQueryExpressionValidator\`1 `type`

##### Namespace

MFR.Expressions.Registry.Validators.Interfaces

##### Summary

Validates instances of objects that implement the
[IRegQueryExpression{T}](#T-MFR-Objects-IRegQueryExpression{T} 'MFR.IRegQueryExpression{T}')
interface.

<a name='P-MFR-Objects-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1-Expression'></a>
### Expression `property`

##### Summary

Gets the instance of the object that implements the
[IRegQueryExpression](#T-MFR-Objects-IRegQueryExpression 'MFR.IRegQueryExpression')
interface
that is being validated.

<a name='M-MFR-Objects-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1-ForRegQueryExpression-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression{`0}-'></a>
### ForRegQueryExpression() `method`

##### Summary

Initializes the value of the
[Expression](#P-MFR-Objects-IRegQueryExpressionValidator-Expression 'MFR.IRegQueryExpressionValidator.Expression')
property to refer to the data that is to be validated.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `expression`, is
passed a `null` value. |

<a name='M-MFR-Objects-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1-Validate'></a>
### Validate() `method`

##### Summary

Validates the data. An exception is thrown if the data is invalid.
No exception means valid.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Expressions-Registry-Validators-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Expressions.Registry.Validators.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Expressions-Registry-Validators-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Expressions-Registry-Validators-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
