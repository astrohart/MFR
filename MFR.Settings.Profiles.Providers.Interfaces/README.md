<a name='assembly'></a>
# MFR.Settings.Profiles.Providers.Interfaces

## Contents

- [IProfileProvider](#T-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider')
  - [ProfileCollectionFilePath](#P-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-ProfileCollectionFilePath 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePath')
  - [Profiles](#P-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-Profiles 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.Profiles')
  - [Load(pathname)](#M-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-Load-System-String- 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.Load(System.String)')
  - [Save(pathname)](#M-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-Save-System-String- 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.Save(System.String)')
- [Resources](#T-MFR-Settings-Profiles-Providers-Interfaces-Properties-Resources 'MFR.Settings.Profiles.Providers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Providers-Interfaces-Properties-Resources-Culture 'MFR.Settings.Profiles.Providers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Providers-Interfaces-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Providers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider'></a>
## IProfileProvider `type`

##### Namespace

MFR.Settings.Profiles.Providers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a
` ProfileProvider` object.

##### Remarks

A `ProfileProvider` object maintains a collection of the saved
configuration setting profiles defined by the user.

<a name='P-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-ProfileCollectionFilePath'></a>
### ProfileCollectionFilePath `property`

##### Summary

Gets a string whose value is the fully-qualified pathname of the profile list
file.

##### Remarks

This property raises the
[](#E-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-ProfileCollectionFilePathChanged 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePathChanged')
event if its value is updated.

<a name='P-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-Profiles'></a>
### Profiles `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface.

##### Remarks

The object to which a reference is returned by this properties
allows access to the set of profiles defined by the user.



If this property is read prior to any profiles being loaded, it
should return a reference the empty collection.

<a name='M-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-Load-System-String-'></a>
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

<a name='M-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-Save-System-String-'></a>
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
[ProfileCollectionFilePath](#P-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-ProfileCollectionFilePath 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePath')
property. |

##### Remarks

If the
[ProfileCollectionFilePath](#P-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-ProfileCollectionFilePath 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePath')
property is blank, then this method does nothing.

<a name='T-MFR-Settings-Profiles-Providers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Providers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Providers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Providers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
