<a name='assembly'></a>
# MFR.Errors.Reports.Commands.Factories

## Contents

- [GetErrorReportCommand](#T-MFR-Errors-Reports-Commands-Factories-GetErrorReportCommand 'MFR.Errors.Reports.Commands.Factories.GetErrorReportCommand')
  - [For\`\`1()](#M-MFR-Errors-Reports-Commands-Factories-GetErrorReportCommand-For``1-MFR-Messages-Constants-MessageType- 'MFR.Errors.Reports.Commands.Factories.GetErrorReportCommand.For``1(MFR.Messages.Constants.MessageType)')
- [GetSendErrorReportCommand](#T-MFR-Errors-Reports-Commands-Factories-GetSendErrorReportCommand 'MFR.Errors.Reports.Commands.Factories.GetSendErrorReportCommand')
  - [#cctor()](#M-MFR-Errors-Reports-Commands-Factories-GetSendErrorReportCommand-#cctor 'MFR.Errors.Reports.Commands.Factories.GetSendErrorReportCommand.#cctor')
  - [SoleInstance()](#M-MFR-Errors-Reports-Commands-Factories-GetSendErrorReportCommand-SoleInstance 'MFR.Errors.Reports.Commands.Factories.GetSendErrorReportCommand.SoleInstance')
- [GetViewErrorReportWithNotepadCommand](#T-MFR-Errors-Reports-Commands-Factories-GetViewErrorReportWithNotepadCommand 'MFR.Errors.Reports.Commands.Factories.GetViewErrorReportWithNotepadCommand')
  - [#cctor()](#M-MFR-Errors-Reports-Commands-Factories-GetViewErrorReportWithNotepadCommand-#cctor 'MFR.Errors.Reports.Commands.Factories.GetViewErrorReportWithNotepadCommand.#cctor')
  - [SoleInstance()](#M-MFR-Errors-Reports-Commands-Factories-GetViewErrorReportWithNotepadCommand-SoleInstance 'MFR.Errors.Reports.Commands.Factories.GetViewErrorReportWithNotepadCommand.SoleInstance')
- [Resources](#T-MFR-Errors-Reports-Commands-Factories-Properties-Resources 'MFR.Errors.Reports.Commands.Factories.Properties.Resources')
  - [Culture](#P-MFR-Errors-Reports-Commands-Factories-Properties-Resources-Culture 'MFR.Errors.Reports.Commands.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Errors-Reports-Commands-Factories-Properties-Resources-ResourceManager 'MFR.Errors.Reports.Commands.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Errors-Reports-Commands-Factories-GetErrorReportCommand'></a>
## GetErrorReportCommand `type`

##### Namespace

MFR.Errors.Reports.Commands.Factories

##### Summary

Creates instances of objects that implement the
[ICommand](#T-MFR-ICommand 'MFR.ICommand')
interface, that define operations on the configuration file and its data.

##### Remarks

In our vernacular, a `command` object is an object that performs an
operation that accepts input, but has no output.

<a name='M-MFR-Errors-Reports-Commands-Factories-GetErrorReportCommand-For``1-MFR-Messages-Constants-MessageType-'></a>
### For\`\`1() `method`

##### Summary

Creates a new instance of an object that implements the
[ICommand](#T-MFR-ICommand 'MFR.ICommand')
interface and returns a reference to it.

##### Parameters

This method has no parameters.

<a name='T-MFR-Errors-Reports-Commands-Factories-GetSendErrorReportCommand'></a>
## GetSendErrorReportCommand `type`

##### Namespace

MFR.Errors.Reports.Commands.Factories

##### Summary

Creates instances of objects that implement the
[ICommand](#T-MFR-Messages-Commands-Interfaces-ICommand 'MFR.Messages.Commands.Interfaces.ICommand'), with a reference to
a [SendErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs') as
input, interface.

<a name='M-MFR-Errors-Reports-Commands-Factories-GetSendErrorReportCommand-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[GetSendErrorReportCommand](#T-MFR-Errors-Reports-Commands-Factories-GetSendErrorReportCommand 'MFR.Errors.Reports.Commands.Factories.GetSendErrorReportCommand')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-Errors-Reports-Commands-Factories-GetSendErrorReportCommand-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Creates a new instance of an object that implements the
[ICommand](#T-MFR-Messages-Commands-Interfaces-ICommand 'MFR.Messages.Commands.Interfaces.ICommand'), with a reference to
a [SendErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs') as
input, interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ICommand](#T-MFR-Messages-Commands-Interfaces-ICommand 'MFR.Messages.Commands.Interfaces.ICommand') interface with a
reference to a
[SendErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs') as
input.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object type requested is not supported. |

<a name='T-MFR-Errors-Reports-Commands-Factories-GetViewErrorReportWithNotepadCommand'></a>
## GetViewErrorReportWithNotepadCommand `type`

##### Namespace

MFR.Errors.Reports.Commands.Factories

##### Summary

Creates instances of objects that implement the
[ICommand](#T-MFR-Messages-Commands-Interfaces-ICommand 'MFR.Messages.Commands.Interfaces.ICommand'), with a reference to
a [ViewErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs') as
input, interface.

<a name='M-MFR-Errors-Reports-Commands-Factories-GetViewErrorReportWithNotepadCommand-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[GetViewErrorReportWithNotepadCommand](#T-MFR-Errors-Reports-Commands-Factories-GetViewErrorReportWithNotepadCommand 'MFR.Errors.Reports.Commands.Factories.GetViewErrorReportWithNotepadCommand')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-Errors-Reports-Commands-Factories-GetViewErrorReportWithNotepadCommand-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Creates a new instance of an object that implements the
[ICommand](#T-MFR-Messages-Commands-Interfaces-ICommand 'MFR.Messages.Commands.Interfaces.ICommand'), with a reference to
a [ViewErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs') as
input, interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ICommand](#T-MFR-Messages-Commands-Interfaces-ICommand 'MFR.Messages.Commands.Interfaces.ICommand') interface with a
reference to a
[ViewErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs') as
input.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if the object type requested is not supported. |

<a name='T-MFR-Errors-Reports-Commands-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Errors.Reports.Commands.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Errors-Reports-Commands-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Errors-Reports-Commands-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
