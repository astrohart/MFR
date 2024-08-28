<a name='assembly'></a>
# MFR.Renamers.Files.Interfaces

## Contents

- [IFileRenamer](#T-MFR-Renamers-Files-Interfaces-IFileRenamer 'MFR.Renamers.Files.Interfaces.IFileRenamer')
  - [IsStarted](#P-MFR-Renamers-Files-Interfaces-IFileRenamer-IsStarted 'MFR.Renamers.Files.Interfaces.IFileRenamer.IsStarted')
  - [LastSolutionFolderPath](#P-MFR-Renamers-Files-Interfaces-IFileRenamer-LastSolutionFolderPath 'MFR.Renamers.Files.Interfaces.IFileRenamer.LastSolutionFolderPath')
  - [LoadedSolutions](#P-MFR-Renamers-Files-Interfaces-IFileRenamer-LoadedSolutions 'MFR.Renamers.Files.Interfaces.IFileRenamer.LoadedSolutions')
  - [RootDirectoryPath](#P-MFR-Renamers-Files-Interfaces-IFileRenamer-RootDirectoryPath 'MFR.Renamers.Files.Interfaces.IFileRenamer.RootDirectoryPath')
  - [ShouldReOpenSolutions](#P-MFR-Renamers-Files-Interfaces-IFileRenamer-ShouldReOpenSolutions 'MFR.Renamers.Files.Interfaces.IFileRenamer.ShouldReOpenSolutions')
  - [ProcessAll(findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-Interfaces-IFileRenamer-ProcessAll-System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.Interfaces.IFileRenamer.ProcessAll(System.String,System.String,System.Predicate{System.String})')
  - [ProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-Interfaces-IFileRenamer-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.Interfaces.IFileRenamer.ProcessAll(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RenameFilesInFolder(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-Interfaces-IFileRenamer-RenameFilesInFolder-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.Interfaces.IFileRenamer.RenameFilesInFolder(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RenameSolutionFolders(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-Interfaces-IFileRenamer-RenameSolutionFolders-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.Interfaces.IFileRenamer.RenameSolutionFolders(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RenameSubFoldersOf(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-Interfaces-IFileRenamer-RenameSubFoldersOf-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.Interfaces.IFileRenamer.RenameSubFoldersOf(System.String,System.String,System.String,System.Predicate{System.String})')
  - [ReplaceTextInFiles(rootFolderPath,findWhat,replaceWith,pathFilter)](#M-MFR-Renamers-Files-Interfaces-IFileRenamer-ReplaceTextInFiles-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Renamers.Files.Interfaces.IFileRenamer.ReplaceTextInFiles(System.String,System.String,System.String,System.Predicate{System.String})')
  - [RequestAbort()](#M-MFR-Renamers-Files-Interfaces-IFileRenamer-RequestAbort 'MFR.Renamers.Files.Interfaces.IFileRenamer.RequestAbort')
  - [StartingFrom(path)](#M-MFR-Renamers-Files-Interfaces-IFileRenamer-StartingFrom-System-String- 'MFR.Renamers.Files.Interfaces.IFileRenamer.StartingFrom(System.String)')
- [Resources](#T-MFR-Renamers-Files-Interfaces-Properties-Resources 'MFR.Renamers.Files.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Renamers-Files-Interfaces-Properties-Resources-Culture 'MFR.Renamers.Files.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Renamers-Files-Interfaces-Properties-Resources-ResourceManager 'MFR.Renamers.Files.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Renamers-Files-Interfaces-IFileRenamer'></a>
## IFileRenamer `type`

##### Namespace

MFR.Renamers.Files.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a
`
            File
            Renamer
            `
object. Such an object is directly responsible for
processing the file operations of this application.

<a name='P-MFR-Renamers-Files-Interfaces-IFileRenamer-IsStarted'></a>
### IsStarted `property`

##### Summary

Gets a value that indicates whether this component is currently processing
operation(s).

<a name='P-MFR-Renamers-Files-Interfaces-IFileRenamer-LastSolutionFolderPath'></a>
### LastSolutionFolderPath `property`

##### Summary

Gets or sets the path to the folder in which last Visual Studio Solution that
we have worked with most recently resides.

<a name='P-MFR-Renamers-Files-Interfaces-IFileRenamer-LoadedSolutions'></a>
### LoadedSolutions `property`

##### Summary

Gets a reference to a collection, each element of which implements the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface.

##### Remarks

Each element of the collection represents a Visual Studio Solution (*.sln) that
is loaded in a running instance of Visual Studio.

<a name='P-MFR-Renamers-Files-Interfaces-IFileRenamer-RootDirectoryPath'></a>
### RootDirectoryPath `property`

##### Summary

Gets a string containing the full pathname of the folder where all
operations start.

<a name='P-MFR-Renamers-Files-Interfaces-IFileRenamer-ShouldReOpenSolutions'></a>
### ShouldReOpenSolutions `property`

##### Summary

Gets a value determining whether the currently-open solution
in Visual Studio should be closed and then re-opened at the
completion of the operation.

<a name='M-MFR-Renamers-Files-Interfaces-IFileRenamer-ProcessAll-System-String,System-String,System-Predicate{System-String}-'></a>
### ProcessAll(findWhat,replaceWith,pathFilter) `method`

##### Summary

Executes the Rename Subfolders, Rename Files, and Replace Text in
Files operation on all the folders and files in the root folder with
the pathname stored in the
[RootDirectoryPath](#P-MFR-FileRenamer-RootDirectoryPath 'MFR.FileRenamer.RootDirectoryPath')
property.

##### Returns

`true` if the operations succeeded;
`false` otherwise.

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

<a name='M-MFR-Renamers-Files-Interfaces-IFileRenamer-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### ProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Executes the Rename Subfolders, Rename Files, and Replace Text in
Files operation on all the folders and files in the root folder with
the pathname specified by the `rootDirectoryPath` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootDirectoryPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | FullName to the recursion root. |
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

<a name='M-MFR-Renamers-Files-Interfaces-IFileRenamer-RenameFilesInFolder-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### RenameFilesInFolder(rootFolderPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Renames all the files in the all the subfolders etc., recursively,
of the folder whose pathname is specified by the
`rootFolderPath`
parameter.

##### Returns

`true` if the operation was successful;
`false` if the operation failed or if the user cancelled the
operation.

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
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either the `rootFolderPath`,
`findWhat`
, or `replaceWith` parameters are blank. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the
`rootFolderPath`
does not exist. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |

<a name='M-MFR-Renamers-Files-Interfaces-IFileRenamer-RenameSolutionFolders-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### RenameSolutionFolders(rootFolderPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Iterates through the directory tree that is topped by the folder having the
specified `rootFolderPath`, and, for all Visual Studio
Solution (`*.sln`) file(s) found in the directory tree, renames them
according to the text-replacement pattern specified by the arguments of the
`findWhat` and `replaceWith` parameters.

##### Returns

`true` if the operation succeeded;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a folder in which the operation is to start. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Text to be found in each file contained in the directory tree. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text that the text
specified by the argument of the `findWhat` parameter is to
be replaced with. |
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
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the
`rootFolderPath`
does not exist. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |

<a name='M-MFR-Renamers-Files-Interfaces-IFileRenamer-RenameSubFoldersOf-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### RenameSubFoldersOf(rootFolderPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Recursively renames all the subfolders in the folder having a
pathname specified by `rootFolderPath`, replacing
any occurrences of the text in the `findWhat`
parameter with the values in the `replaceWith` parameter.

##### Returns

`true` if the operation succeeded;
`false` otherwise.

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
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either the `rootFolderPath`,
`findWhat`
, or `replaceWith` parameters are blank. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the
`rootFolderPath`
does not exist. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |

<a name='M-MFR-Renamers-Files-Interfaces-IFileRenamer-ReplaceTextInFiles-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### ReplaceTextInFiles(rootFolderPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Iterates recursively through a directory tree, starting at the
folder with pathname `rootFolderPath` and replacing
every occurrence of the text specified by the `findWhat` and
`replaceWith` parameters' arguments.

##### Returns

`true` if the operation succeeded;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Pathname of the folder where the operation is to start. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Text to be found in each file contained in the directory tree. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Text to replace all the instances of
`findWhat`
with. If this parameter is blank (the default),
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
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder with pathname specified by the
`rootFolderPath`
does not exist. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown if a file operation does not succeed. |

<a name='M-MFR-Renamers-Files-Interfaces-IFileRenamer-RequestAbort'></a>
### RequestAbort() `method`

##### Summary

Called to ask the `File Renamer` object to stop operations.

##### Parameters

This method has no parameters.

<a name='M-MFR-Renamers-Files-Interfaces-IFileRenamer-StartingFrom-System-String-'></a>
### StartingFrom(path) `method`

##### Summary

Sets the new root directory path from which searches should be started.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of the folder from
which searches should be started.



The fully-qualified pathname passed must reference a folder that currently
exists on the file system; otherwise,
[DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') is thrown. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`path`, is passed a blank or `null` string
for a value. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder whose fully-qualified pathname is passed in the
`path` parameter cannot be located on the file system. |

##### Remarks

Upon successful validation of the fully-qualified folder pathname that is
specified as the value of the `path` parameter, assigns the
value to the [RootDirectoryPath](#P-MFR-Renamers-Files-FileRenamer-RootDirectoryPath 'MFR.Renamers.Files.FileRenamer.RootDirectoryPath')
property.

<a name='T-MFR-Renamers-Files-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Renamers.Files.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Renamers-Files-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Renamers-Files-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
