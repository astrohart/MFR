<a name='assembly'></a>
# MFR.Configuration.Actions.Tests

## Contents

- [LoadConfigurationFromFileActionTests](#T-MFR-Objects-Configuration-Actions-Tests-LoadConfigurationFromFileActionTests 'MFR.Configuration.Actions.Tests.LoadConfigurationFromFileActionTests')
  - [Test_ConfigurationFileLoadedSuccessfully_GivenValidPath()](#M-MFR-Objects-Configuration-Actions-Tests-LoadConfigurationFromFileActionTests-Test_ConfigurationFileLoadedSuccessfully_GivenValidPath 'MFR.Configuration.Actions.Tests.LoadConfigurationFromFileActionTests.Test_ConfigurationFileLoadedSuccessfully_GivenValidPath')
- [LoadStringFromRegistryActionTests](#T-MFR-Objects-Configuration-Actions-Tests-LoadStringFromRegistryActionTests 'MFR.Configuration.Actions.Tests.LoadStringFromRegistryActionTests')
  - [Test_CanSuccessfullyObtain_AppConfigFilePath()](#M-MFR-Objects-Configuration-Actions-Tests-LoadStringFromRegistryActionTests-Test_CanSuccessfullyObtain_AppConfigFilePath 'MFR.Configuration.Actions.Tests.LoadStringFromRegistryActionTests.Test_CanSuccessfullyObtain_AppConfigFilePath')
- [Resources](#T-MFR-Objects-Configuration-Actions-Tests-Properties-Resources 'MFR.Configuration.Actions.Tests.Properties.Resources')
  - [Culture](#P-MFR-Objects-Configuration-Actions-Tests-Properties-Resources-Culture 'MFR.Configuration.Actions.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Configuration-Actions-Tests-Properties-Resources-ResourceManager 'MFR.Configuration.Actions.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Configuration-Actions-Tests-LoadConfigurationFromFileActionTests'></a>
## LoadConfigurationFromFileActionTests `type`

##### Namespace

MFR.Configuration.Actions.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[LoadConfigurationFromFileAction](#T-MFR-Objects-LoadConfigurationFromFileAction 'MFR.LoadConfigurationFromFileAction')
class.

<a name='M-MFR-Objects-Configuration-Actions-Tests-LoadConfigurationFromFileActionTests-Test_ConfigurationFileLoadedSuccessfully_GivenValidPath'></a>
### Test_ConfigurationFileLoadedSuccessfully_GivenValidPath() `method`

##### Summary

Asserts that a valid instance of an object that implements the
[IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.IConfiguration')
interface will be loaded from
the configuration file for the application, provided that a valid
path has been supplied as input to the loading action.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Configuration-Actions-Tests-LoadStringFromRegistryActionTests'></a>
## LoadStringFromRegistryActionTests `type`

##### Namespace

MFR.Configuration.Actions.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[LoadStringFromRegistryAction](#T-MFR-Objects-LoadStringFromRegistryAction 'MFR.LoadStringFromRegistryAction')
class.

<a name='M-MFR-Objects-Configuration-Actions-Tests-LoadStringFromRegistryActionTests-Test_CanSuccessfullyObtain_AppConfigFilePath'></a>
### Test_CanSuccessfullyObtain_AppConfigFilePath() `method`

##### Summary

Asserts that the
[Execute](#M-MFR-Objects-LoadStringFromRegistryAction-Execute 'MFR.LoadStringFromRegistryAction.Execute')
method
correctly loads a path from the system Registry.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Configuration-Actions-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Configuration.Actions.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Configuration-Actions-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Configuration-Actions-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.