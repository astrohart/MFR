<a name='assembly'></a>
# MFR.Settings.Profiles.Commands

## Contents

- [Resources](#T-MFR-Settings-Profiles-Commands-Properties-Resources 'MFR.Settings.Profiles.Commands.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Commands-Properties-Resources-Culture 'MFR.Settings.Profiles.Commands.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Commands-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Commands.Properties.Resources.ResourceManager')
- [SaveProfileCollectionToFileCommand](#T-MFR-Settings-Profiles-Commands-SaveProfileCollectionToFileCommand 'MFR.Settings.Profiles.Commands.SaveProfileCollectionToFileCommand')
  - [#ctor()](#M-MFR-Settings-Profiles-Commands-SaveProfileCollectionToFileCommand-#ctor 'MFR.Settings.Profiles.Commands.SaveProfileCollectionToFileCommand.#ctor')
  - [Instance](#P-MFR-Settings-Profiles-Commands-SaveProfileCollectionToFileCommand-Instance 'MFR.Settings.Profiles.Commands.SaveProfileCollectionToFileCommand.Instance')
  - [MessageType](#P-MFR-Settings-Profiles-Commands-SaveProfileCollectionToFileCommand-MessageType 'MFR.Settings.Profiles.Commands.SaveProfileCollectionToFileCommand.MessageType')
  - [#cctor()](#M-MFR-Settings-Profiles-Commands-SaveProfileCollectionToFileCommand-#cctor 'MFR.Settings.Profiles.Commands.SaveProfileCollectionToFileCommand.#cctor')
  - [CommonExecute()](#M-MFR-Settings-Profiles-Commands-SaveProfileCollectionToFileCommand-CommonExecute 'MFR.Settings.Profiles.Commands.SaveProfileCollectionToFileCommand.CommonExecute')

<a name='T-MFR-Settings-Profiles-Commands-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Commands.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Commands-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Commands-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Settings-Profiles-Commands-SaveProfileCollectionToFileCommand'></a>
## SaveProfileCollectionToFileCommand `type`

##### Namespace

MFR.Settings.Profiles.Commands

##### Summary

Saves a profile list object, i.e., one that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile')
interface, to a JSON file.

##### Remarks

This command takes a reference to an instance of an object that
implements the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface as input, and does not return any output.



This command requires that the
[Path](#P-MFR-IFileSystemEntry-Path 'MFR.IFileSystemEntry.Path')
property be
initialized to the pathname where the profile list data should be
saved; preferably, the file should have the .json extension.



This command also requires that the
[UserState](#P-MFR-IFileSystemEntry-UserState 'MFR.IFileSystemEntry.UserState')
property
be initialized to a reference to the profile list object containing the
data that is to be saved.

<a name='M-MFR-Settings-Profiles-Commands-SaveProfileCollectionToFileCommand-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Profiles-Commands-SaveProfileCollectionToFileCommand-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[SavePathToRegistryAction](#T-MFR-SavePathToRegistryAction 'MFR.SavePathToRegistryAction')
.

<a name='P-MFR-Settings-Profiles-Commands-SaveProfileCollectionToFileCommand-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-MessageType 'MFR.MessageType') that is
being used to identify which message this.

<a name='M-MFR-Settings-Profiles-Commands-SaveProfileCollectionToFileCommand-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Commands-SaveProfileCollectionToFileCommand-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

##### Remarks

Implementers must override this method in order to return this
object's functionality.



This method is to stop executing, without throwing any exceptions,
if the input is `null`.
