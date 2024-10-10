<a name='assembly'></a>
# MFR.Errors.Reports.Commands.Constants

## Contents

- [ErrorReportCommandType](#T-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType 'MFR.Errors.Reports.Commands.Constants.ErrorReportCommandType')
  - [#ctor(messageId)](#M-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType-#ctor-System-Guid- 'MFR.Errors.Reports.Commands.Constants.ErrorReportCommandType.#ctor(System.Guid)')
  - [#ctor(description,messageId)](#M-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType-#ctor-System-Guid,System-String- 'MFR.Errors.Reports.Commands.Constants.ErrorReportCommandType.#ctor(System.Guid,System.String)')
  - [SendErrorReport](#F-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType-SendErrorReport 'MFR.Errors.Reports.Commands.Constants.ErrorReportCommandType.SendErrorReport')
  - [ViewErrorReportWithNotepad](#F-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType-ViewErrorReportWithNotepad 'MFR.Errors.Reports.Commands.Constants.ErrorReportCommandType.ViewErrorReportWithNotepad')
  - [#cctor()](#M-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType-#cctor 'MFR.Errors.Reports.Commands.Constants.ErrorReportCommandType.#cctor')
- [Resources](#T-MFR-Errors-Reports-Commands-Constants-Properties-Resources 'MFR.Errors.Reports.Commands.Constants.Properties.Resources')
  - [Culture](#P-MFR-Errors-Reports-Commands-Constants-Properties-Resources-Culture 'MFR.Errors.Reports.Commands.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Errors-Reports-Commands-Constants-Properties-Resources-ResourceManager 'MFR.Errors.Reports.Commands.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType'></a>
## ErrorReportCommandType `type`

##### Namespace

MFR.Errors.Reports.Commands.Constants

##### Summary

Available commands for use when working with error reports.

<a name='M-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType-#ctor-System-Guid-'></a>
### #ctor(messageId) `constructor`

##### Summary

Constructs a new instance of
[ErrorReportCommandType](#T-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType 'MFR.Errors.Reports.Commands.Constants.ErrorReportCommandType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='M-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType-#ctor-System-Guid,System-String-'></a>
### #ctor(description,messageId) `constructor`

##### Summary

Constructs a new instance of
[ErrorReportCommandType](#T-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType 'MFR.Errors.Reports.Commands.Constants.ErrorReportCommandType')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a user-friendly
descriptive name for this message type. |
| messageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) Reference to an instance of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid')
that provides a unique identifier to be associated with this instance. |

<a name='F-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType-SendErrorReport'></a>
### SendErrorReport `constants`

##### Summary

Sends an error report.

<a name='F-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType-ViewErrorReportWithNotepad'></a>
### ViewErrorReportWithNotepad `constants`

##### Summary

Views the error report requested using Notepad.

<a name='M-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[ErrorReportCommandType](#T-MFR-Errors-Reports-Commands-Constants-ErrorReportCommandType 'MFR.Errors.Reports.Commands.Constants.ErrorReportCommandType')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

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
