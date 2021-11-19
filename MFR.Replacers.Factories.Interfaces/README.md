<a name='assembly'></a>
# MFR.Replacers.Factories.Interfaces

## Contents

- [IStringReplacerFactory](#T-MFR-Replacers-Factories-Interfaces-IStringReplacerFactory 'MFR.Replacers.Factories.Interfaces.IStringReplacerFactory')
  - [AndTextMatchingConfiguration(matchingConfig)](#M-MFR-Replacers-Factories-Interfaces-IStringReplacerFactory-AndTextMatchingConfiguration-MFR-Settings-Configuration-Constants-TextMatchingConfiguration- 'MFR.Replacers.Factories.Interfaces.IStringReplacerFactory.AndTextMatchingConfiguration(MFR.Settings.Configuration.Constants.TextMatchingConfiguration)')
- [Resources](#T-MFR-Replacers-Factories-Interfaces-Properties-Resources 'MFR.Replacers.Factories.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Replacers-Factories-Interfaces-Properties-Resources-Culture 'MFR.Replacers.Factories.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Replacers-Factories-Interfaces-Properties-Resources-ResourceManager 'MFR.Replacers.Factories.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Replacers-Factories-Interfaces-IStringReplacerFactory'></a>
## IStringReplacerFactory `type`

##### Namespace

MFR.Replacers.Factories.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a String Replacer
Factory object.

##### Remarks

There must be one implementer of this interface for each of the relevant
operation types (Rename File in Folder etc.).

<a name='M-MFR-Replacers-Factories-Interfaces-IStringReplacerFactory-AndTextMatchingConfiguration-MFR-Settings-Configuration-Constants-TextMatchingConfiguration-'></a>
### AndTextMatchingConfiguration(matchingConfig) `method`

##### Summary

Creates a new instance of an object that implements the
[IStringReplacer](#T-MFR-IStringReplacer 'MFR.IStringReplacer')
interface and
returns a reference to it for the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value
that is specified by the `matchingConfig` parameter.

##### Returns

Reference to an instance of an object that implements the
[IStringReplacer](#T-MFR-IStringReplacer 'MFR.IStringReplacer')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| matchingConfig | [MFR.Settings.Configuration.Constants.TextMatchingConfiguration](#T-MFR-Settings-Configuration-Constants-TextMatchingConfiguration 'MFR.Settings.Configuration.Constants.TextMatchingConfiguration') | (Required.) One of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that specifies which type of matching is being done. |

<a name='T-MFR-Replacers-Factories-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Replacers.Factories.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Replacers-Factories-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Replacers-Factories-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
