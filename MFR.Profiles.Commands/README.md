<a name='assembly'></a>
# MFR.Profiles.Commands

## Contents

- [Resources](#T-MFR-Profiles-Commands-Properties-Resources 'MFR.Profiles.Commands.Properties.Resources')
  - [Culture](#P-MFR-Profiles-Commands-Properties-Resources-Culture 'MFR.Profiles.Commands.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Profiles-Commands-Properties-Resources-ResourceManager 'MFR.Profiles.Commands.Properties.Resources.ResourceManager')
- [SaveProfileListToFileCommand](#T-MFR-Profiles-Commands-SaveProfileListToFileCommand 'MFR.Profiles.Commands.SaveProfileListToFileCommand')
  - [#ctor()](#M-MFR-Profiles-Commands-SaveProfileListToFileCommand-#ctor 'MFR.Profiles.Commands.SaveProfileListToFileCommand.#ctor')
  - [Instance](#P-MFR-Profiles-Commands-SaveProfileListToFileCommand-Instance 'MFR.Profiles.Commands.SaveProfileListToFileCommand.Instance')
  - [MessageType](#P-MFR-Profiles-Commands-SaveProfileListToFileCommand-MessageType 'MFR.Profiles.Commands.SaveProfileListToFileCommand.MessageType')
  - [#cctor()](#M-MFR-Profiles-Commands-SaveProfileListToFileCommand-#cctor 'MFR.Profiles.Commands.SaveProfileListToFileCommand.#cctor')
  - [CommonExecute()](#M-MFR-Profiles-Commands-SaveProfileListToFileCommand-CommonExecute 'MFR.Profiles.Commands.SaveProfileListToFileCommand.CommonExecute')

<a name='T-MFR-Profiles-Commands-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Profiles.Commands.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Profiles-Commands-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Profiles-Commands-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Profiles-Commands-SaveProfileListToFileCommand'></a>
## SaveProfileListToFileCommand `type`

##### Namespace

MFR.Profiles.Commands

##### Summary

Saves a profile list object, i.e., one that implements the
[IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.Objects.IConfiguration')
interface, to a JSON file.

##### Remarks

This command takes a reference to an instance of an object that
implements the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
interface as input, and does not return any output.



This command requires that the
[Path](#P-MFR-Objects-IFileSystemEntry-Path 'MFR.Objects.IFileSystemEntry.Path')
property be
initialized to the pathname where the profile list data should be
saved; preferably, the file should have the .json extension.



This command also requires that the
[UserState](#P-MFR-Objects-IFileSystemEntry-UserState 'MFR.Objects.IFileSystemEntry.UserState')
property
be initialized to a reference to the profile list object containing the
data that is to be saved.

<a name='M-MFR-Profiles-Commands-SaveProfileListToFileCommand-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Profiles-Commands-SaveProfileListToFileCommand-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[SavePathToRegistryAction](#T-MFR-Objects-SavePathToRegistryAction 'MFR.Objects.SavePathToRegistryAction')
.

<a name='P-MFR-Profiles-Commands-SaveProfileListToFileCommand-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-Objects-MessageType 'MFR.Objects.MessageType') that is
being used to identify which message this is.

<a name='M-MFR-Profiles-Commands-SaveProfileListToFileCommand-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Profiles-Commands-SaveProfileListToFileCommand-CommonExecute'></a>
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
