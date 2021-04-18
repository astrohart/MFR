<a name='assembly'></a>
# MFR.Objects.TextValues.Retrievers

## Contents

- [FileAndFolderTextValueRetrieverBase](#T-MFR-Objects-TextValues-Retrievers-FileAndFolderTextValueRetrieverBase 'MFR.Objects.TextValues.Retrievers.FileAndFolderTextValueRetrieverBase')
  - [GetTextValue(entry)](#M-MFR-Objects-TextValues-Retrievers-FileAndFolderTextValueRetrieverBase-GetTextValue-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Objects.TextValues.Retrievers.FileAndFolderTextValueRetrieverBase.GetTextValue(MFR.Objects.FileSystem.Interfaces.IFileSystemEntry)')
- [FilenameTextValueRetriever](#T-MFR-Objects-TextValues-Retrievers-FilenameTextValueRetriever 'MFR.Objects.TextValues.Retrievers.FilenameTextValueRetriever')
  - [#ctor()](#M-MFR-Objects-TextValues-Retrievers-FilenameTextValueRetriever-#ctor 'MFR.Objects.TextValues.Retrievers.FilenameTextValueRetriever.#ctor')
  - [Instance](#P-MFR-Objects-TextValues-Retrievers-FilenameTextValueRetriever-Instance 'MFR.Objects.TextValues.Retrievers.FilenameTextValueRetriever.Instance')
  - [OperationType](#P-MFR-Objects-TextValues-Retrievers-FilenameTextValueRetriever-OperationType 'MFR.Objects.TextValues.Retrievers.FilenameTextValueRetriever.OperationType')
  - [#cctor()](#M-MFR-Objects-TextValues-Retrievers-FilenameTextValueRetriever-#cctor 'MFR.Objects.TextValues.Retrievers.FilenameTextValueRetriever.#cctor')
- [FolderTextValueRetriever](#T-MFR-Objects-TextValues-Retrievers-FolderTextValueRetriever 'MFR.Objects.TextValues.Retrievers.FolderTextValueRetriever')
  - [#ctor()](#M-MFR-Objects-TextValues-Retrievers-FolderTextValueRetriever-#ctor 'MFR.Objects.TextValues.Retrievers.FolderTextValueRetriever.#ctor')
  - [Instance](#P-MFR-Objects-TextValues-Retrievers-FolderTextValueRetriever-Instance 'MFR.Objects.TextValues.Retrievers.FolderTextValueRetriever.Instance')
  - [OperationType](#P-MFR-Objects-TextValues-Retrievers-FolderTextValueRetriever-OperationType 'MFR.Objects.TextValues.Retrievers.FolderTextValueRetriever.OperationType')
  - [#cctor()](#M-MFR-Objects-TextValues-Retrievers-FolderTextValueRetriever-#cctor 'MFR.Objects.TextValues.Retrievers.FolderTextValueRetriever.#cctor')
- [Resources](#T-MFR-Objects-TextValues-Retrievers-Properties-Resources 'MFR.Objects.TextValues.Retrievers.Properties.Resources')
  - [Culture](#P-MFR-Objects-TextValues-Retrievers-Properties-Resources-Culture 'MFR.Objects.TextValues.Retrievers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-TextValues-Retrievers-Properties-Resources-ResourceManager 'MFR.Objects.TextValues.Retrievers.Properties.Resources.ResourceManager')
- [TextInFileTextValueRetriever](#T-MFR-Objects-TextValues-Retrievers-TextInFileTextValueRetriever 'MFR.Objects.TextValues.Retrievers.TextInFileTextValueRetriever')
  - [#ctor()](#M-MFR-Objects-TextValues-Retrievers-TextInFileTextValueRetriever-#ctor 'MFR.Objects.TextValues.Retrievers.TextInFileTextValueRetriever.#ctor')
  - [Instance](#P-MFR-Objects-TextValues-Retrievers-TextInFileTextValueRetriever-Instance 'MFR.Objects.TextValues.Retrievers.TextInFileTextValueRetriever.Instance')
  - [OperationType](#P-MFR-Objects-TextValues-Retrievers-TextInFileTextValueRetriever-OperationType 'MFR.Objects.TextValues.Retrievers.TextInFileTextValueRetriever.OperationType')
  - [#cctor()](#M-MFR-Objects-TextValues-Retrievers-TextInFileTextValueRetriever-#cctor 'MFR.Objects.TextValues.Retrievers.TextInFileTextValueRetriever.#cctor')
  - [GetTextValue(entry)](#M-MFR-Objects-TextValues-Retrievers-TextInFileTextValueRetriever-GetTextValue-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Objects.TextValues.Retrievers.TextInFileTextValueRetriever.GetTextValue(MFR.Objects.FileSystem.Interfaces.IFileSystemEntry)')
- [TextValueRetrieverBase](#T-MFR-Objects-TextValues-Retrievers-TextValueRetrieverBase 'MFR.Objects.TextValues.Retrievers.TextValueRetrieverBase')
  - [OperationType](#P-MFR-Objects-TextValues-Retrievers-TextValueRetrieverBase-OperationType 'MFR.Objects.TextValues.Retrievers.TextValueRetrieverBase.OperationType')
  - [GetTextValue(entry)](#M-MFR-Objects-TextValues-Retrievers-TextValueRetrieverBase-GetTextValue-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Objects.TextValues.Retrievers.TextValueRetrieverBase.GetTextValue(MFR.Objects.FileSystem.Interfaces.IFileSystemEntry)')

<a name='T-MFR-Objects-TextValues-Retrievers-FileAndFolderTextValueRetrieverBase'></a>
## FileAndFolderTextValueRetrieverBase `type`

##### Namespace

MFR.Objects.TextValues.Retrievers

##### Summary

Implements functionality common to retrievers of data for both files and folders.

<a name='M-MFR-Objects-TextValues-Retrievers-FileAndFolderTextValueRetrieverBase-GetTextValue-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
### GetTextValue(entry) `method`

##### Summary

Gets a string containing the text to be searched, from the
file-system `entry` provided, given the current
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType') now being processed.

##### Returns

String containing the value data to be searched for the current
operation type, or the empty string if the data source has no data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.Objects.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') | Reference to an instance of an object that implements the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |

<a name='T-MFR-Objects-TextValues-Retrievers-FilenameTextValueRetriever'></a>
## FilenameTextValueRetriever `type`

##### Namespace

MFR.Objects.TextValues.Retrievers

##### Summary

Retrieves the search source data for filename replacement operations.

<a name='M-MFR-Objects-TextValues-Retrievers-FilenameTextValueRetriever-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-TextValues-Retrievers-FilenameTextValueRetriever-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [FilenameTextValueRetriever](#T-MFR-Objects-TextValues-Retrievers-FilenameTextValueRetriever 'MFR.Objects.TextValues.Retrievers.FilenameTextValueRetriever').

<a name='P-MFR-Objects-TextValues-Retrievers-FilenameTextValueRetriever-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType') values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-TextValues-Retrievers-FilenameTextValueRetriever-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-TextValues-Retrievers-FolderTextValueRetriever'></a>
## FolderTextValueRetriever `type`

##### Namespace

MFR.Objects.TextValues.Retrievers

<a name='M-MFR-Objects-TextValues-Retrievers-FolderTextValueRetriever-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-TextValues-Retrievers-FolderTextValueRetriever-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [FolderTextValueRetriever](#T-MFR-Objects-TextValues-Retrievers-FolderTextValueRetriever 'MFR.Objects.TextValues.Retrievers.FolderTextValueRetriever').

<a name='P-MFR-Objects-TextValues-Retrievers-FolderTextValueRetriever-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType') values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-TextValues-Retrievers-FolderTextValueRetriever-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-TextValues-Retrievers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.TextValues.Retrievers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-TextValues-Retrievers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-TextValues-Retrievers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-TextValues-Retrievers-TextInFileTextValueRetriever'></a>
## TextInFileTextValueRetriever `type`

##### Namespace

MFR.Objects.TextValues.Retrievers

<a name='M-MFR-Objects-TextValues-Retrievers-TextInFileTextValueRetriever-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-TextValues-Retrievers-TextInFileTextValueRetriever-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[TextInFileTextValueRetriever](#T-MFR-Objects-TextValues-Retrievers-TextInFileTextValueRetriever 'MFR.Objects.TextValues.Retrievers.TextInFileTextValueRetriever').

<a name='P-MFR-Objects-TextValues-Retrievers-TextInFileTextValueRetriever-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the
[OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType')
values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-TextValues-Retrievers-TextInFileTextValueRetriever-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-TextValues-Retrievers-TextInFileTextValueRetriever-GetTextValue-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
### GetTextValue(entry) `method`

##### Summary

Gets a string containing the text to be searched, from the
file-system `entry` provided, given the current
[OperationType](#P-MFR-Objects-FileAndFolderTextValueRetriever-OperationType 'MFR.Objects.FileAndFolderTextValueRetriever.OperationType')
.

##### Returns

String containing the value data to be searched for the current
operation type, or the empty string if the data source has no data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.Objects.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') | Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |

<a name='T-MFR-Objects-TextValues-Retrievers-TextValueRetrieverBase'></a>
## TextValueRetrieverBase `type`

##### Namespace

MFR.Objects.TextValues.Retrievers

<a name='P-MFR-Objects-TextValues-Retrievers-TextValueRetrieverBase-OperationType'></a>
### OperationType `property`

##### Summary

Gets one of the [OperationType](#T-MFR-Objects-OperationType 'MFR.Objects.OperationType') values that
corresponds to the type of operation being performed.

<a name='M-MFR-Objects-TextValues-Retrievers-TextValueRetrieverBase-GetTextValue-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
### GetTextValue(entry) `method`

##### Summary

Gets a string containing the text to be searched, from the
file-system `entry` provided, given the current
[OperationType](#P-MFR-Objects-FileAndFolderTextValueRetriever-OperationType 'MFR.Objects.FileAndFolderTextValueRetriever.OperationType') .

##### Returns

String containing the value data to be searched for the current
operation type, or the empty string if the data source has no data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.Objects.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') | Reference to an instance of an object that implements the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |
