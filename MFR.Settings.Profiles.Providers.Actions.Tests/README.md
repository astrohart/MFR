<a name='assembly'></a>
# MFR.Settings.Profiles.Providers.Actions.Tests

## Contents

- [Get](#T-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Get 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.Get')
  - [LOG_FILE_PATH_TERMINATOR](#F-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Get-LOG_FILE_PATH_TERMINATOR 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.Get.LOG_FILE_PATH_TERMINATOR')
  - [AssemblyCompany](#P-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Get-AssemblyCompany 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.Get.AssemblyCompany')
  - [AssemblyProduct](#P-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Get-AssemblyProduct 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.Get.AssemblyProduct')
  - [AssemblyTitle](#P-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Get-AssemblyTitle 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.Get.AssemblyTitle')
  - [ApplicationProductName()](#M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Get-ApplicationProductName 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.Get.ApplicationProductName')
  - [LogFilePath()](#M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Get-LogFilePath 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.Get.LogFilePath')
- [ObtainTests](#T-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests')
  - [#ctor()](#M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-#ctor 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.#ctor')
  - [CompanyName](#F-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-CompanyName 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.CompanyName')
  - [DefaultProfileCollectionPath](#F-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-DefaultProfileCollectionPath 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.DefaultProfileCollectionPath')
  - [ExpectedProfileCollectionPath](#F-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-ExpectedProfileCollectionPath 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.ExpectedProfileCollectionPath')
  - [ProductNameWithoutCompany](#F-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-ProductNameWithoutCompany 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.ProductNameWithoutCompany')
  - [Test_DefaultProfileCollectionPath_IsWellFormed_AndDoesNotThrowExceptions()](#M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Test_DefaultProfileCollectionPath_IsWellFormed_AndDoesNotThrowExceptions 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.Test_DefaultProfileCollectionPath_IsWellFormed_AndDoesNotThrowExceptions')
  - [Test_ExpectedProfileCollectionPath_IsWellFormed_AndDoesNotThrowExceptions()](#M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Test_ExpectedProfileCollectionPath_IsWellFormed_AndDoesNotThrowExceptions 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.Test_ExpectedProfileCollectionPath_IsWellFormed_AndDoesNotThrowExceptions')
  - [Test_Obtain_ProfileCollectionFilePath_Gets_PathOfFileThatIsNotBlank()](#M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Test_Obtain_ProfileCollectionFilePath_Gets_PathOfFileThatIsNotBlank 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.Test_Obtain_ProfileCollectionFilePath_Gets_PathOfFileThatIsNotBlank')
  - [Test_Obtain_ProfileCollectionFilePath_UsesInputtedFilePath_ThatExists_UsingDefaultValue()](#M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Test_Obtain_ProfileCollectionFilePath_UsesInputtedFilePath_ThatExists_UsingDefaultValue 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.Test_Obtain_ProfileCollectionFilePath_UsesInputtedFilePath_ThatExists_UsingDefaultValue')
  - [Test_Obtain_ProfileCollectionFilePath_UsesInputtedFilePath_ThatExists_WithNoDefaultProvided()](#M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Test_Obtain_ProfileCollectionFilePath_UsesInputtedFilePath_ThatExists_WithNoDefaultProvided 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.Test_Obtain_ProfileCollectionFilePath_UsesInputtedFilePath_ThatExists_WithNoDefaultProvided')
- [Read](#T-MFR-Settings-Profiles-Providers-Actions-Tests-Read 'MFR.Settings.Profiles.Providers.Actions.Tests.Read')
  - [RegistryValue(keyPath,valueName)](#M-MFR-Settings-Profiles-Providers-Actions-Tests-Read-RegistryValue-System-String,System-String- 'MFR.Settings.Profiles.Providers.Actions.Tests.Read.RegistryValue(System.String,System.String)')
- [Resources](#T-MFR-Settings-Profiles-Providers-Actions-Tests-Properties-Resources 'MFR.Settings.Profiles.Providers.Actions.Tests.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Providers-Actions-Tests-Properties-Resources-Culture 'MFR.Settings.Profiles.Providers.Actions.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Providers-Actions-Tests-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Providers.Actions.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Get'></a>
## Get `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests

##### Summary

Exposes static methods to obtain data from various data sources.

<a name='F-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Get-LOG_FILE_PATH_TERMINATOR'></a>
### LOG_FILE_PATH_TERMINATOR `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final piece of the path of the
log file.

<a name='P-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Get-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyCompany](#P-AssemblyMetadata-AssemblyCompany 'AssemblyMetadata.AssemblyCompany') property.

<a name='P-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Get-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyProduct](#P-AssemblyMetadata-AssemblyProduct 'AssemblyMetadata.AssemblyProduct') property.

<a name='P-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Get-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the assembly title defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyTitle](#P-AssemblyMetadata-AssemblyTitle 'AssemblyMetadata.AssemblyTitle') property.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Get-ApplicationProductName'></a>
### ApplicationProductName() `method`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for
the software product of which this application or class library is a part.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name
for the software product of which this application or class library is a part.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Get-LogFilePath'></a>
### LogFilePath() `method`

##### Summary

Obtains a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests'></a>
## ObtainTests `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[Obtain](#T-MFR-Settings-Profiles-Providers-Actions-Obtain 'MFR.Settings.Profiles.Providers.Actions.Obtain') class.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ObtainTests](#T-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests') and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-CompanyName'></a>
### CompanyName `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the application's company name.

<a name='F-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-DefaultProfileCollectionPath'></a>
### DefaultProfileCollectionPath `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the default place we, ideally,
want to store the user's profiles -- their local AppData directory.

<a name='F-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-ExpectedProfileCollectionPath'></a>
### ExpectedProfileCollectionPath `constants`

##### Summary

Keep this value updated with whatever is stored in the system Registry
under the ProfileCollectionPath value of the
Computer\HKEY_CURRENT_USER\SOFTWARE\xyLOGIX, LLC\Project File Renamer\Paths
Registry key.

<a name='F-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-ProductNameWithoutCompany'></a>
### ProductNameWithoutCompany `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the application's product name.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Test_DefaultProfileCollectionPath_IsWellFormed_AndDoesNotThrowExceptions'></a>
### Test_DefaultProfileCollectionPath_IsWellFormed_AndDoesNotThrowExceptions() `method`

##### Summary

Asserts that the
[DefaultProfileCollectionPath](#F-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-DefaultProfileCollectionPath 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.DefaultProfileCollectionPath')
field's value is non-blank, well-formed, and does not throw exceptions when
it's computed.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Test_ExpectedProfileCollectionPath_IsWellFormed_AndDoesNotThrowExceptions'></a>
### Test_ExpectedProfileCollectionPath_IsWellFormed_AndDoesNotThrowExceptions() `method`

##### Summary

Asserts that the
[ExpectedProfileCollectionPath](#F-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-ExpectedProfileCollectionPath 'MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests.ExpectedProfileCollectionPath')
field's value is non-blank, well-formed, and does not throw exceptions when
it's evaluated.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Test_Obtain_ProfileCollectionFilePath_Gets_PathOfFileThatIsNotBlank'></a>
### Test_Obtain_ProfileCollectionFilePath_Gets_PathOfFileThatIsNotBlank() `method`

##### Summary

Asserts that the
[ProfileCollectionFilePath](#M-MFR-Settings-Profiles-Providers-Actions-Obtain-ProfileCollectionFilePath 'MFR.Settings.Profiles.Providers.Actions.Obtain.ProfileCollectionFilePath')
method obtains a fully-qualified pathname to a file that exists, containing
previously-saved configuration-setting profiles, and that the method copes
with, e.g., the absence of the Registry key that contains the pathname of the
`profiles.json` file and still provide a reasonable default.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Test_Obtain_ProfileCollectionFilePath_UsesInputtedFilePath_ThatExists_UsingDefaultValue'></a>
### Test_Obtain_ProfileCollectionFilePath_UsesInputtedFilePath_ThatExists_UsingDefaultValue() `method`

##### Summary

Asserts that the
[ProfileCollectionFilePath](#M-MFR-Settings-Profiles-Providers-Actions-Obtain-ProfileCollectionFilePath 'MFR.Settings.Profiles.Providers.Actions.Obtain.ProfileCollectionFilePath')
method successfully obtains the fully-qualified pathname to the
`profiles.json` file on the user's computer.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Tests-ObtainTests-Test_Obtain_ProfileCollectionFilePath_UsesInputtedFilePath_ThatExists_WithNoDefaultProvided'></a>
### Test_Obtain_ProfileCollectionFilePath_UsesInputtedFilePath_ThatExists_WithNoDefaultProvided() `method`

##### Summary

Asserts that the
[ProfileCollectionFilePath](#M-MFR-Settings-Profiles-Providers-Actions-Obtain-ProfileCollectionFilePath 'MFR.Settings.Profiles.Providers.Actions.Obtain.ProfileCollectionFilePath')
method successfully obtains the fully-qualified pathname to the
`profiles.json` file on the user's computer.



This unit test does not supply the pathname of a default value.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Profiles-Providers-Actions-Tests-Read'></a>
## Read `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions.Tests

##### Summary

Exposes static methods to read data from data sources.

<a name='M-MFR-Settings-Profiles-Providers-Actions-Tests-Read-RegistryValue-System-String,System-String-'></a>
### RegistryValue(keyPath,valueName) `method`

##### Summary

Attempts to read a `REG-SZ` value from the system Registry having the
specified `valueName` and under the specified Registry
`keyPath`.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the data
under the specified key and value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the fully-qualified Registry key pathname of the key that the value
exists under. |
| valueName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the name of the value under `HKEY_CURRENT_USER`
which the data is stored.



Pass the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value to get the data stored
under the key's `(default)` value. |

<a name='T-MFR-Settings-Profiles-Providers-Actions-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Providers.Actions.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Providers-Actions-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Providers-Actions-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
