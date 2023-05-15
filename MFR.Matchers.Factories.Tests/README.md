<a name='assembly'></a>
# MFR.Matchers.Factories.Tests

## Contents

- [GetStringMatcherFactoryTests](#T-MFR-Matchers-Factories-Tests-GetStringMatcherFactoryTests 'MFR.Matchers.Factories.Tests.GetStringMatcherFactoryTests')
  - [Test_For_Returns_ImplementerOf_IStringMatcherFactory_When_RenameFilesInFolder_IsOperationType()](#M-MFR-Matchers-Factories-Tests-GetStringMatcherFactoryTests-Test_For_Returns_ImplementerOf_IStringMatcherFactory_When_RenameFilesInFolder_IsOperationType 'MFR.Matchers.Factories.Tests.GetStringMatcherFactoryTests.Test_For_Returns_ImplementerOf_IStringMatcherFactory_When_RenameFilesInFolder_IsOperationType')
  - [Test_For_Returns_RenameFilesInFolderStringMatcherFactory_When_RenameFilesInFolder_IsOperationType()](#M-MFR-Matchers-Factories-Tests-GetStringMatcherFactoryTests-Test_For_Returns_RenameFilesInFolderStringMatcherFactory_When_RenameFilesInFolder_IsOperationType 'MFR.Matchers.Factories.Tests.GetStringMatcherFactoryTests.Test_For_Returns_RenameFilesInFolderStringMatcherFactory_When_RenameFilesInFolder_IsOperationType')
  - [Test_For_Returns_RenameSubFoldersStringMatcherFactory_When_RenameSubFolders_IsOperationType()](#M-MFR-Matchers-Factories-Tests-GetStringMatcherFactoryTests-Test_For_Returns_RenameSubFoldersStringMatcherFactory_When_RenameSubFolders_IsOperationType 'MFR.Matchers.Factories.Tests.GetStringMatcherFactoryTests.Test_For_Returns_RenameSubFoldersStringMatcherFactory_When_RenameSubFolders_IsOperationType')
  - [Test_For_Returns_ReplaceTextInFilesStringMatcherFactory_When_ReplaceTextInFiles_IsOperationType()](#M-MFR-Matchers-Factories-Tests-GetStringMatcherFactoryTests-Test_For_Returns_ReplaceTextInFilesStringMatcherFactory_When_ReplaceTextInFiles_IsOperationType 'MFR.Matchers.Factories.Tests.GetStringMatcherFactoryTests.Test_For_Returns_ReplaceTextInFilesStringMatcherFactory_When_ReplaceTextInFiles_IsOperationType')
- [RenameFilesInFolderStringMatcherFactoryTests](#T-MFR-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests 'MFR.Matchers.Factories.Tests.RenameFilesInFolderStringMatcherFactoryTests')
  - [Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue()](#M-MFR-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue 'MFR.Matchers.Factories.Tests.RenameFilesInFolderStringMatcherFactoryTests.Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue')
  - [Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher()](#M-MFR-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher 'MFR.Matchers.Factories.Tests.RenameFilesInFolderStringMatcherFactoryTests.Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher')
  - [Test_OperationType_Property_IsSetTo_RenameFilesInFolder()](#M-MFR-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_OperationType_Property_IsSetTo_RenameFilesInFolder 'MFR.Matchers.Factories.Tests.RenameFilesInFolderStringMatcherFactoryTests.Test_OperationType_Property_IsSetTo_RenameFilesInFolder')
  - [Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue()](#M-MFR-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue 'MFR.Matchers.Factories.Tests.RenameFilesInFolderStringMatcherFactoryTests.Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue')
- [RenameSubFoldersStringMatcherFactoryTests](#T-MFR-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests 'MFR.Matchers.Factories.Tests.RenameSubFoldersStringMatcherFactoryTests')
  - [Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue()](#M-MFR-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue 'MFR.Matchers.Factories.Tests.RenameSubFoldersStringMatcherFactoryTests.Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue')
  - [Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher()](#M-MFR-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher 'MFR.Matchers.Factories.Tests.RenameSubFoldersStringMatcherFactoryTests.Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher')
  - [Test_OperationType_Property_IsSetTo_RenameSubFolders()](#M-MFR-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_OperationType_Property_IsSetTo_RenameSubFolders 'MFR.Matchers.Factories.Tests.RenameSubFoldersStringMatcherFactoryTests.Test_OperationType_Property_IsSetTo_RenameSubFolders')
  - [Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue()](#M-MFR-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue 'MFR.Matchers.Factories.Tests.RenameSubFoldersStringMatcherFactoryTests.Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue')
- [ReplaceTextInFilesStringMatcherFactoryTests](#T-MFR-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests 'MFR.Matchers.Factories.Tests.ReplaceTextInFilesStringMatcherFactoryTests')
  - [Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue()](#M-MFR-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue 'MFR.Matchers.Factories.Tests.ReplaceTextInFilesStringMatcherFactoryTests.Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue')
  - [Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher()](#M-MFR-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher 'MFR.Matchers.Factories.Tests.ReplaceTextInFilesStringMatcherFactoryTests.Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher')
  - [Test_OperationType_Property_IsSetTo_ReplaceTextInFiles()](#M-MFR-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_OperationType_Property_IsSetTo_ReplaceTextInFiles 'MFR.Matchers.Factories.Tests.ReplaceTextInFilesStringMatcherFactoryTests.Test_OperationType_Property_IsSetTo_ReplaceTextInFiles')
  - [Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue()](#M-MFR-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue 'MFR.Matchers.Factories.Tests.ReplaceTextInFilesStringMatcherFactoryTests.Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue')
- [Resources](#T-MFR-Matchers-Factories-Tests-Properties-Resources 'MFR.Matchers.Factories.Tests.Properties.Resources')
  - [Culture](#P-MFR-Matchers-Factories-Tests-Properties-Resources-Culture 'MFR.Matchers.Factories.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Matchers-Factories-Tests-Properties-Resources-ResourceManager 'MFR.Matchers.Factories.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Matchers-Factories-Tests-GetStringMatcherFactoryTests'></a>
## GetStringMatcherFactoryTests `type`

##### Namespace

MFR.Matchers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[GetStringMatcherFactory](#T-MFR-GetStringMatcherFactory 'MFR.GetStringMatcherFactory')
class.

<a name='M-MFR-Matchers-Factories-Tests-GetStringMatcherFactoryTests-Test_For_Returns_ImplementerOf_IStringMatcherFactory_When_RenameFilesInFolder_IsOperationType'></a>
### Test_For_Returns_ImplementerOf_IStringMatcherFactory_When_RenameFilesInFolder_IsOperationType() `method`

##### Summary

Asserts that the [For](#M-MFR-GetStringMatcherFactory-For 'MFR.GetStringMatcherFactory.For')
method returns a reference to an instance of an object that
implements the [IStringMatcherFactory](#T-MFR-IStringMatcherFactory 'MFR.IStringMatcherFactory')
interface when the
[RenameFilesInFolder](#T-MFR-Operations-Constants-OperationType-RenameFilesInFolder 'MFR.Operations.Constants.OperationType.RenameFilesInFolder')
value is
passed for its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-Tests-GetStringMatcherFactoryTests-Test_For_Returns_RenameFilesInFolderStringMatcherFactory_When_RenameFilesInFolder_IsOperationType'></a>
### Test_For_Returns_RenameFilesInFolderStringMatcherFactory_When_RenameFilesInFolder_IsOperationType() `method`

##### Summary

Asserts that the [For](#M-MFR-GetStringMatcherFactory-For 'MFR.GetStringMatcherFactory.For')
method returns a reference to an instance of
[RenameFilesInFolderStringMatcherFactory](#T-MFR-RenameFilesInFolderStringMatcherFactory 'MFR.RenameFilesInFolderStringMatcherFactory')
when
the [RenameFilesInFolder](#T-MFR-Operations-Constants-OperationType-RenameFilesInFolder 'MFR.Operations.Constants.OperationType.RenameFilesInFolder')
enumeration value is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-Tests-GetStringMatcherFactoryTests-Test_For_Returns_RenameSubFoldersStringMatcherFactory_When_RenameSubFolders_IsOperationType'></a>
### Test_For_Returns_RenameSubFoldersStringMatcherFactory_When_RenameSubFolders_IsOperationType() `method`

##### Summary

Asserts that the [For](#M-MFR-GetStringMatcherFactory-For 'MFR.GetStringMatcherFactory.For')
method returns a reference to an instance of
[RenameSubFoldersStringMatcherFactory](#T-MFR-RenameSubFoldersStringMatcherFactory 'MFR.RenameSubFoldersStringMatcherFactory')
when the
[RenameSubFolders](#T-MFR-Operations-Constants-OperationType-RenameSubFolders 'MFR.Operations.Constants.OperationType.RenameSubFolders')
enumeration value is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-Tests-GetStringMatcherFactoryTests-Test_For_Returns_ReplaceTextInFilesStringMatcherFactory_When_ReplaceTextInFiles_IsOperationType'></a>
### Test_For_Returns_ReplaceTextInFilesStringMatcherFactory_When_ReplaceTextInFiles_IsOperationType() `method`

##### Summary

Asserts that the [For](#M-MFR-GetStringMatcherFactory-For 'MFR.GetStringMatcherFactory.For')
method returns a reference to an instance of
[ReplaceTextInFilesStringMatcherFactory](#T-MFR-ReplaceTextInFilesStringMatcherFactory 'MFR.ReplaceTextInFilesStringMatcherFactory')
when
the [ReplaceTextInFiles](#T-MFR-Operations-Constants-OperationType-ReplaceTextInFiles 'MFR.Operations.Constants.OperationType.ReplaceTextInFiles')
enumeration value is passed as its argument.

##### Parameters

This method has no parameters.

<a name='T-MFR-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests'></a>
## RenameFilesInFolderStringMatcherFactoryTests `type`

##### Namespace

MFR.Matchers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[RenameFilesInFolderStringMatcherFactory](#T-MFR-RenameFilesInFolderStringMatcherFactory 'MFR.RenameFilesInFolderStringMatcherFactory')
class.

<a name='M-MFR-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue'></a>
### Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue() `method`

##### Summary

Asserts that the
[AndTextMatchingConfiguration](#M-MFR-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method returns an instance of the correct concrete type that
corresponds to the particular
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value that
is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher'></a>
### Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher() `method`

##### Summary

Asserts that each object reference returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method for the
[RenameFilesInFolder](#T-MFR-Operations-Constants-OperationType-RenameFilesInFolder 'MFR.Operations.Constants.OperationType.RenameFilesInFolder')
value implements the
[IStringMatcher](#T-MFR-IStringMatcher 'MFR.IStringMatcher')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_OperationType_Property_IsSetTo_RenameFilesInFolder'></a>
### Test_OperationType_Property_IsSetTo_RenameFilesInFolder() `method`

##### Summary

Asserts that the
[OperationType](#P-MFR-IFixedOperationTypeSpecificObject-OperationType 'MFR.IFixedOperationTypeSpecificObject.OperationType')
property of each of the objects returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method for each
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value, and
for the
[RenameFilesInFolder](#T-MFR-Operations-Constants-OperationType-RenameFilesInFolder 'MFR.Operations.Constants.OperationType.RenameFilesInFolder')
value, is set to that value.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue'></a>
### Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue() `method`

##### Summary

Asserts that the
[TextMatchingConfiguration](#P-MFR-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
property of each of the concrete types returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method has the same value as was supplied to the method.

##### Parameters

This method has no parameters.

<a name='T-MFR-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests'></a>
## RenameSubFoldersStringMatcherFactoryTests `type`

##### Namespace

MFR.Matchers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[RenameSubFoldersStringMatcherFactory](#T-MFR-RenameSubFoldersStringMatcherFactory 'MFR.RenameSubFoldersStringMatcherFactory')
class.

<a name='M-MFR-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue'></a>
### Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue() `method`

##### Summary

Asserts that the
[AndTextMatchingConfiguration](#M-MFR-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method returns an instance of the correct concrete type that
corresponds to the particular
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value that
is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher'></a>
### Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher() `method`

##### Summary

Asserts that each object reference returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method for the
[RenameSubFolders](#T-MFR-Operations-Constants-OperationType-RenameSubFolders 'MFR.Operations.Constants.OperationType.RenameSubFolders')
value implements the
[IStringMatcher](#T-MFR-IStringMatcher 'MFR.IStringMatcher')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_OperationType_Property_IsSetTo_RenameSubFolders'></a>
### Test_OperationType_Property_IsSetTo_RenameSubFolders() `method`

##### Summary

Asserts that the
[OperationType](#P-MFR-IFixedOperationTypeSpecificObject-OperationType 'MFR.IFixedOperationTypeSpecificObject.OperationType')
property of each of the objects returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method for each
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value, and
for the
[RenameSubFolders](#T-MFR-Operations-Constants-OperationType-RenameSubFolders 'MFR.Operations.Constants.OperationType.RenameSubFolders')
value, is set to that value.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue'></a>
### Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue() `method`

##### Summary

Asserts that the
[TextMatchingConfiguration](#P-MFR-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
property of each of the concrete types returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method has the same value as was supplied to the method.

##### Parameters

This method has no parameters.

<a name='T-MFR-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests'></a>
## ReplaceTextInFilesStringMatcherFactoryTests `type`

##### Namespace

MFR.Matchers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ReplaceTextInFilesStringMatcherFactory](#T-MFR-ReplaceTextInFilesStringMatcherFactory 'MFR.ReplaceTextInFilesStringMatcherFactory')
class.

<a name='M-MFR-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue'></a>
### Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue() `method`

##### Summary

Asserts that the
[AndTextMatchingConfiguration](#M-MFR-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method returns an instance of the correct concrete type that
corresponds to the particular
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value that
is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher'></a>
### Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher() `method`

##### Summary

Asserts that each object reference returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method for the
[ReplaceTextInFiles](#T-MFR-Operations-Constants-OperationType-ReplaceTextInFiles 'MFR.Operations.Constants.OperationType.ReplaceTextInFiles')
value implements the
[IStringMatcher](#T-MFR-IStringMatcher 'MFR.IStringMatcher')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_OperationType_Property_IsSetTo_ReplaceTextInFiles'></a>
### Test_OperationType_Property_IsSetTo_ReplaceTextInFiles() `method`

##### Summary

Asserts that the
[OperationType](#P-MFR-IFixedOperationTypeSpecificObject-OperationType 'MFR.IFixedOperationTypeSpecificObject.OperationType')
property of each of the objects returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method for each
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value, and
for the
[ReplaceTextInFiles](#T-MFR-Operations-Constants-OperationType-ReplaceTextInFiles 'MFR.Operations.Constants.OperationType.ReplaceTextInFiles')
value, is set to that value.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue'></a>
### Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue() `method`

##### Summary

Asserts that the
[TextMatchingConfiguration](#P-MFR-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
property of each of the concrete types returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method has the same value as was supplied to the method.

##### Parameters

This method has no parameters.

<a name='T-MFR-Matchers-Factories-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Matchers.Factories.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Matchers-Factories-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Matchers-Factories-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
