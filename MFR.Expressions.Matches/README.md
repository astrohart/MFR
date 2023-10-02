<a name='assembly'></a>
# MFR.Expressions.Matches

## Contents

- [MatchExpression](#T-MFR-Expressions-Matches-MatchExpression 'MFR.Expressions.Matches.MatchExpression')
  - [FindWhat](#P-MFR-Expressions-Matches-MatchExpression-FindWhat 'MFR.Expressions.Matches.MatchExpression.FindWhat')
  - [ReplaceWith](#P-MFR-Expressions-Matches-MatchExpression-ReplaceWith 'MFR.Expressions.Matches.MatchExpression.ReplaceWith')
  - [Value](#P-MFR-Expressions-Matches-MatchExpression-Value 'MFR.Expressions.Matches.MatchExpression.Value')
- [Resources](#T-MFR-Expressions-Matches-Properties-Resources 'MFR.Expressions.Matches.Properties.Resources')
  - [Culture](#P-MFR-Expressions-Matches-Properties-Resources-Culture 'MFR.Expressions.Matches.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Expressions-Matches-Properties-Resources-ResourceManager 'MFR.Expressions.Matches.Properties.Resources.ResourceManager')

<a name='T-MFR-Expressions-Matches-MatchExpression'></a>
## MatchExpression `type`

##### Namespace

MFR.Expressions.Matches

##### Summary

POCO that models a match expression.

##### Remarks

Match expressions consist of two strings: a [Source](#P-MFR-MatchExpression-Source 'MFR.MatchExpression.Source') and a [Pattern](#P-MFR-MatchExpression-Pattern 'MFR.MatchExpression.Pattern') . The [Source](#P-MFR-MatchExpression-Source 'MFR.MatchExpression.Source') is the string
containing data to be searched for the pattern contained in the [Pattern](#P-MFR-MatchExpression-Pattern 'MFR.MatchExpression.Pattern') property.

<a name='P-MFR-Expressions-Matches-MatchExpression-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets a string containing the pattern that is to be used as textual-expression search criteria.

<a name='P-MFR-Expressions-Matches-MatchExpression-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets the data that each of the occurrences of [FindWhat](#P-MFR-Expressions-Matches-MatchExpression-FindWhat 'MFR.Expressions.Matches.MatchExpression.FindWhat') in the
[Value](#P-MFR-Expressions-Matches-MatchExpression-Value 'MFR.Expressions.Matches.MatchExpression.Value') are
to be replaced with.

<a name='P-MFR-Expressions-Matches-MatchExpression-Value'></a>
### Value `property`

##### Summary

Gets or sets a string containing a pattern to be matched against.

<a name='T-MFR-Expressions-Matches-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Expressions.Matches.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Expressions-Matches-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Expressions-Matches-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
