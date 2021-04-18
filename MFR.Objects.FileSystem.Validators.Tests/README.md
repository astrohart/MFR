<a name='assembly'></a>
# MFR.Objects.FileSystem.Validators.Tests

## Contents

- [DirectoryValidatorTests](#T-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests')
  - [Test_DoesExist_ReturnsFalse_WhenProvidedFolderPath_NotExists()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ReturnsFalse_WhenProvidedFolderPath_NotExists 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_DoesExist_ReturnsFalse_WhenProvidedFolderPath_NotExists')
  - [Test_DoesExist_ReturnsTrue_WhenProvidedFolderPath_Exists()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ReturnsTrue_WhenProvidedFolderPath_Exists 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_DoesExist_ReturnsTrue_WhenProvidedFolderPath_Exists')
  - [Test_DoesExist_ThrowsArgumentException_ForBlankPath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ThrowsArgumentException_ForBlankPath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_DoesExist_ThrowsArgumentException_ForBlankPath')
  - [Test_DoesExist_ThrowsArgumentException_ForNullPath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ThrowsArgumentException_ForNullPath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_DoesExist_ThrowsArgumentException_ForNullPath')
  - [Test_DoesExist_ThrowsArgumentException_ForWhitespacePath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ThrowsArgumentException_ForWhitespacePath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_DoesExist_ThrowsArgumentException_ForWhitespacePath')
  - [Test_IsValid_ThrowsArgumentException_ForBlankPath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_ThrowsArgumentException_ForBlankPath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_IsValid_ThrowsArgumentException_ForBlankPath')
  - [Test_IsValid_ThrowsArgumentException_ForNullPath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_ThrowsArgumentException_ForNullPath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_IsValid_ThrowsArgumentException_ForNullPath')
  - [Test_IsValid_ThrowsArgumentException_ForWhitespacePath()](#M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_ThrowsArgumentException_ForWhitespacePath 'MFR.Objects.FileSystem.Validators.Tests.DirectoryValidatorTests.Test_IsValid_ThrowsArgumentException_ForWhitespacePath')
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

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ReturnsTrue_WhenProvidedFolderPath_Exists'></a>
### Test_DoesExist_ReturnsTrue_WhenProvidedFolderPath_Exists() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ThrowsArgumentException_ForBlankPath'></a>
### Test_DoesExist_ThrowsArgumentException_ForBlankPath() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ThrowsArgumentException_ForNullPath'></a>
### Test_DoesExist_ThrowsArgumentException_ForNullPath() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_DoesExist_ThrowsArgumentException_ForWhitespacePath'></a>
### Test_DoesExist_ThrowsArgumentException_ForWhitespacePath() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_ThrowsArgumentException_ForBlankPath'></a>
### Test_IsValid_ThrowsArgumentException_ForBlankPath() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_ThrowsArgumentException_ForNullPath'></a>
### Test_IsValid_ThrowsArgumentException_ForNullPath() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_IsValid_ThrowsArgumentException_ForWhitespacePath'></a>
### Test_IsValid_ThrowsArgumentException_ForWhitespacePath() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsFalse_ForAllowedDir'></a>
### Test_ShouldSkip_ReturnsFalse_ForAllowedDir() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForBlankPath'></a>
### Test_ShouldSkip_ReturnsTrue_ForBlankPath() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForDotfolder'></a>
### Test_ShouldSkip_ReturnsTrue_ForDotfolder() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFolderInBinDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForFolderInBinDir() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForFolderInObjDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForFolderInObjDir() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForNullInput'></a>
### Test_ShouldSkip_ReturnsTrue_ForNullInput() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForNullPath'></a>
### Test_ShouldSkip_ReturnsTrue_ForNullPath() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFolder'></a>
### Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFolder() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForSubfolderOfGitDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForSubfolderOfGitDir() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForSubfolderOfPackagesDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForSubfolderOfPackagesDir() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForSubfolderOfVsDir'></a>
### Test_ShouldSkip_ReturnsTrue_ForSubfolderOfVsDir() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-FileSystem-Validators-Tests-DirectoryValidatorTests-Test_ShouldSkip_ReturnsTrue_ForWhitespacePath'></a>
### Test_ShouldSkip_ReturnsTrue_ForWhitespacePath() `method`

##### Summary

TODO: Add unit test documentation here

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
