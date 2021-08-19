<a name='assembly'></a>
# MFR.Objects.Configuration.Helpers.Tests

## Contents

- [ConfigurationExtensionsTests](#T-MFR-Objects-Configuration-Helpers-Tests-ConfigurationExtensionsTests 'MFR.Objects.Configuration.Helpers.Tests.ConfigurationExtensionsTests')
  - [Test_GetTextMatchingConfiguration_ReturnsMatchCaseAndExactWord_WhenBothMatchCaseAndMatchExactWordAreTrue()](#M-MFR-Objects-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsMatchCaseAndExactWord_WhenBothMatchCaseAndMatchExactWordAreTrue 'MFR.Objects.Configuration.Helpers.Tests.ConfigurationExtensionsTests.Test_GetTextMatchingConfiguration_ReturnsMatchCaseAndExactWord_WhenBothMatchCaseAndMatchExactWordAreTrue')
  - [Test_GetTextMatchingConfiguration_ReturnsMatchCaseOnly_WhenOnlyMatchCaseIsTrue()](#M-MFR-Objects-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsMatchCaseOnly_WhenOnlyMatchCaseIsTrue 'MFR.Objects.Configuration.Helpers.Tests.ConfigurationExtensionsTests.Test_GetTextMatchingConfiguration_ReturnsMatchCaseOnly_WhenOnlyMatchCaseIsTrue')
  - [Test_GetTextMatchingConfiguration_ReturnsMatchExactWordOnly_WhenOnlyMatchExactWordIsTrue()](#M-MFR-Objects-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsMatchExactWordOnly_WhenOnlyMatchExactWordIsTrue 'MFR.Objects.Configuration.Helpers.Tests.ConfigurationExtensionsTests.Test_GetTextMatchingConfiguration_ReturnsMatchExactWordOnly_WhenOnlyMatchExactWordIsTrue')
  - [Test_GetTextMatchingConfiguration_ReturnsNeitherMatchCaseNorExactWord_WhenBothMatchCaseAndMatchExactWordAreFalse()](#M-MFR-Objects-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsNeitherMatchCaseNorExactWord_WhenBothMatchCaseAndMatchExactWordAreFalse 'MFR.Objects.Configuration.Helpers.Tests.ConfigurationExtensionsTests.Test_GetTextMatchingConfiguration_ReturnsNeitherMatchCaseNorExactWord_WhenBothMatchCaseAndMatchExactWordAreFalse')
- [Resources](#T-MFR-Objects-Configuration-Helpers-Tests-Properties-Resources 'MFR.Objects.Configuration.Helpers.Tests.Properties.Resources')
  - [Culture](#P-MFR-Objects-Configuration-Helpers-Tests-Properties-Resources-Culture 'MFR.Objects.Configuration.Helpers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Configuration-Helpers-Tests-Properties-Resources-ResourceManager 'MFR.Objects.Configuration.Helpers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Configuration-Helpers-Tests-ConfigurationExtensionsTests'></a>
## ConfigurationExtensionsTests `type`

##### Namespace

MFR.Objects.Configuration.Helpers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[ConfigurationExtensions](#T-MFR-Objects-ConfigurationExtensions 'MFR.Objects.ConfigurationExtensions')
class.

<a name='M-MFR-Objects-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsMatchCaseAndExactWord_WhenBothMatchCaseAndMatchExactWordAreTrue'></a>
### Test_GetTextMatchingConfiguration_ReturnsMatchCaseAndExactWord_WhenBothMatchCaseAndMatchExactWordAreTrue() `method`

##### Summary

Asserts that the
[GetTextMatchingConfiguration](#M-MFR-Objects-ConfigurationExtensions-GetTextMatchingConfiguration 'MFR.Objects.ConfigurationExtensions.GetTextMatchingConfiguration')
method returns the
[MatchCaseAndExactWord](#T-MFR-Objects-TextMatchingConfiguration-MatchCaseAndExactWord 'MFR.Objects.TextMatchingConfiguration.MatchCaseAndExactWord')
enum value for a configuration object whose
[IConfigurationMatchCase](#P-MFR-Objects-Configuration-Interfaces-IConfigurationMatchCase 'MFR.Objects.Configuration.Interfaces.IConfigurationMatchCase')
property is set to
`true` and whose
[IConfigurationMatchExactWord](#P-MFR-Objects-Configuration-Interfaces-IConfigurationMatchExactWord 'MFR.Objects.Configuration.Interfaces.IConfigurationMatchExactWord')
property is set
to `true`.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsMatchCaseOnly_WhenOnlyMatchCaseIsTrue'></a>
### Test_GetTextMatchingConfiguration_ReturnsMatchCaseOnly_WhenOnlyMatchCaseIsTrue() `method`

##### Summary

Asserts that the
[GetTextMatchingConfiguration](#M-MFR-Objects-ConfigurationExtensions-GetTextMatchingConfiguration 'MFR.Objects.ConfigurationExtensions.GetTextMatchingConfiguration')
method returns the
[MatchCaseOnly](#T-MFR-Objects-TextMatchingConfiguration-MatchCaseOnly 'MFR.Objects.TextMatchingConfiguration.MatchCaseOnly')
enum
value for a configuration object whose
[IConfigurationMatchCase](#P-MFR-Objects-Configuration-Interfaces-IConfigurationMatchCase 'MFR.Objects.Configuration.Interfaces.IConfigurationMatchCase')
property is set to
`true` and whose
[IConfigurationMatchExactWord](#P-MFR-Objects-Configuration-Interfaces-IConfigurationMatchExactWord 'MFR.Objects.Configuration.Interfaces.IConfigurationMatchExactWord')
property is set
to `false`.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsMatchExactWordOnly_WhenOnlyMatchExactWordIsTrue'></a>
### Test_GetTextMatchingConfiguration_ReturnsMatchExactWordOnly_WhenOnlyMatchExactWordIsTrue() `method`

##### Summary

Asserts that the
[GetTextMatchingConfiguration](#M-MFR-Objects-ConfigurationExtensions-GetTextMatchingConfiguration 'MFR.Objects.ConfigurationExtensions.GetTextMatchingConfiguration')
method returns the
[MatchExactWordOnly](#T-MFR-Objects-TextMatchingConfiguration-MatchExactWordOnly 'MFR.Objects.TextMatchingConfiguration.MatchExactWordOnly')
enum value for a configuration object whose
[IConfigurationMatchCase](#P-MFR-Objects-Configuration-Interfaces-IConfigurationMatchCase 'MFR.Objects.Configuration.Interfaces.IConfigurationMatchCase')
property is set to
`false` and whose
[IConfigurationMatchExactWord](#P-MFR-Objects-Configuration-Interfaces-IConfigurationMatchExactWord 'MFR.Objects.Configuration.Interfaces.IConfigurationMatchExactWord')
property is set
to `true`.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Configuration-Helpers-Tests-ConfigurationExtensionsTests-Test_GetTextMatchingConfiguration_ReturnsNeitherMatchCaseNorExactWord_WhenBothMatchCaseAndMatchExactWordAreFalse'></a>
### Test_GetTextMatchingConfiguration_ReturnsNeitherMatchCaseNorExactWord_WhenBothMatchCaseAndMatchExactWordAreFalse() `method`

##### Summary

Asserts that the
[GetTextMatchingConfiguration](#M-MFR-Objects-ConfigurationExtensions-GetTextMatchingConfiguration 'MFR.Objects.ConfigurationExtensions.GetTextMatchingConfiguration')
method returns the
[NeitherMatchCaseNorExactWord](#T-MFR-Objects-TextMatchingConfiguration-NeitherMatchCaseNorExactWord 'MFR.Objects.TextMatchingConfiguration.NeitherMatchCaseNorExactWord')
enum value for a configuration object whose
[IConfigurationMatchCase](#P-MFR-Objects-Configuration-Interfaces-IConfigurationMatchCase 'MFR.Objects.Configuration.Interfaces.IConfigurationMatchCase')
property is set to
`false` and whose
[IConfigurationMatchExactWord](#P-MFR-Objects-Configuration-Interfaces-IConfigurationMatchExactWord 'MFR.Objects.Configuration.Interfaces.IConfigurationMatchExactWord')
property is set
to `false`.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Configuration-Helpers-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Configuration.Helpers.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Configuration-Helpers-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Configuration-Helpers-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
