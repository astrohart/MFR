<a name='assembly'></a>
# MFR.Engines.Actions

## Contents

- [FileRenamerJob](#T-MFR-Engines-Actions-FileRenamerJob 'MFR.Engines.Actions.FileRenamerJob')
  - [FindWhat](#P-MFR-Engines-Actions-FileRenamerJob-FindWhat 'MFR.Engines.Actions.FileRenamerJob.FindWhat')
  - [PathFilter](#P-MFR-Engines-Actions-FileRenamerJob-PathFilter 'MFR.Engines.Actions.FileRenamerJob.PathFilter')
  - [ReplaceWith](#P-MFR-Engines-Actions-FileRenamerJob-ReplaceWith 'MFR.Engines.Actions.FileRenamerJob.ReplaceWith')
  - [RootDirectory](#P-MFR-Engines-Actions-FileRenamerJob-RootDirectory 'MFR.Engines.Actions.FileRenamerJob.RootDirectory')
- [Resources](#T-MFR-Engines-Actions-Properties-Resources 'MFR.Engines.Actions.Properties.Resources')
  - [Culture](#P-MFR-Engines-Actions-Properties-Resources-Culture 'MFR.Engines.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Actions-Properties-Resources-ResourceManager 'MFR.Engines.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Actions-FileRenamerJob'></a>
## FileRenamerJob `type`

##### Namespace

MFR.Engines.Actions

##### Summary

Encapsulates the parameters for a
[FileRenamer](#T-MFR-Renamers-Files-FileRenamer 'MFR.Renamers.Files.FileRenamer') job.

<a name='P-MFR-Engines-Actions-FileRenamerJob-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the content to be
found in file names, folder names, and file contents.

<a name='P-MFR-Engines-Actions-FileRenamerJob-PathFilter'></a>
### PathFilter `property`

##### Summary

Gets or sets an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func') that points to a
delegate, accepting the current file or folder's path as an argument, that
returns `true` if the file should be included in the operation
or `false` otherwise.

<a name='P-MFR-Engines-Actions-FileRenamerJob-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the value(s) that
should be substituted for the found content in file names, folder names, and
file contents.

<a name='P-MFR-Engines-Actions-FileRenamerJob-RootDirectory'></a>
### RootDirectory `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the folder in which the job was ready to start.

<a name='T-MFR-Engines-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
