using MFR.Detectors.Constants;
using MFR.Detectors.Models.Interfaces;
using MFR.FileSystem.Factories.Actions;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Detectors.Models.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Detectors.Models.IFileFormatDetectionResult" /> interface, and
    /// returns references to them.
    /// </summary>
    public static class MakeNewFileFormatDetectionResult
    {
        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Detectors.Models.Interfaces.IFileFormatDetectionResult.Pat" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Detectors.Models.Interfaces.IFileFormatDetectionResult" />
        /// interface.
        /// </param>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the file whose format was examined.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IFileFormatDetectionResult ForFile(string pathname)
        {
            IFileFormatDetectionResult result = default;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname))
                    return result;
                if (Is.Folder(pathname)) return result;

                result = new FileFormatDetectionResult { Pathname = pathname };
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Detectors.Models.Interfaces.IFileFormatDetectionResult.FileFormat" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Detectors.Models.Interfaces.IFileFormatDetectionResult" />
        /// interface.
        /// </param>
        /// <param name="format">
        /// (Required.) One of the
        /// <see cref="T:MFR.Detectors.Constants.DetectedFileFormat" /> enumeration values
        /// that explains what format we think the file is (binary or text).
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        /// <remarks>
        /// It is acceptable to specify
        /// <see cref="F:MFR.Detectors.Constants.DetectedFileFormat.Unknown" /> as the
        /// argument of the <paramref name="format" /> parameter, in the event that we were
        /// unable to determine the format of the file.
        /// </remarks>
        public static IFileFormatDetectionResult HavingFileFormat(
            this IFileFormatDetectionResult self,
            DetectedFileFormat format
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.FileFormat = format;
            return self;
        }
    }
}