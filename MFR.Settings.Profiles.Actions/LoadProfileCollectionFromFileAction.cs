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
            => ProfileCollectionAction.LoadProfileCollectionFromFile;

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
            // entering, into the log
            DebugUtils.WriteLine(DebugLevel.Debug, "In LoadProfileCollectionFromFileAction.CommonExecute");

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the _input field has a null reference for a value..."
            );

            IProfileCollection result = null;

            // Check to see if the required field, _input, is null. If it is,
            // send an error to the log file and quit.
            if (Input == null)
            {
                // the field _input is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: The _input field has a null reference.  This field is required."
                );

                // log the result
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "LoadConfigurationFilePathFromRegistryAction.Execute: Result = {0}", result
                );

                // stop.
                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The _input field has a valid object reference for its value."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** The file with path '{Input.Path}' was found on the disk.  Proceeding..."
            );

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

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"LoadConfigurationFromFileAction.CommonExecute: Result = {result}"
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "LoadConfigurationFromFileAction.CommonExecute: Done."
            );

            /*
             * Provide the fully-qualified pathname of the new file
             * (or blank if a file system exception was thrown) to the caller.
             */

            return result;
        }
    }
}