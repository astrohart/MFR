<a name='assembly'></a>
# MFR.Renamers.Files.Actions

## Contents

- [Delete](#T-MFR-Renamers-Files-Actions-Delete 'MFR.Renamers.Files.Actions.Delete')
  - [File(pathname)](#M-MFR-Renamers-Files-Actions-Delete-File-System-String- 'MFR.Renamers.Files.Actions.Delete.File(System.String)')
- [Formulate](#T-MFR-Renamers-Files-Actions-Formulate 'MFR.Renamers.Files.Actions.Formulate')
- [List](#T-MFR-Renamers-Files-Actions-List 'MFR.Renamers.Files.Actions.List')
  - [ProcessesLockingFileSystemEntry(pathname)](#M-MFR-Renamers-Files-Actions-List-ProcessesLockingFileSystemEntry-System-String- 'MFR.Renamers.Files.Actions.List.ProcessesLockingFileSystemEntry(System.String)')
- [Resources](#T-MFR-Renamers-Files-Actions-Properties-Resources 'MFR.Renamers.Files.Actions.Properties.Resources')
  - [Culture](#P-MFR-Renamers-Files-Actions-Properties-Resources-Culture 'MFR.Renamers.Files.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Renamers-Files-Actions-Properties-Resources-ResourceManager 'MFR.Renamers.Files.Actions.Properties.Resources.ResourceManager')
- [Scan](#T-MFR-Renamers-Files-Actions-Scan 'MFR.Renamers.Files.Actions.Scan')
  - [FileDataForBinaryControlCharacters(textToBeSearched)](#M-MFR-Renamers-Files-Actions-Scan-FileDataForBinaryControlCharacters-System-String- 'MFR.Renamers.Files.Actions.Scan.FileDataForBinaryControlCharacters(System.String)')
- [Should](#T-MFR-Renamers-Files-Actions-Should 'MFR.Renamers.Files.Actions.Should')
  - [AnyPreviouslyLoadedSolutionsBeReopened(previouslyLoadedSolutions)](#M-MFR-Renamers-Files-Actions-Should-AnyPreviouslyLoadedSolutionsBeReopened-System-Collections-Generic-IList{xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution}- 'MFR.Renamers.Files.Actions.Should.AnyPreviouslyLoadedSolutionsBeReopened(System.Collections.Generic.IList{xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution})')

<a name='T-MFR-Renamers-Files-Actions-Delete'></a>
## Delete `type`

##### Namespace

MFR.Renamers.Files.Actions

##### Summary

Exposes static methods to delete data.

<a name='M-MFR-Renamers-Files-Actions-Delete-File-System-String-'></a>
### File(pathname) `method`

##### Summary

If it exists, deletes the file having the specified
`pathname`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file that is to be deleted from the file system. |

##### Remarks

If the file having the specified `pathname` does not
exist, then this method does nothing.

<a name='T-MFR-Renamers-Files-Actions-Formulate'></a>
## Formulate `type`

##### Namespace

MFR.Renamers.Files.Actions

##### Summary

Exposes static methods to formulate string values with other values as input.

<a name='T-MFR-Renamers-Files-Actions-List'></a>
## List `type`

##### Namespace

MFR.Renamers.Files.Actions

<a name='M-MFR-Renamers-Files-Actions-List-ProcessesLockingFileSystemEntry-System-String-'></a>
### ProcessesLockingFileSystemEntry(pathname) `method`

##### Summary

Find out what process(es) have a lock on the specified file.

##### Returns

Processes locking the file

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Path of the file. |

##### Remarks

See also:
http://msdn.microsoft.com/en-us/library/windows/desktop/aa373661(v=vs.85).aspx
http://wyupdate.googlecode.com/svn-history/r401/trunk/frmFilesInUse.cs (no
copyright in code at time of viewing)

<a name='T-MFR-Renamers-Files-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Renamers.Files.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Renamers-Files-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Renamers-Files-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Renamers-Files-Actions-Scan'></a>
## Scan `type`

##### Namespace

MFR.Renamers.Files.Actions

##### Summary

Exposes static methods to scan file data for patterns.

<a name='M-MFR-Renamers-Files-Actions-Scan-FileDataForBinaryControlCharacters-System-String-'></a>
### FileDataForBinaryControlCharacters(textToBeSearched) `method`

##### Summary

Scans the `textToBeSearched`, one character at a time, for
any non-text ASCII control character bytes.

##### Returns

`true` if any non-text ASCII control characters are
present in the specified `textToBeSearched`, or
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textToBeSearched | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
containing the character-string representation of the contents of a file that
is to be scanned. |

##### Remarks

If this method returns `true`, then it can be safely
assumed that the file from which the specified
`textToBeSearched` came is not an ASCII text file.

<a name='T-MFR-Renamers-Files-Actions-Should'></a>
## Should `type`

##### Namespace

MFR.Renamers.Files.Actions

##### Summary

Exposes static methods to determine whether certain actions should be taken.

<a name='M-MFR-Renamers-Files-Actions-Should-AnyPreviouslyLoadedSolutionsBeReopened-System-Collections-Generic-IList{xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution}-'></a>
### AnyPreviouslyLoadedSolutionsBeReopened(previouslyLoadedSolutions) `method`

##### Summary

Determines whether one or more of the entries in the
`previouslyLoadedSolutions` list has a value of its
[ShouldReopen](#P-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution-ShouldReopen 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution.ShouldReopen')
property that is `true`.

##### Returns

`true` if at least one of the
`previouslyLoadedSolutions` should be reopened;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| previouslyLoadedSolutions | [System.Collections.Generic.IList{xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution}') | (Required.) Reference to an instance of a collection of instances of objects
that implement the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface. |

##### Remarks

This method returns `false` if the argument of the
`previouslyLoadedSolutions` parameter is a
`null` reference.



This method also returns `false` if the count of items in the
`previouslyLoadedSolutions` collection is zero.



If an error occurs while searching the
`previouslyLoadedSolutions` collection, then this method
returns `false`.
