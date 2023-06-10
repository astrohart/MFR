<a name='assembly'></a>
# MFR.Settings.Profiles.Providers.Tests

## Contents

- [Get](#T-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Get 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.Get')
  - [LOG_FILE_PATH_TERMINATOR](#F-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Get-LOG_FILE_PATH_TERMINATOR 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.Get.LOG_FILE_PATH_TERMINATOR')
  - [AssemblyCompany](#P-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Get-AssemblyCompany 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.Get.AssemblyCompany')
  - [AssemblyProduct](#P-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Get-AssemblyProduct 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.Get.AssemblyProduct')
  - [AssemblyTitle](#P-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Get-AssemblyTitle 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.Get.AssemblyTitle')
  - [ApplicationProductName()](#M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Get-ApplicationProductName 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.Get.ApplicationProductName')
  - [LogFilePath()](#M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Get-LogFilePath 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.Get.LogFilePath')
- [ProfileProviderTests](#T-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests')
  - [#ctor()](#M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-#ctor 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.#ctor')
  - [ProfileProvider](#P-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-ProfileProvider 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.ProfileProvider')
  - [OnProfileCollectionFilePathChangedProfileProvider(sender,e)](#M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-OnProfileCollectionFilePathChangedProfileProvider-System-Object,System-EventArgs- 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.OnProfileCollectionFilePathChangedProfileProvider(System.Object,System.EventArgs)')
  - [Test_Load_Add_And_Save_Workflow()](#M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Test_Load_Add_And_Save_Workflow 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.Test_Load_Add_And_Save_Workflow')
  - [Test_Load_Method_Works_When_PassedStringEmpty()](#M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Test_Load_Method_Works_When_PassedStringEmpty 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.Test_Load_Method_Works_When_PassedStringEmpty')
- [Resources](#T-MFR-Settings-Profiles-Providers-Tests-Properties-Resources 'MFR.Settings.Profiles.Providers.Tests.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Providers-Tests-Properties-Resources-Culture 'MFR.Settings.Profiles.Providers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Providers-Tests-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Providers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Get'></a>
## Get `type`

##### Namespace

MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests

##### Summary

Exposes static methods to obtain data from various data sources.

<a name='F-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Get-LOG_FILE_PATH_TERMINATOR'></a>
### LOG_FILE_PATH_TERMINATOR `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final piece of the path of the
log file.

<a name='P-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Get-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyCompany](#P-AssemblyMetadata-AssemblyCompany 'AssemblyMetadata.AssemblyCompany') property.

<a name='P-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Get-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyProduct](#P-AssemblyMetadata-AssemblyProduct 'AssemblyMetadata.AssemblyProduct') property.

<a name='P-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Get-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the assembly title defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyTitle](#P-AssemblyMetadata-AssemblyTitle 'AssemblyMetadata.AssemblyTitle') property.

<a name='M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Get-ApplicationProductName'></a>
### ApplicationProductName() `method`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for
the software product of which this application or class library is a part.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name
for the software product of which this application or class library is a part.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Get-LogFilePath'></a>
### LogFilePath() `method`

##### Summary

Obtains a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests'></a>
## ProfileProviderTests `type`

##### Namespace

MFR.Settings.Profiles.Providers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ProfileProvider](#T-MFR-Settings-Profiles-Providers-ProfileProvider 'MFR.Settings.Profiles.Providers.ProfileProvider') class.

<a name='M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ProfileProviderTests](#T-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests') and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-ProfileProvider'></a>
### ProfileProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProfileProvider](#T-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider')
interface.

<a name='M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-OnProfileCollectionFilePathChangedProfileProvider-System-Object,System-EventArgs-'></a>
### OnProfileCollectionFilePathChangedProfileProvider(sender,e) `method`

##### Summary

Handles the
[](#E-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-ProfileCollectionFilePathChanged 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePathChanged')
event raised by the Profile Provider..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method reports, to the console, what the current value of the
[ProfileCollectionFilePath](#P-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-ProfileCollectionFilePath 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePath')
property is.

<a name='M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Test_Load_Add_And_Save_Workflow'></a>
### Test_Load_Add_And_Save_Workflow() `method`

##### Summary

Asserts that the workflow of Profiles, i.e., loading them from disk, adding new
fake profiles to the list, and then saving the results to disk, works.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Test_Load_Method_Works_When_PassedStringEmpty'></a>
### Test_Load_Method_Works_When_PassedStringEmpty() `method`

##### Summary

Asserts that the
[Load](#M-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider-Load 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.Load')
method works even when we pass it the empty string for the pathname of the file
to be loaded.



In this circumstance, the profile
provider object should attempt to read the path to load from, from the system
Registry, or use the default.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Profiles-Providers-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Providers.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Providers-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Providers-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
