<a name='assembly'></a>
# MFR.Objects.Replacers.Factories

## Contents

- [GetStringReplacer](#T-MFR-Objects-Replacers-Factories-GetStringReplacer 'MFR.Objects.Replacers.Factories.GetStringReplacer')
  - [For(type)](#M-MFR-Objects-Replacers-Factories-GetStringReplacer-For-MFR-Objects-Operations-Constants-OperationType- 'MFR.Objects.Replacers.Factories.GetStringReplacer.For(MFR.Objects.Operations.Constants.OperationType)')
- [RenameFilesInFolderStringReplacerFactory](#T-MFR-Objects-Replacers-Factories-RenameFilesInFolderStringReplacerFactory 'MFR.Objects.Replacers.Factories.RenameFilesInFolderStringReplacerFactory')
  - [#ctor()](#M-MFR-Objects-Replacers-Factories-RenameFilesInFolderStringReplacerFactory-#ctor 'MFR.Objects.Replacers.Factories.RenameFilesInFolderStringReplacerFactory.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-Factories-RenameFilesInFolderStringReplacerFactory-Instance 'MFR.Objects.Replacers.Factories.RenameFilesInFolderStringReplacerFactory.Instance')
  - [OperationType](#P-MFR-Objects-Replacers-Factories-RenameFilesInFolderStringReplacerFactory-OperationType 'MFR.Objects.Replacers.Factories.RenameFilesInFolderStringReplacerFactory.OperationType')
  - [#cctor()](#M-MFR-Objects-Replacers-Factories-RenameFilesInFolderStringReplacerFactory-#cctor 'MFR.Objects.Replacers.Factories.RenameFilesInFolderStringReplacerFactory.#cctor')
  - [AndTextMatchingConfiguration(matchingConfig)](#M-MFR-Objects-Replacers-Factories-RenameFilesInFolderStringReplacerFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration- 'MFR.Objects.Replacers.Factories.RenameFilesInFolderStringReplacerFactory.AndTextMatchingConfiguration(MFR.Objects.Configuration.Constants.TextMatchingConfiguration)')
- [RenameSubFoldersStringReplacerFactory](#T-MFR-Objects-Replacers-Factories-RenameSubFoldersStringReplacerFactory 'MFR.Objects.Replacers.Factories.RenameSubFoldersStringReplacerFactory')
  - [#ctor()](#M-MFR-Objects-Replacers-Factories-RenameSubFoldersStringReplacerFactory-#ctor 'MFR.Objects.Replacers.Factories.RenameSubFoldersStringReplacerFactory.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-Factories-RenameSubFoldersStringReplacerFactory-Instance 'MFR.Objects.Replacers.Factories.RenameSubFoldersStringReplacerFactory.Instance')
  - [OperationType](#P-MFR-Objects-Replacers-Factories-RenameSubFoldersStringReplacerFactory-OperationType 'MFR.Objects.Replacers.Factories.RenameSubFoldersStringReplacerFactory.OperationType')
  - [#cctor()](#M-MFR-Objects-Replacers-Factories-RenameSubFoldersStringReplacerFactory-#cctor 'MFR.Objects.Replacers.Factories.RenameSubFoldersStringReplacerFactory.#cctor')
  - [AndTextMatchingConfiguration(matchingConfig)](#M-MFR-Objects-Replacers-Factories-RenameSubFoldersStringReplacerFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration- 'MFR.Objects.Replacers.Factories.RenameSubFoldersStringReplacerFactory.AndTextMatchingConfiguration(MFR.Objects.Configuration.Constants.TextMatchingConfiguration)')
- [ReplaceTextInFilesStringReplacerFactory](#T-MFR-Objects-Replacers-Factories-ReplaceTextInFilesStringReplacerFactory 'MFR.Objects.Replacers.Factories.ReplaceTextInFilesStringReplacerFactory')
  - [#ctor()](#M-MFR-Objects-Replacers-Factories-ReplaceTextInFilesStringReplacerFactory-#ctor 'MFR.Objects.Replacers.Factories.ReplaceTextInFilesStringReplacerFactory.#ctor')
  - [Instance](#P-MFR-Objects-Replacers-Factories-ReplaceTextInFilesStringReplacerFactory-Instance 'MFR.Objects.Replacers.Factories.ReplaceTextInFilesStringReplacerFactory.Instance')
  - [OperationType](#P-MFR-Objects-Replacers-Factories-ReplaceTextInFilesStringReplacerFactory-OperationType 'MFR.Objects.Replacers.Factories.ReplaceTextInFilesStringReplacerFactory.OperationType')
  - [#cctor()](#M-MFR-Objects-Replacers-Factories-ReplaceTextInFilesStringReplacerFactory-#cctor 'MFR.Objects.Replacers.Factories.ReplaceTextInFilesStringReplacerFactory.#cctor')
  - [AndTextMatchingConfiguration(matchingConfig)](#M-MFR-Objects-Replacers-Factories-ReplaceTextInFilesStringReplacerFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration- 'MFR.Objects.Replacers.Factories.ReplaceTextInFilesStringReplacerFactory.AndTextMatchingConfiguration(MFR.Objects.Configuration.Constants.TextMatchingConfiguration)')
- [Resources](#T-MFR-Objects-Replacers-Factories-Properties-Resources 'MFR.Objects.Replacers.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Replacers-Factories-Properties-Resources-Culture 'MFR.Objects.Replacers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Replacers-Factories-Properties-Resources-ResourceManager 'MFR.Objects.Replacers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Replacers-Factories-GetStringReplacer'></a>
## GetStringReplacer `type`

##### Namespace

MFR.Objects.Replacers.Factories

##### Summary

Creates instances of objects that implement the
[IStringReplacer](#T-MFR-Objects-IStringReplacer 'MFR.Objects.IStringReplacer')
interface.

<a name='M-MFR-Objects-Replacers-Factories-GetStringReplacer-For-MFR-Objects-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates a new instance of an object that implements the
[IStringReplacer](#T-MFR-Objects-IStringReplacer 'MFR.Objects.IStringReplacer')
interface and
returns a reference to it, for the given
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
value.

##### Returns

Reference to an instance of an object that implements the
[IStringReplacer](#T-MFR-Objects-IStringReplacer 'MFR.Objects.IStringReplacer')
interface that corresponds to the specified type of operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Objects.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed. |

<a name='T-MFR-Objects-Replacers-Factories-RenameFilesInFolderStringReplacerFactory'></a>
## RenameFilesInFolderStringReplacerFactory `type`

##### Namespace

MFR.Objects.Replacers.Factories

##### Summary

Factory object that creates string replacers, specific to the Rename
Files in Folder type of operation, for the various combinations of
Match Case and Match Exact Word.

<a name='M-MFR-Objects-Replacers-Factories-RenameFilesInFolderStringReplacerFactory-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-Factories-RenameFilesInFolderStringReplacerFactory-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[RenameFilesInFolderStringReplacerFactory](#T-MFR-Objects-Replacers-Factories-RenameFilesInFolderStringReplacerFactory 'MFR.Objects.Replacers.Factories.RenameFilesInFolderStringReplacerFactory')
.

<a name='P-MFR-Objects-Replacers-Factories-RenameFilesInFolderStringReplacerFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-Factories-RenameFilesInFolderStringReplacerFactory-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-RenameFilesInFolderStringReplacerFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-'></a>
### AndTextMatchingConfiguration(matchingConfig) `method`

##### Summary

Creates a new instance of an object that implements the
[IStringReplacer](#T-MFR-Objects-IStringReplacer 'MFR.Objects.IStringReplacer')
interface and
returns a reference to it for the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value that
is specified by the `matchingConfig` parameter.

##### Returns

Reference to an instance of an object that implements the
[IStringReplacer](#T-MFR-Objects-IStringReplacer 'MFR.Objects.IStringReplacer')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| matchingConfig | [MFR.Objects.Configuration.Constants.TextMatchingConfiguration](#T-MFR-Objects-Configuration-Constants-TextMatchingConfiguration 'MFR.Objects.Configuration.Constants.TextMatchingConfiguration') | (Required.) One of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values that
specifies which type of matching is being done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | Thrown if the value passed in the `matchingConfig`
is not one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if a string replacer object is not defined for the Rename
Files in Folder operation type that supports the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value
passed in the `matchingConfig` parameter. |

<a name='T-MFR-Objects-Replacers-Factories-RenameSubFoldersStringReplacerFactory'></a>
## RenameSubFoldersStringReplacerFactory `type`

##### Namespace

MFR.Objects.Replacers.Factories

##### Summary

Factory object that creates string replacers, specific to the Rename
Sub Folders type of operation, for the various combinations of
Match Case and Match Exact Word.

<a name='M-MFR-Objects-Replacers-Factories-RenameSubFoldersStringReplacerFactory-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-Factories-RenameSubFoldersStringReplacerFactory-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [RenameSubFoldersStringReplacerFactory](#T-MFR-Objects-Replacers-Factories-RenameSubFoldersStringReplacerFactory 'MFR.Objects.Replacers.Factories.RenameSubFoldersStringReplacerFactory') .

<a name='P-MFR-Objects-Replacers-Factories-RenameSubFoldersStringReplacerFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType') values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-Factories-RenameSubFoldersStringReplacerFactory-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-RenameSubFoldersStringReplacerFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-'></a>
### AndTextMatchingConfiguration(matchingConfig) `method`

##### Summary

Creates a new instance of an object that implements the [IStringReplacer](#T-MFR-Objects-IStringReplacer 'MFR.Objects.IStringReplacer') interface and
returns a reference to it for the [TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration') value that
is specified by the `matchingConfig` parameter.

##### Returns

Reference to an instance of an object that implements the [IStringReplacer](#T-MFR-Objects-IStringReplacer 'MFR.Objects.IStringReplacer') interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| matchingConfig | [MFR.Objects.Configuration.Constants.TextMatchingConfiguration](#T-MFR-Objects-Configuration-Constants-TextMatchingConfiguration 'MFR.Objects.Configuration.Constants.TextMatchingConfiguration') | (Required.) One of the [TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration') values that
specifies which type of matching is being done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | Thrown if the value passed in the `matchingConfig`
is not one of the [TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration') values. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if a string replacer object is not defined for the Rename
Files in Folder operation type that supports the [TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration') value
passed in the `matchingConfig` parameter. |

<a name='T-MFR-Objects-Replacers-Factories-ReplaceTextInFilesStringReplacerFactory'></a>
## ReplaceTextInFilesStringReplacerFactory `type`

##### Namespace

MFR.Objects.Replacers.Factories

##### Summary

Factory object that creates string replacers, specific to the Replace
Text in Files type of operation, for the various combinations of Match
Case and Match Exact Word.

<a name='M-MFR-Objects-Replacers-Factories-ReplaceTextInFilesStringReplacerFactory-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Replacers-Factories-ReplaceTextInFilesStringReplacerFactory-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[ReplaceTextInFilesStringReplacerFactory](#T-MFR-Objects-Replacers-Factories-ReplaceTextInFilesStringReplacerFactory 'MFR.Objects.Replacers.Factories.ReplaceTextInFilesStringReplacerFactory')
.

<a name='P-MFR-Objects-Replacers-Factories-ReplaceTextInFilesStringReplacerFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Replacers-Factories-ReplaceTextInFilesStringReplacerFactory-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Replacers-Factories-ReplaceTextInFilesStringReplacerFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-'></a>
### AndTextMatchingConfiguration(matchingConfig) `method`

##### Summary

Creates a new instance of an object that implements the
[IStringReplacer](#T-MFR-Objects-IStringReplacer 'MFR.Objects.IStringReplacer')
interface and
returns a reference to it for the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value that
is specified by the `matchingConfig` parameter.

##### Returns

Reference to an instance of an object that implements the
[IStringReplacer](#T-MFR-Objects-IStringReplacer 'MFR.Objects.IStringReplacer')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| matchingConfig | [MFR.Objects.Configuration.Constants.TextMatchingConfiguration](#T-MFR-Objects-Configuration-Constants-TextMatchingConfiguration 'MFR.Objects.Configuration.Constants.TextMatchingConfiguration') | (Required.) One of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values that
specifies which type of matching is being done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | Thrown if the value passed in the `matchingConfig`
is not one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if a string replacer object is not defined for the Replace
Text in Files operation type that supports the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value
passed in the `matchingConfig` parameter. |

<a name='T-MFR-Objects-Replacers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Replacers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Replacers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Replacers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
