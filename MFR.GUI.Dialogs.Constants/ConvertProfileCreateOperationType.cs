using PostSharp.Patterns.Threading;
namespace MFR.GUI.Dialogs.Constants
{
    /// <summary>
    /// Method to convert
    /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" />
    /// values to, e.g., display strings etc.
    /// </summary>
    [ExplicitlySynchronized]
    public static class ConvertProfileCreateOperationType
    {
        /// <summary>
        /// Converts the
        /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> value
        /// passed in the <paramref name="type" /> parameter into a string to be displayed
        /// in a graphical user interface.
        /// </summary>
        /// <param name="type">
        /// (Required.) A
        /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> value
        /// that you want to convert.
        /// </param>
        /// <returns>
        /// String containing the display value that corresponds to the value
        /// passed in the <paramref name="type" /> parameter, or the
        /// <see cref="F:System.String.Empty" /> value if a non-supported value is passed
        /// for the <paramref name="type" /> parameter.
        /// </returns>
        public static string ToString(ProfileCreateOperationType type)
        {
            string result;

            switch (type)
            {
                case ProfileCreateOperationType.New:
                    result = "New Profile";
                    break;

                case ProfileCreateOperationType.SaveAs:
                    result = "Save Profile As";
                    break;

                default:
                    result = string.Empty;
                    break;
            }

            return result;
        }
    }
}