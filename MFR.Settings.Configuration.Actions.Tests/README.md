<a name='assembly'></a>
# MFR.Settings.Configuration.Actions.Tests

## Contents

- [Get](#T-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Get 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests.Get')
  - [LOG_FILE_PATH_TERMINATOR](#F-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Get-LOG_FILE_PATH_TERMINATOR 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests.Get.LOG_FILE_PATH_TERMINATOR')
  - [AssemblyCompany](#P-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Get-AssemblyCompany 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests.Get.AssemblyCompany')
  - [AssemblyProduct](#P-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Get-AssemblyProduct 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests.Get.AssemblyProduct')
  - [AssemblyTitle](#P-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Get-AssemblyTitle 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests.Get.AssemblyTitle')
  - [ApplicationProductName()](#M-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Get-ApplicationProductName 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests.Get.ApplicationProductName')
  - [LogFilePath()](#M-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Get-LogFilePath 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests.Get.LogFilePath')
- [LoadConfigurationFilePathFromRegistryActionTests](#T-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests')
  - [#ctor()](#M-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-#ctor 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests.#ctor')
  - [AccessTheRegueryExpressionValidator](#P-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-AccessTheRegueryExpressionValidator 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests.AccessTheRegueryExpressionValidator')
  - [Test_CanSuccessfullyObtain_AppConfigFilePath()](#M-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Test_CanSuccessfullyObtain_AppConfigFilePath 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests.Test_CanSuccessfullyObtain_AppConfigFilePath')
- [LoadConfigurationFromFileActionTests](#T-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFromFileActionTests 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFromFileActionTests')
  - [Test_ConfigurationFileLoadedSuccessfully_GivenValidPath()](#M-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFromFileActionTests-Test_ConfigurationFileLoadedSuccessfully_GivenValidPath 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFromFileActionTests.Test_ConfigurationFileLoadedSuccessfully_GivenValidPath')
- [Resources](#T-MFR-Settings-Configuration-Actions-Tests-Properties-Resources 'MFR.Settings.Configuration.Actions.Tests.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Actions-Tests-Properties-Resources-Culture 'MFR.Settings.Configuration.Actions.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Actions-Tests-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Actions.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Get'></a>
## Get `type`

##### Namespace

MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests

##### Summary

Exposes static methods to obtain data from various data sources.

<a name='F-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Get-LOG_FILE_PATH_TERMINATOR'></a>
### LOG_FILE_PATH_TERMINATOR `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final piece of the path of the
log file.

<a name='P-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Get-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyCompany](#P-AssemblyMetadata-AssemblyCompany 'AssemblyMetadata.AssemblyCompany') property.

<a name='P-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Get-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyProduct](#P-AssemblyMetadata-AssemblyProduct 'AssemblyMetadata.AssemblyProduct') property.

<a name='P-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Get-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the assembly title defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyTitle](#P-AssemblyMetadata-AssemblyTitle 'AssemblyMetadata.AssemblyTitle') property.

<a name='M-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Get-ApplicationProductName'></a>
### ApplicationProductName() `method`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for
the software product of which this application or class library is a part.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name
for the software product of which this application or class library is a part.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-Get-LogFilePath'></a>
### LogFilePath() `method`

##### Summary

Obtains a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests'></a>
## LoadConfigurationFilePathFromRegistryActionTests `type`

##### Namespace

MFR.Settings.Configuration.Actions.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[LoadStringFromRegistryAction](#T-MFR-LoadStringFromRegistryAction 'MFR.LoadStringFromRegistryAction')
class.

<a name='M-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[LoadConfigurationFilePathFromRegistryActionTests](#T-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests 'MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Configuration-Actions-Tests-LoadConfigurationFilePathFromRegistryActionTests-AccessTheRegueryExpressionValidator'></a>
### AccessTheRegueryExpressionValidator `property`

##### Summary

Gets the one and only instance of the Registry query expression validator that
read [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') values  from the system Registry.

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
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface will be loaded from
the config file for the application, provided that a valid
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
