<a name='assembly'></a>
# MFR.Objects.Engines.Matching.Factories

## Contents

- [GetTextExpressionMatchingEngine](#T-MFR-Objects-Engines-Matching-Factories-GetTextExpressionMatchingEngine 'MFR.Objects.Engines.Matching.Factories.GetTextExpressionMatchingEngine')
  - [For(type)](#M-MFR-Objects-Engines-Matching-Factories-GetTextExpressionMatchingEngine-For-MFR-Objects-Operations-Constants-OperationType- 'MFR.Objects.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For(MFR.Objects.Operations.Constants.OperationType)')
- [Resources](#T-MFR-Objects-Engines-Matching-Factories-Properties-Resources 'MFR.Objects.Engines.Matching.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Engines-Matching-Factories-Properties-Resources-Culture 'MFR.Objects.Engines.Matching.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Engines-Matching-Factories-Properties-Resources-ResourceManager 'MFR.Objects.Engines.Matching.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Engines-Matching-Factories-GetTextExpressionMatchingEngine'></a>
## GetTextExpressionMatchingEngine `type`

##### Namespace

MFR.Objects.Engines.Matching.Factories

##### Summary

Creates instances of objects that implement the
[ITextExpressionMatchingEngine](#T-MFR-Objects-ITextExpressionMatchingEngine 'MFR.Objects.ITextExpressionMatchingEngine')
interface and
returns references to them.

<a name='M-MFR-Objects-Engines-Matching-Factories-GetTextExpressionMatchingEngine-For-MFR-Objects-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates instances of objects that implement the
[ITextExpressionMatchingEngine](#T-MFR-Objects-ITextExpressionMatchingEngine 'MFR.Objects.ITextExpressionMatchingEngine')
interface
and returns references to them.

##### Returns

Reference to an instance of an object that
implements the
[ITextExpressionMatchingEngine](#T-MFR-Objects-ITextExpressionMatchingEngine 'MFR.Objects.ITextExpressionMatchingEngine')
interface
that can tell if data matches a value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Objects.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
specifies the operation currently being performed. |

##### Remarks

After calling this method, callers must
then invoke the fluent
[WithConfiguration](#M-MFR-Objects-ITextExpressionMatchingEngine-WithConfiguration 'MFR.Objects.ITextExpressionMatchingEngine.WithConfiguration')
method on the result of this method in order to attach an object
that implements the
[IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.Objects.IConfiguration')
interface to the
new object instance.

<a name='T-MFR-Objects-Engines-Matching-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Engines.Matching.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Engines-Matching-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Engines-Matching-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
