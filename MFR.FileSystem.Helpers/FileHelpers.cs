using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Exceptions;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Helpers.Properties;
using MFR.FileSystem.Creators;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Helpers
{
    /// <summary>
    /// Static methods to assist in processing files.
    /// </summary>
    public static class FileHelpers
    {
        /// <summary>
        /// Dumps the specified <paramref name="text" /> to a file in the current user's
        /// temporary files directory, and then returns the path to the file thusly
        /// created.
        /// </summary>
        /// <param name="text">
        /// (Required.) String containing the text to be written to the file.
        /// </param>
        /// <returns>
        /// String containing the fully-qualified pathname to the file where the
        /// specified <paramref name="text" /> was written.  If an exception occurred, such
        /// as File I/O error, then the return value of this method is the empty string.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="text" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        public static string DumpTextToTempFile(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(text)
                );

            string result;

            try
            {
                result = Path.GetTempFileName();
                File.WriteAllText(result, text);

                /*
                 * Run a check to ensure that the file actually got written
                 * and that the data provided was written to it.
                 *
                 * This check uses the trigraph operator to be the identity map
                 * if the new file is valid (i.e, exists, has nonzero length, and
                 * its length matches that of the text submitted for writing) or
                 * replaces the result with the empty string if the file written
                 * fails to meet the conditions above (the empty string is a signal
                 * to the caller that the write operation failed).
                 */

                var resultantFile = MakeNewFileInfo.ForPath(result);
                result = resultantFile.Exists && resultantFile.Length > 0 && resultantFile.Length == text.Length
                    ? result
                    : string.Empty;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }

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
        /// included in the output collection -- barring other inclusion/exclusion
        /// criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path filtering
        /// is done.
        /// </param>
        /// <returns>
        /// String containing the file's contents; otherwise, the empty string
        /// if the file does not meet the criteria specified in the path filter.
        /// </returns>
        public static string GetTextContent(string path,
            Predicate<string> pathFilter = null)
        {
            var result = string.Empty;

            if (string.IsNullOrWhiteSpace(path)) return result;

            if (!File.Exists(path)) return result;

            if (!(pathFilter?.Invoke(path) ?? true)) return result;

            try
            {
                result = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Fills a file with random garbage data of varying size.
        /// </summary>
        /// <param name="path">
        /// (Required.) Fully-qualified pathname to the file to be
        /// filled with the data.
        /// <para />
        /// This method throws <see cref="T:System.InvalidOperationException" /> if the
        /// pathname is not an absolute pathname to a file on the disk.
        /// </param>
        public static void FillTextFileWithJunk(string path)
        {
            if (File.Exists(path))
                File.Delete(path);

            var junk = string.Empty;

            var rng = new Random(
                Guid.NewGuid()
                    .GetHashCode()
            );
            for (var i = 0; i < rng.Next(0, 100); i++)
                junk += Guid.NewGuid()
                            .ToString("N");

            MakeSureContainingFolderExists(path);

            File.WriteAllText(path, junk);
        }

        /// <summary>
        /// If the <paramref name="pathname" /> provided contains a fully-qualified
        /// path to a file, then this method makes sure that the folder named in the
        /// path exists.
        /// <para />
        /// If it does not, then a new folder with the specified path is created in
        /// order to hold the file.
        /// </summary>
        /// <param name="pathname">(Required.) Fully-qualified pathname of a file.</param>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the string
        /// specified in the <paramref name="pathname" /> parameter does not refer to a
        /// folder.
        /// </exception>
        public static void MakeSureContainingFolderExists(string pathname)
        {
            // write the name of the current class and method we are now entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "In FileHelpers.MakeSureContainingFolderExists"
            );

            // Dump the variable pathname to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileHelpers.MakeSureContainingFolderExists: pathname = '{pathname}'"
            );

            /* Write the config data to the file.  If the folder that the
                   file should be placed in, does not exist, then create the folder. */
            var containingFolderName = Path.GetDirectoryName(pathname);
            if (string.IsNullOrWhiteSpace(containingFolderName))
                throw new InvalidOperationException(
                    "The configuration file pathname has no folder."
                );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileHelpers.MakeSureContainingFolderExists: Checking whether the folder '{containingFolderName}' exists. If not, creating it..."
            );

            if (!Directory.Exists(containingFolderName))
                Create.Folder(containingFolderName);

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "FileHelpers.MakeSureContainingFolderExists: Checking whether the operation succeeded..."
            );

            Verify.FolderCreated(containingFolderName);

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "FileHelpers.MakeSureContainingFolderExists: Done."
            );
        }

        /// <summary>
        /// Creates a blank config.json file in the specified folder. This
        /// method also attempts to create the folder if it does not already exist.
        /// </summary>
        /// <param name="folderName">
        /// (Required.) Path to the folder in which to store the config.json file.
        /// </param>
        /// <param name="fileName">
        /// (Optional.) Filename to use for the config file. Config.json is the
        /// default. If this parameter is specified, it can't be a blank string
        /// and must be a valid filename.
        /// </param>
        /// <returns>
        /// String containing the fully-qualified pathname to the config.json
        /// file. Blank if a problem occurred (either invalid permissions or
        /// some such.
        /// </returns>
        /// <remarks>
        /// This method simply returns the fully-qualified path to the
        /// configuration file if it already exists.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the <paramref name="folderName" /> or
        /// <paramref
        ///     name="fileName" />
        /// parameters are blank.
        /// </exception>
        public static string CreateOrOpenTextFile(string folderName,
            string fileName = "config.json")
        {
            if (string.IsNullOrWhiteSpace(folderName))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(folderName)
                );
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(fileName)
                );

            var result = Path.Combine(folderName, fileName);

            if (!DebugFileAndFolderHelper.IsValidPath(result))
                throw new InvalidPathException(
                    "The path specified is not valid.", result
                );

            try
            {
                // if the file itself does not exist in the folder specified, then
                // create a new zero-byte file at the pathname specified and then close
                // it immediately.  Make sure the folder that is intended to contain
                // it, is created if the folder does not already exist.
                if (!File.Exists(result))
                {
                    MakeSureContainingFolderExists(result);

                    File.CreateText(result)
                        .Close();
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result =
                    string
                        .Empty; // set the result to blank if an exception is thrown.
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** Created or found a folder at the pathname '{folderName}'."
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SystemPreparer.CreateOrOpenTextFile: Result = '{result}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "SystemPreparer.CreateOrOpenTextFile: Done."
            );

            return result;
        }
    }
}