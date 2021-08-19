using System;
using System.Runtime.InteropServices;

// ReSharper disable NotAccessedVariable

namespace MFR.Win32
{
    /// <summary>
    /// Filter for COM and Windows messages sent by the operating system on the
    /// behalf of a running COM object.
    /// </summary>
    /// <remarks>
    /// This class implements the
    /// <see
    ///     cref="T:MFR.Win32.IOleMessageFilter" />
    /// interface.
    /// </remarks>
    public class WindowsMessageFilter : IOleMessageFilter
    {
        /// <summary>
        /// IOleMessageFilter functions. Handle incoming thread requests.
        /// </summary>
        /// <param name="dwCallType">
        /// Kind of incoming call that has been received.
        /// <para />
        /// Valid values are from the enumeration <c>CALLTYPE</c>.
        /// </param>
        /// <param name="hTaskCaller">
        /// Handle of the task calling this task.
        /// </param>
        /// <param name="dwTickCount">
        /// Elapsed tick count since the outgoing call was made if
        /// <paramref
        ///     name="dwCallType" />
        /// is not <c>CALLTYPE_TOPLEVEL</c>.
        /// <para />
        /// If <paramref name="dwCallType" /> is <c>CALLTYPE_TOPLEVEL</c>,
        /// <paramref name="dwCallType" /> should be ignored.
        /// </param>
        /// <param name="lpInterfaceInfo">
        /// Pointer to an <c>INTERFACEINFO</c> structure, which identifies the
        /// object, the interface, and the method making the call.
        /// <para />
        /// In the case of DDE calls, <paramref name="lpInterfaceInfo" /> can be
        /// zero because the DDE layer does not return interface information.
        /// </param>
        /// <returns>
        /// The <c>SERVERCALL_ISHANDLED</c> value (zero) is always returned.
        /// <para />
        /// The application might be able to process the call.
        /// </returns>
        int IOleMessageFilter.HandleInComingCall(int dwCallType,
                IntPtr hTaskCaller, int dwTickCount, IntPtr lpInterfaceInfo)

            //Return the flag SERVERCALL_ISHANDLED.
            => 0;

        /// <summary>
        /// This client-based method is called by COM when a Windows message
        /// appears in a COM application's message queue while the application
        /// is waiting for a reply to a remote call.
        /// <para />
        /// Handling input while waiting for an outgoing call to finish can
        /// introduce complications. The application should determine whether to
        /// process the message without interrupting the call, continue waiting,
        /// or cancel the operation.
        /// </summary>
        /// <param name="hTaskCallee">
        /// Task handle of the called application that has not yet responded.
        /// </param>
        /// <param name="dwTickCount">
        /// Number of ticks since the call was made.
        /// <para />
        /// It is calculated from the Windows <c>GetTickCount</c> function.
        /// </param>
        /// <param name="dwPendingType">
        /// Type of call made during which a message or event was received.
        /// <para />
        /// Valid values are from the enumeration <c>PENDINGTYPE</c>, where
        /// <c>PENDINGTYPE_TOPLEVEL</c> means the outgoing call was not nested
        /// within a call from another application and <c>PENDINTGYPE_NESTED</c>
        /// means the outgoing call was nested within a call from another application.
        /// </param>
        /// <returns>
        /// The value <c>PENDINGMSG_WAITDEFPROCESS</c> is always returned.
        /// </returns>
        int IOleMessageFilter.MessagePending(IntPtr hTaskCallee,
                int dwTickCount, int dwPendingType)

            // Return the flag PENDINGMSG_WAITDEFPROCESS.
            => 2;

        /// <summary>
        /// This client-based method gives the application an opportunity to
        /// display a dialog box so the user can retry or cancel the call, or
        /// switch to the task identified by <paramref name="hTaskCallee" />.
        /// </summary>
        /// <param name="hTaskCallee">
        /// Handle of the server task that rejected the call.
        /// </param>
        /// <param name="dwTickCount">
        /// Number of elapsed ticks since the call was made.
        /// </param>
        /// <param name="dwRejectType">
        /// Specifies either <c>SERVERCALL_REJECTED</c> or
        /// <c>SERVERCALL_RETRYLATER</c>, as returned by the object application.
        /// </param>
        /// <returns>
        /// If <paramref name="dwRejectType" /> is <c>2</c>, then
        /// <c>SERVERCALL_RETRYLATER</c> is returned. Otherwise, this method
        /// </returns>
        int IOleMessageFilter.RetryRejectedCall(IntPtr hTaskCallee,
            int dwTickCount, int dwRejectType)
        {
            if (dwRejectType == 2)

                // flag = SERVERCALL_RETRYLATER. Retry the thread call
                // immediately if return >=0 & <100.
                return 99;

            // Too busy; cancel call.
            return -1;
        }

        /// <summary>
        /// Starts the filter.
        /// </summary>
        public static void Register()
        {
            var newFilter = new WindowsMessageFilter();
            _ = CoRegisterMessageFilter(newFilter, out _);
        }

        /// <summary>
        /// Closes the filter.
        /// </summary>
        public static void Revoke()
            => _ = CoRegisterMessageFilter(null, out _);

        /// <summary>
        /// This function registers with OLE the instance of an EXE
        /// application's <c>IMessageFilter</c> interface, which is to be used
        /// for handling concurrency issues. DLL object applications cannot
        /// register a message filter.
        /// </summary>
        /// <param name="newFilter">
        /// Pointer to the <c>IMessageFilter</c> interface on the message filter
        /// supplied by the application. Can be <c>NULL</c>, indicating that the
        /// current <c>IMessageFilter</c> registration should be revoked.
        /// </param>
        /// <param name="oldFilter">
        /// Address of <c>IMessageFilter*</c> pointer variable that receives the
        /// interface pointer to the previously registered message filter.
        /// </param>
        /// <returns>
        /// If the <c>IMessageFilter</c> instance registered or revoked
        /// successfully, returns <c>S_OK</c>. Otherwise, <c>S_FALSE</c> is returned.
        /// </returns>
        [DllImport("Ole32.dll")]
        private static extern int CoRegisterMessageFilter(
            IOleMessageFilter newFilter, out IOleMessageFilter oldFilter);
    }
}