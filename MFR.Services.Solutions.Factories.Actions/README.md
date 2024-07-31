<a name='assembly'></a>
# MFR.Services.Solutions.Factories.Actions

## Contents

- [Does](#T-MFR-Services-Solutions-Factories-Actions-Does 'MFR.Services.Solutions.Factories.Actions.Does')
  - [VisualStudioSolutionService](#P-MFR-Services-Solutions-Factories-Actions-Does-VisualStudioSolutionService 'MFR.Services.Solutions.Factories.Actions.Does.VisualStudioSolutionService')
  - [#cctor()](#M-MFR-Services-Solutions-Factories-Actions-Does-#cctor 'MFR.Services.Solutions.Factories.Actions.Does.#cctor')
  - [Folder(folderToSearch)](#M-MFR-Services-Solutions-Factories-Actions-Does-Folder-System-String- 'MFR.Services.Solutions.Factories.Actions.Does.Folder(System.String)')
- [Resources](#T-MFR-Services-Solutions-Factories-Actions-Properties-Resources 'MFR.Services.Solutions.Factories.Actions.Properties.Resources')
  - [Culture](#P-MFR-Services-Solutions-Factories-Actions-Properties-Resources-Culture 'MFR.Services.Solutions.Factories.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Services-Solutions-Factories-Actions-Properties-Resources-ResourceManager 'MFR.Services.Solutions.Factories.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-Services-Solutions-Factories-Actions-Does'></a>
## Does `type`

##### Namespace

MFR.Services.Solutions.Factories.Actions

##### Summary

Creates instances of objects that implement the
[IVisualStudioSolutionService](#T-MFR-Services-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService')
interface.

##### Remarks

This class is part of a fluent usage pattern and should be retained.

<a name='P-MFR-Services-Solutions-Factories-Actions-Does-VisualStudioSolutionService'></a>
### VisualStudioSolutionService `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IVisualStudioSolutionService](#T-MFR-Services-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService')
interface.

<a name='M-MFR-Services-Solutions-Factories-Actions-Does-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [Does](#T-MFR-Services-Solutions-Factories-Actions-Does 'MFR.Services.Solutions.Factories.Actions.Does') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-Services-Solutions-Factories-Actions-Does-Folder-System-String-'></a>
### Folder(folderToSearch) `method`

##### Summary

Builder extension method that initializes the
[FolderToSearch](#P-MFR-Services-Solutions-Interfaces-IVisualStudioSolutionService-FolderToSearch 'MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService.FolderToSearch')
property.

##### Returns

Reference to an instance of an object that implements the
[IVisualStudioSolutionService](#T-MFR-Services-Solutions-Interfaces-IVisualStudioSolutionService 'MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService')
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
the file system. |

<a name='T-MFR-Services-Solutions-Factories-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Services.Solutions.Factories.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Services-Solutions-Factories-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Services-Solutions-Factories-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
