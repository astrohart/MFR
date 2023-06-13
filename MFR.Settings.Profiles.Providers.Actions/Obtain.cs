using MFR.Settings.Profiles.Collections.Factories;
using MFR.Settings.Profiles.Collections.Interfaces;

namespace MFR.Settings.Profiles.Providers.Actions
{
    /// <summary>
    /// Exposes static methods to load profiles from the disk.
    /// </summary>
    public static class Obtain
    {
        /// <summary>
        /// Attempts to obtain a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface that contains the user's configuration-setting profiles.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a <c>profiles.json</c> file on the disk from which profiles are to
        /// be loaded.
        /// </param>
        /// <returns>
        /// If successful, a reference to an instance of an object that implements
        /// the
        /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface that contains the user's configuration-setting profiles; otherwise,
        /// the empty collection is returned.
        /// </returns>
        public static IProfileCollection ProfileCollectionFromFile(
            string pathname
        )
        {
            var result = MakeNewProfileCollection.FromScratch();

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

            return result;
        }
    }
}