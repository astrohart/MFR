using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;

namespace MFR.GUI.Launchers.Dialogs.Params.Factories
{
    /// <summary>
    /// "Base" extension methods available to all the root types of all dialog-box
    /// launch param objects.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewDialogLaunchParams
    {
        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IDialogLaunchParams.Owner" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IDialogLaunchParams" />
        /// interface.
        /// </param>
        /// <param name="owner">
        /// (Optional; can be null.) Reference to an instance of an object that implements
        /// the <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object represents the parent window of the dialog.
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
        public static IDialogLaunchParams AndOwnerWindow(
            this IDialogLaunchParams self, IWin32Window owner)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Owner = owner;

            return self;
        }
    }
}