<a name='assembly'></a>
# MFR.FileSystem.Enumerators.Actions

## Contents

- [Does](#T-MFR-FileSystem-Enumerators-Actions-Does 'MFR.FileSystem.Enumerators.Actions.Does')
  - [FolderHaveAtLeastOneFileMatching(folderPathname,pattern)](#M-MFR-FileSystem-Enumerators-Actions-Does-FolderHaveAtLeastOneFileMatching-System-String,System-String- 'MFR.FileSystem.Enumerators.Actions.Does.FolderHaveAtLeastOneFileMatching(System.String,System.String)')
- [Resources](#T-MFR-FileSystem-Enumerators-Actions-Properties-Resources 'MFR.FileSystem.Enumerators.Actions.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Enumerators-Actions-Properties-Resources-Culture 'MFR.FileSystem.Enumerators.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Enumerators-Actions-Properties-Resources-ResourceManager 'MFR.FileSystem.Enumerators.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Enumerators-Actions-Does'></a>
## Does `type`

##### Namespace

MFR.FileSystem.Enumerators.Actions

##### Summary

Exposes static methods to determine the state of the system and/or data.

<a name='M-MFR-FileSystem-Enumerators-Actions-Does-FolderHaveAtLeastOneFileMatching-System-String,System-String-'></a>
### FolderHaveAtLeastOneFileMatching(folderPathname,pattern) `method`

##### Summary

Determines whether at least one file that matches the specified wildcard
pattern exists in the folder having the specified
`folderPathname`, or its subfolders.  Returns the instant it
finds even the first file in the group.

##### Returns

`true` if the folder having the specified
`folderPathname`, or one of its children or descendants,
contains even one file that matches the `pattern`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderPathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a folder from which the search should be started. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the wildcard pattern to
use to search for file(s) matching the criteria. |

<a name='T-MFR-FileSystem-Enumerators-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Enumerators.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Enumerators-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Enumerators-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
