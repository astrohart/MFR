<a name='assembly'></a>
# MFR.TextValues.Retrievers.Actions

## Contents

- [Get](#T-MFR-TextValues-Retrievers-Actions-Get 'MFR.TextValues.Retrievers.Actions.Get')
  - [FileStreamProvider](#P-MFR-TextValues-Retrievers-Actions-Get-FileStreamProvider 'MFR.TextValues.Retrievers.Actions.Get.FileStreamProvider')
  - [FileDataAsync(ticket,dispose)](#M-MFR-TextValues-Retrievers-Actions-Get-FileDataAsync-System-Guid,System-Boolean- 'MFR.TextValues.Retrievers.Actions.Get.FileDataAsync(System.Guid,System.Boolean)')
  - [FileTicket(pathname)](#M-MFR-TextValues-Retrievers-Actions-Get-FileTicket-System-String- 'MFR.TextValues.Retrievers.Actions.Get.FileTicket(System.String)')
- [Resources](#T-MFR-TextValues-Retrievers-Actions-Properties-Resources 'MFR.TextValues.Retrievers.Actions.Properties.Resources')
  - [Culture](#P-MFR-TextValues-Retrievers-Actions-Properties-Resources-Culture 'MFR.TextValues.Retrievers.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-TextValues-Retrievers-Actions-Properties-Resources-ResourceManager 'MFR.TextValues.Retrievers.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-TextValues-Retrievers-Actions-Get'></a>
## Get `type`

##### Namespace

MFR.TextValues.Retrievers.Actions

<a name='P-MFR-TextValues-Retrievers-Actions-Get-FileStreamProvider'></a>
### FileStreamProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileStreamProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider')
interface.

<a name='M-MFR-TextValues-Retrievers-Actions-Get-FileDataAsync-System-Guid,System-Boolean-'></a>
### FileDataAsync(ticket,dispose) `method`

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
