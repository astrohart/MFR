<a name='assembly'></a>
# MFR.GUI.Dialogs.Factories

## Contents

- [GetAutoStartCancellableProgressDialog](#T-MFR-GUI-Dialogs-Factories-GetAutoStartCancellableProgressDialog 'MFR.GUI.Dialogs.Factories.GetAutoStartCancellableProgressDialog')
  - [SoleInstance()](#M-MFR-GUI-Dialogs-Factories-GetAutoStartCancellableProgressDialog-SoleInstance 'MFR.GUI.Dialogs.Factories.GetAutoStartCancellableProgressDialog.SoleInstance')
- [MakeNewCancellableProgressDialog](#T-MFR-GUI-Dialogs-Factories-MakeNewCancellableProgressDialog 'MFR.GUI.Dialogs.Factories.MakeNewCancellableProgressDialog')
  - [FromScratch()](#M-MFR-GUI-Dialogs-Factories-MakeNewCancellableProgressDialog-FromScratch 'MFR.GUI.Dialogs.Factories.MakeNewCancellableProgressDialog.FromScratch')
- [MakeNewCustomizeOperationsDialog](#T-MFR-GUI-Dialogs-Factories-MakeNewCustomizeOperationsDialog 'MFR.GUI.Dialogs.Factories.MakeNewCustomizeOperationsDialog')
  - [FromScratch()](#M-MFR-GUI-Dialogs-Factories-MakeNewCustomizeOperationsDialog-FromScratch 'MFR.GUI.Dialogs.Factories.MakeNewCustomizeOperationsDialog.FromScratch')
- [MakeNewErrorReportDialog](#T-MFR-GUI-Dialogs-Factories-MakeNewErrorReportDialog 'MFR.GUI.Dialogs.Factories.MakeNewErrorReportDialog')
  - [AttachSendErrorReportRequestedEventHandler(self,handler)](#M-MFR-GUI-Dialogs-Factories-MakeNewErrorReportDialog-AttachSendErrorReportRequestedEventHandler-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog,MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventHandler- 'MFR.GUI.Dialogs.Factories.MakeNewErrorReportDialog.AttachSendErrorReportRequestedEventHandler(MFR.GUI.Dialogs.Interfaces.IErrorReportDialog,MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler)')
  - [AttachViewErrorReportRequestedEventHandler(self,handler)](#M-MFR-GUI-Dialogs-Factories-MakeNewErrorReportDialog-AttachViewErrorReportRequestedEventHandler-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog,MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventHandler- 'MFR.GUI.Dialogs.Factories.MakeNewErrorReportDialog.AttachViewErrorReportRequestedEventHandler(MFR.GUI.Dialogs.Interfaces.IErrorReportDialog,MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventHandler)')
  - [ForException(self,exception)](#M-MFR-GUI-Dialogs-Factories-MakeNewErrorReportDialog-ForException-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog,System-Exception- 'MFR.GUI.Dialogs.Factories.MakeNewErrorReportDialog.ForException(MFR.GUI.Dialogs.Interfaces.IErrorReportDialog,System.Exception)')
  - [FromScratch()](#M-MFR-GUI-Dialogs-Factories-MakeNewErrorReportDialog-FromScratch 'MFR.GUI.Dialogs.Factories.MakeNewErrorReportDialog.FromScratch')
- [MakeNewOperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-Factories-MakeNewOperationDrivenProgressDialog 'MFR.GUI.Dialogs.Factories.MakeNewOperationDrivenProgressDialog')
  - [AndArgument(self,argument)](#M-MFR-GUI-Dialogs-Factories-MakeNewOperationDrivenProgressDialog-AndArgument-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog,System-Object- 'MFR.GUI.Dialogs.Factories.MakeNewOperationDrivenProgressDialog.AndArgument(MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog,System.Object)')
  - [AndStatusText(self,statusText)](#M-MFR-GUI-Dialogs-Factories-MakeNewOperationDrivenProgressDialog-AndStatusText-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog,System-String- 'MFR.GUI.Dialogs.Factories.MakeNewOperationDrivenProgressDialog.AndStatusText(MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog,System.String)')
  - [FromScratch()](#M-MFR-GUI-Dialogs-Factories-MakeNewOperationDrivenProgressDialog-FromScratch 'MFR.GUI.Dialogs.Factories.MakeNewOperationDrivenProgressDialog.FromScratch')
  - [HavingProc(self,proc)](#M-MFR-GUI-Dialogs-Factories-MakeNewOperationDrivenProgressDialog-HavingProc-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog,System-Func{System-Object,System-Object}- 'MFR.GUI.Dialogs.Factories.MakeNewOperationDrivenProgressDialog.HavingProc(MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog,System.Func{System.Object,System.Object})')
  - [HavingProc(self,proc)](#M-MFR-GUI-Dialogs-Factories-MakeNewOperationDrivenProgressDialog-HavingProc-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog,System-Delegate- 'MFR.GUI.Dialogs.Factories.MakeNewOperationDrivenProgressDialog.HavingProc(MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog,System.Delegate)')
- [MakeNewProfileNameDialog](#T-MFR-GUI-Dialogs-Factories-MakeNewProfileNameDialog 'MFR.GUI.Dialogs.Factories.MakeNewProfileNameDialog')
  - [ForProfileCreateOperationType(self,type)](#M-MFR-GUI-Dialogs-Factories-MakeNewProfileNameDialog-ForProfileCreateOperationType-MFR-GUI-Dialogs-Interfaces-IProfileNameDialog,MFR-GUI-Dialogs-Constants-ProfileCreateOperationType- 'MFR.GUI.Dialogs.Factories.MakeNewProfileNameDialog.ForProfileCreateOperationType(MFR.GUI.Dialogs.Interfaces.IProfileNameDialog,MFR.GUI.Dialogs.Constants.ProfileCreateOperationType)')
  - [FromScratch()](#M-MFR-GUI-Dialogs-Factories-MakeNewProfileNameDialog-FromScratch 'MFR.GUI.Dialogs.Factories.MakeNewProfileNameDialog.FromScratch')
- [MakeNewProgressDialog](#T-MFR-GUI-Dialogs-Factories-MakeNewProgressDialog 'MFR.GUI.Dialogs.Factories.MakeNewProgressDialog')
  - [FromScratch()](#M-MFR-GUI-Dialogs-Factories-MakeNewProgressDialog-FromScratch 'MFR.GUI.Dialogs.Factories.MakeNewProgressDialog.FromScratch')
- [Resources](#T-MFR-GUI-Dialogs-Factories-Properties-Resources 'MFR.GUI.Dialogs.Factories.Properties.Resources')
  - [Culture](#P-MFR-GUI-Dialogs-Factories-Properties-Resources-Culture 'MFR.GUI.Dialogs.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Dialogs-Factories-Properties-Resources-ResourceManager 'MFR.GUI.Dialogs.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Dialogs-Factories-GetAutoStartCancellableProgressDialog'></a>
## GetAutoStartCancellableProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IAutoStartCancellableProgressDialog](#T-MFR-GUI-Dialogs-IAutoStartCancellableProgressDialog 'MFR.GUI.Dialogs.IAutoStartCancellableProgressDialog') interface.

<a name='M-MFR-GUI-Dialogs-Factories-GetAutoStartCancellableProgressDialog-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IAutoStartCancellableProgressDialog](#T-MFR-GUI-Dialogs-IAutoStartCancellableProgressDialog 'MFR.GUI.Dialogs.IAutoStartCancellableProgressDialog') interface,
and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IAutoStartCancellableProgressDialog](#T-MFR-GUI-Dialogs-IAutoStartCancellableProgressDialog 'MFR.GUI.Dialogs.IAutoStartCancellableProgressDialog') interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-Factories-MakeNewCancellableProgressDialog'></a>
## MakeNewCancellableProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs.Factories

##### Summary

Creates new instances of objects that implement the
[ICancellableProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-ICancellableProgressDialog 'MFR.GUI.Dialogs.Interfaces.ICancellableProgressDialog')
interface, and
returns references to them.

<a name='M-MFR-GUI-Dialogs-Factories-MakeNewCancellableProgressDialog-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[ICancellableProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-ICancellableProgressDialog 'MFR.GUI.Dialogs.Interfaces.ICancellableProgressDialog')
interface and
returns a reference to it.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-Factories-MakeNewCustomizeOperationsDialog'></a>
## MakeNewCustomizeOperationsDialog `type`

##### Namespace

MFR.GUI.Dialogs.Factories

##### Summary

Creates new instances of objects that implement the
[ICustomizeOperationsDialog](#T-MFR-GUI-Dialogs-Interfaces-ICustomizeOperationsDialog 'MFR.GUI.Dialogs.Interfaces.ICustomizeOperationsDialog')
interface, and returns references to them.

<a name='M-MFR-GUI-Dialogs-Factories-MakeNewCustomizeOperationsDialog-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[ICustomizeOperationsDialog](#T-MFR-GUI-Dialogs-Interfaces-ICustomizeOperationsDialog 'MFR.GUI.Dialogs.Interfaces.ICustomizeOperationsDialog')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ICustomizeOperationsDialog](#T-MFR-GUI-Dialogs-Interfaces-ICustomizeOperationsDialog 'MFR.GUI.Dialogs.Interfaces.ICustomizeOperationsDialog')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-Factories-MakeNewErrorReportDialog'></a>
## MakeNewErrorReportDialog `type`

##### Namespace

MFR.GUI.Dialogs.Factories

##### Summary

Creates new instances of objects that implement the
[IErrorReportDialog](#T-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog') interface, and
returns references to them.

<a name='M-MFR-GUI-Dialogs-Factories-MakeNewErrorReportDialog-AttachSendErrorReportRequestedEventHandler-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog,MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventHandler-'></a>
### AttachSendErrorReportRequestedEventHandler(self,handler) `method`

##### Summary

Attaches a handler for the
[](#E-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog-SendErrorReportRequested 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog.SendErrorReportRequested')
event.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Dialogs.Interfaces.IErrorReportDialog](#T-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog') | (Required.) Reference to an instance of an object that
implements the [IErrorReportDialog](#T-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog')
interface. |
| handler | [MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventHandler 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler') | Reference to a delegate of the
[SendErrorReportRequestedEventHandler](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventHandler 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler')
type.



This delegate is a callback to a method that will implement
application-specific behavior. |

<a name='M-MFR-GUI-Dialogs-Factories-MakeNewErrorReportDialog-AttachViewErrorReportRequestedEventHandler-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog,MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventHandler-'></a>
### AttachViewErrorReportRequestedEventHandler(self,handler) `method`

##### Summary

Attaches a handler for the
[](#E-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog-ViewErrorReportRequested 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog.ViewErrorReportRequested')
event.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Dialogs.Interfaces.IErrorReportDialog](#T-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog') | (Required.) Reference to an instance of an object that
implements the [IErrorReportDialog](#T-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog')
interface. |
| handler | [MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventHandler](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventHandler 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventHandler') | Reference to a delegate of the
[ViewErrorReportRequestedEventHandler](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventHandler 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventHandler')
type.



This delegate is a callback to a method that will implement
application-specific behavior. |

<a name='M-MFR-GUI-Dialogs-Factories-MakeNewErrorReportDialog-ForException-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog,System-Exception-'></a>
### ForException(self,exception) `method`

##### Summary

Builder extension method that initializes the
[IErrorReportDialog](#P-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Dialogs.Interfaces.IErrorReportDialog](#T-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog') | (Required.) Reference to an instance of an object that implements
the
[IErrorReportDialog](#T-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog')
interface. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) A [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes the error being
reported. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-GUI-Dialogs-Factories-MakeNewErrorReportDialog-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IErrorReportDialog](#T-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog') interface and
returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IErrorReportDialog](#T-MFR-GUI-Dialogs-Interfaces-IErrorReportDialog 'MFR.GUI.Dialogs.Interfaces.IErrorReportDialog') interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-Factories-MakeNewOperationDrivenProgressDialog'></a>
## MakeNewOperationDrivenProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs.Factories

##### Summary

Creates new instances of objects that implement the
[IOperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog')
interface, and returns references to them.

<a name='M-MFR-GUI-Dialogs-Factories-MakeNewOperationDrivenProgressDialog-AndArgument-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog,System-Object-'></a>
### AndArgument(self,argument) `method`

##### Summary

Builder extension method that initializes the
[Argument](#P-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog-Argument 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Argument')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog') | (Required.) Reference to an instance of an object that implements
the
[IOperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog')
interface. |
| argument | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) An object that should be passed to the code that is to be executed
by the dialog box, as an argument. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-GUI-Dialogs-Factories-MakeNewOperationDrivenProgressDialog-AndStatusText-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog,System-String-'></a>
### AndStatusText(self,statusText) `method`

##### Summary

Builder extension method that initializes the
[Status](#P-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog-Status 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Status')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog') | (Required.) Reference to an instance of an object that implements
the
[IOperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog')
interface. |
| statusText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to be displayed in the dialog box while
it is being displayed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-GUI-Dialogs-Factories-MakeNewOperationDrivenProgressDialog-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IOperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IOperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog')
interface.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Dialogs-Factories-MakeNewOperationDrivenProgressDialog-HavingProc-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog,System-Func{System-Object,System-Object}-'></a>
### HavingProc(self,proc) `method`

##### Summary

Builder extension method that initializes the
[Proc](#P-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog-Proc 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Proc')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog') | (Required.) Reference to an instance of an object that implements
the
[IOperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog')
interface. |
| proc | [System.Func{System.Object,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Object,System.Object}') | (Required.) A [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func') delegate that specifies code that is
to be executed when the dialog is to be displayed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-GUI-Dialogs-Factories-MakeNewOperationDrivenProgressDialog-HavingProc-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog,System-Delegate-'></a>
### HavingProc(self,proc) `method`

##### Summary

Builder extension method that initializes the
[Proc](#P-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog-Proc 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Proc')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog') | (Required.) Reference to an instance of an object that implements
the
[IOperationDrivenProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-IOperationDrivenProgressDialog 'MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog')
interface. |
| proc | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | (Required.) A [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func') delegate that specifies code that is
to be executed when the dialog is to be displayed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='T-MFR-GUI-Dialogs-Factories-MakeNewProfileNameDialog'></a>
## MakeNewProfileNameDialog `type`

##### Namespace

MFR.GUI.Dialogs.Factories

##### Summary

Creates new instances of objects that implement the
[IProfileNameDialog](#T-MFR-GUI-Dialogs-Interfaces-IProfileNameDialog 'MFR.GUI.Dialogs.Interfaces.IProfileNameDialog') interface, and
returns references to them.

<a name='M-MFR-GUI-Dialogs-Factories-MakeNewProfileNameDialog-ForProfileCreateOperationType-MFR-GUI-Dialogs-Interfaces-IProfileNameDialog,MFR-GUI-Dialogs-Constants-ProfileCreateOperationType-'></a>
### ForProfileCreateOperationType(self,type) `method`

##### Summary

Builder extension method that initializes the
[OperationType](#P-MFR-GUI-Dialogs-Interfaces-IProfileNameDialog-OperationType 'MFR.GUI.Dialogs.Interfaces.IProfileNameDialog.OperationType')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Dialogs.Interfaces.IProfileNameDialog](#T-MFR-GUI-Dialogs-Interfaces-IProfileNameDialog 'MFR.GUI.Dialogs.Interfaces.IProfileNameDialog') | (Required.) Reference to an instance of an object that implements
the
[IProfileNameDialog](#T-MFR-GUI-Dialogs-Interfaces-IProfileNameDialog 'MFR.GUI.Dialogs.Interfaces.IProfileNameDialog')
interface. |
| type | [MFR.GUI.Dialogs.Constants.ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') | (Required.) A
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') value
that specifies the type of profile-creation operation that is being performed
(New, Save As). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-GUI-Dialogs-Factories-MakeNewProfileNameDialog-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IProfileNameDialog](#T-MFR-GUI-Dialogs-Interfaces-IProfileNameDialog 'MFR.GUI.Dialogs.Interfaces.IProfileNameDialog') interface and
returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IProfileNameDialog](#T-MFR-GUI-Dialogs-Interfaces-IProfileNameDialog 'MFR.GUI.Dialogs.Interfaces.IProfileNameDialog') interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-Factories-MakeNewProgressDialog'></a>
## MakeNewProgressDialog `type`

##### Namespace

MFR.GUI.Dialogs.Factories

##### Summary

Creates new instances of objects that implement the
[ICancellableProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-ICancellableProgressDialog 'MFR.GUI.Dialogs.Interfaces.ICancellableProgressDialog')
interface, and
returns references to them.

<a name='M-MFR-GUI-Dialogs-Factories-MakeNewProgressDialog-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[ICancellableProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-ICancellableProgressDialog 'MFR.GUI.Dialogs.Interfaces.ICancellableProgressDialog')
interface and
returns a reference to it.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Dialogs-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Dialogs.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Dialogs-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Dialogs-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
