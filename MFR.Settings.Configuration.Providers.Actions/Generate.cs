using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;
using MFR.Settings.Configuration.Actions.Constants;
using MFR.Settings.Configuration.Actions.Factories;
using MFR.Settings.Configuration.Interfaces;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Providers.Actions
{
    public static class Generate
    {
        /// <summary>
        /// Given the specified <paramref name="pathname" /> of a <c>config.json</c> file,
        /// manufactures and returns a reference to an instance of an object that
        /// implements the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface for that <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a <c>config.json</c> file.
        /// </param>
        /// <returns>
        /// If successful, a reference to an instance of an object that implements
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface for
        /// that <paramref name="pathname" />; otherwise, <see langword="null" />.
        /// </returns>
        /// <remarks>
        /// This method checks whether the file having the specified
        /// <paramref name="pathname" /> exists on the file system or not, and has the filename
        /// <c>config.json</c> before creating a new file system entry object.
        /// </remarks>
        public static IFileSystemEntry FileSystemEntryForConfiguration(
            string pathname
        )
        {
            IFileSystemEntry result = default;

            try
            {
                if (!Determine.IsConfigPathValid(pathname))
                    return result;

                result = MakeNewFileSystemEntry.ForPath(pathname);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        /// <summary>
        /// Generates a new <c>Action</c> object that loads the config data from a
        /// file on the file system.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface that
        /// contains the fully-qualified pathname of a file on the file system that contains
        /// application config data.
        /// </param>
        /// <returns>
        /// A new <c>Action</c> object that loads the config data from a
        /// file on the file system.
        /// </returns>
        public static
            IAction<IFileSystemEntry, IProjectFileRenamerConfig>
            LoadConfigFromFileAction(IFileSystemEntry entry)
        {
            IAction<IFileSystemEntry, IProjectFileRenamerConfig> result =
                default;

            try
            {
                /*
                 * OKAY, only use the pathname provided to this method as
                 * input for the load config from file action if it
                 * contains the fully-qualified pathname of a file that actually
                 * exists on the file system and has a filename of config.json.
                 */

                if (entry == null) return result;
                if (!Determine.IsConfigPathValid(entry.Path))
                    return result;

                var action = GetConfigAction
                    .For<IFileSystemEntry, IProjectFileRenamerConfig>(
                        ConfigActionType.LoadConfigFromFile
                    );

                /*
                 * OKAY, we have frequently encountered exceptions or
                 * null values at this step.  Check the output of the call
                 * above before we proceed further.
                 */

                if (action == null)
                    return result; // failed to get action object

                // initialize the action object by setting its input, before
                // returning the reference to it to the caller of this method.
                result = action.WithInput(entry);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}