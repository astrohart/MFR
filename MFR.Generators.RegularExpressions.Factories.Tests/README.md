<a name='assembly'></a>
# MFR.Generators.RegularExpressions.Factories.Tests

## Contents

- [GetRegularExpressionGeneratorTests](#T-MFR-Generators-RegularExpressions-Factories-Tests-GetRegularExpressionGeneratorTests 'MFR.Generators.RegularExpressions.Factories.Tests.GetRegularExpressionGeneratorTests')
  - [CreateNewRegularExpressionGeneratorFor()](#M-MFR-Generators-RegularExpressions-Factories-Tests-GetRegularExpressionGeneratorTests-CreateNewRegularExpressionGeneratorFor-MFR-Generators-RegularExpressions-Constants-RegularExpressionType- 'MFR.Generators.RegularExpressions.Factories.Tests.GetRegularExpressionGeneratorTests.CreateNewRegularExpressionGeneratorFor(MFR.Generators.RegularExpressions.Constants.RegularExpressionType)')
  - [Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_GeneratesCorrectRegExp()](#M-MFR-Generators-RegularExpressions-Factories-Tests-GetRegularExpressionGeneratorTests-Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_GeneratesCorrectRegExp 'MFR.Generators.RegularExpressions.Factories.Tests.GetRegularExpressionGeneratorTests.Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_GeneratesCorrectRegExp')
  - [Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_Implements_IRegularExpressionGenerator()](#M-MFR-Generators-RegularExpressions-Factories-Tests-GetRegularExpressionGeneratorTests-Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_Implements_IRegularExpressionGenerator 'MFR.Generators.RegularExpressions.Factories.Tests.GetRegularExpressionGeneratorTests.Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_Implements_IRegularExpressionGenerator')
  - [Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_IsCorrectConcreteType()](#M-MFR-Generators-RegularExpressions-Factories-Tests-GetRegularExpressionGeneratorTests-Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_IsCorrectConcreteType 'MFR.Generators.RegularExpressions.Factories.Tests.GetRegularExpressionGeneratorTests.Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_IsCorrectConcreteType')
- [Resources](#T-MFR-Generators-RegularExpressions-Factories-Tests-Properties-Resources 'MFR.Generators.RegularExpressions.Factories.Tests.Properties.Resources')
  - [Culture](#P-MFR-Generators-RegularExpressions-Factories-Tests-Properties-Resources-Culture 'MFR.Generators.RegularExpressions.Factories.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Generators-RegularExpressions-Factories-Tests-Properties-Resources-ResourceManager 'MFR.Generators.RegularExpressions.Factories.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Generators-RegularExpressions-Factories-Tests-GetRegularExpressionGeneratorTests'></a>
## GetRegularExpressionGeneratorTests `type`

##### Namespace

MFR.Generators.RegularExpressions.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[GetRegularExpressionGenerator](#T-MFR-Generators-RegularExpressions-Factories-GetRegularExpressionGenerator 'MFR.Generators.RegularExpressions.Factories.GetRegularExpressionGenerator')
class.

<a name='M-MFR-Generators-RegularExpressions-Factories-Tests-GetRegularExpressionGeneratorTests-CreateNewRegularExpressionGeneratorFor-MFR-Generators-RegularExpressions-Constants-RegularExpressionType-'></a>
### CreateNewRegularExpressionGeneratorFor() `method`

##### Summary

Creates a new instance of an object that implements the
[IRegularExpressionGenerator](#T-MFR-Generators-RegularExpressions-Interfaces-IRegularExpressionGenerator 'MFR.Generators.RegularExpressions.Interfaces.IRegularExpressionGenerator')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IRegularExpressionGenerator](#T-MFR-Generators-RegularExpressions-Interfaces-IRegularExpressionGenerator 'MFR.Generators.RegularExpressions.Interfaces.IRegularExpressionGenerator')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Generators-RegularExpressions-Factories-Tests-GetRegularExpressionGeneratorTests-Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_GeneratesCorrectRegExp'></a>
### Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_GeneratesCorrectRegExp() `method`

##### Summary

Asserts that the return value of the
[For](#M-MFR-Generators-RegularExpressions-Factories-GetRegularExpressionGenerator-For 'MFR.Generators.RegularExpressions.Factories.GetRegularExpressionGenerator.For')
method implements the
[IRegularExpressionGenerator](#T-MFR-Generators-RegularExpressions-Interfaces-IRegularExpressionGenerator 'MFR.Generators.RegularExpressions.Interfaces.IRegularExpressionGenerator')
interface and is an instance of the
[MatchExactWordOnlyRegularExpressionGenerator](#T-MFR-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator 'MFR.Generators.RegularExpressions.MatchExactWordOnlyRegularExpressionGenerator')
class, when the
[MatchExactWordOnly](#T-MFR-Generators-RegularExpressions-Constants-RegularExpressionType-MatchExactWordOnly 'MFR.Generators.RegularExpressions.Constants.RegularExpressionType.MatchExactWordOnly')
value is passed for its parameter.

##### Parameters

This method has no parameters.

<a name='M-MFR-Generators-RegularExpressions-Factories-Tests-GetRegularExpressionGeneratorTests-Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_Implements_IRegularExpressionGenerator'></a>
### Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_Implements_IRegularExpressionGenerator() `method`

##### Summary

Asserts that the return value of the
[For](#M-MFR-Generators-RegularExpressions-Factories-GetRegularExpressionGenerator-For 'MFR.Generators.RegularExpressions.Factories.GetRegularExpressionGenerator.For')
method implements the
[IRegularExpressionGenerator](#T-MFR-Generators-RegularExpressions-Interfaces-IRegularExpressionGenerator 'MFR.Generators.RegularExpressions.Interfaces.IRegularExpressionGenerator')
interface when the
[MatchExactWordOnly](#T-MFR-Generators-RegularExpressions-Constants-RegularExpressionType-MatchExactWordOnly 'MFR.Generators.RegularExpressions.Constants.RegularExpressionType.MatchExactWordOnly')
value is passed for its parameter.

##### Parameters

This method has no parameters.

<a name='M-MFR-Generators-RegularExpressions-Factories-Tests-GetRegularExpressionGeneratorTests-Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_IsCorrectConcreteType'></a>
### Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_IsCorrectConcreteType() `method`

##### Summary

Asserts that the return value of the
[For](#M-MFR-Generators-RegularExpressions-Factories-GetRegularExpressionGenerator-For 'MFR.Generators.RegularExpressions.Factories.GetRegularExpressionGenerator.For')
method implements the
[IRegularExpressionGenerator](#T-MFR-Generators-RegularExpressions-Interfaces-IRegularExpressionGenerator 'MFR.Generators.RegularExpressions.Interfaces.IRegularExpressionGenerator')
interface and is an instance of the
[MatchExactWordOnlyRegularExpressionGenerator](#T-MFR-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator 'MFR.Generators.RegularExpressions.MatchExactWordOnlyRegularExpressionGenerator')
class, when the
[MatchExactWordOnly](#T-MFR-Generators-RegularExpressions-Constants-RegularExpressionType-MatchExactWordOnly 'MFR.Generators.RegularExpressions.Constants.RegularExpressionType.MatchExactWordOnly')
value is passed for its parameter.

##### Parameters

This method has no parameters.

<a name='T-MFR-Generators-RegularExpressions-Factories-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Generators.RegularExpressions.Factories.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Generators-RegularExpressions-Factories-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Generators-RegularExpressions-Factories-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
