<a name='assembly'></a>
# MFR.Objects.Interop.Factories.Tests

## Contents

- [GetRunningObjectTableTests](#T-MFR-Objects-Interop-Factories-Tests-GetRunningObjectTableTests 'MFR.Objects.Interop.Factories.Tests.GetRunningObjectTableTests')
  - [GetNewBindContext()](#M-MFR-Objects-Interop-Factories-Tests-GetRunningObjectTableTests-GetNewBindContext 'MFR.Objects.Interop.Factories.Tests.GetRunningObjectTableTests.GetNewBindContext')
  - [Test_FromBindContextMethod_Works()](#M-MFR-Objects-Interop-Factories-Tests-GetRunningObjectTableTests-Test_FromBindContextMethod_Works 'MFR.Objects.Interop.Factories.Tests.GetRunningObjectTableTests.Test_FromBindContextMethod_Works')
- [MakeNewBindContextTests](#T-MFR-Objects-Interop-Factories-Tests-MakeNewBindContextTests 'MFR.Objects.Interop.Factories.Tests.MakeNewBindContextTests')
  - [Test_FromScratchMethod_Works()](#M-MFR-Objects-Interop-Factories-Tests-MakeNewBindContextTests-Test_FromScratchMethod_Works 'MFR.Objects.Interop.Factories.Tests.MakeNewBindContextTests.Test_FromScratchMethod_Works')
- [Resources](#T-MFR-Objects-Interop-Factories-Tests-Properties-Resources 'MFR.Objects.Interop.Factories.Tests.Properties.Resources')
  - [Culture](#P-MFR-Objects-Interop-Factories-Tests-Properties-Resources-Culture 'MFR.Objects.Interop.Factories.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Interop-Factories-Tests-Properties-Resources-ResourceManager 'MFR.Objects.Interop.Factories.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Interop-Factories-Tests-GetRunningObjectTableTests'></a>
## GetRunningObjectTableTests `type`

##### Namespace

MFR.Objects.Interop.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[GetRunningObjectTable](#T-MFR-Objects-GetRunningObjectTable 'MFR.Objects.GetRunningObjectTable')
class.

<a name='M-MFR-Objects-Interop-Factories-Tests-GetRunningObjectTableTests-GetNewBindContext'></a>
### GetNewBindContext() `method`

##### Summary

Attempts to instruct the operating system to allocate a new instance
of an object that implements the
[IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')
interface.



If the operation is not successful, assertion exceptions will stop
the unit test that this method is called from.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Interop-Factories-Tests-GetRunningObjectTableTests-Test_FromBindContextMethod_Works'></a>
### Test_FromBindContextMethod_Works() `method`

##### Summary

Asserts the
[FromScratch](#M-MFR-Objects-MakeNewBindContext-FromScratch 'MFR.Objects.MakeNewBindContext.FromScratch')
method returns
a valid object reference.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Interop-Factories-Tests-MakeNewBindContextTests'></a>
## MakeNewBindContextTests `type`

##### Namespace

MFR.Objects.Interop.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[MakeNewBindContext](#T-MFR-Objects-Interop-Factories-MakeNewBindContext 'MFR.Objects.Interop.Factories.MakeNewBindContext')
class.

<a name='M-MFR-Objects-Interop-Factories-Tests-MakeNewBindContextTests-Test_FromScratchMethod_Works'></a>
### Test_FromScratchMethod_Works() `method`

##### Summary

Asserts the
[FromScratch](#M-MFR-Objects-MakeNewBindContext-FromScratch 'MFR.Objects.MakeNewBindContext.FromScratch')
method returns a valid object reference.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Interop-Factories-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Interop.Factories.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Interop-Factories-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Interop-Factories-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
