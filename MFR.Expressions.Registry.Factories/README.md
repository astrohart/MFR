<a name='assembly'></a>
# MFR.Expressions.Registry.Factories

## Contents

- [MakeNewRegQueryExpression](#T-MFR-Expressions-Registry-Factories-MakeNewRegQueryExpression 'MFR.Expressions.Registry.Factories.MakeNewRegQueryExpression')
  - [FromScatch\`\`1()](#M-MFR-Expressions-Registry-Factories-MakeNewRegQueryExpression-FromScatch``1 'MFR.Expressions.Registry.Factories.MakeNewRegQueryExpression.FromScatch``1')
- [Resources](#T-MFR-Expressions-Registry-Factories-Properties-Resources 'MFR.Expressions.Registry.Factories.Properties.Resources')
  - [Culture](#P-MFR-Expressions-Registry-Factories-Properties-Resources-Culture 'MFR.Expressions.Registry.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Expressions-Registry-Factories-Properties-Resources-ResourceManager 'MFR.Expressions.Registry.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Expressions-Registry-Factories-MakeNewRegQueryExpression'></a>
## MakeNewRegQueryExpression `type`

##### Namespace

MFR.Expressions.Registry.Factories

##### Summary

Creates instances of objects that implement the
[IRegQueryExpression{T}](#T-MFR-IRegQueryExpression{T} 'MFR.IRegQueryExpression{T}')
interface.

<a name='M-MFR-Expressions-Registry-Factories-MakeNewRegQueryExpression-FromScatch``1'></a>
### FromScatch\`\`1() `method`

##### Summary

Creates a new instance of an object that implements the
[IRegQueryExpression{T}](#T-MFR-IRegQueryExpression{T} 'MFR.IRegQueryExpression{T}')
interface
and returns a reference to it.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the class that is the data type of the value to be obtained
from the system Registry. |

##### Remarks

Callers of this method must then invoke the fluent-builder methods
[ForKeyPath](#M-MFR-IRegQueryExpression-ForKeyPath 'MFR.IRegQueryExpression.ForKeyPath')
,
[AndValueName](#M-MFR-IRegQueryExpression-AndValueName 'MFR.IRegQueryExpression.AndValueName')
, and, optionally, the
[WithDefaultValue](#M-MFR-IRegQueryExpression-WithDefaultValue 'MFR.IRegQueryExpression.WithDefaultValue')
(if needed), to set the properties of the resultant object.



NOTE: The object's properties are also publicly-exposed, meaning an
object initializer statement may also be utilized.



Callers are free to pick whichever instantiation method they feel is best.

<a name='T-MFR-Expressions-Registry-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Expressions.Registry.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Expressions-Registry-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Expressions-Registry-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
