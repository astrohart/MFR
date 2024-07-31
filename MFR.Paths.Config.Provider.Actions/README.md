<a name='assembly'></a>
# MFR.Paths.Config.Provider.Actions

## Contents

- [Execute](#T-MFR-Paths-Config-Provider-Actions-Execute 'MFR.Paths.Config.Provider.Actions.Execute')
  - [OperationToLoadConfigFilePathFromRegistry(action)](#M-MFR-Paths-Config-Provider-Actions-Execute-OperationToLoadConfigFilePathFromRegistry-MFR-Messages-Actions-Interfaces-IAction{MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String},MFR-FileSystem-Interfaces-IFileSystemEntry}- 'MFR.Paths.Config.Provider.Actions.Execute.OperationToLoadConfigFilePathFromRegistry(MFR.Messages.Actions.Interfaces.IAction{MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String},MFR.FileSystem.Interfaces.IFileSystemEntry})')
  - [OperationToSaveConfigFilePathToRegistry(command)](#M-MFR-Paths-Config-Provider-Actions-Execute-OperationToSaveConfigFilePathToRegistry-MFR-Messages-Commands-Interfaces-ICommand{MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{System-String}}- 'MFR.Paths.Config.Provider.Actions.Execute.OperationToSaveConfigFilePathToRegistry(MFR.Messages.Commands.Interfaces.ICommand{MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{System.String}})')
- [Formulate](#T-MFR-Paths-Config-Provider-Actions-Formulate 'MFR.Paths.Config.Provider.Actions.Formulate')
  - [ConfigFilePathRegistryKeyPathname(companyName,productName)](#M-MFR-Paths-Config-Provider-Actions-Formulate-ConfigFilePathRegistryKeyPathname-System-String,System-String- 'MFR.Paths.Config.Provider.Actions.Formulate.ConfigFilePathRegistryKeyPathname(System.String,System.String)')
- [Generate](#T-MFR-Paths-Config-Provider-Actions-Generate 'MFR.Paths.Config.Provider.Actions.Generate')
  - [AccessTheRegOperationMetadataValidator](#P-MFR-Paths-Config-Provider-Actions-Generate-AccessTheRegOperationMetadataValidator 'MFR.Paths.Config.Provider.Actions.Generate.AccessTheRegOperationMetadataValidator')
  - [AccessTheRegQueryExpressionValidator](#P-MFR-Paths-Config-Provider-Actions-Generate-AccessTheRegQueryExpressionValidator 'MFR.Paths.Config.Provider.Actions.Generate.AccessTheRegQueryExpressionValidator')
  - [ConfigPathRegQueryExpression(companyName,productName,defaultValue)](#M-MFR-Paths-Config-Provider-Actions-Generate-ConfigPathRegQueryExpression-System-String,System-String,System-String- 'MFR.Paths.Config.Provider.Actions.Generate.ConfigPathRegQueryExpression(System.String,System.String,System.String)')
  - [DefaultConfigPathname(companyName,productName,currentPathname)](#M-MFR-Paths-Config-Provider-Actions-Generate-DefaultConfigPathname-System-String,System-String,System-String- 'MFR.Paths.Config.Provider.Actions.Generate.DefaultConfigPathname(System.String,System.String,System.String)')
  - [RegOperationMetadataForSavingConfigPath(pathnameToSave,regKeyPathname)](#M-MFR-Paths-Config-Provider-Actions-Generate-RegOperationMetadataForSavingConfigPath-System-String,System-String- 'MFR.Paths.Config.Provider.Actions.Generate.RegOperationMetadataForSavingConfigPath(System.String,System.String)')
  - [RetrieveConfigPathnameFromRegistryAction(expression)](#M-MFR-Paths-Config-Provider-Actions-Generate-RetrieveConfigPathnameFromRegistryAction-MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String}- 'MFR.Paths.Config.Provider.Actions.Generate.RetrieveConfigPathnameFromRegistryAction(MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String})')
  - [SaveConfigPathToRegistryCommand(metadata)](#M-MFR-Paths-Config-Provider-Actions-Generate-SaveConfigPathToRegistryCommand-MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{System-String}- 'MFR.Paths.Config.Provider.Actions.Generate.SaveConfigPathToRegistryCommand(MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{System.String})')
- [Obtain](#T-MFR-Paths-Config-Provider-Actions-Obtain 'MFR.Paths.Config.Provider.Actions.Obtain')
  - [ConfigFilePath(companyName,productName,currentPathname)](#M-MFR-Paths-Config-Provider-Actions-Obtain-ConfigFilePath-System-String,System-String,System-String- 'MFR.Paths.Config.Provider.Actions.Obtain.ConfigFilePath(System.String,System.String,System.String)')
- [Resources](#T-MFR-Paths-Config-Provider-Actions-Properties-Resources 'MFR.Paths.Config.Provider.Actions.Properties.Resources')
  - [Culture](#P-MFR-Paths-Config-Provider-Actions-Properties-Resources-Culture 'MFR.Paths.Config.Provider.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Paths-Config-Provider-Actions-Properties-Resources-ResourceManager 'MFR.Paths.Config.Provider.Actions.Properties.Resources.ResourceManager')
- [Retrieve](#T-MFR-Paths-Config-Provider-Actions-Retrieve 'MFR.Paths.Config.Provider.Actions.Retrieve')
  - [ConfigPathFromRegistry(companyName,productName,currentPathname)](#M-MFR-Paths-Config-Provider-Actions-Retrieve-ConfigPathFromRegistry-System-String,System-String,System-String- 'MFR.Paths.Config.Provider.Actions.Retrieve.ConfigPathFromRegistry(System.String,System.String,System.String)')
- [Store](#T-MFR-Paths-Config-Provider-Actions-Store 'MFR.Paths.Config.Provider.Actions.Store')
  - [ConfigFilePathToRegistry(companyName,productName,pathname)](#M-MFR-Paths-Config-Provider-Actions-Store-ConfigFilePathToRegistry-System-String,System-String,System-String- 'MFR.Paths.Config.Provider.Actions.Store.ConfigFilePathToRegistry(System.String,System.String,System.String)')

<a name='T-MFR-Paths-Config-Provider-Actions-Execute'></a>
## Execute `type`

##### Namespace

MFR.Paths.Config.Provider.Actions

##### Summary

Exposes static methods for executing operations associated with loading and
storing information about the user's favorite configuration-setting profiles.

<a name='M-MFR-Paths-Config-Provider-Actions-Execute-OperationToLoadConfigFilePathFromRegistry-MFR-Messages-Actions-Interfaces-IAction{MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String},MFR-FileSystem-Interfaces-IFileSystemEntry}-'></a>
### OperationToLoadConfigFilePathFromRegistry(action) `method`

##### Summary

Executes the operation to fetch the fully-qualified pathname of the
`config.json` file from the system Registry, if it is configured.

##### Returns

Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface that
should contain the pathname of the `config.json` file; or
`null` if the pathname could not be read.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [MFR.Messages.Actions.Interfaces.IAction{MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String},MFR.FileSystem.Interfaces.IFileSystemEntry}](#T-MFR-Messages-Actions-Interfaces-IAction{MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String},MFR-FileSystem-Interfaces-IFileSystemEntry} 'MFR.Messages.Actions.Interfaces.IAction{MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String},MFR.FileSystem.Interfaces.IFileSystemEntry}') | (Required.) Reference to an instance of an object that
implements the
[IAction{TInput, TResult}](#T-MFR-Messages-Actions-Interfaces-IAction{TInput, TResult} 'MFR.Messages.Actions.Interfaces.IAction{TInput, TResult}')
interface that represents the operation that is to be executed. |

<a name='M-MFR-Paths-Config-Provider-Actions-Execute-OperationToSaveConfigFilePathToRegistry-MFR-Messages-Commands-Interfaces-ICommand{MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{System-String}}-'></a>
### OperationToSaveConfigFilePathToRegistry(command) `method`

##### Summary

Executes a `Command` that saves the pathname of the application
configuration file to the system Registry.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [MFR.Messages.Commands.Interfaces.ICommand{MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{System.String}}](#T-MFR-Messages-Commands-Interfaces-ICommand{MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{System-String}} 'MFR.Messages.Commands.Interfaces.ICommand{MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{System.String}}') | (Required.) Reference to an instance of an object that
implements the
[ICommand{TInput}](#T-MFR-Messages-Commands-Interfaces-ICommand{TInput} 'MFR.Messages.Commands.Interfaces.ICommand{TInput}') interface
that, when executed, saves the pathname of the application configuration file
to the system Registry.. |

<a name='T-MFR-Paths-Config-Provider-Actions-Formulate'></a>
## Formulate `type`

##### Namespace

MFR.Paths.Config.Provider.Actions

##### Summary

Exposes static methods to formulate data values from other data values.

<a name='M-MFR-Paths-Config-Provider-Actions-Formulate-ConfigFilePathRegistryKeyPathname-System-String,System-String-'></a>
### ConfigFilePathRegistryKeyPathname(companyName,productName) `method`

##### Summary

Attempts to get the fully-qualified Registry key pathname of the key storing
the pathnames of the profile list and configuration files.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the
fully-qualified Registry key pathname of the key storing the pathnames of the
profile list and configuration files.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| companyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the company name associated with the application. |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the product name associated with the application. |

##### Remarks

If either of the required parameters, `companyName` and
`productName` are passed the blank or `null`
value as an argument, then this method returns the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.



The [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value is also returned if an error
occurs during the processing of the operation.

<a name='T-MFR-Paths-Config-Provider-Actions-Generate'></a>
## Generate `type`

##### Namespace

MFR.Paths.Config.Provider.Actions

##### Summary

Exposes static methods for generating data values.

<a name='P-MFR-Paths-Config-Provider-Actions-Generate-AccessTheRegOperationMetadataValidator'></a>
### AccessTheRegOperationMetadataValidator `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IRegOperationMetadataValidator{T}](#T-MFR-Metadata-Registry-Validators-Interfaces-IRegOperationMetadataValidator{T} 'MFR.Metadata.Registry.Validators.Interfaces.IRegOperationMetadataValidator{T}')
interface that represents an object that validates the metadata used for
performing Registry operations.

<a name='P-MFR-Paths-Config-Provider-Actions-Generate-AccessTheRegQueryExpressionValidator'></a>
### AccessTheRegQueryExpressionValidator `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IRegQueryExpressionValidator{T}](#T-MFR-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator{T} 'MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator{T}')
interface.

<a name='M-MFR-Paths-Config-Provider-Actions-Generate-ConfigPathRegQueryExpression-System-String,System-String,System-String-'></a>
### ConfigPathRegQueryExpression(companyName,productName,defaultValue) `method`

##### Summary

Generates an instance of an object that implements the
[String}](#T-MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String} 'MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String}')
interface for the purpose of searching the system Registry for the pathname of
the `config.json` file.

##### Returns

Reference to an instance of a Registry query expression object that
can be used to search the system Registry for the fully-qualified pathname of
the `config.json` file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| companyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the company name that
is associated with the application. |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the product name that
is associated with the application. |
| defaultValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains a default value that is to be returned in case nothing can be
successfully read from the system Registry. |

<a name='M-MFR-Paths-Config-Provider-Actions-Generate-DefaultConfigPathname-System-String,System-String,System-String-'></a>
### DefaultConfigPathname(companyName,productName,currentPathname) `method`

##### Summary

Attempts to formulate a default value for the `config.json` file that
contains the user's previously-saved application configuration.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the
default fully-qualified pathname of the `config.json` value that should
be used as a fallback in the event that a `config.json` file cannot be
located either on the file system or in the system Registry.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| companyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the company name associated with the application. |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the product name associated with the application. |
| currentPathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
serves as a default return value for this method in case a failure mode is
otherwise hit (blank input, missing file, missing Registry value, etc. |

##### Remarks

The application configuration is stored in the file.



If an error occurred, or if required information is missing, during the
operation, then this method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value.

<a name='M-MFR-Paths-Config-Provider-Actions-Generate-RegOperationMetadataForSavingConfigPath-System-String,System-String-'></a>
### RegOperationMetadataForSavingConfigPath(pathnameToSave,regKeyPathname) `method`

##### Summary

Generates an instance of an object that implements the
[String}](#T-MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{System-String} 'MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{System.String}')
interface that is to be used for storing the specified
`pathnameToSave` under the specified
`regKeyPathname`.

##### Returns

Reference to an instance of an object that implements the
[String}](#T-MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{System-String} 'MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{System.String}')
interface that can be used for saving the specified
`pathnameToSave` to the Registry key having the specified
`regKeyPathname`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathnameToSave | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file that is to be saved on the hard disk. |
| regKeyPathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A fully-qualified Registry key
pathname under which the fully-qualified pathname of the `profiles.json`
file indicated by the `pathnameToSave` parameter is to be
stored. |

##### Remarks

The file indicated in the `pathnameToSave` parameter must
have the filename `profiles.json` in order to be saved to the system
Registry.



Moreover, the `regKeyPathname` parameter must not have a
blank argument.



If either of these conditions aren't met, then this method returns a
`null` reference.

<a name='M-MFR-Paths-Config-Provider-Actions-Generate-RetrieveConfigPathnameFromRegistryAction-MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String}-'></a>
### RetrieveConfigPathnameFromRegistryAction(expression) `method`

##### Summary

Creates and configures a reference to an instance of an `Action` object
that, when executed, retrieves the fully-qualified pathname of the
`config.json` file that is supposed to be stored in the system Registry.

##### Returns

Reference to an instance of an `Action` object that, when executed,
retrieves the fully-qualified pathname of the `config.json` file that is
supposed to be stored in the system Registry.
executed,

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String}](#T-MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String} 'MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String}') | (Required.) Reference to an instance of an object that implements the
[String}](#T-MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String} 'MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String}')
interface that represents the query object to be used for searching the system
Registry.



This query can be initialized with the
[ConfigPathRegQueryExpression](#M-MFR-Settings-Configs-Providers-Actions-Generate-ConfigPathRegQueryExpression 'MFR.Settings.Configs.Providers.Actions.Generate.ConfigPathRegQueryExpression')
method. |

<a name='M-MFR-Paths-Config-Provider-Actions-Generate-SaveConfigPathToRegistryCommand-MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{System-String}-'></a>
### SaveConfigPathToRegistryCommand(metadata) `method`

##### Summary

Generates a new `Command` object (an object that sends an application
message that has an input value but no output) for saving the pathname of the
file containing the user's saved configuration-setting profiles to the system
Registry.

##### Returns

A new `Command` object (an object that sends an application
message that has an input value but no output) for saving the pathname of the
file containing the user's saved configuration-setting profiles to the system
Registry.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| metadata | [MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{System.String}](#T-MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{System-String} 'MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{System.String}') | (Required.) Reference to an instance of an object that implements the
[IRegOperationMetadata{T}](#T-MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{T} 'MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{T}')
interface.



This object specifies the information that tells the code under which Registry
key and value should the pathname be written. |

<a name='T-MFR-Paths-Config-Provider-Actions-Obtain'></a>
## Obtain `type`

##### Namespace

MFR.Paths.Config.Provider.Actions

##### Summary

Exposes static methods to obtain and formulate various values.

<a name='M-MFR-Paths-Config-Provider-Actions-Obtain-ConfigFilePath-System-String,System-String,System-String-'></a>
### ConfigFilePath(companyName,productName,currentPathname) `method`

##### Summary

Attempts to determine the fully-qualified pathname of the `config.json`
file that stores the application configuration.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| companyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the company name associated with the application. |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the product name associated with the application. |
| currentPathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
serves as a default return value for this method in case a failure mode is
otherwise hit (blank input, missing file, missing Registry value, etc. |

##### Remarks

Configuration profiles let the user save a set of their previously-used
settings to easily recall for later use.



If an error occurred, or if required information is missing, during the
operation, then this method returns the value of the
`currentPathname`
parameter.



The `currentPathname` is allowed to be passed
the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value as its argument, so be mindful.

<a name='T-MFR-Paths-Config-Provider-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Paths.Config.Provider.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Paths-Config-Provider-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Paths-Config-Provider-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Paths-Config-Provider-Actions-Retrieve'></a>
## Retrieve `type`

##### Namespace

MFR.Paths.Config.Provider.Actions

##### Summary

Exposes static methods to retrieve data from data sources.

<a name='M-MFR-Paths-Config-Provider-Actions-Retrieve-ConfigPathFromRegistry-System-String,System-String,System-String-'></a>
### ConfigPathFromRegistry(companyName,productName,currentPathname) `method`

##### Summary

Attempts to obtain the pathname of the file that contains the application
configuration from the system Registry.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
fully-qualified pathname of the `config.json` file that contains the
application configuration.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| companyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the company name associated with the application. |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the product name associated with the application. |
| currentPathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
serves as a default return value for this method in case a failure mode is
otherwise hit (blank input, missing file, missing Registry value, etc. |

##### Remarks

If an error occurred, or if required information is missing, during the
operation, then this method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value.

<a name='T-MFR-Paths-Config-Provider-Actions-Store'></a>
## Store `type`

##### Namespace

MFR.Paths.Config.Provider.Actions

##### Summary

Exposes static methods for storing the pathname of a `config.json` file to
the system Registry.

<a name='M-MFR-Paths-Config-Provider-Actions-Store-ConfigFilePathToRegistry-System-String,System-String,System-String-'></a>
### ConfigFilePathToRegistry(companyName,productName,pathname) `method`

##### Summary

Saves the fully-qualified pathname of the application configuration file to the
system Registry.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| companyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the company name that is associated with the application. |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the product name that is associated with the application. |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the fully-qualified pathname of the application configuration file
that is to be stored in the system Registry.. |
