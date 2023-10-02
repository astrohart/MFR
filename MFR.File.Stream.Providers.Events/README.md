<a name='assembly'></a>
# MFR.File.Stream.Providers.Events

## Contents

- [FileStreamDisposedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamDisposedEventArgs')
  - [#ctor(pathname,ticket)](#M-MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs-#ctor-System-String,System-Guid- 'MFR.File.Stream.Providers.Events.FileStreamDisposedEventArgs.#ctor(System.String,System.Guid)')
  - [Pathname](#P-MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs-Pathname 'MFR.File.Stream.Providers.Events.FileStreamDisposedEventArgs.Pathname')
  - [Ticket](#P-MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs-Ticket 'MFR.File.Stream.Providers.Events.FileStreamDisposedEventArgs.Ticket')
- [FileStreamDisposedEventHandler](#T-MFR-File-Stream-Providers-Events-FileStreamDisposedEventHandler 'MFR.File.Stream.Providers.Events.FileStreamDisposedEventHandler')
- [FileStreamOpenFailedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs')
  - [#ctor(pathname,exception)](#M-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs-#ctor-System-String,System-Exception- 'MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs.#ctor(System.String,System.Exception)')
  - [Exception](#P-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs-Exception 'MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs.Exception')
  - [Pathname](#P-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs-Pathname 'MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs.Pathname')
- [FileStreamOpenFailedEventHandler](#T-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventHandler 'MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventHandler')
- [FileStreamOpenedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs')
  - [#ctor(pathname,reader,ticket)](#M-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs-#ctor-System-String,System-IO-TextReader,System-Guid- 'MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs.#ctor(System.String,System.IO.TextReader,System.Guid)')
  - [Pathname](#P-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs-Pathname 'MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs.Pathname')
  - [Reader](#P-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs-Reader 'MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs.Reader')
  - [Ticket](#P-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs-Ticket 'MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs.Ticket')
- [FileStreamOpenedEventHandler](#T-MFR-File-Stream-Providers-Events-FileStreamOpenedEventHandler 'MFR.File.Stream.Providers.Events.FileStreamOpenedEventHandler')
- [FileStreamOpeningEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs')
  - [#ctor(pathname)](#M-MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs-#ctor-System-String- 'MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs.#ctor(System.String)')
  - [Pathname](#P-MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs-Pathname 'MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs.Pathname')
- [FileStreamOpeningEventHandler](#T-MFR-File-Stream-Providers-Events-FileStreamOpeningEventHandler 'MFR.File.Stream.Providers.Events.FileStreamOpeningEventHandler')
- [Resources](#T-MFR-File-Stream-Providers-Events-Properties-Resources 'MFR.File.Stream.Providers.Events.Properties.Resources')
  - [Culture](#P-MFR-File-Stream-Providers-Events-Properties-Resources-Culture 'MFR.File.Stream.Providers.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-File-Stream-Providers-Events-Properties-Resources-ResourceManager 'MFR.File.Stream.Providers.Events.Properties.Resources.ResourceManager')

<a name='T-MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs'></a>
## FileStreamDisposedEventArgs `type`

##### Namespace

MFR.File.Stream.Providers.Events

##### Summary

Provides information for `FileStreamDisposed` event handlers.

<a name='M-MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs-#ctor-System-String,System-Guid-'></a>
### #ctor(pathname,ticket) `constructor`

##### Summary

Constructs a new instance of
[FileStreamDisposedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamDisposedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file that previously had a file stream opened on it. |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that corresponds to the
`ticket` that now no longer works. |

<a name='P-MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs-Pathname'></a>
### Pathname `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file on which the disposed stream was previously opened.

<a name='P-MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs-Ticket'></a>
### Ticket `property`

##### Summary

Gets a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that corresponds to the `ticket` that
now no longer works.

<a name='T-MFR-File-Stream-Providers-Events-FileStreamDisposedEventHandler'></a>
## FileStreamDisposedEventHandler `type`

##### Namespace

MFR.File.Stream.Providers.Events

##### Summary

Represents a handler for a `FileStreamDisposed` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.File.Stream.Providers.Events.FileStreamDisposedEventHandler](#T-T-MFR-File-Stream-Providers-Events-FileStreamDisposedEventHandler 'T:MFR.File.Stream.Providers.Events.FileStreamDisposedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`FileStreamDisposed` event.

<a name='T-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs'></a>
## FileStreamOpenFailedEventArgs `type`

##### Namespace

MFR.File.Stream.Providers.Events

##### Summary

Provides information for `FileStreamOpenFailed` event handlers.

<a name='M-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs-#ctor-System-String,System-Exception-'></a>
### #ctor(pathname,exception) `constructor`

##### Summary

Constructs a new instance of
[FileStreamOpenFailedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file on which a file stream could not allocated. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) A [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') instance that describes the
failure reason. |

<a name='P-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') instance that describes the failure
reason.

<a name='P-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs-Pathname'></a>
### Pathname `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified pathname
of a file for whom a file stream could not be opened.

<a name='T-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventHandler'></a>
## FileStreamOpenFailedEventHandler `type`

##### Namespace

MFR.File.Stream.Providers.Events

##### Summary

Represents a handler for a `FileStreamOpenFailed` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventHandler](#T-T-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventHandler 'T:MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`FileStreamOpenFailed` event.

<a name='T-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs'></a>
## FileStreamOpenedEventArgs `type`

##### Namespace

MFR.File.Stream.Providers.Events

##### Summary

Provides information for `FileStreamOpened` event handlers.

<a name='M-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs-#ctor-System-String,System-IO-TextReader,System-Guid-'></a>
### #ctor(pathname,reader,ticket) `constructor`

##### Summary

Constructs a new instance of
[FileStreamOpenedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file for which a file stream has been successfully opened. |
| reader | [System.IO.TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') | (Required.) Reference to an instance of a
[TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') that represents the file stream thusly
opened. |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that corresponds to the
`ticket` that subscribers can redeem at a later point to access the file
stream. |

<a name='P-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs-Pathname'></a>
### Pathname `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file for which a file stream was successfully opened.

<a name='P-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs-Reader'></a>
### Reader `property`

##### Summary

Gets a reference to an instance of [TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') that
represents the actual file stream on the file having the pathname specified in
the
[Pathname](#P-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs-Pathname 'MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs.Pathname')
property.

<a name='P-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs-Ticket'></a>
### Ticket `property`

##### Summary

Gets a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that can be redeemed to get access to
the file stream later.

<a name='T-MFR-File-Stream-Providers-Events-FileStreamOpenedEventHandler'></a>
## FileStreamOpenedEventHandler `type`

##### Namespace

MFR.File.Stream.Providers.Events

##### Summary

Represents a handler for a `FileStreamOpened` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.File.Stream.Providers.Events.FileStreamOpenedEventHandler](#T-T-MFR-File-Stream-Providers-Events-FileStreamOpenedEventHandler 'T:MFR.File.Stream.Providers.Events.FileStreamOpenedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`FileStreamOpened` event.

<a name='T-MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs'></a>
## FileStreamOpeningEventArgs `type`

##### Namespace

MFR.File.Stream.Providers.Events

##### Summary

Provides information for `FileStreamOpening` event handlers.

##### Remarks

A `FileStreamOpening` event is raised when a `FileStream` is about to
be
opened upon a specific file.



This object conveys information about the fully-qualified pathname of the
particular file on which the `FileStream` is to be opened.

<a name='M-MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs-#ctor-System-String-'></a>
### #ctor(pathname) `constructor`

##### Summary

Constructs a new instance of
[FileStreamOpeningEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file that is about to have a `FileStream` opened upon it. |

<a name='P-MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs-Pathname'></a>
### Pathname `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file on which a stream is about to be opened.

<a name='T-MFR-File-Stream-Providers-Events-FileStreamOpeningEventHandler'></a>
## FileStreamOpeningEventHandler `type`

##### Namespace

MFR.File.Stream.Providers.Events

##### Summary

Represents a handler for a `FileStreamOpening` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.File.Stream.Providers.Events.FileStreamOpeningEventHandler](#T-T-MFR-File-Stream-Providers-Events-FileStreamOpeningEventHandler 'T:MFR.File.Stream.Providers.Events.FileStreamOpeningEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`FileStreamOpening` event.

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
