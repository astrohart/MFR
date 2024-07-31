<a name='assembly'></a>
# MFR.Settings.Profiles.Providers.Actions

## Contents

- [Determine](#T-MFR-Settings-Profiles-Providers-Actions-Determine 'MFR.Settings.Profiles.Providers.Actions.Determine')
  - [CorrectProfileListPathForSaving(pathnameFromRegistry,submittedPathname)](#M-MFR-Settings-Profiles-Providers-Actions-Determine-CorrectProfileListPathForSaving-System-String,System-String- 'MFR.Settings.Profiles.Providers.Actions.Determine.CorrectProfileListPathForSaving(System.String,System.String)')
  - [IsProfileListPathValidForSaving(pathname)](#M-MFR-Settings-Profiles-Providers-Actions-Determine-IsProfileListPathValidForSaving-System-String- 'MFR.Settings.Profiles.Providers.Actions.Determine.IsProfileListPathValidForSaving(System.String)')
  - [WhetherProfileListPathIsValid(pathname)](#M-MFR-Settings-Profiles-Providers-Actions-Determine-WhetherProfileListPathIsValid-System-String- 'MFR.Settings.Profiles.Providers.Actions.Determine.WhetherProfileListPathIsValid(System.String)')
- [Execute](#T-MFR-Settings-Profiles-Providers-Actions-Execute 'MFR.Settings.Profiles.Providers.Actions.Execute')
  - [OperationToLoadProfileCollectionFromFile(action)](#M-MFR-Settings-Profiles-Providers-Actions-Execute-OperationToLoadProfileCollectionFromFile-MFR-Messages-Actions-Interfaces-IAction{MFR-FileSystem-Interfaces-IFileSystemEntry,MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection}- 'MFR.Settings.Profiles.Providers.Actions.Execute.OperationToLoadProfileCollectionFromFile(MFR.Messages.Actions.Interfaces.IAction{MFR.FileSystem.Interfaces.IFileSystemEntry,MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection})')
- [Generate](#T-MFR-Settings-Profiles-Providers-Actions-Generate 'MFR.Settings.Profiles.Providers.Actions.Generate')
  - [FileSystemEntryForProfileCollection(pathname)](#M-MFR-Settings-Profiles-Providers-Actions-Generate-FileSystemEntryForProfileCollection-System-String- 'MFR.Settings.Profiles.Providers.Actions.Generate.FileSystemEntryForProfileCollection(System.String)')
  - [LoadProfileCollectionFromFileAction(entry)](#M-MFR-Settings-Profiles-Providers-Actions-Generate-LoadProfileCollectionFromFileAction-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Settings.Profiles.Providers.Actions.Generate.LoadProfileCollectionFromFileAction(MFR.FileSystem.Interfaces.IFileSystemEntry)')
- [Obtain](#T-MFR-Settings-Profiles-Providers-Actions-Obtain 'MFR.Settings.Profiles.Providers.Actions.Obtain')
  - [ProfileCollectionFromFile(pathname)](#M-MFR-Settings-Profiles-Providers-Actions-Obtain-ProfileCollectionFromFile-System-String- 'MFR.Settings.Profiles.Providers.Actions.Obtain.ProfileCollectionFromFile(System.String)')
- [Remove](#T-MFR-Settings-Profiles-Providers-Actions-Remove 'MFR.Settings.Profiles.Providers.Actions.Remove')
  - [TemporaryProfiles(collection)](#M-MFR-Settings-Profiles-Providers-Actions-Remove-TemporaryProfiles-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection- 'MFR.Settings.Profiles.Providers.Actions.Remove.TemporaryProfiles(MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection)')
- [Resources](#T-MFR-Settings-Profiles-Providers-Actions-Properties-Resources 'MFR.Settings.Profiles.Providers.Actions.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Providers-Actions-Properties-Resources-Culture 'MFR.Settings.Profiles.Providers.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Providers-Actions-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Providers.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Providers-Actions-Determine'></a>
## Determine `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions

##### Summary

Exposes static methods to determine whether facts are true or false about data.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Determine-CorrectProfileListPathForSaving-System-String,System-String-'></a>
### CorrectProfileListPathForSaving(pathnameFromRegistry,submittedPathname) `method`

##### Summary

Determines whether a user-submitted path, or the pathname stored in the system
Registry, is the correct pathname to be utilized for saving out
config-setting profiles to the file system with.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the correct pathname to be
utilized for the `Save` operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathnameFromRegistry | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
that represents the profile list file pathname that is currently stored in the
system Registry. |
| submittedPathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
containing user-submitted pathname for saving the profiles. |

##### Remarks

The `pathnameFromRegistry` takes precedence.



Neither the `submittedPathname` nor the
`pathnameFromRegistry` have to represent a file that exists
on the file system, since, if this the case, the file will be created by the Save
operation.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Determine-IsProfileListPathValidForSaving-System-String-'></a>
### IsProfileListPathValidForSaving(pathname) `method`

##### Summary

Returns a value that indicates whether the specified
`pathname` is valid for use in saving the user's favorite
config-setting profiles out to the file system.

##### Returns

`true` if the specified `pathname`
is valid for saving; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname that is to be checked. |

##### Remarks

A particular value of the `pathname` is valid for
saving if the specified value is non-blank and has a filename of
`profiles.json`.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Determine-WhetherProfileListPathIsValid-System-String-'></a>
### WhetherProfileListPathIsValid(pathname) `method`

##### Summary

Determines whether the specified `pathname` of a
`profiles.json` file is valid.

##### Returns

`true` if the specified `pathname`
meets the validation criteria; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file to be checked. |

##### Remarks

In order to be valid, the specified `pathname` must
not be blank, must contain the fully-qualified pathname of a file that exists
on the file system; and the filename of the file must be `profiles.json`.

<a name='T-MFR-Settings-Profiles-Providers-Actions-Execute'></a>
## Execute `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions

##### Summary

Exposes static methods to execute operations.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Execute-OperationToLoadProfileCollectionFromFile-MFR-Messages-Actions-Interfaces-IAction{MFR-FileSystem-Interfaces-IFileSystemEntry,MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection}-'></a>
### OperationToLoadProfileCollectionFromFile(action) `method`

##### Summary

Attempts to execute the operation of loading a new
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
from a file on the file system.

##### Returns

If successful, a reference to an instance of an object that implements
the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface containing the loaded profiles, or the empty collection if the
operation could not be executed, or if no profiles are listed in the file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [MFR.Messages.Actions.Interfaces.IAction{MFR.FileSystem.Interfaces.IFileSystemEntry,MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection}](#T-MFR-Messages-Actions-Interfaces-IAction{MFR-FileSystem-Interfaces-IFileSystemEntry,MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection} 'MFR.Messages.Actions.Interfaces.IAction{MFR.FileSystem.Interfaces.IFileSystemEntry,MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection}') | (Required.) Reference to an `Action` object that,
when executed, loads the collection of the user's profiles from a file on the
disk. |

<a name='T-MFR-Settings-Profiles-Providers-Actions-Generate'></a>
## Generate `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions

##### Summary

Exposes static methods to generate references to data.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Generate-FileSystemEntryForProfileCollection-System-String-'></a>
### FileSystemEntryForProfileCollection(pathname) `method`

##### Summary

Generates a reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface, given
the specified `pathname` of a `profiles.json` file.

##### Returns

If the `pathname` refers to a `profiles.json`
file that exists on the file system, then a new reference to an instance of an object
that implements the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface is returned; `null` is returned otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a `profiles.json` file. |

<a name='M-MFR-Settings-Profiles-Providers-Actions-Generate-LoadProfileCollectionFromFileAction-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### LoadProfileCollectionFromFileAction(entry) `method`

##### Summary

Generates a reference to an instance of an `Action` object that is
responsible for executing the operation of loading the user's
config-setting profiles from the file system.

##### Returns

If successful, a reference to an instance of an `Action` object
that is responsible for executing the operation of loading the user's
config-setting profiles from the file system; `null`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that
implements the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface that refers to the `profiles.json` file from which profiles are
to be loaded. |

<a name='T-MFR-Settings-Profiles-Providers-Actions-Obtain'></a>
## Obtain `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions

##### Summary

Exposes static methods to load profiles from the file system.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Obtain-ProfileCollectionFromFile-System-String-'></a>
### ProfileCollectionFromFile(pathname) `method`

##### Summary

Attempts to obtain a reference to an instance of an object that implements the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface that contains the user's config-setting profiles.

##### Returns

If successful, a reference to an instance of an object that implements
the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface that contains the user's config-setting profiles; otherwise,
the empty collection is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a `profiles.json` file on the file system from which profiles are to
be loaded. |

<a name='T-MFR-Settings-Profiles-Providers-Actions-Remove'></a>
## Remove `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions

##### Summary

Exposes static methods for removing items from collections and lists.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Remove-TemporaryProfiles-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection-'></a>
### TemporaryProfiles(collection) `method`

##### Summary

Removes all temporary profiles from the specified
`collection`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection') | (Required.) Reference to an instance of an object that implements the
[IProfileCollection](#T-MFR-Settings-Profiles-Collections-Interfaces-IProfileCollection 'MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection')
interface that represents the collection of profiles from which temporary
profiles are to be removed. |

##### Remarks

A temporary profile is defined to be one whose name begins with
`tmp`.



If the specified `collection` is `null` or
does not contain any elements, then this method does nothing.

<a name='T-MFR-Settings-Profiles-Providers-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Providers-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Providers-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
