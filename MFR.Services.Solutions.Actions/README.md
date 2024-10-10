<a name='assembly'></a>
# MFR.Services.Solutions.Actions

## Contents

- [Get](#T-MFR-Services-Solutions-Actions-Get 'MFR.Services.Solutions.Actions.Get')
  - [#cctor()](#M-MFR-Services-Solutions-Actions-Get-#cctor 'MFR.Services.Solutions.Actions.Get.#cctor')
  - [SolutionPathsInFolder(pathname)](#M-MFR-Services-Solutions-Actions-Get-SolutionPathsInFolder-System-String- 'MFR.Services.Solutions.Actions.Get.SolutionPathsInFolder(System.String)')
  - [SolutionThatInstanceHasOpen(instance)](#M-MFR-Services-Solutions-Actions-Get-SolutionThatInstanceHasOpen-xyLOGIX-VisualStudio-Instances-Interfaces-IVisualStudioInstanceMetadata- 'MFR.Services.Solutions.Actions.Get.SolutionThatInstanceHasOpen(xyLOGIX.VisualStudio.Instances.Interfaces.IVisualStudioInstanceMetadata)')
- [Is](#T-MFR-Services-Solutions-Actions-Is 'MFR.Services.Solutions.Actions.Is')
  - [Folder(pathname)](#M-MFR-Services-Solutions-Actions-Is-Folder-System-String- 'MFR.Services.Solutions.Actions.Is.Folder(System.String)')
- [Resources](#T-MFR-Services-Solutions-Actions-Properties-Resources 'MFR.Services.Solutions.Actions.Properties.Resources')
  - [Culture](#P-MFR-Services-Solutions-Actions-Properties-Resources-Culture 'MFR.Services.Solutions.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Services-Solutions-Actions-Properties-Resources-ResourceManager 'MFR.Services.Solutions.Actions.Properties.Resources.ResourceManager')
- [Should](#T-MFR-Services-Solutions-Actions-Should 'MFR.Services.Solutions.Actions.Should')
  - [SkipSolutionFile(pathname)](#M-MFR-Services-Solutions-Actions-Should-SkipSolutionFile-System-String- 'MFR.Services.Solutions.Actions.Should.SkipSolutionFile(System.String)')

<a name='T-MFR-Services-Solutions-Actions-Get'></a>
## Get `type`

##### Namespace

MFR.Services.Solutions.Actions

##### Summary

Exposes static methods, e.g., to get data sets from the system.

<a name='M-MFR-Services-Solutions-Actions-Get-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [Get](#T-MFR-Services-Solutions-Actions-Get 'MFR.Services.Solutions.Actions.Get') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-Services-Solutions-Actions-Get-SolutionPathsInFolder-System-String-'></a>
### SolutionPathsInFolder(pathname) `method`

##### Summary

Gets an enumerable collection of strings, each of which is the pathname of a
Visual Studio Solution (*.sln) file in the root folder that has the specified
`pathname`.

##### Returns

THe empty enumerable is returned if the specified
`pathname` is blank, or if an error occurs during the search
operation; otherwise, an enumerable collection of
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')s is returned, each element of which is the
pathname of a `*.sln` file in the folder having the specified
`pathname`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a folder in which to search. |

<a name='M-MFR-Services-Solutions-Actions-Get-SolutionThatInstanceHasOpen-xyLOGIX-VisualStudio-Instances-Interfaces-IVisualStudioInstanceMetadata-'></a>
### SolutionThatInstanceHasOpen(instance) `method`

##### Summary

Gets a reference to an instance of an object, implementing the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface, that represents a `Visual Studio Solution (*.sln)` file that is
currently open in the specified `instance` of Visual Studio,
if any.

##### Returns

If successful, a reference to an instance of an object that implements the
[IVisualStudioSolution](#T-xyLOGIX-VisualStudio-Solutions-Interfaces-IVisualStudioSolution 'xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution')
interface representing the `Visual Studio Solution (*.sln)` file that is
currently open in the specified `instance`; otherwise, a
`null` reference is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| instance | [xyLOGIX.VisualStudio.Instances.Interfaces.IVisualStudioInstanceMetadata](#T-xyLOGIX-VisualStudio-Instances-Interfaces-IVisualStudioInstanceMetadata 'xyLOGIX.VisualStudio.Instances.Interfaces.IVisualStudioInstanceMetadata') | (Required.) Reference to an instance of an object that implements the
[IVisualStudioInstanceMetadata](#T-xyLOGIX-VisualStudio-Instances-Interfaces-IVisualStudioInstanceMetadata 'xyLOGIX.VisualStudio.Instances.Interfaces.IVisualStudioInstanceMetadata')
interface representing a currently-open instance of Visual Studio. |

##### Remarks

This method also returns a `null` reference if the specified
`instance` of Visual Studio does not currently have a Visual
Studio Solution (`*.sln`)  file open in it.

<a name='T-MFR-Services-Solutions-Actions-Is'></a>
## Is `type`

##### Namespace

MFR.Services.Solutions.Actions

##### Summary

Exposes static methods to determine whether certain facts are true.

<a name='M-MFR-Services-Solutions-Actions-Is-Folder-System-String-'></a>
### Folder(pathname) `method`

##### Summary

Checks the specified `pathname` to check whether it's the
pathname of a folder that exists on the file system.

##### Returns

`true` if the `pathname` refers to
a folder that exists on the file system; `false` otherwise, or if the
`pathname` parameter's argument is a `null`
reference or a blank [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a folder that exists on the file system. |

<a name='T-MFR-Services-Solutions-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Services.Solutions.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Services-Solutions-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Services-Solutions-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Services-Solutions-Actions-Should'></a>
## Should `type`

##### Namespace

MFR.Services.Solutions.Actions

##### Summary

Exposes static methods that run rules to determine whether certain actions
should be taken on data.

<a name='M-MFR-Services-Solutions-Actions-Should-SkipSolutionFile-System-String-'></a>
### SkipSolutionFile(pathname) `method`

##### Summary

Determines whether a Visual Studio Solution (*.sln) file with the
`pathname` should be skipped in a search.

##### Returns

`true` if the `pathname` provided
should not be included in the results; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the pathname to be checked. |
