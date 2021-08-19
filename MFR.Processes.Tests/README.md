<a name='assembly'></a>
# MFR.Objects.Processes.Tests

## Contents

- [ProcessIdProviderTests](#T-MFR-Objects-Processes-Tests-ProcessIdProviderTests 'MFR.Objects.Processes.Tests.ProcessIdProviderTests')
  - [_processIdProvider](#F-MFR-Objects-Processes-Tests-ProcessIdProviderTests-_processIdProvider 'MFR.Objects.Processes.Tests.ProcessIdProviderTests._processIdProvider')
  - [EmptyIntegerCollection](#P-MFR-Objects-Processes-Tests-ProcessIdProviderTests-EmptyIntegerCollection 'MFR.Objects.Processes.Tests.ProcessIdProviderTests.EmptyIntegerCollection')
  - [Initialize()](#M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Initialize 'MFR.Objects.Processes.Tests.ProcessIdProviderTests.Initialize')
  - [Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsBlank()](#M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsBlank 'MFR.Objects.Processes.Tests.ProcessIdProviderTests.Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsBlank')
  - [Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsGibberish()](#M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsGibberish 'MFR.Objects.Processes.Tests.ProcessIdProviderTests.Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsGibberish')
  - [Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsNull()](#M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsNull 'MFR.Objects.Processes.Tests.ProcessIdProviderTests.Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsNull')
  - [Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsWhitespace()](#M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsWhitespace 'MFR.Objects.Processes.Tests.ProcessIdProviderTests.Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsWhitespace')
  - [Test_GetAllProcessIDsOf_ReturnsNonEmptySet_WhenInputIsDevEnvFilename()](#M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetAllProcessIDsOf_ReturnsNonEmptySet_WhenInputIsDevEnvFilename 'MFR.Objects.Processes.Tests.ProcessIdProviderTests.Test_GetAllProcessIDsOf_ReturnsNonEmptySet_WhenInputIsDevEnvFilename')
  - [Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsBlank()](#M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsBlank 'MFR.Objects.Processes.Tests.ProcessIdProviderTests.Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsBlank')
  - [Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsGibberish()](#M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsGibberish 'MFR.Objects.Processes.Tests.ProcessIdProviderTests.Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsGibberish')
  - [Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsNull()](#M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsNull 'MFR.Objects.Processes.Tests.ProcessIdProviderTests.Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsNull')
  - [Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsWhiteSpace()](#M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsWhiteSpace 'MFR.Objects.Processes.Tests.ProcessIdProviderTests.Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsWhiteSpace')
  - [Test_GetProcessIDOf_ReturnsPositiveInteger_WhenInputIsDevEnvFilename()](#M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetProcessIDOf_ReturnsPositiveInteger_WhenInputIsDevEnvFilename 'MFR.Objects.Processes.Tests.ProcessIdProviderTests.Test_GetProcessIDOf_ReturnsPositiveInteger_WhenInputIsDevEnvFilename')
- [Resources](#T-MFR-Objects-Processes-Tests-Properties-Resources 'MFR.Objects.Processes.Tests.Properties.Resources')
  - [Culture](#P-MFR-Objects-Processes-Tests-Properties-Resources-Culture 'MFR.Objects.Processes.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Processes-Tests-Properties-Resources-ResourceManager 'MFR.Objects.Processes.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Processes-Tests-ProcessIdProviderTests'></a>
## ProcessIdProviderTests `type`

##### Namespace

MFR.Objects.Processes.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ProcessIdProvider](#T-MFR-Objects-ProcessIdProvider 'MFR.Objects.ProcessIdProvider')
class.

<a name='F-MFR-Objects-Processes-Tests-ProcessIdProviderTests-_processIdProvider'></a>
### _processIdProvider `constants`

##### Summary

Reference to an instance of an object that implements the
[IProcessIdProvider](#T-MFR-Objects-IProcessIdProvider 'MFR.Objects.IProcessIdProvider')
interface.

<a name='P-MFR-Objects-Processes-Tests-ProcessIdProviderTests-EmptyIntegerCollection'></a>
### EmptyIntegerCollection `property`

##### Summary

Gets a reference to the empty enumerable of integers.

<a name='M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the state of this fixture for every unit test session.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsBlank'></a>
### Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsBlank() `method`

##### Summary

Asserts that the
[GetAllProcessIDsOf](#M-MFR-Objects-IProcessIdProvider-GetAllProcessIDsOf 'MFR.Objects.IProcessIdProvider.GetAllProcessIDsOf')
method returns the empty collection when it is passed the empty
string as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsGibberish'></a>
### Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsGibberish() `method`

##### Summary

Asserts that the
[GetAllProcessIDsOf](#M-MFR-Objects-IProcessIdProvider-GetAllProcessIDsOf 'MFR.Objects.IProcessIdProvider.GetAllProcessIDsOf')
method returns the empty collection when it is passed gibberish as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsNull'></a>
### Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsNull() `method`

##### Summary

Asserts that the
[GetAllProcessIDsOf](#M-MFR-Objects-IProcessIdProvider-GetAllProcessIDsOf 'MFR.Objects.IProcessIdProvider.GetAllProcessIDsOf')
method returns the empty collection when it is passed the
`null` string as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsWhitespace'></a>
### Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsWhitespace() `method`

##### Summary

Asserts that the
[GetAllProcessIDsOf](#M-MFR-Objects-IProcessIdProvider-GetAllProcessIDsOf 'MFR.Objects.IProcessIdProvider.GetAllProcessIDsOf')
method returns the empty collection when it is passed whitespace as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetAllProcessIDsOf_ReturnsNonEmptySet_WhenInputIsDevEnvFilename'></a>
### Test_GetAllProcessIDsOf_ReturnsNonEmptySet_WhenInputIsDevEnvFilename() `method`

##### Summary

Asserts that the
[GetAllProcessIDsOf](#M-MFR-Objects-IProcessIdProvider-GetAllProcessIDsOf 'MFR.Objects.IProcessIdProvider.GetAllProcessIDsOf')
method returns nonzero items when passed the filename of
`devenv.exe` as input.

##### Parameters

This method has no parameters.

##### Remarks

This test makes the assumption that a test runner is being utilized
that interfaces with Visual Studio; therefore, we are guaranteed
that at least one instance of `devenv.exe` must be running.

<a name='M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsBlank'></a>
### Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsBlank() `method`

##### Summary

Asserts that the
[GetProcessIDOf](#M-MFR-Objects-IProcessIdProvider-GetProcessIDOf 'MFR.Objects.IProcessIdProvider.GetProcessIDOf')
method returns `-1` for the process ID when passed the empty
string as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsGibberish'></a>
### Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsGibberish() `method`

##### Summary

Asserts that the
[GetProcessIDOf](#M-MFR-Objects-IProcessIdProvider-GetProcessIDOf 'MFR.Objects.IProcessIdProvider.GetProcessIDOf')
method returns `-1` for the process ID when passed gibberish
for input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsNull'></a>
### Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsNull() `method`

##### Summary

Asserts that the
[GetProcessIDOf](#M-MFR-Objects-IProcessIdProvider-GetProcessIDOf 'MFR.Objects.IProcessIdProvider.GetProcessIDOf')
method returns `-1` for the process ID when passed the
`null` string as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsWhiteSpace'></a>
### Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsWhiteSpace() `method`

##### Summary

Asserts that the
[GetProcessIDOf](#M-MFR-Objects-IProcessIdProvider-GetProcessIDOf 'MFR.Objects.IProcessIdProvider.GetProcessIDOf')
method returns `-1` for the process ID when passed the empty
string as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Processes-Tests-ProcessIdProviderTests-Test_GetProcessIDOf_ReturnsPositiveInteger_WhenInputIsDevEnvFilename'></a>
### Test_GetProcessIDOf_ReturnsPositiveInteger_WhenInputIsDevEnvFilename() `method`

##### Summary

Asserts the
[GetProcessIDOf](#M-MFR-Objects-IProcessIdProvider-GetProcessIDOf 'MFR.Objects.IProcessIdProvider.GetProcessIDOf') method
always returns a positive integer for the process ID when searching
on `devenv.exe`.

##### Parameters

This method has no parameters.

##### Remarks

We assume that, if this unit test is being run, then it is most
likely being run by a test runner launched by an instance of Visual
Studio; therefore, Visual Studio must have at least one instance open.

<a name='T-MFR-Objects-Processes-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Processes.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Processes-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Processes-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
