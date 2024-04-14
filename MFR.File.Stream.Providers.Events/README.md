<a name='assembly'></a>
# MFR.File.Stream.Providers.Events

## Contents

- [FileHostCreateFailedEventArgs](#T-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventArgs 'MFR.File.Stream.Providers.Events.FileHostCreateFailedEventArgs')
  - [#ctor(pathname,exception)](#M-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventArgs-#ctor-System-String,System-Exception- 'MFR.File.Stream.Providers.Events.FileHostCreateFailedEventArgs.#ctor(System.String,System.Exception)')
  - [Exception](#P-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventArgs-Exception 'MFR.File.Stream.Providers.Events.FileHostCreateFailedEventArgs.Exception')
  - [Pathname](#P-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventArgs-Pathname 'MFR.File.Stream.Providers.Events.FileHostCreateFailedEventArgs.Pathname')
- [FileHostCreateFailedEventHandler](#T-MFR-File-Stream-Providers-Events-FileHostCreateFailedEventHandler 'MFR.File.Stream.Providers.Events.FileHostCreateFailedEventHandler')
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
