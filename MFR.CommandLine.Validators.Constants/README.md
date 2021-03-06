<a name='assembly'></a>
# MFR.CommandLine.Validators.Constants

## Contents

- [CommandLineInvalidReason](#T-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason')
  - [IsNull](#F-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-IsNull 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason.IsNull')
  - [Unknown](#F-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-Unknown 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason.Unknown')
- [CommandLineValidationMessages](#T-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages 'MFR.CommandLine.Validators.Constants.CommandLineValidationMessages')
  - [CommandLineInfoIsNull](#P-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages-CommandLineInfoIsNull 'MFR.CommandLine.Validators.Constants.CommandLineValidationMessages.CommandLineInfoIsNull')
  - [UnknownCommandLineValidationFailedError](#P-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages-UnknownCommandLineValidationFailedError 'MFR.CommandLine.Validators.Constants.CommandLineValidationMessages.UnknownCommandLineValidationFailedError')
- [Resources](#T-MFR-CommandLine-Validators-Constants-Properties-Resources 'MFR.CommandLine.Validators.Constants.Properties.Resources')
  - [CommandLineInfoIsNull](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-CommandLineInfoIsNull 'MFR.CommandLine.Validators.Constants.Properties.Resources.CommandLineInfoIsNull')
  - [Culture](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-Culture 'MFR.CommandLine.Validators.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-ResourceManager 'MFR.CommandLine.Validators.Constants.Properties.Resources.ResourceManager')
  - [RootDirectoryDoesntContainSolution](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-RootDirectoryDoesntContainSolution 'MFR.CommandLine.Validators.Constants.Properties.Resources.RootDirectoryDoesntContainSolution')
  - [RootDirectoryDoesntExist](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-RootDirectoryDoesntExist 'MFR.CommandLine.Validators.Constants.Properties.Resources.RootDirectoryDoesntExist')
  - [RootDirectoryValid](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-RootDirectoryValid 'MFR.CommandLine.Validators.Constants.Properties.Resources.RootDirectoryValid')
  - [UnknownCommandLineValidationFailedError](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-UnknownCommandLineValidationFailedError 'MFR.CommandLine.Validators.Constants.Properties.Resources.UnknownCommandLineValidationFailedError')
  - [UnknownRootDirectoryValidationFailedError](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-UnknownRootDirectoryValidationFailedError 'MFR.CommandLine.Validators.Constants.Properties.Resources.UnknownRootDirectoryValidationFailedError')
- [RootDirectoryInvalidReason](#T-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason 'MFR.CommandLine.Validators.Constants.RootDirectoryInvalidReason')
  - [DoesntContainSolution](#F-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason-DoesntContainSolution 'MFR.CommandLine.Validators.Constants.RootDirectoryInvalidReason.DoesntContainSolution')
  - [DoesntExist](#F-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason-DoesntExist 'MFR.CommandLine.Validators.Constants.RootDirectoryInvalidReason.DoesntExist')
  - [Unknown](#F-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason-Unknown 'MFR.CommandLine.Validators.Constants.RootDirectoryInvalidReason.Unknown')
  - [Valid](#F-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason-Valid 'MFR.CommandLine.Validators.Constants.RootDirectoryInvalidReason.Valid')
- [RootDirectoryValidationMessages](#T-MFR-CommandLine-Validators-Constants-RootDirectoryValidationMessages 'MFR.CommandLine.Validators.Constants.RootDirectoryValidationMessages')
  - [RootDirectoryDoesntContainSolution](#P-MFR-CommandLine-Validators-Constants-RootDirectoryValidationMessages-RootDirectoryDoesntContainSolution 'MFR.CommandLine.Validators.Constants.RootDirectoryValidationMessages.RootDirectoryDoesntContainSolution')
  - [RootDirectoryDoesntExist](#P-MFR-CommandLine-Validators-Constants-RootDirectoryValidationMessages-RootDirectoryDoesntExist 'MFR.CommandLine.Validators.Constants.RootDirectoryValidationMessages.RootDirectoryDoesntExist')
  - [RootDirectoryValid](#P-MFR-CommandLine-Validators-Constants-RootDirectoryValidationMessages-RootDirectoryValid 'MFR.CommandLine.Validators.Constants.RootDirectoryValidationMessages.RootDirectoryValid')
  - [UnknownRootDirectoryValidationFailedError](#P-MFR-CommandLine-Validators-Constants-RootDirectoryValidationMessages-UnknownRootDirectoryValidationFailedError 'MFR.CommandLine.Validators.Constants.RootDirectoryValidationMessages.UnknownRootDirectoryValidationFailedError')

<a name='T-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason'></a>
## CommandLineInvalidReason `type`

##### Namespace

MFR.CommandLine.Validators.Constants

##### Summary

Constants that correspond to the types of validation failures that can
occur for instances of [CommandLineInfo](#T-MFR-CommandLine-CommandLineInfo 'MFR.CommandLine.CommandLineInfo').

<a name='F-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-IsNull'></a>
### IsNull `constants`

##### Summary

A `null` value was passed to the validation method.

<a name='F-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-Unknown'></a>
### Unknown `constants`

##### Summary

Unknown reason for validation failure.

<a name='T-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages'></a>
## CommandLineValidationMessages `type`

##### Namespace

MFR.CommandLine.Validators.Constants

##### Summary

Provides access to format strings that can be used to display
user-friendly error messages when validation of a
[CommandLineInfo](#T-MFR-CommandLine-CommandLineInfo 'MFR.CommandLine.CommandLineInfo')
instance fails.

<a name='P-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages-CommandLineInfoIsNull'></a>
### CommandLineInfoIsNull `property`

##### Summary

Looks up a localized string similar to The command-line arguments
could not be parsed..

<a name='P-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages-UnknownCommandLineValidationFailedError'></a>
### UnknownCommandLineValidationFailedError `property`

##### Summary

Looks up a localized string similar to Due to an error we didn't
expect, we could not perform validation on the command-line
arguments supplied to this application..

<a name='T-MFR-CommandLine-Validators-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.CommandLine.Validators.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-CommandLine-Validators-Constants-Properties-Resources-CommandLineInfoIsNull'></a>
### CommandLineInfoIsNull `property`

##### Summary

Looks up a localized string similar to The command-line arguments could not be parsed..

<a name='P-MFR-CommandLine-Validators-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-CommandLine-Validators-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-MFR-CommandLine-Validators-Constants-Properties-Resources-RootDirectoryDoesntContainSolution'></a>
### RootDirectoryDoesntContainSolution `property`

##### Summary

Looks up a localized string similar to The specified starting directory, '{0}', exists on disk but does not contain a Visual Studio Solution (*.sln) file.

Provide the pathname of a folder that contains a `*.sln` file in its topmost level, and then try to run this application again..

<a name='P-MFR-CommandLine-Validators-Constants-Properties-Resources-RootDirectoryDoesntExist'></a>
### RootDirectoryDoesntExist `property`

##### Summary

Looks up a localized string similar to The specified starting directory, '{0}', does not exist.

Check the value passed on the command line, and then try again..

<a name='P-MFR-CommandLine-Validators-Constants-Properties-Resources-RootDirectoryValid'></a>
### RootDirectoryValid `property`

##### Summary

Looks up a localized string similar to The specified directory exists on the disk and contains a Visual Studio Solution (*.sln) file..

<a name='P-MFR-CommandLine-Validators-Constants-Properties-Resources-UnknownCommandLineValidationFailedError'></a>
### UnknownCommandLineValidationFailedError `property`

##### Summary

Looks up a localized string similar to Due to an error we didn't expect, we could not perform validation on the command-line arguments supplied to this application..

<a name='P-MFR-CommandLine-Validators-Constants-Properties-Resources-UnknownRootDirectoryValidationFailedError'></a>
### UnknownRootDirectoryValidationFailedError `property`

##### Summary

Looks up a localized string similar to Due to an error we didn't expect, we could not perform validation on the path '{0}' that was provided for the starting folder..

<a name='T-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason'></a>
## RootDirectoryInvalidReason `type`

##### Namespace

MFR.CommandLine.Validators.Constants

##### Summary

Specifies the reason that validation either failed or did not fail.

<a name='F-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason-DoesntContainSolution'></a>
### DoesntContainSolution `constants`

##### Summary

The root directory specified does not contain a Visual Studio
Solution (*.sln) file.

<a name='F-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason-DoesntExist'></a>
### DoesntExist `constants`

##### Summary

The root directory specified does not exist on the disk.

<a name='F-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason-Unknown'></a>
### Unknown `constants`

##### Summary

Unknown validation failure.

<a name='F-MFR-CommandLine-Validators-Constants-RootDirectoryInvalidReason-Valid'></a>
### Valid `constants`

##### Summary

The specified directory exists on the disk and contains a Visual
Studio Solution (*.sln) file.

<a name='T-MFR-CommandLine-Validators-Constants-RootDirectoryValidationMessages'></a>
## RootDirectoryValidationMessages `type`

##### Namespace

MFR.CommandLine.Validators.Constants

##### Summary

Provides access to format strings that can be used to display
user-friendly error messages when validation of a root directory
pathname fails.

<a name='P-MFR-CommandLine-Validators-Constants-RootDirectoryValidationMessages-RootDirectoryDoesntContainSolution'></a>
### RootDirectoryDoesntContainSolution `property`

##### Summary

Looks up a localized string similar to The specified starting directory, '{0}', exists on disk but does not contain a Visual Studio Solution (*.sln) file.

Provide the pathname of a folder that contains a `*.sln` file in its topmost level, and then try to run this application again..

<a name='P-MFR-CommandLine-Validators-Constants-RootDirectoryValidationMessages-RootDirectoryDoesntExist'></a>
### RootDirectoryDoesntExist `property`

##### Summary

Looks up a localized string similar to The specified starting
directory, '{0}', exists on disk but does not contain a Visual
Studio Solution (*.sln) file..

<a name='P-MFR-CommandLine-Validators-Constants-RootDirectoryValidationMessages-RootDirectoryValid'></a>
### RootDirectoryValid `property`

##### Summary

Looks up a localized string similar to The specified directory
exists on the disk and contains a Visual Studio Solution (*.sln) file..

<a name='P-MFR-CommandLine-Validators-Constants-RootDirectoryValidationMessages-UnknownRootDirectoryValidationFailedError'></a>
### UnknownRootDirectoryValidationFailedError `property`

##### Summary

Looks up a localized string similar to Due to an error we didn't
expect, we could not perform validation on the path '{0}' that was
provided for the starting folder..
