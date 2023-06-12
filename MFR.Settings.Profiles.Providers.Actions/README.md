<a name='assembly'></a>
# MFR.Settings.Profiles.Providers.Actions

## Contents

- [Execute](#T-MFR-Settings-Profiles-Providers-Actions-Execute 'MFR.Settings.Profiles.Providers.Actions.Execute')
  - [OperationToLoadProfileCollectionFilePathFromRegistry(action)](#M-MFR-Settings-Profiles-Providers-Actions-Execute-OperationToLoadProfileCollectionFilePathFromRegistry-MFR-Messages-Actions-Interfaces-IAction{MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String},MFR-FileSystem-Interfaces-IFileSystemEntry}- 'MFR.Settings.Profiles.Providers.Actions.Execute.OperationToLoadProfileCollectionFilePathFromRegistry(MFR.Messages.Actions.Interfaces.IAction{MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String},MFR.FileSystem.Interfaces.IFileSystemEntry})')
- [Formulate](#T-MFR-Settings-Profiles-Providers-Actions-Formulate 'MFR.Settings.Profiles.Providers.Actions.Formulate')
  - [ProfileFilePathRegistryKeyPathname(companyName,productName)](#M-MFR-Settings-Profiles-Providers-Actions-Formulate-ProfileFilePathRegistryKeyPathname-System-String,System-String- 'MFR.Settings.Profiles.Providers.Actions.Formulate.ProfileFilePathRegistryKeyPathname(System.String,System.String)')
- [Generate](#T-MFR-Settings-Profiles-Providers-Actions-Generate 'MFR.Settings.Profiles.Providers.Actions.Generate')
  - [DefaultProfileCollectionPathname(companyName,productName,currentPathname)](#M-MFR-Settings-Profiles-Providers-Actions-Generate-DefaultProfileCollectionPathname-System-String,System-String,System-String- 'MFR.Settings.Profiles.Providers.Actions.Generate.DefaultProfileCollectionPathname(System.String,System.String,System.String)')
  - [ProfilePathRegQueryExpression(companyName,productName,defaultValue)](#M-MFR-Settings-Profiles-Providers-Actions-Generate-ProfilePathRegQueryExpression-System-String,System-String,System-String- 'MFR.Settings.Profiles.Providers.Actions.Generate.ProfilePathRegQueryExpression(System.String,System.String,System.String)')
  - [RetrieveProfileCollectionPathnameFromRegistryAction(expression)](#M-MFR-Settings-Profiles-Providers-Actions-Generate-RetrieveProfileCollectionPathnameFromRegistryAction-MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String}- 'MFR.Settings.Profiles.Providers.Actions.Generate.RetrieveProfileCollectionPathnameFromRegistryAction(MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String})')
- [Obtain](#T-MFR-Settings-Profiles-Providers-Actions-Obtain 'MFR.Settings.Profiles.Providers.Actions.Obtain')
  - [ProfileCollectionFilePath(companyName,productName,currentPathname)](#M-MFR-Settings-Profiles-Providers-Actions-Obtain-ProfileCollectionFilePath-System-String,System-String,System-String- 'MFR.Settings.Profiles.Providers.Actions.Obtain.ProfileCollectionFilePath(System.String,System.String,System.String)')
- [Resources](#T-MFR-Settings-Profiles-Providers-Actions-Properties-Resources 'MFR.Settings.Profiles.Providers.Actions.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Providers-Actions-Properties-Resources-Culture 'MFR.Settings.Profiles.Providers.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Providers-Actions-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Providers.Actions.Properties.Resources.ResourceManager')
- [Retrieve](#T-MFR-Settings-Profiles-Providers-Actions-Retrieve 'MFR.Settings.Profiles.Providers.Actions.Retrieve')
  - [ProfileCollectionPathFromRegistry(companyName,productName,currentPathname)](#M-MFR-Settings-Profiles-Providers-Actions-Retrieve-ProfileCollectionPathFromRegistry-System-String,System-String,System-String- 'MFR.Settings.Profiles.Providers.Actions.Retrieve.ProfileCollectionPathFromRegistry(System.String,System.String,System.String)')

<a name='T-MFR-Settings-Profiles-Providers-Actions-Execute'></a>
## Execute `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions

##### Summary

Exposes static methods for executing operations associated with loading and
storing information about the user's favorite configuration-setting profiles.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Execute-OperationToLoadProfileCollectionFilePathFromRegistry-MFR-Messages-Actions-Interfaces-IAction{MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String},MFR-FileSystem-Interfaces-IFileSystemEntry}-'></a>
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

<a name='T-MFR-Settings-Profiles-Providers-Actions-Formulate'></a>
## Formulate `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions

##### Summary

Exposes static methods to formulate data values from other data values.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Formulate-ProfileFilePathRegistryKeyPathname-System-String,System-String-'></a>
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

<a name='T-MFR-Settings-Profiles-Providers-Actions-Generate'></a>
## Generate `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions

##### Summary

Exposes static methods for generating data values.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Generate-DefaultProfileCollectionPathname-System-String,System-String,System-String-'></a>
### DefaultProfileCollectionPathname(companyName,productName,currentPathname) `method`

##### Summary

Attempts to formulate a default value for the `profiles.json` file that
contains the user's previously-saved configuration profiles.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the
default fully-qualified pathname of the `profiles.json` value that should
be used as a fallback in the event that a `profiles.json` file cannot be
located either on the disk or in the system Registry.

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

<a name='M-MFR-Settings-Profiles-Providers-Actions-Generate-ProfilePathRegQueryExpression-System-String,System-String,System-String-'></a>
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

<a name='M-MFR-Settings-Profiles-Providers-Actions-Generate-RetrieveProfileCollectionPathnameFromRegistryAction-MFR-Expressions-Registry-Interfaces-IRegQueryExpression{System-String}-'></a>
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

<a name='T-MFR-Settings-Profiles-Providers-Actions-Obtain'></a>
## Obtain `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions

##### Summary

Exposes static methods to obtain and formulate various values.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Obtain-ProfileCollectionFilePath-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Settings-Profiles-Providers-Actions-Retrieve'></a>
## Retrieve `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions

##### Summary

Exposes static methods to retrieve data from data sources.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Retrieve-ProfileCollectionPathFromRegistry-System-String,System-String,System-String-'></a>
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
