<a name='assembly'></a>
# MFR.Renamers.Files.Events

## Contents

- [ClosingSolutionEventArgs](#T-MFR-Renamers-Files-Events-ClosingSolutionEventArgs 'MFR.Renamers.Files.Events.ClosingSolutionEventArgs')
  - [#ctor(solution)](#M-MFR-Renamers-Files-Events-ClosingSolutionEventArgs-#ctor-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution- 'MFR.Renamers.Files.Events.ClosingSolutionEventArgs.#ctor(xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution)')
  - [Solution](#P-MFR-Renamers-Files-Events-ClosingSolutionEventArgs-Solution 'MFR.Renamers.Files.Events.ClosingSolutionEventArgs.Solution')
- [ClosingSolutionEventHandler](#T-MFR-Renamers-Files-Events-ClosingSolutionEventHandler 'MFR.Renamers.Files.Events.ClosingSolutionEventHandler')
- [CurrentOperationChangedEventArgs](#T-MFR-Renamers-Files-Events-CurrentOperationChangedEventArgs 'MFR.Renamers.Files.Events.CurrentOperationChangedEventArgs')
  - [#ctor(newOperationType)](#M-MFR-Renamers-Files-Events-CurrentOperationChangedEventArgs-#ctor-MFR-Operations-Constants-OperationType- 'MFR.Renamers.Files.Events.CurrentOperationChangedEventArgs.#ctor(MFR.Operations.Constants.OperationType)')
  - [NewOperationType](#P-MFR-Renamers-Files-Events-CurrentOperationChangedEventArgs-NewOperationType 'MFR.Renamers.Files.Events.CurrentOperationChangedEventArgs.NewOperationType')
- [CurrentOperationChangedEventHandler](#T-MFR-Renamers-Files-Events-CurrentOperationChangedEventHandler 'MFR.Renamers.Files.Events.CurrentOperationChangedEventHandler')
- [Resources](#T-MFR-Renamers-Files-Events-Properties-Resources 'MFR.Renamers.Files.Events.Properties.Resources')
  - [Culture](#P-MFR-Renamers-Files-Events-Properties-Resources-Culture 'MFR.Renamers.Files.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Renamers-Files-Events-Properties-Resources-ResourceManager 'MFR.Renamers.Files.Events.Properties.Resources.ResourceManager')
- [RootDirectoryPathChangedEventArgs](#T-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventArgs 'MFR.Renamers.Files.Events.RootDirectoryPathChangedEventArgs')
  - [#ctor(oldPath,newPath)](#M-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventArgs-#ctor-System-String,System-String- 'MFR.Renamers.Files.Events.RootDirectoryPathChangedEventArgs.#ctor(System.String,System.String)')
  - [NewPath](#P-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventArgs-NewPath 'MFR.Renamers.Files.Events.RootDirectoryPathChangedEventArgs.NewPath')
  - [OldPath](#P-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventArgs-OldPath 'MFR.Renamers.Files.Events.RootDirectoryPathChangedEventArgs.OldPath')
- [RootDirectoryPathChangedEventHandler](#T-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventHandler 'MFR.Renamers.Files.Events.RootDirectoryPathChangedEventHandler')
- [SolutionCloseFailedEventArgs](#T-MFR-Renamers-Files-Events-SolutionCloseFailedEventArgs 'MFR.Renamers.Files.Events.SolutionCloseFailedEventArgs')
  - [#ctor(exception)](#M-MFR-Renamers-Files-Events-SolutionCloseFailedEventArgs-#ctor-System-Exception- 'MFR.Renamers.Files.Events.SolutionCloseFailedEventArgs.#ctor(System.Exception)')
  - [Exception](#P-MFR-Renamers-Files-Events-SolutionCloseFailedEventArgs-Exception 'MFR.Renamers.Files.Events.SolutionCloseFailedEventArgs.Exception')
- [SolutionCloseFailedEventHandler](#T-MFR-Renamers-Files-Events-SolutionCloseFailedEventHandler 'MFR.Renamers.Files.Events.SolutionCloseFailedEventHandler')
- [SolutionClosedEventArgs](#T-MFR-Renamers-Files-Events-SolutionClosedEventArgs 'MFR.Renamers.Files.Events.SolutionClosedEventArgs')
  - [#ctor(pathname)](#M-MFR-Renamers-Files-Events-SolutionClosedEventArgs-#ctor-System-String- 'MFR.Renamers.Files.Events.SolutionClosedEventArgs.#ctor(System.String)')
  - [Pathname](#P-MFR-Renamers-Files-Events-SolutionClosedEventArgs-Pathname 'MFR.Renamers.Files.Events.SolutionClosedEventArgs.Pathname')
- [SolutionClosedEventHandler](#T-MFR-Renamers-Files-Events-SolutionClosedEventHandler 'MFR.Renamers.Files.Events.SolutionClosedEventHandler')

<a name='T-MFR-Renamers-Files-Events-ClosingSolutionEventArgs'></a>
## ClosingSolutionEventArgs `type`

##### Namespace

MFR.Renamers.Files.Events

##### Summary

Provides information for `ClosingSolution` event handlers.

##### Remarks

Callers can set the value of the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true` as a means of stopping the operation from proceeding.

<a name='M-MFR-Renamers-Files-Events-ClosingSolutionEventArgs-#ctor-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution-'></a>
### #ctor(solution) `constructor`

##### Summary

Constructs a new instance of
[ClosingSolutionEventArgs](#T-MFR-Renamers-Files-Events-ClosingSolutionEventArgs 'MFR.Renamers.Files.Events.ClosingSolutionEventArgs') and returns
a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| solution | [xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution') | (Required.) Reference to an instance of an object that implements the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface that represents the Visual Studio Solution (`*.sln`) file that
is about to be closed/unloaded in a running Visual Studio instance. |

<a name='P-MFR-Renamers-Files-Events-ClosingSolutionEventArgs-Solution'></a>
### Solution `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface that represents the Visual Studio Solution (`*.sln`) file that
is about to be closed/unloaded in a running Visual Studio instance.

<a name='T-MFR-Renamers-Files-Events-ClosingSolutionEventHandler'></a>
## ClosingSolutionEventHandler `type`

##### Namespace

MFR.Renamers.Files.Events

##### Summary

Represents a handler for a `ClosingSolution` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Renamers.Files.Events.ClosingSolutionEventHandler](#T-T-MFR-Renamers-Files-Events-ClosingSolutionEventHandler 'T:MFR.Renamers.Files.Events.ClosingSolutionEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`ClosingSolution` event.

<a name='T-MFR-Renamers-Files-Events-CurrentOperationChangedEventArgs'></a>
## CurrentOperationChangedEventArgs `type`

##### Namespace

MFR.Renamers.Files.Events

##### Summary

Provides information for `CurrentOperationChanged` event handlers.

<a name='M-MFR-Renamers-Files-Events-CurrentOperationChangedEventArgs-#ctor-MFR-Operations-Constants-OperationType-'></a>
### #ctor(newOperationType) `constructor`

##### Summary

Constructs a new instance of
[CurrentOperationChangedEventArgs](#T-MFR-Renamers-Files-Events-CurrentOperationChangedEventArgs 'MFR.Renamers.Files.Events.CurrentOperationChangedEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newOperationType | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that indicates the new operation that is being performed by the
application. |

<a name='P-MFR-Renamers-Files-Events-CurrentOperationChangedEventArgs-NewOperationType'></a>
### NewOperationType `property`

##### Summary

Gets the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') enumeration
value that indicates the new operation that is being executed by the
application..

<a name='T-MFR-Renamers-Files-Events-CurrentOperationChangedEventHandler'></a>
## CurrentOperationChangedEventHandler `type`

##### Namespace

MFR.Renamers.Files.Events

##### Summary

Represents a handler for a `CurrentOperationChanged` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Renamers.Files.Events.CurrentOperationChangedEventHandler](#T-T-MFR-Renamers-Files-Events-CurrentOperationChangedEventHandler 'T:MFR.Renamers.Files.Events.CurrentOperationChangedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`CurrentOperationChanged` event.

<a name='T-MFR-Renamers-Files-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Renamers.Files.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Renamers-Files-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Renamers-Files-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventArgs'></a>
## RootDirectoryPathChangedEventArgs `type`

##### Namespace

MFR.Renamers.Files.Events

##### Summary

Provides information for `RootDirectoryPathChanged` event handlers.

<a name='M-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventArgs-#ctor-System-String,System-String-'></a>
### #ctor(oldPath,newPath) `constructor`

##### Summary

Constructs a new instance of
[RootDirectoryPathChangedEventArgs](#T-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventArgs 'MFR.Renamers.Files.Events.RootDirectoryPathChangedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| oldPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the previous
fully-qualified pathname of a folder from which all operations start. |
| newPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the new
fully-qualified pathname of a folder from which all operations start. |

<a name='P-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventArgs-NewPath'></a>
### NewPath `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the new root directory path.

<a name='P-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventArgs-OldPath'></a>
### OldPath `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the old root directory path.

<a name='T-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventHandler'></a>
## RootDirectoryPathChangedEventHandler `type`

##### Namespace

MFR.Renamers.Files.Events

##### Summary

Represents a handler for a `RootDirectoryPathChanged` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Renamers.Files.Events.RootDirectoryPathChangedEventHandler](#T-T-MFR-Renamers-Files-Events-RootDirectoryPathChangedEventHandler 'T:MFR.Renamers.Files.Events.RootDirectoryPathChangedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`RootDirectoryPathChanged` event.

<a name='T-MFR-Renamers-Files-Events-SolutionCloseFailedEventArgs'></a>
## SolutionCloseFailedEventArgs `type`

##### Namespace

MFR.Renamers.Files.Events

##### Summary

Provides information for `SolutionCloseFailed` event handlers.

<a name='M-MFR-Renamers-Files-Events-SolutionCloseFailedEventArgs-#ctor-System-Exception-'></a>
### #ctor(exception) `constructor`

##### Summary

Constructs a new instance of
[SolutionCloseFailedEventArgs](#T-MFR-Renamers-Files-Events-SolutionCloseFailedEventArgs 'MFR.Renamers.Files.Events.SolutionCloseFailedEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) A [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that explains the reason for
the failure. |

<a name='P-MFR-Renamers-Files-Events-SolutionCloseFailedEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') instance that explains the reason for
the failure.

<a name='T-MFR-Renamers-Files-Events-SolutionCloseFailedEventHandler'></a>
## SolutionCloseFailedEventHandler `type`

##### Namespace

MFR.Renamers.Files.Events

##### Summary

Represents a handler for a `SolutionCloseFailed` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Renamers.Files.Events.SolutionCloseFailedEventHandler](#T-T-MFR-Renamers-Files-Events-SolutionCloseFailedEventHandler 'T:MFR.Renamers.Files.Events.SolutionCloseFailedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`SolutionCloseFailed` event.



This event is typically raised in the event that an attempt to close a Visual
Studio Solution (`*.sln`) file that has been loaded in a running instance
of Visual Studio has failed.

<a name='T-MFR-Renamers-Files-Events-SolutionClosedEventArgs'></a>
## SolutionClosedEventArgs `type`

##### Namespace

MFR.Renamers.Files.Events

##### Summary

Provides information for `SolutionClosed` event handlers.

##### Remarks

The `SolutionClosed` event is used to indicate that a running
instance of Visual Studio has just finished closing/unloading a Visual Studio
Solution (`*.sln`) file.

<a name='M-MFR-Renamers-Files-Events-SolutionClosedEventArgs-#ctor-System-String-'></a>
### #ctor(pathname) `constructor`

##### Summary

Constructs a new instance of
[SolutionClosedEventArgs](#T-MFR-Renamers-Files-Events-SolutionClosedEventArgs 'MFR.Renamers.Files.Events.SolutionClosedEventArgs') and returns
a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a Visual Studio Solution (`*.sln`) file that has just been
unloaded by a running instance of Visual Studio. |

<a name='P-MFR-Renamers-Files-Events-SolutionClosedEventArgs-Pathname'></a>
### Pathname `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the Visual Studio Solution (`*.sln`) file that was most
recently closed/unloaded by a running instance of Visual Studio.

<a name='T-MFR-Renamers-Files-Events-SolutionClosedEventHandler'></a>
## SolutionClosedEventHandler `type`

##### Namespace

MFR.Renamers.Files.Events

##### Summary

Represents a handler for a `SolutionClosed` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Renamers.Files.Events.SolutionClosedEventHandler](#T-T-MFR-Renamers-Files-Events-SolutionClosedEventHandler 'T:MFR.Renamers.Files.Events.SolutionClosedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`SolutionClosed` event.



The `SolutionClosed` event is used to indicate that a running
instance of Visual Studio has just finished closing/unloading a Visual Studio
Solution (`*.sln`) file.
