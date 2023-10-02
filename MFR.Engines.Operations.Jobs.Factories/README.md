<a name='assembly'></a>
# MFR.Engines.Operations.Jobs.Factories

## Contents

- [MakeNewFileRenamerJob](#T-MFR-Engines-Operations-Jobs-Factories-MakeNewFileRenamerJob 'MFR.Engines.Operations.Jobs.Factories.MakeNewFileRenamerJob')
  - [AndReplaceItWith(self,replaceWith)](#M-MFR-Engines-Operations-Jobs-Factories-MakeNewFileRenamerJob-AndReplaceItWith-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob,System-String- 'MFR.Engines.Operations.Jobs.Factories.MakeNewFileRenamerJob.AndReplaceItWith(MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob,System.String)')
  - [ForRootDirectory()](#M-MFR-Engines-Operations-Jobs-Factories-MakeNewFileRenamerJob-ForRootDirectory-System-String- 'MFR.Engines.Operations.Jobs.Factories.MakeNewFileRenamerJob.ForRootDirectory(System.String)')
  - [HavingPathFilter(self,pathFilter)](#M-MFR-Engines-Operations-Jobs-Factories-MakeNewFileRenamerJob-HavingPathFilter-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob,System-Predicate{System-String}- 'MFR.Engines.Operations.Jobs.Factories.MakeNewFileRenamerJob.HavingPathFilter(MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob,System.Predicate{System.String})')
  - [ToFindWhat(self,findWhat)](#M-MFR-Engines-Operations-Jobs-Factories-MakeNewFileRenamerJob-ToFindWhat-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob,System-String- 'MFR.Engines.Operations.Jobs.Factories.MakeNewFileRenamerJob.ToFindWhat(MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob,System.String)')
- [Resources](#T-MFR-Engines-Operations-Jobs-Factories-Properties-Resources 'MFR.Engines.Operations.Jobs.Factories.Properties.Resources')
  - [Culture](#P-MFR-Engines-Operations-Jobs-Factories-Properties-Resources-Culture 'MFR.Engines.Operations.Jobs.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Operations-Jobs-Factories-Properties-Resources-ResourceManager 'MFR.Engines.Operations.Jobs.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Operations-Jobs-Factories-MakeNewFileRenamerJob'></a>
## MakeNewFileRenamerJob `type`

##### Namespace

MFR.Engines.Operations.Jobs.Factories

##### Summary

Creates new instances of objects that implement the
[IFileRenamerJob](#T-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob')
interface, and returns references to them.

<a name='M-MFR-Engines-Operations-Jobs-Factories-MakeNewFileRenamerJob-AndReplaceItWith-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob,System-String-'></a>
### AndReplaceItWith(self,replaceWith) `method`

##### Summary

Builder extension method that initializes the
[ReplaceWith](#P-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob-ReplaceWith 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob.ReplaceWith')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob](#T-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob') | (Required.) Reference to an instance of an object that implements
the
[IFileRenamerJob](#T-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob')
interface. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the replacement
text. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Engines-Operations-Jobs-Factories-MakeNewFileRenamerJob-ForRootDirectory-System-String-'></a>
### ForRootDirectory() `method`

##### Summary

Creates a new instance of an object that implements the
[IFileRenamerJob](#T-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IFileRenamerJob](#T-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-Jobs-Factories-MakeNewFileRenamerJob-HavingPathFilter-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob,System-Predicate{System-String}-'></a>
### HavingPathFilter(self,pathFilter) `method`

##### Summary

Builder extension method that initializes the
[PathFilter](#P-MFR-Engines-Operations-Models-Interfaces-IFileRenamerJob-PathFilter 'MFR.Engines.Operations.Models.Interfaces.IFileRenamerJob.PathFilter')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob](#T-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob') | (Required.) Reference to an instance of an object that implements
the
[IFileRenamerJob](#T-MFR-Engines-Operations-Models-Interfaces-IFileRenamerJob 'MFR.Engines.Operations.Models.Interfaces.IFileRenamerJob')
interface. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Required.) A [String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') that represents
the criteria to be used in the search. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-Engines-Operations-Jobs-Factories-MakeNewFileRenamerJob-ToFindWhat-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob,System-String-'></a>
### ToFindWhat(self,findWhat) `method`

##### Summary

Builder extension method that initializes the
[FindWhat](#P-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob-FindWhat 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob.FindWhat')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob](#T-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob') | (Required.) Reference to an instance of an object that implements
the
[IFileRenamerJob](#T-MFR-Engines-Operations-Jobs-Interfaces-IFileRenamerJob 'MFR.Engines.Operations.Jobs.Interfaces.IFileRenamerJob')
interface. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the text to be
searched for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='T-MFR-Engines-Operations-Jobs-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Operations.Jobs.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Operations-Jobs-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Operations-Jobs-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
