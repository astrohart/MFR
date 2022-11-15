<a name='assembly'></a>
# MFR.FileSystem.Enumerators

## Contents

- [Enumerate](#T-MFR-FileSystem-Enumerators-Enumerate 'MFR.FileSystem.Enumerators.Enumerate')
  - [Directories(path,searchPattern,searchOption)](#M-MFR-FileSystem-Enumerators-Enumerate-Directories-System-String,System-String,System-IO-SearchOption- 'MFR.FileSystem.Enumerators.Enumerate.Directories(System.String,System.String,System.IO.SearchOption)')
  - [Directories(path)](#M-MFR-FileSystem-Enumerators-Enumerate-Directories-System-String- 'MFR.FileSystem.Enumerators.Enumerate.Directories(System.String)')
  - [Directories(path,searchPattern)](#M-MFR-FileSystem-Enumerators-Enumerate-Directories-System-String,System-String- 'MFR.FileSystem.Enumerators.Enumerate.Directories(System.String,System.String)')
  - [Files(path)](#M-MFR-FileSystem-Enumerators-Enumerate-Files-System-String- 'MFR.FileSystem.Enumerators.Enumerate.Files(System.String)')
  - [Files(path,searchPattern)](#M-MFR-FileSystem-Enumerators-Enumerate-Files-System-String,System-String- 'MFR.FileSystem.Enumerators.Enumerate.Files(System.String,System.String)')
  - [Files(path,searchPattern,searchOption)](#M-MFR-FileSystem-Enumerators-Enumerate-Files-System-String,System-String,System-IO-SearchOption- 'MFR.FileSystem.Enumerators.Enumerate.Files(System.String,System.String,System.IO.SearchOption)')
- [Resources](#T-MFR-FileSystem-Enumerators-Properties-Resources 'MFR.FileSystem.Enumerators.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Enumerators-Properties-Resources-Culture 'MFR.FileSystem.Enumerators.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Enumerators-Properties-Resources-ResourceManager 'MFR.FileSystem.Enumerators.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Enumerators-Enumerate'></a>
## Enumerate `type`

##### Namespace

MFR.FileSystem.Enumerators

##### Summary

Exposes static methods to search the file system.

<a name='M-MFR-FileSystem-Enumerators-Enumerate-Directories-System-String,System-String,System-IO-SearchOption-'></a>
### Directories(path,searchPattern,searchOption) `method`

##### Summary

Enumerates the subfolders of the folder whose fully-qualified pathname is
specified by the `path` parameter.

##### Returns

Collection of strings that contains the fully-qualified pathnames of
the folders contained within the folder whose fully-qualified pathname is
passed in the `path`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname
of the folder where the search is to start. |
| searchPattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing one or more wildcard
expressions for the search.



Each wildcard expression must be separated by a semicolon. |
| searchOption | [System.IO.SearchOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.SearchOption 'System.IO.SearchOption') | (Required.) A
[SearchOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.SearchOption 'System.IO.SearchOption') value that specifies whether the search
should list results from the current folder only, or subfolders as well. |

<a name='M-MFR-FileSystem-Enumerators-Enumerate-Directories-System-String-'></a>
### Directories(path) `method`

##### Summary

Enumerates the subfolders of the folder whose fully-qualified pathname is
specified by the `path` parameter.

##### Returns

Collection of strings that contains the fully-qualified pathnames of
the folders contained within the folder whose fully-qualified pathname is
passed in the `path`.



This method only returns those folders in the top level of the folder whose
fully-qualified pathname is specified for the `path`
parameter's value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname
of the folder where the search is to start. |

<a name='M-MFR-FileSystem-Enumerators-Enumerate-Directories-System-String,System-String-'></a>
### Directories(path,searchPattern) `method`

##### Summary

Enumerates the subfolders of the folder whose fully-qualified pathname is
specified by the `path` parameter.

##### Returns

Collection of strings that contains the fully-qualified pathnames of
the folders contained within the folder whose fully-qualified pathname is
passed in the `path`.



This method only returns those folders in the top level of the folder whose
fully-qualified pathname is specified for the `path`
parameter's value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname
of the folder where the search is to start. |
| searchPattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing one or more wildcard
expressions for the search.



Each wildcard expression must be separated by a semicolon. |

<a name='M-MFR-FileSystem-Enumerators-Enumerate-Files-System-String-'></a>
### Files(path) `method`

##### Summary

Enumerates the files in the top level of the folder whose fully-qualified
pathname is
specified by the `path` parameter.

##### Returns

Collection of strings that contains the fully-qualified pathnames of
the files contained within the top level of the folder whose fully-qualified
pathname is passed in the `path`.



This method only returns those folders in the top level of the folder whose
fully-qualified pathname is specified for the `path`
parameter's value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname
of the folder where the search is to start. |

<a name='M-MFR-FileSystem-Enumerators-Enumerate-Files-System-String,System-String-'></a>
### Files(path,searchPattern) `method`

##### Summary

Enumerates the files in the top level of the folder whose fully-qualified
pathname is
specified by the `path` parameter.

##### Returns

Collection of strings that contains the fully-qualified pathnames of
the files contained within the top level of the folder whose fully-qualified
pathname is passed in the `path`.



This method only returns those folders in the top level of the folder whose
fully-qualified pathname is specified for the `path`
parameter's value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname
of the folder where the search is to start. |
| searchPattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing one or more wildcard
expressions for the search.



Each wildcard expression must be separated by a semicolon. |

<a name='M-MFR-FileSystem-Enumerators-Enumerate-Files-System-String,System-String,System-IO-SearchOption-'></a>
### Files(path,searchPattern,searchOption) `method`

##### Summary

Enumerates the files in the top level of the folder whose fully-qualified
pathname is
specified by the `path` parameter.

##### Returns

Collection of strings that contains the fully-qualified pathnames of
the files contained within the top level of the folder whose fully-qualified
pathname is passed in the `path`.



This method only returns those folders in the top level of the folder whose
fully-qualified pathname is specified for the `path`
parameter's value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname
of the folder where the search is to start. |
| searchPattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing one or more wildcard
expressions for the search.



Each wildcard expression must be separated by a semicolon. |
| searchOption | [System.IO.SearchOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.SearchOption 'System.IO.SearchOption') | (Required.) A
[SearchOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.SearchOption 'System.IO.SearchOption') value that specifies whether the search
should list results from the current folder only, or subfolders as well. |

<a name='T-MFR-FileSystem-Enumerators-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Enumerators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Enumerators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Enumerators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
