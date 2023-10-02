<a name='assembly'></a>
# MFR.GUI.Launchers.Dialogs.Params.Factories

## Contents

- [MakeNewDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Factories.MakeNewDialogLaunchParams')
  - [AndOwnerWindow(self,owner)](#M-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewDialogLaunchParams-AndOwnerWindow-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IDialogLaunchParams,System-Windows-Forms-IWin32Window- 'MFR.GUI.Launchers.Dialogs.Params.Factories.MakeNewDialogLaunchParams.AndOwnerWindow(MFR.GUI.Launchers.Dialogs.Params.Interfaces.IDialogLaunchParams,System.Windows.Forms.IWin32Window)')
- [MakeNewErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Factories.MakeNewErrorReportDialogLaunchParams')
  - [AndAttachSendErrorReportRequestedEventHandler(self,handler)](#M-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewErrorReportDialogLaunchParams-AndAttachSendErrorReportRequestedEventHandler-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams,MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventHandler- 'MFR.GUI.Launchers.Dialogs.Params.Factories.MakeNewErrorReportDialogLaunchParams.AndAttachSendErrorReportRequestedEventHandler(MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams,MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler)')
  - [AndAttachViewErrorReportRequestedEventHandler(self,handler)](#M-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewErrorReportDialogLaunchParams-AndAttachViewErrorReportRequestedEventHandler-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams,MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventHandler- 'MFR.GUI.Launchers.Dialogs.Params.Factories.MakeNewErrorReportDialogLaunchParams.AndAttachViewErrorReportRequestedEventHandler(MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams,MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventHandler)')
  - [ForException(self,exception)](#M-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewErrorReportDialogLaunchParams-ForException-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams,System-Exception- 'MFR.GUI.Launchers.Dialogs.Params.Factories.MakeNewErrorReportDialogLaunchParams.ForException(MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams,System.Exception)')
  - [FromScratch()](#M-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewErrorReportDialogLaunchParams-FromScratch 'MFR.GUI.Launchers.Dialogs.Params.Factories.MakeNewErrorReportDialogLaunchParams.FromScratch')
- [MakeNewProfileNameDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewProfileNameDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Factories.MakeNewProfileNameDialogLaunchParams')
  - [ForProfileCreateOperationType(self,type)](#M-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewProfileNameDialogLaunchParams-ForProfileCreateOperationType-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IProfileNameDialogLaunchParams,MFR-GUI-Dialogs-Constants-ProfileCreateOperationType- 'MFR.GUI.Launchers.Dialogs.Params.Factories.MakeNewProfileNameDialogLaunchParams.ForProfileCreateOperationType(MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams,MFR.GUI.Dialogs.Constants.ProfileCreateOperationType)')
  - [FromScratch()](#M-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewProfileNameDialogLaunchParams-FromScratch 'MFR.GUI.Launchers.Dialogs.Params.Factories.MakeNewProfileNameDialogLaunchParams.FromScratch')
- [Resources](#T-MFR-GUI-Launchers-Dialogs-Params-Factories-Properties-Resources 'MFR.GUI.Launchers.Dialogs.Params.Factories.Properties.Resources')
  - [Culture](#P-MFR-GUI-Launchers-Dialogs-Params-Factories-Properties-Resources-Culture 'MFR.GUI.Launchers.Dialogs.Params.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Launchers-Dialogs-Params-Factories-Properties-Resources-ResourceManager 'MFR.GUI.Launchers.Dialogs.Params.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewDialogLaunchParams'></a>
## MakeNewDialogLaunchParams `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Params.Factories

##### Summary

"Base" extension methods available to all the root types of all dialog-box
launch param objects.

<a name='M-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewDialogLaunchParams-AndOwnerWindow-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IDialogLaunchParams,System-Windows-Forms-IWin32Window-'></a>
### AndOwnerWindow(self,owner) `method`

##### Summary

Builder extension method that initializes the
[Owner](#P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IDialogLaunchParams-Owner 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IDialogLaunchParams.Owner')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Launchers.Dialogs.Params.Interfaces.IDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IDialogLaunchParams') | (Required.) Reference to an instance of an object that implements
the
[IDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IDialogLaunchParams')
interface. |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Optional; can be null.) Reference to an instance of an object that implements
the [IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.



This object represents the parent window of the dialog.



Callers of this dialog can implement their custom behavior for sending detailed
error reports via this handler. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='T-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewErrorReportDialogLaunchParams'></a>
## MakeNewErrorReportDialogLaunchParams `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Params.Factories

##### Summary

Creates new instances of objects that implement the
[IErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams')
interface, and returns references to them.

<a name='M-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewErrorReportDialogLaunchParams-AndAttachSendErrorReportRequestedEventHandler-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams,MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventHandler-'></a>
### AndAttachSendErrorReportRequestedEventHandler(self,handler) `method`

##### Summary

Builder extension method that initializes the
[SendHandler](#P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams-SendHandler 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams.SendHandler')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams') | (Required.) Reference to an instance of an object that implements
the
[IErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams')
interface. |
| handler | [MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventHandler 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler') | (Required.) Reference to a delegate of type
[SendErrorReportRequestedEventHandler](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventHandler 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler')
that will handle the `SendErrorReportRequested` event raised by the
dialog.



Callers of this dialog can implement their custom behavior for sending detailed
error reports via this handler. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewErrorReportDialogLaunchParams-AndAttachViewErrorReportRequestedEventHandler-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams,MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventHandler-'></a>
### AndAttachViewErrorReportRequestedEventHandler(self,handler) `method`

##### Summary

Builder extension method that initializes the
[ViewHandler](#P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams-ViewHandler 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams.ViewHandler')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams') | (Required.) Reference to an instance of an object that implements
the
[IErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams')
interface. |
| handler | [MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventHandler](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventHandler 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventHandler') | (Required.) Reference to a delegate of type
[ViewErrorReportRequestedEventHandler](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventHandler 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventHandler')
that will handle the `ViewErrorReportRequested` event raised by the
dialog.



Callers of this dialog can implement their custom behavior for viewing detailed
error reports via this handler. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewErrorReportDialogLaunchParams-ForException-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams,System-Exception-'></a>
### ForException(self,exception) `method`

##### Summary

Builder extension method that initializes the
[Exception](#P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams-Exception 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams.Exception')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams') | (Required.) Reference to an instance of an object that implements
the
[IErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams')
interface. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewErrorReportDialogLaunchParams-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IErrorReportDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IErrorReportDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewProfileNameDialogLaunchParams'></a>
## MakeNewProfileNameDialogLaunchParams `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Params.Factories

##### Summary

Creates new instances of objects that implement the
[IProfileNameDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IProfileNameDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams')
interface, and returns references to them.

<a name='M-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewProfileNameDialogLaunchParams-ForProfileCreateOperationType-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IProfileNameDialogLaunchParams,MFR-GUI-Dialogs-Constants-ProfileCreateOperationType-'></a>
### ForProfileCreateOperationType(self,type) `method`

##### Summary

Builder extension method that initializes the
[OperationType](#P-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IProfileNameDialogLaunchParams-OperationType 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams.OperationType')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IProfileNameDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams') | (Required.) Reference to an instance of an object that implements
the
[IProfileNameDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IProfileNameDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams')
interface. |
| type | [MFR.GUI.Dialogs.Constants.ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') | (Required.) A
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') value
that specifies how the dialog is being used (i.e., for a Save Profile As or a
New Profile action). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-GUI-Launchers-Dialogs-Params-Factories-MakeNewProfileNameDialogLaunchParams-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IProfileNameDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IProfileNameDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IProfileNameDialogLaunchParams](#T-MFR-GUI-Launchers-Dialogs-Params-Interfaces-IProfileNameDialogLaunchParams 'MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Launchers-Dialogs-Params-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Launchers.Dialogs.Params.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Launchers-Dialogs-Params-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Launchers-Dialogs-Params-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
