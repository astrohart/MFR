using MFR.Settings.Configuration.Interfaces;

namespace MFR.Settings.Configuration.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the <see cref="T:MFR.Settings.Configuration.Factories.csproj" /> interface, and returns references to them.
    /// </summary>
    public static class MakeNewConfiguration
    {
        /// <summary>
        /// Creates a new instance of an object that implements the <see cref="T:MFR.Settings.Configuration.Factories.csproj" /> interface and returns a reference to it.
        /// </summary>
        /// <returns>Reference to an instance of an object that implements the <see cref="T:MFR.Settings.Configuration.Factories.csproj" /> interface.</returns>
        public static IConfiguration FromScratch()
            => new Configuration();
    }
}
