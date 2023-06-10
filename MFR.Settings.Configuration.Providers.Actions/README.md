<a name='assembly'></a>
# MFR.Settings.Configuration.Providers.Actions

## Contents

- [Formulate](#T-MFR-Settings-Configuration-Providers-Actions-Formulate 'MFR.Settings.Configuration.Providers.Actions.Formulate')
  - [DefaultConfigDir(companyName,productName)](#M-MFR-Settings-Configuration-Providers-Actions-Formulate-DefaultConfigDir-System-String,System-String- 'MFR.Settings.Configuration.Providers.Actions.Formulate.DefaultConfigDir(System.String,System.String)')
- [Resources](#T-MFR-Settings-Configuration-Providers-Actions-Properties-Resources 'MFR.Settings.Configuration.Providers.Actions.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Providers-Actions-Properties-Resources-Culture 'MFR.Settings.Configuration.Providers.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Providers-Actions-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Providers.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Providers-Actions-Formulate'></a>
## Formulate `type`

##### Namespace

MFR.Settings.Configuration.Providers.Actions

##### Summary

Exposes static methods to formulate values in response to the values of
parameters.

<a name='M-MFR-Settings-Configuration-Providers-Actions-Formulate-DefaultConfigDir-System-String,System-String-'></a>
### DefaultConfigDir(companyName,productName) `method`

##### Summary

Formulates the fully-qualified pathname of the folder that is the default
folder for storing the application's configuration file.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| companyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the company name associated with the application. |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the product name associated with the application. |

##### Remarks

If either the `companyName` or the
`productName` parameters have the blank or
`null`[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') passed to them as an
argument, then this method returns the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value.

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
