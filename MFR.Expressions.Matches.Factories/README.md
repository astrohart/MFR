<a name='assembly'></a>
# MFR.Expressions.Matches.Factories

## Contents

- [FileAndFolderMatchExpressionFactoryBase](#T-MFR-Objects-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase 'MFR.Expressions.Matches.Factories.FileAndFolderMatchExpressionFactoryBase')
  - [AndReplaceItWith(replaceWith)](#M-MFR-Objects-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase-AndReplaceItWith-System-String- 'MFR.Expressions.Matches.Factories.FileAndFolderMatchExpressionFactoryBase.AndReplaceItWith(System.String)')
  - [ForTextValue(value)](#M-MFR-Objects-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase-ForTextValue-System-String- 'MFR.Expressions.Matches.Factories.FileAndFolderMatchExpressionFactoryBase.ForTextValue(System.String)')
  - [ToFindWhat(findWhat)](#M-MFR-Objects-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase-ToFindWhat-System-String- 'MFR.Expressions.Matches.Factories.FileAndFolderMatchExpressionFactoryBase.ToFindWhat(System.String)')
- [FileNameReplacementMatchExpressionFactory](#T-MFR-Objects-Expressions-Matches-Factories-FileNameReplacementMatchExpressionFactory 'MFR.Expressions.Matches.Factories.FileNameReplacementMatchExpressionFactory')
  - [OperationType](#P-MFR-Objects-Expressions-Matches-Factories-FileNameReplacementMatchExpressionFactory-OperationType 'MFR.Expressions.Matches.Factories.FileNameReplacementMatchExpressionFactory.OperationType')
  - [ForTextValue(value)](#M-MFR-Objects-Expressions-Matches-Factories-FileNameReplacementMatchExpressionFactory-ForTextValue-System-String- 'MFR.Expressions.Matches.Factories.FileNameReplacementMatchExpressionFactory.ForTextValue(System.String)')
- [FolderNameReplacementMatchExpressionFactory](#T-MFR-Objects-Expressions-Matches-Factories-FolderNameReplacementMatchExpressionFactory 'MFR.Expressions.Matches.Factories.FolderNameReplacementMatchExpressionFactory')
  - [OperationType](#P-MFR-Objects-Expressions-Matches-Factories-FolderNameReplacementMatchExpressionFactory-OperationType 'MFR.Expressions.Matches.Factories.FolderNameReplacementMatchExpressionFactory.OperationType')
- [GetMatchExpressionFactory](#T-MFR-Objects-Expressions-Matches-Factories-GetMatchExpressionFactory 'MFR.Expressions.Matches.Factories.GetMatchExpressionFactory')
  - [For(type)](#M-MFR-Objects-Expressions-Matches-Factories-GetMatchExpressionFactory-For-MFR-Objects-Operations-Constants-OperationType- 'MFR.Expressions.Matches.Factories.GetMatchExpressionFactory.For(MFR.Operations.Constants.OperationType)')
- [MatchExpressionFactoryBase](#T-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase')
  - [FindWhat](#P-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-FindWhat 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.FindWhat')
  - [OperationType](#P-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-OperationType 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.OperationType')
  - [ReplaceWith](#P-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-ReplaceWith 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.ReplaceWith')
  - [Value](#P-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-Value 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.Value')
  - [AndReplaceItWith(replaceWith)](#M-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-AndReplaceItWith-System-String- 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.AndReplaceItWith(System.String)')
  - [ForTextValue(value)](#M-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-ForTextValue-System-String- 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.ForTextValue(System.String)')
  - [ToFindWhat(findWhat)](#M-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-ToFindWhat-System-String- 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.ToFindWhat(System.String)')
- [ReplaceTextInFileMatchExpressionFactory](#T-MFR-Objects-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory 'MFR.Expressions.Matches.Factories.ReplaceTextInFileMatchExpressionFactory')
  - [OperationType](#P-MFR-Objects-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-OperationType 'MFR.Expressions.Matches.Factories.ReplaceTextInFileMatchExpressionFactory.OperationType')
  - [AndReplaceItWith(replaceWith)](#M-MFR-Objects-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-AndReplaceItWith-System-String- 'MFR.Expressions.Matches.Factories.ReplaceTextInFileMatchExpressionFactory.AndReplaceItWith(System.String)')
  - [ForTextValue(value)](#M-MFR-Objects-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-ForTextValue-System-String- 'MFR.Expressions.Matches.Factories.ReplaceTextInFileMatchExpressionFactory.ForTextValue(System.String)')
  - [ToFindWhat(findWhat)](#M-MFR-Objects-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-ToFindWhat-System-String- 'MFR.Expressions.Matches.Factories.ReplaceTextInFileMatchExpressionFactory.ToFindWhat(System.String)')
- [Resources](#T-MFR-Objects-Expressions-Matches-Factories-Properties-Resources 'MFR.Expressions.Matches.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Expressions-Matches-Factories-Properties-Resources-Culture 'MFR.Expressions.Matches.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Expressions-Matches-Factories-Properties-Resources-ResourceManager 'MFR.Expressions.Matches.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase'></a>
## FileAndFolderMatchExpressionFactoryBase `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Defines the methods and properties that all implementations of the
[IMatchExpressionFactory](#T-MFR-Objects-IMatchExpressionFactory 'MFR.IMatchExpressionFactory')
interface
have in common for both file and folder pathnames being the search values.

<a name='M-MFR-Objects-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase-AndReplaceItWith-System-String-'></a>
### AndReplaceItWith(replaceWith) `method`

##### Summary

Initializes the value that text matching the pattern specified by
the
[ToFindWhat](#M-MFR-Objects-IMatchExpressionFactory-ToFindWhat 'MFR.IMatchExpressionFactory.ToFindWhat')
method will be replaced with.



Whitespace or the empty string is only allowed for the Replace in
Files operation type.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpression](#T-MFR-Objects-IMatchExpression 'MFR.IMatchExpression')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional for Replace in Files only.) String containing the text
that all occurrences of text matching the pattern are to be replaced with. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `replaceWith`, is
passed a blank or `null` string for a value, EXCEPT for the
Replace Text in Files operation type. |

##### Remarks

This method is the final method in the fluent-build chain,
outputting an instance of an object that implements the
[IMatchExpression](#T-MFR-Objects-IMatchExpression 'MFR.IMatchExpression')
interface as a result.



It is required to provide a non-blank, non-whitespace value for
`replaceWith` except for the Replace Text in Files operation.

<a name='M-MFR-Objects-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase-ForTextValue-System-String-'></a>
### ForTextValue(value) `method`

##### Summary

Sets the text data to be searched for a pattern.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data to be searched for a pattern. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `value`, is
passed a blank or `null` string for a value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `value`, is
passed either the empty or `null` string for a value.
Whitespace is allowed ONLY for the Replace Text in Files operation type. |

##### Remarks

Among the fluent-builder methods of this class, this one must be
invoked first.



However, prior to even invoking this method, the
[AndAttachConfiguration](#M-MFR-Objects-IConfigurationComposedObject-AndAttachConfiguration 'MFR.IConfigurationComposedObject.AndAttachConfiguration')
method must be invoked; otherwise, a
[ConfigurationNotAttachedException](#T-MFR-Objects-ConfigurationNotAttachedException 'MFR.ConfigurationNotAttachedException')
will be thrown. It is incumbent upon invokers of this method to
first weed out any possible elements of the source value set that
may make the `value` parameter get passed a blank string.

<a name='M-MFR-Objects-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase-ToFindWhat-System-String-'></a>
### ToFindWhat(findWhat) `method`

##### Summary

Initializes the match expression with the pattern to be found in the
value data.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern to search the value data for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `findWhat`, is
passed a blank or `null` string for a value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `findWhat`, is
passed either the empty string or `null` string for a value.
Whitespace is allowed, but ONLY for the Replace Text in Files
operation type. |

##### Remarks

It is recommended to call this method after calling the
[ForTextValue](#M-MFR-Objects-IMatchExpressionFactory-ForTextValue 'MFR.IMatchExpressionFactory.ForTextValue')
method.



It is incumbent upon invokers of this method to first weed out any
possible elements of the source value set that may make the
`findWhat` parameter get passed a blank string.

<a name='T-MFR-Objects-Expressions-Matches-Factories-FileNameReplacementMatchExpressionFactory'></a>
## FileNameReplacementMatchExpressionFactory `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Creates new instances of objects that implement the
[IMatchExpression](#T-MFR-Objects-Expressions-Matches-Interfaces-IMatchExpression 'MFR.Expressions.Matches.Interfaces.IMatchExpression')
interface that correspond to the
[RenameFilesInFolder](#T-MFR-Objects-Operations-Constants-OperationType-RenameFilesInFolder 'MFR.Operations.Constants.OperationType.RenameFilesInFolder')
operation.

<a name='P-MFR-Objects-Expressions-Matches-Factories-FileNameReplacementMatchExpressionFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType') values
that corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Expressions-Matches-Factories-FileNameReplacementMatchExpressionFactory-ForTextValue-System-String-'></a>
### ForTextValue(value) `method`

##### Summary

Sets the text data to be searched for a pattern.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data to be searched for a pattern. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `value`, is
passed a blank or `null` string for a value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `value`, is
passed either the empty or `null` string for a
value. Whitespace is allowed ONLY for the Replace Text in Files
operation type. |

##### Remarks

Among the fluent-builder methods of this class, this one must be
invoked first.



However, prior to even invoking this method, the
[AndAttachConfiguration](#M-MFR-Objects-IConfigurationComposedObject-AndAttachConfiguration 'MFR.IConfigurationComposedObject.AndAttachConfiguration')
method must be invoked; otherwise, a
[ConfigurationNotAttachedException](#T-MFR-Objects-ConfigurationNotAttachedException 'MFR.ConfigurationNotAttachedException')
will be
thrown. It is incumbent upon invokers of this method to first weed
out any possible elements of the source value set that may make the
`value` parameter get passed a blank string.

<a name='T-MFR-Objects-Expressions-Matches-Factories-FolderNameReplacementMatchExpressionFactory'></a>
## FolderNameReplacementMatchExpressionFactory `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Creates new instances of objects that implement the
[IMatchExpression](#T-MFR-Objects-Expressions-Matches-Interfaces-IMatchExpression 'MFR.Expressions.Matches.Interfaces.IMatchExpression')
interface that correspond to the
[RenameSubFolders](#T-MFR-Objects-Operations-Constants-OperationType-RenameSubFolders 'MFR.Operations.Constants.OperationType.RenameSubFolders')
operation type.

<a name='P-MFR-Objects-Expressions-Matches-Factories-FolderNameReplacementMatchExpressionFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType') values
that corresponds to the type of operation being performed.

<a name='T-MFR-Objects-Expressions-Matches-Factories-GetMatchExpressionFactory'></a>
## GetMatchExpressionFactory `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Creates instances of objects that implement the
[IMatchExpressionFactory](#T-MFR-Objects-IMatchExpressionFactory 'MFR.IMatchExpressionFactory')
interface.

<a name='M-MFR-Objects-Expressions-Matches-Factories-GetMatchExpressionFactory-For-MFR-Objects-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates instances of objects that implement the
[IMatchExpressionFactory](#T-MFR-Objects-IMatchExpressionFactory 'MFR.IMatchExpressionFactory')
interface
for the given operation `type`.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpressionFactory](#T-MFR-Objects-IMatchExpressionFactory 'MFR.IMatchExpressionFactory')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Objects-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | The [OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType') value that
corresponds to the type of operation being performed.



NOTE: Not all operation types are supported. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the [OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType')
value passed in the `type` parameter does not
correspond to an operation type for which a match expression object
can be created.



Not all [OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType') values
are supported. |

<a name='T-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase'></a>
## MatchExpressionFactoryBase `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Defines methods and properties that all implementations of the
[IMatchExpressionFactory](#T-MFR-Objects-IMatchExpressionFactory 'MFR.IMatchExpressionFactory')
interface
have in common.

<a name='P-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets a string containing the pattern to be utilized as
search criteria.

<a name='P-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets a string containing the text that all occurrences of
the pattern in the
[FindWhat](#P-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-FindWhat 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.FindWhat')
property get replaced with in the
[Value](#P-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-Value 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.Value')
property.

<a name='P-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-Value'></a>
### Value `property`

##### Summary

Gets or sets a string containing the text data to be searched.

<a name='M-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-AndReplaceItWith-System-String-'></a>
### AndReplaceItWith(replaceWith) `method`

##### Summary

Initializes the value that text matching the pattern specified by
the
[ToFindWhat](#M-MFR-Objects-IMatchExpressionFactory-ToFindWhat 'MFR.IMatchExpressionFactory.ToFindWhat')
method will be replaced with.



Whitespace or the empty string is only allowed for the Replace in
Files operation type.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpression](#T-MFR-Objects-IMatchExpression 'MFR.IMatchExpression')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional for Replace in Files only.) String containing the text
that all occurrences of text matching the pattern are to be replaced with. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `replaceWith`, is
passed a blank or `null` string for a value, EXCEPT for the
Replace Text in Files operation type. |

##### Remarks

This method is the final method in the fluent-build chain,
outputting an instance of an object that implements the
[IMatchExpression](#T-MFR-Objects-IMatchExpression 'MFR.IMatchExpression')
interface as a result.



It is required to provide a non-blank, non-whitespace value for
`replaceWith` except for the Replace Text in Files operation.

<a name='M-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-ForTextValue-System-String-'></a>
### ForTextValue(value) `method`

##### Summary

Sets the text data to be searched for a pattern.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data to be searched for a pattern. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `value`, is
passed a blank or `null` string for a value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `value`, is
passed either the empty or `null` string for a value.
Whitespace is allowed ONLY for the Replace Text in Files operation type. |

##### Remarks

Among the fluent-builder methods of this class, this one must be
invoked first.



However, prior to even invoking this method, the
[AndAttachConfiguration](#M-MFR-Objects-IConfigurationComposedObject-AndAttachConfiguration 'MFR.IConfigurationComposedObject.AndAttachConfiguration')
method must be invoked; otherwise, a
[ConfigurationNotAttachedException](#T-MFR-Objects-ConfigurationNotAttachedException 'MFR.ConfigurationNotAttachedException')
will be thrown. It is incumbent upon invokers of this method to
first weed out any possible elements of the source value set that
may make the `value` parameter get passed a blank string.

<a name='M-MFR-Objects-Expressions-Matches-Factories-MatchExpressionFactoryBase-ToFindWhat-System-String-'></a>
### ToFindWhat(findWhat) `method`

##### Summary

Initializes the match expression with the pattern to be found in the
value data.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern to search the value data for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `findWhat`, is
passed a blank or `null` string for a value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `findWhat`, is
passed either the empty string or `null` string for a value.
Whitespace is allowed, but ONLY for the Replace Text in Files
operation type. |

##### Remarks

It is recommended to call this method after calling the
[ForTextValue](#M-MFR-Objects-IMatchExpressionFactory-ForTextValue 'MFR.IMatchExpressionFactory.ForTextValue')
method.



It is incumbent upon invokers of this method to first weed out any
possible elements of the source value set that may make the
`findWhat` parameter get passed a blank string.

<a name='T-MFR-Objects-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory'></a>
## ReplaceTextInFileMatchExpressionFactory `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Defines the method of building an instance of an object that implements
the [IMatchExpression](#T-MFR-Objects-IMatchExpression 'MFR.IMatchExpression') interface
interface that correspond to the
[ReplaceTextInFiles](#T-MFR-Objects-OperationType-ReplaceTextInFiles 'MFR.OperationType.ReplaceTextInFiles')
operation type.

<a name='P-MFR-Objects-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-AndReplaceItWith-System-String-'></a>
### AndReplaceItWith(replaceWith) `method`

##### Summary

Initializes the value that text matching the pattern specified by
the
[ToFindWhat](#M-MFR-Objects-IMatchExpressionFactory-ToFindWhat 'MFR.IMatchExpressionFactory.ToFindWhat')
method will be replaced with.



Whitespace or the empty string is only allowed for the Replace in
Files operation type.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpression](#T-MFR-Objects-IMatchExpression 'MFR.IMatchExpression')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional for Replace in Files only.) String containing the text
that all occurrences of text matching the pattern are to be replaced with. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `replaceWith`, is
passed a blank or `null` string for a value, EXCEPT for the
Replace Text in Files operation type. |

##### Remarks

This method is the final method in the fluent-build chain,
outputting an instance of an object that implements the
[IMatchExpression](#T-MFR-Objects-IMatchExpression 'MFR.IMatchExpression')
interface as a result.



It is required to provide a non-blank, non-whitespace value for
`replaceWith` except for the Replace Text in Files operation.

<a name='M-MFR-Objects-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-ForTextValue-System-String-'></a>
### ForTextValue(value) `method`

##### Summary

Sets the text data to be searched for a pattern.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the data to be searched for a pattern. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `value`, is
passed a blank or `null` string for a value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `value`, is
passed either the empty or `null` string for a value.
Whitespace is allowed ONLY for the Replace Text in Files operation type. |

##### Remarks

Among the fluent-builder methods of this class, this one must be
invoked first.



However, prior to even invoking this method, the
[AndAttachConfiguration](#M-MFR-Objects-IConfigurationComposedObject-AndAttachConfiguration 'MFR.IConfigurationComposedObject.AndAttachConfiguration')
method must be invoked; otherwise, a
[ConfigurationNotAttachedException](#T-MFR-Objects-ConfigurationNotAttachedException 'MFR.ConfigurationNotAttachedException')
will be thrown. It is incumbent upon invokers of this method to
first weed out any possible elements of the source value set that
may make the `value` parameter get passed a blank string.

<a name='M-MFR-Objects-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-ToFindWhat-System-String-'></a>
### ToFindWhat(findWhat) `method`

##### Summary

Initializes the match expression with the pattern to be found in the
value data.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pattern to search the value data for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `findWhat`, is
passed a blank or `null` string for a value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `findWhat`, is
passed either the empty string or `null` string for a value.
Whitespace is allowed, but ONLY for the Replace Text in Files
operation type. |

##### Remarks

It is recommended to call this method after calling the
[ForTextValue](#M-MFR-Objects-IMatchExpressionFactory-ForTextValue 'MFR.IMatchExpressionFactory.ForTextValue')
method.



It is incumbent upon invokers of this method to first weed out any
possible elements of the source value set that may make the
`findWhat` parameter get passed a blank string.

<a name='T-MFR-Objects-Expressions-Matches-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Expressions.Matches.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Expressions-Matches-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Expressions-Matches-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
