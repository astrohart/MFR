<a name='assembly'></a>
# MFR.Objects.Interop.Factories

## Contents

- [GetRunningObjectTable](#T-MFR-Objects-Interop-Factories-GetRunningObjectTable 'MFR.Objects.Interop.Factories.GetRunningObjectTable')
  - [FromBindContext(ctx)](#M-MFR-Objects-Interop-Factories-GetRunningObjectTable-FromBindContext-System-Runtime-InteropServices-ComTypes-IBindCtx- 'MFR.Objects.Interop.Factories.GetRunningObjectTable.FromBindContext(System.Runtime.InteropServices.ComTypes.IBindCtx)')
- [MakeNewBindContext](#T-MFR-Objects-Interop-Factories-MakeNewBindContext 'MFR.Objects.Interop.Factories.MakeNewBindContext')
  - [FromScratch()](#M-MFR-Objects-Interop-Factories-MakeNewBindContext-FromScratch 'MFR.Objects.Interop.Factories.MakeNewBindContext.FromScratch')
- [MakeNewEnumMoniker](#T-MFR-Objects-Interop-Factories-MakeNewEnumMoniker 'MFR.Objects.Interop.Factories.MakeNewEnumMoniker')
  - [From(runningObjectTable)](#M-MFR-Objects-Interop-Factories-MakeNewEnumMoniker-From-System-Runtime-InteropServices-ComTypes-IRunningObjectTable- 'MFR.Objects.Interop.Factories.MakeNewEnumMoniker.From(System.Runtime.InteropServices.ComTypes.IRunningObjectTable)')
- [Resources](#T-MFR-Objects-Interop-Factories-Properties-Resources 'MFR.Objects.Interop.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Interop-Factories-Properties-Resources-Culture 'MFR.Objects.Interop.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Interop-Factories-Properties-Resources-ResourceManager 'MFR.Objects.Interop.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Interop-Factories-GetRunningObjectTable'></a>
## GetRunningObjectTable `type`

##### Namespace

MFR.Objects.Interop.Factories

##### Summary

Contains methods that instruct the operating system to provide us with
access to the instance of the Running Object Table (ROT) on the local
workstation.

<a name='M-MFR-Objects-Interop-Factories-GetRunningObjectTable-FromBindContext-System-Runtime-InteropServices-ComTypes-IBindCtx-'></a>
### FromBindContext(ctx) `method`

##### Summary

Instructs the operating system to provide a reference to an instance
of an object that implements the
[IRunningObjectTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IRunningObjectTable 'System.Runtime.InteropServices.ComTypes.IRunningObjectTable')
interface.



Such an object provides access to the local table of OLE objects
that are currently running on the local workstation.

##### Returns

Reference to an instance of an object that implements the
[IRunningObjectTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IRunningObjectTable 'System.Runtime.InteropServices.ComTypes.IRunningObjectTable')
interface that represents the local running object table.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ctx | [System.Runtime.InteropServices.ComTypes.IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx') | (Required.) Reference to an instance of an object that implements
the [IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `ctx`, is passed
a `null` value. |

##### Remarks

There is no guarantee that this method will work. If an
error occurs in the operating system during the operation, then this
method will return `null`.



Callers of this method validate the return value before proceeding.

<a name='T-MFR-Objects-Interop-Factories-MakeNewBindContext'></a>
## MakeNewBindContext `type`

##### Namespace

MFR.Objects.Interop.Factories

##### Summary

Instructs the operating system to create instances of objects that
implement the
[IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')
interface.

<a name='M-MFR-Objects-Interop-Factories-MakeNewBindContext-FromScratch'></a>
### FromScratch() `method`

##### Summary

Instructs the operating system to create an instance of an object
that implements the
[IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')
interface, or `null` if the operating system failed
to carry out the requested operation.

##### Parameters

This method has no parameters.

##### Remarks

There is no guarantee that this method will work. If an
error occurs in the operating system during the object creation
process, this method will return `null`.



Callers of this method validate the return value before proceeding.

<a name='T-MFR-Objects-Interop-Factories-MakeNewEnumMoniker'></a>
## MakeNewEnumMoniker `type`

##### Namespace

MFR.Objects.Interop.Factories

##### Summary

Instructs the operating system to create instances of objects that
implement the
[IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker')
interface given a reference to an instance of an object that implements
other interfaces.

<a name='M-MFR-Objects-Interop-Factories-MakeNewEnumMoniker-From-System-Runtime-InteropServices-ComTypes-IRunningObjectTable-'></a>
### From(runningObjectTable) `method`

##### Summary

Given a reference to an instance of an operating-system-provided
object that implements the
[IRunningObjectTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IRunningObjectTable 'System.Runtime.InteropServices.ComTypes.IRunningObjectTable')
interface, instructs the operating system to give us access to an
instance of an object, that implements the
[IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker')
interface, which provides access to enumerating the entries of the
Running Object Table (ROT) on the local workstation.

##### Returns

Reference to an instance of an object that implements the
[IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker')
interface, or `null` if the operating system was
unable to provide the application with the requested access.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| runningObjectTable | [System.Runtime.InteropServices.ComTypes.IRunningObjectTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IRunningObjectTable 'System.Runtime.InteropServices.ComTypes.IRunningObjectTable') | (Required.) Reference to an instance of an object that implements
the
[IRunningObjectTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IRunningObjectTable 'System.Runtime.InteropServices.ComTypes.IRunningObjectTable')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter,
`runningObjectTable`
, is passed a `null` value. |

##### Remarks

This method is not guaranteed to work. If the operating
system is unable to allow the application access to the requested
object, or another internal error occurs, this method returns
`null`
. Callers of this method should check for a
`null`
result prior to proceeding.

<a name='T-MFR-Objects-Interop-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Interop.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Interop-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Interop-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
