<a name='assembly'></a>
# MFR.Engines.Operations.Jobs

## Contents

- [FileRenamerJob](#T-MFR-Engines-Operations-Models-FileRenamerJob 'MFR.Engines.Operations.Models.FileRenamerJob')
  - [FindWhat](#P-MFR-Engines-Operations-Models-FileRenamerJob-FindWhat 'MFR.Engines.Operations.Models.FileRenamerJob.FindWhat')
  - [PathFilter](#P-MFR-Engines-Operations-Models-FileRenamerJob-PathFilter 'MFR.Engines.Operations.Models.FileRenamerJob.PathFilter')
  - [ReplaceWith](#P-MFR-Engines-Operations-Models-FileRenamerJob-ReplaceWith 'MFR.Engines.Operations.Models.FileRenamerJob.ReplaceWith')
  - [RootDirectory](#P-MFR-Engines-Operations-Models-FileRenamerJob-RootDirectory 'MFR.Engines.Operations.Models.FileRenamerJob.RootDirectory')
- [Resources](#T-MFR-Engines-Operations-Jobs-Properties-Resources 'MFR.Engines.Operations.Jobs.Properties.Resources')
  - [Culture](#P-MFR-Engines-Operations-Jobs-Properties-Resources-Culture 'MFR.Engines.Operations.Jobs.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Operations-Jobs-Properties-Resources-ResourceManager 'MFR.Engines.Operations.Jobs.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Operations-Models-FileRenamerJob'></a>
## FileRenamerJob `type`

##### Namespace

MFR.Engines.Operations.Models

##### Summary

Encapsulates the parameters for a
[FileRenamer](#T-MFR-Renamers-Files-FileRenamer 'MFR.Renamers.Files.FileRenamer') job.

<a name='P-MFR-Engines-Operations-Models-FileRenamerJob-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the content to be
found in file names, folder names, and file contents.

<a name='P-MFR-Engines-Operations-Models-FileRenamerJob-PathFilter'></a>
### PathFilter `property`

##### Summary

Gets or sets an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func') that points to a
delegate, accepting the current file or folder's path as an argument, that
returns `true` if the file should be included in the operation
or `false` otherwise.

<a name='P-MFR-Engines-Operations-Models-FileRenamerJob-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the value(s) that
should be substituted for the found content in file names, folder names, and
file contents.

<a name='P-MFR-Engines-Operations-Models-FileRenamerJob-RootDirectory'></a>
### RootDirectory `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the folder in which the job was ready to start.

<a name='T-MFR-Engines-Operations-Jobs-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Operations.Jobs.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Operations-Jobs-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Operations-Jobs-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
