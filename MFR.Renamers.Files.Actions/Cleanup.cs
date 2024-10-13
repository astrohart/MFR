using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Renamers.Files.Actions
{
    /// <summary>
    /// Exposes static methods to perform cleanup after other operations have
    /// completed.
    /// </summary>
    public static class Cleanup
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.Renamers.Files.Actions.Cleanup" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Cleanup() { }

        /// <summary>
        /// Attempts to remove an empty file folder (usually the result of a rename)
        /// referred to by the specified file system <paramref name="entry" />.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface and which
        /// refers to a (presumably) empty file folder.
        /// </param>
        /// <remarks>
        /// If a <see langword="null" /> reference is passed as the argument of
        /// the <paramref name="entry" /> parameter, then this method returns
        /// <see langword="false" />, but otherwise, does nothing.
        /// <para />
        /// This method also does nothing if the folder that is referred to by the
        /// specified file system <paramref name="entry" /> is not empty.
        /// <para />
        /// Finally, nothing is done by this method if the specified file system
        /// <paramref name="entry" /> either: (a) does not refer to a folder that exists on
        /// the file system; or (b) refers to a file and not a folder.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the operation succeeded;
        /// <see langword="false" /> otherwise, or if the operation isn't applicable to the
        /// specified file system <paramref name="entry" />.
        /// </returns>
        public static bool EmptyFileFolder(IFileSystemEntry entry)
        {
            var result = false;

            try
            {
                /*
                 * We're making an assumption here, that 'entry' refers to a folder, and
                 * not a file.  We tried checking but for some reason, the methods that
                 * determine whether a folder exists, cannot ascertain that here, or
                 * read its file-system attributes.  So, we're just going to shoot from the
                 * hip with a RD /S /Q system call and cross our fingers.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Cleanup.EmptyFileFolder: Checking whether the 'entry' method parameter has a null reference for a value..."
                );

                // Check to see if the required parameter, entry, is null. If it is, send an 
                // error to the log file and quit, returning the default return value of this
                // method.
                if (entry == null)
                {
                    // The parameter, 'entry', is required and is not supposed to have a NULL value.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "Cleanup.EmptyFileFolder: *** ERROR *** A null reference was passed for the 'entry' method parameter.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** Cleanup.EmptyFileFolder: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Cleanup.EmptyFileFolder: *** SUCCESS *** We have been passed a valid object reference for the 'entry' method parameter.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Checking whether the 'entry.Path' property has a null reference for a value, or is blank..."
                );

                // Check to see if the required property, entry.Path, is null or blank. If it is, send an 
                // error to the log file and quit, returning the default value of the result
                // variable.
                if (string.IsNullOrWhiteSpace(entry.Path))
                {
                    // the property entry.Path is required.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR: The 'entry.Path' property has a null reference or is blank.  Stopping."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR: This property is required to be set to a non-blank string before we can proceed."
                    );

                    // log the result
                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"Cleanup.EmptyFileFolder: Result = {result}"
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug, "Cleanup.EmptyFileFolder: Done."
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The 'entry.Path' property is set to a non-blank string."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Cleanup.EmptyFileFolder: Attempting to stop process(es) that might interfere with the folder-remove operation..."
                );

                Stop.Process("nuget.exe");
                Stop.Process("msbuild.exe");
                Stop.Process("TGitCache.exe");
                Stop.Process("dllhost.exe");
                Stop.Process("dllhost.exe");
                Stop.Process("dllhost.exe");

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Cleanup.EmptyFileFolder: *** SUCCESS *** The process(es) have been stopped.  Proceedng to remove the folder..."
                );

                Remove.Directory(entry.Path);

                /*
                 * return TRUE for success and FALSE for failure.  Base the success
                 * of this method on whether the folder in question still exists.
                 * If it does, then we failed.
                 */

                result = !Directory.Exists(entry.Path, PathFormat.FullPath);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                result ? DebugLevel.Info : DebugLevel.Error,
                result
                    ? $"*** SUCCESS *** Removed the file folder, '{entry.Path}', from the file system.  Proceeding..."
                    : $"*** ERROR *** FAILED to remove the file folder, '{entry.Path}', from the file system.  Stopping..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug, $"Cleanup.EmptyFileFolder: Result = {result}"
            );

            return result;
        }
    }
}