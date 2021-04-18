<a name='assembly'></a>
# MFR.Objects.Configuration.Events

## Contents

- [ConfigurationExportedEventArgs](#T-MFR-Objects-Configuration-Events-ConfigurationExportedEventArgs 'MFR.Objects.Configuration.Events.ConfigurationExportedEventArgs')
  - [#ctor(path)](#M-MFR-Objects-Configuration-Events-ConfigurationExportedEventArgs-#ctor-System-String- 'MFR.Objects.Configuration.Events.ConfigurationExportedEventArgs.#ctor(System.String)')
  - [Path](#P-MFR-Objects-Configuration-Events-ConfigurationExportedEventArgs-Path 'MFR.Objects.Configuration.Events.ConfigurationExportedEventArgs.Path')
- [ConfigurationExportedEventHandler](#T-MFR-Objects-Configuration-Events-ConfigurationExportedEventHandler 'MFR.Objects.Configuration.Events.ConfigurationExportedEventHandler')
- [ConfigurationImportedEventArgs](#T-MFR-Objects-Configuration-Events-ConfigurationImportedEventArgs 'MFR.Objects.Configuration.Events.ConfigurationImportedEventArgs')
  - [#ctor(path)](#M-MFR-Objects-Configuration-Events-ConfigurationImportedEventArgs-#ctor-System-String- 'MFR.Objects.Configuration.Events.ConfigurationImportedEventArgs.#ctor(System.String)')
  - [Path](#P-MFR-Objects-Configuration-Events-ConfigurationImportedEventArgs-Path 'MFR.Objects.Configuration.Events.ConfigurationImportedEventArgs.Path')
- [ConfigurationImportedEventHandler](#T-MFR-Objects-Configuration-Events-ConfigurationImportedEventHandler 'MFR.Objects.Configuration.Events.ConfigurationImportedEventHandler')
- [Resources](#T-MFR-Objects-Configuration-Events-Properties-Resources 'MFR.Objects.Configuration.Events.Properties.Resources')
  - [Culture](#P-MFR-Objects-Configuration-Events-Properties-Resources-Culture 'MFR.Objects.Configuration.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Configuration-Events-Properties-Resources-ResourceManager 'MFR.Objects.Configuration.Events.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Configuration-Events-ConfigurationExportedEventArgs'></a>
## ConfigurationExportedEventArgs `type`

##### Namespace

MFR.Objects.Configuration.Events

##### Summary

Provides information for ConfigurationExported event handlers.

<a name='M-MFR-Objects-Configuration-Events-ConfigurationExportedEventArgs-#ctor-System-String-'></a>
### #ctor(path) `constructor`

##### Summary

Constructs a new instance of [ConfigurationExportedEventArgs](#T-MFR-Objects-Configuration-Events-ConfigurationExportedEventArgs 'MFR.Objects.Configuration.Events.ConfigurationExportedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname to the file where
configuration data was exported to. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `path`, is passed
a blank or `null` value. |

<a name='P-MFR-Objects-Configuration-Events-ConfigurationExportedEventArgs-Path'></a>
### Path `property`

##### Summary

Gets a string containing the pathname to the file where the
configuration data was exported to.

<a name='T-MFR-Objects-Configuration-Events-ConfigurationExportedEventHandler'></a>
## ConfigurationExportedEventHandler `type`

##### Namespace

MFR.Objects.Configuration.Events

##### Summary

Represents a handler for an ConfigurationExported event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Objects.Configuration.Events.ConfigurationExportedEventHandler](#T-T-MFR-Objects-Configuration-Events-ConfigurationExportedEventHandler 'T:MFR.Objects.Configuration.Events.ConfigurationExportedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle
the ConfigurationExported event.

<a name='T-MFR-Objects-Configuration-Events-ConfigurationImportedEventArgs'></a>
## ConfigurationImportedEventArgs `type`

##### Namespace

MFR.Objects.Configuration.Events

##### Summary

Defines the data that is passed by all events of type [ConfigurationImportedEventHandler](#T-MFR-Objects-Configuration-Events-ConfigurationImportedEventHandler 'MFR.Objects.Configuration.Events.ConfigurationImportedEventHandler').

<a name='M-MFR-Objects-Configuration-Events-ConfigurationImportedEventArgs-#ctor-System-String-'></a>
### #ctor(path) `constructor`

##### Summary

Creates a new instance of [ConfigurationImportedEventArgs](#T-MFR-Objects-Configuration-Events-ConfigurationImportedEventArgs 'MFR.Objects.Configuration.Events.ConfigurationImportedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the path of the imported file. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `path`, is passed
a blank or `null` value. |

<a name='P-MFR-Objects-Configuration-Events-ConfigurationImportedEventArgs-Path'></a>
### Path `property`

##### Summary

Gets a string containing the path to the file that was imported.

<a name='T-MFR-Objects-Configuration-Events-ConfigurationImportedEventHandler'></a>
## ConfigurationImportedEventHandler `type`

##### Namespace

MFR.Objects.Configuration.Events

##### Summary

Defines the method signature for the handlers of a ConfigurationImported event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Objects.Configuration.Events.ConfigurationImportedEventHandler](#T-T-MFR-Objects-Configuration-Events-ConfigurationImportedEventHandler 'T:MFR.Objects.Configuration.Events.ConfigurationImportedEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-MFR-Objects-Configuration-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Configuration.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Configuration-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Configuration-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
