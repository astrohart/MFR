namespace MFR.GUI.Launchers.Dialogs.Results.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a Profile Name dialog
    /// box's results object.
    /// </summary>
    public interface IProfileNameDialogLaunchResults : IDialogBoxResults
    {
        /// <summary>
        /// Gets or sets a string that contains the name that the user wants to assign to
        /// the Profile.
        /// </summary>
        string ProfileName
        {
            get;
        }
    }
}