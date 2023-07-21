<a name='assembly'></a>
# MFR.File.Stream.Providers

## Contents

- [FileStreamProvider](#T-MFR-File-Stream-Providers-FileStreamProvider 'MFR.File.Stream.Providers.FileStreamProvider')
  - [#ctor()](#M-MFR-File-Stream-Providers-FileStreamProvider-#ctor 'MFR.File.Stream.Providers.FileStreamProvider.#ctor')
  - [Instance](#P-MFR-File-Stream-Providers-FileStreamProvider-Instance 'MFR.File.Stream.Providers.FileStreamProvider.Instance')
  - [LastPathnameRemoved](#P-MFR-File-Stream-Providers-FileStreamProvider-LastPathnameRemoved 'MFR.File.Stream.Providers.FileStreamProvider.LastPathnameRemoved')
  - [MapOfPathnamesToTickets](#P-MFR-File-Stream-Providers-FileStreamProvider-MapOfPathnamesToTickets 'MFR.File.Stream.Providers.FileStreamProvider.MapOfPathnamesToTickets')
  - [MapOfTicketsToPathnames](#P-MFR-File-Stream-Providers-FileStreamProvider-MapOfTicketsToPathnames 'MFR.File.Stream.Providers.FileStreamProvider.MapOfTicketsToPathnames')
  - [#cctor()](#M-MFR-File-Stream-Providers-FileStreamProvider-#cctor 'MFR.File.Stream.Providers.FileStreamProvider.#cctor')
  - [BatchOpenStreams(pathnames)](#M-MFR-File-Stream-Providers-FileStreamProvider-BatchOpenStreams-System-Collections-Generic-IReadOnlyCollection{System-String}- 'MFR.File.Stream.Providers.FileStreamProvider.BatchOpenStreams(System.Collections.Generic.IReadOnlyCollection{System.String})')
  - [CreateTicketToPathnameMapping(pathname,ticket)](#M-MFR-File-Stream-Providers-FileStreamProvider-CreateTicketToPathnameMapping-System-String,System-Guid- 'MFR.File.Stream.Providers.FileStreamProvider.CreateTicketToPathnameMapping(System.String,System.Guid)')
  - [FileStreamAlreadyOpenedFor(pathname)](#M-MFR-File-Stream-Providers-FileStreamProvider-FileStreamAlreadyOpenedFor-System-String- 'MFR.File.Stream.Providers.FileStreamProvider.FileStreamAlreadyOpenedFor(System.String)')
  - [GetPathnameForTicket(ticket)](#M-MFR-File-Stream-Providers-FileStreamProvider-GetPathnameForTicket-System-Guid- 'MFR.File.Stream.Providers.FileStreamProvider.GetPathnameForTicket(System.Guid)')
  - [GetTicketForPathname(pathname)](#M-MFR-File-Stream-Providers-FileStreamProvider-GetTicketForPathname-System-String- 'MFR.File.Stream.Providers.FileStreamProvider.GetTicketForPathname(System.String)')
  - [OnDisposingTicketedObject(e)](#M-MFR-File-Stream-Providers-FileStreamProvider-OnDisposingTicketedObject-xyLOGIX-TicketedProvider-Events-DisposingTicketedObjectEventArgs- 'MFR.File.Stream.Providers.FileStreamProvider.OnDisposingTicketedObject(xyLOGIX.TicketedProvider.Events.DisposingTicketedObjectEventArgs)')
  - [OnFileStreamDisposed(e)](#M-MFR-File-Stream-Providers-FileStreamProvider-OnFileStreamDisposed-MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs- 'MFR.File.Stream.Providers.FileStreamProvider.OnFileStreamDisposed(MFR.File.Stream.Providers.Events.FileStreamDisposedEventArgs)')
  - [OnFileStreamOpenFailed(e)](#M-MFR-File-Stream-Providers-FileStreamProvider-OnFileStreamOpenFailed-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs- 'MFR.File.Stream.Providers.FileStreamProvider.OnFileStreamOpenFailed(MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs)')
  - [OnFileStreamOpened(e)](#M-MFR-File-Stream-Providers-FileStreamProvider-OnFileStreamOpened-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs- 'MFR.File.Stream.Providers.FileStreamProvider.OnFileStreamOpened(MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs)')
  - [OnFileStreamOpening(e)](#M-MFR-File-Stream-Providers-FileStreamProvider-OnFileStreamOpening-MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs- 'MFR.File.Stream.Providers.FileStreamProvider.OnFileStreamOpening(MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs)')
  - [OnTicketedObjectDisposalRequested(e)](#M-MFR-File-Stream-Providers-FileStreamProvider-OnTicketedObjectDisposalRequested-xyLOGIX-TicketedProvider-Events-TicketedObjectDisposalRequestedEventArgs{System-IO-StreamReader}- 'MFR.File.Stream.Providers.FileStreamProvider.OnTicketedObjectDisposalRequested(xyLOGIX.TicketedProvider.Events.TicketedObjectDisposalRequestedEventArgs{System.IO.StreamReader})')
  - [OnTicketedObjectDisposed(e)](#M-MFR-File-Stream-Providers-FileStreamProvider-OnTicketedObjectDisposed-xyLOGIX-TicketedProvider-Events-TicketedObjectDisposedEventArgs- 'MFR.File.Stream.Providers.FileStreamProvider.OnTicketedObjectDisposed(xyLOGIX.TicketedProvider.Events.TicketedObjectDisposedEventArgs)')
  - [OpenStreamFor(pathname)](#M-MFR-File-Stream-Providers-FileStreamProvider-OpenStreamFor-System-String- 'MFR.File.Stream.Providers.FileStreamProvider.OpenStreamFor(System.String)')
  - [RemovePathnameMappingFor(ticket)](#M-MFR-File-Stream-Providers-FileStreamProvider-RemovePathnameMappingFor-System-Guid- 'MFR.File.Stream.Providers.FileStreamProvider.RemovePathnameMappingFor(System.Guid)')
  - [RewindStream(ticket)](#M-MFR-File-Stream-Providers-FileStreamProvider-RewindStream-System-Guid- 'MFR.File.Stream.Providers.FileStreamProvider.RewindStream(System.Guid)')
- [Resources](#T-MFR-File-Stream-Providers-Properties-Resources 'MFR.File.Stream.Providers.Properties.Resources')
  - [Culture](#P-MFR-File-Stream-Providers-Properties-Resources-Culture 'MFR.File.Stream.Providers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-File-Stream-Providers-Properties-Resources-ResourceManager 'MFR.File.Stream.Providers.Properties.Resources.ResourceManager')

<a name='T-MFR-File-Stream-Providers-FileStreamProvider'></a>
## FileStreamProvider `type`

##### Namespace

MFR.File.Stream.Providers

##### Summary

Manages a collection of file streams open on a large group of text files.



Allows disparate parts of the application to access these file streams through
a ticket system.

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-File-Stream-Providers-FileStreamProvider-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFileStreamProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider')
interface.

<a name='P-MFR-File-Stream-Providers-FileStreamProvider-LastPathnameRemoved'></a>
### LastPathnameRemoved `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the most-recently
removed pathname of a file stream mapped to a given ticket.

##### Remarks

This property is for internal use only.

<a name='P-MFR-File-Stream-Providers-FileStreamProvider-MapOfPathnamesToTickets'></a>
### MapOfPathnamesToTickets `property`

##### Summary

Sets up a 1-to-1 correspondence between a file's pathname and a ticket that is
created for it.

<a name='P-MFR-File-Stream-Providers-FileStreamProvider-MapOfTicketsToPathnames'></a>
### MapOfTicketsToPathnames `property`

##### Summary

Sets up a 1-to-1 correspondence between a specific file stream ticket and the
fully-qualified pathname of the associated file on the disk.

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-BatchOpenStreams-System-Collections-Generic-IReadOnlyCollection{System-String}-'></a>
### BatchOpenStreams(pathnames) `method`

##### Summary

Opens file streams for the files specified in the `pathnames`
collection, in batch.  Returns a collection of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
values, each of which represents the corresponding opened file stream.  If a

##### Returns

A collection of one or more [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') values, each
of which corresponds in a 1-to-1 fashion to the file(s) that have been
specified.  If a particular file could not be opened, its corresponding entry
in the returned collection will be the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid.Empty 'System.Guid.Empty')
value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathnames | [System.Collections.Generic.IReadOnlyCollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection 'System.Collections.Generic.IReadOnlyCollection{System.String}') | (Required.) A collection of one or more [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') values,
each of which represents a file to be opened. |

##### Remarks

If the `pathnames` collection is
`null` or the empty collection, then this method returns the
empty collection.

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-CreateTicketToPathnameMapping-System-String,System-Guid-'></a>
### CreateTicketToPathnameMapping(pathname,ticket) `method`

##### Summary

Associates the specified `pathname` with the corresponding
file stream `ticket`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the fully-qualified pathname of a file on the disk, on which a file
stream has been opened and which has the specified `ticket`. |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that is the
ticket for the open file stream on the file having the specified
`pathname`. |

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-FileStreamAlreadyOpenedFor-System-String-'></a>
### FileStreamAlreadyOpenedFor(pathname) `method`

##### Summary

Determines whether a file stream has already been opened for a file having the
specified `pathname`.

##### Returns

`true` if an open file stream exists on the file
having the specified `pathname`; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file that should be checked for having an active file stream
opened on it. |

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-GetPathnameForTicket-System-Guid-'></a>
### GetPathnameForTicket(ticket) `method`

##### Summary

Attempts to look up the fully-qualified pathname of the file on whom a file
stream corresponding to the specified `ticket` has been
opened.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
fully-qualified pathname of the file on whom the file stream corresponding to
the specified `ticket` is opened.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that
should correspond to a file that currently has a stream opened upon it. |

##### Remarks

If this method cannot locate the corresponding pathname of the file
stream that goes with the `ticket`, or if the
`ticket` provided is not mapped to any open file stream, then
this method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-GetTicketForPathname-System-String-'></a>
### GetTicketForPathname(pathname) `method`

##### Summary

Given a fully-qualified `pathname` of a file on the disk,
upon which a file stream has been opened, or we think has been opened, and
finds the corresponding ticket that can be redeemed to access a reference
to that stream. .

##### Returns

If a file stream is open on the file having the specified
`pathname`, the [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that
indicates which ticket can be redeemed to this object in order to get access to
that stream, is returned.



Otherwise, if there is no file stream currently open upon the file having the
specified `pathname`, or if the specified
`pathname` is invalid or refers to a file that does not
exist, then the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid.Empty 'System.Guid.Empty') value is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file on which you think a stream might be open. |

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-OnDisposingTicketedObject-xyLOGIX-TicketedProvider-Events-DisposingTicketedObjectEventArgs-'></a>
### OnDisposingTicketedObject(e) `method`

##### Summary

Raises the
[](#E-xyLOGIX-TicketedProvider-TicketedObjectProviderBase`1-DisposingTicketedObject 'xyLOGIX.TicketedProvider.TicketedObjectProviderBase`1.DisposingTicketedObject')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.TicketedProvider.Events.DisposingTicketedObjectEventArgs](#T-xyLOGIX-TicketedProvider-Events-DisposingTicketedObjectEventArgs 'xyLOGIX.TicketedProvider.Events.DisposingTicketedObjectEventArgs') | A
[DisposingTicketedObjectEventArgs](#T-xyLOGIX-TicketedProvider-Events-DisposingTicketedObjectEventArgs 'xyLOGIX.TicketedProvider.Events.DisposingTicketedObjectEventArgs')
that
allows us to cancel the operation that this event is notifying the caller of.



To cancel the operation, handlers should set the value of the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true`. |

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-OnFileStreamDisposed-MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs-'></a>
### OnFileStreamDisposed(e) `method`

##### Summary

Raises the
[](#E-MFR-File-Stream-Providers-FileStreamProvider-FileStreamDisposed 'MFR.File.Stream.Providers.FileStreamProvider.FileStreamDisposed')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.File.Stream.Providers.Events.FileStreamDisposedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamDisposedEventArgs') | A
[FileStreamDisposedEventHandler](#T-MFR-File-Stream-Providers-Events-FileStreamDisposedEventHandler 'MFR.File.Stream.Providers.Events.FileStreamDisposedEventHandler')
that contains the event data. |

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-OnFileStreamOpenFailed-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs-'></a>
### OnFileStreamOpenFailed(e) `method`

##### Summary

Raises the
[](#E-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs') | A
[FileStreamOpenFailedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs')
that contains the event data. |

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-OnFileStreamOpened-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs-'></a>
### OnFileStreamOpened(e) `method`

##### Summary

Raises the
[](#E-MFR-File-Stream-Providers-FileStreamProvider-FileStreamOpened 'MFR.File.Stream.Providers.FileStreamProvider.FileStreamOpened')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs') | A
[FileStreamDisposedEventHandler](#T-MFR-File-Stream-Providers-Events-FileStreamDisposedEventHandler 'MFR.File.Stream.Providers.Events.FileStreamDisposedEventHandler')
that contains the event data. |

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-OnFileStreamOpening-MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs-'></a>
### OnFileStreamOpening(e) `method`

##### Summary

Raises the
[](#E-MFR-File-Stream-Providers-FileStreamProvider-FileStreamOpening 'MFR.File.Stream.Providers.FileStreamProvider.FileStreamOpening')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs') | (Required.) A
[FileStreamOpeningEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs')
that contains the event data. |

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-OnTicketedObjectDisposalRequested-xyLOGIX-TicketedProvider-Events-TicketedObjectDisposalRequestedEventArgs{System-IO-StreamReader}-'></a>
### OnTicketedObjectDisposalRequested(e) `method`

##### Summary

Raises the
[](#E-xyLOGIX-TicketedProvider-TicketedObjectProviderBase-TicketedObjectDisposalRequested 'xyLOGIX.TicketedProvider.TicketedObjectProviderBase.TicketedObjectDisposalRequested')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.TicketedProvider.Events.TicketedObjectDisposalRequestedEventArgs{System.IO.StreamReader}](#T-xyLOGIX-TicketedProvider-Events-TicketedObjectDisposalRequestedEventArgs{System-IO-StreamReader} 'xyLOGIX.TicketedProvider.Events.TicketedObjectDisposalRequestedEventArgs{System.IO.StreamReader}') | A
[TicketedObjectDisposalRequestedEventArgs\`1](#T-xyLOGIX-TicketedProvider-Events-TicketedObjectDisposalRequestedEventArgs`1 'xyLOGIX.TicketedProvider.Events.TicketedObjectDisposalRequestedEventArgs`1')
that contains the event data. |

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-OnTicketedObjectDisposed-xyLOGIX-TicketedProvider-Events-TicketedObjectDisposedEventArgs-'></a>
### OnTicketedObjectDisposed(e) `method`

##### Summary

Raises the
[](#E-xyLOGIX-TicketedProvider-TicketedObjectProviderBase-TicketedObjectDisposed 'xyLOGIX.TicketedProvider.TicketedObjectProviderBase.TicketedObjectDisposed')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.TicketedProvider.Events.TicketedObjectDisposedEventArgs](#T-xyLOGIX-TicketedProvider-Events-TicketedObjectDisposedEventArgs 'xyLOGIX.TicketedProvider.Events.TicketedObjectDisposedEventArgs') | A
[TicketedObjectDisposedEventArgs](#T-xyLOGIX-TicketedProvider-Events-TicketedObjectDisposedEventArgs 'xyLOGIX.TicketedProvider.Events.TicketedObjectDisposedEventArgs')
that contains the event data. |

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-OpenStreamFor-System-String-'></a>
### OpenStreamFor(pathname) `method`

##### Summary

Opens a file stream, represented by a [StreamReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.StreamReader 'System.IO.StreamReader')
instance, on the text file having the specified `pathname`.

##### Returns

A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that represents a `ticket` that can
be redeemed later on with the
[Redeem](#M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-Redeem 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.Redeem')
method to access the corresponding file stream, or
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid.Empty 'System.Guid.Empty') if the file could not be accessed or if the
`pathname` parameters' argument is the blank or
`null`[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), or if the
`pathname` does not refer to a file or the file that is
referred to does not exist..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file to have a stream opened for it. |

##### Remarks

If the file having the specified `pathname` already
has a stream opened upon it, then the ticket that corresponds to that stream is
returned.

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-RemovePathnameMappingFor-System-Guid-'></a>
### RemovePathnameMappingFor(ticket) `method`

##### Summary

Breaks the link between a file's fully-qualified pathname and the particular
`ticket` that can be redeemed for its corresponding file
stream.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the
fully-qualified pathname of the file on who the stream corresponding to the
specified `ticket` was initially opened.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that can
ordinarily be redeemed to acquire the stream for a corresponding file. |

<a name='M-MFR-File-Stream-Providers-FileStreamProvider-RewindStream-System-Guid-'></a>
### RewindStream(ticket) `method`

##### Summary

Rewinds the file stream associated with the specified
`ticket`, if any corresponding stream is even present in the
internal collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that corresponds to
the already-open file stream that is to be rewound. |

##### Remarks

If successful, this method retrieves the file stream open on a file
that corresponds to the specified `ticket`, and then moves
its file pointer to the beginning of the stream.



If an I/O exception or other error occurs, if the stream that corresponds to
the specified `ticket` cannot be obtained from the internal
collection, or if the stream is already positioned at the beginning of the
data, then the method does nothing.

<a name='T-MFR-File-Stream-Providers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.File.Stream.Providers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-File-Stream-Providers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-File-Stream-Providers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
