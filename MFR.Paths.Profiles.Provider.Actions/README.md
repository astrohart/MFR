<a name='assembly'></a>
# MFR.Paths.Profiles.Provider.Actions

## Contents

- [Execute](#T-MFR-Paths-Profiles-Provider-Actions-Execute 'MFR.Paths.Profiles.Provider.Actions.Execute')
  - [OperationToLoadProfileCollectionFilePathFromRegistry(action)](#M-MFR-Paths-Profiles-Provider-Actions-Execute-OperationToLoadProfileCollectionFilePathFromRegistry-MFR-Messages-Actions-Interfaces-IAction{MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String},MFR-FileSystem-Interfaces-IFileSystemEntry}- 'MFR.Paths.Profiles.Provider.Actions.Execute.OperationToLoadProfileCollectionFilePathFromRegistry(MFR.Messages.Actions.Interfaces.IAction{MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String},MFR.FileSystem.Interfaces.IFileSystemEntry})')
  - [OperationToSaveProfileCollectionFilePathToRegistry(command)](#M-MFR-Paths-Profiles-Provider-Actions-Execute-OperationToSaveProfileCollectionFilePathToRegistry-MFR-Messages-Commands-Interfaces-ICommand{MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{System-String}}- 'MFR.Paths.Profiles.Provider.Actions.Execute.OperationToSaveProfileCollectionFilePathToRegistry(MFR.Messages.Commands.Interfaces.ICommand{MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{System.String}})')
- [Formulate](#T-MFR-Paths-Profiles-Provider-Actions-Formulate 'MFR.Paths.Profiles.Provider.Actions.Formulate')
  - [DefaultProfileCollectionPathname(companyName,productName,currentPathname)](#M-MFR-Paths-Profiles-Provider-Actions-Formulate-DefaultProfileCollectionPathname-System-String,System-String,System-String- 'MFR.Paths.Profiles.Provider.Actions.Formulate.DefaultProfileCollectionPathname(System.String,System.String,System.String)')
  - [ProfileFilePathRegistryKeyPathname(companyName,productName)](#M-MFR-Paths-Profiles-Provider-Actions-Formulate-ProfileFilePathRegistryKeyPathname-System-String,System-String- 'MFR.Paths.Profiles.Provider.Actions.Formulate.ProfileFilePathRegistryKeyPathname(System.String,System.String)')
- [Generate](#T-MFR-Paths-Profiles-Provider-Actions-Generate 'MFR.Paths.Profiles.Provider.Actions.Generate')
  - [AccessTheRegOperationMetadataValidator](#P-MFR-Paths-Profiles-Provider-Actions-Generate-AccessTheRegOperationMetadataValidator 'MFR.Paths.Profiles.Provider.Actions.Generate.AccessTheRegOperationMetadataValidator')
  - [AccessTheRegQueryExpressionValidator](#P-MFR-Paths-Profiles-Provider-Actions-Generate-AccessTheRegQueryExpressionValidator 'MFR.Paths.Profiles.Provider.Actions.Generate.AccessTheRegQueryExpressionValidator')
  - [ProfilePathRegQueryExpression(companyName,productName,defaultValue)](#M-MFR-Paths-Profiles-Provider-Actions-Generate-ProfilePathRegQueryExpression-System-String,System-String,System-String- 'MFR.Paths.Profiles.Provider.Actions.Generate.ProfilePathRegQueryExpression(System.String,System.String,System.String)')
  - [RegOperationMetadataForSavingProfileCollectionPath(pathnameToSave,regKeyPathname)](#M-MFR-Paths-Profiles-Provider-Actions-Generate-RegOperationMetadataForSavingProfileCollectionPath-System-String,System-String- 'MFR.Paths.Profiles.Provider.Actions.Generate.RegOperationMetadataForSavingProfileCollectionPath(System.String,System.String)')
  - [RetrieveProfileCollectionPathnameFromRegistryAction(expression)](#M-MFR-Paths-Profiles-Provider-Actions-Generate-RetrieveProfileCollectionPathnameFromRegistryAction-MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String}- 'MFR.Paths.Profiles.Provider.Actions.Generate.RetrieveProfileCollectionPathnameFromRegistryAction(MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String})')
  - [SaveProfilePathToRegistryCommand(metadata)](#M-MFR-Paths-Profiles-Provider-Actions-Generate-SaveProfilePathToRegistryCommand-MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{System-String}- 'MFR.Paths.Profiles.Provider.Actions.Generate.SaveProfilePathToRegistryCommand(MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{System.String})')
- [Obtain](#T-MFR-Paths-Profiles-Provider-Actions-Obtain 'MFR.Paths.Profiles.Provider.Actions.Obtain')
  - [ProfileCollectionFilePath(companyName,productName,currentPathname)](#M-MFR-Paths-Profiles-Provider-Actions-Obtain-ProfileCollectionFilePath-System-String,System-String,System-String- 'MFR.Paths.Profiles.Provider.Actions.Obtain.ProfileCollectionFilePath(System.String,System.String,System.String)')
- [Resources](#T-MFR-Paths-Profiles-Provider-Actions-Properties-Resources 'MFR.Paths.Profiles.Provider.Actions.Properties.Resources')
  - [Culture](#P-MFR-Paths-Profiles-Provider-Actions-Properties-Resources-Culture 'MFR.Paths.Profiles.Provider.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Paths-Profiles-Provider-Actions-Properties-Resources-ResourceManager 'MFR.Paths.Profiles.Provider.Actions.Properties.Resources.ResourceManager')
- [Retrieve](#T-MFR-Paths-Profiles-Provider-Actions-Retrieve 'MFR.Paths.Profiles.Provider.Actions.Retrieve')
  - [ProfileCollectionPathFromRegistry(companyName,productName,currentPathname)](#M-MFR-Paths-Profiles-Provider-Actions-Retrieve-ProfileCollectionPathFromRegistry-System-String,System-String,System-String- 'MFR.Paths.Profiles.Provider.Actions.Retrieve.ProfileCollectionPathFromRegistry(System.String,System.String,System.String)')
- [Store](#T-MFR-Paths-Profiles-Provider-Actions-Store 'MFR.Paths.Profiles.Provider.Actions.Store')
  - [ProfileCollectionFilePathToRegistry(companyName,productName,pathname)](#M-MFR-Paths-Profiles-Provider-Actions-Store-ProfileCollectionFilePathToRegistry-System-String,System-String,System-String- 'MFR.Paths.Profiles.Provider.Actions.Store.ProfileCollectionFilePathToRegistry(System.String,System.String,System.String)')

<a name='T-MFR-Paths-Profiles-Provider-Actions-Execute'></a>
## Execute `type`

##### Namespace

MFR.Paths.Profiles.Provider.Actions

##### Summary

Exposes static methods for executing operations associated with loading and
storing information about the user's favorite configuration-setting profiles.

<a name='M-MFR-Paths-Profiles-Provider-Actions-Execute-OperationToLoadProfileCollectionFilePathFromRegistry-MFR-Messages-Actions-Interfaces-IAction{MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String},MFR-FileSystem-Interfaces-IFileSystemEntry}-'></a>
### OperationToLoadProfileCollectionFilePathFromRegistry(action) `method`

##### Summary

Executes the operation to fetch the fully-qualified pathname of the
`profiles.json` file from the system Registry, if it is configured.

##### Returns

Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface that
should contain the pathname of the `profiles.json` file; or
`null` if the pathname could not be read.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [MFR.Messages.Actions.Interfaces.IAction{MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String},MFR.FileSystem.Interfaces.IFileSystemEntry}](#T-MFR-Messages-Actions-Interfaces-IAction{MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String},MFR-FileSystem-Interfaces-IFileSystemEntry} 'MFR.Messages.Actions.Interfaces.IAction{MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String},MFR.FileSystem.Interfaces.IFileSystemEntry}') | (Required.) Reference to an instance of an object that
implements the
[IAction[TInput, TResult]](#T-MFR-Messages-Actions-Interfaces-IAction[TInput, TResult] 'MFR.Messages.Actions.Interfaces.IAction[TInput, TResult]')
interface that represents the operation that is to be executed. |

<a name='M-MFR-Paths-Profiles-Provider-Actions-Execute-OperationToSaveProfileCollectionFilePathToRegistry-MFR-Messages-Commands-Interfaces-ICommand{MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{System-String}}-'></a>
### OperationToSaveProfileCollectionFilePathToRegistry(command) `method`

##### Summary

Executes the operation to fetch the fully-qualified pathname of the
`profiles.json` file from the system Registry, if it is configured.

##### Returns

Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface that
should contain the pathname of the `profiles.json` file; or
`null` if the pathname could not be read.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [MFR.Messages.Commands.Interfaces.ICommand{MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{System.String}}](#T-MFR-Messages-Commands-Interfaces-ICommand{MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{System-String}} 'MFR.Messages.Commands.Interfaces.ICommand{MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{System.String}}') | (Required.) Reference to an instance of an object that
implements the
[IAction[TInput, TResult]](#T-MFR-Messages-Actions-Interfaces-IAction[TInput, TResult] 'MFR.Messages.Actions.Interfaces.IAction[TInput, TResult]')
interface that represents the operation that is to be executed. |

<a name='T-MFR-Paths-Profiles-Provider-Actions-Formulate'></a>
## Formulate `type`

##### Namespace

MFR.Paths.Profiles.Provider.Actions

##### Summary

Exposes static methods to formulate data values from other data values.

<a name='M-MFR-Paths-Profiles-Provider-Actions-Formulate-DefaultProfileCollectionPathname-System-String,System-String,System-String-'></a>
### DefaultProfileCollectionPathname(companyName,productName,currentPathname) `method`

##### Summary

Attempts to formulate a default value for the `profiles.json` file that
contains the user's previously-saved configuration profiles.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the
default fully-qualified pathname of the `profiles.json` value that should
be used as a fallback in the event that a `profiles.json` file cannot be
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

Configuration profiles let the user save a set of their previously-used
settings to easily recall for later use.



If an error occurred, or if required information is missing, during the
operation, then this method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value.

<a name='M-MFR-Paths-Profiles-Provider-Actions-Formulate-ProfileFilePathRegistryKeyPathname-System-String,System-String-'></a>
### ProfileFilePathRegistryKeyPathname(companyName,productName) `method`

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

<a name='T-MFR-Paths-Profiles-Provider-Actions-Generate'></a>
## Generate `type`

##### Namespace

MFR.Paths.Profiles.Provider.Actions

##### Summary

Exposes static methods for generating data values.

<a name='P-MFR-Paths-Profiles-Provider-Actions-Generate-AccessTheRegOperationMetadataValidator'></a>
### AccessTheRegOperationMetadataValidator `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IRegOperationMetadataValidator{T}](#T-MFR-Metadata-Registry-Validators-Interfaces-IRegOperationMetadataValidator{T} 'MFR.Metadata.Registry.Validators.Interfaces.IRegOperationMetadataValidator{T}')
interface that represents an object that validates the metadata used for
performing Registry operations.

<a name='P-MFR-Paths-Profiles-Provider-Actions-Generate-AccessTheRegQueryExpressionValidator'></a>
### AccessTheRegQueryExpressionValidator `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IRegQueryExpressionValidator{T}](#T-MFR-Expressions-Registry-Validators-Interfaces-IRegQueryExpressionValidator{T} 'MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator{T}')
interface.

<a name='M-MFR-Paths-Profiles-Provider-Actions-Generate-ProfilePathRegQueryExpression-System-String,System-String,System-String-'></a>
### ProfilePathRegQueryExpression(companyName,productName,defaultValue) `method`

##### Summary

Generates an instance of an object that implements the
[String}](#T-MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String} 'MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String}')
interface for the purpose of searching the system Registry for the pathname of
the `profiles.json` file.

##### Returns

Reference to an instance of a Registry query expression object that
can be used to search the system Registry for the fully-qualified pathname of
the `profiles.json` file.

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

<a name='M-MFR-Paths-Profiles-Provider-Actions-Generate-RegOperationMetadataForSavingProfileCollectionPath-System-String,System-String-'></a>
### RegOperationMetadataForSavingProfileCollectionPath(pathnameToSave,regKeyPathname) `method`

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

<a name='M-MFR-Paths-Profiles-Provider-Actions-Generate-RetrieveProfileCollectionPathnameFromRegistryAction-MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String}-'></a>
### RetrieveProfileCollectionPathnameFromRegistryAction(expression) `method`

##### Summary

Creates and configures a reference to an instance of an `Action` object
that, when executed, retrieves the fully-qualified pathname of the
`profiles.json` file that is supposed to be stored in the system Registry.

##### Returns

Reference to an instance of an `Action` object that, when executed,
retrieves the fully-qualified pathname of the `profiles.json` file that is
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
[ProfilePathRegQueryExpression](#M-MFR-Settings-Profiles-Providers-Actions-Generate-ProfilePathRegQueryExpression 'MFR.Settings.Profiles.Providers.Actions.Generate.ProfilePathRegQueryExpression')
method. |

<a name='M-MFR-Paths-Profiles-Provider-Actions-Generate-SaveProfilePathToRegistryCommand-MFR-Metadata-Registry-Interfaces-IRegOperationMetadata{System-String}-'></a>
### SaveProfilePathToRegistryCommand(metadata) `method`

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

<a name='T-MFR-Paths-Profiles-Provider-Actions-Obtain'></a>
## Obtain `type`

##### Namespace

MFR.Paths.Profiles.Provider.Actions

##### Summary

Exposes static methods to obtain and formulate various values.

<a name='M-MFR-Paths-Profiles-Provider-Actions-Obtain-ProfileCollectionFilePath-System-String,System-String,System-String-'></a>
### ProfileCollectionFilePath(companyName,productName,currentPathname) `method`

##### Summary

Attempts to determine the fully-qualified pathname of the `profiles.json`
file that stores the user's saved configuration profiles.

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

<a name='T-MFR-Paths-Profiles-Provider-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Paths.Profiles.Provider.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Paths-Profiles-Provider-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Paths-Profiles-Provider-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Paths-Profiles-Provider-Actions-Retrieve'></a>
## Retrieve `type`

##### Namespace

MFR.Paths.Profiles.Provider.Actions

##### Summary

Exposes static methods to retrieve data from data sources.

<a name='M-MFR-Paths-Profiles-Provider-Actions-Retrieve-ProfileCollectionPathFromRegistry-System-String,System-String,System-String-'></a>
### ProfileCollectionPathFromRegistry(companyName,productName,currentPathname) `method`

##### Summary

Attempts to obtain the pathname of the file that contains the list of saved
configuration profiles from the system Registry.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
fully-qualified pathname of the `profiles.json` file that contains the
user's previously-saved configuration profiles.

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
operation, then this method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value.

<a name='T-MFR-Paths-Profiles-Provider-Actions-Store'></a>
## Store `type`

##### Namespace

MFR.Paths.Profiles.Provider.Actions

##### Summary

Exposes static methods for storing the pathnameToSave of a `profiles.json`
file
to the system Registry.

<a name='M-MFR-Paths-Profiles-Provider-Actions-Store-ProfileCollectionFilePathToRegistry-System-String,System-String,System-String-'></a>
### ProfileCollectionFilePathToRegistry(companyName,productName,pathname) `method`

##### Summary

Executes an operation to store the fully-qualified pathname of a
`profiles.json` file into the system Registry.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| companyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the company name associated with the application. |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the product name associated with the application. |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a `profiles.json` file that is to be stored in the system
Registry. |

##### Remarks

Configuration profiles let the user save a set of their previously-used
settings to easily recall for later use.



If an error occurred during the operation, or the required information is
missing, then this method does nothing.
