<a name='assembly'></a>
# MFR.Objects.Processes

## Contents

- [ProcessIdProvider](#T-MFR-Objects-Processes-ProcessIdProvider 'MFR.Objects.Processes.ProcessIdProvider')
  - [GetAllProcessIDsOf(path)](#M-MFR-Objects-Processes-ProcessIdProvider-GetAllProcessIDsOf-System-String- 'MFR.Objects.Processes.ProcessIdProvider.GetAllProcessIDsOf(System.String)')
  - [GetProcessIDOf(path)](#M-MFR-Objects-Processes-ProcessIdProvider-GetProcessIDOf-System-String- 'MFR.Objects.Processes.ProcessIdProvider.GetProcessIDOf(System.String)')
- [Resources](#T-MFR-Objects-Processes-Properties-Resources 'MFR.Objects.Processes.Properties.Resources')
  - [Culture](#P-MFR-Objects-Processes-Properties-Resources-Culture 'MFR.Objects.Processes.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Processes-Properties-Resources-ResourceManager 'MFR.Objects.Processes.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Processes-ProcessIdProvider'></a>
## ProcessIdProvider `type`

##### Namespace

MFR.Objects.Processes

##### Summary

Provides the Process IDs (PIDs) of programs that are running on the
local machine.

<a name='M-MFR-Objects-Processes-ProcessIdProvider-GetAllProcessIDsOf-System-String-'></a>
### GetAllProcessIDsOf(path) `method`

##### Summary

Gets a collection of integers representing the process IDs of all
the currently-executing instances of the .exe file with the
specified `path`.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the filename or fully-qualified
pathname, of hte .exe file that you think is currently a running process. |

<a name='M-MFR-Objects-Processes-ProcessIdProvider-GetProcessIDOf-System-String-'></a>
### GetProcessIDOf(path) `method`

##### Summary

Gets the Process ID (PID) of the running process with the .exe file
with the `path` specified.

##### Returns

Integer whose value is set to the ID of the first process whose .exe
filename matches the specified `path`; `-1` if
no matches can be found. Process IDs are always positive integers.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the filename or fully-qualified
pathname, of hte .exe file that you think is currently a running process. |

<a name='T-MFR-Objects-Processes-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Processes.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Processes-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Processes-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
