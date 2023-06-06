<a name='assembly'></a>
# MFR.Renamers.Files.Events

## Contents

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
