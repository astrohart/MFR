using MFR.Messages.Actions.Interfaces;
using MFR.Settings.Profiles.Interfaces;

namespace MFR.Settings.Profiles.Actions.Factories
{
    /// <summary>
    /// Exposes static methods to gain access to a reference to the sole instance of
    /// <see cref="T:MFR.Settings.Profiles.Actions.CreateNewNamedProfileAction" />.
    /// </summary>
    public static class GetCreateNewNamedProfileAction
    {
        /// <summary>
        /// Gets a reference to the sole instance of
        /// <see cref="T:MFR.Settings.Profiles.Actions.CreateNewNamedProfileAction" />.
        /// </summary>
        /// <returns>
        /// A reference to the sole instance of
        /// <see cref="T:MFR.Settings.Profiles.Actions.CreateNewNamedProfileAction" />.
        /// </returns>
        public static IAction<string, IProfile> SoleInstance()
            => CreateNewNamedProfileAction.Instance;
    }
}