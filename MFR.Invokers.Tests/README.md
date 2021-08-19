<a name='assembly'></a>
# MFR.Objects.Invokers.Tests

## Contents

- [PathFilterInvokerBaseTests](#T-MFR-Objects-Invokers-Tests-PathFilterInvokerBaseTests 'MFR.Objects.Invokers.Tests.PathFilterInvokerBaseTests')
  - [Invoker](#P-MFR-Objects-Invokers-Tests-PathFilterInvokerBaseTests-Invoker 'MFR.Objects.Invokers.Tests.PathFilterInvokerBaseTests.Invoker')
  - [Test_Pass_ReturnsTrue_ForNullPathFilter()](#M-MFR-Objects-Invokers-Tests-PathFilterInvokerBaseTests-Test_Pass_ReturnsTrue_ForNullPathFilter 'MFR.Objects.Invokers.Tests.PathFilterInvokerBaseTests.Test_Pass_ReturnsTrue_ForNullPathFilter')
- [Resources](#T-MFR-Objects-Invokers-Tests-Properties-Resources 'MFR.Objects.Invokers.Tests.Properties.Resources')
  - [Culture](#P-MFR-Objects-Invokers-Tests-Properties-Resources-Culture 'MFR.Objects.Invokers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Invokers-Tests-Properties-Resources-ResourceManager 'MFR.Objects.Invokers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Invokers-Tests-PathFilterInvokerBaseTests'></a>
## PathFilterInvokerBaseTests `type`

##### Namespace

MFR.Objects.Invokers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[PathFilterInvokerBase](#T-MFR-Objects-PathFilterInvokerBase 'MFR.Objects.PathFilterInvokerBase')
class.

<a name='P-MFR-Objects-Invokers-Tests-PathFilterInvokerBaseTests-Invoker'></a>
### Invoker `property`

##### Summary

Reference to an instance of an object that implements the [IPathFilterInvoker](#T-MFR-Objects-Invokers-Interfaces-IPathFilterInvoker 'MFR.Objects.Invokers.Interfaces.IPathFilterInvoker') interface.

<a name='M-MFR-Objects-Invokers-Tests-PathFilterInvokerBaseTests-Test_Pass_ReturnsTrue_ForNullPathFilter'></a>
### Test_Pass_ReturnsTrue_ForNullPathFilter() `method`

##### Summary

Asserts that the
[Passes](#M-MFR-Objects-Invokers-Interfaces-IPathFilterInvoker-Passes 'MFR.Objects.Invokers.Interfaces.IPathFilterInvoker.Passes')
method returns `true` when passed
`null`
for its parameter.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Invokers-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Invokers.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Invokers-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Invokers-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
