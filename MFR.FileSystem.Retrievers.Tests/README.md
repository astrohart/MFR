<a name='assembly'></a>
# MFR.FileSystem.Retrievers.Tests

## Contents

- [FolderToRenameRetrieverTests](#T-MFR-FileSystem-Retrievers-Tests-FolderToRenameRetrieverTests 'MFR.FileSystem.Retrievers.Tests.FolderToRenameRetrieverTests')
  - [Retriever](#P-MFR-FileSystem-Retrievers-Tests-FolderToRenameRetrieverTests-Retriever 'MFR.FileSystem.Retrievers.Tests.FolderToRenameRetrieverTests.Retriever')
  - [Initialize()](#M-MFR-FileSystem-Retrievers-Tests-FolderToRenameRetrieverTests-Initialize 'MFR.FileSystem.Retrievers.Tests.FolderToRenameRetrieverTests.Initialize')
  - [Test_DoGetMatchingFileSystemPaths_ReturnsNonzeroEntries_ForValidSearch()](#M-MFR-FileSystem-Retrievers-Tests-FolderToRenameRetrieverTests-Test_DoGetMatchingFileSystemPaths_ReturnsNonzeroEntries_ForValidSearch 'MFR.FileSystem.Retrievers.Tests.FolderToRenameRetrieverTests.Test_DoGetMatchingFileSystemPaths_ReturnsNonzeroEntries_ForValidSearch')
- [Resources](#T-MFR-FileSystem-Retrievers-Tests-Properties-Resources 'MFR.FileSystem.Retrievers.Tests.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Retrievers-Tests-Properties-Resources-Culture 'MFR.FileSystem.Retrievers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Retrievers-Tests-Properties-Resources-ResourceManager 'MFR.FileSystem.Retrievers.Tests.Properties.Resources.ResourceManager')
- [SolutionFilePathRetrieverTests](#T-MFR-FileSystem-Retrievers-Tests-SolutionFilePathRetrieverTests 'MFR.FileSystem.Retrievers.Tests.SolutionFilePathRetrieverTests')
  - [ROOT_FOLDER](#F-MFR-FileSystem-Retrievers-Tests-SolutionFilePathRetrieverTests-ROOT_FOLDER 'MFR.FileSystem.Retrievers.Tests.SolutionFilePathRetrieverTests.ROOT_FOLDER')
  - [Test_Retriever_Works()](#M-MFR-FileSystem-Retrievers-Tests-SolutionFilePathRetrieverTests-Test_Retriever_Works 'MFR.FileSystem.Retrievers.Tests.SolutionFilePathRetrieverTests.Test_Retriever_Works')

<a name='T-MFR-FileSystem-Retrievers-Tests-FolderToRenameRetrieverTests'></a>
## FolderToRenameRetrieverTests `type`

##### Namespace

MFR.FileSystem.Retrievers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[FolderToRenameRetriever](#T-MFR-FolderToRenameRetriever 'MFR.FolderToRenameRetriever')
class.

<a name='P-MFR-FileSystem-Retrievers-Tests-FolderToRenameRetrieverTests-Retriever'></a>
### Retriever `property`

##### Summary

Gets a reference to an instance of the object that implements the
[IFileSystemEntryListRetriever](#T-MFR-FileSystem-Interfaces-IFileSystemEntryListRetriever 'MFR.FileSystem.Interfaces.IFileSystemEntryListRetriever')
interface for renaming folders.

<a name='M-MFR-FileSystem-Retrievers-Tests-FolderToRenameRetrieverTests-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the state of this fixture for every unit test session.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Retrievers-Tests-FolderToRenameRetrieverTests-Test_DoGetMatchingFileSystemPaths_ReturnsNonzeroEntries_ForValidSearch'></a>
### Test_DoGetMatchingFileSystemPaths_ReturnsNonzeroEntries_ForValidSearch() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='T-MFR-FileSystem-Retrievers-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Retrievers.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Retrievers-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Retrievers-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-FileSystem-Retrievers-Tests-SolutionFilePathRetrieverTests'></a>
## SolutionFilePathRetrieverTests `type`

##### Namespace

MFR.FileSystem.Retrievers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[SolutionFilePathRetriever](#T-MFR-FileSystem-Retrievers-SolutionFilePathRetriever 'MFR.FileSystem.Retrievers.SolutionFilePathRetriever') class.

<a name='F-MFR-FileSystem-Retrievers-Tests-SolutionFilePathRetrieverTests-ROOT_FOLDER'></a>
### ROOT_FOLDER `constants`

##### Summary

String containing the path to the root folder to use for the search.

<a name='M-MFR-FileSystem-Retrievers-Tests-SolutionFilePathRetrieverTests-Test_Retriever_Works'></a>
### Test_Retriever_Works() `method`

##### Summary

Unit test to ensure that the object used to retrieve solution file pathnames
works correctly.

##### Parameters

This method has no parameters.
