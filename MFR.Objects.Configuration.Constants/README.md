<a name='assembly'></a>
# MFR.Objects.Configuration.Constants

## Contents

- [Resources](#T-MFR-Objects-Configuration-Constants-Properties-Resources 'MFR.Objects.Configuration.Constants.Properties.Resources')
  - [Culture](#P-MFR-Objects-Configuration-Constants-Properties-Resources-Culture 'MFR.Objects.Configuration.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Configuration-Constants-Properties-Resources-ResourceManager 'MFR.Objects.Configuration.Constants.Properties.Resources.ResourceManager')
- [TextMatchingConfiguration](#T-MFR-Objects-Configuration-Constants-TextMatchingConfiguration 'MFR.Objects.Configuration.Constants.TextMatchingConfiguration')
  - [MatchCaseAndExactWord](#F-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-MatchCaseAndExactWord 'MFR.Objects.Configuration.Constants.TextMatchingConfiguration.MatchCaseAndExactWord')
  - [MatchCaseOnly](#F-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-MatchCaseOnly 'MFR.Objects.Configuration.Constants.TextMatchingConfiguration.MatchCaseOnly')
  - [MatchExactWordOnly](#F-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-MatchExactWordOnly 'MFR.Objects.Configuration.Constants.TextMatchingConfiguration.MatchExactWordOnly')
  - [NeitherMatchCaseNorExactWord](#F-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-NeitherMatchCaseNorExactWord 'MFR.Objects.Configuration.Constants.TextMatchingConfiguration.NeitherMatchCaseNorExactWord')
  - [Unknown](#F-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-Unknown 'MFR.Objects.Configuration.Constants.TextMatchingConfiguration.Unknown')

<a name='T-MFR-Objects-Configuration-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Configuration.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Configuration-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Configuration-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-Configuration-Constants-TextMatchingConfiguration'></a>
## TextMatchingConfiguration `type`

##### Namespace

MFR.Objects.Configuration.Constants

##### Summary

Values that specify whether we are matching case, matching whole word,
or both, or neither.

<a name='F-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-MatchCaseAndExactWord'></a>
### MatchCaseAndExactWord `constants`

##### Summary

Both Match Case and Match Exact Word are toggled.

<a name='F-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-MatchCaseOnly'></a>
### MatchCaseOnly `constants`

##### Summary

The user has toggled Match Case to true and Match Exact Word to false.

<a name='F-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-MatchExactWordOnly'></a>
### MatchExactWordOnly `constants`

##### Summary

The user has toggled Match Exact Word to true and Match Case to false.

<a name='F-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-NeitherMatchCaseNorExactWord'></a>
### NeitherMatchCaseNorExactWord `constants`

##### Summary

Match Case is set to false, and so is Match Exact Word.

<a name='F-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-Unknown'></a>
### Unknown `constants`

##### Summary

We do not know what type of configuration is set.
