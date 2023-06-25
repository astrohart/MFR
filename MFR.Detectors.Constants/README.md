<a name='assembly'></a>
# MFR.Detectors.Constants

## Contents

- [DetectedFileFormat](#T-MFR-Detectors-Constants-DetectedFileFormat 'MFR.Detectors.Constants.DetectedFileFormat')
  - [ASCII](#F-MFR-Detectors-Constants-DetectedFileFormat-ASCII 'MFR.Detectors.Constants.DetectedFileFormat.ASCII')
  - [Binary](#F-MFR-Detectors-Constants-DetectedFileFormat-Binary 'MFR.Detectors.Constants.DetectedFileFormat.Binary')
  - [Unknown](#F-MFR-Detectors-Constants-DetectedFileFormat-Unknown 'MFR.Detectors.Constants.DetectedFileFormat.Unknown')
- [Resources](#T-MFR-Detectors-Constants-Properties-Resources 'MFR.Detectors.Constants.Properties.Resources')
  - [Culture](#P-MFR-Detectors-Constants-Properties-Resources-Culture 'MFR.Detectors.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Detectors-Constants-Properties-Resources-ResourceManager 'MFR.Detectors.Constants.Properties.Resources.ResourceManager')
- [SpecialASCIIChars](#T-MFR-Detectors-Constants-SpecialASCIIChars 'MFR.Detectors.Constants.SpecialASCIIChars')
  - [BS](#F-MFR-Detectors-Constants-SpecialASCIIChars-BS 'MFR.Detectors.Constants.SpecialASCIIChars.BS')
  - [CR](#F-MFR-Detectors-Constants-SpecialASCIIChars-CR 'MFR.Detectors.Constants.SpecialASCIIChars.CR')
  - [NUL](#F-MFR-Detectors-Constants-SpecialASCIIChars-NUL 'MFR.Detectors.Constants.SpecialASCIIChars.NUL')
  - [SUB](#F-MFR-Detectors-Constants-SpecialASCIIChars-SUB 'MFR.Detectors.Constants.SpecialASCIIChars.SUB')

<a name='T-MFR-Detectors-Constants-DetectedFileFormat'></a>
## DetectedFileFormat `type`

##### Namespace

MFR.Detectors.Constants

##### Summary

Values that specify the format of a file that we have ascertained from looking
at some of the bytes of the file.

<a name='F-MFR-Detectors-Constants-DetectedFileFormat-ASCII'></a>
### ASCII `constants`

##### Summary

The file seems to be ASCII format.

<a name='F-MFR-Detectors-Constants-DetectedFileFormat-Binary'></a>
### Binary `constants`

##### Summary

The file has been detected to be a binary format.

<a name='F-MFR-Detectors-Constants-DetectedFileFormat-Unknown'></a>
### Unknown `constants`

##### Summary

We were unable to determine the format of the file.

##### Remarks

When a file-format detection yields a value of
[Unknown](#F-MFR-Detectors-Constants-DetectedFileFormat-Unknown 'MFR.Detectors.Constants.DetectedFileFormat.Unknown'), the file
should be assumed by calling code to have a Binary file format.



How this value is handled is application-specific.

<a name='T-MFR-Detectors-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Detectors.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Detectors-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Detectors-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Detectors-Constants-SpecialASCIIChars'></a>
## SpecialASCIIChars `type`

##### Namespace

MFR.Detectors.Constants

##### Summary

Values for special ASCII characters.

<a name='F-MFR-Detectors-Constants-SpecialASCIIChars-BS'></a>
### BS `constants`

##### Summary

The `BS` character (backspace).

<a name='F-MFR-Detectors-Constants-SpecialASCIIChars-CR'></a>
### CR `constants`

##### Summary

The `CR` character (carriage return).

<a name='F-MFR-Detectors-Constants-SpecialASCIIChars-NUL'></a>
### NUL `constants`

##### Summary

The `NUL` character (null).

<a name='F-MFR-Detectors-Constants-SpecialASCIIChars-SUB'></a>
### SUB `constants`

##### Summary

The `SUB` character (substitute).
