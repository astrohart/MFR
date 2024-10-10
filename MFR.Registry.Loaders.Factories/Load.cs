using MFR.Registry.Loaders.Interfaces;

namespace MFR.Registry.Loaders.Factories
{
    /// <summary>
    /// Loads data from the system Registry.
    /// </summary>
    public static class Load
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the <see cref="T:MFR.Registry.Loaders.IStringLoader" /> interface.
        /// </summary>
        public static IStringLoader String
            => StringLoader.Instance;
    }
}