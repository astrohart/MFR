using MFR.Settings.Profiles.Collections.Interfaces;

namespace MFR.Settings.Profiles.Collections.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
    /// interface, and returns references to them.
    /// </summary>
    public static class MakeNewProfileCollection
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface.
        /// </returns>
        public static IProfileCollection FromScratch()
            => new ProfileCollection();
    }
}