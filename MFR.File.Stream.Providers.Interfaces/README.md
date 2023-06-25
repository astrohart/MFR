<a name='assembly'></a>
# MFR.File.Stream.Providers.Interfaces

## Contents

- [IFileStreamProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider')
  - [Count](#P-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-Count 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.Count')
  - [SyncRoot](#P-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-SyncRoot 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.SyncRoot')
  - [BatchDispose(tickets)](#M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-BatchDispose-System-Collections-Generic-IReadOnlyCollection{System-Guid}- 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.BatchDispose(System.Collections.Generic.IReadOnlyCollection{System.Guid})')
  - [BatchOpenStreams(pathnames)](#M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-BatchOpenStreams-System-Collections-Generic-IReadOnlyCollection{System-String}- 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.BatchOpenStreams(System.Collections.Generic.IReadOnlyCollection{System.String})')
  - [DisposeAll()](#M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-DisposeAll 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.DisposeAll')
  - [DisposeStream(ticket,remove)](#M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-DisposeStream-System-Guid,System-Boolean- 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.DisposeStream(System.Guid,System.Boolean)')
  - [GetPathnameForTicket(ticket)](#M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-GetPathnameForTicket-System-Guid- 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.GetPathnameForTicket(System.Guid)')
  - [GetTicketForPathname(pathname)](#M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-GetTicketForPathname-System-String- 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.GetTicketForPathname(System.String)')
  - [OpenStreamFor(pathname)](#M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-OpenStreamFor-System-String- 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.OpenStreamFor(System.String)')
  - [RedeemTicket(ticket)](#M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-RedeemTicket-System-Guid- 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.RedeemTicket(System.Guid)')
  - [RewindStream(ticket)](#M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-RewindStream-System-Guid- 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.RewindStream(System.Guid)')
- [Resources](#T-MFR-File-Stream-Providers-Interfaces-Properties-Resources 'MFR.File.Stream.Providers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-File-Stream-Providers-Interfaces-Properties-Resources-Culture 'MFR.File.Stream.Providers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-File-Stream-Providers-Interfaces-Properties-Resources-ResourceManager 'MFR.File.Stream.Providers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider'></a>
## IFileStreamProvider `type`

##### Namespace

MFR.File.Stream.Providers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that allocates
instances of [TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') and hands out
[Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')`ticket` values that other parts of the
application can then redeem to access the allocated
[TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') instance for later use.



Also provides a method to dispose all the allocated
[TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') instances previously allocated (e.g.,
when the application shuts down).

##### Remarks

All [TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') instances provided by this class are
thread-safe.

<a name='P-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-Count'></a>
### Count `property`

##### Summary

Gets the count of file streams that are currently available.

<a name='P-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-SyncRoot'></a>
### SyncRoot `property`

##### Summary

Gets a reference to an instance of [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') that is to be
used for thread synchronization.

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-BatchDispose-System-Collections-Generic-IReadOnlyCollection{System-Guid}-'></a>
### BatchDispose(tickets) `method`

##### Summary

Batch-disposes the open file streams that correspond to the
`tickets` provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tickets | [System.Collections.Generic.IReadOnlyCollection{System.Guid}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection 'System.Collections.Generic.IReadOnlyCollection{System.Guid}') | (Required.) A collection of one or more [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') values
that represent the file stream(s) to be disposed. |

##### Remarks

If the `tickets` is `null` or
contains zero elements, then this method does nothing.



Users of this object who want to dispose of all the file streams
that this object manages in one go should use the
[DisposeAll](#M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-DisposeAll 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.DisposeAll')
method instead.

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-BatchOpenStreams-System-Collections-Generic-IReadOnlyCollection{System-String}-'></a>
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

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-DisposeAll'></a>
### DisposeAll() `method`

##### Summary

Removes all allocated [TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') instances
allocated thus far, from memory, and frees resources associated with them.

##### Parameters

This method has no parameters.

##### Remarks

After calling this method, all tickets will be invalid.

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-DisposeStream-System-Guid,System-Boolean-'></a>
### DisposeStream(ticket,remove) `method`

##### Summary

Disposes, i.e., closes the file and releases all resources, for the file stream
that corresponds to the specified `ticket`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that corresponds to
the file stream you wish to close. |
| remove | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) Indicates whether to remove the disposed stream from our internal
collection.  `true` is the default. |

##### Remarks

If the Zero GUID is passed as the argument of the `ticket`
parameter, or if the specified `ticket` is not present in the
internal list.

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-GetPathnameForTicket-System-Guid-'></a>
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

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-GetTicketForPathname-System-String-'></a>
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

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-OpenStreamFor-System-String-'></a>
### OpenStreamFor(pathname) `method`

##### Summary

Opens a file stream, represented by a [TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader')
instance, on the text file having the specified `pathname`.

##### Returns

A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that represents a `ticket` that can
be redeemed later on with the
[RedeemTicket](#M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-RedeemTicket 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.RedeemTicket')
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

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-RedeemTicket-System-Guid-'></a>
### RedeemTicket(ticket) `method`

##### Summary

Provides a reference to an instance of [TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader')
that corresponds to the specified `ticket`.

##### Returns

Reference to an instance of [TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader')
that corresponds to the specified `ticket`, or
`null` if either no corresponding
[TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') can be found in the internal
collection, or if the corresponding [TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader')
instance has already been disposed or removed from the internal collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that
represents a `ticket` that can be redeemed for a particular
[TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') instance that corresponds to a file
stream. |

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-RewindStream-System-Guid-'></a>
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

<a name='T-MFR-File-Stream-Providers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.File.Stream.Providers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-File-Stream-Providers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-File-Stream-Providers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
