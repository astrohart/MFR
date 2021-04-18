<a name='assembly'></a>
# MFR.Objects.Tests

## Contents

- [Resources](#T-MFR-Objects-Tests-Properties-Resources 'MFR.Objects.Tests.Properties.Resources')
  - [Culture](#P-MFR-Objects-Tests-Properties-Resources-Culture 'MFR.Objects.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Tests-Properties-Resources-ResourceManager 'MFR.Objects.Tests.Properties.Resources.ResourceManager')
  - [SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER](#P-MFR-Objects-Tests-Properties-Resources-SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER 'MFR.Objects.Tests.Properties.Resources.SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER')
- [StringExtensionsTests](#T-MFR-Objects-Tests-StringExtensionsTests 'MFR.Objects.Tests.StringExtensionsTests')
  - [Test_IsAbsolutePath_ReturnsFalse_ForFileNameOnly()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_ForFileNameOnly 'MFR.Objects.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsFalse_ForFileNameOnly')
  - [Test_IsAbsolutePath_ReturnsFalse_ForFileNameWithoutExtension()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_ForFileNameWithoutExtension 'MFR.Objects.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsFalse_ForFileNameWithoutExtension')
  - [Test_IsAbsolutePath_ReturnsFalse_WhenPassedBlankInput()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassedBlankInput 'MFR.Objects.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsFalse_WhenPassedBlankInput')
  - [Test_IsAbsolutePath_ReturnsFalse_WhenPassedNullInput()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassedNullInput 'MFR.Objects.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsFalse_WhenPassedNullInput')
  - [Test_IsAbsolutePath_ReturnsFalse_WhenPassedWhitespace()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassedWhitespace 'MFR.Objects.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsFalse_WhenPassedWhitespace')
  - [Test_IsAbsolutePath_ReturnsFalse_WhenPassed_RelativePathName()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassed_RelativePathName 'MFR.Objects.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsFalse_WhenPassed_RelativePathName')
  - [Test_IsAbsolutePath_ReturnsTrue_ForAbsolutePath_EvenIfTheFileNotExists()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsTrue_ForAbsolutePath_EvenIfTheFileNotExists 'MFR.Objects.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsTrue_ForAbsolutePath_EvenIfTheFileNotExists')
  - [Test_IsAbsolutePath_ReturnsTrue_ForFullPathnameOfFileGauranteedToExist()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsTrue_ForFullPathnameOfFileGauranteedToExist 'MFR.Objects.Tests.StringExtensionsTests.Test_IsAbsolutePath_ReturnsTrue_ForFullPathnameOfFileGauranteedToExist')
  - [Test_IsFolderPath_ReturnsFalse_ForBlankInput()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForBlankInput 'MFR.Objects.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForBlankInput')
  - [Test_IsFolderPath_ReturnsFalse_ForFileThatDoesNotExist()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFileThatDoesNotExist 'MFR.Objects.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForFileThatDoesNotExist')
  - [Test_IsFolderPath_ReturnsFalse_ForFileThatExists()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFileThatExists 'MFR.Objects.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForFileThatExists')
  - [Test_IsFolderPath_ReturnsFalse_ForFilenameOnly()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFilenameOnly 'MFR.Objects.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForFilenameOnly')
  - [Test_IsFolderPath_ReturnsFalse_ForFilenameWithNoExtension()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFilenameWithNoExtension 'MFR.Objects.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForFilenameWithNoExtension')
  - [Test_IsFolderPath_ReturnsFalse_ForFolderThatDoesNotExist()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFolderThatDoesNotExist 'MFR.Objects.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForFolderThatDoesNotExist')
  - [Test_IsFolderPath_ReturnsFalse_ForNullInput()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForNullInput 'MFR.Objects.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForNullInput')
  - [Test_IsFolderPath_ReturnsFalse_ForWhitespaceInput()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForWhitespaceInput 'MFR.Objects.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsFalse_ForWhitespaceInput')
  - [Test_IsFolderPath_ReturnsTrue_ForFolderThatExists()](#M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsTrue_ForFolderThatExists 'MFR.Objects.Tests.StringExtensionsTests.Test_IsFolderPath_ReturnsTrue_ForFolderThatExists')

<a name='T-MFR-Objects-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-MFR-Objects-Tests-Properties-Resources-SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER'></a>
### SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER `property`

##### Summary

Looks up a localized string similar to C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\packages\EntityFramework.6.4.4.

<a name='T-MFR-Objects-Tests-StringExtensionsTests'></a>
## StringExtensionsTests `type`

##### Namespace

MFR.Objects.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[StringExtensions](#T-xyLOGIX-Core-Extensions-StringExtensions 'xyLOGIX.Core.Extensions.StringExtensions')
class.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_ForFileNameOnly'></a>
### Test_IsAbsolutePath_ReturnsFalse_ForFileNameOnly() `method`

##### Summary

Asserts the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `false` for the case where it is only
passed a filename (such as NOTEPAD.EXE) and not a complete, absolute pathname.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_ForFileNameWithoutExtension'></a>
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

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassedBlankInput'></a>
### Test_IsAbsolutePath_ReturnsFalse_WhenPassedBlankInput() `method`

##### Summary

Asserts that the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `false` when it is passed a blank value.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassedNullInput'></a>
### Test_IsAbsolutePath_ReturnsFalse_WhenPassedNullInput() `method`

##### Summary

Asserts that the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `false` when passed
`null`
as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassedWhitespace'></a>
### Test_IsAbsolutePath_ReturnsFalse_WhenPassedWhitespace() `method`

##### Summary

Asserts that the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `false` when passed whitespace for input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsFalse_WhenPassed_RelativePathName'></a>
### Test_IsAbsolutePath_ReturnsFalse_WhenPassed_RelativePathName() `method`

##### Summary

Asserts that the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `false` in the event that the
relative pathname, e.g., .\NOTEPAD.EXE, is passed.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsTrue_ForAbsolutePath_EvenIfTheFileNotExists'></a>
### Test_IsAbsolutePath_ReturnsTrue_ForAbsolutePath_EvenIfTheFileNotExists() `method`

##### Summary

Asserts that the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `true` when passed a fully-qualified
pathname of a file, even if the file does not exist.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsAbsolutePath_ReturnsTrue_ForFullPathnameOfFileGauranteedToExist'></a>
### Test_IsAbsolutePath_ReturnsTrue_ForFullPathnameOfFileGauranteedToExist() `method`

##### Summary

Asserts that the
[IsAbsolutePath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsAbsolutePath 'xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath')
method returns `true` when it is passed a
fully-qualified pathname of a file that is guaranteed to exist.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForBlankInput'></a>
### Test_IsFolderPath_ReturnsFalse_ForBlankInput() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` when supplied with the empty
string as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFileThatDoesNotExist'></a>
### Test_IsFolderPath_ReturnsFalse_ForFileThatDoesNotExist() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` when passed the pathname of a
file that is known not to exist.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFileThatExists'></a>
### Test_IsFolderPath_ReturnsFalse_ForFileThatExists() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` for the event in which it is
passed the fully-qualified pathname of a file that is known to exist.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFilenameOnly'></a>
### Test_IsFolderPath_ReturnsFalse_ForFilenameOnly() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` when provided only the name
and extension of a file that is otherwise known to exist.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFilenameWithNoExtension'></a>
### Test_IsFolderPath_ReturnsFalse_ForFilenameWithNoExtension() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` when provided the name of a
file that exists, but without the extension.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForFolderThatDoesNotExist'></a>
### Test_IsFolderPath_ReturnsFalse_ForFolderThatDoesNotExist() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` when passed the
fully-qualified pathname of a folder that is known not to exist.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForNullInput'></a>
### Test_IsFolderPath_ReturnsFalse_ForNullInput() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` when supplied with the
`null`
string as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsFalse_ForWhitespaceInput'></a>
### Test_IsFolderPath_ReturnsFalse_ForWhitespaceInput() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `false` when supplied with whitespace
as an input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Tests-StringExtensionsTests-Test_IsFolderPath_ReturnsTrue_ForFolderThatExists'></a>
### Test_IsFolderPath_ReturnsTrue_ForFolderThatExists() `method`

##### Summary

Asserts that the
[IsFolderPath](#M-xyLOGIX-Core-Extensions-StringExtensions-IsFolderPath 'xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath')
method returns `true` when passed the
fully-qualified pathname of a folder that is known to exist.

##### Parameters

This method has no parameters.
