using MFR.GUI.Constants;

namespace MFR.Paths.Profiles.Provider.Constants
{
    /// <summary>
    /// Values used to read the profile list file path from the system Registry.
    /// </summary>
    /// <remarks>
    /// The profile list file contains user settings that control how the
    /// application runs.
    /// <para />
    /// The profile list file is in JSON format.
    /// <para />
    /// Configuration files are intended to be stored on a per user basis.
    /// </remarks>
    public static class ProfilePathRegistry
    {
        /// <summary>
        /// Gets the name of the Registry value that holds the path to the
        /// profile list file.
        /// </summary>
        public const string ValueName = "ProfileCollectionFile";
    }
}