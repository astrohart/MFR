<a name='assembly'></a>
# MFR.FileSystem.Helpers

## Contents

- [DirectoryInfoExtensions](#T-MFR-FileSystem-Helpers-DirectoryInfoExtensions 'MFR.FileSystem.Helpers.DirectoryInfoExtensions')
  - [RenameTo(folderToBeRenamed,newSubFolderPath,maxRetries)](#M-MFR-FileSystem-Helpers-DirectoryInfoExtensions-RenameTo-Alphaleonis-Win32-Filesystem-DirectoryInfo,System-String,System-Int32- 'MFR.FileSystem.Helpers.DirectoryInfoExtensions.RenameTo(Alphaleonis.Win32.Filesystem.DirectoryInfo,System.String,System.Int32)')
  - [TryRenameFolder(folderToBeRenamed,newSubFolderPath)](#M-MFR-FileSystem-Helpers-DirectoryInfoExtensions-TryRenameFolder-Alphaleonis-Win32-Filesystem-DirectoryInfo,System-String- 'MFR.FileSystem.Helpers.DirectoryInfoExtensions.TryRenameFolder(Alphaleonis.Win32.Filesystem.DirectoryInfo,System.String)')
- [FileHelpers](#T-MFR-FileSystem-Helpers-FileHelpers 'MFR.FileSystem.Helpers.FileHelpers')
  - [CreateOrOpenTextFile(folderName,fileName)](#M-MFR-FileSystem-Helpers-FileHelpers-CreateOrOpenTextFile-System-String,System-String- 'MFR.FileSystem.Helpers.FileHelpers.CreateOrOpenTextFile(System.String,System.String)')
  - [DumpTextToTempFile(text)](#M-MFR-FileSystem-Helpers-FileHelpers-DumpTextToTempFile-System-String- 'MFR.FileSystem.Helpers.FileHelpers.DumpTextToTempFile(System.String)')
  - [FillTextFileWithJunk(path)](#M-MFR-FileSystem-Helpers-FileHelpers-FillTextFileWithJunk-System-String- 'MFR.FileSystem.Helpers.FileHelpers.FillTextFileWithJunk(System.String)')
  - [GetTextContent(path,pathFilter)](#M-MFR-FileSystem-Helpers-FileHelpers-GetTextContent-System-String,System-Predicate{System-String}- 'MFR.FileSystem.Helpers.FileHelpers.GetTextContent(System.String,System.Predicate{System.String})')
  - [MakeSureContainingFolderExists(pathname)](#M-MFR-FileSystem-Helpers-FileHelpers-MakeSureContainingFolderExists-System-String- 'MFR.FileSystem.Helpers.FileHelpers.MakeSureContainingFolderExists(System.String)')
- [FileInfoExtensions](#T-MFR-FileSystem-Helpers-FileInfoExtensions 'MFR.FileSystem.Helpers.FileInfoExtensions')
  - [IsZeroLengthFile(file)](#M-MFR-FileSystem-Helpers-FileInfoExtensions-IsZeroLengthFile-Alphaleonis-Win32-Filesystem-FileInfo- 'MFR.FileSystem.Helpers.FileInfoExtensions.IsZeroLengthFile(Alphaleonis.Win32.Filesystem.FileInfo)')
  - [RenameTo(source,dest)](#M-MFR-FileSystem-Helpers-FileInfoExtensions-RenameTo-Alphaleonis-Win32-Filesystem-FileInfo,System-String- 'MFR.FileSystem.Helpers.FileInfoExtensions.RenameTo(Alphaleonis.Win32.Filesystem.FileInfo,System.String)')
  - [TryRenameTo(source,dest,maxRetries)](#M-MFR-FileSystem-Helpers-FileInfoExtensions-TryRenameTo-Alphaleonis-Win32-Filesystem-FileInfo,System-String,System-Int32- 'MFR.FileSystem.Helpers.FileInfoExtensions.TryRenameTo(Alphaleonis.Win32.Filesystem.FileInfo,System.String,System.Int32)')
- [FileSystemEntryExtensions](#T-MFR-FileSystem-Helpers-FileSystemEntryExtensions 'MFR.FileSystem.Helpers.FileSystemEntryExtensions')
  - [ToDirectoryInfo(entry)](#M-MFR-FileSystem-Helpers-FileSystemEntryExtensions-ToDirectoryInfo-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Helpers.FileSystemEntryExtensions.ToDirectoryInfo(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [ToFileInfo(entry)](#M-MFR-FileSystem-Helpers-FileSystemEntryExtensions-ToFileInfo-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Helpers.FileSystemEntryExtensions.ToFileInfo(MFR.FileSystem.Interfaces.IFileSystemEntry)')
- [Resources](#T-MFR-FileSystem-Helpers-Properties-Resources 'MFR.FileSystem.Helpers.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Helpers-Properties-Resources-Culture 'MFR.FileSystem.Helpers.Properties.Resources.Culture')
  - [Error_ValueCannotBeNullOrWhiteSpace](#P-MFR-FileSystem-Helpers-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace 'MFR.FileSystem.Helpers.Properties.Resources.Error_ValueCannotBeNullOrWhiteSpace')
  - [ResourceManager](#P-MFR-FileSystem-Helpers-Properties-Resources-ResourceManager 'MFR.FileSystem.Helpers.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Helpers-DirectoryInfoExtensions'></a>
## DirectoryInfoExtensions `type`

##### Namespace

MFR.FileSystem.Helpers

##### Summary

Helper methods for working with instances of [DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo').

<a name='M-MFR-FileSystem-Helpers-DirectoryInfoExtensions-RenameTo-Alphaleonis-Win32-Filesystem-DirectoryInfo,System-String,System-Int32-'></a>
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

<a name='M-MFR-FileSystem-Helpers-DirectoryInfoExtensions-TryRenameFolder-Alphaleonis-Win32-Filesystem-DirectoryInfo,System-String-'></a>
### TryRenameFolder(folderToBeRenamed,newSubFolderPath) `method`

##### Summary

Attempts to perform the folder rename operation.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderToBeRenamed | [Alphaleonis.Win32.Filesystem.DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo') | (Required.) Reference to an instance of [DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo') that represents the folder to be renamed. |
| newSubFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new path of the renamed folder. |

<a name='T-MFR-FileSystem-Helpers-FileHelpers'></a>
## FileHelpers `type`

##### Namespace

MFR.FileSystem.Helpers

##### Summary

Static methods to assist in processing files.

<a name='M-MFR-FileSystem-Helpers-FileHelpers-CreateOrOpenTextFile-System-String,System-String-'></a>
### CreateOrOpenTextFile(folderName,fileName) `method`

##### Summary

Creates a blank config.json file in the specified folder. This
method also attempts to create the folder if it does not already exist.

##### Returns

String containing the fully-qualified pathname to the config.json
file. Blank if a problem occurred (either invalid permissions or
some such.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Path to the folder in which to store the config.json file. |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Filename to use for the config file. Config.json is the
default. If this parameter is specified, it can't be a blank string
and must be a valid filename. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the `folderName` or
`fileName`
parameters are blank. |

##### Remarks

This method simply returns the fully-qualified path to the
configuration file if it already exists.

<a name='M-MFR-FileSystem-Helpers-FileHelpers-DumpTextToTempFile-System-String-'></a>
### DumpTextToTempFile(text) `method`

##### Summary

Dumps the specified `text` to a file in the current user's
temporary files directory, and then returns the path to the file thusly
created.

##### Returns

String containing the fully-qualified pathname to the file where the
specified `text` was written.  If an exception occurred, such
as File I/O error, then the return value of this method is the empty string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to be written to the file. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`text`, is passed a blank or `null` string
for a value. |

<a name='M-MFR-FileSystem-Helpers-FileHelpers-FillTextFileWithJunk-System-String-'></a>
### FillTextFileWithJunk(path) `method`

##### Summary

Fills a file with random garbage data of varying size.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Fully-qualified pathname to the file to be
filled with the data.



This method throws [InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') if the
pathname is not an absolute pathname to a file on the disk. |

<a name='M-MFR-FileSystem-Helpers-FileHelpers-GetTextContent-System-String,System-Predicate{System-String}-'></a>
### GetTextContent(path,pathFilter) `method`

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
included in the output collection -- barring other inclusion/exclusion
criteria.



In the event that this parameter is `null`, no path filtering
is done. |

<a name='M-MFR-FileSystem-Helpers-FileHelpers-MakeSureContainingFolderExists-System-String-'></a>
### MakeSureContainingFolderExists(pathname) `method`

##### Summary

If the `pathname` provided contains a fully-qualified
path to a file, then this method makes sure that the folder named in the
path exists.



If it does not, then a new folder with the specified path is created in
order to hold the file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Fully-qualified pathname of a file. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the string
specified in the `pathname` parameter does not refer to a
folder. |

<a name='T-MFR-FileSystem-Helpers-FileInfoExtensions'></a>
## FileInfoExtensions `type`

##### Namespace

MFR.FileSystem.Helpers

##### Summary

Provides helper methods for working with instances of
[FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo').

<a name='M-MFR-FileSystem-Helpers-FileInfoExtensions-IsZeroLengthFile-Alphaleonis-Win32-Filesystem-FileInfo-'></a>
### IsZeroLengthFile(file) `method`

##### Summary

Determines whether the specified `file` has a zero length.

##### Returns

`true` if the `file` parameter is
not `null`, if the file it refers to exists on the
disk, and if the file's length is zero. Otherwise, or if an
operating system error occurred, `false` is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [Alphaleonis.Win32.Filesystem.FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') | (Required.) Reference to an instance of
[FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo')
that describes the
file to be checked. |

<a name='M-MFR-FileSystem-Helpers-FileInfoExtensions-RenameTo-Alphaleonis-Win32-Filesystem-FileInfo,System-String-'></a>
### RenameTo(source,dest) `method`

##### Summary

Renames a file.

##### Returns

`true` if the operation was successful;
`false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [Alphaleonis.Win32.Filesystem.FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') | (Required.) A [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo')
instance that refers to the existing file. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of hte
file's new name. |

##### Remarks

If `source` is `null` or
`dest`
is blank, or some other issue occurs, then this method
returns `false`.

<a name='M-MFR-FileSystem-Helpers-FileInfoExtensions-TryRenameTo-Alphaleonis-Win32-Filesystem-FileInfo,System-String,System-Int32-'></a>
### TryRenameTo(source,dest,maxRetries) `method`

##### Summary

Makes multiple attempts to perform the file-rename operation.



Called by the [RenameTo](#M-MFR-FileSystem-Helpers-FileInfoExtensions-RenameTo 'MFR.FileSystem.Helpers.FileInfoExtensions.RenameTo') method.

##### Returns

`true` if the operation was successfully carried out; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [Alphaleonis.Win32.Filesystem.FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') | (Required.) A [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo')
instance that refers to the existing file. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of hte
file's new name. |
| maxRetries | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Count of retries to perform before giving up, in case the operation experiences an operating system error. |

<a name='T-MFR-FileSystem-Helpers-FileSystemEntryExtensions'></a>
## FileSystemEntryExtensions `type`

##### Namespace

MFR.FileSystem.Helpers

##### Summary

Helper methods for objects that implement the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface.

<a name='M-MFR-FileSystem-Helpers-FileSystemEntryExtensions-ToDirectoryInfo-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### ToDirectoryInfo(entry) `method`

##### Summary

Translates an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface into
an instance of a [DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo') object.



The [DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo') object is initialized
with the value of the
[Path](#P-MFR-IFileSystemEntry-Path 'MFR.IFileSystemEntry.Path')
property.

##### Returns

Reference to an instance of [DirectoryInfo](#T-Alphaleonis-Win32-Filesystem-DirectoryInfo 'Alphaleonis.Win32.Filesystem.DirectoryInfo')
that has been initialized with the value of the
[Path](#P-MFR-IFileSystemEntry-Path 'MFR.IFileSystemEntry.Path')
property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required property,
[Path](#P-MFR-IFileSystemEntry-Path 'MFR.IFileSystemEntry.Path')
, is passed
a blank or `null` string for a value. |

<a name='M-MFR-FileSystem-Helpers-FileSystemEntryExtensions-ToFileInfo-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### ToFileInfo(entry) `method`

##### Summary

Translates an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface into
an instance of a [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') object.



The [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') object is initialized with
the value of the
[Path](#P-MFR-IFileSystemEntry-Path 'MFR.IFileSystemEntry.Path')
property.

##### Returns

Reference to an instance of [FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') that
has been initialized with the value of the
[Path](#P-MFR-IFileSystemEntry-Path 'MFR.IFileSystemEntry.Path')
property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required property,
[Path](#P-MFR-IFileSystemEntry-Path 'MFR.IFileSystemEntry.Path')
, is passed
a blank or `null` string for a value. |

<a name='T-MFR-FileSystem-Helpers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Helpers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Helpers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Helpers-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace'></a>
### Error_ValueCannotBeNullOrWhiteSpace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or whitespace..

<a name='P-MFR-FileSystem-Helpers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
