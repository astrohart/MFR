using MFR.Settings.Profiles.Collections.Interfaces;

namespace MFR.Settings.Profiles.Collections.Factories
{
    /// <summary>
    /// Gets access to the empty <c>ProfileCollection</c>.
    /// </summary>
    public static class GetEmptyProfileCollection
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface that represents the empty collection.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface that represents the empty collection.
        /// </returns>
        public static IProfileCollection SoleInstance()
            => ProfileCollection.Empty;
    }
}