<a name='assembly'></a>
# MFR.Errors.Reports.Commands.Constants

## Contents

- [ErrorReportCommand](#T-MFR-Errors-Reports-Commands-Constants-ErrorReportCommand 'MFR.Errors.Reports.Commands.Constants.ErrorReportCommand')
  - [#ctor(messageId)](#M-MFR-Errors-Reports-Commands-Constants-ErrorReportCommand-#ctor-System-Guid- 'MFR.Errors.Reports.Commands.Constants.ErrorReportCommand.#ctor(System.Guid)')
  - [SendErrorReport](#F-MFR-Errors-Reports-Commands-Constants-ErrorReportCommand-SendErrorReport 'MFR.Errors.Reports.Commands.Constants.ErrorReportCommand.SendErrorReport')
  - [ViewErrorReportWithNotepad](#F-MFR-Errors-Reports-Commands-Constants-ErrorReportCommand-ViewErrorReportWithNotepad 'MFR.Errors.Reports.Commands.Constants.ErrorReportCommand.ViewErrorReportWithNotepad')
- [Resources](#T-MFR-Errors-Reports-Commands-Constants-Properties-Resources 'MFR.Errors.Reports.Commands.Constants.Properties.Resources')
  - [Culture](#P-MFR-Errors-Reports-Commands-Constants-Properties-Resources-Culture 'MFR.Errors.Reports.Commands.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Errors-Reports-Commands-Constants-Properties-Resources-ResourceManager 'MFR.Errors.Reports.Commands.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Errors-Reports-Commands-Constants-ErrorReportCommand'></a>
## ErrorReportCommand `type`

##### Namespace

MFR.Errors.Reports.Commands.Constants

##### Summary

Available commands for use when working with error reports.

<a name='M-MFR-Errors-Reports-Commands-Constants-ErrorReportCommand-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[ErrorReportCommand](#T-MFR-Errors-Reports-Commands-Constants-ErrorReportCommand 'MFR.Errors.Reports.Commands.Constants.ErrorReportCommand')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-Errors-Reports-Commands-Constants-ErrorReportCommand-SendErrorReport'></a>
### SendErrorReport `constants`

##### Summary

Sends an error report.

<a name='F-MFR-Errors-Reports-Commands-Constants-ErrorReportCommand-ViewErrorReportWithNotepad'></a>
### ViewErrorReportWithNotepad `constants`

##### Summary

Views the error report requested using Notepad.

<a name='T-MFR-Errors-Reports-Commands-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Errors.Reports.Commands.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Errors-Reports-Commands-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Errors-Reports-Commands-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
