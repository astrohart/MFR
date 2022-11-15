<a name='assembly'></a>
# MFR.Managers.Solutions.Actions.Constants

## Contents

- [Resources](#T-MFR-Managers-Solutions-Actions-Constants-Properties-Resources 'MFR.Managers.Solutions.Actions.Constants.Properties.Resources')
  - [Culture](#P-MFR-Managers-Solutions-Actions-Constants-Properties-Resources-Culture 'MFR.Managers.Solutions.Actions.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Managers-Solutions-Actions-Constants-Properties-Resources-ResourceManager 'MFR.Managers.Solutions.Actions.Constants.Properties.Resources.ResourceManager')
- [VisualStudioSolutionServiceActionType](#T-MFR-Managers-Solutions-Actions-Constants-VisualStudioSolutionServiceActionType 'MFR.Managers.Solutions.Actions.Constants.VisualStudioSolutionServiceActionType')
  - [#ctor(messageId)](#M-MFR-Managers-Solutions-Actions-Constants-VisualStudioSolutionServiceActionType-#ctor-System-Guid- 'MFR.Managers.Solutions.Actions.Constants.VisualStudioSolutionServiceActionType.#ctor(System.Guid)')
  - [#ctor(description,messageId)](#M-MFR-Managers-Solutions-Actions-Constants-VisualStudioSolutionServiceActionType-#ctor-System-Guid,System-String- 'MFR.Managers.Solutions.Actions.Constants.VisualStudioSolutionServiceActionType.#ctor(System.Guid,System.String)')
  - [LoadAllSolutionsInFolder](#F-MFR-Managers-Solutions-Actions-Constants-VisualStudioSolutionServiceActionType-LoadAllSolutionsInFolder 'MFR.Managers.Solutions.Actions.Constants.VisualStudioSolutionServiceActionType.LoadAllSolutionsInFolder')
  - [Unknown](#F-MFR-Managers-Solutions-Actions-Constants-VisualStudioSolutionServiceActionType-Unknown 'MFR.Managers.Solutions.Actions.Constants.VisualStudioSolutionServiceActionType.Unknown')
  - [UnloadAllSolutionsInFolder](#F-MFR-Managers-Solutions-Actions-Constants-VisualStudioSolutionServiceActionType-UnloadAllSolutionsInFolder 'MFR.Managers.Solutions.Actions.Constants.VisualStudioSolutionServiceActionType.UnloadAllSolutionsInFolder')

<a name='T-MFR-Managers-Solutions-Actions-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Managers.Solutions.Actions.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Managers-Solutions-Actions-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Managers-Solutions-Actions-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Managers-Solutions-Actions-Constants-VisualStudioSolutionServiceActionType'></a>
## VisualStudioSolutionServiceActionType `type`

##### Namespace

MFR.Managers.Solutions.Actions.Constants

##### Summary

Defines names for the types of actions that can be performed on
`Visual Studio Solution Service` objects.

<a name='M-MFR-Managers-Solutions-Actions-Constants-VisualStudioSolutionServiceActionType-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[VisualStudioSolutionAction](#T-MFR-Managers-Solutions-Actions-Constants-VisualStudioSolutionAction 'MFR.Managers.Solutions.Actions.Constants.VisualStudioSolutionAction')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='M-MFR-Managers-Solutions-Actions-Constants-VisualStudioSolutionServiceActionType-#ctor-System-Guid,System-String-'></a>
### #ctor(description,messageId) `constructor`

##### Summary

Constructs a new instance of
[VisualStudioSolutionServiceActionType](#T-MFR-Managers-Solutions-Actions-Constants-VisualStudioSolutionServiceActionType 'MFR.Managers.Solutions.Actions.Constants.VisualStudioSolutionServiceActionType')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a user-friendly
descriptive name for this message type. |
| messageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-Managers-Solutions-Actions-Constants-VisualStudioSolutionServiceActionType-LoadAllSolutionsInFolder'></a>
### LoadAllSolutionsInFolder `constants`

##### Summary

Loads all the `*.sln` files in a given folder into separate instances
of Visual Studio.

<a name='F-MFR-Managers-Solutions-Actions-Constants-VisualStudioSolutionServiceActionType-Unknown'></a>
### Unknown `constants`

##### Summary

Unknown action.

<a name='F-MFR-Managers-Solutions-Actions-Constants-VisualStudioSolutionServiceActionType-UnloadAllSolutionsInFolder'></a>
### UnloadAllSolutionsInFolder `constants`

##### Summary

Unloads all the `*.sln` files in a given folder that also happen to be
loaded in instances of Visual Studio.
