<a name='assembly'></a>
# MFR.Matchers.Factories.Interfaces

## Contents

- [IStringMatcherFactory](#T-MFR-Objects-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
  - [AndTextMatchingConfiguration(matchingConfig)](#M-MFR-Objects-Matchers-Factories-Interfaces-IStringMatcherFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration- 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory.AndTextMatchingConfiguration(MFR.Configuration.Constants.TextMatchingConfiguration)')
- [Resources](#T-MFR-Objects-Matchers-Factories-Interfaces-Properties-Resources 'MFR.Matchers.Factories.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Matchers-Factories-Interfaces-Properties-Resources-Culture 'MFR.Matchers.Factories.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Matchers-Factories-Interfaces-Properties-Resources-ResourceManager 'MFR.Matchers.Factories.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Matchers-Factories-Interfaces-IStringMatcherFactory'></a>
## IStringMatcherFactory `type`

##### Namespace

MFR.Matchers.Factories.Interfaces

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
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.IStringMatcher')
interface and
returns a reference to it for the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value
that is specified by the `matchingConfig` parameter.

##### Returns

Reference to an instance of an object that implements the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.IStringMatcher')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| matchingConfig | [MFR.Configuration.Constants.TextMatchingConfiguration](#T-MFR-Objects-Configuration-Constants-TextMatchingConfiguration 'MFR.Configuration.Constants.TextMatchingConfiguration') | (Required.) One of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that specifies which type of matching is being done. |

<a name='T-MFR-Objects-Matchers-Factories-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Matchers.Factories.Interfaces.Properties

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
