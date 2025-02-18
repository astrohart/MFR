<a name='assembly'></a>
# MFR.CommandLine.Translators

## Contents

- [Resources](#T-MFR-CommandLine-Translators-Properties-Resources 'MFR.CommandLine.Translators.Properties.Resources')
  - [Culture](#P-MFR-CommandLine-Translators-Properties-Resources-Culture 'MFR.CommandLine.Translators.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-CommandLine-Translators-Properties-Resources-ResourceManager 'MFR.CommandLine.Translators.Properties.Resources.ResourceManager')
- [TranslateCommandLineInfo](#T-MFR-CommandLine-Translators-TranslateCommandLineInfo 'MFR.CommandLine.Translators.TranslateCommandLineInfo')
  - [ConfigProvider](#P-MFR-CommandLine-Translators-TranslateCommandLineInfo-ConfigProvider 'MFR.CommandLine.Translators.TranslateCommandLineInfo.ConfigProvider')
  - [CurrentConfig](#P-MFR-CommandLine-Translators-TranslateCommandLineInfo-CurrentConfig 'MFR.CommandLine.Translators.TranslateCommandLineInfo.CurrentConfig')
  - [ToConfiguration(cmdInfo)](#M-MFR-CommandLine-Translators-TranslateCommandLineInfo-ToConfiguration-MFR-CommandLine-Models-Interfaces-ICommandLineInfo- 'MFR.CommandLine.Translators.TranslateCommandLineInfo.ToConfiguration(MFR.CommandLine.Models.Interfaces.ICommandLineInfo)')

<a name='T-MFR-CommandLine-Translators-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.CommandLine.Translators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-CommandLine-Translators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-CommandLine-Translators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-CommandLine-Translators-TranslateCommandLineInfo'></a>
## TranslateCommandLineInfo `type`

##### Namespace

MFR.CommandLine.Translators

##### Summary

Exposes extension methods for objects that implement the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface.

##### Remarks

The methods in this class translate objects that implement the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface
into instances of objects of other types, such as an instance of an object that
implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface, for example.

<a name='P-MFR-CommandLine-Translators-TranslateCommandLineInfo-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

##### Remarks

This object allows access to the user config and the
actions
associated with it.

<a name='P-MFR-CommandLine-Translators-TranslateCommandLineInfo-CurrentConfig'></a>
### CurrentConfig `property`

##### Summary

Gets or sets a reference to the one and only instance of the object that
implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface that represents the currently-loaded config.

<a name='M-MFR-CommandLine-Translators-TranslateCommandLineInfo-ToConfiguration-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-'></a>
### ToConfiguration(cmdInfo) `method`

##### Summary

Translates an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface
to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

##### Returns

Reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface
whose properties have been initialized with the values specified in the
properties of the `cmdInfo` object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cmdInfo | [MFR.CommandLine.Models.Interfaces.ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') | (Required.) Reference to an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface. |
