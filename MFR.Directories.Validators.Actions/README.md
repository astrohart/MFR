<a name='assembly'></a>
# MFR.Directories.Validators.Actions

## Contents

- [Resources](#T-MFR-Directories-Validators-Actions-Properties-Resources 'MFR.Directories.Validators.Actions.Properties.Resources')
  - [Culture](#P-MFR-Directories-Validators-Actions-Properties-Resources-Culture 'MFR.Directories.Validators.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Directories-Validators-Actions-Properties-Resources-ResourceManager 'MFR.Directories.Validators.Actions.Properties.Resources.ResourceManager')
- [Search](#T-MFR-Directories-Validators-Actions-Search 'MFR.Directories.Validators.Actions.Search')
  - [ForFilesHavingExtension(folder,extensionPattern)](#M-MFR-Directories-Validators-Actions-Search-ForFilesHavingExtension-System-String,System-String- 'MFR.Directories.Validators.Actions.Search.ForFilesHavingExtension(System.String,System.String)')

<a name='T-MFR-Directories-Validators-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Directories.Validators.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Directories-Validators-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Directories-Validators-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Directories-Validators-Actions-Search'></a>
## Search `type`

##### Namespace

MFR.Directories.Validators.Actions

##### Summary

Exposes static methods to search for files and folders.

<a name='M-MFR-Directories-Validators-Actions-Search-ForFilesHavingExtension-System-String,System-String-'></a>
### ForFilesHavingExtension(folder,extensionPattern) `method`

##### Summary

Searches the specified `folder`, and all its subfolders, for
file(s) matching the specified `extensionPattern`.

##### Returns

`true` if at least one file is found in the directory
tree of the specified `folder` whose filename matches the
specified `extensionPattern`; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folder | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the fully-qualified pathname of the folder in which to begin the search. |
| extensionPattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
containing the glob pattern, e.g., `*.sln`, that designates the file(s)
that are to be matched by the search. |

##### Remarks

This method returns `false` if the argument of either
the `folder` or the `extensionPattern`
parameters is a `null` reference, the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value, or a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
that contains only whitespace.



If the argument of the `folder` parameter refers to a folder
that does not exist on the file system, then this method also returns
`false`.
