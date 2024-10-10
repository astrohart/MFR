namespace MFR.GUI.Dialogs.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a dialog box that shows
    /// the progress of a file-rename operation that has been launched from the command
    /// line with the <c>--autoStart</c> flag set.
    /// </summary>
    public interface
        IAutoStartCancellableProgressDialog : ICancellableProgressDialog { }
}