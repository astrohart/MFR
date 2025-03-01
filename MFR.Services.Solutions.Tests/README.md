<a name='assembly'></a>
# MFR.Services.Solutions.Tests

## Contents

- [Resources](#T-MFR-Services-Solutions-Tests-Properties-Resources 'MFR.Services.Solutions.Tests.Properties.Resources')
  - [Culture](#P-MFR-Services-Solutions-Tests-Properties-Resources-Culture 'MFR.Services.Solutions.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Services-Solutions-Tests-Properties-Resources-ResourceManager 'MFR.Services.Solutions.Tests.Properties.Resources.ResourceManager')
- [VisualStudioSolutionServiceTests](#T-MFR-Services-Solutions-Tests-VisualStudioSolutionServiceTests 'MFR.Services.Solutions.Tests.VisualStudioSolutionServiceTests')
  - [Test_ContainsLoadedSolutions_ForMFRFolder_ReturnsTrue()](#M-MFR-Services-Solutions-Tests-VisualStudioSolutionServiceTests-Test_ContainsLoadedSolutions_ForMFRFolder_ReturnsTrue 'MFR.Services.Solutions.Tests.VisualStudioSolutionServiceTests.Test_ContainsLoadedSolutions_ForMFRFolder_ReturnsTrue')
  - [Test_ContainsLoadedSolutions_Works_If_FolderToSearch_Property_IsSet()](#M-MFR-Services-Solutions-Tests-VisualStudioSolutionServiceTests-Test_ContainsLoadedSolutions_Works_If_FolderToSearch_Property_IsSet 'MFR.Services.Solutions.Tests.VisualStudioSolutionServiceTests.Test_ContainsLoadedSolutions_Works_If_FolderToSearch_Property_IsSet')

<a name='T-MFR-Services-Solutions-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Services.Solutions.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Services-Solutions-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Services-Solutions-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Services-Solutions-Tests-VisualStudioSolutionServiceTests'></a>
## VisualStudioSolutionServiceTests `type`

##### Namespace

MFR.Services.Solutions.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[VisualStudioSolutionService](#T-MFR-Services-Solutions-VisualStudioSolutionService 'MFR.Services.Solutions.VisualStudioSolutionService')
class.

<a name='M-MFR-Services-Solutions-Tests-VisualStudioSolutionServiceTests-Test_ContainsLoadedSolutions_ForMFRFolder_ReturnsTrue'></a>
### Test_ContainsLoadedSolutions_ForMFRFolder_ReturnsTrue() `method`

##### Summary

Asserts that the
[ContainsLoadedSolutions](#M-MFR-Services-Solutions-VisualStudioSolutionService-ContainsLoadedSolutions 'MFR.Services.Solutions.VisualStudioSolutionService.ContainsLoadedSolutions')
method returns `true` when it's asked to scan for loaded
solutions from the folder in which this solution is being executed.

##### Parameters

This method has no parameters.

<a name='M-MFR-Services-Solutions-Tests-VisualStudioSolutionServiceTests-Test_ContainsLoadedSolutions_Works_If_FolderToSearch_Property_IsSet'></a>
### Test_ContainsLoadedSolutions_Works_If_FolderToSearch_Property_IsSet() `method`

##### Summary

Asserts that the
[ContainLoadedSolutions](#M-MFR-Services-Solutions-Interfaces-IVisualStudioSolutionService-ContainLoadedSolutions 'MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService.ContainLoadedSolutions')
method returns `true` when passed the path of a folder that is
known to exist and contain `.sln` files.

##### Parameters

This method has no parameters.
