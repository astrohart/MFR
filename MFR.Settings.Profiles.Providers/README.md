<a name='assembly'></a>
# MFR.Settings.Profiles.Providers

## Contents

- [ProfileProvider](#T-MFR-Settings-Profiles-Providers-ProfileProvider 'MFR.Settings.Profiles.Providers.ProfileProvider')
  - [#ctor()](#M-MFR-Settings-Profiles-Providers-ProfileProvider-#ctor 'MFR.Settings.Profiles.Providers.ProfileProvider.#ctor')
  - [DefaultProfileListDir](#P-MFR-Settings-Profiles-Providers-ProfileProvider-DefaultProfileListDir 'MFR.Settings.Profiles.Providers.ProfileProvider.DefaultProfileListDir')
  - [DefaultProfileListPath](#P-MFR-Settings-Profiles-Providers-ProfileProvider-DefaultProfileListPath 'MFR.Settings.Profiles.Providers.ProfileProvider.DefaultProfileListPath')
  - [Instance](#P-MFR-Settings-Profiles-Providers-ProfileProvider-Instance 'MFR.Settings.Profiles.Providers.ProfileProvider.Instance')
  - [ProfileCollection](#P-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileCollection 'MFR.Settings.Profiles.Providers.ProfileProvider.ProfileCollection')
  - [ProfileListFilePath](#P-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileListFilePath 'MFR.Settings.Profiles.Providers.ProfileProvider.ProfileListFilePath')
  - [ProfileListPathKeyName](#P-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileListPathKeyName 'MFR.Settings.Profiles.Providers.ProfileProvider.ProfileListPathKeyName')
  - [ProfileListPathValueName](#P-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileListPathValueName 'MFR.Settings.Profiles.Providers.ProfileProvider.ProfileListPathValueName')
  - [#cctor()](#M-MFR-Settings-Profiles-Providers-ProfileProvider-#cctor 'MFR.Settings.Profiles.Providers.ProfileProvider.#cctor')
  - [Load(pathname)](#M-MFR-Settings-Profiles-Providers-ProfileProvider-Load-System-String- 'MFR.Settings.Profiles.Providers.ProfileProvider.Load(System.String)')
  - [Save(pathname)](#M-MFR-Settings-Profiles-Providers-ProfileProvider-Save-System-String- 'MFR.Settings.Profiles.Providers.ProfileProvider.Save(System.String)')
- [Resources](#T-MFR-Settings-Profiles-Providers-Properties-Resources 'MFR.Settings.Profiles.Providers.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Providers-Properties-Resources-Culture 'MFR.Settings.Profiles.Providers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Providers-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Providers.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Providers-ProfileProvider'></a>
## ProfileProvider `type`

##### Namespace

MFR.Settings.Profiles.Providers

##### Summary

Provides access to the collection of profiles for the current user.

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Profiles-Providers-ProfileProvider-DefaultProfileListDir'></a>
### DefaultProfileListDir `property`

##### Summary

Gets the default folder for the profile list file.

##### Remarks

We store the profile list file, by default, in a folder
under the current user's AppData folder.

<a name='P-MFR-Settings-Profiles-Providers-ProfileProvider-DefaultProfileListPath'></a>
### DefaultProfileListPath `property`

##### Summary

Gets the default filename for the profile list file.

<a name='P-MFR-Settings-Profiles-Providers-ProfileProvider-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[ProfileProvider](#T-MFR-Settings-Profiles-Providers-ProfileProvider 'MFR.Settings.Profiles.Providers.ProfileProvider').

<a name='P-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileCollection'></a>
### ProfileCollection `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface.

##### Remarks

The object to which a reference is returned by this properties
allows access to the set of profiles defined by the user.

<a name='P-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileListFilePath'></a>
### ProfileListFilePath `property`

##### Summary

Gets a string whose value is the pathname of the profile list file.

<a name='P-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileListPathKeyName'></a>
### ProfileListPathKeyName `property`

##### Summary

Gets a string whose value is the pathname of the system Registry key
in which Profile settings are stored.

<a name='P-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileListPathValueName'></a>
### ProfileListPathValueName `property`

##### Summary

Gets a string whose value is the Registry value under which we store
the path to the profile list file.

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads the profiles from the profile list file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname of the file from which to
load the profiles. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the file whose pathname is passed in the
`pathname`
parameter cannot be found on the disk. |

##### Remarks

The file whose pathname is passed must not be the actual
configuration file, but a separate file.

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-Save-System-String-'></a>
### Save(pathname) `method`

##### Summary

Saves profile list data to a file on the disk having path
`pathname`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the path to where the data should be
saved in JSON format.



If this parameter is blank, then the data is saved to the path that
is stored in the
[ProfileListFilePath](#P-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-ProfileListFilePath 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileListFilePath')
property. |

##### Remarks

If the
[ProfileListFilePath](#P-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-ProfileListFilePath 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileListFilePath')
property is blank, then this method does nothing.

<a name='T-MFR-Settings-Profiles-Providers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Providers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Providers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Providers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
