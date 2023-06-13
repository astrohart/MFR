using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;
using MFR.Settings.Profiles.Actions.Constants;
using MFR.Settings.Profiles.Actions.Factories;
using MFR.Settings.Profiles.Collections.Interfaces;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers.Actions
{
    /// <summary>
    /// Exposes static methods to generate references to data.
    /// </summary>
    public static class Generate
    {
        /// <summary>
        /// Generates a reference to an instance of an object that implements the
        /// <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface, given
        /// the specified <paramref name="pathname" /> of a <c>profiles.json</c> file.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a <c>profiles.json</c> file.
        /// </param>
        /// <returns>
        /// If the <paramref name="pathname" /> refers to a <c>profiles.json</c>
        /// file that exists on the disk, then a new reference to an instance of an object
        /// that implements the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface is returned; <see langword="null" /> is returned otherwise.
        /// </returns>
        public static IFileSystemEntry FileSystemEntryForProfileCollection(
            string pathname
        )
        {
            IFileSystemEntry result = default;

            try
            {
                if (!Determine.WhetherProfileListPathIsValid(pathname))
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
        /// Generates a reference to an instance of an <c>Action</c> object that is
        /// responsible for executing the operation of loading the user's
        /// configuration-setting profiles from the disk.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface that refers to the <c>profiles.json</c> file from which profiles are
        /// to be loaded.
        /// </param>
        /// <returns>
        /// If successful, a reference to an instance of an <c>Action</c> object
        /// that is responsible for executing the operation of loading the user's
        /// configuration-setting profiles from the disk; <see langword="null" />
        /// otherwise.
        /// </returns>
        public static IAction<IFileSystemEntry, IProfileCollection>
            LoadProfileCollectionFromFileAction(IFileSystemEntry entry)
        {
            IAction<IFileSystemEntry, IProfileCollection> result = default;

            try
            {
                if (entry == null) return result;
                if (!Determine.WhetherProfileListPathIsValid(entry.Path))
                    return result;

                result = GetProfileCollectionAction
                         .For<IFileSystemEntry, IProfileCollection>(
                             ProfileCollectionActionType
                                 .LoadProfileCollectionFromFile
                         )
                         .WithInput(entry);
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