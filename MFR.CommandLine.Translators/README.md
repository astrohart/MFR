<a name='assembly'></a>
# MFR.CommandLine.Translators

## Contents

- [Resources](#T-MFR-CommandLine-Translators-Properties-Resources 'MFR.CommandLine.Translators.Properties.Resources')
  - [Culture](#P-MFR-CommandLine-Translators-Properties-Resources-Culture 'MFR.CommandLine.Translators.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-CommandLine-Translators-Properties-Resources-ResourceManager 'MFR.CommandLine.Translators.Properties.Resources.ResourceManager')
- [TranslateCommandLineInfo](#T-MFR-CommandLine-Translators-TranslateCommandLineInfo 'MFR.CommandLine.Translators.TranslateCommandLineInfo')
  - [ConfigurationProvider](#P-MFR-CommandLine-Translators-TranslateCommandLineInfo-ConfigurationProvider 'MFR.CommandLine.Translators.TranslateCommandLineInfo.ConfigurationProvider')
  - [CurrentConfiguration](#P-MFR-CommandLine-Translators-TranslateCommandLineInfo-CurrentConfiguration 'MFR.CommandLine.Translators.TranslateCommandLineInfo.CurrentConfiguration')
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
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface, for example.

<a name='P-MFR-CommandLine-Translators-TranslateCommandLineInfo-ConfigurationProvider'></a>
### ConfigurationProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider')
interface.

##### Remarks

This object allows access to the user projectFileRenamerConfiguration and the
actions
associated with it.

<a name='P-MFR-CommandLine-Translators-TranslateCommandLineInfo-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to the one and only instance of the object that
implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface that represents the currently-loaded configuration.

<a name='M-MFR-CommandLine-Translators-TranslateCommandLineInfo-ToConfiguration-MFR-CommandLine-Models-Interfaces-ICommandLineInfo-'></a>
### ToConfiguration(cmdInfo) `method`

##### Summary

Translates an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface
to an instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface.

##### Returns

Reference to an instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration') interface
whose properties have been initialized with the values specified in the
properties of the `cmdInfo` object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cmdInfo | [MFR.CommandLine.Models.Interfaces.ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') | (Required.) Reference to an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface. |
