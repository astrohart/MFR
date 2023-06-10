<a name='assembly'></a>
# MFR.GUI.Constants.Tests

## Contents

- [Get](#T-MFR-GUI-Constants-Tests-Get 'MFR.GUI.Constants.Tests.Get')
  - [LOG_FILE_PATH_TERMINATOR](#F-MFR-GUI-Constants-Tests-Get-LOG_FILE_PATH_TERMINATOR 'MFR.GUI.Constants.Tests.Get.LOG_FILE_PATH_TERMINATOR')
  - [AssemblyCompany](#P-MFR-GUI-Constants-Tests-Get-AssemblyCompany 'MFR.GUI.Constants.Tests.Get.AssemblyCompany')
  - [AssemblyProduct](#P-MFR-GUI-Constants-Tests-Get-AssemblyProduct 'MFR.GUI.Constants.Tests.Get.AssemblyProduct')
  - [AssemblyTitle](#P-MFR-GUI-Constants-Tests-Get-AssemblyTitle 'MFR.GUI.Constants.Tests.Get.AssemblyTitle')
  - [ApplicationProductName()](#M-MFR-GUI-Constants-Tests-Get-ApplicationProductName 'MFR.GUI.Constants.Tests.Get.ApplicationProductName')
  - [LogFilePath()](#M-MFR-GUI-Constants-Tests-Get-LogFilePath 'MFR.GUI.Constants.Tests.Get.LogFilePath')
- [ProgramTextTests](#T-MFR-GUI-Constants-Tests-ProgramTextTests 'MFR.GUI.Constants.Tests.ProgramTextTests')
  - [Initialize()](#M-MFR-GUI-Constants-Tests-ProgramTextTests-Initialize 'MFR.GUI.Constants.Tests.ProgramTextTests.Initialize')
  - [Test_CompanyName_Property_DoesNotThrow_And_ReturnsValidValue()](#M-MFR-GUI-Constants-Tests-ProgramTextTests-Test_CompanyName_Property_DoesNotThrow_And_ReturnsValidValue 'MFR.GUI.Constants.Tests.ProgramTextTests.Test_CompanyName_Property_DoesNotThrow_And_ReturnsValidValue')
  - [Test_ProductName_Property_DoesNotThrow_And_ReturnsValidValue()](#M-MFR-GUI-Constants-Tests-ProgramTextTests-Test_ProductName_Property_DoesNotThrow_And_ReturnsValidValue 'MFR.GUI.Constants.Tests.ProgramTextTests.Test_ProductName_Property_DoesNotThrow_And_ReturnsValidValue')
- [Resources](#T-MFR-GUI-Constants-Tests-Properties-Resources 'MFR.GUI.Constants.Tests.Properties.Resources')
  - [Culture](#P-MFR-GUI-Constants-Tests-Properties-Resources-Culture 'MFR.GUI.Constants.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Constants-Tests-Properties-Resources-ResourceManager 'MFR.GUI.Constants.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Constants-Tests-Get'></a>
## Get `type`

##### Namespace

MFR.GUI.Constants.Tests

##### Summary

Exposes static methods to obtain data from various data sources.

<a name='F-MFR-GUI-Constants-Tests-Get-LOG_FILE_PATH_TERMINATOR'></a>
### LOG_FILE_PATH_TERMINATOR `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final piece of the path of the
log file.

<a name='P-MFR-GUI-Constants-Tests-Get-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyCompany](#P-AssemblyMetadata-AssemblyCompany 'AssemblyMetadata.AssemblyCompany') property.

<a name='P-MFR-GUI-Constants-Tests-Get-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyProduct](#P-AssemblyMetadata-AssemblyProduct 'AssemblyMetadata.AssemblyProduct') property.

<a name='P-MFR-GUI-Constants-Tests-Get-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the assembly title defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyTitle](#P-AssemblyMetadata-AssemblyTitle 'AssemblyMetadata.AssemblyTitle') property.

<a name='M-MFR-GUI-Constants-Tests-Get-ApplicationProductName'></a>
### ApplicationProductName() `method`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for
the software product of which this application or class library is a part.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name
for the software product of which this application or class library is a part.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Constants-Tests-Get-LogFilePath'></a>
### LogFilePath() `method`

##### Summary

Obtains a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Constants-Tests-ProgramTextTests'></a>
## ProgramTextTests `type`

##### Namespace

MFR.GUI.Constants.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ProgramText](#T-MFR-GUI-Constants-ProgramText 'MFR.GUI.Constants.ProgramText') class.

<a name='M-MFR-GUI-Constants-Tests-ProgramTextTests-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the state of this fixture for every unit test session.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Constants-Tests-ProgramTextTests-Test_CompanyName_Property_DoesNotThrow_And_ReturnsValidValue'></a>
### Test_CompanyName_Property_DoesNotThrow_And_ReturnsValidValue() `method`

##### Summary

Asserts that the value of the
[CompanyName](#P-MFR-GUI-Constants-ProgramText-CompanyName 'MFR.GUI.Constants.ProgramText.CompanyName') property does not
throw any exceptions (which it has been doing as of late) and that it returns a
non-blank value.
value.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Constants-Tests-ProgramTextTests-Test_ProductName_Property_DoesNotThrow_And_ReturnsValidValue'></a>
### Test_ProductName_Property_DoesNotThrow_And_ReturnsValidValue() `method`

##### Summary

Asserts that the value of the
[ProductName](#P-MFR-GUI-Constants-ProgramText-ProductName 'MFR.GUI.Constants.ProgramText.ProductName') property does not
throw any exceptions (which it has been doing as of late) and that it returns a
non-blank value.
value.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Constants-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Constants.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Constants-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Constants-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
