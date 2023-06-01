<a name='assembly'></a>
# MFR.Engines.Replacement.Tests

## Contents

- [FolderNameReplacementEngineTests](#T-MFR-Engines-Replacement-Tests-FolderNameReplacementEngineTests 'MFR.Engines.Replacement.Tests.FolderNameReplacementEngineTests')
  - [Initialize()](#M-MFR-Engines-Replacement-Tests-FolderNameReplacementEngineTests-Initialize 'MFR.Engines.Replacement.Tests.FolderNameReplacementEngineTests.Initialize')
  - [Test_FolderName_ReplacedCorrectly()](#M-MFR-Engines-Replacement-Tests-FolderNameReplacementEngineTests-Test_FolderName_ReplacedCorrectly 'MFR.Engines.Replacement.Tests.FolderNameReplacementEngineTests.Test_FolderName_ReplacedCorrectly')
- [Resources](#T-MFR-Engines-Replacement-Tests-Properties-Resources 'MFR.Engines.Replacement.Tests.Properties.Resources')
  - [Culture](#P-MFR-Engines-Replacement-Tests-Properties-Resources-Culture 'MFR.Engines.Replacement.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Replacement-Tests-Properties-Resources-ResourceManager 'MFR.Engines.Replacement.Tests.Properties.Resources.ResourceManager')
- [TextReplacementEngineTestBase](#T-MFR-Engines-Replacement-Tests-TextReplacementEngineTestBase 'MFR.Engines.Replacement.Tests.TextReplacementEngineTestBase')
  - [Configuration](#P-MFR-Engines-Replacement-Tests-TextReplacementEngineTestBase-Configuration 'MFR.Engines.Replacement.Tests.TextReplacementEngineTestBase.Configuration')
  - [Replacer](#P-MFR-Engines-Replacement-Tests-TextReplacementEngineTestBase-Replacer 'MFR.Engines.Replacement.Tests.TextReplacementEngineTestBase.Replacer')
  - [CreateReplacementEngineFor(type)](#M-MFR-Engines-Replacement-Tests-TextReplacementEngineTestBase-CreateReplacementEngineFor-MFR-Operations-Constants-OperationType- 'MFR.Engines.Replacement.Tests.TextReplacementEngineTestBase.CreateReplacementEngineFor(MFR.Operations.Constants.OperationType)')
  - [Initialize()](#M-MFR-Engines-Replacement-Tests-TextReplacementEngineTestBase-Initialize 'MFR.Engines.Replacement.Tests.TextReplacementEngineTestBase.Initialize')

<a name='T-MFR-Engines-Replacement-Tests-FolderNameReplacementEngineTests'></a>
## FolderNameReplacementEngineTests `type`

##### Namespace

MFR.Engines.Replacement.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[FolderNameReplacementEngine](#T-MFR-FolderNameReplacementEngine 'MFR.FolderNameReplacementEngine')
class.

<a name='M-MFR-Engines-Replacement-Tests-FolderNameReplacementEngineTests-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the state of this fixture for every unit test session.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Replacement-Tests-FolderNameReplacementEngineTests-Test_FolderName_ReplacedCorrectly'></a>
### Test_FolderName_ReplacedCorrectly() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-Replacement-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Replacement.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Replacement-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Replacement-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Engines-Replacement-Tests-TextReplacementEngineTestBase'></a>
## TextReplacementEngineTestBase `type`

##### Namespace

MFR.Engines.Replacement.Tests

##### Summary

Provides default implementations for unit tests and abstract methods for
mandatory implementation details.

<a name='P-MFR-Engines-Replacement-Tests-TextReplacementEngineTestBase-Configuration'></a>
### Configuration `property`

##### Summary

Reference to an instance of an object that implements the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface.

<a name='P-MFR-Engines-Replacement-Tests-TextReplacementEngineTestBase-Replacer'></a>
### Replacer `property`

##### Summary

Reference to an instance of an object that implements the
[ITextReplacementEngine](#T-MFR-ITextReplacementEngine 'MFR.ITextReplacementEngine')
interface.

<a name='M-MFR-Engines-Replacement-Tests-TextReplacementEngineTestBase-CreateReplacementEngineFor-MFR-Operations-Constants-OperationType-'></a>
### CreateReplacementEngineFor(type) `method`

##### Summary

Creates an instance of an object that implements the
[ITextReplacementEngine](#T-MFR-ITextReplacementEngine 'MFR.ITextReplacementEngine')
interface for the
specified operation `type`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | One of the [OperationType](#T-MFR-OperationType 'MFR.OperationType') values that
specifies which operation to create a data-matcher object for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the `type` parameter is not set to a
value that the factory supports. |

<a name='M-MFR-Engines-Replacement-Tests-TextReplacementEngineTestBase-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the state of this fixture for every unit test session.

##### Parameters

This method has no parameters.
