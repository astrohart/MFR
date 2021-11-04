<a name='assembly'></a>
# MFR.Directories.Enumerators.Tests

## Contents

- [EnumerateTests](#T-MFR-Directories-Enumerators-Tests-EnumerateTests 'MFR.Directories.Enumerators.Tests.EnumerateTests')
  - [Test_Directories_Method_ThrowsArgumentException_WhenWhitespaceIsPassed()](#M-MFR-Directories-Enumerators-Tests-EnumerateTests-Test_Directories_Method_ThrowsArgumentException_WhenWhitespaceIsPassed 'MFR.Directories.Enumerators.Tests.EnumerateTests.Test_Directories_Method_ThrowsArgumentException_WhenWhitespaceIsPassed')
  - [Test_Directories_Method_ThrowsArgumentException_WithBlankInput()](#M-MFR-Directories-Enumerators-Tests-EnumerateTests-Test_Directories_Method_ThrowsArgumentException_WithBlankInput 'MFR.Directories.Enumerators.Tests.EnumerateTests.Test_Directories_Method_ThrowsArgumentException_WithBlankInput')
  - [Test_Directories_Method_ThrowsArgumentException_WithNullInput()](#M-MFR-Directories-Enumerators-Tests-EnumerateTests-Test_Directories_Method_ThrowsArgumentException_WithNullInput 'MFR.Directories.Enumerators.Tests.EnumerateTests.Test_Directories_Method_ThrowsArgumentException_WithNullInput')
  - [Test_Directories_Method_Works_TopDirectoryOnly()](#M-MFR-Directories-Enumerators-Tests-EnumerateTests-Test_Directories_Method_Works_TopDirectoryOnly 'MFR.Directories.Enumerators.Tests.EnumerateTests.Test_Directories_Method_Works_TopDirectoryOnly')
- [Resources](#T-MFR-Directories-Enumerators-Tests-Properties-Resources 'MFR.Directories.Enumerators.Tests.Properties.Resources')
  - [Culture](#P-MFR-Directories-Enumerators-Tests-Properties-Resources-Culture 'MFR.Directories.Enumerators.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Enumerators-Tests-Properties-Resources-ResourceManager 'MFR.Directories.Enumerators.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Directories-Enumerators-Tests-EnumerateTests'></a>
## EnumerateTests `type`

##### Namespace

MFR.Directories.Enumerators.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[Enumerate](#T-MFR-Directories-Enumerators-Enumerate 'MFR.Directories.Enumerators.Enumerate') class.

<a name='M-MFR-Directories-Enumerators-Tests-EnumerateTests-Test_Directories_Method_ThrowsArgumentException_WhenWhitespaceIsPassed'></a>
### Test_Directories_Method_ThrowsArgumentException_WhenWhitespaceIsPassed() `method`

##### Summary

Asserts that the
[Directories](#M-MFR-Directories-Enumerators-Enumerate-Directories 'MFR.Directories.Enumerators.Enumerate.Directories')
method throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') when passed
whitespace as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Directories-Enumerators-Tests-EnumerateTests-Test_Directories_Method_ThrowsArgumentException_WithBlankInput'></a>
### Test_Directories_Method_ThrowsArgumentException_WithBlankInput() `method`

##### Summary

Asserts that the
[Directories](#M-MFR-Directories-Enumerators-Enumerate-Directories 'MFR.Directories.Enumerators.Enumerate.Directories')
method throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') when passed
a reference to the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') field as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Directories-Enumerators-Tests-EnumerateTests-Test_Directories_Method_ThrowsArgumentException_WithNullInput'></a>
### Test_Directories_Method_ThrowsArgumentException_WithNullInput() `method`

##### Summary

Asserts that the
[Directories](#M-MFR-Directories-Enumerators-Enumerate-Directories 'MFR.Directories.Enumerators.Enumerate.Directories')
method throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') when passed
`null` as input.

##### Parameters

This method has no parameters.

<a name='M-MFR-Directories-Enumerators-Tests-EnumerateTests-Test_Directories_Method_Works_TopDirectoryOnly'></a>
### Test_Directories_Method_Works_TopDirectoryOnly() `method`

##### Summary

Asserts that the
[Directories](#M-MFR-Directories-Enumerators-Enumerate-Directories 'MFR.Directories.Enumerators.Enumerate.Directories') method works
and lists all the top level subfolders of the testing directory.

##### Parameters

This method has no parameters.

<a name='T-MFR-Directories-Enumerators-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Directories.Enumerators.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Directories-Enumerators-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Directories-Enumerators-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
