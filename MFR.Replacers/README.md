<a name='assembly'></a>
# MFR.Replacers

## Contents

- [MatchCaseAndExactWordFileNameStringReplacer](#T-MFR-Replacers-MatchCaseAndExactWordFileNameStringReplacer 'MFR.Replacers.MatchCaseAndExactWordFileNameStringReplacer')
  - [#ctor()](#M-MFR-Replacers-MatchCaseAndExactWordFileNameStringReplacer-#ctor 'MFR.Replacers.MatchCaseAndExactWordFileNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Replacers-MatchCaseAndExactWordFileNameStringReplacer-Instance 'MFR.Replacers.MatchCaseAndExactWordFileNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Replacers-MatchCaseAndExactWordFileNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchCaseAndExactWordFileNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Replacers-MatchCaseAndExactWordFileNameStringReplacer-#cctor 'MFR.Replacers.MatchCaseAndExactWordFileNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-MatchCaseAndExactWordFileNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchCaseAndExactWordFileNameStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchCaseAndExactWordFolderNameStringReplacer](#T-MFR-Replacers-MatchCaseAndExactWordFolderNameStringReplacer 'MFR.Replacers.MatchCaseAndExactWordFolderNameStringReplacer')
  - [#ctor()](#M-MFR-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-#ctor 'MFR.Replacers.MatchCaseAndExactWordFolderNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-Instance 'MFR.Replacers.MatchCaseAndExactWordFolderNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchCaseAndExactWordFolderNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-#cctor 'MFR.Replacers.MatchCaseAndExactWordFolderNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchCaseAndExactWordFolderNameStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchCaseAndExactWordTextInFilesStringReplacer](#T-MFR-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer 'MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer')
  - [#ctor()](#M-MFR-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-#ctor 'MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer.#ctor')
  - [Instance](#P-MFR-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-Instance 'MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-#cctor 'MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchCaseOnlyFileNameStringReplacer](#T-MFR-Replacers-MatchCaseOnlyFileNameStringReplacer 'MFR.Replacers.MatchCaseOnlyFileNameStringReplacer')
  - [#ctor()](#M-MFR-Replacers-MatchCaseOnlyFileNameStringReplacer-#ctor 'MFR.Replacers.MatchCaseOnlyFileNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Replacers-MatchCaseOnlyFileNameStringReplacer-Instance 'MFR.Replacers.MatchCaseOnlyFileNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Replacers-MatchCaseOnlyFileNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchCaseOnlyFileNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Replacers-MatchCaseOnlyFileNameStringReplacer-#cctor 'MFR.Replacers.MatchCaseOnlyFileNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-MatchCaseOnlyFileNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchCaseOnlyFileNameStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchCaseOnlyFolderNameStringReplacer](#T-MFR-Replacers-MatchCaseOnlyFolderNameStringReplacer 'MFR.Replacers.MatchCaseOnlyFolderNameStringReplacer')
  - [#ctor()](#M-MFR-Replacers-MatchCaseOnlyFolderNameStringReplacer-#ctor 'MFR.Replacers.MatchCaseOnlyFolderNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Replacers-MatchCaseOnlyFolderNameStringReplacer-Instance 'MFR.Replacers.MatchCaseOnlyFolderNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Replacers-MatchCaseOnlyFolderNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchCaseOnlyFolderNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Replacers-MatchCaseOnlyFolderNameStringReplacer-#cctor 'MFR.Replacers.MatchCaseOnlyFolderNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-MatchCaseOnlyFolderNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchCaseOnlyFolderNameStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchCaseOnlyTextInFilesStringReplacer](#T-MFR-Replacers-MatchCaseOnlyTextInFilesStringReplacer 'MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer')
  - [#ctor()](#M-MFR-Replacers-MatchCaseOnlyTextInFilesStringReplacer-#ctor 'MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer.#ctor')
  - [Instance](#P-MFR-Replacers-MatchCaseOnlyTextInFilesStringReplacer-Instance 'MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Replacers-MatchCaseOnlyTextInFilesStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Replacers-MatchCaseOnlyTextInFilesStringReplacer-#cctor 'MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-MatchCaseOnlyTextInFilesStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchExactWordOnlyFileNameStringReplacer](#T-MFR-Replacers-MatchExactWordOnlyFileNameStringReplacer 'MFR.Replacers.MatchExactWordOnlyFileNameStringReplacer')
  - [#ctor()](#M-MFR-Replacers-MatchExactWordOnlyFileNameStringReplacer-#ctor 'MFR.Replacers.MatchExactWordOnlyFileNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Replacers-MatchExactWordOnlyFileNameStringReplacer-Instance 'MFR.Replacers.MatchExactWordOnlyFileNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Replacers-MatchExactWordOnlyFileNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchExactWordOnlyFileNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Replacers-MatchExactWordOnlyFileNameStringReplacer-#cctor 'MFR.Replacers.MatchExactWordOnlyFileNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-MatchExactWordOnlyFileNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchExactWordOnlyFileNameStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchExactWordOnlyFolderNameStringReplacer](#T-MFR-Replacers-MatchExactWordOnlyFolderNameStringReplacer 'MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer')
  - [#ctor()](#M-MFR-Replacers-MatchExactWordOnlyFolderNameStringReplacer-#ctor 'MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Replacers-MatchExactWordOnlyFolderNameStringReplacer-Instance 'MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Replacers-MatchExactWordOnlyFolderNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Replacers-MatchExactWordOnlyFolderNameStringReplacer-#cctor 'MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-MatchExactWordOnlyFolderNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchExactWordOnlyTextInFilesStringReplacer](#T-MFR-Replacers-MatchExactWordOnlyTextInFilesStringReplacer 'MFR.Replacers.MatchExactWordOnlyTextInFilesStringReplacer')
  - [#ctor()](#M-MFR-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-#ctor 'MFR.Replacers.MatchExactWordOnlyTextInFilesStringReplacer.#ctor')
  - [Instance](#P-MFR-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-Instance 'MFR.Replacers.MatchExactWordOnlyTextInFilesStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchExactWordOnlyTextInFilesStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-#cctor 'MFR.Replacers.MatchExactWordOnlyTextInFilesStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchExactWordOnlyTextInFilesStringReplacer.Replace(System.String,System.String,System.String)')
- [NeitherMatchCaseNorExactWordFileNameStringReplacer](#T-MFR-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer 'MFR.Replacers.NeitherMatchCaseNorExactWordFileNameStringReplacer')
  - [#ctor()](#M-MFR-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-#ctor 'MFR.Replacers.NeitherMatchCaseNorExactWordFileNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-Instance 'MFR.Replacers.NeitherMatchCaseNorExactWordFileNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.NeitherMatchCaseNorExactWordFileNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-#cctor 'MFR.Replacers.NeitherMatchCaseNorExactWordFileNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.NeitherMatchCaseNorExactWordFileNameStringReplacer.Replace(System.String,System.String,System.String)')
- [NeitherMatchCaseNorExactWordFolderNameStringReplacer](#T-MFR-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer 'MFR.Replacers.NeitherMatchCaseNorExactWordFolderNameStringReplacer')
  - [#ctor()](#M-MFR-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-#ctor 'MFR.Replacers.NeitherMatchCaseNorExactWordFolderNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-Instance 'MFR.Replacers.NeitherMatchCaseNorExactWordFolderNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.NeitherMatchCaseNorExactWordFolderNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-#cctor 'MFR.Replacers.NeitherMatchCaseNorExactWordFolderNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.NeitherMatchCaseNorExactWordFolderNameStringReplacer.Replace(System.String,System.String,System.String)')
- [NeitherMatchCaseNorExactWordTextInFilesStringReplacer](#T-MFR-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer 'MFR.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer')
  - [#ctor()](#M-MFR-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-#ctor 'MFR.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer.#ctor')
  - [Instance](#P-MFR-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-Instance 'MFR.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-TextMatchingConfiguration 'MFR.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-#cctor 'MFR.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer.Replace(System.String,System.String,System.String)')
- [RenameFilesInFolderStringReplacerBase](#T-MFR-Replacers-RenameFilesInFolderStringReplacerBase 'MFR.Replacers.RenameFilesInFolderStringReplacerBase')
  - [OperationType](#P-MFR-Replacers-RenameFilesInFolderStringReplacerBase-OperationType 'MFR.Replacers.RenameFilesInFolderStringReplacerBase.OperationType')
  - [TextMatchingConfiguration](#P-MFR-Replacers-RenameFilesInFolderStringReplacerBase-TextMatchingConfiguration 'MFR.Replacers.RenameFilesInFolderStringReplacerBase.TextMatchingConfiguration')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-RenameFilesInFolderStringReplacerBase-Replace-System-String,System-String,System-String- 'MFR.Replacers.RenameFilesInFolderStringReplacerBase.Replace(System.String,System.String,System.String)')
- [RenameSubFoldersStringReplacerBase](#T-MFR-Replacers-RenameSubFoldersStringReplacerBase 'MFR.Replacers.RenameSubFoldersStringReplacerBase')
  - [OperationType](#P-MFR-Replacers-RenameSubFoldersStringReplacerBase-OperationType 'MFR.Replacers.RenameSubFoldersStringReplacerBase.OperationType')
  - [TextMatchingConfiguration](#P-MFR-Replacers-RenameSubFoldersStringReplacerBase-TextMatchingConfiguration 'MFR.Replacers.RenameSubFoldersStringReplacerBase.TextMatchingConfiguration')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-RenameSubFoldersStringReplacerBase-Replace-System-String,System-String,System-String- 'MFR.Replacers.RenameSubFoldersStringReplacerBase.Replace(System.String,System.String,System.String)')
- [ReplaceTextInfilesStringReplacerBase](#T-MFR-Replacers-ReplaceTextInfilesStringReplacerBase 'MFR.Replacers.ReplaceTextInfilesStringReplacerBase')
  - [OperationType](#P-MFR-Replacers-ReplaceTextInfilesStringReplacerBase-OperationType 'MFR.Replacers.ReplaceTextInfilesStringReplacerBase.OperationType')
  - [TextMatchingConfiguration](#P-MFR-Replacers-ReplaceTextInfilesStringReplacerBase-TextMatchingConfiguration 'MFR.Replacers.ReplaceTextInfilesStringReplacerBase.TextMatchingConfiguration')
  - [Replace(value,pattern,dest)](#M-MFR-Replacers-ReplaceTextInfilesStringReplacerBase-Replace-System-String,System-String,System-String- 'MFR.Replacers.ReplaceTextInfilesStringReplacerBase.Replace(System.String,System.String,System.String)')
- [Resources](#T-MFR-Replacers-Properties-Resources 'MFR.Replacers.Properties.Resources')
  - [Culture](#P-MFR-Replacers-Properties-Resources-Culture 'MFR.Replacers.Properties.Resources.Culture')
  - [Error_PatternCantBeNulLOrEmpty](#P-MFR-Replacers-Properties-Resources-Error_PatternCantBeNulLOrEmpty 'MFR.Replacers.Properties.Resources.Error_PatternCantBeNulLOrEmpty')
  - [Error_SourceCantBeNullOrEmpty](#P-MFR-Replacers-Properties-Resources-Error_SourceCantBeNullOrEmpty 'MFR.Replacers.Properties.Resources.Error_SourceCantBeNullOrEmpty')
  - [Error_ValueCannotBeNullOrWhiteSpace](#P-MFR-Replacers-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace 'MFR.Replacers.Properties.Resources.Error_ValueCannotBeNullOrWhiteSpace')
  - [ResourceManager](#P-MFR-Replacers-Properties-Resources-ResourceManager 'MFR.Replacers.Properties.Resources.ResourceManager')

<a name='T-MFR-Replacers-MatchCaseAndExactWordFileNameStringReplacer'></a>
## MatchCaseAndExactWordFileNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where both Match Case and Match Whole
Word are set to `true`, for the Rename Files in Folder operation type.

<a name='M-MFR-Replacers-MatchCaseAndExactWordFileNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Replacers-MatchCaseAndExactWordFileNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseAndExactWordFileNameStringReplacer](#T-MFR-Replacers-MatchCaseAndExactWordFileNameStringReplacer 'MFR.Replacers.MatchCaseAndExactWordFileNameStringReplacer')
.

<a name='P-MFR-Replacers-MatchCaseAndExactWordFileNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-MatchCaseAndExactWordFileNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-MatchCaseAndExactWordFileNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new data that should be
substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-MatchCaseAndExactWordFolderNameStringReplacer'></a>
## MatchCaseAndExactWordFolderNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where both Match Case and Match Whole
Word are set to `true`, for the Rename Sub Folders
operation type.

<a name='M-MFR-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseAndExactWordFolderNameStringReplacer](#T-MFR-Replacers-MatchCaseAndExactWordFolderNameStringReplacer 'MFR.Replacers.MatchCaseAndExactWordFolderNameStringReplacer')
.

<a name='P-MFR-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new data that should be
substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer'></a>
## MatchCaseAndExactWordTextInFilesStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where both Match Case and Match Whole
Word are set to `true`, for the ReplaceTextInFiles
operation type.

<a name='M-MFR-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseAndExactWordTextInFilesStringReplacer](#T-MFR-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer 'MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer')
.

<a name='P-MFR-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new data that should be
substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-MatchCaseOnlyFileNameStringReplacer'></a>
## MatchCaseOnlyFileNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where Match Case is set to `true` but Match
Exact Word is set to `false`, for the case when a Rename Files in Folder operation
is being performed.

<a name='M-MFR-Replacers-MatchCaseOnlyFileNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Replacers-MatchCaseOnlyFileNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseOnlyFileNameStringReplacer](#T-MFR-Replacers-MatchCaseOnlyFileNameStringReplacer 'MFR.Replacers.MatchCaseOnlyFileNameStringReplacer').

<a name='P-MFR-Replacers-MatchCaseOnlyFileNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-MatchCaseOnlyFileNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-MatchCaseOnlyFileNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new data that should be
substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-MatchCaseOnlyFolderNameStringReplacer'></a>
## MatchCaseOnlyFolderNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces text in strings when Match Case is set to `true` but Match Exact Word is set to `false`
, for the Rename Sub Folders operation type.

<a name='M-MFR-Replacers-MatchCaseOnlyFolderNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Replacers-MatchCaseOnlyFolderNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [MatchCaseOnlyFolderNameStringReplacer](#T-MFR-Replacers-MatchCaseOnlyFolderNameStringReplacer 'MFR.Replacers.MatchCaseOnlyFolderNameStringReplacer').

<a name='P-MFR-Replacers-MatchCaseOnlyFolderNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the [TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration') values that
corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-MatchCaseOnlyFolderNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-MatchCaseOnlyFolderNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Default is blank. String containing the new data that
should be substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters, `value` , `pattern`, or `dest` , are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-MatchCaseOnlyTextInFilesStringReplacer'></a>
## MatchCaseOnlyTextInFilesStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces text in strings when Match Case is set to
`true`
but Match Exact Word is set to `false`
, for the Replace Text in Files operation type.

<a name='M-MFR-Replacers-MatchCaseOnlyTextInFilesStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Replacers-MatchCaseOnlyTextInFilesStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseOnlyTextInFilesStringReplacer](#T-MFR-Replacers-MatchCaseOnlyTextInFilesStringReplacer 'MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer')
.

<a name='P-MFR-Replacers-MatchCaseOnlyTextInFilesStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-MatchCaseOnlyTextInFilesStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-MatchCaseOnlyTextInFilesStringReplacer-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.



For this style of searching ONLY, the `dest`
parameter can be passed a blank value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Default is blank. String containing the new data that
should be substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
or `pattern`, are passed blank or
`null` strings for values.



For this search, a blank value is allowed for the
`dest` parameter. |

<a name='T-MFR-Replacers-MatchExactWordOnlyFileNameStringReplacer'></a>
## MatchExactWordOnlyFileNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where Match Exact Word is enabled but
Match Case is not, for the Rename Files in Folder operation type.

<a name='M-MFR-Replacers-MatchExactWordOnlyFileNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Replacers-MatchExactWordOnlyFileNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchExactWordOnlyFileNameStringReplacer](#T-MFR-Replacers-MatchExactWordOnlyFileNameStringReplacer 'MFR.Replacers.MatchExactWordOnlyFileNameStringReplacer')
.

<a name='P-MFR-Replacers-MatchExactWordOnlyFileNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-MatchExactWordOnlyFileNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-MatchExactWordOnlyFileNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new data that should be
substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-MatchExactWordOnlyFolderNameStringReplacer'></a>
## MatchExactWordOnlyFolderNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where Match Exact Word is set to
`true`
but Match Case is set to `false`, for
the Rename Sub Folders operation type.

<a name='M-MFR-Replacers-MatchExactWordOnlyFolderNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Replacers-MatchExactWordOnlyFolderNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchExactWordOnlyFolderNameStringReplacer](#T-MFR-Replacers-MatchExactWordOnlyFolderNameStringReplacer 'MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer')
.

<a name='P-MFR-Replacers-MatchExactWordOnlyFolderNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-MatchExactWordOnlyFolderNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-MatchExactWordOnlyFolderNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new data that should be
substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-MatchExactWordOnlyTextInFilesStringReplacer'></a>
## MatchExactWordOnlyTextInFilesStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where Match Exact Word is set to
`true`
but Match Case is set to `false`, for
the Replace Text in Files operation type.

<a name='M-MFR-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchExactWordOnlyTextInFilesStringReplacer](#T-MFR-Replacers-MatchExactWordOnlyTextInFilesStringReplacer 'MFR.Replacers.MatchExactWordOnlyTextInFilesStringReplacer')
.

<a name='P-MFR-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new data that should be
substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer'></a>
## NeitherMatchCaseNorExactWordFileNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where neither Match Case nor Match
Exact Word is set to `true`, for the Rename Files in
Folder operation type.

<a name='M-MFR-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[NeitherMatchCaseNorExactWordFileNameStringReplacer](#T-MFR-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer 'MFR.Replacers.NeitherMatchCaseNorExactWordFileNameStringReplacer')
.

<a name='P-MFR-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new data that should be
substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer'></a>
## NeitherMatchCaseNorExactWordFolderNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where neither Match Case nor Match
Exact Word is set to `true`, for the Rename Sub Folders
operation type.

<a name='M-MFR-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [NeitherMatchCaseNorExactWordFolderNameStringReplacer](#T-MFR-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer 'MFR.Replacers.NeitherMatchCaseNorExactWordFolderNameStringReplacer') .

<a name='P-MFR-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the [TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration') values that
corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new data that should be
substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters, `value` , `pattern`, or `dest` , are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer'></a>
## NeitherMatchCaseNorExactWordTextInFilesStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where neither Match Case nor Match
Exact Word is set to `true`, for the Rename Sub Folders operation type.

<a name='M-MFR-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[NeitherMatchCaseNorExactWordTextInFilesStringReplacer](#T-MFR-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer 'MFR.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer')
.

<a name='P-MFR-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the new data that should be
substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-RenameFilesInFolderStringReplacerBase'></a>
## RenameFilesInFolderStringReplacerBase `type`

##### Namespace

MFR.Replacers

##### Summary

Defines the methods, properties, and events that all String Replacer
objects for the Rename Files in Folder operation type have in common.

<a name='P-MFR-Replacers-RenameFilesInFolderStringReplacerBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-OperationType 'MFR.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Replacers-RenameFilesInFolderStringReplacerBase-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-RenameFilesInFolderStringReplacerBase-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Default is blank. String containing the new data that
should be substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-RenameSubFoldersStringReplacerBase'></a>
## RenameSubFoldersStringReplacerBase `type`

##### Namespace

MFR.Replacers

##### Summary

Defines the methods, properties, and events that all String Replacer
objects for the Rename Files in Folder operation type have in common.

<a name='P-MFR-Replacers-RenameSubFoldersStringReplacerBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-OperationType 'MFR.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Replacers-RenameSubFoldersStringReplacerBase-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-RenameSubFoldersStringReplacerBase-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Default is blank. String containing the new data that
should be substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-ReplaceTextInfilesStringReplacerBase'></a>
## ReplaceTextInfilesStringReplacerBase `type`

##### Namespace

MFR.Replacers

##### Summary

Defines the methods, properties, and events that all String Replacer
objects for the Rename Files in Folder operation type have in common.

<a name='P-MFR-Replacers-ReplaceTextInfilesStringReplacerBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-OperationType 'MFR.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Replacers-ReplaceTextInfilesStringReplacerBase-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Replacers-ReplaceTextInfilesStringReplacerBase-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Default is blank. String containing the new data that
should be substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |

<a name='T-MFR-Replacers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Replacers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Replacers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Replacers-Properties-Resources-Error_PatternCantBeNulLOrEmpty'></a>
### Error_PatternCantBeNulLOrEmpty `property`

##### Summary

Looks up a localized string similar to The pattern cannot be null or the empty string.  It CAN be whitespace, however..

<a name='P-MFR-Replacers-Properties-Resources-Error_SourceCantBeNullOrEmpty'></a>
### Error_SourceCantBeNullOrEmpty `property`

##### Summary

Looks up a localized string similar to Source cannot be null or the empty string.  It CAN be whitespace, however..

<a name='P-MFR-Replacers-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace'></a>
### Error_ValueCannotBeNullOrWhiteSpace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or whitespace..

<a name='P-MFR-Replacers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
