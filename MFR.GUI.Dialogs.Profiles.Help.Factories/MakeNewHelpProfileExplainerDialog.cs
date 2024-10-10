using MFR.GUI.Dialogs.Profiles.Help.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Dialogs.Profiles.Help.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IHelpProfileExplainerDialog" />
    /// interface, and returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewHelpProfileExplainerDialog
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IHelpProfileExplainerDialog" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IHelpProfileExplainerDialog" />
        /// interface.
        /// </returns>
        public static IHelpProfileExplainerDialog FromScratch()
            => new HelpProfileExplainerDialog();
    }
}