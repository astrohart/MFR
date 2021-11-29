<a name='assembly'></a>
# MFR.Managers.RootFolders.Events

## Contents

- [Resources](#T-MFR-Managers-RootFolders-Events-Properties-Resources 'MFR.Managers.RootFolders.Events.Properties.Resources')
  - [Culture](#P-MFR-Managers-RootFolders-Events-Properties-Resources-Culture 'MFR.Managers.RootFolders.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Managers-RootFolders-Events-Properties-Resources-ResourceManager 'MFR.Managers.RootFolders.Events.Properties.Resources.ResourceManager')
- [RootFolderAddedEventArgs](#T-MFR-Managers-RootFolders-Events-RootFolderAddedEventArgs 'MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs')
  - [#ctor(path)](#M-MFR-Managers-RootFolders-Events-RootFolderAddedEventArgs-#ctor-System-String- 'MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs.#ctor(System.String)')
- [RootFolderAddedEventHandler](#T-MFR-Managers-RootFolders-Events-RootFolderAddedEventHandler 'MFR.Managers.RootFolders.Events.RootFolderAddedEventHandler')
- [RootFolderEventArgsBase](#T-MFR-Managers-RootFolders-Events-RootFolderEventArgsBase 'MFR.Managers.RootFolders.Events.RootFolderEventArgsBase')
  - [#ctor(path)](#M-MFR-Managers-RootFolders-Events-RootFolderEventArgsBase-#ctor-System-String- 'MFR.Managers.RootFolders.Events.RootFolderEventArgsBase.#ctor(System.String)')
  - [Path](#P-MFR-Managers-RootFolders-Events-RootFolderEventArgsBase-Path 'MFR.Managers.RootFolders.Events.RootFolderEventArgsBase.Path')
- [RootFolderRemovedEventArgs](#T-MFR-Managers-RootFolders-Events-RootFolderRemovedEventArgs 'MFR.Managers.RootFolders.Events.RootFolderRemovedEventArgs')
  - [#ctor(path)](#M-MFR-Managers-RootFolders-Events-RootFolderRemovedEventArgs-#ctor-System-String- 'MFR.Managers.RootFolders.Events.RootFolderRemovedEventArgs.#ctor(System.String)')
- [RootFolderRemovedEventHandler](#T-MFR-Managers-RootFolders-Events-RootFolderRemovedEventHandler 'MFR.Managers.RootFolders.Events.RootFolderRemovedEventHandler')

<a name='T-MFR-Managers-RootFolders-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Managers.RootFolders.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Managers-RootFolders-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Managers-RootFolders-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Managers-RootFolders-Events-RootFolderAddedEventArgs'></a>
## RootFolderAddedEventArgs `type`

##### Namespace

MFR.Managers.RootFolders.Events

##### Summary

Provides information for RootFolderAdded event handlers.

<a name='M-MFR-Managers-RootFolders-Events-RootFolderAddedEventArgs-#ctor-System-String-'></a>
### #ctor(path) `constructor`

##### Summary

Constructs a new instance of
[RootFolderAddedEventArgs](#T-MFR-Managers-RootFolders-Events-RootFolderAddedEventArgs 'MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs') and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname to the root folder
that has just been added. |

<a name='T-MFR-Managers-RootFolders-Events-RootFolderAddedEventHandler'></a>
## RootFolderAddedEventHandler `type`

##### Namespace

MFR.Managers.RootFolders.Events

##### Summary

Represents a handler for a RootFolderAdded event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Managers.RootFolders.Events.RootFolderAddedEventHandler](#T-T-MFR-Managers-RootFolders-Events-RootFolderAddedEventHandler 'T:MFR.Managers.RootFolders.Events.RootFolderAddedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
RootFolderAdded event.



The event should be raised by the
[RootFolderPathManager](#T-MFR-Managers-RootFolders-RootFolderPathManager 'MFR.Managers.RootFolders.RootFolderPathManager') class when a
folder is added to its collection of root folders.

<a name='T-MFR-Managers-RootFolders-Events-RootFolderEventArgsBase'></a>
## RootFolderEventArgsBase `type`

##### Namespace

MFR.Managers.RootFolders.Events

##### Summary

Defines methods and properties that are common to all the event-argument
objects that deal with root folder paths.

<a name='M-MFR-Managers-RootFolders-Events-RootFolderEventArgsBase-#ctor-System-String-'></a>
### #ctor(path) `constructor`

##### Summary

Constructs a new instance of
[RootFolderAdded](#T-MFR-Managers-RootFolders-Events-RootFolderAdded 'MFR.Managers.RootFolders.Events.RootFolderAdded') and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname to the root folder
that has just been added. |

<a name='P-MFR-Managers-RootFolders-Events-RootFolderEventArgsBase-Path'></a>
### Path `property`

##### Summary

Gets or sets the fully-qualified pathname of the root folder that has been
added.

<a name='T-MFR-Managers-RootFolders-Events-RootFolderRemovedEventArgs'></a>
## RootFolderRemovedEventArgs `type`

##### Namespace

MFR.Managers.RootFolders.Events

##### Summary

Provides information for RootFolderRemoved event handlers.

<a name='M-MFR-Managers-RootFolders-Events-RootFolderRemovedEventArgs-#ctor-System-String-'></a>
### #ctor(path) `constructor`

##### Summary

Constructs a new instance of
[RootFolderRemovedEventArgs](#T-MFR-Managers-RootFolders-Events-RootFolderRemovedEventArgs 'MFR.Managers.RootFolders.Events.RootFolderRemovedEventArgs') and
returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname to the root folder
that has just been removed. |

<a name='T-MFR-Managers-RootFolders-Events-RootFolderRemovedEventHandler'></a>
## RootFolderRemovedEventHandler `type`

##### Namespace

MFR.Managers.RootFolders.Events

##### Summary

Represents a handler for a RootFolderRemoved event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Managers.RootFolders.Events.RootFolderRemovedEventHandler](#T-T-MFR-Managers-RootFolders-Events-RootFolderRemovedEventHandler 'T:MFR.Managers.RootFolders.Events.RootFolderRemovedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
RootFolderRemoved event.
