<a name='assembly'></a>
# MFR.Replacers.Factories.Tests

## Contents

- [GetStringReplacerTests](#T-MFR-Replacers-Factories-Tests-GetStringReplacerTests 'MFR.Replacers.Factories.Tests.GetStringReplacerTests')
  - [Test_For_Returns_ImplementerOf_IStringReplacerFactory_When_RenameFilesInFolder_IsOperationType()](#M-MFR-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_ImplementerOf_IStringReplacerFactory_When_RenameFilesInFolder_IsOperationType 'MFR.Replacers.Factories.Tests.GetStringReplacerTests.Test_For_Returns_ImplementerOf_IStringReplacerFactory_When_RenameFilesInFolder_IsOperationType')
  - [Test_For_Returns_RenameFilesInFolderStringReplacerFactory_When_RenameFilesInFolder_IsOperationType()](#M-MFR-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_RenameFilesInFolderStringReplacerFactory_When_RenameFilesInFolder_IsOperationType 'MFR.Replacers.Factories.Tests.GetStringReplacerTests.Test_For_Returns_RenameFilesInFolderStringReplacerFactory_When_RenameFilesInFolder_IsOperationType')
  - [Test_For_Returns_RenameSubFoldersStringReplacerFactory_When_RenameSubFolders_IsOperationType()](#M-MFR-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_RenameSubFoldersStringReplacerFactory_When_RenameSubFolders_IsOperationType 'MFR.Replacers.Factories.Tests.GetStringReplacerTests.Test_For_Returns_RenameSubFoldersStringReplacerFactory_When_RenameSubFolders_IsOperationType')
  - [Test_For_Returns_ReplaceTextInFilesStringReplacerFactory_When_ReplaceTextInFiles_IsOperationType()](#M-MFR-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_ReplaceTextInFilesStringReplacerFactory_When_ReplaceTextInFiles_IsOperationType 'MFR.Replacers.Factories.Tests.GetStringReplacerTests.Test_For_Returns_ReplaceTextInFilesStringReplacerFactory_When_ReplaceTextInFiles_IsOperationType')
- [RenameFilesInFolderStringReplacerFactoryTests](#T-MFR-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests 'MFR.Replacers.Factories.Tests.RenameFilesInFolderStringReplacerFactoryTests')
  - [Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue()](#M-MFR-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue 'MFR.Replacers.Factories.Tests.RenameFilesInFolderStringReplacerFactoryTests.Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue')
  - [Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer()](#M-MFR-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer 'MFR.Replacers.Factories.Tests.RenameFilesInFolderStringReplacerFactoryTests.Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer')
  - [Test_OperationType_Property_IsSetTo_RenameFilesInFolder()](#M-MFR-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_OperationType_Property_IsSetTo_RenameFilesInFolder 'MFR.Replacers.Factories.Tests.RenameFilesInFolderStringReplacerFactoryTests.Test_OperationType_Property_IsSetTo_RenameFilesInFolder')
  - [Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue()](#M-MFR-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue 'MFR.Replacers.Factories.Tests.RenameFilesInFolderStringReplacerFactoryTests.Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue')
- [RenameSubFoldersStringReplacerFactoryTests](#T-MFR-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests 'MFR.Replacers.Factories.Tests.RenameSubFoldersStringReplacerFactoryTests')
  - [Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue()](#M-MFR-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue 'MFR.Replacers.Factories.Tests.RenameSubFoldersStringReplacerFactoryTests.Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue')
  - [Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer()](#M-MFR-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer 'MFR.Replacers.Factories.Tests.RenameSubFoldersStringReplacerFactoryTests.Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer')
  - [Test_OperationType_Property_IsSetTo_RenameSubFolders()](#M-MFR-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_OperationType_Property_IsSetTo_RenameSubFolders 'MFR.Replacers.Factories.Tests.RenameSubFoldersStringReplacerFactoryTests.Test_OperationType_Property_IsSetTo_RenameSubFolders')
  - [Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue()](#M-MFR-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue 'MFR.Replacers.Factories.Tests.RenameSubFoldersStringReplacerFactoryTests.Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue')
- [ReplaceTextInFilesStringReplacerFactoryTests](#T-MFR-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests 'MFR.Replacers.Factories.Tests.ReplaceTextInFilesStringReplacerFactoryTests')
  - [Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue()](#M-MFR-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue 'MFR.Replacers.Factories.Tests.ReplaceTextInFilesStringReplacerFactoryTests.Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue')
  - [Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer()](#M-MFR-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer 'MFR.Replacers.Factories.Tests.ReplaceTextInFilesStringReplacerFactoryTests.Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer')
  - [Test_OperationType_Property_IsSetTo_ReplaceTextInFiles()](#M-MFR-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_OperationType_Property_IsSetTo_ReplaceTextInFiles 'MFR.Replacers.Factories.Tests.ReplaceTextInFilesStringReplacerFactoryTests.Test_OperationType_Property_IsSetTo_ReplaceTextInFiles')
  - [Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue()](#M-MFR-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue 'MFR.Replacers.Factories.Tests.ReplaceTextInFilesStringReplacerFactoryTests.Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue')
- [Resources](#T-MFR-Replacers-Factories-Tests-Properties-Resources 'MFR.Replacers.Factories.Tests.Properties.Resources')
  - [Culture](#P-MFR-Replacers-Factories-Tests-Properties-Resources-Culture 'MFR.Replacers.Factories.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Replacers-Factories-Tests-Properties-Resources-ResourceManager 'MFR.Replacers.Factories.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Replacers-Factories-Tests-GetStringReplacerTests'></a>
## GetStringReplacerTests `type`

##### Namespace

MFR.Replacers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[GetStringReplacer](#T-MFR-GetStringReplacer 'MFR.GetStringReplacer')
class.

<a name='M-MFR-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_ImplementerOf_IStringReplacerFactory_When_RenameFilesInFolder_IsOperationType'></a>
### Test_For_Returns_ImplementerOf_IStringReplacerFactory_When_RenameFilesInFolder_IsOperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-GetStringReplacer-For 'MFR.GetStringReplacer.For')
method
returns a reference to an instance of an object that implements the
[IStringReplacerFactory](#T-MFR-IStringReplacerFactory 'MFR.IStringReplacerFactory')
interface when the
[RenameFilesInFolder](#T-MFR-Operations-Constants-OperationType-RenameFilesInFolder 'MFR.Operations.Constants.OperationType.RenameFilesInFolder')
value is passed for its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_RenameFilesInFolderStringReplacerFactory_When_RenameFilesInFolder_IsOperationType'></a>
### Test_For_Returns_RenameFilesInFolderStringReplacerFactory_When_RenameFilesInFolder_IsOperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-GetStringReplacer-For 'MFR.GetStringReplacer.For')
method
returns a reference to an instance of
[RenameFilesInFolderStringReplacerFactory](#T-MFR-RenameFilesInFolderStringReplacerFactory 'MFR.RenameFilesInFolderStringReplacerFactory')
when the
[RenameFilesInFolder](#T-MFR-Operations-Constants-OperationType-RenameFilesInFolder 'MFR.Operations.Constants.OperationType.RenameFilesInFolder')
enumeration value is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_RenameSubFoldersStringReplacerFactory_When_RenameSubFolders_IsOperationType'></a>
### Test_For_Returns_RenameSubFoldersStringReplacerFactory_When_RenameSubFolders_IsOperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-GetStringReplacer-For 'MFR.GetStringReplacer.For')
method
returns a reference to an instance of
[RenameSubFoldersStringReplacerFactory](#T-MFR-RenameSubFoldersStringReplacerFactory 'MFR.RenameSubFoldersStringReplacerFactory')
when the
[RenameSubFolders](#T-MFR-Operations-Constants-OperationType-RenameSubFolders 'MFR.Operations.Constants.OperationType.RenameSubFolders')
enumeration value is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_ReplaceTextInFilesStringReplacerFactory_When_ReplaceTextInFiles_IsOperationType'></a>
### Test_For_Returns_ReplaceTextInFilesStringReplacerFactory_When_ReplaceTextInFiles_IsOperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-GetStringReplacer-For 'MFR.GetStringReplacer.For')
method
returns a reference to an instance of
[ReplaceTextInFilesStringReplacerFactory](#T-MFR-ReplaceTextInFilesStringReplacerFactory 'MFR.ReplaceTextInFilesStringReplacerFactory')
when the
[ReplaceTextInFiles](#T-MFR-Operations-Constants-OperationType-ReplaceTextInFiles 'MFR.Operations.Constants.OperationType.ReplaceTextInFiles')
enumeration value is passed as its argument.

##### Parameters

This method has no parameters.

<a name='T-MFR-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests'></a>
## RenameFilesInFolderStringReplacerFactoryTests `type`

##### Namespace

MFR.Replacers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[RenameFilesInFolderStringReplacerFactory](#T-MFR-RenameFilesInFolderStringReplacerFactory 'MFR.RenameFilesInFolderStringReplacerFactory')
class.

<a name='M-MFR-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue'></a>
### Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue() `method`

##### Summary

Asserts that the
[AndTextMatchingConfiguration](#M-MFR-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.IStringReplacerFactory.AndTextMatchingConfiguration')
method returns an instance of the correct concrete type that
corresponds to the particular
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value that
is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer'></a>
### Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer() `method`

##### Summary

Asserts that each object reference returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.IStringReplacerFactory.AndTextMatchingConfiguration')
method for the
[RenameFilesInFolder](#T-MFR-Operations-Constants-OperationType-RenameFilesInFolder 'MFR.Operations.Constants.OperationType.RenameFilesInFolder')
value implements the
[IStringReplacer](#T-MFR-IStringReplacer 'MFR.IStringReplacer')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_OperationType_Property_IsSetTo_RenameFilesInFolder'></a>
### Test_OperationType_Property_IsSetTo_RenameFilesInFolder() `method`

##### Summary

Asserts that the
[OperationType](#P-MFR-IFixedOperationTypeSpecificObject-OperationType 'MFR.IFixedOperationTypeSpecificObject.OperationType')
property of each of the objects returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.IStringReplacerFactory.AndTextMatchingConfiguration')
method for each
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value, and
for the
[RenameFilesInFolder](#T-MFR-Operations-Constants-OperationType-RenameFilesInFolder 'MFR.Operations.Constants.OperationType.RenameFilesInFolder')
value, is set to that value.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue'></a>
### Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue() `method`

##### Summary

Asserts that the
[TextMatchingConfiguration](#P-MFR-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
property of each of the concrete types returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.IStringReplacerFactory.AndTextMatchingConfiguration')
method has the same value as was supplied to the method.

##### Parameters

This method has no parameters.

<a name='T-MFR-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests'></a>
## RenameSubFoldersStringReplacerFactoryTests `type`

##### Namespace

MFR.Replacers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[RenameSubFoldersStringReplacerFactory](#T-MFR-RenameSubFoldersStringReplacerFactory 'MFR.RenameSubFoldersStringReplacerFactory')
class.

<a name='M-MFR-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue'></a>
### Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue() `method`

##### Summary

Asserts that the
[AndTextMatchingConfiguration](#M-MFR-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.IStringReplacerFactory.AndTextMatchingConfiguration')
method returns an instance of the correct concrete type that
corresponds to the particular
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value that
is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer'></a>
### Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer() `method`

##### Summary

Asserts that each object reference returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.IStringReplacerFactory.AndTextMatchingConfiguration')
method for the
[RenameSubFolders](#T-MFR-Operations-Constants-OperationType-RenameSubFolders 'MFR.Operations.Constants.OperationType.RenameSubFolders')
value implements the
[IStringReplacer](#T-MFR-IStringReplacer 'MFR.IStringReplacer')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_OperationType_Property_IsSetTo_RenameSubFolders'></a>
### Test_OperationType_Property_IsSetTo_RenameSubFolders() `method`

##### Summary

Asserts that the
[OperationType](#P-MFR-IFixedOperationTypeSpecificObject-OperationType 'MFR.IFixedOperationTypeSpecificObject.OperationType')
property of each of the objects returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.IStringReplacerFactory.AndTextMatchingConfiguration')
method for each
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value, and
for the
[RenameSubFolders](#T-MFR-Operations-Constants-OperationType-RenameSubFolders 'MFR.Operations.Constants.OperationType.RenameSubFolders')
value, is set to that value.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue'></a>
### Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue() `method`

##### Summary

Asserts that the
[TextMatchingConfiguration](#P-MFR-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
property of each of the concrete types returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.IStringReplacerFactory.AndTextMatchingConfiguration')
method has the same value as was supplied to the method.

##### Parameters

This method has no parameters.

<a name='T-MFR-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests'></a>
## ReplaceTextInFilesStringReplacerFactoryTests `type`

##### Namespace

MFR.Replacers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ReplaceTextInFilesStringReplacerFactory](#T-MFR-ReplaceTextInFilesStringReplacerFactory 'MFR.ReplaceTextInFilesStringReplacerFactory')
class.

<a name='M-MFR-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue'></a>
### Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue() `method`

##### Summary

Asserts that the
[AndTextMatchingConfiguration](#M-MFR-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.IStringReplacerFactory.AndTextMatchingConfiguration')
method returns an instance of the correct concrete type that
corresponds to the particular
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value that
is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer'></a>
### Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer() `method`

##### Summary

Asserts that each object reference returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.IStringReplacerFactory.AndTextMatchingConfiguration')
method for the
[ReplaceTextInFiles](#T-MFR-Operations-Constants-OperationType-ReplaceTextInFiles 'MFR.Operations.Constants.OperationType.ReplaceTextInFiles')
value implements the
[IStringReplacer](#T-MFR-IStringReplacer 'MFR.IStringReplacer')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_OperationType_Property_IsSetTo_ReplaceTextInFiles'></a>
### Test_OperationType_Property_IsSetTo_ReplaceTextInFiles() `method`

##### Summary

Asserts that the
[OperationType](#P-MFR-IFixedOperationTypeSpecificObject-OperationType 'MFR.IFixedOperationTypeSpecificObject.OperationType')
property of each of the objects returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.IStringReplacerFactory.AndTextMatchingConfiguration')
method for each
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value, and
for the
[ReplaceTextInFiles](#T-MFR-Operations-Constants-OperationType-ReplaceTextInFiles 'MFR.Operations.Constants.OperationType.ReplaceTextInFiles')
value, is set to that value.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue'></a>
### Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue() `method`

##### Summary

Asserts that the
[TextMatchingConfiguration](#P-MFR-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
property of each of the concrete types returned by the
[AndTextMatchingConfiguration](#M-MFR-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.IStringReplacerFactory.AndTextMatchingConfiguration')
method has the same value as was supplied to the method.

##### Parameters

This method has no parameters.

<a name='T-MFR-Replacers-Factories-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Replacers.Factories.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Replacers-Factories-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Replacers-Factories-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
