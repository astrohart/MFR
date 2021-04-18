<a name='assembly'></a>
# MFR.Objects.Messages.Actions.Tests

## Contents

- [LoadConfigurationFromFileActionTests](#T-MFR-Objects-Messages-Actions-Tests-LoadConfigurationFromFileActionTests 'MFR.Objects.Messages.Actions.Tests.LoadConfigurationFromFileActionTests')
  - [Test_ConfigurationFileLoadedSuccessfully_GivenValidPath()](#M-MFR-Objects-Messages-Actions-Tests-LoadConfigurationFromFileActionTests-Test_ConfigurationFileLoadedSuccessfully_GivenValidPath 'MFR.Objects.Messages.Actions.Tests.LoadConfigurationFromFileActionTests.Test_ConfigurationFileLoadedSuccessfully_GivenValidPath')
- [LoadStringFromRegistryActionTests](#T-MFR-Objects-Messages-Actions-Tests-LoadStringFromRegistryActionTests 'MFR.Objects.Messages.Actions.Tests.LoadStringFromRegistryActionTests')
  - [Test_CanSuccessfullyObtain_AppConfigFilePath()](#M-MFR-Objects-Messages-Actions-Tests-LoadStringFromRegistryActionTests-Test_CanSuccessfullyObtain_AppConfigFilePath 'MFR.Objects.Messages.Actions.Tests.LoadStringFromRegistryActionTests.Test_CanSuccessfullyObtain_AppConfigFilePath')
- [Resources](#T-MFR-Objects-Messages-Actions-Tests-Properties-Resources 'MFR.Objects.Messages.Actions.Tests.Properties.Resources')
  - [Culture](#P-MFR-Objects-Messages-Actions-Tests-Properties-Resources-Culture 'MFR.Objects.Messages.Actions.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Messages-Actions-Tests-Properties-Resources-ResourceManager 'MFR.Objects.Messages.Actions.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Messages-Actions-Tests-LoadConfigurationFromFileActionTests'></a>
## LoadConfigurationFromFileActionTests `type`

##### Namespace

MFR.Objects.Messages.Actions.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[LoadConfigurationFromFileAction](#T-MFR-Objects-LoadConfigurationFromFileAction 'MFR.Objects.LoadConfigurationFromFileAction')
class.

<a name='M-MFR-Objects-Messages-Actions-Tests-LoadConfigurationFromFileActionTests-Test_ConfigurationFileLoadedSuccessfully_GivenValidPath'></a>
### Test_ConfigurationFileLoadedSuccessfully_GivenValidPath() `method`

##### Summary

Asserts that a valid instance of an object that implements the
[IConfiguration](#T-MFR-Objects-IConfiguration 'MFR.Objects.IConfiguration')
interface will be
loaded from the configuration file for the application, provided
that a valid path has been supplied as input to the loading action.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Messages-Actions-Tests-LoadStringFromRegistryActionTests'></a>
## LoadStringFromRegistryActionTests `type`

##### Namespace

MFR.Objects.Messages.Actions.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[LoadStringFromRegistryAction](#T-MFR-Objects-LoadStringFromRegistryAction 'MFR.Objects.LoadStringFromRegistryAction')
class.

<a name='M-MFR-Objects-Messages-Actions-Tests-LoadStringFromRegistryActionTests-Test_CanSuccessfullyObtain_AppConfigFilePath'></a>
### Test_CanSuccessfullyObtain_AppConfigFilePath() `method`

##### Summary

Asserts that the
[Execute](#M-MFR-Objects-LoadStringFromRegistryAction-Execute 'MFR.Objects.LoadStringFromRegistryAction.Execute')
method correctly loads a path from the system Registry.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Messages-Actions-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Messages.Actions.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Messages-Actions-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Messages-Actions-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
