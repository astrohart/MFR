<a name='assembly'></a>
# MFR.File.Stream.Providers.Tests

## Contents

- [FileStreamProviderTests](#T-MFR-File-Stream-Providers-Tests-FileStreamProviderTests 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests')
  - [#ctor()](#M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-#ctor 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests.#ctor')
  - [FileStreamProvider](#P-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-FileStreamProvider 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests.FileStreamProvider')
  - [OnFileStreamDisposed(sender,e)](#M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-OnFileStreamDisposed-System-Object,MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs- 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests.OnFileStreamDisposed(System.Object,MFR.File.Stream.Providers.Events.FileStreamDisposedEventArgs)')
  - [OnFileStreamOpenFailed(sender,e)](#M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-OnFileStreamOpenFailed-System-Object,MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs- 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests.OnFileStreamOpenFailed(System.Object,MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs)')
  - [OnFileStreamOpened(sender,e)](#M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-OnFileStreamOpened-System-Object,MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs- 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests.OnFileStreamOpened(System.Object,MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs)')
  - [OnFileStreamOpening(sender,e)](#M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-OnFileStreamOpening-System-Object,MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs- 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests.OnFileStreamOpening(System.Object,MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs)')
  - [Test_Open_FilesInFolder()](#M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Test_Open_FilesInFolder 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests.Test_Open_FilesInFolder')
- [Get](#T-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Get 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests.Get')
  - [LOG_FILE_PATH_TERMINATOR](#F-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Get-LOG_FILE_PATH_TERMINATOR 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests.Get.LOG_FILE_PATH_TERMINATOR')
  - [AssemblyCompany](#P-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Get-AssemblyCompany 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests.Get.AssemblyCompany')
  - [AssemblyProduct](#P-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Get-AssemblyProduct 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests.Get.AssemblyProduct')
  - [AssemblyTitle](#P-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Get-AssemblyTitle 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests.Get.AssemblyTitle')
  - [ApplicationProductName()](#M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Get-ApplicationProductName 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests.Get.ApplicationProductName')
  - [LogFilePath()](#M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Get-LogFilePath 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests.Get.LogFilePath')
- [Resources](#T-MFR-File-Stream-Providers-Tests-Properties-Resources 'MFR.File.Stream.Providers.Tests.Properties.Resources')
  - [Culture](#P-MFR-File-Stream-Providers-Tests-Properties-Resources-Culture 'MFR.File.Stream.Providers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-File-Stream-Providers-Tests-Properties-Resources-ResourceManager 'MFR.File.Stream.Providers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-File-Stream-Providers-Tests-FileStreamProviderTests'></a>
## FileStreamProviderTests `type`

##### Namespace

MFR.File.Stream.Providers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[FileStreamProvider](#T-MFR-File-Stream-Providers-FileStreamProvider 'MFR.File.Stream.Providers.FileStreamProvider') class.

<a name='M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[FileStreamProviderTests](#T-MFR-File-Stream-Providers-Tests-FileStreamProviderTests 'MFR.File.Stream.Providers.Tests.FileStreamProviderTests') and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-FileStreamProvider'></a>
### FileStreamProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileStreamProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider')
interface.

<a name='M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-OnFileStreamDisposed-System-Object,MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs-'></a>
### OnFileStreamDisposed(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-FileStreamDisposed 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.FileStreamDisposed')
event raised by the file stream provider object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [MFR.File.Stream.Providers.Events.FileStreamDisposedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamDisposedEventArgs') | A
[FileStreamDisposedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamDisposedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamDisposedEventArgs')
that contains the event data. |

##### Remarks

This method responds by writing a logging message explaining that a
file stream opened on a specific file was disposed.

<a name='M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-OnFileStreamOpenFailed-System-Object,MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs-'></a>
### OnFileStreamOpenFailed(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-FileStreamOpenFailed 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.FileStreamOpenFailed')
event raised by the DESC.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs') | A
[FileStreamOpenFailedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpenFailedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpenFailedEventArgs')
that contains the event data. |

##### Remarks



<a name='M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-OnFileStreamOpened-System-Object,MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs-'></a>
### OnFileStreamOpened(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-FileStreamOpened 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.FileStreamOpened')
event raised by the file stream provider object..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs') | A
[FileStreamOpenedEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpenedEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs')
that contains the event data. |

##### Remarks

This method responds by writing the fully-qualified pathname of the
file on which the new stream was opened, to the log file.

<a name='M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-OnFileStreamOpening-System-Object,MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs-'></a>
### OnFileStreamOpening(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-FileStreamOpening 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.FileStreamOpening')
event raised by the DESC.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs') | A
[FileStreamOpeningEventArgs](#T-MFR-File-Stream-Providers-Events-FileStreamOpeningEventArgs 'MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs')
that contains the event data. |

##### Remarks

This method responds by writing a message to the debugging log stating
that we are attempting to open a `FileStream` upon a particular file.

<a name='M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Test_Open_FilesInFolder'></a>
### Test_Open_FilesInFolder() `method`

##### Summary

An integration test of opening file streams on a number of files in the
execution folder of this unit test, and then disposing of the streams.

##### Parameters

This method has no parameters.

<a name='T-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Get'></a>
## Get `type`

##### Namespace

MFR.File.Stream.Providers.Tests.FileStreamProviderTests

##### Summary

Exposes static methods to obtain data from various data sources.

<a name='F-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Get-LOG_FILE_PATH_TERMINATOR'></a>
### LOG_FILE_PATH_TERMINATOR `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final piece of the path of the
log file.

<a name='P-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Get-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyCompany](#P-AssemblyMetadata-AssemblyCompany 'AssemblyMetadata.AssemblyCompany') property.

<a name='P-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Get-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyProduct](#P-AssemblyMetadata-AssemblyProduct 'AssemblyMetadata.AssemblyProduct') property.

<a name='P-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Get-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the assembly title defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyTitle](#P-AssemblyMetadata-AssemblyTitle 'AssemblyMetadata.AssemblyTitle') property.

<a name='M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Get-ApplicationProductName'></a>
### ApplicationProductName() `method`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for
the software product of which this application or class library is a part.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name
for the software product of which this application or class library is a part.

##### Parameters

This method has no parameters.

<a name='M-MFR-File-Stream-Providers-Tests-FileStreamProviderTests-Get-LogFilePath'></a>
### LogFilePath() `method`

##### Summary

Obtains a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Parameters

This method has no parameters.

<a name='T-MFR-File-Stream-Providers-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.File.Stream.Providers.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-File-Stream-Providers-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-File-Stream-Providers-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
