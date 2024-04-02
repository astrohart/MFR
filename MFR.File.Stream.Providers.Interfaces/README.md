<a name='assembly'></a>
# MFR.File.Stream.Providers.Interfaces

## Contents

- [IFileHostProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileHostProvider 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider')
  - [BatchOpenStreams(pathnames)](#M-MFR-File-Stream-Providers-Interfaces-IFileHostProvider-BatchOpenStreams-System-Collections-Generic-IList{System-String}- 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider.BatchOpenStreams(System.Collections.Generic.IList{System.String})')
  - [DisposeObject(ticket,remove)](#M-MFR-File-Stream-Providers-Interfaces-IFileHostProvider-DisposeObject-System-Guid,System-Boolean- 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider.DisposeObject(System.Guid,System.Boolean)')
  - [GetPathnameForTicket(ticket)](#M-MFR-File-Stream-Providers-Interfaces-IFileHostProvider-GetPathnameForTicket-System-Guid- 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider.GetPathnameForTicket(System.Guid)')
  - [GetTicketForPathname(pathname)](#M-MFR-File-Stream-Providers-Interfaces-IFileHostProvider-GetTicketForPathname-System-String- 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider.GetTicketForPathname(System.String)')
  - [OpenStreamFor(pathname)](#M-MFR-File-Stream-Providers-Interfaces-IFileHostProvider-OpenStreamFor-System-String- 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider.OpenStreamFor(System.String)')
  - [RewindStream(ticket)](#M-MFR-File-Stream-Providers-Interfaces-IFileHostProvider-RewindStream-System-Guid- 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider.RewindStream(System.Guid)')
  - [RewindStream(fileHost)](#M-MFR-File-Stream-Providers-Interfaces-IFileHostProvider-RewindStream-MFR-File-Hosts-Interfaces-IFileHost- 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider.RewindStream(MFR.File.Hosts.Interfaces.IFileHost)')
- [Resources](#T-MFR-File-Stream-Providers-Interfaces-Properties-Resources 'MFR.File.Stream.Providers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-File-Stream-Providers-Interfaces-Properties-Resources-Culture 'MFR.File.Stream.Providers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-File-Stream-Providers-Interfaces-Properties-Resources-ResourceManager 'MFR.File.Stream.Providers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-File-Stream-Providers-Interfaces-IFileHostProvider'></a>
## IFileHostProvider `type`

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

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileHostProvider-BatchOpenStreams-System-Collections-Generic-IList{System-String}-'></a>
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
| pathnames | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | (Required.) A collection of one or more [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') values,
each of which represents a file to be opened. |

##### Remarks

If the `pathnames` collection is
`null` or the empty collection, then this method returns the
empty collection.

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileHostProvider-DisposeObject-System-Guid,System-Boolean-'></a>
### DisposeObject(ticket,remove) `method`

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

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileHostProvider-GetPathnameForTicket-System-Guid-'></a>
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

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileHostProvider-GetTicketForPathname-System-String-'></a>
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

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileHostProvider-OpenStreamFor-System-String-'></a>
### OpenStreamFor(pathname) `method`

##### Summary

Opens a file stream, represented by a [FileHost](#T-MFR-File-Hosts-FileHost 'MFR.File.Hosts.FileHost')
instance, on the text file having the specified `pathname`.

##### Returns

A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that represents a `ticket` that can
be redeemed later on with the
[Redeem](#M-xyLOGIX-TicketedProvider-Interfaces-ITicketedObjectProvider`1-Redeem 'xyLOGIX.TicketedProvider.Interfaces.ITicketedObjectProvider`1.Redeem')
method to access the corresponding object, or
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

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileHostProvider-RewindStream-System-Guid-'></a>
### RewindStream(ticket) `method`

##### Summary

Rewinds the object associated with the specified
`ticket`, if any corresponding stream is even present in the
internal collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that corresponds to
the already-open object that is to be rewound. |

##### Remarks

If successful, this method retrieves the object open on a file
that corresponds to the specified `ticket`, and then moves
its file pointer to the beginning of the stream.



If an I/O exception or other error occurs, if the stream that corresponds to
the specified `ticket` cannot be obtained from the internal
collection, or if the stream is already positioned at the beginning of the
data, then the method does nothing.

<a name='M-MFR-File-Stream-Providers-Interfaces-IFileHostProvider-RewindStream-MFR-File-Hosts-Interfaces-IFileHost-'></a>
### RewindStream(fileHost) `method`

##### Summary

Rewinds the file stream associated with the specified
`fileHost`, if any corresponding `Stream` is even open
in the first place.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileHost | [MFR.File.Hosts.Interfaces.IFileHost](#T-MFR-File-Hosts-Interfaces-IFileHost 'MFR.File.Hosts.Interfaces.IFileHost') | (Required.) Reference to an instance of an object that implements the
[IFileHost](#T-MFR-File-Hosts-Interfaces-IFileHost 'MFR.File.Hosts.Interfaces.IFileHost') interface, representing
the file host whose `Stream` is to be rewound. |

##### Remarks

If a `null` reference is provided as the argument of the
`fileHost` parameter, then this method does nothing.



If successful, this method retrieves the file stream open on a file that
corresponds to the specified `ticket`, and then moves its
file pointer to the beginning of the stream.



If an I/O exception or other error occurs, if the `Stream` that
corresponds to the specified `fileHost` cannot be obtained
from the internal collection, or if the `Stream` is already positioned at
the beginning of the data, then the method does nothing.

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
