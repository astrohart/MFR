using MFR.GUI.Launchers.Dialogs.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Launchers.Dialogs.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.GUI.Launchers.Dialogs.Interfaces.HelpProfileExplainerDialogLauncher" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetHelpProfileExplainerDialogLauncher
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Interfaces.HelpProfileExplainerDialogLauncher" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Interfaces.HelpProfileExplainerDialogLauncher" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the object type requested is not supported.
        /// </exception>
        public static IHelpProfileExplainerDialogLauncher SoleInstance()
            => HelpProfileExplainerDialogLauncher.Instance;
    }
}