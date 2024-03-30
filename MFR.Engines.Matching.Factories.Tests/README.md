<a name='assembly'></a>
# MFR.Engines.Matching.Factories.Tests

## Contents

- [GetTextExpressionMatchingEngineTests](#T-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests 'MFR.Engines.Matching.Factories.Tests.GetTextExpressionMatchingEngineTests')
  - [Test_For_ReturnsFileNameMatchingEngine_For_RenameFilesInFolder_OperationType()](#M-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests-Test_For_ReturnsFileNameMatchingEngine_For_RenameFilesInFolder_OperationType 'MFR.Engines.Matching.Factories.Tests.GetTextExpressionMatchingEngineTests.Test_For_ReturnsFileNameMatchingEngine_For_RenameFilesInFolder_OperationType')
  - [Test_For_ReturnsFolderNameMatchingEngine_For_RenameSubFolders_OperationType()](#M-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests-Test_For_ReturnsFolderNameMatchingEngine_For_RenameSubFolders_OperationType 'MFR.Engines.Matching.Factories.Tests.GetTextExpressionMatchingEngineTests.Test_For_ReturnsFolderNameMatchingEngine_For_RenameSubFolders_OperationType')
  - [Test_For_ReturnsTextInFileMatchingEngine_For_ReplaceTextInFiles_OperationType()](#M-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests-Test_For_ReturnsTextInFileMatchingEngine_For_ReplaceTextInFiles_OperationType 'MFR.Engines.Matching.Factories.Tests.GetTextExpressionMatchingEngineTests.Test_For_ReturnsTextInFileMatchingEngine_For_ReplaceTextInFiles_OperationType')
  - [Test_For_ThrowsArgumentOutOfRangeException_For_CalculateListOfFilesToBeRenamed_OperationType()](#M-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests-Test_For_ThrowsArgumentOutOfRangeException_For_CalculateListOfFilesToBeRenamed_OperationType 'MFR.Engines.Matching.Factories.Tests.GetTextExpressionMatchingEngineTests.Test_For_ThrowsArgumentOutOfRangeException_For_CalculateListOfFilesToBeRenamed_OperationType')
  - [Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType()](#M-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests-Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType 'MFR.Engines.Matching.Factories.Tests.GetTextExpressionMatchingEngineTests.Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType')
  - [Test_For_ThrowsArgumentOutOfRangeException_For_FindVisualStudio_OperationType()](#M-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests-Test_For_ThrowsArgumentOutOfRangeException_For_FindVisualStudio_OperationType 'MFR.Engines.Matching.Factories.Tests.GetTextExpressionMatchingEngineTests.Test_For_ThrowsArgumentOutOfRangeException_For_FindVisualStudio_OperationType')
  - [Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_OperationType()](#M-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests-Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_OperationType 'MFR.Engines.Matching.Factories.Tests.GetTextExpressionMatchingEngineTests.Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_OperationType')
- [Resources](#T-MFR-Engines-Matching-Factories-Tests-Properties-Resources 'MFR.Engines.Matching.Factories.Tests.Properties.Resources')
  - [Culture](#P-MFR-Engines-Matching-Factories-Tests-Properties-Resources-Culture 'MFR.Engines.Matching.Factories.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Matching-Factories-Tests-Properties-Resources-ResourceManager 'MFR.Engines.Matching.Factories.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests'></a>
## GetTextExpressionMatchingEngineTests `type`

##### Namespace

MFR.Engines.Matching.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[GetTextExpressionMatchingEngine](#T-MFR-GetTextExpressionMatchingEngine 'MFR.GetTextExpressionMatchingEngine')
class.

<a name='M-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests-Test_For_ReturnsFileNameMatchingEngine_For_RenameFilesInFolder_OperationType'></a>
### Test_For_ReturnsFileNameMatchingEngine_For_RenameFilesInFolder_OperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine-For 'MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For')
method, when passed the
[RenameFilesInFolder](#T-MFR-Operations-Constants-OperationType-RenameFilesInFolder 'MFR.Operations.Constants.OperationType.RenameFilesInFolder')
value, returns an instance of
[FileNameMatchingEngine](#T-MFR-Engines-Matching-FileNameMatchingEngine 'MFR.Engines.Matching.FileNameMatchingEngine').

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests-Test_For_ReturnsFolderNameMatchingEngine_For_RenameSubFolders_OperationType'></a>
### Test_For_ReturnsFolderNameMatchingEngine_For_RenameSubFolders_OperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine-For 'MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For')
method, when passed the
[RenameSubFolders](#T-MFR-Operations-Constants-OperationType-RenameSubFolders 'MFR.Operations.Constants.OperationType.RenameSubFolders')
value, returns an instance of
[FolderNameMatchingEngine](#T-MFR-Engines-Matching-FolderNameMatchingEngine 'MFR.Engines.Matching.FolderNameMatchingEngine').

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests-Test_For_ReturnsTextInFileMatchingEngine_For_ReplaceTextInFiles_OperationType'></a>
### Test_For_ReturnsTextInFileMatchingEngine_For_ReplaceTextInFiles_OperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine-For 'MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For')
method, when passed the
[ReplaceTextInFiles](#T-MFR-Operations-Constants-OperationType-ReplaceTextInFiles 'MFR.Operations.Constants.OperationType.ReplaceTextInFiles')
value, returns an instance of
[TextInFilesMatchingEngine](#T-MFR-Engines-Matching-TextInFilesMatchingEngine 'MFR.Engines.Matching.TextInFilesMatchingEngine').

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests-Test_For_ThrowsArgumentOutOfRangeException_For_CalculateListOfFilesToBeRenamed_OperationType'></a>
### Test_For_ThrowsArgumentOutOfRangeException_For_CalculateListOfFilesToBeRenamed_OperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine-For 'MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For')
method throws [ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') when supplied
with the
[CalculateListOfFilesToBeRenamed](#T-MFR-Operations-Constants-OperationType-CalculateListOfFilesToBeRenamed 'MFR.Operations.Constants.OperationType.CalculateListOfFilesToBeRenamed')
value,
as this not one of the values that a text-expression matcher object is
available for.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests-Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType'></a>
### Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine-For 'MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For')
method throws [ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') when supplied
with the
[CloseActiveSolutions](#T-MFR-Operations-Constants-OperationType-CloseActiveSolutions 'MFR.Operations.Constants.OperationType.CloseActiveSolutions')
value,
as this not one of the values that a text-expression matcher object is
available for.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests-Test_For_ThrowsArgumentOutOfRangeException_For_FindVisualStudio_OperationType'></a>
### Test_For_ThrowsArgumentOutOfRangeException_For_FindVisualStudio_OperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine-For 'MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For')
method throws [ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') when supplied
with the
[FindVisualStudio](#T-MFR-Operations-Constants-OperationType-FindVisualStudio 'MFR.Operations.Constants.OperationType.FindVisualStudio') value,
as this not one of the values that a text-expression matcher object is
available for.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Matching-Factories-Tests-GetTextExpressionMatchingEngineTests-Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_OperationType'></a>
### Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_OperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine-For 'MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For')
method throws [ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') when supplied
with the
[OpenActiveSolutions](#T-MFR-Operations-Constants-OperationType-OpenActiveSolutions 'MFR.Operations.Constants.OperationType.OpenActiveSolutions')
value,
as this not one of the values that a text-expression matcher object is
available for.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-Matching-Factories-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Matching.Factories.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Matching-Factories-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Matching-Factories-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
