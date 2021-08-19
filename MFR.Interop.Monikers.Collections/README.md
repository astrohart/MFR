<a name='assembly'></a>
# MFR.Objects.Interop.Monikers.Collections

## Contents

- [MonikerCollection](#T-MFR-Objects-Interop-Monikers-Collections-MonikerCollection 'MFR.Objects.Interop.Monikers.Collections.MonikerCollection')
  - [_bindContext](#F-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-_bindContext 'MFR.Objects.Interop.Monikers.Collections.MonikerCollection._bindContext')
  - [_monikerEnumerator](#F-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-_monikerEnumerator 'MFR.Objects.Interop.Monikers.Collections.MonikerCollection._monikerEnumerator')
  - [_runningObjectTable](#F-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-_runningObjectTable 'MFR.Objects.Interop.Monikers.Collections.MonikerCollection._runningObjectTable')
  - [Enumerator](#P-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-Enumerator 'MFR.Objects.Interop.Monikers.Collections.MonikerCollection.Enumerator')
  - [AndAttachOperatingSystemEnumerator(monikerEnumerator)](#M-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-AndAttachOperatingSystemEnumerator-System-Runtime-InteropServices-ComTypes-IEnumMoniker- 'MFR.Objects.Interop.Monikers.Collections.MonikerCollection.AndAttachOperatingSystemEnumerator(System.Runtime.InteropServices.ComTypes.IEnumMoniker)')
  - [AndBindContext(bindContext)](#M-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-AndBindContext-System-Runtime-InteropServices-ComTypes-IBindCtx- 'MFR.Objects.Interop.Monikers.Collections.MonikerCollection.AndBindContext(System.Runtime.InteropServices.ComTypes.IBindCtx)')
  - [AndRunningObjectTable(runningObjectTable)](#M-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-AndRunningObjectTable-System-Runtime-InteropServices-ComTypes-IRunningObjectTable- 'MFR.Objects.Interop.Monikers.Collections.MonikerCollection.AndRunningObjectTable(System.Runtime.InteropServices.ComTypes.IRunningObjectTable)')
  - [GetEnumerator()](#M-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-GetEnumerator 'MFR.Objects.Interop.Monikers.Collections.MonikerCollection.GetEnumerator')
  - [System#Collections#IEnumerable#GetEnumerator()](#M-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-System#Collections#IEnumerable#GetEnumerator 'MFR.Objects.Interop.Monikers.Collections.MonikerCollection.System#Collections#IEnumerable#GetEnumerator')
- [MonikerEnumerator](#T-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator')
  - [#ctor()](#M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-#ctor 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator.#ctor')
  - [#ctor(monikerEnumerator)](#M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-#ctor-System-Runtime-InteropServices-ComTypes-IEnumMoniker- 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator.#ctor(System.Runtime.InteropServices.ComTypes.IEnumMoniker)')
  - [_bindContext](#F-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-_bindContext 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator._bindContext')
  - [_monikerEnumerator](#F-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-_monikerEnumerator 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator._monikerEnumerator')
  - [_runningObjectTable](#F-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-_runningObjectTable 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator._runningObjectTable')
  - [Current](#P-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-Current 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator.Current')
  - [System#Collections#IEnumerator#Current](#P-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-System#Collections#IEnumerator#Current 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator.System#Collections#IEnumerator#Current')
  - [AttachBindContext(bindContext)](#M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-AttachBindContext-System-Runtime-InteropServices-ComTypes-IBindCtx- 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator.AttachBindContext(System.Runtime.InteropServices.ComTypes.IBindCtx)')
  - [AttachOperatingSystemEnumerator(monikerEnumerator)](#M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-AttachOperatingSystemEnumerator-System-Runtime-InteropServices-ComTypes-IEnumMoniker- 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator.AttachOperatingSystemEnumerator(System.Runtime.InteropServices.ComTypes.IEnumMoniker)')
  - [AttachRunningObjectTable(runningObjectTable)](#M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-AttachRunningObjectTable-System-Runtime-InteropServices-ComTypes-IRunningObjectTable- 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator.AttachRunningObjectTable(System.Runtime.InteropServices.ComTypes.IRunningObjectTable)')
  - [Dispose()](#M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-Dispose 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator.Dispose')
  - [MoveNext()](#M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-MoveNext 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator.MoveNext')
  - [Reset()](#M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-Reset 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator.Reset')
- [Resources](#T-MFR-Objects-Interop-Monikers-Collections-Properties-Resources 'MFR.Objects.Interop.Monikers.Collections.Properties.Resources')
  - [Culture](#P-MFR-Objects-Interop-Monikers-Collections-Properties-Resources-Culture 'MFR.Objects.Interop.Monikers.Collections.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Interop-Monikers-Collections-Properties-Resources-ResourceManager 'MFR.Objects.Interop.Monikers.Collections.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Interop-Monikers-Collections-MonikerCollection'></a>
## MonikerCollection `type`

##### Namespace

MFR.Objects.Interop.Monikers.Collections

##### Summary

Collection that represents an operating-system defined table of COM
object monikers.

##### Remarks

This object must be associated with an instance of an object that
implements the
[IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker')
interface.

<a name='F-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-_bindContext'></a>
### _bindContext `constants`

##### Summary

Reference to an instance of an object that implements the
[IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')
interface.

<a name='F-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-_monikerEnumerator'></a>
### _monikerEnumerator `constants`

##### Summary

Reference to an instance of an object that implements the
[IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker')
interface.

<a name='F-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-_runningObjectTable'></a>
### _runningObjectTable `constants`

##### Summary

Reference to an instance of an object that implements the
[IRunningObjectTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IRunningObjectTable 'System.Runtime.InteropServices.ComTypes.IRunningObjectTable')
interface.

<a name='P-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-Enumerator'></a>
### Enumerator `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the [IMonikerEnumerator](#T-MFR-Objects-IMonikerEnumerator 'MFR.Objects.IMonikerEnumerator')
interface and which provides COM object moniker enumeration services.

<a name='M-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-AndAttachOperatingSystemEnumerator-System-Runtime-InteropServices-ComTypes-IEnumMoniker-'></a>
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

<a name='M-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-AndBindContext-System-Runtime-InteropServices-ComTypes-IBindCtx-'></a>
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

<a name='M-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-AndRunningObjectTable-System-Runtime-InteropServices-ComTypes-IRunningObjectTable-'></a>
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

<a name='M-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through the collection.

##### Returns

An enumerator that can be used to iterate through the collection.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Interop-Monikers-Collections-MonikerCollection-System#Collections#IEnumerable#GetEnumerator'></a>
### System#Collections#IEnumerable#GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through a collection.

##### Returns

An [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') object that can be
used to iterate through the collection.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator'></a>
## MonikerEnumerator `type`

##### Namespace

MFR.Objects.Interop.Monikers.Collections

##### Summary

Enumerates through COM object moniker tables provided by the operating system.

<a name='M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[MonikerEnumerator](#T-MFR-Objects-MonikerEnumerator 'MFR.Objects.MonikerEnumerator')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

##### Remarks

Callers of this constructor should then immediately call the
[AttachOperatingSystemEnumerator](#M-MFR-Objects-MonikerEnumerator-AttachOperatingSystemEnumerator 'MFR.Objects.MonikerEnumerator.AttachOperatingSystemEnumerator')
method to associate this object with an enumerator object provided
by the operating system.

<a name='M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-#ctor-System-Runtime-InteropServices-ComTypes-IEnumMoniker-'></a>
### #ctor(monikerEnumerator) `constructor`

##### Summary

Constructs a new instance of
[MonikerEnumerator](#T-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator 'MFR.Objects.Interop.Monikers.Collections.MonikerEnumerator')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| monikerEnumerator | [System.Runtime.InteropServices.ComTypes.IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker') | (Required.) Reference to an instance of an object that implements
the
[IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker')
interface that provides enumeration services over a COM object
moniker collection. |

<a name='F-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-_bindContext'></a>
### _bindContext `constants`

##### Summary

Reference to an instance of an object that implements the
[IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')
interface.

<a name='F-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-_monikerEnumerator'></a>
### _monikerEnumerator `constants`

##### Summary

Reference to an instance of an object that implements the
[IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker')
interface.

##### Remarks

This object provides enumeration services.

<a name='F-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-_runningObjectTable'></a>
### _runningObjectTable `constants`

##### Summary

Reference to an instance of an object that implements the
[IRunningObjectTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IRunningObjectTable 'System.Runtime.InteropServices.ComTypes.IRunningObjectTable')
interface.

<a name='P-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-Current'></a>
### Current `property`

##### Summary

Gets the element in the collection at the current position of the enumerator.

##### Returns

The element in the collection at the current position of the enumerator.

<a name='P-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-System#Collections#IEnumerator#Current'></a>
### System#Collections#IEnumerator#Current `property`

##### Summary

Gets the element in the collection at the current position of the enumerator.

##### Returns

The element in the collection at the current position of the enumerator.

<a name='M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-AttachBindContext-System-Runtime-InteropServices-ComTypes-IBindCtx-'></a>
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

<a name='M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-AttachOperatingSystemEnumerator-System-Runtime-InteropServices-ComTypes-IEnumMoniker-'></a>
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

<a name='M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-AttachRunningObjectTable-System-Runtime-InteropServices-ComTypes-IRunningObjectTable-'></a>
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

<a name='M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-Dispose'></a>
### Dispose() `method`

##### Summary

Performs application-defined tasks associated with freeing,
releasing, or resetting unmanaged resources.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-MoveNext'></a>
### MoveNext() `method`

##### Summary

Advances the enumerator to the next element of the collection.

##### Returns

`true` if the enumerator was successfully advanced
to the next element; `false` if the enumerator has
passed the end of the collection, or if the
[AttachOperatingSystemEnumerator](#M-MFR-Objects-MonikerEnumerator-AttachOperatingSystemEnumerator 'MFR.Objects.MonikerEnumerator.AttachOperatingSystemEnumerator')
method has not been called with a valid object reference to an
instance of an object implementing the
[IEnumMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IEnumMoniker 'System.Runtime.InteropServices.ComTypes.IEnumMoniker')
method having been passed to its sole parameter first.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | The collection was modified after the enumerator was created. |

<a name='M-MFR-Objects-Interop-Monikers-Collections-MonikerEnumerator-Reset'></a>
### Reset() `method`

##### Summary

Sets the enumerator to its initial position, which is before the
first element in the collection.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | The collection was modified after the enumerator was created. |

<a name='T-MFR-Objects-Interop-Monikers-Collections-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Interop.Monikers.Collections.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Interop-Monikers-Collections-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Interop-Monikers-Collections-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
