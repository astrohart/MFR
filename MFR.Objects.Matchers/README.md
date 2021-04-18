<a name='assembly'></a>
# MFR.Objects.Matchers

## Contents

- [MatchCaseAndExactWordFileNameStringMatcher](#T-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher 'MFR.Objects.Matchers.MatchCaseAndExactWordFileNameStringMatcher')
  - [#ctor()](#M-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher-#ctor 'MFR.Objects.Matchers.MatchCaseAndExactWordFileNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher-Instance 'MFR.Objects.Matchers.MatchCaseAndExactWordFileNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher-TextMatchingConfiguration 'MFR.Objects.Matchers.MatchCaseAndExactWordFileNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher-#cctor 'MFR.Objects.Matchers.MatchCaseAndExactWordFileNameStringMatcher.#cctor')
  - [GetPattern(findWhat)](#M-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher-GetPattern-System-String- 'MFR.Objects.Matchers.MatchCaseAndExactWordFileNameStringMatcher.GetPattern(System.String)')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.MatchCaseAndExactWordFileNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchCaseAndExactWordFolderNameStringMatcher](#T-MFR-Objects-Matchers-MatchCaseAndExactWordFolderNameStringMatcher 'MFR.Objects.Matchers.MatchCaseAndExactWordFolderNameStringMatcher')
  - [#ctor()](#M-MFR-Objects-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-#ctor 'MFR.Objects.Matchers.MatchCaseAndExactWordFolderNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-Instance 'MFR.Objects.Matchers.MatchCaseAndExactWordFolderNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-TextMatchingConfiguration 'MFR.Objects.Matchers.MatchCaseAndExactWordFolderNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-#cctor 'MFR.Objects.Matchers.MatchCaseAndExactWordFolderNameStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.MatchCaseAndExactWordFolderNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchCaseAndExactWordTextInFilesStringMatcher](#T-MFR-Objects-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher 'MFR.Objects.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher')
  - [#ctor()](#M-MFR-Objects-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-#ctor 'MFR.Objects.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-Instance 'MFR.Objects.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-TextMatchingConfiguration 'MFR.Objects.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-#cctor 'MFR.Objects.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchCaseOnlyFileNameStringMatcher](#T-MFR-Objects-Matchers-MatchCaseOnlyFileNameStringMatcher 'MFR.Objects.Matchers.MatchCaseOnlyFileNameStringMatcher')
  - [#ctor()](#M-MFR-Objects-Matchers-MatchCaseOnlyFileNameStringMatcher-#ctor 'MFR.Objects.Matchers.MatchCaseOnlyFileNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-MatchCaseOnlyFileNameStringMatcher-Instance 'MFR.Objects.Matchers.MatchCaseOnlyFileNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-MatchCaseOnlyFileNameStringMatcher-TextMatchingConfiguration 'MFR.Objects.Matchers.MatchCaseOnlyFileNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Matchers-MatchCaseOnlyFileNameStringMatcher-#cctor 'MFR.Objects.Matchers.MatchCaseOnlyFileNameStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-MatchCaseOnlyFileNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.MatchCaseOnlyFileNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchCaseOnlyFolderNameStringMatcher](#T-MFR-Objects-Matchers-MatchCaseOnlyFolderNameStringMatcher 'MFR.Objects.Matchers.MatchCaseOnlyFolderNameStringMatcher')
  - [#ctor()](#M-MFR-Objects-Matchers-MatchCaseOnlyFolderNameStringMatcher-#ctor 'MFR.Objects.Matchers.MatchCaseOnlyFolderNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-MatchCaseOnlyFolderNameStringMatcher-Instance 'MFR.Objects.Matchers.MatchCaseOnlyFolderNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-MatchCaseOnlyFolderNameStringMatcher-TextMatchingConfiguration 'MFR.Objects.Matchers.MatchCaseOnlyFolderNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Matchers-MatchCaseOnlyFolderNameStringMatcher-#cctor 'MFR.Objects.Matchers.MatchCaseOnlyFolderNameStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-MatchCaseOnlyFolderNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.MatchCaseOnlyFolderNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchCaseOnlyTextInFilesStringMatcher](#T-MFR-Objects-Matchers-MatchCaseOnlyTextInFilesStringMatcher 'MFR.Objects.Matchers.MatchCaseOnlyTextInFilesStringMatcher')
  - [#ctor()](#M-MFR-Objects-Matchers-MatchCaseOnlyTextInFilesStringMatcher-#ctor 'MFR.Objects.Matchers.MatchCaseOnlyTextInFilesStringMatcher.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-MatchCaseOnlyTextInFilesStringMatcher-Instance 'MFR.Objects.Matchers.MatchCaseOnlyTextInFilesStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-MatchCaseOnlyTextInFilesStringMatcher-TextMatchingConfiguration 'MFR.Objects.Matchers.MatchCaseOnlyTextInFilesStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Matchers-MatchCaseOnlyTextInFilesStringMatcher-#cctor 'MFR.Objects.Matchers.MatchCaseOnlyTextInFilesStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-MatchCaseOnlyTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.MatchCaseOnlyTextInFilesStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchExactWordOnlyFileNameStringMatcher](#T-MFR-Objects-Matchers-MatchExactWordOnlyFileNameStringMatcher 'MFR.Objects.Matchers.MatchExactWordOnlyFileNameStringMatcher')
  - [#ctor()](#M-MFR-Objects-Matchers-MatchExactWordOnlyFileNameStringMatcher-#ctor 'MFR.Objects.Matchers.MatchExactWordOnlyFileNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-MatchExactWordOnlyFileNameStringMatcher-Instance 'MFR.Objects.Matchers.MatchExactWordOnlyFileNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-MatchExactWordOnlyFileNameStringMatcher-TextMatchingConfiguration 'MFR.Objects.Matchers.MatchExactWordOnlyFileNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Matchers-MatchExactWordOnlyFileNameStringMatcher-#cctor 'MFR.Objects.Matchers.MatchExactWordOnlyFileNameStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-MatchExactWordOnlyFileNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.MatchExactWordOnlyFileNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchExactWordOnlyFolderNameStringMatcher](#T-MFR-Objects-Matchers-MatchExactWordOnlyFolderNameStringMatcher 'MFR.Objects.Matchers.MatchExactWordOnlyFolderNameStringMatcher')
  - [#ctor()](#M-MFR-Objects-Matchers-MatchExactWordOnlyFolderNameStringMatcher-#ctor 'MFR.Objects.Matchers.MatchExactWordOnlyFolderNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-MatchExactWordOnlyFolderNameStringMatcher-Instance 'MFR.Objects.Matchers.MatchExactWordOnlyFolderNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-MatchExactWordOnlyFolderNameStringMatcher-TextMatchingConfiguration 'MFR.Objects.Matchers.MatchExactWordOnlyFolderNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Matchers-MatchExactWordOnlyFolderNameStringMatcher-#cctor 'MFR.Objects.Matchers.MatchExactWordOnlyFolderNameStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-MatchExactWordOnlyFolderNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.MatchExactWordOnlyFolderNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchExactWordOnlyTextInFilesStringMatcher](#T-MFR-Objects-Matchers-MatchExactWordOnlyTextInFilesStringMatcher 'MFR.Objects.Matchers.MatchExactWordOnlyTextInFilesStringMatcher')
  - [#ctor()](#M-MFR-Objects-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-#ctor 'MFR.Objects.Matchers.MatchExactWordOnlyTextInFilesStringMatcher.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-Instance 'MFR.Objects.Matchers.MatchExactWordOnlyTextInFilesStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-TextMatchingConfiguration 'MFR.Objects.Matchers.MatchExactWordOnlyTextInFilesStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-#cctor 'MFR.Objects.Matchers.MatchExactWordOnlyTextInFilesStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.MatchExactWordOnlyTextInFilesStringMatcher.IsMatch(System.String,System.String,System.String)')
- [NeitherMatchCaseNorExactWordFileNameStringMatcher](#T-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordFileNameStringMatcher')
  - [#ctor()](#M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-#ctor 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordFileNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-Instance 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordFileNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-TextMatchingConfiguration 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordFileNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-#cctor 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordFileNameStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordFileNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [NeitherMatchCaseNorExactWordFolderNameStringMatcher](#T-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordFolderNameStringMatcher')
  - [#ctor()](#M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-#ctor 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordFolderNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-Instance 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordFolderNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-TextMatchingConfiguration 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordFolderNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-#cctor 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordFolderNameStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordFolderNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [NeitherMatchCaseNorExactWordTextInFilesStringMatcher](#T-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher')
  - [#ctor()](#M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-#ctor 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-Instance 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-TextMatchingConfiguration 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-#cctor 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher.IsMatch(System.String,System.String,System.String)')
- [RenameFilesInFolderStringMatcherBase](#T-MFR-Objects-Matchers-RenameFilesInFolderStringMatcherBase 'MFR.Objects.Matchers.RenameFilesInFolderStringMatcherBase')
  - [OperationType](#P-MFR-Objects-Matchers-RenameFilesInFolderStringMatcherBase-OperationType 'MFR.Objects.Matchers.RenameFilesInFolderStringMatcherBase.OperationType')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-RenameFilesInFolderStringMatcherBase-TextMatchingConfiguration 'MFR.Objects.Matchers.RenameFilesInFolderStringMatcherBase.TextMatchingConfiguration')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-RenameFilesInFolderStringMatcherBase-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.RenameFilesInFolderStringMatcherBase.IsMatch(System.String,System.String,System.String)')
- [RenameSubFoldersStringMatcherBase](#T-MFR-Objects-Matchers-RenameSubFoldersStringMatcherBase 'MFR.Objects.Matchers.RenameSubFoldersStringMatcherBase')
  - [OperationType](#P-MFR-Objects-Matchers-RenameSubFoldersStringMatcherBase-OperationType 'MFR.Objects.Matchers.RenameSubFoldersStringMatcherBase.OperationType')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-RenameSubFoldersStringMatcherBase-TextMatchingConfiguration 'MFR.Objects.Matchers.RenameSubFoldersStringMatcherBase.TextMatchingConfiguration')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-RenameSubFoldersStringMatcherBase-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.RenameSubFoldersStringMatcherBase.IsMatch(System.String,System.String,System.String)')
- [ReplaceTextInFilesStringMatcherBase](#T-MFR-Objects-Matchers-ReplaceTextInFilesStringMatcherBase 'MFR.Objects.Matchers.ReplaceTextInFilesStringMatcherBase')
  - [OperationType](#P-MFR-Objects-Matchers-ReplaceTextInFilesStringMatcherBase-OperationType 'MFR.Objects.Matchers.ReplaceTextInFilesStringMatcherBase.OperationType')
  - [TextMatchingConfiguration](#P-MFR-Objects-Matchers-ReplaceTextInFilesStringMatcherBase-TextMatchingConfiguration 'MFR.Objects.Matchers.ReplaceTextInFilesStringMatcherBase.TextMatchingConfiguration')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Objects-Matchers-ReplaceTextInFilesStringMatcherBase-IsMatch-System-String,System-String,System-String- 'MFR.Objects.Matchers.ReplaceTextInFilesStringMatcherBase.IsMatch(System.String,System.String,System.String)')
- [Resources](#T-MFR-Objects-Matchers-Properties-Resources 'MFR.Objects.Matchers.Properties.Resources')
  - [Culture](#P-MFR-Objects-Matchers-Properties-Resources-Culture 'MFR.Objects.Matchers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Matchers-Properties-Resources-ResourceManager 'MFR.Objects.Matchers.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher'></a>
## MatchCaseAndExactWordFileNameStringMatcher `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`true`
and Match Exact Word is set to `true`,
for the case when a Rename Files in Folder operation is being performed.

<a name='M-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseAndExactWordFileNameStringMatcher](#T-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher 'MFR.Objects.Matchers.MatchCaseAndExactWordFileNameStringMatcher')
.

<a name='P-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher-GetPattern-System-String-'></a>
### GetPattern(findWhat) `method`

##### Summary

Formulates the pattern to use for searching.

##### Returns

String containing the full regular expression to be used for
searching, or the input if the `findWhat` is
`null`
or whitespace.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to be searched. |

<a name='M-MFR-Objects-Matchers-MatchCaseAndExactWordFileNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Matchers-MatchCaseAndExactWordFolderNameStringMatcher'></a>
## MatchCaseAndExactWordFolderNameStringMatcher `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`true`
and Match Exact Word is set to `true`
for the case when a Rename Sub Folders operation is being performed.

<a name='M-MFR-Objects-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseAndExactWordFolderNameStringMatcher](#T-MFR-Objects-Matchers-MatchCaseAndExactWordFolderNameStringMatcher 'MFR.Objects.Matchers.MatchCaseAndExactWordFolderNameStringMatcher')
.

<a name='P-MFR-Objects-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher'></a>
## MatchCaseAndExactWordTextInFilesStringMatcher `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`true`
and Match Exact Word is set to `true`
for the case when a Replace Text in Files operation is being performed.

<a name='M-MFR-Objects-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseAndExactWordTextInFilesStringMatcher](#T-MFR-Objects-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher 'MFR.Objects.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher')
.

<a name='P-MFR-Objects-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Matchers-MatchCaseOnlyFileNameStringMatcher'></a>
## MatchCaseOnlyFileNameStringMatcher `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`true`
but Match Exact Word is set to `false`
, for the case when a Rename Files in Folder operation is being performed.

<a name='M-MFR-Objects-Matchers-MatchCaseOnlyFileNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-MatchCaseOnlyFileNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseOnlyFileNameStringMatcher](#T-MFR-Objects-Matchers-MatchCaseOnlyFileNameStringMatcher 'MFR.Objects.Matchers.MatchCaseOnlyFileNameStringMatcher').

<a name='P-MFR-Objects-Matchers-MatchCaseOnlyFileNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-MatchCaseOnlyFileNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-MatchCaseOnlyFileNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Matchers-MatchCaseOnlyFolderNameStringMatcher'></a>
## MatchCaseOnlyFolderNameStringMatcher `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`true`
but Match Exact Word is set to `false`
, for the case when a Rename Sub Folders operation is being performed.

<a name='M-MFR-Objects-Matchers-MatchCaseOnlyFolderNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-MatchCaseOnlyFolderNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseOnlyFolderNameStringMatcher](#T-MFR-Objects-Matchers-MatchCaseOnlyFolderNameStringMatcher 'MFR.Objects.Matchers.MatchCaseOnlyFolderNameStringMatcher').

<a name='P-MFR-Objects-Matchers-MatchCaseOnlyFolderNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-MatchCaseOnlyFolderNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-MatchCaseOnlyFolderNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Matchers-MatchCaseOnlyTextInFilesStringMatcher'></a>
## MatchCaseOnlyTextInFilesStringMatcher `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`true`
and Match Exact Word is set to `false`
for the case when a Replace Text in Files operation is being performed.

<a name='M-MFR-Objects-Matchers-MatchCaseOnlyTextInFilesStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-MatchCaseOnlyTextInFilesStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseOnlyTextInFilesStringMatcher](#T-MFR-Objects-Matchers-MatchCaseOnlyTextInFilesStringMatcher 'MFR.Objects.Matchers.MatchCaseOnlyTextInFilesStringMatcher').

<a name='P-MFR-Objects-Matchers-MatchCaseOnlyTextInFilesStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-MatchCaseOnlyTextInFilesStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-MatchCaseOnlyTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Matchers-MatchExactWordOnlyFileNameStringMatcher'></a>
## MatchExactWordOnlyFileNameStringMatcher `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Matches strings only for the case where Match Case is set to `false` and Match Exact Word is set to `true`,
for the case when a Rename Files in Folder operation is being performed.

<a name='M-MFR-Objects-Matchers-MatchExactWordOnlyFileNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-MatchExactWordOnlyFileNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [MatchExactWordOnlyFileNameStringMatcher](#T-MFR-Objects-Matchers-MatchExactWordOnlyFileNameStringMatcher 'MFR.Objects.Matchers.MatchExactWordOnlyFileNameStringMatcher').

<a name='P-MFR-Objects-Matchers-MatchExactWordOnlyFileNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the [TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration') values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-MatchExactWordOnlyFileNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-MatchExactWordOnlyFileNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
### IsMatch(value,findWhat,replaceWith) `method`

##### Summary

Determines whether a `value` string is a match
against a `findWhat`, according to how the
application is configured.

##### Returns

Returns `true` if the `value` is a
match against the provided `findWhat`; `false` if no matches are found.

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
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters, `value` or `findWhat`, are passed blank or
`null` string for values. |

<a name='T-MFR-Objects-Matchers-MatchExactWordOnlyFolderNameStringMatcher'></a>
## MatchExactWordOnlyFolderNameStringMatcher `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`false`
and Match Exact Word is set to `true`
for the case when a Rename Sub Folders operation is being performed.

<a name='M-MFR-Objects-Matchers-MatchExactWordOnlyFolderNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-MatchExactWordOnlyFolderNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchExactWordOnlyFolderNameStringMatcher](#T-MFR-Objects-Matchers-MatchExactWordOnlyFolderNameStringMatcher 'MFR.Objects.Matchers.MatchExactWordOnlyFolderNameStringMatcher')
.

<a name='P-MFR-Objects-Matchers-MatchExactWordOnlyFolderNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-MatchExactWordOnlyFolderNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-MatchExactWordOnlyFolderNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Matchers-MatchExactWordOnlyTextInFilesStringMatcher'></a>
## MatchExactWordOnlyTextInFilesStringMatcher `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`false`
and Match Exact Word is set to `true`
for the case when a Replace Text in Files operation is being performed.

<a name='M-MFR-Objects-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchExactWordOnlyTextInFilesStringMatcher](#T-MFR-Objects-Matchers-MatchExactWordOnlyTextInFilesStringMatcher 'MFR.Objects.Matchers.MatchExactWordOnlyTextInFilesStringMatcher')
.

<a name='P-MFR-Objects-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher'></a>
## NeitherMatchCaseNorExactWordFileNameStringMatcher `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Matches strings only for the case where Match Case is set to `false` and Match Exact Word is set to `false`,
for the case when a Rename Files in Folder operation is being performed.

<a name='M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [NeitherMatchCaseNorExactWordFileNameStringMatcher](#T-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordFileNameStringMatcher').

<a name='P-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the [TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration') values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
### IsMatch(value,findWhat,replaceWith) `method`

##### Summary

Determines whether a `value` string is a match
against a `findWhat`, according to how the
application is configured.

##### Returns

Returns `true` if the `value` is a
match against the provided `findWhat`; `false` if no matches are found.

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
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters, `value` or `findWhat`, are passed blank or
`null` string for values. |

<a name='T-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher'></a>
## NeitherMatchCaseNorExactWordFolderNameStringMatcher `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`false`
and Match Exact Word is set to
`false`
, for the case when a Rename Sub Folders operation is
being performed.

<a name='M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[NeitherMatchCaseNorExactWordFolderNameStringMatcher](#T-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordFolderNameStringMatcher')
.

<a name='P-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher'></a>
## NeitherMatchCaseNorExactWordTextInFilesStringMatcher `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Matches strings only for the case where Match Case is set to `false` and Match Exact Word is set to `false`,
for the case when a Replace Text in Files operation is being performed.

<a name='M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[NeitherMatchCaseNorExactWordTextInFilesStringMatcher](#T-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher 'MFR.Objects.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher').

<a name='P-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Matchers-RenameFilesInFolderStringMatcherBase'></a>
## RenameFilesInFolderStringMatcherBase `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Defines the methods, properties, and events that all String Matcher
objects for the Rename Files in Folder operation type have in common.

<a name='P-MFR-Objects-Matchers-RenameFilesInFolderStringMatcherBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Objects-Matchers-RenameFilesInFolderStringMatcherBase-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-RenameFilesInFolderStringMatcherBase-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Matchers-RenameSubFoldersStringMatcherBase'></a>
## RenameSubFoldersStringMatcherBase `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Defines the methods, properties, and events that all String Matcher
objects for the Rename Sub Folders operation type have in common.

<a name='P-MFR-Objects-Matchers-RenameSubFoldersStringMatcherBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Objects-Matchers-RenameSubFoldersStringMatcherBase-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-RenameSubFoldersStringMatcherBase-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Matchers-ReplaceTextInFilesStringMatcherBase'></a>
## ReplaceTextInFilesStringMatcherBase `type`

##### Namespace

MFR.Objects.Matchers

##### Summary

Defines the methods, properties, and events that all String Matcher
objects for the Replace Text in Files operation type have in common.

<a name='P-MFR-Objects-Matchers-ReplaceTextInFilesStringMatcherBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Objects-Matchers-ReplaceTextInFilesStringMatcherBase-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-ReplaceTextInFilesStringMatcherBase-IsMatch-System-String,System-String,System-String-'></a>
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

##### Remarks

The base class method contains default input-validation logic and
overriders should call the base class method while ignoring its
return value.

<a name='T-MFR-Objects-Matchers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Matchers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Matchers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Matchers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
