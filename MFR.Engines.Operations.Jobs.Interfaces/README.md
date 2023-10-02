<a name='assembly'></a>
# MFR.Engines.Operations.Jobs.Interfaces

## Contents

- [IFileRenamerJob](#T-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob')
  - [FindWhat](#P-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob-FindWhat 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob.FindWhat')
  - [PathFilter](#P-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob-PathFilter 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob.PathFilter')
  - [ReplaceWith](#P-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob-ReplaceWith 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob.ReplaceWith')
  - [RootDirectory](#P-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob-RootDirectory 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob.RootDirectory')
- [Resources](#T-MFR-Engines-Operations-Jobs-Interfaces-Properties-Resources 'MFR.Engines.Operations.Jobs.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Engines-Operations-Jobs-Interfaces-Properties-Resources-Culture 'MFR.Engines.Operations.Jobs.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Operations-Jobs-Interfaces-Properties-Resources-ResourceManager 'MFR.Engines.Operations.Jobs.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob'></a>
## IFileRenamerJob `type`

##### Namespace

MFR.Engines.Operations.Jobs.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that
represents one of the jobs in the job queue for renaming files, folders, and
replacing the text within files..

<a name='P-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob-FindWhat'></a>
### FindWhat `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the content to be
found in file names, folder names, and file contents.

<a name='P-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob-PathFilter'></a>
### PathFilter `property`

##### Summary

Gets or sets an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func') that points to a
delegate, accepting the current file or folder's path as an argument, that
returns `true` if the file should be included in the operation
or `false` otherwise.

<a name='P-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob-ReplaceWith'></a>
### ReplaceWith `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the value(s) that
should be substituted for the found content in file names, folder names, and
file contents.

<a name='P-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob-RootDirectory'></a>
### RootDirectory `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the folder in which the job was ready to start.

<a name='T-MFR-Engines-Operations-Jobs-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Operations.Jobs.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Operations-Jobs-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Operations-Jobs-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
