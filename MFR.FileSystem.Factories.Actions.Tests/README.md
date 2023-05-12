<a name='assembly'></a>
# MFR.FileSystem.Factories.Actions.Tests

## Contents

- [IsTests](#T-MFR-FileSystem-Factories-Actions-Tests-IsTests 'MFR.FileSystem.Factories.Actions.Tests.IsTests')
  - [DIRECTORY_THAT_EXISTS](#F-MFR-FileSystem-Factories-Actions-Tests-IsTests-DIRECTORY_THAT_EXISTS 'MFR.FileSystem.Factories.Actions.Tests.IsTests.DIRECTORY_THAT_EXISTS')
  - [FAKE_DIRECTORY](#F-MFR-FileSystem-Factories-Actions-Tests-IsTests-FAKE_DIRECTORY 'MFR.FileSystem.Factories.Actions.Tests.IsTests.FAKE_DIRECTORY')
  - [FAKE_FILE](#F-MFR-FileSystem-Factories-Actions-Tests-IsTests-FAKE_FILE 'MFR.FileSystem.Factories.Actions.Tests.IsTests.FAKE_FILE')
  - [Test_IsFolder_ReturnsFalse_For_FakeDirectory()](#M-MFR-FileSystem-Factories-Actions-Tests-IsTests-Test_IsFolder_ReturnsFalse_For_FakeDirectory 'MFR.FileSystem.Factories.Actions.Tests.IsTests.Test_IsFolder_ReturnsFalse_For_FakeDirectory')
  - [Test_IsFolder_ReturnsFalse_For_FakeFile()](#M-MFR-FileSystem-Factories-Actions-Tests-IsTests-Test_IsFolder_ReturnsFalse_For_FakeFile 'MFR.FileSystem.Factories.Actions.Tests.IsTests.Test_IsFolder_ReturnsFalse_For_FakeFile')
  - [Test_IsFolder_ReturnsFalse_For_FileThatExists()](#M-MFR-FileSystem-Factories-Actions-Tests-IsTests-Test_IsFolder_ReturnsFalse_For_FileThatExists 'MFR.FileSystem.Factories.Actions.Tests.IsTests.Test_IsFolder_ReturnsFalse_For_FileThatExists')
  - [Test_IsFolder_ReturnsTrue_For_DirectoryThatExists()](#M-MFR-FileSystem-Factories-Actions-Tests-IsTests-Test_IsFolder_ReturnsTrue_For_DirectoryThatExists 'MFR.FileSystem.Factories.Actions.Tests.IsTests.Test_IsFolder_ReturnsTrue_For_DirectoryThatExists')
- [Resources](#T-MFR-FileSystem-Factories-Actions-Tests-Properties-Resources 'MFR.FileSystem.Factories.Actions.Tests.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Factories-Actions-Tests-Properties-Resources-Culture 'MFR.FileSystem.Factories.Actions.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Factories-Actions-Tests-Properties-Resources-ResourceManager 'MFR.FileSystem.Factories.Actions.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Factories-Actions-Tests-IsTests'></a>
## IsTests `type`

##### Namespace

MFR.FileSystem.Factories.Actions.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[Is](#T-MFR-FileSystem-Factories-Actions-Is 'MFR.FileSystem.Factories.Actions.Is') class.

<a name='F-MFR-FileSystem-Factories-Actions-Tests-IsTests-DIRECTORY_THAT_EXISTS'></a>
### DIRECTORY_THAT_EXISTS `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified path of a
folder, i.e., `C:\WINDOWS`, that is guaranteed to exist.

<a name='F-MFR-FileSystem-Factories-Actions-Tests-IsTests-FAKE_DIRECTORY'></a>
### FAKE_DIRECTORY `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is guaranteed to contain the pathname of
a folder that does not exist.

<a name='F-MFR-FileSystem-Factories-Actions-Tests-IsTests-FAKE_FILE'></a>
### FAKE_FILE `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that holds the pathname of a file that is
guaranteed not to exist.

<a name='M-MFR-FileSystem-Factories-Actions-Tests-IsTests-Test_IsFolder_ReturnsFalse_For_FakeDirectory'></a>
### Test_IsFolder_ReturnsFalse_For_FakeDirectory() `method`

##### Summary

Asserts that the [Folder](#M-MFR-FileSystem-Factories-Actions-Is-Folder 'MFR.FileSystem.Factories.Actions.Is.Folder')
method returns `false` for the folder whose pathname is
contained within the
[FAKE_DIRECTORY](#F-MFR-FileSystem-Factories-Actions-Tests-IsTests-FAKE_DIRECTORY 'MFR.FileSystem.Factories.Actions.Tests.IsTests.FAKE_DIRECTORY')
field.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Factories-Actions-Tests-IsTests-Test_IsFolder_ReturnsFalse_For_FakeFile'></a>
### Test_IsFolder_ReturnsFalse_For_FakeFile() `method`

##### Summary

Asserts that the [Folder](#M-MFR-FileSystem-Factories-Actions-Is-Folder 'MFR.FileSystem.Factories.Actions.Is.Folder')
method returns `false` for the folder whose pathname is
contained within the
[FAKE_FILE](#F-MFR-FileSystem-Factories-Actions-Tests-IsTests-FAKE_FILE 'MFR.FileSystem.Factories.Actions.Tests.IsTests.FAKE_FILE')
field.

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Factories-Actions-Tests-IsTests-Test_IsFolder_ReturnsFalse_For_FileThatExists'></a>
### Test_IsFolder_ReturnsFalse_For_FileThatExists() `method`

##### Summary

Asserts that the [Folder](#M-MFR-FileSystem-Factories-Actions-Is-Folder 'MFR.FileSystem.Factories.Actions.Is.Folder')
method returns `false` for the folder whose pathname is
contained within the
[FILE_THAT_EXISTS](#F-MFR-FileSystem-Factories-Actions-Tests-IsTests-FILE_THAT_EXISTS 'MFR.FileSystem.Factories.Actions.Tests.IsTests.FILE_THAT_EXISTS')
field (as it should, since the pathname is of a file, not a folder).

##### Parameters

This method has no parameters.

<a name='M-MFR-FileSystem-Factories-Actions-Tests-IsTests-Test_IsFolder_ReturnsTrue_For_DirectoryThatExists'></a>
### Test_IsFolder_ReturnsTrue_For_DirectoryThatExists() `method`

##### Summary

Asserts that the [Folder](#M-MFR-FileSystem-Factories-Actions-Is-Folder 'MFR.FileSystem.Factories.Actions.Is.Folder')
method returns `true` for the folder whose pathname is
contained within the
[DIRECTORY_THAT_EXISTS](#F-MFR-FileSystem-Factories-Actions-Tests-IsTests-DIRECTORY_THAT_EXISTS 'MFR.FileSystem.Factories.Actions.Tests.IsTests.DIRECTORY_THAT_EXISTS')
field.

##### Parameters

This method has no parameters.

<a name='T-MFR-FileSystem-Factories-Actions-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Factories.Actions.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Factories-Actions-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Factories-Actions-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
