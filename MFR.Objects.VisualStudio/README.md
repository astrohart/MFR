<a name='assembly'></a>
# MFR.Objects.VisualStudio

## Contents

- [Resources](#T-MFR-Objects-VisualStudio-Properties-Resources 'MFR.Objects.VisualStudio.Properties.Resources')
  - [Culture](#P-MFR-Objects-VisualStudio-Properties-Resources-Culture 'MFR.Objects.VisualStudio.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-VisualStudio-Properties-Resources-ResourceManager 'MFR.Objects.VisualStudio.Properties.Resources.ResourceManager')
- [VisualStudioManager](#T-MFR-Objects-VisualStudio-VisualStudioManager 'MFR.Objects.VisualStudio.VisualStudioManager')
  - [_processIdProvider](#F-MFR-Objects-VisualStudio-VisualStudioManager-_processIdProvider 'MFR.Objects.VisualStudio.VisualStudioManager._processIdProvider')
  - [#cctor()](#M-MFR-Objects-VisualStudio-VisualStudioManager-#cctor 'MFR.Objects.VisualStudio.VisualStudioManager.#cctor')
  - [ConnectToRunningVisualStudio(pid)](#M-MFR-Objects-VisualStudio-VisualStudioManager-ConnectToRunningVisualStudio-System-Int32- 'MFR.Objects.VisualStudio.VisualStudioManager.ConnectToRunningVisualStudio(System.Int32)')
  - [GetVsProcessHavingSolutionOpened(path)](#M-MFR-Objects-VisualStudio-VisualStudioManager-GetVsProcessHavingSolutionOpened-System-String- 'MFR.Objects.VisualStudio.VisualStudioManager.GetVsProcessHavingSolutionOpened(System.String)')
  - [IsSolutionOpen(path)](#M-MFR-Objects-VisualStudio-VisualStudioManager-IsSolutionOpen-System-String- 'MFR.Objects.VisualStudio.VisualStudioManager.IsSolutionOpen(System.String)')

<a name='T-MFR-Objects-VisualStudio-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.VisualStudio.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-VisualStudio-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-VisualStudio-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-VisualStudio-VisualStudioManager'></a>
## VisualStudioManager `type`

##### Namespace

MFR.Objects.VisualStudio

##### Summary

Provides helper methods for interacting with Visual Studio.

<a name='F-MFR-Objects-VisualStudio-VisualStudioManager-_processIdProvider'></a>
### _processIdProvider `constants`

##### Summary

Reference to an instance of an object that implements the
[IProcessIdProvider](#T-MFR-Objects-IProcessIdProvider 'MFR.Objects.IProcessIdProvider')
interface and that
provides the ability to obtain the Process IDs (PIDs) of running
processes from the operating system.

<a name='M-MFR-Objects-VisualStudio-VisualStudioManager-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs messages that need to be
performed once only for the
[VisualStudioManager](#T-MFR-Objects-VisualStudio-VisualStudioManager 'MFR.Objects.VisualStudio.VisualStudioManager')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-MFR-Objects-VisualStudio-VisualStudioManager-ConnectToRunningVisualStudio-System-Int32-'></a>
### ConnectToRunningVisualStudio(pid) `method`

##### Summary

Attempts to connect to the instance of Visual Studio that is running
on the local machine, having the specified Process ID, `pid`.

##### Returns

Reference to an instance of an object that implements the
[DTE](#T-EnvDTE-DTE 'EnvDTE.DTE')
interface, or `null` if no
such running Visual Studio instance can be found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pid | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) A positive integer that is the Process ID of a running
instance of `devenv.exe`. |

<a name='M-MFR-Objects-VisualStudio-VisualStudioManager-GetVsProcessHavingSolutionOpened-System-String-'></a>
### GetVsProcessHavingSolutionOpened(path) `method`

##### Summary

Attempts to find the Visual Studio instance that has the solution
with pathname `path` currently loaded. Returns
`null`
if such an instance cannot be found.

##### Returns

Reference to an instance of the object that implements the
[DTE](#T-EnvDTE-DTE 'EnvDTE.DTE')
automation interface for the Visual Studio
instance that has the solution opened; `null` if
such an instance cannot be located.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of a
Visual Studio solution file. |

<a name='M-MFR-Objects-VisualStudio-VisualStudioManager-IsSolutionOpen-System-String-'></a>
### IsSolutionOpen(path) `method`

##### Summary

Determines whether the Visual Studio Solution with the specified
`path` is loaded in an existing instance of Visual Studio.

##### Returns

`true` if a running instance of Visual Studio has
the specified solution open; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of a
Visual Studio Solution (*.sln) file. |
