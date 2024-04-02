<a name='assembly'></a>
# MFR.Generators.RegularExpressions.Constants

## Contents

- [RegexFormats](#T-MFR-Generators-RegularExpressions-Constants-RegexFormats 'MFR.Generators.RegularExpressions.Constants.RegexFormats')
  - [MatchExactWord](#F-MFR-Generators-RegularExpressions-Constants-RegexFormats-MatchExactWord 'MFR.Generators.RegularExpressions.Constants.RegexFormats.MatchExactWord')
  - [MatchWholeLine](#F-MFR-Generators-RegularExpressions-Constants-RegexFormats-MatchWholeLine 'MFR.Generators.RegularExpressions.Constants.RegexFormats.MatchWholeLine')
- [RegularExpressionType](#T-MFR-Generators-RegularExpressions-Constants-RegularExpressionType 'MFR.Generators.RegularExpressions.Constants.RegularExpressionType')
  - [MatchExactWordOnly](#F-MFR-Generators-RegularExpressions-Constants-RegularExpressionType-MatchExactWordOnly 'MFR.Generators.RegularExpressions.Constants.RegularExpressionType.MatchExactWordOnly')
  - [MatchWholeLine](#F-MFR-Generators-RegularExpressions-Constants-RegularExpressionType-MatchWholeLine 'MFR.Generators.RegularExpressions.Constants.RegularExpressionType.MatchWholeLine')
  - [Unknown](#F-MFR-Generators-RegularExpressions-Constants-RegularExpressionType-Unknown 'MFR.Generators.RegularExpressions.Constants.RegularExpressionType.Unknown')
- [Resources](#T-MFR-Generators-RegularExpressions-Constants-Properties-Resources 'MFR.Generators.RegularExpressions.Constants.Properties.Resources')
  - [Culture](#P-MFR-Generators-RegularExpressions-Constants-Properties-Resources-Culture 'MFR.Generators.RegularExpressions.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Generators-RegularExpressions-Constants-Properties-Resources-ResourceManager 'MFR.Generators.RegularExpressions.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Generators-RegularExpressions-Constants-RegexFormats'></a>
## RegexFormats `type`

##### Namespace

MFR.Generators.RegularExpressions.Constants

##### Summary

Substitution formats for regular expressions.

<a name='F-MFR-Generators-RegularExpressions-Constants-RegexFormats-MatchExactWord'></a>
### MatchExactWord `constants`

##### Summary

Regular expression that matches an exact word.

##### Remarks

This sensitive to dot-delimited names such as those which may
appear in Visual Studio solution, project, and source files.



Substitute, into this format, the escaped version of the search
phrase.



If the text `.Properties` follows the text to be
matched, even in the case of an exact-word match, it is included 
with an atomic group.



The idea being to fix namespaces when renaming projects to ensure
that `using` statements bringing in Resources will still work.

<a name='F-MFR-Generators-RegularExpressions-Constants-RegexFormats-MatchWholeLine'></a>
### MatchWholeLine `constants`

##### Summary

Regular expression that matches an entire line from beginning to end.

<a name='T-MFR-Generators-RegularExpressions-Constants-RegularExpressionType'></a>
## RegularExpressionType `type`

##### Namespace

MFR.Generators.RegularExpressions.Constants

##### Summary

Types of regular expressions (e.g., for matching email addresses, phone
numbers, exact words etc.)

<a name='F-MFR-Generators-RegularExpressions-Constants-RegularExpressionType-MatchExactWordOnly'></a>
### MatchExactWordOnly `constants`

##### Summary

Matches an exact word only, whether surrounded by other text or not.

<a name='F-MFR-Generators-RegularExpressions-Constants-RegularExpressionType-MatchWholeLine'></a>
### MatchWholeLine `constants`

##### Summary

Matches an entire line from beginning to end.

<a name='F-MFR-Generators-RegularExpressions-Constants-RegularExpressionType-Unknown'></a>
### Unknown `constants`

##### Summary

Unknown regular expression type.

<a name='T-MFR-Generators-RegularExpressions-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Generators.RegularExpressions.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Generators-RegularExpressions-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Generators-RegularExpressions-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
