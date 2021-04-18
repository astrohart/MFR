<a name='assembly'></a>
# MFR.Objects.Expressions.Registry.Validators

## Contents

- [RegQueryExpressionValidator\`1](#T-MFR-Objects-Expressions-Registry-Validators-RegQueryExpressionValidator`1 'MFR.Objects.Expressions.Registry.Validators.RegQueryExpressionValidator`1')
  - [#ctor()](#M-MFR-Objects-Expressions-Registry-Validators-RegQueryExpressionValidator`1-#ctor 'MFR.Objects.Expressions.Registry.Validators.RegQueryExpressionValidator`1.#ctor')
  - [Expression](#P-MFR-Objects-Expressions-Registry-Validators-RegQueryExpressionValidator`1-Expression 'MFR.Objects.Expressions.Registry.Validators.RegQueryExpressionValidator`1.Expression')
  - [Instance](#P-MFR-Objects-Expressions-Registry-Validators-RegQueryExpressionValidator`1-Instance 'MFR.Objects.Expressions.Registry.Validators.RegQueryExpressionValidator`1.Instance')
  - [#cctor()](#M-MFR-Objects-Expressions-Registry-Validators-RegQueryExpressionValidator`1-#cctor 'MFR.Objects.Expressions.Registry.Validators.RegQueryExpressionValidator`1.#cctor')
  - [ForRegQueryExpression()](#M-MFR-Objects-Expressions-Registry-Validators-RegQueryExpressionValidator`1-ForRegQueryExpression-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression{`0}- 'MFR.Objects.Expressions.Registry.Validators.RegQueryExpressionValidator`1.ForRegQueryExpression(MFR.Objects.Expressions.Registry.Interfaces.IRegQueryExpression{`0})')
  - [Validate()](#M-MFR-Objects-Expressions-Registry-Validators-RegQueryExpressionValidator`1-Validate 'MFR.Objects.Expressions.Registry.Validators.RegQueryExpressionValidator`1.Validate')
- [Resources](#T-MFR-Objects-Expressions-Registry-Validators-Properties-Resources 'MFR.Objects.Expressions.Registry.Validators.Properties.Resources')
  - [Culture](#P-MFR-Objects-Expressions-Registry-Validators-Properties-Resources-Culture 'MFR.Objects.Expressions.Registry.Validators.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Expressions-Registry-Validators-Properties-Resources-ResourceManager 'MFR.Objects.Expressions.Registry.Validators.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Expressions-Registry-Validators-RegQueryExpressionValidator`1'></a>
## RegQueryExpressionValidator\`1 `type`

##### Namespace

MFR.Objects.Expressions.Registry.Validators

<a name='M-MFR-Objects-Expressions-Registry-Validators-RegQueryExpressionValidator`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Expressions-Registry-Validators-RegQueryExpressionValidator`1-Expression'></a>
### Expression `property`

##### Summary

Gets the instance of the object that implements the
[IRegQueryExpression](#T-MFR-Objects-IRegQueryExpression 'MFR.Objects.IRegQueryExpression')
interface
that is being validated.

<a name='P-MFR-Objects-Expressions-Registry-Validators-RegQueryExpressionValidator`1-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[RegQueryExpressionValidator](#T-MFR-Objects-RegQueryExpressionValidator 'MFR.Objects.RegQueryExpressionValidator').

<a name='M-MFR-Objects-Expressions-Registry-Validators-RegQueryExpressionValidator`1-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Expressions-Registry-Validators-RegQueryExpressionValidator`1-ForRegQueryExpression-MFR-Objects-Expressions-Registry-Interfaces-IRegQueryExpression{`0}-'></a>
### ForRegQueryExpression() `method`

##### Summary

Initializes the value of the
[Expression](#P-MFR-Objects-IRegQueryExpressionValidator-Expression 'MFR.Objects.IRegQueryExpressionValidator.Expression')
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

<a name='M-MFR-Objects-Expressions-Registry-Validators-RegQueryExpressionValidator`1-Validate'></a>
### Validate() `method`

##### Summary

Validates the data. An
[InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException')
is thrown if the data is
invalid. No exception means valid.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the data is not valid. |

<a name='T-MFR-Objects-Expressions-Registry-Validators-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Expressions.Registry.Validators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Expressions-Registry-Validators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Expressions-Registry-Validators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
