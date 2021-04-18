<a name='assembly'></a>
# MFR.Objects.Interop.Monikers.Wrappers.Factories

## Contents

- [GetOperatingSystemObjectDisplayName](#T-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetOperatingSystemObjectDisplayName')
  - [#ctor()](#M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName-#ctor 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetOperatingSystemObjectDisplayName.#ctor')
  - [_bindContext](#F-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName-_bindContext 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetOperatingSystemObjectDisplayName._bindContext')
  - [_moniker](#F-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName-_moniker 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetOperatingSystemObjectDisplayName._moniker')
  - [Instance](#P-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName-Instance 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetOperatingSystemObjectDisplayName.Instance')
  - [#cctor()](#M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName-#cctor 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetOperatingSystemObjectDisplayName.#cctor')
  - [FromMoniker()](#M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName-FromMoniker-System-Runtime-InteropServices-ComTypes-IMoniker- 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetOperatingSystemObjectDisplayName.FromMoniker(System.Runtime.InteropServices.ComTypes.IMoniker)')
  - [UsingBindContext(bindContext)](#M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName-UsingBindContext-System-Runtime-InteropServices-ComTypes-IBindCtx- 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetOperatingSystemObjectDisplayName.UsingBindContext(System.Runtime.InteropServices.ComTypes.IBindCtx)')
- [GetRunningOperatingSystemObject](#T-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetRunningOperatingSystemObject')
  - [#ctor()](#M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject-#ctor 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetRunningOperatingSystemObject.#ctor')
  - [_moniker](#F-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject-_moniker 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetRunningOperatingSystemObject._moniker')
  - [_runningObjectTable](#F-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject-_runningObjectTable 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetRunningOperatingSystemObject._runningObjectTable')
  - [Instance](#P-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject-Instance 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetRunningOperatingSystemObject.Instance')
  - [#cctor()](#M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject-#cctor 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetRunningOperatingSystemObject.#cctor')
  - [AndRunningObjectTable()](#M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject-AndRunningObjectTable-System-Runtime-InteropServices-ComTypes-IRunningObjectTable- 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetRunningOperatingSystemObject.AndRunningObjectTable(System.Runtime.InteropServices.ComTypes.IRunningObjectTable)')
  - [FromMoniker()](#M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject-FromMoniker-System-Runtime-InteropServices-ComTypes-IMoniker- 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetRunningOperatingSystemObject.FromMoniker(System.Runtime.InteropServices.ComTypes.IMoniker)')
- [MakeNewMonikerWrapper](#T-MFR-Objects-Interop-Monikers-Wrappers-Factories-MakeNewMonikerWrapper 'MFR.Objects.Interop.Monikers.Wrappers.Factories.MakeNewMonikerWrapper')
  - [From(bindContext,runningObjectTable,PARM)](#M-MFR-Objects-Interop-Monikers-Wrappers-Factories-MakeNewMonikerWrapper-From-System-Runtime-InteropServices-ComTypes-IBindCtx,System-Runtime-InteropServices-ComTypes-IRunningObjectTable,System-Runtime-InteropServices-ComTypes-IMoniker- 'MFR.Objects.Interop.Monikers.Wrappers.Factories.MakeNewMonikerWrapper.From(System.Runtime.InteropServices.ComTypes.IBindCtx,System.Runtime.InteropServices.ComTypes.IRunningObjectTable,System.Runtime.InteropServices.ComTypes.IMoniker)')
- [Resources](#T-MFR-Objects-Interop-Monikers-Wrappers-Factories-Properties-Resources 'MFR.Objects.Interop.Monikers.Wrappers.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Interop-Monikers-Wrappers-Factories-Properties-Resources-Culture 'MFR.Objects.Interop.Monikers.Wrappers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Interop-Monikers-Wrappers-Factories-Properties-Resources-ResourceManager 'MFR.Objects.Interop.Monikers.Wrappers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName'></a>
## GetOperatingSystemObjectDisplayName `type`

##### Namespace

MFR.Objects.Interop.Monikers.Wrappers.Factories

##### Summary

Obtains the display names of objects from the operating-system-provided
Running Object Table (ROT) for the local workstation.

<a name='M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName-_bindContext'></a>
### _bindContext `constants`

##### Summary

Reference to an instance of an object that implements the
[IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')
interface.

<a name='F-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName-_moniker'></a>
### _moniker `constants`

##### Summary

Reference to an instance of an object that implements the
[IMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IMoniker 'System.Runtime.InteropServices.ComTypes.IMoniker')
interface.

<a name='P-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[GetDisplayName](#T-MFR-Objects-GetDisplayName 'MFR.Objects.GetDisplayName').

<a name='M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName-FromMoniker-System-Runtime-InteropServices-ComTypes-IMoniker-'></a>
### FromMoniker() `method`

##### Summary

Associates a reference to an instance of an
operating-system-provided object that implements the
[IMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IMoniker 'System.Runtime.InteropServices.ComTypes.IMoniker')
interface with this factory.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `moniker`, is
passed a `null` value. |

<a name='M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetOperatingSystemObjectDisplayName-UsingBindContext-System-Runtime-InteropServices-ComTypes-IBindCtx-'></a>
### UsingBindContext(bindContext) `method`

##### Summary

Associates a reference to an instance of an
operating-system-provided object that implements the
[IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')
interface with this factory and, using it and the
[_moniker](#F-MFR-Objects-GetDisplayName-_moniker 'MFR.Objects.GetDisplayName._moniker')
field's
value, attempts to obtain the moniker's display name from the
operating system.

##### Returns

String containing the display name, or blank if the display name
could not be obtained from the operating system.

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
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if this method has been called without calling the
[FromMoniker](#M-MFR-Objects-GetOperatingSystemObjectDisplayName-FromMoniker 'MFR.Objects.GetOperatingSystemObjectDisplayName.FromMoniker')
method first. |

##### Remarks

Clients of this class must call the
[FromMoniker](#M-MFR-Objects-GetOperatingSystemObjectDisplayName-FromMoniker 'MFR.Objects.GetOperatingSystemObjectDisplayName.FromMoniker')
method prior to calling this method. If that has not been done, then
this method will throw
[InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException')
.

<a name='T-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject'></a>
## GetRunningOperatingSystemObject `type`

##### Namespace

MFR.Objects.Interop.Monikers.Wrappers.Factories

##### Summary

Looks up running objects from the operating-system-provided Running
Object Table (ROT) on the local workstation.

<a name='M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject-_moniker'></a>
### _moniker `constants`

##### Summary

Reference to an instance of an object that implements the [IMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IMoniker 'System.Runtime.InteropServices.ComTypes.IMoniker') interface.

<a name='F-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject-_runningObjectTable'></a>
### _runningObjectTable `constants`

##### Summary

Reference to an instance of an object that implements the [IRunningObjectTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IRunningObjectTable 'System.Runtime.InteropServices.ComTypes.IRunningObjectTable') interface.

<a name='P-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [GetRunningOperatingSystemObject](#T-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject 'MFR.Objects.Interop.Monikers.Wrappers.Factories.GetRunningOperatingSystemObject').

<a name='M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject-AndRunningObjectTable-System-Runtime-InteropServices-ComTypes-IRunningObjectTable-'></a>
### AndRunningObjectTable() `method`

##### Summary

Associates this object with an instance of an
operating-system-provided object that implements the [IRunningObjectTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IRunningObjectTable 'System.Runtime.InteropServices.ComTypes.IRunningObjectTable') interface.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Interop-Monikers-Wrappers-Factories-GetRunningOperatingSystemObject-FromMoniker-System-Runtime-InteropServices-ComTypes-IMoniker-'></a>
### FromMoniker() `method`

##### Summary

Associates a reference to an instance of an
operating-system-provided object that implements the [IMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IMoniker 'System.Runtime.InteropServices.ComTypes.IMoniker')
interface with this factory.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `moniker`, is
passed a `null` value. |

<a name='T-MFR-Objects-Interop-Monikers-Wrappers-Factories-MakeNewMonikerWrapper'></a>
## MakeNewMonikerWrapper `type`

##### Namespace

MFR.Objects.Interop.Monikers.Wrappers.Factories

##### Summary

Creates and initializes instances of objects that implement the
[IMonikerWrapper](#T-MFR-Objects-IMonikerWrapper 'MFR.Objects.IMonikerWrapper')
interface and returns
references to them.

<a name='M-MFR-Objects-Interop-Monikers-Wrappers-Factories-MakeNewMonikerWrapper-From-System-Runtime-InteropServices-ComTypes-IBindCtx,System-Runtime-InteropServices-ComTypes-IRunningObjectTable,System-Runtime-InteropServices-ComTypes-IMoniker-'></a>
### From(bindContext,runningObjectTable,PARM) `method`

##### Summary

Creates a new instance of an object that implements the
[IMonikerWrapper](#T-MFR-Objects-IMonikerWrapper 'MFR.Objects.IMonikerWrapper')
interface, given
the provided `bindContext`,
`runningObjectTable`
, and `currentMoniker`
references that are provided in the corresponding arguments.

##### Returns

Reference to an instance of an object that implements the
[IMonikerWrapper](#T-MFR-Objects-IMonikerWrapper 'MFR.Objects.IMonikerWrapper')
interface, with
its properties initialized.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bindContext | [System.Runtime.InteropServices.ComTypes.IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx') | (Required.) Reference to an instance of an object that implements
the [IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')
interface. |
| runningObjectTable | [System.Runtime.InteropServices.ComTypes.IRunningObjectTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IRunningObjectTable 'System.Runtime.InteropServices.ComTypes.IRunningObjectTable') | (Required.) Reference to an instance of an object that implements
the
[IRunningObjectTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IRunningObjectTable 'System.Runtime.InteropServices.ComTypes.IRunningObjectTable')
interface. |
| PARM | [System.Runtime.InteropServices.ComTypes.IMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IMoniker 'System.Runtime.InteropServices.ComTypes.IMoniker') | (Required.) Reference to an instance of an object that implements
the [IMoniker](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IMoniker 'System.Runtime.InteropServices.ComTypes.IMoniker')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if any of the required parameters,
`bindContext`
, `runningObjectTable`, or
`currentMoniker` are passed a
`null`
value. |

<a name='T-MFR-Objects-Interop-Monikers-Wrappers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Interop.Monikers.Wrappers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Interop-Monikers-Wrappers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Interop-Monikers-Wrappers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
