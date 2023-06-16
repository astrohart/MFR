<a name='assembly'></a>
# MFR.Settings.Configuration.Constants.Actions

## Contents

- [Formulate](#T-MFR-Settings-Configuration-Constants-Actions-Formulate 'MFR.Settings.Configuration.Constants.Actions.Formulate')
  - [ConfigurationFilePathKeyName(companyName,productName)](#M-MFR-Settings-Configuration-Constants-Actions-Formulate-ConfigurationFilePathKeyName-System-String,System-String- 'MFR.Settings.Configuration.Constants.Actions.Formulate.ConfigurationFilePathKeyName(System.String,System.String)')
- [Resources](#T-MFR-Settings-Configuration-Constants-Actions-Properties-Resources 'MFR.Settings.Configuration.Constants.Actions.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Constants-Actions-Properties-Resources-Culture 'MFR.Settings.Configuration.Constants.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Constants-Actions-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Constants.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Constants-Actions-Formulate'></a>
## Formulate `type`

##### Namespace

MFR.Settings.Configuration.Constants.Actions

##### Summary

Exposes static methods to formulate [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') values.

<a name='M-MFR-Settings-Configuration-Constants-Actions-Formulate-ConfigurationFilePathKeyName-System-String,System-String-'></a>
### ConfigurationFilePathKeyName(companyName,productName) `method`

##### Summary

Formulates the fully-qualified Registry key pathname of the Registry key under
which the pathname of the configuration file is stored.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
Registry key pathname of the Registry key under which the pathname of the
configuration file is stored.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| companyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that represents the company name
that is associated with the application. |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that represents the product name
that is associated with the application. |

##### Remarks

If either of the `companyName` or
`productName` parameters' arguments are passed blank values
or `null` references, then this method returns the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

<a name='T-MFR-Settings-Configuration-Constants-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Constants.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Constants-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Constants-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
