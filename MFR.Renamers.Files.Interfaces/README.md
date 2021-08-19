<a name='assembly'></a>
# MFR.Objects.Renamers.Files.Interfaces

## Contents

- [IFileRenamer](#T-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer 'MFR.Objects.Renamers.Files.Interfaces.IFileRenamer')
  - [RootDirectoryPath](#P-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-RootDirectoryPath 'MFR.Objects.Renamers.Files.Interfaces.IFileRenamer.RootDirectoryPath')
  - [ProcessAll(findWhat,replaceWith,pathFilter)](#M-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-ProcessAll-System-String,System-String,System-Predicate{System-String}- 'MFR.Objects.Renamers.Files.Interfaces.IFileRenamer.ProcessAll(System.String,System.String,System.Predicate{System.String})')
  - [ProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter)](#M-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Objects.Renamers.Files.Interfaces.IFileRenamer.ProcessAll(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RenameFilesInFolder(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-RenameFilesInFolder-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Objects.Renamers.Files.Interfaces.IFileRenamer.RenameFilesInFolder(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RenameSubFoldersOf(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-RenameSubFoldersOf-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Objects.Renamers.Files.Interfaces.IFileRenamer.RenameSubFoldersOf(System.String,System.String,System.String,System.Predicate{System.String})')
  - [ReplaceTextInFiles(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-ReplaceTextInFiles-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Objects.Renamers.Files.Interfaces.IFileRenamer.ReplaceTextInFiles(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RequestAbort()](#M-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-RequestAbort 'MFR.Objects.Renamers.Files.Interfaces.IFileRenamer.RequestAbort')
  - [StartingFrom()](#M-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-StartingFrom-System-String- 'MFR.Objects.Renamers.Files.Interfaces.IFileRenamer.StartingFrom(System.String)')
- [Resources](#T-MFR-Objects-Renamers-Files-Interfaces-Properties-Resources 'MFR.Objects.Renamers.Files.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Renamers-Files-Interfaces-Properties-Resources-Culture 'MFR.Objects.Renamers.Files.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Renamers-Files-Interfaces-Properties-Resources-ResourceManager 'MFR.Objects.Renamers.Files.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer'></a>
## IFileRenamer `type`

##### Namespace

MFR.Objects.Renamers.Files.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a `File
            Renamer` object. Such an object is directly responsible for
processing the file operations of this application.

<a name='P-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-RootDirectoryPath'></a>
### RootDirectoryPath `property`

##### Summary

Gets a string containing the full pathname of the folder where all
operations start.

<a name='M-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-ProcessAll-System-String,System-String,System-Predicate{System-String}-'></a>
### ProcessAll(findWhat,replaceWith,pathFilter) `method`

##### Summary

Executes the Rename Subfolders, Rename Files, and Replace Text in
Files operation on all the folders and files in the root folder with
the pathname stored in the [RootDirectoryPath](#P-MFR-Objects-FileRenamer-RootDirectoryPath 'MFR.Objects.FileRenamer.RootDirectoryPath') property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to search for. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to replace the text specified
by `findWhat` with. |
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

<a name='M-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### ProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Executes the Rename Subfolders, Rename Files, and Replace Text in
Files operation on all the folders and files in the root folder with
the pathname specified by the `rootDirectoryPath` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootDirectoryPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Path to the recursion root. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to search for. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to replace the text specified
by `findWhat` with. |
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

<a name='M-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-RenameFilesInFolder-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### RenameFilesInFolder(rootFolderPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Renames all the files in the all the subfolders etc., recursively,
of the folder whose pathname is specified by the `rootFolderPath` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the full pathname of an existing
directory on the computer that is to be where the operation is started. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to search for. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to replace the text specified
by `findWhat` with. |
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
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either the `rootFolderPath`, `findWhat` , or `replaceWith` parameters are blank. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the `rootFolderPath` does not exist. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |

<a name='M-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-RenameSubFoldersOf-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### RenameSubFoldersOf(rootFolderPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Recursively renames all the subfolders in the folder having a
pathname specified by `rootFolderPath`, replacing
any occurrences of the text in the `findWhat`
parameter with the values in the `replaceWith` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the full pathname of an existing
directory on the computer that is to be where the operation is started. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to search for. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to replace the text specified
by `findWhat` with. |
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
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either the `rootFolderPath`, `findWhat` , or `replaceWith` parameters are blank. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the `rootFolderPath` does not exist. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |

<a name='M-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-ReplaceTextInFiles-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### ReplaceTextInFiles(rootFolderPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Iterates recursively through a directory tree, starting at the
folder with pathname `rootFolderPath` and replacing
every occurrence of the text specified by the `findWhat` parameter with the text specified by the `replaceWith` parameter. A case-sensitive, not-in-exact-word
search is performed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Pathname of the folder where the operation is to start. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Text to be found in each file contained in the directory tree. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Text to replace all the instances of `findWhat` with. If this parameter is blank (the default),
then the text is deleted. |
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
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either the `rootFolderPath` or the
`findWhat` parameters are blank. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the `rootFolderPath` does not exist. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |

<a name='M-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-RequestAbort'></a>
### RequestAbort() `method`

##### Summary

Called to ask the `File Renamer` object to stop operations.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-StartingFrom-System-String-'></a>
### StartingFrom() `method`

##### Summary

Initializes the value of the [RootDirectoryPath](#P-MFR-Objects-Renamers-Files-Interfaces-IFileRenamer-RootDirectoryPath 'MFR.Objects.Renamers.Files.Interfaces.IFileRenamer.RootDirectoryPath')
property to the value specified in the `rootDirectoryPath` parameter.



The value is the starting location of the search operations.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Renamers-Files-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Renamers.Files.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Renamers-Files-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Renamers-Files-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
