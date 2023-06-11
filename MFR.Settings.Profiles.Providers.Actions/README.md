<a name='assembly'></a>
# MFR.Settings.Profiles.Providers.Actions

## Contents

- [Obtain](#T-MFR-Settings-Profiles-Providers-Actions-Obtain 'MFR.Settings.Profiles.Providers.Actions.Obtain')
  - [GetDefaultProfileCollectionPathname(companyName,productName)](#M-MFR-Settings-Profiles-Providers-Actions-Obtain-GetDefaultProfileCollectionPathname-System-String,System-String- 'MFR.Settings.Profiles.Providers.Actions.Obtain.GetDefaultProfileCollectionPathname(System.String,System.String)')
  - [GetProfileCollectionPathFromRegistry(companyName,productName)](#M-MFR-Settings-Profiles-Providers-Actions-Obtain-GetProfileCollectionPathFromRegistry-System-String,System-String- 'MFR.Settings.Profiles.Providers.Actions.Obtain.GetProfileCollectionPathFromRegistry(System.String,System.String)')
  - [GetProfileFilePathRegistryKeyPathname(companyName,productName)](#M-MFR-Settings-Profiles-Providers-Actions-Obtain-GetProfileFilePathRegistryKeyPathname-System-String,System-String- 'MFR.Settings.Profiles.Providers.Actions.Obtain.GetProfileFilePathRegistryKeyPathname(System.String,System.String)')
  - [ProfileCollectionFilePath(companyName,productName,currentPathname)](#M-MFR-Settings-Profiles-Providers-Actions-Obtain-ProfileCollectionFilePath-System-String,System-String,System-String- 'MFR.Settings.Profiles.Providers.Actions.Obtain.ProfileCollectionFilePath(System.String,System.String,System.String)')
- [Resources](#T-MFR-Settings-Profiles-Providers-Actions-Properties-Resources 'MFR.Settings.Profiles.Providers.Actions.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Providers-Actions-Properties-Resources-Culture 'MFR.Settings.Profiles.Providers.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Providers-Actions-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Providers.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Providers-Actions-Obtain'></a>
## Obtain `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions

##### Summary

Exposes static methods to obtain and formulate various values.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Obtain-GetDefaultProfileCollectionPathname-System-String,System-String-'></a>
### GetDefaultProfileCollectionPathname(companyName,productName) `method`

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

##### Remarks

Configuration profiles let the user save a set of their previously-used
settings to easily recall for later use.



If an error occurred, or if required information is missing, during the
operation, then this method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Obtain-GetProfileCollectionPathFromRegistry-System-String,System-String-'></a>
### GetProfileCollectionPathFromRegistry(companyName,productName) `method`

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

##### Remarks

Configuration profiles let the user save a set of their previously-used
settings to easily recall for later use.



If an error occurred, or if required information is missing, during the
operation, then this method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Obtain-GetProfileFilePathRegistryKeyPathname-System-String,System-String-'></a>
### GetProfileFilePathRegistryKeyPathname(companyName,productName) `method`

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
| currentPathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

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
