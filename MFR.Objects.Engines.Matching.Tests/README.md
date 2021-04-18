<a name='assembly'></a>
# MFR.Objects.Engines.Matching.Tests

## Contents

- [FileNameMatchingEngineTests](#T-MFR-Objects-Engines-Matching-Tests-FileNameMatchingEngineTests 'MFR.Objects.Engines.Matching.Tests.FileNameMatchingEngineTests')
  - [Initialize()](#M-MFR-Objects-Engines-Matching-Tests-FileNameMatchingEngineTests-Initialize 'MFR.Objects.Engines.Matching.Tests.FileNameMatchingEngineTests.Initialize')
- [FolderNameMatchingEngineTests](#T-MFR-Objects-Engines-Matching-Tests-FolderNameMatchingEngineTests 'MFR.Objects.Engines.Matching.Tests.FolderNameMatchingEngineTests')
  - [Initialize()](#M-MFR-Objects-Engines-Matching-Tests-FolderNameMatchingEngineTests-Initialize 'MFR.Objects.Engines.Matching.Tests.FolderNameMatchingEngineTests.Initialize')
  - [Test_IsMatch_ReturnsTrue_ForExactFolderSearchMatch()](#M-MFR-Objects-Engines-Matching-Tests-FolderNameMatchingEngineTests-Test_IsMatch_ReturnsTrue_ForExactFolderSearchMatch 'MFR.Objects.Engines.Matching.Tests.FolderNameMatchingEngineTests.Test_IsMatch_ReturnsTrue_ForExactFolderSearchMatch')
- [Resources](#T-MFR-Objects-Engines-Matching-Tests-Properties-Resources 'MFR.Objects.Engines.Matching.Tests.Properties.Resources')
  - [Culture](#P-MFR-Objects-Engines-Matching-Tests-Properties-Resources-Culture 'MFR.Objects.Engines.Matching.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Engines-Matching-Tests-Properties-Resources-ResourceManager 'MFR.Objects.Engines.Matching.Tests.Properties.Resources.ResourceManager')
- [TextExpressionMatchingEngineTestBase](#T-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase')
  - [_configuration](#F-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-_configuration 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase._configuration')
  - [_matcher](#F-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-_matcher 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase._matcher')
  - [Initialize()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Initialize 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Initialize')
  - [Test_ArgumentException_NotThrown_If_AllThreeParams_Of_IsMatch_Method_AreNonBlank()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_NotThrown_If_AllThreeParams_Of_IsMatch_Method_AreNonBlank 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_NotThrown_If_AllThreeParams_Of_IsMatch_Method_AreNonBlank')
  - [Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreBlank()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreBlank 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreBlank')
  - [Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreNull()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreNull 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreNull')
  - [Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreWhitespace()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreWhitespace 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreWhitespace')
  - [Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreBlank()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreBlank 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreBlank')
  - [Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreNull()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreNull 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreNull')
  - [Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreWhitespace()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreWhitespace 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreWhitespace')
  - [Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreBlank()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreBlank 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreBlank')
  - [Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreNull()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreNull 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreNull')
  - [Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreWhitespace()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreWhitespace 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreWhitespace')
  - [Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsBlank()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsBlank 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsBlank')
  - [Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsNull()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsNull 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsNull')
  - [Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsWhitespace()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsWhitespace 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsWhitespace')
  - [Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsBlank()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsBlank 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsBlank')
  - [Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsNull()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsNull 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsNull')
  - [Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsWhitespace()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsWhitespace 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsWhitespace')
  - [Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsBlank()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsBlank 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsBlank')
  - [Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsNull()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsNull 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsNull')
  - [Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsWhitespace()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsWhitespace 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsWhitespace')
  - [Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreBlank()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreBlank 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreBlank')
  - [Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreNull()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreNull 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreNull')
  - [Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreWhitespace()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreWhitespace 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreWhitespace')
  - [Test_FalseReturnedIfCaseDoesNotMatch_AndFalseReturnedWhenCaseDoesMatch_IfSourceDoesNotExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturnedIfCaseDoesNotMatch_AndFalseReturnedWhenCaseDoesMatch_IfSourceDoesNotExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_FalseReturnedIfCaseDoesNotMatch_AndFalseReturnedWhenCaseDoesMatch_IfSourceDoesNotExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn')
  - [Test_FalseReturnedIfCaseDoesNotMatch_AndTrueReturnedWhenCaseDoesMatch_IfSourceExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturnedIfCaseDoesNotMatch_AndTrueReturnedWhenCaseDoesMatch_IfSourceExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_FalseReturnedIfCaseDoesNotMatch_AndTrueReturnedWhenCaseDoesMatch_IfSourceExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn')
  - [Test_FalseReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_FalseReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch')
  - [Test_FalseReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOn_And_MatchCase_IsTurnedOff()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOn_And_MatchCase_IsTurnedOff 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_FalseReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOn_And_MatchCase_IsTurnedOff')
  - [Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOff()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOff 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOff')
  - [Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn')
  - [Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch')
  - [Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesMatch()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesMatch 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesMatch')
  - [Test_FalseReturned_IfSourceExactlyMatchesPattern_WhenMatchExactWord_IsTurnedOn_And_MatchCase_IsTurnedOff()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturned_IfSourceExactlyMatchesPattern_WhenMatchExactWord_IsTurnedOn_And_MatchCase_IsTurnedOff 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_FalseReturned_IfSourceExactlyMatchesPattern_WhenMatchExactWord_IsTurnedOn_And_MatchCase_IsTurnedOff')
  - [Test_TrueReturned_IfSourceContainsPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOff()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_TrueReturned_IfSourceContainsPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOff 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_TrueReturned_IfSourceContainsPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOff')
  - [Test_TrueReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_TrueReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_TrueReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn')
  - [Test_TrueReturned_WhenSourceExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_TrueReturned_WhenSourceExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_TrueReturned_WhenSourceExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn')
  - [Test_WhenMatchCaseOn_AndMatchExactWordOn_FalseReturned_IfSourceContainsPattern()](#M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_WhenMatchCaseOn_AndMatchExactWordOn_FalseReturned_IfSourceContainsPattern 'MFR.Objects.Engines.Matching.Tests.TextExpressionMatchingEngineTestBase.Test_WhenMatchCaseOn_AndMatchExactWordOn_FalseReturned_IfSourceContainsPattern')
- [TextInFilesMatchingEngineTests](#T-MFR-Objects-Engines-Matching-Tests-TextInFilesMatchingEngineTests 'MFR.Objects.Engines.Matching.Tests.TextInFilesMatchingEngineTests')
  - [Test_Match_WithCaseAndNotExactWords_Found_InCsProjFile()](#M-MFR-Objects-Engines-Matching-Tests-TextInFilesMatchingEngineTests-Test_Match_WithCaseAndNotExactWords_Found_InCsProjFile 'MFR.Objects.Engines.Matching.Tests.TextInFilesMatchingEngineTests.Test_Match_WithCaseAndNotExactWords_Found_InCsProjFile')

<a name='T-MFR-Objects-Engines-Matching-Tests-FileNameMatchingEngineTests'></a>
## FileNameMatchingEngineTests `type`

##### Namespace

MFR.Objects.Engines.Matching.Tests

##### Summary

Provides unit tests for the methods of the
[FileNameMatchingEngine](#T-MFR-Objects-FileNameMatchingEngine 'MFR.Objects.FileNameMatchingEngine')
class.

<a name='M-MFR-Objects-Engines-Matching-Tests-FileNameMatchingEngineTests-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the state of this fixture for every unit test session.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Engines-Matching-Tests-FolderNameMatchingEngineTests'></a>
## FolderNameMatchingEngineTests `type`

##### Namespace

MFR.Objects.Engines.Matching.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[FolderNameMatchingEngine](#T-MFR-Objects-FolderNameMatchingEngine 'MFR.Objects.FolderNameMatchingEngine')
class.

<a name='M-MFR-Objects-Engines-Matching-Tests-FolderNameMatchingEngineTests-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the state of this fixture for every unit test session.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-FolderNameMatchingEngineTests-Test_IsMatch_ReturnsTrue_ForExactFolderSearchMatch'></a>
### Test_IsMatch_ReturnsTrue_ForExactFolderSearchMatch() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Engines-Matching-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Engines.Matching.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Engines-Matching-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Engines-Matching-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase'></a>
## TextExpressionMatchingEngineTestBase `type`

##### Namespace

MFR.Objects.Engines.Matching.Tests

##### Summary

Provides default implementations for unit tests and abstract methods for
mandatory implementation details.

<a name='F-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-_configuration'></a>
### _configuration `constants`

##### Summary

Reference to an instance of an object that implements the
[IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.Objects.IConfiguration')
interface.

<a name='F-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-_matcher'></a>
### _matcher `constants`

##### Summary

Reference to an instance of an object that implements the
[ITextExpressionMatchingEngine](#T-MFR-Objects-ITextExpressionMatchingEngine 'MFR.Objects.ITextExpressionMatchingEngine')
interface.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the state of this fixture for every unit test session.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_NotThrown_If_AllThreeParams_Of_IsMatch_Method_AreNonBlank'></a>
### Test_ArgumentException_NotThrown_If_AllThreeParams_Of_IsMatch_Method_AreNonBlank() `method`

##### Summary

Asserts that the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if the empty string
is passed for all three of its parameters.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreBlank'></a>
### Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreBlank() `method`

##### Summary

Asserts that the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if the empty string
is passed for all three of its parameters.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreNull'></a>
### Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreNull() `method`

##### Summary

Asserts that the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if strings
containing whitespace are passed for all three of its parameters.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreWhitespace'></a>
### Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreWhitespace() `method`

##### Summary

Asserts that the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if strings
containing whitespace are passed for all three of its parameters.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreBlank'></a>
### Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreBlank() `method`

##### Summary

Asserts that the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if the empty string
is passed for its first and second parameters, with a non-blank
string passed in the third.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreNull'></a>
### Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreNull() `method`

##### Summary

Asserts that the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if the empty string
is passed for its first and second parameters, with a non-blank
string passed in the third.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreWhitespace'></a>
### Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreWhitespace() `method`

##### Summary

Asserts that the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if the empty string
is passed for its first and second parameters, with a non-blank
string passed in the third.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreBlank'></a>
### Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreBlank() `method`

##### Summary

Asserts that the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if the empty string
is passed for its first and third parameters, with a non-blank
string passed in the second.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreNull'></a>
### Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreNull() `method`

##### Summary

Asserts that the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if the empty string
is passed for its first and third parameters, with a non-blank
string passed in the second.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreWhitespace'></a>
### Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreWhitespace() `method`

##### Summary

Asserts that the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if the empty string
is passed for its first and third parameters, with a non-blank
string passed in the second.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsBlank'></a>
### Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsBlank() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if only the first
parameter is the empty string.

##### Parameters

This method has no parameters.

##### Remarks

This test method is marked `virtual` so that it can be
overriden for the case where implementations of
[ITextExpressionMatchingEngine](#T-MFR-Objects-ITextExpressionMatchingEngine 'MFR.Objects.ITextExpressionMatchingEngine')
do not require
the first parameter.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsNull'></a>
### Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsNull() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if only the first
parameter is `null`.

##### Parameters

This method has no parameters.

##### Remarks

This test method is marked `virtual` so that it can be
overriden for the case where implementations of
[ITextExpressionMatchingEngine](#T-MFR-Objects-ITextExpressionMatchingEngine 'MFR.Objects.ITextExpressionMatchingEngine')
do not require
the first parameter.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsWhitespace'></a>
### Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsWhitespace() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if only the first
parameter is whitespace.

##### Parameters

This method has no parameters.

##### Remarks

This test method is marked `virtual` so that it can be
overriden for the case where implementations of
[ITextExpressionMatchingEngine](#T-MFR-Objects-ITextExpressionMatchingEngine 'MFR.Objects.ITextExpressionMatchingEngine')
do not require
the first parameter.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsBlank'></a>
### Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsBlank() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if only the second
parameter is the empty string.

##### Parameters

This method has no parameters.

##### Remarks

This test method is marked `virtual` so that it can be
overriden for the case where implementations of
[ITextExpressionMatchingEngine](#T-MFR-Objects-ITextExpressionMatchingEngine 'MFR.Objects.ITextExpressionMatchingEngine')
do not require
the second parameter.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsNull'></a>
### Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsNull() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if only the second
parameter is `null`.

##### Parameters

This method has no parameters.

##### Remarks

This test method is marked `virtual` so that it can be
overriden for the case where implementations of
[ITextExpressionMatchingEngine](#T-MFR-Objects-ITextExpressionMatchingEngine 'MFR.Objects.ITextExpressionMatchingEngine')
do not require
the second parameter.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsWhitespace'></a>
### Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsWhitespace() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if only the second
parameter is whitespace.

##### Parameters

This method has no parameters.

##### Remarks

This test method is marked `virtual` so that it can be
overriden for the case where implementations of
[ITextExpressionMatchingEngine](#T-MFR-Objects-ITextExpressionMatchingEngine 'MFR.Objects.ITextExpressionMatchingEngine')
do not require
the second parameter.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsBlank'></a>
### Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsBlank() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if only the third
parameter is the empty string.

##### Parameters

This method has no parameters.

##### Remarks

This test method is marked `virtual` so that it can be
overriden for the case where implementations of
[ITextExpressionMatchingEngine](#T-MFR-Objects-ITextExpressionMatchingEngine 'MFR.Objects.ITextExpressionMatchingEngine')
do not require
the third parameter.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsNull'></a>
### Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsNull() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if only the third
parameter is `null`.

##### Parameters

This method has no parameters.

##### Remarks

This test method is marked `virtual` so that it can be
overriden for the case where implementations of
[ITextExpressionMatchingEngine](#T-MFR-Objects-ITextExpressionMatchingEngine 'MFR.Objects.ITextExpressionMatchingEngine')
do not require
the third parameter.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsWhitespace'></a>
### Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsWhitespace() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if only the third
parameter is whitespace.

##### Parameters

This method has no parameters.

##### Remarks

This test method is marked `virtual` so that it can be
overriden for the case where implementations of
[ITextExpressionMatchingEngine](#T-MFR-Objects-ITextExpressionMatchingEngine 'MFR.Objects.ITextExpressionMatchingEngine')
do not require
the third parameter.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreBlank'></a>
### Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreBlank() `method`

##### Summary

Asserts that the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if the empty string
is passed for its second and third parameters, with a non-blank
string passed in the first.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreNull'></a>
### Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreNull() `method`

##### Summary

Asserts that the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if the empty string
is passed for its second and third parameters, with a non-blank
string passed in the first.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreWhitespace'></a>
### Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreWhitespace() `method`

##### Summary

Asserts that the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') if the empty string
is passed for its second and third parameters, with a non-blank
string passed in the first.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturnedIfCaseDoesNotMatch_AndFalseReturnedWhenCaseDoesMatch_IfSourceDoesNotExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn'></a>
### Test_FalseReturnedIfCaseDoesNotMatch_AndFalseReturnedWhenCaseDoesMatch_IfSourceDoesNotExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
returns `false` in the event that (a) MatchCase =
MatchExactWord
= true in the configuration, (b) the source string does not exactly
match the pattern string as a substring, and if (c) the cases do not
match in the first sub-case.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturnedIfCaseDoesNotMatch_AndTrueReturnedWhenCaseDoesMatch_IfSourceExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn'></a>
### Test_FalseReturnedIfCaseDoesNotMatch_AndTrueReturnedWhenCaseDoesMatch_IfSourceExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
returns `true` in the event that (a) MatchCase =
MatchExactWord
= true in the configuration, (b) the source string exactly matches the
pattern string as a substring, except if (c) the cases do not match
in the first sub-case.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch'></a>
### Test_FalseReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
returns `false` in the event that (a) MatchCase =
true and MatchExactWord
= false in the configuration, (b) the source string contains the
pattern string as a substring, but (c) the cases do not match in
neither the first sub-case nor in the second.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOn_And_MatchCase_IsTurnedOff'></a>
### Test_FalseReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOn_And_MatchCase_IsTurnedOff() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
returns `false` in the event that (a) MatchCase =
false and MatchExactWord
= true in the configuration, (b) the source string contains the
pattern string as a substring, and (c) the cases do not match in the
first sub-case but the cases match in the second.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOff'></a>
### Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOff() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
returns `false` in the event that (a) MatchCase =
MatchExactWord
= false in the configuration, (b) the source string does not contain the
pattern string as a substring, and (c) the cases do not match in the
first sub-case.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn'></a>
### Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
returns `false` in the event that (a) MatchCase =
true and MatchExactWord
= false in the configuration, (b) the source string does not contain the
pattern string as a substring, and even if (c) the cases do not
match in the first sub-case but the cases match in the second.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch'></a>
### Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
returns `false` in the event that (a) MatchCase =
true and MatchExactWord
= false in the configuration, (b) the source string does not contain the
pattern string as a substring, but (c) the cases do not match in
neither the first sub-case nor in the second.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesMatch'></a>
### Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesMatch() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
returns `false` in the event that (a) MatchCase =
true and MatchExactWord
= false in the configuration, (b) the source string does not contain the
pattern string as a substring, but (c) the cases match in both the
first sub-case and in the second.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_FalseReturned_IfSourceExactlyMatchesPattern_WhenMatchExactWord_IsTurnedOn_And_MatchCase_IsTurnedOff'></a>
### Test_FalseReturned_IfSourceExactlyMatchesPattern_WhenMatchExactWord_IsTurnedOn_And_MatchCase_IsTurnedOff() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
returns `true` in the event that (a) MatchCase =
false and MatchExactWord
= true in the configuration, (b) the source string exactly matches the
pattern string, and (c) the cases do not match in the first sub-case
but the cases match in the second.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_TrueReturned_IfSourceContainsPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOff'></a>
### Test_TrueReturned_IfSourceContainsPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOff() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
returns `true` in the event that (a) MatchCase =
MatchExactWord
= false in the configuration, (b) the source string contains the
pattern string as a substring, and (c) the cases do not match in the
first sub-case.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_TrueReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn'></a>
### Test_TrueReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
returns `true` in the event that (a) MatchCase =
true and MatchExactWord
= false in the configuration, (b) the source string contains the
pattern string as a substring, and if (c) the cases match in the
first sub-case and in the second.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_TrueReturned_WhenSourceExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn'></a>
### Test_TrueReturned_WhenSourceExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
returns `true` in the event that (a) MatchCase =
MatchExactWord
= true in the configuration, and (b) the source string exactly
matches the pattern string as a substring (including case).

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextExpressionMatchingEngineTestBase-Test_WhenMatchCaseOn_AndMatchExactWordOn_FalseReturned_IfSourceContainsPattern'></a>
### Test_WhenMatchCaseOn_AndMatchExactWordOn_FalseReturned_IfSourceContainsPattern() `method`

##### Summary

Asserts the
[IsMatch](#M-MFR-Objects-ITextExpressionMatchingEngine-IsMatch 'MFR.Objects.ITextExpressionMatchingEngine.IsMatch')
method
returns `false` in the event that (a) MatchCase =
MatchExactWord
= true in the configuration, (b) the source string does contain the
pattern string as a substring, and (c) the cases do not match in the
first sub-case.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Engines-Matching-Tests-TextInFilesMatchingEngineTests'></a>
## TextInFilesMatchingEngineTests `type`

##### Namespace

MFR.Objects.Engines.Matching.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[TextInFilesMatchingEngine](#T-MFR-Objects-Engines-Matching-TextInFilesMatchingEngine 'MFR.Objects.Engines.Matching.TextInFilesMatchingEngine')
class.

<a name='M-MFR-Objects-Engines-Matching-Tests-TextInFilesMatchingEngineTests-Test_Match_WithCaseAndNotExactWords_Found_InCsProjFile'></a>
### Test_Match_WithCaseAndNotExactWords_Found_InCsProjFile() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.
