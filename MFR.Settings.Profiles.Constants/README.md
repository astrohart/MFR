<a name='assembly'></a>
# MFR.Settings.Profiles.Constants

## Contents

- [ProfilePathRegistry](#T-MFR-Settings-Profiles-Constants-ProfilePathRegistry 'MFR.Settings.Profiles.Constants.ProfilePathRegistry')
  - [KeyName](#F-MFR-Settings-Profiles-Constants-ProfilePathRegistry-KeyName 'MFR.Settings.Profiles.Constants.ProfilePathRegistry.KeyName')
  - [ValueName](#F-MFR-Settings-Profiles-Constants-ProfilePathRegistry-ValueName 'MFR.Settings.Profiles.Constants.ProfilePathRegistry.ValueName')
- [Resources](#T-MFR-Settings-Profiles-Constants-Properties-Resources 'MFR.Settings.Profiles.Constants.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Constants-Properties-Resources-Culture 'MFR.Settings.Profiles.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Constants-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Constants-ProfilePathRegistry'></a>
## ProfilePathRegistry `type`

##### Namespace

MFR.Settings.Profiles.Constants

##### Summary

Values used to read the profile list file path from the system Registry.

##### Remarks

The profile list file contains user settings that control how the
application runs.



TRhe profile list file is in JSON format.



Configuration files are intended to be stored on a per user basis.

<a name='F-MFR-Settings-Profiles-Constants-ProfilePathRegistry-KeyName'></a>
### KeyName `constants`

##### Summary

Gets the path to the Registry subkey that stores information about
the paths of files.

<a name='F-MFR-Settings-Profiles-Constants-ProfilePathRegistry-ValueName'></a>
### ValueName `constants`

##### Summary

Gets the name of the Registry value that holds the path to the
profile list file.

<a name='T-MFR-Settings-Profiles-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
