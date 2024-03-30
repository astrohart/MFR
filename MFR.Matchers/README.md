<a name='assembly'></a>
# MFR.Matchers

## Contents

- [MatchCaseAndExactWordFileNameStringMatcher](#T-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher 'MFR.Matchers.MatchCaseAndExactWordFileNameStringMatcher')
  - [#ctor()](#M-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher-#ctor 'MFR.Matchers.MatchCaseAndExactWordFileNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher-Instance 'MFR.Matchers.MatchCaseAndExactWordFileNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher-TextMatchingConfiguration 'MFR.Matchers.MatchCaseAndExactWordFileNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher-#cctor 'MFR.Matchers.MatchCaseAndExactWordFileNameStringMatcher.#cctor')
  - [GetPattern(findWhat)](#M-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher-GetPattern-System-String- 'MFR.Matchers.MatchCaseAndExactWordFileNameStringMatcher.GetPattern(System.String)')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.MatchCaseAndExactWordFileNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchCaseAndExactWordFolderNameStringMatcher](#T-MFR-Matchers-MatchCaseAndExactWordFolderNameStringMatcher 'MFR.Matchers.MatchCaseAndExactWordFolderNameStringMatcher')
  - [#ctor()](#M-MFR-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-#ctor 'MFR.Matchers.MatchCaseAndExactWordFolderNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-Instance 'MFR.Matchers.MatchCaseAndExactWordFolderNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-TextMatchingConfiguration 'MFR.Matchers.MatchCaseAndExactWordFolderNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-#cctor 'MFR.Matchers.MatchCaseAndExactWordFolderNameStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.MatchCaseAndExactWordFolderNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchCaseAndExactWordTextInFilesStringMatcher](#T-MFR-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher 'MFR.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher')
  - [#ctor()](#M-MFR-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-#ctor 'MFR.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher.#ctor')
  - [Instance](#P-MFR-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-Instance 'MFR.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-TextMatchingConfiguration 'MFR.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-#cctor 'MFR.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchCaseOnlyFileNameStringMatcher](#T-MFR-Matchers-MatchCaseOnlyFileNameStringMatcher 'MFR.Matchers.MatchCaseOnlyFileNameStringMatcher')
  - [#ctor()](#M-MFR-Matchers-MatchCaseOnlyFileNameStringMatcher-#ctor 'MFR.Matchers.MatchCaseOnlyFileNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Matchers-MatchCaseOnlyFileNameStringMatcher-Instance 'MFR.Matchers.MatchCaseOnlyFileNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Matchers-MatchCaseOnlyFileNameStringMatcher-TextMatchingConfiguration 'MFR.Matchers.MatchCaseOnlyFileNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Matchers-MatchCaseOnlyFileNameStringMatcher-#cctor 'MFR.Matchers.MatchCaseOnlyFileNameStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-MatchCaseOnlyFileNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.MatchCaseOnlyFileNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchCaseOnlyFolderNameStringMatcher](#T-MFR-Matchers-MatchCaseOnlyFolderNameStringMatcher 'MFR.Matchers.MatchCaseOnlyFolderNameStringMatcher')
  - [#ctor()](#M-MFR-Matchers-MatchCaseOnlyFolderNameStringMatcher-#ctor 'MFR.Matchers.MatchCaseOnlyFolderNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Matchers-MatchCaseOnlyFolderNameStringMatcher-Instance 'MFR.Matchers.MatchCaseOnlyFolderNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Matchers-MatchCaseOnlyFolderNameStringMatcher-TextMatchingConfiguration 'MFR.Matchers.MatchCaseOnlyFolderNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Matchers-MatchCaseOnlyFolderNameStringMatcher-#cctor 'MFR.Matchers.MatchCaseOnlyFolderNameStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-MatchCaseOnlyFolderNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.MatchCaseOnlyFolderNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchCaseOnlyTextInFilesStringMatcher](#T-MFR-Matchers-MatchCaseOnlyTextInFilesStringMatcher 'MFR.Matchers.MatchCaseOnlyTextInFilesStringMatcher')
  - [#ctor()](#M-MFR-Matchers-MatchCaseOnlyTextInFilesStringMatcher-#ctor 'MFR.Matchers.MatchCaseOnlyTextInFilesStringMatcher.#ctor')
  - [Instance](#P-MFR-Matchers-MatchCaseOnlyTextInFilesStringMatcher-Instance 'MFR.Matchers.MatchCaseOnlyTextInFilesStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Matchers-MatchCaseOnlyTextInFilesStringMatcher-TextMatchingConfiguration 'MFR.Matchers.MatchCaseOnlyTextInFilesStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Matchers-MatchCaseOnlyTextInFilesStringMatcher-#cctor 'MFR.Matchers.MatchCaseOnlyTextInFilesStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-MatchCaseOnlyTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.MatchCaseOnlyTextInFilesStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchExactWordOnlyFileNameStringMatcher](#T-MFR-Matchers-MatchExactWordOnlyFileNameStringMatcher 'MFR.Matchers.MatchExactWordOnlyFileNameStringMatcher')
  - [#ctor()](#M-MFR-Matchers-MatchExactWordOnlyFileNameStringMatcher-#ctor 'MFR.Matchers.MatchExactWordOnlyFileNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Matchers-MatchExactWordOnlyFileNameStringMatcher-Instance 'MFR.Matchers.MatchExactWordOnlyFileNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Matchers-MatchExactWordOnlyFileNameStringMatcher-TextMatchingConfiguration 'MFR.Matchers.MatchExactWordOnlyFileNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Matchers-MatchExactWordOnlyFileNameStringMatcher-#cctor 'MFR.Matchers.MatchExactWordOnlyFileNameStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-MatchExactWordOnlyFileNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.MatchExactWordOnlyFileNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchExactWordOnlyFolderNameStringMatcher](#T-MFR-Matchers-MatchExactWordOnlyFolderNameStringMatcher 'MFR.Matchers.MatchExactWordOnlyFolderNameStringMatcher')
  - [#ctor()](#M-MFR-Matchers-MatchExactWordOnlyFolderNameStringMatcher-#ctor 'MFR.Matchers.MatchExactWordOnlyFolderNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Matchers-MatchExactWordOnlyFolderNameStringMatcher-Instance 'MFR.Matchers.MatchExactWordOnlyFolderNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Matchers-MatchExactWordOnlyFolderNameStringMatcher-TextMatchingConfiguration 'MFR.Matchers.MatchExactWordOnlyFolderNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Matchers-MatchExactWordOnlyFolderNameStringMatcher-#cctor 'MFR.Matchers.MatchExactWordOnlyFolderNameStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-MatchExactWordOnlyFolderNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.MatchExactWordOnlyFolderNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [MatchExactWordOnlyTextInFilesStringMatcher](#T-MFR-Matchers-MatchExactWordOnlyTextInFilesStringMatcher 'MFR.Matchers.MatchExactWordOnlyTextInFilesStringMatcher')
  - [#ctor()](#M-MFR-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-#ctor 'MFR.Matchers.MatchExactWordOnlyTextInFilesStringMatcher.#ctor')
  - [Instance](#P-MFR-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-Instance 'MFR.Matchers.MatchExactWordOnlyTextInFilesStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-TextMatchingConfiguration 'MFR.Matchers.MatchExactWordOnlyTextInFilesStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-#cctor 'MFR.Matchers.MatchExactWordOnlyTextInFilesStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.MatchExactWordOnlyTextInFilesStringMatcher.IsMatch(System.String,System.String,System.String)')
- [NeitherMatchCaseNorExactWordFileNameStringMatcher](#T-MFR-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher 'MFR.Matchers.NeitherMatchCaseNorExactWordFileNameStringMatcher')
  - [#ctor()](#M-MFR-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-#ctor 'MFR.Matchers.NeitherMatchCaseNorExactWordFileNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-Instance 'MFR.Matchers.NeitherMatchCaseNorExactWordFileNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-TextMatchingConfiguration 'MFR.Matchers.NeitherMatchCaseNorExactWordFileNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-#cctor 'MFR.Matchers.NeitherMatchCaseNorExactWordFileNameStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.NeitherMatchCaseNorExactWordFileNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [NeitherMatchCaseNorExactWordFolderNameStringMatcher](#T-MFR-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher 'MFR.Matchers.NeitherMatchCaseNorExactWordFolderNameStringMatcher')
  - [#ctor()](#M-MFR-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-#ctor 'MFR.Matchers.NeitherMatchCaseNorExactWordFolderNameStringMatcher.#ctor')
  - [Instance](#P-MFR-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-Instance 'MFR.Matchers.NeitherMatchCaseNorExactWordFolderNameStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-TextMatchingConfiguration 'MFR.Matchers.NeitherMatchCaseNorExactWordFolderNameStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-#cctor 'MFR.Matchers.NeitherMatchCaseNorExactWordFolderNameStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.NeitherMatchCaseNorExactWordFolderNameStringMatcher.IsMatch(System.String,System.String,System.String)')
- [NeitherMatchCaseNorExactWordTextInFilesStringMatcher](#T-MFR-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher 'MFR.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher')
  - [#ctor()](#M-MFR-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-#ctor 'MFR.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher.#ctor')
  - [Instance](#P-MFR-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-Instance 'MFR.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher.Instance')
  - [TextMatchingConfiguration](#P-MFR-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-TextMatchingConfiguration 'MFR.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-#cctor 'MFR.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher.#cctor')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher.IsMatch(System.String,System.String,System.String)')
- [RenameFilesInFolderStringMatcherBase](#T-MFR-Matchers-RenameFilesInFolderStringMatcherBase 'MFR.Matchers.RenameFilesInFolderStringMatcherBase')
  - [OperationType](#P-MFR-Matchers-RenameFilesInFolderStringMatcherBase-OperationType 'MFR.Matchers.RenameFilesInFolderStringMatcherBase.OperationType')
  - [TextMatchingConfiguration](#P-MFR-Matchers-RenameFilesInFolderStringMatcherBase-TextMatchingConfiguration 'MFR.Matchers.RenameFilesInFolderStringMatcherBase.TextMatchingConfiguration')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-RenameFilesInFolderStringMatcherBase-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.RenameFilesInFolderStringMatcherBase.IsMatch(System.String,System.String,System.String)')
- [RenameSubFoldersStringMatcherBase](#T-MFR-Matchers-RenameSubFoldersStringMatcherBase 'MFR.Matchers.RenameSubFoldersStringMatcherBase')
  - [OperationType](#P-MFR-Matchers-RenameSubFoldersStringMatcherBase-OperationType 'MFR.Matchers.RenameSubFoldersStringMatcherBase.OperationType')
  - [TextMatchingConfiguration](#P-MFR-Matchers-RenameSubFoldersStringMatcherBase-TextMatchingConfiguration 'MFR.Matchers.RenameSubFoldersStringMatcherBase.TextMatchingConfiguration')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-RenameSubFoldersStringMatcherBase-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.RenameSubFoldersStringMatcherBase.IsMatch(System.String,System.String,System.String)')
- [ReplaceTextInFilesStringMatcherBase](#T-MFR-Matchers-ReplaceTextInFilesStringMatcherBase 'MFR.Matchers.ReplaceTextInFilesStringMatcherBase')
  - [OperationType](#P-MFR-Matchers-ReplaceTextInFilesStringMatcherBase-OperationType 'MFR.Matchers.ReplaceTextInFilesStringMatcherBase.OperationType')
  - [TextMatchingConfiguration](#P-MFR-Matchers-ReplaceTextInFilesStringMatcherBase-TextMatchingConfiguration 'MFR.Matchers.ReplaceTextInFilesStringMatcherBase.TextMatchingConfiguration')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Matchers-ReplaceTextInFilesStringMatcherBase-IsMatch-System-String,System-String,System-String- 'MFR.Matchers.ReplaceTextInFilesStringMatcherBase.IsMatch(System.String,System.String,System.String)')
- [Resources](#T-MFR-Matchers-Properties-Resources 'MFR.Matchers.Properties.Resources')
  - [Culture](#P-MFR-Matchers-Properties-Resources-Culture 'MFR.Matchers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Matchers-Properties-Resources-ResourceManager 'MFR.Matchers.Properties.Resources.ResourceManager')

<a name='T-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher'></a>
## MatchCaseAndExactWordFileNameStringMatcher `type`

##### Namespace

MFR.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`true`
and Match Exact Word is set to `true`,
for the case when a Rename Files in Folder operation is being performed.

<a name='M-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseAndExactWordFileNameStringMatcher](#T-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher 'MFR.Matchers.MatchCaseAndExactWordFileNameStringMatcher')
.

<a name='P-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher-GetPattern-System-String-'></a>
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

<a name='M-MFR-Matchers-MatchCaseAndExactWordFileNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-MatchCaseAndExactWordFolderNameStringMatcher'></a>
## MatchCaseAndExactWordFolderNameStringMatcher `type`

##### Namespace

MFR.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`true`
and Match Exact Word is set to `true`
for the case when a Rename Sub Folders operation is being performed.

<a name='M-MFR-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface that matches
BOTH on character casing AND on the exact string that is supplied for the
text-replacement specification provided by the user in the box
in the user interface.



This the Mass File Renamer analogy of the user placing check marks in both
the and the checkbox in, say, the
, dialog box in most text-editing applications.

<a name='P-MFR-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-MatchCaseAndExactWordFolderNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher'></a>
## MatchCaseAndExactWordTextInFilesStringMatcher `type`

##### Namespace

MFR.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`true`
and Match Exact Word is set to `true`
for the case when a Replace Text in Files operation is being performed.

<a name='M-MFR-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseAndExactWordTextInFilesStringMatcher](#T-MFR-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher 'MFR.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher')
.

<a name='P-MFR-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-MatchCaseAndExactWordTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-MatchCaseOnlyFileNameStringMatcher'></a>
## MatchCaseOnlyFileNameStringMatcher `type`

##### Namespace

MFR.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`true`
but Match Exact Word is set to `false`
, for the case when a Rename Files in Folder operation is being performed.

<a name='M-MFR-Matchers-MatchCaseOnlyFileNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-MatchCaseOnlyFileNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseOnlyFileNameStringMatcher](#T-MFR-Matchers-MatchCaseOnlyFileNameStringMatcher 'MFR.Matchers.MatchCaseOnlyFileNameStringMatcher').

<a name='P-MFR-Matchers-MatchCaseOnlyFileNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-MatchCaseOnlyFileNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-MatchCaseOnlyFileNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-MatchCaseOnlyFolderNameStringMatcher'></a>
## MatchCaseOnlyFolderNameStringMatcher `type`

##### Namespace

MFR.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`true`
but Match Exact Word is set to `false`
, for the case when a Rename Sub Folders operation is being performed.

<a name='M-MFR-Matchers-MatchCaseOnlyFolderNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-MatchCaseOnlyFolderNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface that matches
text expressions with a case-sensitive search.



This object should be used when the check box is selected by
the user when doing the operations of renaming solution folders or sub folders
of a Solution.

<a name='P-MFR-Matchers-MatchCaseOnlyFolderNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-MatchCaseOnlyFolderNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-MatchCaseOnlyFolderNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-MatchCaseOnlyTextInFilesStringMatcher'></a>
## MatchCaseOnlyTextInFilesStringMatcher `type`

##### Namespace

MFR.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`true`
and Match Exact Word is set to `false`
for the case when a Replace Text in Files operation is being performed.

<a name='M-MFR-Matchers-MatchCaseOnlyTextInFilesStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-MatchCaseOnlyTextInFilesStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseOnlyTextInFilesStringMatcher](#T-MFR-Matchers-MatchCaseOnlyTextInFilesStringMatcher 'MFR.Matchers.MatchCaseOnlyTextInFilesStringMatcher').

<a name='P-MFR-Matchers-MatchCaseOnlyTextInFilesStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-MatchCaseOnlyTextInFilesStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-MatchCaseOnlyTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-MatchExactWordOnlyFileNameStringMatcher'></a>
## MatchExactWordOnlyFileNameStringMatcher `type`

##### Namespace

MFR.Matchers

##### Summary

Matches strings only for the case where Match Case is set to `false` and Match Exact Word is set to `true`,
for the case when a Rename Files in Folder operation is being performed.

<a name='M-MFR-Matchers-MatchExactWordOnlyFileNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-MatchExactWordOnlyFileNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [MatchExactWordOnlyFileNameStringMatcher](#T-MFR-Matchers-MatchExactWordOnlyFileNameStringMatcher 'MFR.Matchers.MatchExactWordOnlyFileNameStringMatcher').

<a name='P-MFR-Matchers-MatchExactWordOnlyFileNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the [TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration') values
that corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-MatchExactWordOnlyFileNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-MatchExactWordOnlyFileNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-MatchExactWordOnlyFolderNameStringMatcher'></a>
## MatchExactWordOnlyFolderNameStringMatcher `type`

##### Namespace

MFR.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`false`
and Match Exact Word is set to `true`
for the case when a Rename Sub Folders operation is being performed.

<a name='M-MFR-Matchers-MatchExactWordOnlyFolderNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-MatchExactWordOnlyFolderNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface that matches
the exact string that is supplied for the text-replacement specification
provided by the user in the box in the user interface.



This the Mass File Renamer analogy of the `Match Whole Word` checkbox
in, say, the , dialog box in most text-editing
applications.

<a name='P-MFR-Matchers-MatchExactWordOnlyFolderNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-MatchExactWordOnlyFolderNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-MatchExactWordOnlyFolderNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-MatchExactWordOnlyTextInFilesStringMatcher'></a>
## MatchExactWordOnlyTextInFilesStringMatcher `type`

##### Namespace

MFR.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`false`
and Match Exact Word is set to `true`
for the case when a Replace Text in Files operation is being performed.

<a name='M-MFR-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchExactWordOnlyTextInFilesStringMatcher](#T-MFR-Matchers-MatchExactWordOnlyTextInFilesStringMatcher 'MFR.Matchers.MatchExactWordOnlyTextInFilesStringMatcher')
.

<a name='P-MFR-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-MatchExactWordOnlyTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher'></a>
## NeitherMatchCaseNorExactWordFileNameStringMatcher `type`

##### Namespace

MFR.Matchers

##### Summary

Matches strings only for the case where Match Case is set to `false` and Match Exact Word is set to `false`,
for the case when a Rename Files in Folder operation is being performed.

<a name='M-MFR-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [NeitherMatchCaseNorExactWordFileNameStringMatcher](#T-MFR-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher 'MFR.Matchers.NeitherMatchCaseNorExactWordFileNameStringMatcher').

<a name='P-MFR-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the [TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration') values
that corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-NeitherMatchCaseNorExactWordFileNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher'></a>
## NeitherMatchCaseNorExactWordFolderNameStringMatcher `type`

##### Namespace

MFR.Matchers

##### Summary

Matches strings only for the case where Match Case is set to
`false`
and Match Exact Word is set to
`false`
, for the case when a Rename Sub Folders operation is
being performed.

<a name='M-MFR-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface that matches
NEITHER on character casing NOR on the exact string that is supplied for the
text-replacement specification provided by the user in the box
in the user interface.



This the Mass File Renamer analogy of the user clearing check marks in both
the and the checkbox in, say, the
, dialog box in most text-editing applications.

<a name='P-MFR-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-NeitherMatchCaseNorExactWordFolderNameStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher'></a>
## NeitherMatchCaseNorExactWordTextInFilesStringMatcher `type`

##### Namespace

MFR.Matchers

##### Summary

Matches strings only for the case where Match Case is set to `false` and Match Exact Word is set to `false`,
for the case when a Replace Text in Files operation is being performed.

<a name='M-MFR-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[NeitherMatchCaseNorExactWordTextInFilesStringMatcher](#T-MFR-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher 'MFR.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher').

<a name='P-MFR-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-NeitherMatchCaseNorExactWordTextInFilesStringMatcher-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-RenameFilesInFolderStringMatcherBase'></a>
## RenameFilesInFolderStringMatcherBase `type`

##### Namespace

MFR.Matchers

##### Summary

Defines the methods, properties, and events that all String Matcher
objects for the Rename Files in Folder operation type have in common.

<a name='P-MFR-Matchers-RenameFilesInFolderStringMatcherBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Matchers-RenameFilesInFolderStringMatcherBase-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-RenameFilesInFolderStringMatcherBase-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-RenameSubFoldersStringMatcherBase'></a>
## RenameSubFoldersStringMatcherBase `type`

##### Namespace

MFR.Matchers

##### Summary

Defines the methods, properties, and events that all String Matcher
objects for the Rename Sub Folders operation type have in common.

<a name='P-MFR-Matchers-RenameSubFoldersStringMatcherBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Matchers-RenameSubFoldersStringMatcherBase-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-RenameSubFoldersStringMatcherBase-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-ReplaceTextInFilesStringMatcherBase'></a>
## ReplaceTextInFilesStringMatcherBase `type`

##### Namespace

MFR.Matchers

##### Summary

Defines the methods, properties, and events that all String Matcher
objects for the Replace Text in Files operation type have in common.

<a name='P-MFR-Matchers-ReplaceTextInFilesStringMatcherBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Matchers-ReplaceTextInFilesStringMatcherBase-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-ReplaceTextInFilesStringMatcherBase-IsMatch-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Matchers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Matchers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Matchers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Matchers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
