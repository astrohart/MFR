<a name='assembly'></a>
# MFR.Settings.Configuration.Events

## Contents

- [ConfigurationExportedEventArgs](#T-MFR-Settings-Configuration-Events-ConfigurationExportedEventArgs 'MFR.Settings.Configuration.Events.ConfigurationExportedEventArgs')
  - [#ctor(path)](#M-MFR-Settings-Configuration-Events-ConfigurationExportedEventArgs-#ctor-System-String- 'MFR.Settings.Configuration.Events.ConfigurationExportedEventArgs.#ctor(System.String)')
  - [Path](#P-MFR-Settings-Configuration-Events-ConfigurationExportedEventArgs-Path 'MFR.Settings.Configuration.Events.ConfigurationExportedEventArgs.Path')
- [ConfigurationExportedEventHandler](#T-MFR-Settings-Configuration-Events-ConfigurationExportedEventHandler 'MFR.Settings.Configuration.Events.ConfigurationExportedEventHandler')
- [ConfigurationImportedEventArgs](#T-MFR-Settings-Configuration-Events-ConfigurationImportedEventArgs 'MFR.Settings.Configuration.Events.ConfigurationImportedEventArgs')
  - [#ctor(path)](#M-MFR-Settings-Configuration-Events-ConfigurationImportedEventArgs-#ctor-System-String- 'MFR.Settings.Configuration.Events.ConfigurationImportedEventArgs.#ctor(System.String)')
  - [Path](#P-MFR-Settings-Configuration-Events-ConfigurationImportedEventArgs-Path 'MFR.Settings.Configuration.Events.ConfigurationImportedEventArgs.Path')
- [ConfigurationImportedEventHandler](#T-MFR-Settings-Configuration-Events-ConfigurationImportedEventHandler 'MFR.Settings.Configuration.Events.ConfigurationImportedEventHandler')
- [Resources](#T-MFR-Settings-Configuration-Events-Properties-Resources 'MFR.Settings.Configuration.Events.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Events-Properties-Resources-Culture 'MFR.Settings.Configuration.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Events-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Events.Properties.Resources.ResourceManager')
- [StartingFolderChangedEventArgs](#T-MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs 'MFR.Settings.Configuration.Events.StartingFolderChangedEventArgs')
  - [#ctor(oldPath,newPath)](#M-MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs-#ctor-System-String,System-String- 'MFR.Settings.Configuration.Events.StartingFolderChangedEventArgs.#ctor(System.String,System.String)')
  - [NewPath](#P-MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs-NewPath 'MFR.Settings.Configuration.Events.StartingFolderChangedEventArgs.NewPath')
  - [OldPath](#P-MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs-OldPath 'MFR.Settings.Configuration.Events.StartingFolderChangedEventArgs.OldPath')
- [StartingFolderChangedEventHandler](#T-MFR-Settings-Configuration-Events-StartingFolderChangedEventHandler 'MFR.Settings.Configuration.Events.StartingFolderChangedEventHandler')

<a name='T-MFR-Settings-Configuration-Events-ConfigurationExportedEventArgs'></a>
## ConfigurationExportedEventArgs `type`

##### Namespace

MFR.Settings.Configuration.Events

##### Summary

Provides information for ConfigurationExported event handlers.

<a name='M-MFR-Settings-Configuration-Events-ConfigurationExportedEventArgs-#ctor-System-String-'></a>
### #ctor(path) `constructor`

##### Summary

Constructs a new instance of [ConfigurationExportedEventArgs](#T-MFR-Settings-Configuration-Events-ConfigurationExportedEventArgs 'MFR.Settings.Configuration.Events.ConfigurationExportedEventArgs')
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

<a name='P-MFR-Settings-Configuration-Events-ConfigurationExportedEventArgs-Path'></a>
### Path `property`

##### Summary

Gets a string containing the pathname to the file where the
configuration data was exported to.

<a name='T-MFR-Settings-Configuration-Events-ConfigurationExportedEventHandler'></a>
## ConfigurationExportedEventHandler `type`

##### Namespace

MFR.Settings.Configuration.Events

##### Summary

Represents a handler for an ConfigurationExported event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Settings.Configuration.Events.ConfigurationExportedEventHandler](#T-T-MFR-Settings-Configuration-Events-ConfigurationExportedEventHandler 'T:MFR.Settings.Configuration.Events.ConfigurationExportedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle
the ConfigurationExported event.

<a name='T-MFR-Settings-Configuration-Events-ConfigurationImportedEventArgs'></a>
## ConfigurationImportedEventArgs `type`

##### Namespace

MFR.Settings.Configuration.Events

##### Summary

Defines the data that is passed by all events of type [ConfigurationImportedEventHandler](#T-MFR-Settings-Configuration-Events-ConfigurationImportedEventHandler 'MFR.Settings.Configuration.Events.ConfigurationImportedEventHandler').

<a name='M-MFR-Settings-Configuration-Events-ConfigurationImportedEventArgs-#ctor-System-String-'></a>
### #ctor(path) `constructor`

##### Summary

Creates a new instance of [ConfigurationImportedEventArgs](#T-MFR-Settings-Configuration-Events-ConfigurationImportedEventArgs 'MFR.Settings.Configuration.Events.ConfigurationImportedEventArgs')
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

<a name='P-MFR-Settings-Configuration-Events-ConfigurationImportedEventArgs-Path'></a>
### Path `property`

##### Summary

Gets a string containing the path to the file that was imported.

<a name='T-MFR-Settings-Configuration-Events-ConfigurationImportedEventHandler'></a>
## ConfigurationImportedEventHandler `type`

##### Namespace

MFR.Settings.Configuration.Events

##### Summary

Defines the method signature for the handlers of a ConfigurationImported event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Settings.Configuration.Events.ConfigurationImportedEventHandler](#T-T-MFR-Settings-Configuration-Events-ConfigurationImportedEventHandler 'T:MFR.Settings.Configuration.Events.ConfigurationImportedEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-MFR-Settings-Configuration-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs'></a>
## StartingFolderChangedEventArgs `type`

##### Namespace

MFR.Settings.Configuration.Events

##### Summary

Provides information for `StartingFolderChanged` event handlers.

<a name='M-MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs-#ctor-System-String,System-String-'></a>
### #ctor(oldPath,newPath) `constructor`

##### Summary

Constructs a new instance of
[StartingFolderChangedEventArgs](#T-MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs 'MFR.Settings.Configuration.Events.StartingFolderChangedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| oldPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the former value of
the fully-qualified pathname of the folder in which this application's
operations are started. |
| newPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the current value of
the fully-qualified pathname  of the folder in which this application's
operations are started. |

<a name='P-MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs-NewPath'></a>
### NewPath `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the current value of the
fully-qualified pathname of the folder in which this application's operations
are started.

<a name='P-MFR-Settings-Configuration-Events-StartingFolderChangedEventArgs-OldPath'></a>
### OldPath `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') tha contains the former value of the
fully-qualified pathname of the folder in which this application's operations
are started.

<a name='T-MFR-Settings-Configuration-Events-StartingFolderChangedEventHandler'></a>
## StartingFolderChangedEventHandler `type`

##### Namespace

MFR.Settings.Configuration.Events

##### Summary

Represents a handler for a `StartingFolderChanged` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.Settings.Configuration.Events.StartingFolderChangedEventHandler](#T-T-MFR-Settings-Configuration-Events-StartingFolderChangedEventHandler 'T:MFR.Settings.Configuration.Events.StartingFolderChangedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`StartingFolderChanged` event.
