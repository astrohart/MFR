using MFR.Detectors.Interfaces;

namespace MFR.Detectors.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Detectors.Interfaces.IFileFormatDetector" /> interface.
    /// </summary>
    public static class GetFileFormatDetector
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Detectors.Interfaces.IFileFormatDetector" /> interface, and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Detectors.Interfaces.IFileFormatDetector" /> interface.
        /// </returns>
        public static IFileFormatDetector SoleInstance()
            => FileFormatDetector.Instance;
    }
}