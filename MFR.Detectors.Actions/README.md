<a name='assembly'></a>
# MFR.Detectors.Actions

## Contents

- [Detect](#T-MFR-Detectors-Actions-Detect 'MFR.Detectors.Actions.Detect')
  - [FormatOfFile(pathname)](#M-MFR-Detectors-Actions-Detect-FormatOfFile-System-String- 'MFR.Detectors.Actions.Detect.FormatOfFile(System.String)')
- [Determine](#T-MFR-Detectors-Actions-Determine 'MFR.Detectors.Actions.Determine')
  - [FileSize(pathname)](#M-MFR-Detectors-Actions-Determine-FileSize-System-String- 'MFR.Detectors.Actions.Determine.FileSize(System.String)')
  - [WhetherCharacterIsControlCharacter(ch)](#M-MFR-Detectors-Actions-Determine-WhetherCharacterIsControlCharacter-System-Int32- 'MFR.Detectors.Actions.Determine.WhetherCharacterIsControlCharacter(System.Int32)')
- [Resources](#T-MFR-Detectors-Actions-Properties-Resources 'MFR.Detectors.Actions.Properties.Resources')
  - [Culture](#P-MFR-Detectors-Actions-Properties-Resources-Culture 'MFR.Detectors.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Detectors-Actions-Properties-Resources-ResourceManager 'MFR.Detectors.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-Detectors-Actions-Detect'></a>
## Detect `type`

##### Namespace

MFR.Detectors.Actions

##### Summary

Exposes static methods to do detection on files.

<a name='M-MFR-Detectors-Actions-Detect-FormatOfFile-System-String-'></a>
### FormatOfFile(pathname) `method`

##### Summary

Attempts to determine the format of the file having the specified
`pathname`.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the fully-qualified pathname of a file on the disk, whose format is to
be detected. |

<a name='T-MFR-Detectors-Actions-Determine'></a>
## Determine `type`

##### Namespace

MFR.Detectors.Actions

##### Summary

Exposes static methods to determine things about files.

<a name='M-MFR-Detectors-Actions-Determine-FileSize-System-String-'></a>
### FileSize(pathname) `method`

##### Summary

Determines the number of bytes in a file.

##### Returns

A [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') value that is set to `-1` if an
error occurred, or the length of the file in bytes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file for which we want to obtain the size. |

<a name='M-MFR-Detectors-Actions-Determine-WhetherCharacterIsControlCharacter-System-Int32-'></a>
### WhetherCharacterIsControlCharacter(ch) `method`

##### Summary

Determines whether the specified ASCII character code, `ch`,
represents or encodes any of the special ASCII control characters that would
signify that a file is binary.

##### Returns

`true` if `ch` is a ASCII control
character code; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ch | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-MFR-Detectors-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Detectors.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Detectors-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Detectors-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
