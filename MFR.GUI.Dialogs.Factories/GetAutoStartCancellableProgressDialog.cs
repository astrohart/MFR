using MFR.GUI.Dialogs.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Dialogs.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.GUI.Dialogs.IAutoStartCancellableProgressDialog" /> interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetAutoStartCancellableProgressDialog
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.IAutoStartCancellableProgressDialog" /> interface,
        /// and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.IAutoStartCancellableProgressDialog" /> interface.
        /// </returns>
        public static IAutoStartCancellableProgressDialog SoleInstance()
            => AutoStartCancellableProgressDialog.Instance;
    }
}