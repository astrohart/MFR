<a name='assembly'></a>
# MFR.TextValues.Retrievers.Interfaces

## Contents

- [ITextValueRetriever](#T-MFR-Objects-TextValues-Retrievers-Interfaces-ITextValueRetriever 'MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever')
  - [GetTextValue(entry)](#M-MFR-Objects-TextValues-Retrievers-Interfaces-ITextValueRetriever-GetTextValue-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever.GetTextValue(MFR.FileSystem.Interfaces.IFileSystemEntry)')
- [Resources](#T-MFR-Objects-TextValues-Retrievers-Interfaces-Properties-Resources 'MFR.TextValues.Retrievers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-TextValues-Retrievers-Interfaces-Properties-Resources-Culture 'MFR.TextValues.Retrievers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-TextValues-Retrievers-Interfaces-Properties-Resources-ResourceManager 'MFR.TextValues.Retrievers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-TextValues-Retrievers-Interfaces-ITextValueRetriever'></a>
## ITextValueRetriever `type`

##### Namespace

MFR.TextValues.Retrievers.Interfaces

##### Summary

Defines the public-exposed methods and properties of a text-retriever object.

##### Remarks

Such objects examine the properties of another object that implements
the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') interface.



The properties are used to extract a text value that contains the data
upon which a find/replace operation is based.



The specific data to be utilized varies from one type of operation to
the other.

<a name='M-MFR-Objects-TextValues-Retrievers-Interfaces-ITextValueRetriever-GetTextValue-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
### GetTextValue(entry) `method`

##### Summary

Gets a string containing the text to be searched, from the
file-system `entry` provided, given the current
[OperationType](#T-MFR-Objects-OperationType 'MFR.OperationType') now being processed.

##### Returns

String containing the value data to be searched for the current
operation type, or the empty string if the data source has no data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `entry`, is
passed a `null` value. |

<a name='T-MFR-Objects-TextValues-Retrievers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.TextValues.Retrievers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-TextValues-Retrievers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-TextValues-Retrievers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
