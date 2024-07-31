<a name='assembly'></a>
# MFR.Settings.Profiles.Providers

## Contents

- [ProfileProvider](#T-MFR-Settings-Profiles-Providers-ProfileProvider 'MFR.Settings.Profiles.Providers.ProfileProvider')
  - [#ctor()](#M-MFR-Settings-Profiles-Providers-ProfileProvider-#ctor 'MFR.Settings.Profiles.Providers.ProfileProvider.#ctor')
  - [Instance](#P-MFR-Settings-Profiles-Providers-ProfileProvider-Instance 'MFR.Settings.Profiles.Providers.ProfileProvider.Instance')
  - [ProfileCollectionFilePath](#P-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileCollectionFilePath 'MFR.Settings.Profiles.Providers.ProfileProvider.ProfileCollectionFilePath')
  - [ProfileListPathProvider](#P-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileListPathProvider 'MFR.Settings.Profiles.Providers.ProfileProvider.ProfileListPathProvider')
  - [Profiles](#P-MFR-Settings-Profiles-Providers-ProfileProvider-Profiles 'MFR.Settings.Profiles.Providers.ProfileProvider.Profiles')
  - [#cctor()](#M-MFR-Settings-Profiles-Providers-ProfileProvider-#cctor 'MFR.Settings.Profiles.Providers.ProfileProvider.#cctor')
  - [InitializeProfileListPathProvider()](#M-MFR-Settings-Profiles-Providers-ProfileProvider-InitializeProfileListPathProvider 'MFR.Settings.Profiles.Providers.ProfileProvider.InitializeProfileListPathProvider')
  - [Load()](#M-MFR-Settings-Profiles-Providers-ProfileProvider-Load 'MFR.Settings.Profiles.Providers.ProfileProvider.Load')
  - [OnLoadingProfiles(e)](#M-MFR-Settings-Profiles-Providers-ProfileProvider-OnLoadingProfiles-System-ComponentModel-CancelEventArgs- 'MFR.Settings.Profiles.Providers.ProfileProvider.OnLoadingProfiles(System.ComponentModel.CancelEventArgs)')
  - [OnProfileCollectionFilePathChanged(sender,e)](#M-MFR-Settings-Profiles-Providers-ProfileProvider-OnProfileCollectionFilePathChanged-System-Object,System-EventArgs- 'MFR.Settings.Profiles.Providers.ProfileProvider.OnProfileCollectionFilePathChanged(System.Object,System.EventArgs)')
  - [OnProfileLoadFailed(e)](#M-MFR-Settings-Profiles-Providers-ProfileProvider-OnProfileLoadFailed-MFR-Events-Common-ExceptionRaisedEventArgs- 'MFR.Settings.Profiles.Providers.ProfileProvider.OnProfileLoadFailed(MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnProfileSaveFailed(e)](#M-MFR-Settings-Profiles-Providers-ProfileProvider-OnProfileSaveFailed-MFR-Events-Common-ExceptionRaisedEventArgs- 'MFR.Settings.Profiles.Providers.ProfileProvider.OnProfileSaveFailed(MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnProfilesLoaded()](#M-MFR-Settings-Profiles-Providers-ProfileProvider-OnProfilesLoaded 'MFR.Settings.Profiles.Providers.ProfileProvider.OnProfilesLoaded')
  - [OnProfilesSaved()](#M-MFR-Settings-Profiles-Providers-ProfileProvider-OnProfilesSaved 'MFR.Settings.Profiles.Providers.ProfileProvider.OnProfilesSaved')
  - [OnSavingProfiles(e)](#M-MFR-Settings-Profiles-Providers-ProfileProvider-OnSavingProfiles-System-ComponentModel-CancelEventArgs- 'MFR.Settings.Profiles.Providers.ProfileProvider.OnSavingProfiles(System.ComponentModel.CancelEventArgs)')
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

<a name='P-MFR-Settings-Profiles-Providers-ProfileProvider-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IProfileProvider](#T-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider')
interface.

<a name='P-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileCollectionFilePath'></a>
### ProfileCollectionFilePath `property`

##### Summary

Gets or sets the fully-qualified pathname of the `profiles.json` file.

<a name='P-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileListPathProvider'></a>
### ProfileListPathProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProfileListPathProvider](#T-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider')
interface.

<a name='P-MFR-Settings-Profiles-Providers-ProfileProvider-Profiles'></a>
### Profiles `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface.

##### Remarks

The object to which a reference is returned by this properties
allows access to the set of profiles defined by the user.

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-InitializeProfileListPathProvider'></a>
### InitializeProfileListPathProvider() `method`

##### Summary

Configures settings on the object reference that we retain as a dependency,
that implements the
[IProfileListPathProvider](#T-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-Load'></a>
### Load() `method`

##### Summary

Loads the profiles from the profile list file.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-OnLoadingProfiles-System-ComponentModel-CancelEventArgs-'></a>
### OnLoadingProfiles(e) `method`

##### Summary

Raises the
[](#E-MFR-Settings-Profiles-Providers-ProfileProvider-LoadingProfiles 'MFR.Settings.Profiles.Providers.ProfileProvider.LoadingProfiles')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.ComponentModel.CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') | A [CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') that
allows us to cancel the operation that this event is notifying the caller of.



To cancel the operation, handlers should set the value of the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true`. |

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-OnProfileCollectionFilePathChanged-System-Object,System-EventArgs-'></a>
### OnProfileCollectionFilePathChanged(sender,e) `method`

##### Summary

Raises the
[](#E-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileCollectionFilePathChanged 'MFR.Settings.Profiles.Providers.ProfileProvider.ProfileCollectionFilePathChanged')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to the sender of this event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | (Required.) A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains
the event data. |

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-OnProfileLoadFailed-MFR-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnProfileLoadFailed(e) `method`

##### Summary

Raises the
[](#E-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileLoadFailed 'MFR.Settings.Profiles.Providers.ProfileProvider.ProfileLoadFailed')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.Common.ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs') | A [ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs')
that contains the event data. |

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-OnProfileSaveFailed-MFR-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnProfileSaveFailed(e) `method`

##### Summary

Raises the
[](#E-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileSaveFailed 'MFR.Settings.Profiles.Providers.ProfileProvider.ProfileSaveFailed')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.Common.ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs') | A [ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs')
that contains the event data. |

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-OnProfilesLoaded'></a>
### OnProfilesLoaded() `method`

##### Summary

Raises the
[](#E-MFR-Settings-Profiles-Providers-ProfileProvider-ProfilesLoaded 'MFR.Settings.Profiles.Providers.ProfileProvider.ProfilesLoaded')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-OnProfilesSaved'></a>
### OnProfilesSaved() `method`

##### Summary

Raises the
[](#E-MFR-Settings-Profiles-Providers-ProfileProvider-ProfilesSaved 'MFR.Settings.Profiles.Providers.ProfileProvider.ProfilesSaved')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-OnSavingProfiles-System-ComponentModel-CancelEventArgs-'></a>
### OnSavingProfiles(e) `method`

##### Summary

Raises the
[](#E-MFR-Settings-Profiles-Providers-ProfileProvider-SavingProfiles 'MFR.Settings.Profiles.Providers.ProfileProvider.SavingProfiles')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.ComponentModel.CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') | A [CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') that
allows us to cancel the operation that this event is notifying the caller of.



To cancel the operation, handlers should set the value of the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true`. |

<a name='M-MFR-Settings-Profiles-Providers-ProfileProvider-Save-System-String-'></a>
### Save(pathname) `method`

##### Summary

Saves profile list data to a file on the file system having path
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
