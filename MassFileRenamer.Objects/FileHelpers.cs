using System;
using System.IO;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Static methods to assist in processing files.
    /// </summary>
    public static class FileHelpers
    {
        /// <summary>
        /// Reads all the data in from the file whose pathname is given by the '
        /// <paramref name="path" /> parameter, caches it, and then returns it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname of the
        /// file to be read.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file should be
        /// included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method should return
        /// <see langword="true" /> to specify that a given file-system entry is to be
        /// included in the output collection -- barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path filtering
        /// is done.
        /// </param>
        /// <returns>
        /// String containing the file's contents; otherwise, the empty string
        /// if the file does not meet the criteria specified in the path filter.
        /// </returns>
        public static string GetContent(string path,
            Predicate<string> pathFilter = null)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(DebugLevel.Debug, "In FileHelpers.GetContent");

            // Dump the parameter path to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, $"FileHelpers.GetContent: path = '{path}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileHelpers.GetContent: Attempting to read the data in the file having path '{path}'..."
            );

            var result = string.Empty;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the value of the 'path' parameter is blank..."
            );

            if (string.IsNullOrWhiteSpace(path))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "FileHelpers.GetContent: Blank value passed for the 'path' parameter. This parameter is required."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileHelpers.GetContent: Result = '{result}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "FileHelpers.GetContent: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The parameter 'path' is not blank.  Continuing..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the file with path '{path}' exists on the disk..."
            );

            if (!File.Exists(path))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"*** ERROR *** The system could not locate the file having the path '{path}' on the disk.  This file is required to exist in order for us to proceed."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileHelpers.GetContent: Result = '{result}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "FileHelpers.GetContent: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** The file with path '{path}' was found on the disk.  Proceeding..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "FileHelpers.GetContent: Checking whether the path-filtering criteria are met..."
            );

            if (!(pathFilter?.Invoke(path) ?? true))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR *** The path-filtering criteria were not met."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The path-filtering criteria were met."
            );

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Attempting to read the contents of the file having path '{path}'..."
                );

                result = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Setting the return value of this method to the empty string..."
                );

                result = string.Empty;
            }

            if (!string.IsNullOrWhiteSpace(result))
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** SUCCESS *** The contents of the file having path '{path}' have been read."
                );

            return result;
        }
    }
}