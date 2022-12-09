<a name='assembly'></a>
# MFR.Matchers.Interfaces

## Contents

- [IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-Interfaces-IStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.Interfaces.IStringMatcher.IsMatch(System.String,System.String,System.String)')
- [Resources](#T-MFR-Matchers-Interfaces-Properties-Resources 'MFR.Matchers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Matchers-Interfaces-Properties-Resources-Culture 'MFR.Matchers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Matchers-Interfaces-Properties-Resources-ResourceManager 'MFR.Matchers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Matchers-Interfaces-IStringMatcher'></a>
## IStringMatcher `type`

##### Namespace

MFR.Matchers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that
performs matching on strings.

##### Remarks

The type of matching performed varies by file- and folder-renaming
operation type, as well as the specific projectFileRenamerConfiguration of matching (Match
Case, Match Exact Word etc.).

<a name='M-MFR-Matchers-Interfaces-IStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
### IsMatch(value,findWhat,replaceWith) `method`

##### Summary

Determines whether a `value` string is a match
against a `findWhat`, according to how the
application is configured.

##### Returns

Returns `true` if the `value` is a
match against the provided `findWhat`;
`false`
if no matches are found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value to check for matches. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the pattern that specifies the search criteria. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data that all instances of
`findWhat` in `value` are to be
replaced with. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
or `findWhat`, are passed blank or
`null` string for values. |

<a name='T-MFR-Matchers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Matchers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Matchers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Matchers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
