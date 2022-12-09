<a name='assembly'></a>
# MFR.Expressions.Matches.Factories.Tests

## Contents

- [FileNameReplacementMatchExpressionFactoryTests](#T-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests')
  - [GetMatchExpressionFactoryConfiguredAccordingTo(projectFileRenamerConfiguration)](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-GetMatchExpressionFactoryConfiguredAccordingTo-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration- 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.GetMatchExpressionFactoryConfiguredAccordingTo(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration)')
  - [Initialize()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Initialize 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Initialize')
  - [Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseFalse_And_MatchExactWordFalse()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseFalse_And_MatchExactWordFalse 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseFalse_And_MatchExactWordFalse')
  - [Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseFalse_And_MatchExactWordTrue()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseFalse_And_MatchExactWordTrue 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseFalse_And_MatchExactWordTrue')
  - [Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseTrue_And_MatchExactWordFalse()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseTrue_And_MatchExactWordFalse 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseTrue_And_MatchExactWordFalse')
  - [Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseTrue_And_MatchExactWordTrue()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseTrue_And_MatchExactWordTrue 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseTrue_And_MatchExactWordTrue')
  - [Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseFalse_And_MatchExactWordFalse()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseFalse_And_MatchExactWordFalse 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseFalse_And_MatchExactWordFalse')
  - [Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseFalse_And_MatchExactWordTrue()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseFalse_And_MatchExactWordTrue 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseFalse_And_MatchExactWordTrue')
  - [Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseTrue_And_MatchExactWordFalse()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseTrue_And_MatchExactWordFalse 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseTrue_And_MatchExactWordFalse')
  - [Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseTrue_And_MatchExactWordTrue()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseTrue_And_MatchExactWordTrue 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseTrue_And_MatchExactWordTrue')
  - [Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseFalse_And_MatchExactWordFalse()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseFalse_And_MatchExactWordFalse 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseFalse_And_MatchExactWordFalse')
  - [Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseFalse_And_MatchExactWordTrue()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseFalse_And_MatchExactWordTrue 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseFalse_And_MatchExactWordTrue')
  - [Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseTrue_And_MatchExactWordFalse()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseTrue_And_MatchExactWordFalse 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseTrue_And_MatchExactWordFalse')
  - [Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseTrue_And_MatchExactWordTrue()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseTrue_And_MatchExactWordTrue 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseTrue_And_MatchExactWordTrue')
  - [Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseFalse_And_MatchExactWordFalse()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseFalse_And_MatchExactWordFalse 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseFalse_And_MatchExactWordFalse')
  - [Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseFalse_And_MatchExactWordTrue()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseFalse_And_MatchExactWordTrue 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseFalse_And_MatchExactWordTrue')
  - [Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseTrue_And_MatchExactWordFalse()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseTrue_And_MatchExactWordFalse 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseTrue_And_MatchExactWordFalse')
  - [Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseTrue_And_MatchExactWordTrue()](#M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseTrue_And_MatchExactWordTrue 'MFR.Expressions.Matches.Factories.Tests.FileNameReplacementMatchExpressionFactoryTests.Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseTrue_And_MatchExactWordTrue')
- [GetMatchExpressionFactoryTests](#T-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests 'MFR.Expressions.Matches.Factories.Tests.GetMatchExpressionFactoryTests')
  - [Test_For_ReturnsFileNameReplacementMatchExpressionFactory_For_RenameFilesInFolder_OperationType()](#M-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests-Test_For_ReturnsFileNameReplacementMatchExpressionFactory_For_RenameFilesInFolder_OperationType 'MFR.Expressions.Matches.Factories.Tests.GetMatchExpressionFactoryTests.Test_For_ReturnsFileNameReplacementMatchExpressionFactory_For_RenameFilesInFolder_OperationType')
  - [Test_For_ReturnsFolderNameReplacementMatchExpressionFactory_For_RenameSubFolders_OperationType()](#M-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests-Test_For_ReturnsFolderNameReplacementMatchExpressionFactory_For_RenameSubFolders_OperationType 'MFR.Expressions.Matches.Factories.Tests.GetMatchExpressionFactoryTests.Test_For_ReturnsFolderNameReplacementMatchExpressionFactory_For_RenameSubFolders_OperationType')
  - [Test_For_ReturnsReplaceTextInFileMatchExpressionFactory_For_ReplaceTextInFiles_OperationType()](#M-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests-Test_For_ReturnsReplaceTextInFileMatchExpressionFactory_For_ReplaceTextInFiles_OperationType 'MFR.Expressions.Matches.Factories.Tests.GetMatchExpressionFactoryTests.Test_For_ReturnsReplaceTextInFileMatchExpressionFactory_For_ReplaceTextInFiles_OperationType')
  - [Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType()](#M-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests-Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType 'MFR.Expressions.Matches.Factories.Tests.GetMatchExpressionFactoryTests.Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType')
  - [Test_For_ThrowsArgumentOutOfRangeException_For_FindVisualStudio_OperationType()](#M-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests-Test_For_ThrowsArgumentOutOfRangeException_For_FindVisualStudio_OperationType 'MFR.Expressions.Matches.Factories.Tests.GetMatchExpressionFactoryTests.Test_For_ThrowsArgumentOutOfRangeException_For_FindVisualStudio_OperationType')
  - [Test_For_ThrowsArgumentOutOfRangeException_For_GettingListOfFilesToBeRenamed_OperationType()](#M-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests-Test_For_ThrowsArgumentOutOfRangeException_For_GettingListOfFilesToBeRenamed_OperationType 'MFR.Expressions.Matches.Factories.Tests.GetMatchExpressionFactoryTests.Test_For_ThrowsArgumentOutOfRangeException_For_GettingListOfFilesToBeRenamed_OperationType')
  - [Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_OperationType()](#M-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests-Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_OperationType 'MFR.Expressions.Matches.Factories.Tests.GetMatchExpressionFactoryTests.Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_OperationType')
- [Resources](#T-MFR-Expressions-Matches-Factories-Tests-Properties-Resources 'MFR.Expressions.Matches.Factories.Tests.Properties.Resources')
  - [Culture](#P-MFR-Expressions-Matches-Factories-Tests-Properties-Resources-Culture 'MFR.Expressions.Matches.Factories.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Expressions-Matches-Factories-Tests-Properties-Resources-ResourceManager 'MFR.Expressions.Matches.Factories.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests'></a>
## FileNameReplacementMatchExpressionFactoryTests `type`

##### Namespace

MFR.Expressions.Matches.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[FileNameReplacementMatchExpressionFactory](#T-MFR-FileNameReplacementMatchExpressionFactory 'MFR.FileNameReplacementMatchExpressionFactory')
class.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-GetMatchExpressionFactoryConfiguredAccordingTo-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-'></a>
### GetMatchExpressionFactoryConfiguredAccordingTo(projectFileRenamerConfiguration) `method`

##### Summary

Gets a reference to an instance of an object that implements the
[IMatchExpressionFactory](#T-MFR-IMatchExpressionFactory 'MFR.IMatchExpressionFactory')
interface and that is configured according to the
`projectFileRenamerConfiguration`
instance specified.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpressionFactory](#T-MFR-IMatchExpressionFactory 'MFR.IMatchExpressionFactory')
interface
that has the specified `projectFileRenamerConfiguration` attached.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectFileRenamerConfiguration | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') | (Required.) Reference to an instance of an object that implements
the [IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') interface. |

##### Remarks

The specific match-expression factory in use is that which is keyed
to the
[RenameFilesInFolder](#T-MFR-OperationType-RenameFilesInFolder 'MFR.OperationType.RenameFilesInFolder')
operation type.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the state of this fixture for every unit test session.

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseFalse_And_MatchExactWordFalse'></a>
### Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseFalse_And_MatchExactWordFalse() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseFalse_And_MatchExactWordTrue'></a>
### Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseFalse_And_MatchExactWordTrue() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseTrue_And_MatchExactWordFalse'></a>
### Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseTrue_And_MatchExactWordFalse() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseTrue_And_MatchExactWordTrue'></a>
### Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseTrue_And_MatchExactWordTrue() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseFalse_And_MatchExactWordFalse'></a>
### Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseFalse_And_MatchExactWordFalse() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseFalse_And_MatchExactWordTrue'></a>
### Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseFalse_And_MatchExactWordTrue() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseTrue_And_MatchExactWordFalse'></a>
### Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseTrue_And_MatchExactWordFalse() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseTrue_And_MatchExactWordTrue'></a>
### Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseTrue_And_MatchExactWordTrue() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseFalse_And_MatchExactWordFalse'></a>
### Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseFalse_And_MatchExactWordFalse() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseFalse_And_MatchExactWordTrue'></a>
### Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseFalse_And_MatchExactWordTrue() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseTrue_And_MatchExactWordFalse'></a>
### Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseTrue_And_MatchExactWordFalse() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseTrue_And_MatchExactWordTrue'></a>
### Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseTrue_And_MatchExactWordTrue() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseFalse_And_MatchExactWordFalse'></a>
### Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseFalse_And_MatchExactWordFalse() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseFalse_And_MatchExactWordTrue'></a>
### Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseFalse_And_MatchExactWordTrue() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseTrue_And_MatchExactWordFalse'></a>
### Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseTrue_And_MatchExactWordFalse() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-FileNameReplacementMatchExpressionFactoryTests-Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseTrue_And_MatchExactWordTrue'></a>
### Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseTrue_And_MatchExactWordTrue() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='T-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests'></a>
## GetMatchExpressionFactoryTests `type`

##### Namespace

MFR.Expressions.Matches.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[GetMatchExpressionFactory](#T-MFR-GetMatchExpressionFactory 'MFR.GetMatchExpressionFactory')
class.

<a name='M-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests-Test_For_ReturnsFileNameReplacementMatchExpressionFactory_For_RenameFilesInFolder_OperationType'></a>
### Test_For_ReturnsFileNameReplacementMatchExpressionFactory_For_RenameFilesInFolder_OperationType() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests-Test_For_ReturnsFolderNameReplacementMatchExpressionFactory_For_RenameSubFolders_OperationType'></a>
### Test_For_ReturnsFolderNameReplacementMatchExpressionFactory_For_RenameSubFolders_OperationType() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests-Test_For_ReturnsReplaceTextInFileMatchExpressionFactory_For_ReplaceTextInFiles_OperationType'></a>
### Test_For_ReturnsReplaceTextInFileMatchExpressionFactory_For_ReplaceTextInFiles_OperationType() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests-Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType'></a>
### Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests-Test_For_ThrowsArgumentOutOfRangeException_For_FindVisualStudio_OperationType'></a>
### Test_For_ThrowsArgumentOutOfRangeException_For_FindVisualStudio_OperationType() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests-Test_For_ThrowsArgumentOutOfRangeException_For_GettingListOfFilesToBeRenamed_OperationType'></a>
### Test_For_ThrowsArgumentOutOfRangeException_For_GettingListOfFilesToBeRenamed_OperationType() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Expressions-Matches-Factories-Tests-GetMatchExpressionFactoryTests-Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_OperationType'></a>
### Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_OperationType() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='T-MFR-Expressions-Matches-Factories-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Expressions.Matches.Factories.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Expressions-Matches-Factories-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Expressions-Matches-Factories-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
