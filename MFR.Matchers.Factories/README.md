<a name='assembly'></a>
# MFR.Objects.Matchers.Factories

## Contents

- [GetStringMatcher](#T-MFR-Objects-Matchers-Factories-GetStringMatcher 'MFR.Objects.Matchers.Factories.GetStringMatcher')
  - [For(type)](#M-MFR-Objects-Matchers-Factories-GetStringMatcher-For-MFR-Objects-Operations-Constants-OperationType- 'MFR.Objects.Matchers.Factories.GetStringMatcher.For(MFR.Objects.Operations.Constants.OperationType)')
- [RenameFilesInFolderStringMatcherFactory](#T-MFR-Objects-Matchers-Factories-RenameFilesInFolderStringMatcherFactory 'MFR.Objects.Matchers.Factories.RenameFilesInFolderStringMatcherFactory')
  - [#ctor()](#M-MFR-Objects-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-#ctor 'MFR.Objects.Matchers.Factories.RenameFilesInFolderStringMatcherFactory.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-Instance 'MFR.Objects.Matchers.Factories.RenameFilesInFolderStringMatcherFactory.Instance')
  - [OperationType](#P-MFR-Objects-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-OperationType 'MFR.Objects.Matchers.Factories.RenameFilesInFolderStringMatcherFactory.OperationType')
  - [#cctor()](#M-MFR-Objects-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-#cctor 'MFR.Objects.Matchers.Factories.RenameFilesInFolderStringMatcherFactory.#cctor')
  - [AndTextMatchingConfiguration(matchingConfig)](#M-MFR-Objects-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration- 'MFR.Objects.Matchers.Factories.RenameFilesInFolderStringMatcherFactory.AndTextMatchingConfiguration(MFR.Objects.Configuration.Constants.TextMatchingConfiguration)')
- [RenameSubFoldersStringMatcherFactory](#T-MFR-Objects-Matchers-Factories-RenameSubFoldersStringMatcherFactory 'MFR.Objects.Matchers.Factories.RenameSubFoldersStringMatcherFactory')
  - [#ctor()](#M-MFR-Objects-Matchers-Factories-RenameSubFoldersStringMatcherFactory-#ctor 'MFR.Objects.Matchers.Factories.RenameSubFoldersStringMatcherFactory.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-Factories-RenameSubFoldersStringMatcherFactory-Instance 'MFR.Objects.Matchers.Factories.RenameSubFoldersStringMatcherFactory.Instance')
  - [OperationType](#P-MFR-Objects-Matchers-Factories-RenameSubFoldersStringMatcherFactory-OperationType 'MFR.Objects.Matchers.Factories.RenameSubFoldersStringMatcherFactory.OperationType')
  - [#cctor()](#M-MFR-Objects-Matchers-Factories-RenameSubFoldersStringMatcherFactory-#cctor 'MFR.Objects.Matchers.Factories.RenameSubFoldersStringMatcherFactory.#cctor')
  - [AndTextMatchingConfiguration(matchingConfig)](#M-MFR-Objects-Matchers-Factories-RenameSubFoldersStringMatcherFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration- 'MFR.Objects.Matchers.Factories.RenameSubFoldersStringMatcherFactory.AndTextMatchingConfiguration(MFR.Objects.Configuration.Constants.TextMatchingConfiguration)')
- [ReplaceTextInFilesStringMatcherFactory](#T-MFR-Objects-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory 'MFR.Objects.Matchers.Factories.ReplaceTextInFilesStringMatcherFactory')
  - [#ctor()](#M-MFR-Objects-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-#ctor 'MFR.Objects.Matchers.Factories.ReplaceTextInFilesStringMatcherFactory.#ctor')
  - [Instance](#P-MFR-Objects-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-Instance 'MFR.Objects.Matchers.Factories.ReplaceTextInFilesStringMatcherFactory.Instance')
  - [OperationType](#P-MFR-Objects-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-OperationType 'MFR.Objects.Matchers.Factories.ReplaceTextInFilesStringMatcherFactory.OperationType')
  - [#cctor()](#M-MFR-Objects-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-#cctor 'MFR.Objects.Matchers.Factories.ReplaceTextInFilesStringMatcherFactory.#cctor')
  - [AndTextMatchingConfiguration(matchingConfig)](#M-MFR-Objects-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration- 'MFR.Objects.Matchers.Factories.ReplaceTextInFilesStringMatcherFactory.AndTextMatchingConfiguration(MFR.Objects.Configuration.Constants.TextMatchingConfiguration)')
- [Resources](#T-MFR-Objects-Matchers-Factories-Properties-Resources 'MFR.Objects.Matchers.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Matchers-Factories-Properties-Resources-Culture 'MFR.Objects.Matchers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Matchers-Factories-Properties-Resources-ResourceManager 'MFR.Objects.Matchers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Matchers-Factories-GetStringMatcher'></a>
## GetStringMatcher `type`

##### Namespace

MFR.Objects.Matchers.Factories

##### Summary

Creates instances of objects that implement the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.Objects.IStringMatcher')
interface.

<a name='M-MFR-Objects-Matchers-Factories-GetStringMatcher-For-MFR-Objects-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates a new instance of an object that implements the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.Objects.IStringMatcher')
interface and
returns a reference to it, for the given
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
value.

##### Returns

Reference to an instance of an object that implements the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.Objects.IStringMatcher')
interface that corresponds to the specified type of operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Objects.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Objects.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed. |

<a name='T-MFR-Objects-Matchers-Factories-RenameFilesInFolderStringMatcherFactory'></a>
## RenameFilesInFolderStringMatcherFactory `type`

##### Namespace

MFR.Objects.Matchers.Factories

##### Summary

Factory object that creates string matchers, specific to the Rename
Files in Folder type of operation, for the various combinations of Match
Case and Match Exact Word.

<a name='M-MFR-Objects-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[RenameFilesInFolderStringMatcherFactory](#T-MFR-Objects-Matchers-Factories-RenameFilesInFolderStringMatcherFactory 'MFR.Objects.Matchers.Factories.RenameFilesInFolderStringMatcherFactory')
.

<a name='P-MFR-Objects-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-'></a>
### AndTextMatchingConfiguration(matchingConfig) `method`

##### Summary

Creates a new instance of an object that implements the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.Objects.IStringMatcher')
interface and
returns a reference to it for the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value
that is specified by the `matchingConfig` parameter.

##### Returns

Reference to an instance of an object that implements the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.Objects.IStringMatcher')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| matchingConfig | [MFR.Objects.Configuration.Constants.TextMatchingConfiguration](#T-MFR-Objects-Configuration-Constants-TextMatchingConfiguration 'MFR.Objects.Configuration.Constants.TextMatchingConfiguration') | (Required.) One of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values
that specifies which type of matching is being done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | Thrown if the value passed in the `matchingConfig`
is not one of the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
values. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if a string matcher object is not defined for the Rename
Files in Folder operation type that supports the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value
passed in the `matchingConfig` parameter. |

<a name='T-MFR-Objects-Matchers-Factories-RenameSubFoldersStringMatcherFactory'></a>
## RenameSubFoldersStringMatcherFactory `type`

##### Namespace

MFR.Objects.Matchers.Factories

##### Summary

Factory object that creates string matchers, specific to the Rename
Sub Folders type of operation, for the various combinations of
Match Case and Match Exact Word.

<a name='M-MFR-Objects-Matchers-Factories-RenameSubFoldersStringMatcherFactory-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-Factories-RenameSubFoldersStringMatcherFactory-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[RenameSubFoldersStringMatcherFactory](#T-MFR-Objects-Matchers-Factories-RenameSubFoldersStringMatcherFactory 'MFR.Objects.Matchers.Factories.RenameSubFoldersStringMatcherFactory')
.

<a name='P-MFR-Objects-Matchers-Factories-RenameSubFoldersStringMatcherFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-Factories-RenameSubFoldersStringMatcherFactory-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-RenameSubFoldersStringMatcherFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-'></a>
### AndTextMatchingConfiguration(matchingConfig) `method`

##### Summary

Creates a new instance of an object that implements the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.Objects.IStringMatcher')
interface and
returns a reference to it for the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value that
is specified by the `matchingConfig` parameter.

##### Returns

Reference to an instance of an object that implements the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.Objects.IStringMatcher')
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
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if a string matcher object is not defined for the Rename
Files in Folder operation type that supports the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value
passed in the `matchingConfig` parameter. |

<a name='T-MFR-Objects-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory'></a>
## ReplaceTextInFilesStringMatcherFactory `type`

##### Namespace

MFR.Objects.Matchers.Factories

##### Summary

Factory object that creates string matchers, specific to the Rename
Sub Folders type of operation, for the various combinations of
Match Case and Match Exact Word.

<a name='M-MFR-Objects-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[ReplaceTextInFilesStringMatcherFactory](#T-MFR-Objects-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory 'MFR.Objects.Matchers.Factories.ReplaceTextInFilesStringMatcherFactory')
.

<a name='P-MFR-Objects-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-AndTextMatchingConfiguration-MFR-Objects-Configuration-Constants-TextMatchingConfiguration-'></a>
### AndTextMatchingConfiguration(matchingConfig) `method`

##### Summary

Creates a new instance of an object that implements the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.Objects.IStringMatcher')
interface and
returns a reference to it for the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value that
is specified by the `matchingConfig` parameter.

##### Returns

Reference to an instance of an object that implements the
[IStringMatcher](#T-MFR-Objects-IStringMatcher 'MFR.Objects.IStringMatcher')
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
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if a string matcher object is not defined for the Rename
Files in Folder operation type that supports the
[TextMatchingConfiguration](#T-MFR-Objects-TextMatchingConfiguration 'MFR.Objects.TextMatchingConfiguration')
value
passed in the `matchingConfig` parameter. |

<a name='T-MFR-Objects-Matchers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Matchers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Matchers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Matchers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.