<a name='assembly'></a>
# MFR.Objects.FileSystem.Retrievers

## Contents

- [FileAndFolderNameFileSystemEntryListRetrieverBase](#T-MFR-Objects-FileSystem-Retrievers-FileAndFolderNameFileSystemEntryListRetrieverBase 'MFR.Objects.FileSystem.Retrievers.FileAndFolderNameFileSystemEntryListRetrieverBase')
  - [AndReplaceItWith()](#M-MFR-Objects-FileSystem-Retrievers-FileAndFolderNameFileSystemEntryListRetrieverBase-AndReplaceItWith-System-String- 'MFR.Objects.FileSystem.Retrievers.FileAndFolderNameFileSystemEntryListRetrieverBase.AndReplaceItWith(System.String)')
  - [Reset()](#M-MFR-Objects-FileSystem-Retrievers-FileAndFolderNameFileSystemEntryListRetrieverBase-Reset 'MFR.Objects.FileSystem.Retrievers.FileAndFolderNameFileSystemEntryListRetrieverBase.Reset')
- [FileSystemEntryListRetrieverBase](#T-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase')
  - [#ctor()](#M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-#ctor 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.#ctor')
  - [FileSystemEntryValidatorSays](#P-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-FileSystemEntryValidatorSays 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.FileSystemEntryValidatorSays')
  - [FindWhat](#P-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-FindWhat 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.FindWhat')
  - [OperationType](#P-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-OperationType 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.OperationType')
  - [ReplaceWith](#P-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ReplaceWith 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.ReplaceWith')
  - [SearchOption](#P-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-SearchOption 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.SearchOption')
  - [SearchPattern](#P-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-SearchPattern 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.SearchPattern')
  - [TextExpressionMatchingEngineSays](#P-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-TextExpressionMatchingEngineSays 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.TextExpressionMatchingEngineSays')
  - [AndReplaceItWith()](#M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-AndReplaceItWith-System-String- 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.AndReplaceItWith(System.String)')
  - [DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter)](#M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}- 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.DoGetMatchingFileSystemPaths(System.String,System.Predicate{System.String})')
  - [ForFileSystemEntry(entry)](#M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ForFileSystemEntry-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.ForFileSystemEntry(MFR.Objects.FileSystem.Interfaces.IFileSystemEntry)')
  - [GetMatchingFileSystemPaths(rootFolderPath,pathFilter)](#M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-GetMatchingFileSystemPaths-System-String,System-Predicate{System-String}- 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.GetMatchingFileSystemPaths(System.String,System.Predicate{System.String})')
  - [PassesPathFilter(pathFilter,entry)](#M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-PassesPathFilter-System-Predicate{System-String},MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.PassesPathFilter(System.Predicate{System.String},MFR.Objects.FileSystem.Interfaces.IFileSystemEntry)')
  - [Reset()](#M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-Reset 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.Reset')
  - [SearchCriteriaMatch(entry)](#M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-SearchCriteriaMatch-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.SearchCriteriaMatch(MFR.Objects.FileSystem.Interfaces.IFileSystemEntry)')
  - [ToFindWhat(findWhat)](#M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ToFindWhat-System-String- 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.ToFindWhat(System.String)')
  - [UsingSearchPattern()](#M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-UsingSearchPattern-System-String- 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.UsingSearchPattern(System.String)')
  - [WithSearchOption(option)](#M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-WithSearchOption-System-IO-SearchOption- 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.WithSearchOption(System.IO.SearchOption)')
- [FilesToRenameRetriever](#T-MFR-Objects-FileSystem-Retrievers-FilesToRenameRetriever 'MFR.Objects.FileSystem.Retrievers.FilesToRenameRetriever')
  - [OperationType](#P-MFR-Objects-FileSystem-Retrievers-FilesToRenameRetriever-OperationType 'MFR.Objects.FileSystem.Retrievers.FilesToRenameRetriever.OperationType')
  - [DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter)](#M-MFR-Objects-FileSystem-Retrievers-FilesToRenameRetriever-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}- 'MFR.Objects.FileSystem.Retrievers.FilesToRenameRetriever.DoGetMatchingFileSystemPaths(System.String,System.Predicate{System.String})')
- [FolderToRenameRetriever](#T-MFR-Objects-FileSystem-Retrievers-FolderToRenameRetriever 'MFR.Objects.FileSystem.Retrievers.FolderToRenameRetriever')
  - [OperationType](#P-MFR-Objects-FileSystem-Retrievers-FolderToRenameRetriever-OperationType 'MFR.Objects.FileSystem.Retrievers.FolderToRenameRetriever.OperationType')
  - [DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter)](#M-MFR-Objects-FileSystem-Retrievers-FolderToRenameRetriever-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}- 'MFR.Objects.FileSystem.Retrievers.FolderToRenameRetriever.DoGetMatchingFileSystemPaths(System.String,System.Predicate{System.String})')
- [Resources](#T-MFR-Objects-FileSystem-Retrievers-Properties-Resources 'MFR.Objects.FileSystem.Retrievers.Properties.Resources')
  - [Culture](#P-MFR-Objects-FileSystem-Retrievers-Properties-Resources-Culture 'MFR.Objects.FileSystem.Retrievers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-FileSystem-Retrievers-Properties-Resources-ResourceManager 'MFR.Objects.FileSystem.Retrievers.Properties.Resources.ResourceManager')
- [TextInFilesRetriever](#T-MFR-Objects-FileSystem-Retrievers-TextInFilesRetriever 'MFR.Objects.FileSystem.Retrievers.TextInFilesRetriever')
  - [OperationType](#P-MFR-Objects-FileSystem-Retrievers-TextInFilesRetriever-OperationType 'MFR.Objects.FileSystem.Retrievers.TextInFilesRetriever.OperationType')
  - [AndReplaceItWith()](#M-MFR-Objects-FileSystem-Retrievers-TextInFilesRetriever-AndReplaceItWith-System-String- 'MFR.Objects.FileSystem.Retrievers.TextInFilesRetriever.AndReplaceItWith(System.String)')
  - [DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter)](#M-MFR-Objects-FileSystem-Retrievers-TextInFilesRetriever-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}- 'MFR.Objects.FileSystem.Retrievers.TextInFilesRetriever.DoGetMatchingFileSystemPaths(System.String,System.Predicate{System.String})')

<a name='T-MFR-Objects-FileSystem-Retrievers-FileAndFolderNameFileSystemEntryListRetrieverBase'></a>
## FileAndFolderNameFileSystemEntryListRetrieverBase `type`

##### Namespace

MFR.Objects.FileSystem.Retrievers

##### Summary

Implements functionality that is shared among objects that search file
and folder names.

<a name='M-MFR-Objects-FileSystem-Retrievers-FileAndFolderNameFileSystemEntryListRetrieverBase-AndReplaceItWith-System-String-'></a>
### AndReplaceItWith() `method`

##### Summary

Specifies a string that should be utilized in order to replace a
textual pattern in the name of a file or folder or the contents thereof.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `replaceWith`, is
passed a blank or `null` string for a value. |

##### Remarks

The value of the `replaceWith` parameter may be
allowed by some implementations to be blank.



This particular implementation requires a non-blank value be specified.

<a name='M-MFR-Objects-FileSystem-Retrievers-FileAndFolderNameFileSystemEntryListRetrieverBase-Reset'></a>
### Reset() `method`

##### Summary

Sets the values of this class' properties to their default values.

##### Parameters

This method has no parameters.

##### Remarks

This method typically is called from a class constructor.

<a name='T-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase'></a>
## FileSystemEntryListRetrieverBase `type`

##### Namespace

MFR.Objects.FileSystem.Retrievers

##### Summary

Contains functionality that is shared by all file-system-entry-list
retriever objects across all types of operations.

<a name='M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[FileSystemEntryListRetrieverBase](#T-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase 'MFR.Objects.FileSystem.Retrievers.FileSystemEntryListRetrieverBase')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-FileSystemEntryValidatorSays'></a>
### FileSystemEntryValidatorSays `property`

##### Summary

Fluent bridge property that accesses the appropriate file-system
entry validator object, that implements the
[IFileSystemEntryValidator](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntryValidator 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntryValidator')
interface, for the current operation type.

##### Remarks

The property is designed to be called as part of a fluent
criteria-evaluation expression.

<a name='P-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets a string containing the pattern to be found in the name
and/or contents of a file or folder.

##### Remarks

The value of this property can be set by clients of this object
using the
[ToFindWhat](#M-MFR-Objects-IFileSystemEntryListRetriever-ToFindWhat 'MFR.Objects.IFileSystemEntryListRetriever.ToFindWhat')
method.

<a name='P-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets a string containing the pattern to replace text found
in the contents or name of a folder or file.

##### Remarks

The value of this property can be set by clients of this object
using the
[AndReplaceItWith](#M-MFR-Objects-IFileSystemEntryListRetriever-AndReplaceItWith 'MFR.Objects.IFileSystemEntryListRetriever.AndReplaceItWith')
method.

<a name='P-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-SearchOption'></a>
### SearchOption `property`

##### Summary

A [SearchOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.SearchOption 'System.IO.SearchOption') value to be utilized for
file-system searches.

<a name='P-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-SearchPattern'></a>
### SearchPattern `property`

##### Summary

Gets or sets a string that contains a wildcard search pattern.

##### Remarks

This property may have a blank or `null` value. The
default value of this property is nominally an asterisk; however,
classes that implement this interface may specify something different.

<a name='P-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-TextExpressionMatchingEngineSays'></a>
### TextExpressionMatchingEngineSays `property`

##### Summary

Fluent bridge property that accesses the appropriate text-expression
matcher object, that implements the
[ITextExpressionMatchingEngine](#T-MFR-Objects-ITextExpressionMatchingEngine 'MFR.Objects.ITextExpressionMatchingEngine')
interface,
for the current operation type and configuration.

##### Remarks

The property is designed to be called as part of a fluent
criteria-evaluation expression.

<a name='M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-AndReplaceItWith-System-String-'></a>
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

<a name='M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}-'></a>
### DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter) `method`

##### Summary

Provides the implementation of the
[GetMatchingFileSystemPaths](#M-MFR-Objects-FileSystemEntryListRetrieverBase-GetMatchingFileSystemPaths 'MFR.Objects.FileSystemEntryListRetrieverBase.GetMatchingFileSystemPaths')
method.

##### Returns

Collection of instances of objects that implement the
[IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
interface that
correspond to the file system entries that match the criteria specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the full pathname of the folder in
which to start the search. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) Reference to an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func')
that points to a delegate, accepting the current file or folder's
path as an argument, that returns `true` if the file
should be included in the operation or `false` otherwise.



This parameter is `null` by default. This method
should return `true` to specify that a given
file-system entry is to be included in the output collection --
barring other inclusion/exclusion criteria.



In the event that this parameter is `null`, no path
filtering is done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `rootFolderPath`,
is passed a blank or `null` string for a value. |
| [MFR.Objects.ConfigurationNotAttachedException](#T-MFR-Objects-ConfigurationNotAttachedException 'MFR.Objects.ConfigurationNotAttachedException') | Thrown if no configuration data is attached to this object. |

##### Remarks

Implementers of this method have a guarantee that the
`rootFolderPath`
parameter contains a fully-qualified
pathname of a folder that exists on the disk, and that the
[Configuration](#P-MFR-Objects-ConfigurationComposedObjectBase-Configuration 'MFR.Objects.ConfigurationComposedObjectBase.Configuration')
property is set to a valid object instance reference.

<a name='M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ForFileSystemEntry-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
### ForFileSystemEntry(entry) `method`

##### Summary

Gets a reference to an instance of an object that implements the
[IMatchExpression](#T-MFR-Objects-IMatchExpression 'MFR.Objects.IMatchExpression') interface.



This object specifies textual search criteria.



The resulting object instance is then to be composed with
text-expression matching and or replacement-engine objects.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpression](#T-MFR-Objects-IMatchExpression 'MFR.Objects.IMatchExpression')
interface.



The properties of the object provide text-search and replacement criteria.

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
| [MFR.Objects.ConfigurationNotAttachedException](#T-MFR-Objects-ConfigurationNotAttachedException 'MFR.Objects.ConfigurationNotAttachedException') | Thrown if no configuration data is attached to this object. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown in the event that the
[Path](#P-MFR-Objects-IFileSystemEntry-Path 'MFR.Objects.IFileSystemEntry.Path')
property of
the object referenced by the `entry` parameter is a
blank or `null` string. |

<a name='M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-GetMatchingFileSystemPaths-System-String,System-Predicate{System-String}-'></a>
### GetMatchingFileSystemPaths(rootFolderPath,pathFilter) `method`

##### Summary

Gets a list of the files that match the criteria specified by this
object and that correspond to the type of operation being performed.

##### Returns

Collection of instances of objects that implement the
[IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
interface that
correspond to the file system entries that match the criteria specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the full pathname of the folder in
which to start the search. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) Reference to an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func')
that points to a delegate, accepting the current file or folder's
path as an argument, that returns `true` if the file
should be included in the operation or `false` otherwise.



This parameter is `null` by default. This method
should return `true` to specify that a given
file-system entry is to be included in the output collection --
barring other inclusion/exclusion criteria.



In the event that this parameter is `null`, no path
filtering is done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `rootFolderPath`,
is passed a blank or `null` string for a value. |
| [MFR.Objects.ConfigurationNotAttachedException](#T-MFR-Objects-ConfigurationNotAttachedException 'MFR.Objects.ConfigurationNotAttachedException') | Thrown if no configuration data is attached to this object. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder whose pathname is specified by the '
`path`
' parameter cannot be located on the disk. |

<a name='M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-PassesPathFilter-System-Predicate{System-String},MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
### PassesPathFilter(pathFilter,entry) `method`

##### Summary

Determines whether the data in the file-system
`entry`
provided passes the additional path-filtering
crtieria specified by the `pathFilter` predicate.

##### Returns

`true` if the file-system `entry`
passed the path-filtering criteria in `pathFilter`,
or if `pathFilter` is `null`;
otherwise, `false` is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) A [Predicate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate') that points to the
logic to be executed to determine a match to the file-system
`entry` passed. If this parameter is
`null`
, then this method returns `true`. |
| entry | [MFR.Objects.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') | (Optional.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
interface that has the data to run decision-making upon. If this
parameter is `null`, then this method returns
`false`. |

<a name='M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-Reset'></a>
### Reset() `method`

##### Summary

Sets the values of this class' properties to their default values.

##### Parameters

This method has no parameters.

##### Remarks

This method typically is called from a class constructor.

<a name='M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-SearchCriteriaMatch-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
### SearchCriteriaMatch(entry) `method`

##### Summary

Determines whether the path and/or user-state data in the specified
file system `entry` object matches search and
configuration criteria specified by the user.

##### Returns

`true` if the `entry` data
satisfies the text-expression match criteria for the current
operation; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.Objects.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
interface that has the data for the matching process. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |

<a name='M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ToFindWhat-System-String-'></a>
### ToFindWhat(findWhat) `method`

##### Summary

Specifies a string that should be utilized in order to filter files
and/or folders.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that serves as search criteria.



Whitespace may be passed for this parameter, but not the empty
string or `null`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `findWhat`, is
passed either the empty string or `null` string for
a value.



Whitespace may be passed for `findWhat`. |

<a name='M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-UsingSearchPattern-System-String-'></a>
### UsingSearchPattern() `method`

##### Summary

Specifies a string that is to be used as the search pattern for
enumerating file-system entries.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `searchPattern`,
is passed a blank or `null` string for a value. |

##### Remarks

The default value is nominally an asterisk; however, classes that
implement this interface may specify something different.



NOTE: Calling this method is optional. If this method is not called,
then the default value will be utilized.

<a name='M-MFR-Objects-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-WithSearchOption-System-IO-SearchOption-'></a>
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

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | Thrown in the event that an integer is passed for the
`option`
parameter that is not defined by the
[SearchOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.SearchOption 'System.IO.SearchOption')
enumeration. |

##### Remarks

Calling this method is optional. If this method is not called, the
type that implements the
[IFileSystemEntryListRetriever](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntryListRetriever 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntryListRetriever')
interface will decide what is the default value to be utilized.

<a name='T-MFR-Objects-FileSystem-Retrievers-FilesToRenameRetriever'></a>
## FilesToRenameRetriever `type`

##### Namespace

MFR.Objects.FileSystem.Retrievers

##### Summary

Retrieves lists of file-system entries that should be processed by an
operation that wants to rename the files in a folder and its subfolders.

<a name='P-MFR-Objects-FileSystem-Retrievers-FilesToRenameRetriever-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-FileSystem-Retrievers-FilesToRenameRetriever-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}-'></a>
### DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter) `method`

##### Summary

Gets a list of the files that match the criteria specified by this
object and that correspond to the type of operation being performed.

##### Returns

Collection of instances of objects that implement the
[IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
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
| [MFR.Objects.ConfigurationNotAttachedException](#T-MFR-Objects-ConfigurationNotAttachedException 'MFR.Objects.ConfigurationNotAttachedException') | Thrown if no configuration data is attached to this object. |

##### Remarks

Implementers of this method have a guarantee that the
`rootFolderPath`
parameter contains a fully-qualified
pathname of a folder that exists on the disk, and that the
[Configuration](#P-MFR-Objects-ConfigurationComposedObjectBase-Configuration 'MFR.Objects.ConfigurationComposedObjectBase.Configuration')
property is set to a valid object instance reference.

<a name='T-MFR-Objects-FileSystem-Retrievers-FolderToRenameRetriever'></a>
## FolderToRenameRetriever `type`

##### Namespace

MFR.Objects.FileSystem.Retrievers

##### Summary

Retrieves lists of file-system entries that should be processed by an
operation that wants to rename the files in a folder and its subfolders.

<a name='P-MFR-Objects-FileSystem-Retrievers-FolderToRenameRetriever-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-FileSystem-Retrievers-FolderToRenameRetriever-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}-'></a>
### DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter) `method`

##### Summary

Gets a list of the files that match the criteria specified by this
object and that correspond to the type of operation being performed.

##### Returns

Collection of instances of objects that implement the
[IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
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
| [MFR.Objects.ConfigurationNotAttachedException](#T-MFR-Objects-ConfigurationNotAttachedException 'MFR.Objects.ConfigurationNotAttachedException') | Thrown if no configuration data is attached to this object. |

##### Remarks

Implementers of this method have a guarantee that the
`rootFolderPath`
parameter contains a fully-qualified
pathname of a folder that exists on the disk, and that the
[Configuration](#P-MFR-Objects-ConfigurationComposedObjectBase-Configuration 'MFR.Objects.ConfigurationComposedObjectBase.Configuration')
property is set to a valid object instance reference.

<a name='T-MFR-Objects-FileSystem-Retrievers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.FileSystem.Retrievers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-FileSystem-Retrievers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-FileSystem-Retrievers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-FileSystem-Retrievers-TextInFilesRetriever'></a>
## TextInFilesRetriever `type`

##### Namespace

MFR.Objects.FileSystem.Retrievers

<a name='P-MFR-Objects-FileSystem-Retrievers-TextInFilesRetriever-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-FileSystem-Retrievers-TextInFilesRetriever-AndReplaceItWith-System-String-'></a>
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

<a name='M-MFR-Objects-FileSystem-Retrievers-TextInFilesRetriever-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}-'></a>
### DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter) `method`

##### Summary

Provides the implementation of the
[GetMatchingFileSystemPaths](#M-MFR-Objects-FileSystemEntryListRetrieverBase-GetMatchingFileSystemPaths 'MFR.Objects.FileSystemEntryListRetrieverBase.GetMatchingFileSystemPaths')
method.

##### Returns

Collection of instances of objects that implement the
[IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
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
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `rootFolderPath`,
is passed a blank or `null` string for a value. |
| [MFR.Objects.ConfigurationNotAttachedException](#T-MFR-Objects-ConfigurationNotAttachedException 'MFR.Objects.ConfigurationNotAttachedException') | Thrown if no configuration data is attached to this object. |

##### Remarks

Implementers of this method have a guarantee that the
`rootFolderPath`
parameter contains a fully-qualified
pathname of a folder that exists on the disk, and that the
[Configuration](#P-MFR-Objects-ConfigurationComposedObjectBase-Configuration 'MFR.Objects.ConfigurationComposedObjectBase.Configuration')
property is set to a valid object instance reference.
