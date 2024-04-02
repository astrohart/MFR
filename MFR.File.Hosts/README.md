<a name='assembly'></a>
# MFR.File.Hosts

## Contents

- [FileHost](#T-MFR-File-Hosts-FileHost 'MFR.File.Hosts.FileHost')
  - [#ctor(path)](#M-MFR-File-Hosts-FileHost-#ctor-System-String- 'MFR.File.Hosts.FileHost.#ctor(System.String)')
  - [_stream](#F-MFR-File-Hosts-FileHost-_stream 'MFR.File.Hosts.FileHost._stream')
  - [Accessor](#P-MFR-File-Hosts-FileHost-Accessor 'MFR.File.Hosts.FileHost.Accessor')
  - [Encoding](#P-MFR-File-Hosts-FileHost-Encoding 'MFR.File.Hosts.FileHost.Encoding')
  - [MemoryMappedData](#P-MFR-File-Hosts-FileHost-MemoryMappedData 'MFR.File.Hosts.FileHost.MemoryMappedData')
  - [OriginalLength](#P-MFR-File-Hosts-FileHost-OriginalLength 'MFR.File.Hosts.FileHost.OriginalLength')
  - [Path](#P-MFR-File-Hosts-FileHost-Path 'MFR.File.Hosts.FileHost.Path')
  - [Stream](#P-MFR-File-Hosts-FileHost-Stream 'MFR.File.Hosts.FileHost.Stream')
  - [Dispose()](#M-MFR-File-Hosts-FileHost-Dispose 'MFR.File.Hosts.FileHost.Dispose')
  - [OnStreamChanged()](#M-MFR-File-Hosts-FileHost-OnStreamChanged 'MFR.File.Hosts.FileHost.OnStreamChanged')
- [Resources](#T-MFR-File-Hosts-Properties-Resources 'MFR.File.Hosts.Properties.Resources')
  - [Culture](#P-MFR-File-Hosts-Properties-Resources-Culture 'MFR.File.Hosts.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-File-Hosts-Properties-Resources-ResourceManager 'MFR.File.Hosts.Properties.Resources.ResourceManager')

<a name='T-MFR-File-Hosts-FileHost'></a>
## FileHost `type`

##### Namespace

MFR.File.Hosts

##### Summary

Hosts a file during the `Replace Text in File` process.

<a name='M-MFR-File-Hosts-FileHost-#ctor-System-String-'></a>
### #ctor(path) `constructor`

##### Summary

Constructs a new instance of [FileHost](#T-MFR-File-Hosts-FileHost 'MFR.File.Hosts.FileHost') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file for which this object is to be initialized. |

<a name='F-MFR-File-Hosts-FileHost-_stream'></a>
### _stream `constants`

##### Summary

Reference to an instance of [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') that is a
currently-open file stream.

<a name='P-MFR-File-Hosts-FileHost-Accessor'></a>
### Accessor `property`

##### Summary

Gets a reference to an instance of
[MemoryMappedViewAccessor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.MemoryMappedFiles.MemoryMappedViewAccessor 'System.IO.MemoryMappedFiles.MemoryMappedViewAccessor') that
exposes a read/write, random-access view of the block of memory containing the
contents of a file on the file system whose fully-qualified pathname is given
by the value of the [Path](#P-MFR-File-Hosts-FileHost-Path 'MFR.File.Hosts.FileHost.Path') property.

<a name='P-MFR-File-Hosts-FileHost-Encoding'></a>
### Encoding `property`

##### Summary

Gets or sets a [Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') value that describes the encoding of the file.

<a name='P-MFR-File-Hosts-FileHost-MemoryMappedData'></a>
### MemoryMappedData `property`

##### Summary

Gets a reference to an instance of
[MemoryMappedFile](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.MemoryMappedFiles.MemoryMappedFile 'System.IO.MemoryMappedFiles.MemoryMappedFile')

##### Remarks

If the value of this property is updated, then the
[](#E-MFR-File-Hosts-FileHost-MemoryMappedDataChanged 'MFR.File.Hosts.FileHost.MemoryMappedDataChanged') event is
raised.

<a name='P-MFR-File-Hosts-FileHost-OriginalLength'></a>
### OriginalLength `property`

##### Summary

The original length of the file
[_stream](#F-MFR-File-Hosts-FileHost-_stream 'MFR.File.Hosts.FileHost._stream') as originally passed to the
constructor of this class.

<a name='P-MFR-File-Hosts-FileHost-Path'></a>
### Path `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified pathname
of the file to which this object refers.

<a name='P-MFR-File-Hosts-FileHost-Stream'></a>
### Stream `property`

##### Summary

Gets a reference to an instance of [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') that
refers to a file stream that is currently opened to the file having the
fully-qualified pathname [Path](#P-MFR-File-Hosts-FileHost-Path 'MFR.File.Hosts.FileHost.Path').

<a name='M-MFR-File-Hosts-FileHost-Dispose'></a>
### Dispose() `method`

##### Summary

Performs application-defined tasks associated with freeing, releasing,
or resetting unmanaged resources.

##### Parameters

This method has no parameters.

<a name='M-MFR-File-Hosts-FileHost-OnStreamChanged'></a>
### OnStreamChanged() `method`

##### Summary

Called when the value of the [Stream](#P-MFR-File-Hosts-FileHost-Stream 'MFR.File.Hosts.FileHost.Stream')
property is updated.

##### Parameters

This method has no parameters.

<a name='T-MFR-File-Hosts-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.File.Hosts.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-File-Hosts-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-File-Hosts-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
