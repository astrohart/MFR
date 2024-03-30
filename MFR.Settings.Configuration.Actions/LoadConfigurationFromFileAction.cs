using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Helpers;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions;
using MFR.Messages.Actions.Interfaces;
using MFR.Messages.Constants;
using MFR.Settings.Configuration.Actions.Constants;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Serializers;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Actions
{
    /// <summary>
    /// Accesses a key and value in the system Registry to load the pathname of
    /// the master config file.
    /// </summary>
    public class LoadConfigurationFromFileAction : ActionBase<IFileSystemEntry,
        IProjectFileRenamerConfig>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static LoadConfigurationFromFileAction() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        private LoadConfigurationFromFileAction() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Actions.LoadConfigurationFromFileAction" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static
            IAction<IFileSystemEntry, IProjectFileRenamerConfig> Instance
        {
            get;
        } = new LoadConfigurationFromFileAction();

        /// <summary>
        /// Gets the <see cref="T:MFR.MessageType" /> that is being used
        /// to identify which message this.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
            => ConfigActionType.LoadConfigFromFile;

        /// <summary>
        /// Executes this message.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface that is initialized with the values read in from the
        /// specified file.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the <see cref="F:MFR.ActionBase._input" /> field is
        /// blank or <see langword="null" />.
        /// </exception>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// </remarks>
        protected override IProjectFileRenamerConfig CommonExecute()
        {
            IProjectFileRenamerConfig result = null;

            // Check to see if the required field, _input, is null. If it is, stop.
            if (Input == null)

                // the field _input is required.
                // stop.
                return result;
            try
            {
                Input.Path = CreateOrOpen.TextFile(Input.Path);

                result = ConfigurationSerializer.Load(Input.Path);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return result;
        }
    }
}