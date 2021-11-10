<a name='assembly'></a>
# MFR.Settings.Profiles.Providers.Tests

## Contents

- [ProfileProviderTests](#T-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests')
  - [ProfileProvider](#P-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-ProfileProvider 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.ProfileProvider')
  - [Initialize()](#M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Initialize 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.Initialize')
  - [Test_Load_Add_And_Save_Workflow()](#M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Test_Load_Add_And_Save_Workflow 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.Test_Load_Add_And_Save_Workflow')
  - [Test_Load_Method_Works_When_PassedStringEmpty()](#M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Test_Load_Method_Works_When_PassedStringEmpty 'MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests.Test_Load_Method_Works_When_PassedStringEmpty')
- [Resources](#T-MFR-Settings-Profiles-Providers-Tests-Properties-Resources 'MFR.Settings.Profiles.Providers.Tests.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Providers-Tests-Properties-Resources-Culture 'MFR.Settings.Profiles.Providers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Providers-Tests-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Providers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests'></a>
## ProfileProviderTests `type`

##### Namespace

MFR.Settings.Profiles.Providers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ProfileProvider](#T-MFR-Settings-Profiles-Providers-ProfileProvider 'MFR.Settings.Profiles.Providers.ProfileProvider') class.

<a name='P-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-ProfileProvider'></a>
### ProfileProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProfileProvider](#T-MFR-Settings-Profiles-Providers-Interfaces-IProfileProvider 'MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider')
interface.

<a name='M-MFR-Settings-Profiles-Providers-Tests-ProfileProviderTests-Initialize'></a>
### Initialize() `method`

##### Summary

Method that sets up the logging infrastructure for use with a child test
fixture.



Child classes may override this method to run additional
set-up logic.

##### Parameters

This method has no parameters.

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
