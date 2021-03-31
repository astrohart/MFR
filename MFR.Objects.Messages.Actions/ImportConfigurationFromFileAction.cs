namespace MFR.Objects.Messages.Actions
{
    /// <summary>
    /// Imports configuration from a file that is not the master configuration file.
    /// </summary>
    public class ImportConfigurationFromFileAction
    {
        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MFR.Objects.Messages.Actions.ImportConfigurationFromFileAction"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static ImportConfigurationFromFileAction Instance
        {
            get;
        } = new ImportConfigurationFromFileAction();

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static ImportConfigurationFromFileAction() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected ImportConfigurationFromFileAction() { }


    }
}
