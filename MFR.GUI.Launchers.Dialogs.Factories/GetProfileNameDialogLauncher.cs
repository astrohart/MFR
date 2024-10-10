using MFR.GUI.Launchers.Dialogs.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Launchers.Dialogs.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.GUI.Launchers.Dialogs.Interfaces.IProfileNameDialogLauncher" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetProfileNameDialogLauncher
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.GUI.Launchers.Dialogs.Interfaces.IProfileNameDialogLauncher" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.GUI.Launchers.Dialogs.Interfaces.IProfileNameDialogLauncher" />
        /// interface.
        /// </returns>
        public static IProfileNameDialogLauncher SoleInstance()
            => ProfileNameDialogLauncher.Instance;
    }
}