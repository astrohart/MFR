<a name='assembly'></a>
# MFR.Win32

## Contents

- [IOleMessageFilter](#T-MFR-Objects-Win32-IOleMessageFilter 'MFR.Win32.IOleMessageFilter')
  - [HandleInComingCall(dwCallType,hTaskCaller,dwTickCount,lpInterfaceInfo)](#M-MFR-Objects-Win32-IOleMessageFilter-HandleInComingCall-System-Int32,System-IntPtr,System-Int32,System-IntPtr- 'MFR.Win32.IOleMessageFilter.HandleInComingCall(System.Int32,System.IntPtr,System.Int32,System.IntPtr)')
  - [MessagePending(hTaskCallee,dwTickCount,dwPendingType)](#M-MFR-Objects-Win32-IOleMessageFilter-MessagePending-System-IntPtr,System-Int32,System-Int32- 'MFR.Win32.IOleMessageFilter.MessagePending(System.IntPtr,System.Int32,System.Int32)')
  - [RetryRejectedCall(hTaskCallee,dwTickCount,dwRejectType)](#M-MFR-Objects-Win32-IOleMessageFilter-RetryRejectedCall-System-IntPtr,System-Int32,System-Int32- 'MFR.Win32.IOleMessageFilter.RetryRejectedCall(System.IntPtr,System.Int32,System.Int32)')
- [NativeMethods](#T-MFR-Objects-Win32-NativeMethods 'MFR.Win32.NativeMethods')
  - [CreateBindCtx(reserved,ppbc)](#M-MFR-Objects-Win32-NativeMethods-CreateBindCtx-System-UInt32,System-Runtime-InteropServices-ComTypes-IBindCtx@- 'MFR.Win32.NativeMethods.CreateBindCtx(System.UInt32,System.Runtime.InteropServices.ComTypes.IBindCtx@)')
- [Resources](#T-MFR-Objects-Win32-Properties-Resources 'MFR.Win32.Properties.Resources')
  - [Culture](#P-MFR-Objects-Win32-Properties-Resources-Culture 'MFR.Win32.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Win32-Properties-Resources-ResourceManager 'MFR.Win32.Properties.Resources.ResourceManager')
- [WindowsMessageFilter](#T-MFR-Objects-Win32-WindowsMessageFilter 'MFR.Win32.WindowsMessageFilter')
  - [CoRegisterMessageFilter(newFilter,oldFilter)](#M-MFR-Objects-Win32-WindowsMessageFilter-CoRegisterMessageFilter-MFR-Objects-Win32-IOleMessageFilter,MFR-Objects-Win32-IOleMessageFilter@- 'MFR.Win32.WindowsMessageFilter.CoRegisterMessageFilter(MFR.Win32.IOleMessageFilter,MFR.Win32.IOleMessageFilter@)')
  - [MFR#Objects#Win32#IOleMessageFilter#HandleInComingCall(dwCallType,hTaskCaller,dwTickCount,lpInterfaceInfo)](#M-MFR-Objects-Win32-WindowsMessageFilter-MFR#Objects#Win32#IOleMessageFilter#HandleInComingCall-System-Int32,System-IntPtr,System-Int32,System-IntPtr- 'MFR.Win32.WindowsMessageFilter.MFR#Objects#Win32#IOleMessageFilter#HandleInComingCall(System.Int32,System.IntPtr,System.Int32,System.IntPtr)')
  - [MFR#Objects#Win32#IOleMessageFilter#MessagePending(hTaskCallee,dwTickCount,dwPendingType)](#M-MFR-Objects-Win32-WindowsMessageFilter-MFR#Objects#Win32#IOleMessageFilter#MessagePending-System-IntPtr,System-Int32,System-Int32- 'MFR.Win32.WindowsMessageFilter.MFR#Objects#Win32#IOleMessageFilter#MessagePending(System.IntPtr,System.Int32,System.Int32)')
  - [MFR#Objects#Win32#IOleMessageFilter#RetryRejectedCall(hTaskCallee,dwTickCount,dwRejectType)](#M-MFR-Objects-Win32-WindowsMessageFilter-MFR#Objects#Win32#IOleMessageFilter#RetryRejectedCall-System-IntPtr,System-Int32,System-Int32- 'MFR.Win32.WindowsMessageFilter.MFR#Objects#Win32#IOleMessageFilter#RetryRejectedCall(System.IntPtr,System.Int32,System.Int32)')
  - [Register()](#M-MFR-Objects-Win32-WindowsMessageFilter-Register 'MFR.Win32.WindowsMessageFilter.Register')
  - [Revoke()](#M-MFR-Objects-Win32-WindowsMessageFilter-Revoke 'MFR.Win32.WindowsMessageFilter.Revoke')

<a name='T-MFR-Objects-Win32-IOleMessageFilter'></a>
## IOleMessageFilter `type`

##### Namespace

MFR.Win32

##### Summary

Provides COM servers and applications with the ability to selectively
handle incoming and outgoing COM messages while waiting for responses
from synchronous calls.

##### Remarks

Filtering messages helps to ensure that calls are handled in a manner
that improves performance and avoids deadlocks. COM messages can be
synchronous, asynchronous, or input-synchronized; the majority of
interface calls are synchronous.

<a name='M-MFR-Objects-Win32-IOleMessageFilter-HandleInComingCall-System-Int32,System-IntPtr,System-Int32,System-IntPtr-'></a>
### HandleInComingCall(dwCallType,hTaskCaller,dwTickCount,lpInterfaceInfo) `method`

##### Summary

Provides a single entry point for incoming calls.

##### Returns

This method can return the following values:
`SERVERCALL_ISHANDLED`, `SERVERCALL_REJECTED`, or
`SERVERCALL_RETRYLATER`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dwCallType | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The type of incoming call that has been received. Possible values
are from the enumeration `CALLTYPE`. |
| hTaskCaller | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | The thread id of the caller. |
| dwTickCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The elapsed tick count since the outgoing call was made, if
dwCallType is not `CALLTYPE_TOPLEVEL`. If dwCallType is
`CALLTYPE_TOPLEVEL`, dwTickCount should be ignored. |
| lpInterfaceInfo | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | A pointer to an `INTERFACEINFO` structure that identifies the
object, interface, and method being called. In the case of DDE
calls, `lpInterfaceInfo` can be `NULL` because
the DDE layer does not return interface information. |

##### Remarks

This method is called prior to each method invocation originating
outside the current process and provides the ability to filter or
reject incoming calls (or callbacks) to an object or a process. If
implemented,
[HandleInComingCall](#M-MFR-Objects-Win32-IOleMessageFilter-HandleInComingCall 'MFR.Win32.IOleMessageFilter.HandleInComingCall')
is
called by COM when an incoming COM message is received. Depending on
an application's current state, a call is either accepted and
processed or rejected (permanently or temporarily). If
`SERVERCALL_ISHANDLED` is returned, the application may be able
to process the call, although success depends on the interface for
which the call is destined. If the call cannot be processed, COM
returns RPC_E_CALL_REJECTED. Input-synchronized and asynchronous
calls are dispatched even if the application returns
`SERVERCALL_REJECTED` or `SERVERCALL_RETRYLATER`.
HandleInComingCall should not be used to hold off updates to objects
during operations such as band printing. For that purpose, use
`IViewObject::Freeze`. You can also use
[HandleInComingCall](#M-MFR-Objects-Win32-IOleMessageFilter-HandleInComingCall 'MFR.Win32.IOleMessageFilter.HandleInComingCall')
to
set up the application's state so that the call can be processed in
the future.

<a name='M-MFR-Objects-Win32-IOleMessageFilter-MessagePending-System-IntPtr,System-Int32,System-Int32-'></a>
### MessagePending(hTaskCallee,dwTickCount,dwPendingType) `method`

##### Summary

Provides applications with an opportunity to display a dialog box
offering retry, cancel, or task-switching options.

##### Returns

This method can return the following values:

-1: The call should be canceled. COM then returns
`RPC_E_CALL_REJECTED` from the original method call.

0 <= value < 100: The call is to be retried immediately.

100 <= value: COM will wait for this many milliseconds and then
retry the call.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hTaskCallee | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | The thread id of the called application. |
| dwTickCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elapsed ticks since the call was made. |
| dwPendingType | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Specifies either SERVERCALL_REJECTED or SERVERCALL_RETRYLATER, as
returned by the object application. |

##### Remarks

COM calls RetryRejectedCall on the caller's IMessageFilter interface
immediately after receiving SERVERCALL_RETRYLATER or
`SERVERCALL_REJECTED` from the
`IMessageFilter::HandleInComingCall` method on the callee's
`IMessageFilter` interface.

If a called task rejects a call, the application is probably in a
state where it cannot handle such calls, possibly only temporarily.
When this occurs, COM returns to the caller and issues
[RetryRejectedCall](#M-MFR-Objects-Win32-IOleMessageFilter-RetryRejectedCall 'MFR.Win32.IOleMessageFilter.RetryRejectedCall')
to
determine whether it should retry the rejected call.

Applications should silently retry calls that have returned with
`SERVERCALL_RETRYLATER`. If, after a reasonable amount of time
has passed, say about 30 seconds, the application should display the
busy dialog box; a standard implementation of this dialog box is
available in the `OLEDLG` library. The callee may momentarily
be in a state where calls can be handled. The option to wait and
retry is provided for special kinds of calling applications, such as
background tasks executing macros or scripts, so that they can retry
the calls in a nonintrusive way.

If, after a dialog box is displayed, the user chooses to cancel,
RetryRejectedCall returns -1 and the call will appear to fail with
`RPC_E_CALL_REJECTED`.

If a client implements IMessageFilter and calls a server method on a
remote machine,
[RetryRejectedCall](#M-MFR-Objects-Win32-IOleMessageFilter-RetryRejectedCall 'MFR.Win32.IOleMessageFilter.RetryRejectedCall')
will not be called.

<a name='M-MFR-Objects-Win32-IOleMessageFilter-RetryRejectedCall-System-IntPtr,System-Int32,System-Int32-'></a>
### RetryRejectedCall(hTaskCallee,dwTickCount,dwRejectType) `method`

##### Summary

Indicates that a message has arrived while COM is waiting to respond
to a remote call.

Handling input while waiting for an outgoing call to finish can
introduce complications. The application should determine whether to
process the message without interrupting the call, to continue
waiting, or to cancel the operation.

##### Returns

This method can return the following values:
`PENDINGMSG_CANCELCALL`, `PENDINGMSG_WAITNOPROCESS`, or
`PENDINGMSG_WAITDEFPROCESS`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hTaskCallee | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | The thread id of the called application. |
| dwTickCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of ticks since the call was made. It is calculated from
the GetTickCount function. |
| dwRejectType | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The type of call made during which a message or event was received.
Possible values are from the enumeration `PENDINGTYPE`, where
`PENDINGTYPE_TOPLEVEL` means the outgoing call was not nested
within a call from another application and `PENDINTGYPE_NESTED`
means the outgoing call was nested within a call from another application. |

##### Remarks

COM calls MessagePending after an application has made a COM method
call and a Windows message occurs before the call has returned. A
Windows message is sent, for example, when the user selects a menu
command or double-clicks an object. Before COM makes the
MessagePending call, it calculates the elapsed time since the
original COM method call was made. COM delivers the elapsed time in
the dwTickCount parameter. In the meantime, COM does not remove the
message from the queue.

Windows messages that appear in the caller's queue should remain in
the queue until sufficient time has passed to ensure that the
messages are probably not the result of typing ahead, but are
instead an attempt to get attention. Set the delay with the
dwTickCount parameter —a two-second or three-second delay is
recommended. If that amount of time passes and the call has not been
completed, the caller should flush the messages from the queue and
the OLE UI busy dialog box should be displayed offering the user the
choice of retrying the call (continue waiting) or switching to the
specified task. This ensures the following behaviors:

Handling input while waiting for an outgoing call to finish can
introduce complications. The application should determine whether to
process the message without interrupting the call, to continue
waiting, or to cancel the operation.

When there is no response to the original COM call, the application
can cancel the call and restore the COM object to a consistent state
by calling IStorage::Revert on its storage. The object can be
released when the container can shut down. However, canceling a call
can create orphaned operations and resource leaks. Canceling should
be used only as a last resort. It is strongly recommended that
applications not allow such calls to be canceled.

<a name='T-MFR-Objects-Win32-NativeMethods'></a>
## NativeMethods `type`

##### Namespace

MFR.Win32

##### Summary

P/Invoke signatures of Win32 API functions and constants.

<a name='M-MFR-Objects-Win32-NativeMethods-CreateBindCtx-System-UInt32,System-Runtime-InteropServices-ComTypes-IBindCtx@-'></a>
### CreateBindCtx(reserved,ppbc) `method`

##### Summary

Returns a pointer to an implementation of IBindCtx (a bind
context object). This object stores information about a
particular moniker-binding operation.

##### Returns

This function can return the standard return values `E_OUTOFMEMORY` and `S_OK`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reserved | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | (Required.) This parameter is reserved and must be 0. |
| ppbc | [System.Runtime.InteropServices.ComTypes.IBindCtx@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx@ 'System.Runtime.InteropServices.ComTypes.IBindCtx@') | (Required.) Address of an [IBindCtx](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.InteropServices.ComTypes.IBindCtx 'System.Runtime.InteropServices.ComTypes.IBindCtx')* pointer variable that receives the interface pointer to the new bind context object.



When the function is successful, the caller is responsible for calling the [Release](#M-stdole-IUnknown-Release 'stdole.IUnknown.Release') method on the bind context. A NULL value for the bind context indicates that an error occurred. |

<a name='T-MFR-Objects-Win32-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Win32.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Win32-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Win32-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Objects-Win32-WindowsMessageFilter'></a>
## WindowsMessageFilter `type`

##### Namespace

MFR.Win32

##### Summary

Filter for COM and Windows messages sent by the operating system on the
behalf of a running COM object.

##### Remarks

This class implements the
[IOleMessageFilter](#T-MFR-Objects-Win32-IOleMessageFilter 'MFR.Win32.IOleMessageFilter')
interface.

<a name='M-MFR-Objects-Win32-WindowsMessageFilter-CoRegisterMessageFilter-MFR-Objects-Win32-IOleMessageFilter,MFR-Objects-Win32-IOleMessageFilter@-'></a>
### CoRegisterMessageFilter(newFilter,oldFilter) `method`

##### Summary

This function registers with OLE the instance of an EXE
application's `IMessageFilter` interface, which is to be used
for handling concurrency issues. DLL object applications cannot
register a message filter.

##### Returns

If the `IMessageFilter` instance registered or revoked
successfully, returns `S_OK`. Otherwise, `S_FALSE` is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newFilter | [MFR.Win32.IOleMessageFilter](#T-MFR-Objects-Win32-IOleMessageFilter 'MFR.Win32.IOleMessageFilter') | Pointer to the `IMessageFilter` interface on the message filter
supplied by the application. Can be `NULL`, indicating that the
current `IMessageFilter` registration should be revoked. |
| oldFilter | [MFR.Win32.IOleMessageFilter@](#T-MFR-Objects-Win32-IOleMessageFilter@ 'MFR.Win32.IOleMessageFilter@') | Address of `IMessageFilter*` pointer variable that receives the
interface pointer to the previously registered message filter. |

<a name='M-MFR-Objects-Win32-WindowsMessageFilter-MFR#Objects#Win32#IOleMessageFilter#HandleInComingCall-System-Int32,System-IntPtr,System-Int32,System-IntPtr-'></a>
### MFR#Objects#Win32#IOleMessageFilter#HandleInComingCall(dwCallType,hTaskCaller,dwTickCount,lpInterfaceInfo) `method`

##### Summary

IOleMessageFilter functions. Handle incoming thread requests.

##### Returns

The `SERVERCALL_ISHANDLED` value (zero) is always returned.



The application might be able to process the call.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dwCallType | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Kind of incoming call that has been received.



Valid values are from the enumeration `CALLTYPE`. |
| hTaskCaller | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | Handle of the task calling this task. |
| dwTickCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Elapsed tick count since the outgoing call was made if
`dwCallType`
is not `CALLTYPE_TOPLEVEL`.



If `dwCallType` is `CALLTYPE_TOPLEVEL`,
`dwCallType` should be ignored. |
| lpInterfaceInfo | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | Pointer to an `INTERFACEINFO` structure, which identifies the
object, the interface, and the method making the call.



In the case of DDE calls, `lpInterfaceInfo` can be
zero because the DDE layer does not return interface information. |

<a name='M-MFR-Objects-Win32-WindowsMessageFilter-MFR#Objects#Win32#IOleMessageFilter#MessagePending-System-IntPtr,System-Int32,System-Int32-'></a>
### MFR#Objects#Win32#IOleMessageFilter#MessagePending(hTaskCallee,dwTickCount,dwPendingType) `method`

##### Summary

This client-based method is called by COM when a Windows message
appears in a COM application's message queue while the application
is waiting for a reply to a remote call.



Handling input while waiting for an outgoing call to finish can
introduce complications. The application should determine whether to
process the message without interrupting the call, continue waiting,
or cancel the operation.

##### Returns

The value `PENDINGMSG_WAITDEFPROCESS` is always returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hTaskCallee | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | Task handle of the called application that has not yet responded. |
| dwTickCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of ticks since the call was made.



It is calculated from the Windows `GetTickCount` function. |
| dwPendingType | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Type of call made during which a message or event was received.



Valid values are from the enumeration `PENDINGTYPE`, where
`PENDINGTYPE_TOPLEVEL` means the outgoing call was not nested
within a call from another application and `PENDINTGYPE_NESTED`
means the outgoing call was nested within a call from another application. |

<a name='M-MFR-Objects-Win32-WindowsMessageFilter-MFR#Objects#Win32#IOleMessageFilter#RetryRejectedCall-System-IntPtr,System-Int32,System-Int32-'></a>
### MFR#Objects#Win32#IOleMessageFilter#RetryRejectedCall(hTaskCallee,dwTickCount,dwRejectType) `method`

##### Summary

This client-based method gives the application an opportunity to
display a dialog box so the user can retry or cancel the call, or
switch to the task identified by `hTaskCallee`.

##### Returns

If `dwRejectType` is `2`, then
`SERVERCALL_RETRYLATER` is returned. Otherwise, this method

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hTaskCallee | [System.IntPtr](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IntPtr 'System.IntPtr') | Handle of the server task that rejected the call. |
| dwTickCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of elapsed ticks since the call was made. |
| dwRejectType | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Specifies either `SERVERCALL_REJECTED` or
`SERVERCALL_RETRYLATER`, as returned by the object application. |

<a name='M-MFR-Objects-Win32-WindowsMessageFilter-Register'></a>
### Register() `method`

##### Summary

Starts the filter.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Win32-WindowsMessageFilter-Revoke'></a>
### Revoke() `method`

##### Summary

Closes the filter.

##### Parameters

This method has no parameters.
