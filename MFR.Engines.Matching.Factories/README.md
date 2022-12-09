<a name='assembly'></a>
# MFR.Engines.Matching.Factories

## Contents

- [GetTextExpressionMatchingEngine](#T-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine 'MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine')
  - [For(type)](#M-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine-For-MFR-Operations-Constants-OperationType- 'MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For(MFR.Operations.Constants.OperationType)')
- [Resources](#T-MFR-Engines-Matching-Factories-Properties-Resources 'MFR.Engines.Matching.Factories.Properties.Resources')
  - [Culture](#P-MFR-Engines-Matching-Factories-Properties-Resources-Culture 'MFR.Engines.Matching.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Matching-Factories-Properties-Resources-ResourceManager 'MFR.Engines.Matching.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine'></a>
## GetTextExpressionMatchingEngine `type`

##### Namespace

MFR.Engines.Matching.Factories

##### Summary

Creates instances of objects that implement the
[ITextExpressionMatchingEngine](#T-MFR-ITextExpressionMatchingEngine 'MFR.ITextExpressionMatchingEngine')
interface and
returns references to them.

<a name='M-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates instances of objects that implement the
[ITextExpressionMatchingEngine](#T-MFR-ITextExpressionMatchingEngine 'MFR.ITextExpressionMatchingEngine')
interface
and returns references to them.

##### Returns

Reference to an instance of an object that
implements the
[ITextExpressionMatchingEngine](#T-MFR-ITextExpressionMatchingEngine 'MFR.ITextExpressionMatchingEngine')
interface
that can tell if data matches a value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-OperationType 'MFR.OperationType')
values that
specifies the operation currently being performed. |

##### Remarks

After calling this method, callers must
then invoke the fluent
[WithConfiguration](#M-MFR-ITextExpressionMatchingEngine-WithConfiguration 'MFR.ITextExpressionMatchingEngine.WithConfiguration')
method on the result of this method in order to attach an object
that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface to the
new object instance.

<a name='T-MFR-Engines-Matching-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Matching.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Matching-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Matching-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
