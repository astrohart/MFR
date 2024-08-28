<a name='assembly'></a>
# MFR.FileSystem.Retrievers.Interfaces

## Contents

- [IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
  - [AndReplaceItWith()](#M-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever-AndReplaceItWith-System-String- 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever.AndReplaceItWith(System.String)')
  - [GetMatchingFileSystemPaths(rootFolderPath,pathFilter)](#M-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever-GetMatchingFileSystemPaths-System-String,System-Predicate{System-String}- 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever.GetMatchingFileSystemPaths(System.String,System.Predicate{System.String})')
  - [ToFindWhat()](#M-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever-ToFindWhat-System-String- 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever.ToFindWhat(System.String)')
  - [UsingSearchPattern(searchPattern)](#M-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever-UsingSearchPattern-System-String- 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever.UsingSearchPattern(System.String)')
  - [WithSearchOption(option)](#M-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever-WithSearchOption-System-IO-SearchOption- 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever.WithSearchOption(System.IO.SearchOption)')
- [Resources](#T-MFR-FileSystem-Retrievers-Interfaces-Properties-Resources 'MFR.FileSystem.Retrievers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Retrievers-Interfaces-Properties-Resources-Culture 'MFR.FileSystem.Retrievers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Retrievers-Interfaces-Properties-Resources-ResourceManager 'MFR.FileSystem.Retrievers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever'></a>
## IFileSystemEntryListRetriever `type`

##### Namespace

MFR.FileSystem.Retrievers.Interfaces

##### Summary

Defines the public-exposed methods and properties of an object that
obtains a list of files from the file system that match certain criteria.



This allows us to specify differing criteria depending on the type of
operation that is being performed.



The results of the searching and filtering is then returned.

<a name='M-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever-AndReplaceItWith-System-String-'></a>
### AndReplaceItWith() `method`

##### Summary

Specifies a string that should be utilized in order to replace a
textual pattern in the name of a file or folder or the contents thereof.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

##### Remarks

The value of the `replaceWith` parameter may be
allowed by some implementations to be blank.

<a name='M-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever-GetMatchingFileSystemPaths-System-String,System-Predicate{System-String}-'></a>
### GetMatchingFileSystemPaths(rootFolderPath,pathFilter) `method`

##### Summary

Gets a list of the files that match the criteria specified by this
object and that correspond to the type of operation being performed.

##### Returns

Collection of instances of objects that implement the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface that
correspond to the file system entries that match the criteria specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the full pathname of the folder in
which to start the search. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) Reference to an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func')
that points to a delegate, accepting the current file or folder's
path as an argument, that returns `true` if the file should be
included in the operation or `false` otherwise.



This parameter is `null` by default. This method should return
`true` to specify that a given file-system entry is to be
included in the output collection -- barring other
inclusion/exclusion criteria.



In the event that this parameter is `null`, no path filtering
is done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `rootFolderPath`,
is passed a blank or `null` string for a value. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder whose pathname is specified by the '
`rootFolderPath`
' parameter cannot be located on the file system. |

<a name='M-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever-ToFindWhat-System-String-'></a>
### ToFindWhat() `method`

##### Summary

Specifies a string that should be utilized in order to filter files
and/or folders.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever-UsingSearchPattern-System-String-'></a>
### UsingSearchPattern(searchPattern) `method`

##### Summary

Specifies a string that is to be used as the search pattern for
enumerating file-system entries.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| searchPattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the search pattern to be utilized.  Default is "*". |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `searchPattern`,
is passed a blank or `null` string for a value. |

##### Remarks

This property may have a blank or `null` value. The default
value is nominally an asterisk; however, classes that implement this
interface may specify something different.



NOTE: Calling this method is optional. If this method is not called,
then the default value will be utilized.

<a name='M-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever-WithSearchOption-System-IO-SearchOption-'></a>
### WithSearchOption(option) `method`

##### Summary

Specifies the [SearchOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.SearchOption 'System.IO.SearchOption') value to be
utilized when performing searches for file system entries.



The idea is that we can search either just the files in the topmost
level of the root folder, or get all files recursively.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| option | [System.IO.SearchOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.SearchOption 'System.IO.SearchOption') | (Required.) A [SearchOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.SearchOption 'System.IO.SearchOption') value to pass
to the file-system enumeration method that is called. |

##### Remarks

Calling this method is optional. If this method is not called, the
type that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Interfaces.IFileSystemEntryListRetriever')
interface will decide what is the default value to be utilized.

<a name='T-MFR-FileSystem-Retrievers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Retrievers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Retrievers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Retrievers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
