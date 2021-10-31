<a name='assembly'></a>
# MFR.Matchers.Factories.Tests

## Contents

- [GetStringMatcherTests](#T-MFR-Objects-Matchers-Factories-Tests-GetStringMatcherTests 'MFR.Matchers.Factories.Tests.GetStringMatcherTests')
  - [Test_For_Returns_ImplementerOf_IStringMatcherFactory_When_RenameFilesInFolder_IsOperationType()](#M-MFR-Objects-Matchers-Factories-Tests-GetStringMatcherTests-Test_For_Returns_ImplementerOf_IStringMatcherFactory_When_RenameFilesInFolder_IsOperationType 'MFR.Matchers.Factories.Tests.GetStringMatcherTests.Test_For_Returns_ImplementerOf_IStringMatcherFactory_When_RenameFilesInFolder_IsOperationType')
  - [Test_For_Returns_RenameFilesInFolderStringMatcherFactory_When_RenameFilesInFolder_IsOperationType()](#M-MFR-Objects-Matchers-Factories-Tests-GetStringMatcherTests-Test_For_Returns_RenameFilesInFolderStringMatcherFactory_When_RenameFilesInFolder_IsOperationType 'MFR.Matchers.Factories.Tests.GetStringMatcherTests.Test_For_Returns_RenameFilesInFolderStringMatcherFactory_When_RenameFilesInFolder_IsOperationType')
  - [Test_For_Returns_RenameSubFoldersStringMatcherFactory_When_RenameSubFolders_IsOperationType()](#M-MFR-Objects-Matchers-Factories-Tests-GetStringMatcherTests-Test_For_Returns_RenameSubFoldersStringMatcherFactory_When_RenameSubFolders_IsOperationType 'MFR.Matchers.Factories.Tests.GetStringMatcherTests.Test_For_Returns_RenameSubFoldersStringMatcherFactory_When_RenameSubFolders_IsOperationType')
  - [Test_For_Returns_ReplaceTextInFilesStringMatcherFactory_When_ReplaceTextInFiles_IsOperationType()](#M-MFR-Objects-Matchers-Factories-Tests-GetStringMatcherTests-Test_For_Returns_ReplaceTextInFilesStringMatcherFactory_When_ReplaceTextInFiles_IsOperationType 'MFR.Matchers.Factories.Tests.GetStringMatcherTests.Test_For_Returns_ReplaceTextInFilesStringMatcherFactory_When_ReplaceTextInFiles_IsOperationType')
- [RenameFilesInFolderStringMatcherFactoryTests](#T-MFR-Objects-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests 'MFR.Matchers.Factories.Tests.RenameFilesInFolderStringMatcherFactoryTests')
  - [Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue()](#M-MFR-Objects-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue 'MFR.Matchers.Factories.Tests.RenameFilesInFolderStringMatcherFactoryTests.Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue')
  - [Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher()](#M-MFR-Objects-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher 'MFR.Matchers.Factories.Tests.RenameFilesInFolderStringMatcherFactoryTests.Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher')
  - [Test_OperationType_Property_IsSetTo_RenameFilesInFolder()](#M-MFR-Objects-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_OperationType_Property_IsSetTo_RenameFilesInFolder 'MFR.Matchers.Factories.Tests.RenameFilesInFolderStringMatcherFactoryTests.Test_OperationType_Property_IsSetTo_RenameFilesInFolder')
  - [Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue()](#M-MFR-Objects-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue 'MFR.Matchers.Factories.Tests.RenameFilesInFolderStringMatcherFactoryTests.Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue')
- [RenameSubFoldersStringMatcherFactoryTests](#T-MFR-Objects-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests 'MFR.Matchers.Factories.Tests.RenameSubFoldersStringMatcherFactoryTests')
  - [Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue()](#M-MFR-Objects-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue 'MFR.Matchers.Factories.Tests.RenameSubFoldersStringMatcherFactoryTests.Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue')
  - [Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher()](#M-MFR-Objects-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher 'MFR.Matchers.Factories.Tests.RenameSubFoldersStringMatcherFactoryTests.Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher')
  - [Test_OperationType_Property_IsSetTo_RenameSubFolders()](#M-MFR-Objects-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_OperationType_Property_IsSetTo_RenameSubFolders 'MFR.Matchers.Factories.Tests.RenameSubFoldersStringMatcherFactoryTests.Test_OperationType_Property_IsSetTo_RenameSubFolders')
  - [Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue()](#M-MFR-Objects-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue 'MFR.Matchers.Factories.Tests.RenameSubFoldersStringMatcherFactoryTests.Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue')
- [ReplaceTextInFilesStringMatcherFactoryTests](#T-MFR-Objects-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests 'MFR.Matchers.Factories.Tests.ReplaceTextInFilesStringMatcherFactoryTests')
  - [Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue()](#M-MFR-Objects-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue 'MFR.Matchers.Factories.Tests.ReplaceTextInFilesStringMatcherFactoryTests.Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue')
  - [Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher()](#M-MFR-Objects-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher 'MFR.Matchers.Factories.Tests.ReplaceTextInFilesStringMatcherFactoryTests.Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher')
  - [Test_OperationType_Property_IsSetTo_ReplaceTextInFiles()](#M-MFR-Objects-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_OperationType_Property_IsSetTo_ReplaceTextInFiles 'MFR.Matchers.Factories.Tests.ReplaceTextInFilesStringMatcherFactoryTests.Test_OperationType_Property_IsSetTo_ReplaceTextInFiles')
  - [Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue()](#M-MFR-Objects-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue 'MFR.Matchers.Factories.Tests.ReplaceTextInFilesStringMatcherFactoryTests.Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue')
- [Resources](#T-MFR-Objects-Matchers-Factories-Tests-Properties-Resources 'MFR.Matchers.Factories.Tests.Properties.Resources')
  - [Culture](#P-MFR-Objects-Matchers-Factories-Tests-Properties-Resources-Culture 'MFR.Matchers.Factories.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Matchers-Factories-Tests-Properties-Resources-ResourceManager 'MFR.Matchers.Factories.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Matchers-Factories-Tests-GetStringMatcherTests'></a>
## GetStringMatcherTests `type`

##### Namespace

MFR.Matchers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[GetStringMatcher](#T-MFR-Objects-GetStringMatcher 'MFR.GetStringMatcher')
class.

<a name='M-MFR-Objects-Matchers-Factories-Tests-GetStringMatcherTests-Test_For_Returns_ImplementerOf_IStringMatcherFactory_When_RenameFilesInFolder_IsOperationType'></a>
### Test_For_Returns_ImplementerOf_IStringMatcherFactory_When_RenameFilesInFolder_IsOperationType() `method`

##### Summary

Asserts that the [For](#M-MFR-Objects-GetStringMatcher-For 'MFR.GetStringMatcher.For')
method returns a reference to an instance of an object that
implements the [IStringMatcherFactory](#T-MFR-Objects-IStringMatcherFactory 'MFR.IStringMatcherFactory')
interface when the
[RenameFilesInFolder](#T-MFR-Objects-OperationType-RenameFilesInFolder 'MFR.OperationType.RenameFilesInFolder')
value is
passed for its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-Tests-GetStringMatcherTests-Test_For_Returns_RenameFilesInFolderStringMatcherFactory_When_RenameFilesInFolder_IsOperationType'></a>
### Test_For_Returns_RenameFilesInFolderStringMatcherFactory_When_RenameFilesInFolder_IsOperationType() `method`

##### Summary

Asserts that the [For](#M-MFR-Objects-GetStringMatcher-For 'MFR.GetStringMatcher.For')
method returns a reference to an instance of
[RenameFilesInFolderStringMatcherFactory](#T-MFR-Objects-RenameFilesInFolderStringMatcherFactory 'MFR.RenameFilesInFolderStringMatcherFactory')
when
the [RenameFilesInFolder](#T-MFR-Objects-OperationType-RenameFilesInFolder 'MFR.OperationType.RenameFilesInFolder')
enumeration value is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-Tests-GetStringMatcherTests-Test_For_Returns_RenameSubFoldersStringMatcherFactory_When_RenameSubFolders_IsOperationType'></a>
### Test_For_Returns_RenameSubFoldersStringMatcherFactory_When_RenameSubFolders_IsOperationType() `method`

##### Summary

Asserts that the [For](#M-MFR-Objects-GetStringMatcher-For 'MFR.GetStringMatcher.For')
method returns a reference to an instance of
[RenameSubFoldersStringMatcherFactory](#T-MFR-Objects-RenameSubFoldersStringMatcherFactory 'MFR.RenameSubFoldersStringMatcherFactory')
when the
[RenameSubFolders](#T-MFR-Objects-OperationType-RenameSubFolders 'MFR.OperationType.RenameSubFolders')
enumeration value is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-Tests-GetStringMatcherTests-Test_For_Returns_ReplaceTextInFilesStringMatcherFactory_When_ReplaceTextInFiles_IsOperationType'></a>
### Test_For_Returns_ReplaceTextInFilesStringMatcherFactory_When_ReplaceTextInFiles_IsOperationType() `method`

##### Summary

Asserts that the [For](#M-MFR-Objects-GetStringMatcher-For 'MFR.GetStringMatcher.For')
method returns a reference to an instance of
[ReplaceTextInFilesStringMatcherFactory](#T-MFR-Objects-ReplaceTextInFilesStringMatcherFactory 'MFR.ReplaceTextInFilesStringMatcherFactory')
when
the [ReplaceTextInFiles](#T-MFR-Objects-OperationType-ReplaceTextInFiles 'MFR.OperationType.ReplaceTextInFiles')
enumeration value is passed as its argument.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests'></a>
## RenameFilesInFolderStringMatcherFactoryTests `type`

##### Namespace

MFR.Matchers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[RenameFilesInFolderStringMatcherFactory](#T-MFR-Objects-RenameFilesInFolderStringMatcherFactory 'MFR.RenameFilesInFolderStringMatcherFactory')
class.

<a name='M-MFR-Objects-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue'></a>
### Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue() `method`

##### Summary

Asserts that the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method returns an instance of the correct concrete type that
corresponds to the particular
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value that
is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher'></a>
### Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher() `method`

##### Summary

Asserts that each object reference returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method for the
[RenameFilesInFolder](#T-MFR-Objects-OperationType-RenameFilesInFolder 'MFR.OperationType.RenameFilesInFolder')
value implements the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.IStringMatcher')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_OperationType_Property_IsSetTo_RenameFilesInFolder'></a>
### Test_OperationType_Property_IsSetTo_RenameFilesInFolder() `method`

##### Summary

Asserts that the
[OperationType](#P-MFR-Objects-IFixedOperationTypeSpecificObject-OperationType 'MFR.IFixedOperationTypeSpecificObject.OperationType')
property of each of the objects returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method for each
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value, and
for the
[RenameFilesInFolder](#T-MFR-Objects-OperationType-RenameFilesInFolder 'MFR.OperationType.RenameFilesInFolder')
value, is set to that value.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-Tests-RenameFilesInFolderStringMatcherFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue'></a>
### Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue() `method`

##### Summary

Asserts that the
[TextMatchingConfiguration](#P-MFR-Objects-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
property of each of the concrete types returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method has the same value as was supplied to the method.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests'></a>
## RenameSubFoldersStringMatcherFactoryTests `type`

##### Namespace

MFR.Matchers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[RenameSubFoldersStringMatcherFactory](#T-MFR-Objects-RenameSubFoldersStringMatcherFactory 'MFR.RenameSubFoldersStringMatcherFactory')
class.

<a name='M-MFR-Objects-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue'></a>
### Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue() `method`

##### Summary

Asserts that the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method returns an instance of the correct concrete type that
corresponds to the particular
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value that
is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher'></a>
### Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher() `method`

##### Summary

Asserts that each object reference returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method for the
[RenameSubFolders](#T-MFR-Objects-OperationType-RenameSubFolders 'MFR.OperationType.RenameSubFolders')
value implements the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.IStringMatcher')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_OperationType_Property_IsSetTo_RenameSubFolders'></a>
### Test_OperationType_Property_IsSetTo_RenameSubFolders() `method`

##### Summary

Asserts that the
[OperationType](#P-MFR-Objects-IFixedOperationTypeSpecificObject-OperationType 'MFR.IFixedOperationTypeSpecificObject.OperationType')
property of each of the objects returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method for each
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value, and
for the
[RenameSubFolders](#T-MFR-Objects-OperationType-RenameSubFolders 'MFR.OperationType.RenameSubFolders')
value, is set to that value.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-Tests-RenameSubFoldersStringMatcherFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue'></a>
### Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue() `method`

##### Summary

Asserts that the
[TextMatchingConfiguration](#P-MFR-Objects-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
property of each of the concrete types returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method has the same value as was supplied to the method.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests'></a>
## ReplaceTextInFilesStringMatcherFactoryTests `type`

##### Namespace

MFR.Matchers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ReplaceTextInFilesStringMatcherFactory](#T-MFR-Objects-ReplaceTextInFilesStringMatcherFactory 'MFR.ReplaceTextInFilesStringMatcherFactory')
class.

<a name='M-MFR-Objects-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue'></a>
### Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue() `method`

##### Summary

Asserts that the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method returns an instance of the correct concrete type that
corresponds to the particular
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value that
is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher'></a>
### Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher() `method`

##### Summary

Asserts that each object reference returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method for the
[ReplaceTextInFiles](#T-MFR-Objects-OperationType-ReplaceTextInFiles 'MFR.OperationType.ReplaceTextInFiles')
value implements the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.IStringMatcher')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_OperationType_Property_IsSetTo_ReplaceTextInFiles'></a>
### Test_OperationType_Property_IsSetTo_ReplaceTextInFiles() `method`

##### Summary

Asserts that the
[OperationType](#P-MFR-Objects-IFixedOperationTypeSpecificObject-OperationType 'MFR.IFixedOperationTypeSpecificObject.OperationType')
property of each of the objects returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method for each
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value, and
for the
[ReplaceTextInFiles](#T-MFR-Objects-OperationType-ReplaceTextInFiles 'MFR.OperationType.ReplaceTextInFiles')
value, is set to that value.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-Tests-ReplaceTextInFilesStringMatcherFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue'></a>
### Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue() `method`

##### Summary

Asserts that the
[TextMatchingConfiguration](#P-MFR-Objects-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
property of each of the concrete types returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringMatcherFactory-AndTextMatchingConfiguration 'MFR.IStringMatcherFactory.AndTextMatchingConfiguration')
method has the same value as was supplied to the method.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Matchers-Factories-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Matchers.Factories.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Matchers-Factories-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Matchers-Factories-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
