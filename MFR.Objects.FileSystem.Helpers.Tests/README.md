<a name='assembly'></a>
# MFR.Objects.FileSystem.Helpers.Tests

## Contents

- [DirectoryInfoExtensionsTests](#T-MFR-Objects-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests 'MFR.Objects.FileSystem.Helpers.Tests.DirectoryInfoExtensionsTests')
  - [Test_Directory_RenamedSuccessfully()](#M-MFR-Objects-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests-Test_Directory_RenamedSuccessfully 'MFR.Objects.FileSystem.Helpers.Tests.DirectoryInfoExtensionsTests.Test_Directory_RenamedSuccessfully')
- [FileHelpersTests](#T-MFR-Objects-FileSystem-Helpers-Tests-FileHelpersTests 'MFR.Objects.FileSystem.Helpers.Tests.FileHelpersTests')
  - [Initialize()](#M-MFR-Objects-FileSystem-Helpers-Tests-FileHelpersTests-Initialize 'MFR.Objects.FileSystem.Helpers.Tests.FileHelpersTests.Initialize')
  - [Test_FilleWithJunk_Works()](#M-MFR-Objects-FileSystem-Helpers-Tests-FileHelpersTests-Test_FilleWithJunk_Works 'MFR.Objects.FileSystem.Helpers.Tests.FileHelpersTests.Test_FilleWithJunk_Works')
  - [Test_GetContent_Works_OnTempFileFullOfJunk()](#M-MFR-Objects-FileSystem-Helpers-Tests-FileHelpersTests-Test_GetContent_Works_OnTempFileFullOfJunk 'MFR.Objects.FileSystem.Helpers.Tests.FileHelpersTests.Test_GetContent_Works_OnTempFileFullOfJunk')
- [FileInfoExtensionsTests](#T-MFR-Objects-FileSystem-Helpers-Tests-FileInfoExtensionsTests 'MFR.Objects.FileSystem.Helpers.Tests.FileInfoExtensionsTests')
  - [MainTestBed()](#M-MFR-Objects-FileSystem-Helpers-Tests-FileInfoExtensionsTests-MainTestBed 'MFR.Objects.FileSystem.Helpers.Tests.FileInfoExtensionsTests.MainTestBed')
  - [MainTestBed_WithAllMethodCallsComposed()](#M-MFR-Objects-FileSystem-Helpers-Tests-FileInfoExtensionsTests-MainTestBed_WithAllMethodCallsComposed 'MFR.Objects.FileSystem.Helpers.Tests.FileInfoExtensionsTests.MainTestBed_WithAllMethodCallsComposed')
  - [Test_RenameTo_RefusesToWork_WhenNewFilePath_IsJustAFileName()](#M-MFR-Objects-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Test_RenameTo_RefusesToWork_WhenNewFilePath_IsJustAFileName 'MFR.Objects.FileSystem.Helpers.Tests.FileInfoExtensionsTests.Test_RenameTo_RefusesToWork_WhenNewFilePath_IsJustAFileName')
  - [Test_RenameTo_Works_On_ExistingTempFile()](#M-MFR-Objects-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Test_RenameTo_Works_On_ExistingTempFile 'MFR.Objects.FileSystem.Helpers.Tests.FileInfoExtensionsTests.Test_RenameTo_Works_On_ExistingTempFile')
- [Resources](#T-MFR-Objects-FileSystem-Helpers-Tests-Properties-Resources 'MFR.Objects.FileSystem.Helpers.Tests.Properties.Resources')
  - [Culture](#P-MFR-Objects-FileSystem-Helpers-Tests-Properties-Resources-Culture 'MFR.Objects.FileSystem.Helpers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-FileSystem-Helpers-Tests-Properties-Resources-ResourceManager 'MFR.Objects.FileSystem.Helpers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests'></a>
## DirectoryInfoExtensionsTests `type`

##### Namespace

MFR.Objects.FileSystem.Helpers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[DirectoryInfoExtensions](#T-MFR-Objects-DirectoryInfoExtensions 'MFR.Objects.DirectoryInfoExtensions')
class.

<a name='M-MFR-Objects-FileSystem-Helpers-Tests-DirectoryInfoExtensionsTests-Test_Directory_RenamedSuccessfully'></a>
### Test_Directory_RenamedSuccessfully() `method`

##### Summary

Asserts the
[RenameTo](#M-MFR-Objects-DirectoryInfoExtensions-RenameTo 'MFR.Objects.DirectoryInfoExtensions.RenameTo')
method renames a directory successfully when passed proper pathnames.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-FileSystem-Helpers-Tests-FileHelpersTests'></a>
## FileHelpersTests `type`

##### Namespace

MFR.Objects.FileSystem.Helpers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[FileHelpers](#T-MFR-Objects-FileHelpers 'MFR.Objects.FileHelpers')
class.

<a name='M-MFR-Objects-FileSystem-Helpers-Tests-FileHelpersTests-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the state of this fixture for every unit test session.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Helpers-Tests-FileHelpersTests-Test_FilleWithJunk_Works'></a>
### Test_FilleWithJunk_Works() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Helpers-Tests-FileHelpersTests-Test_GetContent_Works_OnTempFileFullOfJunk'></a>
### Test_GetContent_Works_OnTempFileFullOfJunk() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-FileSystem-Helpers-Tests-FileInfoExtensionsTests'></a>
## FileInfoExtensionsTests `type`

##### Namespace

MFR.Objects.FileSystem.Helpers.Tests

##### Summary

Provides unit tests for the methods in the
[FileInfoExtensions](#T-MFR-Objects-FileInfoExtensions 'MFR.Objects.FileInfoExtensions')
class.

<a name='M-MFR-Objects-FileSystem-Helpers-Tests-FileInfoExtensionsTests-MainTestBed'></a>
### MainTestBed() `method`

##### Summary

Serves as a test bed to run the entire algorithm of renaming projects without having to invoke the GUI.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Helpers-Tests-FileInfoExtensionsTests-MainTestBed_WithAllMethodCallsComposed'></a>
### MainTestBed_WithAllMethodCallsComposed() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Test_RenameTo_RefusesToWork_WhenNewFilePath_IsJustAFileName'></a>
### Test_RenameTo_RefusesToWork_WhenNewFilePath_IsJustAFileName() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Helpers-Tests-FileInfoExtensionsTests-Test_RenameTo_Works_On_ExistingTempFile'></a>
### Test_RenameTo_Works_On_ExistingTempFile() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-FileSystem-Helpers-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.FileSystem.Helpers.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-FileSystem-Helpers-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-FileSystem-Helpers-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
