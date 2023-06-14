<a name='assembly'></a>
# MFR.Settings.Configuration.Providers.Actions

## Contents

- [Create](#T-MFR-Settings-Configuration-Providers-Actions-Create 'MFR.Settings.Configuration.Providers.Actions.Create')
  - [BlankConfiguration()](#M-MFR-Settings-Configuration-Providers-Actions-Create-BlankConfiguration 'MFR.Settings.Configuration.Providers.Actions.Create.BlankConfiguration')
- [Determine](#T-MFR-Settings-Configuration-Providers-Actions-Determine 'MFR.Settings.Configuration.Providers.Actions.Determine')
  - [CorrectPathForLoadingConfiguration(submittedPathname,currentPathnameInRegistry)](#M-MFR-Settings-Configuration-Providers-Actions-Determine-CorrectPathForLoadingConfiguration-System-String,System-String- 'MFR.Settings.Configuration.Providers.Actions.Determine.CorrectPathForLoadingConfiguration(System.String,System.String)')
  - [IsConfigPathValid(pathname)](#M-MFR-Settings-Configuration-Providers-Actions-Determine-IsConfigPathValid-System-String- 'MFR.Settings.Configuration.Providers.Actions.Determine.IsConfigPathValid(System.String)')
- [Execute](#T-MFR-Settings-Configuration-Providers-Actions-Execute 'MFR.Settings.Configuration.Providers.Actions.Execute')
  - [OperationToLoadConfigFromFile(action)](#M-MFR-Settings-Configuration-Providers-Actions-Execute-OperationToLoadConfigFromFile-MFR-Messages-Actions-Interfaces-IAction{MFR-FileSystem-Interfaces-IFileSystemEntry,MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration}- 'MFR.Settings.Configuration.Providers.Actions.Execute.OperationToLoadConfigFromFile(MFR.Messages.Actions.Interfaces.IAction{MFR.FileSystem.Interfaces.IFileSystemEntry,MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration})')
- [Generate](#T-MFR-Settings-Configuration-Providers-Actions-Generate 'MFR.Settings.Configuration.Providers.Actions.Generate')
  - [FileSystemEntryForConfiguration(pathname)](#M-MFR-Settings-Configuration-Providers-Actions-Generate-FileSystemEntryForConfiguration-System-String- 'MFR.Settings.Configuration.Providers.Actions.Generate.FileSystemEntryForConfiguration(System.String)')
  - [LoadConfigFromFileAction(entry)](#M-MFR-Settings-Configuration-Providers-Actions-Generate-LoadConfigFromFileAction-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Settings.Configuration.Providers.Actions.Generate.LoadConfigFromFileAction(MFR.FileSystem.Interfaces.IFileSystemEntry)')
- [Obtain](#T-MFR-Settings-Configuration-Providers-Actions-Obtain 'MFR.Settings.Configuration.Providers.Actions.Obtain')
  - [ConfigurationFrom(pathname)](#M-MFR-Settings-Configuration-Providers-Actions-Obtain-ConfigurationFrom-System-String- 'MFR.Settings.Configuration.Providers.Actions.Obtain.ConfigurationFrom(System.String)')
- [Resources](#T-MFR-Settings-Configuration-Providers-Actions-Properties-Resources 'MFR.Settings.Configuration.Providers.Actions.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Providers-Actions-Properties-Resources-Culture 'MFR.Settings.Configuration.Providers.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Providers-Actions-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Providers.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Providers-Actions-Create'></a>
## Create `type`

##### Namespace

MFR.Settings.Configuration.Providers.Actions

##### Summary

Exposes static methods to create instances of objects and data.

<a name='M-MFR-Settings-Configuration-Providers-Actions-Create-BlankConfiguration'></a>
### BlankConfiguration() `method`

##### Summary

Creates an instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface and initializes it with the default invokable operations.

##### Returns

Reference to an instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface that is initialized with the default invokable operations.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Providers-Actions-Determine'></a>
## Determine `type`

##### Namespace

MFR.Settings.Configuration.Providers.Actions

##### Summary

Exposes static methods to make determinations on data.

<a name='M-MFR-Settings-Configuration-Providers-Actions-Determine-CorrectPathForLoadingConfiguration-System-String,System-String-'></a>
### CorrectPathForLoadingConfiguration(submittedPathname,currentPathnameInRegistry) `method`

##### Summary

Determines the correct pathname to use for loading the application
configuration.

##### Returns

If the `submittedPathname` is not blank and is set
to the pathname of a file that exists on the disk, then the method returns that
pathname; otherwise, the `currentPathnameInRegistry` is
returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| submittedPathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname submitted to the
[Load](#M-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider-Load 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider.Load')
method. |
| currentPathnameInRegistry | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified pathname of the
application configuration file as read from the system Registry. |

<a name='M-MFR-Settings-Configuration-Providers-Actions-Determine-IsConfigPathValid-System-String-'></a>
### IsConfigPathValid(pathname) `method`

##### Summary

Determines whether the specified `pathname` of a
`config.json` file is valid.

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
on the disk; and the filename of the file must be `config.json`.

<a name='T-MFR-Settings-Configuration-Providers-Actions-Execute'></a>
## Execute `type`

##### Namespace

MFR.Settings.Configuration.Providers.Actions

##### Summary

Exposes static  methods to execute actions on data.

<a name='M-MFR-Settings-Configuration-Providers-Actions-Execute-OperationToLoadConfigFromFile-MFR-Messages-Actions-Interfaces-IAction{MFR-FileSystem-Interfaces-IFileSystemEntry,MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration}-'></a>
### OperationToLoadConfigFromFile(action) `method`

##### Summary

Attempts to execute the operation of loading a new instance of an object that
implements
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
from a file on the disk.

##### Returns

If successful, a reference to an instance of an object that implements
the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface containing the loaded application configuration, or the blank
configuration if the operation could not be executed, or if no application
configuration data is contained within the specified file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [MFR.Messages.Actions.Interfaces.IAction{MFR.FileSystem.Interfaces.IFileSystemEntry,MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration}](#T-MFR-Messages-Actions-Interfaces-IAction{MFR-FileSystem-Interfaces-IFileSystemEntry,MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration} 'MFR.Messages.Actions.Interfaces.IAction{MFR.FileSystem.Interfaces.IFileSystemEntry,MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration}') | (Required.) Reference to an `Action` object that, when executed, loads the
application configuration from a file on the disk. |

<a name='T-MFR-Settings-Configuration-Providers-Actions-Generate'></a>
## Generate `type`

##### Namespace

MFR.Settings.Configuration.Providers.Actions

<a name='M-MFR-Settings-Configuration-Providers-Actions-Generate-FileSystemEntryForConfiguration-System-String-'></a>
### FileSystemEntryForConfiguration(pathname) `method`

##### Summary

Given the specified `pathname` of a `config.json` file,
manufactures and returns a reference to an instance of an object that
implements the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface for that `pathname`.

##### Returns

If successful, a reference to an instance of an object that implements
the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface for
that `pathname`; otherwise, `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a `config.json` file. |

##### Remarks

This method checks whether the file having the specified
`pathname` exists on the disk or not, and has the filename
`config.json` before creating a new file system entry object.

<a name='M-MFR-Settings-Configuration-Providers-Actions-Generate-LoadConfigFromFileAction-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### LoadConfigFromFileAction(entry) `method`

##### Summary

Generates a new `Action` object that loads the configuration data from a
file on the disk.

##### Returns

A new `Action` object that loads the configuration data from a
file on the disk.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface that
contains the fully-qualified pathname of a file on the disk that contains
application configuration data. |

<a name='T-MFR-Settings-Configuration-Providers-Actions-Obtain'></a>
## Obtain `type`

##### Namespace

MFR.Settings.Configuration.Providers.Actions

##### Summary

Exposes static methods to load and initialize object instances from data
sources.

<a name='M-MFR-Settings-Configuration-Providers-Actions-Obtain-ConfigurationFrom-System-String-'></a>
### ConfigurationFrom(pathname) `method`

##### Summary

Attempts to obtain a reference to an instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface that contains the application configuration.

##### Returns

If successful, a reference to an instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface that contains the application configuration is returned; otherwise, a
blank configuration is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a `config.json` file on the disk from which the application
configuration is to be loaded. |

<a name='T-MFR-Settings-Configuration-Providers-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Providers.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Providers-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Providers-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
