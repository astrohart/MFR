using MFR.Detectors.Constants;
using MFR.FileSystem.Factories.Actions;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Detectors.Actions
{
    /// <summary>
    /// Exposes static methods to do detection on files.
    /// </summary>
    public static class Detect
    {
        /// <summary>
        /// Attempts to determine the format of the file having the specified
        /// <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the fully-qualified pathname of a file on the disk, whose format is to
        /// be detected.
        /// </param>
        /// <returns></returns>
        public static DetectedFileFormat FormatOfFile(string pathname)
        {
            var result = DetectedFileFormat.Unknown;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (!Does.FileExist(pathname)) return result;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = DetectedFileFormat.Unknown;
            }

            return result;
        }
    }
}