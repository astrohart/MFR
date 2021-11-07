using MFR.Registry.Writers.Interfaces;

namespace MFR.Registry.Writers.Factories
{
    /// <summary>
    /// Writes data to the system Registry.
    /// </summary>
    public static class Write
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the <see cref="T:MFR.Registry.Writers.IStringWriter" /> interface.
        /// </summary>
        /// <remarks>
        /// This object provides the service of writing string data to the system Registry.
        /// </remarks>
        public static IStringWriter String
            => StringWriter.Instance;
    }
}