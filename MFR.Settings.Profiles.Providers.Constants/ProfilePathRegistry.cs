using MFR.GUI.Constants;

namespace MFR.Settings.Profiles.Providers.Constants
{
    /// <summary>
    /// Values used to read the profile list file path from the system Registry.
    /// </summary>
    /// <remarks>
    /// The profile list file contains user settings that control how the
    /// application runs.
    /// <para />
    /// TRhe profile list file is in JSON format.
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

        /// <summary>
        /// Gets the path to the Registry subkey that stores information about
        /// the paths of files.
        /// </summary>
        public static readonly string KeyName =
            $@"HKEY_CURRENT_USER\SOFTWARE\{ProgramText.CompanyName}\{ProgramText.ProductNameWithoutCompany}\Paths";
    }
}