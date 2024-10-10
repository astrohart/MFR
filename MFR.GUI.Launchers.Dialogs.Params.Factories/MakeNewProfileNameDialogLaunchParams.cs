using MFR.GUI.Dialogs.Constants;
using PostSharp.Patterns.Diagnostics;
using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using System;

namespace MFR.GUI.Launchers.Dialogs.Params.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams" />
    /// interface, and returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewProfileNameDialogLaunchParams
    {
        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams.OperationType" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams" />
        /// interface.
        /// </param>
        /// <param name="type">
        /// (Required.) A
        /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> value
        /// that specifies how the dialog is being used (i.e., for a Save Profile As or a
        /// New Profile action).
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProfileNameDialogLaunchParams
            ForProfileCreateOperationType(
                this IProfileNameDialogLaunchParams self,
                ProfileCreateOperationType type)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.OperationType = type;
            return self;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams" />
        /// interface.
        /// </returns>
        public static IProfileNameDialogLaunchParams FromScratch()
            => new ProfileNameDialogLaunchParams();
    }
}