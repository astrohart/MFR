<a name='assembly'></a>
# MFR.File.Stream.Providers.Tests

## Contents

- [FileHostProviderTests](#T-MFR-File-Stream-Providers-Tests-FileHostProviderTests 'MFR.File.Stream.Providers.Tests.FileHostProviderTests')
  - [#ctor()](#M-MFR-File-Stream-Providers-Tests-FileHostProviderTests-#ctor 'MFR.File.Stream.Providers.Tests.FileHostProviderTests.#ctor')
  - [FileHostProvider](#P-MFR-File-Stream-Providers-Tests-FileHostProviderTests-FileHostProvider 'MFR.File.Stream.Providers.Tests.FileHostProviderTests.FileHostProvider')
  - [Cleanup()](#M-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Cleanup 'MFR.File.Stream.Providers.Tests.FileHostProviderTests.Cleanup')
  - [Initialize()](#M-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Initialize 'MFR.File.Stream.Providers.Tests.FileHostProviderTests.Initialize')
  - [ReadTextFromMemory(accessor,length)](#M-MFR-File-Stream-Providers-Tests-FileHostProviderTests-ReadTextFromMemory-System-Text-Encoding,System-IO-UnmanagedMemoryAccessor,System-Int64- 'MFR.File.Stream.Providers.Tests.FileHostProviderTests.ReadTextFromMemory(System.Text.Encoding,System.IO.UnmanagedMemoryAccessor,System.Int64)')
  - [Test_Open_FilesInFolder()](#M-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Test_Open_FilesInFolder 'MFR.File.Stream.Providers.Tests.FileHostProviderTests.Test_Open_FilesInFolder')
- [Get](#T-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Get 'MFR.File.Stream.Providers.Tests.FileHostProviderTests.Get')
  - [LOG_FILE_PATH_TERMINATOR](#F-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Get-LOG_FILE_PATH_TERMINATOR 'MFR.File.Stream.Providers.Tests.FileHostProviderTests.Get.LOG_FILE_PATH_TERMINATOR')
  - [AssemblyCompany](#P-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Get-AssemblyCompany 'MFR.File.Stream.Providers.Tests.FileHostProviderTests.Get.AssemblyCompany')
  - [AssemblyProduct](#P-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Get-AssemblyProduct 'MFR.File.Stream.Providers.Tests.FileHostProviderTests.Get.AssemblyProduct')
  - [AssemblyTitle](#P-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Get-AssemblyTitle 'MFR.File.Stream.Providers.Tests.FileHostProviderTests.Get.AssemblyTitle')
  - [ApplicationProductName()](#M-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Get-ApplicationProductName 'MFR.File.Stream.Providers.Tests.FileHostProviderTests.Get.ApplicationProductName')
  - [LogFilePath()](#M-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Get-LogFilePath 'MFR.File.Stream.Providers.Tests.FileHostProviderTests.Get.LogFilePath')
- [Resources](#T-MFR-File-Stream-Providers-Tests-Properties-Resources 'MFR.File.Stream.Providers.Tests.Properties.Resources')
  - [Culture](#P-MFR-File-Stream-Providers-Tests-Properties-Resources-Culture 'MFR.File.Stream.Providers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-File-Stream-Providers-Tests-Properties-Resources-ResourceManager 'MFR.File.Stream.Providers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-File-Stream-Providers-Tests-FileHostProviderTests'></a>
## FileHostProviderTests `type`

##### Namespace

MFR.File.Stream.Providers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[FileHostProvider](#T-MFR-File-Stream-Providers-FileHostProvider 'MFR.File.Stream.Providers.FileHostProvider') class.

<a name='M-MFR-File-Stream-Providers-Tests-FileHostProviderTests-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[FileHostProviderTests](#T-MFR-File-Stream-Providers-Tests-FileHostProviderTests 'MFR.File.Stream.Providers.Tests.FileHostProviderTests') and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-File-Stream-Providers-Tests-FileHostProviderTests-FileHostProvider'></a>
### FileHostProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileHostProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileHostProvider 'MFR.File.Stream.Providers.Interfaces.IFileHostProvider')
interface.

<a name='M-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Cleanup'></a>
### Cleanup() `method`

##### Summary

Cleans up/releases system resources after each unit test has completed.

##### Parameters

This method has no parameters.

<a name='M-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the state of this fixture for every unit test session.

##### Parameters

This method has no parameters.

<a name='M-MFR-File-Stream-Providers-Tests-FileHostProviderTests-ReadTextFromMemory-System-Text-Encoding,System-IO-UnmanagedMemoryAccessor,System-Int64-'></a>
### ReadTextFromMemory(accessor,length) `method`

##### Summary

Reads text from a memory-mapped file accessor.

##### Returns

The text read from memory.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessor | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | The memory-mapped file accessor. |
| length | [System.IO.UnmanagedMemoryAccessor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.UnmanagedMemoryAccessor 'System.IO.UnmanagedMemoryAccessor') | The length of the text to read. |

##### Remarks

This method reads text from a memory-mapped file accessor and returns it as a
string.
It reads the specified length of bytes from the accessor and decodes them using
UTF-8 encoding.

<a name='M-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Test_Open_FilesInFolder'></a>
### Test_Open_FilesInFolder() `method`

##### Summary

An integration test of opening file streams on a number of files in the
execution folder of this unit test, and then disposing of the streams.

##### Parameters

This method has no parameters.

<a name='T-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Get'></a>
## Get `type`

##### Namespace

MFR.File.Stream.Providers.Tests.FileHostProviderTests

##### Summary

Exposes static methods to obtain data from various data sources.

<a name='F-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Get-LOG_FILE_PATH_TERMINATOR'></a>
### LOG_FILE_PATH_TERMINATOR `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final piece of the path of the
log file.

<a name='P-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Get-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyCompany](#P-AssemblyMetadata-AssemblyCompany 'AssemblyMetadata.AssemblyCompany') property.

<a name='P-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Get-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyProduct](#P-AssemblyMetadata-AssemblyProduct 'AssemblyMetadata.AssemblyProduct') property.

<a name='P-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Get-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the assembly title defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyTitle](#P-AssemblyMetadata-AssemblyTitle 'AssemblyMetadata.AssemblyTitle') property.

<a name='M-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Get-ApplicationProductName'></a>
### ApplicationProductName() `method`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for
the software product of which this application or class library is a part.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name
for the software product of which this application or class library is a part.

##### Parameters

This method has no parameters.

<a name='M-MFR-File-Stream-Providers-Tests-FileHostProviderTests-Get-LogFilePath'></a>
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
