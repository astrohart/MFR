<a name='assembly'></a>
# MFR.TextValues.Retrievers.Factories

## Contents

- [GetFilenameTextValueRetriever](#T-MFR-TextValues-Retrievers-Factories-GetFilenameTextValueRetriever 'MFR.TextValues.Retrievers.Factories.GetFilenameTextValueRetriever')
  - [SoleInstance()](#M-MFR-TextValues-Retrievers-Factories-GetFilenameTextValueRetriever-SoleInstance 'MFR.TextValues.Retrievers.Factories.GetFilenameTextValueRetriever.SoleInstance')
- [GetFolderTextValueRetriever](#T-MFR-TextValues-Retrievers-Factories-GetFolderTextValueRetriever 'MFR.TextValues.Retrievers.Factories.GetFolderTextValueRetriever')
  - [SoleInstance()](#M-MFR-TextValues-Retrievers-Factories-GetFolderTextValueRetriever-SoleInstance 'MFR.TextValues.Retrievers.Factories.GetFolderTextValueRetriever.SoleInstance')
- [GetTextInFileTextValueRetriever](#T-MFR-TextValues-Retrievers-Factories-GetTextInFileTextValueRetriever 'MFR.TextValues.Retrievers.Factories.GetTextInFileTextValueRetriever')
  - [SoleInstance()](#M-MFR-TextValues-Retrievers-Factories-GetTextInFileTextValueRetriever-SoleInstance 'MFR.TextValues.Retrievers.Factories.GetTextInFileTextValueRetriever.SoleInstance')
- [GetTextValueRetriever](#T-MFR-TextValues-Retrievers-Factories-GetTextValueRetriever 'MFR.TextValues.Retrievers.Factories.GetTextValueRetriever')
  - [For(type)](#M-MFR-TextValues-Retrievers-Factories-GetTextValueRetriever-For-MFR-Operations-Constants-OperationType- 'MFR.TextValues.Retrievers.Factories.GetTextValueRetriever.For(MFR.Operations.Constants.OperationType)')
- [Resources](#T-MFR-TextValues-Retrievers-Factories-Properties-Resources 'MFR.TextValues.Retrievers.Factories.Properties.Resources')
  - [Culture](#P-MFR-TextValues-Retrievers-Factories-Properties-Resources-Culture 'MFR.TextValues.Retrievers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-TextValues-Retrievers-Factories-Properties-Resources-ResourceManager 'MFR.TextValues.Retrievers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-TextValues-Retrievers-Factories-GetFilenameTextValueRetriever'></a>
## GetFilenameTextValueRetriever `type`

##### Namespace

MFR.TextValues.Retrievers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[ITextValueRetriever](#T-MFR-TextValues-Retrievers-Interfaces-ITextValueRetriever 'MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever')
interface.

<a name='M-MFR-TextValues-Retrievers-Factories-GetFilenameTextValueRetriever-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[ITextValueRetriever](#T-MFR-TextValues-Retrievers-Interfaces-ITextValueRetriever 'MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[ITextValueRetriever](#T-MFR-TextValues-Retrievers-Interfaces-ITextValueRetriever 'MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-TextValues-Retrievers-Factories-GetFolderTextValueRetriever'></a>
## GetFolderTextValueRetriever `type`

##### Namespace

MFR.TextValues.Retrievers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[ITextValueRetriever](#T-MFR-TextValues-Retrievers-Interfaces-ITextValueRetriever 'MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever')
interface for obtaining the pathname of a folder.

<a name='M-MFR-TextValues-Retrievers-Factories-GetFolderTextValueRetriever-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[ITextValueRetriever](#T-MFR-TextValues-Retrievers-Interfaces-ITextValueRetriever 'MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[ITextValueRetriever](#T-MFR-TextValues-Retrievers-Interfaces-ITextValueRetriever 'MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever')
interface for obtaining the pathname of a folder.

##### Parameters

This method has no parameters.

<a name='T-MFR-TextValues-Retrievers-Factories-GetTextInFileTextValueRetriever'></a>
## GetTextInFileTextValueRetriever `type`

##### Namespace

MFR.TextValues.Retrievers.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[ITextValueRetriever](#T-MFR-TextValues-Retrievers-Interfaces-ITextValueRetriever 'MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever')
interface.

<a name='M-MFR-TextValues-Retrievers-Factories-GetTextInFileTextValueRetriever-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[ITextValueRetriever](#T-MFR-TextValues-Retrievers-Interfaces-ITextValueRetriever 'MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[ITextValueRetriever](#T-MFR-TextValues-Retrievers-Interfaces-ITextValueRetriever 'MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever')
interface for retrieving the text content from a file.

##### Parameters

This method has no parameters.

<a name='T-MFR-TextValues-Retrievers-Factories-GetTextValueRetriever'></a>
## GetTextValueRetriever `type`

##### Namespace

MFR.TextValues.Retrievers.Factories

##### Summary

Creates instances of objects that implement the
[ITextValueRetriever](#T-MFR-FileSystem-Retrievers-ITextValueRetriever 'MFR.FileSystem.Retrievers.ITextValueRetriever')
interface.

##### Remarks

Objects that implement the
[ITextValueRetriever](#T-MFR-TextValues-Retrievers-Interfaces-ITextValueRetriever 'MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever')
interface examine pathnames of files and folders, or the contents of text
files, for content in which the search term is to be searched for in a
find-and-replace operation.

<a name='M-MFR-TextValues-Retrievers-Factories-GetTextValueRetriever-For-MFR-Operations-Constants-OperationType-'></a>
### For(type) `method`

##### Summary

Creates a new instance of an object that implements the
[ITextValueRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-ITextValueRetriever 'MFR.FileSystem.Retrievers.Interfaces.ITextValueRetriever')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ITextValueRetriever](#T-MFR-FileSystem-Retrievers-Interfaces-ITextValueRetriever 'MFR.FileSystem.Retrievers.Interfaces.ITextValueRetriever')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.Operations.Constants.OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') | One of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values
that specifies which operation is currently being performed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the operation type specified by the
`type`
parameter is not one of the supported values. |

##### Remarks

Objects that implement the
[ITextValueRetriever](#T-MFR-TextValues-Retrievers-Interfaces-ITextValueRetriever 'MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever')
interface examine pathnames of files and folders, or the contents of text
files, for content in which the search term is to be searched for in a
find-and-replace operation.

<a name='T-MFR-TextValues-Retrievers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.TextValues.Retrievers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-TextValues-Retrievers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-TextValues-Retrievers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
