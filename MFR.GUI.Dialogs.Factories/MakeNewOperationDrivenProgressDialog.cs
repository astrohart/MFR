using MFR.GUI.Dialogs.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.GUI.Dialogs.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog" />
    /// interface, and returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewOperationDrivenProgressDialog
    {
        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Argument" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog" />
        /// interface.
        /// </param>
        /// <param name="argument">
        /// (Required.) An object that should be passed to the code that is to be executed
        /// by the dialog box, as an argument.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IOperationDrivenProgressDialog AndArgument(
            this IOperationDrivenProgressDialog self, object argument)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Argument = argument;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Status" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog" />
        /// interface.
        /// </param>
        /// <param name="statusText">
        /// (Required.) String containing the text to be displayed in the dialog box while
        /// it is being displayed.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IOperationDrivenProgressDialog AndStatusText(
            this IOperationDrivenProgressDialog self, string statusText)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Status = statusText;

            return self;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog" />
        /// interface.
        /// </returns>
        public static IOperationDrivenProgressDialog FromScratch()
            => new OperationDrivenProgressDialog();

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Proc" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog" />
        /// interface.
        /// </param>
        /// <param name="proc">
        /// (Required.) A <see cref="T:System.Func" /> delegate that specifies code that is
        /// to be executed when the dialog is to be displayed.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IOperationDrivenProgressDialog HavingProc(
            this IOperationDrivenProgressDialog self, Func<dynamic, dynamic> proc)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Proc = proc;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog.Proc" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.IOperationDrivenProgressDialog" />
        /// interface.
        /// </param>
        /// <param name="proc">
        /// (Required.) A <see cref="T:System.Func" /> delegate that specifies code that is
        /// to be executed when the dialog is to be displayed.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IOperationDrivenProgressDialog HavingProc(
            this IOperationDrivenProgressDialog self, Delegate proc)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Proc = proc;
            return self;
        }
    }
}