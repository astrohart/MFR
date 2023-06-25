<a name='assembly'></a>
# MFR.Detectors

## Contents

- [FileFormatDetector](#T-MFR-Detectors-FileFormatDetector 'MFR.Detectors.FileFormatDetector')
  - [#ctor()](#M-MFR-Detectors-FileFormatDetector-#ctor 'MFR.Detectors.FileFormatDetector.#ctor')
  - [FileStreamProvider](#P-MFR-Detectors-FileFormatDetector-FileStreamProvider 'MFR.Detectors.FileFormatDetector.FileStreamProvider')
  - [Instance](#P-MFR-Detectors-FileFormatDetector-Instance 'MFR.Detectors.FileFormatDetector.Instance')
  - [SyncRoot](#P-MFR-Detectors-FileFormatDetector-SyncRoot 'MFR.Detectors.FileFormatDetector.SyncRoot')
  - [#cctor()](#M-MFR-Detectors-FileFormatDetector-#cctor 'MFR.Detectors.FileFormatDetector.#cctor')
  - [DetectFileFormat(pathname)](#M-MFR-Detectors-FileFormatDetector-DetectFileFormat-System-String- 'MFR.Detectors.FileFormatDetector.DetectFileFormat(System.String)')
  - [DetectFileFormat(pathname,ticket)](#M-MFR-Detectors-FileFormatDetector-DetectFileFormat-System-String,System-Guid- 'MFR.Detectors.FileFormatDetector.DetectFileFormat(System.String,System.Guid)')
  - [DetectFileFormat(ticket)](#M-MFR-Detectors-FileFormatDetector-DetectFileFormat-System-Guid- 'MFR.Detectors.FileFormatDetector.DetectFileFormat(System.Guid)')
  - [GetFileStreamForFile(pathname)](#M-MFR-Detectors-FileFormatDetector-GetFileStreamForFile-System-String- 'MFR.Detectors.FileFormatDetector.GetFileStreamForFile(System.String)')
- [Resources](#T-MFR-Detectors-Properties-Resources 'MFR.Detectors.Properties.Resources')
  - [Culture](#P-MFR-Detectors-Properties-Resources-Culture 'MFR.Detectors.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Detectors-Properties-Resources-ResourceManager 'MFR.Detectors.Properties.Resources.ResourceManager')

<a name='T-MFR-Detectors-FileFormatDetector'></a>
## FileFormatDetector `type`

##### Namespace

MFR.Detectors

##### Summary

A detector of the format of files on the disk.

##### Remarks

This object can prove useful for the `Replace Text in Files` operation.



As it goes without saying that we do not need to text-replacement in a binary
file, we use this object to screen out those files that would not make sense to
be included in a `Replace Text in Files` operation.

<a name='M-MFR-Detectors-FileFormatDetector-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Detectors-FileFormatDetector-FileStreamProvider'></a>
### FileStreamProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileStreamProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider')
interface.

##### Remarks

This object is used to retrieve file streams that have already been
opened on files in order to more quickly and efficiently run detection on them.

<a name='P-MFR-Detectors-FileFormatDetector-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFileFormatDetector](#T-MFR-Detectors-Interfaces-IFileFormatDetector 'MFR.Detectors.Interfaces.IFileFormatDetector') interface.

<a name='P-MFR-Detectors-FileFormatDetector-SyncRoot'></a>
### SyncRoot `property`

##### Summary

Reference to an instance of an object that can be used for thread
synchronization.

<a name='M-MFR-Detectors-FileFormatDetector-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Detectors-FileFormatDetector-DetectFileFormat-System-String-'></a>
### DetectFileFormat(pathname) `method`

##### Summary

Examines the file having the specified `pathname` and
attempts to determine its format (binary or ASCII).

##### Returns

Reference to an instance of an object that implements the
[IFileFormatDetectionResult](#T-MFR-Detectors-Models-IFileFormatDetectionResult 'MFR.Detectors.Models.IFileFormatDetectionResult') interface that
contains data on the file's format.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the fully-qualified pathname of the file to have detection run on it. |

<a name='M-MFR-Detectors-FileFormatDetector-DetectFileFormat-System-String,System-Guid-'></a>
### DetectFileFormat(pathname,ticket) `method`

##### Summary

Examines the file having the specified `pathname` and
attempts to determine its format (binary or ASCII).

##### Returns

Reference to an instance of an object that implements the
[IFileFormatDetectionResult](#T-MFR-Detectors-Models-IFileFormatDetectionResult 'MFR.Detectors.Models.IFileFormatDetectionResult') interface that
contains data on the file's format.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the fully-qualified pathname of the file to have detection run on it. |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that is
used to access the file stream that is open on the desired file. |

<a name='M-MFR-Detectors-FileFormatDetector-DetectFileFormat-System-Guid-'></a>
### DetectFileFormat(ticket) `method`

##### Summary

Attempts to detect whether the file that is represented by an open file stream
that corresponds to the specified `ticket` is a binary or
ASCII file.



NOTE: This method assumes that it is not being passed Unicode files ever.

##### Returns

One of the [DetectedFileFormat](#T-MFR-Detectors-Constants-DetectedFileFormat 'MFR.Detectors.Constants.DetectedFileFormat')
enumeration values that corresponds to the detected format of the file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ticket | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that is
used to access the file stream that is open on the desired file. |

##### Remarks

Callers must call the
[RewindStream](#M-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider-RewindStream 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.RewindStream')
method on the specified `ticket` before the stream is read
from again.

<a name='M-MFR-Detectors-FileFormatDetector-GetFileStreamForFile-System-String-'></a>
### GetFileStreamForFile(pathname) `method`

##### Summary

Attempts to look up the `ticket` for the file stream that has been opened
on the file having the specified `pathname`.



If a stream has not been opened on the file, then one is opened for it.

##### Returns

A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that serves as the `ticket`
for the file stream that has been opened on the file having the specified
`pathname`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file for which a file-stream ticket is to be retrieved. |

##### Remarks

If the file having the specified `pathname` could
not be opened, or does not exist, or if another error occurs, then the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid.Empty 'System.Guid.Empty') value is returned.

<a name='T-MFR-Detectors-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Detectors.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Detectors-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Detectors-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
