namespace MassFileRenamer.GUI
{
    /// <summary>
    /// Gets references to presenter objects.
    /// </summary>
    public static class GetPresenter
    {
        /// <summary>
        /// Obtains a reference to a new instance of an object that implements
        /// the <see cref="T:MassFileRenamer.GUI.IMainWindowPresenter" /> interface.
        /// </summary>
        /// <returns>
        /// Reference to a new instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.GUI.IMainWindowPresenter" />
        /// interface.
        /// </returns>
        public static IMainWindowPresenter Having()
            => new MainWindowPresenter();
    }
}