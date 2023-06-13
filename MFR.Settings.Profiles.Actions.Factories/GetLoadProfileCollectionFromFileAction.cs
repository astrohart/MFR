using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;
using MFR.Settings.Profiles.Collections.Interfaces;

namespace MFR.Settings.Profiles.Actions.Factories
{
    /// <summary>
    /// Exposes static methods to obtain a reference to the one and only instance of
    /// <see cref="T:MFR.Settings.Profiles.Actions.LoadProfileCollectionFromFileAction" />
    /// .
    /// </summary>
    public static class GetLoadProfileCollectionFromFileAction
    {
        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Settings.Profiles.Actions.LoadProfileCollectionFromFileAction" />
        /// .
        /// </summary>
        /// <returns>
        /// A reference to the one and only instance of
        /// <see cref="T:MFR.Settings.Profiles.Actions.LoadProfileCollectionFromFileAction" />
        /// .
        /// </returns>
        public static IAction<IFileSystemEntry, IProfileCollection>
            SoleInstance()
            => LoadProfileCollectionFromFileAction.Instance;
    }
}