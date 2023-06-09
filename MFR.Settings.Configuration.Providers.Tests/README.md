<a name='assembly'></a>
# MFR.Settings.Configuration.Providers.Tests

## Contents

- [Get](#T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Get 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests.Get')
  - [LOG_FILE_PATH_TERMINATOR](#F-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Get-LOG_FILE_PATH_TERMINATOR 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests.Get.LOG_FILE_PATH_TERMINATOR')
  - [AssemblyCompany](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Get-AssemblyCompany 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests.Get.AssemblyCompany')
  - [AssemblyProduct](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Get-AssemblyProduct 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests.Get.AssemblyProduct')
  - [AssemblyTitle](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Get-AssemblyTitle 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests.Get.AssemblyTitle')
  - [ApplicationProductName()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Get-ApplicationProductName 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests.Get.ApplicationProductName')
  - [LogFilePath()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Get-LogFilePath 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests.Get.LogFilePath')
- [ProjectFileRenamerConfigurationProviderTests](#T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests')
  - [#ctor()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-#ctor 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests.#ctor')
  - [CurrentConfiguration](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-CurrentConfiguration 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests.CurrentConfiguration')
  - [ProjectFileRenamerConfigurationProvider](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-ProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests.ProjectFileRenamerConfigurationProvider')
  - [InitializeProjectFileRenamerConfigurationProvider()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-InitializeProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests.InitializeProjectFileRenamerConfigurationProvider')
  - [Test_Load_Works()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Test_Load_Works 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests.Test_Load_Works')
- [Resources](#T-MFR-Settings-Configuration-Providers-Tests-Properties-Resources 'MFR.Settings.Configuration.Providers.Tests.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Providers-Tests-Properties-Resources-Culture 'MFR.Settings.Configuration.Providers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Providers-Tests-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Providers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Get'></a>
## Get `type`

##### Namespace

MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests

##### Summary

Exposes static methods to obtain data from various data sources.

<a name='F-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Get-LOG_FILE_PATH_TERMINATOR'></a>
### LOG_FILE_PATH_TERMINATOR `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final piece of the path of the
log file.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Get-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyCompany](#P-AssemblyMetadata-AssemblyCompany 'AssemblyMetadata.AssemblyCompany') property.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Get-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyProduct](#P-AssemblyMetadata-AssemblyProduct 'AssemblyMetadata.AssemblyProduct') property.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Get-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the assembly title defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyTitle](#P-AssemblyMetadata-AssemblyTitle 'AssemblyMetadata.AssemblyTitle') property.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Get-ApplicationProductName'></a>
### ApplicationProductName() `method`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for
the software product of which this application or class library is a part.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name
for the software product of which this application or class library is a part.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Get-LogFilePath'></a>
### LogFilePath() `method`

##### Summary

Obtains a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests'></a>
## ProjectFileRenamerConfigurationProviderTests `type`

##### Namespace

MFR.Settings.Configuration.Providers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider')
class.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ProjectFileRenamerConfigurationProviderTests](#T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration')
interface that allows access to the currently-loaded application configuration.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-ProjectFileRenamerConfigurationProvider'></a>
### ProjectFileRenamerConfigurationProvider `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider')
interface that provides access to this application's configuration.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-InitializeProjectFileRenamerConfigurationProvider'></a>
### InitializeProjectFileRenamerConfigurationProvider() `method`

##### Summary

Initializes the project file renamer configuration provider object.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigurationProviderTests-Test_Load_Works'></a>
### Test_Load_Works() `method`

##### Summary

Asserts that the
[Load](#M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-Load 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.Load')
method functions properly and actually loads a configuration object.

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
