using MFR.Settings.Configuration.Interfaces;

namespace MFR.Settings.Configuration.Providers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a ProjectFileRenamerConfiguration Provider object.
    /// </summary>
    public interface IProjectFileRenamerConfigurationProvider
    {
        /// <summary>
        /// Gets a reference to the instance of the object that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" /> interface and which
        /// exposes settings changed by the user in order to modify the
        /// application's behavior.
        /// </summary>
        IProjectFileRenamerConfiguration CurrentConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the pathname of the configuration file.
        /// </summary>
        string ConfigurationFilePath { get; set; }

        /// <summary>
        /// Gets the default filename for the config file.
        /// </summary>
        string DefaultConfigFileName { get; }

        /// <summary>
        /// Exports configuration data to a file other than the master
        /// configuration file.
        /// </summary>
        /// <param name="exportFileName">
        /// </param>
        /// <remarks>
        /// Before performing the export, the method first saves the latest
        /// settings out to the master configuration file.
        /// <para />
        /// It goes without saying that an alternative to calling this method in
        /// the first place is to simply call the
        /// <see
        ///     cref="M:MFR.Settings.ConfigurationProvider.Save" />
        /// method with a
        /// value for its pathname parameter.
        /// <para />
        /// However, doing this will not save the user's settings to the master
        /// file, which is important enough that we write a special method to
        /// handle this.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="exportFileName" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        void Export(string exportFileName);

        /// <summary>
        /// Imports configuration data from a file whose path is
        /// <paramref name="sourceFilePath" />.
        /// </summary>
        /// <param name="sourceFilePath">
        /// (Required.) String containing the fully-qualified pathname of the
        /// file from which to import the configuration data.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="sourceFilePath" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file, the path to which is specified by the
        /// <paramref
        ///     name="sourceFilePath" />
        /// parameter, cannot be located on the disk.
        /// </exception>
        /// <remarks>
        /// First, this method loads the data from the file specified into the
        /// application's configuration object.
        /// <para />
        /// Then, the method saves the new data out to the master configuration file.
        /// </remarks>
        void Import(string sourceFilePath);

        /// <summary>
        /// Loads the configuration from the disk.
        /// <para />
        /// The
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Providers.ConfigurationProvider.ProjectFileRenamerConfiguration" />
        /// property is then initialized to point to the data that has been loaded.
        /// </summary>
        /// <param name="pathname">
        /// (Optional.) String containing the pathname to a file to be loaded
        /// from disk, that contains the configuration data in JSON format.
        /// <para />
        /// If this value is blank, then the file whose path is stored in the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Providers.ConfigurationProvider.ConfigurationFilePath" />
        /// property is used instead.
        /// </param>
        /// <remarks>
        /// The value of the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Providers.ConfigurationProvider.ProjectFileRenamerConfiguration" />
        /// property is set to <see langword="null" /> if an error occurs during loading.
        /// </remarks>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file whose pathname is passed in the
        /// <paramref
        ///     name="pathname" />
        /// parameter cannot be located on the disk.
        /// </exception>
        void Load(string pathname = "");

        /// <summary>
        /// Saves configuration data to a file on the disk having path
        /// <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Optional.) String containing the path to where the data should be
        /// saved in JSON format.
        /// <para />
        /// If this parameter is blank, then the data is saved to the path that
        /// is stored in the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Providers.ConfigurationProvider.ConfigurationFilePath" />
        /// property.
        /// </param>
        /// <remarks>
        /// If the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Providers.ConfigurationProvider.ConfigurationFilePath" />
        /// property is blank, then this method does nothing.
        /// </remarks>
        void Save(string pathname = "");
    }
}
