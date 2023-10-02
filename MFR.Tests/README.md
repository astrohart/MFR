<a name='assembly'></a>
# MFR.Tests

## Contents

- [DebuggableTestFixture](#T-MFR-Tests-DebuggableTestFixture 'MFR.Tests.DebuggableTestFixture')
  - [Initialize()](#M-MFR-Tests-DebuggableTestFixture-Initialize 'MFR.Tests.DebuggableTestFixture.Initialize')
- [Resources](#T-MFR-Tests-Properties-Resources 'MFR.Tests.Properties.Resources')
  - [Culture](#P-MFR-Tests-Properties-Resources-Culture 'MFR.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Tests-Properties-Resources-ResourceManager 'MFR.Tests.Properties.Resources.ResourceManager')
  - [SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER](#P-MFR-Tests-Properties-Resources-SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER 'MFR.Tests.Properties.Resources.SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER')
- [StringExtensionsTests](#T-MFR-Tests-StringExtensionsTests 'MFR.Tests.StringExtensionsTests')
  - [Test_IsAbsolutePath_ReturnsFalse_ForFileNameOnly()](#M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_ForFileNameOnly 'MFR.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsFalse_ForFileNameOnly')
  - [Test_IsAbsolutePath_ReturnsFalse_ForFileNameWithoutExtension()](#M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_ForFileNameWithoutExtension 'MFR.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsFalse_ForFileNameWithoutExtension')
  - [Test_IsAbsolutePath_ReturnsFalse_WhenPassedBlankInput()](#M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassedBlankInput 'MFR.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsFalse_WhenPassedBlankInput')
  - [Test_IsAbsolutePath_ReturnsFalse_WhenPassedNullInput()](#M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassedNullInput 'MFR.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsFalse_WhenPassedNullInput')
  - [Test_IsAbsolutePath_ReturnsFalse_WhenPassedWhitespace()](#M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassedWhitespace 'MFR.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsFalse_WhenPassedWhitespace')
  - [Test_IsAbsolutePath_ReturnsFalse_WhenPassed_RelativePathName()](#M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassed_RelativePathName 'MFR.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsFalse_WhenPassed_RelativePathName')
  - [Test_IsAbsolutePath_ReturnsTrue_ForAbsolutePath_EvenIfTheFileNotExists()](#M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsTrue_ForAbsolutePath_EvenIfTheFileNotExists 'MFR.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsTrue_ForAbsolutePath_EvenIfTheFileNotExists')
  - [Test_IsAbsolutePath_ReturnsTrue_ForFullPathnameOfFileGauranteedToExist()](#M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsTrue_ForFullPathnameOfFileGauranteedToExist 'MFR.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsTrue_ForFullPathnameOfFileGauranteedToExist')
  - [Test_IsFolderPath_ReturnsFalse_ForBlankInput()](#M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForBlankInput 'MFR.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForBlankInput')
  - [Test_IsFolderPath_ReturnsFalse_ForFileThatDoesNotExist()](#M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFileThatDoesNotExist 'MFR.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForFileThatDoesNotExist')
  - [Test_IsFolderPath_ReturnsFalse_ForFileThatExists()](#M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFileThatExists 'MFR.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForFileThatExists')
  - [Test_IsFolderPath_ReturnsFalse_ForFilenameOnly()](#M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFilenameOnly 'MFR.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForFilenameOnly')
  - [Test_IsFolderPath_ReturnsFalse_ForFilenameWithNoExtension()](#M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFilenameWithNoExtension 'MFR.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForFilenameWithNoExtension')
  - [Test_IsFolderPath_ReturnsFalse_ForFolderThatDoesNotExist()](#M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFolderThatDoesNotExist 'MFR.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForFolderThatDoesNotExist')
  - [Test_IsFolderPath_ReturnsFalse_ForNullInput()](#M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForNullInput 'MFR.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForNullInput')
  - [Test_IsFolderPath_ReturnsFalse_ForWhitespaceInput()](#M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForWhitespaceInput 'MFR.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForWhitespaceInput')
  - [Test_IsFolderPath_ReturnsTrue_ForFolderThatExists()](#M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsTrue_ForFolderThatExists 'MFR.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsTrue_ForFolderThatExists')
- [TestFixtureExtensions](#T-MFR-Tests-TestFixtureExtensions 'MFR.Tests.TestFixtureExtensions')
  - [DumpStringsToConsole(fixture,list)](#M-MFR-Tests-TestFixtureExtensions-DumpStringsToConsole-System-Object,System-Collections-Generic-IEnumerable{System-String}- 'MFR.Tests.TestFixtureExtensions.DumpStringsToConsole(System.Object,System.Collections.Generic.IEnumerable{System.String})')

<a name='T-MFR-Tests-DebuggableTestFixture'></a>
## DebuggableTestFixture `type`

##### Namespace

MFR.Tests

##### Summary

Base class for a test fixture that can use the standard
[DebugUtils](#T-xyLOGIX-Core-Debug-DebugUtils 'xyLOGIX.Core.Debug.DebugUtils')-based infrastructure to write
messages to the console.

<a name='M-MFR-Tests-DebuggableTestFixture-Initialize'></a>
### Initialize() `method`

##### Summary

Method that sets up the logging infrastructure for use with a child test
fixture.



Child classes may override this method to run additional
set-up logic.

##### Parameters

This method has no parameters.

<a name='T-MFR-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-MFR-Tests-Properties-Resources-SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER'></a>
### SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER `property`

##### Summary

Looks up a localized string similar to C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\packages\EntityFramework.6.4.4.

<a name='T-MFR-Tests-StringExtensionsTests'></a>
## StringExtensionsTests `type`

##### Namespace

MFR.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[StringExtensions](#T-xyLOGIX-Core-Extensions-StringExtensions 'xyLOGIX.Core.Extensions.StringExtensions')
class.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_ForFileNameOnly'></a>
### Test_IsAbsolutePath_ReturnsFalse_ForFileNameOnly() `method`

##### Summary

Asserts the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `false` for the case where it is only
passed a filename (such as NOTEPAD.EXE) and not a complete, absolute pathname.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_ForFileNameWithoutExtension'></a>
### Test_IsAbsolutePath_ReturnsFalse_ForFileNameWithoutExtension() `method`

##### Summary

Asserts the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `false` for the case where it is only
passed a filename (such as
LICENSE) that does not have a file extension, and not a complete,
absolute pathname.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassedBlankInput'></a>
### Test_IsAbsolutePath_ReturnsFalse_WhenPassedBlankInput() `method`

##### Summary

Asserts that the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `false` when it is passed a blank value.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassedNullInput'></a>
### Test_IsAbsolutePath_ReturnsFalse_WhenPassedNullInput() `method`

##### Summary

Asserts that the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `false` when passed
`null`
as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassedWhitespace'></a>
### Test_IsAbsolutePath_ReturnsFalse_WhenPassedWhitespace() `method`

##### Summary

Asserts that the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `false` when passed whitespace for input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassed_RelativePathName'></a>
### Test_IsAbsolutePath_ReturnsFalse_WhenPassed_RelativePathName() `method`

##### Summary

Asserts that the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `false` in the event that the
relative pathname, e.g., .\NOTEPAD.EXE, is passed.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsTrue_ForAbsolutePath_EvenIfTheFileNotExists'></a>
### Test_IsAbsolutePath_ReturnsTrue_ForAbsolutePath_EvenIfTheFileNotExists() `method`

##### Summary

Asserts that the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `true` when passed a fully-qualified
pathname of a file, even if the file does not exist.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsTrue_ForFullPathnameOfFileGauranteedToExist'></a>
### Test_IsAbsolutePath_ReturnsTrue_ForFullPathnameOfFileGauranteedToExist() `method`

##### Summary

Asserts that the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `true` when it is passed a
fully-qualified pathname of a file that is guaranteed to exist.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForBlankInput'></a>
### Test_IsFolderPath_ReturnsFalse_ForBlankInput() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` when supplied with the empty
string as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFileThatDoesNotExist'></a>
### Test_IsFolderPath_ReturnsFalse_ForFileThatDoesNotExist() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` when passed the pathname of a
file that is known not to exist.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFileThatExists'></a>
### Test_IsFolderPath_ReturnsFalse_ForFileThatExists() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` for the event in which it is
passed the fully-qualified pathname of a file that is known to exist.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFilenameOnly'></a>
### Test_IsFolderPath_ReturnsFalse_ForFilenameOnly() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` when provided only the name
and extension of a file that is otherwise known to exist.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFilenameWithNoExtension'></a>
### Test_IsFolderPath_ReturnsFalse_ForFilenameWithNoExtension() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` when provided the name of a
file that exists, but without the extension.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFolderThatDoesNotExist'></a>
### Test_IsFolderPath_ReturnsFalse_ForFolderThatDoesNotExist() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` when passed the
fully-qualified pathname of a folder that is known not to exist.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForNullInput'></a>
### Test_IsFolderPath_ReturnsFalse_ForNullInput() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` when supplied with the
`null`
string as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForWhitespaceInput'></a>
### Test_IsFolderPath_ReturnsFalse_ForWhitespaceInput() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` when supplied with whitespace
as an input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsTrue_ForFolderThatExists'></a>
### Test_IsFolderPath_ReturnsTrue_ForFolderThatExists() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `true` when passed the
fully-qualified pathname of a folder that is known to exist.

##### Parameters

This method has no parameters.

<a name='T-MFR-Tests-TestFixtureExtensions'></a>
## TestFixtureExtensions `type`

##### Namespace

MFR.Tests

##### Summary

Exposes static methods to extend the functionality of test fixtures.

<a name='M-MFR-Tests-TestFixtureExtensions-DumpStringsToConsole-System-Object,System-Collections-Generic-IEnumerable{System-String}-'></a>
### DumpStringsToConsole(fixture,list) `method`

##### Summary

Dumps a collection of strings to the console, one element per line.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fixture | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to an object that is the test
fixture being used. |
| list | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | (Required.) Reference to an enumerable collection of
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that represents the list to be dumped. |

##### Remarks

If the `list` parameter is `null` or
contains zero elements, then the method does nothing but print an error
message.



Otherwise, the list is written to [Out](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Console.Out 'System.Console.Out'), one
element per line.
