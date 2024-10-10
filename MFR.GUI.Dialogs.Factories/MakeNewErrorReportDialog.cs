using MFR.GUI.Dialogs.Events;
using PostSharp.Patterns.Diagnostics;
using MFR.GUI.Dialogs.Interfaces;
using System;

namespace MFR.GUI.Dialogs.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IErrorReportDialog" /> interface, and
    /// returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewErrorReportDialog
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IErrorReportDialog" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IErrorReportDialog" /> interface.
        /// </returns>
        public static IErrorReportDialog FromScratch()
            => new ErrorReportDialog();

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Dialogs.Interfaces.IErrorReportDialog" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.IErrorReportDialog" />
        /// interface.
        /// </param>
        /// <param name="exception">
        /// (Required.) A <see cref="T:System.Exception" /> that describes the error being
        /// reported.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IErrorReportDialog ForException(
            this IErrorReportDialog self, Exception exception)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Exception = exception;

            return self;
        }

        /// <summary>
        /// Attaches a handler for the
        /// <see
        ///     cref="E:MFR.GUI.Dialogs.Interfaces.IErrorReportDialog.ViewErrorReportRequested" />
        /// event.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:MFR.GUI.Dialogs.Interfaces.IErrorReportDialog" />
        /// interface.
        /// </param>
        /// <param name="handler">
        /// Reference to a delegate of the
        /// <see cref="T:MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventHandler" />
        /// type.
        /// <para />
        /// This delegate is a callback to a method that will implement
        /// application-specific behavior.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this method,
        /// for fluent use.
        /// </returns>
        public static IErrorReportDialog
            AttachViewErrorReportRequestedEventHandler(
                this IErrorReportDialog self,
                ViewErrorReportRequestedEventHandler handler)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));
            if (handler == null)
                throw new ArgumentNullException(nameof(handler));

            self.ViewErrorReportRequested -= handler;
            self.ViewErrorReportRequested += handler;

            return self;
        }

        /// <summary>
        /// Attaches a handler for the
        /// <see
        ///     cref="E:MFR.GUI.Dialogs.Interfaces.IErrorReportDialog.SendErrorReportRequested" />
        /// event.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:MFR.GUI.Dialogs.Interfaces.IErrorReportDialog" />
        /// interface.
        /// </param>
        /// <param name="handler">
        /// Reference to a delegate of the
        /// <see cref="T:MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler" />
        /// type.
        /// <para />
        /// This delegate is a callback to a method that will implement
        /// application-specific behavior.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this method,
        /// for fluent use.
        /// </returns>
        public static IErrorReportDialog
            AttachSendErrorReportRequestedEventHandler(
                this IErrorReportDialog self,
                SendErrorReportRequestedEventHandler handler)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));
            if (handler == null)
                throw new ArgumentNullException(nameof(handler));

            self.SendErrorReportRequested -= handler;
            self.SendErrorReportRequested += handler;

            return self;
        }

    }
}