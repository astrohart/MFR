<a name='assembly'></a>
# MFR.Profiles.Providers

## Contents

- [ProfileProvider](#T-MFR-Profiles-Providers-ProfileProvider 'MFR.Profiles.Providers.ProfileProvider')
  - [#ctor()](#M-MFR-Profiles-Providers-ProfileProvider-#ctor 'MFR.Profiles.Providers.ProfileProvider.#ctor')
  - [DefaultProfileDir](#P-MFR-Profiles-Providers-ProfileProvider-DefaultProfileDir 'MFR.Profiles.Providers.ProfileProvider.DefaultProfileDir')
  - [Instance](#P-MFR-Profiles-Providers-ProfileProvider-Instance 'MFR.Profiles.Providers.ProfileProvider.Instance')
  - [ProfileListPath](#P-MFR-Profiles-Providers-ProfileProvider-ProfileListPath 'MFR.Profiles.Providers.ProfileProvider.ProfileListPath')
  - [ProfileListPathKeyName](#P-MFR-Profiles-Providers-ProfileProvider-ProfileListPathKeyName 'MFR.Profiles.Providers.ProfileProvider.ProfileListPathKeyName')
  - [ProfileListPathValueName](#P-MFR-Profiles-Providers-ProfileProvider-ProfileListPathValueName 'MFR.Profiles.Providers.ProfileProvider.ProfileListPathValueName')
  - [Profiles](#P-MFR-Profiles-Providers-ProfileProvider-Profiles 'MFR.Profiles.Providers.ProfileProvider.Profiles')
  - [#cctor()](#M-MFR-Profiles-Providers-ProfileProvider-#cctor 'MFR.Profiles.Providers.ProfileProvider.#cctor')
  - [Load(pathname)](#M-MFR-Profiles-Providers-ProfileProvider-Load-System-String- 'MFR.Profiles.Providers.ProfileProvider.Load(System.String)')
  - [Save(pathname)](#M-MFR-Profiles-Providers-ProfileProvider-Save-System-String- 'MFR.Profiles.Providers.ProfileProvider.Save(System.String)')
- [Resources](#T-MFR-Profiles-Providers-Properties-Resources 'MFR.Profiles.Providers.Properties.Resources')
  - [Culture](#P-MFR-Profiles-Providers-Properties-Resources-Culture 'MFR.Profiles.Providers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Profiles-Providers-Properties-Resources-ResourceManager 'MFR.Profiles.Providers.Properties.Resources.ResourceManager')

<a name='T-MFR-Profiles-Providers-ProfileProvider'></a>
## ProfileProvider `type`

##### Namespace

MFR.Profiles.Providers

##### Summary

Provides access to the collection of profiles for the current user.

<a name='M-MFR-Profiles-Providers-ProfileProvider-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Profiles-Providers-ProfileProvider-DefaultProfileDir'></a>
### DefaultProfileDir `property`

##### Summary

Gets the default folder for the configuration file.

##### Remarks

We store the profile configuration file, by default, in a folder
under the current user's AppData folder.

<a name='P-MFR-Profiles-Providers-ProfileProvider-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[ProfileProvider](#T-MFR-Profiles-Providers-ProfileProvider 'MFR.Profiles.Providers.ProfileProvider').

<a name='P-MFR-Profiles-Providers-ProfileProvider-ProfileListPath'></a>
### ProfileListPath `property`

##### Summary

Gets a string whose value is the pathname of the profile list file.

<a name='P-MFR-Profiles-Providers-ProfileProvider-ProfileListPathKeyName'></a>
### ProfileListPathKeyName `property`

##### Summary

Gets a string whose value is the pathname of the system Registry key
in which Profile settings are stored.

<a name='P-MFR-Profiles-Providers-ProfileProvider-ProfileListPathValueName'></a>
### ProfileListPathValueName `property`

##### Summary

Gets a string whose value is the Registry value under which we store
the path to the profile list file.

<a name='P-MFR-Profiles-Providers-ProfileProvider-Profiles'></a>
### Profiles `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProfileCollection](#T-MFR-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Profiles.Collections.Interfaces.IProfileCollection')
interface.

##### Remarks

The object to which a reference is returned by this properties
allows access to the set of profiles defined by the user.

<a name='M-MFR-Profiles-Providers-ProfileProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Profiles-Providers-ProfileProvider-Load-System-String-'></a>
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

<a name='M-MFR-Profiles-Providers-ProfileProvider-Save-System-String-'></a>
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
[ProfileListPath](#P-MFR-Profiles-Providers-Interfaces-IProfileProvider-ProfileListPath 'MFR.Profiles.Providers.Interfaces.IProfileProvider.ProfileListPath')
property. |

##### Remarks

If the
[ProfileListPath](#P-MFR-Profiles-Providers-Interfaces-IProfileProvider-ProfileListPath 'MFR.Profiles.Providers.Interfaces.IProfileProvider.ProfileListPath')
property is blank, then this method does nothing.

<a name='T-MFR-Profiles-Providers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Profiles.Providers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Profiles-Providers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Profiles-Providers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
