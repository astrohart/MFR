<a name='assembly'></a>
# MFR.Objects.Replacers.Factories.Tests

## Contents

- [GetStringReplacerTests](#T-MFR-Objects-Replacers-Factories-Tests-GetStringReplacerTests 'MFR.Objects.Replacers.Factories.Tests.GetStringReplacerTests')
  - [Test_For_Returns_ImplementerOf_IStringReplacerFactory_When_RenameFilesInFolder_IsOperationType()](#M-MFR-Objects-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_ImplementerOf_IStringReplacerFactory_When_RenameFilesInFolder_IsOperationType 'MFR.Objects.Replacers.Factories.Tests.GetStringReplacerTests.Test_For_Returns_ImplementerOf_IStringReplacerFactory_When_RenameFilesInFolder_IsOperationType')
  - [Test_For_Returns_RenameFilesInFolderStringReplacerFactory_When_RenameFilesInFolder_IsOperationType()](#M-MFR-Objects-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_RenameFilesInFolderStringReplacerFactory_When_RenameFilesInFolder_IsOperationType 'MFR.Objects.Replacers.Factories.Tests.GetStringReplacerTests.Test_For_Returns_RenameFilesInFolderStringReplacerFactory_When_RenameFilesInFolder_IsOperationType')
  - [Test_For_Returns_RenameSubFoldersStringReplacerFactory_When_RenameSubFolders_IsOperationType()](#M-MFR-Objects-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_RenameSubFoldersStringReplacerFactory_When_RenameSubFolders_IsOperationType 'MFR.Objects.Replacers.Factories.Tests.GetStringReplacerTests.Test_For_Returns_RenameSubFoldersStringReplacerFactory_When_RenameSubFolders_IsOperationType')
  - [Test_For_Returns_ReplaceTextInFilesStringReplacerFactory_When_ReplaceTextInFiles_IsOperationType()](#M-MFR-Objects-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_ReplaceTextInFilesStringReplacerFactory_When_ReplaceTextInFiles_IsOperationType 'MFR.Objects.Replacers.Factories.Tests.GetStringReplacerTests.Test_For_Returns_ReplaceTextInFilesStringReplacerFactory_When_ReplaceTextInFiles_IsOperationType')
- [RenameFilesInFolderStringReplacerFactoryTests](#T-MFR-Objects-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests 'MFR.Objects.Replacers.Factories.Tests.RenameFilesInFolderStringReplacerFactoryTests')
  - [Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue()](#M-MFR-Objects-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue 'MFR.Objects.Replacers.Factories.Tests.RenameFilesInFolderStringReplacerFactoryTests.Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue')
  - [Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer()](#M-MFR-Objects-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer 'MFR.Objects.Replacers.Factories.Tests.RenameFilesInFolderStringReplacerFactoryTests.Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer')
  - [Test_OperationType_Property_IsSetTo_RenameFilesInFolder()](#M-MFR-Objects-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_OperationType_Property_IsSetTo_RenameFilesInFolder 'MFR.Objects.Replacers.Factories.Tests.RenameFilesInFolderStringReplacerFactoryTests.Test_OperationType_Property_IsSetTo_RenameFilesInFolder')
  - [Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue()](#M-MFR-Objects-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue 'MFR.Objects.Replacers.Factories.Tests.RenameFilesInFolderStringReplacerFactoryTests.Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue')
- [RenameSubFoldersStringReplacerFactoryTests](#T-MFR-Objects-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests 'MFR.Objects.Replacers.Factories.Tests.RenameSubFoldersStringReplacerFactoryTests')
  - [Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue()](#M-MFR-Objects-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue 'MFR.Objects.Replacers.Factories.Tests.RenameSubFoldersStringReplacerFactoryTests.Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue')
  - [Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer()](#M-MFR-Objects-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer 'MFR.Objects.Replacers.Factories.Tests.RenameSubFoldersStringReplacerFactoryTests.Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer')
  - [Test_OperationType_Property_IsSetTo_RenameSubFolders()](#M-MFR-Objects-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_OperationType_Property_IsSetTo_RenameSubFolders 'MFR.Objects.Replacers.Factories.Tests.RenameSubFoldersStringReplacerFactoryTests.Test_OperationType_Property_IsSetTo_RenameSubFolders')
  - [Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue()](#M-MFR-Objects-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue 'MFR.Objects.Replacers.Factories.Tests.RenameSubFoldersStringReplacerFactoryTests.Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue')
- [ReplaceTextInFilesStringReplacerFactoryTests](#T-MFR-Objects-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests 'MFR.Objects.Replacers.Factories.Tests.ReplaceTextInFilesStringReplacerFactoryTests')
  - [Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue()](#M-MFR-Objects-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue 'MFR.Objects.Replacers.Factories.Tests.ReplaceTextInFilesStringReplacerFactoryTests.Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue')
  - [Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer()](#M-MFR-Objects-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer 'MFR.Objects.Replacers.Factories.Tests.ReplaceTextInFilesStringReplacerFactoryTests.Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer')
  - [Test_OperationType_Property_IsSetTo_ReplaceTextInFiles()](#M-MFR-Objects-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_OperationType_Property_IsSetTo_ReplaceTextInFiles 'MFR.Objects.Replacers.Factories.Tests.ReplaceTextInFilesStringReplacerFactoryTests.Test_OperationType_Property_IsSetTo_ReplaceTextInFiles')
  - [Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue()](#M-MFR-Objects-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue 'MFR.Objects.Replacers.Factories.Tests.ReplaceTextInFilesStringReplacerFactoryTests.Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue')
- [Resources](#T-MFR-Objects-Replacers-Factories-Tests-Properties-Resources 'MFR.Objects.Replacers.Factories.Tests.Properties.Resources')
  - [Culture](#P-MFR-Objects-Replacers-Factories-Tests-Properties-Resources-Culture 'MFR.Objects.Replacers.Factories.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Replacers-Factories-Tests-Properties-Resources-ResourceManager 'MFR.Objects.Replacers.Factories.Tests.Properties.Resources.ResourceManager')
- [SaveConfigurationToFileCommandTests](#T-MFR-Objects-Replacers-Factories-Tests-SaveConfigurationToFileCommandTests 'MFR.Objects.Replacers.Factories.Tests.SaveConfigurationToFileCommandTests')
  - [FILE_PATH](#F-MFR-Objects-Replacers-Factories-Tests-SaveConfigurationToFileCommandTests-FILE_PATH 'MFR.Objects.Replacers.Factories.Tests.SaveConfigurationToFileCommandTests.FILE_PATH')
  - [CONFIGURATION_DATA](#P-MFR-Objects-Replacers-Factories-Tests-SaveConfigurationToFileCommandTests-CONFIGURATION_DATA 'MFR.Objects.Replacers.Factories.Tests.SaveConfigurationToFileCommandTests.CONFIGURATION_DATA')
  - [Test_SaveConfigurationToFile_Works_ForvalidInputs()](#M-MFR-Objects-Replacers-Factories-Tests-SaveConfigurationToFileCommandTests-Test_SaveConfigurationToFile_Works_ForvalidInputs 'MFR.Objects.Replacers.Factories.Tests.SaveConfigurationToFileCommandTests.Test_SaveConfigurationToFile_Works_ForvalidInputs')
- [SaveStringToRegistryCommandTests](#T-MFR-Objects-Replacers-Factories-Tests-SaveStringToRegistryCommandTests 'MFR.Objects.Replacers.Factories.Tests.SaveStringToRegistryCommandTests')
  - [Test_CanSuccessfullySave_AppConfigFilePath_ToRegistry()](#M-MFR-Objects-Replacers-Factories-Tests-SaveStringToRegistryCommandTests-Test_CanSuccessfullySave_AppConfigFilePath_ToRegistry 'MFR.Objects.Replacers.Factories.Tests.SaveStringToRegistryCommandTests.Test_CanSuccessfullySave_AppConfigFilePath_ToRegistry')

<a name='T-MFR-Objects-Replacers-Factories-Tests-GetStringReplacerTests'></a>
## GetStringReplacerTests `type`

##### Namespace

MFR.Objects.Replacers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[GetStringReplacer](#T-MFR-Objects-GetStringReplacer 'MFR.Objects.GetStringReplacer')
class.

<a name='M-MFR-Objects-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_ImplementerOf_IStringReplacerFactory_When_RenameFilesInFolder_IsOperationType'></a>
### Test_For_Returns_ImplementerOf_IStringReplacerFactory_When_RenameFilesInFolder_IsOperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-Objects-GetStringReplacer-For 'MFR.Objects.GetStringReplacer.For')
method
returns a reference to an instance of an object that implements the
[IStringReplacerFactory](#T-MFR-Objects-IStringReplacerFactory 'MFR.Objects.IStringReplacerFactory')
interface when the
[RenameFilesInFolder](#T-MFR-Objects-OperationType-RenameFilesInFolder 'MFR.Objects.OperationType.RenameFilesInFolder')
value is passed for its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_RenameFilesInFolderStringReplacerFactory_When_RenameFilesInFolder_IsOperationType'></a>
### Test_For_Returns_RenameFilesInFolderStringReplacerFactory_When_RenameFilesInFolder_IsOperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-Objects-GetStringReplacer-For 'MFR.Objects.GetStringReplacer.For')
method
returns a reference to an instance of
[RenameFilesInFolderStringReplacerFactory](#T-MFR-Objects-RenameFilesInFolderStringReplacerFactory 'MFR.Objects.RenameFilesInFolderStringReplacerFactory')
when the
[RenameFilesInFolder](#T-MFR-Objects-OperationType-RenameFilesInFolder 'MFR.Objects.OperationType.RenameFilesInFolder')
enumeration value is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_RenameSubFoldersStringReplacerFactory_When_RenameSubFolders_IsOperationType'></a>
### Test_For_Returns_RenameSubFoldersStringReplacerFactory_When_RenameSubFolders_IsOperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-Objects-GetStringReplacer-For 'MFR.Objects.GetStringReplacer.For')
method
returns a reference to an instance of
[RenameSubFoldersStringReplacerFactory](#T-MFR-Objects-RenameSubFoldersStringReplacerFactory 'MFR.Objects.RenameSubFoldersStringReplacerFactory')
when the
[RenameSubFolders](#T-MFR-Objects-OperationType-RenameSubFolders 'MFR.Objects.OperationType.RenameSubFolders')
enumeration value is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-Tests-GetStringReplacerTests-Test_For_Returns_ReplaceTextInFilesStringReplacerFactory_When_ReplaceTextInFiles_IsOperationType'></a>
### Test_For_Returns_ReplaceTextInFilesStringReplacerFactory_When_ReplaceTextInFiles_IsOperationType() `method`

##### Summary

Asserts that the
[For](#M-MFR-Objects-GetStringReplacer-For 'MFR.Objects.GetStringReplacer.For')
method
returns a reference to an instance of
[ReplaceTextInFilesStringReplacerFactory](#T-MFR-Objects-ReplaceTextInFilesStringReplacerFactory 'MFR.Objects.ReplaceTextInFilesStringReplacerFactory')
when the
[ReplaceTextInFiles](#T-MFR-Objects-OperationType-ReplaceTextInFiles 'MFR.Objects.OperationType.ReplaceTextInFiles')
enumeration value is passed as its argument.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests'></a>
## RenameFilesInFolderStringReplacerFactoryTests `type`

##### Namespace

MFR.Objects.Replacers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[RenameFilesInFolderStringReplacerFactory](#T-MFR-Objects-RenameFilesInFolderStringReplacerFactory 'MFR.Objects.RenameFilesInFolderStringReplacerFactory')
class.

<a name='M-MFR-Objects-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue'></a>
### Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue() `method`

##### Summary

Asserts that the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration')
method returns an instance of the correct concrete type that
corresponds to the particular
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value that
is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer'></a>
### Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer() `method`

##### Summary

Asserts that each object reference returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration')
method for the
[RenameFilesInFolder](#T-MFR-Objects-OperationType-RenameFilesInFolder 'MFR.Objects.OperationType.RenameFilesInFolder')
value implements the
[IStringReplacer](#T-MFR-Objects-IStringReplacer 'MFR.Objects.IStringReplacer')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_OperationType_Property_IsSetTo_RenameFilesInFolder'></a>
### Test_OperationType_Property_IsSetTo_RenameFilesInFolder() `method`

##### Summary

Asserts that the
[OperationType](#P-MFR-Objects-IFixedOperationTypeSpecificObject-OperationType 'MFR.Objects.IFixedOperationTypeSpecificObject.OperationType')
property of each of the objects returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration')
method for each
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value, and
for the
[RenameFilesInFolder](#T-MFR-Objects-OperationType-RenameFilesInFolder 'MFR.Objects.OperationType.RenameFilesInFolder')
value, is set to that value.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-Tests-RenameFilesInFolderStringReplacerFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue'></a>
### Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue() `method`

##### Summary

Asserts that the
[TextMatchingConfiguration](#P-MFR-Objects-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.Objects.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
property of each of the concrete types returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration')
method has the same value as was supplied to the method.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests'></a>
## RenameSubFoldersStringReplacerFactoryTests `type`

##### Namespace

MFR.Objects.Replacers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[RenameSubFoldersStringReplacerFactory](#T-MFR-Objects-RenameSubFoldersStringReplacerFactory 'MFR.Objects.RenameSubFoldersStringReplacerFactory')
class.

<a name='M-MFR-Objects-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue'></a>
### Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue() `method`

##### Summary

Asserts that the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration')
method returns an instance of the correct concrete type that
corresponds to the particular
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value that
is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer'></a>
### Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer() `method`

##### Summary

Asserts that each object reference returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration')
method for the
[RenameSubFolders](#T-MFR-Objects-OperationType-RenameSubFolders 'MFR.Objects.OperationType.RenameSubFolders')
value implements the
[IStringReplacer](#T-MFR-Objects-IStringReplacer 'MFR.Objects.IStringReplacer')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_OperationType_Property_IsSetTo_RenameSubFolders'></a>
### Test_OperationType_Property_IsSetTo_RenameSubFolders() `method`

##### Summary

Asserts that the
[OperationType](#P-MFR-Objects-IFixedOperationTypeSpecificObject-OperationType 'MFR.Objects.IFixedOperationTypeSpecificObject.OperationType')
property of each of the objects returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration')
method for each
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value, and
for the
[RenameSubFolders](#T-MFR-Objects-OperationType-RenameSubFolders 'MFR.Objects.OperationType.RenameSubFolders')
value, is set to that value.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-Tests-RenameSubFoldersStringReplacerFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue'></a>
### Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue() `method`

##### Summary

Asserts that the
[TextMatchingConfiguration](#P-MFR-Objects-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.Objects.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
property of each of the concrete types returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration')
method has the same value as was supplied to the method.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests'></a>
## ReplaceTextInFilesStringReplacerFactoryTests `type`

##### Namespace

MFR.Objects.Replacers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ReplaceTextInFilesStringReplacerFactory](#T-MFR-Objects-ReplaceTextInFilesStringReplacerFactory 'MFR.Objects.ReplaceTextInFilesStringReplacerFactory')
class.

<a name='M-MFR-Objects-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue'></a>
### Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue() `method`

##### Summary

Asserts that the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration')
method returns an instance of the correct concrete type that
corresponds to the particular
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value that
is passed as its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer'></a>
### Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer() `method`

##### Summary

Asserts that each object reference returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration')
method for the
[ReplaceTextInFiles](#T-MFR-Objects-OperationType-ReplaceTextInFiles 'MFR.Objects.OperationType.ReplaceTextInFiles')
value implements the
[IStringReplacer](#T-MFR-Objects-IStringReplacer 'MFR.Objects.IStringReplacer')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_OperationType_Property_IsSetTo_ReplaceTextInFiles'></a>
### Test_OperationType_Property_IsSetTo_ReplaceTextInFiles() `method`

##### Summary

Asserts that the
[OperationType](#P-MFR-Objects-IFixedOperationTypeSpecificObject-OperationType 'MFR.Objects.IFixedOperationTypeSpecificObject.OperationType')
property of each of the objects returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration')
method for each
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value, and
for the
[ReplaceTextInFiles](#T-MFR-Objects-OperationType-ReplaceTextInFiles 'MFR.Objects.OperationType.ReplaceTextInFiles')
value, is set to that value.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-Tests-ReplaceTextInFilesStringReplacerFactoryTests-Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue'></a>
### Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue() `method`

##### Summary

Asserts that the
[TextMatchingConfiguration](#P-MFR-Objects-IFixedTextMatchingConfigurationSpecificObject-TextMatchingConfiguration 'MFR.Objects.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration')
property of each of the concrete types returned by the
[AndTextMatchingConfiguration](#M-MFR-Objects-IStringReplacerFactory-AndTextMatchingConfiguration 'MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration')
method has the same value as was supplied to the method.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Replacers-Factories-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Replacers.Factories.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Replacers-Factories-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Replacers-Factories-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-Replacers-Factories-Tests-SaveConfigurationToFileCommandTests'></a>
## SaveConfigurationToFileCommandTests `type`

##### Namespace

MFR.Objects.Replacers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[SaveConfigurationToFileCommand](#T-MFR-Objects-SaveConfigurationToFileCommand 'MFR.Objects.SaveConfigurationToFileCommand')
class.

##### Remarks

This class enables callers to provide a filename and a configuration
object reference, bundled together inside a File System Entry POCO, and
it is serialized to disk.

<a name='F-MFR-Objects-Replacers-Factories-Tests-SaveConfigurationToFileCommandTests-FILE_PATH'></a>
### FILE_PATH `constants`

##### Summary

File in the root of the C: drive where the data is to be saved.

<a name='P-MFR-Objects-Replacers-Factories-Tests-SaveConfigurationToFileCommandTests-CONFIGURATION_DATA'></a>
### CONFIGURATION_DATA `property`

##### Summary

Empty configuration object for testing.

<a name='M-MFR-Objects-Replacers-Factories-Tests-SaveConfigurationToFileCommandTests-Test_SaveConfigurationToFile_Works_ForvalidInputs'></a>
### Test_SaveConfigurationToFile_Works_ForvalidInputs() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Replacers-Factories-Tests-SaveStringToRegistryCommandTests'></a>
## SaveStringToRegistryCommandTests `type`

##### Namespace

MFR.Objects.Replacers.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[SaveStringToRegistryCommand](#T-MFR-Objects-SaveStringToRegistryCommand 'MFR.Objects.SaveStringToRegistryCommand')
class.

<a name='M-MFR-Objects-Replacers-Factories-Tests-SaveStringToRegistryCommandTests-Test_CanSuccessfullySave_AppConfigFilePath_ToRegistry'></a>
### Test_CanSuccessfullySave_AppConfigFilePath_ToRegistry() `method`

##### Summary

Asserts that the
[Execute](#M-MFR-Objects-LoadStringFromRegistryAction-Execute 'MFR.Objects.LoadStringFromRegistryAction.Execute')
method correctly loads a path from the system Registry.

##### Parameters

This method has no parameters.