<a name='assembly'></a>
# MFR.Interop.Monikers.Collections.Interfaces

## Contents

- [IMonikerEnumerable](#T-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerable 'MFR.Interop.Monikers.Collections.Interfaces.IMonikerEnumerable')
  - [AndAttachOperatingSystemEnumerator(monikerEnumerator)](#M-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerable-AndAttachOperatingSystemEnumerator-System-Runtime-InteropServices-ComTypes-IEnumMoniker- 'MFR.Interop.Monikers.Collections.Interfaces.IMonikerEnumerable.AndAttachOperatingSystemEnumerator(System.Runtime.InteropServices.ComTypes.IEnumMoniker)')
  - [AndBindContext(bindContext)](#M-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerable-AndBindContext-System-Runtime-InteropServices-ComTypes-IBindCtx- 'MFR.Interop.Monikers.Collections.Interfaces.IMonikerEnumerable.AndBindContext(System.Runtime.InteropServices.ComTypes.IBindCtx)')
  - [AndRunningObjectTable(runningObjectTable)](#M-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerable-AndRunningObjectTable-System-Runtime-InteropServices-ComTypes-IRunningObjectTable- 'MFR.Interop.Monikers.Collections.Interfaces.IMonikerEnumerable.AndRunningObjectTable(System.Runtime.InteropServices.ComTypes.IRunningObjectTable)')
- [IMonikerEnumerator](#T-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerator 'MFR.Interop.Monikers.Collections.Interfaces.IMonikerEnumerator')
  - [AttachBindContext(bindContext)](#M-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerator-AttachBindContext-System-Runtime-InteropServices-ComTypes-IBindCtx- 'MFR.Interop.Monikers.Collections.Interfaces.IMonikerEnumerator.AttachBindContext(System.Runtime.InteropServices.ComTypes.IBindCtx)')
  - [AttachOperatingSystemEnumerator(monikerEnumerator)](#M-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerator-AttachOperatingSystemEnumerator-System-Runtime-InteropServices-ComTypes-IEnumMoniker- 'MFR.Interop.Monikers.Collections.Interfaces.IMonikerEnumerator.AttachOperatingSystemEnumerator(System.Runtime.InteropServices.ComTypes.IEnumMoniker)')
  - [AttachRunningObjectTable(runningObjectTable)](#M-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerator-AttachRunningObjectTable-System-Runtime-InteropServices-ComTypes-IRunningObjectTable- 'MFR.Interop.Monikers.Collections.Interfaces.IMonikerEnumerator.AttachRunningObjectTable(System.Runtime.InteropServices.ComTypes.IRunningObjectTable)')
- [Resources](#T-MFR-Objects-Interop-Monikers-Collections-Interfaces-Properties-Resources 'MFR.Interop.Monikers.Collections.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Interop-Monikers-Collections-Interfaces-Properties-Resources-Culture 'MFR.Interop.Monikers.Collections.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Interop-Monikers-Collections-Interfaces-Properties-Resources-ResourceManager 'MFR.Interop.Monikers.Collections.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerable'></a>
## IMonikerEnumerable `type`

##### Namespace

MFR.Interop.Monikers.Collections.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an enumerable
collection of objects that implement the
[IMonikerWrapper](#T-MFR-Objects-IMonikerWrapper 'MFR.IMonikerWrapper')
interface.

<a name='M-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerable-AndAttachOperatingSystemEnumerator-System-Runtime-InteropServices-ComTypes-IEnumMoniker-'></a>
### AndAttachOperatingSystemEnumerator(monikerEnumerator) `method`

##### Summary

Associates this object with an instance of an operating-system
provided object, that implements the
[IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker')
interface, providing enumeration services for a collection of COM
object monikers.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| monikerEnumerator | [System.Runtime.InteropServices.ComTypes.IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker') | (Required.) Reference to an instance of an object that implements
the
[IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter,
`monikerEnumerator`
, is passed a `null` value. |

<a name='M-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerable-AndBindContext-System-Runtime-InteropServices-ComTypes-IBindCtx-'></a>
### AndBindContext(bindContext) `method`

##### Summary

Associates an instance of an object that implements the
[IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')
interface with this collection.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bindContext | [System.Runtime.InteropServices.ComTypes.IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx') | (Required.) Reference to an instance of an object that implements
the [IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `bindContext`, is
passed a `null` value. |

<a name='M-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerable-AndRunningObjectTable-System-Runtime-InteropServices-ComTypes-IRunningObjectTable-'></a>
### AndRunningObjectTable(runningObjectTable) `method`

##### Summary

Associates an instance of an operating-system-provided object that
implements the
[IRunningObjectTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IRunningObjectTable 'System.Runtime.InteropServices.ComTypes.IRunningObjectTable')
interface with this object.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

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

<a name='T-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerator'></a>
## IMonikerEnumerator `type`

##### Namespace

MFR.Interop.Monikers.Collections.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an enumerable
collection of COM object monikers.

<a name='M-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerator-AttachBindContext-System-Runtime-InteropServices-ComTypes-IBindCtx-'></a>
### AttachBindContext(bindContext) `method`

##### Summary

Associates an instance of an object that implements the
[IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')
interface with this collection.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bindContext | [System.Runtime.InteropServices.ComTypes.IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx') | (Required.) Reference to an instance of an object that implements
the [IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `bindContext`, is
passed a `null` value. |

<a name='M-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerator-AttachOperatingSystemEnumerator-System-Runtime-InteropServices-ComTypes-IEnumMoniker-'></a>
### AttachOperatingSystemEnumerator(monikerEnumerator) `method`

##### Summary

Associates this object with an instance of an operating-system
provided object, that implements the
[IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker')
interface, providing enumeration services for a collection of COM
object monikers.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| monikerEnumerator | [System.Runtime.InteropServices.ComTypes.IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker') | (Required.) Reference to an instance of an object that implements
the
[IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter,
`monikerEnumerator`
, is passed a `null` value. |

<a name='M-MFR-Objects-Interop-Monikers-Collections-Interfaces-IMonikerEnumerator-AttachRunningObjectTable-System-Runtime-InteropServices-ComTypes-IRunningObjectTable-'></a>
### AttachRunningObjectTable(runningObjectTable) `method`

##### Summary

Associates an instance of an object that implements the
[IRunningObjectTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IRunningObjectTable 'System.Runtime.InteropServices.ComTypes.IRunningObjectTable')
interface with this collection.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

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

<a name='T-MFR-Objects-Interop-Monikers-Collections-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Interop.Monikers.Collections.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Interop-Monikers-Collections-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Interop-Monikers-Collections-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
