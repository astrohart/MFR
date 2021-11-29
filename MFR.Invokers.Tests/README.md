<a name='assembly'></a>
# MFR.Invokers.Tests

## Contents

- [PathFilterInvokerBaseTests](#T-MFR-Invokers-Tests-PathFilterInvokerBaseTests 'MFR.Invokers.Tests.PathFilterInvokerBaseTests')
  - [Invoker](#P-MFR-Invokers-Tests-PathFilterInvokerBaseTests-Invoker 'MFR.Invokers.Tests.PathFilterInvokerBaseTests.Invoker')
  - [Test_Pass_ReturnsTrue_ForNullPathFilter()](#M-MFR-Invokers-Tests-PathFilterInvokerBaseTests-Test_Pass_ReturnsTrue_ForNullPathFilter 'MFR.Invokers.Tests.PathFilterInvokerBaseTests.Test_Pass_ReturnsTrue_ForNullPathFilter')
- [Resources](#T-MFR-Invokers-Tests-Properties-Resources 'MFR.Invokers.Tests.Properties.Resources')
  - [Culture](#P-MFR-Invokers-Tests-Properties-Resources-Culture 'MFR.Invokers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Invokers-Tests-Properties-Resources-ResourceManager 'MFR.Invokers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Invokers-Tests-PathFilterInvokerBaseTests'></a>
## PathFilterInvokerBaseTests `type`

##### Namespace

MFR.Invokers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[PathFilterInvokerBase](#T-MFR-PathFilterInvokerBase 'MFR.PathFilterInvokerBase')
class.

<a name='P-MFR-Invokers-Tests-PathFilterInvokerBaseTests-Invoker'></a>
### Invoker `property`

##### Summary

Reference to an instance of an object that implements the [IPathFilterInvoker](#T-MFR-Invokers-Interfaces-IPathFilterInvoker 'MFR.Invokers.Interfaces.IPathFilterInvoker') interface.

<a name='M-MFR-Invokers-Tests-PathFilterInvokerBaseTests-Test_Pass_ReturnsTrue_ForNullPathFilter'></a>
### Test_Pass_ReturnsTrue_ForNullPathFilter() `method`

##### Summary

Asserts that the
[Passes](#M-MFR-Invokers-Interfaces-IPathFilterInvoker-Passes 'MFR.Invokers.Interfaces.IPathFilterInvoker.Passes')
method returns `true` when passed
`null`
for its parameter.

##### Parameters

This method has no parameters.

<a name='T-MFR-Invokers-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Invokers.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Invokers-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Invokers-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
