using MFR.Settings.Profiles.Collections.Factories;
using MFR.Settings.Profiles.Collections.Interfaces;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers.Actions
{
    /// <summary>
    /// Exposes static methods to load profiles from the file system.
    /// </summary>
    public static class Obtain
    {
        /// <summary>
        /// Attempts to obtain a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface that contains the user's config-setting profiles.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a <c>profiles.json</c> file on the file system from which profiles are to
        /// be loaded.
        /// </param>
        /// <returns>
        /// If successful, a reference to an instance of an object that implements
        /// the
        /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface that contains the user's config-setting profiles; otherwise,
        /// the empty collection is returned.
        /// </returns>
        public static IProfileCollection ProfileCollectionFromFile(
            string pathname
        )
        {
            var result = GetEmptyProfileCollection.SoleInstance();

            try
            {
                if (!Determine.WhetherProfileListPathIsValid(pathname))
                    return result;

                var profileCollectionFileSystemEntry =
                    Generate.FileSystemEntryForProfileCollection(pathname);
                if (profileCollectionFileSystemEntry == null) return result;

                var loadProfileCollectionFromFileAction =
                    Generate.LoadProfileCollectionFromFileAction(
                        profileCollectionFileSystemEntry
                    );
                if (loadProfileCollectionFromFileAction == null) return result;

                result =
                    Execute.OperationToLoadProfileCollectionFromFile(
                        loadProfileCollectionFromFileAction
                    );
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