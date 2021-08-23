using MFR.GUI.Dialogs.Interfaces;

namespace MFR.GUI.Dialogs.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.GUI.Dialogs.Interfaces.INewProfileNameDialog" /> interface,
    /// and returns references to them.
    /// </summary>
    public static class MakeNewNewProfileNameDialog
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Interfaces.INewProfileNameDialog" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Interfaces.INewProfileNameDialog" /> interface.
        /// </returns>
        public static INewProfileNameDialog FromScratch()
            => new NewProfileNameDialog();
    }
}