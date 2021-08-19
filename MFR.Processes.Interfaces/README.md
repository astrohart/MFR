<a name='assembly'></a>
# MFR.Objects.Processes.Interfaces

## Contents

- [IProcessIdProvider](#T-MFR-Objects-Processes-Interfaces-IProcessIdProvider 'MFR.Objects.Processes.Interfaces.IProcessIdProvider')
  - [GetAllProcessIDsOf(path)](#M-MFR-Objects-Processes-Interfaces-IProcessIdProvider-GetAllProcessIDsOf-System-String- 'MFR.Objects.Processes.Interfaces.IProcessIdProvider.GetAllProcessIDsOf(System.String)')
  - [GetProcessIDOf(path)](#M-MFR-Objects-Processes-Interfaces-IProcessIdProvider-GetProcessIDOf-System-String- 'MFR.Objects.Processes.Interfaces.IProcessIdProvider.GetProcessIDOf(System.String)')
- [Resources](#T-MFR-Objects-Processes-Interfaces-Properties-Resources 'MFR.Objects.Processes.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Processes-Interfaces-Properties-Resources-Culture 'MFR.Objects.Processes.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Processes-Interfaces-Properties-Resources-ResourceManager 'MFR.Objects.Processes.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Processes-Interfaces-IProcessIdProvider'></a>
## IProcessIdProvider `type`

##### Namespace

MFR.Objects.Processes.Interfaces

##### Summary

Defines the public-exposed methods and properties of an object that
provides the process ID (PID) of a running process.

<a name='M-MFR-Objects-Processes-Interfaces-IProcessIdProvider-GetAllProcessIDsOf-System-String-'></a>
### GetAllProcessIDsOf(path) `method`

##### Summary

Gets a collection of integers representing the process IDs of all the currently-executing instances of the .exe file with the specified `path`.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the filename or fully-qualified
pathname, of hte .exe file that you think is currently a running process. |

<a name='M-MFR-Objects-Processes-Interfaces-IProcessIdProvider-GetProcessIDOf-System-String-'></a>
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

<a name='T-MFR-Objects-Processes-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Processes.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Processes-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Processes-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
