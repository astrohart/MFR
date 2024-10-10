using MFR.GUI.Dialogs.Constants;
using PostSharp.Patterns.Diagnostics;
using MFR.GUI.Dialogs.Interfaces;
using System;

namespace MFR.GUI.Dialogs.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IProfileNameDialog" /> interface, and
    /// returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewProfileNameDialog
    {
        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Dialogs.Interfaces.IProfileNameDialog.OperationType" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.IProfileNameDialog" />
        /// interface.
        /// </param>
        /// <param name="type">
        /// (Required.) A
        /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> value
        /// that specifies the type of profile-creation operation that is being performed
        /// (New, Save As).
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProfileNameDialog ForProfileCreateOperationType(
            this IProfileNameDialog self, ProfileCreateOperationType type)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.OperationType = type;
            return self;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IProfileNameDialog" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IProfileNameDialog" /> interface.
        /// </returns>
        public static IProfileNameDialog FromScratch()
            => new ProfileNameDialog();
    }
}