using MFR.GUI.Constants;
using MFR.GUI.Constants.Properties;
using Resources = MFR.Settings.Profiles.Providers.Constants.Properties.Resources;

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
        public static string ValueName
            => Resources.RegistryValueName_ProfilePath;
    }
}