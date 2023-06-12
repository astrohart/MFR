<a name='assembly'></a>
# MFR.Settings.Configuration.Providers.Tests

## Contents

- [Get](#T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Get 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenmerConfigurationProviderTests.Get')
  - [LOG_FILE_PATH_TERMINATOR](#F-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Get-LOG_FILE_PATH_TERMINATOR 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenmerConfigurationProviderTests.Get.LOG_FILE_PATH_TERMINATOR')
  - [AssemblyCompany](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Get-AssemblyCompany 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenmerConfigurationProviderTests.Get.AssemblyCompany')
  - [AssemblyProduct](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Get-AssemblyProduct 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenmerConfigurationProviderTests.Get.AssemblyProduct')
  - [AssemblyTitle](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Get-AssemblyTitle 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenmerConfigurationProviderTests.Get.AssemblyTitle')
  - [ApplicationProductName()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Get-ApplicationProductName 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenmerConfigurationProviderTests.Get.ApplicationProductName')
  - [LogFilePath()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Get-LogFilePath 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenmerConfigurationProviderTests.Get.LogFilePath')
- [ProjectFileRenmerConfigurationProviderTests](#T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenmerConfigurationProviderTests')
  - [#ctor()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-#ctor 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenmerConfigurationProviderTests.#ctor')
  - [ConfigFilePath](#F-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-ConfigFilePath 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenmerConfigurationProviderTests.ConfigFilePath')
  - [ProjectFileRenamerConfigurationProvider](#P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-ProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenmerConfigurationProviderTests.ProjectFileRenamerConfigurationProvider')
  - [Test_Load_Works()](#M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Test_Load_Works 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenmerConfigurationProviderTests.Test_Load_Works')
- [Resources](#T-MFR-Settings-Configuration-Providers-Tests-Properties-Resources 'MFR.Settings.Configuration.Providers.Tests.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Providers-Tests-Properties-Resources-Culture 'MFR.Settings.Configuration.Providers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Providers-Tests-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Providers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Get'></a>
## Get `type`

##### Namespace

MFR.Settings.Configuration.Providers.Tests.ProjectFileRenmerConfigurationProviderTests

##### Summary

Exposes static methods to obtain data from various data sources.

<a name='F-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Get-LOG_FILE_PATH_TERMINATOR'></a>
### LOG_FILE_PATH_TERMINATOR `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final piece of the path of the
log file.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Get-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyCompany](#P-AssemblyMetadata-AssemblyCompany 'AssemblyMetadata.AssemblyCompany') property.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Get-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyProduct](#P-AssemblyMetadata-AssemblyProduct 'AssemblyMetadata.AssemblyProduct') property.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Get-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the assembly title defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyTitle](#P-AssemblyMetadata-AssemblyTitle 'AssemblyMetadata.AssemblyTitle') property.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Get-ApplicationProductName'></a>
### ApplicationProductName() `method`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for
the software product of which this application or class library is a part.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name
for the software product of which this application or class library is a part.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Get-LogFilePath'></a>
### LogFilePath() `method`

##### Summary

Obtains a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests'></a>
## ProjectFileRenmerConfigurationProviderTests `type`

##### Namespace

MFR.Settings.Configuration.Providers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ProjectFileRenmerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-ProjectFileRenmerConfigurationProvider 'MFR.Settings.Configuration.Providers.ProjectFileRenmerConfigurationProvider')
class.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ProjectFileRenmerConfigurationProviderTests](#T-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests 'MFR.Settings.Configuration.Providers.Tests.ProjectFileRenmerConfigurationProviderTests')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-ConfigFilePath'></a>
### ConfigFilePath `constants`

##### Summary

Path to a sample configuration file.

<a name='P-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-ProjectFileRenamerConfigurationProvider'></a>
### ProjectFileRenamerConfigurationProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProjectFileRenamerConfigurationProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider')
interface.

<a name='M-MFR-Settings-Configuration-Providers-Tests-ProjectFileRenmerConfigurationProviderTests-Test_Load_Works'></a>
### Test_Load_Works() `method`

##### Summary

Asserts that the
[Load](#M-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigurationProvider-Load 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.Load')
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
