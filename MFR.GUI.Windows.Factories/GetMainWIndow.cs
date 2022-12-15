using MFR.GUI.Windows.Interfaces;

namespace MFR.GUI.Windows.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.GUI.Windows.Interfaces.IMainWindow" /> interface.
    /// </summary>
    public static class GetMainWIndow
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.GUI.Windows.Interfaces.IMainWindow" /> interface, and returns
        /// a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.GUI.Windows.Interfaces.IMainWindow" /> interface.
        /// </returns>
        public static IMainWindow SoleInstance()
            => MainWindow.Instance;
    }
}