<a name='assembly'></a>
# MFR.Engines.Matching.Factories

## Contents

- [GetTextExpressionMatchingEngine](#T-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine 'MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine')
  - [For(type)](#M-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine-For-MFR-Operations-Constants-OperationType- 'MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For(MFR.Operations.Constants.OperationType)')
- [MakeNewFileNameMatchingEngine](#T-MFR-Engines-Matching-Factories-MakeNewFileNameMatchingEngine 'MFR.Engines.Matching.Factories.MakeNewFileNameMatchingEngine')
  - [FromScratch()](#M-MFR-Engines-Matching-Factories-MakeNewFileNameMatchingEngine-FromScratch 'MFR.Engines.Matching.Factories.MakeNewFileNameMatchingEngine.FromScratch')
- [MakeNewFolderNameMatchingEngine](#T-MFR-Engines-Matching-Factories-MakeNewFolderNameMatchingEngine 'MFR.Engines.Matching.Factories.MakeNewFolderNameMatchingEngine')
  - [FromScratch()](#M-MFR-Engines-Matching-Factories-MakeNewFolderNameMatchingEngine-FromScratch 'MFR.Engines.Matching.Factories.MakeNewFolderNameMatchingEngine.FromScratch')
- [MakeNewSolutionFolderNameMatchingEngine](#T-MFR-Engines-Matching-Factories-MakeNewSolutionFolderNameMatchingEngine 'MFR.Engines.Matching.Factories.MakeNewSolutionFolderNameMatchingEngine')
  - [FromScratch()](#M-MFR-Engines-Matching-Factories-MakeNewSolutionFolderNameMatchingEngine-FromScratch 'MFR.Engines.Matching.Factories.MakeNewSolutionFolderNameMatchingEngine.FromScratch')
- [MakeNewTextInFilesMatchingEngine](#T-MFR-Engines-Matching-Factories-MakeNewTextInFilesMatchingEngine 'MFR.Engines.Matching.Factories.MakeNewTextInFilesMatchingEngine')
  - [FromScratch()](#M-MFR-Engines-Matching-Factories-MakeNewTextInFilesMatchingEngine-FromScratch 'MFR.Engines.Matching.Factories.MakeNewTextInFilesMatchingEngine.FromScratch')
- [Resources](#T-MFR-Engines-Matching-Factories-Properties-Resources 'MFR.Engines.Matching.Factories.Properties.Resources')
  - [Culture](#P-MFR-Engines-Matching-Factories-Properties-Resources-Culture 'MFR.Engines.Matching.Factories.Properties.Resources.Culture')
  - [Exception_OperationTypeNotSupported](#P-MFR-Engines-Matching-Factories-Properties-Resources-Exception_OperationTypeNotSupported 'MFR.Engines.Matching.Factories.Properties.Resources.Exception_OperationTypeNotSupported')
  - [ResourceManager](#P-MFR-Engines-Matching-Factories-Properties-Resources-ResourceManager 'MFR.Engines.Matching.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine'></a>
## GetTextExpressionMatchingEngine `type`

##### Namespace

MFR.Engines.Matching.Factories

##### Summary

Creates instances of objects that implement the
[ITextExpressionMatchingEngine](#T-MFR-ITextExpressionMatchingEngine 'MFR.ITextExpressionMatchingEngine')
interface and
returns references to them.

<a name='M-MFR-Engines-Matching-Factories-GetTextExpressionMatchingEngine-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates instances of objects that implement the
[ITextExpressionMatchingEngine](#T-MFR-ITextExpressionMatchingEngine 'MFR.ITextExpressionMatchingEngine')
interface
and returns references to them.

##### Returns

Reference to an instance of an object that
implements the
[ITextExpressionMatchingEngine](#T-MFR-ITextExpressionMatchingEngine 'MFR.ITextExpressionMatchingEngine')
interface
that can tell if data matches a value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
specifies the operation currently being performed. |

##### Remarks

After calling this method, callers must
then invoke the fluent
[WithConfiguration](#M-MFR-ITextExpressionMatchingEngine-WithConfiguration 'MFR.ITextExpressionMatchingEngine.WithConfiguration')
method on the result of this method in order to attach an object
that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface to the
new object instance.

<a name='T-MFR-Engines-Matching-Factories-MakeNewFileNameMatchingEngine'></a>
## MakeNewFileNameMatchingEngine `type`

##### Namespace

MFR.Engines.Matching.Factories

##### Summary

Creates new instances of objects that implement the
[ITextExpressionMatchingEngine](#T-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine')
interface that applies criteria to match file names against textual expressions.

<a name='M-MFR-Engines-Matching-Factories-MakeNewFileNameMatchingEngine-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[ITextExpressionMatchingEngine](#T-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ITextExpressionMatchingEngine](#T-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine')
interface that applies criteria to match file names against textual expressions.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-Matching-Factories-MakeNewFolderNameMatchingEngine'></a>
## MakeNewFolderNameMatchingEngine `type`

##### Namespace

MFR.Engines.Matching.Factories

##### Summary

Creates new instances of objects that implement the
[ITextExpressionMatchingEngine](#T-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine')
interface that searches for matches to textual-search criteria patterns and
regexes in the pathnames of folders, according to rules specified by
config settings.

<a name='M-MFR-Engines-Matching-Factories-MakeNewFolderNameMatchingEngine-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[ITextExpressionMatchingEngine](#T-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ITextExpressionMatchingEngine](#T-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine')
interface that searches for matches to textual-search criteria patterns and
regexes in the pathnames of folders, according to rules specified by
config settings.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-Matching-Factories-MakeNewSolutionFolderNameMatchingEngine'></a>
## MakeNewSolutionFolderNameMatchingEngine `type`

##### Namespace

MFR.Engines.Matching.Factories

##### Summary

Creates new instances of objects that implement the
[ITextExpressionMatchingEngine](#T-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine')
interface that searches for matches to textual-search criteria patterns and
regexes in the pathnames of folders that contain Visual Studio Solution (
`*.sln`) files, according to rules specified by config settings.

<a name='M-MFR-Engines-Matching-Factories-MakeNewSolutionFolderNameMatchingEngine-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[ITextExpressionMatchingEngine](#T-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ITextExpressionMatchingEngine](#T-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine')
interface that searches for matches to textual-search criteria patterns and
regexes in the pathnames of folders that contain Visual Studio Solution (
`*.sln`) files, according to rules specified by config settings.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-Matching-Factories-MakeNewTextInFilesMatchingEngine'></a>
## MakeNewTextInFilesMatchingEngine `type`

##### Namespace

MFR.Engines.Matching.Factories

##### Summary

Creates new instances of objects that implement the
[ITextExpressionMatchingEngine](#T-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine')
interface that matches text in a file that is to be (eventually) replaced.

<a name='M-MFR-Engines-Matching-Factories-MakeNewTextInFilesMatchingEngine-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[ITextExpressionMatchingEngine](#T-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ITextExpressionMatchingEngine](#T-MFR-Engines-Matching-Interfaces-ITextExpressionMatchingEngine 'MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine')
interface that matches text in a file that is to be (eventually) replaced.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-Matching-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Matching.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Matching-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Matching-Factories-Properties-Resources-Exception_OperationTypeNotSupported'></a>
### Exception_OperationTypeNotSupported `property`

##### Summary

Looks up a localized string similar to There is no text-matching engine available for the operation type '{0}'..

<a name='P-MFR-Engines-Matching-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
