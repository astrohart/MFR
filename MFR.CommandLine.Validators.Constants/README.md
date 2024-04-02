<a name='assembly'></a>
# MFR.CommandLine.Validators.Constants

## Contents

- [CommandLineInvalidReason](#T-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason')
  - [FindWhatBlank](#F-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-FindWhatBlank 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason.FindWhatBlank')
  - [IsNull](#F-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-IsNull 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason.IsNull')
  - [RootDirectoryDoesntContainSolution](#F-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-RootDirectoryDoesntContainSolution 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason.RootDirectoryDoesntContainSolution')
  - [RootDirectoryDoesntExist](#F-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-RootDirectoryDoesntExist 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason.RootDirectoryDoesntExist')
  - [Unknown](#F-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-Unknown 'MFR.CommandLine.Validators.Constants.CommandLineInvalidReason.Unknown')
- [CommandLineValidationMessages](#T-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages 'MFR.CommandLine.Validators.Constants.CommandLineValidationMessages')
  - [CommandLineInfoIsNull](#P-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages-CommandLineInfoIsNull 'MFR.CommandLine.Validators.Constants.CommandLineValidationMessages.CommandLineInfoIsNull')
  - [FindWhatBlank](#P-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages-FindWhatBlank 'MFR.CommandLine.Validators.Constants.CommandLineValidationMessages.FindWhatBlank')
  - [RootDirectoryDoesntContainSolution](#P-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages-RootDirectoryDoesntContainSolution 'MFR.CommandLine.Validators.Constants.CommandLineValidationMessages.RootDirectoryDoesntContainSolution')
  - [RootDirectoryDoesntExist](#P-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages-RootDirectoryDoesntExist 'MFR.CommandLine.Validators.Constants.CommandLineValidationMessages.RootDirectoryDoesntExist')
  - [UnknownCommandLineValidationFailedError](#P-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages-UnknownCommandLineValidationFailedError 'MFR.CommandLine.Validators.Constants.CommandLineValidationMessages.UnknownCommandLineValidationFailedError')
- [Resources](#T-MFR-CommandLine-Validators-Constants-Properties-Resources 'MFR.CommandLine.Validators.Constants.Properties.Resources')
  - [CommandLineInfoIsNull](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-CommandLineInfoIsNull 'MFR.CommandLine.Validators.Constants.Properties.Resources.CommandLineInfoIsNull')
  - [Culture](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-Culture 'MFR.CommandLine.Validators.Constants.Properties.Resources.Culture')
  - [FindWhatBlank](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-FindWhatBlank 'MFR.CommandLine.Validators.Constants.Properties.Resources.FindWhatBlank')
  - [ResourceManager](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-ResourceManager 'MFR.CommandLine.Validators.Constants.Properties.Resources.ResourceManager')
  - [RootDirectoryDoesntContainSolution](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-RootDirectoryDoesntContainSolution 'MFR.CommandLine.Validators.Constants.Properties.Resources.RootDirectoryDoesntContainSolution')
  - [RootDirectoryDoesntExist](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-RootDirectoryDoesntExist 'MFR.CommandLine.Validators.Constants.Properties.Resources.RootDirectoryDoesntExist')
  - [RootDirectoryValid](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-RootDirectoryValid 'MFR.CommandLine.Validators.Constants.Properties.Resources.RootDirectoryValid')
  - [UnknownCommandLineValidationFailedError](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-UnknownCommandLineValidationFailedError 'MFR.CommandLine.Validators.Constants.Properties.Resources.UnknownCommandLineValidationFailedError')
  - [UnknownRootDirectoryValidationFailedError](#P-MFR-CommandLine-Validators-Constants-Properties-Resources-UnknownRootDirectoryValidationFailedError 'MFR.CommandLine.Validators.Constants.Properties.Resources.UnknownRootDirectoryValidationFailedError')

<a name='T-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason'></a>
## CommandLineInvalidReason `type`

##### Namespace

MFR.CommandLine.Validators.Constants

##### Summary

Constants that correspond to the types of validation failures that can
occur for instances of [CommandLineInfo](#T-MFR-CommandLine-CommandLineInfo 'MFR.CommandLine.CommandLineInfo').

<a name='F-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-FindWhatBlank'></a>
### FindWhatBlank `constants`

##### Summary

The `Find What` value supplied is blank.  This a required value.

<a name='F-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-IsNull'></a>
### IsNull `constants`

##### Summary

A `null` value was passed to the validation method.

<a name='F-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-RootDirectoryDoesntContainSolution'></a>
### RootDirectoryDoesntContainSolution `constants`

##### Summary

The starting folder provided does not contain any .sln files, and not in its hierarchy, either.



This application needs to be launched on a directory that contains at least one `.sln` file.

<a name='F-MFR-CommandLine-Validators-Constants-CommandLineInvalidReason-RootDirectoryDoesntExist'></a>
### RootDirectoryDoesntExist `constants`

##### Summary

The starting folder whose pathname was provided does not exist on the disk.

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

<a name='P-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages-FindWhatBlank'></a>
### FindWhatBlank `property`

##### Summary

Looks up a localized string similar to The 'Find What' value is
blank, or it contains only whitespace..

<a name='P-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages-RootDirectoryDoesntContainSolution'></a>
### RootDirectoryDoesntContainSolution `property`

##### Summary

Looks up a localized string similar to The specified starting directory, '
{0}', exists on disk but does not contain a Visual Studio Solution (*.sln)
file.
m  the pathname of a folder that contains a *.sln file in its topmost level,
and then try to run this application again..

<a name='P-MFR-CommandLine-Validators-Constants-CommandLineValidationMessages-RootDirectoryDoesntExist'></a>
### RootDirectoryDoesntExist `property`

##### Summary

Looks up a localized string similar to The specified starting directory, '
{0}', does not exist.
Check the value passed on the command line, and then try again..

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

<a name='P-MFR-CommandLine-Validators-Constants-Properties-Resources-FindWhatBlank'></a>
### FindWhatBlank `property`

##### Summary

Looks up a localized string similar to The 'Find What' value is blank, or it contains only whitespace..

<a name='P-MFR-CommandLine-Validators-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-MFR-CommandLine-Validators-Constants-Properties-Resources-RootDirectoryDoesntContainSolution'></a>
### RootDirectoryDoesntContainSolution `property`

##### Summary

Looks up a localized string similar to The specified starting directory, '{0}', exists on disk but does not contain a Visual Studio Solution (*.sln) file.

Provide the pathname of a folder that contains a *.sln file in its topmost level, and then try to run this application again..

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
