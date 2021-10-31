<a name='assembly'></a>
# MFR.Replacers

## Contents

- [MatchCaseAndExactWordFileNameStringReplacer](#T-MFR-Objects-Replacers-MatchCaseAndExactWordFileNameStringReplacer 'MFR.Replacers.MatchCaseAndExactWordFileNameStringReplacer')
  - [#ctor()](#M-MFR-Objects-Replacers-MatchCaseAndExactWordFileNameStringReplacer-#ctor 'MFR.Replacers.MatchCaseAndExactWordFileNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-MatchCaseAndExactWordFileNameStringReplacer-Instance 'MFR.Replacers.MatchCaseAndExactWordFileNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-MatchCaseAndExactWordFileNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchCaseAndExactWordFileNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Replacers-MatchCaseAndExactWordFileNameStringReplacer-#cctor 'MFR.Replacers.MatchCaseAndExactWordFileNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-MatchCaseAndExactWordFileNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchCaseAndExactWordFileNameStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchCaseAndExactWordFolderNameStringReplacer](#T-MFR-Objects-Replacers-MatchCaseAndExactWordFolderNameStringReplacer 'MFR.Replacers.MatchCaseAndExactWordFolderNameStringReplacer')
  - [#ctor()](#M-MFR-Objects-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-#ctor 'MFR.Replacers.MatchCaseAndExactWordFolderNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-Instance 'MFR.Replacers.MatchCaseAndExactWordFolderNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchCaseAndExactWordFolderNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-#cctor 'MFR.Replacers.MatchCaseAndExactWordFolderNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchCaseAndExactWordFolderNameStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchCaseAndExactWordTextInFilesStringReplacer](#T-MFR-Objects-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer 'MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer')
  - [#ctor()](#M-MFR-Objects-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-#ctor 'MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-Instance 'MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-#cctor 'MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchCaseOnlyFileNameStringReplacer](#T-MFR-Objects-Replacers-MatchCaseOnlyFileNameStringReplacer 'MFR.Replacers.MatchCaseOnlyFileNameStringReplacer')
  - [#ctor()](#M-MFR-Objects-Replacers-MatchCaseOnlyFileNameStringReplacer-#ctor 'MFR.Replacers.MatchCaseOnlyFileNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-MatchCaseOnlyFileNameStringReplacer-Instance 'MFR.Replacers.MatchCaseOnlyFileNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-MatchCaseOnlyFileNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchCaseOnlyFileNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Replacers-MatchCaseOnlyFileNameStringReplacer-#cctor 'MFR.Replacers.MatchCaseOnlyFileNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-MatchCaseOnlyFileNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchCaseOnlyFileNameStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchCaseOnlyFolderNameStringReplacer](#T-MFR-Objects-Replacers-MatchCaseOnlyFolderNameStringReplacer 'MFR.Replacers.MatchCaseOnlyFolderNameStringReplacer')
  - [#ctor()](#M-MFR-Objects-Replacers-MatchCaseOnlyFolderNameStringReplacer-#ctor 'MFR.Replacers.MatchCaseOnlyFolderNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-MatchCaseOnlyFolderNameStringReplacer-Instance 'MFR.Replacers.MatchCaseOnlyFolderNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-MatchCaseOnlyFolderNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchCaseOnlyFolderNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Replacers-MatchCaseOnlyFolderNameStringReplacer-#cctor 'MFR.Replacers.MatchCaseOnlyFolderNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-MatchCaseOnlyFolderNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchCaseOnlyFolderNameStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchCaseOnlyTextInFilesStringReplacer](#T-MFR-Objects-Replacers-MatchCaseOnlyTextInFilesStringReplacer 'MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer')
  - [#ctor()](#M-MFR-Objects-Replacers-MatchCaseOnlyTextInFilesStringReplacer-#ctor 'MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-MatchCaseOnlyTextInFilesStringReplacer-Instance 'MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-MatchCaseOnlyTextInFilesStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Replacers-MatchCaseOnlyTextInFilesStringReplacer-#cctor 'MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-MatchCaseOnlyTextInFilesStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchExactWordOnlyFileNameStringReplacer](#T-MFR-Objects-Replacers-MatchExactWordOnlyFileNameStringReplacer 'MFR.Replacers.MatchExactWordOnlyFileNameStringReplacer')
  - [#ctor()](#M-MFR-Objects-Replacers-MatchExactWordOnlyFileNameStringReplacer-#ctor 'MFR.Replacers.MatchExactWordOnlyFileNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-MatchExactWordOnlyFileNameStringReplacer-Instance 'MFR.Replacers.MatchExactWordOnlyFileNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-MatchExactWordOnlyFileNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchExactWordOnlyFileNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Replacers-MatchExactWordOnlyFileNameStringReplacer-#cctor 'MFR.Replacers.MatchExactWordOnlyFileNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-MatchExactWordOnlyFileNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchExactWordOnlyFileNameStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchExactWordOnlyFolderNameStringReplacer](#T-MFR-Objects-Replacers-MatchExactWordOnlyFolderNameStringReplacer 'MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer')
  - [#ctor()](#M-MFR-Objects-Replacers-MatchExactWordOnlyFolderNameStringReplacer-#ctor 'MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-MatchExactWordOnlyFolderNameStringReplacer-Instance 'MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-MatchExactWordOnlyFolderNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Replacers-MatchExactWordOnlyFolderNameStringReplacer-#cctor 'MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-MatchExactWordOnlyFolderNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer.Replace(System.String,System.String,System.String)')
- [MatchExactWordOnlyTextInFilesStringReplacer](#T-MFR-Objects-Replacers-MatchExactWordOnlyTextInFilesStringReplacer 'MFR.Replacers.MatchExactWordOnlyTextInFilesStringReplacer')
  - [#ctor()](#M-MFR-Objects-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-#ctor 'MFR.Replacers.MatchExactWordOnlyTextInFilesStringReplacer.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-Instance 'MFR.Replacers.MatchExactWordOnlyTextInFilesStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-TextMatchingConfiguration 'MFR.Replacers.MatchExactWordOnlyTextInFilesStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-#cctor 'MFR.Replacers.MatchExactWordOnlyTextInFilesStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.MatchExactWordOnlyTextInFilesStringReplacer.Replace(System.String,System.String,System.String)')
- [NeitherMatchCaseNorExactWordFileNameStringReplacer](#T-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer 'MFR.Replacers.NeitherMatchCaseNorExactWordFileNameStringReplacer')
  - [#ctor()](#M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-#ctor 'MFR.Replacers.NeitherMatchCaseNorExactWordFileNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-Instance 'MFR.Replacers.NeitherMatchCaseNorExactWordFileNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.NeitherMatchCaseNorExactWordFileNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-#cctor 'MFR.Replacers.NeitherMatchCaseNorExactWordFileNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.NeitherMatchCaseNorExactWordFileNameStringReplacer.Replace(System.String,System.String,System.String)')
- [NeitherMatchCaseNorExactWordFolderNameStringReplacer](#T-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer 'MFR.Replacers.NeitherMatchCaseNorExactWordFolderNameStringReplacer')
  - [#ctor()](#M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-#ctor 'MFR.Replacers.NeitherMatchCaseNorExactWordFolderNameStringReplacer.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-Instance 'MFR.Replacers.NeitherMatchCaseNorExactWordFolderNameStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-TextMatchingConfiguration 'MFR.Replacers.NeitherMatchCaseNorExactWordFolderNameStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-#cctor 'MFR.Replacers.NeitherMatchCaseNorExactWordFolderNameStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.NeitherMatchCaseNorExactWordFolderNameStringReplacer.Replace(System.String,System.String,System.String)')
- [NeitherMatchCaseNorExactWordTextInFilesStringReplacer](#T-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer 'MFR.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer')
  - [#ctor()](#M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-#ctor 'MFR.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-Instance 'MFR.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer.Instance')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-TextMatchingConfiguration 'MFR.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer.TextMatchingConfiguration')
  - [#cctor()](#M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-#cctor 'MFR.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer.#cctor')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-Replace-System-String,System-String,System-String- 'MFR.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer.Replace(System.String,System.String,System.String)')
- [RenameFilesInFolderStringReplacerBase](#T-MFR-Objects-Replacers-RenameFilesInFolderStringReplacerBase 'MFR.Replacers.RenameFilesInFolderStringReplacerBase')
  - [OperationType](#P-MFR-Objects-Replacers-RenameFilesInFolderStringReplacerBase-OperationType 'MFR.Replacers.RenameFilesInFolderStringReplacerBase.OperationType')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-RenameFilesInFolderStringReplacerBase-TextMatchingConfiguration 'MFR.Replacers.RenameFilesInFolderStringReplacerBase.TextMatchingConfiguration')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-RenameFilesInFolderStringReplacerBase-Replace-System-String,System-String,System-String- 'MFR.Replacers.RenameFilesInFolderStringReplacerBase.Replace(System.String,System.String,System.String)')
- [RenameSubFoldersStringReplacerBase](#T-MFR-Objects-Replacers-RenameSubFoldersStringReplacerBase 'MFR.Replacers.RenameSubFoldersStringReplacerBase')
  - [OperationType](#P-MFR-Objects-Replacers-RenameSubFoldersStringReplacerBase-OperationType 'MFR.Replacers.RenameSubFoldersStringReplacerBase.OperationType')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-RenameSubFoldersStringReplacerBase-TextMatchingConfiguration 'MFR.Replacers.RenameSubFoldersStringReplacerBase.TextMatchingConfiguration')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-RenameSubFoldersStringReplacerBase-Replace-System-String,System-String,System-String- 'MFR.Replacers.RenameSubFoldersStringReplacerBase.Replace(System.String,System.String,System.String)')
- [ReplaceTextInfilesStringReplacerBase](#T-MFR-Objects-Replacers-ReplaceTextInfilesStringReplacerBase 'MFR.Replacers.ReplaceTextInfilesStringReplacerBase')
  - [OperationType](#P-MFR-Objects-Replacers-ReplaceTextInfilesStringReplacerBase-OperationType 'MFR.Replacers.ReplaceTextInfilesStringReplacerBase.OperationType')
  - [TextMatchingConfiguration](#P-MFR-Objects-Replacers-ReplaceTextInfilesStringReplacerBase-TextMatchingConfiguration 'MFR.Replacers.ReplaceTextInfilesStringReplacerBase.TextMatchingConfiguration')
  - [Replace(value,pattern,dest)](#M-MFR-Objects-Replacers-ReplaceTextInfilesStringReplacerBase-Replace-System-String,System-String,System-String- 'MFR.Replacers.ReplaceTextInfilesStringReplacerBase.Replace(System.String,System.String,System.String)')
- [Resources](#T-MFR-Objects-Replacers-Properties-Resources 'MFR.Replacers.Properties.Resources')
  - [Culture](#P-MFR-Objects-Replacers-Properties-Resources-Culture 'MFR.Replacers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Replacers-Properties-Resources-ResourceManager 'MFR.Replacers.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Replacers-MatchCaseAndExactWordFileNameStringReplacer'></a>
## MatchCaseAndExactWordFileNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where both Match Case and Match Whole
Word are set to `true`, for the Rename Files in Folder operation type.

<a name='M-MFR-Objects-Replacers-MatchCaseAndExactWordFileNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-MatchCaseAndExactWordFileNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseAndExactWordFileNameStringReplacer](#T-MFR-Objects-Replacers-MatchCaseAndExactWordFileNameStringReplacer 'MFR.Replacers.MatchCaseAndExactWordFileNameStringReplacer')
.

<a name='P-MFR-Objects-Replacers-MatchCaseAndExactWordFileNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-MatchCaseAndExactWordFileNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-MatchCaseAndExactWordFileNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-MatchCaseAndExactWordFolderNameStringReplacer'></a>
## MatchCaseAndExactWordFolderNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where both Match Case and Match Whole
Word are set to `true`, for the Rename Sub Folders
operation type.

<a name='M-MFR-Objects-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseAndExactWordFolderNameStringReplacer](#T-MFR-Objects-Replacers-MatchCaseAndExactWordFolderNameStringReplacer 'MFR.Replacers.MatchCaseAndExactWordFolderNameStringReplacer')
.

<a name='P-MFR-Objects-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-MatchCaseAndExactWordFolderNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer'></a>
## MatchCaseAndExactWordTextInFilesStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where both Match Case and Match Whole
Word are set to `true`, for the ReplaceTextInFiles
operation type.

<a name='M-MFR-Objects-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseAndExactWordTextInFilesStringReplacer](#T-MFR-Objects-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer 'MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer')
.

<a name='P-MFR-Objects-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-MatchCaseAndExactWordTextInFilesStringReplacer-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-MatchCaseOnlyFileNameStringReplacer'></a>
## MatchCaseOnlyFileNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where Match Case is set to `true` but Match
Exact Word is set to `false`, for the case when a Rename Files in Folder operation
is being performed.

<a name='M-MFR-Objects-Replacers-MatchCaseOnlyFileNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-MatchCaseOnlyFileNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseOnlyFileNameStringReplacer](#T-MFR-Objects-Replacers-MatchCaseOnlyFileNameStringReplacer 'MFR.Replacers.MatchCaseOnlyFileNameStringReplacer').

<a name='P-MFR-Objects-Replacers-MatchCaseOnlyFileNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-MatchCaseOnlyFileNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-MatchCaseOnlyFileNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-MatchCaseOnlyFolderNameStringReplacer'></a>
## MatchCaseOnlyFolderNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces text in strings when Match Case is set to `true` but Match Exact Word is set to `false`
, for the Rename Sub Folders operation type.

<a name='M-MFR-Objects-Replacers-MatchCaseOnlyFolderNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-MatchCaseOnlyFolderNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [MatchCaseOnlyFolderNameStringReplacer](#T-MFR-Objects-Replacers-MatchCaseOnlyFolderNameStringReplacer 'MFR.Replacers.MatchCaseOnlyFolderNameStringReplacer').

<a name='P-MFR-Objects-Replacers-MatchCaseOnlyFolderNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the [TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration') values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-MatchCaseOnlyFolderNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-MatchCaseOnlyFolderNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-MatchCaseOnlyTextInFilesStringReplacer'></a>
## MatchCaseOnlyTextInFilesStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces text in strings when Match Case is set to
`true`
but Match Exact Word is set to `false`
, for the Replace Text in Files operation type.

<a name='M-MFR-Objects-Replacers-MatchCaseOnlyTextInFilesStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-MatchCaseOnlyTextInFilesStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchCaseOnlyTextInFilesStringReplacer](#T-MFR-Objects-Replacers-MatchCaseOnlyTextInFilesStringReplacer 'MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer')
.

<a name='P-MFR-Objects-Replacers-MatchCaseOnlyTextInFilesStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-MatchCaseOnlyTextInFilesStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-MatchCaseOnlyTextInFilesStringReplacer-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-MatchExactWordOnlyFileNameStringReplacer'></a>
## MatchExactWordOnlyFileNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where Match Exact Word is enabled but
Match Case is not, for the Rename Files in Folder operation type.

<a name='M-MFR-Objects-Replacers-MatchExactWordOnlyFileNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-MatchExactWordOnlyFileNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchExactWordOnlyFileNameStringReplacer](#T-MFR-Objects-Replacers-MatchExactWordOnlyFileNameStringReplacer 'MFR.Replacers.MatchExactWordOnlyFileNameStringReplacer')
.

<a name='P-MFR-Objects-Replacers-MatchExactWordOnlyFileNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-MatchExactWordOnlyFileNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-MatchExactWordOnlyFileNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-MatchExactWordOnlyFolderNameStringReplacer'></a>
## MatchExactWordOnlyFolderNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where Match Exact Word is set to
`true`
but Match Case is set to `false`, for
the Rename Sub Folders operation type.

<a name='M-MFR-Objects-Replacers-MatchExactWordOnlyFolderNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-MatchExactWordOnlyFolderNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchExactWordOnlyFolderNameStringReplacer](#T-MFR-Objects-Replacers-MatchExactWordOnlyFolderNameStringReplacer 'MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer')
.

<a name='P-MFR-Objects-Replacers-MatchExactWordOnlyFolderNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-MatchExactWordOnlyFolderNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-MatchExactWordOnlyFolderNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-MatchExactWordOnlyTextInFilesStringReplacer'></a>
## MatchExactWordOnlyTextInFilesStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where Match Exact Word is set to
`true`
but Match Case is set to `false`, for
the Replace Text in Files operation type.

<a name='M-MFR-Objects-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MatchExactWordOnlyTextInFilesStringReplacer](#T-MFR-Objects-Replacers-MatchExactWordOnlyTextInFilesStringReplacer 'MFR.Replacers.MatchExactWordOnlyTextInFilesStringReplacer')
.

<a name='P-MFR-Objects-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-MatchExactWordOnlyTextInFilesStringReplacer-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer'></a>
## NeitherMatchCaseNorExactWordFileNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where neither Match Case nor Match
Exact Word is set to `true`, for the Rename Files in
Folder operation type.

<a name='M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[NeitherMatchCaseNorExactWordFileNameStringReplacer](#T-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer 'MFR.Replacers.NeitherMatchCaseNorExactWordFileNameStringReplacer')
.

<a name='P-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFileNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer'></a>
## NeitherMatchCaseNorExactWordFolderNameStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where neither Match Case nor Match
Exact Word is set to `true`, for the Rename Sub Folders
operation type.

<a name='M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [NeitherMatchCaseNorExactWordFolderNameStringReplacer](#T-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer 'MFR.Replacers.NeitherMatchCaseNorExactWordFolderNameStringReplacer') .

<a name='P-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the [TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration') values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordFolderNameStringReplacer-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer'></a>
## NeitherMatchCaseNorExactWordTextInFilesStringReplacer `type`

##### Namespace

MFR.Replacers

##### Summary

Replaces strings only for the case where neither Match Case nor Match
Exact Word is set to `true`, for the Rename Sub Folders operation type.

<a name='M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[NeitherMatchCaseNorExactWordTextInFilesStringReplacer](#T-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer 'MFR.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer')
.

<a name='P-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-NeitherMatchCaseNorExactWordTextInFilesStringReplacer-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-RenameFilesInFolderStringReplacerBase'></a>
## RenameFilesInFolderStringReplacerBase `type`

##### Namespace

MFR.Replacers

##### Summary

Defines the methods, properties, and events that all String Replacer
objects for the Rename Files in Folder operation type have in common.

<a name='P-MFR-Objects-Replacers-RenameFilesInFolderStringReplacerBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Objects-Replacers-RenameFilesInFolderStringReplacerBase-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-RenameFilesInFolderStringReplacerBase-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-RenameSubFoldersStringReplacerBase'></a>
## RenameSubFoldersStringReplacerBase `type`

##### Namespace

MFR.Replacers

##### Summary

Defines the methods, properties, and events that all String Replacer
objects for the Rename Files in Folder operation type have in common.

<a name='P-MFR-Objects-Replacers-RenameSubFoldersStringReplacerBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Objects-Replacers-RenameSubFoldersStringReplacerBase-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-RenameSubFoldersStringReplacerBase-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-ReplaceTextInfilesStringReplacerBase'></a>
## ReplaceTextInfilesStringReplacerBase `type`

##### Namespace

MFR.Replacers

##### Summary

Defines the methods, properties, and events that all String Replacer
objects for the Rename Files in Folder operation type have in common.

<a name='P-MFR-Objects-Replacers-ReplaceTextInfilesStringReplacerBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Objects-Replacers-ReplaceTextInfilesStringReplacerBase-TextMatchingConfiguration'></a>
### TextMatchingConfiguration `property`

##### Summary

Gets one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-ReplaceTextInfilesStringReplacerBase-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Objects-Replacers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Replacers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Replacers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Replacers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
