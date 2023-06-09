<a name='assembly'></a>
# MFR.Settings.Configuration.Providers.Events

## Contents

- [ConfigurationFilePathChangedEventArgs](#T-MFR-Settings-Configuration-Providers-Events-ConfigurationFilePathChangedEventArgs 'MFR.Settings.Configuration.Providers.Events.ConfigurationFilePathChangedEventArgs')
  - [#ctor(pathname)](#M-MFR-Settings-Configuration-Providers-Events-ConfigurationFilePathChangedEventArgs-#ctor-System-String- 'MFR.Settings.Configuration.Providers.Events.ConfigurationFilePathChangedEventArgs.#ctor(System.String)')
  - [Pathname](#P-MFR-Settings-Configuration-Providers-Events-ConfigurationFilePathChangedEventArgs-Pathname 'MFR.Settings.Configuration.Providers.Events.ConfigurationFilePathChangedEventArgs.Pathname')
- [ConfigurationFilePathChangedEventHandler](#T-MFR-Settings-Configuration-Providers-Events-ConfigurationFilePathChangedEventHandler 'MFR.Settings.Configuration.Providers.Events.ConfigurationFilePathChangedEventHandler')
- [Resources](#T-MFR-Settings-Configuration-Providers-Events-Properties-Resources 'MFR.Settings.Configuration.Providers.Events.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Providers-Events-Properties-Resources-Culture 'MFR.Settings.Configuration.Providers.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Providers-Events-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Providers.Events.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Providers-Events-ConfigurationFilePathChangedEventArgs'></a>
## ConfigurationFilePathChangedEventArgs `type`

##### Namespace

MFR.Settings.Configuration.Providers.Events

##### Summary

Provides information for `ConfigurationFilePathChanged` event handlers.

<a name='M-MFR-Settings-Configuration-Providers-Events-ConfigurationFilePathChangedEventArgs-#ctor-System-String-'></a>
### #ctor(pathname) `constructor`

##### Summary

Constructs a new instance of
[ConfigurationFilePathChangedEventArgs](#T-MFR-Settings-Configuration-Providers-Events-ConfigurationFilePathChangedEventArgs 'MFR.Settings.Configuration.Providers.Events.ConfigurationFilePathChangedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the configuration file that was most recently loaded. |

<a name='P-MFR-Settings-Configuration-Providers-Events-ConfigurationFilePathChangedEventArgs-Pathname'></a>
### Pathname `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the configuration file that was most recently loaded.

<a name='T-MFR-Settings-Configuration-Providers-Events-ConfigurationFilePathChangedEventHandler'></a>
## ConfigurationFilePathChangedEventHandler `type`

##### Namespace

MFR.Settings.Configuration.Providers.Events

##### Summary

Represents a handler for a `ConfigurationFilePathChanged` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Settings.Configuration.Providers.Events.ConfigurationFilePathChangedEventHandler](#T-T-MFR-Settings-Configuration-Providers-Events-ConfigurationFilePathChangedEventHandler 'T:MFR.Settings.Configuration.Providers.Events.ConfigurationFilePathChangedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`ConfigurationFilePathChanged` event.

<a name='T-MFR-Settings-Configuration-Providers-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Providers.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Providers-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Providers-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
