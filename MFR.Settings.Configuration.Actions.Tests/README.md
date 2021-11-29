<a name='assembly'></a>
# MFR.Settings.Configuration.Actions.Tests

## Contents

- [LoadConfigurationFilePathFromRegistryActionTests](#T-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests')
  - [Test_CanSuccessfullyObtain_AppConfigFilePath()](#M-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Test_CanSuccessfullyObtain_AppConfigFilePath 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests.Test_CanSuccessfullyObtain_AppConfigFilePath')
- [LoadConfigurationFromFileActionTests](#T-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFromFileActionTests 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFromFileActionTests')
  - [Test_ConfigurationFileLoadedSuccessfully_GivenValidPath()](#M-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFromFileActionTests-Test_ConfigurationFileLoadedSuccessfully_GivenValidPath 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFromFileActionTests.Test_ConfigurationFileLoadedSuccessfully_GivenValidPath')
- [Resources](#T-MFR-Settings-Configuration-Actions-Tests-Properties-Resources 'MFR.Settings.Configuration.Actions.Tests.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Actions-Tests-Properties-Resources-Culture 'MFR.Settings.Configuration.Actions.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Actions-Tests-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Actions.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests'></a>
## LoadConfigurationFilePathFromRegistryActionTests `type`

##### Namespace

MFR.Settings.Configuration.Actions.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[LoadStringFromRegistryAction](#T-MFR-LoadStringFromRegistryAction 'MFR.LoadStringFromRegistryAction')
class.

<a name='M-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Test_CanSuccessfullyObtain_AppConfigFilePath'></a>
### Test_CanSuccessfullyObtain_AppConfigFilePath() `method`

##### Summary

Asserts that the
[Execute](#M-MFR-LoadStringFromRegistryAction-Execute 'MFR.LoadStringFromRegistryAction.Execute')
method
correctly loads a path from the system Registry.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFromFileActionTests'></a>
## LoadConfigurationFromFileActionTests `type`

##### Namespace

MFR.Settings.Configuration.Actions.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[LoadConfigurationFromFileAction](#T-MFR-LoadConfigurationFromFileAction 'MFR.LoadConfigurationFromFileAction')
class.

<a name='M-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFromFileActionTests-Test_ConfigurationFileLoadedSuccessfully_GivenValidPath'></a>
### Test_ConfigurationFileLoadedSuccessfully_GivenValidPath() `method`

##### Summary

Asserts that a valid instance of an object that implements the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface will be loaded from
the configuration file for the application, provided that a valid
path has been supplied as input to the loading action.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Actions-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Actions.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Actions-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Actions-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
