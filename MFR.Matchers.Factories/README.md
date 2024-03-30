<a name='assembly'></a>
# MFR.Matchers.Factories

## Contents

- [GetMatchCaseAndExactWordFolderNameStringMatcher](#T-MFR-Matchers-Factories-GetMatchCaseAndExactWordFolderNameStringMatcher 'MFR.Matchers.Factories.GetMatchCaseAndExactWordFolderNameStringMatcher')
  - [SoleInstance()](#M-MFR-Matchers-Factories-GetMatchCaseAndExactWordFolderNameStringMatcher-SoleInstance 'MFR.Matchers.Factories.GetMatchCaseAndExactWordFolderNameStringMatcher.SoleInstance')
- [GetMatchCaseOnlyFolderNameStringMatcher](#T-MFR-Matchers-Factories-GetMatchCaseOnlyFolderNameStringMatcher 'MFR.Matchers.Factories.GetMatchCaseOnlyFolderNameStringMatcher')
  - [SoleInstance()](#M-MFR-Matchers-Factories-GetMatchCaseOnlyFolderNameStringMatcher-SoleInstance 'MFR.Matchers.Factories.GetMatchCaseOnlyFolderNameStringMatcher.SoleInstance')
- [GetMatchExactWordOnlyFolderNameStringMatcher](#T-MFR-Matchers-Factories-GetMatchExactWordOnlyFolderNameStringMatcher 'MFR.Matchers.Factories.GetMatchExactWordOnlyFolderNameStringMatcher')
  - [SoleInstance()](#M-MFR-Matchers-Factories-GetMatchExactWordOnlyFolderNameStringMatcher-SoleInstance 'MFR.Matchers.Factories.GetMatchExactWordOnlyFolderNameStringMatcher.SoleInstance')
- [GetNeitherMatchCaseNorExactWordFolderNameStringMatcher](#T-MFR-Matchers-Factories-GetNeitherMatchCaseNorExactWordFolderNameStringMatcher 'MFR.Matchers.Factories.GetNeitherMatchCaseNorExactWordFolderNameStringMatcher')
  - [SoleInstance()](#M-MFR-Matchers-Factories-GetNeitherMatchCaseNorExactWordFolderNameStringMatcher-SoleInstance 'MFR.Matchers.Factories.GetNeitherMatchCaseNorExactWordFolderNameStringMatcher.SoleInstance')
- [GetRenameFilesInFolderStringMatcherFactory](#T-MFR-Matchers-Factories-GetRenameFilesInFolderStringMatcherFactory 'MFR.Matchers.Factories.GetRenameFilesInFolderStringMatcherFactory')
  - [SoleInstance()](#M-MFR-Matchers-Factories-GetRenameFilesInFolderStringMatcherFactory-SoleInstance 'MFR.Matchers.Factories.GetRenameFilesInFolderStringMatcherFactory.SoleInstance')
- [GetRenameSolutionFoldersStringMatcherFactory](#T-MFR-Matchers-Factories-GetRenameSolutionFoldersStringMatcherFactory 'MFR.Matchers.Factories.GetRenameSolutionFoldersStringMatcherFactory')
  - [SoleInstance()](#M-MFR-Matchers-Factories-GetRenameSolutionFoldersStringMatcherFactory-SoleInstance 'MFR.Matchers.Factories.GetRenameSolutionFoldersStringMatcherFactory.SoleInstance')
- [GetRenameSubFoldersStringMatcherFactory](#T-MFR-Matchers-Factories-GetRenameSubFoldersStringMatcherFactory 'MFR.Matchers.Factories.GetRenameSubFoldersStringMatcherFactory')
  - [SoleInstance()](#M-MFR-Matchers-Factories-GetRenameSubFoldersStringMatcherFactory-SoleInstance 'MFR.Matchers.Factories.GetRenameSubFoldersStringMatcherFactory.SoleInstance')
- [GetReplaceTextInFilesStringMatcherFactory](#T-MFR-Matchers-Factories-GetReplaceTextInFilesStringMatcherFactory 'MFR.Matchers.Factories.GetReplaceTextInFilesStringMatcherFactory')
  - [SoleInstance()](#M-MFR-Matchers-Factories-GetReplaceTextInFilesStringMatcherFactory-SoleInstance 'MFR.Matchers.Factories.GetReplaceTextInFilesStringMatcherFactory.SoleInstance')
- [GetStringMatcherFactory](#T-MFR-Matchers-Factories-GetStringMatcherFactory 'MFR.Matchers.Factories.GetStringMatcherFactory')
  - [For(type)](#M-MFR-Matchers-Factories-GetStringMatcherFactory-For-MFR-Operations-Constants-OperationType- 'MFR.Matchers.Factories.GetStringMatcherFactory.For(MFR.Operations.Constants.OperationType)')
- [RenameFilesInFolderStringMatcherFactory](#T-MFR-Matchers-Factories-RenameFilesInFolderStringMatcherFactory 'MFR.Matchers.Factories.RenameFilesInFolderStringMatcherFactory')
  - [#ctor()](#M-MFR-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-#ctor 'MFR.Matchers.Factories.RenameFilesInFolderStringMatcherFactory.#ctor')
  - [Instance](#P-MFR-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-Instance 'MFR.Matchers.Factories.RenameFilesInFolderStringMatcherFactory.Instance')
  - [OperationType](#P-MFR-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-OperationType 'MFR.Matchers.Factories.RenameFilesInFolderStringMatcherFactory.OperationType')
  - [#cctor()](#M-MFR-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-#cctor 'MFR.Matchers.Factories.RenameFilesInFolderStringMatcherFactory.#cctor')
  - [AndTextMatchingConfiguration(matchingConfig)](#M-MFR-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-AndTextMatchingConfiguration-MFR-Settings-Configuration-Constants-TextMatchingConfiguration- 'MFR.Matchers.Factories.RenameFilesInFolderStringMatcherFactory.AndTextMatchingConfiguration(MFR.Settings.Configuration.Constants.TextMatchingConfiguration)')
- [RenameSolutionFoldersStringMatcherFactory](#T-MFR-Matchers-Factories-RenameSolutionFoldersStringMatcherFactory 'MFR.Matchers.Factories.RenameSolutionFoldersStringMatcherFactory')
  - [#ctor()](#M-MFR-Matchers-Factories-RenameSolutionFoldersStringMatcherFactory-#ctor 'MFR.Matchers.Factories.RenameSolutionFoldersStringMatcherFactory.#ctor')
  - [Instance](#P-MFR-Matchers-Factories-RenameSolutionFoldersStringMatcherFactory-Instance 'MFR.Matchers.Factories.RenameSolutionFoldersStringMatcherFactory.Instance')
  - [OperationType](#P-MFR-Matchers-Factories-RenameSolutionFoldersStringMatcherFactory-OperationType 'MFR.Matchers.Factories.RenameSolutionFoldersStringMatcherFactory.OperationType')
  - [#cctor()](#M-MFR-Matchers-Factories-RenameSolutionFoldersStringMatcherFactory-#cctor 'MFR.Matchers.Factories.RenameSolutionFoldersStringMatcherFactory.#cctor')
  - [AndTextMatchingConfiguration(matchingConfig)](#M-MFR-Matchers-Factories-RenameSolutionFoldersStringMatcherFactory-AndTextMatchingConfiguration-MFR-Settings-Configuration-Constants-TextMatchingConfiguration- 'MFR.Matchers.Factories.RenameSolutionFoldersStringMatcherFactory.AndTextMatchingConfiguration(MFR.Settings.Configuration.Constants.TextMatchingConfiguration)')
- [RenameSubFoldersStringMatcherFactory](#T-MFR-Matchers-Factories-RenameSubFoldersStringMatcherFactory 'MFR.Matchers.Factories.RenameSubFoldersStringMatcherFactory')
  - [#ctor()](#M-MFR-Matchers-Factories-RenameSubFoldersStringMatcherFactory-#ctor 'MFR.Matchers.Factories.RenameSubFoldersStringMatcherFactory.#ctor')
  - [Instance](#P-MFR-Matchers-Factories-RenameSubFoldersStringMatcherFactory-Instance 'MFR.Matchers.Factories.RenameSubFoldersStringMatcherFactory.Instance')
  - [OperationType](#P-MFR-Matchers-Factories-RenameSubFoldersStringMatcherFactory-OperationType 'MFR.Matchers.Factories.RenameSubFoldersStringMatcherFactory.OperationType')
  - [#cctor()](#M-MFR-Matchers-Factories-RenameSubFoldersStringMatcherFactory-#cctor 'MFR.Matchers.Factories.RenameSubFoldersStringMatcherFactory.#cctor')
  - [AndTextMatchingConfiguration(matchingConfig)](#M-MFR-Matchers-Factories-RenameSubFoldersStringMatcherFactory-AndTextMatchingConfiguration-MFR-Settings-Configuration-Constants-TextMatchingConfiguration- 'MFR.Matchers.Factories.RenameSubFoldersStringMatcherFactory.AndTextMatchingConfiguration(MFR.Settings.Configuration.Constants.TextMatchingConfiguration)')
- [ReplaceTextInFilesStringMatcherFactory](#T-MFR-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory 'MFR.Matchers.Factories.ReplaceTextInFilesStringMatcherFactory')
  - [#ctor()](#M-MFR-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-#ctor 'MFR.Matchers.Factories.ReplaceTextInFilesStringMatcherFactory.#ctor')
  - [Instance](#P-MFR-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-Instance 'MFR.Matchers.Factories.ReplaceTextInFilesStringMatcherFactory.Instance')
  - [OperationType](#P-MFR-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-OperationType 'MFR.Matchers.Factories.ReplaceTextInFilesStringMatcherFactory.OperationType')
  - [#cctor()](#M-MFR-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-#cctor 'MFR.Matchers.Factories.ReplaceTextInFilesStringMatcherFactory.#cctor')
  - [AndTextMatchingConfiguration(matchingConfig)](#M-MFR-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-AndTextMatchingConfiguration-MFR-Settings-Configuration-Constants-TextMatchingConfiguration- 'MFR.Matchers.Factories.ReplaceTextInFilesStringMatcherFactory.AndTextMatchingConfiguration(MFR.Settings.Configuration.Constants.TextMatchingConfiguration)')
- [Resources](#T-MFR-Matchers-Factories-Properties-Resources 'MFR.Matchers.Factories.Properties.Resources')
  - [Culture](#P-MFR-Matchers-Factories-Properties-Resources-Culture 'MFR.Matchers.Factories.Properties.Resources.Culture')
  - [Error_NoStringMatcherDefinedForOperation](#P-MFR-Matchers-Factories-Properties-Resources-Error_NoStringMatcherDefinedForOperation 'MFR.Matchers.Factories.Properties.Resources.Error_NoStringMatcherDefinedForOperation')
  - [ResourceManager](#P-MFR-Matchers-Factories-Properties-Resources-ResourceManager 'MFR.Matchers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Matchers-Factories-GetMatchCaseAndExactWordFolderNameStringMatcher'></a>
## GetMatchCaseAndExactWordFolderNameStringMatcher `type`

##### Namespace

MFR.Matchers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface that matches
BOTH on character casing AND on the exact string that is supplied for the
text-replacement specification provided by the user in the box
in the user interface.



This the Mass File Renamer analogy of the user placing check marks in both
the and the checkbox in, say, the
, dialog box in most text-editing applications.

<a name='M-MFR-Matchers-Factories-GetMatchCaseAndExactWordFolderNameStringMatcher-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface, and returns
a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface that matches
BOTH on character casing AND on the exact string that is supplied for the
text-replacement specification provided by the user in the box
in the user interface.



This the Mass File Renamer analogy of the user placing check marks in both
the and the checkbox in, say, the
, dialog box in most text-editing applications.

##### Parameters

This method has no parameters.

<a name='T-MFR-Matchers-Factories-GetMatchCaseOnlyFolderNameStringMatcher'></a>
## GetMatchCaseOnlyFolderNameStringMatcher `type`

##### Namespace

MFR.Matchers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface that matches
text expressions with a case-sensitive search.



This object should be used when the check box is selected by
the user when doing the operations of renaming solution folders or sub folders
of a Solution.

<a name='M-MFR-Matchers-Factories-GetMatchCaseOnlyFolderNameStringMatcher-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface, and returns
a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface that matches
text expressions with a case-sensitive search.



This object should be used when the check box is selected by
the user when doing the operations of renaming solution folders or sub folders
of a Solution.

##### Parameters

This method has no parameters.

<a name='T-MFR-Matchers-Factories-GetMatchExactWordOnlyFolderNameStringMatcher'></a>
## GetMatchExactWordOnlyFolderNameStringMatcher `type`

##### Namespace

MFR.Matchers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface that matches
the exact string that is supplied for the text-replacement specification
provided by the user in the box in the user interface.



This the Mass File Renamer analogy of the `Match Whole Word` checkbox
in, say, the , dialog box in most text-editing
applications.

<a name='M-MFR-Matchers-Factories-GetMatchExactWordOnlyFolderNameStringMatcher-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface, and returns
a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface that matches
the exact string that is supplied for the text-replacement specification
provided by the user in the box in the user interface.



This the Mass File Renamer analogy of the `Match Whole Word` checkbox
in, say, the , dialog box in most text-editing
applications.

##### Parameters

This method has no parameters.

<a name='T-MFR-Matchers-Factories-GetNeitherMatchCaseNorExactWordFolderNameStringMatcher'></a>
## GetNeitherMatchCaseNorExactWordFolderNameStringMatcher `type`

##### Namespace

MFR.Matchers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface that matches
NEITHER on character casing NOR on the exact string that is supplied for the
text-replacement specification provided by the user in the box
in the user interface.



This the Mass File Renamer analogy of the user clearing check marks in both
the and the checkbox in, say, the
, dialog box in most text-editing applications.

<a name='M-MFR-Matchers-Factories-GetNeitherMatchCaseNorExactWordFolderNameStringMatcher-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface, and returns
a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface that matches
NEITHER on character casing NOR on the exact string that is supplied for the
text-replacement specification provided by the user in the box
in the user interface.



This the Mass File Renamer analogy of the user clearing check marks in both
the and the checkbox in, say, the
, dialog box in most text-editing applications.

##### Parameters

This method has no parameters.

<a name='T-MFR-Matchers-Factories-GetRenameFilesInFolderStringMatcherFactory'></a>
## GetRenameFilesInFolderStringMatcherFactory `type`

##### Namespace

MFR.Matchers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface that creates string matcher objects to be used in order to assist the
application with renaming files in a folder that match a specific
text-replacement pattern.

<a name='M-MFR-Matchers-Factories-GetRenameFilesInFolderStringMatcherFactory-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface that creates string matcher objects to be used in order to assist the
application with renaming files in a folder that match a specific
text-replacement pattern.

##### Parameters

This method has no parameters.

<a name='T-MFR-Matchers-Factories-GetRenameSolutionFoldersStringMatcherFactory'></a>
## GetRenameSolutionFoldersStringMatcherFactory `type`

##### Namespace

MFR.Matchers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface that creates string matcher objects used in order to assist the
application with carrying out the operation of renaming folders containing
Visual Studio Solution (`*.sln`) file(s)  in a directory tree according to
a text-replacement pattern that is specified by the user.

<a name='M-MFR-Matchers-Factories-GetRenameSolutionFoldersStringMatcherFactory-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface that creates string matcher objects used in order to assist the
application with carrying out the operation of renaming folders containing
Visual Studio Solution (`*.sln`) file(s)  in a directory tree according to
a text-replacement pattern that is specified by the user.

##### Parameters

This method has no parameters.

<a name='T-MFR-Matchers-Factories-GetRenameSubFoldersStringMatcherFactory'></a>
## GetRenameSubFoldersStringMatcherFactory `type`

##### Namespace

MFR.Matchers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface that creates string matcher objects used in order to assist the
application with carrying out the operation of renaming folders in a directory
tree according to a text-replacement pattern that is specified by the user.

<a name='M-MFR-Matchers-Factories-GetRenameSubFoldersStringMatcherFactory-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface that creates string matcher objects used in order to assist the
application with carrying out the operation of renaming folders in a directory
tree according to a text-replacement pattern that is specified by the user.

##### Parameters

This method has no parameters.

<a name='T-MFR-Matchers-Factories-GetReplaceTextInFilesStringMatcherFactory'></a>
## GetReplaceTextInFilesStringMatcherFactory `type`

##### Namespace

MFR.Matchers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface that creates string matcher objects used in order to assist the
application with replacing text in the files in a folder according to a
text-replacement pattern that is specified by the user.

<a name='M-MFR-Matchers-Factories-GetReplaceTextInFilesStringMatcherFactory-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface that creates string matcher objects used in order to assist the
application with replacing text in the files in a folder according to a
text-replacement pattern that is specified by the user.

##### Parameters

This method has no parameters.

<a name='T-MFR-Matchers-Factories-GetStringMatcherFactory'></a>
## GetStringMatcherFactory `type`

##### Namespace

MFR.Matchers.Factories

##### Summary

Creates instances of objects that implement the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface.

<a name='M-MFR-Matchers-Factories-GetStringMatcherFactory-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates a new instance of an object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface and
returns a reference to it, for the given
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
value.

##### Returns

Reference to an instance of an object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface that corresponds to the specified type of operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | (Required.) One of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed. |

<a name='T-MFR-Matchers-Factories-RenameFilesInFolderStringMatcherFactory'></a>
## RenameFilesInFolderStringMatcherFactory `type`

##### Namespace

MFR.Matchers.Factories

##### Summary

Factory object that creates string matchers, specific to the Rename
Files in Folder type of operation, for the various combinations of Match
Case and Match Exact Word.

<a name='M-MFR-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface that creates string matcher objects to be used in order to assist the
application with renaming files in a folder that match a specific
text-replacement pattern.

<a name='P-MFR-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-RenameFilesInFolderStringMatcherFactory-AndTextMatchingConfiguration-MFR-Settings-Configuration-Constants-TextMatchingConfiguration-'></a>
### AndTextMatchingConfiguration(matchingConfig) `method`

##### Summary

Creates a new instance of an object that implements the
[IStringMatcher](#T-MFR-IStringMatcher 'MFR.IStringMatcher')
interface and
returns a reference to it for the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value
that is specified by the `matchingConfig` parameter.

##### Returns

Reference to an instance of an object that implements the
[IStringMatcher](#T-MFR-IStringMatcher 'MFR.IStringMatcher')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| matchingConfig | [MFR.Settings.Configuration.Constants.TextMatchingConfiguration](#T-MFR-Settings-Configuration-Constants-TextMatchingConfiguration 'MFR.Settings.Configuration.Constants.TextMatchingConfiguration') | (Required.) One of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values
that specifies which type of matching is being done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | Thrown if the value passed in the `matchingConfig`
is not one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if a string matcher object is not defined for the Rename
Files in Folder operation type that supports the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value
passed in the `matchingConfig` parameter. |

<a name='T-MFR-Matchers-Factories-RenameSolutionFoldersStringMatcherFactory'></a>
## RenameSolutionFoldersStringMatcherFactory `type`

##### Namespace

MFR.Matchers.Factories

##### Summary

Factory object that creates string matchers, specific to the Rename
Sub Folders type of operation, for the various combinations of
Match Case and Match Exact Word.

<a name='M-MFR-Matchers-Factories-RenameSolutionFoldersStringMatcherFactory-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-Factories-RenameSolutionFoldersStringMatcherFactory-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface that creates string matcher objects used in order to assist the
application with carrying out the operation of renaming folders containing
Visual Studio Solution (`*.sln`) file(s)  in a directory tree according to
a text-replacement pattern that is specified by the user.

<a name='P-MFR-Matchers-Factories-RenameSolutionFoldersStringMatcherFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-Factories-RenameSolutionFoldersStringMatcherFactory-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-RenameSolutionFoldersStringMatcherFactory-AndTextMatchingConfiguration-MFR-Settings-Configuration-Constants-TextMatchingConfiguration-'></a>
### AndTextMatchingConfiguration(matchingConfig) `method`

##### Summary

Creates a new instance of an object that implements the
[IStringMatcher](#T-MFR-IStringMatcher 'MFR.IStringMatcher')
interface and
returns a reference to it for the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value that
is specified by the `matchingConfig` parameter.

##### Returns

Reference to an instance of an object that implements the
[IStringMatcher](#T-MFR-IStringMatcher 'MFR.IStringMatcher')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| matchingConfig | [MFR.Settings.Configuration.Constants.TextMatchingConfiguration](#T-MFR-Settings-Configuration-Constants-TextMatchingConfiguration 'MFR.Settings.Configuration.Constants.TextMatchingConfiguration') | (Required.) One of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
specifies which type of matching is being done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | Thrown if the value passed in the `matchingConfig`
is not one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if a string matcher object is not defined for the Rename
Files in Folder operation type that supports the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value
passed in the `matchingConfig` parameter. |

<a name='T-MFR-Matchers-Factories-RenameSubFoldersStringMatcherFactory'></a>
## RenameSubFoldersStringMatcherFactory `type`

##### Namespace

MFR.Matchers.Factories

##### Summary

Factory object that creates string matchers, specific to the Rename
Sub Folders type of operation, for the various combinations of
Match Case and Match Exact Word.

<a name='M-MFR-Matchers-Factories-RenameSubFoldersStringMatcherFactory-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-Factories-RenameSubFoldersStringMatcherFactory-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface that creates string matcher objects used in order to assist the
application with carrying out the operation of renaming folders in a directory
tree according to a text-replacement pattern that is specified by the user.

<a name='P-MFR-Matchers-Factories-RenameSubFoldersStringMatcherFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-Factories-RenameSubFoldersStringMatcherFactory-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-RenameSubFoldersStringMatcherFactory-AndTextMatchingConfiguration-MFR-Settings-Configuration-Constants-TextMatchingConfiguration-'></a>
### AndTextMatchingConfiguration(matchingConfig) `method`

##### Summary

Creates a new instance of an object that implements the
[IStringMatcher](#T-MFR-IStringMatcher 'MFR.IStringMatcher')
interface and
returns a reference to it for the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value that
is specified by the `matchingConfig` parameter.

##### Returns

Reference to an instance of an object that implements the
[IStringMatcher](#T-MFR-IStringMatcher 'MFR.IStringMatcher')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| matchingConfig | [MFR.Settings.Configuration.Constants.TextMatchingConfiguration](#T-MFR-Settings-Configuration-Constants-TextMatchingConfiguration 'MFR.Settings.Configuration.Constants.TextMatchingConfiguration') | (Required.) One of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
specifies which type of matching is being done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | Thrown if the value passed in the `matchingConfig`
is not one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if a string matcher object is not defined for the Rename
Files in Folder operation type that supports the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value
passed in the `matchingConfig` parameter. |

<a name='T-MFR-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory'></a>
## ReplaceTextInFilesStringMatcherFactory `type`

##### Namespace

MFR.Matchers.Factories

##### Summary

Factory object that creates string matchers, specific to the Rename
Sub Folders type of operation, for the various combinations of
Match Case and Match Exact Word.

<a name='M-MFR-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IStringMatcherFactory](#T-MFR-Matchers-Factories-Interfaces-IStringMatcherFactory 'MFR.Matchers.Factories.Interfaces.IStringMatcherFactory')
interface that creates string matcher objects used in order to assist the
application with replacing text in the files in a folder according to a
text-replacement pattern that is specified by the user.

<a name='P-MFR-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Matchers-Factories-ReplaceTextInFilesStringMatcherFactory-AndTextMatchingConfiguration-MFR-Settings-Configuration-Constants-TextMatchingConfiguration-'></a>
### AndTextMatchingConfiguration(matchingConfig) `method`

##### Summary

Creates a new instance of an object that implements the
[IStringMatcher](#T-MFR-IStringMatcher 'MFR.IStringMatcher')
interface and
returns a reference to it for the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value that
is specified by the `matchingConfig` parameter.

##### Returns

Reference to an instance of an object that implements the
[IStringMatcher](#T-MFR-IStringMatcher 'MFR.IStringMatcher')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| matchingConfig | [MFR.Settings.Configuration.Constants.TextMatchingConfiguration](#T-MFR-Settings-Configuration-Constants-TextMatchingConfiguration 'MFR.Settings.Configuration.Constants.TextMatchingConfiguration') | (Required.) One of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values that
specifies which type of matching is being done. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.InvalidEnumArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.InvalidEnumArgumentException 'System.ComponentModel.InvalidEnumArgumentException') | Thrown if the value passed in the `matchingConfig`
is not one of the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
values. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if a string matcher object is not defined for the Rename
Files in Folder operation type that supports the
[TextMatchingConfiguration](#T-MFR-TextMatchingConfiguration 'MFR.TextMatchingConfiguration')
value
passed in the `matchingConfig` parameter. |

<a name='T-MFR-Matchers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Matchers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Matchers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Matchers-Factories-Properties-Resources-Error_NoStringMatcherDefinedForOperation'></a>
### Error_NoStringMatcherDefinedForOperation `property`

##### Summary

Looks up a localized string similar to There are no string matcher objects defined for the '{0}' operation type that support the '{1}' matching config..

<a name='P-MFR-Matchers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
