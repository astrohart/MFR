using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Helpers;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions;
using MFR.Messages.Constants;
using MFR.Settings.Profiles.Actions.Constants;
using MFR.Settings.Profiles.Collections.Interfaces;
using MFR.Settings.Profiles.Serializers;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Actions
{
    /// <summary>
    /// Accesses a key and value in the system Registry to load the pathname of
    /// the master configuration file.
    /// </summary>
    public class
        LoadProfileCollectionFromFileAction : ActionBase<IFileSystemEntry,
            IProfileCollection>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static LoadProfileCollectionFromFileAction()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected LoadProfileCollectionFromFileAction()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of <see
        /// cref="T:MFR.Settings.Profiles.Actions.LoadProfileCollectionFromFileAction"/> .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static LoadProfileCollectionFromFileAction Instance
        {
            get;
        } = new LoadProfileCollectionFromFileAction();

        /// <summary>
        /// Gets the <see cref="T:MFR.MessageType"/> that is being used
        /// to identify which message this is.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
            => ProfileCollectionActionType.LoadProfileCollectionFromFile;

        /// <summary>
        /// Executes this message.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the <see
        /// cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection"/>
        /// interface that is initialized with the values read in from the
        /// specified file.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the <see cref="F:MFR.ActionBase._input"/> field is
        /// blank or <see langword="null"/>.
        /// </exception>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// </remarks>
        protected override IProfileCollection CommonExecute()
        {
            // write the name of the current class and method we are now
            IProfileCollection result = null;

            // Check to see if the required field, _input, is null. If it is,
            if (Input == null)
            {
                // the field _input is required.
                // stop.
                return result;
            }
            try
            {
                Input.Path = FileHelpers.CreateOrOpenTextFile(
                    Path.GetDirectoryName(Input.Path),
                    Path.GetFileName(Input.Path)
                );

                result = ProfileCollectionSerializer.Load(Input.Path);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
            /*
             * Provide the fully-qualified pathname of the new file
             * (or blank if a file system exception was thrown) to the caller.
             */

            return result;
        }
    }
}
