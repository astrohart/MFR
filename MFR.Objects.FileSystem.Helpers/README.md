<a name='assembly'></a>
# MFR.Objects.FileSystem.Helpers

## Contents

- [DirectoryInfoExtensions](#T-MFR-Objects-FileSystem-Helpers-DirectoryInfoExtensions 'MFR.Objects.FileSystem.Helpers.DirectoryInfoExtensions')
  - [RenameTo(folderToBeRenamed,newSubFolderPath,maxRetries)](#M-MFR-Objects-FileSystem-Helpers-DirectoryInfoExtensions-RenameTo-Alphaleonis-Win32-Filesystem-DirectoryInfo,System-String,System-Int32- 'MFR.Objects.FileSystem.Helpers.DirectoryInfoExtensions.RenameTo(Alphaleonis.Win32.Filesystem.DirectoryInfo,System.String,System.Int32)')
  - [TryRenameFolder(folderToBeRenamed,newSubFolderPath)](#M-MFR-Objects-FileSystem-Helpers-DirectoryInfoExtensions-TryRenameFolder-Alphaleonis-Win32-Filesystem-DirectoryInfo,System-String- 'MFR.Objects.FileSystem.Helpers.DirectoryInfoExtensions.TryRenameFolder(Alphaleonis.Win32.Filesystem.DirectoryInfo,System.String)')
- [FileHelpers](#T-MFR-Objects-FileSystem-Helpers-FileHelpers 'MFR.Objects.FileSystem.Helpers.FileHelpers')
  - [FillWithJunk(path)](#M-MFR-Objects-FileSystem-Helpers-FileHelpers-FillWithJunk-System-String- 'MFR.Objects.FileSystem.Helpers.FileHelpers.FillWithJunk(System.String)')
  - [GetContent(path,pathFilter)](#M-MFR-Objects-FileSystem-Helpers-FileHelpers-GetContent-System-String,System-Predicate{System-String}- 'MFR.Objects.FileSystem.Helpers.FileHelpers.GetContent(System.String,System.Predicate{System.String})')
- [FileInfoExtensions](#T-MFR-Objects-FileSystem-Helpers-FileInfoExtensions 'MFR.Objects.FileSystem.Helpers.FileInfoExtensions')
  - [IsZeroLengthFile(fileInfo)](#M-MFR-Objects-FileSystem-Helpers-FileInfoExtensions-IsZeroLengthFile-Alphaleonis-Win32-Filesystem-FileInfo- 'MFR.Objects.FileSystem.Helpers.FileInfoExtensions.IsZeroLengthFile(Alphaleonis.Win32.Filesystem.FileInfo)')
  - [RenameTo(existingFile,newFilePath,maxRetries)](#M-MFR-Objects-FileSystem-Helpers-FileInfoExtensions-RenameTo-Alphaleonis-Win32-Filesystem-FileInfo,System-String,System-Int32- 'MFR.Objects.FileSystem.Helpers.FileInfoExtensions.RenameTo(Alphaleonis.Win32.Filesystem.FileInfo,System.String,System.Int32)')
- [FileSystemEntryExtensions](#T-MFR-Objects-FileSystem-Helpers-FileSystemEntryExtensions 'MFR.Objects.FileSystem.Helpers.FileSystemEntryExtensions')
  - [ToDirectoryInfo(entry)](#M-MFR-Objects-FileSystem-Helpers-FileSystemEntryExtensions-ToDirectoryInfo-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Objects.FileSystem.Helpers.FileSystemEntryExtensions.ToDirectoryInfo(MFR.Objects.FileSystem.Interfaces.IFileSystemEntry)')
  - [ToFileInfo(entry)](#M-MFR-Objects-FileSystem-Helpers-FileSystemEntryExtensions-ToFileInfo-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Objects.FileSystem.Helpers.FileSystemEntryExtensions.ToFileInfo(MFR.Objects.FileSystem.Interfaces.IFileSystemEntry)')
- [Resources](#T-MFR-Objects-FileSystem-Helpers-Properties-Resources 'MFR.Objects.FileSystem.Helpers.Properties.Resources')
  - [Culture](#P-MFR-Objects-FileSystem-Helpers-Properties-Resources-Culture 'MFR.Objects.FileSystem.Helpers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-FileSystem-Helpers-Properties-Resources-ResourceManager 'MFR.Objects.FileSystem.Helpers.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-FileSystem-Helpers-DirectoryInfoExtensions'></a>
## DirectoryInfoExtensions `type`

##### Namespace

MFR.Objects.FileSystem.Helpers

##### Summary

Helper methods for working with instances of [DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo').

<a name='M-MFR-Objects-FileSystem-Helpers-DirectoryInfoExtensions-RenameTo-Alphaleonis-Win32-Filesystem-DirectoryInfo,System-String,System-Int32-'></a>
### RenameTo(folderToBeRenamed,newSubFolderPath,maxRetries) `method`

##### Summary

Renames a folder.

##### Returns

`true` if the rename operation is successful; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderToBeRenamed | [Alphaleonis.Win32.Filesystem.DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo') | A [DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo') describing the folder to
be renamed. |
| newSubFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String containing the pathname of the renamed folder. |
| maxRetries | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Optional.) Set to the maximum retries before giving up. Default is 5. |

##### Remarks

A `maxRetries` parameter is necessary since, during
rename operations, random exceptions keep popping up. Therefore, we
retry the operation until either (a) the operation succeeded, or (b)
the max number of retries has been hit.

<a name='M-MFR-Objects-FileSystem-Helpers-DirectoryInfoExtensions-TryRenameFolder-Alphaleonis-Win32-Filesystem-DirectoryInfo,System-String-'></a>
### TryRenameFolder(folderToBeRenamed,newSubFolderPath) `method`

##### Summary

Attempts to perform the folder rename operation.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderToBeRenamed | [Alphaleonis.Win32.Filesystem.DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo') | (Required.) Reference to an instance of [DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo') that represents the folder to be renamed. |
| newSubFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new path of the renamed folder. |

<a name='T-MFR-Objects-FileSystem-Helpers-FileHelpers'></a>
## FileHelpers `type`

##### Namespace

MFR.Objects.FileSystem.Helpers

##### Summary

Static methods to assist in processing files.

<a name='M-MFR-Objects-FileSystem-Helpers-FileHelpers-FillWithJunk-System-String-'></a>
### FillWithJunk(path) `method`

##### Summary

Fills a file with random garbage data of varying size.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Fully-qualified pathname to the file to be filled with the data.



This method throws [InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') if the pathname is not an absolute pathname to a file on the disk. |

<a name='M-MFR-Objects-FileSystem-Helpers-FileHelpers-GetContent-System-String,System-Predicate{System-String}-'></a>
### GetContent(path,pathFilter) `method`

##### Summary

Reads all the data in from the file whose pathname is given by the '
`path` parameter, caches it, and then returns it.

##### Returns

String containing the file's contents; otherwise, the empty string
if the file does not meet the criteria specified in the path filter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of the
file to be read. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) Reference to an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func')
that points to a delegate, accepting the current file or folder's
path as an argument, that returns `true` if the file should be
included in the operation or `false` otherwise.



This parameter is `null` by default. This method should return
`true` to specify that a given file-system entry is to be
included in the output collection -- barring other inclusion/exclusion criteria.



In the event that this parameter is `null`, no path filtering
is done. |

<a name='T-MFR-Objects-FileSystem-Helpers-FileInfoExtensions'></a>
## FileInfoExtensions `type`

##### Namespace

MFR.Objects.FileSystem.Helpers

##### Summary

Helper methods for working with instances of
[FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo').

<a name='M-MFR-Objects-FileSystem-Helpers-FileInfoExtensions-IsZeroLengthFile-Alphaleonis-Win32-Filesystem-FileInfo-'></a>
### IsZeroLengthFile(fileInfo) `method`

##### Summary

Determines whether a file is zero bytes in length or not.

##### Returns

`true` if the `fileInfo` references
a file that exists yet is zero bytes in length.
`false`
if the file does not exist or if the length of
the file is greater than zero.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileInfo | [Alphaleonis.Win32.Filesystem.FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') | (Required.) A [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo')
that represents the file whose length is to be checked. |

<a name='M-MFR-Objects-FileSystem-Helpers-FileInfoExtensions-RenameTo-Alphaleonis-Win32-Filesystem-FileInfo,System-String,System-Int32-'></a>
### RenameTo(existingFile,newFilePath,maxRetries) `method`

##### Summary

Renames a file.

##### Returns

`true` if the rename operation is successful;
`false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| existingFile | [Alphaleonis.Win32.Filesystem.FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') | A [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') describing
the file to be renamed. |
| newFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String containing the fully-qualified pathname of the renamed file. |
| maxRetries | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Optional.) Integer specifying the maximum retries of the operation.
Must be greater than zero. The default value is `5`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Throw if the `maxRetries` argument is zero or a
negative number.



Since this number is a count of retries, it must be 1 or greater. |

<a name='T-MFR-Objects-FileSystem-Helpers-FileSystemEntryExtensions'></a>
## FileSystemEntryExtensions `type`

##### Namespace

MFR.Objects.FileSystem.Helpers

##### Summary

Helper methods for objects that implement the
[IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
interface.

<a name='M-MFR-Objects-FileSystem-Helpers-FileSystemEntryExtensions-ToDirectoryInfo-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
### ToDirectoryInfo(entry) `method`

##### Summary

Translates an instance of an object that implements the
[IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
interface into
an instance of a [DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo') object.



The [DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo') object is initialized
with the value of the
[Path](#P-MFR-Objects-IFileSystemEntry-Path 'MFR.Objects.IFileSystemEntry.Path')
property.

##### Returns

Reference to an instance of [DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo')
that has been initialized with the value of the
[Path](#P-MFR-Objects-IFileSystemEntry-Path 'MFR.Objects.IFileSystemEntry.Path')
property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.Objects.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required property,
[Path](#P-MFR-Objects-IFileSystemEntry-Path 'MFR.Objects.IFileSystemEntry.Path')
, is passed
a blank or `null` string for a value. |

<a name='M-MFR-Objects-FileSystem-Helpers-FileSystemEntryExtensions-ToFileInfo-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
### ToFileInfo(entry) `method`

##### Summary

Translates an instance of an object that implements the
[IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
interface into
an instance of a [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') object.



The [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') object is initialized with
the value of the
[Path](#P-MFR-Objects-IFileSystemEntry-Path 'MFR.Objects.IFileSystemEntry.Path')
property.

##### Returns

Reference to an instance of [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') that
has been initialized with the value of the
[Path](#P-MFR-Objects-IFileSystemEntry-Path 'MFR.Objects.IFileSystemEntry.Path')
property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.Objects.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required property,
[Path](#P-MFR-Objects-IFileSystemEntry-Path 'MFR.Objects.IFileSystemEntry.Path')
, is passed
a blank or `null` string for a value. |

<a name='T-MFR-Objects-FileSystem-Helpers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.FileSystem.Helpers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-FileSystem-Helpers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-FileSystem-Helpers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
