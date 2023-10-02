<a name='assembly'></a>
# MFR.Directories.Managers.Tests

## Contents

- [Get](#T-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Get 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests.Get')
  - [LOG_FILE_PATH_TERMINATOR](#F-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Get-LOG_FILE_PATH_TERMINATOR 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests.Get.LOG_FILE_PATH_TERMINATOR')
  - [AssemblyCompany](#P-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Get-AssemblyCompany 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests.Get.AssemblyCompany')
  - [AssemblyProduct](#P-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Get-AssemblyProduct 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests.Get.AssemblyProduct')
  - [AssemblyTitle](#P-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Get-AssemblyTitle 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests.Get.AssemblyTitle')
  - [ApplicationProductName()](#M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Get-ApplicationProductName 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests.Get.ApplicationProductName')
  - [LogFilePath()](#M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Get-LogFilePath 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests.Get.LogFilePath')
- [Resources](#T-MFR-Directories-Managers-Tests-Properties-Resources 'MFR.Directories.Managers.Tests.Properties.Resources')
  - [Culture](#P-MFR-Directories-Managers-Tests-Properties-Resources-Culture 'MFR.Directories.Managers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Managers-Tests-Properties-Resources-ResourceManager 'MFR.Directories.Managers.Tests.Properties.Resources.ResourceManager')
- [SearchDirectoryManagerTests](#T-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests')
  - [#ctor()](#M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-#ctor 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests.#ctor')
  - [SearchDirectoryManager](#P-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-SearchDirectoryManager 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests.SearchDirectoryManager')
  - [StartStopwatch()](#M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-StartStopwatch 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests.StartStopwatch')
  - [StopStopwatch()](#M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-StopStopwatch 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests.StopStopwatch')
  - [Test_GetSearchDirectories_Works_ForAllRepos_IPortfolioMonitor_Folder()](#M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Test_GetSearchDirectories_Works_ForAllRepos_IPortfolioMonitor_Folder 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests.Test_GetSearchDirectories_Works_ForAllRepos_IPortfolioMonitor_Folder')
  - [Test_GetSearchDirectories_Works_ForAllRepos_InAstrohart_Folder()](#M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Test_GetSearchDirectories_Works_ForAllRepos_InAstrohart_Folder 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests.Test_GetSearchDirectories_Works_ForAllRepos_InAstrohart_Folder')
  - [Test_GetSearchDirectories_Works_ForAllRepos_InMFR_Folder()](#M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Test_GetSearchDirectories_Works_ForAllRepos_InMFR_Folder 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests.Test_GetSearchDirectories_Works_ForAllRepos_InMFR_Folder')

<a name='T-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Get'></a>
## Get `type`

##### Namespace

MFR.Directories.Managers.Tests.SearchDirectoryManagerTests

##### Summary

Exposes static methods to obtain data from various data sources.

<a name='F-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Get-LOG_FILE_PATH_TERMINATOR'></a>
### LOG_FILE_PATH_TERMINATOR `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final piece of the path of the
log file.

<a name='P-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Get-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyCompany](#P-AssemblyMetadata-AssemblyCompany 'AssemblyMetadata.AssemblyCompany') property.

<a name='P-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Get-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyProduct](#P-AssemblyMetadata-AssemblyProduct 'AssemblyMetadata.AssemblyProduct') property.

<a name='P-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Get-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the assembly title defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyTitle](#P-AssemblyMetadata-AssemblyTitle 'AssemblyMetadata.AssemblyTitle') property.

<a name='M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Get-ApplicationProductName'></a>
### ApplicationProductName() `method`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for
the software product of which this application or class library is a part.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name
for the software product of which this application or class library is a part.

##### Parameters

This method has no parameters.

<a name='M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Get-LogFilePath'></a>
### LogFilePath() `method`

##### Summary

Obtains a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Parameters

This method has no parameters.

<a name='T-MFR-Directories-Managers-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Directories.Managers.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Directories-Managers-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Directories-Managers-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests'></a>
## SearchDirectoryManagerTests `type`

##### Namespace

MFR.Directories.Managers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[SearchDirectoryManager](#T-MFR-Directories-Managers-SearchDirectoryManager 'MFR.Directories.Managers.SearchDirectoryManager') class.

<a name='M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[SearchDirectoryManagerTests](#T-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests 'MFR.Directories.Managers.Tests.SearchDirectoryManagerTests') and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-SearchDirectoryManager'></a>
### SearchDirectoryManager `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ISearchDirectoryManager](#T-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager 'MFR.Directories.Managers.Interfaces.ISearchDirectoryManager')
interface.

<a name='M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-StartStopwatch'></a>
### StartStopwatch() `method`

##### Summary

Starts the stopwatch.

##### Parameters

This method has no parameters.

<a name='M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-StopStopwatch'></a>
### StopStopwatch() `method`

##### Summary

Stops the stopwatch.

##### Parameters

This method has no parameters.

<a name='M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Test_GetSearchDirectories_Works_ForAllRepos_IPortfolioMonitor_Folder'></a>
### Test_GetSearchDirectories_Works_ForAllRepos_IPortfolioMonitor_Folder() `method`

##### Summary

Asserts that the
[Search](#M-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager-Search 'MFR.Directories.Managers.Interfaces.ISearchDirectoryManager.Search')
method finds all the folders containing Visual Studio Solution (`*.sln`)
files in the `C:\Users\Brian Hart\source\repos\astrohart` top-level
folder, which is known to contain folders.

##### Parameters

This method has no parameters.

<a name='M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Test_GetSearchDirectories_Works_ForAllRepos_InAstrohart_Folder'></a>
### Test_GetSearchDirectories_Works_ForAllRepos_InAstrohart_Folder() `method`

##### Summary

Asserts that the
[Search](#M-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager-Search 'MFR.Directories.Managers.Interfaces.ISearchDirectoryManager.Search')
method finds all the folders containing Visual Studio Solution (`*.sln`)
files in the `C:\Users\Brian Hart\source\repos\astrohart` top-level
folder, which is known to contain folders.

##### Parameters

This method has no parameters.

<a name='M-MFR-Directories-Managers-Tests-SearchDirectoryManagerTests-Test_GetSearchDirectories_Works_ForAllRepos_InMFR_Folder'></a>
### Test_GetSearchDirectories_Works_ForAllRepos_InMFR_Folder() `method`

##### Summary

Asserts that the
[Search](#M-MFR-Directories-Managers-Interfaces-ISearchDirectoryManager-Search 'MFR.Directories.Managers.Interfaces.ISearchDirectoryManager.Search')
method finds all the folders containing Visual Studio Solution (`*.sln`)
files in the `C:\Users\Brian Hart\source\repos\astrohart` top-level
folder, which is known to contain folders.

##### Parameters

This method has no parameters.
