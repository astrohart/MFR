<a name='assembly'></a>
# MFR.Errors.Reports.Commands

## Contents

- [Resources](#T-MFR-Errors-Reports-Commands-Properties-Resources 'MFR.Errors.Reports.Commands.Properties.Resources')
  - [Culture](#P-MFR-Errors-Reports-Commands-Properties-Resources-Culture 'MFR.Errors.Reports.Commands.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Errors-Reports-Commands-Properties-Resources-ResourceManager 'MFR.Errors.Reports.Commands.Properties.Resources.ResourceManager')
- [ViewErrorReportWithNotepadCommand](#T-MFR-Errors-Reports-Commands-ViewErrorReportWithNotepadCommand 'MFR.Errors.Reports.Commands.ViewErrorReportWithNotepadCommand')
  - [#ctor()](#M-MFR-Errors-Reports-Commands-ViewErrorReportWithNotepadCommand-#ctor 'MFR.Errors.Reports.Commands.ViewErrorReportWithNotepadCommand.#ctor')
  - [Instance](#P-MFR-Errors-Reports-Commands-ViewErrorReportWithNotepadCommand-Instance 'MFR.Errors.Reports.Commands.ViewErrorReportWithNotepadCommand.Instance')
  - [MessageType](#P-MFR-Errors-Reports-Commands-ViewErrorReportWithNotepadCommand-MessageType 'MFR.Errors.Reports.Commands.ViewErrorReportWithNotepadCommand.MessageType')
  - [#cctor()](#M-MFR-Errors-Reports-Commands-ViewErrorReportWithNotepadCommand-#cctor 'MFR.Errors.Reports.Commands.ViewErrorReportWithNotepadCommand.#cctor')
  - [CommonExecute()](#M-MFR-Errors-Reports-Commands-ViewErrorReportWithNotepadCommand-CommonExecute 'MFR.Errors.Reports.Commands.ViewErrorReportWithNotepadCommand.CommonExecute')

<a name='T-MFR-Errors-Reports-Commands-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Errors.Reports.Commands.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Errors-Reports-Commands-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Errors-Reports-Commands-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Errors-Reports-Commands-ViewErrorReportWithNotepadCommand'></a>
## ViewErrorReportWithNotepadCommand `type`

##### Namespace

MFR.Errors.Reports.Commands

##### Summary

Instructs the application to launch a viewer of an error report.

<a name='M-MFR-Errors-Reports-Commands-ViewErrorReportWithNotepadCommand-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Errors-Reports-Commands-ViewErrorReportWithNotepadCommand-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[ViewErrorReportWithNotepadCommand](#T-MFR-Errors-Reports-Commands-ViewErrorReportWithNotepadCommand 'MFR.Errors.Reports.Commands.ViewErrorReportWithNotepadCommand').

<a name='P-MFR-Errors-Reports-Commands-ViewErrorReportWithNotepadCommand-MessageType'></a>
### MessageType `property`

##### Summary

Gets the
[MessageType](#T-MFR-MessageType 'MFR.MessageType')
that is
being used to identify which message this.

<a name='M-MFR-Errors-Reports-Commands-ViewErrorReportWithNotepadCommand-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Errors-Reports-Commands-ViewErrorReportWithNotepadCommand-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

##### Remarks

Implementers must override this method in order to return this
object's functionality.
