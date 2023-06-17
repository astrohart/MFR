<a name='assembly'></a>
# MFR.Engines.Replacement.Factories

## Contents

- [GetTextReplacementEngine](#T-MFR-Engines-Replacement-Factories-GetTextReplacementEngine 'MFR.Engines.Replacement.Factories.GetTextReplacementEngine')
  - [For(type)](#M-MFR-Engines-Replacement-Factories-GetTextReplacementEngine-For-MFR-Operations-Constants-OperationType- 'MFR.Engines.Replacement.Factories.GetTextReplacementEngine.For(MFR.Operations.Constants.OperationType)')
<<<<<<< HEAD
=======
- [MakeNewFileNameReplacementEngine](#T-MFR-Engines-Replacement-Factories-MakeNewFileNameReplacementEngine 'MFR.Engines.Replacement.Factories.MakeNewFileNameReplacementEngine')
  - [FromScratch()](#M-MFR-Engines-Replacement-Factories-MakeNewFileNameReplacementEngine-FromScratch 'MFR.Engines.Replacement.Factories.MakeNewFileNameReplacementEngine.FromScratch')
- [MakeNewFolderNameReplacementEngine](#T-MFR-Engines-Replacement-Factories-MakeNewFolderNameReplacementEngine 'MFR.Engines.Replacement.Factories.MakeNewFolderNameReplacementEngine')
  - [FromScratch()](#M-MFR-Engines-Replacement-Factories-MakeNewFolderNameReplacementEngine-FromScratch 'MFR.Engines.Replacement.Factories.MakeNewFolderNameReplacementEngine.FromScratch')
- [MakeNewSolutionFolderNameReplacementEngine](#T-MFR-Engines-Replacement-Factories-MakeNewSolutionFolderNameReplacementEngine 'MFR.Engines.Replacement.Factories.MakeNewSolutionFolderNameReplacementEngine')
  - [FromScratch()](#M-MFR-Engines-Replacement-Factories-MakeNewSolutionFolderNameReplacementEngine-FromScratch 'MFR.Engines.Replacement.Factories.MakeNewSolutionFolderNameReplacementEngine.FromScratch')
- [MakeNewTextInFileReplacementEngine](#T-MFR-Engines-Replacement-Factories-MakeNewTextInFileReplacementEngine 'MFR.Engines.Replacement.Factories.MakeNewTextInFileReplacementEngine')
  - [FromScratch()](#M-MFR-Engines-Replacement-Factories-MakeNewTextInFileReplacementEngine-FromScratch 'MFR.Engines.Replacement.Factories.MakeNewTextInFileReplacementEngine.FromScratch')
>>>>>>> 5c56bab7c99bcfd0fdf8cba1e1d81c04714e5a3b
- [Resources](#T-MFR-Engines-Replacement-Factories-Properties-Resources 'MFR.Engines.Replacement.Factories.Properties.Resources')
  - [Culture](#P-MFR-Engines-Replacement-Factories-Properties-Resources-Culture 'MFR.Engines.Replacement.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Replacement-Factories-Properties-Resources-ResourceManager 'MFR.Engines.Replacement.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Replacement-Factories-GetTextReplacementEngine'></a>
## GetTextReplacementEngine `type`

##### Namespace

MFR.Engines.Replacement.Factories

##### Summary

Creates instances of objects that implement the
[ITextReplacementEngine](#T-MFR-ITextReplacementEngine 'MFR.ITextReplacementEngine')
interface.

<a name='M-MFR-Engines-Replacement-Factories-GetTextReplacementEngine-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Gets an instance of the object that implements the
[ITextReplacementEngine](#T-MFR-ITextReplacementEngine 'MFR.ITextReplacementEngine')
interface
corresponding to the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
specified.

##### Returns

Reference to the instance of the object that implements the
[ITextReplacementEngine](#T-MFR-ITextReplacementEngine 'MFR.ITextReplacementEngine')
interface
corresponding to the operation of the `type`
specified, or `null` if no object supports the specified
`type` of operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
specifies which operation is being performed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the `type` parameter specifies an
operation modality that is not supported. |

<<<<<<< HEAD
=======
<a name='T-MFR-Engines-Replacement-Factories-MakeNewFileNameReplacementEngine'></a>
## MakeNewFileNameReplacementEngine `type`

##### Namespace

MFR.Engines.Replacement.Factories

##### Summary

Creates new instances of objects that implement the
[ITextReplacementEngine](#T-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine')
interface that replaces the names of files with content identified by a
user-directed search.
them.

<a name='M-MFR-Engines-Replacement-Factories-MakeNewFileNameReplacementEngine-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[ITextReplacementEngine](#T-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ITextReplacementEngine](#T-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine')
interface that replaces the names of files with content identified by a
user-directed search.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-Replacement-Factories-MakeNewFolderNameReplacementEngine'></a>
## MakeNewFolderNameReplacementEngine `type`

##### Namespace

MFR.Engines.Replacement.Factories

##### Summary

Creates new instances of objects that implement the
[ITextReplacementEngine](#T-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine')
interface that renames folders according to the parameters supplied by the
user.
them.

<a name='M-MFR-Engines-Replacement-Factories-MakeNewFolderNameReplacementEngine-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[ITextReplacementEngine](#T-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ITextReplacementEngine](#T-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine')
interface that renames folders according to the parameters supplied by the
user.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-Replacement-Factories-MakeNewSolutionFolderNameReplacementEngine'></a>
## MakeNewSolutionFolderNameReplacementEngine `type`

##### Namespace

MFR.Engines.Replacement.Factories

##### Summary

Creates new instances of objects that implement the
[ITextReplacementEngine](#T-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine')
interface that renames solution folders according to the parameters supplied by
the user.
them.

<a name='M-MFR-Engines-Replacement-Factories-MakeNewSolutionFolderNameReplacementEngine-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[ITextReplacementEngine](#T-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ITextReplacementEngine](#T-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine')
interface that renames solution folders according to the parameters supplied by
the user.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-Replacement-Factories-MakeNewTextInFileReplacementEngine'></a>
## MakeNewTextInFileReplacementEngine `type`

##### Namespace

MFR.Engines.Replacement.Factories

##### Summary

Creates new instances of objects that implement the
[ITextReplacementEngine](#T-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine')
interface that replaces the text content of files with content identified by a
user-directed search.
them.

<a name='M-MFR-Engines-Replacement-Factories-MakeNewTextInFileReplacementEngine-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[ITextReplacementEngine](#T-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ITextReplacementEngine](#T-MFR-Engines-Replacement-Intefaces-ITextReplacementEngine 'MFR.Engines.Replacement.Intefaces.ITextReplacementEngine')
interface that replaces the text content of files with content identified by a
user-directed search.

##### Parameters

This method has no parameters.

>>>>>>> 5c56bab7c99bcfd0fdf8cba1e1d81c04714e5a3b
<a name='T-MFR-Engines-Replacement-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Replacement.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Replacement-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Replacement-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
