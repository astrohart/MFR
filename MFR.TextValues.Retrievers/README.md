<a name='assembly'></a>
# MFR.TextValues.Retrievers

## Contents

- [FileAndFolderTextValueRetrieverBase](#T-MFR-TextValues-Retrievers-FileAndFolderTextValueRetrieverBase 'MFR.TextValues.Retrievers.FileAndFolderTextValueRetrieverBase')
  - [GetTextValue(entry)](#M-MFR-TextValues-Retrievers-FileAndFolderTextValueRetrieverBase-GetTextValue-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.TextValues.Retrievers.FileAndFolderTextValueRetrieverBase.GetTextValue(MFR.FileSystem.Interfaces.IFileSystemEntry)')
- [FilenameTextValueRetriever](#T-MFR-TextValues-Retrievers-FilenameTextValueRetriever 'MFR.TextValues.Retrievers.FilenameTextValueRetriever')
  - [#ctor()](#M-MFR-TextValues-Retrievers-FilenameTextValueRetriever-#ctor 'MFR.TextValues.Retrievers.FilenameTextValueRetriever.#ctor')
  - [Instance](#P-MFR-TextValues-Retrievers-FilenameTextValueRetriever-Instance 'MFR.TextValues.Retrievers.FilenameTextValueRetriever.Instance')
  - [OperationType](#P-MFR-TextValues-Retrievers-FilenameTextValueRetriever-OperationType 'MFR.TextValues.Retrievers.FilenameTextValueRetriever.OperationType')
  - [#cctor()](#M-MFR-TextValues-Retrievers-FilenameTextValueRetriever-#cctor 'MFR.TextValues.Retrievers.FilenameTextValueRetriever.#cctor')
- [FolderTextValueRetriever](#T-MFR-TextValues-Retrievers-FolderTextValueRetriever 'MFR.TextValues.Retrievers.FolderTextValueRetriever')
  - [#ctor()](#M-MFR-TextValues-Retrievers-FolderTextValueRetriever-#ctor 'MFR.TextValues.Retrievers.FolderTextValueRetriever.#ctor')
  - [Instance](#P-MFR-TextValues-Retrievers-FolderTextValueRetriever-Instance 'MFR.TextValues.Retrievers.FolderTextValueRetriever.Instance')
  - [OperationType](#P-MFR-TextValues-Retrievers-FolderTextValueRetriever-OperationType 'MFR.TextValues.Retrievers.FolderTextValueRetriever.OperationType')
  - [#cctor()](#M-MFR-TextValues-Retrievers-FolderTextValueRetriever-#cctor 'MFR.TextValues.Retrievers.FolderTextValueRetriever.#cctor')
- [Resources](#T-MFR-TextValues-Retrievers-Properties-Resources 'MFR.TextValues.Retrievers.Properties.Resources')
  - [Culture](#P-MFR-TextValues-Retrievers-Properties-Resources-Culture 'MFR.TextValues.Retrievers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-TextValues-Retrievers-Properties-Resources-ResourceManager 'MFR.TextValues.Retrievers.Properties.Resources.ResourceManager')
- [TextInFileTextValueRetriever](#T-MFR-TextValues-Retrievers-TextInFileTextValueRetriever 'MFR.TextValues.Retrievers.TextInFileTextValueRetriever')
  - [#ctor()](#M-MFR-TextValues-Retrievers-TextInFileTextValueRetriever-#ctor 'MFR.TextValues.Retrievers.TextInFileTextValueRetriever.#ctor')
  - [Instance](#P-MFR-TextValues-Retrievers-TextInFileTextValueRetriever-Instance 'MFR.TextValues.Retrievers.TextInFileTextValueRetriever.Instance')
  - [OperationType](#P-MFR-TextValues-Retrievers-TextInFileTextValueRetriever-OperationType 'MFR.TextValues.Retrievers.TextInFileTextValueRetriever.OperationType')
  - [#cctor()](#M-MFR-TextValues-Retrievers-TextInFileTextValueRetriever-#cctor 'MFR.TextValues.Retrievers.TextInFileTextValueRetriever.#cctor')
  - [GetTextValue(entry)](#M-MFR-TextValues-Retrievers-TextInFileTextValueRetriever-GetTextValue-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.TextValues.Retrievers.TextInFileTextValueRetriever.GetTextValue(MFR.FileSystem.Interfaces.IFileSystemEntry)')
- [TextValueRetrieverBase](#T-MFR-TextValues-Retrievers-TextValueRetrieverBase 'MFR.TextValues.Retrievers.TextValueRetrieverBase')
  - [OperationType](#P-MFR-TextValues-Retrievers-TextValueRetrieverBase-OperationType 'MFR.TextValues.Retrievers.TextValueRetrieverBase.OperationType')
  - [GetTextValue(entry)](#M-MFR-TextValues-Retrievers-TextValueRetrieverBase-GetTextValue-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.TextValues.Retrievers.TextValueRetrieverBase.GetTextValue(MFR.FileSystem.Interfaces.IFileSystemEntry)')

<a name='T-MFR-TextValues-Retrievers-FileAndFolderTextValueRetrieverBase'></a>
## FileAndFolderTextValueRetrieverBase `type`

##### Namespace

MFR.TextValues.Retrievers

##### Summary

Implements functionality common to retrievers of data for both files and folders.

<a name='M-MFR-TextValues-Retrievers-FileAndFolderTextValueRetrieverBase-GetTextValue-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### GetTextValue(entry) `method`

##### Summary

Gets a string containing the text to be searched, from the
file-system `entry` provided, given the current
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') now being processed.

##### Returns

String containing the value data to be searched for the current
operation type, or the empty string if the data source has no data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | Reference to an instance of an object that implements the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |

<a name='T-MFR-TextValues-Retrievers-FilenameTextValueRetriever'></a>
## FilenameTextValueRetriever `type`

##### Namespace

MFR.TextValues.Retrievers

##### Summary

Retrieves the search source data for filename replacement operations.

<a name='M-MFR-TextValues-Retrievers-FilenameTextValueRetriever-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-TextValues-Retrievers-FilenameTextValueRetriever-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [FilenameTextValueRetriever](#T-MFR-TextValues-Retrievers-FilenameTextValueRetriever 'MFR.TextValues.Retrievers.FilenameTextValueRetriever').

<a name='P-MFR-TextValues-Retrievers-FilenameTextValueRetriever-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values that
corresponds to the type of operation being performed.

<a name='M-MFR-TextValues-Retrievers-FilenameTextValueRetriever-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-TextValues-Retrievers-FolderTextValueRetriever'></a>
## FolderTextValueRetriever `type`

##### Namespace

MFR.TextValues.Retrievers

##### Summary

Retrieves the value to be used in which to search for text to be
substituted in the names of file folders.

<a name='M-MFR-TextValues-Retrievers-FolderTextValueRetriever-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-TextValues-Retrievers-FolderTextValueRetriever-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[FolderTextValueRetriever](#T-MFR-TextValues-Retrievers-FolderTextValueRetriever 'MFR.TextValues.Retrievers.FolderTextValueRetriever').

<a name='P-MFR-TextValues-Retrievers-FolderTextValueRetriever-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='M-MFR-TextValues-Retrievers-FolderTextValueRetriever-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-TextValues-Retrievers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.TextValues.Retrievers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-TextValues-Retrievers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-TextValues-Retrievers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-TextValues-Retrievers-TextInFileTextValueRetriever'></a>
## TextInFileTextValueRetriever `type`

##### Namespace

MFR.TextValues.Retrievers

##### Summary

Retrieves the text content of a file.

<a name='M-MFR-TextValues-Retrievers-TextInFileTextValueRetriever-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-TextValues-Retrievers-TextInFileTextValueRetriever-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[TextInFileTextValueRetriever](#T-MFR-TextValues-Retrievers-TextInFileTextValueRetriever 'MFR.TextValues.Retrievers.TextInFileTextValueRetriever').

<a name='P-MFR-TextValues-Retrievers-TextInFileTextValueRetriever-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-TextValues-Retrievers-TextInFileTextValueRetriever-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-TextValues-Retrievers-TextInFileTextValueRetriever-GetTextValue-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### GetTextValue(entry) `method`

##### Summary

Gets a string containing the text to be searched, from the
file-system `entry` provided, given the current
[OperationType](#P-MFR-FileAndFolderTextValueRetriever-OperationType 'MFR.FileAndFolderTextValueRetriever.OperationType')
.

##### Returns

String containing the value data to be searched for the current
operation type, or the empty string if the data source has no data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |

<a name='T-MFR-TextValues-Retrievers-TextValueRetrieverBase'></a>
## TextValueRetrieverBase `type`

##### Namespace

MFR.TextValues.Retrievers

##### Summary

Defines the events, methods, properties, and behaviors for all `Text
            Value Retriever` objects.

<a name='P-MFR-TextValues-Retrievers-TextValueRetrieverBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Operations-Constants-OperationType 'MFR.Operations.Constants.OperationType') values
that corresponds to the type of operation being performed.

<a name='M-MFR-TextValues-Retrievers-TextValueRetrieverBase-GetTextValue-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### GetTextValue(entry) `method`

##### Summary

Gets a string containing the text to be searched, from the
file-system `entry` provided, given the current
[OperationType](#P-MFR-FileAndFolderTextValueRetriever-OperationType 'MFR.FileAndFolderTextValueRetriever.OperationType') .

##### Returns

String containing the value data to be searched for the current
operation type, or the empty string if the data source has no data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | Reference to an instance of an object that implements the [IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |
