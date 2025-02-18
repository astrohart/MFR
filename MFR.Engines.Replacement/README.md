<a name='assembly'></a>
# MFR.Engines.Replacement

## Contents

- [FileNameReplacementEngine](#T-MFR-Engines-Replacement-FileNameReplacementEngine 'MFR.Engines.Replacement.FileNameReplacementEngine')
  - [#ctor()](#M-MFR-Engines-Replacement-FileNameReplacementEngine-#ctor 'MFR.Engines.Replacement.FileNameReplacementEngine.#ctor')
  - [#ctor(config)](#M-MFR-Engines-Replacement-FileNameReplacementEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Engines.Replacement.FileNameReplacementEngine.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [OperationType](#P-MFR-Engines-Replacement-FileNameReplacementEngine-OperationType 'MFR.Engines.Replacement.FileNameReplacementEngine.OperationType')
  - [Replace(value,pattern,dest)](#M-MFR-Engines-Replacement-FileNameReplacementEngine-Replace-System-String,System-String,System-String- 'MFR.Engines.Replacement.FileNameReplacementEngine.Replace(System.String,System.String,System.String)')
- [FolderNameReplacementEngine](#T-MFR-Engines-Replacement-FolderNameReplacementEngine 'MFR.Engines.Replacement.FolderNameReplacementEngine')
  - [#ctor()](#M-MFR-Engines-Replacement-FolderNameReplacementEngine-#ctor 'MFR.Engines.Replacement.FolderNameReplacementEngine.#ctor')
  - [#ctor(config)](#M-MFR-Engines-Replacement-FolderNameReplacementEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Engines.Replacement.FolderNameReplacementEngine.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [OperationType](#P-MFR-Engines-Replacement-FolderNameReplacementEngine-OperationType 'MFR.Engines.Replacement.FolderNameReplacementEngine.OperationType')
  - [Replace(value,pattern,dest)](#M-MFR-Engines-Replacement-FolderNameReplacementEngine-Replace-System-String,System-String,System-String- 'MFR.Engines.Replacement.FolderNameReplacementEngine.Replace(System.String,System.String,System.String)')
- [Resources](#T-MFR-Engines-Replacement-Properties-Resources 'MFR.Engines.Replacement.Properties.Resources')
  - [Culture](#P-MFR-Engines-Replacement-Properties-Resources-Culture 'MFR.Engines.Replacement.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Replacement-Properties-Resources-ResourceManager 'MFR.Engines.Replacement.Properties.Resources.ResourceManager')
- [SolutionFolderNameReplacementEngine](#T-MFR-Engines-Replacement-SolutionFolderNameReplacementEngine 'MFR.Engines.Replacement.SolutionFolderNameReplacementEngine')
  - [#ctor()](#M-MFR-Engines-Replacement-SolutionFolderNameReplacementEngine-#ctor 'MFR.Engines.Replacement.SolutionFolderNameReplacementEngine.#ctor')
  - [#ctor(config)](#M-MFR-Engines-Replacement-SolutionFolderNameReplacementEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Engines.Replacement.SolutionFolderNameReplacementEngine.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [OperationType](#P-MFR-Engines-Replacement-SolutionFolderNameReplacementEngine-OperationType 'MFR.Engines.Replacement.SolutionFolderNameReplacementEngine.OperationType')
- [TextInFileReplacementEngine](#T-MFR-Engines-Replacement-TextInFileReplacementEngine 'MFR.Engines.Replacement.TextInFileReplacementEngine')
  - [#ctor()](#M-MFR-Engines-Replacement-TextInFileReplacementEngine-#ctor 'MFR.Engines.Replacement.TextInFileReplacementEngine.#ctor')
  - [#ctor(config)](#M-MFR-Engines-Replacement-TextInFileReplacementEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Engines.Replacement.TextInFileReplacementEngine.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [OperationType](#P-MFR-Engines-Replacement-TextInFileReplacementEngine-OperationType 'MFR.Engines.Replacement.TextInFileReplacementEngine.OperationType')
  - [Replace(value,pattern,dest)](#M-MFR-Engines-Replacement-TextInFileReplacementEngine-Replace-System-String,System-String,System-String- 'MFR.Engines.Replacement.TextInFileReplacementEngine.Replace(System.String,System.String,System.String)')
- [TextReplacementEngineBase](#T-MFR-Engines-Replacement-TextReplacementEngineBase 'MFR.Engines.Replacement.TextReplacementEngineBase')
  - [#ctor()](#M-MFR-Engines-Replacement-TextReplacementEngineBase-#ctor 'MFR.Engines.Replacement.TextReplacementEngineBase.#ctor')
  - [#ctor(config)](#M-MFR-Engines-Replacement-TextReplacementEngineBase-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Engines.Replacement.TextReplacementEngineBase.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [ConfigProvider](#P-MFR-Engines-Replacement-TextReplacementEngineBase-ConfigProvider 'MFR.Engines.Replacement.TextReplacementEngineBase.ConfigProvider')
  - [CurrentConfig](#P-MFR-Engines-Replacement-TextReplacementEngineBase-CurrentConfig 'MFR.Engines.Replacement.TextReplacementEngineBase.CurrentConfig')
  - [OperationType](#P-MFR-Engines-Replacement-TextReplacementEngineBase-OperationType 'MFR.Engines.Replacement.TextReplacementEngineBase.OperationType')
  - [Replace(value,pattern,dest)](#M-MFR-Engines-Replacement-TextReplacementEngineBase-Replace-System-String,System-String,System-String- 'MFR.Engines.Replacement.TextReplacementEngineBase.Replace(System.String,System.String,System.String)')
  - [Replace(expression)](#M-MFR-Engines-Replacement-TextReplacementEngineBase-Replace-MFR-Expressions-Matches-Interfaces-IMatchExpression- 'MFR.Engines.Replacement.TextReplacementEngineBase.Replace(MFR.Expressions.Matches.Interfaces.IMatchExpression)')

<a name='T-MFR-Engines-Replacement-FileNameReplacementEngine'></a>
## FileNameReplacementEngine `type`

##### Namespace

MFR.Engines.Replacement

##### Summary

Replaces text in file names.

<a name='M-MFR-Engines-Replacement-FileNameReplacementEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[FileNameReplacementEngine](#T-MFR-Engines-Replacement-FileNameReplacementEngine 'MFR.Engines.Replacement.FileNameReplacementEngine')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Engines-Replacement-FileNameReplacementEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### #ctor(config) `constructor`

##### Summary

Constructs a new instance of
[TextReplacementEngineBase](#T-MFR-TextReplacementEngineBase 'MFR.TextReplacementEngineBase')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the [IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') interface that holds
settings that are specified by the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `config`,
is passed a `null` value. |

<a name='P-MFR-Engines-Replacement-FileNameReplacementEngine-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='M-MFR-Engines-Replacement-FileNameReplacementEngine-Replace-System-String,System-String,System-String-'></a>
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

<a name='T-MFR-Engines-Replacement-FolderNameReplacementEngine'></a>
## FolderNameReplacementEngine `type`

##### Namespace

MFR.Engines.Replacement

##### Summary

Contains rules to replace text in the pathnames of folders.

<a name='M-MFR-Engines-Replacement-FolderNameReplacementEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[FolderNameReplacementEngine](#T-MFR-Engines-Replacement-FolderNameReplacementEngine 'MFR.Engines.Replacement.FolderNameReplacementEngine')
and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Engines-Replacement-FolderNameReplacementEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### #ctor(config) `constructor`

##### Summary

Constructs a new instance of
[TextReplacementEngineBase](#T-MFR-TextReplacementEngineBase 'MFR.TextReplacementEngineBase')
and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an
instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface that
holds settings that are specified by the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `config`, is passed a
`null`
value. |

<a name='P-MFR-Engines-Replacement-FolderNameReplacementEngine-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Engines-Replacement-FolderNameReplacementEngine-Replace-System-String,System-String,System-String-'></a>
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
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the `value` parameter does not contain
the fully-qualified, absolute pathname to a folder. |

<a name='T-MFR-Engines-Replacement-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Replacement.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Replacement-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Replacement-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Engines-Replacement-SolutionFolderNameReplacementEngine'></a>
## SolutionFolderNameReplacementEngine `type`

##### Namespace

MFR.Engines.Replacement

##### Summary

Contains rules to replace text in the pathnames of folders.

<a name='M-MFR-Engines-Replacement-SolutionFolderNameReplacementEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[SolutionFolderNameReplacementEngine](#T-MFR-Engines-Replacement-SolutionFolderNameReplacementEngine 'MFR.Engines.Replacement.SolutionFolderNameReplacementEngine')
and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Engines-Replacement-SolutionFolderNameReplacementEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### #ctor(config) `constructor`

##### Summary

Constructs a new instance of
[TextReplacementEngineBase](#T-MFR-TextReplacementEngineBase 'MFR.TextReplacementEngineBase')
and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an
instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface that
holds settings that are specified by the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `config`, is passed a
`null`
value. |

<a name='P-MFR-Engines-Replacement-SolutionFolderNameReplacementEngine-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='T-MFR-Engines-Replacement-TextInFileReplacementEngine'></a>
## TextInFileReplacementEngine `type`

##### Namespace

MFR.Engines.Replacement

##### Summary

Replaces text in a file. Here, we represent the file's contents as
simply the source string of methods.

<a name='M-MFR-Engines-Replacement-TextInFileReplacementEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[TextInFileReplacementEngine](#T-MFR-Engines-Replacement-TextInFileReplacementEngine 'MFR.Engines.Replacement.TextInFileReplacementEngine')
and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Engines-Replacement-TextInFileReplacementEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### #ctor(config) `constructor`

##### Summary

Constructs a new instance of
[TextReplacementEngineBase](#T-MFR-TextReplacementEngineBase 'MFR.TextReplacementEngineBase')
and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an
instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface that
holds settings that are specified by the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `config`, is passed a
`null`
value. |

<a name='P-MFR-Engines-Replacement-TextInFileReplacementEngine-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Engines-Replacement-TextInFileReplacementEngine-Replace-System-String,System-String,System-String-'></a>
### Replace(value,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `value`. Returns a string

##### Returns

String containing the new data. If the `value`

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
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `pattern`, is
passed either the empty or `null` string for a value.



This makes logical sense; if the `pattern` is
blank, then we have nothing to search against!



NOTE: This parameter MAY have whitespace characters since these can
be matched inside the content of a text file, which is what we
expect to be passed for the `value` parameter. |

##### Remarks

Here, the `dest` parameter may be blank or null; if
the `value` parameter is `null` or
the empty string, then this method returns the empty string.



NOTE: The `value` parameter MAY contain whitespace.
this the case, then the text found by the
`pattern`
just gets deleted, which is okay in this instance.

<a name='T-MFR-Engines-Replacement-TextReplacementEngineBase'></a>
## TextReplacementEngineBase `type`

##### Namespace

MFR.Engines.Replacement

##### Summary

Defines the methods, properties, and events that are common to all
text-replacement engine object implementations.

<a name='M-MFR-Engines-Replacement-TextReplacementEngineBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[TextReplacementEngineBase](#T-MFR-Engines-Replacement-TextReplacementEngineBase 'MFR.Engines.Replacement.TextReplacementEngineBase')
and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Engines-Replacement-TextReplacementEngineBase-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### #ctor(config) `constructor`

##### Summary

Constructs a new instance of
[TextReplacementEngineBase](#T-MFR-TextReplacementEngineBase 'MFR.TextReplacementEngineBase')
and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an
instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface that
holds settings that are specified by the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `config`, is passed a
`null`
value. |

<a name='P-MFR-Engines-Replacement-TextReplacementEngineBase-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

##### Remarks

This object allows access to the user config and the
actions
associated with it.

<a name='P-MFR-Engines-Replacement-TextReplacementEngineBase-CurrentConfig'></a>
### CurrentConfig `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

<a name='P-MFR-Engines-Replacement-TextReplacementEngineBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Engines-Replacement-TextReplacementEngineBase-Replace-System-String,System-String,System-String-'></a>
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
or `pattern`, are passed blank or
`null` string for values. |

<a name='M-MFR-Engines-Replacement-TextReplacementEngineBase-Replace-MFR-Expressions-Matches-Interfaces-IMatchExpression-'></a>
### Replace(expression) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `expression`. Returns a string
containing the results.

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [MFR.Expressions.Matches.Interfaces.IMatchExpression](#T-MFR-Expressions-Matches-Interfaces-IMatchExpression 'MFR.Expressions.Matches.Interfaces.IMatchExpression') | (Required.) A
[MatchExpression](#T-MFR-MatchExpression 'MFR.MatchExpression')
that contains the
replacement data. |
