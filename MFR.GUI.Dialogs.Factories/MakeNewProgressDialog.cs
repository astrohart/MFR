using MFR.GUI.Dialogs.Interfaces;

namespace MFR.GUI.Dialogs.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MFR.GUI.Dialogs.Interfaces.IProgressDialog" />
    /// interface, and
    /// returns references to them.
    /// </summary>
    public static class MakeNewProgressDialog
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.IProgressDialog" />
        /// interface and
        /// returns a reference to it.
        /// </summary>
        public static IProgressDialog FromScratch()
            => new ProgressDialog();
    }
}