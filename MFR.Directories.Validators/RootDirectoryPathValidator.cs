using MFR.Directories.Validators.Actions;
using MFR.Directories.Validators.Constants;
using MFR.Directories.Validators.Events;
using MFR.Directories.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using xyLOGIX.Core.Debug;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.Directories.Validators
{
    /// <summary>
    /// Validates the root directory of a project-rename operation.
    /// </summary>
    public class RootDirectoryPathValidator : IRootDirectoryPathValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RootDirectoryPathValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RootDirectoryPathValidator() { }

        /// <summary>
        /// Gets a collection of strings, each of which contains an error message.
        /// </summary>
        public IList<string> Errors
        {
            get;
        } = new List<string>();

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Directories.Validators.RootDirectoryPathValidator" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IRootDirectoryPathValidator Instance
        {
            get;
        } = new RootDirectoryPathValidator();

        /// <summary>
        /// Gets a count of validation failures that occurred the last time the
        /// <see
        ///     cref="M:MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.IsValid" />
        /// method was called.
        /// </summary>
        public int ValidationFailures
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a collection of strings, each of which contains a warning message.
        /// </summary>
        public IList<string> VWarnings
        {
            get;
        } = new List<string>();

        /// <summary>
        /// Occurs when validation rules have determined that the value of the
        /// <see
        ///     cref="P:MFR.CommandLine.CommandLineInfo.RootDirectory" />
        /// property is invalid.
        /// </summary>
        public event RootDirectoryInvalidEventHandler RootDirectoryInvalid;

        /// <summary>
        /// Gets a value that determines whether the specified
        /// <paramref
        ///     name="rootDirectory" />
        /// is valid or not.
        /// <para />
        /// A "root directory" is defined to be the starting folder of a
        /// project-rename operation.
        /// <para />
        /// It must exist on the file system, and it must contain a Visual Studio
        /// Solution (*.sln) file.
        /// </summary>
        /// <param name="rootDirectory">
        /// (Optional.) String containing the pathname of a root directory to be validated.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the pathname specified by the
        /// <paramref
        ///     name="rootDirectory" />
        /// parameter refers to a valid directory;
        /// <see
        ///     langword="false" />
        /// otherwise.
        /// </returns>
        /// <remarks>
        /// In the event that validation fails, this method raises the
        /// <see
        ///     cref="E:MFR.CommandLine.Validators.Interfaces.IRootDirectoryPathValidator.RootDirectoryInvalid" />
        /// event.
        /// </remarks>
        public bool Validate(string rootDirectory)
        {
            var result = false;

            ValidationFailures = 0;
            Errors.Clear();

            try
            {
                // Dump the parameter rootDirectory to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"RootDirectoryPathValidator.Validate: rootDirectory = '{rootDirectory}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "RootDirectoryPathValidator.Validate: Checking whether we were passed the path to the user's My Documents folder..."
                );

                if (Directories.Constants.Directories.MyDocuments.Equals(
                        rootDirectory
                    ))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "RootDirectoryPathValidator.Validate: *** SUCCESS *** We were passed the user's My Documents folder for the starting folder.  This always valid.  Proceeding..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"RootDirectoryPathValidator.Validate: Result = {true}"
                    );

                    return true;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "RootDirectoryPathValidator.Validate: The user's My Documents folder is not the starting folder.  Proceeding..."
                );

                /*
                 * OKAY, a root directory is defined to be the path to
                 * the folder in which a project-rename operation starts.
                 * In order for the pathname to such a folder to be valid,
                 * it has to refer to the pathname of a folder that actually
                 * exists on the file system (minor detail), and one which
                 * contains at least one Visual Studio Solution (*.sln) file.
                 */

                var directoryToUse = rootDirectory;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"RootDirectoryPathValidator.Validate: Checking whether the folder '{directoryToUse}' exists..."
                );

                if (!Directory.Exists(directoryToUse))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** The folder '{directoryToUse}' could not be found.  Stopping..."
                    );

                    var args = new RootDirectoryInvalidEventArgs(
                        RootDirectoryInvalidReason.DoesntExist, directoryToUse
                    );

                    /*
                     * Instead of just straight up returning false (for invalid), we
                     * use the OnRootDirectoryInvalid call below to display a UI to
                     * give the user another chance to supply us with a valid starting
                     * folder.
                     *
                     * If the user cancelled the operation, then return false.
                     */

                    OnRootDirectoryInvalid(args);
                    if (args.Cancel) return false;

                    directoryToUse = args.RootDirectory;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"RootDirectoryPathValidator.Validate: Checking whether the folder '{directoryToUse}' exists again..."
                );

                if (!Directory.Exists(directoryToUse))
                {
                    /*
                     * If we get here, we already gave the user a chance to fix
                     * the problem, and the user did not...so just stop.
                     */

                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** We weren't able to locate the folder '{directoryToUse}' on the file system..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"RootDirectoryPathValidator.Validate: Result = {result}"
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"RootDirectoryPathValidator.Validate: *** SUCCESS *** The folder '{directoryToUse}' was found on the user's system.  Proceeding..."
                );

                /*
                 * Run a search to determine whether the specified directoryToUse
                 * has even one Visual Studio Solution (*.sln) file in its directory
                 * tree.
                 *
                 * If it is not the case that the specified folder contains even one
                 * Visual Studio Solution (*.sln) file, then tell the user that the
                 * specified directoryToUse is invalid.
                 */

                if (!Search.ForFilesHavingExtension(directoryToUse, "*.sln"))
                {
                    var args = new RootDirectoryInvalidEventArgs(
                        RootDirectoryInvalidReason.DoesntContainSolution,
                        rootDirectory
                    );
                    OnRootDirectoryInvalid(args);
                    if (args.Cancel) return false;
                }

                /*
                 * Return true (valid) if, and only if, the ValidationFailures
                 * property has a value equal to zero.
                 */

                result = ValidationFailures == 0;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                OnRootDirectoryInvalid(
                    new RootDirectoryInvalidEventArgs(
                        RootDirectoryInvalidReason.Unknown, rootDirectory, ex
                    )
                );

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"RootDirectoryPathValidator.Validate: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.CommandLine.Validators.RootDirectoryPathValidator.RootDirectoryInvalid" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs" />
        /// that contains the event data.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="e" />, is passed a <see langword="null" /> value.
        /// </exception>
        protected virtual void OnRootDirectoryInvalid(
            RootDirectoryInvalidEventArgs e
        )
        {
            if (e == null) throw new ArgumentNullException(nameof(e));

            Errors.Add(e.Message);
            ValidationFailures = Errors.Count;

            RootDirectoryInvalid?.Invoke(this, e);
        }
    }
}