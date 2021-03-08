namespace MassFileRenamer.GUI
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of any object that
    /// has functionality common to all presenters.
    /// </summary>
    public interface IPresenter
    {
        /// <summary>
        /// Dismisses the progress dialog.
        /// </summary>
        void CloseProgressDialog();

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        void ShowProgressDialog();

        /// <summary>
        /// Updates data. Moves data from the screen to the model (
        /// <paramref
        ///     name="bSavingAndValidating" />
        /// equals <c>true</c>) or from the model
        /// to the screen ( <paramref name="bSavingAndValidating" /> equals <c>false</c>).
        /// </summary>
        /// <param name="bSavingAndValidating">
        /// Set to <c>true</c> to move data from the screen to the model;
        /// <c>false</c> to move data from the model to the screen.
        /// </param>
        /// <remarks>
        /// Note that whatever operations this method performs may potentially
        /// throw exceptions.
        /// </remarks>
        void UpdateData(bool bSavingAndValidating = true);
    }
}