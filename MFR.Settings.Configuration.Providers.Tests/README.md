<a name='assembly'></a>
# MFR.Settings.Configuration.Providers.Tests

## Contents

- [Get](#T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Get 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderfigurationProviderTests.Get')
  - [LOG_FILE_PATH_TERMINATOR](#F-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Get-LOG_FILE_PATH_TERMINATOR 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderfigurationProviderTests.Get.LOG_FILE_PATH_TERMINATOR')
  - [AssemblyCompany](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Get-AssemblyCompany 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderfigurationProviderTests.Get.AssemblyCompany')
  - [AssemblyProduct](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Get-AssemblyProduct 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderfigurationProviderTests.Get.AssemblyProduct')
  - [AssemblyTitle](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Get-AssemblyTitle 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderfigurationProviderTests.Get.AssemblyTitle')
  - [LogFilePath()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Get-LogFilePath 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderfigurationProviderTests.Get.LogFilePath')
- [ProjectFileRenamerConfigurationProviderfigurationProviderTests](#T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderfigurationProviderTests')
  - [ConfigFilePath](#F-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-ConfigFilePath 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderfigurationProviderTests.ConfigFilePath')
  - [CurrentConfiguration](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-CurrentConfiguration 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderfigurationProviderTests.CurrentConfiguration')
  - [Initialize()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Initialize 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderfigurationProviderTests.Initialize')
  - [Test_Load_Works()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Test_Load_Works 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderfigurationProviderTests.Test_Load_Works')
- [Resources](#T-MFR-Settings-Configuration-Providers-Tests-Properties-Resources 'MFR.Settings.Configuration.Providers.Tests.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Providers-Tests-Properties-Resources-Culture 'MFR.Settings.Configuration.Providers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Providers-Tests-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Providers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Get'></a>
## Get `type`

##### Namespace

MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderfigurationProviderTests

##### Summary

Exposes static methods to obtain data from various data sources.

<a name='F-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Get-LOG_FILE_PATH_TERMINATOR'></a>
### LOG_FILE_PATH_TERMINATOR `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final piece of the path of the
log file.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Get-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyCompany](#P-AssemblyMetadata-AssemblyCompany 'AssemblyMetadata.AssemblyCompany') property.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Get-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyProduct](#P-AssemblyMetadata-AssemblyProduct 'AssemblyMetadata.AssemblyProduct') property.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Get-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the assembly title defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyTitle](#P-AssemblyMetadata-AssemblyTitle 'AssemblyMetadata.AssemblyTitle') property.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Get-LogFilePath'></a>
### LogFilePath() `method`

##### Summary

Obtains a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests'></a>
## ProjectFileRenamerConfigurationProviderfigurationProviderTests `type`

##### Namespace

MFR.Settings.Configuration.Providers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider')
class.

<a name='F-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-ConfigFilePath'></a>
### ConfigFilePath `constants`

##### Summary

Path to a sample configuration file.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the state of this fixture for every unit test session.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderfigurationProviderTests-Test_Load_Works'></a>
### Test_Load_Works() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Providers-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Providers.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Providers-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Providers-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
