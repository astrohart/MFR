using MFR.Settings.Profiles.Interfaces;

namespace MFR.Settings.Profiles.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface, and
    /// returns references to them.
    /// </summary>
    public static class MakeNewProfile
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface.
        /// </returns>
        public static IProfile FromScratch()
            => new Profile();
    }
}