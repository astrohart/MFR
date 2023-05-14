<a name='assembly'></a>
# MFR.FileSystem.Retrievers

## Contents

- [FileAndFolderNameFileSystemEntryListRetrieverBase](#T-MFR-FileSystem-Retrievers-FileAndFolderNameFileSystemEntryListRetrieverBase 'MFR.FileSystem.Retrievers.FileAndFolderNameFileSystemEntryListRetrieverBase')
  - [AndReplaceItWith()](#M-MFR-FileSystem-Retrievers-FileAndFolderNameFileSystemEntryListRetrieverBase-AndReplaceItWith-System-String- 'MFR.FileSystem.Retrievers.FileAndFolderNameFileSystemEntryListRetrieverBase.AndReplaceItWith(System.String)')
  - [Reset()](#M-MFR-FileSystem-Retrievers-FileAndFolderNameFileSystemEntryListRetrieverBase-Reset 'MFR.FileSystem.Retrievers.FileAndFolderNameFileSystemEntryListRetrieverBase.Reset')
- [FileSystemEntryListRetrieverBase](#T-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase')
  - [#ctor()](#M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-#ctor 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.#ctor')
  - [ConfigurationProvider](#P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ConfigurationProvider 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.ConfigurationProvider')
  - [CurrentConfiguration](#P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-CurrentConfiguration 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.CurrentConfiguration')
  - [FileStreamProvider](#P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-FileStreamProvider 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.FileStreamProvider')
  - [FileSystemEntryValidatorSays](#P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-FileSystemEntryValidatorSays 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.FileSystemEntryValidatorSays')
  - [FindWhat](#P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-FindWhat 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.FindWhat')
  - [OperationType](#P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-OperationType 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.OperationType')
  - [ReplaceWith](#P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ReplaceWith 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.ReplaceWith')
  - [SearchOption](#P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-SearchOption 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.SearchOption')
  - [SearchPattern](#P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-SearchPattern 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.SearchPattern')
  - [TextExpressionMatchingEngineSays](#P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-TextExpressionMatchingEngineSays 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.TextExpressionMatchingEngineSays')
  - [AndReplaceItWith()](#M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-AndReplaceItWith-System-String- 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.AndReplaceItWith(System.String)')
  - [DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter)](#M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}- 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.DoGetMatchingFileSystemPaths(System.String,System.Predicate{System.String})')
  - [ForFileSystemEntry(entry)](#M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ForFileSystemEntry-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.ForFileSystemEntry(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [GetMatchingFileSystemPaths(rootFolderPath,pathFilter)](#M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-GetMatchingFileSystemPaths-System-String,System-Predicate{System-String}- 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.GetMatchingFileSystemPaths(System.String,System.Predicate{System.String})')
  - [Reset()](#M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-Reset 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.Reset')
  - [SearchCriteriaMatch(entry)](#M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-SearchCriteriaMatch-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.SearchCriteriaMatch(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [ShouldDoPath(path,pathFilter)](#M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ShouldDoPath-System-String,System-Predicate{System-String}- 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.ShouldDoPath(System.String,System.Predicate{System.String})')
  - [ToFindWhat(findWhat)](#M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ToFindWhat-System-String- 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.ToFindWhat(System.String)')
  - [UsingSearchPattern()](#M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-UsingSearchPattern-System-String- 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.UsingSearchPattern(System.String)')
  - [WithSearchOption(option)](#M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-WithSearchOption-System-IO-SearchOption- 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.WithSearchOption(System.IO.SearchOption)')
- [FilesToRenameRetriever](#T-MFR-FileSystem-Retrievers-FilesToRenameRetriever 'MFR.FileSystem.Retrievers.FilesToRenameRetriever')
  - [#ctor()](#M-MFR-FileSystem-Retrievers-FilesToRenameRetriever-#ctor 'MFR.FileSystem.Retrievers.FilesToRenameRetriever.#ctor')
  - [Instance](#P-MFR-FileSystem-Retrievers-FilesToRenameRetriever-Instance 'MFR.FileSystem.Retrievers.FilesToRenameRetriever.Instance')
  - [OperationType](#P-MFR-FileSystem-Retrievers-FilesToRenameRetriever-OperationType 'MFR.FileSystem.Retrievers.FilesToRenameRetriever.OperationType')
  - [#cctor()](#M-MFR-FileSystem-Retrievers-FilesToRenameRetriever-#cctor 'MFR.FileSystem.Retrievers.FilesToRenameRetriever.#cctor')
  - [DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter)](#M-MFR-FileSystem-Retrievers-FilesToRenameRetriever-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}- 'MFR.FileSystem.Retrievers.FilesToRenameRetriever.DoGetMatchingFileSystemPaths(System.String,System.Predicate{System.String})')
- [FolderToRenameRetriever](#T-MFR-FileSystem-Retrievers-FolderToRenameRetriever 'MFR.FileSystem.Retrievers.FolderToRenameRetriever')
  - [#ctor()](#M-MFR-FileSystem-Retrievers-FolderToRenameRetriever-#ctor 'MFR.FileSystem.Retrievers.FolderToRenameRetriever.#ctor')
  - [Instance](#P-MFR-FileSystem-Retrievers-FolderToRenameRetriever-Instance 'MFR.FileSystem.Retrievers.FolderToRenameRetriever.Instance')
  - [OperationType](#P-MFR-FileSystem-Retrievers-FolderToRenameRetriever-OperationType 'MFR.FileSystem.Retrievers.FolderToRenameRetriever.OperationType')
  - [#cctor()](#M-MFR-FileSystem-Retrievers-FolderToRenameRetriever-#cctor 'MFR.FileSystem.Retrievers.FolderToRenameRetriever.#cctor')
  - [DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter)](#M-MFR-FileSystem-Retrievers-FolderToRenameRetriever-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}- 'MFR.FileSystem.Retrievers.FolderToRenameRetriever.DoGetMatchingFileSystemPaths(System.String,System.Predicate{System.String})')
- [Resources](#T-MFR-FileSystem-Retrievers-Properties-Resources 'MFR.FileSystem.Retrievers.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Retrievers-Properties-Resources-Culture 'MFR.FileSystem.Retrievers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Retrievers-Properties-Resources-ResourceManager 'MFR.FileSystem.Retrievers.Properties.Resources.ResourceManager')
- [SolutionFilePathRetriever](#T-MFR-FileSystem-Retrievers-SolutionFilePathRetriever 'MFR.FileSystem.Retrievers.SolutionFilePathRetriever')
  - [#ctor()](#M-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-#ctor 'MFR.FileSystem.Retrievers.SolutionFilePathRetriever.#ctor')
  - [Instance](#P-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-Instance 'MFR.FileSystem.Retrievers.SolutionFilePathRetriever.Instance')
  - [OperationType](#P-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-OperationType 'MFR.FileSystem.Retrievers.SolutionFilePathRetriever.OperationType')
  - [SearchPattern](#P-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-SearchPattern 'MFR.FileSystem.Retrievers.SolutionFilePathRetriever.SearchPattern')
  - [#cctor()](#M-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-#cctor 'MFR.FileSystem.Retrievers.SolutionFilePathRetriever.#cctor')
  - [AndReplaceItWith()](#M-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-AndReplaceItWith-System-String- 'MFR.FileSystem.Retrievers.SolutionFilePathRetriever.AndReplaceItWith(System.String)')
  - [DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter)](#M-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}- 'MFR.FileSystem.Retrievers.SolutionFilePathRetriever.DoGetMatchingFileSystemPaths(System.String,System.Predicate{System.String})')
  - [Reset()](#M-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-Reset 'MFR.FileSystem.Retrievers.SolutionFilePathRetriever.Reset')
  - [UsingSearchPattern()](#M-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-UsingSearchPattern-System-String- 'MFR.FileSystem.Retrievers.SolutionFilePathRetriever.UsingSearchPattern(System.String)')
  - [VerifyConfigurationAttached()](#M-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-VerifyConfigurationAttached 'MFR.FileSystem.Retrievers.SolutionFilePathRetriever.VerifyConfigurationAttached')
- [TextInFilesRetriever](#T-MFR-FileSystem-Retrievers-TextInFilesRetriever 'MFR.FileSystem.Retrievers.TextInFilesRetriever')
  - [#ctor()](#M-MFR-FileSystem-Retrievers-TextInFilesRetriever-#ctor 'MFR.FileSystem.Retrievers.TextInFilesRetriever.#ctor')
  - [FileStreamProvider](#P-MFR-FileSystem-Retrievers-TextInFilesRetriever-FileStreamProvider 'MFR.FileSystem.Retrievers.TextInFilesRetriever.FileStreamProvider')
  - [Instance](#P-MFR-FileSystem-Retrievers-TextInFilesRetriever-Instance 'MFR.FileSystem.Retrievers.TextInFilesRetriever.Instance')
  - [OperationType](#P-MFR-FileSystem-Retrievers-TextInFilesRetriever-OperationType 'MFR.FileSystem.Retrievers.TextInFilesRetriever.OperationType')
  - [#cctor()](#M-MFR-FileSystem-Retrievers-TextInFilesRetriever-#cctor 'MFR.FileSystem.Retrievers.TextInFilesRetriever.#cctor')
  - [AndReplaceItWith()](#M-MFR-FileSystem-Retrievers-TextInFilesRetriever-AndReplaceItWith-System-String- 'MFR.FileSystem.Retrievers.TextInFilesRetriever.AndReplaceItWith(System.String)')
  - [DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter)](#M-MFR-FileSystem-Retrievers-TextInFilesRetriever-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}- 'MFR.FileSystem.Retrievers.TextInFilesRetriever.DoGetMatchingFileSystemPaths(System.String,System.Predicate{System.String})')

<a name='T-MFR-FileSystem-Retrievers-FileAndFolderNameFileSystemEntryListRetrieverBase'></a>
## FileAndFolderNameFileSystemEntryListRetrieverBase `type`

##### Namespace

MFR.FileSystem.Retrievers

##### Summary

Implements functionality that is shared among objects that search file
and folder names.

<a name='M-MFR-FileSystem-Retrievers-FileAndFolderNameFileSystemEntryListRetrieverBase-AndReplaceItWith-System-String-'></a>
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

<a name='M-MFR-FileSystem-Retrievers-FileAndFolderNameFileSystemEntryListRetrieverBase-Reset'></a>
### Reset() `method`

##### Summary

Sets the values of this class' properties to their default values.

##### Parameters

This method has no parameters.

##### Remarks

This method typically is called from a class constructor.

<a name='T-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase'></a>
## FileSystemEntryListRetrieverBase `type`

##### Namespace

MFR.FileSystem.Retrievers

##### Summary

Contains functionality that is shared by all file-system-entry-list
retriever objects across all types of operations.

<a name='M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[FileSystemEntryListRetrieverBase](#T-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ConfigurationProvider'></a>
### ConfigurationProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider')
interface.

##### Remarks

This object allows access to the user projectFileRenamerConfiguration and the
actions
associated with it.

<a name='P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface.

<a name='P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-FileStreamProvider'></a>
### FileStreamProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileStreamProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider')
interface.

<a name='P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-FileSystemEntryValidatorSays'></a>
### FileSystemEntryValidatorSays `property`

##### Summary

Fluent bridge property that accesses the appropriate file-system
entry validator object, that implements the
[IFileSystemEntryValidator](#T-MFR-FileSystem-Interfaces-IFileSystemEntryValidator 'MFR.FileSystem.Interfaces.IFileSystemEntryValidator')
interface, for the current operation type.

##### Remarks

The property is designed to be called as part of a fluent
criteria-evaluation expression.

<a name='P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets a string containing the pattern to be found in the name
and/or contents of a file or folder.

##### Remarks

The value of this property can be set by clients of this object
using the
[ToFindWhat](#M-MFR-IFileSystemEntryListRetriever-ToFindWhat 'MFR.IFileSystemEntryListRetriever.ToFindWhat')
method.

<a name='P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets a string containing the pattern to replace text found
in the contents or name of a folder or file.

##### Remarks

The value of this property can be set by clients of this object
using the
[AndReplaceItWith](#M-MFR-IFileSystemEntryListRetriever-AndReplaceItWith 'MFR.IFileSystemEntryListRetriever.AndReplaceItWith')
method.

<a name='P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-SearchOption'></a>
### SearchOption `property`

##### Summary

A [SearchOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.SearchOption 'System.IO.SearchOption') value to be utilized for
file-system searches.

<a name='P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-SearchPattern'></a>
### SearchPattern `property`

##### Summary

Gets or sets a string that contains a wildcard search pattern.

##### Remarks

This property may have a blank or `null` value. The
default value of this property is nominally an asterisk; however,
classes that implement this interface may specify something different.

<a name='P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-TextExpressionMatchingEngineSays'></a>
### TextExpressionMatchingEngineSays `property`

##### Summary

Fluent bridge property that accesses the appropriate text-expression
matcher object, that implements the
[ITextExpressionMatchingEngine](#T-MFR-ITextExpressionMatchingEngine 'MFR.ITextExpressionMatchingEngine')
interface,
for the current operation type and projectFileRenamerConfiguration.

##### Remarks

The property is designed to be called as part of a fluent
criteria-evaluation expression.

<a name='M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-AndReplaceItWith-System-String-'></a>
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

<a name='M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}-'></a>
### DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter) `method`

##### Summary

Provides the implementation of the
[GetMatchingFileSystemPaths](#M-MFR-FileSystemEntryListRetrieverBase-GetMatchingFileSystemPaths 'MFR.FileSystemEntryListRetrieverBase.GetMatchingFileSystemPaths')
method.

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
| [MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException') | Thrown if no projectFileRenamerConfiguration data is attached to this object. |

##### Remarks

Implementers of this method have a guarantee that the
`rootFolderPath`
parameter contains a fully-qualified
pathname of a folder that exists on the disk, and that the
[ProjectFileRenamerConfiguration](#P-MFR-Settings-ConfigurationComposedObjectBase-ProjectFileRenamerConfiguration 'MFR.Settings.ConfigurationComposedObjectBase.ProjectFileRenamerConfiguration')
property is set to a valid object instance reference.

<a name='M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ForFileSystemEntry-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### ForFileSystemEntry(entry) `method`

##### Summary

Gets a reference to an instance of an object that implements the
[IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression') interface.



This object specifies textual search criteria.



The resulting object instance is then to be composed with
text-expression matching and or replacement-engine objects.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression')
interface.



The properties of the object provide text-search and replacement criteria.

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
| [MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException') | Thrown if no projectFileRenamerConfiguration data is attached to this object. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown in the event that the
[Path](#P-MFR-IFileSystemEntry-Path 'MFR.IFileSystemEntry.Path')
property of
the object referenced by the `entry` parameter is a
blank or `null` string. |

<a name='M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-GetMatchingFileSystemPaths-System-String,System-Predicate{System-String}-'></a>
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
| [MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException') | Thrown if no projectFileRenamerConfiguration data is attached to this object. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder whose pathname is specified by the '
`rootFolderPath`
' parameter cannot be located on the disk. |

<a name='M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-Reset'></a>
### Reset() `method`

##### Summary

Sets the values of this class' properties to their default values.

##### Parameters

This method has no parameters.

##### Remarks

This method typically is called from a class constructor.

<a name='M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-SearchCriteriaMatch-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### SearchCriteriaMatch(entry) `method`

##### Summary

Determines whether the path and/or user-state data in the specified
file system `entry` object matches search and
projectFileRenamerConfiguration criteria specified by the user.

##### Returns

`true` if the `entry` data
satisfies the text-expression match criteria for the current
operation; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface that has the data for the matching process. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |

<a name='M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ShouldDoPath-System-String,System-Predicate{System-String}-'></a>
### ShouldDoPath(path,pathFilter) `method`

##### Summary

Determines whether a certain path should be executed.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file to be checked. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) A reference to an instance of
[String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') that contains additional rules
stating whether to include files or directories. |

<a name='M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-ToFindWhat-System-String-'></a>
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

<a name='M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-UsingSearchPattern-System-String-'></a>
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



Child classes can override this method, e.g., to hard-code the search pattern
value.



NOTE: Calling this method is optional. If this method is not called,
then the default value will be utilized.

<a name='M-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-WithSearchOption-System-IO-SearchOption-'></a>
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
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Interfaces.IFileSystemEntryListRetriever')
interface will decide what is the default value to be utilized.

<a name='T-MFR-FileSystem-Retrievers-FilesToRenameRetriever'></a>
## FilesToRenameRetriever `type`

##### Namespace

MFR.FileSystem.Retrievers

##### Summary

Retrieves lists of file-system entries that should be processed by an
operation that wants to rename the files in a folder and its subfolders.

<a name='M-MFR-FileSystem-Retrievers-FilesToRenameRetriever-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-FileSystem-Retrievers-FilesToRenameRetriever-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[FilesToRenameRetriever](#T-MFR-FileSystem-Retrievers-FilesToRenameRetriever 'MFR.FileSystem.Retrievers.FilesToRenameRetriever').

<a name='P-MFR-FileSystem-Retrievers-FilesToRenameRetriever-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='M-MFR-FileSystem-Retrievers-FilesToRenameRetriever-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Retrievers-FilesToRenameRetriever-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}-'></a>
### DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter) `method`

##### Summary

Gets a list of the files that match the criteria specified by this
object and that correspond to the type of operation being performed.

##### Returns

Collection of instances of objects that implement the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface that correspond to the file system entries that match the
criteria specified.

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
| [MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException') | Thrown if no projectFileRenamerConfiguration data is attached to this object. |

##### Remarks

Implementers of this method have a guarantee that the
`rootFolderPath`
parameter contains a fully-qualified
pathname of a folder that exists on the disk, and that the
[ProjectFileRenamerConfiguration](#P-MFR-Settings-ConfigurationComposedObjectBase-ProjectFileRenamerConfiguration 'MFR.Settings.ConfigurationComposedObjectBase.ProjectFileRenamerConfiguration')
property is set to a valid object instance reference.

<a name='T-MFR-FileSystem-Retrievers-FolderToRenameRetriever'></a>
## FolderToRenameRetriever `type`

##### Namespace

MFR.FileSystem.Retrievers

##### Summary

Retrieves lists of file-system entries that should be processed by an
operation that wants to rename the files in a folder and its subfolders.

<a name='M-MFR-FileSystem-Retrievers-FolderToRenameRetriever-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-FileSystem-Retrievers-FolderToRenameRetriever-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[FolderToRenameRetriever](#T-MFR-FileSystem-Retrievers-FolderToRenameRetriever 'MFR.FileSystem.Retrievers.FolderToRenameRetriever').

<a name='P-MFR-FileSystem-Retrievers-FolderToRenameRetriever-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='M-MFR-FileSystem-Retrievers-FolderToRenameRetriever-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Retrievers-FolderToRenameRetriever-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}-'></a>
### DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter) `method`

##### Summary

Gets a list of the files that match the criteria specified by this
object and that correspond to the type of operation being performed.

##### Returns

Collection of instances of objects that implement the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface that correspond to the file system entries that match the
criteria specified.

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
| [MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException') | Thrown if no projectFileRenamerConfiguration data is attached to this object. |

##### Remarks

Implementers of this method have a guarantee that the
`rootFolderPath`
parameter contains a fully-qualified
pathname of a folder that exists on the disk, and that the
[ProjectFileRenamerConfiguration](#P-MFR-Settings-ConfigurationComposedObjectBase-ProjectFileRenamerConfiguration 'MFR.Settings.ConfigurationComposedObjectBase.ProjectFileRenamerConfiguration')
property is set to a valid object instance reference.

<a name='T-MFR-FileSystem-Retrievers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Retrievers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Retrievers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Retrievers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-FileSystem-Retrievers-SolutionFilePathRetriever'></a>
## SolutionFilePathRetriever `type`

##### Namespace

MFR.FileSystem.Retrievers

##### Summary

Retrieves a list of Visual Studio Solution (`*.sln`) files in a given
directory tree.

<a name='M-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[SolutionFilePathRetriever](#T-MFR-FileSystem-Retrievers-SolutionFilePathRetriever 'MFR.FileSystem.Retrievers.SolutionFilePathRetriever').

<a name='P-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-SearchPattern'></a>
### SearchPattern `property`

##### Summary

Gets or sets a string that contains a wildcard search pattern.

##### Remarks

This property may have a blank or `null` value. The
default value of this property is nominally an asterisk; however,
classes that implement this interface may specify something different.



This particular implementation overrides the
[SearchPattern](#P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-SearchPattern 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.SearchPattern')
property in order to specify `*.sln` as the one and only search pattern to
be utilized with this class.

<a name='M-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-AndReplaceItWith-System-String-'></a>
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



This specific implementation does not need such a "Replace With" value, so
therefore the method
always throws [NotSupportedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotSupportedException 'System.NotSupportedException').

<a name='M-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}-'></a>
### DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter) `method`

##### Summary

Provides the implementation of the
[GetMatchingFileSystemPaths](#M-MFR-FileSystemEntryListRetrieverBase-GetMatchingFileSystemPaths 'MFR.FileSystemEntryListRetrieverBase.GetMatchingFileSystemPaths')
method.

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
| [MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException') | Thrown if no projectFileRenamerConfiguration data is attached to this object. |

##### Remarks

Implementers of this method have a guarantee that the
`rootFolderPath`
parameter contains a fully-qualified
pathname of a folder that exists on the disk, and that the
[ProjectFileRenamerConfiguration](#P-MFR-Settings-ConfigurationComposedObjectBase-ProjectFileRenamerConfiguration 'MFR.Settings.ConfigurationComposedObjectBase.ProjectFileRenamerConfiguration')
property is set to a valid object instance reference.

<a name='M-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-Reset'></a>
### Reset() `method`

##### Summary

Sets the values of this class' properties to their default values.

##### Parameters

This method has no parameters.

##### Remarks

This method typically is called from a class constructor.

<a name='M-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-UsingSearchPattern-System-String-'></a>
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



Child classes can override this method, e.g., to hard-code the search pattern
value.



This particular override hard-codes the
[SearchPattern](#P-MFR-FileSystem-Retrievers-FileSystemEntryListRetrieverBase-SearchPattern 'MFR.FileSystem.Retrievers.FileSystemEntryListRetrieverBase.SearchPattern')
property to always have the value `*.sln`.



NOTE: Calling this method is optional. If this method is not called,
then the default value will be utilized.

<a name='M-MFR-FileSystem-Retrievers-SolutionFilePathRetriever-VerifyConfigurationAttached'></a>
### VerifyConfigurationAttached() `method`

##### Summary

Verifies that projectFileRenamerConfiguration has been attached to this object.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException') | Thrown if no projectFileRenamerConfiguration data is attached to this object. |

##### Remarks

If no projectFileRenamerConfiguration is attached to this object, then
[ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException')
is thrown.



Child classes may override this method, e.g., to make
attaching a projectFileRenamerConfiguration object optional.



This particular override of the method takes no action at all.

<a name='T-MFR-FileSystem-Retrievers-TextInFilesRetriever'></a>
## TextInFilesRetriever `type`

##### Namespace

MFR.FileSystem.Retrievers

##### Summary

Retrieves the list of file system entries (i.e., files and/or folders)
that are to be included in the `Replace Text in Files` operation.

<a name='M-MFR-FileSystem-Retrievers-TextInFilesRetriever-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-FileSystem-Retrievers-TextInFilesRetriever-FileStreamProvider'></a>
### FileStreamProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileStreamProvider](#T-MFR-File-Stream-Providers-Interfaces-IFileStreamProvider 'MFR.File.Stream.Providers.Interfaces.IFileStreamProvider')
interface.

<a name='P-MFR-FileSystem-Retrievers-TextInFilesRetriever-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Retrievers.Interfaces.IFileSystemEntryListRetriever')
interface that represents an object that is capable of searching text in files.

<a name='P-MFR-FileSystem-Retrievers-TextInFilesRetriever-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='M-MFR-FileSystem-Retrievers-TextInFilesRetriever-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Retrievers-TextInFilesRetriever-AndReplaceItWith-System-String-'></a>
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

<a name='M-MFR-FileSystem-Retrievers-TextInFilesRetriever-DoGetMatchingFileSystemPaths-System-String,System-Predicate{System-String}-'></a>
### DoGetMatchingFileSystemPaths(rootFolderPath,pathFilter) `method`

##### Summary

Provides the implementation of the
[GetMatchingFileSystemPaths](#M-MFR-FileSystemEntryListRetrieverBase-GetMatchingFileSystemPaths 'MFR.FileSystemEntryListRetrieverBase.GetMatchingFileSystemPaths')
method.

##### Returns

Collection of instances of objects that implement the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface that correspond to the file system entries that match the
criteria specified.

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
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `rootFolderPath`,
is passed a blank or `null` string for a value. |
| [MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException') | Thrown if no projectFileRenamerConfiguration data is attached to this object. |

##### Remarks

Implementers of this method have a guarantee that the
`rootFolderPath`
parameter contains a fully-qualified
pathname of a folder that exists on the disk, and that the
[ProjectFileRenamerConfiguration](#P-MFR-Settings-ConfigurationComposedObjectBase-ProjectFileRenamerConfiguration 'MFR.Settings.ConfigurationComposedObjectBase.ProjectFileRenamerConfiguration')
property is set to a valid object instance reference.
