<a name='assembly'></a>
# MFR.FileSystem.Enumerators.Tests

## Contents

- [EnumerateTests](#T-MFR-FileSystem-Enumerators-Tests-EnumerateTests 'MFR.FileSystem.Enumerators.Tests.EnumerateTests')
  - [Test_Directories_Method_ThrowsArgumentException_WhenWhitespaceIsPassed()](#M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Directories_Method_ThrowsArgumentException_WhenWhitespaceIsPassed 'MFR.FileSystem.Enumerators.Tests.EnumerateTests.Test_Directories_Method_ThrowsArgumentException_WhenWhitespaceIsPassed')
  - [Test_Directories_Method_ThrowsArgumentException_WithBlankInput()](#M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Directories_Method_ThrowsArgumentException_WithBlankInput 'MFR.FileSystem.Enumerators.Tests.EnumerateTests.Test_Directories_Method_ThrowsArgumentException_WithBlankInput')
  - [Test_Directories_Method_ThrowsArgumentException_WithNullInput()](#M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Directories_Method_ThrowsArgumentException_WithNullInput 'MFR.FileSystem.Enumerators.Tests.EnumerateTests.Test_Directories_Method_ThrowsArgumentException_WithNullInput')
  - [Test_Directories_Method_Works_TopDirectoryOnly()](#M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Directories_Method_Works_TopDirectoryOnly 'MFR.FileSystem.Enumerators.Tests.EnumerateTests.Test_Directories_Method_Works_TopDirectoryOnly')
  - [Test_Files_Method_ThrowsArgumentException_WhenWhitespaceIsPassed()](#M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Files_Method_ThrowsArgumentException_WhenWhitespaceIsPassed 'MFR.FileSystem.Enumerators.Tests.EnumerateTests.Test_Files_Method_ThrowsArgumentException_WhenWhitespaceIsPassed')
  - [Test_Files_Method_ThrowsArgumentException_WithBlankInput()](#M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Files_Method_ThrowsArgumentException_WithBlankInput 'MFR.FileSystem.Enumerators.Tests.EnumerateTests.Test_Files_Method_ThrowsArgumentException_WithBlankInput')
  - [Test_Files_Method_ThrowsArgumentException_WithNullInput()](#M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Files_Method_ThrowsArgumentException_WithNullInput 'MFR.FileSystem.Enumerators.Tests.EnumerateTests.Test_Files_Method_ThrowsArgumentException_WithNullInput')
  - [Test_Files_Method_Works_TopDirectoryOnly()](#M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Files_Method_Works_TopDirectoryOnly 'MFR.FileSystem.Enumerators.Tests.EnumerateTests.Test_Files_Method_Works_TopDirectoryOnly')
- [Resources](#T-MFR-FileSystem-Enumerators-Tests-Properties-Resources 'MFR.FileSystem.Enumerators.Tests.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Enumerators-Tests-Properties-Resources-Culture 'MFR.FileSystem.Enumerators.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Enumerators-Tests-Properties-Resources-ResourceManager 'MFR.FileSystem.Enumerators.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Enumerators-Tests-EnumerateTests'></a>
## EnumerateTests `type`

##### Namespace

MFR.FileSystem.Enumerators.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[Enumerate](#T-MFR-FileSystem-Enumerators-Enumerate 'MFR.FileSystem.Enumerators.Enumerate') class.

<a name='M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Directories_Method_ThrowsArgumentException_WhenWhitespaceIsPassed'></a>
### Test_Directories_Method_ThrowsArgumentException_WhenWhitespaceIsPassed() `method`

##### Summary

Asserts that the
[Directories](#M-MFR-FileSystem-Enumerators-Enumerate-Directories 'MFR.FileSystem.Enumerators.Enumerate.Directories') method
returns the empty collection when passed whitespace as input for the root
folder.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Directories_Method_ThrowsArgumentException_WithBlankInput'></a>
### Test_Directories_Method_ThrowsArgumentException_WithBlankInput() `method`

##### Summary

Asserts that the
[Directories](#M-MFR-FileSystem-Enumerators-Enumerate-Directories 'MFR.FileSystem.Enumerators.Enumerate.Directories') method
returns the empty collection when passed a reference to the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') field as input for the root folder.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Directories_Method_ThrowsArgumentException_WithNullInput'></a>
### Test_Directories_Method_ThrowsArgumentException_WithNullInput() `method`

##### Summary

Asserts that the
[Directories](#M-MFR-FileSystem-Enumerators-Enumerate-Directories 'MFR.FileSystem.Enumerators.Enumerate.Directories') method
returns the empty collection when passed `null` as input for
them  root folder.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Directories_Method_Works_TopDirectoryOnly'></a>
### Test_Directories_Method_Works_TopDirectoryOnly() `method`

##### Summary

Asserts that the
[Directories](#M-MFR-FileSystem-Enumerators-Enumerate-Directories 'MFR.FileSystem.Enumerators.Enumerate.Directories') method works
and lists all the top level subfolders of the testing directory.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Files_Method_ThrowsArgumentException_WhenWhitespaceIsPassed'></a>
### Test_Files_Method_ThrowsArgumentException_WhenWhitespaceIsPassed() `method`

##### Summary

Asserts that the
[Files](#M-MFR-FileSystem-Enumerators-Enumerate-Files 'MFR.FileSystem.Enumerators.Enumerate.Files') method
returns the empty collection when passed whitespace as input for the root
folder.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Files_Method_ThrowsArgumentException_WithBlankInput'></a>
### Test_Files_Method_ThrowsArgumentException_WithBlankInput() `method`

##### Summary

Asserts that the
[Files](#M-MFR-FileSystem-Enumerators-Enumerate-Files 'MFR.FileSystem.Enumerators.Enumerate.Files') method
returns the empty collection when passed a reference to the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') field as input for the root folder.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Files_Method_ThrowsArgumentException_WithNullInput'></a>
### Test_Files_Method_ThrowsArgumentException_WithNullInput() `method`

##### Summary

Asserts that the
[Files](#M-MFR-FileSystem-Enumerators-Enumerate-Files 'MFR.FileSystem.Enumerators.Enumerate.Files') method
returns the empty collection when passed `null` as input for
them  root folder.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Enumerators-Tests-EnumerateTests-Test_Files_Method_Works_TopDirectoryOnly'></a>
### Test_Files_Method_Works_TopDirectoryOnly() `method`

##### Summary

Asserts that the
[Files](#M-MFR-FileSystem-Enumerators-Enumerate-Files 'MFR.FileSystem.Enumerators.Enumerate.Files') method works
and lists all the top level subfolders of the testing directory.

##### Parameters

This method has no parameters.

<a name='T-MFR-FileSystem-Enumerators-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Enumerators.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Enumerators-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Enumerators-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
