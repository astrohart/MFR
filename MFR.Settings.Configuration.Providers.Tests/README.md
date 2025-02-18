<a name='assembly'></a>
# MFR.Settings.Configuration.Providers.Tests

## Contents

- [Get](#T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Get 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests.Get')
  - [LOG_FILE_PATH_TERMINATOR](#F-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Get-LOG_FILE_PATH_TERMINATOR 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests.Get.LOG_FILE_PATH_TERMINATOR')
  - [AssemblyCompany](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Get-AssemblyCompany 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests.Get.AssemblyCompany')
  - [AssemblyProduct](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Get-AssemblyProduct 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests.Get.AssemblyProduct')
  - [AssemblyTitle](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Get-AssemblyTitle 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests.Get.AssemblyTitle')
  - [ApplicationProductName()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Get-ApplicationProductName 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests.Get.ApplicationProductName')
  - [LogFilePath()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Get-LogFilePath 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests.Get.LogFilePath')
- [ProjectFileRenamerConfigProviderTests](#T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests')
  - [#ctor()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-#ctor 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests.#ctor')
  - [ConfigFilePath](#F-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-ConfigFilePath 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests.ConfigFilePath')
  - [CurrentConfig](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-CurrentConfig 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests.CurrentConfig')
  - [ProjectFileRenamerConfigProvider](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-ProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests.ProjectFileRenamerConfigProvider')
  - [#cctor()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-#cctor 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests.#cctor')
  - [Test_Load_Works()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Test_Load_Works 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests.Test_Load_Works')
- [Resources](#T-MFR-Settings-Configuration-Providers-Tests-Properties-Resources 'MFR.Settings.Configuration.Providers.Tests.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Providers-Tests-Properties-Resources-Culture 'MFR.Settings.Configuration.Providers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Providers-Tests-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Providers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Get'></a>
## Get `type`

##### Namespace

MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests

##### Summary

Exposes static methods to obtain data from various data sources.

<a name='F-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Get-LOG_FILE_PATH_TERMINATOR'></a>
### LOG_FILE_PATH_TERMINATOR `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final piece of the path of the
log file.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Get-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyCompany](#P-AssemblyMetadata-AssemblyCompany 'AssemblyMetadata.AssemblyCompany') property.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Get-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyProduct](#P-AssemblyMetadata-AssemblyProduct 'AssemblyMetadata.AssemblyProduct') property.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Get-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the assembly title defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyTitle](#P-AssemblyMetadata-AssemblyTitle 'AssemblyMetadata.AssemblyTitle') property.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Get-ApplicationProductName'></a>
### ApplicationProductName() `method`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for
the software product of which this application or class library is a part.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name
for the software product of which this application or class library is a part.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Get-LogFilePath'></a>
### LogFilePath() `method`

##### Summary

Obtains a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests'></a>
## ProjectFileRenamerConfigProviderTests `type`

##### Namespace

MFR.Settings.Configuration.Providers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-ProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider')
class.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ProjectFileRenamerConfigProviderTests](#T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-ConfigFilePath'></a>
### ConfigFilePath `constants`

##### Summary

Path to a sample config file.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-CurrentConfig'></a>
### CurrentConfig `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface that represents the currently-loaded (if any) config.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-ProjectFileRenamerConfigProvider'></a>
### ProjectFileRenamerConfigProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[ProjectFileRenamerConfigProviderTests](#T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigProviderTests')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenamerConfigProviderTests-Test_Load_Works'></a>
### Test_Load_Works() `method`

##### Summary

Asserts that the
[Load](#M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider-Load 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider.Load')
method works correctly.

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
