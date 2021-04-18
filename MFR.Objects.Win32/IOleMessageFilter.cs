using System;
using System.Runtime.InteropServices;

namespace MFR.Objects.Win32
{
    /// <summary>
    /// Provides COM servers and applications with the ability to selectively
    /// handle incoming and outgoing COM messages while waiting for responses
    /// from synchronous calls.
    /// </summary>
    /// <remarks>
    /// Filtering messages helps to ensure that calls are handled in a manner
    /// that improves performance and avoids deadlocks. COM messages can be
    /// synchronous, asynchronous, or input-synchronized; the majority of
    /// interface calls are synchronous.
    /// </remarks>
    [ComImport]
    [Guid("00000016-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IOleMessageFilter
    {
        /// <summary>
        /// Provides a single entry point for incoming calls.
        /// </summary>
        /// <param name="dwCallType">
        /// The type of incoming call that has been received. Possible values
        /// are from the enumeration <c>CALLTYPE</c>.
        /// </param>
        /// <param name="hTaskCaller">
        /// The thread id of the caller.
        /// </param>
        /// <param name="dwTickCount">
        /// The elapsed tick count since the outgoing call was made, if
        /// dwCallType is not <c>CALLTYPE_TOPLEVEL</c>. If dwCallType is
        /// <c>CALLTYPE_TOPLEVEL</c>, dwTickCount should be ignored.
        /// </param>
        /// <param name="lpInterfaceInfo">
        /// A pointer to an <c>INTERFACEINFO</c> structure that identifies the
        /// object, interface, and method being called. In the case of DDE
        /// calls, <paramref name="lpInterfaceInfo" /> can be <c>NULL</c> because
        /// the DDE layer does not return interface information.
        /// </param>
        /// <returns>
        /// This method can return the following values:
        /// <c>SERVERCALL_ISHANDLED</c>, <c>SERVERCALL_REJECTED</c>, or
        /// <c>SERVERCALL_RETRYLATER</c>.
        /// </returns>
        /// <remarks>
        /// This method is called prior to each method invocation originating
        /// outside the current process and provides the ability to filter or
        /// reject incoming calls (or callbacks) to an object or a process. If
        /// implemented,
        /// <see
        ///     cref="M:MFR.Objects.Win32.IOleMessageFilter.HandleInComingCall" />
        /// is
        /// called by COM when an incoming COM message is received. Depending on
        /// an application's current state, a call is either accepted and
        /// processed or rejected (permanently or temporarily). If
        /// <c>SERVERCALL_ISHANDLED</c> is returned, the application may be able
        /// to process the call, although success depends on the interface for
        /// which the call is destined. If the call cannot be processed, COM
        /// returns RPC_E_CALL_REJECTED. Input-synchronized and asynchronous
        /// calls are dispatched even if the application returns
        /// <c>SERVERCALL_REJECTED</c> or <c>SERVERCALL_RETRYLATER</c>.
        /// HandleInComingCall should not be used to hold off updates to objects
        /// during operations such as band printing. For that purpose, use
        /// <c>IViewObject::Freeze</c>. You can also use
        /// <see
        ///     cref="M:MFR.Objects.Win32.IOleMessageFilter.HandleInComingCall" />
        /// to
        /// set up the application's state so that the call can be processed in
        /// the future.
        /// </remarks>
        [PreserveSig]
        int HandleInComingCall(int dwCallType, IntPtr hTaskCaller,
            int dwTickCount, IntPtr lpInterfaceInfo);

        /// <summary>
        /// Indicates that a message has arrived while COM is waiting to respond
        /// to a remote call.
        /// <para>
        /// Handling input while waiting for an outgoing call to finish can
        /// introduce complications. The application should determine whether to
        /// process the message without interrupting the call, to continue
        /// waiting, or to cancel the operation.
        /// </para>
        /// </summary>
        /// <param name="hTaskCallee">
        /// The thread id of the called application.
        /// </param>
        /// <param name="dwTickCount">
        /// The number of ticks since the call was made. It is calculated from
        /// the GetTickCount function.
        /// </param>
        /// <param name="dwRejectType">
        /// The type of call made during which a message or event was received.
        /// Possible values are from the enumeration <c>PENDINGTYPE</c>, where
        /// <c>PENDINGTYPE_TOPLEVEL</c> means the outgoing call was not nested
        /// within a call from another application and <c>PENDINTGYPE_NESTED</c>
        /// means the outgoing call was nested within a call from another application.
        /// </param>
        /// <returns>
        /// This method can return the following values:
        /// <c>PENDINGMSG_CANCELCALL</c>, <c>PENDINGMSG_WAITNOPROCESS</c>, or
        /// <c>PENDINGMSG_WAITDEFPROCESS</c>.
        /// </returns>
        /// <remarks>
        /// COM calls MessagePending after an application has made a COM method
        /// call and a Windows message occurs before the call has returned. A
        /// Windows message is sent, for example, when the user selects a menu
        /// command or double-clicks an object. Before COM makes the
        /// MessagePending call, it calculates the elapsed time since the
        /// original COM method call was made. COM delivers the elapsed time in
        /// the dwTickCount parameter. In the meantime, COM does not remove the
        /// message from the queue.
        /// <para>
        /// Windows messages that appear in the caller's queue should remain in
        /// the queue until sufficient time has passed to ensure that the
        /// messages are probably not the result of typing ahead, but are
        /// instead an attempt to get attention. Set the delay with the
        /// dwTickCount parameter —a two-second or three-second delay is
        /// recommended. If that amount of time passes and the call has not been
        /// completed, the caller should flush the messages from the queue and
        /// the OLE UI busy dialog box should be displayed offering the user the
        /// choice of retrying the call (continue waiting) or switching to the
        /// specified task. This ensures the following behaviors:
        /// <ul>
        /// <li>
        /// If
        /// calls are completed in a reasonable amount of time, type ahead will
        /// be treated correctly.
        /// </li>
        /// <li>
        /// If the callee does not respond, type
        /// ahead is not misinterpreted and the user is able to act to solve the
        /// problem. For example, OLE 1 servers can queue up requests without
        /// responding when they are in modal dialog boxes.
        /// </li>
        /// </ul>
        /// </para>
        /// <para>
        /// Handling input while waiting for an outgoing call to finish can
        /// introduce complications. The application should determine whether to
        /// process the message without interrupting the call, to continue
        /// waiting, or to cancel the operation.
        /// </para>
        /// <para>
        /// When there is no response to the original COM call, the application
        /// can cancel the call and restore the COM object to a consistent state
        /// by calling IStorage::Revert on its storage. The object can be
        /// released when the container can shut down. However, canceling a call
        /// can create orphaned operations and resource leaks. Canceling should
        /// be used only as a last resort. It is strongly recommended that
        /// applications not allow such calls to be canceled.
        /// </para>
        /// </remarks>
        [PreserveSig]
        int RetryRejectedCall(IntPtr hTaskCallee, int dwTickCount,
            int dwRejectType);

        /// <summary>
        /// Provides applications with an opportunity to display a dialog box
        /// offering retry, cancel, or task-switching options.
        /// </summary>
        /// <param name="hTaskCallee">
        /// The thread id of the called application.
        /// </param>
        /// <param name="dwTickCount">
        /// The number of elapsed ticks since the call was made.
        /// </param>
        /// <param name="dwPendingType">
        /// Specifies either SERVERCALL_REJECTED or SERVERCALL_RETRYLATER, as
        /// returned by the object application.
        /// </param>
        /// <returns>
        /// <para>This method can return the following values:</para>
        /// <para>
        /// -1: The call should be canceled. COM then returns
        /// <c>RPC_E_CALL_REJECTED</c> from the original method call.
        /// </para>
        /// <para>0 &lt;= value &lt; 100: The call is to be retried immediately.</para>
        /// <para>
        /// 100 &lt;= value: COM will wait for this many milliseconds and then
        /// retry the call.
        /// </para>
        /// </returns>
        /// <remarks>
        /// COM calls RetryRejectedCall on the caller's IMessageFilter interface
        /// immediately after receiving SERVERCALL_RETRYLATER or
        /// <c>SERVERCALL_REJECTED</c> from the
        /// <c>IMessageFilter::HandleInComingCall</c> method on the callee's
        /// <c>IMessageFilter</c> interface.
        /// <para>
        /// If a called task rejects a call, the application is probably in a
        /// state where it cannot handle such calls, possibly only temporarily.
        /// When this occurs, COM returns to the caller and issues
        /// <see
        ///     cref="M:MFR.Objects.Win32.IOleMessageFilter.RetryRejectedCall" />
        /// to
        /// determine whether it should retry the rejected call.
        /// </para>
        /// <para>
        /// Applications should silently retry calls that have returned with
        /// <c>SERVERCALL_RETRYLATER</c>. If, after a reasonable amount of time
        /// has passed, say about 30 seconds, the application should display the
        /// busy dialog box; a standard implementation of this dialog box is
        /// available in the <c>OLEDLG</c> library. The callee may momentarily
        /// be in a state where calls can be handled. The option to wait and
        /// retry is provided for special kinds of calling applications, such as
        /// background tasks executing macros or scripts, so that they can retry
        /// the calls in a nonintrusive way.
        /// </para>
        /// <para>
        /// If, after a dialog box is displayed, the user chooses to cancel,
        /// RetryRejectedCall returns -1 and the call will appear to fail with
        /// <c>RPC_E_CALL_REJECTED</c>.
        /// </para>
        /// <para>
        /// If a client implements IMessageFilter and calls a server method on a
        /// remote machine,
        /// <see
        ///     cref="M:MFR.Objects.Win32.IOleMessageFilter.RetryRejectedCall" />
        /// will not be called.
        /// </para>
        /// </remarks>
        [PreserveSig]
        int MessagePending(IntPtr hTaskCallee, int dwTickCount,
            int dwPendingType);
    }
}