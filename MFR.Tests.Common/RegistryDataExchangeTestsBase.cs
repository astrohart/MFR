using Alphaleonis.Win32.Filesystem;
using System;

namespace MFR.Tests.Common
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all unit test
    /// fixtures that test methods and objects that perform data exchange to and from
    /// the system Registry.
    /// </summary>
    public class RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the name of the company that
        /// is associated with the application.
        /// </summary>
        protected const string COMPANY_NAME = "xyLOGIX, LLC";

        /// <summary>
        /// String containing the name of a config file.
        /// </summary>
        protected const string CONFIG_FILE_NAME = "config.json";

        /// <summary>
        /// Fully-qualified pathname to where we expect that the path to the
        /// config file has been written to.
        /// </summary>
        protected const string KEY_PATH =
            @"HKEY_CURRENT_USER\Software\xyLOGIX, LLC\Project File Renamer\Paths";

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the product name that is
        /// associated with the application.
        /// </summary>
        protected const string PRODUCT_NAME = "Project File Renamer";

        /// <summary>
        /// Name of the Registry value under which the path to the application's
        /// config file is to be stored.
        /// </summary>
        protected const string VALUE_NAME = "ConfigFile";

        /// <summary>
        /// String containing the fully-qualified pathname of a folder that stores the
        /// config file.
        /// </summary>
        protected static readonly string DEFAULT_CONFIG_FILE_DIR = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData
            ), $@"{COMPANY_NAME}\{PRODUCT_NAME}\Config"
        );

        /// <summary>
        /// String containing the fully-qualified pathname of the master
        /// config file.
        /// </summary>
        /// <remarks>
        /// The master config file is defined to be that file, containing
        /// a JSON representation of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Interfaces.IProfile" />
        /// interface, exists
        /// in the centralized location that is used by the application.
        /// <para />
        /// (Other such files may exist, but these are exports/imports.)
        /// </remarks>
        protected static readonly string DEFAULT_CONFIG_FILE_PATH =
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData
                ), $@"{COMPANY_NAME}\{PRODUCT_NAME}\Config\config.json"
            );
    }
}