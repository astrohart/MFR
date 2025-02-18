<a name='assembly'></a>
# MFR.Expressions.Matches.Factories

## Contents

- [FileAndFolderMatchExpressionFactoryBase](#T-MFR-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase 'MFR.Expressions.Matches.Factories.FileAndFolderMatchExpressionFactoryBase')
  - [AndReplaceItWith(replaceWith)](#M-MFR-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase-AndReplaceItWith-System-String- 'MFR.Expressions.Matches.Factories.FileAndFolderMatchExpressionFactoryBase.AndReplaceItWith(System.String)')
  - [ForTextValue(value)](#M-MFR-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase-ForTextValue-System-String- 'MFR.Expressions.Matches.Factories.FileAndFolderMatchExpressionFactoryBase.ForTextValue(System.String)')
  - [ToFindWhat(findWhat)](#M-MFR-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase-ToFindWhat-System-String- 'MFR.Expressions.Matches.Factories.FileAndFolderMatchExpressionFactoryBase.ToFindWhat(System.String)')
- [FileNameReplacementMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-FileNameReplacementMatchExpressionFactory 'MFR.Expressions.Matches.Factories.FileNameReplacementMatchExpressionFactory')
  - [OperationType](#P-MFR-Expressions-Matches-Factories-FileNameReplacementMatchExpressionFactory-OperationType 'MFR.Expressions.Matches.Factories.FileNameReplacementMatchExpressionFactory.OperationType')
  - [ForTextValue(value)](#M-MFR-Expressions-Matches-Factories-FileNameReplacementMatchExpressionFactory-ForTextValue-System-String- 'MFR.Expressions.Matches.Factories.FileNameReplacementMatchExpressionFactory.ForTextValue(System.String)')
- [FolderNameReplacementMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-FolderNameReplacementMatchExpressionFactory 'MFR.Expressions.Matches.Factories.FolderNameReplacementMatchExpressionFactory')
  - [OperationType](#P-MFR-Expressions-Matches-Factories-FolderNameReplacementMatchExpressionFactory-OperationType 'MFR.Expressions.Matches.Factories.FolderNameReplacementMatchExpressionFactory.OperationType')
- [GetMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-GetMatchExpressionFactory 'MFR.Expressions.Matches.Factories.GetMatchExpressionFactory')
  - [For(type)](#M-MFR-Expressions-Matches-Factories-GetMatchExpressionFactory-For-MFR-Operations-Constants-OperationType- 'MFR.Expressions.Matches.Factories.GetMatchExpressionFactory.For(MFR.Operations.Constants.OperationType)')
- [MakeNewFileNameReplacementMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-MakeNewFileNameReplacementMatchExpressionFactory 'MFR.Expressions.Matches.Factories.MakeNewFileNameReplacementMatchExpressionFactory')
  - [FromScratch()](#M-MFR-Expressions-Matches-Factories-MakeNewFileNameReplacementMatchExpressionFactory-FromScratch 'MFR.Expressions.Matches.Factories.MakeNewFileNameReplacementMatchExpressionFactory.FromScratch')
- [MakeNewFolderNameReplacementMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-MakeNewFolderNameReplacementMatchExpressionFactory 'MFR.Expressions.Matches.Factories.MakeNewFolderNameReplacementMatchExpressionFactory')
  - [FromScratch()](#M-MFR-Expressions-Matches-Factories-MakeNewFolderNameReplacementMatchExpressionFactory-FromScratch 'MFR.Expressions.Matches.Factories.MakeNewFolderNameReplacementMatchExpressionFactory.FromScratch')
- [MakeNewReplaceTextInFileMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-MakeNewReplaceTextInFileMatchExpressionFactory 'MFR.Expressions.Matches.Factories.MakeNewReplaceTextInFileMatchExpressionFactory')
  - [FromScratch()](#M-MFR-Expressions-Matches-Factories-MakeNewReplaceTextInFileMatchExpressionFactory-FromScratch 'MFR.Expressions.Matches.Factories.MakeNewReplaceTextInFileMatchExpressionFactory.FromScratch')
- [MakeNewSolutionFolderNameReplacementMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-MakeNewSolutionFolderNameReplacementMatchExpressionFactory 'MFR.Expressions.Matches.Factories.MakeNewSolutionFolderNameReplacementMatchExpressionFactory')
  - [FromScratch()](#M-MFR-Expressions-Matches-Factories-MakeNewSolutionFolderNameReplacementMatchExpressionFactory-FromScratch 'MFR.Expressions.Matches.Factories.MakeNewSolutionFolderNameReplacementMatchExpressionFactory.FromScratch')
- [MatchExpressionFactoryBase](#T-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase')
  - [ConfigProvider](#P-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-ConfigProvider 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.ConfigProvider')
  - [CurrentConfig](#P-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-CurrentConfig 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.CurrentConfig')
  - [FindWhat](#P-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-FindWhat 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.FindWhat')
  - [OperationType](#P-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-OperationType 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.OperationType')
  - [ReplaceWith](#P-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-ReplaceWith 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.ReplaceWith')
  - [Value](#P-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-Value 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.Value')
  - [AndReplaceItWith(replaceWith)](#M-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-AndReplaceItWith-System-String- 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.AndReplaceItWith(System.String)')
  - [ForTextValue(value)](#M-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-ForTextValue-System-String- 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.ForTextValue(System.String)')
  - [ToFindWhat(findWhat)](#M-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-ToFindWhat-System-String- 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.ToFindWhat(System.String)')
- [ReplaceTextInFileMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory 'MFR.Expressions.Matches.Factories.ReplaceTextInFileMatchExpressionFactory')
  - [OperationType](#P-MFR-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-OperationType 'MFR.Expressions.Matches.Factories.ReplaceTextInFileMatchExpressionFactory.OperationType')
  - [AndReplaceItWith(replaceWith)](#M-MFR-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-AndReplaceItWith-System-String- 'MFR.Expressions.Matches.Factories.ReplaceTextInFileMatchExpressionFactory.AndReplaceItWith(System.String)')
  - [ForTextValue(value)](#M-MFR-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-ForTextValue-System-String- 'MFR.Expressions.Matches.Factories.ReplaceTextInFileMatchExpressionFactory.ForTextValue(System.String)')
  - [ToFindWhat(findWhat)](#M-MFR-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-ToFindWhat-System-String- 'MFR.Expressions.Matches.Factories.ReplaceTextInFileMatchExpressionFactory.ToFindWhat(System.String)')
- [Resources](#T-MFR-Expressions-Matches-Factories-Properties-Resources 'MFR.Expressions.Matches.Factories.Properties.Resources')
  - [Culture](#P-MFR-Expressions-Matches-Factories-Properties-Resources-Culture 'MFR.Expressions.Matches.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Expressions-Matches-Factories-Properties-Resources-ResourceManager 'MFR.Expressions.Matches.Factories.Properties.Resources.ResourceManager')
- [SolutionFolderNameReplacementMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-SolutionFolderNameReplacementMatchExpressionFactory 'MFR.Expressions.Matches.Factories.SolutionFolderNameReplacementMatchExpressionFactory')
  - [OperationType](#P-MFR-Expressions-Matches-Factories-SolutionFolderNameReplacementMatchExpressionFactory-OperationType 'MFR.Expressions.Matches.Factories.SolutionFolderNameReplacementMatchExpressionFactory.OperationType')

<a name='T-MFR-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase'></a>
## FileAndFolderMatchExpressionFactoryBase `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Defines the methods and properties that all implementations of the
[IMatchExpressionFactory](#T-MFR-IMatchExpressionFactory 'MFR.IMatchExpressionFactory')
interface
have in common for both file and folder pathnames being the search values.

<a name='M-MFR-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase-AndReplaceItWith-System-String-'></a>
### AndReplaceItWith(replaceWith) `method`

##### Summary

Initializes the value that text matching the pattern specified by
the
[ToFindWhat](#M-MFR-IMatchExpressionFactory-ToFindWhat 'MFR.IMatchExpressionFactory.ToFindWhat')
method will be replaced with.



Whitespace or the empty string is only allowed for the Replace in
Files operation type.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression')
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
[IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression')
interface as a result.



It is required to provide a non-blank, non-whitespace value for
`replaceWith` except for the Replace Text in Files operation.

<a name='M-MFR-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase-ForTextValue-System-String-'></a>
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
[AndAttachConfiguration](#M-MFR-IConfigurationComposedObject-AndAttachConfiguration 'MFR.IConfigurationComposedObject.AndAttachConfiguration')
method must be invoked; otherwise, a
[ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException')
will be thrown. It is incumbent upon invokers of this method to
first weed out any possible elements of the source value set that
may make the `value` parameter get passed a blank string.

<a name='M-MFR-Expressions-Matches-Factories-FileAndFolderMatchExpressionFactoryBase-ToFindWhat-System-String-'></a>
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
[ForTextValue](#M-MFR-IMatchExpressionFactory-ForTextValue 'MFR.IMatchExpressionFactory.ForTextValue')
method.



It is incumbent upon invokers of this method to first weed out any
possible elements of the source value set that may make the
`findWhat` parameter get passed a blank string.

<a name='T-MFR-Expressions-Matches-Factories-FileNameReplacementMatchExpressionFactory'></a>
## FileNameReplacementMatchExpressionFactory `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Creates new instances of objects that implement the
[IMatchExpression](#T-MFR-Expressions-Matches-Interfaces-IMatchExpression 'MFR.Expressions.Matches.Interfaces.IMatchExpression')
interface that correspond to the
[RenameFilesInFolder](#T-MFR-Operations-Constants-OperationType-RenameFilesInFolder 'MFR.Operations.Constants.OperationType.RenameFilesInFolder')
operation.

<a name='P-MFR-Expressions-Matches-Factories-FileNameReplacementMatchExpressionFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='M-MFR-Expressions-Matches-Factories-FileNameReplacementMatchExpressionFactory-ForTextValue-System-String-'></a>
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
[AndAttachConfiguration](#M-MFR-IConfigurationComposedObject-AndAttachConfiguration 'MFR.IConfigurationComposedObject.AndAttachConfiguration')
method must be invoked; otherwise, a
[ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException')
will be
thrown. It is incumbent upon invokers of this method to first weed
out any possible elements of the source value set that may make the
`value` parameter get passed a blank string.

<a name='T-MFR-Expressions-Matches-Factories-FolderNameReplacementMatchExpressionFactory'></a>
## FolderNameReplacementMatchExpressionFactory `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Creates new instances of objects that implement the
[IMatchExpression](#T-MFR-Expressions-Matches-Interfaces-IMatchExpression 'MFR.Expressions.Matches.Interfaces.IMatchExpression')
interface that correspond to the
[RenameSubFolders](#T-MFR-Operations-Constants-OperationType-RenameSubFolders 'MFR.Operations.Constants.OperationType.RenameSubFolders')
operation type.

<a name='P-MFR-Expressions-Matches-Factories-FolderNameReplacementMatchExpressionFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='T-MFR-Expressions-Matches-Factories-GetMatchExpressionFactory'></a>
## GetMatchExpressionFactory `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Creates instances of objects that implement the
[IMatchExpressionFactory](#T-MFR-IMatchExpressionFactory 'MFR.IMatchExpressionFactory')
interface.

<a name='M-MFR-Expressions-Matches-Factories-GetMatchExpressionFactory-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates instances of objects that implement the
[IMatchExpressionFactory](#T-MFR-IMatchExpressionFactory 'MFR.IMatchExpressionFactory')
interface
for the given operation `type`.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpressionFactory](#T-MFR-IMatchExpressionFactory 'MFR.IMatchExpressionFactory')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | The [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') value that
corresponds to the type of operation being performed.



NOTE: Not all operation types are supported. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
value passed in the `type` parameter does not
correspond to an operation type for which a match expression object
can be created.



Not all [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
are supported. |

<a name='T-MFR-Expressions-Matches-Factories-MakeNewFileNameReplacementMatchExpressionFactory'></a>
## MakeNewFileNameReplacementMatchExpressionFactory `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Creates new instances of objects that implement the
[IMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory')
interface that generates a matching expression for the renaming of files
according to what the user specified to search for in the filename and what to
replace it with.

<a name='M-MFR-Expressions-Matches-Factories-MakeNewFileNameReplacementMatchExpressionFactory-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory')
interface that generates a matching expression for the renaming of files
according to what the user specified to search for in the filename and what to
replace it with.

##### Parameters

This method has no parameters.

<a name='T-MFR-Expressions-Matches-Factories-MakeNewFolderNameReplacementMatchExpressionFactory'></a>
## MakeNewFolderNameReplacementMatchExpressionFactory `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Creates new instances of objects that implement the
[IMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory')
interface that generates a matching expression for the renaming of file folders
according to what the user specified to search for in the filename and what to
replace it with.

<a name='M-MFR-Expressions-Matches-Factories-MakeNewFolderNameReplacementMatchExpressionFactory-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory')
interface that generates a matching expression for the renaming of file folders
according to what the user specified to search for in the filename and what to
replace it with.

##### Parameters

This method has no parameters.

<a name='T-MFR-Expressions-Matches-Factories-MakeNewReplaceTextInFileMatchExpressionFactory'></a>
## MakeNewReplaceTextInFileMatchExpressionFactory `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Creates new instances of objects that implement the
[IMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory')
interface that generates a matching expression for the replacing of text in files
according to what the user specified to search for in the filename and what to
replace it with.

<a name='M-MFR-Expressions-Matches-Factories-MakeNewReplaceTextInFileMatchExpressionFactory-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory')
interface that generates a matching expression for the replacing of text in files
according to what the user specified to search for in the filename and what to
replace it with.

##### Parameters

This method has no parameters.

<a name='T-MFR-Expressions-Matches-Factories-MakeNewSolutionFolderNameReplacementMatchExpressionFactory'></a>
## MakeNewSolutionFolderNameReplacementMatchExpressionFactory `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Creates new instances of objects that implement the
[IMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory')
interface that generates a matching expression for the renaming of file folders
that contain Visual Studio Solution (`*.sln`) files according to what the
user specified to search for in the filename and what to replace it with.

<a name='M-MFR-Expressions-Matches-Factories-MakeNewSolutionFolderNameReplacementMatchExpressionFactory-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpressionFactory](#T-MFR-Expressions-Matches-Factories-Interfaces-IMatchExpressionFactory 'MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory')
interface that generates a matching expression for the renaming of file folders
that contain Visual Studio Solution (`*.sln`) files according to what the
user specified to search for in the filename and what to replace it with.

##### Parameters

This method has no parameters.

<a name='T-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase'></a>
## MatchExpressionFactoryBase `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Defines methods and properties that all implementations of the
[IMatchExpressionFactory](#T-MFR-IMatchExpressionFactory 'MFR.IMatchExpressionFactory')
interface
have in common.

<a name='P-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

##### Remarks

This object allows access to the user config and the
actions
associated with it.

<a name='P-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-CurrentConfig'></a>
### CurrentConfig `property`

##### Summary

Gets or sets a reference to an instance of an object that implements
the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

<a name='P-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets a string containing the pattern to be utilized as
search criteria.

<a name='P-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='P-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets a string containing the text that all occurrences of
the pattern in the
[ToFindWhat](#P-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-ToFindWhat 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.ToFindWhat')
property get replaced with in the
[Value](#P-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-Value 'MFR.Expressions.Matches.Factories.MatchExpressionFactoryBase.Value')
property.

<a name='P-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-Value'></a>
### Value `property`

##### Summary

Gets or sets a string containing the text data to be searched.

<a name='M-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-AndReplaceItWith-System-String-'></a>
### AndReplaceItWith(replaceWith) `method`

##### Summary

Initializes the value that text matching the pattern specified by
the
[ToFindWhat](#M-MFR-IMatchExpressionFactory-ToFindWhat 'MFR.IMatchExpressionFactory.ToFindWhat')
method will be replaced with.



Whitespace or the empty string is only allowed for the Replace in
Files operation type.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression')
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
[IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression')
interface as a result.



It is required to provide a non-blank, non-whitespace value for
`replaceWith` except for the Replace Text in Files operation.

<a name='M-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-ForTextValue-System-String-'></a>
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
[AndAttachConfiguration](#M-MFR-IConfigurationComposedObject-AndAttachConfiguration 'MFR.IConfigurationComposedObject.AndAttachConfiguration')
method must be invoked; otherwise, a
[ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException')
will be thrown. It is incumbent upon invokers of this method to
first weed out any possible elements of the source value set that
may make the `value` parameter get passed a blank string.

<a name='M-MFR-Expressions-Matches-Factories-MatchExpressionFactoryBase-ToFindWhat-System-String-'></a>
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
[ForTextValue](#M-MFR-IMatchExpressionFactory-ForTextValue 'MFR.IMatchExpressionFactory.ForTextValue')
method.



It is incumbent upon invokers of this method to first weed out any
possible elements of the source value set that may make the
`findWhat` parameter get passed a blank string.

<a name='T-MFR-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory'></a>
## ReplaceTextInFileMatchExpressionFactory `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Defines the method of building an instance of an object that implements
the [IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression') interface
interface that correspond to the
[ReplaceTextInFiles](#T-MFR-Operations-Constants-OperationType-ReplaceTextInFiles 'MFR.Operations.Constants.OperationType.ReplaceTextInFiles')
operation type.

<a name='P-MFR-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-AndReplaceItWith-System-String-'></a>
### AndReplaceItWith(replaceWith) `method`

##### Summary

Initializes the value that text matching the pattern specified by
the
[ToFindWhat](#M-MFR-IMatchExpressionFactory-ToFindWhat 'MFR.IMatchExpressionFactory.ToFindWhat')
method will be replaced with.



Whitespace or the empty string is only allowed for the Replace in
Files operation type.

##### Returns

Reference to an instance of an object that implements the
[IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression')
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
[IMatchExpression](#T-MFR-IMatchExpression 'MFR.IMatchExpression')
interface as a result.



It is required to provide a non-blank, non-whitespace value for
`replaceWith` except for the Replace Text in Files operation.

<a name='M-MFR-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-ForTextValue-System-String-'></a>
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
[AndAttachConfiguration](#M-MFR-IConfigurationComposedObject-AndAttachConfiguration 'MFR.IConfigurationComposedObject.AndAttachConfiguration')
method must be invoked; otherwise, a
[ConfigurationNotAttachedException](#T-MFR-Settings-Configuration-Exceptions-ConfigurationNotAttachedException 'MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException')
will be thrown. It is incumbent upon invokers of this method to
first weed out any possible elements of the source value set that
may make the `value` parameter get passed a blank string.

<a name='M-MFR-Expressions-Matches-Factories-ReplaceTextInFileMatchExpressionFactory-ToFindWhat-System-String-'></a>
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
[ForTextValue](#M-MFR-IMatchExpressionFactory-ForTextValue 'MFR.IMatchExpressionFactory.ForTextValue')
method.



It is incumbent upon invokers of this method to first weed out any
possible elements of the source value set that may make the
`findWhat` parameter get passed a blank string.

<a name='T-MFR-Expressions-Matches-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Expressions.Matches.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Expressions-Matches-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Expressions-Matches-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Expressions-Matches-Factories-SolutionFolderNameReplacementMatchExpressionFactory'></a>
## SolutionFolderNameReplacementMatchExpressionFactory `type`

##### Namespace

MFR.Expressions.Matches.Factories

##### Summary

Creates new instances of objects that implement the
[IMatchExpression](#T-MFR-Expressions-Matches-Interfaces-IMatchExpression 'MFR.Expressions.Matches.Interfaces.IMatchExpression')
interface that correspond to the
[RenameSolutionFolders](#T-MFR-Operations-Constants-OperationType-RenameSolutionFolders 'MFR.Operations.Constants.OperationType.RenameSolutionFolders')
operation type.

<a name='P-MFR-Expressions-Matches-Factories-SolutionFolderNameReplacementMatchExpressionFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.
