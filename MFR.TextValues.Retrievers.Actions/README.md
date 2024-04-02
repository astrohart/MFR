<a name='assembly'></a>
# MFR.TextValues.Retrievers.Actions

## Contents

- [Dispose](#T-MFR-TextValues-Retrievers-Actions-Dispose 'MFR.TextValues.Retrievers.Actions.Dispose')
  - [FileHostProvider](#P-MFR-TextValues-Retrievers-Actions-Dispose-FileHostProvider 'MFR.TextValues.Retrievers.Actions.Dispose.FileHostProvider')
  - [FileStream(ticket)](#M-MFR-TextValues-Retrievers-Actions-Dispose-FileStream-System-Guid- 'MFR.TextValues.Retrievers.Actions.Dispose.FileStream(System.Guid)')
- [Get](#T-MFR-TextValues-Retrievers-Actions-Get 'MFR.TextValues.Retrievers.Actions.Get')
  - [FileHostProvider](#P-MFR-TextValues-Retrievers-Actions-Get-FileHostProvider 'MFR.TextValues.Retrievers.Actions.Get.FileHostProvider')
  - [SemaphoreLocker](#P-MFR-TextValues-Retrievers-Actions-Get-SemaphoreLocker 'MFR.TextValues.Retrievers.Actions.Get.SemaphoreLocker')
  - [SyncRoot](#P-MFR-TextValues-Retrievers-Actions-Get-SyncRoot 'MFR.TextValues.Retrievers.Actions.Get.SyncRoot')
  - [FileData(ticket,dispose)](#M-MFR-TextValues-Retrievers-Actions-Get-FileData-System-Guid,System-Boolean- 'MFR.TextValues.Retrievers.Actions.Get.FileData(System.Guid,System.Boolean)')
  - [FileDataAsync(ticket)](#M-MFR-TextValues-Retrievers-Actions-Get-FileDataAsync-System-Guid- 'MFR.TextValues.Retrievers.Actions.Get.FileDataAsync(System.Guid)')
  - [FileTicket(pathname)](#M-MFR-TextValues-Retrievers-Actions-Get-FileTicket-System-String- 'MFR.TextValues.Retrievers.Actions.Get.FileTicket(System.String)')
  - [ReadTextFromMemory(encoding,accessor,length)](#M-MFR-TextValues-Retrievers-Actions-Get-ReadTextFromMemory-System-Text-Encoding,System-IO-UnmanagedMemoryAccessor,System-Int64- 'MFR.TextValues.Retrievers.Actions.Get.ReadTextFromMemory(System.Text.Encoding,System.IO.UnmanagedMemoryAccessor,System.Int64)')
- [Resources](#T-MFR-TextValues-Retrievers-Actions-Properties-Resources 'MFR.TextValues.Retrievers.Actions.Properties.Resources')
  - [Culture](#P-MFR-TextValues-Retrievers-Actions-Properties-Resources-Culture 'MFR.TextValues.Retrievers.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-TextValues-Retrievers-Actions-Properties-Resources-ResourceManager 'MFR.TextValues.Retrievers.Actions.Properties.Resources.ResourceManager')
- [Rewind](#T-MFR-TextValues-Retrievers-Actions-Rewind 'MFR.TextValues.Retrievers.Actions.Rewind')
  - [FileHostProvider](#P-MFR-TextValues-Retrievers-Actions-Rewind-FileHostProvider 'MFR.TextValues.Retrievers.Actions.Rewind.FileHostProvider')
  - [FileStream(ticket)](#M-MFR-TextValues-Retrievers-Actions-Rewind-FileStream-System-Guid- 'MFR.TextValues.Retrievers.Actions.Rewind.FileStream(System.Guid)')

<a name='T-MFR-TextValues-Retrievers-Actions-Dispose'></a>
## Dispose `type`

##### Namespace

MFR.TextValues.Retrievers.Actions

##### Summary

Exposes static methods to release system resources.

<a name='P-MFR-TextValues-Retrievers-Actions-Dispose-FileHostProvider'></a>
### FileHostProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileHostProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileHostProvider 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider')
interface.

<a name='M-MFR-TextValues-Retrievers-Actions-Dispose-FileStream-System-Guid-'></a>
### FileStream(ticket) `method`

##### Summary

Releases the open file stream that is referred to by the specified
`ticket`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that identifies
the file stream to be closed. |

##### Remarks

The reference to the closed file stream is itself removed from the
internal collection of streams; therefore, after this method returns, the
specified `ticket` is no longer redeemable.

<a name='T-MFR-TextValues-Retrievers-Actions-Get'></a>
## Get `type`

##### Namespace

MFR.TextValues.Retrievers.Actions

##### Summary

Exposes static methods, e.g., to retrieve data from text files.

<a name='P-MFR-TextValues-Retrievers-Actions-Get-FileHostProvider'></a>
### FileHostProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileHostProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileHostProvider 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider')
interface.

<a name='P-MFR-TextValues-Retrievers-Actions-Get-SemaphoreLocker'></a>
### SemaphoreLocker `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ISemaphoreLocker](#T-MFR-TextValues-Retrievers-Synchronization-Interfaces-ISemaphoreLocker 'MFR.TextValues.Retrievers.Synchronization.Interfaces.ISemaphoreLocker')
interface.

<a name='P-MFR-TextValues-Retrievers-Actions-Get-SyncRoot'></a>
### SyncRoot `property`

##### Summary

Gets a reference to an instance of [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') that is to be
used for thread synchronization.

<a name='M-MFR-TextValues-Retrievers-Actions-Get-FileData-System-Guid,System-Boolean-'></a>
### FileData(ticket,dispose) `method`

##### Summary

Extracts the data from the file having a stream open on it that corresponds to
the specified `ticket`.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the content of the
corresponding file, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') if the content
could not be obtained.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that
serves a `ticket` that can be used to extract the data from a stream that
is open on the corresponding file. |
| dispose | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) Indicates whether the underlying file stream
should be disposed when this method has finished executing;
`false` is the default. |

<a name='M-MFR-TextValues-Retrievers-Actions-Get-FileDataAsync-System-Guid-'></a>
### FileDataAsync(ticket) `method`

##### Summary

Extracts the data from the file having a stream open on it that corresponds to
the specified `ticket`.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the content of the
corresponding file, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') if the content
could not be obtained.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that
serves a `ticket` that can be used to extract the data from a stream that
is open on the corresponding file. |

<a name='M-MFR-TextValues-Retrievers-Actions-Get-FileTicket-System-String-'></a>
### FileTicket(pathname) `method`

##### Summary

Gets a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that serves as a `ticket` that
can be later used to extract the data from the file having the specified
`pathname`.

##### Returns

A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that serves as a `ticket`
that can be later used to extract the data from the file having the specified
`pathname`, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid.Empty 'System.Guid.Empty') if a stream
could not be opened on the specified file, or some other error occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is the
fully-qualified pathname of a file upon which to open a file stream. |

<a name='M-MFR-TextValues-Retrievers-Actions-Get-ReadTextFromMemory-System-Text-Encoding,System-IO-UnmanagedMemoryAccessor,System-Int64-'></a>
### ReadTextFromMemory(encoding,accessor,length) `method`

##### Summary

Reads text from a memory-mapped file accessor.

##### Returns

The text read from memory.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | (Required.) Reference to an instance of [Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding')
that represents the text encoding of the file. |
| accessor | [System.IO.UnmanagedMemoryAccessor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.UnmanagedMemoryAccessor 'System.IO.UnmanagedMemoryAccessor') | The memory-mapped file accessor. |
| length | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The length of the text to read. |

##### Remarks

This method reads text from a memory-mapped file accessor and returns it as a
string.
It reads the specified length of bytes from the accessor and decodes them using
UTF-8 encoding.

<a name='T-MFR-TextValues-Retrievers-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.TextValues.Retrievers.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-TextValues-Retrievers-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-TextValues-Retrievers-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-TextValues-Retrievers-Actions-Rewind'></a>
## Rewind `type`

##### Namespace

MFR.TextValues.Retrievers.Actions

##### Summary

Exposes static methods to rewind, e.g., set the file pointer to the beginning,
file streams.

<a name='P-MFR-TextValues-Retrievers-Actions-Rewind-FileHostProvider'></a>
### FileHostProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileHostProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileHostProvider 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider')
interface.

<a name='M-MFR-TextValues-Retrievers-Actions-Rewind-FileStream-System-Guid-'></a>
### FileStream(ticket) `method`

##### Summary

Rewinds the file stream, e.g., moves its file pointer back to the beginning of
the file and releases all buffered data, that corresponds to the specified
`ticket`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that identifies
the file stream to be rewound. |

##### Remarks

This method does nothing if the `ticket` is set to the Zero
GUID, or if the corresponding file stream's file pointer already points to the
beginning of the file.



This method will do a cursory refresh of any buffered data, regardless of
whether the stream ends up needing to be rewound or not.
