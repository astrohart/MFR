<a name='assembly'></a>
# MFR.Objects.Matchers.Factories.Interfaces

## Contents

- [IStringMatcherFactory](#T-MFR-Objects-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Objects.Matchers.Factories.Interfaces.IStringMatcherFactory')
  - [AndTextMatchingConfiguration(matchingConfig)](#M-MFR-Objects-Matchers-Factories-Interfaces-IStringMatcherFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration- 'MFR.Objects.Matchers.Factories.Interfaces.IStringMatcherFactory.AndTextMatchingConfiguration(MFR.Objects.Configuration.Constants.TextMatchingConfiguration)')
- [Resources](#T-MFR-Objects-Matchers-Factories-Interfaces-Properties-Resources 'MFR.Objects.Matchers.Factories.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Matchers-Factories-Interfaces-Properties-Resources-Culture 'MFR.Objects.Matchers.Factories.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Matchers-Factories-Interfaces-Properties-Resources-ResourceManager 'MFR.Objects.Matchers.Factories.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Matchers-Factories-Interfaces-IStringMatcherFactory'></a>
## IStringMatcherFactory `type`

##### Namespace

MFR.Objects.Matchers.Factories.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a String Matcher Factory
object.

##### Remarks

There must be one implementer of this interface for each of the relevant
operation types (Rename File in Folder etc.).

<a name='M-MFR-Objects-Matchers-Factories-Interfaces-IStringMatcherFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-'></a>
### AndTextMatchingConfiguration(matchingConfig) `method`

##### Summary

Creates a new instance of an object that implements the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.Objects.IStringMatcher')
interface and
returns a reference to it for the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value
that is specified by the `matchingConfig` parameter.

##### Returns

Reference to an instance of an object that implements the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.Objects.IStringMatcher')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| matchingConfig | [MFR.Objects.Configuration.Constants.TextMatchingConfiguration](#T-MFR-Objects-Configuration-Constants-TextMatchingConfiguration 'MFR.Objects.Configuration.Constants.TextMatchingConfiguration') | (Required.) One of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values
that specifies which type of matching is being done. |

<a name='T-MFR-Objects-Matchers-Factories-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Matchers.Factories.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Matchers-Factories-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Matchers-Factories-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
