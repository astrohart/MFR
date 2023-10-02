<a name='assembly'></a>
# MFR.Paths.Profiles.Provider

## Contents

- [ProfileListPathProvider](#T-MFR-Paths-Profiles-Provider-ProfileListPathProvider 'MFR.Paths.Profiles.Provider.ProfileListPathProvider')
  - [#ctor()](#M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-#ctor 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.#ctor')
  - [_profileCollectionFilePath](#F-MFR-Paths-Profiles-Provider-ProfileListPathProvider-_profileCollectionFilePath 'MFR.Paths.Profiles.Provider.ProfileListPathProvider._profileCollectionFilePath')
  - [Instance](#P-MFR-Paths-Profiles-Provider-ProfileListPathProvider-Instance 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.Instance')
  - [ProfileCollectionFilePath](#P-MFR-Paths-Profiles-Provider-ProfileListPathProvider-ProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePath')
  - [#cctor()](#M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-#cctor 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.#cctor')
  - [Load()](#M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-Load 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.Load')
  - [OnLoadingProfileCollectionFilePath(e)](#M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-OnLoadingProfileCollectionFilePath-System-ComponentModel-CancelEventArgs- 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.OnLoadingProfileCollectionFilePath(System.ComponentModel.CancelEventArgs)')
  - [OnProfileCollectListPathSaveFailed(e)](#M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-OnProfileCollectListPathSaveFailed-MFR-Events-Common-ExceptionRaisedEventArgs- 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.OnProfileCollectListPathSaveFailed(MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnProfileCollectionFilePathChanged()](#M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-OnProfileCollectionFilePathChanged 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.OnProfileCollectionFilePathChanged')
  - [OnProfileCollectionFilePathLoadFailed(e)](#M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-OnProfileCollectionFilePathLoadFailed-MFR-Events-Common-ExceptionRaisedEventArgs- 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.OnProfileCollectionFilePathLoadFailed(MFR.Events.Common.ExceptionRaisedEventArgs)')
  - [OnProfileCollectionFilePathLoaded()](#M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-OnProfileCollectionFilePathLoaded 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.OnProfileCollectionFilePathLoaded')
  - [OnProfileCollectionFilePathSaved()](#M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-OnProfileCollectionFilePathSaved 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.OnProfileCollectionFilePathSaved')
  - [OnSavingProfileCollectionFilePath(e)](#M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-OnSavingProfileCollectionFilePath-System-ComponentModel-CancelEventArgs- 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.OnSavingProfileCollectionFilePath(System.ComponentModel.CancelEventArgs)')
  - [Save()](#M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-Save 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.Save')
- [Resources](#T-MFR-Paths-Profiles-Provider-Properties-Resources 'MFR.Paths.Profiles.Provider.Properties.Resources')
  - [Culture](#P-MFR-Paths-Profiles-Provider-Properties-Resources-Culture 'MFR.Paths.Profiles.Provider.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Paths-Profiles-Provider-Properties-Resources-ResourceManager 'MFR.Paths.Profiles.Provider.Properties.Resources.ResourceManager')

<a name='T-MFR-Paths-Profiles-Provider-ProfileListPathProvider'></a>
## ProfileListPathProvider `type`

##### Namespace

MFR.Paths.Profiles.Provider

##### Summary

Manages the loading and the storing of the pathname of the `profiles.json`
file to/from the system Registry.

<a name='M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Paths-Profiles-Provider-ProfileListPathProvider-_profileCollectionFilePath'></a>
### _profileCollectionFilePath `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that holds the path the JSON file that stores
profiles.

<a name='P-MFR-Paths-Profiles-Provider-ProfileListPathProvider-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IProfileListPathProvider](#T-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider')
interface.

<a name='P-MFR-Paths-Profiles-Provider-ProfileListPathProvider-ProfileCollectionFilePath'></a>
### ProfileCollectionFilePath `property`

##### Summary

Gets a string whose value is the fully-qualified pathname of the profile list
file.

##### Remarks

When this property's value is updated, the
[](#E-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileCollectionFilePathChanged 'MFR.Settings.Profiles.Providers.ProfileProvider.ProfileCollectionFilePathChanged')
event  is raised.

<a name='M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-Load'></a>
### Load() `method`

##### Summary

Loads the value of the
[ProfileCollectionFilePath](#P-MFR-Paths-Profiles-Provider-ProfileListPathProvider-ProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePath')
property from the system Registry.

##### Parameters

This method has no parameters.

##### Remarks

The
[](#E-MFR-Paths-Profiles-Provider-ProfileListPathProvider-LoadingProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.LoadingProfileCollectionFilePath')
event is raised before this method begins its operations.  Setting the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true` on this event will prevent this method from executing
further.



If the operation of obtaining the value of the
[ProfileCollectionFilePath](#P-MFR-Paths-Profiles-Provider-ProfileListPathProvider-ProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePath')
property from the system Registry was successful, then the
[](#E-MFR-Paths-Profiles-Provider-ProfileListPathProvider-ProfileCollectionFilePathLoaded 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathLoaded')
event is raised.



Otherwise, if a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') is raised during the
processing of the operation, then this method raises the
[](#E-MFR-Paths-Profiles-Provider-ProfileListPathProvider-ProfileCollectionFilePathLoadFailed 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathLoadFailed')
event.

<a name='M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-OnLoadingProfileCollectionFilePath-System-ComponentModel-CancelEventArgs-'></a>
### OnLoadingProfileCollectionFilePath(e) `method`

##### Summary

Raises the
[](#E-MFR-Paths-Profiles-Provider-ProfileListPathProvider-LoadingProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.LoadingProfileCollectionFilePath')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.ComponentModel.CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') | A [CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') that
allows us to cancel the operation that this event is notifying the caller of.



To cancel the operation, handlers should set the value of the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true`. |

<a name='M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-OnProfileCollectListPathSaveFailed-MFR-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnProfileCollectListPathSaveFailed(e) `method`

##### Summary

Raises the
[](#E-MFR-Paths-Profiles-Provider-ProfileListPathProvider-ProfileCollectionFilePathSaveFailed 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathSaveFailed')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.Common.ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs') | A [ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs')
that contains the event data. |

<a name='M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-OnProfileCollectionFilePathChanged'></a>
### OnProfileCollectionFilePathChanged() `method`

##### Summary

Raises the
[](#E-MFR-Settings-Profiles-Providers-ProfileProvider-ProfileCollectionFilePathChanged 'MFR.Settings.Profiles.Providers.ProfileProvider.ProfileCollectionFilePathChanged')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-OnProfileCollectionFilePathLoadFailed-MFR-Events-Common-ExceptionRaisedEventArgs-'></a>
### OnProfileCollectionFilePathLoadFailed(e) `method`

##### Summary

Raises the
[](#E-MFR-Paths-Profiles-Provider-ProfileListPathProvider-ProfileCollectionFilePathLoadFailed 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathLoadFailed')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [MFR.Events.Common.ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs') | A [ExceptionRaisedEventArgs](#T-MFR-Events-Common-ExceptionRaisedEventArgs 'MFR.Events.Common.ExceptionRaisedEventArgs')
that contains the event data. |

<a name='M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-OnProfileCollectionFilePathLoaded'></a>
### OnProfileCollectionFilePathLoaded() `method`

##### Summary

Raises the
[](#E-MFR-Paths-Profiles-Provider-ProfileListPathProvider-ProfileCollectionFilePathLoaded 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathLoaded')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-OnProfileCollectionFilePathSaved'></a>
### OnProfileCollectionFilePathSaved() `method`

##### Summary

Raises the
[](#E-MFR-Paths-Profiles-Provider-ProfileListPathProvider-ProfileCollectionFilePathSaved 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathSaved')
event.

##### Parameters

This method has no parameters.

<a name='M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-OnSavingProfileCollectionFilePath-System-ComponentModel-CancelEventArgs-'></a>
### OnSavingProfileCollectionFilePath(e) `method`

##### Summary

Raises the
[](#E-MFR-Paths-Profiles-Provider-ProfileListPathProvider-SavingProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.SavingProfileCollectionFilePath')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.ComponentModel.CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') | A [CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') that
allows us to cancel the operation that this event is notifying the caller of.



To cancel the operation, handlers should set the value of the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true`. |

<a name='M-MFR-Paths-Profiles-Provider-ProfileListPathProvider-Save'></a>
### Save() `method`

##### Summary

Saves the value of the
[ProfileCollectionFilePath](#P-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-ProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath')
property to the system Registry.

##### Parameters

This method has no parameters.

##### Remarks

The
[](#E-MFR-Paths-Profiles-Provider-ProfileListPathProvider-SavingProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.SavingProfileCollectionFilePath')
event is raised before this method begins its operations.  Setting the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true` on this event will prevent this method from executing
further.



If the operation of storing the value of the
[ProfileCollectionFilePath](#P-MFR-Paths-Profiles-Provider-ProfileListPathProvider-ProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePath')
property to the system Registry was successful, then the
[](#E-MFR-Paths-Profiles-Provider-ProfileListPathProvider-ProfileCollectionFilePathSaved 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathSaved')
event is raised.



Otherwise, if a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') is raised during the
processing of the operation, then this method raises the
[](#E-MFR-Paths-Profiles-Provider-ProfileListPathProvider-ProfileCollectionFilePathSaveFailed 'MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathSaveFailed')
event.

<a name='T-MFR-Paths-Profiles-Provider-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Paths.Profiles.Provider.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Paths-Profiles-Provider-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Paths-Profiles-Provider-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
