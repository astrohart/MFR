using MFR.Registry.Loaders.Interfaces;

namespace MFR.Registry.Loaders.Factories
{
    public static class Load
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the <see cref="T:MFR.Registry.Loaders.IStringLoader" /> interface.
        /// </summary>
        public static IStringLoader String
            => StringLoader.Instance;
    }
}