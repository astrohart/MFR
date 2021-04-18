<a name='assembly'></a>
# MFR.Objects.FileSystem.Validators.Tests

## Contents

- [DirectoryValidatorTests](#T-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests')
  - [Test_DoesExist_ReturnsFalse_WhenProvidedFolderPath_NotExists()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ReturnsFalse_WhenProvidedFolderPath_NotExists 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_DoesExist_ReturnsFalse_WhenProvidedFolderPath_NotExists')
  - [Test_DoesExist_ReturnsTrue_WhenProvidedFolderPath_Exists()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ReturnsTrue_WhenProvidedFolderPath_Exists 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_DoesExist_ReturnsTrue_WhenProvidedFolderPath_Exists')
  - [Test_DoesExist_ThrowsArgumentException_ForBlankPath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ThrowsArgumentException_ForBlankPath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_DoesExist_ThrowsArgumentException_ForBlankPath')
  - [Test_DoesExist_ThrowsArgumentException_ForNullPath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ThrowsArgumentException_ForNullPath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_DoesExist_ThrowsArgumentException_ForNullPath')
  - [Test_DoesExist_ThrowsArgumentException_ForWhitespacePath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ThrowsArgumentException_ForWhitespacePath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_DoesExist_ThrowsArgumentException_ForWhitespacePath')
  - [Test_IsValid_DoesNotThrowException_ForWindowsSystemFolder()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_DoesNotThrowException_ForWindowsSystemFolder 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_IsValid_DoesNotThrowException_ForWindowsSystemFolder')
  - [Test_IsValid_ThrowsArgumentException_ForBlankPath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_ThrowsArgumentException_ForBlankPath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_IsValid_ThrowsArgumentException_ForBlankPath')
  - [Test_IsValid_ThrowsArgumentException_ForNullPath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_ThrowsArgumentException_ForNullPath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_IsValid_ThrowsArgumentException_ForNullPath')
  - [Test_IsValid_ThrowsArgumentException_ForWhitespacePath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_ThrowsArgumentException_ForWhitespacePath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_IsValid_ThrowsArgumentException_ForWhitespacePath')
  - [Test_IsValid_ThrowsDirectoryNotFoundException_ForNonexistentFolder()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_ThrowsDirectoryNotFoundException_ForNonexistentFolder 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_IsValid_ThrowsDirectoryNotFoundException_ForNonexistentFolder')
  - [Test_ShouldSkip_ReturnsFalse_ForAllowedDir()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsFalse_ForAllowedDir 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_ShouldSkip_ReturnsFalse_ForAllowedDir')
  - [Test_ShouldSkip_ReturnsTrue_ForBlankPath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForBlankPath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_ShouldSkip_ReturnsTrue_ForBlankPath')
  - [Test_ShouldSkip_ReturnsTrue_ForDotfolder()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForDotfolder 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_ShouldSkip_ReturnsTrue_ForDotfolder')
  - [Test_ShouldSkip_ReturnsTrue_ForFolderInBinDir()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFolderInBinDir 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_ShouldSkip_ReturnsTrue_ForFolderInBinDir')
  - [Test_ShouldSkip_ReturnsTrue_ForFolderInObjDir()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFolderInObjDir 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_ShouldSkip_ReturnsTrue_ForFolderInObjDir')
  - [Test_ShouldSkip_ReturnsTrue_ForNullInput()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForNullInput 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_ShouldSkip_ReturnsTrue_ForNullInput')
  - [Test_ShouldSkip_ReturnsTrue_ForNullPath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForNullPath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_ShouldSkip_ReturnsTrue_ForNullPath')
  - [Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFolder()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFolder 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFolder')
  - [Test_ShouldSkip_ReturnsTrue_ForSubfolderOfGitDir()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForSubfolderOfGitDir 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_ShouldSkip_ReturnsTrue_ForSubfolderOfGitDir')
  - [Test_ShouldSkip_ReturnsTrue_ForSubfolderOfPackagesDir()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForSubfolderOfPackagesDir 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_ShouldSkip_ReturnsTrue_ForSubfolderOfPackagesDir')
  - [Test_ShouldSkip_ReturnsTrue_ForSubfolderOfVsDir()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForSubfolderOfVsDir 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_ShouldSkip_ReturnsTrue_ForSubfolderOfVsDir')
  - [Test_ShouldSkip_ReturnsTrue_ForWhitespacePath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForWhitespacePath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_ShouldSkip_ReturnsTrue_ForWhitespacePath')
- [FileValidatorTests](#T-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests 'MFR.Objects.FileSystem.Validators.Tests.FileValidatorTests')
  - [Test_ShouldSkip_ReturnsFalse_ForAllowedFile()](#M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsFalse_ForAllowedFile 'MFR.Objects.FileSystem.Validators.Tests.FileValidatorTests.Test_ShouldSkip_ReturnsFalse_ForAllowedFile')
  - [Test_ShouldSkip_ReturnsTrue_ForBlankPath()](#M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForBlankPath 'MFR.Objects.FileSystem.Validators.Tests.FileValidatorTests.Test_ShouldSkip_ReturnsTrue_ForBlankPath')
  - [Test_ShouldSkip_ReturnsTrue_ForDotfile()](#M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForDotfile 'MFR.Objects.FileSystem.Validators.Tests.FileValidatorTests.Test_ShouldSkip_ReturnsTrue_ForDotfile')
  - [Test_ShouldSkip_ReturnsTrue_ForFileInBinDir()](#M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFileInBinDir 'MFR.Objects.FileSystem.Validators.Tests.FileValidatorTests.Test_ShouldSkip_ReturnsTrue_ForFileInBinDir')
  - [Test_ShouldSkip_ReturnsTrue_ForFileInGitDir()](#M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFileInGitDir 'MFR.Objects.FileSystem.Validators.Tests.FileValidatorTests.Test_ShouldSkip_ReturnsTrue_ForFileInGitDir')
  - [Test_ShouldSkip_ReturnsTrue_ForFileInObjDir()](#M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFileInObjDir 'MFR.Objects.FileSystem.Validators.Tests.FileValidatorTests.Test_ShouldSkip_ReturnsTrue_ForFileInObjDir')
  - [Test_ShouldSkip_ReturnsTrue_ForFileInPackagesDir()](#M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFileInPackagesDir 'MFR.Objects.FileSystem.Validators.Tests.FileValidatorTests.Test_ShouldSkip_ReturnsTrue_ForFileInPackagesDir')
  - [Test_ShouldSkip_ReturnsTrue_ForFileInVsDir()](#M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFileInVsDir 'MFR.Objects.FileSystem.Validators.Tests.FileValidatorTests.Test_ShouldSkip_ReturnsTrue_ForFileInVsDir')
  - [Test_ShouldSkip_ReturnsTrue_ForNullInput()](#M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForNullInput 'MFR.Objects.FileSystem.Validators.Tests.FileValidatorTests.Test_ShouldSkip_ReturnsTrue_ForNullInput')
  - [Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFile()](#M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFile 'MFR.Objects.FileSystem.Validators.Tests.FileValidatorTests.Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFile')
  - [Test_ShouldSkip_ReturnsTrue_ForPathWithNoFileExtension()](#M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForPathWithNoFileExtension 'MFR.Objects.FileSystem.Validators.Tests.FileValidatorTests.Test_ShouldSkip_ReturnsTrue_ForPathWithNoFileExtension')
  - [Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile()](#M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile 'MFR.Objects.FileSystem.Validators.Tests.FileValidatorTests.Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile')
  - [Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile2()](#M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile2 'MFR.Objects.FileSystem.Validators.Tests.FileValidatorTests.Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile2')
- [Resources](#T-MFR-Objects-FileSystem-Validators-Tests-Properties-Resources 'MFR.Objects.FileSystem.Validators.Tests.Properties.Resources')
  - [Culture](#P-MFR-Objects-FileSystem-Validators-Tests-Properties-Resources-Culture 'MFR.Objects.FileSystem.Validators.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-FileSystem-Validators-Tests-Properties-Resources-ResourceManager 'MFR.Objects.FileSystem.Validators.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests'></a>
## DirectoryValidatorTests `type`

##### Namespace

MFR.Objects.FileSystem.Validators.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[FileValidator](#T-MFR-Objects-FileValidator 'MFR.Objects.FileValidator')
class.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ReturnsFalse_WhenProvidedFolderPath_NotExists'></a>
### Test_DoesExist_ReturnsFalse_WhenProvidedFolderPath_NotExists() `method`

##### Summary

Asserts that the
[DoesExist](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-DoesExist 'MFR.Objects.FileSystem.Validators.DirectoryValidator.DoesExist')
method returns `false` when the folder path provided
to the method as its argument does not, in fact, exist on the disk.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ReturnsTrue_WhenProvidedFolderPath_Exists'></a>
### Test_DoesExist_ReturnsTrue_WhenProvidedFolderPath_Exists() `method`

##### Summary

Asserts that the
[DoesExist](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-DoesExist 'MFR.Objects.FileSystem.Validators.DirectoryValidator.DoesExist')
method returns `true` when provided with the path to
a folder on the disk that is guaranteed to exist.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ThrowsArgumentException_ForBlankPath'></a>
### Test_DoesExist_ThrowsArgumentException_ForBlankPath() `method`

##### Summary

Asserts that the [DoesExist](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-DoesExist 'MFR.Objects.FileSystem.Validators.DirectoryValidator.DoesExist') method throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') when passed a blank value for its parameter.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ThrowsArgumentException_ForNullPath'></a>
### Test_DoesExist_ThrowsArgumentException_ForNullPath() `method`

##### Summary

Asserts that the [DoesExist](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-DoesExist 'MFR.Objects.FileSystem.Validators.DirectoryValidator.DoesExist') method throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') when passed a `null` value for its parameter.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ThrowsArgumentException_ForWhitespacePath'></a>
### Test_DoesExist_ThrowsArgumentException_ForWhitespacePath() `method`

##### Summary

Asserts that the [DoesExist](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-DoesExist 'MFR.Objects.FileSystem.Validators.DirectoryValidator.DoesExist') method throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') when passed a whitespace value for its parameter.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_DoesNotThrowException_ForWindowsSystemFolder'></a>
### Test_IsValid_DoesNotThrowException_ForWindowsSystemFolder() `method`

##### Summary

Asserts that the [IsValid](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-IsValid 'MFR.Objects.FileSystem.Validators.DirectoryValidator.IsValid') method does not throw any exceptions when passed the pathname of the C:\WINDOWS\System32 folder (which is guaranteed to always be valid).

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_ThrowsArgumentException_ForBlankPath'></a>
### Test_IsValid_ThrowsArgumentException_ForBlankPath() `method`

##### Summary

Asserts that the [IsValid](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-IsValid 'MFR.Objects.FileSystem.Validators.DirectoryValidator.IsValid') method throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') when passed a blank string for its parameter.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_ThrowsArgumentException_ForNullPath'></a>
### Test_IsValid_ThrowsArgumentException_ForNullPath() `method`

##### Summary

Asserts that the [IsValid](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-IsValid 'MFR.Objects.FileSystem.Validators.DirectoryValidator.IsValid') method throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') when passed a `null` string for its parameter.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_ThrowsArgumentException_ForWhitespacePath'></a>
### Test_IsValid_ThrowsArgumentException_ForWhitespacePath() `method`

##### Summary

Asserts that the [IsValid](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-IsValid 'MFR.Objects.FileSystem.Validators.DirectoryValidator.IsValid') method throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') when passed whitespace for its parameter.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_ThrowsDirectoryNotFoundException_ForNonexistentFolder'></a>
### Test_IsValid_ThrowsDirectoryNotFoundException_ForNonexistentFolder() `method`

##### Summary

Asserts that the [IsValid](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-IsValid 'MFR.Objects.FileSystem.Validators.DirectoryValidator.IsValid') method throws [DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') when passed the path to a folder that is guaranteed not to actually exist on the machine's hard disk.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsFalse_ForAllowedDir'></a>
### Test_ShouldSkip_ReturnsFalse_ForAllowedDir() `method`

##### Summary

Asserts that the [ShouldSkip](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-ShouldSkip 'MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip') method returns `false` when passed the path to a folder that matches the operational criteria.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForBlankPath'></a>
### Test_ShouldSkip_ReturnsTrue_ForBlankPath() `method`

##### Summary

Asserts that the [ShouldSkip](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-ShouldSkip 'MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip') method returns `true` when passed a blank string for its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForDotfolder'></a>
### Test_ShouldSkip_ReturnsTrue_ForDotfolder() `method`

##### Summary

Asserts that the [ShouldSkip](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-ShouldSkip 'MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip') method returns `true` when passed the pathname to a dotfolder (a folder whose name begins with a period), as such a folder does not meet the operational criteria.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFolderInBinDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForFolderInBinDir() `method`

##### Summary

Asserts that the [ShouldSkip](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-ShouldSkip 'MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip') method returns `true` for a folder named `bin`, which does not meet the operational criteria.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFolderInObjDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForFolderInObjDir() `method`

##### Summary

Asserts that the [ShouldSkip](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-ShouldSkip 'MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip') method returns `true` for a folder named `obj`, which does not meet the operational criteria.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForNullInput'></a>
### Test_ShouldSkip_ReturnsTrue_ForNullInput() `method`

##### Summary

Asserts that the [ShouldSkip](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-ShouldSkip 'MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip') method returns `true` when passed the `null` string for its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForNullPath'></a>
### Test_ShouldSkip_ReturnsTrue_ForNullPath() `method`

##### Summary

Asserts that the [ShouldSkip](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-ShouldSkip 'MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip') method returns `true` when passed the `null` string for its argument.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFolder'></a>
### Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFolder() `method`

##### Summary

Asserts that the [ShouldSkip](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-ShouldSkip 'MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip') method returns `true` when passed the pathname of a folder that is known not to exist.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForSubfolderOfGitDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForSubfolderOfGitDir() `method`

##### Summary

Asserts that the [ShouldSkip](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-ShouldSkip 'MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip') method returns `true` for a folder named `.git`, or a subfolder thereof, which does not meet the operational criteria.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForSubfolderOfPackagesDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForSubfolderOfPackagesDir() `method`

##### Summary

Asserts that the [ShouldSkip](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-ShouldSkip 'MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip') method returns `true` for a folder named `packages`, or a subfolder thereof, which does not meet the operational criteria.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForSubfolderOfVsDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForSubfolderOfVsDir() `method`

##### Summary

Asserts that the [ShouldSkip](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-ShouldSkip 'MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip') method returns `true` for a folder named `.vs`, or a subfolder thereof, which does not meet the operational criteria.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForWhitespacePath'></a>
### Test_ShouldSkip_ReturnsTrue_ForWhitespacePath() `method`

##### Summary

Asserts that the [ShouldSkip](#M-MFR-Objects-FileSystem-Validators-DirectoryValidator-ShouldSkip 'MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip') method returns `true` when passed whitespace for its argument.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests'></a>
## FileValidatorTests `type`

##### Namespace

MFR.Objects.FileSystem.Validators.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[FileValidator](#T-MFR-Objects-FileValidator 'MFR.Objects.FileValidator')
class.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsFalse_ForAllowedFile'></a>
### Test_ShouldSkip_ReturnsFalse_ForAllowedFile() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForBlankPath'></a>
### Test_ShouldSkip_ReturnsTrue_ForBlankPath() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForDotfile'></a>
### Test_ShouldSkip_ReturnsTrue_ForDotfile() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFileInBinDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForFileInBinDir() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFileInGitDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForFileInGitDir() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFileInObjDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForFileInObjDir() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFileInPackagesDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForFileInPackagesDir() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFileInVsDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForFileInVsDir() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForNullInput'></a>
### Test_ShouldSkip_ReturnsTrue_ForNullInput() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFile'></a>
### Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFile() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForPathWithNoFileExtension'></a>
### Test_ShouldSkip_ReturnsTrue_ForPathWithNoFileExtension() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile'></a>
### Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-FileValidatorTests-Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile2'></a>
### Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile2() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-FileSystem-Validators-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.FileSystem.Validators.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-FileSystem-Validators-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-FileSystem-Validators-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
