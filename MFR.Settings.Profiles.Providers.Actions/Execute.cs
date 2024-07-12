using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;
using MFR.Settings.Profiles.Collections.Factories;
using MFR.Settings.Profiles.Collections.Interfaces;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers.Actions
{
    /// <summary>
    /// Exposes static methods to execute operations.
    /// </summary>
    public static class Execute
    {
        /// <summary>
        /// Attempts to execute the operation of loading a new
        /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// from a file on the file system.
        /// </summary>
        /// <param name="action">
        /// (Required.) Reference to an <c>Action</c> object that,
        /// when executed, loads the collection of the user's profiles from a file on the
        /// disk.
        /// </param>
        /// <returns>
        /// If successful, a reference to an instance of an object that implements
        /// the
        /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface containing the loaded profiles, or the empty collection if the
        /// operation could not be executed, or if no profiles are listed in the file.
        /// </returns>
        public static IProfileCollection
            OperationToLoadProfileCollectionFromFile(
                IAction<IFileSystemEntry, IProfileCollection> action
            )
        {
            var result = GetEmptyProfileCollection.SoleInstance();

            try
            {
                if (action == null) return result;

                result = action.Execute();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = GetEmptyProfileCollection.SoleInstance();
            }

            return result;
        }
    }
}