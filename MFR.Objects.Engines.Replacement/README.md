<a name='assembly'></a>
# MFR.Objects.Engines.Replacement

## Contents

- [FileNameReplacementEngine](#T-MFR-Objects-Engines-Replacement-FileNameReplacementEngine 'MFR.Objects.Engines.Replacement.FileNameReplacementEngine')
  - [#ctor()](#M-MFR-Objects-Engines-Replacement-FileNameReplacementEngine-#ctor 'MFR.Objects.Engines.Replacement.FileNameReplacementEngine.#ctor')
  - [OperationType](#P-MFR-Objects-Engines-Replacement-FileNameReplacementEngine-OperationType 'MFR.Objects.Engines.Replacement.FileNameReplacementEngine.OperationType')
  - [Replace(source,pattern,dest)](#M-MFR-Objects-Engines-Replacement-FileNameReplacementEngine-Replace-System-String,System-String,System-String- 'MFR.Objects.Engines.Replacement.FileNameReplacementEngine.Replace(System.String,System.String,System.String)')
- [FolderNameReplacementEngine](#T-MFR-Objects-Engines-Replacement-FolderNameReplacementEngine 'MFR.Objects.Engines.Replacement.FolderNameReplacementEngine')
  - [#ctor()](#M-MFR-Objects-Engines-Replacement-FolderNameReplacementEngine-#ctor 'MFR.Objects.Engines.Replacement.FolderNameReplacementEngine.#ctor')
  - [OperationType](#P-MFR-Objects-Engines-Replacement-FolderNameReplacementEngine-OperationType 'MFR.Objects.Engines.Replacement.FolderNameReplacementEngine.OperationType')
  - [Replace(source,pattern,dest)](#M-MFR-Objects-Engines-Replacement-FolderNameReplacementEngine-Replace-System-String,System-String,System-String- 'MFR.Objects.Engines.Replacement.FolderNameReplacementEngine.Replace(System.String,System.String,System.String)')
- [Resources](#T-MFR-Objects-Engines-Replacement-Properties-Resources 'MFR.Objects.Engines.Replacement.Properties.Resources')
  - [Culture](#P-MFR-Objects-Engines-Replacement-Properties-Resources-Culture 'MFR.Objects.Engines.Replacement.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Engines-Replacement-Properties-Resources-ResourceManager 'MFR.Objects.Engines.Replacement.Properties.Resources.ResourceManager')
- [TextInFileReplacementEngine](#T-MFR-Objects-Engines-Replacement-TextInFileReplacementEngine 'MFR.Objects.Engines.Replacement.TextInFileReplacementEngine')
  - [#ctor()](#M-MFR-Objects-Engines-Replacement-TextInFileReplacementEngine-#ctor 'MFR.Objects.Engines.Replacement.TextInFileReplacementEngine.#ctor')
  - [OperationType](#P-MFR-Objects-Engines-Replacement-TextInFileReplacementEngine-OperationType 'MFR.Objects.Engines.Replacement.TextInFileReplacementEngine.OperationType')
  - [Replace(source,pattern,dest)](#M-MFR-Objects-Engines-Replacement-TextInFileReplacementEngine-Replace-System-String,System-String,System-String- 'MFR.Objects.Engines.Replacement.TextInFileReplacementEngine.Replace(System.String,System.String,System.String)')
- [TextReplacementEngineBase](#T-MFR-Objects-Engines-Replacement-TextReplacementEngineBase 'MFR.Objects.Engines.Replacement.TextReplacementEngineBase')
  - [#ctor()](#M-MFR-Objects-Engines-Replacement-TextReplacementEngineBase-#ctor 'MFR.Objects.Engines.Replacement.TextReplacementEngineBase.#ctor')
  - [OperationType](#P-MFR-Objects-Engines-Replacement-TextReplacementEngineBase-OperationType 'MFR.Objects.Engines.Replacement.TextReplacementEngineBase.OperationType')
  - [Replace(source,pattern,dest)](#M-MFR-Objects-Engines-Replacement-TextReplacementEngineBase-Replace-System-String,System-String,System-String- 'MFR.Objects.Engines.Replacement.TextReplacementEngineBase.Replace(System.String,System.String,System.String)')
  - [Replace(expression)](#M-MFR-Objects-Engines-Replacement-TextReplacementEngineBase-Replace-MFR-Objects-Expressions-Matches-Interfaces-IMatchExpression- 'MFR.Objects.Engines.Replacement.TextReplacementEngineBase.Replace(MFR.Objects.Expressions.Matches.Interfaces.IMatchExpression)')

<a name='T-MFR-Objects-Engines-Replacement-FileNameReplacementEngine'></a>
## FileNameReplacementEngine `type`

##### Namespace

MFR.Objects.Engines.Replacement

##### Summary

Replaces text in file names.

<a name='M-MFR-Objects-Engines-Replacement-FileNameReplacementEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[FileNameReplacementEngine](#T-MFR-Objects-Engines-Replacement-FileNameReplacementEngine 'MFR.Objects.Engines.Replacement.FileNameReplacementEngine')
and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Engines-Replacement-FileNameReplacementEngine-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Engines-Replacement-FileNameReplacementEngine-Replace-System-String,System-String,System-String-'></a>
### Replace(source,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `expression`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Default is blank. String containing the new data that
should be substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`source`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |

<a name='T-MFR-Objects-Engines-Replacement-FolderNameReplacementEngine'></a>
## FolderNameReplacementEngine `type`

##### Namespace

MFR.Objects.Engines.Replacement

##### Summary

Contains rules to replace text in the pathnames of folders.

<a name='M-MFR-Objects-Engines-Replacement-FolderNameReplacementEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[FolderNameReplacementEngine](#T-MFR-Objects-Engines-Replacement-FolderNameReplacementEngine 'MFR.Objects.Engines.Replacement.FolderNameReplacementEngine')
and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Engines-Replacement-FolderNameReplacementEngine-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Engines-Replacement-FolderNameReplacementEngine-Replace-System-String,System-String,System-String-'></a>
### Replace(source,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `expression`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Default is blank. String containing the new data that
should be substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`source`
, `pattern`, or
`dest`
, are passed blank or `null` string
for values. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the `source` parameter does not contain
the fully-qualified, absolute pathname to a folder. |

<a name='T-MFR-Objects-Engines-Replacement-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Engines.Replacement.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Engines-Replacement-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Engines-Replacement-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-Engines-Replacement-TextInFileReplacementEngine'></a>
## TextInFileReplacementEngine `type`

##### Namespace

MFR.Objects.Engines.Replacement

##### Summary

Replaces text in a file. Here, we represent the file's contents as
simply the source string of methods.

<a name='M-MFR-Objects-Engines-Replacement-TextInFileReplacementEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[TextInFileReplacementEngine](#T-MFR-Objects-Engines-Replacement-TextInFileReplacementEngine 'MFR.Objects.Engines.Replacement.TextInFileReplacementEngine')
and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Engines-Replacement-TextInFileReplacementEngine-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Engines-Replacement-TextInFileReplacementEngine-Replace-System-String,System-String,System-String-'></a>
### Replace(source,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `expression`. Returns a string

##### Returns

String containing the new data. If the `source`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
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
expect to be passed for the `source` parameter. |

##### Remarks

Here, the `dest` parameter may be blank or null; if
the `source` parameter is `null` or
the empty string, then this method returns the empty string.



NOTE: The `source` parameter MAY contain whitespace.
this is the case, then the text found by the
`pattern`
just gets deleted, which is okay in this instance.

<a name='T-MFR-Objects-Engines-Replacement-TextReplacementEngineBase'></a>
## TextReplacementEngineBase `type`

##### Namespace

MFR.Objects.Engines.Replacement

##### Summary

Defines the methods, properties, and events that are common to all
text-replacement engine object implementations.

<a name='M-MFR-Objects-Engines-Replacement-TextReplacementEngineBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[TextReplacementEngineBase](#T-MFR-Objects-Engines-Replacement-TextReplacementEngineBase 'MFR.Objects.Engines.Replacement.TextReplacementEngineBase')
and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Engines-Replacement-TextReplacementEngineBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Engines-Replacement-TextReplacementEngineBase-Replace-System-String,System-String,System-String-'></a>
### Replace(source,pattern,dest) `method`

##### Summary

Carries out the replacement operation using the values specified by
the provided `expression`. Returns a string

##### Returns

String containing the new data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data upon which the replacement
operation is to be carried out. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern that allows us to match
the data to be replaced. |
| dest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Default is blank. String containing the new data that
should be substituted for the replaced text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`source`
or `pattern`, are passed blank or
`null` string for values. |

<a name='M-MFR-Objects-Engines-Replacement-TextReplacementEngineBase-Replace-MFR-Objects-Expressions-Matches-Interfaces-IMatchExpression-'></a>
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
| expression | [MFR.Objects.Expressions.Matches.Interfaces.IMatchExpression](#T-MFR-Objects-Expressions-Matches-Interfaces-IMatchExpression 'MFR.Objects.Expressions.Matches.Interfaces.IMatchExpression') | (Required.) A
[MatchExpression](#T-MFR-Objects-MatchExpression 'MFR.Objects.MatchExpression')
that contains the
replacement data. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `expression`, is
passed a `null` value. |