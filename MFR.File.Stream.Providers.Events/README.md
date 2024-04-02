<a name='assembly'></a>
# MFR.File.Stream.Providers.Events

## Contents

- [FileHostCreateFailedEventArgs](#T-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventArgs 'MFR.File.Stream.Providers.Events.FileHostCreateFailedEventArgs')
  - [#ctor(pathname,exception)](#M-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventArgs-#ctor-System-String,System-Exception- 'MFR.File.Stream.Providers.Events.FileHostCreateFailedEventArgs.#ctor(System.String,System.Exception)')
  - [Exception](#P-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventArgs-Exception 'MFR.File.Stream.Providers.Events.FileHostCreateFailedEventArgs.Exception')
  - [Pathname](#P-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventArgs-Pathname 'MFR.File.Stream.Providers.Events.FileHostCreateFailedEventArgs.Pathname')
- [FileHostCreateFailedEventHandler](#T-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventHandler 'MFR.File.Stream.Providers.Events.FileHostCreateFailedEventHandler')
- [FileHostCreatedEventArgs](#T-MFR-File-Stream-Providers-Events-FileHostCreatedEventArgs 'MFR.File.Stream.Providers.Events.FileHostCreatedEventArgs')
  - [#ctor(pathname,host,ticket)](#M-MFR-File-Stream-Providers-Events-FileHostCreatedEventArgs-#ctor-System-String,MFR-File-Hosts-Interfaces-IFileHost,System-Guid- 'MFR.File.Stream.Providers.Events.FileHostCreatedEventArgs.#ctor(System.String,MFR.File.Hosts.Interfaces.IFileHost,System.Guid)')
  - [Host](#P-MFR-File-Stream-Providers-Events-FileHostCreatedEventArgs-Host 'MFR.File.Stream.Providers.Events.FileHostCreatedEventArgs.Host')
  - [Pathname](#P-MFR-File-Stream-Providers-Events-FileHostCreatedEventArgs-Pathname 'MFR.File.Stream.Providers.Events.FileHostCreatedEventArgs.Pathname')
  - [Ticket](#P-MFR-File-Stream-Providers-Events-FileHostCreatedEventArgs-Ticket 'MFR.File.Stream.Providers.Events.FileHostCreatedEventArgs.Ticket')
- [FileHostCreatedEventHandler](#T-MFR-File-Stream-Providers-Events-FileHostCreatedEventHandler 'MFR.File.Stream.Providers.Events.FileHostCreatedEventHandler')
- [Resources](#T-MFR-File-Stream-Providers-Events-Properties-Resources 'MFR.File.Stream.Providers.Events.Properties.Resources')
  - [Culture](#P-MFR-File-Stream-Providers-Events-Properties-Resources-Culture 'MFR.File.Stream.Providers.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-File-Stream-Providers-Events-Properties-Resources-ResourceManager 'MFR.File.Stream.Providers.Events.Properties.Resources.ResourceManager')

<a name='T-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventArgs'></a>
## FileHostCreateFailedEventArgs `type`

##### Namespace

MFR.File.Stream.Providers.Events

##### Summary

Provides information for `FileHostCreateFailed` event handlers.

<a name='M-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventArgs-#ctor-System-String,System-Exception-'></a>
### #ctor(pathname,exception) `constructor`

##### Summary

Constructs a new instance of
[FileHostCreateFailedEventArgs](#T-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventArgs 'MFR.File.Stream.Providers.Events.FileHostCreateFailedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file on which a file stream could not be allocated. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) A [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') instance that describes the
failure reason. |

<a name='P-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') instance that describes the failure
reason.

<a name='P-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventArgs-Pathname'></a>
### Pathname `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified pathname
of a file for whom a file stream could not be opened.

<a name='T-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventHandler'></a>
## FileHostCreateFailedEventHandler `type`

##### Namespace

MFR.File.Stream.Providers.Events

##### Summary

Represents a handler for a `FileHostCreateFailed` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.File.Stream.Providers.Events.FileHostCreateFailedEventHandler](#T-T-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventHandler 'T:MFR.File.Stream.Providers.Events.FileHostCreateFailedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`FileHostCreateFailed` event.

<a name='T-MFR-File-Stream-Providers-Events-FileHostCreatedEventArgs'></a>
## FileHostCreatedEventArgs `type`

##### Namespace

MFR.File.Stream.Providers.Events

##### Summary

Provides information for `FileHostCreated` event handlers.

<a name='M-MFR-File-Stream-Providers-Events-FileHostCreatedEventArgs-#ctor-System-String,MFR-File-Hosts-Interfaces-IFileHost,System-Guid-'></a>
### #ctor(pathname,host,ticket) `constructor`

##### Summary

Constructs a new instance of
[FileHostCreatedEventArgs](#T-MFR-File-Stream-Providers-Events-FileHostCreatedEventArgs 'MFR.File.Stream.Providers.Events.FileHostCreatedEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file for which a file stream has been successfully opened. |
| host | [MFR.File.Hosts.Interfaces.IFileHost](#T-MFR-File-Hosts-Interfaces-IFileHost 'MFR.File.Hosts.Interfaces.IFileHost') | (Required.) Reference to an instance of an object that implements the
[IFileHost](#T-MFR-File-Hosts-Interfaces-IFileHost 'MFR.File.Hosts.Interfaces.IFileHost') interface. |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that corresponds to the
`ticket` that subscribers can redeem at a later point to access the file
stream. |

<a name='P-MFR-File-Stream-Providers-Events-FileHostCreatedEventArgs-Host'></a>
### Host `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileHost](#T-MFR-File-Hosts-Interfaces-IFileHost 'MFR.File.Hosts.Interfaces.IFileHost') interface that represents
the `File Host` that was just created.

<a name='P-MFR-File-Stream-Providers-Events-FileHostCreatedEventArgs-Pathname'></a>
### Pathname `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file for which a file stream was successfully opened.

<a name='P-MFR-File-Stream-Providers-Events-FileHostCreatedEventArgs-Ticket'></a>
### Ticket `property`

##### Summary

Gets a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that can be redeemed to get access to
the file stream later.

<a name='T-MFR-File-Stream-Providers-Events-FileHostCreatedEventHandler'></a>
## FileHostCreatedEventHandler `type`

##### Namespace

MFR.File.Stream.Providers.Events

##### Summary

Represents a handler for a `FileHostCreated` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.File.Stream.Providers.Events.FileHostCreatedEventHandler](#T-T-MFR-File-Stream-Providers-Events-FileHostCreatedEventHandler 'T:MFR.File.Stream.Providers.Events.FileHostCreatedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`FileHostCreated` event.

<a name='T-MFR-File-Stream-Providers-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.File.Stream.Providers.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-File-Stream-Providers-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-File-Stream-Providers-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
