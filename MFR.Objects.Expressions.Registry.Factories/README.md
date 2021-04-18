<a name='assembly'></a>
# MFR.Objects.Expressions.Registry.Factories

## Contents

- [MakeNewRegQueryExpression](#T-MFR-Objects-Expressions-Registry-Factories-MakeNewRegQueryExpression 'MFR.Objects.Expressions.Registry.Factories.MakeNewRegQueryExpression')
  - [FromScatch\`\`1()](#M-MFR-Objects-Expressions-Registry-Factories-MakeNewRegQueryExpression-FromScatch``1 'MFR.Objects.Expressions.Registry.Factories.MakeNewRegQueryExpression.FromScatch``1')
- [Resources](#T-MFR-Objects-Expressions-Registry-Factories-Properties-Resources 'MFR.Objects.Expressions.Registry.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Expressions-Registry-Factories-Properties-Resources-Culture 'MFR.Objects.Expressions.Registry.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Expressions-Registry-Factories-Properties-Resources-ResourceManager 'MFR.Objects.Expressions.Registry.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Expressions-Registry-Factories-MakeNewRegQueryExpression'></a>
## MakeNewRegQueryExpression `type`

##### Namespace

MFR.Objects.Expressions.Registry.Factories

##### Summary

Creates instances of objects that implement the
[IRegQueryExpression{T}](#T-MFR-Objects-IRegQueryExpression{T} 'MFR.Objects.IRegQueryExpression{T}')
interface.

<a name='M-MFR-Objects-Expressions-Registry-Factories-MakeNewRegQueryExpression-FromScatch``1'></a>
### FromScatch\`\`1() `method`

##### Summary

Creates a new instance of an object that implements the
[IRegQueryExpression{T}](#T-MFR-Objects-IRegQueryExpression{T} 'MFR.Objects.IRegQueryExpression{T}')
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
[ForKeyPath](#M-MFR-Objects-IRegQueryExpression-ForKeyPath 'MFR.Objects.IRegQueryExpression.ForKeyPath')
,
[AndValueName](#M-MFR-Objects-IRegQueryExpression-AndValueName 'MFR.Objects.IRegQueryExpression.AndValueName')
, and, optionally, the
[WithDefaultValue](#M-MFR-Objects-IRegQueryExpression-WithDefaultValue 'MFR.Objects.IRegQueryExpression.WithDefaultValue')
(if needed), to set the properties of the resultant object.



NOTE: The object's properties are also publicly-exposed, meaning an
object initializer statement may also be utilized.



Callers are free to pick whichever instantiation method they feel is best.

<a name='T-MFR-Objects-Expressions-Registry-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Expressions.Registry.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Expressions-Registry-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Expressions-Registry-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
