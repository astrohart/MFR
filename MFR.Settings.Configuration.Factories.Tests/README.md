<a name='assembly'></a>
# MFR.Settings.Configuration.Factories.Tests

## Contents

- [MakeNewConfigurationTests](#T-MFR-Settings-Configuration-Factories-Tests-MakeNewConfigurationTests 'MFR.Settings.Configuration.Factories.Tests.MakeNewConfigurationTests')
  - [Test_MakeNewConfiguraton_FromScratch_Method_Works()](#M-MFR-Settings-Configuration-Factories-Tests-MakeNewConfigurationTests-Test_MakeNewConfiguraton_FromScratch_Method_Works 'MFR.Settings.Configuration.Factories.Tests.MakeNewConfigurationTests.Test_MakeNewConfiguraton_FromScratch_Method_Works')
- [Resources](#T-MFR-Settings-Configuration-Factories-Tests-Properties-Resources 'MFR.Settings.Configuration.Factories.Tests.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Factories-Tests-Properties-Resources-Culture 'MFR.Settings.Configuration.Factories.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Factories-Tests-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Factories.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Factories-Tests-MakeNewConfigurationTests'></a>
## MakeNewConfigurationTests `type`

##### Namespace

MFR.Settings.Configuration.Factories.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[MakeNewProjectFileRenamerConfiguration](#T-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration')
class.

<a name='M-MFR-Settings-Configuration-Factories-Tests-MakeNewConfigurationTests-Test_MakeNewConfiguraton_FromScratch_Method_Works'></a>
### Test_MakeNewConfiguraton_FromScratch_Method_Works() `method`

##### Summary

Asserts that the
[FromScratch](#M-MFR-Settings-Configuration-Factories-MakeNewProjectFileRenamerConfiguration-FromScratch 'MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration.FromScratch')
method returns a reference to an instance of an object that is (a) non-
`null`, (b) an instance of the
[ProjectFileRenamerConfig](#T-MFR-Settings-Configuration-ProjectFileRenamerConfig 'MFR.Settings.Configuration.ProjectFileRenamerConfig')
class, and (c)
implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Factories-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Factories.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Factories-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Factories-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
