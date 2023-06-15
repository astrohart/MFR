<a name='assembly'></a>
# MFR.Paths.Profiles.Provider.Interfaces

## Contents

- [IProfileListPathProvider](#T-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider')
  - [ProfileCollectionFilePath](#P-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-ProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath')
  - [Load()](#M-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-Load 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.Load')
  - [Save()](#M-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-Save 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.Save')
- [Resources](#T-MFR-Paths-Profiles-Provider-Interfaces-Properties-Resources 'MFR.Paths.Profiles.Provider.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Paths-Profiles-Provider-Interfaces-Properties-Resources-Culture 'MFR.Paths.Profiles.Provider.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Paths-Profiles-Provider-Interfaces-Properties-Resources-ResourceManager 'MFR.Paths.Profiles.Provider.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider'></a>
## IProfileListPathProvider `type`

##### Namespace

MFR.Paths.Profiles.Provider.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that provides
access to the fully-qualified pathname of the list of the user's favorite
configuration-setting profiles.

<a name='P-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-ProfileCollectionFilePath'></a>
### ProfileCollectionFilePath `property`

##### Summary

Gets a string whose value is the fully-qualified pathname of the profile list
file.

##### Remarks

When this property's value is updated, the
[](#E-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-ProfileCollectionFilePathChanged 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePathChanged')
event  is raised.

<a name='M-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-Load'></a>
### Load() `method`

##### Summary

Loads the value of the
[ProfileCollectionFilePath](#P-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-ProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath')
property from the system Registry.

##### Parameters

This method has no parameters.

##### Remarks

The
[](#E-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-LoadingProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.LoadingProfileCollectionFilePath')
event is raised before this method begins its operations.  Setting the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true` on this event will prevent this method from executing
further.



If the operation of obtaining the value of the
[ProfileCollectionFilePath](#P-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-ProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath')
property from the system Registry was successful, then the
[](#E-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-ProfileCollectionFilePathLoaded 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePathLoaded')
event is raised.



Otherwise, if a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') is raised during the
processing of the operation, then this method raises the
[](#E-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-ProfileCollectionFilePathLoadFailed 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePathLoadFailed')
event.

<a name='M-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-Save'></a>
### Save() `method`

##### Summary

Saves the value of the
[ProfileCollectionFilePath](#P-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-ProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath')
property to the system Registry.

##### Parameters

This method has no parameters.

##### Remarks

The
[](#E-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-SavingProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.SavingProfileCollectionFilePath')
event is raised before this method begins its operations.  Setting the
[Cancel](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs.Cancel 'System.ComponentModel.CancelEventArgs.Cancel') property to
`true` on this event will prevent this method from executing
further.



If the operation of storing the value of the
[ProfileCollectionFilePath](#P-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-ProfileCollectionFilePath 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath')
property to the system Registry was successful, then the
[](#E-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-ProfileCollectionFilePathSaved 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePathSaved')
event is raised.



Otherwise, if a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') is raised during the
processing of the operation, then this method raises the
[](#E-MFR-Paths-Profiles-Provider-Interfaces-IProfileListPathProvider-ProfileCollectionFilePathSaveFailed 'MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePathSaveFailed')
event.

<a name='T-MFR-Paths-Profiles-Provider-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Paths.Profiles.Provider.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Paths-Profiles-Provider-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Paths-Profiles-Provider-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
