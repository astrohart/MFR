<a name='assembly'></a>
# MFR.File.Hosts.Interfaces

## Contents

- [IFileHost](#T-MFR-File-Hosts-Interfaces-IFileHost 'MFR.File.Hosts.Interfaces.IFileHost')
  - [Accessor](#P-MFR-File-Hosts-Interfaces-IFileHost-Accessor 'MFR.File.Hosts.Interfaces.IFileHost.Accessor')
  - [Encoding](#P-MFR-File-Hosts-Interfaces-IFileHost-Encoding 'MFR.File.Hosts.Interfaces.IFileHost.Encoding')
  - [MemoryMappedData](#P-MFR-File-Hosts-Interfaces-IFileHost-MemoryMappedData 'MFR.File.Hosts.Interfaces.IFileHost.MemoryMappedData')
  - [OriginalLength](#P-MFR-File-Hosts-Interfaces-IFileHost-OriginalLength 'MFR.File.Hosts.Interfaces.IFileHost.OriginalLength')
  - [Path](#P-MFR-File-Hosts-Interfaces-IFileHost-Path 'MFR.File.Hosts.Interfaces.IFileHost.Path')
  - [Stream](#P-MFR-File-Hosts-Interfaces-IFileHost-Stream 'MFR.File.Hosts.Interfaces.IFileHost.Stream')
- [Resources](#T-MFR-File-Hosts-Interfaces-Properties-Resources 'MFR.File.Hosts.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-File-Hosts-Interfaces-Properties-Resources-Culture 'MFR.File.Hosts.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-File-Hosts-Interfaces-Properties-Resources-ResourceManager 'MFR.File.Hosts.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-File-Hosts-Interfaces-IFileHost'></a>
## IFileHost `type`

##### Namespace

MFR.File.Hosts.Interfaces

##### Summary

Defines the publicly-exposed events, methods and properties of an object that
hosts a file during the `Replace Text in File` process..

<a name='P-MFR-File-Hosts-Interfaces-IFileHost-Accessor'></a>
### Accessor `property`

##### Summary

Gets a reference to an instance of
[MemoryMappedViewAccessor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.MemoryMappedFiles.MemoryMappedViewAccessor 'System.IO.MemoryMappedFiles.MemoryMappedViewAccessor') that
exposes a read/write, random-access view of the block of memory containing the
contents of a file on the file system whose fully-qualified pathname is given
by the value of the [Path](#P-MFR-File-Hosts-FileHost-Path 'MFR.File.Hosts.FileHost.Path') property.

<a name='P-MFR-File-Hosts-Interfaces-IFileHost-Encoding'></a>
### Encoding `property`

##### Summary

Gets or sets a [Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') value that describes the encoding of the file.

<a name='P-MFR-File-Hosts-Interfaces-IFileHost-MemoryMappedData'></a>
### MemoryMappedData `property`

##### Summary

Gets a reference to an instance of
[MemoryMappedFile](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.MemoryMappedFiles.MemoryMappedFile 'System.IO.MemoryMappedFiles.MemoryMappedFile')

##### Remarks

If the value of this property is updated, then the
[](#E-MFR-File-Hosts-FileHost-MemoryMappedDataChanged 'MFR.File.Hosts.FileHost.MemoryMappedDataChanged') event is
raised.

<a name='P-MFR-File-Hosts-Interfaces-IFileHost-OriginalLength'></a>
### OriginalLength `property`

##### Summary

The original length of the file
[_stream](#F-MFR-File-Hosts-FileHost-_stream 'MFR.File.Hosts.FileHost._stream') as originally passed to the
constructor of this class.

<a name='P-MFR-File-Hosts-Interfaces-IFileHost-Path'></a>
### Path `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified pathname
of the file to which this object refers.

<a name='P-MFR-File-Hosts-Interfaces-IFileHost-Stream'></a>
### Stream `property`

##### Summary

Gets a reference to an instance of [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') that
refers to a file stream that is currently opened to the file having the
fully-qualified pathname [Path](#P-MFR-File-Hosts-FileHost-Path 'MFR.File.Hosts.FileHost.Path').

<a name='T-MFR-File-Hosts-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.File.Hosts.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-File-Hosts-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-File-Hosts-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
