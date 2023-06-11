<a name='assembly'></a>
# MFR.Settings.Profiles.Providers.Constants

## Contents

- [ProfileFile](#T-MFR-Settings-Profiles-Providers-Constants-ProfileFile 'MFR.Settings.Profiles.Providers.Constants.ProfileFile')
  - [DefaultFilename](#F-MFR-Settings-Profiles-Providers-Constants-ProfileFile-DefaultFilename 'MFR.Settings.Profiles.Providers.Constants.ProfileFile.DefaultFilename')
- [ProfilePathRegistry](#T-MFR-Settings-Profiles-Providers-Constants-ProfilePathRegistry 'MFR.Settings.Profiles.Providers.Constants.ProfilePathRegistry')
  - [ValueName](#F-MFR-Settings-Profiles-Providers-Constants-ProfilePathRegistry-ValueName 'MFR.Settings.Profiles.Providers.Constants.ProfilePathRegistry.ValueName')
- [Resources](#T-MFR-Settings-Profiles-Providers-Constants-Properties-Resources 'MFR.Settings.Profiles.Providers.Constants.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Providers-Constants-Properties-Resources-Culture 'MFR.Settings.Profiles.Providers.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Providers-Constants-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Providers.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Providers-Constants-ProfileFile'></a>
## ProfileFile `type`

##### Namespace

MFR.Settings.Profiles.Providers.Constants

<a name='F-MFR-Settings-Profiles-Providers-Constants-ProfileFile-DefaultFilename'></a>
### DefaultFilename `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the default filename to be used
for the file containing the saved collection of the user's previously-saved
configuration setting profiles, `profiles.json`..

<a name='T-MFR-Settings-Profiles-Providers-Constants-ProfilePathRegistry'></a>
## ProfilePathRegistry `type`

##### Namespace

MFR.Settings.Profiles.Providers.Constants

##### Summary

Values used to read the profile list file path from the system Registry.

##### Remarks

The profile list file contains user settings that control how the
application runs.



TRhe profile list file is in JSON format.



Configuration files are intended to be stored on a per user basis.

<a name='F-MFR-Settings-Profiles-Providers-Constants-ProfilePathRegistry-ValueName'></a>
### ValueName `constants`

##### Summary

Gets the name of the Registry value that holds the path to the
profile list file.

<a name='T-MFR-Settings-Profiles-Providers-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Providers.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Providers-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Providers-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
