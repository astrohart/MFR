<a name='assembly'></a>
# MFR.Expressions.Registry.Validators.Interfaces

## Contents

- [IRegQueryExpressionValidator\`1](#T-MFR-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1 'MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator`1')
  - [Expression](#P-MFR-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1-Expression 'MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator`1.Expression')
  - [ForRegQueryExpression()](#M-MFR-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1-ForRegQueryExpression-MFR-Expressions-Registry-Interfaces-IRegQueryExpression{`0}- 'MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator`1.ForRegQueryExpression(MFR.Expressions.Registry.Interfaces.IRegQueryExpression{`0})')
  - [Validate()](#M-MFR-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1-Validate 'MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator`1.Validate')
- [Resources](#T-MFR-Expressions-Registry-Validators-Interfaces-Properties-Resources 'MFR.Expressions.Registry.Validators.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Expressions-Registry-Validators-Interfaces-Properties-Resources-Culture 'MFR.Expressions.Registry.Validators.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Expressions-Registry-Validators-Interfaces-Properties-Resources-ResourceManager 'MFR.Expressions.Registry.Validators.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1'></a>
## IRegQueryExpressionValidator\`1 `type`

##### Namespace

MFR.Expressions.Registry.Validators.Interfaces

##### Summary

Validates instances of objects that implement the
[IRegQueryExpression{T}](#T-MFR-IRegQueryExpression{T} 'MFR.IRegQueryExpression{T}')
interface.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Name of the data type of the information that
to be accessed. |

<a name='P-MFR-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1-Expression'></a>
### Expression `property`

##### Summary

Gets the instance of the object that implements the
[IRegQueryExpression](#T-MFR-IRegQueryExpression 'MFR.IRegQueryExpression')
interface
that is being validated.

<a name='M-MFR-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1-ForRegQueryExpression-MFR-Expressions-Registry-Interfaces-IRegQueryExpression{`0}-'></a>
### ForRegQueryExpression() `method`

##### Summary

Initializes the value of the
[Expression](#P-MFR-IRegQueryExpressionValidator-Expression 'MFR.IRegQueryExpressionValidator.Expression')
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

<a name='M-MFR-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator`1-Validate'></a>
### Validate() `method`

##### Summary

Validates the data.

##### Returns

`true` if the value of the
[Expression](#P-MFR-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator{T}-Expression 'MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator{T}.Expression')
property is valid; `false` otherwise.

##### Parameters

This method has no parameters.

<a name='T-MFR-Expressions-Registry-Validators-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Expressions.Registry.Validators.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Expressions-Registry-Validators-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Expressions-Registry-Validators-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
