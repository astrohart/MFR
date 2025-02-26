<a name='assembly'></a>
# MFR.Directories.Validators.Constants

## Contents

- [Resources](#T-MFR-Directories-Validators-Constants-Properties-Resources 'MFR.Directories.Validators.Constants.Properties.Resources')
  - [Culture](#P-MFR-Directories-Validators-Constants-Properties-Resources-Culture 'MFR.Directories.Validators.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Validators-Constants-Properties-Resources-ResourceManager 'MFR.Directories.Validators.Constants.Properties.Resources.ResourceManager')
  - [RootDirectoryDoesntContainSolution](#P-MFR-Directories-Validators-Constants-Properties-Resources-RootDirectoryDoesntContainSolution 'MFR.Directories.Validators.Constants.Properties.Resources.RootDirectoryDoesntContainSolution')
  - [RootDirectoryDoesntExist](#P-MFR-Directories-Validators-Constants-Properties-Resources-RootDirectoryDoesntExist 'MFR.Directories.Validators.Constants.Properties.Resources.RootDirectoryDoesntExist')
  - [RootDirectoryValid](#P-MFR-Directories-Validators-Constants-Properties-Resources-RootDirectoryValid 'MFR.Directories.Validators.Constants.Properties.Resources.RootDirectoryValid')
  - [UnknownRootDirectoryValidationFailedError](#P-MFR-Directories-Validators-Constants-Properties-Resources-UnknownRootDirectoryValidationFailedError 'MFR.Directories.Validators.Constants.Properties.Resources.UnknownRootDirectoryValidationFailedError')
- [RootDirectoryInvalidReason](#T-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason 'MFR.Directories.Validators.Constants.RootDirectoryInvalidReason')
  - [Blank](#F-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason-Blank 'MFR.Directories.Validators.Constants.RootDirectoryInvalidReason.Blank')
  - [DoesntContainSolution](#F-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason-DoesntContainSolution 'MFR.Directories.Validators.Constants.RootDirectoryInvalidReason.DoesntContainSolution')
  - [DoesntExist](#F-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason-DoesntExist 'MFR.Directories.Validators.Constants.RootDirectoryInvalidReason.DoesntExist')
  - [Unknown](#F-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason-Unknown 'MFR.Directories.Validators.Constants.RootDirectoryInvalidReason.Unknown')
  - [Valid](#F-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason-Valid 'MFR.Directories.Validators.Constants.RootDirectoryInvalidReason.Valid')
- [RootDirectoryValidationMessages](#T-MFR-Directories-Validators-Constants-RootDirectoryValidationMessages 'MFR.Directories.Validators.Constants.RootDirectoryValidationMessages')
  - [RootDirectoryDoesntContainSolution](#P-MFR-Directories-Validators-Constants-RootDirectoryValidationMessages-RootDirectoryDoesntContainSolution 'MFR.Directories.Validators.Constants.RootDirectoryValidationMessages.RootDirectoryDoesntContainSolution')
  - [RootDirectoryDoesntExist](#P-MFR-Directories-Validators-Constants-RootDirectoryValidationMessages-RootDirectoryDoesntExist 'MFR.Directories.Validators.Constants.RootDirectoryValidationMessages.RootDirectoryDoesntExist')
  - [RootDirectoryValid](#P-MFR-Directories-Validators-Constants-RootDirectoryValidationMessages-RootDirectoryValid 'MFR.Directories.Validators.Constants.RootDirectoryValidationMessages.RootDirectoryValid')
  - [UnknownRootDirectoryValidationFailedError](#P-MFR-Directories-Validators-Constants-RootDirectoryValidationMessages-UnknownRootDirectoryValidationFailedError 'MFR.Directories.Validators.Constants.RootDirectoryValidationMessages.UnknownRootDirectoryValidationFailedError')

<a name='T-MFR-Directories-Validators-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Directories.Validators.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Directories-Validators-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Directories-Validators-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-MFR-Directories-Validators-Constants-Properties-Resources-RootDirectoryDoesntContainSolution'></a>
### RootDirectoryDoesntContainSolution `property`

##### Summary

Looks up a localized string similar to The specified starting directory, '{0}', exists on disk but does not contain a Visual Studio Solution (*.sln) file.

Provide the pathname of a folder that contains a *.sln file in its topmost level, and then try to run this application again..

<a name='P-MFR-Directories-Validators-Constants-Properties-Resources-RootDirectoryDoesntExist'></a>
### RootDirectoryDoesntExist `property`

##### Summary

Looks up a localized string similar to The specified starting directory, '{0}', does not exist.

Check the value passed on the command line, and then try again..

<a name='P-MFR-Directories-Validators-Constants-Properties-Resources-RootDirectoryValid'></a>
### RootDirectoryValid `property`

##### Summary

Looks up a localized string similar to The specified directory exists on the file system and contains a Visual Studio Solution (*.sln) file..

<a name='P-MFR-Directories-Validators-Constants-Properties-Resources-UnknownRootDirectoryValidationFailedError'></a>
### UnknownRootDirectoryValidationFailedError `property`

##### Summary

Looks up a localized string similar to Due to an error we didn't expect, we could not perform validation on the path '{0}' that was provided for the starting folder..

<a name='T-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason'></a>
## RootDirectoryInvalidReason `type`

##### Namespace

MFR.Directories.Validators.Constants

##### Summary

Specifies the reason that validation either failed or did not fail.

<a name='F-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason-Blank'></a>
### Blank `constants`

##### Summary

A blank pathname was specified for the value of the `--root` command-line
parameter.

<a name='F-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason-DoesntContainSolution'></a>
### DoesntContainSolution `constants`

##### Summary

The root directory specified does not contain a Visual Studio
Solution (*.sln) file.

<a name='F-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason-DoesntExist'></a>
### DoesntExist `constants`

##### Summary

The root directory specified does not exist on the file system.

<a name='F-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason-Unknown'></a>
### Unknown `constants`

##### Summary

Unknown validation failure.

<a name='F-MFR-Directories-Validators-Constants-RootDirectoryInvalidReason-Valid'></a>
### Valid `constants`

##### Summary

The specified directory exists on the file system and contains a Visual
Studio Solution (*.sln) file.

<a name='T-MFR-Directories-Validators-Constants-RootDirectoryValidationMessages'></a>
## RootDirectoryValidationMessages `type`

##### Namespace

MFR.Directories.Validators.Constants

##### Summary

Provides access to format strings that can be used to display
user-friendly error messages when validation of a root directory
pathname fails.

<a name='P-MFR-Directories-Validators-Constants-RootDirectoryValidationMessages-RootDirectoryDoesntContainSolution'></a>
### RootDirectoryDoesntContainSolution `property`

##### Summary

Looks up a localized string similar to The specified starting directory, '{0}', exists on disk but does not contain a Visual Studio Solution (*.sln) file.

Provide the pathname of a folder that contains a `*.sln` file in its topmost level, and then try to run this application again..

<a name='P-MFR-Directories-Validators-Constants-RootDirectoryValidationMessages-RootDirectoryDoesntExist'></a>
### RootDirectoryDoesntExist `property`

##### Summary

Looks up a localized string similar to The specified starting
directory, '{0}', exists on disk but does not contain a Visual
Studio Solution (*.sln) file..

<a name='P-MFR-Directories-Validators-Constants-RootDirectoryValidationMessages-RootDirectoryValid'></a>
### RootDirectoryValid `property`

##### Summary

Looks up a localized string similar to The specified directory
exists on the file system and contains a Visual Studio Solution (*.sln) file..

<a name='P-MFR-Directories-Validators-Constants-RootDirectoryValidationMessages-UnknownRootDirectoryValidationFailedError'></a>
### UnknownRootDirectoryValidationFailedError `property`

##### Summary

Looks up a localized string similar to Due to an error we didn't
expect, we could not perform validation on the path '{0}' that was
provided for the starting folder..
