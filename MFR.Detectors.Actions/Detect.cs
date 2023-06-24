using MFR.Detectors.Constants;
using MFR.FileSystem.Factories.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xyLOGIX.Core.Debug;

namespace MFR.Detectors.Actions
{
    /// <summary>
    /// Exposes static methods to do detection on files.
    /// </summary>
    public static class Detect
    {
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
