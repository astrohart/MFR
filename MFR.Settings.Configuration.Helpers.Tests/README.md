<a name='assembly'></a>
# MFR.Settings.Configuration.Helpers.Tests

## Contents

- [ConfigurationExtensionsTests](#T-MFR-Settings-Configuration-Helpers-Tests-ConfigurationExtensionsTests 'MFR.Settings.Configuration.Helpers.Tests.ConfigurationExtensionsTests')
  - [Test_GetTextMatchingConfiguration_ReturnsMatchCaseAndExactWord_WhenBothMatchCaseAndMatchExactWordAreTrue()](#M-MFR-Settings-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsMatchCaseAndExactWord_WhenBothMatchCaseAndMatchExactWordAreTrue 'MFR.Settings.Configuration.Helpers.Tests.ConfigurationExtensionsTests.Test_GetTextMatchingConfiguration_ReturnsMatchCaseAndExactWord_WhenBothMatchCaseAndMatchExactWordAreTrue')
  - [Test_GetTextMatchingConfiguration_ReturnsMatchCaseOnly_WhenOnlyMatchCaseIsTrue()](#M-MFR-Settings-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsMatchCaseOnly_WhenOnlyMatchCaseIsTrue 'MFR.Settings.Configuration.Helpers.Tests.ConfigurationExtensionsTests.Test_GetTextMatchingConfiguration_ReturnsMatchCaseOnly_WhenOnlyMatchCaseIsTrue')
  - [Test_GetTextMatchingConfiguration_ReturnsMatchExactWordOnly_WhenOnlyMatchExactWordIsTrue()](#M-MFR-Settings-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsMatchExactWordOnly_WhenOnlyMatchExactWordIsTrue 'MFR.Settings.Configuration.Helpers.Tests.ConfigurationExtensionsTests.Test_GetTextMatchingConfiguration_ReturnsMatchExactWordOnly_WhenOnlyMatchExactWordIsTrue')
  - [Test_GetTextMatchingConfiguration_ReturnsNeitherMatchCaseNorExactWord_WhenBothMatchCaseAndMatchExactWordAreFalse()](#M-MFR-Settings-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsNeitherMatchCaseNorExactWord_WhenBothMatchCaseAndMatchExactWordAreFalse 'MFR.Settings.Configuration.Helpers.Tests.ConfigurationExtensionsTests.Test_GetTextMatchingConfiguration_ReturnsNeitherMatchCaseNorExactWord_WhenBothMatchCaseAndMatchExactWordAreFalse')
- [Resources](#T-MFR-Settings-Configuration-Helpers-Tests-Properties-Resources 'MFR.Settings.Configuration.Helpers.Tests.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Helpers-Tests-Properties-Resources-Culture 'MFR.Settings.Configuration.Helpers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Helpers-Tests-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Helpers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Helpers-Tests-ConfigurationExtensionsTests'></a>
## ConfigurationExtensionsTests `type`

##### Namespace

MFR.Settings.Configuration.Helpers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ConfigurationExtensions](#T-MFR-Settings-ConfigurationExtensions 'MFR.Settings.ConfigurationExtensions')
class.

<a name='M-MFR-Settings-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsMatchCaseAndExactWord_WhenBothMatchCaseAndMatchExactWordAreTrue'></a>
### Test_GetTextMatchingConfiguration_ReturnsMatchCaseAndExactWord_WhenBothMatchCaseAndMatchExactWordAreTrue() `method`

##### Summary

Asserts that the
[GetTextMatchingConfiguration](#M-MFR-Settings-ConfigurationExtensions-GetTextMatchingConfiguration 'MFR.Settings.ConfigurationExtensions.GetTextMatchingConfiguration')
method returns the
[MatchCaseAndExactWord](#T-MFR-TextMatchingConfiguration-MatchCaseAndExactWord 'MFR.TextMatchingConfiguration.MatchCaseAndExactWord')
enum value for a configuration object whose
[IConfigurationMatchCase](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IConfigurationMatchCase 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchCase')
property is set to
`true` and whose
[IConfigurationMatchExactWord](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IConfigurationMatchExactWord 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchExactWord')
property is set
to `true`.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsMatchCaseOnly_WhenOnlyMatchCaseIsTrue'></a>
### Test_GetTextMatchingConfiguration_ReturnsMatchCaseOnly_WhenOnlyMatchCaseIsTrue() `method`

##### Summary

Asserts that the
[GetTextMatchingConfiguration](#M-MFR-Settings-ConfigurationExtensions-GetTextMatchingConfiguration 'MFR.Settings.ConfigurationExtensions.GetTextMatchingConfiguration')
method returns the
[MatchCaseOnly](#T-MFR-TextMatchingConfiguration-MatchCaseOnly 'MFR.TextMatchingConfiguration.MatchCaseOnly')
enum
value for a configuration object whose
[IConfigurationMatchCase](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IConfigurationMatchCase 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchCase')
property is set to
`true` and whose
[IConfigurationMatchExactWord](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IConfigurationMatchExactWord 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchExactWord')
property is set
to `false`.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsMatchExactWordOnly_WhenOnlyMatchExactWordIsTrue'></a>
### Test_GetTextMatchingConfiguration_ReturnsMatchExactWordOnly_WhenOnlyMatchExactWordIsTrue() `method`

##### Summary

Asserts that the
[GetTextMatchingConfiguration](#M-MFR-Settings-ConfigurationExtensions-GetTextMatchingConfiguration 'MFR.Settings.ConfigurationExtensions.GetTextMatchingConfiguration')
method returns the
[MatchExactWordOnly](#T-MFR-TextMatchingConfiguration-MatchExactWordOnly 'MFR.TextMatchingConfiguration.MatchExactWordOnly')
enum value for a configuration object whose
[IConfigurationMatchCase](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IConfigurationMatchCase 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchCase')
property is set to
`false` and whose
[IConfigurationMatchExactWord](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IConfigurationMatchExactWord 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchExactWord')
property is set
to `true`.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsNeitherMatchCaseNorExactWord_WhenBothMatchCaseAndMatchExactWordAreFalse'></a>
### Test_GetTextMatchingConfiguration_ReturnsNeitherMatchCaseNorExactWord_WhenBothMatchCaseAndMatchExactWordAreFalse() `method`

##### Summary

Asserts that the
[GetTextMatchingConfiguration](#M-MFR-Settings-ConfigurationExtensions-GetTextMatchingConfiguration 'MFR.Settings.ConfigurationExtensions.GetTextMatchingConfiguration')
method returns the
[NeitherMatchCaseNorExactWord](#T-MFR-TextMatchingConfiguration-NeitherMatchCaseNorExactWord 'MFR.TextMatchingConfiguration.NeitherMatchCaseNorExactWord')
enum value for a configuration object whose
[IConfigurationMatchCase](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IConfigurationMatchCase 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchCase')
property is set to
`false` and whose
[IConfigurationMatchExactWord](#P-MFR-Settings-ProjectFileRenamerConfiguration-Interfaces-IConfigurationMatchExactWord 'MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchExactWord')
property is set
to `false`.

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Helpers-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Helpers.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Helpers-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Helpers-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
