<a name='assembly'></a>
# MFR.Engines.Matching

## Contents

- [FileNameMatchingEngine](#T-MFR-Engines-Matching-FileNameMatchingEngine 'MFR.Engines.Matching.FileNameMatchingEngine')
  - [#ctor()](#M-MFR-Engines-Matching-FileNameMatchingEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Engines.Matching.FileNameMatchingEngine.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [#ctor()](#M-MFR-Engines-Matching-FileNameMatchingEngine-#ctor 'MFR.Engines.Matching.FileNameMatchingEngine.#ctor')
  - [OperationType](#P-MFR-Engines-Matching-FileNameMatchingEngine-OperationType 'MFR.Engines.Matching.FileNameMatchingEngine.OperationType')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Engines-Matching-FileNameMatchingEngine-IsMatch-System-String,System-String,System-String- 'MFR.Engines.Matching.FileNameMatchingEngine.IsMatch(System.String,System.String,System.String)')
- [FolderNameMatchingEngine](#T-MFR-Engines-Matching-FolderNameMatchingEngine 'MFR.Engines.Matching.FolderNameMatchingEngine')
  - [#ctor()](#M-MFR-Engines-Matching-FolderNameMatchingEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Engines.Matching.FolderNameMatchingEngine.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [#ctor()](#M-MFR-Engines-Matching-FolderNameMatchingEngine-#ctor 'MFR.Engines.Matching.FolderNameMatchingEngine.#ctor')
  - [OperationType](#P-MFR-Engines-Matching-FolderNameMatchingEngine-OperationType 'MFR.Engines.Matching.FolderNameMatchingEngine.OperationType')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Engines-Matching-FolderNameMatchingEngine-IsMatch-System-String,System-String,System-String- 'MFR.Engines.Matching.FolderNameMatchingEngine.IsMatch(System.String,System.String,System.String)')
- [Resources](#T-MFR-Engines-Matching-Properties-Resources 'MFR.Engines.Matching.Properties.Resources')
  - [Culture](#P-MFR-Engines-Matching-Properties-Resources-Culture 'MFR.Engines.Matching.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Matching-Properties-Resources-ResourceManager 'MFR.Engines.Matching.Properties.Resources.ResourceManager')
- [SolutionFolderNameMatchingEngine](#T-MFR-Engines-Matching-SolutionFolderNameMatchingEngine 'MFR.Engines.Matching.SolutionFolderNameMatchingEngine')
  - [#ctor()](#M-MFR-Engines-Matching-SolutionFolderNameMatchingEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Engines.Matching.SolutionFolderNameMatchingEngine.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [#ctor()](#M-MFR-Engines-Matching-SolutionFolderNameMatchingEngine-#ctor 'MFR.Engines.Matching.SolutionFolderNameMatchingEngine.#ctor')
  - [OperationType](#P-MFR-Engines-Matching-SolutionFolderNameMatchingEngine-OperationType 'MFR.Engines.Matching.SolutionFolderNameMatchingEngine.OperationType')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Engines-Matching-SolutionFolderNameMatchingEngine-IsMatch-System-String,System-String,System-String- 'MFR.Engines.Matching.SolutionFolderNameMatchingEngine.IsMatch(System.String,System.String,System.String)')
- [TextExpressionMatchingEngineBase](#T-MFR-Engines-Matching-TextExpressionMatchingEngineBase 'MFR.Engines.Matching.TextExpressionMatchingEngineBase')
  - [#ctor()](#M-MFR-Engines-Matching-TextExpressionMatchingEngineBase-#ctor 'MFR.Engines.Matching.TextExpressionMatchingEngineBase.#ctor')
  - [#ctor(config)](#M-MFR-Engines-Matching-TextExpressionMatchingEngineBase-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Engines.Matching.TextExpressionMatchingEngineBase.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [ConfigProvider](#P-MFR-Engines-Matching-TextExpressionMatchingEngineBase-ConfigProvider 'MFR.Engines.Matching.TextExpressionMatchingEngineBase.ConfigProvider')
  - [CurrentConfiguration](#P-MFR-Engines-Matching-TextExpressionMatchingEngineBase-CurrentConfiguration 'MFR.Engines.Matching.TextExpressionMatchingEngineBase.CurrentConfiguration')
  - [OperationType](#P-MFR-Engines-Matching-TextExpressionMatchingEngineBase-OperationType 'MFR.Engines.Matching.TextExpressionMatchingEngineBase.OperationType')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Engines-Matching-TextExpressionMatchingEngineBase-IsMatch-System-String,System-String,System-String- 'MFR.Engines.Matching.TextExpressionMatchingEngineBase.IsMatch(System.String,System.String,System.String)')
  - [IsMatch(expression)](#M-MFR-Engines-Matching-TextExpressionMatchingEngineBase-IsMatch-MFR-Expressions-Matches-Interfaces-IMatchExpression- 'MFR.Engines.Matching.TextExpressionMatchingEngineBase.IsMatch(MFR.Expressions.Matches.Interfaces.IMatchExpression)')
- [TextInFilesMatchingEngine](#T-MFR-Engines-Matching-TextInFilesMatchingEngine 'MFR.Engines.Matching.TextInFilesMatchingEngine')
  - [#ctor()](#M-MFR-Engines-Matching-TextInFilesMatchingEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Engines.Matching.TextInFilesMatchingEngine.#ctor(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
  - [#ctor()](#M-MFR-Engines-Matching-TextInFilesMatchingEngine-#ctor 'MFR.Engines.Matching.TextInFilesMatchingEngine.#ctor')
  - [OperationType](#P-MFR-Engines-Matching-TextInFilesMatchingEngine-OperationType 'MFR.Engines.Matching.TextInFilesMatchingEngine.OperationType')
  - [IsMatch(value,findWhat,replaceWith)](#M-MFR-Engines-Matching-TextInFilesMatchingEngine-IsMatch-System-String,System-String,System-String- 'MFR.Engines.Matching.TextInFilesMatchingEngine.IsMatch(System.String,System.String,System.String)')

<a name='T-MFR-Engines-Matching-FileNameMatchingEngine'></a>
## FileNameMatchingEngine `type`

##### Namespace

MFR.Engines.Matching

##### Summary

Applies criteria to match file names against textual expressions.

<a name='M-MFR-Engines-Matching-FileNameMatchingEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[FileNameMatchingEngine](#T-MFR-Engines-Matching-FileNameMatchingEngine 'MFR.Engines.Matching.FileNameMatchingEngine')
and
returns a reference to it.

##### Parameters

This constructor has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `config`,
is passed a `null` value. |

<a name='M-MFR-Engines-Matching-FileNameMatchingEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[FileNameMatchingEngine](#T-MFR-Engines-Matching-FileNameMatchingEngine 'MFR.Engines.Matching.FileNameMatchingEngine')
and
returns a reference to it.

##### Parameters

This constructor has no parameters.

##### Remarks

NOTE: This constructor is marked as `internal`. This to
limit the scope of invocation to abstract factories only.



Clients who want to new up an instance of this class directly must
use the `public` constructor.

<a name='P-MFR-Engines-Matching-FileNameMatchingEngine-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='M-MFR-Engines-Matching-FileNameMatchingEngine-IsMatch-System-String,System-String,System-String-'></a>
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
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that specifies the search criteria. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value that the found text is to be
replaced with. Cannot be blank for a filename. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `findWhat`, or
`replaceWith`
, are passed blank or `null`
string for values. |

<a name='T-MFR-Engines-Matching-FolderNameMatchingEngine'></a>
## FolderNameMatchingEngine `type`

##### Namespace

MFR.Engines.Matching

##### Summary

Searches for matches to textual-search criteria patterns and regexes in the
pathnames of folders, according to rules specified by config settings.

<a name='M-MFR-Engines-Matching-FolderNameMatchingEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[TextExpressionMatchingEngineBase](#T-MFR-Engines-Matching-TextExpressionMatchingEngineBase 'MFR.Engines.Matching.TextExpressionMatchingEngineBase')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter,
`config`,
is passed a `null` value. |

<a name='M-MFR-Engines-Matching-FolderNameMatchingEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[FolderNameMatchingEngine](#T-MFR-Engines-Matching-FolderNameMatchingEngine 'MFR.Engines.Matching.FolderNameMatchingEngine')
and
returns a reference to it.

##### Parameters

This constructor has no parameters.

##### Remarks

NOTE: This constructor is marked as `internal`. This to
limit the scope of invocation to abstract factories only.



Clients who want to new up an instance of this class directly must
use the `public` constructor.

<a name='P-MFR-Engines-Matching-FolderNameMatchingEngine-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='M-MFR-Engines-Matching-FolderNameMatchingEngine-IsMatch-System-String,System-String,System-String-'></a>
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
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that specifies the search criteria. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value that the found text is to be
replaced with. Cannot be blank. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `findWhat`, or
`replaceWith`
are passed blank or `null`
string for values. |

<a name='T-MFR-Engines-Matching-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Matching.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Matching-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Matching-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Engines-Matching-SolutionFolderNameMatchingEngine'></a>
## SolutionFolderNameMatchingEngine `type`

##### Namespace

MFR.Engines.Matching

##### Summary

Searches for matches to textual-search criteria patterns and regexes in the
pathnames of folders that contain Visual Studio Solution (`*.sln`) files,
according to rules specified by config settings.

<a name='M-MFR-Engines-Matching-SolutionFolderNameMatchingEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[TextExpressionMatchingEngineBase](#T-MFR-Engines-Matching-TextExpressionMatchingEngineBase 'MFR.Engines.Matching.TextExpressionMatchingEngineBase')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter,
`config`,
is passed a `null` value. |

<a name='M-MFR-Engines-Matching-SolutionFolderNameMatchingEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[SolutionFolderNameMatchingEngine](#T-MFR-Engines-Matching-SolutionFolderNameMatchingEngine 'MFR.Engines.Matching.SolutionFolderNameMatchingEngine')
and
returns a reference to it.

##### Parameters

This constructor has no parameters.

##### Remarks

NOTE: This constructor is marked as `internal`. This to
limit the scope of invocation to abstract factories only.



Clients who want to new up an instance of this class directly must
use the `public` constructor.

<a name='P-MFR-Engines-Matching-SolutionFolderNameMatchingEngine-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='M-MFR-Engines-Matching-SolutionFolderNameMatchingEngine-IsMatch-System-String,System-String,System-String-'></a>
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
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that specifies the search criteria. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the value that the found text is to be
replaced with. Cannot be blank. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
, `findWhat`, or
`replaceWith`
are passed blank or `null`
string for values. |

<a name='T-MFR-Engines-Matching-TextExpressionMatchingEngineBase'></a>
## TextExpressionMatchingEngineBase `type`

##### Namespace

MFR.Engines.Matching

##### Summary

Implements functionality common to all text-expression matcher objects.

<a name='M-MFR-Engines-Matching-TextExpressionMatchingEngineBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[TextExpressionMatchingEngineBase](#T-MFR-Engines-Matching-TextExpressionMatchingEngineBase 'MFR.Engines.Matching.TextExpressionMatchingEngineBase')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Engines-Matching-TextExpressionMatchingEngineBase-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### #ctor(config) `constructor`

##### Summary

Constructs a new instance of
[TextExpressionMatchingEngineBase](#T-MFR-TextExpressionMatchingEngineBase 'MFR.TextExpressionMatchingEngineBase')
and returns
a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface that holds
settings that are specified by the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter,
`config`,
is passed a `null` value. |

<a name='P-MFR-Engines-Matching-TextExpressionMatchingEngineBase-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

##### Remarks

This object allows access to the user config and the
actions
associated with it.

<a name='P-MFR-Engines-Matching-TextExpressionMatchingEngineBase-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

<a name='P-MFR-Engines-Matching-TextExpressionMatchingEngineBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='M-MFR-Engines-Matching-TextExpressionMatchingEngineBase-IsMatch-System-String,System-String,System-String-'></a>
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
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that specifies the search criteria. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the value to be substituted for the
found text in `value`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
or `findWhat`, are passed blank or
`null` string for values. |

##### Remarks

NOTE: Implementers of this object must override this method and the
override must start by calling the base class.

<a name='M-MFR-Engines-Matching-TextExpressionMatchingEngineBase-IsMatch-MFR-Expressions-Matches-Interfaces-IMatchExpression-'></a>
### IsMatch(expression) `method`

##### Summary

Determines whether data and a search patterned, bound up together in
the form of the `expression` provided, contain a
data match according to rules specified by the user in the object, a
reference to which is specified in the
[ProjectFileRenamerConfig](#P-MFR-ITextExpressionMatchingEngine-ProjectFileRenamerConfig 'MFR.ITextExpressionMatchingEngine.ProjectFileRenamerConfig')
property.

##### Returns

`true` if more than zero matches are found;
`false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [MFR.Expressions.Matches.Interfaces.IMatchExpression](#T-MFR-Expressions-Matches-Interfaces-IMatchExpression 'MFR.Expressions.Matches.Interfaces.IMatchExpression') | (Required.) Reference to an instance of an object that implements
the [IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression') interface and whose
properties contain the match and pattern data. |

<a name='T-MFR-Engines-Matching-TextInFilesMatchingEngine'></a>
## TextInFilesMatchingEngine `type`

##### Namespace

MFR.Engines.Matching

##### Summary

Matches text in a file that is to be (eventually) replaced.

<a name='M-MFR-Engines-Matching-TextInFilesMatchingEngine-#ctor-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[TextExpressionMatchingEngineBase](#T-MFR-Engines-Matching-TextExpressionMatchingEngineBase 'MFR.Engines.Matching.TextExpressionMatchingEngineBase')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter,
`config`,
is passed a `null` value. |

<a name='M-MFR-Engines-Matching-TextInFilesMatchingEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[TextInFileMatchingEngine](#T-MFR-TextInFileMatchingEngine 'MFR.TextInFileMatchingEngine')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

##### Remarks

NOTE: This constructor is marked as `internal`. This to
limit the scope of invocation to abstract factories only.



Clients who want to new up an instance of this class directly must
use the `public` constructor.

<a name='P-MFR-Engines-Matching-TextInFilesMatchingEngine-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='M-MFR-Engines-Matching-TextInFilesMatchingEngine-IsMatch-System-String,System-String,System-String-'></a>
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
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that specifies the search criteria. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) String containing the data to replace all occurrences of
`findWhat` with in the `value`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`value`
or `findWhat`, are passed blank or
`null` string for values. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `findWhat`, is
passed either the empty or `null` string for a value.



This makes logical sense; if the `findWhat` is
blank, then we have nothing to search against!



NOTE: This parameter MAY have whitespace characters since these can
be matched inside the content of a text file, which is what we
expect to be passed for the `value` parameter. |

##### Remarks

It is expected that the `value` parameter has the
contents of the file. Sometimes, files contain zero bytes of data.



If this the case, then this method does nothing and returns the
default result of `false`.
