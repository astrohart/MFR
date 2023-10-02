<a name='assembly'></a>
# MFR.Renamers.Files.Actions.Win32

## Contents

- [RM_UNIQUE_PROCESS](#T-MFR-Renamers-Files-Actions-Win32-RM_UNIQUE_PROCESS 'MFR.Renamers.Files.Actions.Win32.RM_UNIQUE_PROCESS')
  - [ProcessStartTime](#F-MFR-Renamers-Files-Actions-Win32-RM_UNIQUE_PROCESS-ProcessStartTime 'MFR.Renamers.Files.Actions.Win32.RM_UNIQUE_PROCESS.ProcessStartTime')
  - [dwProcessId](#F-MFR-Renamers-Files-Actions-Win32-RM_UNIQUE_PROCESS-dwProcessId 'MFR.Renamers.Files.Actions.Win32.RM_UNIQUE_PROCESS.dwProcessId')
- [Resources](#T-MFR-Renamers-Files-Actions-Win32-Properties-Resources 'MFR.Renamers.Files.Actions.Win32.Properties.Resources')
  - [Culture](#P-MFR-Renamers-Files-Actions-Win32-Properties-Resources-Culture 'MFR.Renamers.Files.Actions.Win32.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Renamers-Files-Actions-Win32-Properties-Resources-ResourceManager 'MFR.Renamers.Files.Actions.Win32.Properties.Resources.ResourceManager')

<a name='T-MFR-Renamers-Files-Actions-Win32-RM_UNIQUE_PROCESS'></a>
## RM_UNIQUE_PROCESS `type`

##### Namespace

MFR.Renamers.Files.Actions.Win32

##### Summary

Uniquely identifies a process by its `PID` and the time the process began.
An array of `RM_UNIQUE_PROCESS` structures can be passed to the
`RmRegisterResources`
function.

<a name='F-MFR-Renamers-Files-Actions-Win32-RM_UNIQUE_PROCESS-ProcessStartTime'></a>
### ProcessStartTime `constants`

##### Summary

The creation time of the process. The time is provided as a `FILETIME`
structure that is returned by the `lpCreationTime` parameter of the
`GetProcessTimes` function.

<a name='F-MFR-Renamers-Files-Actions-Win32-RM_UNIQUE_PROCESS-dwProcessId'></a>
### dwProcessId `constants`

##### Summary

The process identifier (PID).

<a name='T-MFR-Renamers-Files-Actions-Win32-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Renamers.Files.Actions.Win32.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Renamers-Files-Actions-Win32-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Renamers-Files-Actions-Win32-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
