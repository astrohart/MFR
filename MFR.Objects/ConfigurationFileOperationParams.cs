namespace MFR.Objects
{
    public class ConfigurationFileOperationParams
    {
        /// <summary>
        /// Gets or sets the <see cref="T:MFR.Objects.ConfigurationActionType"/> value that is being used to identify what action these parameters are being utilized for.
        /// </summary>
        public ConfigurationActionType ActionType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the <see cref="T:MFR.Objects.IFileSystemEntry" /> interface.
        /// </summary>
        /// <remarks>
        /// This object should point to the fully-qualified pathname of the
        /// configuration file.
        /// <para />
        /// Its user-state property should be filled with a reference to the
        /// configuration object.
        /// </remarks>
        public IFileSystemEntry ConfigFileSystemEntry
        {
            get;
            set;
        }
    }
}