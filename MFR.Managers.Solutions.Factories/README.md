<a name='assembly'></a>
# MFR.Managers.Solutions.Factories

## Contents

- [Does](#T-MFR-Managers-Solutions-Factories-Does 'MFR.Managers.Solutions.Factories.Does')
  - [Folder(folderToSearch)](#M-MFR-Managers-Solutions-Factories-Does-Folder-System-String- 'MFR.Managers.Solutions.Factories.Does.Folder(System.String)')
  - [SoleInstance()](#M-MFR-Managers-Solutions-Factories-Does-SoleInstance 'MFR.Managers.Solutions.Factories.Does.SoleInstance')
- [GetVisualStudioSolutionService](#T-MFR-Managers-Solutions-Factories-GetVisualStudioSolutionService 'MFR.Managers.Solutions.Factories.GetVisualStudioSolutionService')
  - [SoleInstance()](#M-MFR-Managers-Solutions-Factories-GetVisualStudioSolutionService-SoleInstance 'MFR.Managers.Solutions.Factories.GetVisualStudioSolutionService.SoleInstance')
- [Resources](#T-MFR-Managers-Solutions-Factories-Properties-Resources 'MFR.Managers.Solutions.Factories.Properties.Resources')
  - [Culture](#P-MFR-Managers-Solutions-Factories-Properties-Resources-Culture 'MFR.Managers.Solutions.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Managers-Solutions-Factories-Properties-Resources-ResourceManager 'MFR.Managers.Solutions.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Managers-Solutions-Factories-Does'></a>
## Does `type`

##### Namespace

MFR.Managers.Solutions.Factories

##### Summary

Creates instances of objects that implement the
[IVisualStudioSolutionService](#T-MFR-Managers-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService')
interface.

<a name='M-MFR-Managers-Solutions-Factories-Does-Folder-System-String-'></a>
### Folder(folderToSearch) `method`

##### Summary

Builder extension method that initializes the
[FolderToSearch](#P-MFR-Managers-Solutions-Interfaces-IVisualStudioSolutionService-FolderToSearch 'MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService.FolderToSearch')
property.

##### Returns

Reference to an instance of an object that implements the
[IVisualStudioSolutionService](#T-MFR-Managers-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderToSearch | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of the folder to be
searched. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the `folderToSearch` parameter is passed a value
that is not the fully-qualified pathname of a folder that actually exists on
the disk. |

<a name='M-MFR-Managers-Solutions-Factories-Does-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Creates a new instance of an object that implements the
[IVisualStudioSolutionService](#T-MFR-Managers-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IVisualStudioSolutionService](#T-MFR-Managers-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService')
interface.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object type requested is not supported. |

<a name='T-MFR-Managers-Solutions-Factories-GetVisualStudioSolutionService'></a>
## GetVisualStudioSolutionService `type`

##### Namespace

MFR.Managers.Solutions.Factories

##### Summary

Creates instances of objects that implement the
[IVisualStudioSolutionService](#T-MFR-Managers-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService')
interface.

<a name='M-MFR-Managers-Solutions-Factories-GetVisualStudioSolutionService-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Creates a new instance of an object that implements the
[IVisualStudioSolutionService](#T-MFR-Managers-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IVisualStudioSolutionService](#T-MFR-Managers-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService')
interface.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object type requested is not supported. |

<a name='T-MFR-Managers-Solutions-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Managers.Solutions.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Managers-Solutions-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Managers-Solutions-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
