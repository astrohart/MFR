<a name='assembly'></a>
# MFR.FileSystem.Helpers.Tests

## Contents

- [DirectoryInfoExtensionsTests](#T-MFR-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests 'MFR.FileSystem.Helpers.Tests.DirectoryInfoExtensionsTests')
  - [DEST_FOLDER](#F-MFR-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests-DEST_FOLDER 'MFR.FileSystem.Helpers.Tests.DirectoryInfoExtensionsTests.DEST_FOLDER')
  - [SOURCE_FOLDER](#F-MFR-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests-SOURCE_FOLDER 'MFR.FileSystem.Helpers.Tests.DirectoryInfoExtensionsTests.SOURCE_FOLDER')
  - [GeneratedTempFolderPath](#P-MFR-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests-GeneratedTempFolderPath 'MFR.FileSystem.Helpers.Tests.DirectoryInfoExtensionsTests.GeneratedTempFolderPath')
  - [Test_Directory_RenamedSuccessfully()](#M-MFR-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests-Test_Directory_RenamedSuccessfully 'MFR.FileSystem.Helpers.Tests.DirectoryInfoExtensionsTests.Test_Directory_RenamedSuccessfully')
  - [Test_SourceFolder_DoesNotHave_SameNameAs_SourceFolder()](#M-MFR-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests-Test_SourceFolder_DoesNotHave_SameNameAs_SourceFolder 'MFR.FileSystem.Helpers.Tests.DirectoryInfoExtensionsTests.Test_SourceFolder_DoesNotHave_SameNameAs_SourceFolder')
- [FileHelpersTests](#T-MFR-FileSystem-Helpers-Tests-FileHelpersTests 'MFR.FileSystem.Helpers.Tests.FileHelpersTests')
  - [Initialize()](#M-MFR-FileSystem-Helpers-Tests-FileHelpersTests-Initialize 'MFR.FileSystem.Helpers.Tests.FileHelpersTests.Initialize')
  - [Test_DumpTextToTempFile_Works()](#M-MFR-FileSystem-Helpers-Tests-FileHelpersTests-Test_DumpTextToTempFile_Works 'MFR.FileSystem.Helpers.Tests.FileHelpersTests.Test_DumpTextToTempFile_Works')
  - [Test_FilleWithJunk_Works()](#M-MFR-FileSystem-Helpers-Tests-FileHelpersTests-Test_FilleWithJunk_Works 'MFR.FileSystem.Helpers.Tests.FileHelpersTests.Test_FilleWithJunk_Works')
  - [Test_GetContent_Works_OnTempFileFullOfJunk()](#M-MFR-FileSystem-Helpers-Tests-FileHelpersTests-Test_GetContent_Works_OnTempFileFullOfJunk 'MFR.FileSystem.Helpers.Tests.FileHelpersTests.Test_GetContent_Works_OnTempFileFullOfJunk')
  - [VerifyResultantFile(resultantFile)](#M-MFR-FileSystem-Helpers-Tests-FileHelpersTests-VerifyResultantFile-Alphaleonis-Win32-Filesystem-FileInfo- 'MFR.FileSystem.Helpers.Tests.FileHelpersTests.VerifyResultantFile(Alphaleonis.Win32.Filesystem.FileInfo)')
- [FileInfoExtensionsTests](#T-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests 'MFR.FileSystem.Helpers.Tests.FileInfoExtensionsTests')
  - [ConfigProvider](#P-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-ConfigProvider 'MFR.FileSystem.Helpers.Tests.FileInfoExtensionsTests.ConfigProvider')
  - [Cleanup()](#M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Cleanup 'MFR.FileSystem.Helpers.Tests.FileInfoExtensionsTests.Cleanup')
  - [Initialize()](#M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Initialize 'MFR.FileSystem.Helpers.Tests.FileInfoExtensionsTests.Initialize')
  - [MainTestBed()](#M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-MainTestBed 'MFR.FileSystem.Helpers.Tests.FileInfoExtensionsTests.MainTestBed')
  - [MainTestBed_WithAllMethodCallsComposed()](#M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-MainTestBed_WithAllMethodCallsComposed 'MFR.FileSystem.Helpers.Tests.FileInfoExtensionsTests.MainTestBed_WithAllMethodCallsComposed')
  - [Test_IsZeroLengthFile_ReturnsFalse_ForPathOfNotepadApp()](#M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Test_IsZeroLengthFile_ReturnsFalse_ForPathOfNotepadApp 'MFR.FileSystem.Helpers.Tests.FileInfoExtensionsTests.Test_IsZeroLengthFile_ReturnsFalse_ForPathOfNotepadApp')
  - [Test_IsZeroLengthFile_ReturnsTrue_ForXUDLFile_From_PortfolioMonitor()](#M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Test_IsZeroLengthFile_ReturnsTrue_ForXUDLFile_From_PortfolioMonitor 'MFR.FileSystem.Helpers.Tests.FileInfoExtensionsTests.Test_IsZeroLengthFile_ReturnsTrue_ForXUDLFile_From_PortfolioMonitor')
  - [Test_RenameTo_RefusesToWork_WhenNewFilePath_IsJustAFileName()](#M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Test_RenameTo_RefusesToWork_WhenNewFilePath_IsJustAFileName 'MFR.FileSystem.Helpers.Tests.FileInfoExtensionsTests.Test_RenameTo_RefusesToWork_WhenNewFilePath_IsJustAFileName')
  - [Test_RenameTo_Works_On_ExistingTempFile()](#M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Test_RenameTo_Works_On_ExistingTempFile 'MFR.FileSystem.Helpers.Tests.FileInfoExtensionsTests.Test_RenameTo_Works_On_ExistingTempFile')
  - [Test_RenameTo_Works_On_VastlyDifferentFileNames()](#M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Test_RenameTo_Works_On_VastlyDifferentFileNames 'MFR.FileSystem.Helpers.Tests.FileInfoExtensionsTests.Test_RenameTo_Works_On_VastlyDifferentFileNames')
- [Resources](#T-MFR-FileSystem-Helpers-Tests-Properties-Resources 'MFR.FileSystem.Helpers.Tests.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Helpers-Tests-Properties-Resources-Culture 'MFR.FileSystem.Helpers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Helpers-Tests-Properties-Resources-ResourceManager 'MFR.FileSystem.Helpers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests'></a>
## DirectoryInfoExtensionsTests `type`

##### Namespace

MFR.FileSystem.Helpers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[DirectoryInfoExtensions](#T-MFR-DirectoryInfoExtensions 'MFR.DirectoryInfoExtensions')
class.

<a name='F-MFR-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests-DEST_FOLDER'></a>
### DEST_FOLDER `constants`

##### Summary

String containing the fully-qualified pathname of the folder after a rename operation is carried out.

<a name='F-MFR-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests-SOURCE_FOLDER'></a>
### SOURCE_FOLDER `constants`

##### Summary

String containing the fully-qualified pathname of the folder before a rename operation proceeds.

<a name='P-MFR-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests-GeneratedTempFolderPath'></a>
### GeneratedTempFolderPath `property`

##### Summary

Gets a string containing the fully-qualified pathname of a subfolder of the user's Temp folder that is named after a GUID.

<a name='M-MFR-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests-Test_Directory_RenamedSuccessfully'></a>
### Test_Directory_RenamedSuccessfully() `method`

##### Summary

Asserts the
[RenameTo](#M-MFR-DirectoryInfoExtensions-RenameTo 'MFR.DirectoryInfoExtensions.RenameTo')
method renames a directory successfully when passed proper pathnames.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests-Test_SourceFolder_DoesNotHave_SameNameAs_SourceFolder'></a>
### Test_SourceFolder_DoesNotHave_SameNameAs_SourceFolder() `method`

##### Summary

Asserts that the [SOURCE_FOLDER](#F-MFR-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests-SOURCE_FOLDER 'MFR.FileSystem.Helpers.Tests.DirectoryInfoExtensionsTests.SOURCE_FOLDER') value is not the same string as the [DEST_FOLDER](#F-MFR-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests-DEST_FOLDER 'MFR.FileSystem.Helpers.Tests.DirectoryInfoExtensionsTests.DEST_FOLDER').

##### Parameters

This method has no parameters.

<a name='T-MFR-FileSystem-Helpers-Tests-FileHelpersTests'></a>
## FileHelpersTests `type`

##### Namespace

MFR.FileSystem.Helpers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[FileHelpers](#T-MFR-FileHelpers 'MFR.FileHelpers')
class.

<a name='M-MFR-FileSystem-Helpers-Tests-FileHelpersTests-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the state of this fixture for every unit test session.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Helpers-Tests-FileHelpersTests-Test_DumpTextToTempFile_Works'></a>
### Test_DumpTextToTempFile_Works() `method`

##### Summary

Asserts that the [ToTempFile](#M-MFR-FileSystem-Helpers-FileHelpers-ToTempFile 'MFR.FileSystem.Helpers.FileHelpers.ToTempFile') method dumps text to a temporary file.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Helpers-Tests-FileHelpersTests-Test_FilleWithJunk_Works'></a>
### Test_FilleWithJunk_Works() `method`

##### Summary

Asserts that the
[WithJunk](#M-MFR-FileSystem-Helpers-FillTextFile-WithJunk 'MFR.FileSystem.Helpers.FillTextFile.WithJunk') method
creates a new file of nonzero length.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Helpers-Tests-FileHelpersTests-Test_GetContent_Works_OnTempFileFullOfJunk'></a>
### Test_GetContent_Works_OnTempFileFullOfJunk() `method`

##### Summary

Calls the
[WithJunk](#M-MFR-FileSystem-Helpers-FillTextFile-WithJunk 'MFR.FileSystem.Helpers.FillTextFile.WithJunk') method
to fill a temporary file with random data, and then makes sure that the
[GetTextContent](#M-MFR-FileSystem-Helpers-FileHelpers-GetTextContent 'MFR.FileSystem.Helpers.FileHelpers.GetTextContent') method
successfully reads the data.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Helpers-Tests-FileHelpersTests-VerifyResultantFile-Alphaleonis-Win32-Filesystem-FileInfo-'></a>
### VerifyResultantFile(resultantFile) `method`

##### Summary

Runs common assertions on the
[FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') instance specified in
the `resultantFile` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resultantFile | [Alphaleonis.Win32.Filesystem.FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') | (Required.) A
[FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') instance that contains
information about the `resultantFile`. |

##### Remarks

The [ForPath](#M-MFR-FileSystem-Factories-MakeNewFileInfo-ForPath 'MFR.FileSystem.Factories.MakeNewFileInfo.ForPath')
method can be utilized to manufacture the
[FileInfo](#T-Alphaleonis-Win32-Filesystem-FileInfo 'Alphaleonis.Win32.Filesystem.FileInfo') instance given a
pathname.

<a name='T-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests'></a>
## FileInfoExtensionsTests `type`

##### Namespace

MFR.FileSystem.Helpers.Tests

##### Summary

Provides unit tests for the methods in the
[FileInfoExtensions](#T-MFR-FileInfoExtensions 'MFR.FileInfoExtensions')
class.

<a name='P-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

##### Remarks

This object allows access to the user config and the actions
associated with it.

<a name='M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Cleanup'></a>
### Cleanup() `method`

##### Summary

Called to both clean up after this test fixture's tests have run.

##### Parameters

This method has no parameters.

##### Remarks

The current implementation of this method simply removes all files
and folders (that it can) from the user's TEMP folder.

<a name='M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Initialize'></a>
### Initialize() `method`

##### Summary

Prepares this test fixture for test execution.

##### Parameters

This method has no parameters.

##### Remarks

The current implementation of this method clears files and folders
from the user's TEMP folder, and then fills a file with random junk.

<a name='M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-MainTestBed'></a>
### MainTestBed() `method`

##### Summary

Serves as a test bed to run the entire algorithm of renaming
projects without having to invoke the GUI.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-MainTestBed_WithAllMethodCallsComposed'></a>
### MainTestBed_WithAllMethodCallsComposed() `method`

##### Summary

Serves as a test bed to run the entire algorithm of renaming
projects without having to invoke the GUI.

##### Parameters

This method has no parameters.

##### Remarks

This method is different from the
[MainTestBed](#M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-MainTestBed 'MFR.FileSystem.Helpers.Tests.FileInfoExtensionsTests.MainTestBed')
method in that it uses the fluent composition of objects -- rather
than initializing individual variables with the results -- to test
how the algorithms work when methods are called as they are in the
production code, i.e., in a fluent manner.

<a name='M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Test_IsZeroLengthFile_ReturnsFalse_ForPathOfNotepadApp'></a>
### Test_IsZeroLengthFile_ReturnsFalse_ForPathOfNotepadApp() `method`

##### Summary

Asserts that the
[IsZeroLengthFile](#M-MFR-FileSystem-Helpers-FileInfoExtensions-IsZeroLengthFile 'MFR.FileSystem.Helpers.FileInfoExtensions.IsZeroLengthFile')
method returns `false` when fed the path to the
Windows Notepad utility --- which we know not to be a zero-length
file, since it's a Windows Application.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Test_IsZeroLengthFile_ReturnsTrue_ForXUDLFile_From_PortfolioMonitor'></a>
### Test_IsZeroLengthFile_ReturnsTrue_ForXUDLFile_From_PortfolioMonitor() `method`

##### Summary

Asserts that the
[IsZeroLengthFile](#M-MFR-FileSystem-Helpers-FileInfoExtensions-IsZeroLengthFile 'MFR.FileSystem.Helpers.FileInfoExtensions.IsZeroLengthFile')
method returns `true` when fed the value of the
[PORTFOLIO_MONITOR_X_UDL_FILE](#F-MFR-Tests-Common-StringConstants-PORTFOLIO_MONITOR_X_UDL_FILE 'MFR.Tests.Common.StringConstants.PORTFOLIO_MONITOR_X_UDL_FILE')
constant as a parameter (this constant having as its value, the path
to a zero-length file).

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Test_RenameTo_RefusesToWork_WhenNewFilePath_IsJustAFileName'></a>
### Test_RenameTo_RefusesToWork_WhenNewFilePath_IsJustAFileName() `method`

##### Summary

Asserts that the
[RenameTo](#M-MFR-FileSystem-Helpers-FileInfoExtensions-RenameTo 'MFR.FileSystem.Helpers.FileInfoExtensions.RenameTo')
method will not work when provided only with a filename, not a
fully-qualified path.

##### Parameters

This method has no parameters.

##### Remarks

By "does not work" we mean, "returns `false` and
doesn't carry out the file-rename operation."

<a name='M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Test_RenameTo_Works_On_ExistingTempFile'></a>
### Test_RenameTo_Works_On_ExistingTempFile() `method`

##### Summary

Asserts that the
[RenameTo](#M-MFR-FileSystem-Helpers-FileInfoExtensions-RenameTo 'MFR.FileSystem.Helpers.FileInfoExtensions.RenameTo')
method works (i.e., returns `true` and performs the
correct operations) when we give it the fully-qualified pathname of
a temporary file that actually exists.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Test_RenameTo_Works_On_VastlyDifferentFileNames'></a>
### Test_RenameTo_Works_On_VastlyDifferentFileNames() `method`

##### Summary

Asserts that the
[RenameTo](#M-MFR-FileSystem-Helpers-FileInfoExtensions-RenameTo 'MFR.FileSystem.Helpers.FileInfoExtensions.RenameTo')
method works (i.e., returns `true` and performs the
correct operations) when we give it the fully-qualified pathname of
two files that have vastly different locations.

##### Parameters

This method has no parameters.

<a name='T-MFR-FileSystem-Helpers-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Helpers.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Helpers-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Helpers-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
