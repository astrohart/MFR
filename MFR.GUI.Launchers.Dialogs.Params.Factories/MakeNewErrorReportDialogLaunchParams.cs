using MFR.GUI.Dialogs.Events;
using PostSharp.Patterns.Diagnostics;
using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using System;
using System.Windows.Forms;

namespace MFR.GUI.Launchers.Dialogs.Params.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams" />
    /// interface, and returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewErrorReportDialogLaunchParams
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams" />
        /// interface.
        /// </returns>
        public static IErrorReportDialogLaunchParams FromScratch()
            => new ErrorReportDialogLaunchParams();



        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams.Exception" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams" />
        /// interface.
        /// </param>
        /// <param name="exception">
        /// (Required.)
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IErrorReportDialogLaunchParams ForException(
            this IErrorReportDialogLaunchParams self, Exception exception)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Exception = exception;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams.ViewHandler" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams" />
        /// interface.
        /// </param>
        /// <param name="handler">
        /// (Required.) Reference to a delegate of type
        /// <see cref="T:MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventHandler" />
        /// that will handle the <c>ViewErrorReportRequested</c> event raised by the
        /// dialog.
        /// <para />
        /// Callers of this dialog can implement their custom behavior for viewing detailed
        /// error reports via this handler.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IErrorReportDialogLaunchParams
            AndAttachViewErrorReportRequestedEventHandler(
                this IErrorReportDialogLaunchParams self,
                ViewErrorReportRequestedEventHandler handler)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.ViewHandler = handler;

            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams.SendHandler" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IErrorReportDialogLaunchParams" />
        /// interface.
        /// </param>
        /// <param name="handler">
        /// (Required.) Reference to a delegate of type
        /// <see cref="T:MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler" />
        /// that will handle the <c>SendErrorReportRequested</c> event raised by the
        /// dialog.
        /// <para />
        /// Callers of this dialog can implement their custom behavior for sending detailed
        /// error reports via this handler.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IErrorReportDialogLaunchParams
            AndAttachSendErrorReportRequestedEventHandler(
                this IErrorReportDialogLaunchParams self,
                SendErrorReportRequestedEventHandler handler)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.SendHandler = handler;

            return self;
        }
    }
}