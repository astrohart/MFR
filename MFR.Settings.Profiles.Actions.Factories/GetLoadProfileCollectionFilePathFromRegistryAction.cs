using MFR.Expressions.Registry.Interfaces;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;

namespace MFR.Settings.Profiles.Actions.Factories
{
    /// <summary>
    /// Exposes static methods for obtaining a reference to the sole instance of
    /// <see
    ///     cref="T:MFR.Settings.Profiles.Actions.LoadProfileCollectionFilePathFromRegistryAction" />
    /// .
    /// </summary>
    public static class GetLoadProfileCollectionFilePathFromRegistryAction
    {
        /// <summary>
        /// Gets a  reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Actions.LoadProfileCollectionFilePathFromRegistryAction" />
        /// .
        /// </summary>
        /// <returns></returns>
        public static IAction<IRegQueryExpression<string>, IFileSystemEntry>
            SoleInstance()
            => LoadProfileCollectionFilePathFromRegistryAction.Instance;
    }
}